using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace uShop1
{
    public partial class frmWishlist : Form
    {
        public frmWishlist()
        {
            InitializeComponent();
        }

        private Game game;
        bool addedToCart;
        List<Game> wishlist;
        public static int cartCount = GameDB.CheckCartCount();

        private void AddtoCart(object sender, EventArgs e)
        {
            try
            {
                addedToCart = GameDB.AddToCart(game); //this method in the games db class returns true or false
                if (addedToCart) //if it returns true, it checks how many rows are in the cart
                    cartCount = GameDB.CheckCartCount();
                if (cartCount > 0) //if the cart has more than 0 rows in it, this displays next to the cart icon in my GUI
                    lblCartCount.Text = cartCount.ToString();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void frmWishlist_Load(object sender, EventArgs e)
        {
            try
            {
                wishlist = GameDB.GetWishlist();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
            this.LoadWishlistListBox();
        }

        private List<Game> GetWishlist() //gets items in wishlist
        {
            try
            {
                List<Game> wishlist = new List<Game>();
                wishlist = GameDB.GetWishlist();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }

            return wishlist;
        }

        private void LoadWishlistListBox() //loads the listbox with the items in the wishlist
        {
            try
            {
                wishlist = GetWishlist();
                lboxWishlist.DataSource = wishlist;
                lboxWishlist.DisplayMember = "Title";
                lboxWishlist.ValueMember = "GameID";
                game = wishlist[lboxWishlist.SelectedIndex];
                DisplayGame(game);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void DisplayGame(Game game)
        {
            lblTitle.Text = game.Title;
            lblGenre.Text = game.Genre;
            lblPrice.Text = game.Price.ToString("C");
            pboxGamePicture.Image = game.Picture;
        }

        private void lboxWishlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                game = wishlist[lboxWishlist.SelectedIndex]; //this is so the currently selected game in my listbox is the one being displayed
                DisplayGame(game);
                cartCount = GameDB.CheckCartCount();
                lblCartCount.Text = cartCount.ToString();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void RemoveWishlist(object sender, EventArgs e)
        {

            try
            {
                if (wishlist.Count == 1)
                {
                    this.Close(); //closes this form if they remove the only item in their cart
                    GameDB.RemoveFromWishlist(game);
                    mainForm.cartCount = cartCount; //sends information back to the main form
                }
                else
                {
                    GameDB.RemoveFromWishlist(game);
                    wishlist = GameDB.GetWishlist();
                    LoadWishlistListBox();
                    cartCount = GameDB.CheckCartCount();
                    lblCartCount.Text = cartCount.ToString();
                    mainForm.cartCount = cartCount; //sends information back to the main form
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry, but something went wrong. Contact us with your error type\nError Type:\n" + ex.GetType().ToString(), "Error");
            }
        }

        private void GoToCart(object sender, EventArgs e) //opens cart form
        {
            try
            {
                cartCount = GameDB.CheckCartCount();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }

            if (cartCount != 0)
            {
                this.Close(); //close wishlist form
                frmCart cartForm = new frmCart();
                cartForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("No items in cart.");
            }
        }
    }
}
