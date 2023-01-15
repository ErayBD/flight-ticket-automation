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
	public partial class ManageBooking : Form {
		int ticketno;
		string flightno;
		string idcardno;
		string fname;
		string lname;
		string departurecity;
		string destinationcity;
		string departuredate;
		string departuretime;
		string price;

		
		public ManageBooking() {
			InitializeComponent();
		}
		NpgsqlConnection connection = new NpgsqlConnection("server=localhost; port=5432; database=ucakBiletSatisOtomasyonu; username=postgres; password=eraybd");

		private void button6_Click(object sender, EventArgs e) {
			Flight flight = new Flight();
			ManageBooking manageBooking = new ManageBooking();

			manageBooking.Close();
			flight.Show();
		}

		private void button5_Click(object sender, EventArgs e) {
			SignIn signIn = new SignIn();
			ManageBooking manageBooking = new ManageBooking();

			manageBooking.Close();
			signIn.Show();

		}

		private void button2_Click(object sender, EventArgs e) {
			SignUp signUp = new SignUp();
			ManageBooking manageBooking = new ManageBooking();

			manageBooking.Close();
			signUp.Show();
		}

		private void button3_Click(object sender, EventArgs e) {
			Booking booking = new Booking();
			ManageBooking manageBooking = new ManageBooking();

			manageBooking.Close();
			booking.Show();
		}

		private void button7_Click(object sender, EventArgs e) {
			Profile profile = new Profile();
			ManageBooking manageBooking = new ManageBooking();

			manageBooking.Close();
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

		private void bt_login_Click(object sender, EventArgs e) {

			NpgDB npgdb = new NpgDB();

			try {
				tb_idcardno.Text = npgdb.get_loggedin_idcardno().ToString();
				string sorgu_ticketlist = "SELECT * FROM someone_ticket WHERE idcardno = " + "'" + tb_idcardno.Text + "'";
				NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(sorgu_ticketlist, connection);
				DataSet dataSet = new DataSet();
				dataAdapter.Fill(dataSet);
				datagrid_ticketlist.DataSource = dataSet.Tables[0];
			}

			catch {
				string sorgu_ticketlist = "SELECT * FROM someone_ticket WHERE idcardno = " + "'" + tb_idcardno.Text + "'";
				NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(sorgu_ticketlist, connection);
				DataSet dataSet = new DataSet();
				dataAdapter.Fill(dataSet);
				datagrid_ticketlist.DataSource = dataSet.Tables[0];
			}	
		}

		private void datagrid_ticketlist_CellClick(object sender, DataGridViewCellEventArgs e) {
			int index = e.RowIndex;
			DataGridViewRow selectedRow = datagrid_ticketlist.Rows[index];

			ticketno = Convert.ToInt32(selectedRow.Cells[0].Value);
			flightno = selectedRow.Cells[1].Value.ToString();
			idcardno = selectedRow.Cells[2].Value.ToString();
			fname = selectedRow.Cells[3].Value.ToString();
			lname = selectedRow.Cells[4].Value.ToString();
			departurecity = selectedRow.Cells[5].Value.ToString();
			destinationcity = selectedRow.Cells[6].Value.ToString();
			departuredate = selectedRow.Cells[7].Value.ToString();
			departuretime = selectedRow.Cells[8].Value.ToString();
			price = selectedRow.Cells[9].Value.ToString();
		}

		private void button10_Click(object sender, EventArgs e) {
			var npgdb = new NpgDB();
			DialogResult deleteTicket = MessageBox.Show("Are you sure you want to delete ticket " + ticketno + "?", "Info", MessageBoxButtons.YesNo);

			if (deleteTicket == DialogResult.Yes) {
				npgdb.cancelTicket(ticketno);

				MessageBox.Show("The passenger and the ticket has been deleted succesfully..!", "Info");

				string sorgu_ticketlist = "SELECT * FROM someone_ticket WHERE idcardno = " + "'" + tb_idcardno.Text + "'";
				NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(sorgu_ticketlist, connection);
				DataSet dataSet = new DataSet();
				dataAdapter.Fill(dataSet);
				datagrid_ticketlist.DataSource = dataSet.Tables[0];
			}
			else if (deleteTicket!= DialogResult.No) {}
			
		}
	}
}
