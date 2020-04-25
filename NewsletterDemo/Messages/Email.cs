using System;
using System.Collections.Generic;
using System.Text;

namespace NewsletterDemo.Messages {
    public class Email : IMessage {
        public Email( string sender, string title, string text ) {
            Sender = sender;
            Text = text;
            Title = title;
        }

        private string Text { get; set; }
        private string Sender { get; set; }
        private string Title { get; set; }

        public string GetDetails() {
            string output;
            output = "From: " + Sender + "\n" 
                   + "Title: " + Title +  "\n"
                   + "Message: " + Text + "\n";

            return output;
        }

        public string GetSimpleMessage() {
            return Sender + "\n" 
                    + Text + "\n";
        }
    }
}