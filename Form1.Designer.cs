namespace Calculadora
{
    partial class Calculadora
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
            lblResumen = new Label();
            lblActual = new Label();
            btn0 = new Button();
            btnIgual = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnDividir = new Button();
            btnMultiplicar = new Button();
            btnRestar = new Button();
            btnSumar = new Button();
            label3 = new Label();
            label4 = new Label();
            btnLimpiar = new Button();
            lbHistorial = new ListBox();
            SuspendLayout();
            // 
            // lblResumen
            // 
            lblResumen.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResumen.ForeColor = SystemColors.ControlDark;
            lblResumen.Location = new Point(12, 47);
            lblResumen.Name = "lblResumen";
            lblResumen.Size = new Size(413, 23);
            lblResumen.TabIndex = 0;
            lblResumen.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblActual
            // 
            lblActual.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold);
            lblActual.ForeColor = SystemColors.ControlLightLight;
            lblActual.Location = new Point(12, 70);
            lblActual.Name = "lblActual";
            lblActual.Size = new Size(413, 50);
            lblActual.TabIndex = 1;
            lblActual.Text = "0";
            lblActual.TextAlign = ContentAlignment.MiddleRight;
            lblActual.Click += label2_Click;
            // 
            // btn0
            // 
            btn0.BackColor = SystemColors.ControlDark;
            btn0.FlatStyle = FlatStyle.Flat;
            btn0.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn0.ForeColor = SystemColors.ButtonHighlight;
            btn0.Location = new Point(7, 291);
            btn0.Name = "btn0";
            btn0.Size = new Size(100, 50);
            btn0.TabIndex = 2;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += btn0_Click;
            // 
            // btnIgual
            // 
            btnIgual.BackColor = SystemColors.MenuHighlight;
            btnIgual.FlatStyle = FlatStyle.Flat;
            btnIgual.Font = new Font("Segoe UI Semibold", 18F);
            btnIgual.Location = new Point(219, 291);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(100, 50);
            btnIgual.TabIndex = 3;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = false;
            btnIgual.Click += btnIgual_Click;
            // 
            // btn1
            // 
            btn1.BackColor = SystemColors.ControlDark;
            btn1.FlatStyle = FlatStyle.Flat;
            btn1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn1.ForeColor = SystemColors.ButtonHighlight;
            btn1.Location = new Point(7, 235);
            btn1.Name = "btn1";
            btn1.Size = new Size(100, 50);
            btn1.TabIndex = 4;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.BackColor = SystemColors.ControlDark;
            btn2.FlatStyle = FlatStyle.Flat;
            btn2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn2.ForeColor = SystemColors.ButtonHighlight;
            btn2.Location = new Point(113, 235);
            btn2.Name = "btn2";
            btn2.Size = new Size(100, 50);
            btn2.TabIndex = 5;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.BackColor = SystemColors.ControlDark;
            btn3.FlatStyle = FlatStyle.Flat;
            btn3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn3.ForeColor = SystemColors.ButtonHighlight;
            btn3.Location = new Point(219, 235);
            btn3.Name = "btn3";
            btn3.Size = new Size(100, 50);
            btn3.TabIndex = 6;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += btn3_Click;
            // 
            // btn4
            // 
            btn4.BackColor = SystemColors.ControlDark;
            btn4.FlatStyle = FlatStyle.Flat;
            btn4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn4.ForeColor = SystemColors.ButtonHighlight;
            btn4.Location = new Point(7, 179);
            btn4.Name = "btn4";
            btn4.Size = new Size(100, 50);
            btn4.TabIndex = 7;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += btn4_Click;
            // 
            // btn5
            // 
            btn5.BackColor = SystemColors.ControlDark;
            btn5.FlatStyle = FlatStyle.Flat;
            btn5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn5.ForeColor = SystemColors.ButtonHighlight;
            btn5.Location = new Point(113, 179);
            btn5.Name = "btn5";
            btn5.Size = new Size(100, 50);
            btn5.TabIndex = 8;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += btn5_Click;
            // 
            // btn6
            // 
            btn6.BackColor = SystemColors.ControlDark;
            btn6.FlatStyle = FlatStyle.Flat;
            btn6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn6.ForeColor = SystemColors.ButtonHighlight;
            btn6.Location = new Point(219, 179);
            btn6.Name = "btn6";
            btn6.Size = new Size(100, 50);
            btn6.TabIndex = 9;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += btn6_Click;
            // 
            // btn7
            // 
            btn7.BackColor = SystemColors.ControlDark;
            btn7.FlatStyle = FlatStyle.Flat;
            btn7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn7.ForeColor = SystemColors.ButtonHighlight;
            btn7.Location = new Point(7, 123);
            btn7.Name = "btn7";
            btn7.Size = new Size(100, 50);
            btn7.TabIndex = 10;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += btn7_Click;
            // 
            // btn8
            // 
            btn8.BackColor = SystemColors.ControlDark;
            btn8.FlatStyle = FlatStyle.Flat;
            btn8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn8.ForeColor = SystemColors.ButtonHighlight;
            btn8.Location = new Point(113, 123);
            btn8.Name = "btn8";
            btn8.Size = new Size(100, 50);
            btn8.TabIndex = 11;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += btn8_Click;
            // 
            // btn9
            // 
            btn9.BackColor = SystemColors.ControlDark;
            btn9.FlatStyle = FlatStyle.Flat;
            btn9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn9.ForeColor = SystemColors.ButtonHighlight;
            btn9.Location = new Point(219, 123);
            btn9.Name = "btn9";
            btn9.Size = new Size(100, 50);
            btn9.TabIndex = 12;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += btn9_Click;
            // 
            // btnDividir
            // 
            btnDividir.BackColor = SystemColors.ControlDarkDark;
            btnDividir.FlatStyle = FlatStyle.Flat;
            btnDividir.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDividir.ForeColor = SystemColors.ButtonHighlight;
            btnDividir.Location = new Point(325, 123);
            btnDividir.Name = "btnDividir";
            btnDividir.Size = new Size(100, 50);
            btnDividir.TabIndex = 13;
            btnDividir.Text = "/";
            btnDividir.UseVisualStyleBackColor = false;
            btnDividir.Click += btnDividir_Click;
            // 
            // btnMultiplicar
            // 
            btnMultiplicar.BackColor = SystemColors.ControlDarkDark;
            btnMultiplicar.FlatStyle = FlatStyle.Flat;
            btnMultiplicar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMultiplicar.ForeColor = SystemColors.ButtonHighlight;
            btnMultiplicar.Location = new Point(325, 179);
            btnMultiplicar.Name = "btnMultiplicar";
            btnMultiplicar.Size = new Size(100, 50);
            btnMultiplicar.TabIndex = 14;
            btnMultiplicar.Text = "x";
            btnMultiplicar.UseVisualStyleBackColor = false;
            btnMultiplicar.Click += btnMultiplicar_Click;
            // 
            // btnRestar
            // 
            btnRestar.BackColor = SystemColors.ControlDarkDark;
            btnRestar.FlatStyle = FlatStyle.Flat;
            btnRestar.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRestar.ForeColor = SystemColors.ButtonHighlight;
            btnRestar.Location = new Point(325, 235);
            btnRestar.Name = "btnRestar";
            btnRestar.Size = new Size(100, 50);
            btnRestar.TabIndex = 15;
            btnRestar.Text = "-";
            btnRestar.UseVisualStyleBackColor = false;
            btnRestar.Click += btnRestar_Click;
            // 
            // btnSumar
            // 
            btnSumar.BackColor = SystemColors.ControlDarkDark;
            btnSumar.FlatStyle = FlatStyle.Flat;
            btnSumar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSumar.ForeColor = SystemColors.ButtonHighlight;
            btnSumar.Location = new Point(325, 291);
            btnSumar.Name = "btnSumar";
            btnSumar.Size = new Size(100, 50);
            btnSumar.TabIndex = 16;
            btnSumar.Text = "+";
            btnSumar.UseVisualStyleBackColor = false;
            btnSumar.Click += btnSumar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.ImageAlign = ContentAlignment.MiddleLeft;
            label3.Location = new Point(7, 9);
            label3.Name = "label3";
            label3.Size = new Size(95, 21);
            label3.TabIndex = 17;
            label3.Text = "Calculadora";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(438, 15);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 18;
            label4.Text = "Historial";
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = SystemColors.ControlDarkDark;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnLimpiar.ForeColor = SystemColors.ButtonHighlight;
            btnLimpiar.Location = new Point(113, 291);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(100, 50);
            btnLimpiar.TabIndex = 20;
            btnLimpiar.Text = "C";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += button1_Click;
            // 
            // lbHistorial
            // 
            lbHistorial.BackColor = SystemColors.InfoText;
            lbHistorial.BorderStyle = BorderStyle.None;
            lbHistorial.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbHistorial.ForeColor = Color.White;
            lbHistorial.FormattingEnabled = true;
            lbHistorial.ItemHeight = 21;
            lbHistorial.Location = new Point(438, 33);
            lbHistorial.Name = "lbHistorial";
            lbHistorial.RightToLeft = RightToLeft.Yes;
            lbHistorial.Size = new Size(325, 315);
            lbHistorial.TabIndex = 21;
            // 
            // Calculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InfoText;
            ClientSize = new Size(775, 350);
            Controls.Add(lbHistorial);
            Controls.Add(btnLimpiar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(btnSumar);
            Controls.Add(btnRestar);
            Controls.Add(btnMultiplicar);
            Controls.Add(btnDividir);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btnIgual);
            Controls.Add(btn0);
            Controls.Add(lblActual);
            Controls.Add(lblResumen);
            Name = "Calculadora";
            Text = "Calculadora";
            Load += Calculadora_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblResumen;
        private Label lblActual;
        private Button btn0;
        private Button btnIgual;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnDividir;
        private Button btnMultiplicar;
        private Button btnRestar;
        private Button btnSumar;
        private Label label3;
        private Label label4;
        private Button btnLimpiar;
        private ListBox lbHistorial;
    }
}
