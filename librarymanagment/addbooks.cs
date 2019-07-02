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
    public partial class addbooks : MaterialSkin.Controls.MaterialForm
    {
       private  library_managmentEntities2 _context;
       
        public addbooks()
        {
            this._context = new library_managmentEntities2 ();
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Blue800, MaterialSkin.Primary.Grey900, MaterialSkin.Primary.BlueGrey500, MaterialSkin.Accent.LightBlue700, MaterialSkin.TextShade.WHITE);
        
        }

        private void Addbooks_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

       

        private void Txtbookname(object sender, EventArgs e)
        {

        }

        private void MaterialFlatButton1_Click(object sender, EventArgs e)
        {
             booksInfo bk=new booksInfo
            {
                
                books_name = Txtbkname.Text,
                books_author_name = Txtbkauthor.Text,
                books_publication_date = Txtbkpb.Value,
                books_price = Convert.ToInt32(Txtbkprice.Text.ToString()),
                books_quantity = Convert.ToInt32(Txtbkquantity.Text.ToString())
              
                
             };
                 
             
             this._context.booksInfoes.Add(bk);
             this._context.SaveChanges();
            MessageBox.Show("Book added", MessageBoxButtons.OK.ToString());

        }

       
                   

        private void MaterialFlatButton2_Click(object sender, EventArgs e)
        {
            Dgvlist.Rows.Clear();

            List<booksInfo> bkinfo = this._context.booksInfoes.ToList();
           
            foreach (booksInfo item in bkinfo)
            {
                Dgvlist.Rows.Add(item.books_name, item.books_author_name, item.books_publication_date, item.books_price, item.books_quantity);
               

            }
           

        }
    }
}
