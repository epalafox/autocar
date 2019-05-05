using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer;
namespace AutoCarForm
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            IDatabase database = LiteDBDatabase.GetInstance();
            var autos = database.GetAutos();
            lstAutos.Items.Clear();
            foreach (var auto in autos)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = auto.GetNombre();
                lstAutos.Items.Add(lvi);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var agregar = new Add(this);
            agregar.Show();
        }
    }
}
