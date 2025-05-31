namespace Practica_2
{
    partial class Form1
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
            ckl_opciones = new CheckedListBox();
            txt_emergencia = new TextBox();
            btn_registrar = new Button();
            lst_muestreo = new ListBox();
            label1 = new Label();
            label2 = new Label();
            btn_formagregar = new Button();
            SuspendLayout();
            // 
            // ckl_opciones
            // 
            ckl_opciones.FormattingEnabled = true;
            ckl_opciones.Location = new Point(155, 127);
            ckl_opciones.Name = "ckl_opciones";
            ckl_opciones.Size = new Size(204, 238);
            ckl_opciones.TabIndex = 0;
            ckl_opciones.SelectedIndexChanged += ckl_opciones_SelectedIndexChanged;
            // 
            // txt_emergencia
            // 
            txt_emergencia.Location = new Point(85, 47);
            txt_emergencia.Name = "txt_emergencia";
            txt_emergencia.Size = new Size(274, 23);
            txt_emergencia.TabIndex = 1;
            txt_emergencia.TextChanged += txt_emergencia_TextChanged;
            // 
            // btn_registrar
            // 
            btn_registrar.Location = new Point(393, 47);
            btn_registrar.Name = "btn_registrar";
            btn_registrar.Size = new Size(75, 23);
            btn_registrar.TabIndex = 2;
            btn_registrar.Text = "Registrar";
            btn_registrar.UseVisualStyleBackColor = true;
            btn_registrar.Click += btn_registrar_Click;
            // 
            // lst_muestreo
            // 
            lst_muestreo.FormattingEnabled = true;
            lst_muestreo.ItemHeight = 15;
            lst_muestreo.Location = new Point(516, 119);
            lst_muestreo.Name = "lst_muestreo";
            lst_muestreo.Size = new Size(248, 229);
            lst_muestreo.TabIndex = 3;
            lst_muestreo.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 47);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 4;
            label1.Text = "Emergencia";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 127);
            label2.Name = "label2";
            label2.Size = new Size(139, 15);
            label2.TabIndex = 5;
            label2.Text = "Instrucciones de cuidado";
            // 
            // btn_formagregar
            // 
            btn_formagregar.Location = new Point(10, 178);
            btn_formagregar.Name = "btn_formagregar";
            btn_formagregar.Size = new Size(105, 48);
            btn_formagregar.TabIndex = 6;
            btn_formagregar.Text = "Agregar paso al formulario";
            btn_formagregar.UseVisualStyleBackColor = true;
            btn_formagregar.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_formagregar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lst_muestreo);
            Controls.Add(btn_registrar);
            Controls.Add(txt_emergencia);
            Controls.Add(ckl_opciones);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox ckl_opciones;
        private TextBox txt_emergencia;
        private Button btn_registrar;
        private ListBox lst_muestreo;
        private Label label1;
        private Label label2;
        private Button btn_formagregar;
    }
}
