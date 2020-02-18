namespace uShop1
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label gamePriceLabel;
            System.Windows.Forms.Label gameGenreLabel;
            System.Windows.Forms.Label gameDescriptionLabel;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.lblGameTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblGameDescription = new System.Windows.Forms.Label();
            this.lblGameGenre = new System.Windows.Forms.Label();
            this.pboxGamePicture = new System.Windows.Forms.PictureBox();
            this.lblGamePrice = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.lboxGames = new System.Windows.Forms.ListBox();
            this.btnCart = new System.Windows.Forms.Button();
            this.lblCartCount = new System.Windows.Forms.Label();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblAddedWishlist = new System.Windows.Forms.Label();
            this.addedWishlistTimer = new System.Windows.Forms.Timer(this.components);
            this.gboxSort = new System.Windows.Forms.GroupBox();
            this.rdoNameA = new System.Windows.Forms.RadioButton();
            this.rdoPriceHigh = new System.Windows.Forms.RadioButton();
            this.rdoPopularityHigh = new System.Windows.Forms.RadioButton();
            this.lblSort = new System.Windows.Forms.LinkLabel();
            this.rdoNameZ = new System.Windows.Forms.RadioButton();
            this.rdoPriceLow = new System.Windows.Forms.RadioButton();
            this.rdoPopularityLow = new System.Windows.Forms.RadioButton();
            gamePriceLabel = new System.Windows.Forms.Label();
            gameGenreLabel = new System.Windows.Forms.Label();
            gameDescriptionLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxGamePicture)).BeginInit();
            this.gboxSort.SuspendLayout();
            this.SuspendLayout();
            // 
            // gamePriceLabel
            // 
            gamePriceLabel.Font = new System.Drawing.Font("Noto Sans Lao", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gamePriceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(217)))), ((int)(((byte)(155)))));
            gamePriceLabel.Location = new System.Drawing.Point(863, 70);
            gamePriceLabel.Name = "gamePriceLabel";
            gamePriceLabel.Size = new System.Drawing.Size(68, 26);
            gamePriceLabel.TabIndex = 3;
            gamePriceLabel.Text = "Price:";
            // 
            // gameGenreLabel
            // 
            gameGenreLabel.Font = new System.Drawing.Font("Noto Sans Lao", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gameGenreLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            gameGenreLabel.Location = new System.Drawing.Point(263, 110);
            gameGenreLabel.Name = "gameGenreLabel";
            gameGenreLabel.Size = new System.Drawing.Size(79, 23);
            gameGenreLabel.TabIndex = 3;
            gameGenreLabel.Text = "Genre:";
            // 
            // gameDescriptionLabel
            // 
            gameDescriptionLabel.Font = new System.Drawing.Font("Noto Sans Lao", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gameDescriptionLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            gameDescriptionLabel.Location = new System.Drawing.Point(263, 163);
            gameDescriptionLabel.Name = "gameDescriptionLabel";
            gameDescriptionLabel.Size = new System.Drawing.Size(115, 23);
            gameDescriptionLabel.TabIndex = 5;
            gameDescriptionLabel.Text = "Description:";
            // 
            // label1
            // 
            label1.Font = new System.Drawing.Font("Noto Serif Lao", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label1.Location = new System.Drawing.Point(21, 14);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(106, 34);
            label1.TabIndex = 11;
            label1.Text = "Games";
            // 
            // lblGameTitle
            // 
            this.lblGameTitle.Font = new System.Drawing.Font("Noto Serif Lao", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(217)))), ((int)(((byte)(155)))));
            this.lblGameTitle.Location = new System.Drawing.Point(260, 18);
            this.lblGameTitle.Name = "lblGameTitle";
            this.lblGameTitle.Size = new System.Drawing.Size(325, 100);
            this.lblGameTitle.TabIndex = 2;
            this.lblGameTitle.Text = "<SQL title connection goes here>";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(gameDescriptionLabel);
            this.panel1.Controls.Add(this.lblGameDescription);
            this.panel1.Controls.Add(gameGenreLabel);
            this.panel1.Controls.Add(this.lblGameGenre);
            this.panel1.Controls.Add(this.pboxGamePicture);
            this.panel1.Controls.Add(this.lblGameTitle);
            this.panel1.Location = new System.Drawing.Point(240, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(607, 383);
            this.panel1.TabIndex = 3;
            // 
            // lblGameDescription
            // 
            this.lblGameDescription.Font = new System.Drawing.Font("Noto Sans Lao", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameDescription.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblGameDescription.Location = new System.Drawing.Point(285, 193);
            this.lblGameDescription.Name = "lblGameDescription";
            this.lblGameDescription.Size = new System.Drawing.Size(300, 169);
            this.lblGameDescription.TabIndex = 6;
            this.lblGameDescription.Text = "<SQL description connection goes here>";
            // 
            // lblGameGenre
            // 
            this.lblGameGenre.Font = new System.Drawing.Font("Noto Sans Lao", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameGenre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblGameGenre.Location = new System.Drawing.Point(285, 140);
            this.lblGameGenre.Name = "lblGameGenre";
            this.lblGameGenre.Size = new System.Drawing.Size(300, 23);
            this.lblGameGenre.TabIndex = 4;
            this.lblGameGenre.Text = "<SQL genre connection goes here>";
            // 
            // pboxGamePicture
            // 
            this.pboxGamePicture.Location = new System.Drawing.Point(18, 18);
            this.pboxGamePicture.Name = "pboxGamePicture";
            this.pboxGamePicture.Size = new System.Drawing.Size(227, 208);
            this.pboxGamePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxGamePicture.TabIndex = 3;
            this.pboxGamePicture.TabStop = false;
            // 
            // lblGamePrice
            // 
            this.lblGamePrice.Font = new System.Drawing.Font("Noto Sans Lao", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGamePrice.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblGamePrice.Location = new System.Drawing.Point(883, 96);
            this.lblGamePrice.Name = "lblGamePrice";
            this.lblGamePrice.Size = new System.Drawing.Size(170, 87);
            this.lblGamePrice.TabIndex = 4;
            this.lblGamePrice.Text = "<SQL price connection goes here>";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Noto Serif Lao", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(908, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 47);
            this.button1.TabIndex = 5;
            this.button1.TabStop = false;
            this.button1.Text = "Add to Cart";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AddtoCart);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Noto Serif Lao", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(908, 270);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 47);
            this.button2.TabIndex = 6;
            this.button2.TabStop = false;
            this.button2.Text = "Add to Wishlist";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.AddtoWishlist);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Noto Serif Lao", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(1000, 397);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(71, 37);
            this.button4.TabIndex = 8;
            this.button4.TabStop = false;
            this.button4.Text = "Wishlist";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.GoToWishlist);
            // 
            // lboxGames
            // 
            this.lboxGames.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lboxGames.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lboxGames.Font = new System.Drawing.Font("Noto Serif Lao", 7.9F);
            this.lboxGames.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lboxGames.FormattingEnabled = true;
            this.lboxGames.ItemHeight = 18;
            this.lboxGames.Location = new System.Drawing.Point(27, 51);
            this.lboxGames.Name = "lboxGames";
            this.lboxGames.Size = new System.Drawing.Size(189, 272);
            this.lboxGames.TabIndex = 1;
            this.lboxGames.SelectedIndexChanged += new System.EventHandler(this.lboxGames_SelectedIndexChanged);
            // 
            // btnCart
            // 
            this.btnCart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCart.Font = new System.Drawing.Font("Noto Serif Lao", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCart.Image = ((System.Drawing.Image)(resources.GetObject("btnCart.Image")));
            this.btnCart.Location = new System.Drawing.Point(1025, 25);
            this.btnCart.Name = "btnCart";
            this.btnCart.Size = new System.Drawing.Size(64, 68);
            this.btnCart.TabIndex = 7;
            this.btnCart.TabStop = false;
            this.btnCart.UseVisualStyleBackColor = true;
            this.btnCart.Click += new System.EventHandler(this.GoToCart);
            // 
            // lblCartCount
            // 
            this.lblCartCount.AutoSize = true;
            this.lblCartCount.Font = new System.Drawing.Font("Noto Serif Lao", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCartCount.ForeColor = System.Drawing.Color.Gold;
            this.lblCartCount.Location = new System.Drawing.Point(996, 44);
            this.lblCartCount.Name = "lblCartCount";
            this.lblCartCount.Size = new System.Drawing.Size(23, 27);
            this.lblCartCount.TabIndex = 10;
            this.lblCartCount.Text = "0";
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(466, 452);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(38, 39);
            this.btnPrevious.TabIndex = 12;
            this.btnPrevious.TabStop = false;
            this.btnPrevious.Text = "←";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.NavigationButton_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(592, 452);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(38, 39);
            this.btnNext.TabIndex = 13;
            this.btnNext.TabStop = false;
            this.btnNext.Text = "→";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.NavigationButton_Click);
            // 
            // lblAddedWishlist
            // 
            this.lblAddedWishlist.AutoSize = true;
            this.lblAddedWishlist.Font = new System.Drawing.Font("Noto Serif Lao", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddedWishlist.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblAddedWishlist.Location = new System.Drawing.Point(996, 279);
            this.lblAddedWishlist.Name = "lblAddedWishlist";
            this.lblAddedWishlist.Size = new System.Drawing.Size(35, 25);
            this.lblAddedWishlist.TabIndex = 14;
            this.lblAddedWishlist.Text = "+1";
            this.lblAddedWishlist.Visible = false;
            // 
            // addedWishlistTimer
            // 
            this.addedWishlistTimer.Interval = 1000;
            this.addedWishlistTimer.Tick += new System.EventHandler(this.addedWishlistTimer_Tick);
            // 
            // gboxSort
            // 
            this.gboxSort.Controls.Add(this.rdoPopularityLow);
            this.gboxSort.Controls.Add(this.rdoPriceLow);
            this.gboxSort.Controls.Add(this.rdoNameZ);
            this.gboxSort.Controls.Add(this.rdoNameA);
            this.gboxSort.Controls.Add(this.rdoPriceHigh);
            this.gboxSort.Controls.Add(this.rdoPopularityHigh);
            this.gboxSort.Font = new System.Drawing.Font("Noto Serif Lao", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxSort.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gboxSort.Location = new System.Drawing.Point(27, 356);
            this.gboxSort.Name = "gboxSort";
            this.gboxSort.Size = new System.Drawing.Size(189, 158);
            this.gboxSort.TabIndex = 16;
            this.gboxSort.TabStop = false;
            this.gboxSort.Visible = false;
            // 
            // rdoNameA
            // 
            this.rdoNameA.AutoSize = true;
            this.rdoNameA.Location = new System.Drawing.Point(6, 107);
            this.rdoNameA.Name = "rdoNameA";
            this.rdoNameA.Size = new System.Drawing.Size(95, 22);
            this.rdoNameA.TabIndex = 2;
            this.rdoNameA.TabStop = true;
            this.rdoNameA.Text = "Name (A-Z)";
            this.rdoNameA.UseVisualStyleBackColor = true;
            this.rdoNameA.CheckedChanged += new System.EventHandler(this.sortCheckChanged);
            // 
            // rdoPriceHigh
            // 
            this.rdoPriceHigh.AutoSize = true;
            this.rdoPriceHigh.Location = new System.Drawing.Point(6, 63);
            this.rdoPriceHigh.Name = "rdoPriceHigh";
            this.rdoPriceHigh.Size = new System.Drawing.Size(130, 22);
            this.rdoPriceHigh.TabIndex = 1;
            this.rdoPriceHigh.TabStop = true;
            this.rdoPriceHigh.Text = "Price (high to low)";
            this.rdoPriceHigh.UseVisualStyleBackColor = true;
            this.rdoPriceHigh.CheckedChanged += new System.EventHandler(this.sortCheckChanged);
            // 
            // rdoPopularityHigh
            // 
            this.rdoPopularityHigh.AutoSize = true;
            this.rdoPopularityHigh.Checked = true;
            this.rdoPopularityHigh.FlatAppearance.CheckedBackColor = System.Drawing.Color.Aqua;
            this.rdoPopularityHigh.Location = new System.Drawing.Point(6, 19);
            this.rdoPopularityHigh.Name = "rdoPopularityHigh";
            this.rdoPopularityHigh.Size = new System.Drawing.Size(159, 22);
            this.rdoPopularityHigh.TabIndex = 0;
            this.rdoPopularityHigh.TabStop = true;
            this.rdoPopularityHigh.Text = "Popularity (high to low)";
            this.rdoPopularityHigh.UseVisualStyleBackColor = true;
            this.rdoPopularityHigh.CheckedChanged += new System.EventHandler(this.sortCheckChanged);
            // 
            // lblSort
            // 
            this.lblSort.ActiveLinkColor = System.Drawing.Color.Cyan;
            this.lblSort.AutoSize = true;
            this.lblSort.Font = new System.Drawing.Font("Noto Serif Lao", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSort.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lblSort.LinkColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSort.Location = new System.Drawing.Point(33, 354);
            this.lblSort.Name = "lblSort";
            this.lblSort.Size = new System.Drawing.Size(117, 18);
            this.lblSort.TabIndex = 17;
            this.lblSort.TabStop = true;
            this.lblSort.Text = "(+) Sorting Options";
            this.lblSort.VisitedLinkColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSort.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblSort_LinkClicked);
            // 
            // rdoNameZ
            // 
            this.rdoNameZ.AutoSize = true;
            this.rdoNameZ.Location = new System.Drawing.Point(6, 129);
            this.rdoNameZ.Name = "rdoNameZ";
            this.rdoNameZ.Size = new System.Drawing.Size(95, 22);
            this.rdoNameZ.TabIndex = 3;
            this.rdoNameZ.TabStop = true;
            this.rdoNameZ.Text = "Name (Z-A)";
            this.rdoNameZ.UseVisualStyleBackColor = true;
            this.rdoNameZ.CheckedChanged += new System.EventHandler(this.sortCheckChanged);
            // 
            // rdoPriceLow
            // 
            this.rdoPriceLow.AutoSize = true;
            this.rdoPriceLow.Location = new System.Drawing.Point(6, 85);
            this.rdoPriceLow.Name = "rdoPriceLow";
            this.rdoPriceLow.Size = new System.Drawing.Size(130, 22);
            this.rdoPriceLow.TabIndex = 4;
            this.rdoPriceLow.TabStop = true;
            this.rdoPriceLow.Text = "Price (low to high)";
            this.rdoPriceLow.UseVisualStyleBackColor = true;
            this.rdoPriceLow.CheckedChanged += new System.EventHandler(this.sortCheckChanged);
            // 
            // rdoPopularityLow
            // 
            this.rdoPopularityLow.AutoSize = true;
            this.rdoPopularityLow.Location = new System.Drawing.Point(6, 41);
            this.rdoPopularityLow.Name = "rdoPopularityLow";
            this.rdoPopularityLow.Size = new System.Drawing.Size(159, 22);
            this.rdoPopularityLow.TabIndex = 5;
            this.rdoPopularityLow.TabStop = true;
            this.rdoPopularityLow.Text = "Popularity (low to high)";
            this.rdoPopularityLow.UseVisualStyleBackColor = true;
            this.rdoPopularityLow.CheckedChanged += new System.EventHandler(this.sortCheckChanged);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(1110, 544);
            this.Controls.Add(this.lblSort);
            this.Controls.Add(this.gboxSort);
            this.Controls.Add(this.lblAddedWishlist);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(label1);
            this.Controls.Add(this.lblCartCount);
            this.Controls.Add(this.lboxGames);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnCart);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(gamePriceLabel);
            this.Controls.Add(this.lblGamePrice);
            this.Controls.Add(this.panel1);
            this.Name = "mainForm";
            this.Text = "uStore";
            this.Activated += new System.EventHandler(this.mainForm_Activated);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboxGamePicture)).EndInit();
            this.gboxSort.ResumeLayout(false);
            this.gboxSort.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblGameTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblGameDescription;
        private System.Windows.Forms.Label lblGameGenre;
        private System.Windows.Forms.PictureBox pboxGamePicture;
        private System.Windows.Forms.Label lblGamePrice;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListBox lboxGames;
        private System.Windows.Forms.Button btnCart;
        private System.Windows.Forms.Label lblCartCount;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblAddedWishlist;
        private System.Windows.Forms.Timer addedWishlistTimer;
        private System.Windows.Forms.GroupBox gboxSort;
        private System.Windows.Forms.RadioButton rdoNameA;
        private System.Windows.Forms.RadioButton rdoPriceHigh;
        private System.Windows.Forms.RadioButton rdoPopularityHigh;
        private System.Windows.Forms.LinkLabel lblSort;
        private System.Windows.Forms.RadioButton rdoNameZ;
        private System.Windows.Forms.RadioButton rdoPopularityLow;
        private System.Windows.Forms.RadioButton rdoPriceLow;
    }
}

