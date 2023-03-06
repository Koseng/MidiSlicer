using M;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MidiMessageSender
{
    public partial class Form1 : Form
    {
        MidiOutputDevice _device;
        public Form1()
        {
            InitializeComponent();

            OutputsComboBox.DisplayMember = "Name";
            var outputs = MidiDevice.Outputs;

            foreach (var input in outputs)
                OutputsComboBox.Items.Add(input);

            if (OutputsComboBox.Items.Count > 1)
                OutputsComboBox.SelectedIndex = 1;
        }

        private void OutputsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                _device?.Close();
                _device = OutputsComboBox.SelectedItem as MidiOutputDevice;
                _device.Open();
                EnableButtons();
            }
            catch (Exception)
            {
                MessageBox.Show("Could not open midi device. In usage by other application?");
                DisableButtons();
            }
        }

        private void DisableButtons()
        {
            noteOnSendButton.Enabled = false;
            noteOffSendButton.Enabled = false;
            CCSendButton.Enabled = false;
        }

        private void EnableButtons()
        {
            noteOnSendButton.Enabled = true;
            noteOffSendButton.Enabled = true;
            CCSendButton.Enabled = true;
        }

        private void noteOnSendButton_Click(object sender, EventArgs e)
        {
            byte noteId = (byte)noteOnIdNumericUpDown.Value;
            byte channel = (byte)(noteOnChNumericUpDown.Value - 1);
            byte velocity = (byte)noteOnVNumericUpDown.Value;
            var message = new MidiMessageNoteOn(noteId, velocity, channel);            
            _device?.Send(message);
        }

        private void noteOffSendButton_Click(object sender, EventArgs e)
        {
            byte noteId = (byte)noteOffIdNumericUpDown.Value;
            byte channel = (byte)(noteOnChNumericUpDown.Value - 1);
            byte velocity = (byte)noteOffVNumericUpDown.Value;
            var message = new MidiMessageNoteOff(noteId, velocity, channel);
            _device?.Send(message);
        }

        private void CCSendButton_Click(object sender, EventArgs e)
        {
            byte controlId = (byte)CCIdNumericUpDown.Value;
            byte channel = (byte)(noteOnChNumericUpDown.Value - 1);
            byte value = (byte)CCVNumericUpDown.Value;
            var message = new MidiMessageCC(controlId, value, channel);
            _device?.Send(message);
        }
    }
}
