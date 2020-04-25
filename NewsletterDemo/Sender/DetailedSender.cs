using NewsletterDemo.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewsletterDemo.Sender {
    public class DetailedSender : Sender, ISender {

        public void Sent( IMessage message ) {
            string text = "Date: " + DateTime.Now + "\n" + message.GetDetails() + "\n";
            _OnMessageSent?.Invoke(this, new MessageEventArgs(text));
        }

        public void SentAll( ICollection<IMessage> messages ) {
            foreach (var message in messages) {
                string text = "Date: " + DateTime.Now + "\n" + message.GetDetails() + "\n";
                _OnMessageSent?.Invoke(this, new MessageEventArgs(text));
            }
        }
    }
}