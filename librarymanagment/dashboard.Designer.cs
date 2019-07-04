namespace librarymanagment
{
    partial class srch
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
            this.Lblsearch = new MaterialSkin.Controls.MaterialFlatButton();
            this.Txtsearch = new System.Windows.Forms.TextBox();
            this.Mtsrch = new MaterialSkin.Controls.MaterialFlatButton();
            this.Dgvsearch = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Dgvsearch)).BeginInit();
            this.SuspendLayout();
            // 
            // Lblsearch
            // 
            this.Lblsearch.AutoSize = true;
            this.Lblsearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Lblsearch.Depth = 0;
            this.Lblsearch.Location = new System.Drawing.Point(267, 104);
            this.Lblsearch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Lblsearch.MouseState = MaterialSkin.MouseState.HOVER;
            this.Lblsearch.Name = "Lblsearch";
            this.Lblsearch.Primary = false;
            this.Lblsearch.Size = new System.Drawing.Size(111, 36);
            this.Lblsearch.TabIndex = 0;
            this.Lblsearch.Text = "Book Name";
            this.Lblsearch.UseVisualStyleBackColor = true;
            // 
            // Txtsearch
            // 
            this.Txtsearch.Location = new System.Drawing.Point(442, 111);
            this.Txtsearch.Name = "Txtsearch";
            this.Txtsearch.Size = new System.Drawing.Size(250, 22);
            this.Txtsearch.TabIndex = 1;
            // 
            // Mtsrch
            // 
            this.Mtsrch.AutoSize = true;
            this.Mtsrch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Mtsrch.BackColor = System.Drawing.Color.Blue;
            this.Mtsrch.Depth = 0;
            this.Mtsrch.Location = new System.Drawing.Point(267, 174);
            this.Mtsrch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Mtsrch.MouseState = MaterialSkin.MouseState.HOVER;
            this.Mtsrch.Name = "Mtsrch";
            this.Mtsrch.Primary = false;
            this.Mtsrch.Size = new System.Drawing.Size(79, 36);
            this.Mtsrch.TabIndex = 2;
            this.Mtsrch.Text = "Search";
            this.Mtsrch.UseVisualStyleBackColor = false;
            this.Mtsrch.Click += new System.EventHandler(this.Mtsrch_Click);
            // 
            // Dgvsearch
            // 
            this.Dgvsearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgvsearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgvsearch.Location = new System.Drawing.Point(0, 284);
            this.Dgvsearch.Name = "Dgvsearch";
            this.Dgvsearch.RowTemplate.Height = 24;
            this.Dgvsearch.Size = new System.Drawing.Size(1282, 254);
            this.Dgvsearch.TabIndex = 3;
            // 
            // srch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 587);
            this.Controls.Add(this.Dgvsearch);
            this.Controls.Add(this.Mtsrch);
            this.Controls.Add(this.Txtsearch);
            this.Controls.Add(this.Lblsearch);
            this.Name = "srch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Book";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Srch_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.Dgvsearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton Lblsearch;
        private System.Windows.Forms.TextBox Txtsearch;
        private MaterialSkin.Controls.MaterialFlatButton Mtsrch;
        private System.Windows.Forms.DataGridView Dgvsearch;
    }
}