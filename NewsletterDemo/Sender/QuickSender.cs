using NewsletterDemo.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewsletterDemo.Sender {
    public class QuickSender : Sender, ISender {

        public void Sent( IMessage message ) {
            string text = message.GetSimpleMessage();
            _OnMessageSent?.Invoke(this, new MessageEventArgs(text));
        }

        public void SentAll( ICollection<IMessage> messages ) {
            foreach (var message in messages) {
                string text = message.GetSimpleMessage();
                _OnMessageSent?.Invoke(this, new MessageEventArgs(text));
            }
        }
    }
}