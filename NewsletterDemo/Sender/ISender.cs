using NewsletterDemo.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewsletterDemo.Sender {
    public interface ISender {
        void Sent(IMessage message);
        void SentAll(ICollection<IMessage> messages);
    }
}