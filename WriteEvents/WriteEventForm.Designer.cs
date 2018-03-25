namespace WriteEvents
{
    partial class WriteEventForm
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
            this.DayUpDown = new System.Windows.Forms.NumericUpDown();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.eventTextBox = new System.Windows.Forms.TextBox();
            this.labelDay = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelEvent = new System.Windows.Forms.Label();
            this.textDescription = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.openFileButton = new System.Windows.Forms.Button();
            this.enterButton = new System.Windows.Forms.Button();
            this.closeFileButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DayUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // DayUpDown
            // 
            this.DayUpDown.Location = new System.Drawing.Point(79, 26);
            this.DayUpDown.Name = "DayUpDown";
            this.DayUpDown.Size = new System.Drawing.Size(200, 20);
            this.DayUpDown.TabIndex = 0;
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.Location = new System.Drawing.Point(79, 52);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.DateTimePicker.TabIndex = 1;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(79, 78);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(200, 20);
            this.priceTextBox.TabIndex = 2;
            // 
            // eventTextBox
            // 
            this.eventTextBox.Location = new System.Drawing.Point(79, 105);
            this.eventTextBox.Name = "eventTextBox";
            this.eventTextBox.Size = new System.Drawing.Size(200, 20);
            this.eventTextBox.TabIndex = 3;
            // 
            // labelDay
            // 
            this.labelDay.AutoSize = true;
            this.labelDay.Location = new System.Drawing.Point(13, 26);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(29, 13);
            this.labelDay.TabIndex = 4;
            this.labelDay.Text = "Day:";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(12, 52);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(33, 13);
            this.labelTime.TabIndex = 5;
            this.labelTime.Text = "Time:";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(13, 78);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(34, 13);
            this.labelPrice.TabIndex = 6;
            this.labelPrice.Text = "Price:";
            // 
            // labelEvent
            // 
            this.labelEvent.AutoSize = true;
            this.labelEvent.Location = new System.Drawing.Point(13, 105);
            this.labelEvent.Name = "labelEvent";
            this.labelEvent.Size = new System.Drawing.Size(38, 13);
            this.labelEvent.TabIndex = 7;
            this.labelEvent.Text = "Event:";
            // 
            // textDescription
            // 
            this.textDescription.Location = new System.Drawing.Point(79, 132);
            this.textDescription.Multiline = true;
            this.textDescription.Name = "textDescription";
            this.textDescription.Size = new System.Drawing.Size(200, 100);
            this.textDescription.TabIndex = 8;
            this.textDescription.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(12, 132);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(63, 13);
            this.labelDescription.TabIndex = 9;
            this.labelDescription.Text = "Description:";
            this.labelDescription.Click += new System.EventHandler(this.labelDiscription_Click);
            // 
            // openFileButton
            // 
            this.openFileButton.Location = new System.Drawing.Point(15, 248);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(75, 23);
            this.openFileButton.TabIndex = 10;
            this.openFileButton.Text = "Open File...";
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Click += new System.EventHandler(this.openFileBotton_Click);
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(108, 248);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(75, 23);
            this.enterButton.TabIndex = 11;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // closeFileButton
            // 
            this.closeFileButton.Location = new System.Drawing.Point(204, 248);
            this.closeFileButton.Name = "closeFileButton";
            this.closeFileButton.Size = new System.Drawing.Size(75, 23);
            this.closeFileButton.TabIndex = 12;
            this.closeFileButton.Text = "Close File";
            this.closeFileButton.UseVisualStyleBackColor = true;
            // 
            // WriteEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 279);
            this.Controls.Add(this.closeFileButton);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.openFileButton);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.textDescription);
            this.Controls.Add(this.labelEvent);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelDay);
            this.Controls.Add(this.eventTextBox);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.DateTimePicker);
            this.Controls.Add(this.DayUpDown);
            this.Name = "WriteEventForm";
            this.Text = "Write Event";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DayUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown DayUpDown;
        private System.Windows.Forms.DateTimePicker DateTimePicker;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox eventTextBox;
        private System.Windows.Forms.Label labelDay;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelEvent;
        private System.Windows.Forms.TextBox textDescription;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Button closeFileButton;
    }
}

