using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Classes;
using System.Collections;

namespace CRUDArchivos
{
    public partial class Bajas : Form
    {
		bool v = false;
        //String ruta = @"E:\CRUDArchivos\Test.txt";
		String ruta = "";
		ArrayList Registro = new ArrayList();
        int noCuenta = 0;
		DataBase db;
		bool database;


        public Bajas(String ruta)
        {
            InitializeComponent();
            this.ruta = ruta;
			Registro = CRUDArchivos.Registro.LlenarRegistros(ruta);
			database = false;
        }

		public Bajas(DataBase dbp)
		{
			InitializeComponent();
			db = dbp;
			Registro = CRUDArchivos.Registro.LlenarRegistros(db);
			database = true;
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

        private void llenarComboiBox(string clave) {
            comboBox1.Items.Clear();
			for (int i = 0; i < Registro.Count; i++) {
				if (((Registro)Registro[i]).noCuenta.ToString().Contains(clave))
					comboBox1.Items.Add(((Registro)Registro[i]).noCuenta);
			}
            comboBox1.Select(comboBox1.Text.Length,comboBox1.Text.Length);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
			//String[] Archivo = Archivos.leerArchivo (ruta);

			if (v == false) {


				for (int i = 0; i < Registro.Count; i++) {
					if (((Registro)Registro [i]).noCuenta == Convert.ToInt32 (comboBox1.Text)) {
						labelNombre.Text = ((Registro)Registro [i]).nombre;
                        //comboBox1.Text = ((Registro)Registro [i]).noCuenta.ToString ();
                        noCuenta = ((Registro)Registro[i]).noCuenta;

                        v = true;
					}
				}
			}
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
			if (v == false)
           	 llenarComboiBox(comboBox1.Text);

        }

		/*
        private void BorrarRegistros()
        {
            contregistros = 0;
            String[] Archivo = Archivos.leerArchivo(ruta);
            int pos = -1;


            for (int i = 0; i < Archivo.Length; i++)
            {
                if (Registro[i].Nocuenta == Convert.ToInt32(comboBox1.Text))
                    pos = i;
             }
            if (pos != -1)
            {
                contregistros = 0;
                for (int i = pos; i < Registro.Length - 1; i++)
                {
                    Registro[i].Nocuenta = Registro[i+1].Nocuenta;
                    Registro[i].Nombre = Registro[i+1].Nombre;
                    Registro[i].direccion = Registro[i+1].direccion;
                    Registro[i].telefono = Registro[i+1].telefono;
                    Registro[i].correo = Registro[i+1].correo;
                    if (Registro[i].Nombre != null)
                        contregistros++;
                }
            }
        }

       */

        private void Bajas_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (!database)
            {
                Registro = borrarRegistros(Registro, comboBox1, noCuenta);
                Archivos.escribirArchivo(ruta, CRUDArchivos.Registro.StructToString(this.Registro));
                Registro = CRUDArchivos.Registro.LlenarRegistros(ruta);
                v = false;
                labelNombre.Text = "-";
                llenarComboiBox(comboBox1.Text);
            }
            else
            {
                Registro = borrarRegistros(Registro, comboBox1, noCuenta,db);
                Registro = CRUDArchivos.Registro.LlenarRegistros(db);
                v = false;
                labelNombre.Text = "-";
                llenarComboiBox(comboBox1.Text);
            }
        }

		public static ArrayList borrarRegistros(ArrayList arreglo, ComboBox c, int noCuenta){
			int pos = CRUDArchivos.Registro.buscar (noCuenta, arreglo);
			if (pos >= 0) {
				arreglo.RemoveAt (pos);
				c.Text = "";


			}
			else
				MessageBox.Show("No existe el registro");
			return arreglo;
		}

        public static ArrayList borrarRegistros(ArrayList arreglo, ComboBox c, int noCuenta, DataBase dbp)
        {
            int pos = CRUDArchivos.Registro.buscar(noCuenta, arreglo);
            if (pos >= 0)
            {
                Console.WriteLine(dbp.baja("noCuenta", noCuenta.ToString(), "AlumnosIng"));
                c.Text = "";


            }
            else
                MessageBox.Show("No existe el registro");
            return arreglo;
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

        bool terminate = false;
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            terminate = true;
            System.Windows.Forms.Application.Exit();
        }

        private void Bajas_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!terminate)
            {
                Form1 f = new Form1();
                f.Show();
            }
        }
    }
}
