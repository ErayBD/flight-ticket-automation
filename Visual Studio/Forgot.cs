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
	public partial class Forgot : Form {
		public Forgot() {
			InitializeComponent();
		}
		NpgsqlConnection connection = new NpgsqlConnection("server=localhost; port=5432; database=ucakBiletSatisOtomasyonu; username=postgres; password=eraybd");

		private void bt_close_Click(object sender, EventArgs e) {
			System.Windows.Forms.Application.Exit();
		}

		private void bt_login_Click(object sender, EventArgs e) {
			var npgdb = new NpgDB();

			tb_pw.Text = npgdb.get_consumerpw(tb_id.Text, tb_phone.Text);
		}

		private void button6_Click(object sender, EventArgs e) {
			Flight flight= new Flight();
			Forgot forgot= new Forgot();

			forgot.Hide();
			flight.Show();
		}

		private void button5_Click(object sender, EventArgs e) {
			SignIn signIn = new SignIn();
			Forgot forgot = new Forgot();

			forgot.Hide();
			signIn.Show();
		}

		private void button2_Click(object sender, EventArgs e) {
			SignUp signUp = new SignUp();
			Forgot forgot = new Forgot();

			forgot.Hide();
			signUp.Show();
		}

		private void button3_Click(object sender, EventArgs e) {
			Booking booking= new Booking();
			Forgot forgot = new Forgot();

			forgot.Hide();
			booking.Show();
		}

		private void button4_Click(object sender, EventArgs e) {
			ManageBooking manageBooking= new ManageBooking();
			Forgot forgot = new Forgot();

			forgot.Hide();
			manageBooking.Show();
		}

		private void button7_Click(object sender, EventArgs e) {
			Profile profile= new Profile();
			Forgot forgot = new Forgot();

			forgot.Hide();
			profile.Show();
		}
	}
}
