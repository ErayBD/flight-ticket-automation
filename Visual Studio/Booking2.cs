using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje {
	public partial class Booking2 : Form {
		public string yolcuSayisi;
		public string odenecekTutar;
		public string sex;
		public Booking2() {
			InitializeComponent();
		}

		public void set_creditcard(string text) {
			Holder_creditcard.Text = text;
		}

		public void set_flightno(string text) {
			Holder_flightno.Text = text;
		}

		public void set_yolcuSayisi(string text) {
			yolcuSayisi = text;
		}

		public void set_odenecekTutar(string text) {
			odenecekTutar = text;
		}

		private void radioButton1_CheckedChanged(object sender, EventArgs e) {
			if (rb_tc.Checked) {
				panel1.Enabled = false;
				p_right_id.Enabled = true;
				tb_passportno.Text = string.Empty;
			}
			else {
				p_right_id.Enabled = false;
				panel1.Enabled = true;
				tb_tcno.Text= string.Empty;
			}
		}

		private void bt_close_Click(object sender, EventArgs e) {
			NpgDB npgdb = new NpgDB();
			npgdb.change_loginstatus_deactive();
			System.Windows.Forms.Application.Exit();
		}

		public void set_tbOdenecekTutar() {
			tb_odenecekTutar.Text = (Convert.ToInt32(odenecekTutar) * Convert.ToInt32(yolcuSayisi)).ToString();
		}

		private void button9_Click(object sender, EventArgs e) {

			if (tb_passportno.Text == string.Empty) {
				Holder_idcardno.Text = tb_tcno.Text;
			}
			else {
				Holder_idcardno.Text = tb_passportno.Text;
			}

			if (gender_male.Checked) {
				sex = "M";
			} else if (gender_female.Checked) {
				sex = "F";
			}

			var npgdb = new NpgDB();

			npgdb.saveTicket(Holder_flightno.Text, Holder_idcardno.Text);
			MessageBox.Show("Your ticket has been created!");
			npgdb.savePassenger(tb_id.Text, tb_soyad.Text, sex, tb_dob.Text, tb_mail.Text, tb_phone.Text, Holder_creditcard.Text, Holder_flightno.Text, Holder_idcardno.Text);
			MessageBox.Show("The passenger created!");


		}

		private void button1_Click(object sender, EventArgs e) {

			NpgDB npgdb = new NpgDB();

			try {
				tb_phone.Text = npgdb.get_loggedin_phone().ToString();
				tb_mail.Text = npgdb.get_loggedin_mail().ToString();

				if (npgdb.get_loggedin_sex().ToString() == "M") {
					gender_male.Checked = true;
				}
				
				else if (npgdb.get_loggedin_sex().ToString() == "F") {
					gender_female.Checked = true;
				}

				tb_dob.Text = npgdb.get_loggedin_dob().ToString();

				if (npgdb.get_loggedin_idcardno().ToString().Length == 11) {
					tb_tcno.Text = npgdb.get_loggedin_idcardno().ToString();
					rb_tc.Checked = true;
				}
				else if (npgdb.get_loggedin_idcardno().ToString().Length == 9) {
					tb_passportno.Text = npgdb.get_loggedin_idcardno().ToString();
					rb_foreign.Checked = true;
				}
				MessageBox.Show("Please insert your name and surname.", "Info");
			}
			
			catch {
				MessageBox.Show("You must be logged in to fill out the form.", "Info");
			}
		}

		private void button4_Click(object sender, EventArgs e) {
			ManageBooking managebooking = new ManageBooking();
			Booking2 booking2 = new Booking2();

			booking2.Hide();
			managebooking.Show();
		}

		private void button6_Click(object sender, EventArgs e) {
			Flight flight = new Flight();
			Booking2 booking2 = new Booking2();

			booking2.Hide();
			flight.Show();
		}

		private void button5_Click(object sender, EventArgs e) {
			SignIn signIn = new SignIn();
			Booking2 booking2 = new Booking2();

			booking2.Hide();
			signIn.Show();
		}

		private void button2_Click(object sender, EventArgs e) {
			SignUp signUp = new SignUp();
			Booking2 booking2 = new Booking2();

			booking2.Hide();
			signUp.Show();
		}

		private void button7_Click(object sender, EventArgs e) {
			Profile profile = new Profile();
			Booking2 booking2 = new Booking2();

			booking2.Hide();
			profile.Show();
		}
	}
}
