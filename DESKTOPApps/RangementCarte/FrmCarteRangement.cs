using RangementCarte.Data;
using RangementCarte.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RangementCarte
{
	public partial class FrmCarteRangement : Form
	{
		ApplicationDbContext _db = new ApplicationDbContext();

		public FrmCarteRangement()
		{
			InitializeComponent();
			LoadDatagridView();

			this.TxtMatriculeNat.Enabled = true;
			this.TxtNewMatricule.Visible = false;
			this.labelMatriculeCorrect.Visible = false;
			this.btnAnnulerModification.Visible = false;

		}

		private void FrmCarteRangement_Load(object sender, EventArgs e)
		{	
			this.Text +="  " + "	::::::::::::::::::  Bienvenue ~ " + Form1.user;
		}

		private void btnValider_Click(object sender, EventArgs e)
		{
			try
			{
				EnregistrerCarte();
				LoadDatagridView();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Une erreur est survenu dans le system : " + ex.ToString());
			}
		}

		public void LoadDatagridView()
		{
			List<Carte> lstCarte = _db.Cartes
				.Where(x => x.User == Form1.user).OrderByDescending(x => x.Id).Take(10).ToList();

			this.dgvListCard.DataSource = lstCarte;
		}

		public void EnregistrerCarte()
		{
			if (this.TxtMatriculeNat.Text.Trim() !="")
			{
				if (VerifierExistanceMatricule(this.TxtMatriculeNat.Text.Trim()))
				{
					Carte ctr = _db.Cartes.Where(x => x.MatriculeNational == this.TxtMatriculeNat.Text.Trim()).FirstOrDefault();

					ctr.MatriculeNational = this.TxtNewMatricule.Text.Trim();
					if (this.rdbA.Checked)
					{
						ctr.Boxe = "A";
					}
					else if (this.rdbB.Checked)
					{
						ctr.Boxe = "B";
					}
					else if (this.rdbC.Checked)
					{
						ctr.Boxe = "C";
					}
					else if (this.rdbD.Checked)
					{
						ctr.Boxe = "D";
					}
					else if (this.rdbE.Checked)
					{
						ctr.Boxe = "E";
					}

					ctr.User = Form1.user;

					_db.SaveChanges();

					this.TxtMatriculeNat.Enabled = true;
					this.TxtMatriculeNat.Text = "";
					this.TxtNewMatricule.Visible = false;
					this.labelMatriculeCorrect.Visible = false;
					this.btnAnnulerModification.Visible = false;

					MessageBox.Show("Modification achevée avec succès!");
				}
				else
				{
					Carte crte = new Carte();

					if (this.rdbA.Checked)
					{
						crte.Boxe = "A";
					}
					else if (this.rdbB.Checked)
					{
						crte.Boxe = "B";
					}
					else if (this.rdbC.Checked)
					{
						crte.Boxe = "C";
					}
					else if (this.rdbD.Checked)
					{
						crte.Boxe = "D";
					}
					else if (this.rdbE.Checked)
					{
						crte.Boxe = "E";
					}

					crte.MatriculeNational = this.TxtMatriculeNat.Text.Trim();
					crte.User = Form1.user;

					_db.Cartes.Add(crte);
					_db.SaveChanges();
					this.TxtMatriculeNat.Text = "";
				}
				
			}
			else
			{
				MessageBox.Show("Renseignez le matricule national SVP!");
			}
			
		}

		private bool VerifierExistanceMatricule(string matr)
		{
			if (_db.Cartes.Where(x =>x.MatriculeNational==this.TxtMatriculeNat.Text.Trim()).Count() > 0)
			{
				return true;
			}
			return false;
		}
				

		private void btnAnnulerModification_Click(object sender, EventArgs e)
		{			
			this.btnAnnulerModification.Visible = false;
			this.labelMatriculeCorrect.Visible = false;
			this.TxtNewMatricule.Text = "";
			this.TxtNewMatricule.Visible = false;
			this.TxtMatriculeNat.Enabled = true;
			this.TxtMatriculeNat.Text = "";
		}

		private void dgvListCard_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			DataGridViewRow row = this.dgvListCard.Rows[e.RowIndex];
			this.TxtMatriculeNat.Text = row.Cells["MatriculeNational"].Value.ToString();
			string strbox = row.Cells["Boxe"].Value.ToString();
			
			switch (strbox)
			{
				case "A":
					this.rdbA.Checked = true;
					break;
				case "B":
					this.rdbB.Checked = true;
					break;
				case "C":
					this.rdbC.Checked = true;
					break;
				case "D":
					this.rdbD.Checked = true;
					break;
				case "E":
					this.rdbE.Checked = true;
					break;
			}

			this.TxtMatriculeNat.Enabled = false;
			this.TxtNewMatricule.Visible = true;
			this.labelMatriculeCorrect.Visible = true;
			this.btnAnnulerModification.Visible = true;
		}
	}
}
