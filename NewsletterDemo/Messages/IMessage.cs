using System;
using System.Collections.Generic;
using System.Text;

namespace NewsletterDemo.Messages {
    public interface IMessage {
        string GetSimpleMessage();
        string GetDetails();
    }
}