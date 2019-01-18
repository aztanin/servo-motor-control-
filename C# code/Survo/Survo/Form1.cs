using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

using MySql.Data.MySqlClient;

namespace Survo
{
    public partial class Form1 : Form
    {
        string conStr = "server=localhost;user id=root;database=survo";
        SerialPort _SerialPort;
        int x;
        public Form1()
        {
            InitializeComponent();
            SurvoMotor();
        }

        private void degNumber()
        {
            MySqlConnection con = new MySqlConnection(conStr);
            try
            {
                int id = 1;
                string sql = "SELECT * FROM degnum WHERE id='" + id + "'";
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows[0][1].ToString() != string.Empty)
                {
                    x = int.Parse(dt.Rows[0][1].ToString());

                    if (_SerialPort.IsOpen)
                    {
                        txtDegree.Text = x.ToString();
                        _SerialPort.WriteLine(trackBarRange.Value.ToString());
                       
                        
                    }
                   
                }
            }
            catch
            {
                MessageBox.Show("WRONG");
            }
        }

        private void SurvoMotor()
        {
            _SerialPort = new SerialPort();
            _SerialPort.PortName = "COM5";
            _SerialPort.BaudRate = 9600;
            try
            {
               
                _SerialPort.Open();
              
            }
            catch 
            {
                MessageBox.Show("Error");
            }

        }

        private void trackBarRange_Scroll(object sender, EventArgs e)
        {
            /*
            if(_SerialPort.IsOpen)
            {
                _SerialPort.WriteLine(trackBarRange.Value.ToString());
                txtDegree.Text = trackBarRange.Value.ToString();
              
                timer1.Start();
            }
            */
            timer1.Start();
          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(conStr);
            try
            {
                int id = 1;
                string sql = "SELECT * FROM degnum WHERE id='" + id + "'";
                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows[0][1].ToString() != string.Empty)
                {
                    x = int.Parse(dt.Rows[0][1].ToString());

                    if (_SerialPort.IsOpen)
                    {
                        txtDegree.Text = x.ToString();
                        _SerialPort.WriteLine(x.ToString());


                    }

                }
            }
            catch
            {
                MessageBox.Show("WRONG");
            }
           
        }

        private void txtDegree_Click(object sender, EventArgs e)
        {

        }

        private void txtDegree_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

       
    }
}
