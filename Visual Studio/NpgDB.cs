using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Proje {
	public class NpgDB {

		public NpgsqlConnection GetConnection() {
			return new NpgsqlConnection("server=localhost; port=5432; database=ucakBiletSatisOtomasyonu; User Id=postgres; password=eraybd");
		}

		public bool savePassenger(string fname, string lname, string sex, string dob, string mail, string phonenumber,
								  string creditcardno, string flightno, string idcardno) {
			bool saved = false;
			using (var conn = GetConnection()) {
				NpgsqlCommand cmd = new NpgsqlCommand("call save_passenger(:fname, :lname, :sex, :dob, :mail, :phonenumber, :creditcardno, :flightno, :idcardno)", conn);
				
				cmd.Parameters.AddWithValue("fname", DbType.String).Value = fname;
				cmd.Parameters.AddWithValue("lname", DbType.String).Value = lname;
				cmd.Parameters.AddWithValue("sex", DbType.String).Value = sex;
				cmd.Parameters.AddWithValue("dob", DbType.String).Value = dob;
				cmd.Parameters.AddWithValue("mail", DbType.String).Value = mail;
				cmd.Parameters.AddWithValue("phonenumber", DbType.String).Value = phonenumber;
				cmd.Parameters.AddWithValue("creditcardno", DbType.String).Value = creditcardno;
				cmd.Parameters.AddWithValue("flightno", DbType.String).Value = flightno;
				cmd.Parameters.AddWithValue("idcardno", DbType.String).Value = idcardno;
				conn.Open();
				int affectedCount = cmd.ExecuteNonQuery();
				saved = (affectedCount == 1);
				conn.Close();
			}
			return saved;
		}

		public bool saveTicket(string flightno, string idcardno) {
			bool saved = false;
			using (var conn = GetConnection()) {
				NpgsqlCommand cmd = new NpgsqlCommand("call save_ticket(:flightno, :idcardno)", conn);
				cmd.Parameters.AddWithValue("flightno", DbType.String).Value = flightno;
				cmd.Parameters.AddWithValue("idcardno", DbType.String).Value = idcardno;
				conn.Open();
				int affectedCount = cmd.ExecuteNonQuery();
				saved = (affectedCount == 1);
				conn.Close();
			}
			return saved;
		}

		public bool cancelTicket(int ticketno) {
			bool saved = false;
			using (var conn = GetConnection()) {
				NpgsqlCommand cmd = new NpgsqlCommand("call cancel_ticket(:ticketno)", conn);
				cmd.Parameters.AddWithValue("ticketno", DbType.Int32).Value = ticketno;
				conn.Open();
				int affectedCount = cmd.ExecuteNonQuery();
				saved = (affectedCount == 1);
				conn.Close();
			}
			return saved;
		}

		public bool saveConsumer(string consumerid, string consumerpw, string phone, string mail, string sex, string dob, string idcardno) {
			bool saved = false;
			using (var conn = GetConnection()) {
				NpgsqlCommand cmd = new NpgsqlCommand("call save_consumer(:consumerid, :consumerpw, :phone, :mail, :sex, :dob, :idcardno)", conn);
				cmd.Parameters.AddWithValue("consumerid", DbType.String).Value = consumerid;
				cmd.Parameters.AddWithValue("consumerpw", DbType.String).Value = consumerpw;
				cmd.Parameters.AddWithValue("phone", DbType.String).Value = phone;
				cmd.Parameters.AddWithValue("mail", DbType.String).Value = mail;
				cmd.Parameters.AddWithValue("sex", DbType.String).Value = sex;
				cmd.Parameters.AddWithValue("dob",DbType.String).Value = dob;
				cmd.Parameters.AddWithValue("idcardno",DbType.String).Value = idcardno;
				conn.Open();
				int affectedCount = cmd.ExecuteNonQuery();
				saved = (affectedCount == 1);
				conn.Close();
			}
			return saved;
		}

		public string get_consumerpw(string get_consumerid, string get_phone) {
			using (var conn = GetConnection()) {
				conn.Open();
				string result = null;
				string sql = @"SELECT get_consumerpw(:consumerid, :phone)";
				NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
				cmd.Parameters.AddWithValue("consumerid", get_consumerid);
				cmd.Parameters.AddWithValue("phone", get_phone);
				
				try {
					result = (string)cmd.ExecuteScalar();
				}
				catch {
					MessageBox.Show("No match.");
				}
				
				conn.Close();
				return result;
			}
		}

		public bool get_consumerinfo(string get_consumerid, string get_consumerpw) {
			using (var conn = GetConnection()) {
				conn.Open();
				string sql = @"SELECT get_consumerinfo(:consumerid, :consumerpw)";
				NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
				cmd.Parameters.AddWithValue("consumerid", get_consumerid);
				cmd.Parameters.AddWithValue("consumerpw", get_consumerpw);
				bool result = (bool)cmd.ExecuteScalar();
				conn.Close();
				return result;
			}
		}

		public bool change_loginstatus(string get_consumerid, string get_consumerpw) {
			bool saved = false;
			using (var conn = GetConnection()) {
				NpgsqlCommand cmd = new NpgsqlCommand("call change_loginstatus(:get_consumerid, :get_consumerpw)", conn);
				cmd.Parameters.AddWithValue("get_consumerid", DbType.String).Value = get_consumerid;
				cmd.Parameters.AddWithValue("get_consumerpw", DbType.String).Value = get_consumerpw;
				conn.Open();
				int affectedCount = cmd.ExecuteNonQuery();
				saved = (affectedCount == 1);
				conn.Close();
			}
			return saved;
		}

		public bool change_loginstatus_deactive() {
			bool saved = false;
			using (var conn = GetConnection()) {
				NpgsqlCommand cmd = new NpgsqlCommand("call change_loginstatus_deactive()", conn);
				conn.Open();
				int affectedCount = cmd.ExecuteNonQuery();
				saved = (affectedCount == 1);
				conn.Close();
			}
			return saved;
		}

		public string get_loggedin_idcardno() {
			using (var conn = GetConnection()) {
				conn.Open();
				string sql = @"SELECT get_loggedin_idcardno()";
				NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
				string result = (string)cmd.ExecuteScalar();
				conn.Close();
				return result;
			}
		}

		public string get_loggedin_id() {
			using (var conn = GetConnection()) {
				conn.Open();
				string sql = @"SELECT get_loggedin_id()";
				NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
				string result = (string)cmd.ExecuteScalar();
				conn.Close();
				return result;
			}
		}

		public string get_loggedin_pw() {
			using (var conn = GetConnection()) {
				conn.Open();
				string sql = @"SELECT get_loggedin_pw()";
				NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
				string result = (string)cmd.ExecuteScalar();
				conn.Close();
				return result;
			}
		}

		public string get_loggedin_phone() {
			using (var conn = GetConnection()) {
				conn.Open();
				string sql = @"SELECT get_loggedin_phone()";
				NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
				string result = (string)cmd.ExecuteScalar();
				conn.Close();
				return result;
			}
		}

		public string get_loggedin_mail() {
			using (var conn = GetConnection()) {
				conn.Open();
				string sql = @"SELECT get_loggedin_mail()";
				NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
				string result = (string)cmd.ExecuteScalar();
				conn.Close();
				return result;
			}
		}

		public string get_loggedin_sex() {
			using (var conn = GetConnection()) {
				conn.Open();
				string sql = @"SELECT get_loggedin_sex()";
				NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
				string result = (string)cmd.ExecuteScalar();
				conn.Close();
				return result;
			}
		}

		public string get_loggedin_dob() {
			using (var conn = GetConnection()) {
				conn.Open();
				string sql = @"SELECT get_loggedin_dob()";
				NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
				string result = (string)cmd.ExecuteScalar();
				conn.Close();
				return result;
			}
		}

		public bool update_consumer(string pw, string phone, string mail) {
			bool saved = false;
			using (var conn = GetConnection()) {
				NpgsqlCommand cmd = new NpgsqlCommand("call update_consumer(:get_consumerpw, :get_phone, :get_mail)", conn);
				cmd.Parameters.AddWithValue("get_consumerpw", DbType.String).Value = pw;
				cmd.Parameters.AddWithValue("get_phone", DbType.String).Value = phone;
				cmd.Parameters.AddWithValue("get_mail", DbType.String).Value = mail;
				conn.Open();
				int affectedCount = cmd.ExecuteNonQuery();
				saved = (affectedCount == 1);
				conn.Close();
			}
			return saved;
		}
	}
}
