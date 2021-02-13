package hr.algebra;

import hr.algebra.model.Car;
import hr.algebra.model.Driver;
import hr.algebra.model.Fuel;
import hr.algebra.model.Route;
import hr.algebra.model.TravelWarrant;
import java.io.IOException;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.persistence.EntityManager;
import javax.persistence.EntityManagerFactory;
import javax.persistence.Persistence;
import javax.persistence.Query;
import org.apache.pdfbox.pdmodel.PDDocument;
import org.apache.pdfbox.pdmodel.PDPage;
import org.apache.pdfbox.pdmodel.PDPageContentStream;
import org.apache.pdfbox.pdmodel.font.PDType1Font;

/**
 *
 * @author efurkev
 */
public class Main {

    private static final String PDF_PATH = "travelWarrant_id_%d.pdf";

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        EntityManagerFactory emf = null;
        try {
            emf = Persistence.createEntityManagerFactory("java-hibernate-appPU");

            if (args[0].equals("all")) {
                System.out.println("Printing all travel warrants in database");
                printAllTravelWarrants(emf);
            } else {
                System.out.printf("Generating PDF document for TravelWarrant with ID: %s%n", args[0]);
                createPdf(emf, Integer.parseInt(args[0]));
            }

        } catch (Exception e) {
            e.printStackTrace();
        } finally {
            if (emf != null) {
                emf.close();
            }
        }
    }

    private static void printAllTravelWarrants(EntityManagerFactory emf) {
        EntityManager em = null;
        try {
            em = emf.createEntityManager();
            em.getTransaction().begin();

            Query query = em.createNativeQuery("select * from TravelWarrant", TravelWarrant.class);
            query.getResultList().forEach(System.out::println);

            em.getTransaction().commit();
        } catch (Exception e) {
            e.printStackTrace();
        } finally {
            if (em != null) {
                em.close();
            }
        }
    }

    private static void createPdf(EntityManagerFactory emf, int iDTravelWarrant) {

        try (PDDocument doc = new PDDocument()) {
            PDPage myPage = new PDPage();
            doc.addPage(myPage);
            try (PDPageContentStream content = new PDPageContentStream(doc, myPage)) {

                content.beginText();

                TravelWarrant travelWarrant = getTravelWarantFromDB(emf, iDTravelWarrant);

                content.setFont(PDType1Font.TIMES_BOLD, 16);
                content.setLeading(14.5f);
                content.newLineAtOffset(25, 700);

                // travelWarrant title
                String travelWarrantLine = String.format("Travel Warrant, %s", travelWarrant.getTravelWarrantType());
                content.showText(travelWarrantLine);
                content.newLine();
                String underScore = "_________________________________________";
                content.showText(underScore);
                content.newLine();

                // Car
                content.newLine();
                String carLine = "Car";
                content.showText(carLine);
                content.newLine();

                content.setFont(PDType1Font.TIMES_ROMAN, 12);
                content.newLine();
                Car car = travelWarrant.getCar();
                String carData = String.format("%s %s, %d., %dkm",
                        car.getBrand(),
                        car.getModel(),
                        car.getYear(),
                        car.getInitialMileage()
                );
                content.showText(carData);
                content.newLine();

                content.setFont(PDType1Font.TIMES_BOLD, 16);
                content.showText(underScore);
                content.newLine();

                // Driver
                content.newLine();
                String driverLine = "Driver";
                content.showText(driverLine);
                content.newLine();

                content.setFont(PDType1Font.TIMES_ROMAN, 12);
                content.newLine();
                Driver driver = travelWarrant.getDriver();
                String driverData = String.format("%s %s, +385%s, #%d",
                        driver.getFirstname(),
                        driver.getLastname(),
                        driver.getTelephone(),
                        driver.getDrivingLicenceNumber()
                );
                content.showText(driverData);
                content.newLine();
                
                content.setFont(PDType1Font.TIMES_BOLD, 16);
                content.showText(underScore);
                content.newLine();
                
                // Information
                content.newLine();
                String infoLine = "Information";
                content.showText(infoLine);
                content.newLine();

                content.setFont(PDType1Font.TIMES_ROMAN, 12);
                content.newLine();
                Route route = travelWarrant.getRoute();
                String routeData = String.format("%s -> %s, %dh, %dkm",
                        route.getCityA(),
                        route.getCityB(),
                        route.getTimeHours(),
                        route.getKilometers()
                );
                content.showText(routeData);
                content.newLine();
                
                Fuel fuel = travelWarrant.getFuel();
                String fuelData = String.format("%dL of fuel for %dkn in %s",
                        fuel.getAmount(),
                        fuel.getPrice(),
                        fuel.getCity()
                );
                content.showText(fuelData);
                content.newLine();

                content.endText();
            }

            doc.save(String.format(PDF_PATH, iDTravelWarrant));
        } catch (IOException ex) {
            Logger.getLogger(Main.class.getName()).log(Level.SEVERE, null, ex);
        }
    }

    private static TravelWarrant getTravelWarantFromDB(EntityManagerFactory emf, int id) {
        EntityManager em = null;
        TravelWarrant travelWarrant = null;

        try {
            em = emf.createEntityManager();
            em.getTransaction().begin();

            travelWarrant = em.find(TravelWarrant.class, id);

            em.getTransaction().commit();
        } catch (Exception e) {
            e.printStackTrace();
        } finally {
            if (em != null) {
                em.close();
            }
        }

        return travelWarrant;
    }
}
