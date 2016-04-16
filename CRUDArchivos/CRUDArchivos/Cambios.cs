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
    public partial class Cambios : Form
    {
		bool database;
		DataBase db;

        String ruta = "";
        ArrayList Registro = new ArrayList();
        TextBox[] t;

        public Cambios(String ruta)
        {
            InitializeComponent();
            this.ruta = ruta;
            llenarTXT();
            Registro = CRUDArchivos.Registro.LlenarRegistros(ruta);
			database = false;
        }

        public Cambios(DataBase dbp)
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

        private void vaciarTextBox()
        {
            for (int i = 0; i < t.Length; i++)
                t[i].Text = "";
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
                    for (int j = 0; j < t.Length; j++)
                        t[j].Enabled = true;
                }
            }
            if (existe == false)
                MessageBox.Show("No se encontró el registro");
        }

        private void bGuardar_Click(object sender, EventArgs e)
        {
            int cont = 0;
            //Valida si todos los textbox tienen información, en caso contrario los pone en rojo
            for (int i = 0; i < t.Length; i++)
            {
                if (t[i].Text == "")
                {
                    t[i].BackColor = Color.Red;
                    cont++;
                }
            }
            if (cont > 0)
                MessageBox.Show("Llena los campos en rojo");
            //Cuado estan llenos los campos contin[ua el proceso
            else
            {
                
                int posicion = CRUDArchivos.Registro.buscar(Convert.ToInt32(Txt_NoCuenta.Text), Registro);
                if (posicion != -1)
                {
                    #region archivos

                    if (!database)
                    {
                        ((Registro)Registro[posicion]).correo = Txt_Correo.Text;
                        ((Registro)Registro[posicion]).direccion = Txt_Direccion.Text;
                        ((Registro)Registro[posicion]).nombre = Txt_Nombre.Text;
                        ((Registro)Registro[posicion]).telefono = Txt_Telefono.Text;
                        Archivos.escribirArchivo(ruta, CRUDArchivos.Registro.StructToString(this.Registro));
                        Registro = CRUDArchivos.Registro.LlenarRegistros(ruta);
                    }
                    #endregion
                    #region database
                    else
                    {
                        ArrayList columns = new ArrayList();
                        columns.Add("nombre");
                        columns.Add("direccion");
                        columns.Add("telefono");
                        columns.Add("correo");
                        ArrayList values = new ArrayList();
                        values.Add(Txt_Nombre.Text);
                        values.Add(Txt_Direccion.Text);
                        values.Add(Txt_Telefono.Text);
                        values.Add(Txt_Correo.Text);
                        Console.WriteLine(db.update(columns, values, "noCuenta", Txt_NoCuenta.Text, "AlumnosIng"));
                        Registro = CRUDArchivos.Registro.LlenarRegistros(db);
                    }



                    #endregion
                    vaciarTextBox();
                    
                    for (int j = 0; j < t.Length; j++)
                        t[j].Enabled = false;
                    Txt_NoCuenta.Enabled = true;
                    

                }
                else
                    MessageBox.Show("No existe el registro");

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

        private void Cambios_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!terminate)
            {
                Form1 f = new Form1();
                f.Show();
            }
        }
    }
}
