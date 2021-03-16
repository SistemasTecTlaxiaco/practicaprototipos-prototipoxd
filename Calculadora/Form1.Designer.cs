
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Pantalla = new System.Windows.Forms.TextBox();
            this.Retroceso = new System.Windows.Forms.Button();
            this.num7 = new System.Windows.Forms.Button();
            this.num4 = new System.Windows.Forms.Button();
            this.num1 = new System.Windows.Forms.Button();
            this.num2 = new System.Windows.Forms.Button();
            this.num5 = new System.Windows.Forms.Button();
            this.num8 = new System.Windows.Forms.Button();
            this.Borrar = new System.Windows.Forms.Button();
            this.num3 = new System.Windows.Forms.Button();
            this.num6 = new System.Windows.Forms.Button();
            this.num9 = new System.Windows.Forms.Button();
            this.Suma = new System.Windows.Forms.Button();
            this.Resta = new System.Windows.Forms.Button();
            this.Division = new System.Windows.Forms.Button();
            this.Multiplicacion = new System.Windows.Forms.Button();
            this.num0 = new System.Windows.Forms.Button();
            this.punto = new System.Windows.Forms.Button();
            this.Igual = new System.Windows.Forms.Button();
            this.Alcuadrado = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DodgerBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(312, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Pantalla
            // 
            this.Pantalla.BackColor = System.Drawing.Color.White;
            this.Pantalla.Font = new System.Drawing.Font("AR JULIAN", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pantalla.Location = new System.Drawing.Point(12, 39);
            this.Pantalla.Multiline = true;
            this.Pantalla.Name = "Pantalla";
            this.Pantalla.Size = new System.Drawing.Size(284, 94);
            this.Pantalla.TabIndex = 2;
            this.Pantalla.Text = "0";
            // 
            // Retroceso
            // 
            this.Retroceso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Retroceso.Font = new System.Drawing.Font("AR JULIAN", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Retroceso.Location = new System.Drawing.Point(13, 165);
            this.Retroceso.Name = "Retroceso";
            this.Retroceso.Size = new System.Drawing.Size(168, 35);
            this.Retroceso.TabIndex = 3;
            this.Retroceso.Text = "Retroceso";
            this.Retroceso.UseVisualStyleBackColor = false;
            this.Retroceso.Click += new System.EventHandler(this.button1_Click);
            // 
            // num7
            // 
            this.num7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.num7.Font = new System.Drawing.Font("AR JULIAN", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num7.Location = new System.Drawing.Point(12, 214);
            this.num7.Name = "num7";
            this.num7.Size = new System.Drawing.Size(52, 35);
            this.num7.TabIndex = 5;
            this.num7.Text = "7";
            this.num7.UseVisualStyleBackColor = false;
            this.num7.Click += new System.EventHandler(this.num7_Click);
            // 
            // num4
            // 
            this.num4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.num4.Font = new System.Drawing.Font("AR JULIAN", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num4.Location = new System.Drawing.Point(12, 265);
            this.num4.Name = "num4";
            this.num4.Size = new System.Drawing.Size(52, 35);
            this.num4.TabIndex = 6;
            this.num4.Text = "4";
            this.num4.UseVisualStyleBackColor = false;
            this.num4.Click += new System.EventHandler(this.num4_Click);
            // 
            // num1
            // 
            this.num1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.num1.Font = new System.Drawing.Font("AR JULIAN", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num1.Location = new System.Drawing.Point(12, 315);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(52, 35);
            this.num1.TabIndex = 7;
            this.num1.Text = "1";
            this.num1.UseVisualStyleBackColor = false;
            this.num1.Click += new System.EventHandler(this.num1_Click);
            // 
            // num2
            // 
            this.num2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.num2.Font = new System.Drawing.Font("AR JULIAN", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num2.Location = new System.Drawing.Point(70, 315);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(52, 35);
            this.num2.TabIndex = 11;
            this.num2.Text = "2";
            this.num2.UseVisualStyleBackColor = false;
            this.num2.Click += new System.EventHandler(this.num2_Click);
            // 
            // num5
            // 
            this.num5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.num5.Font = new System.Drawing.Font("AR JULIAN", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num5.Location = new System.Drawing.Point(70, 265);
            this.num5.Name = "num5";
            this.num5.Size = new System.Drawing.Size(52, 35);
            this.num5.TabIndex = 10;
            this.num5.Text = "5";
            this.num5.UseVisualStyleBackColor = false;
            this.num5.Click += new System.EventHandler(this.num5_Click);
            // 
            // num8
            // 
            this.num8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.num8.Font = new System.Drawing.Font("AR JULIAN", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num8.Location = new System.Drawing.Point(70, 214);
            this.num8.Name = "num8";
            this.num8.Size = new System.Drawing.Size(52, 35);
            this.num8.TabIndex = 9;
            this.num8.Text = "8";
            this.num8.UseVisualStyleBackColor = false;
            this.num8.Click += new System.EventHandler(this.num8_Click);
            // 
            // Borrar
            // 
            this.Borrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Borrar.Font = new System.Drawing.Font("AR JULIAN", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Borrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Borrar.Location = new System.Drawing.Point(187, 165);
            this.Borrar.Name = "Borrar";
            this.Borrar.Size = new System.Drawing.Size(52, 35);
            this.Borrar.TabIndex = 8;
            this.Borrar.Text = "C";
            this.Borrar.UseVisualStyleBackColor = false;
            this.Borrar.Click += new System.EventHandler(this.Borrar_Click);
            // 
            // num3
            // 
            this.num3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.num3.Font = new System.Drawing.Font("AR JULIAN", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num3.Location = new System.Drawing.Point(128, 315);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(52, 35);
            this.num3.TabIndex = 15;
            this.num3.Text = "3";
            this.num3.UseVisualStyleBackColor = false;
            this.num3.Click += new System.EventHandler(this.num3_Click);
            // 
            // num6
            // 
            this.num6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.num6.Font = new System.Drawing.Font("AR JULIAN", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num6.Location = new System.Drawing.Point(128, 265);
            this.num6.Name = "num6";
            this.num6.Size = new System.Drawing.Size(52, 35);
            this.num6.TabIndex = 14;
            this.num6.Text = "6";
            this.num6.UseVisualStyleBackColor = false;
            this.num6.Click += new System.EventHandler(this.num6_Click);
            // 
            // num9
            // 
            this.num9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.num9.Font = new System.Drawing.Font("AR JULIAN", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num9.Location = new System.Drawing.Point(128, 214);
            this.num9.Name = "num9";
            this.num9.Size = new System.Drawing.Size(52, 35);
            this.num9.TabIndex = 13;
            this.num9.Text = "9";
            this.num9.UseVisualStyleBackColor = false;
            this.num9.Click += new System.EventHandler(this.num9_Click);
            // 
            // Suma
            // 
            this.Suma.BackColor = System.Drawing.Color.Olive;
            this.Suma.Font = new System.Drawing.Font("AR JULIAN", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Suma.Location = new System.Drawing.Point(186, 315);
            this.Suma.Name = "Suma";
            this.Suma.Size = new System.Drawing.Size(52, 76);
            this.Suma.TabIndex = 19;
            this.Suma.Text = "+";
            this.Suma.UseVisualStyleBackColor = false;
            this.Suma.Click += new System.EventHandler(this.Suma_Click);
            // 
            // Resta
            // 
            this.Resta.BackColor = System.Drawing.Color.Olive;
            this.Resta.Font = new System.Drawing.Font("AR JULIAN", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resta.Location = new System.Drawing.Point(186, 265);
            this.Resta.Name = "Resta";
            this.Resta.Size = new System.Drawing.Size(52, 35);
            this.Resta.TabIndex = 18;
            this.Resta.Text = "-";
            this.Resta.UseVisualStyleBackColor = false;
            this.Resta.Click += new System.EventHandler(this.Resta_Click);
            // 
            // Division
            // 
            this.Division.BackColor = System.Drawing.Color.Olive;
            this.Division.Font = new System.Drawing.Font("AR JULIAN", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Division.Location = new System.Drawing.Point(186, 214);
            this.Division.Name = "Division";
            this.Division.Size = new System.Drawing.Size(52, 35);
            this.Division.TabIndex = 17;
            this.Division.Text = "/";
            this.Division.UseVisualStyleBackColor = false;
            this.Division.Click += new System.EventHandler(this.Division_Click);
            // 
            // Multiplicacion
            // 
            this.Multiplicacion.BackColor = System.Drawing.Color.Olive;
            this.Multiplicacion.Font = new System.Drawing.Font("AR JULIAN", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Multiplicacion.Location = new System.Drawing.Point(244, 164);
            this.Multiplicacion.Name = "Multiplicacion";
            this.Multiplicacion.Size = new System.Drawing.Size(52, 35);
            this.Multiplicacion.TabIndex = 16;
            this.Multiplicacion.Text = "*";
            this.Multiplicacion.UseVisualStyleBackColor = false;
            this.Multiplicacion.Click += new System.EventHandler(this.Multiplicacion_Click);
            // 
            // num0
            // 
            this.num0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.num0.Font = new System.Drawing.Font("AR JULIAN", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num0.Location = new System.Drawing.Point(12, 356);
            this.num0.Name = "num0";
            this.num0.Size = new System.Drawing.Size(110, 35);
            this.num0.TabIndex = 20;
            this.num0.Text = "0";
            this.num0.UseVisualStyleBackColor = false;
            this.num0.Click += new System.EventHandler(this.num0_Click);
            // 
            // punto
            // 
            this.punto.BackColor = System.Drawing.Color.Olive;
            this.punto.Font = new System.Drawing.Font("AR JULIAN", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.punto.Location = new System.Drawing.Point(128, 356);
            this.punto.Name = "punto";
            this.punto.Size = new System.Drawing.Size(52, 35);
            this.punto.TabIndex = 21;
            this.punto.Text = ".";
            this.punto.UseVisualStyleBackColor = false;
            // 
            // Igual
            // 
            this.Igual.BackColor = System.Drawing.Color.Olive;
            this.Igual.Font = new System.Drawing.Font("AR JULIAN", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Igual.Location = new System.Drawing.Point(244, 265);
            this.Igual.Name = "Igual";
            this.Igual.Size = new System.Drawing.Size(52, 126);
            this.Igual.TabIndex = 22;
            this.Igual.Text = "=";
            this.Igual.UseVisualStyleBackColor = false;
            this.Igual.Click += new System.EventHandler(this.Igual_Click);
            // 
            // Alcuadrado
            // 
            this.Alcuadrado.BackColor = System.Drawing.Color.Olive;
            this.Alcuadrado.Font = new System.Drawing.Font("AR JULIAN", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Alcuadrado.Location = new System.Drawing.Point(244, 214);
            this.Alcuadrado.Name = "Alcuadrado";
            this.Alcuadrado.Size = new System.Drawing.Size(52, 35);
            this.Alcuadrado.TabIndex = 24;
            this.Alcuadrado.Text = "x^2";
            this.Alcuadrado.UseVisualStyleBackColor = false;
            this.Alcuadrado.Click += new System.EventHandler(this.button21_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(312, 404);
            this.Controls.Add(this.Alcuadrado);
            this.Controls.Add(this.Igual);
            this.Controls.Add(this.punto);
            this.Controls.Add(this.num0);
            this.Controls.Add(this.Suma);
            this.Controls.Add(this.Resta);
            this.Controls.Add(this.Division);
            this.Controls.Add(this.Multiplicacion);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.num6);
            this.Controls.Add(this.num9);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num5);
            this.Controls.Add(this.num8);
            this.Controls.Add(this.Borrar);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.num4);
            this.Controls.Add(this.num7);
            this.Controls.Add(this.Retroceso);
            this.Controls.Add(this.Pantalla);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.TextBox Pantalla;
        private System.Windows.Forms.Button Retroceso;
        private System.Windows.Forms.Button num7;
        private System.Windows.Forms.Button num4;
        private System.Windows.Forms.Button num1;
        private System.Windows.Forms.Button num2;
        private System.Windows.Forms.Button num5;
        private System.Windows.Forms.Button num8;
        private System.Windows.Forms.Button Borrar;
        private System.Windows.Forms.Button num3;
        private System.Windows.Forms.Button num6;
        private System.Windows.Forms.Button num9;
        private System.Windows.Forms.Button Suma;
        private System.Windows.Forms.Button Resta;
        private System.Windows.Forms.Button Division;
        private System.Windows.Forms.Button Multiplicacion;
        private System.Windows.Forms.Button num0;
        private System.Windows.Forms.Button punto;
        private System.Windows.Forms.Button Igual;
        private System.Windows.Forms.Button Alcuadrado;
    }
}

