using NewsletterDemo.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewsletterDemo.Reciever {
    public interface IRecevier {
        public void OnNotify( object sender, MessageEventArgs args );
    }
}