
namespace Actividad_1_Parcial_2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuArea = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPesos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLatidos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSalario = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEcuacion = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(93, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(640, 49);
            this.label1.TabIndex = 6;
            this.label1.Text = "Actividad 1 segundo Parcial";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuArea,
            this.menuPesos,
            this.menuLatidos,
            this.menuSalario,
            this.menuEcuacion});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(799, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuArea
            // 
            this.menuArea.Name = "menuArea";
            this.menuArea.Size = new System.Drawing.Size(128, 20);
            this.menuArea.Text = "Area de un Triangulo";
            this.menuArea.Click += new System.EventHandler(this.menuArea_Click);
            // 
            // menuPesos
            // 
            this.menuPesos.Name = "menuPesos";
            this.menuPesos.Size = new System.Drawing.Size(140, 20);
            this.menuPesos.Text = "Pesos a dolares y euros";
            this.menuPesos.Click += new System.EventHandler(this.menuPesos_Click);
            // 
            // menuLatidos
            // 
            this.menuLatidos.Name = "menuLatidos";
            this.menuLatidos.Size = new System.Drawing.Size(120, 20);
            this.menuLatidos.Text = "Latidos por minuto";
            this.menuLatidos.Click += new System.EventHandler(this.menuLatidos_Click);
            // 
            // menuSalario
            // 
            this.menuSalario.Name = "menuSalario";
            this.menuSalario.Size = new System.Drawing.Size(92, 20);
            this.menuSalario.Text = "Nuevo Salario";
            this.menuSalario.Click += new System.EventHandler(this.menuSalario_Click);
            // 
            // menuEcuacion
            // 
            this.menuEcuacion.Name = "menuEcuacion";
            this.menuEcuacion.Size = new System.Drawing.Size(166, 20);
            this.menuEcuacion.Text = "Ecuacion de segundo grado";
            this.menuEcuacion.Click += new System.EventHandler(this.menuEcuacion_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(64, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(696, 44);
            this.label2.TabIndex = 8;
            this.label2.Text = "Pedro Santiago Mendoza González";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(335, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 44);
            this.label3.TabIndex = 9;
            this.label3.Text = "3 \"PV\"";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Actividad_1_Parcial_2.Properties.Resources.fondo_acuarela;
            this.ClientSize = new System.Drawing.Size(799, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuArea;
        private System.Windows.Forms.ToolStripMenuItem menuPesos;
        private System.Windows.Forms.ToolStripMenuItem menuLatidos;
        private System.Windows.Forms.ToolStripMenuItem menuSalario;
        private System.Windows.Forms.ToolStripMenuItem menuEcuacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

