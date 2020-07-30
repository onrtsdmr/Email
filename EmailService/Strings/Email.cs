using System.IO;

namespace EmailService.Data
{
    public static class Email
    {
        private const string PathToHtmlFile = @"C:\Users\onurt\Desktop\.NET WEB API\EmailService\EmailService\Data\EmailTemplateHTML.html";
        public static readonly string HtmlBody = File.ReadAllText(PathToHtmlFile);
    }
}