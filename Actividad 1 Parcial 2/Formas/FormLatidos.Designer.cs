
namespace Actividad_1_Parcial_2.Formas
{
    partial class FormLatidosM
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
            this.buttonFCM = new System.Windows.Forms.Button();
            this.textEdad = new System.Windows.Forms.TextBox();
            this.textFCM = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.text60segH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button60segM = new System.Windows.Forms.Button();
            this.button60segH = new System.Windows.Forms.Button();
            this.text60segM = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(207, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(439, 49);
            this.label1.TabIndex = 8;
            this.label1.Text = "Latidos por minuto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(299, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 39);
            this.label2.TabIndex = 13;
            this.label2.Text = "Edad: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(75, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(343, 39);
            this.label3.TabIndex = 15;
            this.label3.Text = "Frecuencia Maxima";
            // 
            // buttonFCM
            // 
            this.buttonFCM.BackColor = System.Drawing.Color.White;
            this.buttonFCM.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFCM.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.buttonFCM.Location = new System.Drawing.Point(343, 195);
            this.buttonFCM.Name = "buttonFCM";
            this.buttonFCM.Size = new System.Drawing.Size(154, 63);
            this.buttonFCM.TabIndex = 17;
            this.buttonFCM.Text = "Calcular Frecuencia Maxima";
            this.buttonFCM.UseVisualStyleBackColor = false;
            this.buttonFCM.Click += new System.EventHandler(this.buttonLatidos_Click);
            // 
            // textEdad
            // 
            this.textEdad.Font = new System.Drawing.Font("Gill Sans MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdad.ForeColor = System.Drawing.Color.Black;
            this.textEdad.Location = new System.Drawing.Point(451, 54);
            this.textEdad.Multiline = true;
            this.textEdad.Name = "textEdad";
            this.textEdad.Size = new System.Drawing.Size(251, 42);
            this.textEdad.TabIndex = 21;
            // 
            // textFCM
            // 
            this.textFCM.Font = new System.Drawing.Font("Gill Sans MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFCM.ForeColor = System.Drawing.Color.Black;
            this.textFCM.Location = new System.Drawing.Point(451, 126);
            this.textFCM.Multiline = true;
            this.textFCM.Name = "textFCM";
            this.textFCM.Size = new System.Drawing.Size(251, 42);
            this.textFCM.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(2, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(335, 33);
            this.label4.TabIndex = 23;
            this.label4.Text = "Latidos en 60 seg (H)";
            // 
            // text60segH
            // 
            this.text60segH.Font = new System.Drawing.Font("Gill Sans MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text60segH.ForeColor = System.Drawing.Color.Black;
            this.text60segH.Location = new System.Drawing.Point(353, 270);
            this.text60segH.Multiline = true;
            this.text60segH.Name = "text60segH";
            this.text60segH.Size = new System.Drawing.Size(96, 42);
            this.text60segH.TabIndex = 24;
            this.text60segH.TextChanged += new System.EventHandler(this.text60segH_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label5.Location = new System.Drawing.Point(468, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(337, 33);
            this.label5.TabIndex = 26;
            this.label5.Text = "Latidos en 60 seg (M)";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // button60segM
            // 
            this.button60segM.BackColor = System.Drawing.Color.White;
            this.button60segM.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button60segM.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.button60segM.Location = new System.Drawing.Point(598, 342);
            this.button60segM.Name = "button60segM";
            this.button60segM.Size = new System.Drawing.Size(140, 73);
            this.button60segM.TabIndex = 27;
            this.button60segM.Text = "Calcular Latidos en 60 seg (M)";
            this.button60segM.UseVisualStyleBackColor = false;
            this.button60segM.Click += new System.EventHandler(this.button60segM_Click);
            // 
            // button60segH
            // 
            this.button60segH.BackColor = System.Drawing.Color.White;
            this.button60segH.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button60segH.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.button60segH.Location = new System.Drawing.Point(128, 342);
            this.button60segH.Name = "button60segH";
            this.button60segH.Size = new System.Drawing.Size(140, 73);
            this.button60segH.TabIndex = 28;
            this.button60segH.Text = "Calcular Latidos en 60 seg (H)";
            this.button60segH.UseVisualStyleBackColor = false;
            this.button60segH.Click += new System.EventHandler(this.button60segH_Click);
            // 
            // text60segM
            // 
            this.text60segM.Font = new System.Drawing.Font("Gill Sans MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text60segM.ForeColor = System.Drawing.Color.Black;
            this.text60segM.Location = new System.Drawing.Point(818, 279);
            this.text60segM.Multiline = true;
            this.text60segM.Name = "text60segM";
            this.text60segM.Size = new System.Drawing.Size(96, 42);
            this.text60segM.TabIndex = 29;
            // 
            // FormLatidosM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Actividad_1_Parcial_2.Properties.Resources.fondo_aqua;
            this.ClientSize = new System.Drawing.Size(926, 490);
            this.Controls.Add(this.text60segM);
            this.Controls.Add(this.button60segH);
            this.Controls.Add(this.button60segM);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.text60segH);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textFCM);
            this.Controls.Add(this.textEdad);
            this.Controls.Add(this.buttonFCM);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormLatidosM";
            this.Text = "FormLatidos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonFCM;
        private System.Windows.Forms.TextBox textEdad;
        private System.Windows.Forms.TextBox textFCM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox text60segH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button60segM;
        private System.Windows.Forms.Button button60segH;
        private System.Windows.Forms.TextBox text60segM;
    }
}