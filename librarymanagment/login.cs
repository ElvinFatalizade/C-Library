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


namespace librarymanagment
{
    public partial class login : MaterialSkin.Controls.MaterialForm
    {
        SqlConnection con = new SqlConnection(@"Server=DESKTOP-DFSVU7E\MSSQLSERVER02; Database=library_managment;Trusted_Connection=True;");
        int count = 0;
        public login()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Green800, MaterialSkin.Primary.Grey900, MaterialSkin.Primary.BlueGrey500, MaterialSkin.Accent.LightBlue700, MaterialSkin.TextShade.WHITE);
        }

        private void Btnlogin_Click(object sender, EventArgs e)
        {
            
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT  * FROM login WHERE Username='" + Mtuser.Text + "' and Password='" + Mtpassword.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            count = Convert.ToInt32(dt.Rows.Count.ToString());

            if (count == 0)
            {
                MessageBox.Show("Username or Password incorrect");
            }
            else
            {
                users us = new users();
                us.Show();
                this.Hide();

            }
           
        }

        private void Login_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
        }
    }
}
