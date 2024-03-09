namespace Projeto_Integrador
{
    partial class frmLobby
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLobby));
            this.btnIniciar = new System.Windows.Forms.Button();
            this.lblVez = new System.Windows.Forms.Label();
            this.lblJ1 = new System.Windows.Forms.Label();
            this.lblJ2 = new System.Windows.Forms.Label();
            this.lblJ3 = new System.Windows.Forms.Label();
            this.lblJ4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnVoltar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIniciar
            // 
            this.btnIniciar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIniciar.BackColor = System.Drawing.Color.Black;
            this.btnIniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIniciar.Font = new System.Drawing.Font("Minecraft", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIniciar.Location = new System.Drawing.Point(749, 605);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(123, 44);
            this.btnIniciar.TabIndex = 32;
            this.btnIniciar.Text = "Iniciar!";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnCriar_Click);
            // 
            // lblVez
            // 
            this.lblVez.AutoSize = true;
            this.lblVez.BackColor = System.Drawing.Color.Black;
            this.lblVez.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblVez.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblVez.Font = new System.Drawing.Font("Minecraft", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVez.ForeColor = System.Drawing.Color.White;
            this.lblVez.Location = new System.Drawing.Point(326, 144);
            this.lblVez.Name = "lblVez";
            this.lblVez.Size = new System.Drawing.Size(281, 50);
            this.lblVez.TabIndex = 41;
            this.lblVez.Text = "Jogadores:";
            // 
            // lblJ1
            // 
            this.lblJ1.AutoSize = true;
            this.lblJ1.BackColor = System.Drawing.Color.Black;
            this.lblJ1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblJ1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblJ1.Font = new System.Drawing.Font("Minecraft", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJ1.ForeColor = System.Drawing.Color.White;
            this.lblJ1.Location = new System.Drawing.Point(326, 195);
            this.lblJ1.Name = "lblJ1";
            this.lblJ1.Size = new System.Drawing.Size(253, 50);
            this.lblJ1.TabIndex = 42;
            this.lblJ1.Text = "Jogador 1";
            this.lblJ1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblJ2
            // 
            this.lblJ2.AutoSize = true;
            this.lblJ2.BackColor = System.Drawing.Color.Black;
            this.lblJ2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblJ2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblJ2.Font = new System.Drawing.Font("Minecraft", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJ2.ForeColor = System.Drawing.Color.White;
            this.lblJ2.Location = new System.Drawing.Point(326, 246);
            this.lblJ2.Name = "lblJ2";
            this.lblJ2.Size = new System.Drawing.Size(259, 50);
            this.lblJ2.TabIndex = 43;
            this.lblJ2.Text = "Jogador 2";
            // 
            // lblJ3
            // 
            this.lblJ3.AutoSize = true;
            this.lblJ3.BackColor = System.Drawing.Color.Black;
            this.lblJ3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblJ3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblJ3.Font = new System.Drawing.Font("Minecraft", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJ3.ForeColor = System.Drawing.Color.White;
            this.lblJ3.Location = new System.Drawing.Point(326, 297);
            this.lblJ3.Name = "lblJ3";
            this.lblJ3.Size = new System.Drawing.Size(259, 50);
            this.lblJ3.TabIndex = 44;
            this.lblJ3.Text = "Jogador 3";
            // 
            // lblJ4
            // 
            this.lblJ4.AutoSize = true;
            this.lblJ4.BackColor = System.Drawing.Color.Black;
            this.lblJ4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblJ4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblJ4.Font = new System.Drawing.Font("Minecraft", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJ4.ForeColor = System.Drawing.Color.White;
            this.lblJ4.Location = new System.Drawing.Point(326, 348);
            this.lblJ4.Name = "lblJ4";
            this.lblJ4.Size = new System.Drawing.Size(262, 50);
            this.lblJ4.TabIndex = 45;
            this.lblJ4.Text = "Jogador 4";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Font = new System.Drawing.Font("Minecraft", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(705, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 48);
            this.label5.TabIndex = 46;
            this.label5.Text = "label5";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblID
            // 
            this.lblID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.Black;
            this.lblID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblID.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblID.Font = new System.Drawing.Font("Minecraft", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.White;
            this.lblID.Location = new System.Drawing.Point(423, 9);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(276, 50);
            this.lblID.TabIndex = 47;
            this.lblID.Text = "Id da Sala:";
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Transparent;
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.Location = new System.Drawing.Point(12, 12);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(119, 44);
            this.btnVoltar.TabIndex = 65;
            this.btnVoltar.TabStop = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click_1);
            // 
            // frmLobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Projeto_Integrador.Properties.Resources._8_bit_factory_forest_cute_aesthetic_pc_au2735qwvpz5kiea;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblJ4);
            this.Controls.Add(this.lblJ3);
            this.Controls.Add(this.lblJ2);
            this.Controls.Add(this.lblJ1);
            this.Controls.Add(this.lblVez);
            this.Controls.Add(this.btnIniciar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLobby";
            this.Text = "frmLobby";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmLobby_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnVoltar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Label lblVez;
        private System.Windows.Forms.Label lblJ1;
        private System.Windows.Forms.Label lblJ2;
        private System.Windows.Forms.Label lblJ3;
        private System.Windows.Forms.Label lblJ4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.PictureBox btnVoltar;
    }
}