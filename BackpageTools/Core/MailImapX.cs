using ImapX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BackpageTools.Core
{
    public class MailImapX
    {
        string _server = string.Empty;
        string _login = string.Empty;
        string _password = string.Empty;
        ImapX.ImapClient _client = null;
        public MailImapX(string server, string login, string password)
        {
            _server = server;
            _login = login;
            _password = password;
            _client = new ImapX.ImapClient(server, true);
            if (!_client.Connect())
                return;
            if (!_client.Login(_login, _password))
                return;
        }
        public ImapX.Message GetMailBySubject(string subject)
        {
            ImapX.Message output = null;
            if (!_client.IsConnected)
            {
                if (!_client.Connect())
                    return output;
                if (!_client.Login(_login, _password))
                    return output;
            }
            ImapX.Message[] messages = _client.Folders.Inbox.Search("UNSEEN", ImapX.Enums.MessageFetchMode.Headers); // THIS LINE takes like 5-10 seconds to complete
            foreach (var item in messages)
            {
                if (item.Subject.Contains(subject))
                {
                    item.Download(ImapX.Enums.MessageFetchMode.Body);
                    output = item;
                    break;
                }
            }
            return output;
        }
        private static void test()
        {
            var server = "imap.gmail.com";
            var login = "mohamed.aly.omer@gmail.com";
            var password = "FalseX!983";

            var attachmentsPath = @"C:\test";
            var inboxFolderName = "INBOX";
            var processedFolderName = "PROCESSED";

            var processedMessages = new List<Message>();

            var client = new ImapX.ImapClient(server, true);

            var messages = client.Folders.Inbox.Search("UNSEEN"); // THIS LINE takes like 5-10 seconds to complete

            foreach (var item in messages)
            {
                if (item.Subject.Contains("Click link to post!"))
                {
                    string s = item.Subject;

                }
            }

            var inboxFolder = client.Folders.FirstOrDefault(f => f.Name == inboxFolderName);
            if (inboxFolder == null)
                return;
            inboxFolder.Messages.Download();

        }
    }
}
