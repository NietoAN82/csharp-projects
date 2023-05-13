using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using System.Diagnostics;

namespace ChatApp
{
    public class Server
    {
        //Listens to incoming connections
        TcpListener listener;
        //Stores connected clients
        List<TcpClient> clients;
        //Handles incoming connections.
        Thread listenThread;
        public Server()
        {
            // Create a new TcpListener and start listening for incoming connections
            listener = new TcpListener(IPAddress.Any, 1234);
            listener.Start();

            // Create a new List to store connected clients
            clients = new List<TcpClient>();

            // Start the listenThread to handle incoming connections
            listenThread = new Thread(ListenForClients);
            listenThread.Start();   
        }
        
        private void ListenForClients()
        {
            while (true)
            {
                // Accept incoming connections
                TcpClient client = listener.AcceptTcpClient();

                //Add the new client to the list of clients
                clients.Add(client);

                //Start a new thread to handle messages from the client
                Thread clientThread = new Thread(HandleClient);
                clientThread.Start(client);
                
            }
        }

        private void HandleClient(object obj)
        {
            TcpClient client = (TcpClient)obj;

            // Get the client's network stream
            NetworkStream clientStream = client.GetStream();

            while (true)
            {
                //Read incoming messages from the client
                byte[] buffer = new byte[1024];
                int bytesRead = clientStream.Read(buffer, 0, buffer.Length);

                // Convert the incoming message to a string
                string message = Encoding.ASCII.GetString(buffer, 0, bytesRead);

                //Broadcast the message to all connected clients
                Broadcast(message);
            }
        }
        private void Broadcast(string message)
        {
            //Convert the message to a byte array
            byte[] buffer = Encoding.ASCII.GetBytes(message);

            //Send the message to all connected clients
            foreach (TcpClient client in clients)
            {
                NetworkStream clientStream = client.GetStream();
                clientStream.Write(buffer, 0, buffer.Length);
            }
            Debug.WriteLine("This function is returning messages.");
        }

    }
}
