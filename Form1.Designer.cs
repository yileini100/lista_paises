namespace Lista_País
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
            this.cbo_lista_países = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.txt_capital = new System.Windows.Forms.TextBox();
            this.txt_idioma = new System.Windows.Forms.TextBox();
            this.txt_población = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_religión = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbo_lista_países
            // 
            this.cbo_lista_países.FormattingEnabled = true;
            this.cbo_lista_países.Items.AddRange(new object[] {
            "",
            "Venezuela",
            "República Dominicana",
            "Haití",
            "España",
            "China",
            "Corea del Sur",
            "Corea del Norte",
            "Estados Unidos",
            "México",
            "Canadá"});
            this.cbo_lista_países.Location = new System.Drawing.Point(355, 127);
            this.cbo_lista_países.Name = "cbo_lista_países";
            this.cbo_lista_países.Size = new System.Drawing.Size(121, 21);
            this.cbo_lista_países.TabIndex = 0;
            this.cbo_lista_países.SelectedIndexChanged += new System.EventHandler(this.cbo_lista_países_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(174, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista de países";
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_limpiar.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar.Location = new System.Drawing.Point(559, 198);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(105, 33);
            this.btn_limpiar.TabIndex = 3;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = false;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_salir.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.Location = new System.Drawing.Point(559, 253);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(105, 32);
            this.btn_salir.TabIndex = 4;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // txt_capital
            // 
            this.txt_capital.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_capital.Location = new System.Drawing.Point(120, 136);
            this.txt_capital.Name = "txt_capital";
            this.txt_capital.Size = new System.Drawing.Size(147, 25);
            this.txt_capital.TabIndex = 5;
            // 
            // txt_idioma
            // 
            this.txt_idioma.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_idioma.Location = new System.Drawing.Point(120, 195);
            this.txt_idioma.Multiline = true;
            this.txt_idioma.Name = "txt_idioma";
            this.txt_idioma.Size = new System.Drawing.Size(147, 22);
            this.txt_idioma.TabIndex = 6;
            // 
            // txt_población
            // 
            this.txt_población.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_población.Location = new System.Drawing.Point(136, 252);
            this.txt_población.Name = "txt_población";
            this.txt_población.Size = new System.Drawing.Size(266, 25);
            this.txt_población.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Capital";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Población";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Idioma";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "Religión";
            // 
            // txt_religión
            // 
            this.txt_religión.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_religión.Location = new System.Drawing.Point(132, 316);
            this.txt_religión.Multiline = true;
            this.txt_religión.Name = "txt_religión";
            this.txt_religión.Size = new System.Drawing.Size(270, 24);
            this.txt_religión.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 481);
            this.Controls.Add(this.txt_religión);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_población);
            this.Controls.Add(this.txt_idioma);
            this.Controls.Add(this.txt_capital);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbo_lista_países);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbo_lista_países;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.TextBox txt_capital;
        private System.Windows.Forms.TextBox txt_idioma;
        private System.Windows.Forms.TextBox txt_población;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_religión;
    }
}

