/// Week 11 Lab 1
/// File Name: week11lab1.cs
/// Author: Lucas Smith
/// Date:  November 8, 2021
///
/// Problem Statement:  Define a class named Document that contains an instance variable of type string named text that stores any textual content for the document.
/// Create a method named ToString() that returns the text field and also include a method to set this value.
/// 
/// 
/// Overall Plan:
/// 1) Declare public classes for Document, Email and File
/// 2) Declare the methods inside Document, and the extension methods in Email and File
/// 3) Test each class with the provided method
using System;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Document document = new Document();
            Console.WriteLine("Enter some text: ");
            document.SetText(Console.ReadLine());

            Email email = new Email();
            email.SetText(document.ToString());
            Console.WriteLine("Who is sending the email?");
            email.SetSender(Console.ReadLine());

            Console.WriteLine("Who is receiving the email?");
            email.SetRecipient(Console.ReadLine());

            Console.WriteLine("What is the Subject of your email?");
            email.SetTitle(Console.ReadLine());

            File file = new File();

            Console.WriteLine("Enter the file path: ");
            file.SetPathname(Console.ReadLine());
            file.SetText(document.ToString());

            Console.WriteLine("Document Output: " + document.ToString());
            Console.WriteLine("Email Output: " + email.ToString());
            Console.WriteLine("File Output: " + file.ToString());

            //Final Method Test

            Email emailTwo = new Email();
            File fileTwo = new File();

            Console.WriteLine("Enter the sender for your second email: ");
            emailTwo.SetSender(Console.ReadLine());
            Console.WriteLine("Enter the recipient for your second email: ");
            emailTwo.SetRecipient(Console.ReadLine());

            Console.WriteLine("Enter the text for your second email: ");
            emailTwo.SetText(Console.ReadLine());
            Console.WriteLine("Enter the title for your second email: ");
            emailTwo.SetTitle(Console.ReadLine());

            Console.WriteLine(ContainsKeyword(email, "text"));
            Console.WriteLine(ContainsKeyword(emailTwo, "text"));
            Console.WriteLine(ContainsKeyword(file, "text"));
            Console.WriteLine(ContainsKeyword(fileTwo, "text"));
        }

        public static bool ContainsKeyword(Document docObject, string keyword)
        {
            if (docObject.ToString().IndexOf(keyword, 0) >= 0)
            {
                return true;
            }
            return false;
        }
    }

    public class Document
    {
        protected string text;

        public void SetText(string input)
        {
            text = input;
        }

        public override string ToString()
        {
            return text;
        }
    }

    public class Email : Document
    {
        private string sender = "lsoceanengineer@gmail.com";
        private string recipient = "askrobsmith@gmail.com";
        private string title = "Email";

        public string GetSender()
        {
            return sender;
        }

        public string GetRecipient()
        {
            return recipient;
        }

        public string GetTitle()
        {
            return title;
        }

        public void SetSender(string send)
        {
            sender = send;
        }

        public void SetRecipient(string recip)
        {
            recipient = recip;
        }

        public void SetTitle(string titleName)
        {
            title = titleName;
        }

        public new string ToString()
        {
            return ("Sender: " + sender + " Recipient: " + recipient + " Subject: " + title + " Body: " + text);
        }
    }

    public class File : Document
    {
        private string pathname;

        public void SetPathname(string path)
        {
            pathname = path;
        }

        public new string ToString()
        {
            return ("Text: " + text + " Pathname: " + pathname);
        }
    }
}
