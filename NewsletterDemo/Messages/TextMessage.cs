using System;
using System.Collections.Generic;
using System.Text;

namespace NewsletterDemo.Messages {
    public class SMSMessage : IMessage {
        public SMSMessage(string sender, string text) {
            Sender = sender;
            Text = text;
        }

        private string Text { get; set; }
        private string Sender { get; set; }

        public string GetDetails() {
            string output;
            output = "From: " + Sender + "\n"
                   + "Message: " + Text + "\n";

            return output;
        }

        public string GetSimpleMessage() {
            return Text;
        }
    }
}