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
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        //initialize variables
        private Game game;
        List<Game> games = new List<Game>();
        List<Game> wishlist;
        public static int cartCount;

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                cartCount = GameDB.CheckCartCount();
                games = GameDB.SortGames("numberOfPurchases DESC"); //calls my select all method from the games db class
                LoadGameListBox(games);
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
        
        private void LoadGameListBox(List<Game> games)
        {
            try
            {
                lboxGames.DataSource = games; //maps the list to my list box
                lboxGames.DisplayMember = "Title"; //this is what's being displayed in the list box
                lboxGames.ValueMember = "GameID"; //this is what is being called by the selection in the list box
                game = games[lboxGames.SelectedIndex]; //this is so the currently selected game in my listbox is the one being displayed
                DisplayGame(game);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void DisplayGame(Game game) //mapping info to my controls
        {
            lblGameTitle.Text = game.Title;
            lblGameDescription.Text = game.Description;
            lblGameGenre.Text = game.Genre;
            lblGamePrice.Text = game.Price.ToString("C");
            pboxGamePicture.Image = game.Picture;
        }

        private void AddtoCart(object sender, EventArgs e)
        {
            try
            {
                bool addedToCart = false;
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

        private void AddtoWishlist(object sender, EventArgs e)
        {
            try
            {
                bool addedToWishlist = false;
                addedToWishlist = GameDB.AddToWishlist(game);
                if (addedToWishlist)
                {
                    lblAddedWishlist.Visible = true;
                    addedWishlistTimer.Start();
                }
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

        private void lboxGames_SelectedIndexChanged(object sender, EventArgs e) //updates info based on which item in the listbox is selected
        {
            try
            {
                game = games[lboxGames.SelectedIndex];
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

        private void GoToCart(object sender, EventArgs e) //this goes to the cart checkout form if there are items in the cart
        {
            if(cartCount != 0)
            {
                frmCart cartForm = new frmCart();
                cartForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("No items in cart.");
            }
        }

        private void mainForm_Activated(object sender, EventArgs e) //every time the form is activated, it checks the cart. This is mostly for when the user returns from checkout
        {
            try
            {
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

        private void NavigationButton_Click(object sender, EventArgs e) //this is for the arrow buttons at the bottom of the form to allow the user to scroll through the listbox easier
        {
            var button = sender as Button;
            switch (button.Name)
            {
                case "btnNext":
                    if (lboxGames.SelectedIndex+1 < games.Count)
                        lboxGames.SelectedIndex += 1;
                    break;
                case "btnPrevious":

                    if (lboxGames.SelectedIndex >= 1)
                        lboxGames.SelectedIndex -= 1;
                    break;
            }
                
        }

        private void GoToWishlist(object sender, EventArgs e) //same as GoToCart except with wishlist, uses a different method of checking count
        {
            try
            {
                int wishlistCount = 0;
                wishlist = GameDB.GetWishlist();
                foreach(Game game in wishlist)
                {
                    wishlistCount++;
                }
                if (wishlistCount > 0)
                {
                    frmWishlist wishlistForm = new frmWishlist();
                    wishlistForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("No items in wishlist.");
                }
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

        private void addedWishlistTimer_Tick(object sender, EventArgs e)
        {
            lblAddedWishlist.Visible = false;
        }

        private void lblSort_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lblSort.Text == "(+) Sorting Options")
            {
                lblSort.Text = "(-) Sorting Options";
                gboxSort.Visible = true;
            }
            else if (lblSort.Text == "(-) Sorting Options")
            {
                lblSort.Text = "(+) Sorting Options";
                gboxSort.Visible = false;
            }
        }

        private void sortCheckChanged(object sender, EventArgs e)
        {
            try
            {
                if (rdoPopularityHigh.Checked == true)
                {
                    games = GameDB.SortGames("numberOfPurchases DESC");
                }
                else if (rdoPopularityLow.Checked == true)
                {
                    games = GameDB.SortGames("numberOfPurchases ASC");
                }
                else if (rdoPriceHigh.Checked == true)
                {
                    games = GameDB.SortGames("gamePrice DESC");
                }
                else if (rdoPriceLow.Checked == true)
                {
                    games = GameDB.SortGames("gamePrice ASC");
                }
                else if (rdoNameA.Checked == true)
                {
                    games = GameDB.SortGames("gameTitle ASC");
                }
                else if (rdoNameZ.Checked == true)
                {
                    games = GameDB.SortGames("gameTitle DESC");
                }

                LoadGameListBox(games);
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
    }
}
