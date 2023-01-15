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
	public partial class SignUp : Form {

		string id;
		string pw;
		string phone;
		string mail;
		string gender;
		string dob;
		string idcardno;


		public SignUp() {
			InitializeComponent();
		}
		NpgsqlConnection connection = new NpgsqlConnection("server=localhost; port=5432; database=ucakBiletSatisOtomasyonu; username=postgres; password=eraybd");

		private void bt_close_Click(object sender, EventArgs e) {
			NpgDB npgdb = new NpgDB();
			npgdb.change_loginstatus_deactive();
			System.Windows.Forms.Application.Exit();
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

		private void button5_Click(object sender, EventArgs e) { //SignIn sayfasına gider
			SignUp signUp = new SignUp();
			SignIn signIn = new SignIn();

			signUp.Close();
			signIn.Show();
		}


		private void button7_Click(object sender, EventArgs e) {
			SignUp signUp = new SignUp();
			Profile profile = new Profile();

			signUp.Close();
			profile.Show();
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

			tb_id.ForeColor = Color.White;
			tb_phone.ForeColor = Color.FromArgb(41, 128, 185);
			tb_mail.ForeColor = Color.FromArgb(41, 128, 185);
			tb_pw.ForeColor = Color.FromArgb(41, 128, 185);
		}

		private void textBox1_Click(object sender, EventArgs e) {

			tb_id.BackColor = Color.White;
			tb_pw.BackColor = Color.White;			
			tb_phone.BackColor = Color.White;
			panel4.BackColor = Color.FromArgb(41, 128, 185);
			tb_mail.BackColor = Color.White;
			p_right_mail.BackColor = Color.FromArgb(41, 128, 185);
			p_right_pw.BackColor = Color.FromArgb(41, 128, 185);
			p_right_id.BackColor = Color.FromArgb(41, 128, 185);

			tb_id.ForeColor = Color.FromArgb(41, 128, 185);
			tb_phone.ForeColor = Color.FromArgb(41, 128, 185);
			tb_mail.ForeColor = Color.FromArgb(41, 128, 185);
			tb_pw.ForeColor = Color.FromArgb(41, 128, 185);
		}

		private void textBox2_Click(object sender, EventArgs e) {
			tb_phone.BackColor = Color.FromArgb(41, 128, 185);
			panel4.BackColor = Color.White;

			tb_id.BackColor = Color.White;
			tb_mail.BackColor = Color.White;
			p_right_mail.BackColor = Color.FromArgb(41, 128, 185);
			tb_pw.BackColor = Color.White;
			p_right_pw.BackColor = Color.FromArgb(41, 128, 185);
			p_right_id.BackColor = Color.FromArgb(41, 128, 185);

			tb_id.ForeColor = Color.FromArgb(41, 128, 185);
			tb_phone.ForeColor = Color.White;
			tb_mail.ForeColor = Color.FromArgb(41, 128, 185);
			tb_pw.ForeColor = Color.FromArgb(41, 128, 185);
		}

		private void tb_mail_Click(object sender, EventArgs e) {
			tb_mail.BackColor = Color.FromArgb(41, 128, 185);
			p_right_mail.BackColor = Color.White;

			tb_phone.BackColor = Color.White;
			panel4.BackColor = Color.FromArgb(41, 128, 185);
			tb_id.BackColor = Color.White;
			tb_pw.BackColor = Color.White;
			p_right_pw.BackColor = Color.FromArgb(41, 128, 185);
			p_right_id.BackColor = Color.FromArgb(41, 128, 185);

			tb_id.ForeColor = Color.FromArgb(41, 128, 185);
			tb_phone.ForeColor = Color.FromArgb(41, 128, 185);
			tb_mail.ForeColor = Color.White;
			tb_pw.ForeColor = Color.FromArgb(41, 128, 185);
		}

		private void tb_pw_Click(object sender, EventArgs e) {
			tb_pw.BackColor = Color.FromArgb(41, 128, 185);
			p_right_pw.BackColor = Color.White;

			tb_mail.BackColor = Color.White;
			p_right_mail.BackColor = Color.FromArgb(41, 128, 185);
			tb_phone.BackColor = Color.White;
			panel4.BackColor = Color.FromArgb(41, 128, 185);
			tb_id.BackColor = Color.White;
			p_right_id.BackColor = Color.FromArgb(41, 128, 185);

			tb_id.ForeColor = Color.FromArgb(41, 128, 185);
			tb_phone.ForeColor = Color.FromArgb(41, 128, 185);
			tb_mail.ForeColor = Color.FromArgb(41, 128, 185);
			tb_pw.ForeColor = Color.White;
		}

		private void textBox3_Click(object sender, EventArgs e) {

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
		}

		private void pictureBox7_MouseDown(object sender, MouseEventArgs e) {
			pictureBox7.ImageLocation = "C:\\Users\\erayd\\Desktop\\Lectures\\Veritabanı Yönetim Sistemleri, BMT-311\\Proje\\Proje\\images\\eye.png";
			tb_pw.UseSystemPasswordChar = false;
		}

		private void pictureBox7_MouseUp(object sender, MouseEventArgs e) {
			pictureBox7.ImageLocation = "C:\\Users\\erayd\\Desktop\\Lectures\\Veritabanı Yönetim Sistemleri, BMT-311\\Proje\\Proje\\images\\eyeCrossed.png";
			tb_pw.UseSystemPasswordChar = true;
		}

		private void textBox4_Click(object sender, EventArgs e) {

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
		}

		private void button6_Click(object sender, EventArgs e) {
			SignUp signUp = new SignUp();
			Flight flight = new Flight();

			signUp.Close();
			flight.Show();
		}

		private void textBox5_Click(object sender, EventArgs e) {
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
			
		}

		private void textBox6_Click(object sender, EventArgs e) {


			
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
	
		}

		private void button3_Click(object sender, EventArgs e) {
			Booking booking = new Booking();
			SignUp signUp = new SignUp();

			signUp.Close();
			booking.Show();
		}

		private void button4_Click(object sender, EventArgs e) {
			ManageBooking manageBooking = new ManageBooking();
			SignUp signUp = new SignUp();

			signUp.Close();
			manageBooking.Show();
		}

		private void bt_login_Click(object sender, EventArgs e) {
			id = tb_id.Text;
			pw = tb_pw.Text;
			phone = tb_phone.Text;
			mail = tb_mail.Text;
			dob = tb_dob.Text;
			idcardno= tb_idcardno.Text;
			
			if (gender_male.Checked) {
				gender = "M";
			}
			else if (gender_female.Checked) {
				gender = "F";
			}

			var npgdb = new NpgDB();

			npgdb.saveConsumer(id, pw, phone, mail, gender, dob, idcardno);
			MessageBox.Show("Registration Successful!! You can login now...", "Info");

			SignUp signUp = new SignUp();
			SignIn signIn = new SignIn();

			signUp.Hide();
			signIn.Show();

		}

		private void pictureBox7_MouseDown_1(object sender, MouseEventArgs e) {
			pictureBox7.ImageLocation = "C:\\Users\\erayd\\Desktop\\Lectures\\Veritabanı Yönetim Sistemleri, BMT-311\\Proje\\Proje\\images\\eye.png";
			tb_pw.UseSystemPasswordChar = false;
		}

		private void pictureBox7_MouseUp_1(object sender, MouseEventArgs e) {
			pictureBox7.ImageLocation = "C:\\Users\\erayd\\Desktop\\Lectures\\Veritabanı Yönetim Sistemleri, BMT-311\\Proje\\Proje\\images\\eyeCrossed.png";
			tb_pw.UseSystemPasswordChar = true;
		}


	}
}
