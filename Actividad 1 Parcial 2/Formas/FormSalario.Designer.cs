
namespace Actividad_1_Parcial_2.Formas
{
    partial class FormSalario
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
            this.buttonNewSalario = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textSalarioActual = new System.Windows.Forms.TextBox();
            this.textSalarioNuevo = new System.Windows.Forms.TextBox();
            this.textAumento = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(256, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 49);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nuevo Salario";
            // 
            // buttonNewSalario
            // 
            this.buttonNewSalario.BackColor = System.Drawing.Color.White;
            this.buttonNewSalario.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNewSalario.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.buttonNewSalario.Location = new System.Drawing.Point(356, 251);
            this.buttonNewSalario.Name = "buttonNewSalario";
            this.buttonNewSalario.Size = new System.Drawing.Size(139, 65);
            this.buttonNewSalario.TabIndex = 22;
            this.buttonNewSalario.Text = "Calcular Salario";
            this.buttonNewSalario.UseVisualStyleBackColor = false;
            this.buttonNewSalario.Click += new System.EventHandler(this.buttonNewSalario_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(216, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 39);
            this.label3.TabIndex = 20;
            this.label3.Text = "Aumento de: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(193, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 39);
            this.label2.TabIndex = 18;
            this.label2.Text = "Salario Actual:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label5.Location = new System.Drawing.Point(193, 344);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(256, 39);
            this.label5.TabIndex = 24;
            this.label5.Text = "Salario nuevo:";
            // 
            // textSalarioActual
            // 
            this.textSalarioActual.Font = new System.Drawing.Font("Gill Sans MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSalarioActual.ForeColor = System.Drawing.Color.Black;
            this.textSalarioActual.Location = new System.Drawing.Point(480, 98);
            this.textSalarioActual.Multiline = true;
            this.textSalarioActual.Name = "textSalarioActual";
            this.textSalarioActual.Size = new System.Drawing.Size(98, 42);
            this.textSalarioActual.TabIndex = 26;
            // 
            // textSalarioNuevo
            // 
            this.textSalarioNuevo.Font = new System.Drawing.Font("Gill Sans MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSalarioNuevo.ForeColor = System.Drawing.Color.Black;
            this.textSalarioNuevo.Location = new System.Drawing.Point(480, 344);
            this.textSalarioNuevo.Multiline = true;
            this.textSalarioNuevo.Name = "textSalarioNuevo";
            this.textSalarioNuevo.Size = new System.Drawing.Size(98, 42);
            this.textSalarioNuevo.TabIndex = 27;
            this.textSalarioNuevo.TextChanged += new System.EventHandler(this.textSalarioNuevo_TextChanged);
            // 
            // textAumento
            // 
            this.textAumento.Font = new System.Drawing.Font("Gill Sans MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAumento.ForeColor = System.Drawing.Color.Black;
            this.textAumento.Location = new System.Drawing.Point(480, 173);
            this.textAumento.Multiline = true;
            this.textAumento.Name = "textAumento";
            this.textAumento.Size = new System.Drawing.Size(98, 42);
            this.textAumento.TabIndex = 28;
            // 
            // FormSalario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Actividad_1_Parcial_2.Properties.Resources.fondo_aqua;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textAumento);
            this.Controls.Add(this.textSalarioNuevo);
            this.Controls.Add(this.textSalarioActual);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonNewSalario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormSalario";
            this.Text = "FormSalario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonNewSalario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textSalarioActual;
        private System.Windows.Forms.TextBox textSalarioNuevo;
        private System.Windows.Forms.TextBox textAumento;
    }
}