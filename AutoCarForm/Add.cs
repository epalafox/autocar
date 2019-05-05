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
    public partial class Add : Form
    {
        private Main _previous;
        public Add(Main previous)
        {
            _previous = previous;
            InitializeComponent();
        }

        private void evGuardar(object sender, EventArgs e)
        {
            var Errores = new List<string>();
            var valido = true;
            if(
                string.IsNullOrEmpty(tbDoors.Text) ||
                string.IsNullOrEmpty(tbBrand.Text) ||
                string.IsNullOrEmpty(tbExtColor.Text) ||
                string.IsNullOrEmpty(tbIntColor.Text) ||
                string.IsNullOrEmpty(tbKm.Text) ||
                string.IsNullOrEmpty(tbLiters.Text) ||
                string.IsNullOrEmpty(tbModel.Text) ||
                string.IsNullOrEmpty(tbPrice.Text) ||
                string.IsNullOrEmpty(tbYear.Text)
                )
            {
                Errores.Add("Todos los campos son requeridos");
                valido = false;
            }
            if(!int.TryParse(tbDoors.Text, out var doors))
            {
                Errores.Add("Las puertas deben ser un valor entero");
                valido = false;
            }
            if (!int.TryParse(tbKm.Text, out var km))
            {
                Errores.Add("El Km debe ser un valor entero");
                valido = false;
            }
            if (!float.TryParse(tbLiters.Text, out var liters))
            {
                Errores.Add("Los litros deben ser un valor decimal");
                valido = false;
            }
            if (!float.TryParse(tbPrice.Text, out var price))
            {
                Errores.Add("El precio debe ser un valor decimal");
                valido = false;
            }
            if (!int.TryParse(tbYear.Text, out var year))
            {
                Errores.Add("El año debe ser un valor entero");
                valido = false;
            }
            if(valido)
            {
                var nuevoAuto = new Auto
                {
                    Brand = tbBrand.Text,
                    Doors = int.Parse(tbDoors.Text),
                    ExtColor = tbExtColor.Text,
                    IntColor = tbIntColor.Text,
                    Km = int.Parse(tbKm.Text),
                    Liters = float.Parse(tbLiters.Text),
                    Model = tbModel.Text,
                    Price = float.Parse(tbPrice.Text),
                    Year = int.Parse(tbYear.Text)
                };
                IDatabase database = LiteDBDatabase.GetInstance();
                database.InsertAuto(nuevoAuto);
                _previous.LoadData();
                Close();
            }
            else
            {
                MessageBox.Show(string.Join(System.Environment.NewLine, Errores),
                        "Datos Invalidos",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
