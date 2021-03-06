﻿namespace LGBookRentals
{
    partial class availableBooksPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Bookname = new System.Windows.Forms.TextBox();
            this.RentalLenght = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.placeorderbtn = new System.Windows.Forms.Button();
            this.booklist = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bookprice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bookpicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bookpicture)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.Location = new System.Drawing.Point(43, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Available Books";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(391, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Book Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(391, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Rental Length";
            // 
            // Bookname
            // 
            this.Bookname.Location = new System.Drawing.Point(395, 153);
            this.Bookname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Bookname.Name = "Bookname";
            this.Bookname.Size = new System.Drawing.Size(296, 22);
            this.Bookname.TabIndex = 4;
            // 
            // RentalLenght
            // 
            this.RentalLenght.Location = new System.Drawing.Point(395, 198);
            this.RentalLenght.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RentalLenght.Name = "RentalLenght";
            this.RentalLenght.Size = new System.Drawing.Size(296, 22);
            this.RentalLenght.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label4.Location = new System.Drawing.Point(395, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(296, 58);
            this.label4.TabIndex = 6;
            this.label4.Text = "Please enter the name of the book that you would like to check out and the rental" +
    " length in days.";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // placeorderbtn
            // 
            this.placeorderbtn.Location = new System.Drawing.Point(467, 256);
            this.placeorderbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.placeorderbtn.Name = "placeorderbtn";
            this.placeorderbtn.Size = new System.Drawing.Size(139, 70);
            this.placeorderbtn.TabIndex = 8;
            this.placeorderbtn.Text = "Place Order";
            this.placeorderbtn.UseVisualStyleBackColor = true;
            this.placeorderbtn.Click += new System.EventHandler(this.placeorderbtn_Click);
            // 
            // booklist
            // 
            this.booklist.FormattingEnabled = true;
            this.booklist.Location = new System.Drawing.Point(52, 112);
            this.booklist.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.booklist.Name = "booklist";
            this.booklist.Size = new System.Drawing.Size(200, 24);
            this.booklist.TabIndex = 9;
            this.booklist.SelectedIndexChanged += new System.EventHandler(this.booklist_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 89);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Select a book from the list";
            // 
            // bookprice
            // 
            this.bookprice.Location = new System.Drawing.Point(52, 170);
            this.bookprice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bookprice.Name = "bookprice";
            this.bookprice.ReadOnly = true;
            this.bookprice.Size = new System.Drawing.Size(83, 22);
            this.bookprice.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 146);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "price";
            // 
            // bookpicture
            // 
            this.bookpicture.Location = new System.Drawing.Point(52, 234);
            this.bookpicture.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bookpicture.Name = "bookpicture";
            this.bookpicture.Size = new System.Drawing.Size(172, 150);
            this.bookpicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bookpicture.TabIndex = 13;
            this.bookpicture.TabStop = false;
            // 
            // availableBooksPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 412);
            this.Controls.Add(this.bookpicture);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bookprice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.booklist);
            this.Controls.Add(this.placeorderbtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RentalLenght);
            this.Controls.Add(this.Bookname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "availableBooksPage";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.bookpicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Bookname;
        private System.Windows.Forms.TextBox RentalLenght;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button placeorderbtn;
        private System.Windows.Forms.ComboBox booklist;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox bookprice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox bookpicture;
    }
}