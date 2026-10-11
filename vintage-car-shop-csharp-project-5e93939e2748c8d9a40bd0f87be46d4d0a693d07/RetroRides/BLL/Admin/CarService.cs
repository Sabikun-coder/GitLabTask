using RetroRides.Data;
using System.Data;
using System.Data.SqlClient;

namespace RetroRides.BLL.Admin
{
    public class CarService
    {
        private readonly DatabaseConnection _dbConnection;

        public CarService(DatabaseConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        // Load all car data from the database
        public DataTable LoadCarData()
        {
            string query = "SELECT * FROM Cars";
            DataTable dataTable = new DataTable();

            using (SqlConnection conn = _dbConnection.GetConnection())
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
                    adapter.Fill(dataTable);
                }
            }

            return dataTable;
        }

        // Add a new car to the database
        public bool AddCar(string modelName, int year, int topSpeed, int maxPower, decimal price, string description, string imagePath)
        {
            string query = @"INSERT INTO Cars (ModelName, YearOfManufacture, TopSpeed, MaxPower, Price, Description, ImagePath) 
                             VALUES (@ModelName, @Year, @TopSpeed, @MaxPower, @Price, @Description, @ImagePath)";

            SqlParameter[] parameters = {
                new SqlParameter("@ModelName", modelName),
                new SqlParameter("@Year", year),
                new SqlParameter("@TopSpeed", topSpeed),
                new SqlParameter("@MaxPower", maxPower),
                new SqlParameter("@Price", price),
                new SqlParameter("@Description", description),
                new SqlParameter("@ImagePath", imagePath)
            };

            return _dbConnection.ExecuteNonQuery(query, parameters) > 0;
        }

        // Update car details in the database
        public bool UpdateCar(int carId, string modelName, int year, int topSpeed, int maxPower, decimal price, string description, string imagePath)
        {
            string query = @"UPDATE Cars 
                             SET ModelName = @ModelName, YearOfManufacture = @Year, TopSpeed = @TopSpeed, MaxPower = @MaxPower, 
                                 Price = @Price, Description = @Description, ImagePath = @ImagePath 
                             WHERE CarID = @CarID";

            SqlParameter[] parameters = {
                new SqlParameter("@ModelName", modelName),
                new SqlParameter("@Year", year),
                new SqlParameter("@TopSpeed", topSpeed),
                new SqlParameter("@MaxPower", maxPower),
                new SqlParameter("@Price", price),
                new SqlParameter("@Description", description),
                new SqlParameter("@ImagePath", imagePath),
                new SqlParameter("@CarID", carId)
            };

            return _dbConnection.ExecuteNonQuery(query, parameters) > 0;
        }

        // Delete a car from the database by CarID
        public bool DeleteCar(int carId)
        {
            string query = "DELETE FROM Cars WHERE CarID = @CarID";
            SqlParameter[] parameters = {
                new SqlParameter("@CarID", carId)
            };

            return _dbConnection.ExecuteNonQuery(query, parameters) > 0;
        }
    }
}
