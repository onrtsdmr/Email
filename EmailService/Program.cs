using EmailService.Extensions;

namespace EmailService
{
    internal static class Program
    {
        private const string MailTo = "onurtaademir@gmail.com";

        private static void Main(string[] args)
        {
            MailTo.EmailSend();
        }
    }
}