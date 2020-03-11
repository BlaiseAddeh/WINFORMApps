namespace RangementCarte
{
	partial class FrmCarteRangement
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.rdbE = new System.Windows.Forms.RadioButton();
			this.rdbD = new System.Windows.Forms.RadioButton();
			this.rdbC = new System.Windows.Forms.RadioButton();
			this.rdbB = new System.Windows.Forms.RadioButton();
			this.rdbA = new System.Windows.Forms.RadioButton();
			this.TxtMatriculeNat = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnValider = new System.Windows.Forms.Button();
			this.dgvListCard = new System.Windows.Forms.DataGridView();
			this.TxtNewMatricule = new System.Windows.Forms.TextBox();
			this.labelMatriculeCorrect = new System.Windows.Forms.Label();
			this.btnAnnulerModification = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvListCard)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.rdbE);
			this.groupBox1.Controls.Add(this.rdbD);
			this.groupBox1.Controls.Add(this.rdbC);
			this.groupBox1.Controls.Add(this.rdbB);
			this.groupBox1.Controls.Add(this.rdbA);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(21, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(753, 100);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Boxes de rangement";
			// 
			// rdbE
			// 
			this.rdbE.AutoSize = true;
			this.rdbE.Location = new System.Drawing.Point(598, 38);
			this.rdbE.Name = "rdbE";
			this.rdbE.Size = new System.Drawing.Size(96, 29);
			this.rdbE.TabIndex = 4;
			this.rdbE.TabStop = true;
			this.rdbE.Text = "Boxe E";
			this.rdbE.UseVisualStyleBackColor = true;
			// 
			// rdbD
			// 
			this.rdbD.AutoSize = true;
			this.rdbD.Location = new System.Drawing.Point(446, 38);
			this.rdbD.Name = "rdbD";
			this.rdbD.Size = new System.Drawing.Size(97, 29);
			this.rdbD.TabIndex = 3;
			this.rdbD.TabStop = true;
			this.rdbD.Text = "Boxe D";
			this.rdbD.UseVisualStyleBackColor = true;
			// 
			// rdbC
			// 
			this.rdbC.AutoSize = true;
			this.rdbC.Location = new System.Drawing.Point(312, 38);
			this.rdbC.Name = "rdbC";
			this.rdbC.Size = new System.Drawing.Size(98, 29);
			this.rdbC.TabIndex = 2;
			this.rdbC.TabStop = true;
			this.rdbC.Text = "Boxe C";
			this.rdbC.UseVisualStyleBackColor = true;
			// 
			// rdbB
			// 
			this.rdbB.AutoSize = true;
			this.rdbB.Location = new System.Drawing.Point(168, 38);
			this.rdbB.Name = "rdbB";
			this.rdbB.Size = new System.Drawing.Size(96, 29);
			this.rdbB.TabIndex = 1;
			this.rdbB.TabStop = true;
			this.rdbB.Text = "Boxe B";
			this.rdbB.UseVisualStyleBackColor = true;
			// 
			// rdbA
			// 
			this.rdbA.AutoSize = true;
			this.rdbA.Location = new System.Drawing.Point(28, 38);
			this.rdbA.Name = "rdbA";
			this.rdbA.Size = new System.Drawing.Size(97, 29);
			this.rdbA.TabIndex = 0;
			this.rdbA.TabStop = true;
			this.rdbA.Text = "Boxe A";
			this.rdbA.UseVisualStyleBackColor = true;
			// 
			// TxtMatriculeNat
			// 
			this.TxtMatriculeNat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.TxtMatriculeNat.Location = new System.Drawing.Point(21, 167);
			this.TxtMatriculeNat.Name = "TxtMatriculeNat";
			this.TxtMatriculeNat.Size = new System.Drawing.Size(753, 22);
			this.TxtMatriculeNat.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(18, 126);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(325, 29);
			this.label1.TabIndex = 2;
			this.label1.Text = "Saisir le matricule national :";
			// 
			// btnValider
			// 
			this.btnValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnValider.ForeColor = System.Drawing.Color.Red;
			this.btnValider.Location = new System.Drawing.Point(21, 267);
			this.btnValider.Name = "btnValider";
			this.btnValider.Size = new System.Drawing.Size(244, 52);
			this.btnValider.TabIndex = 3;
			this.btnValider.Text = "VALIDER";
			this.btnValider.UseVisualStyleBackColor = true;
			this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
			// 
			// dgvListCard
			// 
			this.dgvListCard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvListCard.Location = new System.Drawing.Point(23, 340);
			this.dgvListCard.Name = "dgvListCard";
			this.dgvListCard.RowHeadersWidth = 51;
			this.dgvListCard.RowTemplate.Height = 24;
			this.dgvListCard.Size = new System.Drawing.Size(751, 203);
			this.dgvListCard.TabIndex = 4;
			this.dgvListCard.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListCard_CellContentClick);
			// 
			// TxtNewMatricule
			// 
			this.TxtNewMatricule.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.TxtNewMatricule.Location = new System.Drawing.Point(23, 218);
			this.TxtNewMatricule.Name = "TxtNewMatricule";
			this.TxtNewMatricule.Size = new System.Drawing.Size(590, 22);
			this.TxtNewMatricule.TabIndex = 5;
			// 
			// labelMatriculeCorrect
			// 
			this.labelMatriculeCorrect.AutoSize = true;
			this.labelMatriculeCorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelMatriculeCorrect.ForeColor = System.Drawing.Color.Coral;
			this.labelMatriculeCorrect.Location = new System.Drawing.Point(23, 194);
			this.labelMatriculeCorrect.Name = "labelMatriculeCorrect";
			this.labelMatriculeCorrect.Size = new System.Drawing.Size(146, 18);
			this.labelMatriculeCorrect.TabIndex = 6;
			this.labelMatriculeCorrect.Text = "Matricule correct :";
			// 
			// btnAnnulerModification
			// 
			this.btnAnnulerModification.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnAnnulerModification.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAnnulerModification.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.btnAnnulerModification.Location = new System.Drawing.Point(632, 214);
			this.btnAnnulerModification.Name = "btnAnnulerModification";
			this.btnAnnulerModification.Size = new System.Drawing.Size(140, 30);
			this.btnAnnulerModification.TabIndex = 7;
			this.btnAnnulerModification.Text = "Annuler Modif.";
			this.btnAnnulerModification.UseVisualStyleBackColor = false;
			this.btnAnnulerModification.Click += new System.EventHandler(this.btnAnnulerModification_Click);
			// 
			// FrmCarteRangement
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 554);
			this.Controls.Add(this.btnAnnulerModification);
			this.Controls.Add(this.labelMatriculeCorrect);
			this.Controls.Add(this.TxtNewMatricule);
			this.Controls.Add(this.dgvListCard);
			this.Controls.Add(this.btnValider);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.TxtMatriculeNat);
			this.Controls.Add(this.groupBox1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FrmCarteRangement";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Carte Rangement";
			this.Load += new System.EventHandler(this.FrmCarteRangement_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvListCard)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton rdbE;
		private System.Windows.Forms.RadioButton rdbD;
		private System.Windows.Forms.RadioButton rdbC;
		private System.Windows.Forms.RadioButton rdbB;
		private System.Windows.Forms.RadioButton rdbA;
		private System.Windows.Forms.TextBox TxtMatriculeNat;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnValider;
		private System.Windows.Forms.DataGridView dgvListCard;
		private System.Windows.Forms.TextBox TxtNewMatricule;
		private System.Windows.Forms.Label labelMatriculeCorrect;
		private System.Windows.Forms.Button btnAnnulerModification;
	}
}