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
using librarymanagment.Models;

namespace librarymanagment
{
    public partial class srch : MaterialSkin.Controls.MaterialForm
    {
        SqlConnection con = new SqlConnection(@"Server=DESKTOP-DFSVU7E\MSSQLSERVER02;Database=library_managment;Trusted_Connection=True;");

        private library_managmentEntities5 _context;
        public srch()
        {
            this._context = new library_managmentEntities5();
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.LightBlue400, MaterialSkin.Primary.Grey900, MaterialSkin.Primary.BlueGrey500, MaterialSkin.Accent.LightBlue700, MaterialSkin.TextShade.WHITE);
        }

        private void Mtsrch_Click(object sender, EventArgs e)
        {
            int i = 0;
            con.Open();
            SqlCommand cm = con.CreateCommand();
            cm.CommandType = CommandType.Text;
            cm.CommandText = "SELECT  * FROM booksInfo WHERE books_name like('%" + Txtsearch.Text + "%')";
            cm.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cm);
            da.Fill(dt);
            i = Convert.ToInt32(dt.Rows.Count.ToString());
            Dgvsearch.DataSource = dt;
         

            con.Close();
            if (i == 0)
            {
                MessageBox.Show("Book not found");
            }
        }
       

        private void Srch_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Srch_FormClosed_1(object sender, FormClosedEventArgs e)
        {

        }
    }
}
