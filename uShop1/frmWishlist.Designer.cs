namespace uShop1
{
    partial class frmWishlist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWishlist));
            this.lboxWishlist = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pboxGamePicture = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnRemoveWishlist = new System.Windows.Forms.Button();
            this.btnAddtoCart = new System.Windows.Forms.Button();
            this.lblCartCount = new System.Windows.Forms.Label();
            this.btnCart = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pboxGamePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // lboxWishlist
            // 
            this.lboxWishlist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lboxWishlist.Font = new System.Drawing.Font("Noto Serif Lao", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lboxWishlist.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lboxWishlist.FormattingEnabled = true;
            this.lboxWishlist.ItemHeight = 15;
            this.lboxWishlist.Location = new System.Drawing.Point(24, 61);
            this.lboxWishlist.Name = "lboxWishlist";
            this.lboxWishlist.Size = new System.Drawing.Size(163, 289);
            this.lboxWishlist.TabIndex = 1;
            this.lboxWishlist.SelectedIndexChanged += new System.EventHandler(this.lboxWishlist_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Serif Lao", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(217)))), ((int)(((byte)(155)))));
            this.label1.Location = new System.Drawing.Point(149, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Your Wishlist";
            // 
            // pboxGamePicture
            // 
            this.pboxGamePicture.Location = new System.Drawing.Point(212, 71);
            this.pboxGamePicture.Name = "pboxGamePicture";
            this.pboxGamePicture.Size = new System.Drawing.Size(174, 153);
            this.pboxGamePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxGamePicture.TabIndex = 2;
            this.pboxGamePicture.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("OpenSymbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitle.Location = new System.Drawing.Point(272, 244);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(116, 16);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "<title goes here>";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Font = new System.Drawing.Font("OpenSymbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblGenre.Location = new System.Drawing.Point(272, 276);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(131, 16);
            this.lblGenre.TabIndex = 4;
            this.lblGenre.Text = "<genre goes here>";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("OpenSymbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(209, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Price:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("OpenSymbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPrice.Location = new System.Drawing.Point(272, 308);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(126, 16);
            this.lblPrice.TabIndex = 7;
            this.lblPrice.Text = "<price goes here>";
            // 
            // btnRemoveWishlist
            // 
            this.btnRemoveWishlist.Font = new System.Drawing.Font("Noto Serif Lao", 7F);
            this.btnRemoveWishlist.Location = new System.Drawing.Point(212, 343);
            this.btnRemoveWishlist.Name = "btnRemoveWishlist";
            this.btnRemoveWishlist.Size = new System.Drawing.Size(81, 24);
            this.btnRemoveWishlist.TabIndex = 8;
            this.btnRemoveWishlist.TabStop = false;
            this.btnRemoveWishlist.Text = "Remove";
            this.btnRemoveWishlist.UseVisualStyleBackColor = true;
            this.btnRemoveWishlist.Click += new System.EventHandler(this.RemoveWishlist);
            // 
            // btnAddtoCart
            // 
            this.btnAddtoCart.Font = new System.Drawing.Font("Noto Serif Lao", 7F);
            this.btnAddtoCart.Location = new System.Drawing.Point(305, 343);
            this.btnAddtoCart.Name = "btnAddtoCart";
            this.btnAddtoCart.Size = new System.Drawing.Size(81, 24);
            this.btnAddtoCart.TabIndex = 9;
            this.btnAddtoCart.TabStop = false;
            this.btnAddtoCart.Text = "Add to Cart";
            this.btnAddtoCart.UseVisualStyleBackColor = true;
            this.btnAddtoCart.Click += new System.EventHandler(this.AddtoCart);
            // 
            // lblCartCount
            // 
            this.lblCartCount.AutoSize = true;
            this.lblCartCount.Font = new System.Drawing.Font("Noto Serif Lao", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCartCount.ForeColor = System.Drawing.Color.Gold;
            this.lblCartCount.Location = new System.Drawing.Point(389, 31);
            this.lblCartCount.Name = "lblCartCount";
            this.lblCartCount.Size = new System.Drawing.Size(23, 27);
            this.lblCartCount.TabIndex = 12;
            this.lblCartCount.Text = "0";
            // 
            // btnCart
            // 
            this.btnCart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCart.Font = new System.Drawing.Font("Noto Serif Lao", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCart.Image = ((System.Drawing.Image)(resources.GetObject("btnCart.Image")));
            this.btnCart.Location = new System.Drawing.Point(418, 12);
            this.btnCart.Name = "btnCart";
            this.btnCart.Size = new System.Drawing.Size(64, 68);
            this.btnCart.TabIndex = 11;
            this.btnCart.TabStop = false;
            this.btnCart.UseVisualStyleBackColor = true;
            this.btnCart.Click += new System.EventHandler(this.GoToCart);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("OpenSymbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(209, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Title:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("OpenSymbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(209, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Genre:";
            // 
            // frmWishlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(504, 416);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCartCount);
            this.Controls.Add(this.btnCart);
            this.Controls.Add(this.btnAddtoCart);
            this.Controls.Add(this.btnRemoveWishlist);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pboxGamePicture);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lboxWishlist);
            this.Name = "frmWishlist";
            this.Text = "frmWishlist";
            this.Load += new System.EventHandler(this.frmWishlist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboxGamePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lboxWishlist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pboxGamePicture;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Button btnRemoveWishlist;
        private System.Windows.Forms.Button btnAddtoCart;
        private System.Windows.Forms.Label lblCartCount;
        private System.Windows.Forms.Button btnCart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}