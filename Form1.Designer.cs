namespace ejercicio_3_practica_2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblcantidad = new Label();
            lblpromedio = new Label();
            lblsuma = new Label();
            txtboxnum = new TextBox();
            btnAgregar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(256, 54);
            label1.Name = "label1";
            label1.Size = new Size(122, 20);
            label1.TabIndex = 0;
            label1.Text = "Insertar numeros:";
            // 
            // label2
            // 
            label2.Location = new Point(301, 182);
            label2.Name = "label2";
            label2.Size = new Size(54, 26);
            label2.TabIndex = 1;
            label2.Text = "Suma:";
            // 
            // label3
            // 
            label3.Location = new Point(278, 301);
            label3.Name = "label3";
            label3.Size = new Size(77, 26);
            label3.TabIndex = 2;
            label3.Text = "Promedio:";
            // 
            // label4
            // 
            label4.Location = new Point(218, 241);
            label4.Name = "label4";
            label4.Size = new Size(137, 26);
            label4.TabIndex = 3;
            label4.Text = "Valores agregados:";
            // 
            // lblcantidad
            // 
            lblcantidad.BorderStyle = BorderStyle.Fixed3D;
            lblcantidad.Location = new Point(400, 241);
            lblcantidad.Name = "lblcantidad";
            lblcantidad.Size = new Size(77, 26);
            lblcantidad.TabIndex = 6;
            // 
            // lblpromedio
            // 
            lblpromedio.BorderStyle = BorderStyle.Fixed3D;
            lblpromedio.Location = new Point(400, 301);
            lblpromedio.Name = "lblpromedio";
            lblpromedio.Size = new Size(77, 26);
            lblpromedio.TabIndex = 5;
            // 
            // lblsuma
            // 
            lblsuma.BorderStyle = BorderStyle.Fixed3D;
            lblsuma.Location = new Point(400, 182);
            lblsuma.Name = "lblsuma";
            lblsuma.Size = new Size(77, 26);
            lblsuma.TabIndex = 4;
            // 
            // txtboxnum
            // 
            txtboxnum.Location = new Point(384, 51);
            txtboxnum.Name = "txtboxnum";
            txtboxnum.Size = new Size(125, 27);
            txtboxnum.TabIndex = 7;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(415, 100);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 8;
            btnAgregar.Text = "agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAgregar);
            Controls.Add(txtboxnum);
            Controls.Add(lblcantidad);
            Controls.Add(lblpromedio);
            Controls.Add(lblsuma);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblcantidad;
        private Label lblpromedio;
        private Label lblsuma;
        private TextBox txtboxnum;
        private Button btnAgregar;
    }
}
