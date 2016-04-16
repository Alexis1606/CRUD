using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using Classes;

namespace CRUDArchivos
{
    public partial class Consultas : Form
    {
        String ruta = "";
        ArrayList Registro = new ArrayList();
        TextBox[] t;
		bool database;
		DataBase db;

        public Consultas(String ruta)
        {
            InitializeComponent();
            this.ruta = ruta;
            llenarTXT();
            Registro = CRUDArchivos.Registro.LlenarRegistros(ruta);
			database = false;
        }

        public Consultas(DataBase dbp)
        {
            InitializeComponent();
            db = dbp;
            llenarTXT();
            Registro = CRUDArchivos.Registro.LlenarRegistros(db);
            database = true;
        }

        private void llenarTXT()
        {
            t = new TextBox[] { Txt_Correo, Txt_Direccion, Txt_NoCuenta, Txt_Nombre, Txt_Telefono };
        }

        private void bBuscar_Click(object sender, EventArgs e)
        {
            bool existe = false;
            for (int i = 0; i < Registro.Count; i++)
            {
                if (((Registro)Registro[i]).noCuenta.ToString().Contains(Txt_NoCuenta.Text))
                {
                    Txt_Correo.Text = ((Registro)Registro[i]).correo;
                    Txt_Direccion.Text = ((Registro)Registro[i]).direccion;
                    Txt_Nombre.Text = ((Registro)Registro[i]).nombre;
                    Txt_Telefono.Text = ((Registro)Registro[i]).telefono;
                    existe = true;
                }
             }
            if (existe == false)
                MessageBox.Show("No se encontró el registro");
        }

        private void altasToolStripMenuItem_Click(object sender, EventArgs e)
        {
			Altas a;
			if (!database)
				a = new Altas (ruta);
			else
				a = new Altas (db);
			a.Show();
			this.Hide();
        }

        private void bajasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bajas b;
            if (database)
            {
                b = new Bajas(db);
            }
            else
                b = new Bajas(ruta);
            b.Show();
            this.Hide();
        }

        private void cambiosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cambios cam;
            if (database)
            {
                cam = new Cambios(db);
            }
            else
                cam = new Cambios(ruta);
            cam.Show();
            this.Hide();
        }

        private void reporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes r;
            if (database)
            {
                r = new Reportes(db);
            }
            else
                r = new Reportes(ruta);
            r.Show();
            this.Hide();
        }

        bool terminate = false;
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            terminate = true;
            System.Windows.Forms.Application.Exit();
        }

        private void Consultas_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!terminate)
            {
                Form1 f = new Form1();
                f.Show();
            }
        }
    }
}
