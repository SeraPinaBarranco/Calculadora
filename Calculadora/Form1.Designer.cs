namespace Calculadora
{
    partial class frm_calculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_calculadora));
            this.txt_operacion = new System.Windows.Forms.TextBox();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_0 = new System.Windows.Forms.Button();
            this.btn_igual = new System.Windows.Forms.Button();
            this.lbl_previsualizar = new System.Windows.Forms.Label();
            this.rd_sumar = new System.Windows.Forms.RadioButton();
            this.rd_restar = new System.Windows.Forms.RadioButton();
            this.rd_multiplicar = new System.Windows.Forms.RadioButton();
            this.rd_dividir = new System.Windows.Forms.RadioButton();
            this.btn_sumar = new System.Windows.Forms.Button();
            this.btn_restar = new System.Windows.Forms.Button();
            this.btn_multiplicar = new System.Windows.Forms.Button();
            this.btn_dividir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_operacion
            // 
            this.txt_operacion.Location = new System.Drawing.Point(135, 12);
            this.txt_operacion.Name = "txt_operacion";
            this.txt_operacion.Size = new System.Drawing.Size(207, 31);
            this.txt_operacion.TabIndex = 0;
            // 
            // btn_1
            // 
            this.btn_1.Location = new System.Drawing.Point(135, 91);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(36, 35);
            this.btn_1.TabIndex = 1;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.operar);
            // 
            // btn_2
            // 
            this.btn_2.Location = new System.Drawing.Point(177, 91);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(36, 35);
            this.btn_2.TabIndex = 2;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.operar);
            // 
            // btn_3
            // 
            this.btn_3.Location = new System.Drawing.Point(219, 91);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(36, 35);
            this.btn_3.TabIndex = 3;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = true;
            this.btn_3.Click += new System.EventHandler(this.operar);
            // 
            // btn_4
            // 
            this.btn_4.Location = new System.Drawing.Point(135, 132);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(36, 35);
            this.btn_4.TabIndex = 4;
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = true;
            this.btn_4.Click += new System.EventHandler(this.operar);
            // 
            // btn_5
            // 
            this.btn_5.Location = new System.Drawing.Point(177, 132);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(36, 35);
            this.btn_5.TabIndex = 5;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = true;
            this.btn_5.Click += new System.EventHandler(this.operar);
            // 
            // btn_6
            // 
            this.btn_6.Location = new System.Drawing.Point(219, 132);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(36, 35);
            this.btn_6.TabIndex = 6;
            this.btn_6.Text = "6";
            this.btn_6.UseVisualStyleBackColor = true;
            this.btn_6.Click += new System.EventHandler(this.operar);
            // 
            // btn_7
            // 
            this.btn_7.Location = new System.Drawing.Point(135, 173);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(36, 35);
            this.btn_7.TabIndex = 7;
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = true;
            this.btn_7.Click += new System.EventHandler(this.operar);
            // 
            // btn_8
            // 
            this.btn_8.Location = new System.Drawing.Point(177, 173);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(36, 35);
            this.btn_8.TabIndex = 8;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = true;
            this.btn_8.Click += new System.EventHandler(this.operar);
            // 
            // btn_9
            // 
            this.btn_9.Location = new System.Drawing.Point(219, 173);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(36, 35);
            this.btn_9.TabIndex = 9;
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = true;
            this.btn_9.Click += new System.EventHandler(this.operar);
            // 
            // btn_0
            // 
            this.btn_0.Location = new System.Drawing.Point(177, 214);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(36, 35);
            this.btn_0.TabIndex = 10;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = true;
            this.btn_0.Click += new System.EventHandler(this.operar);
            // 
            // btn_igual
            // 
            this.btn_igual.Location = new System.Drawing.Point(269, 49);
            this.btn_igual.Name = "btn_igual";
            this.btn_igual.Size = new System.Drawing.Size(73, 36);
            this.btn_igual.TabIndex = 15;
            this.btn_igual.Text = "=";
            this.btn_igual.UseVisualStyleBackColor = true;
            this.btn_igual.Click += new System.EventHandler(this.operar);
            // 
            // lbl_previsualizar
            // 
            this.lbl_previsualizar.AutoSize = true;
            this.lbl_previsualizar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_previsualizar.Location = new System.Drawing.Point(203, 55);
            this.lbl_previsualizar.Name = "lbl_previsualizar";
            this.lbl_previsualizar.Size = new System.Drawing.Size(52, 25);
            this.lbl_previsualizar.TabIndex = 16;
            this.lbl_previsualizar.Text = "xxxx";
            this.lbl_previsualizar.UseMnemonic = false;
            // 
            // rd_sumar
            // 
            this.rd_sumar.AutoSize = true;
            this.rd_sumar.Location = new System.Drawing.Point(269, 91);
            this.rd_sumar.Name = "rd_sumar";
            this.rd_sumar.Size = new System.Drawing.Size(113, 29);
            this.rd_sumar.TabIndex = 17;
            this.rd_sumar.TabStop = true;
            this.rd_sumar.Text = "Sumar (+)";
            this.rd_sumar.UseVisualStyleBackColor = true;
            // 
            // rd_restar
            // 
            this.rd_restar.AutoSize = true;
            this.rd_restar.Location = new System.Drawing.Point(269, 126);
            this.rd_restar.Name = "rd_restar";
            this.rd_restar.Size = new System.Drawing.Size(116, 29);
            this.rd_restar.TabIndex = 18;
            this.rd_restar.TabStop = true;
            this.rd_restar.Text = "Restar (-)";
            this.rd_restar.UseVisualStyleBackColor = true;
            // 
            // rd_multiplicar
            // 
            this.rd_multiplicar.AutoSize = true;
            this.rd_multiplicar.Location = new System.Drawing.Point(269, 161);
            this.rd_multiplicar.Name = "rd_multiplicar";
            this.rd_multiplicar.Size = new System.Drawing.Size(149, 29);
            this.rd_multiplicar.TabIndex = 19;
            this.rd_multiplicar.TabStop = true;
            this.rd_multiplicar.Text = "Multiplicar (x)";
            this.rd_multiplicar.UseVisualStyleBackColor = true;
            // 
            // rd_dividir
            // 
            this.rd_dividir.AutoSize = true;
            this.rd_dividir.Location = new System.Drawing.Point(269, 196);
            this.rd_dividir.Name = "rd_dividir";
            this.rd_dividir.Size = new System.Drawing.Size(115, 29);
            this.rd_dividir.TabIndex = 20;
            this.rd_dividir.TabStop = true;
            this.rd_dividir.Text = "Dividir (÷)";
            this.rd_dividir.UseVisualStyleBackColor = true;
            // 
            // btn_sumar
            // 
            this.btn_sumar.Location = new System.Drawing.Point(435, 88);
            this.btn_sumar.Name = "btn_sumar";
            this.btn_sumar.Size = new System.Drawing.Size(36, 35);
            this.btn_sumar.TabIndex = 11;
            this.btn_sumar.Text = "+";
            this.btn_sumar.UseVisualStyleBackColor = true;
            // 
            // btn_restar
            // 
            this.btn_restar.Location = new System.Drawing.Point(435, 129);
            this.btn_restar.Name = "btn_restar";
            this.btn_restar.Size = new System.Drawing.Size(36, 35);
            this.btn_restar.TabIndex = 12;
            this.btn_restar.Text = "-";
            this.btn_restar.UseVisualStyleBackColor = true;
            // 
            // btn_multiplicar
            // 
            this.btn_multiplicar.Location = new System.Drawing.Point(435, 170);
            this.btn_multiplicar.Name = "btn_multiplicar";
            this.btn_multiplicar.Size = new System.Drawing.Size(36, 35);
            this.btn_multiplicar.TabIndex = 13;
            this.btn_multiplicar.Text = "x";
            this.btn_multiplicar.UseVisualStyleBackColor = true;
            // 
            // btn_dividir
            // 
            this.btn_dividir.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dividir.Location = new System.Drawing.Point(435, 211);
            this.btn_dividir.Name = "btn_dividir";
            this.btn_dividir.Size = new System.Drawing.Size(36, 35);
            this.btn_dividir.TabIndex = 14;
            this.btn_dividir.Text = "÷";
            this.btn_dividir.UseVisualStyleBackColor = true;
            // 
            // frm_calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(745, 304);
            this.Controls.Add(this.rd_dividir);
            this.Controls.Add(this.rd_multiplicar);
            this.Controls.Add(this.rd_restar);
            this.Controls.Add(this.rd_sumar);
            this.Controls.Add(this.lbl_previsualizar);
            this.Controls.Add(this.btn_igual);
            this.Controls.Add(this.btn_dividir);
            this.Controls.Add(this.btn_multiplicar);
            this.Controls.Add(this.btn_restar);
            this.Controls.Add(this.btn_sumar);
            this.Controls.Add(this.btn_0);
            this.Controls.Add(this.btn_9);
            this.Controls.Add(this.btn_8);
            this.Controls.Add(this.btn_7);
            this.Controls.Add(this.btn_6);
            this.Controls.Add(this.btn_5);
            this.Controls.Add(this.btn_4);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.txt_operacion);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_calculadora";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_operacion;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_0;
        private System.Windows.Forms.Button btn_igual;
        private System.Windows.Forms.Label lbl_previsualizar;
        private System.Windows.Forms.RadioButton rd_sumar;
        private System.Windows.Forms.RadioButton rd_restar;
        private System.Windows.Forms.RadioButton rd_multiplicar;
        private System.Windows.Forms.RadioButton rd_dividir;
        private System.Windows.Forms.Button btn_sumar;
        private System.Windows.Forms.Button btn_restar;
        private System.Windows.Forms.Button btn_multiplicar;
        private System.Windows.Forms.Button btn_dividir;
    }
}

