using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing; //this is necessary for the Image data type

namespace uShop1
{
    public class Game
    {
        //these are all columns in my game table in SQL
        private int gameID;
        private string gameTitle;
        private decimal gamePrice;
        private string gameDescription;
        private string gameGenre;
        private int numberOfPurchases;
        private string wishlist;
        private string cart;
        private Image gamePicture;


        public Game(int gameID, string gameTitle, decimal gamePrice, string gameDescription, string gameGenre,
            int numberOfPurchases, string wishlist, string cart, Image gamePicture)
        {
            this.GameID = gameID;
            this.Title = gameTitle;
            this.Price = gamePrice;
            this.Description = gameDescription;
            this.Genre = gameGenre;
            this.Purchases = numberOfPurchases;
            this.Wishlist = wishlist;
            this.Cart = cart;
            this.Picture = gamePicture;
            
        }

        public Game() { }

        public int GameID
        {
            get
            {
                return gameID;
            }
            set
            {
                gameID = value;
            }
        }

        public string Title
        {
            get
            {
                return gameTitle;
            }
            set
            {
                gameTitle = value;
            }
        }

        public decimal Price
        {
            get
            {
                return gamePrice;
            }
            set
            {
                gamePrice = value;
            }
        }

        public string Description
        {
            get
            {
                return gameDescription;
            }
            set
            {
                gameDescription = value;
            }
        }

        public string Genre
        {
            get
            {
                return gameGenre;
            }
            set
            {
                gameGenre = value;
            }
        }

        public int Purchases
        {
            get
            {
                return numberOfPurchases;
            }
            set
            {
                numberOfPurchases = value;
            }
        }

        public string Wishlist
        {
            get
            {
                return wishlist;
            }
            set
            {
                wishlist = value;
            }
        }
        public string Cart
        {
            get
            {
                return cart;
            }
            set
            {
                cart = value;
            }
        }
        public Image Picture
        {
            get
            {
                return gamePicture;
            }
            set
            {
                gamePicture = value;
            }
        }
    }
}
