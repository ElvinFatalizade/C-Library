using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using librarymanagment.Models;
using System.Data.SqlClient;

namespace librarymanagment
{
    public partial class customeissue : MaterialSkin.Controls.MaterialForm

    {
        SqlConnection con = new SqlConnection(@"Server=DESKTOP-DFSVU7E\MSSQLSERVER02;Database=library_managment;Trusted_Connection=True;");
        private library_managmentEntities5 context;

        public customeissue()
        {

            context = new library_managmentEntities5();

            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.LightBlue400, MaterialSkin.Primary.Grey900, MaterialSkin.Primary.BlueGrey500, MaterialSkin.Accent.LightBlue700, MaterialSkin.TextShade.WHITE);
        }

        private void TextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btnad_Click(object sender, EventArgs e)
        {
            customerissue csm = new customerissue
            {
                customer_name = Txt1.Text,
                customer_surname = Txt2.Text,
                Customer_email = Txt3.Text,
                customer_phone = Txt4.Text,
                book_name = Txt5.Text,
                book_issue_date = Dt6.Value,
                book_price = Convert.ToInt32(Txt7.Text),
                customer_enrollment_no=Txtenrollment.Text
                
                
            };
            context.customerissues.Add(csm);
            context.SaveChanges();
            MessageBox.Show("Info add");
        }

        private void Txt5_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ListBox1_KeyUp(object sender, KeyEventArgs e)
        {
            int count = 0;


            if(e.KeyCode != Keys.Enter)
            {

                con.Open();
                SqlCommand cm = con.CreateCommand();
                cm.CommandType = CommandType.Text;
                cm.CommandText = "SELECT  * FROM booksInfo WHERE books_name like('%" + Txt5.Text + "%')";
                cm.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cm);
                da.Fill(dt);
                count = Convert.ToInt32(dt.Rows.Count.ToString());

                if (count > 0)
                {
                    listBox1.Visible = true;
                    foreach (DataRow dr in dt.Rows)
                    {
                        listBox1.Items.Add(dr["books_name"].ToString());
                    }
                }


                con.Close();

            }


         
          
        }

        private void Btnsearch_Click(object sender, EventArgs e)
        {
            int i = 0;
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM customerissue WHERE customer_enrollment_no='" + textBox1.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            i = Convert.ToInt32(dt.Rows.Count.ToString());
           
                if (i == 0)
                {
                    MessageBox.Show("This enrollmet not found");
                }
                else
                {
                  foreach(DataRow dr in dt.Rows)
                    {
                        Txt1.Text = dr["customer_name"].ToString();
                        Txt2.Text = dr["customer_surname"].ToString();
                    Txt3.Text = dr["Customer_email"].ToString();
                    Txt4.Text = dr["customer_phone"].ToString();
                   


                    }
                }
            con.Close();
            }
        
        }
    }

