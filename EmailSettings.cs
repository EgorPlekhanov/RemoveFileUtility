namespace RemoveFileUtility
{
    internal class EmailSettings
    {
        public string FromEmail { get; set; }
        public string[] ToEmails { get; set; }
        public string SmtpServer { get; set; }
        public string SmtpLogin { get; set; }
        public string SmtpPassword { get; set; }
        public bool UseSSL { get; set; } = false;
    }
}