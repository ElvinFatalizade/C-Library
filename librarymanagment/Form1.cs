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
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    {
        SqlConnection con = new SqlConnection(@"Server=DESKTOP-DFSVU7E\MSSQLSERVER02; Database=librarymanagment;Trusted_Connection=True;");

        public Form1()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Green800, MaterialSkin.Primary.Grey900, MaterialSkin.Primary.BlueGrey500, MaterialSkin.Accent.LightBlue700, MaterialSkin.TextShade.WHITE);
        }

      

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void Btnlogin_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select * From profilemaster WHERE name='" + Mtuser.Text + "' and password='" + Mtpassword.Text + "' ", con);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count==1)
            {
             
                LMS obj = new LMS();
                obj.Show();
                this.Hide();
               
            }
            else
            

            {
                MessageBox.Show("Invalid username or password", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }
    }
}
