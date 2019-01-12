using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Windows.Forms;
namespace Sparkle
{
    class FTPdownload
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string URL { get; set; }
        public FtpWebRequest request { get; set; }
        public FTPdownload(string username,string password,string url)
        {
            Username = username;
            Password = password;
            URL = url;
            try
            {
                request = (FtpWebRequest)WebRequest.Create(URL);
                request.Credentials = new NetworkCredential(Username, Password);
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                if (request != null)
                {
                    request.Abort();
                }
            }
        }
        private const int bufferSize = 1024;
        public string[] ListAllFiles()
        {
            StringBuilder result = new StringBuilder();
            try
            {
                //request = (FtpWebRequest)WebRequest.Create(new Uri(URL));
                //request.Credentials = new NetworkCredential(Username, Password);
                request.Method = WebRequestMethods.Ftp.ListDirectory;
                WebResponse response = request.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream());
            string line = reader.ReadLine();
            while (line != null)
            {
                result.Append(line);
                result.Append("\n");
                line = reader.ReadLine();
            }
            result.Remove(result.ToString().LastIndexOf('\n'), 1);
            reader.Close();
            response.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                //MessageBoxEx.Show("Download2");
                if (request != null)
                {
                    request.Abort();
                }
            }

            return result.ToString().Split('\n');
        }
        public List<string> getSpecFileList(string[] fileList,string searchItem)
        {
            List<string> outstr = new List<string>();
            foreach(var item in fileList)
            {
                if (item.Contains(searchItem))
                    outstr.Add(item);
            }
            return outstr;
        }
        public void DownFile(string filePath,ProgressBar pb)
        {
            FtpWebResponse response = null;
            Stream responseStream = null;
            FileStream outStream = null;
            try
            {
                request.Method = WebRequestMethods.Ftp.DownloadFile;
                response = (FtpWebResponse)request.GetResponse();
                responseStream = response.GetResponseStream();
                byte[] buffer = new byte[bufferSize];
                int readCount = responseStream.Read(buffer, 0, bufferSize);
                string fileName = Path.GetFileName(URL);
                string newFilePath = filePath + fileName;
                outStream = File.Create(newFilePath);
                long cl = GetFileSize(URL, Username, Password);
                float percent = 0;
                while (readCount > 0)
                {
                    outStream.Write(buffer, 0, readCount);
                    readCount = responseStream.Read(buffer, 0, bufferSize);
                    percent = outStream.Length / (float)cl * 100;
                    if (percent <= 100)
                    {
                        if (pb != null)
                        {
                            pb.Invoke(new updateui(upui), new object[] { cl, (int)percent, pb });
                        }
                    }
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                if (request != null)
                    request.Abort();
                if (response != null)
                    response.Close();
                if (responseStream != null)
                    response.Close();
                if (outStream != null)
                    outStream.Close();
            }
        }
        public void DownloadAllRelated(string baseFTPpath,string filePath,string related,ProgressBar pb)
        {
            string[] allFile = ListAllFiles();
            List<string> relateFile = getSpecFileList(allFile, related);
            foreach(var item in relateFile)
            {
                string tempURL = baseFTPpath + item;
                try
                {
                    request = (FtpWebRequest)WebRequest.Create(tempURL);
                    request.Credentials = new NetworkCredential(Username, Password);
                }
                catch(Exception e)
                {
                    MessageBox.Show(e.Message);
                }
                finally
                {
                    if (request != null)
                        request.Abort();
                }
                URL = tempURL;
                DownFile(filePath,pb);
            }
        }
        public static bool Download(string FTPURL,string filePath,string FTPusername,string FTPpassword, ProgressBar pb )
        {
            FtpWebRequest reqFtp = null;
            FtpWebResponse response = null;
            Stream ftpStream = null;
            FileStream outputStream = null;
            try
            {
                reqFtp = (FtpWebRequest)WebRequest.Create(new Uri(FTPURL));
                reqFtp.UseBinary = true;
                reqFtp.Credentials = new NetworkCredential(FTPusername, FTPpassword);
                response = (FtpWebResponse)reqFtp.GetResponse();
                ftpStream = response.GetResponseStream();
                long cl = GetFileSize(FTPURL,FTPusername,FTPpassword);
                int bufferSize = 2048;
                int readCount;
                byte[] buffer = new byte[bufferSize];
                readCount = ftpStream.Read(buffer, 0, bufferSize);
                outputStream = new FileStream(filePath, FileMode.Create);
                float percent = 0;
                while (readCount > 0)
                {
                    outputStream.Write(buffer, 0, readCount);
                    readCount = ftpStream.Read(buffer, 0, bufferSize);
                    percent = outputStream.Length / (float)cl * 100;
                    if (percent <= 100)
                    {
                        if (pb != null)
                        {
                            pb.Invoke(new updateui(upui), new object[] { cl, (int)percent, pb });
                        }
                    }
                    // pb.Invoke(new updateui(upui), new object[] { cl, outputStream.Length, pb });

                }

                //MessageBoxEx.Show("Download0");
                return true;
            }
            catch (Exception ex)
            {
                //errorinfo = string.Format("因{0},无法下载", ex.Message);
                //MessageBoxEx.Show("Download00");
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                //MessageBoxEx.Show("Download2");
                if (reqFtp != null)
                {
                    reqFtp.Abort();
                }
                if (response != null)
                {
                    response.Close();
                }
                if (ftpStream != null)
                {
                    ftpStream.Close();
                }
                if (outputStream != null)
                {
                    outputStream.Close();
                }
            }
        }
        private delegate void updateui(long rowCount, int i, ProgressBar PB);
        public static void upui(long rowCount, int i, ProgressBar PB)
        {
            try
            {
                PB.Value = i;
            }
            catch { }
        }
        public static long GetFileSize(string url, string FTPusername, string FTPpassword)
        {

            long fileSize = 0;
            try
            {
                FtpWebRequest reqFtp = (FtpWebRequest)WebRequest.Create(new Uri(url));
                reqFtp.UseBinary = true;
                reqFtp.Credentials = new NetworkCredential(FTPusername, FTPpassword);
                reqFtp.Method = WebRequestMethods.Ftp.GetFileSize;
                FtpWebResponse response = (FtpWebResponse)reqFtp.GetResponse();
                fileSize = response.ContentLength;

                response.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return fileSize;
        }
    }
}
