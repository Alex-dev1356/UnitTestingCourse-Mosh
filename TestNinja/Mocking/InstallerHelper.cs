using System; 
using System.Net;

namespace TestNinja.Mocking
{
    public class InstallerHelper
    {
        private readonly IClient _client;
        private string _setupDestinationFile;

        public InstallerHelper(IClient client)
        {
            _client = client;
        }

        //public bool DownloadInstaller(string customerName, string installerName)
        public bool DownloadInstaller(string customerName, string installerName)
        {
            //var client = new WebClient();
            try
            {
                _client.DownloadFile(
                    string.Format("http://example.com/{0}/{1}",
                        customerName,
                        installerName),
                    _setupDestinationFile);

                //_client.DownloadFile(customerName, installerName);

                return true;
            }
            catch (WebException)
            {
                return false; 
            }
        }
    }

    public interface IClient
    {
        void DownloadFile(string url, string path);
    }

    public class Client : IClient
    {
        
        public void DownloadFile(string url, string path)
        {
            var client = new WebClient();
            client.DownloadFile(url,path);
        }
    }
}