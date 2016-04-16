using System;
using System.Drawing;
using System.Windows.Forms;
using Classes;
using System.Collections;

namespace CRUDArchivos
{
    public partial class Altas : Form
    {

		TextBox[] t;
        //String ruta = @"E:\CRUDArchivos\Test.txt";
		string ruta = "/home/alexis/Desktop/CRUDArchivos v2/Test.txt";
        int contregistros = 0;
		ArrayList Registro = new ArrayList();
		DataBase db;
		bool database;


        public Altas(string ruta)
        {
            InitializeComponent();
            this.ruta = ruta;
            llenarTXT();
			Registro = CRUDArchivos.Registro.LlenarRegistros(ruta);
			database = false;
        }
		public Altas(DataBase dbp)
		{
			InitializeComponent();
			this.db = dbp;
			llenarTXT();
			//Registro = CRUDArchivos.Registro.LlenarRegistros(dbp);
			database = true;
		}
        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void b_Aceptar_Click(object sender, EventArgs e)
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

				if (!database) {
					int posicion = 0;
//Valida que no exista el numero de cuenta y si existe guarda la posici[on en la que se encuentra o permanece en menos 1 si no la encuentra
					posicion = CRUDArchivos.Registro.buscar (Convert.ToInt32 (Txt_NoCuenta.Text), Registro);
					if (posicion == -1) {
						Registro temp = new CRUDArchivos.Registro ();
						temp.noCuenta = Convert.ToInt32 (Txt_NoCuenta.Text);
						temp.nombre = Txt_Nombre.Text;
						temp.telefono = Txt_Telefono.Text;
						temp.direccion = Txt_Direccion.Text;
						temp.correo = Txt_Correo.Text;
						Registro.Add (temp);
						contregistros++;
						vaciarTextBox ();
						Archivos.escribirArchivo (ruta, CRUDArchivos.Registro.StructToString (this.Registro));
						Registro = CRUDArchivos.Registro.LlenarRegistros (ruta);
					} else {
						MessageBox.Show ("Ya existe el registro");
					}
				} else {
					ArrayList values = new ArrayList ();
					values.Add (Convert.ToInt32 (Txt_NoCuenta.Text));
					values.Add (Txt_Nombre.Text);
					values.Add (Txt_Direccion.Text);
					values.Add (Txt_Telefono.Text);
					values.Add (Txt_Correo.Text);
					String res = db.insert ("AlumnosIng", values);
					if ( res == "") {
						MessageBox.Show ("Alta exitosa");
						vaciarTextBox ();
					}else
						MessageBox.Show ("error "+res);


				}
           }
        }

//crea un arreglo con todos los text box de la forma 
        private void llenarTXT()
        {
           t = new TextBox[] { Txt_Correo, Txt_Direccion, Txt_NoCuenta, Txt_Nombre, Txt_Telefono };
        }

        private void Altas_Load(object sender, EventArgs e)
        {
        }

        private void Txt_Nombre_TextChanged(object sender, EventArgs e)
        {
            Txt_Nombre.BackColor = Color.White;
        }

        private void Txt_NoCuenta_TextChanged(object sender, EventArgs e)
        {
            Txt_NoCuenta.BackColor = Color.White;
        }

        private void Txt_Direccion_TextChanged(object sender, EventArgs e)
        {
            Txt_Direccion.BackColor = Color.White;
        }

        private void Txt_Telefono_TextChanged(object sender, EventArgs e)
        {
            Txt_Telefono.BackColor = Color.White;
        }

        private void Txt_Correo_TextChanged(object sender, EventArgs e)
        {
            Txt_Correo.BackColor = Color.White;
        }

//Lee el archivo para llenar el arraylist inicial ignorando los rnglones que unicamente contengan la cadena "\n"
		/*
		public static ArrayList LlenarRegistros(String path)
        {
			ArrayList res = new ArrayList ();
            //contregistros = 0;
            String[] Archivo = Archivos.leerArchivo(path);
            for (int i = 0; i < Archivo.Length; i++) {
                //obtenemos cada palabra
                if (Archivo[i] != "\n")
                {
                    String[] temp = ProcesamientoTexto.renglonAPalabras(Archivo[i], '|');
					Registro contenedor = new Registro ();
					contenedor.noCuenta = Convert.ToInt32(temp[0]);
                    contenedor.nombre = temp[1];
                    contenedor.direccion = temp[2];
                    contenedor.telefono = temp[3];
                    contenedor.correo = temp[4];
                    //contregistros++;
					res.Add (contenedor);
                }
            }
			return res;
        }
*/

		/*
		public static Registro[] arrayListToRegistroArray(ArrayList array){
			CRUDArchivos.Registro[] r = new CRUDArchivos.Registro[array.Count];

			for (int i = 0; i < array.Count; i++) {
				r [i] = new CRUDArchivos.Registro ();
				r [i].correo = ((Registro)array [i]).correo;
				r [i].direccion = ((Registro)array [i]).direccion;
				r [i].noCuenta = ((Registro)array [i]).noCuenta;
				r [i].nombre = ((Registro)array [i]).nombre;
				r [i].telefono = ((Registro)array [i]).telefono;
			}
			return r;
		}
*/
		/*
//Convierte el array list en arreglo de registros para buscar si existe el numero de cuenta

		public static int buscar(int noCuenta, ArrayList array)
        {
			Registro[] r =CRUDArchivos.Registro.arrayListToRegistroArray (array);
            int posicion = -1;
            for (int i = 0; i < r.Length; i++)
            {
                if (r[i].noCuenta == noCuenta)
					posicion = i;
            }
            return posicion;
         }
		*/
        private void vaciarTextBox() {

            for (int i = 0; i < t.Length; i++)
            {
                t[i].Text = "";
            }

        }

		/*
		public static String[] StructToString(ArrayList array) {
			Registro[] r =arrayListToRegistroArray (array);
			string[] res = new String[Registro.Count];

            for (int i = 0; i < contregistros; i++) {

				res [i] = r [i].ToString ();
            }
            return res;
        }*/

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

        private void Altas_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!terminate)
            {
                Form1 f = new Form1();
                f.Show();
            }
        }
    }
}
