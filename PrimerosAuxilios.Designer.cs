namespace PrimerosAuxilios
{
    partial class PrimerosAuxilios
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
            label1 = new Label();
            cmbEmergencias = new ComboBox();
            lvPautas = new ListView();
            label3 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(22, 20);
            label1.Name = "label1";
            label1.Size = new Size(223, 30);
            label1.TabIndex = 1;
            label1.Text = "PRIMEROS AUXILIOS";
            // 
            // cmbEmergencias
            // 
            cmbEmergencias.FormattingEnabled = true;
            cmbEmergencias.Location = new Point(22, 53);
            cmbEmergencias.Name = "cmbEmergencias";
            cmbEmergencias.Size = new Size(402, 23);
            cmbEmergencias.TabIndex = 2;
            cmbEmergencias.SelectedIndexChanged += cmbEmergencias_SelectedIndexChanged;
            // 
            // lvPautas
            // 
            lvPautas.GridLines = true;
            lvPautas.Location = new Point(22, 126);
            lvPautas.Name = "lvPautas";
            lvPautas.Size = new Size(402, 290);
            lvPautas.TabIndex = 4;
            lvPautas.UseCompatibleStateImageBehavior = false;
            lvPautas.View = View.Details;
            lvPautas.SelectedIndexChanged += lvPautas_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(22, 102);
            label3.Name = "label3";
            label3.Size = new Size(137, 21);
            label3.TabIndex = 5;
            label3.Text = "PAUTAS BÁSICAS";
            label3.Click += label3_Click;
            // 
            // button1
            // 
            button1.Location = new Point(294, 432);
            button1.Name = "button1";
            button1.Size = new Size(130, 23);
            button1.TabIndex = 6;
            button1.Text = "Agregar nueva guía";
            button1.UseVisualStyleBackColor = true;
            // 
            // PrimerosAuxilios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(445, 492);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(lvPautas);
            Controls.Add(cmbEmergencias);
            Controls.Add(label1);
            Name = "PrimerosAuxilios";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private ComboBox cmbEmergencias;
        private ListView lvPautas;
        private Label label3;
        private Button button1;
    }
}
