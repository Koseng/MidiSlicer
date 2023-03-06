using M;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace MidiMonitor
{
	public partial class Main : Form
	{
		MidiInputDevice _device = null;
		StringBuilder stringBuilder = new StringBuilder();
		public Main()
		{
			InitializeComponent();
			InputsComboBox.DisplayMember = "Name";
			var inputs = MidiDevice.Inputs;

			foreach(var input in inputs)
				InputsComboBox.Items.Add(input);
			
			if (InputsComboBox.Items.Count > 0)
				InputsComboBox.SelectedIndex = 0;
		}

        private void InputsComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			stringBuilder.Clear();
			try
			{
				if (null != _device)
				{
					_device.Input -= device_Input;
					_device.Close();
				}
				_device = InputsComboBox.SelectedItem as MidiInputDevice;
				_device.Input += device_Input;
				_device.Open();
				_device.Start();
				AddDeviceNameToLog();
			}
			catch (Exception)
			{
				MessageBox.Show("Could not open midi device. In usage by other application?");				
			}
		}

		private void AddDeviceNameToLog()
        {
			if (null != _device)
			{
				string deviceChanged = $"Device Name: {_device.Name}";
				stringBuilder.AppendLine(deviceChanged);
				MessagesTextBox.AppendText(deviceChanged + Environment.NewLine);
			}
		}

		private void device_Input(object sender, MidiInputEventArgs args)
		{
			try
			{			
				string output = null;
				if (args.Message is MidiMessageNoteOn)
                {
					var m = (MidiMessageNoteOn)args.Message;
					output = $"Note  On: {m.NoteId}, Channel: {m.Channel+1} Velocity: {m.Velocity}";					
				}
				else if (args.Message is MidiMessageNoteOff)
				{
					var m = (MidiMessageNoteOff)args.Message;
					output = $"Note Off: {m.NoteId}, Channel: {m.Channel+1} Velocity: {m.Velocity}";					
				}
				else if (args.Message is MidiMessageCC)
				{
					var m = (MidiMessageCC)args.Message;
					output = $"CC: {m.ControlId}, Channel: {m.Channel+1} Value: {m.Value}";					
				}
				else if (args.Message is MidiMessageChannelPitch)
				{
					var m = (MidiMessageChannelPitch)args.Message;
					output = $"Pitch Channel: {m.Channel+1} Pitch: {m.Pitch}";
				}
				else
                {									
					output = args.Message.ToString();
				}
				if (output != null)
                {
					DateTime now = DateTime.Now;
					stringBuilder.AppendLine($"{now:HH:mm:ss.fff}   {output}");
					Invoke(new Action(delegate ()
					{												
						MessagesTextBox.AppendText(output + Environment.NewLine);
					}));
				}
			}
			catch (Exception ex)
			{
				stringBuilder.AppendLine(ex.ToString());
			}
		}
		protected override void OnClosed(EventArgs e)
		{
			_device?.Close();			
			base.OnClosed(e);
		}

		private void clearButton_Click(object sender, EventArgs e)
        {
			stringBuilder.Clear();
			MessagesTextBox.Text = string.Empty;
			AddDeviceNameToLog();
		}

        private void logFileButton_Click(object sender, EventArgs e)
        {
			var t = DateTime.Now;
			File.WriteAllText($"MIDI_{t.Year}{t.Month:D2}{t.Day:D2}__{t.Hour:D2}_{t.Minute:D2}_{t.Second:D2}.txt", stringBuilder.ToString());
		}
    }
}
