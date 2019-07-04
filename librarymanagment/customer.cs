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
    public partial class customer : MaterialSkin.Controls.MaterialForm

    {
        private library_managmentEntities3 _context;

        customerInfo custom;

        public customer()
        {
            this._context = new library_managmentEntities3();

            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.LightBlue400, MaterialSkin.Primary.Grey900, MaterialSkin.Primary.BlueGrey500, MaterialSkin.Accent.LightBlue700, MaterialSkin.TextShade.WHITE);
        }

        private void Btnadd_Click(object sender, EventArgs e)
        {
            customerInfo cm = new customerInfo
            {
                Name = Txtname.Text,
                Surname=Txtsurname.Text,
                Email=Txtemail.Text,
                Phone=Txtphone.Text

        };
            this._context.customerInfos.Add(cm);
            this._context.SaveChanges();
            MessageBox.Show("Customer Add");
        }

        public void customerlist()
        {
            Dgvcustom.Rows.Clear();

            List<customerInfo> csm = this._context.customerInfos.ToList();
              
            foreach (customerInfo item in csm)
            {
                Dgvcustom.Rows.Add(item.id, item.Name, item.Surname, item.Email, item.Phone);
            }
        }

        private void Btnlist_Click(object sender, EventArgs e)
        {
            customerlist();
        }

        private void Dgvcustom_RowDividerDoubleClick(object sender, DataGridViewRowDividerDoubleClickEventArgs e)
        {
            Btndelete.Visible = true;
            Btnupdate.Visible = true;

            int customid = Convert.ToInt32(Dgvcustom.Rows[e.RowIndex].Cells[0].Value);
            custom = _context.customerInfos.Find(customid);
            Txtna.Text = custom.Name;
            Txtsu.Text = custom.Surname;
            Txtemail.Text = custom.Email;
            Txtph.Text = custom.Phone;
        }

        private void Btndelete_Click(object sender, EventArgs e)
        {
            _context.customerInfos.Remove(custom);
            _context.SaveChanges();
            customerlist();
        }

        private void Btnupdate_Click(object sender, EventArgs e)
        {
            custom.Name = Txtna.Text;
            custom.Surname = Txtsu.Text;
            custom.Email = Txtem.Text;
            custom.Phone = Txtph.Text;
            customerlist();
        }
    }
}
