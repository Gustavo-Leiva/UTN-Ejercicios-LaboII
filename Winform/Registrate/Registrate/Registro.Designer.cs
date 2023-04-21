namespace Registrate
{
    partial class Registro
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
            this.gb_detalle = new System.Windows.Forms.GroupBox();
            this.nud_edad = new System.Windows.Forms.NumericUpDown();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lbl_edad = new System.Windows.Forms.Label();
            this.lbl_direccion = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.grp_genero = new System.Windows.Forms.GroupBox();
            this.rdo_no_binario = new System.Windows.Forms.RadioButton();
            this.rdo_femenino = new System.Windows.Forms.RadioButton();
            this.rdo_masculino = new System.Windows.Forms.RadioButton();
            this.grp_cursos = new System.Windows.Forms.GroupBox();
            this.chk_javascript = new System.Windows.Forms.CheckBox();
            this.chk_cmas = new System.Windows.Forms.CheckBox();
            this.chk_c = new System.Windows.Forms.CheckBox();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.lst_pais = new System.Windows.Forms.ListBox();
            this.gb_detalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_edad)).BeginInit();
            this.grp_genero.SuspendLayout();
            this.grp_cursos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_detalle
            // 
            this.gb_detalle.Controls.Add(this.nud_edad);
            this.gb_detalle.Controls.Add(this.txt_address);
            this.gb_detalle.Controls.Add(this.txt_nombre);
            this.gb_detalle.Controls.Add(this.lbl_edad);
            this.gb_detalle.Controls.Add(this.lbl_direccion);
            this.gb_detalle.Controls.Add(this.lbl_nombre);
            this.gb_detalle.Location = new System.Drawing.Point(66, 31);
            this.gb_detalle.Margin = new System.Windows.Forms.Padding(2);
            this.gb_detalle.Name = "gb_detalle";
            this.gb_detalle.Padding = new System.Windows.Forms.Padding(2);
            this.gb_detalle.Size = new System.Drawing.Size(258, 136);
            this.gb_detalle.TabIndex = 0;
            this.gb_detalle.TabStop = false;
            this.gb_detalle.Text = "Detalle de usuario";
            // 
            // nud_edad
            // 
            this.nud_edad.Location = new System.Drawing.Point(132, 97);
            this.nud_edad.Margin = new System.Windows.Forms.Padding(2);
            this.nud_edad.Name = "nud_edad";
            this.nud_edad.Size = new System.Drawing.Size(105, 23);
            this.nud_edad.TabIndex = 5;
            this.nud_edad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(132, 66);
            this.txt_address.Margin = new System.Windows.Forms.Padding(2);
            this.txt_address.Name = "txt_address";
            this.txt_address.PlaceholderText = "Ingrese direccion";
            this.txt_address.Size = new System.Drawing.Size(106, 23);
            this.txt_address.TabIndex = 4;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(129, 32);
            this.txt_nombre.Margin = new System.Windows.Forms.Padding(2);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.PlaceholderText = "Ingrese nombre";
            this.txt_nombre.Size = new System.Drawing.Size(109, 23);
            this.txt_nombre.TabIndex = 3;
            // 
            // lbl_edad
            // 
            this.lbl_edad.AutoSize = true;
            this.lbl_edad.Location = new System.Drawing.Point(25, 97);
            this.lbl_edad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_edad.Name = "lbl_edad";
            this.lbl_edad.Size = new System.Drawing.Size(33, 15);
            this.lbl_edad.TabIndex = 2;
            this.lbl_edad.Text = "Edad";
            // 
            // lbl_direccion
            // 
            this.lbl_direccion.AutoSize = true;
            this.lbl_direccion.Location = new System.Drawing.Point(24, 65);
            this.lbl_direccion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_direccion.Name = "lbl_direccion";
            this.lbl_direccion.Size = new System.Drawing.Size(57, 15);
            this.lbl_direccion.TabIndex = 1;
            this.lbl_direccion.Text = "Direccion";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(22, 34);
            this.lbl_nombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(51, 15);
            this.lbl_nombre.TabIndex = 0;
            this.lbl_nombre.Text = "Nombre";
            // 
            // grp_genero
            // 
            this.grp_genero.Controls.Add(this.rdo_no_binario);
            this.grp_genero.Controls.Add(this.rdo_femenino);
            this.grp_genero.Controls.Add(this.rdo_masculino);
            this.grp_genero.Location = new System.Drawing.Point(435, 20);
            this.grp_genero.Margin = new System.Windows.Forms.Padding(2);
            this.grp_genero.Name = "grp_genero";
            this.grp_genero.Padding = new System.Windows.Forms.Padding(2);
            this.grp_genero.Size = new System.Drawing.Size(144, 115);
            this.grp_genero.TabIndex = 1;
            this.grp_genero.TabStop = false;
            this.grp_genero.Text = "Género";
            // 
            // rdo_no_binario
            // 
            this.rdo_no_binario.AutoSize = true;
            this.rdo_no_binario.Location = new System.Drawing.Point(22, 85);
            this.rdo_no_binario.Margin = new System.Windows.Forms.Padding(2);
            this.rdo_no_binario.Name = "rdo_no_binario";
            this.rdo_no_binario.Size = new System.Drawing.Size(81, 19);
            this.rdo_no_binario.TabIndex = 2;
            this.rdo_no_binario.Text = "No Binario";
            this.rdo_no_binario.UseVisualStyleBackColor = true;
            // 
            // rdo_femenino
            // 
            this.rdo_femenino.AutoSize = true;
            this.rdo_femenino.Location = new System.Drawing.Point(24, 54);
            this.rdo_femenino.Margin = new System.Windows.Forms.Padding(2);
            this.rdo_femenino.Name = "rdo_femenino";
            this.rdo_femenino.Size = new System.Drawing.Size(78, 19);
            this.rdo_femenino.TabIndex = 1;
            this.rdo_femenino.Text = "Femenino";
            this.rdo_femenino.UseVisualStyleBackColor = true;
            // 
            // rdo_masculino
            // 
            this.rdo_masculino.AutoSize = true;
            this.rdo_masculino.Checked = true;
            this.rdo_masculino.Location = new System.Drawing.Point(23, 23);
            this.rdo_masculino.Margin = new System.Windows.Forms.Padding(2);
            this.rdo_masculino.Name = "rdo_masculino";
            this.rdo_masculino.Size = new System.Drawing.Size(80, 19);
            this.rdo_masculino.TabIndex = 0;
            this.rdo_masculino.TabStop = true;
            this.rdo_masculino.Text = "Masculino";
            this.rdo_masculino.UseVisualStyleBackColor = true;
            // 
            // grp_cursos
            // 
            this.grp_cursos.Controls.Add(this.chk_javascript);
            this.grp_cursos.Controls.Add(this.chk_cmas);
            this.grp_cursos.Controls.Add(this.chk_c);
            this.grp_cursos.Location = new System.Drawing.Point(435, 148);
            this.grp_cursos.Margin = new System.Windows.Forms.Padding(2);
            this.grp_cursos.Name = "grp_cursos";
            this.grp_cursos.Padding = new System.Windows.Forms.Padding(2);
            this.grp_cursos.Size = new System.Drawing.Size(144, 90);
            this.grp_cursos.TabIndex = 2;
            this.grp_cursos.TabStop = false;
            this.grp_cursos.Text = "Cursos";
            // 
            // chk_javascript
            // 
            this.chk_javascript.AutoSize = true;
            this.chk_javascript.Location = new System.Drawing.Point(8, 62);
            this.chk_javascript.Margin = new System.Windows.Forms.Padding(2);
            this.chk_javascript.Name = "chk_javascript";
            this.chk_javascript.Size = new System.Drawing.Size(77, 19);
            this.chk_javascript.TabIndex = 2;
            this.chk_javascript.Text = "Javascript";
            this.chk_javascript.UseVisualStyleBackColor = true;
            // 
            // chk_cmas
            // 
            this.chk_cmas.AutoSize = true;
            this.chk_cmas.Location = new System.Drawing.Point(8, 41);
            this.chk_cmas.Margin = new System.Windows.Forms.Padding(2);
            this.chk_cmas.Name = "chk_cmas";
            this.chk_cmas.Size = new System.Drawing.Size(50, 19);
            this.chk_cmas.TabIndex = 1;
            this.chk_cmas.Text = "C++";
            this.chk_cmas.UseVisualStyleBackColor = true;
            // 
            // chk_c
            // 
            this.chk_c.AutoSize = true;
            this.chk_c.Checked = true;
            this.chk_c.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_c.Location = new System.Drawing.Point(8, 20);
            this.chk_c.Margin = new System.Windows.Forms.Padding(2);
            this.chk_c.Name = "chk_c";
            this.chk_c.Size = new System.Drawing.Size(41, 19);
            this.chk_c.TabIndex = 0;
            this.chk_c.Text = "C#";
            this.chk_c.UseVisualStyleBackColor = true;
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(446, 267);
            this.btn_aceptar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(95, 26);
            this.btn_aceptar.TabIndex = 4;
            this.btn_aceptar.Text = "Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // lst_pais
            // 
            this.lst_pais.FormattingEnabled = true;
            this.lst_pais.ItemHeight = 15;
            this.lst_pais.Location = new System.Drawing.Point(83, 204);
            this.lst_pais.Margin = new System.Windows.Forms.Padding(2);
            this.lst_pais.Name = "lst_pais";
            this.lst_pais.Size = new System.Drawing.Size(127, 79);
            this.lst_pais.TabIndex = 5;
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 355);
            this.Controls.Add(this.lst_pais);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.grp_cursos);
            this.Controls.Add(this.grp_genero);
            this.Controls.Add(this.gb_detalle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Registro";
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.Registro_Load);
            this.gb_detalle.ResumeLayout(false);
            this.gb_detalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_edad)).EndInit();
            this.grp_genero.ResumeLayout(false);
            this.grp_genero.PerformLayout();
            this.grp_cursos.ResumeLayout(false);
            this.grp_cursos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gb_detalle;
        private Label lbl_edad;
        private Label lbl_direccion;
        private Label lbl_nombre;
        private TextBox txt_address;
        private TextBox txt_nombre;
        private NumericUpDown nud_edad;
        private GroupBox grp_genero;
        private RadioButton rdo_no_binario;
        private RadioButton rdo_femenino;
        private RadioButton rdo_masculino;
        private GroupBox grp_cursos;
        private CheckBox chk_javascript;
        private CheckBox chk_cmas;
        private CheckBox chk_c;
        private Button btn_aceptar;
        private ListBox lst_pais;
    }
}