
namespace Actividad_1_Parcial_2.Formas
{
    partial class FormEcuacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonEcuacion = new System.Windows.Forms.Button();
            this.textValorA = new System.Windows.Forms.TextBox();
            this.textValorB = new System.Windows.Forms.TextBox();
            this.textValorC = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(113, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(612, 49);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ecuacion de segundo grado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(244, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 39);
            this.label2.TabIndex = 20;
            this.label2.Text = "Valor A:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(244, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 39);
            this.label3.TabIndex = 22;
            this.label3.Text = "Valor B:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(244, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 39);
            this.label4.TabIndex = 24;
            this.label4.Text = "Valor C:";
            // 
            // buttonEcuacion
            // 
            this.buttonEcuacion.BackColor = System.Drawing.Color.White;
            this.buttonEcuacion.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEcuacion.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.buttonEcuacion.Location = new System.Drawing.Point(331, 330);
            this.buttonEcuacion.Name = "buttonEcuacion";
            this.buttonEcuacion.Size = new System.Drawing.Size(139, 65);
            this.buttonEcuacion.TabIndex = 26;
            this.buttonEcuacion.Text = "Calcular ";
            this.buttonEcuacion.UseVisualStyleBackColor = false;
            this.buttonEcuacion.Click += new System.EventHandler(this.buttonEcuacion_Click);
            // 
            // textValorA
            // 
            this.textValorA.Font = new System.Drawing.Font("Gill Sans MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textValorA.ForeColor = System.Drawing.Color.Black;
            this.textValorA.Location = new System.Drawing.Point(437, 104);
            this.textValorA.Multiline = true;
            this.textValorA.Name = "textValorA";
            this.textValorA.Size = new System.Drawing.Size(98, 42);
            this.textValorA.TabIndex = 29;
            // 
            // textValorB
            // 
            this.textValorB.Font = new System.Drawing.Font("Gill Sans MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textValorB.ForeColor = System.Drawing.Color.Black;
            this.textValorB.Location = new System.Drawing.Point(437, 192);
            this.textValorB.Multiline = true;
            this.textValorB.Name = "textValorB";
            this.textValorB.Size = new System.Drawing.Size(98, 42);
            this.textValorB.TabIndex = 30;
            // 
            // textValorC
            // 
            this.textValorC.Font = new System.Drawing.Font("Gill Sans MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textValorC.ForeColor = System.Drawing.Color.Black;
            this.textValorC.Location = new System.Drawing.Point(437, 273);
            this.textValorC.Multiline = true;
            this.textValorC.Name = "textValorC";
            this.textValorC.Size = new System.Drawing.Size(98, 42);
            this.textValorC.TabIndex = 31;
            // 
            // FormEcuacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Actividad_1_Parcial_2.Properties.Resources.fondo_aqua;
            this.ClientSize = new System.Drawing.Size(800, 485);
            this.Controls.Add(this.textValorC);
            this.Controls.Add(this.textValorB);
            this.Controls.Add(this.textValorA);
            this.Controls.Add(this.buttonEcuacion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormEcuacion";
            this.Text = "FormEcuacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonEcuacion;
        private System.Windows.Forms.TextBox textValorA;
        private System.Windows.Forms.TextBox textValorB;
        private System.Windows.Forms.TextBox textValorC;
    }
}