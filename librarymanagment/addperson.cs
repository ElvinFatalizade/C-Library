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
    public partial class addperson : MaterialSkin.Controls.MaterialForm
    {
       

        private library_managmentEntities5 _context;

        person_infos selectedperson;

        public addperson()
        {
            this._context = new library_managmentEntities5();
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.LightBlue400, MaterialSkin.Primary.Grey900, MaterialSkin.Primary.BlueGrey500, MaterialSkin.Accent.LightBlue700, MaterialSkin.TextShade.WHITE);
        }
           
        private void Btnadd_Click(object sender, EventArgs e)
        {
            person_infos pr = new person_infos
            {
                Name = Txtname.Text,
                Surname = Txtsur.Text,
                Email = Txtml.Text,
                Phone = Txtph.Text
            };
            this._context.person_infos.Add(pr);
            this._context.SaveChanges();
            MessageBox.Show("Info Added", MessageBoxButtons.OK.ToString());
           
        }

        public void PersonsView()
        {
            Dgvpr.Rows.Clear();

            List<person_infos> person = this._context.person_infos.ToList();

            foreach (person_infos item in person)
            {
                Dgvpr.Rows.Add(item.id,item.Name, item.Surname, item.Email, item.Phone);

            }

        }

        private void Lbllist_Click(object sender, EventArgs e)
        {
            PersonsView();
        }

        private void Btnupdate_Click(object sender, EventArgs e)
        {
            selectedperson.Name = Txtn.Text;
            selectedperson.Surname = Txts.Text;
            selectedperson.Email = Txte.Text;
            selectedperson.Phone = Txtp.Text;
            _context.SaveChanges();

            PersonsView();

        }


        private void Dgvpr_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            Btndelete.Visible = true;
            Btnupdate.Visible = true;

            int idperson = Convert.ToInt32(Dgvpr.Rows[e.RowIndex].Cells[0].Value);
            selectedperson = _context.person_infos.Find(idperson);
            Txtn.Text = selectedperson.Name;
            Txts.Text = selectedperson.Surname;
            Txte.Text = selectedperson.Email;
            Txtp.Text = selectedperson.Phone;
        }

        private void Btndelete_Click(object sender, EventArgs e)
        {
            _context.person_infos.Remove(selectedperson);
            _context.SaveChanges();
            PersonsView();
        }
    }
}
