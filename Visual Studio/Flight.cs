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
	public partial class Flight : Form {
		string flightno;
		string planeid;
		string departurecity;
		string destinationcity;
		string departuredate;
		string price;
		string departuretime;
		string destinationtime;

		public Flight() {
			InitializeComponent();
		}
		NpgsqlConnection connection = new NpgsqlConnection("server=localhost; port=5432; database=ucakBiletSatisOtomasyonu; username=postgres; password=eraybd");

		public string getflightno() { return flightno; }
		public string getplaneid() { return planeid; }
		public string getdeparturecity() { return departurecity; }
		public string getdestinationcity() { return destinationcity; }
		public string getdeparturedate() { return departuredate; }
		public string getprice() { return price; }
		public string getdeparturetime() { return departuretime; }
		public string getdestinationtime() { return destinationtime;  }

		private void button5_Click(object sender, EventArgs e) {
			SignIn signIn = new SignIn();
			Flight flight = new Flight();

			flight.Close();
			signIn.Show();
		}

		private void button2_Click(object sender, EventArgs e) {
			SignUp signUp = new SignUp();
			Flight flight = new Flight();

			flight.Close();
			signUp.Show();
		}

		private void button7_Click(object sender, EventArgs e) {
			Profile profile = new Profile();
			Flight flight = new Flight();

			flight.Close();
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

		private void button3_Click(object sender, EventArgs e) {
			Booking booking = new Booking();
			Flight flight = new Flight();

			flight.Close();
			booking.Show();
		}

		private void button4_Click(object sender, EventArgs e) {
			ManageBooking manageBooking = new ManageBooking();
			Flight flight = new Flight();

			flight.Close();
			manageBooking.Show();
		}

		private void bt_ucusListe_Click(object sender, EventArgs e) {
			string nereden = cb_nereden.Text; //İstanbul
			string nereye = cb_nereye.Text; //Ankara
			string sorgu_UcusListe = "SELECT * FROM flight WHERE departureCity = " + "'" + nereden + "'" + "AND destinationCity = " + "'" + nereye + "'";
			NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(sorgu_UcusListe, connection);
			DataSet dataSet = new DataSet();
			dataAdapter.Fill(dataSet);
			datagrid_ucusListe.DataSource = dataSet.Tables[0];
		}

		private void datagrid_ucusListe_CellClick(object sender, DataGridViewCellEventArgs e) {
			int index = e.RowIndex;
			DataGridViewRow selectedRow = datagrid_ucusListe.Rows[index];

			flightno = selectedRow.Cells[0].Value.ToString();
			planeid = selectedRow.Cells[1].Value.ToString();
			departurecity = selectedRow.Cells[2].Value.ToString();
			destinationcity = selectedRow.Cells[3].Value.ToString();
			departuredate = selectedRow.Cells[4].Value.ToString();
			price = selectedRow.Cells[5].Value.ToString();
			departuretime = selectedRow.Cells[6].Value.ToString();
			destinationtime = selectedRow.Cells[7].Value.ToString();

		}

		private void button9_Click(object sender, EventArgs e) {
			Booking booking = new Booking();
			Booking2 booking2 = new Booking2();
			Flight flight = new Flight();

			flight.Hide();
			booking.Show();

			booking.set_tbNereden(departurecity);
			booking.set_tbNereye(destinationcity);
			booking.set_tbGidisTarihi(departuretime);

			booking.set_holderTutar(price);
			booking.set_flightnoHolder(flightno);
			
		}
	}
}
