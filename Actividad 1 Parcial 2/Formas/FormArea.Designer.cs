
namespace Actividad_1_Parcial_2.Formas
{
    partial class FormArea
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
            this.textBase = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textAltura = new System.Windows.Forms.TextBox();
            this.textArea = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(167, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(479, 49);
            this.label1.TabIndex = 6;
            this.label1.Text = "Area de un triangulo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(223, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 39);
            this.label2.TabIndex = 7;
            this.label2.Text = "Base: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBase
            // 
            this.textBase.Font = new System.Drawing.Font("Gill Sans MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBase.ForeColor = System.Drawing.Color.Black;
            this.textBase.Location = new System.Drawing.Point(374, 133);
            this.textBase.Multiline = true;
            this.textBase.Name = "textBase";
            this.textBase.Size = new System.Drawing.Size(251, 42);
            this.textBase.TabIndex = 8;
            this.textBase.TextChanged += new System.EventHandler(this.textBase_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(190, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 39);
            this.label3.TabIndex = 9;
            this.label3.Text = "Altura: ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.BackColor = System.Drawing.Color.White;
            this.buttonCalcular.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalcular.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.buttonCalcular.Location = new System.Drawing.Point(343, 272);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(155, 49);
            this.buttonCalcular.TabIndex = 11;
            this.buttonCalcular.Text = "Calcular";
            this.buttonCalcular.UseVisualStyleBackColor = false;
            this.buttonCalcular.Click += new System.EventHandler(this.buttonCalcular_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(219, 356);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 39);
            this.label4.TabIndex = 12;
            this.label4.Text = "Area: ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textAltura
            // 
            this.textAltura.Font = new System.Drawing.Font("Gill Sans MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAltura.ForeColor = System.Drawing.Color.Black;
            this.textAltura.Location = new System.Drawing.Point(374, 200);
            this.textAltura.Multiline = true;
            this.textAltura.Name = "textAltura";
            this.textAltura.Size = new System.Drawing.Size(251, 42);
            this.textAltura.TabIndex = 14;
            this.textAltura.TextChanged += new System.EventHandler(this.textAltura_TextChanged);
            // 
            // textArea
            // 
            this.textArea.Font = new System.Drawing.Font("Gill Sans MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textArea.ForeColor = System.Drawing.Color.Black;
            this.textArea.Location = new System.Drawing.Point(374, 356);
            this.textArea.Multiline = true;
            this.textArea.Name = "textArea";
            this.textArea.Size = new System.Drawing.Size(251, 42);
            this.textArea.TabIndex = 15;
            this.textArea.TextChanged += new System.EventHandler(this.textArea_TextChanged);
            // 
            // FormArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Actividad_1_Parcial_2.Properties.Resources.fondo_aqua;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textArea);
            this.Controls.Add(this.textAltura);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonCalcular);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBase);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormArea";
            this.Text = "FormArea";
            this.Load += new System.EventHandler(this.FormArea_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBase;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonCalcular;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textAltura;
        private System.Windows.Forms.TextBox textArea;
    }
}