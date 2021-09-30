
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
            this.button0 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.suma = new System.Windows.Forms.Button();
            this.resta = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.multiplicacion = new System.Windows.Forms.Button();
            this.numero1 = new System.Windows.Forms.TextBox();
            this.numero2 = new System.Windows.Forms.TextBox();
            this.resultado = new System.Windows.Forms.TextBox();
            this.button9 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(280, 383);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(237, 70);
            this.button0.TabIndex = 0;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(280, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 70);
            this.button1.TabIndex = 1;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(361, 155);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 70);
            this.button2.TabIndex = 2;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(442, 155);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 70);
            this.button3.TabIndex = 3;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(280, 231);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 70);
            this.button4.TabIndex = 4;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(361, 231);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 70);
            this.button5.TabIndex = 5;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(442, 231);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 70);
            this.button6.TabIndex = 6;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(280, 307);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 70);
            this.button7.TabIndex = 7;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(361, 307);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 70);
            this.button8.TabIndex = 8;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // suma
            // 
            this.suma.Location = new System.Drawing.Point(625, 383);
            this.suma.Name = "suma";
            this.suma.Size = new System.Drawing.Size(43, 32);
            this.suma.TabIndex = 9;
            this.suma.Text = "+";
            this.suma.UseVisualStyleBackColor = true;
            this.suma.Click += new System.EventHandler(this.suma_Click);
            // 
            // resta
            // 
            this.resta.Location = new System.Drawing.Point(625, 307);
            this.resta.Name = "resta";
            this.resta.Size = new System.Drawing.Size(43, 32);
            this.resta.TabIndex = 10;
            this.resta.Text = "-";
            this.resta.UseVisualStyleBackColor = true;
            // 
            // division
            // 
            this.division.Location = new System.Drawing.Point(625, 231);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(43, 32);
            this.division.TabIndex = 11;
            this.division.Text = "/";
            this.division.UseVisualStyleBackColor = true;
            // 
            // multiplicacion
            // 
            this.multiplicacion.Location = new System.Drawing.Point(625, 155);
            this.multiplicacion.Name = "multiplicacion";
            this.multiplicacion.Size = new System.Drawing.Size(43, 32);
            this.multiplicacion.TabIndex = 12;
            this.multiplicacion.Text = "X";
            this.multiplicacion.UseVisualStyleBackColor = true;
            // 
            // numero1
            // 
            this.numero1.Location = new System.Drawing.Point(280, 129);
            this.numero1.Name = "numero1";
            this.numero1.Size = new System.Drawing.Size(123, 20);
            this.numero1.TabIndex = 13;
            // 
            // numero2
            // 
            this.numero2.Location = new System.Drawing.Point(405, 129);
            this.numero2.Name = "numero2";
            this.numero2.Size = new System.Drawing.Size(112, 20);
            this.numero2.TabIndex = 14;
            // 
            // resultado
            // 
            this.resultado.Location = new System.Drawing.Point(280, 475);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(237, 20);
            this.resultado.TabIndex = 15;
            this.resultado.Text = "0";
            this.resultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(442, 307);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 70);
            this.button9.TabIndex = 16;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 630);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.numero2);
            this.Controls.Add(this.numero1);
            this.Controls.Add(this.multiplicacion);
            this.Controls.Add(this.division);
            this.Controls.Add(this.resta);
            this.Controls.Add(this.suma);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button0);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button suma;
        private System.Windows.Forms.Button resta;
        private System.Windows.Forms.Button division;
        private System.Windows.Forms.Button multiplicacion;
        private System.Windows.Forms.TextBox numero1;
        private System.Windows.Forms.TextBox numero2;
        private System.Windows.Forms.TextBox resultado;
        private System.Windows.Forms.Button button9;
    }
}

