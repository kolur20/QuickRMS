
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Xml.Linq;
using HtmlAgilityPack;
using System.Xml;

namespace QuickRMS.Classes
{
    class ConnectionManager
    {
        public bool CheckConnection(string host)
        {
            try
            {
                var req = string.Format($"{host}/service/");
                SendRequest(req);
                
                return true;
            }
            catch (Exception)
            {
               return false;
            }
        }
        public string CheckConnectionSafe(string host)
        {
            var req = string.Format($"{host}/service/");
            int del = 0;
            if (req.Contains("://"))
            {
                del = req.IndexOf(':');
                req = req.Remove(0, del);
            }
            else
            {
                req = "://" + req;
                host = "://" + host;
            }
            try
            {
                try
                {
                    SendRequest(@"http" + req);
                    return @"http" + host.Remove(0, del);
                }
                catch (Exception)
                {
                    SendRequest(@"https" + req);

                    return @"https" + host.Remove(0, del);
                }
            }
            catch (Exception)
            {
                return host;
            }
        }

        public string GetServerInfo(string host)
        {
            var req = string.Format($"{host}/get_server_info.jsp?encoding=UTF-8");
            var res = SendRequest(req);
            XElement root;
            try
            {
                root = XElement.Parse(res);
            }
            catch (Exception)
            {
                throw new Exception("Не удалось распарсить server_info");
            }
            var xElement = root.Element("serverName");
            return xElement != null ? xElement.Value : "";
        }


        public string GetServerVersion(string host)
        {
            var req = string.Format($"{host}/get_server_info.jsp?encoding=UTF-8");
            var res = SendRequest(req);
            XElement root;
            try
            {
                root = XElement.Parse(res);
            }
            catch (Exception)
            {
                throw new Exception("Не удалось распарсить server_info");
            }
            var xElement = root.Element("version");
            return xElement != null ? xElement.Value : "";
        }
        private string SendRequest(string gethttp)
        {
            WebRequest webRequest = WebRequest.Create(gethttp);
            webRequest.Headers.Add("Accept-Language", "ru-RU");

            webRequest.Timeout = 5000;
            WebResponse response1;
            try
            {
                response1 = webRequest.GetResponse();
            }
            catch (WebException ex)
            {
                string str = "";
                WebResponse response2 = ex.Response;
                if (response2 == null)
                    throw new Exception(ex.Message);
                using (Stream responseStream = response2.GetResponseStream())
                {
                    if (responseStream != null)
                    {
                        string end = new StreamReader(responseStream).ReadToEnd();
                        HtmlDocument htmlDocument = new HtmlDocument();
                        htmlDocument.LoadHtml(end);
                        str = htmlDocument.DocumentNode.Descendants("div").Aggregate<HtmlNode, string>(str, (Func<string, HtmlNode, string>)((current, item) => current + item.InnerText));
                    }
                }
                if (str == "")
                    str = ex.Message;
                throw new Exception(str);
            }
            Stream responseStream1 = response1.GetResponseStream();
            if (responseStream1 == null)
                return "";
            StreamReader streamReader = new StreamReader(responseStream1, Encoding.UTF8);
            string end1 = streamReader.ReadToEnd();
            streamReader.Close();
            responseStream1.Close();
            response1.Close();
            return end1;
        }
    }
}
