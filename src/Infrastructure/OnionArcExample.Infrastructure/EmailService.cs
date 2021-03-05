using System;
using OnionArcExample.Application.Interfaces.Services;

namespace OnionArcExample.Infrastructure
{
    public class EmailService: IEmailService
    {
        public bool Send(string to, string message)
        {
            Console.WriteLine($"Mail Sent");
            return true;
        }
    }
}
