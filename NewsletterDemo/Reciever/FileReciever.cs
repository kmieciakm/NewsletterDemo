using NewsletterDemo.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewsletterDemo.Reciever {
    public class FileReciever : IRecevier {
        public string Filepath { get; private set; }

        public FileReciever( string filepath ) {
            Filepath = filepath;
        }

        public void OnNotify( object sender, MessageEventArgs args ) {
            SaveMessage(args.Text);
        }

        public void Subscribe( Sender.Sender sender ) {
            sender.OnMessageSent += OnNotify;
        }

        private void SaveMessage( string text ) {
            System.IO.File.AppendAllText(Filepath, text);
        }
    }
}
