//using Microsoft.Extensions.Configuration;
//using System.Data.SqlClient;

//IConfigurationRoot config = new ConfigurationBuilder()
//    .AddJsonFile("appsettings.json")
//    .Build();

//string? connectionStr = config.GetConnectionString("ConnectionString");
//Console.WriteLine(connectionStr);


//using (var connection = new SqlConnection(connectionStr))
//{
//    connection.Open();
//    //string query = "SELECT * FROM city";
//    //using (var command = new SqlCommand(query, connection))
//    //{
//    //    using (SqlDataReader reader = command.ExecuteReader())
//    //    {
//    //        while (reader.Read())
//    //        {
//    //            int id = reader.GetInt32(0);
//    //            string name = reader.GetString(1);
//    //            Console.WriteLine($"ID: {id} Name {name}");
//    //        }
//    //    }
//    //}
//}





//using Microsoft.Extensions.Configuration;
//using System.Data.SqlClient;


//IConfigurationRoot config = new ConfigurationBuilder()
//    .AddJsonFile("appsettings.json")
//    .Build();

//string? connectionStr = config.GetConnectionString("ConnectionString");

//using (var connection = new SqlConnection(connectionStr))
//{
//    connection.Open();
//    #region pre
//string query = "INSERT INTO city (ID,Name, CountryCode, District, Population) VALUES (@Val1,@Val2,@Val3,@Val4,@Val5)";
//using (var command = new SqlCommand(query, connection))
//{
//    Random r = new Random();
//    command.Parameters.AddWithValue("@Val1", 4081);
//    command.Parameters.AddWithValue("@Val2", "test_" + r.Next(1, 1000).ToString());
//    command.Parameters.AddWithValue("@Val3", "DZA");
//    command.Parameters.AddWithValue("@Val4", "dist_" + r.Next(1, 1000).ToString());
//    command.Parameters.AddWithValue("@Val5", r.Next(10000, 1000000));

//    int affectedRows = command.ExecuteNonQuery();
//    Console.WriteLine("Success");
//}

//string query = "INSERT INTO city (ID, Name, CountryCode, District, Population) VALUES (" +
//               "@Val1, 'test_' + CAST(ABS(CHECKSUM(NEWID())) % 1000 AS NVARCHAR(4)), 'DZA', " +
//               "'dist_' + CAST(ABS(CHECKSUM(NEWID())) % 1000 AS NVARCHAR(4)), " +
//               "ABS(CHECKSUM(NEWID())) % 990000 + 10000)";

//using (var command = new SqlCommand(query, connection))
//{
//    Random r = new Random();
//    command.Parameters.AddWithValue("@Val1", 4082);

//    int affectedRows = command.ExecuteNonQuery();
//    Console.WriteLine("Success");
//}
//#endregion


//    int id = 0;
//    string query = "SELECT MAX(ID) FROM city";
//    using (var command = new SqlCommand(query, connection))
//    {
//        using (SqlDataReader reader = command.ExecuteReader())
//        {
//            while (reader.Read())
//            {
//                id = reader.GetInt32(0);
//            }
//        }
//    }

//    string second_query = @"INSERT INTO city (ID, Name, CountryCode, District, Population) VALUES ";
//    for (int i = 0; i < 10000; i++)
//    {
//        Random r = new Random();
//        second_query += $"({id + 1 + i}, ";
//        second_query += $"'test_{r.Next(1, 1000)}', ";
//        second_query += "'DZA', ";
//        second_query += $"'dist_{+r.Next(1, 1000)}', ";
//        second_query += $"{r.Next(10000, 1000000)}";
//        second_query += "),";
//    }
//    // Убираем последнюю запятую
//    second_query = second_query.TrimEnd(',');

//    using (var command = new SqlCommand(second_query, connection))
//    {
//        try
//        {
//            int rowsAffected = command.ExecuteNonQuery();
//            Console.WriteLine($"Количество затронутых строк: {rowsAffected}");
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine($"Ошибка: {ex.Message}");
//        }
//    }
//}












using System.Data.SqlClient;
using System.Diagnostics;
using System.Text;
using Microsoft.Extensions.Configuration;

IConfigurationRoot config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

string? connectionStr = config.GetConnectionString("ConnectionString");
Console.WriteLine(connectionStr);


Stopwatch stopwatch = new Stopwatch();
stopwatch.Start();

//кількість строк для заповнення
int stepInstert = 100000;

using (var connection = new SqlConnection(connectionStr))
{
    connection.Open();


    for (int j = 0; j < 1; j++)
    {
        StringBuilder query = new StringBuilder("SELECT MAX(ID) FROM city");
        int lastID = -1;



        using (var command = new SqlCommand(query.ToString(), connection))
        {
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    lastID = reader.GetInt32(0);

                    Console.WriteLine($"ID: {lastID}");
                }
                query = new StringBuilder("");
            }
        }



        Random r = new Random();
        for (int i = lastID + 1; i < lastID + stepInstert + 1; i++)
        {
            query.Append($"INSERT INTO city (ID, Name, CountryCode, District, Population) VALUES ({i}, \'Test_{r.Next(2000, 6000)}\' , \'DZA\', \'dist_{r.Next(1, 100)}\', {r.Next(10000, 1000000)})\n");
        }


        using (var command = new SqlCommand(query.ToString(), connection))
        {
            command.ExecuteNonQuery();
        }
    }

    stopwatch.Stop();
    Console.WriteLine($"Bulk insert completed in {stopwatch.ElapsedMilliseconds} milliseconds.");
    Console.WriteLine("Success");



    //    for (int i = lastID + 1; i < lastID + stepInstert + 1; i++)
    //    {
    //        query = "INSERT INTO city (ID, Name, CountryCode, District, Population) VALUES (@Val1, @Val2, @Val3, @Val4, @Val5)";
    //        using (var command = new SqlCommand(query, connection))
    //        {
    //            Random r = new Random();
    //            command.Parameters.AddWithValue("@Val1", i);
    //            command.Parameters.AddWithValue("@Val2", $"Test_" + r.Next(2000, 6000).ToString());
    //            command.Parameters.AddWithValue("@Val3", $"DZA{i}");
    //            command.Parameters.AddWithValue("@Val4", "dist_" + r.Next(1, 100).ToString());
    //            command.Parameters.AddWithValue("@Val5", r.Next(10000, 1000000));

    //            int affectedRows = command.ExecuteNonQuery();
    //            Console.WriteLine("Done " + i.ToString() + " " + (i - lastID).ToString() + "/" + stepInstert.ToString());
    //        }
    //    }

}


