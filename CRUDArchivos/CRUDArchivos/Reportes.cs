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
    public partial class Reportes : Form
    {
        String ruta = "";
        bool terminate = false;
        ArrayList Registro = new ArrayList();
		DataBase db;
		bool database;

        public Reportes(String ruta)
        {
            InitializeComponent();
            this.ruta = ruta;
            Registro = CRUDArchivos.Registro.LlenarRegistros(ruta);
			database = false;
        }
        public Reportes(DataBase dbp)
        {
            InitializeComponent();
            db =dbp;
            Registro = CRUDArchivos.Registro.LlenarRegistros(db);
            database = true;
        }

        private void Reportes_Load(object sender, EventArgs e)
        {

            for (int i = 0; i < Registro.Count; i++)
            {
                object[] t = new object[5];
                t[0] = ((Registro)Registro[i]).noCuenta;
                t[1] = ((Registro)Registro[i]).nombre;
                t[2] = ((Registro)Registro[i]).direccion;
                t[3] = ((Registro)Registro[i]).telefono;
                t[4] = ((Registro)Registro[i]).correo;

                dataGridView1.Rows.Add(t);
            }
           
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

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultas cam;
            if (database)
            {
                cam = new Consultas(db);
            }
            else
                cam = new Consultas(ruta);
            cam.Show();
            this.Hide();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            terminate = true;
            System.Windows.Forms.Application.Exit();
        }

        private void Reportes_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!terminate)
            {
                Form1 f = new Form1();
                f.Show();
            }
        }
    }
}
