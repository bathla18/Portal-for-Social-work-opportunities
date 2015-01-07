using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;

/// <summary>
/// Summary description for SendMail
/// </summary>
public class SendMail
{
    static SmtpClient Smtpserver;
	public SendMail()
	{
		Smtpserver = new SmtpClient("smtp.gmail.com");
        Smtpserver.Port = 587;
        Smtpserver.Credentials = new System.Net.NetworkCredential("ankitb@maqsoftware.net", "rit2011089");
        Smtpserver.EnableSsl = true;
	}
    public static bool sendMail(string[] to, string subject, string body)
    {
        bool mailSentStatus = true;
        foreach (string toPerson in to)
        {
            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("no-reply@ongoingass.com");
                mail.To.Add(toPerson);
                mail.Subject = subject;
                mail.Body = body;
                
                Smtpserver.Send(mail);

            }
            catch (Exception ex)
            {
                mailSentStatus = false;
            }
        }
        return mailSentStatus;
    }
}