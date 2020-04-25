using System;
using System.Collections.Generic;
using System.Text;

namespace NewsletterDemo.Messages {
    public class MessageEventArgs : EventArgs {
        public string Text { get; }

        public MessageEventArgs( string text ) {
            Text = text;
        }
    }

    public delegate void MessageHandler(object sender, MessageEventArgs messageArgs);
}
