using tpf;

namespace WiW
{
    partial class Board
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Board));
            this.barra = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.controles = new System.Windows.Forms.Panel();
            this.pictureBoxNo = new System.Windows.Forms.PictureBox();
            this.pictureBoxSi = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnLevels = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnPaths = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnLeafs = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.requestLabel = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtPregunta = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnNo = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnYes = new System.Windows.Forms.Button();
            this.caras = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnNewGame = new System.Windows.Forms.Label();
            this.userQuerys = new System.Windows.Forms.ComboBox();
            this.userFace = new System.Windows.Forms.PictureBox();
            this.panel12 = new System.Windows.Forms.Panel();
            this.btnAsk = new System.Windows.Forms.Button();
            this.panel13 = new System.Windows.Forms.Panel();
            this.btnGuess = new System.Windows.Forms.Button();
            this.barra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.controles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.caras.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userFace)).BeginInit();
            this.SuspendLayout();
            // 
            // barra
            // 
            this.barra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.barra.Controls.Add(this.btnClose);
            this.barra.Dock = System.Windows.Forms.DockStyle.Top;
            this.barra.Location = new System.Drawing.Point(0, 0);
            this.barra.Margin = new System.Windows.Forms.Padding(5);
            this.barra.Name = "barra";
            this.barra.Size = new System.Drawing.Size(1509, 59);
            this.barra.TabIndex = 0;
            this.barra.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Drag);
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1459, 8);
            this.btnClose.Margin = new System.Windows.Forms.Padding(5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(39, 41);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            // 
            // controles
            // 
            this.controles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.controles.Controls.Add(this.pictureBoxNo);
            this.controles.Controls.Add(this.pictureBoxSi);
            this.controles.Controls.Add(this.panel6);
            this.controles.Controls.Add(this.btnLevels);
            this.controles.Controls.Add(this.panel5);
            this.controles.Controls.Add(this.btnPaths);
            this.controles.Controls.Add(this.panel3);
            this.controles.Controls.Add(this.btnLeafs);
            this.controles.Controls.Add(this.panel1);
            this.controles.Controls.Add(this.requestLabel);
            this.controles.Controls.Add(this.pictureBox2);
            this.controles.Controls.Add(this.txtPregunta);
            this.controles.Controls.Add(this.panel4);
            this.controles.Controls.Add(this.btnNo);
            this.controles.Controls.Add(this.panel2);
            this.controles.Controls.Add(this.btnYes);
            this.controles.Dock = System.Windows.Forms.DockStyle.Left;
            this.controles.Location = new System.Drawing.Point(0, 59);
            this.controles.Margin = new System.Windows.Forms.Padding(5);
            this.controles.Name = "controles";
            this.controles.Size = new System.Drawing.Size(351, 775);
            this.controles.TabIndex = 4;
            // 
            // pictureBoxNo
            // 
            this.pictureBoxNo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxNo.Image")));
            this.pictureBoxNo.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxNo.InitialImage")));
            this.pictureBoxNo.Location = new System.Drawing.Point(-39, 0);
            this.pictureBoxNo.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBoxNo.Name = "pictureBoxNo";
            this.pictureBoxNo.Size = new System.Drawing.Size(434, 230);
            this.pictureBoxNo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxNo.TabIndex = 21;
            this.pictureBoxNo.TabStop = false;
            this.pictureBoxNo.Visible = false;
            // 
            // pictureBoxSi
            // 
            this.pictureBoxSi.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSi.Image")));
            this.pictureBoxSi.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxSi.InitialImage")));
            this.pictureBoxSi.Location = new System.Drawing.Point(5, 0);
            this.pictureBoxSi.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBoxSi.Name = "pictureBoxSi";
            this.pictureBoxSi.Size = new System.Drawing.Size(434, 230);
            this.pictureBoxSi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSi.TabIndex = 20;
            this.pictureBoxSi.TabStop = false;
            this.pictureBoxSi.Visible = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel6.Location = new System.Drawing.Point(67, 695);
            this.panel6.Margin = new System.Windows.Forms.Padding(5);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(10, 44);
            this.panel6.TabIndex = 19;
            // 
            // btnLevels
            // 
            this.btnLevels.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnLevels.FlatAppearance.BorderSize = 0;
            this.btnLevels.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnLevels.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLevels.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLevels.ForeColor = System.Drawing.Color.White;
            this.btnLevels.Image = ((System.Drawing.Image)(resources.GetObject("btnLevels.Image")));
            this.btnLevels.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLevels.Location = new System.Drawing.Point(73, 695);
            this.btnLevels.Margin = new System.Windows.Forms.Padding(5);
            this.btnLevels.Name = "btnLevels";
            this.btnLevels.Size = new System.Drawing.Size(300, 44);
            this.btnLevels.TabIndex = 18;
            this.btnLevels.Text = "Profundidad";
            this.btnLevels.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel5.Location = new System.Drawing.Point(67, 626);
            this.panel5.Margin = new System.Windows.Forms.Padding(5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 44);
            this.panel5.TabIndex = 17;
            // 
            // btnPaths
            // 
            this.btnPaths.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnPaths.FlatAppearance.BorderSize = 0;
            this.btnPaths.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnPaths.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaths.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPaths.ForeColor = System.Drawing.Color.White;
            this.btnPaths.Image = ((System.Drawing.Image)(resources.GetObject("btnPaths.Image")));
            this.btnPaths.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPaths.Location = new System.Drawing.Point(73, 626);
            this.btnPaths.Margin = new System.Windows.Forms.Padding(5);
            this.btnPaths.Name = "btnPaths";
            this.btnPaths.Size = new System.Drawing.Size(300, 44);
            this.btnPaths.TabIndex = 16;
            this.btnPaths.Text = "Camino";
            this.btnPaths.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel3.Location = new System.Drawing.Point(67, 554);
            this.panel3.Margin = new System.Windows.Forms.Padding(5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 44);
            this.panel3.TabIndex = 15;
            // 
            // btnLeafs
            // 
            this.btnLeafs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnLeafs.FlatAppearance.BorderSize = 0;
            this.btnLeafs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnLeafs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeafs.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLeafs.ForeColor = System.Drawing.Color.White;
            this.btnLeafs.Image = ((System.Drawing.Image)(resources.GetObject("btnLeafs.Image")));
            this.btnLeafs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLeafs.Location = new System.Drawing.Point(73, 554);
            this.btnLeafs.Margin = new System.Windows.Forms.Padding(5);
            this.btnLeafs.Name = "btnLeafs";
            this.btnLeafs.Size = new System.Drawing.Size(300, 44);
            this.btnLeafs.TabIndex = 14;
            this.btnLeafs.Text = "Predicciones";
            this.btnLeafs.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel1.Location = new System.Drawing.Point(7, 470);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 44);
            this.panel1.TabIndex = 13;
            // 
            // requestLabel
            // 
            this.requestLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.requestLabel.FlatAppearance.BorderSize = 0;
            this.requestLabel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.requestLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.requestLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.requestLabel.ForeColor = System.Drawing.Color.White;
            this.requestLabel.Image = ((System.Drawing.Image)(resources.GetObject("requestLabel.Image")));
            this.requestLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.requestLabel.Location = new System.Drawing.Point(14, 470);
            this.requestLabel.Margin = new System.Windows.Forms.Padding(5);
            this.requestLabel.Name = "requestLabel";
            this.requestLabel.Size = new System.Drawing.Size(300, 44);
            this.requestLabel.TabIndex = 12;
            this.requestLabel.Text = "Consultas";
            this.requestLabel.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(351, 230);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // txtPregunta
            // 
            this.txtPregunta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.txtPregunta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPregunta.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPregunta.ForeColor = System.Drawing.Color.White;
            this.txtPregunta.Location = new System.Drawing.Point(7, 249);
            this.txtPregunta.Margin = new System.Windows.Forms.Padding(5);
            this.txtPregunta.Name = "txtPregunta";
            this.txtPregunta.ReadOnly = true;
            this.txtPregunta.Size = new System.Drawing.Size(414, 36);
            this.txtPregunta.TabIndex = 10;
            this.txtPregunta.Text = "Pregunta";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel4.Location = new System.Drawing.Point(7, 372);
            this.panel4.Margin = new System.Windows.Forms.Padding(5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 42);
            this.panel4.TabIndex = 8;
            // 
            // btnNo
            // 
            this.btnNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnNo.FlatAppearance.BorderSize = 0;
            this.btnNo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNo.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNo.ForeColor = System.Drawing.Color.White;
            this.btnNo.Image = ((System.Drawing.Image)(resources.GetObject("btnNo.Image")));
            this.btnNo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNo.Location = new System.Drawing.Point(14, 372);
            this.btnNo.Margin = new System.Windows.Forms.Padding(5);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(279, 42);
            this.btnNo.TabIndex = 9;
            this.btnNo.Text = "No";
            this.btnNo.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel2.Location = new System.Drawing.Point(7, 312);
            this.panel2.Margin = new System.Windows.Forms.Padding(5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(16, 50);
            this.panel2.TabIndex = 7;
            // 
            // btnYes
            // 
            this.btnYes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnYes.FlatAppearance.BorderSize = 0;
            this.btnYes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYes.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnYes.ForeColor = System.Drawing.Color.White;
            this.btnYes.Image = ((System.Drawing.Image)(resources.GetObject("btnYes.Image")));
            this.btnYes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYes.Location = new System.Drawing.Point(14, 312);
            this.btnYes.Margin = new System.Windows.Forms.Padding(5);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(279, 42);
            this.btnYes.TabIndex = 6;
            this.btnYes.Text = "Si";
            this.btnYes.UseVisualStyleBackColor = false;
            // 
            // caras
            // 
            this.caras.AutoScroll = true;
            this.caras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.caras.Controls.Add(this.panel7);
            this.caras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.caras.Location = new System.Drawing.Point(351, 59);
            this.caras.Margin = new System.Windows.Forms.Padding(5);
            this.caras.Name = "caras";
            this.caras.Size = new System.Drawing.Size(1158, 775);
            this.caras.TabIndex = 7;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel7.Controls.Add(this.btnNewGame);
            this.panel7.Controls.Add(this.userQuerys);
            this.panel7.Controls.Add(this.userFace);
            this.panel7.Controls.Add(this.panel12);
            this.panel7.Controls.Add(this.btnAsk);
            this.panel7.Controls.Add(this.panel13);
            this.panel7.Controls.Add(this.btnGuess);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(757, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(5);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(401, 775);
            this.panel7.TabIndex = 5;
            // 
            // btnNewGame
            // 
            this.btnNewGame.AutoSize = true;
            this.btnNewGame.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNewGame.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNewGame.Location = new System.Drawing.Point(163, 708);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(184, 40);
            this.btnNewGame.TabIndex = 14;
            this.btnNewGame.Text = "Nuevo Juego";
            // 
            // userQuerys
            // 
            this.userQuerys.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userQuerys.FormattingEnabled = true;
            this.userQuerys.Location = new System.Drawing.Point(5, 299);
            this.userQuerys.Margin = new System.Windows.Forms.Padding(5);
            this.userQuerys.Name = "userQuerys";
            this.userQuerys.Size = new System.Drawing.Size(391, 45);
            this.userQuerys.TabIndex = 13;
            // 
            // userFace
            // 
            this.userFace.Dock = System.Windows.Forms.DockStyle.Top;
            this.userFace.Image = ((System.Drawing.Image)(resources.GetObject("userFace.Image")));
            this.userFace.Location = new System.Drawing.Point(0, 0);
            this.userFace.Margin = new System.Windows.Forms.Padding(5);
            this.userFace.Name = "userFace";
            this.userFace.Size = new System.Drawing.Size(401, 230);
            this.userFace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userFace.TabIndex = 11;
            this.userFace.TabStop = false;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel12.Location = new System.Drawing.Point(303, 391);
            this.panel12.Margin = new System.Windows.Forms.Padding(5);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(16, 50);
            this.panel12.TabIndex = 8;
            // 
            // btnAsk
            // 
            this.btnAsk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnAsk.FlatAppearance.BorderSize = 0;
            this.btnAsk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnAsk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsk.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAsk.ForeColor = System.Drawing.Color.White;
            this.btnAsk.Image = ((System.Drawing.Image)(resources.GetObject("btnAsk.Image")));
            this.btnAsk.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAsk.Location = new System.Drawing.Point(0, 391);
            this.btnAsk.Margin = new System.Windows.Forms.Padding(5);
            this.btnAsk.Name = "btnAsk";
            this.btnAsk.Size = new System.Drawing.Size(309, 50);
            this.btnAsk.TabIndex = 9;
            this.btnAsk.Text = "Preguntar";
            this.btnAsk.UseVisualStyleBackColor = false;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel13.Location = new System.Drawing.Point(303, 470);
            this.panel13.Margin = new System.Windows.Forms.Padding(5);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(16, 50);
            this.panel13.TabIndex = 7;
            // 
            // btnGuess
            // 
            this.btnGuess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnGuess.FlatAppearance.BorderSize = 0;
            this.btnGuess.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnGuess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuess.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGuess.ForeColor = System.Drawing.Color.White;
            this.btnGuess.Image = ((System.Drawing.Image)(resources.GetObject("btnGuess.Image")));
            this.btnGuess.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuess.Location = new System.Drawing.Point(0, 470);
            this.btnGuess.Margin = new System.Windows.Forms.Padding(5);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(309, 50);
            this.btnGuess.TabIndex = 6;
            this.btnGuess.Text = "Arriesgar";
            this.btnGuess.UseVisualStyleBackColor = false;
            // 
            // Board
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1509, 834);
            this.Controls.Add(this.caras);
            this.Controls.Add(this.controles);
            this.Controls.Add(this.barra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Board";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "¿Quien es?";
            this.barra.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.controles.ResumeLayout(false);
            this.controles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.caras.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userFace)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel barra;
        private PictureBox btnClose;
        private Panel controles;
        public PictureBox pictureBox2;
        private TextBox txtPregunta;
        private Panel panel4;
        private Button btnNo;
        private Panel panel2;
        private Button btnYes;
        private Panel caras;
        private Panel panel1;
        private Button requestLabel;
        private Panel panel3;
        private Button btnLeafs;
        private Panel panel6;
        private Button btnLevels;
        private Panel panel5;
        private Button btnPaths;
        public PictureBox pictureBoxSi;
        public PictureBox pictureBoxNo;
        private Panel panel7;
        public PictureBox userFace;
        private Panel panel12;
        private Button btnAsk;
        private Panel panel13;
        private Button btnGuess;
        private ComboBox userQuerys;
        private Label btnNewGame;
    }
}