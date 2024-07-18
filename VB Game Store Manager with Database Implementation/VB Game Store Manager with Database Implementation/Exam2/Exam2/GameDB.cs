using System;
using System.Collections.Generic;
//ADO.NET API
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exam2
{
    class GameDB
    {
       
        public static void addGame(Game game)
        {
            //Insert using embedded sql
            string sqlString = "insert into game values(@id, @titl, @prce, @dscnt) ";

            //Get a connetion object
            SqlConnection connection = DBConnection.getConnection();
            //Prepare for a SQL statement 
            try
            {
                SqlCommand insertCommand = new SqlCommand(sqlString, connection);
                insertCommand.Parameters.AddWithValue("@id", game.GameId);
                insertCommand.Parameters.AddWithValue("@titl", game.Title);
                insertCommand.Parameters.AddWithValue("@prce", game.Price);
                insertCommand.Parameters.AddWithValue("@dscnt", game.Discount);
                connection.Open();
                insertCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //log the error.
                Console.WriteLine(ex);
                throw ex;
            }

            try
            {
                connection.Close();
            }
            catch (Exception ex)
            {
                //log the error.
                Console.WriteLine(ex);
            }

        }
        public static List<Game> getAllGames()
        {
            List<Game> list = new List<Game>();
            string sqlString = "select * from game";


            //Get a connetion object
            SqlConnection connection = DBConnection.getConnection();

            //Prepare for a SQL statement 
            SqlCommand selectCommand = new SqlCommand(sqlString, connection);
            SqlDataReader reader;

            //Execute the SQL command
            try
            {
                connection.Open();
                reader = selectCommand.ExecuteReader();
            }
            catch (Exception ex)
            {
                //log the error.
                Console.WriteLine(ex);

                //throw the error to the presntation layer
                throw new Exception("database server error");
            }

            //populate the list of games
            while (reader.Read()) //reader.Read() return true if there is a recored
            {
                Game g;
                try
                {
                    g = new Game();
                    g.GameId = (string)reader["GameId"]; // column name is case sentitive 
                    g.Title = (string)reader["Title"];
                    g.Price = (decimal)reader["Price"];
                    g.Discount = (decimal)reader["Discount"];
                }
                catch (Exception ex)
                {
                    //log the error.
                    Console.WriteLine(ex);
                    return null;

                    //throw the error to the presntation layer
                    throw new Exception("data error");

                }
                list.Add(g);
            }

            try
            {
                connection.Close();
            }
            catch (Exception ex)
            {
                //log the error.
                Console.WriteLine(ex);
            }
            return list;
        }
    }
}
