namespace RangementCarte
{
	partial class Form1
	{
		/// <summary>
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Nettoyage des ressources utilisées.
		/// </summary>
		/// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Code généré par le Concepteur Windows Form

		/// <summary>
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.grpBIdentification = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.TxtUsername = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.TxtPassword = new System.Windows.Forms.TextBox();
			this.btnLogin = new System.Windows.Forms.Button();
			this.btnLogout = new System.Windows.Forms.Button();
			this.btnCarteRangement = new System.Windows.Forms.Button();
			this.btnCarteSendUsinier = new System.Windows.Forms.Button();
			this.lblNbreCarteRange = new System.Windows.Forms.Label();
			this.labelNbreCarteRange = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.grpBIdentification.SuspendLayout();
			this.SuspendLayout();
			// 
			// grpBIdentification
			// 
			this.grpBIdentification.Controls.Add(this.btnLogin);
			this.grpBIdentification.Controls.Add(this.TxtPassword);
			this.grpBIdentification.Controls.Add(this.label2);
			this.grpBIdentification.Controls.Add(this.TxtUsername);
			this.grpBIdentification.Controls.Add(this.label1);
			this.grpBIdentification.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grpBIdentification.Location = new System.Drawing.Point(280, 103);
			this.grpBIdentification.Name = "grpBIdentification";
			this.grpBIdentification.Size = new System.Drawing.Size(448, 252);
			this.grpBIdentification.TabIndex = 0;
			this.grpBIdentification.TabStop = false;
			this.grpBIdentification.Text = "Identification Utilisateur";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(26, 71);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(86, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Username";
			// 
			// TxtUsername
			// 
			this.TxtUsername.Location = new System.Drawing.Point(167, 65);
			this.TxtUsername.Name = "TxtUsername";
			this.TxtUsername.Size = new System.Drawing.Size(238, 26);
			this.TxtUsername.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(26, 125);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(83, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "Password";
			// 
			// TxtPassword
			// 
			this.TxtPassword.Location = new System.Drawing.Point(167, 120);
			this.TxtPassword.Name = "TxtPassword";
			this.TxtPassword.PasswordChar = '*';
			this.TxtPassword.Size = new System.Drawing.Size(238, 26);
			this.TxtPassword.TabIndex = 3;
			// 
			// btnLogin
			// 
			this.btnLogin.Location = new System.Drawing.Point(29, 187);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(140, 42);
			this.btnLogin.TabIndex = 4;
			this.btnLogin.Text = "Login";
			this.btnLogin.UseVisualStyleBackColor = true;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// btnLogout
			// 
			this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLogout.Location = new System.Drawing.Point(795, 23);
			this.btnLogout.Name = "btnLogout";
			this.btnLogout.Size = new System.Drawing.Size(125, 41);
			this.btnLogout.TabIndex = 1;
			this.btnLogout.Text = "Log out";
			this.btnLogout.UseVisualStyleBackColor = true;
			this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
			// 
			// btnCarteRangement
			// 
			this.btnCarteRangement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCarteRangement.Location = new System.Drawing.Point(12, 111);
			this.btnCarteRangement.Name = "btnCarteRangement";
			this.btnCarteRangement.Size = new System.Drawing.Size(211, 60);
			this.btnCarteRangement.TabIndex = 2;
			this.btnCarteRangement.Text = "Carte en stock";
			this.btnCarteRangement.UseVisualStyleBackColor = true;
			this.btnCarteRangement.Click += new System.EventHandler(this.btnCarteRangement_Click);
			// 
			// btnCarteSendUsinier
			// 
			this.btnCarteSendUsinier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCarteSendUsinier.Location = new System.Drawing.Point(12, 194);
			this.btnCarteSendUsinier.Name = "btnCarteSendUsinier";
			this.btnCarteSendUsinier.Size = new System.Drawing.Size(211, 60);
			this.btnCarteSendUsinier.TabIndex = 3;
			this.btnCarteSendUsinier.Text = "Cartes envoyées aux Usiniers";
			this.btnCarteSendUsinier.UseVisualStyleBackColor = true;
			this.btnCarteSendUsinier.Click += new System.EventHandler(this.btnCarteSendUsinier_Click);
			// 
			// lblNbreCarteRange
			// 
			this.lblNbreCarteRange.AutoSize = true;
			this.lblNbreCarteRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNbreCarteRange.ForeColor = System.Drawing.Color.Red;
			this.lblNbreCarteRange.Location = new System.Drawing.Point(329, 29);
			this.lblNbreCarteRange.Name = "lblNbreCarteRange";
			this.lblNbreCarteRange.Size = new System.Drawing.Size(162, 29);
			this.lblNbreCarteRange.TabIndex = 5;
			this.lblNbreCarteRange.Text = "LblNbreCarte";
			// 
			// labelNbreCarteRange
			// 
			this.labelNbreCarteRange.AutoSize = true;
			this.labelNbreCarteRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelNbreCarteRange.Location = new System.Drawing.Point(12, 23);
			this.labelNbreCarteRange.Name = "labelNbreCarteRange";
			this.labelNbreCarteRange.Size = new System.Drawing.Size(271, 36);
			this.labelNbreCarteRange.TabIndex = 6;
			this.labelNbreCarteRange.Text = "Nbre Carte Rangé :";
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(932, 503);
			this.Controls.Add(this.labelNbreCarteRange);
			this.Controls.Add(this.lblNbreCarteRange);
			this.Controls.Add(this.btnCarteSendUsinier);
			this.Controls.Add(this.btnCarteRangement);
			this.Controls.Add(this.btnLogout);
			this.Controls.Add(this.grpBIdentification);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Rangement des cartes planteurs";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.grpBIdentification.ResumeLayout(false);
			this.grpBIdentification.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox grpBIdentification;
		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.TextBox TxtPassword;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox TxtUsername;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnLogout;
		private System.Windows.Forms.Button btnCarteRangement;
		private System.Windows.Forms.Button btnCarteSendUsinier;
		private System.Windows.Forms.Label lblNbreCarteRange;
		private System.Windows.Forms.Label labelNbreCarteRange;
		private System.Windows.Forms.Timer timer1;
	}
}

