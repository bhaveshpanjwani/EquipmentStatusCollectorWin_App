using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EquipmentStatusCollector
{
    /// <summary>
    /// This is Equipment Status Collector Form for check IP is online or offline.
    /// </summary>
    public partial class EquipmentStatusCollector : Form
    {
        /// <summary>
        /// This is constructor of Equipment Status Collector Form
        /// </summary>
        public EquipmentStatusCollector()
        {
            InitializeComponent();
        }

        public class Product
        {
            public string IpAddress { get; set; }

            public bool Status { get; set; }

            public DateTime LastReportedTime { get; set; }
        }

        ManualResetEvent manualResetEvent = new ManualResetEvent(false);

        /// <summary>
        /// This function run when button clicked 
        /// </summary>
        /// <param name="sender">Object of System.Object</param>
        /// <param name="e">object of EventArgs</param>
        private void CollectStatusButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Check text box is null.
                if (string.IsNullOrWhiteSpace(TextBoxIPAddress.Text))
                {
                    MessageBox.Show(Constant.ErrTextBoxNull, Constant.InvalidInput, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                // Validate ip address
                if (ValidateIP(TextBoxIPAddress.Text) == false)
                {
                    MessageBox.Show(Constant.ErrInvalidIpAddress, Constant.InvalidInput, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Grid View 
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(GridView);
                GridView.Rows.Clear();

                // Assign value to first row.
                row.Cells[0].Value = TextBoxIPAddress.Text;

                // Add rows to grid view.
                GridView.Rows.Add(row);
                GridView.Visible = true;

                // Label for message and show date and time
                LastStatusCollectLabel.Visible = true;
                LabelForLastStatusDateTime.Visible = true;

                // Thread for status check
                Thread checkStatusThread = new Thread(new ThreadStart(delegate { ThreadForCheckIPStatus(TextBoxIPAddress.Text, row); })) { IsBackground = true };

                // Thread for date and time
                Thread threadForTimeCollect = new Thread(ThreadForDateAndTimeCollect) { IsBackground = true };

                Thread sendDataToAPI = new Thread(new ThreadStart(delegate { SendDataToAPI(row); })) { IsBackground = true };

                checkStatusThread.Start();
                threadForTimeCollect.Start();
                sendDataToAPI.Start();

                TextBoxIPAddress.Focus();

                manualResetEvent.Set();

            }
            catch (InvalidEnumArgumentException invalidEnumArgumentException)
            {
                MessageBox.Show(invalidEnumArgumentException.Message, Constant.MsgError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ThreadStateException threadStateException)
            {
                MessageBox.Show(threadStateException.Message, Constant.MsgError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OutOfMemoryException outOfMemoryException)
            {
                MessageBox.Show(outOfMemoryException.Message, Constant.MsgError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Constant.MsgError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// This thread is for collecting time and date 
        /// </summary>
        private void ThreadForDateAndTimeCollect()
        {
            try
            {
                while (true)
                {
                    // When label require 
                    if (LabelForLastStatusDateTime.InvokeRequired)
                    {
                        // Get current date and time.
                        DateTime.TryParse(DateTime.Now.ToString(), out DateTime dateTime);
                        LabelForLastStatusDateTime.Invoke(new MethodInvoker(delegate
                        {
                            // Date and time Assign to label and with yyyy-MM-dd hh:mm format.
                            LabelForLastStatusDateTime.Text = dateTime.ToString(Constant.DateTimeFormat);
                            
                        }));
                    }

                    //MessageBox.Show("Running Label", Constant.MsgError, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // Thread Sleep
                    Thread.Sleep(15000);
                }
            }
            catch (ArgumentOutOfRangeException argumentOutOfRange)
            {
                MessageBox.Show(argumentOutOfRange.Message, Constant.MsgError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException formatException)
            {
                MessageBox.Show(formatException.Message, Constant.MsgError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidEnumArgumentException invalidEnumArgumentException)
            {
                MessageBox.Show(invalidEnumArgumentException.Message, Constant.MsgError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Constant.MsgError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Thread for determining whether an IP address is online or offline with a one-minute sleep.
        /// </summary>
        /// <param name="ipAddress">ip address</param>
        /// <param name="row">object of DataGridViewRow</param>
        private void ThreadForCheckIPStatus(string ipAddress, DataGridViewRow row)
        {
            try
            {
                while (true)
                {
                    // Check ip Address status
                    if (CheckStatus(ipAddress))
                    {
                        // Assign value to second row.
                        row.Cells[1].Value = Constant.MsgOnline;
                    }
                    else
                    {
                        row.Cells[1].Value = Constant.MsgOffline;
                    }

                    // Thread Sleep
                    Thread.Sleep(15000);
                }
            }
            catch (InvalidOperationException invalidOperationException)
            {
                MessageBox.Show(invalidOperationException.Message, Constant.MsgError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentOutOfRangeException argumentOutOfRange)
            {
                MessageBox.Show(argumentOutOfRange.Message, Constant.MsgError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidEnumArgumentException invalidEnumArgumentException)
            {
                MessageBox.Show(invalidEnumArgumentException.Message, Constant.MsgError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Check for IP Address has success or not 
        /// </summary>
        /// <param name="ipAddress">IP Address</param>
        /// <param name="ping">ping object</param>
        /// <returns>true or false</returns>
        private static bool CheckStatus(string ipAddress)
        {
            try
            {
                Ping ping = new Ping();
                // Ping replay
                int timeout = 50;
                PingReply pingReply = ping.Send(ipAddress, timeout);

                // Check IPStatus
                if (pingReply.Status == IPStatus.Success)
                {
                    return true;
                }
            }
            catch (ArgumentNullException argumentNull)
            {
                MessageBox.Show(argumentNull.Message, Constant.MsgError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidOperationException invalidOperationException)
            {
                MessageBox.Show(invalidOperationException.Message, Constant.MsgError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (NotSupportedException notSupportedException)
            {
                MessageBox.Show(notSupportedException.Message, Constant.MsgError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidEnumArgumentException invalidEnumArgumentException)
            {
                MessageBox.Show(invalidEnumArgumentException.Message, Constant.MsgError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Constant.MsgError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        /// <summary>
        /// Validate IP address
        /// </summary>
        /// <param name="ipAddress">IP Address</param>
        /// <returns>true or false</returns>
        private static bool ValidateIP(string ipAddress)
        {
            try
            {
                if (string.IsNullOrEmpty(ipAddress))
                {
                    return false;
                }

                string[] nums = ipAddress.Split('.');
                return nums.Length == 4 && nums.All(ip => byte.TryParse(ip, out _));
            }
            catch (ArgumentNullException argumentNull)
            {
                MessageBox.Show(argumentNull.Message, Constant.MsgError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidEnumArgumentException invalidEnumArgumentException)
            {
                MessageBox.Show(invalidEnumArgumentException.Message, Constant.MsgError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Constant.MsgError, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        private void SendDataToAPI(DataGridViewRow row)
        {
            manualResetEvent.WaitOne();
            Thread.Sleep(500);
            using (HttpClient client = new HttpClient())
            {
                var uri = new Uri("https://localhost:7282/api/EquipmentStatusCollector");
                var newPostJson = JsonConvert.SerializeObject(new Product()
                {
                    IpAddress = TextBoxIPAddress.Text,
                    Status = CheckStatus(TextBoxIPAddress.Text),
                    LastReportedTime = Convert.ToDateTime(LabelForLastStatusDateTime.Text)
                });

                var payload = new StringContent(newPostJson, Encoding.UTF8, "application/json");

                var result = client.PostAsync(uri, payload).Result.Content.ReadAsStringAsync().Result;

                newPostJson.Remove(0);

            }
        }
    }
}