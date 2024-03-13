namespace Projeto_Integrador
{
    partial class frmCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastro));
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtSenha2 = new System.Windows.Forms.TextBox();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.cbSenha2 = new System.Windows.Forms.CheckBox();
            this.cbSenha = new System.Windows.Forms.CheckBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.pbGuilty = new System.Windows.Forms.PictureBox();
            this.btnCadastrar = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pb4 = new System.Windows.Forms.PictureBox();
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.pb5 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.PictureBox();
            this.pbMsenha1 = new System.Windows.Forms.PictureBox();
            this.pbMsenha2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbGuilty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCadastrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVoltar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMsenha1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMsenha2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Minecraft", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(291, 518);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(186, 25);
            this.txtID.TabIndex = 49;
            this.txtID.Visible = false;
            // 
            // txtSenha2
            // 
            this.txtSenha2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSenha2.Font = new System.Drawing.Font("Minecraft", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha2.Location = new System.Drawing.Point(291, 361);
            this.txtSenha2.Name = "txtSenha2";
            this.txtSenha2.Size = new System.Drawing.Size(186, 25);
            this.txtSenha2.TabIndex = 42;
            this.txtSenha2.UseSystemPasswordChar = true;
            this.txtSenha2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSenha2_KeyPress_1);
            // 
            // txtIdade
            // 
            this.txtIdade.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdade.Font = new System.Drawing.Font("Minecraft", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdade.Location = new System.Drawing.Point(291, 469);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(186, 25);
            this.txtIdade.TabIndex = 41;
            this.txtIdade.Text = "10/10/2010";
            // 
            // cbSenha2
            // 
            this.cbSenha2.AutoSize = true;
            this.cbSenha2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(232)))), ((int)(((byte)(208)))));
            this.cbSenha2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbSenha2.Font = new System.Drawing.Font("Minecraft", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSenha2.ForeColor = System.Drawing.Color.Black;
            this.cbSenha2.Location = new System.Drawing.Point(512, 363);
            this.cbSenha2.Name = "cbSenha2";
            this.cbSenha2.Size = new System.Drawing.Size(150, 20);
            this.cbSenha2.TabIndex = 38;
            this.cbSenha2.Text = "Mostrar senha";
            this.cbSenha2.UseVisualStyleBackColor = false;
            this.cbSenha2.CheckedChanged += new System.EventHandler(this.cbSenha2_CheckedChanged);
            // 
            // cbSenha
            // 
            this.cbSenha.AutoSize = true;
            this.cbSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(232)))), ((int)(((byte)(208)))));
            this.cbSenha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbSenha.Font = new System.Drawing.Font("Minecraft", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSenha.ForeColor = System.Drawing.Color.Black;
            this.cbSenha.Location = new System.Drawing.Point(512, 308);
            this.cbSenha.Name = "cbSenha";
            this.cbSenha.Size = new System.Drawing.Size(150, 20);
            this.cbSenha.TabIndex = 36;
            this.cbSenha.Text = "Mostrar senha";
            this.cbSenha.UseVisualStyleBackColor = false;
            this.cbSenha.CheckedChanged += new System.EventHandler(this.cbSenha_CheckedChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.Font = new System.Drawing.Font("Minecraft", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(291, 413);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(186, 25);
            this.txtEmail.TabIndex = 31;
            this.txtEmail.Text = "Email@email.com";
            // 
            // txtSenha
            // 
            this.txtSenha.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSenha.Font = new System.Drawing.Font("Minecraft", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(291, 303);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(186, 25);
            this.txtSenha.TabIndex = 27;
            this.txtSenha.Text = "1234";
            this.txtSenha.UseSystemPasswordChar = true;
            this.txtSenha.TextChanged += new System.EventHandler(this.txtSenha_TextChanged);
            this.txtSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSenha_KeyPress);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsuario.Font = new System.Drawing.Font("Minecraft", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(291, 241);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(186, 25);
            this.txtUsuario.TabIndex = 26;
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_KeyPress);
            // 
            // pbGuilty
            // 
            this.pbGuilty.BackColor = System.Drawing.Color.Black;
            this.pbGuilty.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbGuilty.Location = new System.Drawing.Point(234, -1);
            this.pbGuilty.Name = "pbGuilty";
            this.pbGuilty.Size = new System.Drawing.Size(233, 222);
            this.pbGuilty.TabIndex = 39;
            this.pbGuilty.TabStop = false;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCadastrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCadastrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.Location = new System.Drawing.Point(291, 544);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(119, 44);
            this.btnCadastrar.TabIndex = 52;
            this.btnCadastrar.TabStop = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click_2);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(232)))), ((int)(((byte)(208)))));
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("Minecraft", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(196, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 56;
            this.label2.Text = "SENHA";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(232)))), ((int)(((byte)(208)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Minecraft", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(173, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 55;
            this.label1.Text = "USUARIO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
//            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pb2
            // 
            this.pb2.BackColor = System.Drawing.Color.Black;
            this.pb2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb2.Location = new System.Drawing.Point(177, 290);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(108, 50);
            this.pb2.TabIndex = 54;
            this.pb2.TabStop = false;
            // 
            // pb1
            // 
            this.pb1.BackColor = System.Drawing.Color.Black;
            this.pb1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb1.Location = new System.Drawing.Point(155, 234);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(130, 50);
            this.pb1.TabIndex = 53;
            this.pb1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(232)))), ((int)(((byte)(208)))));
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label4.Font = new System.Drawing.Font("Minecraft", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(190, 416);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 60;
            this.label4.Text = "E-MAIL";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(232)))), ((int)(((byte)(208)))));
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label5.Font = new System.Drawing.Font("Minecraft", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(60, 361);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 16);
            this.label5.TabIndex = 59;
            this.label5.Text = "CONFIRMAR SENHA";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pb4
            // 
            this.pb4.BackColor = System.Drawing.Color.Black;
            this.pb4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb4.Location = new System.Drawing.Point(177, 402);
            this.pb4.Name = "pb4";
            this.pb4.Size = new System.Drawing.Size(108, 50);
            this.pb4.TabIndex = 58;
            this.pb4.TabStop = false;
            // 
            // pb3
            // 
            this.pb3.BackColor = System.Drawing.Color.Black;
            this.pb3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb3.Location = new System.Drawing.Point(27, 346);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(258, 50);
            this.pb3.TabIndex = 57;
            this.pb3.TabStop = false;
            // 
            // pb5
            // 
            this.pb5.BackColor = System.Drawing.Color.Black;
            this.pb5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb5.Location = new System.Drawing.Point(114, 458);
            this.pb5.Name = "pb5";
            this.pb5.Size = new System.Drawing.Size(171, 50);
            this.pb5.TabIndex = 61;
            this.pb5.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(232)))), ((int)(((byte)(208)))));
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label8.Font = new System.Drawing.Font("Minecraft", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Location = new System.Drawing.Point(135, 472);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 16);
            this.label8.TabIndex = 63;
            this.label8.Text = "NASCIMENTO";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnVoltar.BackColor = System.Drawing.Color.Transparent;
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.Location = new System.Drawing.Point(12, 21);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(119, 44);
            this.btnVoltar.TabIndex = 64;
            this.btnVoltar.TabStop = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click_1);
            // 
            // pbMsenha1
            // 
            this.pbMsenha1.BackColor = System.Drawing.Color.Black;
            this.pbMsenha1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbMsenha1.Location = new System.Drawing.Point(483, 290);
            this.pbMsenha1.Name = "pbMsenha1";
            this.pbMsenha1.Size = new System.Drawing.Size(205, 50);
            this.pbMsenha1.TabIndex = 65;
            this.pbMsenha1.TabStop = false;
            // 
            // pbMsenha2
            // 
            this.pbMsenha2.BackColor = System.Drawing.Color.Black;
            this.pbMsenha2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbMsenha2.Location = new System.Drawing.Point(483, 346);
            this.pbMsenha2.Name = "pbMsenha2";
            this.pbMsenha2.Size = new System.Drawing.Size(205, 50);
            this.pbMsenha2.TabIndex = 66;
            this.pbMsenha2.TabStop = false;
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(700, 600);
            this.ControlBox = false;
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pb5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pb4);
            this.Controls.Add(this.pb3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.pbGuilty);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtSenha2);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.cbSenha2);
            this.Controls.Add(this.cbSenha);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.pbMsenha2);
            this.Controls.Add(this.pbMsenha1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guilty";
            this.Resize += new System.EventHandler(this.frmCadastro_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pbGuilty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCadastrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnVoltar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMsenha1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMsenha2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox cbSenha2;
        private System.Windows.Forms.CheckBox cbSenha;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.PictureBox pbGuilty;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.TextBox txtSenha2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.PictureBox btnCadastrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pb4;
        private System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.PictureBox pb5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox btnVoltar;
        private System.Windows.Forms.PictureBox pbMsenha1;
        private System.Windows.Forms.PictureBox pbMsenha2;
    }
}