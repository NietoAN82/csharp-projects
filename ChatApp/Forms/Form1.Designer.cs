namespace ChatApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            chatHistoryTextBox = new TextBox();
            messageTextBox = new TextBox();
            sendButton = new Button();
            SuspendLayout();
            // 
            // chatHistoryTextBox
            // 
            chatHistoryTextBox.Location = new Point(12, 12);
            chatHistoryTextBox.Multiline = true;
            chatHistoryTextBox.Name = "chatHistoryTextBox";
            chatHistoryTextBox.ScrollBars = ScrollBars.Vertical;
            chatHistoryTextBox.Size = new Size(751, 365);
            chatHistoryTextBox.TabIndex = 0;
            chatHistoryTextBox.TextChanged += textBox1_TextChanged;
            // 
            // messageTextBox
            // 
            messageTextBox.Location = new Point(12, 383);
            messageTextBox.Multiline = true;
            messageTextBox.Name = "messageTextBox";
            messageTextBox.Size = new Size(658, 40);
            messageTextBox.TabIndex = 1;
            messageTextBox.TextChanged += textBox1_TextChanged_1;
            // 
            // sendButton
            // 
            sendButton.ImageAlign = ContentAlignment.BottomRight;
            sendButton.Location = new Point(676, 383);
            sendButton.Name = "sendButton";
            sendButton.Size = new Size(87, 40);
            sendButton.TabIndex = 2;
            sendButton.Text = "Send";
            sendButton.UseVisualStyleBackColor = true;
            sendButton.Click += sendButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(sendButton);
            Controls.Add(messageTextBox);
            Controls.Add(chatHistoryTextBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox chatHistoryTextBox;
        private TextBox messageTextBox;
        private Button sendButton;             
    }
}