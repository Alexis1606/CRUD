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
    public partial class Form1 : Form
    {
        TextBox[] t;
        bool terminate = false;
        string ruta = "";
        DataBase db;
        public Form1()

        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            menuStrip1.Enabled = false;

            if (radioButton1.Checked == false) {
                Txt_DB.Enabled = false;
                Txt_Pass.Enabled = false;
                Txt_SErvidor.Enabled = false;
                Txt_Usuario.Enabled = false;

            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void altasToolStripMenuItem_Click(object sender, EventArgs e)
        {

			Altas a ;
			if (radioButton1.Checked) {
				//MessageBox.Show ("Creating form");
				a = new Altas (db);
			}
			else
				a = new Altas(ruta);
			//MessageBox.Show ("Form created");
			a.Show();
			this.Hide();



        }

		private void bajasToolStripMenuItem_Click(object sender, EventArgs e)
        {
			Bajas b ;
			if (radioButton1.Checked) {
				MessageBox.Show ("Creating form");
				b = new Bajas (db);
			}
			else
				b = new Bajas(ruta);
			MessageBox.Show ("Form created");
			b.Show();
			this.Hide();

        }

        private void BRuta_Click(object sender, EventArgs e)
        {


            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                TRuta.Text = openFileDialog1.InitialDirectory + openFileDialog1.FileName;
            }


        }

        private void TRuta_TextChanged(object sender, EventArgs e)
        {
            ArrayList Registro = new ArrayList();
            menuStrip1.Enabled = false;
            ruta = TRuta.Text;
            try
            {

                Registro = CRUDArchivos.Registro.LlenarRegistros(ruta);
                menuStrip1.Enabled = true;
            } catch {
                MessageBox.Show("El archivo no tiene el formato adecuado");
            }
            
        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultas c;
            if (radioButton1.Checked)
            {
                MessageBox.Show("Creating form");
                c = new Consultas(db);
            }
            else
                c = new Consultas(ruta);
            MessageBox.Show("Form created");
            c.Show();
            this.Hide();

        }

        private void cambiosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cambios c;
            if (radioButton1.Checked)
            {
                MessageBox.Show("Creating form");
                c = new Cambios(db);
            }
            else
                c = new Cambios(ruta);
            MessageBox.Show("Form created");
            c.Show();
            this.Hide();
        }

        private void reporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes r;
            if (radioButton1.Checked)
            {
                MessageBox.Show("Creating form");
                r = new Reportes(db);
            }
            else
                r = new Reportes(ruta);
            MessageBox.Show("Form created");
            r.Show();
            this.Hide();
        }

        private void salirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            terminate = true;
            System.Windows.Forms.Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void RArchivo_CheckedChanged(object sender, EventArgs e)
        {
            TRuta.Text = "";
            bloquearTextBox();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            bloquearTextBox();
        }

        public void bloquearTextBox()
        {
            menuStrip1.Enabled = false;

            if (radioButton1.Checked)
            {
                Txt_DB.Enabled = true;
                Txt_Pass.Enabled = true;
                Txt_SErvidor.Enabled = true;
                Txt_Usuario.Enabled = true;
                BRuta.Enabled = false;
                rMySQL.Enabled = true;
                rSQL.Enabled = true;
            }
            else
            {
                Txt_DB.Enabled = false;
                Txt_Pass.Enabled = false;
                Txt_SErvidor.Enabled = false;
                Txt_Usuario.Enabled = false;
                menuStrip1.Enabled = false;
                BRuta.Enabled = true;
                rMySQL.Enabled = false;
                rSQL.Enabled = false;

            }
        }

        private void llenarTXT()
        {
            t = new TextBox[] { Txt_DB, Txt_Pass, Txt_SErvidor, Txt_Usuario };
        }


        //Prueba la conexión a la base de datos
        //En caso de una conexi[on exitosa activa el menustrip1
        private void Btn_Validar_Click(object sender, EventArgs e)
        {
            string serverType = "";
            int cont = 0;
            llenarTXT();
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

            if (Txt_DB.Text != "" && Txt_Pass.Text != "" && Txt_SErvidor.Text != "" && Txt_Usuario.Text != "")
            {
                if (rMySQL.Checked)
                    serverType = "MySQL";
                else if (rSQL.Checked)
                    serverType = "SQL";

                menuStrip1.Enabled = true;
                db = new DataBase(serverType, Txt_Usuario.Text, Txt_Pass.Text, Txt_SErvidor.Text, Txt_DB.Text);

                if (db.conectar())
                {
                    MessageBox.Show("Conexión exitosa");
                    menuStrip1.Enabled = true;
                }
                else
                    MessageBox.Show("Conexión fallida");
            }

        }

        private void Txt_SErvidor_TextChanged(object sender, EventArgs e)
        {
            Txt_SErvidor.BackColor = Color.White;
        }

        private void Txt_DB_TextChanged(object sender, EventArgs e)
        {
            Txt_DB.BackColor = Color.White;
        }

        private void Txt_Usuario_TextChanged(object sender, EventArgs e)
        {
            Txt_Usuario.BackColor = Color.White;
        }

        private void Txt_Pass_TextChanged(object sender, EventArgs e)
        {
            Txt_Pass.BackColor = Color.White;
        }
    }
}
