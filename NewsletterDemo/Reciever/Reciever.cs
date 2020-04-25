using NewsletterDemo.Messages;
using NewsletterDemo.Sender;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewsletterDemo.Reciever {
    public class ConsoleReciever : IRecevier {

        public void OnNotify( object sender, MessageEventArgs args ) {
            DisplayText(args.Text);
        }

        public void Subscribe( Sender.Sender sender ) {
            sender.OnMessageSent += OnNotify;
        }

        private void DisplayText( string text ) {
            Console.WriteLine(text);
        }
    }
}