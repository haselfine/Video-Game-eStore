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
    public partial class frmCart : Form
    {
        public frmCart()
        {
            InitializeComponent();
        }
        //initialize variables
        private Game game;
        private List<Game> cart = new List<Game>();
        int cartCount = mainForm.cartCount; //checks how many items are in the cart. This is mostly so I can send the information back to the main form later.
        decimal subtotal;
        decimal tax;
        decimal salesTax = 0.06875m;
        decimal total;


        private void frmCart_Load(object sender, EventArgs e)
        {
            try
            {
                cart = GameDB.GetCart();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
            this.LoadCartListBox();
            this.LoadTotals();
        }

        private List<Game> SortCart(string sort = "gameTitle DESC") //gets items in cart
        {
            try
            {
                List<Game> cart = new List<Game>();
                cart = GameDB.GetCart();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }

            return cart;
        }

        private void LoadCartListBox() //loads the listbox with the items in the cart
        {
            try
            {
                cart = SortCart();
                lboxGames.DataSource = cart;
                lboxGames.DisplayMember = "Title";
                lboxGames.ValueMember = "GameID";
                game = cart[lboxGames.SelectedIndex];
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
            pboxGamePicture.Image = game.Picture;
            lblPrice.Text = game.Price.ToString("C");
        }

        private void LoadTotals() //this is for loading the subtotal, tax, and grand total sum of all items
        {
            try
            {
                cartCount = GameDB.CheckCartCount();
                lblCartCount.Text = cartCount.ToString();
                
                cart = SortCart();
                subtotal = FindSubtotal(cart);
                tax = FindTax(subtotal);
                total = FindTotal(subtotal, tax);

                if (subtotal == 0m)
                    lblSubtotal.Text = String.Empty;
                else
                    lblSubtotal.Text = subtotal.ToString("C");

                if (tax == 0m)
                    lblTax.Text = String.Empty;
                else
                    lblTax.Text = tax.ToString("C");

                if (total == 0m)
                    lblTotal.Text = String.Empty;
                else
                    lblTotal.Text = total.ToString("C");
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
        
        public decimal FindSubtotal(List<Game> cart)
        {
            subtotal = 0;
            foreach (Game g in cart)
            {
                subtotal = subtotal + g.Price;
            }
            return subtotal;
        }

        public decimal FindTax(decimal subtotal)
        {
            tax = 0;
            tax = subtotal * salesTax;
            return tax;
        }

        public decimal FindTotal(decimal subtotal, decimal tax)
        {
            total = 0;
            total = subtotal + tax;
            return total;
        }

        private void RemoveFromCart(object sender, EventArgs e) //calls method in games DB which sets the cart column to "N" for selected items
        {

            try
            {
                if(cart.Count == 1)
                {
                    this.Close(); //closes this form if they remove the only item in their cart
                    GameDB.RemoveFromCart(game);
                    mainForm.cartCount = cartCount; //sends information back to the main form
                }
                else
                {
                    GameDB.RemoveFromCart(game);
                    cart = GameDB.GetCart();
                    LoadCartListBox();
                    LoadTotals();
                    cartCount = GameDB.CheckCartCount();
                    lblCartCount.Text = cartCount.ToString();
                    mainForm.cartCount = cartCount; //sends information back to the main form
                }
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
            catch(Exception ex)
            {
                MessageBox.Show("Sorry, but something went wrong. Contact us with your error type\nError Type:\n" + ex.GetType().ToString(), "Error");
            }
        }

        private void Checkout(object sender, EventArgs e) //if they press the checkout button, displays message
        {
            try
            {
                foreach(Game game in cart)
                {
                    GameDB.RemoveFromCart(game);
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
            MessageBox.Show("Thank you for using the uStore! Your purchase has been processed.\n\n" +
                "Your game codes should arrive in your email shortly.\n\nHave a nice day!");
            this.Close();
        }

        private void lboxGames_SelectedIndexChanged(object sender, EventArgs e) //changes display based off selected item
        {
            game = cart[lboxGames.SelectedIndex];
            DisplayGame(game);
        }
    }
}
