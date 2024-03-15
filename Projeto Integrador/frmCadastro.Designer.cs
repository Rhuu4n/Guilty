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
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCsenha = new System.Windows.Forms.Label();
            this.pb4 = new System.Windows.Forms.PictureBox();
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.pb5 = new System.Windows.Forms.PictureBox();
            this.lblNascimento = new System.Windows.Forms.Label();
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
            this.btnCadastrar.BackColor = System.Drawing.Color.Black;
            this.btnCadastrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.Location = new System.Drawing.Point(291, 544);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(119, 44);
            this.btnCadastrar.TabIndex = 52;
            this.btnCadastrar.TabStop = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click_2);
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(232)))), ((int)(((byte)(208)))));
            this.lblSenha.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblSenha.Font = new System.Drawing.Font("Minecraft", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.ForeColor = System.Drawing.Color.Black;
            this.lblSenha.Location = new System.Drawing.Point(196, 303);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(65, 16);
            this.lblSenha.TabIndex = 56;
            this.lblSenha.Text = "SENHA";
            this.lblSenha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(232)))), ((int)(((byte)(208)))));
            this.lblUser.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblUser.Font = new System.Drawing.Font("Minecraft", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.Black;
            this.lblUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUser.Location = new System.Drawing.Point(173, 249);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(88, 16);
            this.lblUser.TabIndex = 55;
            this.lblUser.Text = "USUARIO";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblUser.Click += new System.EventHandler(this.label1_Click);
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
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(232)))), ((int)(((byte)(208)))));
            this.lblEmail.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblEmail.Font = new System.Drawing.Font("Minecraft", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.Black;
            this.lblEmail.Location = new System.Drawing.Point(190, 416);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(67, 16);
            this.lblEmail.TabIndex = 60;
            this.lblEmail.Text = "E-MAIL";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCsenha
            // 
            this.lblCsenha.AutoSize = true;
            this.lblCsenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(232)))), ((int)(((byte)(208)))));
            this.lblCsenha.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblCsenha.Font = new System.Drawing.Font("Minecraft", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCsenha.ForeColor = System.Drawing.Color.Black;
            this.lblCsenha.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCsenha.Location = new System.Drawing.Point(60, 361);
            this.lblCsenha.Name = "lblCsenha";
            this.lblCsenha.Size = new System.Drawing.Size(179, 16);
            this.lblCsenha.TabIndex = 59;
            this.lblCsenha.Text = "CONFIRMAR SENHA";
            this.lblCsenha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // lblNascimento
            // 
            this.lblNascimento.AutoSize = true;
            this.lblNascimento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(232)))), ((int)(((byte)(208)))));
            this.lblNascimento.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblNascimento.Font = new System.Drawing.Font("Minecraft", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNascimento.ForeColor = System.Drawing.Color.Black;
            this.lblNascimento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNascimento.Location = new System.Drawing.Point(135, 472);
            this.lblNascimento.Name = "lblNascimento";
            this.lblNascimento.Size = new System.Drawing.Size(123, 16);
            this.lblNascimento.TabIndex = 63;
            this.lblNascimento.Text = "NASCIMENTO";
            this.lblNascimento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.Controls.Add(this.lblNascimento);
            this.Controls.Add(this.pb5);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblCsenha);
            this.Controls.Add(this.pb4);
            this.Controls.Add(this.pb3);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblUser);
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
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCsenha;
        private System.Windows.Forms.PictureBox pb4;
        private System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.PictureBox pb5;
        private System.Windows.Forms.Label lblNascimento;
        private System.Windows.Forms.PictureBox btnVoltar;
        private System.Windows.Forms.PictureBox pbMsenha1;
        private System.Windows.Forms.PictureBox pbMsenha2;
    }
}