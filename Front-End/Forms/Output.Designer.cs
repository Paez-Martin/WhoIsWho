namespace WiW
{
    partial class Output
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Output));
            this.barra = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnclose = new System.Windows.Forms.PictureBox();
            this.caras = new System.Windows.Forms.Panel();
            this.txt = new System.Windows.Forms.RichTextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.barra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnclose)).BeginInit();
            this.caras.SuspendLayout();
            this.SuspendLayout();
            // 
            // barra
            // 
            this.barra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.barra.Controls.Add(this.textBox1);
            this.barra.Controls.Add(this.btnclose);
            this.barra.Dock = System.Windows.Forms.DockStyle.Top;
            this.barra.Location = new System.Drawing.Point(0, 0);
            this.barra.Margin = new System.Windows.Forms.Padding(5);
            this.barra.Name = "barra";
            this.barra.Size = new System.Drawing.Size(1257, 58);
            this.barra.TabIndex = 0;
            this.barra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Drag);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(14, 10);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(126, 33);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Consultas";
            this.textBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Drag);
            // 
            // btnclose
            // 
            this.btnclose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnclose.Image = ((System.Drawing.Image)(resources.GetObject("btnclose.Image")));
            this.btnclose.Location = new System.Drawing.Point(1199, 7);
            this.btnclose.Margin = new System.Windows.Forms.Padding(5);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(39, 42);
            this.btnclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnclose.TabIndex = 0;
            this.btnclose.TabStop = false;
            // 
            // caras
            // 
            this.caras.AutoScroll = true;
            this.caras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.caras.Controls.Add(this.btnBack);
            this.caras.Controls.Add(this.txt);
            this.caras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.caras.Location = new System.Drawing.Point(0, 58);
            this.caras.Margin = new System.Windows.Forms.Padding(5);
            this.caras.Name = "caras";
            this.caras.Size = new System.Drawing.Size(1257, 859);
            this.caras.TabIndex = 3;
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(19, 35);
            this.txt.Margin = new System.Windows.Forms.Padding(5);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(1217, 716);
            this.txt.TabIndex = 3;
            this.txt.Text = "";
            this.txt.WordWrap = false;
            // 
            // BtnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("BtnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(1175, 782);
            this.btnBack.Margin = new System.Windows.Forms.Padding(5);
            this.btnBack.Name = "BtnBack";
            this.btnBack.Size = new System.Drawing.Size(63, 57);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = " ";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // Output
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 917);
            this.Controls.Add(this.caras);
            this.Controls.Add(this.barra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Output";
            this.Text = "Resultado";
            this.barra.ResumeLayout(false);
            this.barra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnclose)).EndInit();
            this.caras.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Panel barra;
        private PictureBox btnclose;
        private TextBox textBox1;
        private Form Parent;
        private Panel caras;
        private RichTextBox txt;
        private Button btnBack;
    }
}
