
namespace Calculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.borrar = new System.Windows.Forms.Button();
            this.suma = new System.Windows.Forms.Button();
            this.resta = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.multiplicacion = new System.Windows.Forms.Button();
            this.numeros = new System.Windows.Forms.TextBox();
            this.num1 = new System.Windows.Forms.Label();
            this.num7 = new System.Windows.Forms.Label();
            this.num8 = new System.Windows.Forms.Label();
            this.num0 = new System.Windows.Forms.Label();
            this.num9 = new System.Windows.Forms.Label();
            this.num6 = new System.Windows.Forms.Label();
            this.num5 = new System.Windows.Forms.Label();
            this.num4 = new System.Windows.Forms.Label();
            this.num2 = new System.Windows.Forms.Label();
            this.num3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // borrar
            // 
            this.borrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.borrar.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrar.Location = new System.Drawing.Point(236, 130);
            this.borrar.Name = "borrar";
            this.borrar.Size = new System.Drawing.Size(57, 43);
            this.borrar.TabIndex = 1;
            this.borrar.Text = "C";
            this.borrar.UseVisualStyleBackColor = true;
            this.borrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // suma
            // 
            this.suma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.suma.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suma.Location = new System.Drawing.Point(57, 118);
            this.suma.Name = "suma";
            this.suma.Size = new System.Drawing.Size(36, 47);
            this.suma.TabIndex = 9;
            this.suma.Text = "+";
            this.suma.UseVisualStyleBackColor = true;
            this.suma.Click += new System.EventHandler(this.suma_Click);
            // 
            // resta
            // 
            this.resta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resta.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resta.Location = new System.Drawing.Point(106, 174);
            this.resta.Name = "resta";
            this.resta.Size = new System.Drawing.Size(36, 46);
            this.resta.TabIndex = 10;
            this.resta.Text = "-";
            this.resta.UseVisualStyleBackColor = true;
            this.resta.Click += new System.EventHandler(this.resta_Click);
            // 
            // division
            // 
            this.division.Cursor = System.Windows.Forms.Cursors.Hand;
            this.division.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.division.Location = new System.Drawing.Point(57, 173);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(36, 46);
            this.division.TabIndex = 11;
            this.division.Text = "/";
            this.division.UseVisualStyleBackColor = true;
            this.division.Click += new System.EventHandler(this.division_Click);
            // 
            // multiplicacion
            // 
            this.multiplicacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.multiplicacion.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplicacion.Location = new System.Drawing.Point(106, 118);
            this.multiplicacion.Name = "multiplicacion";
            this.multiplicacion.Size = new System.Drawing.Size(36, 47);
            this.multiplicacion.TabIndex = 12;
            this.multiplicacion.Text = "X";
            this.multiplicacion.UseVisualStyleBackColor = true;
            this.multiplicacion.Click += new System.EventHandler(this.multiplicacion_Click);
            // 
            // numeros
            // 
            this.numeros.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeros.Location = new System.Drawing.Point(57, 236);
            this.numeros.Name = "numeros";
            this.numeros.Size = new System.Drawing.Size(109, 38);
            this.numeros.TabIndex = 15;
            this.numeros.Text = "0";
            this.numeros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numeros.TextChanged += new System.EventHandler(this.numeros_TextChanged);
            // 
            // num1
            // 
            this.num1.AutoSize = true;
            this.num1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(81)))), ((int)(((byte)(57)))));
            this.num1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.num1.Font = new System.Drawing.Font("MV Boli", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(3)))), ((int)(((byte)(51)))));
            this.num1.Location = new System.Drawing.Point(318, 80);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(60, 39);
            this.num1.TabIndex = 18;
            this.num1.Text = " 1 ";
            this.num1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // num7
            // 
            this.num7.AutoSize = true;
            this.num7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(81)))), ((int)(((byte)(57)))));
            this.num7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.num7.Font = new System.Drawing.Font("MV Boli", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(3)))), ((int)(((byte)(51)))));
            this.num7.Location = new System.Drawing.Point(316, 192);
            this.num7.Name = "num7";
            this.num7.Size = new System.Drawing.Size(65, 39);
            this.num7.TabIndex = 19;
            this.num7.Text = " 7 ";
            // 
            // num8
            // 
            this.num8.AutoSize = true;
            this.num8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(81)))), ((int)(((byte)(57)))));
            this.num8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.num8.Font = new System.Drawing.Font("MV Boli", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(3)))), ((int)(((byte)(51)))));
            this.num8.Location = new System.Drawing.Point(394, 193);
            this.num8.Name = "num8";
            this.num8.Size = new System.Drawing.Size(67, 39);
            this.num8.TabIndex = 20;
            this.num8.Text = " 8 ";
            // 
            // num0
            // 
            this.num0.AutoSize = true;
            this.num0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(81)))), ((int)(((byte)(57)))));
            this.num0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.num0.Font = new System.Drawing.Font("MV Boli", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(3)))), ((int)(((byte)(51)))));
            this.num0.Location = new System.Drawing.Point(471, 250);
            this.num0.Name = "num0";
            this.num0.Size = new System.Drawing.Size(68, 39);
            this.num0.TabIndex = 21;
            this.num0.Text = " 0 ";
            // 
            // num9
            // 
            this.num9.AutoSize = true;
            this.num9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(81)))), ((int)(((byte)(57)))));
            this.num9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.num9.Font = new System.Drawing.Font("MV Boli", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(3)))), ((int)(((byte)(51)))));
            this.num9.Location = new System.Drawing.Point(472, 193);
            this.num9.Name = "num9";
            this.num9.Size = new System.Drawing.Size(67, 39);
            this.num9.TabIndex = 22;
            this.num9.Text = " 9 ";
            // 
            // num6
            // 
            this.num6.AutoSize = true;
            this.num6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(81)))), ((int)(((byte)(57)))));
            this.num6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.num6.Font = new System.Drawing.Font("MV Boli", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(3)))), ((int)(((byte)(51)))));
            this.num6.Location = new System.Drawing.Point(472, 134);
            this.num6.Name = "num6";
            this.num6.Size = new System.Drawing.Size(67, 39);
            this.num6.TabIndex = 23;
            this.num6.Text = " 6 ";
            // 
            // num5
            // 
            this.num5.AutoSize = true;
            this.num5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(81)))), ((int)(((byte)(57)))));
            this.num5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.num5.Font = new System.Drawing.Font("MV Boli", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(3)))), ((int)(((byte)(51)))));
            this.num5.Location = new System.Drawing.Point(396, 134);
            this.num5.Name = "num5";
            this.num5.Size = new System.Drawing.Size(67, 39);
            this.num5.TabIndex = 24;
            this.num5.Text = " 5 ";
            // 
            // num4
            // 
            this.num4.AutoSize = true;
            this.num4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(81)))), ((int)(((byte)(57)))));
            this.num4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.num4.Font = new System.Drawing.Font("MV Boli", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(3)))), ((int)(((byte)(51)))));
            this.num4.Location = new System.Drawing.Point(314, 134);
            this.num4.Name = "num4";
            this.num4.Size = new System.Drawing.Size(68, 39);
            this.num4.TabIndex = 25;
            this.num4.Text = " 4 ";
            // 
            // num2
            // 
            this.num2.AutoSize = true;
            this.num2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(81)))), ((int)(((byte)(57)))));
            this.num2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.num2.Font = new System.Drawing.Font("MV Boli", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(3)))), ((int)(((byte)(51)))));
            this.num2.Location = new System.Drawing.Point(395, 79);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(67, 39);
            this.num2.TabIndex = 27;
            this.num2.Text = " 2 ";
            // 
            // num3
            // 
            this.num3.AutoSize = true;
            this.num3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(81)))), ((int)(((byte)(57)))));
            this.num3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.num3.Font = new System.Drawing.Font("MV Boli", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(3)))), ((int)(((byte)(51)))));
            this.num3.Location = new System.Drawing.Point(472, 78);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(67, 39);
            this.num3.TabIndex = 26;
            this.num3.Text = " 3 ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Calculadora.Properties.Resources.calculadoraChocolate;
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(645, 355);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Calculadora.Properties.Resources.carita;
            this.pictureBox2.Location = new System.Drawing.Point(85, 78);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 31);
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 353);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.num4);
            this.Controls.Add(this.num5);
            this.Controls.Add(this.num6);
            this.Controls.Add(this.num9);
            this.Controls.Add(this.num0);
            this.Controls.Add(this.num8);
            this.Controls.Add(this.num7);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.numeros);
            this.Controls.Add(this.multiplicacion);
            this.Controls.Add(this.division);
            this.Controls.Add(this.resta);
            this.Controls.Add(this.suma);
            this.Controls.Add(this.borrar);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button borrar;
        private System.Windows.Forms.Button suma;
        private System.Windows.Forms.Button resta;
        private System.Windows.Forms.Button division;
        private System.Windows.Forms.Button multiplicacion;
        private System.Windows.Forms.TextBox numeros;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label num1;
        private System.Windows.Forms.Label num7;
        private System.Windows.Forms.Label num8;
        private System.Windows.Forms.Label num0;
        private System.Windows.Forms.Label num9;
        private System.Windows.Forms.Label num6;
        private System.Windows.Forms.Label num5;
        private System.Windows.Forms.Label num4;
        private System.Windows.Forms.Label num3;
        private System.Windows.Forms.Label num2;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

