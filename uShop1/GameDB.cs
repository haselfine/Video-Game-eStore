using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //this is for SQL
using System.Drawing; //this is for image data type
using System.IO; //this is for using memory stream I'm pretty sure

namespace uShop1
{
    public static class GameDB
    {
        public static List<Game> SortGames(string sort) //this one is mostly a select statement with all my columns with a sorting variable
        {
            List<Game> games = new List<Game>(); //initialize list with the data type of "Game"
            SqlConnection connection = uStoreDB.GetConnection(); //use method in your class with the connection to your database
            string selectStatement = //my statement is a join because my game pictures are in a separate table from the rest of my columns
                "SELECT games.gameID, gameTitle, gamePrice, gameDescription, gameGenre, numberOfPurchases, wishlist, cart, gamePicture" +
                " FROM Games JOIN GamePictures" +
                " ON Games.GameID = GamePictures.GameID" +
                " ORDER BY " + sort;
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection); //notice this one says SqlCommand rather than SqlConnection
            try
            {
                connection.Open(); //first open the connection
                SqlDataReader gameReader = selectCommand.ExecuteReader(); //then start a data reader
                while (gameReader.Read())
                {
                    Game game = new Game(); //instantiate object of Game type, then all columns
                    game.GameID = (int)gameReader["GameID"]; //change data type to the type you want to work with
                    game.Title = gameReader["gameTitle"].ToString();
                    game.Price = (decimal)gameReader["gamePrice"];
                    game.Description = gameReader["gameDescription"].ToString();
                    game.Genre = gameReader["gameGenre"].ToString();
                    game.Purchases = (int)gameReader["numberOfPurchases"];
                    game.Wishlist = gameReader["wishlist"].ToString();
                    game.Cart = gameReader["cart"].ToString();


                    byte[] imageBytes = (byte[])gameReader["GamePicture"]; //use a byte array for your images
                    MemoryStream buf = new MemoryStream(imageBytes); //put them into memory stream
                    Image picture = Image.FromStream(buf, true); //convert from memory stream to Image data type
                    game.Picture = picture; //add to object

                    games.Add(game); //add each column to your list
                }
                gameReader.Close(); //don't forget to close the connection when you're done.
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            return games; //return the list object
        }

