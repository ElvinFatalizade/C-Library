namespace librarymanagment
{
    partial class addbooks
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.Txtbkname = new System.Windows.Forms.TextBox();
            this.Txtbkauthor = new System.Windows.Forms.TextBox();
            this.Txtbkpb = new System.Windows.Forms.DateTimePicker();
            this.Txtbkprice = new System.Windows.Forms.TextBox();
            this.Txtbkquantity = new System.Windows.Forms.TextBox();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.Dgvlist = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.Dgvlist)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.White;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(32, 83);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(110, 24);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Book Name";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.White;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(32, 137);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(114, 24);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Book Author";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.Color.White;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(32, 182);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(154, 24);
            this.materialLabel3.TabIndex = 2;
            this.materialLabel3.Text = "Book Publication";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(32, 231);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(102, 24);
            this.materialLabel4.TabIndex = 3;
            this.materialLabel4.Text = "Book Price";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(32, 272);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(128, 24);
            this.materialLabel5.TabIndex = 4;
            this.materialLabel5.Text = "Book Quantity";
            // 
            // Txtbkname
            // 
            this.Txtbkname.Location = new System.Drawing.Point(223, 85);
            this.Txtbkname.Name = "Txtbkname";
            this.Txtbkname.Size = new System.Drawing.Size(220, 22);
            this.Txtbkname.TabIndex = 5;
            this.Txtbkname.TextChanged += new System.EventHandler(this.Txtbookname);
            // 
            // Txtbkauthor
            // 
            this.Txtbkauthor.Location = new System.Drawing.Point(223, 137);
            this.Txtbkauthor.Name = "Txtbkauthor";
            this.Txtbkauthor.Size = new System.Drawing.Size(220, 22);
            this.Txtbkauthor.TabIndex = 6;
            // 
            // Txtbkpb
            // 
            this.Txtbkpb.Location = new System.Drawing.Point(223, 182);
            this.Txtbkpb.Name = "Txtbkpb";
            this.Txtbkpb.Size = new System.Drawing.Size(220, 22);
            this.Txtbkpb.TabIndex = 7;
            // 
            // Txtbkprice
            // 
            this.Txtbkprice.Location = new System.Drawing.Point(223, 231);
            this.Txtbkprice.Name = "Txtbkprice";
            this.Txtbkprice.Size = new System.Drawing.Size(220, 22);
            this.Txtbkprice.TabIndex = 8;
            // 
            // Txtbkquantity
            // 
            this.Txtbkquantity.Location = new System.Drawing.Point(223, 272);
            this.Txtbkquantity.Name = "Txtbkquantity";
            this.Txtbkquantity.Size = new System.Drawing.Size(220, 22);
            this.Txtbkquantity.TabIndex = 9;
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(512, 258);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(47, 36);
            this.materialFlatButton1.TabIndex = 10;
            this.materialFlatButton1.Text = "Add";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.MaterialFlatButton1_Click);
            // 
            // Dgvlist
            // 
            this.Dgvlist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgvlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgvlist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.Dgvlist.Location = new System.Drawing.Point(3, 319);
            this.Dgvlist.Name = "Dgvlist";
            this.Dgvlist.RowTemplate.Height = 24;
            this.Dgvlist.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Dgvlist.Size = new System.Drawing.Size(1280, 261);
            this.Dgvlist.TabIndex = 11;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Book Name";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Book Author";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Book Publication";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Book Price";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Book Quantity";
            this.Column5.Name = "Column5";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(958, 83);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 12;
            // 
            // materialFlatButton2
            // 
            this.materialFlatButton2.AutoSize = true;
            this.materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton2.Depth = 0;
            this.materialFlatButton2.Location = new System.Drawing.Point(577, 258);
            this.materialFlatButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton2.Name = "materialFlatButton2";
            this.materialFlatButton2.Primary = false;
            this.materialFlatButton2.Size = new System.Drawing.Size(93, 36);
            this.materialFlatButton2.TabIndex = 13;
            this.materialFlatButton2.Text = "View List";
            this.materialFlatButton2.UseVisualStyleBackColor = true;
            this.materialFlatButton2.Click += new System.EventHandler(this.MaterialFlatButton2_Click);
            // 
            // addbooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1286, 577);
            this.Controls.Add(this.materialFlatButton2);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.Dgvlist);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.Txtbkquantity);
            this.Controls.Add(this.Txtbkprice);
            this.Controls.Add(this.Txtbkpb);
            this.Controls.Add(this.Txtbkauthor);
            this.Controls.Add(this.Txtbkname);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Name = "addbooks";
            this.Text = "Add Books";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Addbooks_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.Dgvlist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private System.Windows.Forms.TextBox Txtbkname;
        private System.Windows.Forms.TextBox Txtbkauthor;
        private System.Windows.Forms.DateTimePicker Txtbkpb;
        private System.Windows.Forms.TextBox Txtbkprice;
        private System.Windows.Forms.TextBox Txtbkquantity;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private System.Windows.Forms.DataGridView Dgvlist;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton2;
    }
}