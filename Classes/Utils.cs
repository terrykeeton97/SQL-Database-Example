using Bogus;
using System.Data.SqlClient;

namespace SQL_Application.Classes
{
    internal class Utils
    {
        internal static void InsertFakeData()
        {
            var faker = new Faker();
            int numberOfRecords = 1000;
            try
            {
                for (int i = 0; i < numberOfRecords; i++)
                {
                    int customerId = i + 1;
                    string customerName = faker.Name.FullName();
                    string customerDOB = faker.Date.Past().ToString("yyyy-MM-dd");
                    int customerPhoneNumber = faker.Random.Int(100000000, 999999999);
                    string customerAddress = faker.Address.FullAddress();

                    string query = $"INSERT INTO Customers ([ID], [Customer Name], [Customer DOB], [Customer Phone Number], [Customer Address]) " +
                                   $"VALUES ({customerId}, '{customerName}', '{customerDOB}', {customerPhoneNumber}, '{customerAddress}')";

                    using (SqlCommand command = new SqlCommand(query, SqlHandler.sqlConnection))
                    {
                        command.ExecuteNonQuery();
                    }
                }

            }
            catch { }
        }
    }
}
