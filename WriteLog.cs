using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;


namespace WebService
{
    public class WriteLog
    {
        static string path = "./Log";

        
       

        public static bool WriteErroLog(string errinfo)
        {
            bool result = false;
            string strException = string.Empty;
            string filename = "Log" + DateTime.Now.ToString("YYYYMMDD")+".log";
            string filepath = path + "\\" + filename;
            try
            {
                if (!File.Exists(filepath))
                    File.Create(filepath);
                StreamWriter writer = File.AppendText(filepath);
                writer.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + ":" + errinfo);
                writer.Flush();
                writer.Close();
            }
            catch(Exception e)
            {
                result = false;
            }
            return result;
        }
    }
}