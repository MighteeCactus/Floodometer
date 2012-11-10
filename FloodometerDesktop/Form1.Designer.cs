namespace FloodometerDesktop
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
            this.components = new System.ComponentModel.Container();
            this.inputText = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.qip9095Radio = new System.Windows.Forms.RadioButton();
            this.skypeRadio = new System.Windows.Forms.RadioButton();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.outputList = new System.Windows.Forms.ListBox();
            this.ClearInput = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputText
            // 
            this.inputText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.inputText.Location = new System.Drawing.Point(15, 25);
            this.inputText.Name = "inputText";
            this.inputText.Size = new System.Drawing.Size(275, 192);
            this.inputText.TabIndex = 1;
            this.inputText.Text = "";
            this.inputText.TextChanged += new System.EventHandler(this.inputText_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Past part of chat history here:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.qip9095Radio);
            this.groupBox1.Controls.Add(this.skypeRadio);
            this.groupBox1.Location = new System.Drawing.Point(296, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(106, 73);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Messenger";
            // 
            // qip9095Radio
            // 
            this.qip9095Radio.AutoSize = true;
            this.qip9095Radio.Location = new System.Drawing.Point(7, 44);
            this.qip9095Radio.Name = "qip9095Radio";
            this.qip9095Radio.Size = new System.Drawing.Size(70, 17);
            this.qip9095Radio.TabIndex = 1;
            this.qip9095Radio.Text = "QIP 9095";
            this.qip9095Radio.UseVisualStyleBackColor = true;
            this.qip9095Radio.CheckedChanged += new System.EventHandler(this.qip9095Radio_CheckedChanged);
            // 
            // skypeRadio
            // 
            this.skypeRadio.AutoSize = true;
            this.skypeRadio.Checked = true;
            this.skypeRadio.Location = new System.Drawing.Point(7, 20);
            this.skypeRadio.Name = "skypeRadio";
            this.skypeRadio.Size = new System.Drawing.Size(55, 17);
            this.skypeRadio.TabIndex = 0;
            this.skypeRadio.TabStop = true;
            this.skypeRadio.Text = "Skype";
            this.skypeRadio.UseVisualStyleBackColor = true;
            this.skypeRadio.CheckedChanged += new System.EventHandler(this.skypeRadio_CheckedChanged);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // outputList
            // 
            this.outputList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.outputList.FormattingEnabled = true;
            this.outputList.Items.AddRange(new object[] {
            "Nothing to show"});
            this.outputList.Location = new System.Drawing.Point(15, 223);
            this.outputList.Name = "outputList";
            this.outputList.Size = new System.Drawing.Size(387, 212);
            this.outputList.TabIndex = 4;
            // 
            // ClearInput
            // 
            this.ClearInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearInput.Location = new System.Drawing.Point(296, 105);
            this.ClearInput.Name = "ClearInput";
            this.ClearInput.Size = new System.Drawing.Size(106, 23);
            this.ClearInput.TabIndex = 5;
            this.ClearInput.Text = "Clear input";
            this.ClearInput.UseVisualStyleBackColor = true;
            this.ClearInput.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 454);
            this.Controls.Add(this.ClearInput);
            this.Controls.Add(this.outputList);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputText);
            this.Name = "Form1";
            this.Text = "Floodometer";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox inputText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton qip9095Radio;
        private System.Windows.Forms.RadioButton skypeRadio;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ListBox outputList;
        private System.Windows.Forms.Button ClearInput;
    }
}