        public static bool AddToCart(Game game) //this one is just changing the character in the Cart column to "y" to indicate that it's in the cart
        {
            SqlConnection connection = uStoreDB.GetConnection();
            string updateCartStatement =
                "UPDATE Games SET Cart = 'Y'" +
                "WHERE GameID = @GameID";
            SqlCommand updateCartCommand = new SqlCommand(updateCartStatement, connection);
            updateCartCommand.Parameters.AddWithValue("@GameID", game.GameID);
            try
            {
                connection.Open();
                int count = updateCartCommand.ExecuteNonQuery(); //this count checks whether the column(s) were updated. If it returns 0, nothing was updated
                if (count > 0)
                    return true;
                else
                    return false;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }


        public static bool RemoveFromCart(Game game) //this is the reverse of the AddToCart method
        {
            SqlConnection connection = uStoreDB.GetConnection();
            string updateCartStatement =
                "UPDATE Games SET Cart = 'N'" +
                "WHERE GameID = @GameID";
            SqlCommand updateCartCommand = new SqlCommand(updateCartStatement, connection);
            updateCartCommand.Parameters.AddWithValue("@GameID", game.GameID);
            try
            {
                connection.Open();
                int count = updateCartCommand.ExecuteNonQuery();
                if (count > 0)
                    return true;
                else
                    return false;
                
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }

        public static int CheckCartCount() //this checks how many rows in the cart table are set to "y"
        {
            SqlConnection connection = uStoreDB.GetConnection();
            string checkCartStatement =
                "SELECT COUNT(*) FROM Games WHERE Cart = 'Y'";
            SqlCommand checkCartCommand = new SqlCommand(checkCartStatement, connection);
            try
            {
                connection.Open();
                int cartCount = (int)checkCartCommand.ExecuteScalar(); //notice I use .ExecuteScalar(). This returns the amount of the first row of the first column in your results
                return cartCount;
            }
            catch(SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }

        public static List<Game> GetCart() //this selects every result that has "Y" in the cart column
        {
            List<Game> cart = new List<Game>();
            SqlConnection connection = uStoreDB.GetConnection();
            string selectStatement =
                "SELECT games.gameID, gameTitle, gamePrice, gameDescription, gameGenre, numberOfPurchases, wishlist, cart, gamePicture" +
                " FROM Games JOIN GamePictures" +
                " ON Games.GameID = GamePictures.GameID" +
                " WHERE cart = 'Y'" +
                " ORDER BY Games.GameID";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            try
            {
                connection.Open();
                SqlDataReader gameReader = selectCommand.ExecuteReader();
                while (gameReader.Read())
                {
                    Game game = new Game();
                    game.GameID = (int)gameReader["GameID"];
                    game.Title = gameReader["gameTitle"].ToString();
                    game.Price = (decimal)gameReader["gamePrice"];
                    game.Description = gameReader["gameDescription"].ToString();
                    game.Genre = gameReader["gameGenre"].ToString();
                    game.Purchases = (int)gameReader["numberOfPurchases"];
                    game.Wishlist = gameReader["wishlist"].ToString();
                    game.Cart = gameReader["cart"].ToString();


                    byte[] imageBytes = (byte[])gameReader["GamePicture"];
                    MemoryStream buf = new MemoryStream(imageBytes);
                    Image picture = Image.FromStream(buf, true);
                    game.Picture = picture;

                    cart.Add(game);
                }
                gameReader.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            connection.Close();
            return cart;
        }

        public static bool AddToWishlist(Game game) //this is the same as AddToCart except with the wishlist column... I'll add similar methods once I start working on the wishlist aspect of my program.
        {
            SqlConnection connection = uStoreDB.GetConnection();
            string updateWishlistStatement =
                "UPDATE Games SET Wishlist = 'Y'" +
                "WHERE Games.GameID = @gameID";
            SqlCommand updateWishlistCommand = new SqlCommand(updateWishlistStatement, connection);
            updateWishlistCommand.Parameters.AddWithValue("@GameID", game.GameID);
            try
            {
                connection.Open();
                int count = updateWishlistCommand.ExecuteNonQuery();
                if (count > 0)
                    return true;
                else
                    return false;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }

        public static bool RemoveFromWishlist(Game game) //this is the reverse of the AddToWishlist method
        {
            SqlConnection connection = uStoreDB.GetConnection();
            string updateWishlistStatement =
                "UPDATE Games SET Wishlist = 'N'" +
                "WHERE GameID = @GameID";
            SqlCommand updateWishlistCommand = new SqlCommand(updateWishlistStatement, connection);
            updateWishlistCommand.Parameters.AddWithValue("@GameID", game.GameID);
            try
            {
                connection.Open();
                int count = updateWishlistCommand.ExecuteNonQuery();
                if (count > 0)
                    return true;
                else
                    return false;

            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }

        public static List<Game> GetWishlist() //this selects every result that has "Y" in the wishlist column
        {
            List<Game> wishlist = new List<Game>();
            SqlConnection connection = uStoreDB.GetConnection();
            string selectStatement =
                "SELECT games.gameID, gameTitle, gamePrice, gameDescription, gameGenre, numberOfPurchases, wishlist, cart, gamePicture" +
                " FROM Games JOIN GamePictures" +
                " ON Games.GameID = GamePictures.GameID" +
                " WHERE wishlist = 'Y'" +
                " ORDER BY Games.GameID";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            try
            {
                connection.Open();
                SqlDataReader gameReader = selectCommand.ExecuteReader();
                while (gameReader.Read())
                {
                    Game game = new Game();
                    game.GameID = (int)gameReader["GameID"];
                    game.Title = gameReader["gameTitle"].ToString();
                    game.Price = (decimal)gameReader["gamePrice"];
                    game.Description = gameReader["gameDescription"].ToString();
                    game.Genre = gameReader["gameGenre"].ToString();
                    game.Purchases = (int)gameReader["numberOfPurchases"];
                    game.Wishlist = gameReader["wishlist"].ToString();
                    game.Cart = gameReader["cart"].ToString();


                    byte[] imageBytes = (byte[])gameReader["GamePicture"];
                    MemoryStream buf = new MemoryStream(imageBytes);
                    Image picture = Image.FromStream(buf, true);
                    game.Picture = picture;

                    wishlist.Add(game);
                }
                gameReader.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            connection.Close();
            return wishlist;
        }
    }
}
