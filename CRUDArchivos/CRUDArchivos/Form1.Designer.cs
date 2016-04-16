namespace CRUDArchivos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.altasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bajasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            this.RArchivo = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.TRuta = new System.Windows.Forms.TextBox();
            this.BRuta = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rMySQL = new System.Windows.Forms.RadioButton();
            this.rSQL = new System.Windows.Forms.RadioButton();
            this.Txt_DB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_Pass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_Usuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_SErvidor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Validar = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altasToolStripMenuItem,
            this.bajasToolStripMenuItem,
            this.cambiosToolStripMenuItem,
            this.reporteToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(568, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // altasToolStripMenuItem
            // 
            this.altasToolStripMenuItem.Name = "altasToolStripMenuItem";
            this.altasToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.altasToolStripMenuItem.Text = "Altas";
            this.altasToolStripMenuItem.Click += new System.EventHandler(this.altasToolStripMenuItem_Click);
            // 
            // bajasToolStripMenuItem
            // 
            this.bajasToolStripMenuItem.Name = "bajasToolStripMenuItem";
            this.bajasToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.bajasToolStripMenuItem.Text = "Bajas";
            this.bajasToolStripMenuItem.Click += new System.EventHandler(this.bajasToolStripMenuItem_Click);
            // 
            // cambiosToolStripMenuItem
            // 
            this.cambiosToolStripMenuItem.Name = "cambiosToolStripMenuItem";
            this.cambiosToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cambiosToolStripMenuItem.Text = "Cambios";
            this.cambiosToolStripMenuItem.Click += new System.EventHandler(this.cambiosToolStripMenuItem_Click);
            // 
            // reporteToolStripMenuItem
            // 
            this.reporteToolStripMenuItem.Name = "reporteToolStripMenuItem";
            this.reporteToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.reporteToolStripMenuItem.Text = "Reporte";
            this.reporteToolStripMenuItem.Click += new System.EventHandler(this.reporteToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            this.consultasToolStripMenuItem.Click += new System.EventHandler(this.consultasToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click_1);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.RArchivo);
            this.panel2.Controls.Add(this.radioButton1);
            this.panel2.Controls.Add(this.TRuta);
            this.panel2.Controls.Add(this.BRuta);
            this.panel2.Location = new System.Drawing.Point(37, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(441, 94);
            this.panel2.TabIndex = 27;
            // 
            // RArchivo
            // 
            this.RArchivo.AutoSize = true;
            this.RArchivo.Checked = true;
            this.RArchivo.Location = new System.Drawing.Point(21, 27);
            this.RArchivo.Name = "RArchivo";
            this.RArchivo.Size = new System.Drawing.Size(106, 17);
            this.RArchivo.TabIndex = 1;
            this.RArchivo.TabStop = true;
            this.RArchivo.Text = "Ruta del archivo ";
            this.RArchivo.UseVisualStyleBackColor = true;
            this.RArchivo.CheckedChanged += new System.EventHandler(this.RArchivo_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(21, 64);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(93, 17);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.Text = "Base de datos";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // TRuta
            // 
            this.TRuta.Enabled = false;
            this.TRuta.Location = new System.Drawing.Point(142, 27);
            this.TRuta.Name = "TRuta";
            this.TRuta.Size = new System.Drawing.Size(226, 20);
            this.TRuta.TabIndex = 2;
            // 
            // BRuta
            // 
            this.BRuta.Location = new System.Drawing.Point(366, 25);
            this.BRuta.Name = "BRuta";
            this.BRuta.Size = new System.Drawing.Size(24, 23);
            this.BRuta.TabIndex = 3;
            this.BRuta.Text = "...";
            this.BRuta.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rMySQL);
            this.panel1.Controls.Add(this.rSQL);
            this.panel1.Location = new System.Drawing.Point(386, 172);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(146, 143);
            this.panel1.TabIndex = 26;
            // 
            // rMySQL
            // 
            this.rMySQL.AutoSize = true;
            this.rMySQL.Enabled = false;
            this.rMySQL.Location = new System.Drawing.Point(12, 56);
            this.rMySQL.Name = "rMySQL";
            this.rMySQL.Size = new System.Drawing.Size(60, 17);
            this.rMySQL.TabIndex = 1;
            this.rMySQL.Text = "MySQL";
            this.rMySQL.UseVisualStyleBackColor = true;
            // 
            // rSQL
            // 
            this.rSQL.AutoSize = true;
            this.rSQL.Checked = true;
            this.rSQL.Enabled = false;
            this.rSQL.Location = new System.Drawing.Point(12, 27);
            this.rSQL.Name = "rSQL";
            this.rSQL.Size = new System.Drawing.Size(80, 17);
            this.rSQL.TabIndex = 0;
            this.rSQL.TabStop = true;
            this.rSQL.Text = "SQL Server";
            this.rSQL.UseVisualStyleBackColor = true;
            // 
            // Txt_DB
            // 
            this.Txt_DB.Location = new System.Drawing.Point(179, 202);
            this.Txt_DB.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_DB.Name = "Txt_DB";
            this.Txt_DB.Size = new System.Drawing.Size(187, 20);
            this.Txt_DB.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 203);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Base de datos";
            // 
            // Txt_Pass
            // 
            this.Txt_Pass.Location = new System.Drawing.Point(179, 264);
            this.Txt_Pass.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_Pass.Name = "Txt_Pass";
            this.Txt_Pass.Size = new System.Drawing.Size(187, 20);
            this.Txt_Pass.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 264);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Password";
            // 
            // Txt_Usuario
            // 
            this.Txt_Usuario.Location = new System.Drawing.Point(179, 227);
            this.Txt_Usuario.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_Usuario.Name = "Txt_Usuario";
            this.Txt_Usuario.Size = new System.Drawing.Size(187, 20);
            this.Txt_Usuario.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 227);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Usuario";
            // 
            // Txt_SErvidor
            // 
            this.Txt_SErvidor.Location = new System.Drawing.Point(179, 172);
            this.Txt_SErvidor.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_SErvidor.Name = "Txt_SErvidor";
            this.Txt_SErvidor.Size = new System.Drawing.Size(187, 20);
            this.Txt_SErvidor.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 172);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Servidor";
            // 
            // Btn_Validar
            // 
            this.Btn_Validar.Location = new System.Drawing.Point(386, 343);
            this.Btn_Validar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Validar.Name = "Btn_Validar";
            this.Btn_Validar.Size = new System.Drawing.Size(98, 22);
            this.Btn_Validar.TabIndex = 28;
            this.Btn_Validar.Text = "Probar conexión";
            this.Btn_Validar.UseVisualStyleBackColor = true;
            this.Btn_Validar.Click += new System.EventHandler(this.Btn_Validar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 376);
            this.Controls.Add(this.Btn_Validar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Txt_DB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Txt_Pass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txt_Usuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txt_SErvidor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem altasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bajasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton RArchivo;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox TRuta;
        private System.Windows.Forms.Button BRuta;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rMySQL;
        private System.Windows.Forms.RadioButton rSQL;
        private System.Windows.Forms.TextBox Txt_DB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_Pass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_Usuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_SErvidor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Validar;
    }
}

