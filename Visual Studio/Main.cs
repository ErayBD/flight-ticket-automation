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
	public partial class Main : Form {
		public Main() {
			InitializeComponent();
		}

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
			Main main = new Main();
			SignIn signIn = new SignIn();

			main.Close();
			signIn.Show();
		}

		private void button2_Click(object sender, EventArgs e) { //SignUp sayfasına gider
			Main main = new Main();
			SignUp signUp = new SignUp();

			main.Close();
			signUp.Show();

		}

		private void button7_Click(object sender, EventArgs e) {
			Profile profile = new Profile();
			Main main = new Main();

			main.Close();
			profile.Show();
		}

		private void button6_Click(object sender, EventArgs e) {
			Flight flight = new Flight();
			Main main = new Main();

			main.Close();
			flight.Show();
		}

		private void button3_Click(object sender, EventArgs e) {
			Booking booking= new Booking();
			Main main= new Main();
			
			main.Close();
			booking.Show();
		}

		private void button4_Click(object sender, EventArgs e) {
			ManageBooking manageBooking= new ManageBooking();
			Main main= new Main();

			main.Close();
			manageBooking.Show();
		}
	}
}
