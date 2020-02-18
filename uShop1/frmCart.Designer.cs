namespace uShop1
{
    partial class frmCart
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
            this.lboxGames = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pboxGamePicture = new System.Windows.Forms.PictureBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCartCount = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lblCart = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pboxGamePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // lboxGames
            // 
            this.lboxGames.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lboxGames.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lboxGames.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lboxGames.FormattingEnabled = true;
            this.lboxGames.Location = new System.Drawing.Point(33, 38);
            this.lboxGames.Name = "lboxGames";
            this.lboxGames.Size = new System.Drawing.Size(197, 145);
            this.lboxGames.TabIndex = 1;
            this.lboxGames.SelectedIndexChanged += new System.EventHandler(this.lboxGames_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(154, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 35);
            this.button1.TabIndex = 11;
            this.button1.TabStop = false;
            this.button1.Text = "Remove from Cart";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.RemoveFromCart);
            // 
            // pboxGamePicture
            // 
            this.pboxGamePicture.Location = new System.Drawing.Point(236, 38);
            this.pboxGamePicture.Name = "pboxGamePicture";
            this.pboxGamePicture.Size = new System.Drawing.Size(70, 68);
            this.pboxGamePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxGamePicture.TabIndex = 12;
            this.pboxGamePicture.TabStop = false;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Noto Serif Lao", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPrice.Location = new System.Drawing.Point(246, 109);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(53, 20);
            this.lblPrice.TabIndex = 13;
            this.lblPrice.Text = "<price>";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Noto Serif Lao", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(366, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 21);
            this.label2.TabIndex = 14;
            this.label2.Text = "Items in Cart:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Noto Serif Lao", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(398, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 21);
            this.label3.TabIndex = 15;
            this.label3.Text = "Subtotal: ";
            // 
            // lblCartCount
            // 
            this.lblCartCount.AutoSize = true;
            this.lblCartCount.Font = new System.Drawing.Font("Noto Serif Lao", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCartCount.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCartCount.Location = new System.Drawing.Point(475, 38);
            this.lblCartCount.Name = "lblCartCount";
            this.lblCartCount.Size = new System.Drawing.Size(93, 21);
            this.lblCartCount.TabIndex = 16;
            this.lblCartCount.Text = "<cartCount>";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Noto Serif Lao", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSubtotal.Location = new System.Drawing.Point(475, 64);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(80, 21);
            this.lblSubtotal.TabIndex = 17;
            this.lblSubtotal.Text = "<subtotal>";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Noto Serif Lao", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(398, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 21);
            this.label6.TabIndex = 18;
            this.label6.Text = "Tax (7%):";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Noto Serif Lao", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTax.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTax.Location = new System.Drawing.Point(475, 92);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(47, 21);
            this.lblTax.TabIndex = 19;
            this.lblTax.Text = "<tax>";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Noto Serif Lao", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(414, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 21);
            this.label8.TabIndex = 20;
            this.label8.Text = "Total:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Noto Serif Lao", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTotal.Location = new System.Drawing.Point(475, 126);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(56, 21);
            this.lblTotal.TabIndex = 21;
            this.lblTotal.Text = "<total>";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(439, 190);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 22;
            this.button2.TabStop = false;
            this.button2.Text = "Checkout";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Checkout);
            // 
            // lblCart
            // 
            this.lblCart.AutoSize = true;
            this.lblCart.Font = new System.Drawing.Font("Noto Serif Lao", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCart.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblCart.Location = new System.Drawing.Point(39, 14);
            this.lblCart.Name = "lblCart";
            this.lblCart.Size = new System.Drawing.Size(38, 21);
            this.lblCart.TabIndex = 23;
            this.lblCart.Text = "Cart";
            // 
            // frmCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(582, 295);
            this.Controls.Add(this.lblCart);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.lblCartCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.pboxGamePicture);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lboxGames);
            this.Name = "frmCart";
            this.Text = "frmCart";
            this.Load += new System.EventHandler(this.frmCart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboxGamePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lboxGames;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pboxGamePicture;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCartCount;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblCart;
    }
}