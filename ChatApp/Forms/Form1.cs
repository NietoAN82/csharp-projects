namespace ChatApp
{
    public partial class Form1 : Form
    {
        private Server server;
        public Form1(Server server)
        {
            InitializeComponent();
            this.server = server;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

       internal void sendButton_Click(object sender, EventArgs e)
        {
            string message = messageTextBox.Text;

            //Sends the message to the server
            chatHistoryTextBox.AppendText("You: " + message + Environment.NewLine);
            server.Send(message);
            //Clear the message text box
            messageTextBox.Clear();
        }
        
    }
}