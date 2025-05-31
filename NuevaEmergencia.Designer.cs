namespace PrimerosAuxilios
{
    partial class NuevaEmergencia
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
            label1 = new Label();
            txtEmergencia = new TextBox();
            label2 = new Label();
            txtPauta = new TextBox();
            btnAnadirPauta = new Button();
            label3 = new Label();
            lvVistaPrevia = new ListView();
            btnRegistrar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 26);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 0;
            label1.Text = "Emergencia";
            // 
            // txtEmergencia
            // 
            txtEmergencia.Location = new Point(30, 44);
            txtEmergencia.Name = "txtEmergencia";
            txtEmergencia.Size = new Size(302, 23);
            txtEmergencia.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 80);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 2;
            label2.Text = "Pauta";
            // 
            // txtPauta
            // 
            txtPauta.Location = new Point(30, 98);
            txtPauta.Name = "txtPauta";
            txtPauta.Size = new Size(302, 23);
            txtPauta.TabIndex = 3;
            // 
            // btnAnadirPauta
            // 
            btnAnadirPauta.Location = new Point(211, 140);
            btnAnadirPauta.Name = "btnAnadirPauta";
            btnAnadirPauta.Size = new Size(121, 23);
            btnAnadirPauta.TabIndex = 4;
            btnAnadirPauta.Text = "Añadir pauta";
            btnAnadirPauta.UseVisualStyleBackColor = true;
            btnAnadirPauta.Click += btnAnadirPauta_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 186);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 5;
            label3.Text = "Vista previa";
            // 
            // lvVistaPrevia
            // 
            lvVistaPrevia.GridLines = true;
            lvVistaPrevia.Location = new Point(30, 204);
            lvVistaPrevia.Name = "lvVistaPrevia";
            lvVistaPrevia.Size = new Size(302, 156);
            lvVistaPrevia.TabIndex = 6;
            lvVistaPrevia.UseCompatibleStateImageBehavior = false;
            lvVistaPrevia.View = View.Details;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(211, 381);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(121, 23);
            btnRegistrar.TabIndex = 7;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // NuevaEmergencia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(373, 450);
            Controls.Add(btnRegistrar);
            Controls.Add(lvVistaPrevia);
            Controls.Add(label3);
            Controls.Add(btnAnadirPauta);
            Controls.Add(txtPauta);
            Controls.Add(label2);
            Controls.Add(txtEmergencia);
            Controls.Add(label1);
            Name = "NuevaEmergencia";
            Text = "Nueva Emergencia";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtEmergencia;
        private Label label2;
        private TextBox txtPauta;
        private Button btnAnadirPauta;
        private Label label3;
        private ListView lvVistaPrevia;
        private Button btnRegistrar;
    }
}