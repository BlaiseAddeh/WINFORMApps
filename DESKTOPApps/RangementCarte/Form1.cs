using RangementCarte.Data;
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
	public partial class Form1 : Form
	{
		ApplicationDbContext _db = new ApplicationDbContext();
		public static string user = "";
		
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			this.btnCarteRangement.Enabled = false;
			this.btnCarteSendUsinier.Enabled = false;
			this.btnLogout.Enabled = false;
			this.lblNbreCarteRange.Visible = false;
			this.labelNbreCarteRange.Visible = false;
			this.TxtUsername.Focus();
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{		

			if (this.TxtUsername.Text == "" || this.TxtPassword.Text == "")
			{
				MessageBox.Show("Please provide UserName and Password");
				return;
			}
			try
			{
				if ( _db.Users.Where(
					x=>x.Username==this.TxtUsername.Text.Trim() && 
					x.Password==this.TxtPassword.Text.Trim())
					.Count() == 1)
				{
					MessageBox.Show("Login Successful!");
					user = this.TxtUsername.Text.Trim();
								

					this.btnCarteRangement.Enabled = true;
					this.btnCarteSendUsinier.Enabled = true;
					this.btnLogout.Enabled = true;

					this.grpBIdentification.Enabled = false;
					this.label1.Enabled = false;
					this.label2.Enabled = false;
					this.TxtUsername.Enabled = false;
					this.TxtPassword.Enabled = false;

					this.labelNbreCarteRange.Visible = true;
					this.lblNbreCarteRange.Visible = true;
					this.lblNbreCarteRange.Text = _db.Cartes.Where(x => x.User == Form1.user).Count() + " Cartes";
				}
				else
				{
					MessageBox.Show("Login Failed!");
				}
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		private void btnCarteRangement_Click(object sender, EventArgs e)
		{
			FrmCarteRangement fcd = new FrmCarteRangement();
			fcd.Show();
		}

		private void btnCarteSendUsinier_Click(object sender, EventArgs e)
		{

		}

		private void btnLogout_Click(object sender, EventArgs e)
		{
			this.btnCarteRangement.Enabled = false;
			this.btnCarteSendUsinier.Enabled = false;
			this.btnLogout.Enabled = false;
			this.labelNbreCarteRange.Visible = false;
			this.lblNbreCarteRange.Visible = false;

			this.TxtUsername.Text="";
			this.TxtPassword.Text = "";
			this.TxtUsername.Focus();
			this.grpBIdentification.Enabled = true;
			this.label1.Enabled = true;
			this.label2.Enabled = true;
			this.TxtUsername.Enabled = true;
			this.TxtPassword.Enabled = true;
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			this.lblNbreCarteRange.Text = _db.Cartes.Where(x => x.User == Form1.user).Count() + " Cartes";
		}
	}
}
