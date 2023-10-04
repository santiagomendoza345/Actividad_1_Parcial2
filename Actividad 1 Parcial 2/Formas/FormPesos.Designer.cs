
namespace Actividad_1_Parcial_2.Formas
{
    partial class FormPesos
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
            this.buttonEuros = new System.Windows.Forms.Button();
            this.buttonDolares = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textPesos = new System.Windows.Forms.TextBox();
            this.textResultDolares = new System.Windows.Forms.TextBox();
            this.textResultEuros = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(138, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(531, 49);
            this.label1.TabIndex = 7;
            this.label1.Text = "Pesos a Dolares y Euros";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(153, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 39);
            this.label2.TabIndex = 11;
            this.label2.Text = "Pesos MXN: ";
            // 
            // buttonEuros
            // 
            this.buttonEuros.BackColor = System.Drawing.Color.White;
            this.buttonEuros.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEuros.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.buttonEuros.Location = new System.Drawing.Point(391, 187);
            this.buttonEuros.Name = "buttonEuros";
            this.buttonEuros.Size = new System.Drawing.Size(139, 65);
            this.buttonEuros.TabIndex = 14;
            this.buttonEuros.Text = "Convertir a Euros";
            this.buttonEuros.UseVisualStyleBackColor = false;
            this.buttonEuros.Click += new System.EventHandler(this.buttonEuros_Click);
            // 
            // buttonDolares
            // 
            this.buttonDolares.BackColor = System.Drawing.Color.White;
            this.buttonDolares.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDolares.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.buttonDolares.Location = new System.Drawing.Point(232, 187);
            this.buttonDolares.Name = "buttonDolares";
            this.buttonDolares.Size = new System.Drawing.Size(139, 65);
            this.buttonDolares.TabIndex = 15;
            this.buttonDolares.Text = "Convertir a Dolares";
            this.buttonDolares.UseVisualStyleBackColor = false;
            this.buttonDolares.Click += new System.EventHandler(this.buttonDolares_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(82, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 39);
            this.label3.TabIndex = 16;
            this.label3.Text = "Dolares: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(410, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 39);
            this.label4.TabIndex = 18;
            this.label4.Text = "Euros: ";
            // 
            // textPesos
            // 
            this.textPesos.Font = new System.Drawing.Font("Gill Sans MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPesos.ForeColor = System.Drawing.Color.Black;
            this.textPesos.Location = new System.Drawing.Point(391, 103);
            this.textPesos.Multiline = true;
            this.textPesos.Name = "textPesos";
            this.textPesos.Size = new System.Drawing.Size(251, 42);
            this.textPesos.TabIndex = 20;
            // 
            // textResultDolares
            // 
            this.textResultDolares.Font = new System.Drawing.Font("Gill Sans MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textResultDolares.ForeColor = System.Drawing.Color.Black;
            this.textResultDolares.Location = new System.Drawing.Point(271, 303);
            this.textResultDolares.Multiline = true;
            this.textResultDolares.Name = "textResultDolares";
            this.textResultDolares.Size = new System.Drawing.Size(110, 42);
            this.textResultDolares.TabIndex = 21;
            this.textResultDolares.TextChanged += new System.EventHandler(this.textResultDolares_TextChanged);
            // 
            // textResultEuros
            // 
            this.textResultEuros.Font = new System.Drawing.Font("Gill Sans MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textResultEuros.ForeColor = System.Drawing.Color.Black;
            this.textResultEuros.Location = new System.Drawing.Point(559, 307);
            this.textResultEuros.Multiline = true;
            this.textResultEuros.Name = "textResultEuros";
            this.textResultEuros.Size = new System.Drawing.Size(110, 42);
            this.textResultEuros.TabIndex = 22;
            this.textResultEuros.TextChanged += new System.EventHandler(this.textResultEuros_TextChanged);
            // 
            // FormPesos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Actividad_1_Parcial_2.Properties.Resources.fondo_aqua;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textResultEuros);
            this.Controls.Add(this.textResultDolares);
            this.Controls.Add(this.textPesos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonDolares);
            this.Controls.Add(this.buttonEuros);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormPesos";
            this.Text = "FormPesos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonEuros;
        private System.Windows.Forms.Button buttonDolares;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textPesos;
        private System.Windows.Forms.TextBox textResultDolares;
        private System.Windows.Forms.TextBox textResultEuros;
    }
}