namespace quadratic_solver
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblFuncion = new Label();
            groupBox1 = new GroupBox();
            txtC = new TextBox();
            label7 = new Label();
            txtB = new TextBox();
            label6 = new Label();
            txtA = new TextBox();
            label5 = new Label();
            groupBox2 = new GroupBox();
            txtX2 = new TextBox();
            label9 = new Label();
            txtX1 = new TextBox();
            label8 = new Label();
            btnCalcular = new Button();
            btnBorrar = new Button();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.IndianRed;
            pictureBox1.Location = new Point(-1, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1460, 99);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.IndianRed;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(55, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(135, 96);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.IndianRed;
            label1.Font = new Font("Dubai", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SeaShell;
            label1.Location = new Point(989, 9);
            label1.Name = "label1";
            label1.Size = new Size(370, 79);
            label1.TabIndex = 2;
            label1.Text = "Quadratic Solver";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.SeaShell;
            label2.Font = new Font("Dubai", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(478, 120);
            label2.Name = "label2";
            label2.Size = new Size(438, 75);
            label2.TabIndex = 3;
            label2.Text = "Calculadora de Raices";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(263, 180);
            label3.Name = "label3";
            label3.Size = new Size(839, 56);
            label3.TabIndex = 4;
            label3.Text = "Ingrese los valores de los coeficientes para la ecuación ax² + bx + c = 0 y el programa calculará \r\nlas raíces correspondientes.";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFuncion
            // 
            lblFuncion.AutoSize = true;
            lblFuncion.BackColor = Color.IndianRed;
            lblFuncion.Font = new Font("Calibri", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFuncion.ForeColor = Color.SeaShell;
            lblFuncion.Location = new Point(603, 260);
            lblFuncion.Name = "lblFuncion";
            lblFuncion.Size = new Size(143, 41);
            lblFuncion.TabIndex = 5;
            lblFuncion.Text = "ax²+bx+c";
            lblFuncion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtC);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtB);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtA);
            groupBox1.Controls.Add(label5);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.IndianRed;
            groupBox1.Location = new Point(227, 328);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(953, 105);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Valores";
            // 
            // txtC
            // 
            txtC.BackColor = Color.BlanchedAlmond;
            txtC.ForeColor = Color.IndianRed;
            txtC.Location = new Point(671, 46);
            txtC.Multiline = true;
            txtC.Name = "txtC";
            txtC.Size = new Size(73, 36);
            txtC.TabIndex = 5;
            txtC.TextAlign = HorizontalAlignment.Center;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Symbol", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Gray;
            label7.Location = new Point(574, 46);
            label7.Name = "label7";
            label7.Size = new Size(91, 31);
            label7.TabIndex = 4;
            label7.Text = "Valor c";
            // 
            // txtB
            // 
            txtB.BackColor = Color.BlanchedAlmond;
            txtB.ForeColor = Color.IndianRed;
            txtB.Location = new Point(463, 46);
            txtB.Multiline = true;
            txtB.Name = "txtB";
            txtB.Size = new Size(73, 36);
            txtB.TabIndex = 3;
            txtB.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Symbol", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Gray;
            label6.Location = new Point(363, 46);
            label6.Name = "label6";
            label6.Size = new Size(94, 31);
            label6.TabIndex = 2;
            label6.Text = "Valor b";
            label6.Click += label6_Click;
            // 
            // txtA
            // 
            txtA.BackColor = Color.BlanchedAlmond;
            txtA.ForeColor = Color.IndianRed;
            txtA.Location = new Point(258, 46);
            txtA.Multiline = true;
            txtA.Name = "txtA";
            txtA.Size = new Size(73, 36);
            txtA.TabIndex = 1;
            txtA.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Symbol", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Gray;
            label5.Location = new Point(160, 46);
            label5.Name = "label5";
            label5.Size = new Size(92, 31);
            label5.TabIndex = 0;
            label5.Text = "Valor a";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtX2);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(txtX1);
            groupBox2.Controls.Add(label8);
            groupBox2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.IndianRed;
            groupBox2.Location = new Point(227, 523);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(953, 105);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Raices";
            // 
            // txtX2
            // 
            txtX2.BackColor = Color.BlanchedAlmond;
            txtX2.ForeColor = Color.IndianRed;
            txtX2.Location = new Point(564, 46);
            txtX2.Multiline = true;
            txtX2.Name = "txtX2";
            txtX2.Size = new Size(73, 36);
            txtX2.TabIndex = 9;
            txtX2.TextAlign = HorizontalAlignment.Center;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Symbol", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Gray;
            label9.Location = new Point(516, 44);
            label9.Name = "label9";
            label9.Size = new Size(42, 38);
            label9.TabIndex = 8;
            label9.Text = "x₂";
            // 
            // txtX1
            // 
            txtX1.BackColor = Color.BlanchedAlmond;
            txtX1.ForeColor = Color.IndianRed;
            txtX1.Location = new Point(363, 46);
            txtX1.Multiline = true;
            txtX1.Name = "txtX1";
            txtX1.Size = new Size(73, 36);
            txtX1.TabIndex = 7;
            txtX1.TextAlign = HorizontalAlignment.Center;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Symbol", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Gray;
            label8.Location = new Point(315, 44);
            label8.Name = "label8";
            label8.Size = new Size(42, 38);
            label8.TabIndex = 6;
            label8.Text = "x₁";
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.IndianRed;
            btnCalcular.FlatStyle = FlatStyle.Flat;
            btnCalcular.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalcular.ForeColor = Color.SeaShell;
            btnCalcular.Location = new Point(603, 451);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(143, 44);
            btnCalcular.TabIndex = 8;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            // 
            // btnBorrar
            // 
            btnBorrar.BackColor = Color.IndianRed;
            btnBorrar.FlatStyle = FlatStyle.Flat;
            btnBorrar.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBorrar.ForeColor = Color.SeaShell;
            btnBorrar.Location = new Point(478, 680);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(143, 44);
            btnBorrar.TabIndex = 9;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.IndianRed;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = Color.SeaShell;
            btnSalir.Location = new Point(773, 680);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(143, 44);
            btnSalir.TabIndex = 10;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            ClientSize = new Size(1421, 774);
            Controls.Add(btnSalir);
            Controls.Add(btnBorrar);
            Controls.Add(btnCalcular);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(lblFuncion);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            ForeColor = Color.IndianRed;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Inicio";
            Text = "Quadratic Solver";
            Load += this.Inicio_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblFuncion;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnCalcular;
        private TextBox txtA;
        private Label label5;
        private Button btnBorrar;
        private Button btnSalir;
        private TextBox txtC;
        private Label label7;
        private TextBox txtB;
        private Label label6;
        private TextBox txtX1;
        private Label label8;
        private TextBox txtX2;
        private Label label9;
    }
}
