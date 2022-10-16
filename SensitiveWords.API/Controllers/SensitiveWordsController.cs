using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;
using System.Net;

namespace SensitiveWords.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SensitiveWordsController : ControllerBase
    {

        [HttpGet("{queryString}")]

            public string GetQuery(string queryString)
            {
            List<string> sensitiveWords = new List<string>();
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();


                builder.ConnectionString = "Server = localhost; Database = SensitiveWords; Trusted_Connection = True; MultipleActiveResultSets = True;";
                builder.UserID = "achin";
                builder.Password = "Test1234";

                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {

                    connection.Open();

                    String sql = "SELECT word FROM dbo.SensitiveWords";

                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                sensitiveWords.Add(reader.GetString(0));
                            }

                        }

                    }
                }
            }

            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }

            string[] queryWords = queryString.Split(" ");

            for (int i = 0; i < queryWords.Length; i++)
            {
                if (sensitiveWords.Contains(queryWords[i].ToUpper()))
                {
                    queryWords[i] = string.Concat(Enumerable.Repeat("*", queryWords[i].Length));
                }
            }

            var response = string.Join(" ", queryWords);

            HttpContext.Response.Headers.Add("Access-Control-Allow-Origin", "*");

            return response;

        }
    }
}




