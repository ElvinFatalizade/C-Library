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


namespace librarymanagment
{
    public partial class customeissue : MaterialSkin.Controls.MaterialForm

    {

       
     
        private library_managmentEntities5 context;

        customerissue cs;

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
               
                
                
            }; 
            context.customerissues.Add(csm);
            context.SaveChanges();
            MessageBox.Show("Info add");
        }


        private void Btnsearch_Click(object sender, EventArgs e)
        {
        }

        public void custom()
        {
            Dgvlist.Rows.Clear();

            List<customerissue> issue = this.context.customerissues.ToList();

            foreach (customerissue item in issue)
            {

                Dgvlist.Rows.Add(item.id, item.customer_name, item.customer_surname, item.Customer_email, item.customer_phone, item.book_name, item.book_issue_date, item.book_price);


            }
        }

        private void Btnlist_Click(object sender, EventArgs e)
        {
            custom();
           
        }

        private void Dgvlist_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int idcustom = Convert.ToInt32(Dgvlist.Rows[e.RowIndex].Cells[0].Value);
            cs = context.customerissues.Find(idcustom);
            lblname.Text = cs.customer_name;
            lblemail.Text = cs.Customer_email;
            lblphone.Text = cs.customer_phone;
            lblbookname.Text = cs.book_name;
            lblissuedate.Text = cs.book_issue_date.ToString();
            lblbookprice.Text = cs.book_price.ToString();
            
            
        }

        private void Btnreturn_Click(object sender, EventArgs e)
        {
            
        }

    }
    }

