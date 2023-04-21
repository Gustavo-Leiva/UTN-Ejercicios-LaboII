namespace Hola_Windows_Forms
{
    partial class Principal
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
            this.btn_saludar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_saludar
            // 
            this.btn_saludar.Location = new System.Drawing.Point(732, 378);
            this.btn_saludar.Name = "btn_saludar";
            this.btn_saludar.Size = new System.Drawing.Size(112, 34);
            this.btn_saludar.TabIndex = 0;
            this.btn_saludar.Text = "Saludar";
            this.btn_saludar.UseVisualStyleBackColor = true;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 750);
            this.Controls.Add(this.btn_saludar);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "¡Hola, Windows Forms!";
            this.Load += new System.EventHandler(this.Principal_Load_1);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_saludar;
        private Label lbl_nombre;
        private Label lbl_apellido;
        private TextBox txt_nombre;
        private TextBox txt_apellido;
        private Label lbl_materia;
        private ComboBox cbo_materia;
    }
}