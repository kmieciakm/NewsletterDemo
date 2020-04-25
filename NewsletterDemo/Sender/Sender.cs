using NewsletterDemo.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace NewsletterDemo.Sender {
    public abstract class Sender {

        protected MessageHandler _OnMessageSent; 

        public event MessageHandler OnMessageSent {
            add { 
                _OnMessageSent = (MessageHandler) 
                    Delegate.Combine(value, _OnMessageSent); 
            }
            remove { 
                _OnMessageSent = (MessageHandler) 
                    Delegate.Remove(_OnMessageSent, value); 
            }
        }

    }
}