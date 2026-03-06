namespace T1_CalPromEst
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnCal = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Nota4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Nota3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Nota2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Nota1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnCalComplectivo = new System.Windows.Forms.Button();
            this.BtnCalExtraordinario = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(219, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Promedio de Estudiante";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnCal);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Nota4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Nota3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.Nota2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Nota1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(52, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(702, 161);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Favor de Ingresar las 4 Notas del Estudiante";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // BtnCal
            // 
            this.BtnCal.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnCal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCal.Location = new System.Drawing.Point(275, 114);
            this.BtnCal.Name = "BtnCal";
            this.BtnCal.Size = new System.Drawing.Size(134, 33);
            this.BtnCal.TabIndex = 14;
            this.BtnCal.Text = "Calcular";
            this.BtnCal.UseVisualStyleBackColor = false;
            this.BtnCal.Click += new System.EventHandler(this.BtnCal_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(518, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 22);
            this.label4.TabIndex = 13;
            this.label4.Text = "Nota 4:";
            // 
            // Nota4
            // 
            this.Nota4.Location = new System.Drawing.Point(592, 50);
            this.Nota4.Name = "Nota4";
            this.Nota4.Size = new System.Drawing.Size(70, 30);
            this.Nota4.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(354, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 22);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nota 3:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Nota3
            // 
            this.Nota3.Location = new System.Drawing.Point(428, 50);
            this.Nota3.Name = "Nota3";
            this.Nota3.Size = new System.Drawing.Size(70, 30);
            this.Nota3.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(186, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 22);
            this.label6.TabIndex = 9;
            this.label6.Text = "Nota 2:";
            // 
            // Nota2
            // 
            this.Nota2.Location = new System.Drawing.Point(260, 50);
            this.Nota2.Name = "Nota2";
            this.Nota2.Size = new System.Drawing.Size(70, 30);
            this.Nota2.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nota 1:";
            // 
            // Nota1
            // 
            this.Nota1.Location = new System.Drawing.Point(97, 50);
            this.Nota1.Name = "Nota1";
            this.Nota1.Size = new System.Drawing.Size(70, 30);
            this.Nota1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnCalExtraordinario);
            this.groupBox2.Controls.Add(this.BtnCalComplectivo);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 258);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 220);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Estado del Estudiante:";
            this.groupBox2.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(506, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 22);
            this.label9.TabIndex = 19;
            this.label9.Text = "?";
            this.label9.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(392, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 22);
            this.label8.TabIndex = 18;
            this.label8.Text = "Resultado:";
            this.label8.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(306, 138);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(70, 30);
            this.textBox2.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Enabled = false;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(278, 22);
            this.label7.TabIndex = 16;
            this.label7.Text = "Ingrese la Nota de Extraordinario:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(292, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(70, 30);
            this.textBox1.TabIndex = 15;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(264, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ingrese la Nota de Complectivo:";
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.BackColor = System.Drawing.Color.Brown;
            this.BtnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnLimpiar.Location = new System.Drawing.Point(52, 21);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(91, 32);
            this.BtnLimpiar.TabIndex = 4;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = false;
            this.BtnLimpiar.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnCalComplectivo
            // 
            this.BtnCalComplectivo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnCalComplectivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCalComplectivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalComplectivo.Location = new System.Drawing.Point(138, 101);
            this.BtnCalComplectivo.Name = "BtnCalComplectivo";
            this.BtnCalComplectivo.Size = new System.Drawing.Size(92, 33);
            this.BtnCalComplectivo.TabIndex = 15;
            this.BtnCalComplectivo.Text = "Calcular";
            this.BtnCalComplectivo.UseVisualStyleBackColor = false;
            this.BtnCalComplectivo.Click += new System.EventHandler(this.BtnCalComplectivo_Click);
            // 
            // BtnCalExtraordinario
            // 
            this.BtnCalExtraordinario.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnCalExtraordinario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCalExtraordinario.Enabled = false;
            this.BtnCalExtraordinario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalExtraordinario.Location = new System.Drawing.Point(138, 181);
            this.BtnCalExtraordinario.Name = "BtnCalExtraordinario";
            this.BtnCalExtraordinario.Size = new System.Drawing.Size(92, 33);
            this.BtnCalExtraordinario.TabIndex = 20;
            this.BtnCalExtraordinario.Text = "Calcular";
            this.BtnCalExtraordinario.UseVisualStyleBackColor = false;
            this.BtnCalExtraordinario.Click += new System.EventHandler(this.BtnCalExtraordinario_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 505);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Nota4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Nota3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Nota2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Nota1;
        private System.Windows.Forms.Button BtnCal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Button BtnCalExtraordinario;
        private System.Windows.Forms.Button BtnCalComplectivo;
    }
}

