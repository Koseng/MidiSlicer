
namespace MidiMessageSender
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.noteOnChNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.noteOnIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.noteOnVNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.noteOnSendButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.noteOffSendButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.noteOffIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.noteOffChNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.noteOffVNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CCSendButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CCIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.CCChNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.CCVNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.OutputsComboBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.noteOnChNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noteOnIdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noteOnVNumericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.noteOffIdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noteOffChNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noteOffVNumericUpDown)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CCIdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CCChNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CCVNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // noteOnChNumericUpDown
            // 
            this.noteOnChNumericUpDown.Location = new System.Drawing.Point(193, 27);
            this.noteOnChNumericUpDown.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.noteOnChNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.noteOnChNumericUpDown.Name = "noteOnChNumericUpDown";
            this.noteOnChNumericUpDown.Size = new System.Drawing.Size(51, 20);
            this.noteOnChNumericUpDown.TabIndex = 0;
            this.noteOnChNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // noteOnIdNumericUpDown
            // 
            this.noteOnIdNumericUpDown.Location = new System.Drawing.Point(63, 27);
            this.noteOnIdNumericUpDown.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.noteOnIdNumericUpDown.Name = "noteOnIdNumericUpDown";
            this.noteOnIdNumericUpDown.Size = new System.Drawing.Size(49, 20);
            this.noteOnIdNumericUpDown.TabIndex = 0;
            // 
            // noteOnVNumericUpDown
            // 
            this.noteOnVNumericUpDown.Location = new System.Drawing.Point(312, 27);
            this.noteOnVNumericUpDown.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.noteOnVNumericUpDown.Name = "noteOnVNumericUpDown";
            this.noteOnVNumericUpDown.Size = new System.Drawing.Size(48, 20);
            this.noteOnVNumericUpDown.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "NoteId";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.noteOnSendButton);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.noteOnIdNumericUpDown);
            this.groupBox1.Controls.Add(this.noteOnChNumericUpDown);
            this.groupBox1.Controls.Add(this.noteOnVNumericUpDown);
            this.groupBox1.Location = new System.Drawing.Point(12, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(476, 68);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "NoteOn Message";
            // 
            // noteOnSendButton
            // 
            this.noteOnSendButton.Location = new System.Drawing.Point(380, 24);
            this.noteOnSendButton.Name = "noteOnSendButton";
            this.noteOnSendButton.Size = new System.Drawing.Size(75, 23);
            this.noteOnSendButton.TabIndex = 5;
            this.noteOnSendButton.Text = "Send";
            this.noteOnSendButton.UseVisualStyleBackColor = true;
            this.noteOnSendButton.Click += new System.EventHandler(this.noteOnSendButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Velocity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Channel";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.noteOffSendButton);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.noteOffIdNumericUpDown);
            this.groupBox2.Controls.Add(this.noteOffChNumericUpDown);
            this.groupBox2.Controls.Add(this.noteOffVNumericUpDown);
            this.groupBox2.Location = new System.Drawing.Point(12, 148);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(476, 68);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "NoteOff Message";
            // 
            // noteOffSendButton
            // 
            this.noteOffSendButton.Location = new System.Drawing.Point(380, 24);
            this.noteOffSendButton.Name = "noteOffSendButton";
            this.noteOffSendButton.Size = new System.Drawing.Size(75, 23);
            this.noteOffSendButton.TabIndex = 5;
            this.noteOffSendButton.Text = "Send";
            this.noteOffSendButton.UseVisualStyleBackColor = true;
            this.noteOffSendButton.Click += new System.EventHandler(this.noteOffSendButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(262, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Velocity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(141, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Channel";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "NoteId";
            // 
            // noteOffIdNumericUpDown
            // 
            this.noteOffIdNumericUpDown.Location = new System.Drawing.Point(63, 27);
            this.noteOffIdNumericUpDown.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.noteOffIdNumericUpDown.Name = "noteOffIdNumericUpDown";
            this.noteOffIdNumericUpDown.Size = new System.Drawing.Size(49, 20);
            this.noteOffIdNumericUpDown.TabIndex = 1;
            // 
            // noteOffChNumericUpDown
            // 
            this.noteOffChNumericUpDown.Location = new System.Drawing.Point(193, 27);
            this.noteOffChNumericUpDown.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.noteOffChNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.noteOffChNumericUpDown.Name = "noteOffChNumericUpDown";
            this.noteOffChNumericUpDown.Size = new System.Drawing.Size(51, 20);
            this.noteOffChNumericUpDown.TabIndex = 0;
            this.noteOffChNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // noteOffVNumericUpDown
            // 
            this.noteOffVNumericUpDown.Location = new System.Drawing.Point(312, 27);
            this.noteOffVNumericUpDown.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.noteOffVNumericUpDown.Name = "noteOffVNumericUpDown";
            this.noteOffVNumericUpDown.Size = new System.Drawing.Size(48, 20);
            this.noteOffVNumericUpDown.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.CCSendButton);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.CCIdNumericUpDown);
            this.groupBox3.Controls.Add(this.CCChNumericUpDown);
            this.groupBox3.Controls.Add(this.CCVNumericUpDown);
            this.groupBox3.Location = new System.Drawing.Point(12, 222);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(476, 68);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "CC Message";
            // 
            // CCSendButton
            // 
            this.CCSendButton.Location = new System.Drawing.Point(380, 24);
            this.CCSendButton.Name = "CCSendButton";
            this.CCSendButton.Size = new System.Drawing.Size(75, 23);
            this.CCSendButton.TabIndex = 5;
            this.CCSendButton.Text = "Send";
            this.CCSendButton.UseVisualStyleBackColor = true;
            this.CCSendButton.Click += new System.EventHandler(this.CCSendButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(262, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Value";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(141, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Channel";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "ControlId";
            // 
            // CCIdNumericUpDown
            // 
            this.CCIdNumericUpDown.Location = new System.Drawing.Point(63, 27);
            this.CCIdNumericUpDown.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.CCIdNumericUpDown.Name = "CCIdNumericUpDown";
            this.CCIdNumericUpDown.Size = new System.Drawing.Size(49, 20);
            this.CCIdNumericUpDown.TabIndex = 1;
            // 
            // CCChNumericUpDown
            // 
            this.CCChNumericUpDown.Location = new System.Drawing.Point(193, 27);
            this.CCChNumericUpDown.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.CCChNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CCChNumericUpDown.Name = "CCChNumericUpDown";
            this.CCChNumericUpDown.Size = new System.Drawing.Size(51, 20);
            this.CCChNumericUpDown.TabIndex = 0;
            this.CCChNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CCVNumericUpDown
            // 
            this.CCVNumericUpDown.Location = new System.Drawing.Point(312, 27);
            this.CCVNumericUpDown.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.CCVNumericUpDown.Name = "CCVNumericUpDown";
            this.CCVNumericUpDown.Size = new System.Drawing.Size(48, 20);
            this.CCVNumericUpDown.TabIndex = 0;
            // 
            // OutputsComboBox
            // 
            this.OutputsComboBox.FormattingEnabled = true;
            this.OutputsComboBox.Location = new System.Drawing.Point(75, 23);
            this.OutputsComboBox.Name = "OutputsComboBox";
            this.OutputsComboBox.Size = new System.Drawing.Size(243, 21);
            this.OutputsComboBox.TabIndex = 8;
            this.OutputsComboBox.SelectedIndexChanged += new System.EventHandler(this.OutputsComboBox_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Output";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 305);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.OutputsComboBox);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Midi Message Sender";
            ((System.ComponentModel.ISupportInitialize)(this.noteOnChNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noteOnIdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noteOnVNumericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.noteOffIdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noteOffChNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noteOffVNumericUpDown)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CCIdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CCChNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CCVNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown noteOnChNumericUpDown;
        private System.Windows.Forms.NumericUpDown noteOnIdNumericUpDown;
        private System.Windows.Forms.NumericUpDown noteOnVNumericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button noteOnSendButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button noteOffSendButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown noteOffIdNumericUpDown;
        private System.Windows.Forms.NumericUpDown noteOffChNumericUpDown;
        private System.Windows.Forms.NumericUpDown noteOffVNumericUpDown;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button CCSendButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown CCIdNumericUpDown;
        private System.Windows.Forms.NumericUpDown CCChNumericUpDown;
        private System.Windows.Forms.NumericUpDown CCVNumericUpDown;
        private System.Windows.Forms.ComboBox OutputsComboBox;
        private System.Windows.Forms.Label label10;
    }
}

