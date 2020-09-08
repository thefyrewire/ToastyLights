using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using YeelightAPI;
using YeelightAPI.Models;
using YeelightAPI.Models.ColorFlow;

namespace ToastyLights
{
    public partial class Form1 : Form
    {
        List<Device> devices = new List<Device>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckStatus();
        }
        private async Task<List<Device>> GetDevicesAsync()
        {
            // Await the asynchronous call to the static API
            List<Device> discoveredDevices = (await DeviceLocator.DiscoverAsync()).ToList();
            return discoveredDevices;
        }

        private async void CheckStatus()
        {
            try
            {
                devices = await GetDevicesAsync();
                // devices.Add(new Device("localhost"));
                UpdateStatus(devices.Count.ToString() + " device(s) found PogChamp");
                foreach (var device in devices)
                {
                    await device.Connect();
                }
                UpdateStatus(devices.Count.ToString() + " device(s) connected PogChamp");
                enableTestOptions(true);
                btn_Test.BackColor = Color.FromArgb(145, 70, 255);
            }
            catch (Exception err)
            {
                UpdateStatus("No devices found... Toasty sad :(");
                enableTestOptions(false);
                btn_Test.BackColor = SystemColors.Control;
            }
        }

        private void Btn_Refresh_Click(object sender, EventArgs e)
        {
            CheckStatus();
        }

        private void UpdateStatus(string status)
        {
            lbl_Status.Text = status;
        }

        private async void Btn_Test_Click(object sender, EventArgs e)
        {
            if (devices.Count == 0)
                return;

            foreach (var device in devices)
            {
                if (!device.IsConnected)
                    return;

                try
                {
                    await device.SetRGBColor(
                        Int32.Parse(colorDialog.Color.R.ToString()),
                        Int32.Parse(colorDialog.Color.G.ToString()),
                        Int32.Parse(colorDialog.Color.B.ToString()),
                        2000
                    );
                }
                catch
                {
                    MessageBox.Show("Couldn't connect to device or change color :/", "And I oop-", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void Btn_ColorDialog_Click(object sender, EventArgs e)
        {
            colorDialog.CustomColors = new int[] {
                ColorTranslator.ToOle(Color.FromArgb(145, 70, 255))
            };

            DialogResult dialogResult = colorDialog.ShowDialog();
            if (dialogResult != DialogResult.OK)
                return;

            nud_ColorR.Value = colorDialog.Color.R;
            nud_ColorG.Value = colorDialog.Color.G;
            nud_ColorB.Value = colorDialog.Color.B;
            btn_Test.BackColor = colorDialog.Color;
        }

        private async void Btn_TestFlow_Click(object sender, EventArgs e)
        {
            if (devices.Count == 0)
                return;

            foreach (var device in devices)
            {
                if (!device.IsConnected)
                    return;

                try
                {
                    FluentFlow flow = await device.BackgroundFlow()
                      .RgbColor(255, 0, 0, 50, 1000)
                      .Sleep(2000)
                      .RgbColor(0, 255, 0, 50) //without timing
                      .During(1000) // set the timing of the previous instruction
                      .Sleep(2000)
                      .RgbColor(0, 0, 255, 50, 1000)
                      .Sleep(2000)
                      .Temperature(2700, 100, 1000)
                      .Sleep(2000)
                      .Temperature(6500, 100, 1000)
                      .Play(ColorFlowEndAction.Restore);
                }
                catch
                {
                    MessageBox.Show("Couldn't connect to device or change color :/", "And I oop-", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void enableTestOptions(bool allow)
        {
            nud_ColorR.Enabled = allow;
            nud_ColorG.Enabled = allow;
            nud_ColorB.Enabled = allow;
            btn_ColorDialog.Enabled = allow;
            btn_Test.Enabled = allow;
            btn_TestFlow.Enabled = allow;
        }
    }
}
