namespace librarymanagment
{
    partial class login
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
            this.Mtuser = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Mtpassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Mtcheckbox = new MaterialSkin.Controls.MaterialCheckBox();
            this.Btnlogin = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // Mtuser
            // 
            this.Mtuser.Depth = 0;
            this.Mtuser.Hint = "Username";
            this.Mtuser.Location = new System.Drawing.Point(114, 148);
            this.Mtuser.MouseState = MaterialSkin.MouseState.HOVER;
            this.Mtuser.Name = "Mtuser";
            this.Mtuser.PasswordChar = '\0';
            this.Mtuser.SelectedText = "";
            this.Mtuser.SelectionLength = 0;
            this.Mtuser.SelectionStart = 0;
            this.Mtuser.Size = new System.Drawing.Size(300, 28);
            this.Mtuser.TabIndex = 0;
            this.Mtuser.UseSystemPasswordChar = false;
            // 
            // Mtpassword
            // 
            this.Mtpassword.Depth = 0;
            this.Mtpassword.Hint = "Password";
            this.Mtpassword.Location = new System.Drawing.Point(114, 212);
            this.Mtpassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.Mtpassword.Name = "Mtpassword";
            this.Mtpassword.PasswordChar = '\0';
            this.Mtpassword.SelectedText = "";
            this.Mtpassword.SelectionLength = 0;
            this.Mtpassword.SelectionStart = 0;
            this.Mtpassword.Size = new System.Drawing.Size(300, 28);
            this.Mtpassword.TabIndex = 1;
            this.Mtpassword.UseSystemPasswordChar = true;
            // 
            // Mtcheckbox
            // 
            this.Mtcheckbox.AutoSize = true;
            this.Mtcheckbox.BackColor = System.Drawing.Color.Transparent;
            this.Mtcheckbox.Depth = 0;
            this.Mtcheckbox.Font = new System.Drawing.Font("Roboto", 10F);
            this.Mtcheckbox.Location = new System.Drawing.Point(114, 261);
            this.Mtcheckbox.Margin = new System.Windows.Forms.Padding(0);
            this.Mtcheckbox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.Mtcheckbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.Mtcheckbox.Name = "Mtcheckbox";
            this.Mtcheckbox.Ripple = true;
            this.Mtcheckbox.Size = new System.Drawing.Size(143, 30);
            this.Mtcheckbox.TabIndex = 2;
            this.Mtcheckbox.Text = "Remember me";
            this.Mtcheckbox.UseVisualStyleBackColor = false;
            // 
            // Btnlogin
            // 
            this.Btnlogin.Depth = 0;
            this.Btnlogin.Location = new System.Drawing.Point(281, 261);
            this.Btnlogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.Btnlogin.Name = "Btnlogin";
            this.Btnlogin.Primary = true;
            this.Btnlogin.Size = new System.Drawing.Size(133, 30);
            this.Btnlogin.TabIndex = 3;
            this.Btnlogin.Text = "Login";
            this.Btnlogin.UseVisualStyleBackColor = true;
            this.Btnlogin.Click += new System.EventHandler(this.Btnlogin_Click);
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(8, 373);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(544, 10);
            this.materialDivider1.TabIndex = 4;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(12, 415);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(190, 24);
            this.materialLabel1.TabIndex = 5;
            this.materialLabel1.Text = "Lost your password ?";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(439, 415);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(80, 24);
            this.materialLabel2.TabIndex = 6;
            this.materialLabel2.Text = "Register";
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(561, 472);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialDivider1);
            this.Controls.Add(this.Btnlogin);
            this.Controls.Add(this.Mtcheckbox);
            this.Controls.Add(this.Mtpassword);
            this.Controls.Add(this.Mtuser);
            this.ForeColor = System.Drawing.Color.DarkGray;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField Mtuser;
        private MaterialSkin.Controls.MaterialSingleLineTextField Mtpassword;
        private MaterialSkin.Controls.MaterialCheckBox Mtcheckbox;
        private MaterialSkin.Controls.MaterialRaisedButton Btnlogin;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
    }
}

