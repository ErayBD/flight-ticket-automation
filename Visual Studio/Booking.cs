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
	public partial class Booking : Form {
		public Booking() {
			InitializeComponent();
		}
		NpgsqlConnection connection = new NpgsqlConnection("server=localhost; port=5432; database=ucakBiletSatisOtomasyonu; username=postgres; password=eraybd");
		
		public void set_flightnoHolder(string text) {
			Holder_flightno.Text = text;
		}
		public void set_tbNereden(string text) {
			tb_nereden.Text = text;
		}

		public void set_tbNereye(string text) {
			tb_nereye.Text = text;
		}

		public void set_tbGidisTarihi(string text) {
			tb_gidisTarih.Text = text;
		}

		public void set_yolcuSayisi(string text) {
			Booking2 booking2 = new Booking2();
			booking2.set_yolcuSayisi(get_yolcuSayisi());
		}

		public void set_holderTutar(string text) {
			tb_holderTutar.Text = text;
		}

		public string get_yolcuSayisi() { return tb_yolcusayisi.Text; }
		private void button6_Click(object sender, EventArgs e) {
			Flight flight = new Flight();
			Booking booking = new Booking();

			booking.Close();
			flight.Show();
		}

		private void button5_Click(object sender, EventArgs e) {
			SignIn signIn = new SignIn();
			Booking booking = new Booking();

			booking.Close();
			signIn.Show();
		}

		private void button2_Click(object sender, EventArgs e) {
			SignUp signUp = new SignUp();
			Booking booking = new Booking();

			booking.Close();
			signUp.Show();
		}

		private void button4_Click(object sender, EventArgs e) {
			ManageBooking manageBooking = new ManageBooking();
			Booking booking = new Booking();

			booking.Close();
			manageBooking.Show();
		}

		private void button7_Click(object sender, EventArgs e) {
			Profile profile = new Profile();
			Booking booking = new Booking();

			booking.Close();
			profile.Show();
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

		private void button10_Click(object sender, EventArgs e) {
			Booking booking = new Booking();
			Booking2 booking2 = new Booking2();
			Flight flight = new Flight();

			booking.Hide();
			booking2.Show();

			booking2.set_flightno(Holder_flightno.Text);
			booking2.set_yolcuSayisi(tb_yolcusayisi.Text);
			booking2.set_odenecekTutar(tb_holderTutar.Text);
			booking2.set_tbOdenecekTutar();
			booking2.set_creditcard(tb_creditcard.Text);

		}
	}
}
