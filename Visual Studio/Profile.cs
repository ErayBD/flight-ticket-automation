using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje {
	public partial class Profile : Form {
		public Profile() {
			InitializeComponent();
		}
		NpgsqlConnection connection = new NpgsqlConnection("server=localhost; port=5432; database=ucakBiletSatisOtomasyonu; username=postgres; password=eraybd");

		private void button5_Click(object sender, EventArgs e) {
			SignIn signIn = new SignIn();
			Profile profile = new Profile();

			profile.Close();
			signIn.Show();
		}

		private void button2_Click(object sender, EventArgs e) {
			SignUp signUp = new SignUp();
			Profile profile = new Profile();

			profile.Close();
			signUp.Show();
		}

		private void bt_close_Click(object sender, EventArgs e) {
			NpgDB npgdb = new NpgDB();
			npgdb.change_loginstatus_deactive();
			System.Windows.Forms.Application.Exit();
		}

		private void tb_id_Click(object sender, EventArgs e) {
			tb_id.BackColor = Color.FromArgb(41, 128, 185);
			tb_pw.BackColor = Color.White;
			p_right_id.BackColor = Color.White;

			tb_phone.BackColor = Color.White;
			panel4.BackColor = Color.FromArgb(41, 128, 185);
			tb_mail.BackColor = Color.White;
			p_right_mail.BackColor = Color.FromArgb(41, 128, 185);
			p_right_pw.BackColor = Color.FromArgb(41, 128, 185);
			tb_idcardno.BackColor = Color.White;
			panel5.BackColor = Color.FromArgb(41, 128, 185);

			tb_id.ForeColor = Color.White;
			tb_phone.ForeColor = Color.FromArgb(41, 128, 185);
			tb_mail.ForeColor = Color.FromArgb(41, 128, 185);
			tb_pw.ForeColor = Color.FromArgb(41, 128, 185);
			tb_idcardno.ForeColor = Color.FromArgb(41, 128, 185);
		}

		private void textBox1_Click(object sender, EventArgs e) {
			tb_id.BackColor = Color.White;
			tb_pw.BackColor = Color.White;
			tb_phone.BackColor = Color.White;
			panel4.BackColor = Color.FromArgb(41, 128, 185);
			tb_mail.BackColor = Color.White;
			p_right_mail.BackColor = Color.FromArgb(41, 128, 185);
			p_right_pw.BackColor = Color.FromArgb(41, 128, 185);
			tb_idcardno.BackColor = Color.White;
			panel5.BackColor = Color.FromArgb(41, 128, 185);
			p_right_id.BackColor = Color.FromArgb(41, 128, 185);

			tb_id.ForeColor = Color.FromArgb(41, 128, 185);
			tb_phone.ForeColor = Color.FromArgb(41, 128, 185);
			tb_mail.ForeColor = Color.FromArgb(41, 128, 185);
			tb_pw.ForeColor = Color.FromArgb(41, 128, 185);
			tb_idcardno.ForeColor = Color.FromArgb(41, 128, 185);
		}

		private void textBox2_Click(object sender, EventArgs e) {
			tb_phone.BackColor = Color.FromArgb(41, 128, 185);
			panel4.BackColor = Color.White;

			tb_id.BackColor = Color.White;
			tb_mail.BackColor = Color.White;
			p_right_mail.BackColor = Color.FromArgb(41, 128, 185);
			tb_pw.BackColor = Color.White;
			p_right_pw.BackColor = Color.FromArgb(41, 128, 185);
			tb_idcardno.BackColor = Color.White;
			panel5.BackColor = Color.FromArgb(41, 128, 185);
			p_right_id.BackColor = Color.FromArgb(41, 128, 185);

			tb_id.ForeColor = Color.FromArgb(41, 128, 185);
			tb_phone.ForeColor = Color.White;
			tb_mail.ForeColor = Color.FromArgb(41, 128, 185);
			tb_pw.ForeColor = Color.FromArgb(41, 128, 185);
			tb_idcardno.ForeColor = Color.FromArgb(41, 128, 185);
		}

		private void tb_mail_Click(object sender, EventArgs e) {
			tb_mail.BackColor = Color.FromArgb(41, 128, 185);
			p_right_mail.BackColor = Color.White;

			tb_phone.BackColor = Color.White;
			panel4.BackColor = Color.FromArgb(41, 128, 185);
			tb_id.BackColor = Color.White;
			tb_pw.BackColor = Color.White;
			p_right_pw.BackColor = Color.FromArgb(41, 128, 185);
			tb_idcardno.BackColor = Color.White;
			panel5.BackColor = Color.FromArgb(41, 128, 185);
			p_right_id.BackColor = Color.FromArgb(41, 128, 185);

			tb_id.ForeColor = Color.FromArgb(41, 128, 185);
			tb_phone.ForeColor = Color.FromArgb(41, 128, 185);
			tb_mail.ForeColor = Color.White;
			tb_pw.ForeColor = Color.FromArgb(41, 128, 185);
			tb_idcardno.ForeColor = Color.FromArgb(41, 128, 185);
		}

		private void tb_pw_Click(object sender, EventArgs e) {
			tb_pw.BackColor = Color.FromArgb(41, 128, 185);
			p_right_pw.BackColor = Color.White;

			tb_mail.BackColor = Color.White;
			p_right_mail.BackColor = Color.FromArgb(41, 128, 185);
			tb_phone.BackColor = Color.White;
			panel4.BackColor = Color.FromArgb(41, 128, 185);
			tb_id.BackColor = Color.White;
			tb_idcardno.BackColor = Color.White;
			panel5.BackColor = Color.FromArgb(41, 128, 185);
			p_right_id.BackColor = Color.FromArgb(41, 128, 185);

			tb_id.ForeColor = Color.FromArgb(41, 128, 185);
			tb_phone.ForeColor = Color.FromArgb(41, 128, 185);
			tb_mail.ForeColor = Color.FromArgb(41, 128, 185);
			tb_pw.ForeColor = Color.White;
			tb_idcardno.ForeColor = Color.FromArgb(41, 128, 185);
		}

		private void textBox3_Click(object sender, EventArgs e) {
			tb_idcardno.BackColor = Color.FromArgb(41, 128, 185);
			panel5.BackColor = Color.White;

			tb_pw.BackColor = Color.White;
			p_right_pw.BackColor = Color.FromArgb(41, 128, 185);
			tb_mail.BackColor = Color.White;
			p_right_mail.BackColor = Color.FromArgb(41, 128, 185);
			tb_phone.BackColor = Color.White;
			panel4.BackColor = Color.FromArgb(41, 128, 185);
			tb_id.BackColor = Color.White;
			p_right_id.BackColor = Color.FromArgb(41, 128, 185);

			tb_id.ForeColor = Color.FromArgb(41, 128, 185);
			tb_phone.ForeColor = Color.FromArgb(41, 128, 185);
			tb_mail.ForeColor = Color.FromArgb(41, 128, 185);
			tb_pw.ForeColor = Color.FromArgb(41, 128, 185);
			tb_idcardno.ForeColor = Color.White;
		}

		private void textBox4_Click(object sender, EventArgs e) {
			tb_dob.BackColor = Color.White;

			tb_idcardno.BackColor = Color.White;
			panel5.BackColor = Color.FromArgb(41, 128, 185);
			tb_pw.BackColor = Color.White;
			p_right_pw.BackColor = Color.FromArgb(41, 128, 185);
			tb_mail.BackColor = Color.White;
			p_right_mail.BackColor = Color.FromArgb(41, 128, 185);
			tb_phone.BackColor = Color.White;
			panel4.BackColor = Color.FromArgb(41, 128, 185);
			tb_id.BackColor = Color.White;

			tb_id.ForeColor = Color.FromArgb(41, 128, 185);
			tb_phone.ForeColor = Color.FromArgb(41, 128, 185);
			tb_mail.ForeColor = Color.FromArgb(41, 128, 185);
			tb_pw.ForeColor = Color.FromArgb(41, 128, 185);
			tb_idcardno.ForeColor = Color.FromArgb(41, 128, 185);
		}

		private void pb_left_MouseDown(object sender, MouseEventArgs e) {
			pb_left.ImageLocation = "C:\\Users\\erayd\\Desktop\\Lectures\\Veritabanı Yönetim Sistemleri, BMT-311\\Proje\\Proje\\images\\eye.png";
			tb_pw.UseSystemPasswordChar = false;
		}

		private void pb_left_MouseUp(object sender, MouseEventArgs e) {
			pb_left.ImageLocation = "C:\\Users\\erayd\\Desktop\\Lectures\\Veritabanı Yönetim Sistemleri, BMT-311\\Proje\\Proje\\images\\eyeCrossed.png";
			tb_pw.UseSystemPasswordChar = true;
		}

		private void pb_left_Click(object sender, EventArgs e) {
			p_left1.Visible = false;
			p_leftMain.Visible = true;
		}

		private void pb_right_Click(object sender, EventArgs e) {
			p_left1.Visible = true;
			p_leftMain.Visible = false;
		}

		private void pb_left_MouseHover(object sender, EventArgs e) {
			pb_left.ImageLocation = "C:\\Users\\erayd\\Desktop\\Lectures\\Veritabanı Yönetim Sistemleri, BMT-311\\Proje\\Proje\\images\\menuRW.png";
		}

		private void pb_left_MouseLeave(object sender, EventArgs e) {
			pb_left.ImageLocation = "C:\\Users\\erayd\\Desktop\\Lectures\\Veritabanı Yönetim Sistemleri, BMT-311\\Proje\\Proje\\images\\menuRB.png";
		}

		private void pb_right_MouseHover(object sender, EventArgs e) {
			pb_right.ImageLocation = "C:\\Users\\erayd\\Desktop\\Lectures\\Veritabanı Yönetim Sistemleri, BMT-311\\Proje\\Proje\\images\\menuLW.png";
		}

		private void pb_right_MouseLeave(object sender, EventArgs e) {
			pb_right.ImageLocation = "C:\\Users\\erayd\\Desktop\\Lectures\\Veritabanı Yönetim Sistemleri, BMT-311\\Proje\\Proje\\images\\menuLB.png";
		}

		private void button6_Click(object sender, EventArgs e) {
			Flight flight = new Flight();
			Profile profile = new Profile();

			profile.Close();
			flight.Show();
		}

		private void textBox5_Click(object sender, EventArgs e) {
			tb_dob.BackColor = Color.White;

			tb_idcardno.BackColor = Color.White;
			panel5.BackColor = Color.FromArgb(41, 128, 185);
			tb_pw.BackColor = Color.White;
			p_right_pw.BackColor = Color.FromArgb(41, 128, 185);
			tb_mail.BackColor = Color.White;
			p_right_mail.BackColor = Color.FromArgb(41, 128, 185);
			tb_phone.BackColor = Color.White;
			panel4.BackColor = Color.FromArgb(41, 128, 185);
			tb_id.BackColor = Color.White;

			tb_id.ForeColor = Color.FromArgb(41, 128, 185);
			tb_phone.ForeColor = Color.FromArgb(41, 128, 185);
			tb_mail.ForeColor = Color.FromArgb(41, 128, 185);
			tb_pw.ForeColor = Color.FromArgb(41, 128, 185);
			tb_idcardno.ForeColor = Color.FromArgb(41, 128, 185);
		}

		private void textBox6_Click(object sender, EventArgs e) {

			tb_dob.BackColor = Color.White;

			tb_idcardno.BackColor = Color.White;
			panel5.BackColor = Color.FromArgb(41, 128, 185);
			tb_pw.BackColor = Color.White;
			p_right_pw.BackColor = Color.FromArgb(41, 128, 185);
			tb_mail.BackColor = Color.White;
			p_right_mail.BackColor = Color.FromArgb(41, 128, 185);
			tb_phone.BackColor = Color.White;
			panel4.BackColor = Color.FromArgb(41, 128, 185);
			tb_id.BackColor = Color.White;

			tb_id.ForeColor = Color.FromArgb(41, 128, 185);
			tb_phone.ForeColor = Color.FromArgb(41, 128, 185);
			tb_mail.ForeColor = Color.FromArgb(41, 128, 185);
			tb_pw.ForeColor = Color.FromArgb(41, 128, 185);
			tb_idcardno.ForeColor = Color.FromArgb(41, 128, 185);
		}

		private void pictureBox7_MouseDown(object sender, MouseEventArgs e) {
			pictureBox7.ImageLocation = "C:\\Users\\erayd\\Desktop\\Lectures\\Veritabanı Yönetim Sistemleri, BMT-311\\Proje\\Proje\\images\\eye.png";
			tb_pw.UseSystemPasswordChar = false;
		}

		private void pictureBox7_MouseUp(object sender, MouseEventArgs e) {
			pictureBox7.ImageLocation = "C:\\Users\\erayd\\Desktop\\Lectures\\Veritabanı Yönetim Sistemleri, BMT-311\\Proje\\Proje\\images\\eyeCrossed.png";
			tb_pw.UseSystemPasswordChar = true;
		}

		private void button3_Click(object sender, EventArgs e) {
			Booking booking = new Booking();
			Profile profile = new Profile();

			profile.Close();
			booking.Show();
		}

		private void button4_Click(object sender, EventArgs e) {
			ManageBooking manageBooking= new ManageBooking();
			Profile profile = new Profile();

			profile.Close();
			manageBooking.Show();
		}

		private void button9_Click(object sender, EventArgs e) {
			NpgDB npgdb = new NpgDB();

			try {
				npgdb.update_consumer(tb_pw.Text, tb_phone.Text, tb_mail.Text);
				MessageBox.Show("Your profile has been updated!", "Info");
			}

			catch {
				MessageBox.Show("You must be logged in to update your profile.", "Info");
			}
		}

		private void button1_Click(object sender, EventArgs e) {
			NpgDB npgdb = new NpgDB();

			try {
				tb_id.Text = npgdb.get_loggedin_id().ToString();
				tb_pw.Text = npgdb.get_loggedin_pw().ToString();
				tb_phone.Text = npgdb.get_loggedin_phone().ToString();
				tb_mail.Text = npgdb.get_loggedin_mail().ToString();

				if (npgdb.get_loggedin_sex().ToString() == "M") {
					gender_male.Checked = true;
				}
				
				else if (npgdb.get_loggedin_sex().ToString() == "F") {
					gender_female.Checked = true;
				}

				tb_dob.Text = npgdb.get_loggedin_dob().ToString();
				tb_idcardno.Text = npgdb.get_loggedin_idcardno().ToString();
			}

			catch {
				MessageBox.Show("You must be logged in to fill out the form.", "Info");
			}
			
		}
	}
}
