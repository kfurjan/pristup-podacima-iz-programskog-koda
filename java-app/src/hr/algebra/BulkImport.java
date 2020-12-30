package hr.algebra;

import hr.algebra.csv.ReadCsv;
import hr.algebra.dao.SqlRepository;
import hr.algebra.factory.RepositoryFactory;
import hr.algebra.repository.Repository;
import java.io.IOException;
import java.lang.reflect.InvocationTargetException;
import java.util.logging.Level;
import java.util.logging.Logger;

/**
 *
 * @author efurkev
 */
public class BulkImport {

    private static final int BATCH_SIZE = 100;

    public static void main(String[] args) {
        importCsvData();
    }

    private static void importCsvData() {
        try {
            Repository repository = RepositoryFactory.getRepository(SqlRepository.class.getName());

            repository.importDriverData(ReadCsv.getDriverData(), BATCH_SIZE);
            repository.importCarData(ReadCsv.getCarData(), BATCH_SIZE);
            repository.importCityData(ReadCsv.getCityData(), BATCH_SIZE);
            repository.importFuelData(ReadCsv.getFuelData(), BATCH_SIZE);
            repository.importRouteData(ReadCsv.getRouteData(), BATCH_SIZE);
            repository.importTravelWarrantData(ReadCsv.getTravelWarrantData(), BATCH_SIZE);
        } catch (ClassNotFoundException | NoSuchMethodException | IllegalAccessException | InvocationTargetException | InstantiationException | IOException ex) {
            Logger.getLogger(BulkImport.class.getName()).log(Level.SEVERE, null, ex);
        }
    }

}
