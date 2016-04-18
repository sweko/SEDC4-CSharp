using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;
using System.Configuration;

namespace Bookr
{
    class Program
    {
        static void Main(string[] args)
        {
            var connection = ConfigurationManager.ConnectionStrings["BookrDatabase"].ConnectionString;
            Console.WriteLine(connection);
            using (var sqlConnection = new SqlConnection(connection))
            {
                sqlConnection.Open();
                Console.WriteLine("Connected to database");

                while (true)
                {
                    Console.Write("Enter start of name: ");
                    var entry = Console.ReadLine();

                    var result = sqlConnection.Query<Author>(
                        "select ID, Name from Authors where Name like @authorPart + '%'", 
                        new { authorPart = entry } );

                    foreach (var author in result)
                    {
                        Console.WriteLine(author);
                    }
                }
            }
        }
    }
}
