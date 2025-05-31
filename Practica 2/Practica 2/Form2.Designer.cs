namespace Practica_2
{
    partial class FormAgregarInstruccion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_agregarpaso = new Button();
            txt_paso = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btn_agregarpaso
            // 
            btn_agregarpaso.Location = new Point(499, 103);
            btn_agregarpaso.Name = "btn_agregarpaso";
            btn_agregarpaso.Size = new Size(116, 60);
            btn_agregarpaso.TabIndex = 0;
            btn_agregarpaso.Text = "Agregar";
            btn_agregarpaso.UseVisualStyleBackColor = true;
            btn_agregarpaso.Click += btn_agregarpaso_Click;
            // 
            // txt_paso
            // 
            txt_paso.Location = new Point(206, 123);
            txt_paso.Name = "txt_paso";
            txt_paso.Size = new Size(260, 23);
            txt_paso.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 126);
            label1.Name = "label1";
            label1.Size = new Size(139, 15);
            label1.TabIndex = 2;
            label1.Text = "Instrucciones de cuidado";
            // 
            // FormAgregarInstruccion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(txt_paso);
            Controls.Add(btn_agregarpaso);
            Name = "FormAgregarInstruccion";
            Text = "FormAgregarInstruccion";
            Load += FormAgregarInstruccion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_agregarpaso;
        private TextBox txt_paso;
        private Label label1;
    }
}