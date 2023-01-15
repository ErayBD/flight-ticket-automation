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
	public partial class SignIn : Form {
		public SignIn() {
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

		private void button2_Click(object sender, EventArgs e) { //SignUp sayfasına gider
			SignUp signUp = new SignUp();
			SignIn signIn = new SignIn();

			signIn.Close();
			signUp.Show();
		}

		private void button7_Click(object sender, EventArgs e) {
			Profile profile = new Profile();
			SignIn signIn = new SignIn();

			signIn.Close();
			profile.Show();
		}

		private void tb_id_Click(object sender, EventArgs e) {
			tb_id.BackColor = Color.FromArgb(41, 128, 185);
			tb_pw.BackColor = Color.White;
			p_right_id.BackColor = Color.White;
			p_right_pw.BackColor = Color.FromArgb(41, 128, 185);
			tb_id.ForeColor = Color.White;
			tb_pw.ForeColor = Color.FromArgb(41, 128, 185);
			

		}

		private void tb_pw_Click(object sender, EventArgs e) {
			tb_pw.BackColor = Color.FromArgb(41, 128, 185);
			p_right_pw.BackColor = Color.White;
			tb_id.BackColor = Color.White;
			p_right_id.BackColor = Color.FromArgb(41, 128, 185);
			tb_id.ForeColor = Color.FromArgb(41, 128, 185);
			tb_pw.ForeColor = Color.White;
		}

		private void pictureBox4_MouseDown(object sender, MouseEventArgs e) {
			pictureBox4.ImageLocation = "C:\\Users\\erayd\\Desktop\\Lectures\\Veritabanı Yönetim Sistemleri, BMT-311\\Proje\\Proje\\images\\eye.png";
			tb_pw.UseSystemPasswordChar = false;
		}

		private void pictureBox4_MouseUp(object sender, MouseEventArgs e) {
			pictureBox4.ImageLocation = "C:\\Users\\erayd\\Desktop\\Lectures\\Veritabanı Yönetim Sistemleri, BMT-311\\Proje\\Proje\\images\\eyeCrossed.png";
			tb_pw.UseSystemPasswordChar = true;
		}

		private void button9_Click(object sender, EventArgs e) {
			SignUp signUp = new SignUp();
			SignIn signIn = new SignIn();

			signIn.Close();
			signUp.Show();
		}

		private void button6_Click(object sender, EventArgs e) {
			SignIn signIn = new SignIn();
			Flight flight = new Flight();

			signIn.Close();
			flight.Show();
		}

		private void button3_Click(object sender, EventArgs e) {
			Booking booking = new Booking();
			SignIn signIn = new SignIn();

			signIn.Close();
			booking.Show();
		}

		private void button4_Click(object sender, EventArgs e) {
			ManageBooking manageBooking= new ManageBooking();
			SignIn signIn = new SignIn();

			signIn.Close();
			manageBooking.Show();
		}

		private void bt_fpw_Click(object sender, EventArgs e) {
			Forgot forgot = new Forgot();
			SignIn signIn = new SignIn();

			signIn.Close();
			forgot.Show();
		}

		private void bt_login_Click(object sender, EventArgs e) {
			var npgdb = new NpgDB();

			if (npgdb.get_consumerinfo(tb_id.Text, tb_pw.Text)) {
				lb_consumerName.Text = "Welcome, " + tb_id.Text;
				lb_consumerName.Visible= true;
				MessageBox.Show("Login Succesful!\nWelcome back " + tb_id.Text + "!", "Info");
				npgdb.change_loginstatus(tb_id.Text, tb_pw.Text);
				MessageBox.Show("Login Status Has Changed to 'Active'", "Info");
			}
			else {
				MessageBox.Show("Login information is incorrect!", "Info");
			}
			
		}






	}
}
