namespace Ejercicio_01
{
    partial class frm_Principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_apellido = new System.Windows.Forms.Label();
            this.btn_saludo = new System.Windows.Forms.Button();
            this.cbo_materia = new System.Windows.Forms.ComboBox();
            this.lbl_materia = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(121, 85);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.PlaceholderText = "Introduce tu nombre";
            this.txt_nombre.Size = new System.Drawing.Size(243, 31);
            this.txt_nombre.TabIndex = 0;
            this.txt_nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_nombre_KeyPress);
            // 
            // txt_apellido
            // 
            this.txt_apellido.Location = new System.Drawing.Point(451, 88);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.PlaceholderText = "Introduce tu apellido";
            this.txt_apellido.Size = new System.Drawing.Size(244, 31);
            this.txt_apellido.TabIndex = 1;
            this.txt_apellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_apellido_KeyPress);
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_nombre.Location = new System.Drawing.Point(121, 30);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(81, 25);
            this.lbl_nombre.TabIndex = 2;
            this.lbl_nombre.Text = "Nombre";
            // 
            // lbl_apellido
            // 
            this.lbl_apellido.AutoSize = true;
            this.lbl_apellido.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_apellido.Location = new System.Drawing.Point(451, 30);
            this.lbl_apellido.Name = "lbl_apellido";
            this.lbl_apellido.Size = new System.Drawing.Size(83, 25);
            this.lbl_apellido.TabIndex = 3;
            this.lbl_apellido.Text = "Apellido";
            // 
            // btn_saludo
            // 
            this.btn_saludo.Location = new System.Drawing.Point(531, 330);
            this.btn_saludo.Name = "btn_saludo";
            this.btn_saludo.Size = new System.Drawing.Size(111, 47);
            this.btn_saludo.TabIndex = 4;
            this.btn_saludo.Text = "Saludar";
            this.btn_saludo.UseVisualStyleBackColor = true;
            this.btn_saludo.Click += new System.EventHandler(this.btn_saludo_Click);
            // 
            // cbo_materia
            // 
            this.cbo_materia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_materia.FormattingEnabled = true;
            this.cbo_materia.Location = new System.Drawing.Point(117, 233);
            this.cbo_materia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbo_materia.Name = "cbo_materia";
            this.cbo_materia.Size = new System.Drawing.Size(578, 33);
            this.cbo_materia.TabIndex = 5;
            // 
            // lbl_materia
            // 
            this.lbl_materia.AutoSize = true;
            this.lbl_materia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_materia.Location = new System.Drawing.Point(117, 178);
            this.lbl_materia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_materia.Name = "lbl_materia";
            this.lbl_materia.Size = new System.Drawing.Size(151, 25);
            this.lbl_materia.TabIndex = 6;
            this.lbl_materia.Text = "Materia Favorita";
            // 
            // frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_materia);
            this.Controls.Add(this.cbo_materia);
            this.Controls.Add(this.btn_saludo);
            this.Controls.Add(this.lbl_apellido);
            this.Controls.Add(this.lbl_nombre);
            this.Controls.Add(this.txt_apellido);
            this.Controls.Add(this.txt_nombre);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "¡Hola, Windows Forms!";
            this.Load += new System.EventHandler(this.Saludar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txt_nombre;
        private TextBox txt_apellido;
        private Label lbl_nombre;
        private Label lbl_apellido;
        private Button btn_saludo;
        private ComboBox cbo_materia;
        private Label lbl_materia;
    }
}