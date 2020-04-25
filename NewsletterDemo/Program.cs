using System;
using NewsletterDemo.Sender;
using NewsletterDemo.Messages;
using NewsletterDemo.Reciever;

namespace NewsletterDemo {
    class Program {
        static void Main( string[] args ) {
            DetailedSender senderDetail = new DetailedSender();
            QuickSender senderShort = new QuickSender();

            ConsoleReciever consoleReciever = new ConsoleReciever();
            consoleReciever.Subscribe(senderDetail);

            FileReciever spam = new FileReciever("C:\\Temp\\spam.txt");
            spam.Subscribe(senderShort);

            senderDetail.Sent(new Email("emailOne", "First email", "Lorem ipsum"));
            senderDetail.Sent(new Email("emailTwo", "Second email", "Lorem ipsum lorem"));
            senderShort.Sent(new Email("quick", "Pictures", "Lorem ipsum"));
        }
    }
}
