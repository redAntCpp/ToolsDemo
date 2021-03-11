using System;
using System.Collections.Generic;
using System.Text;
using LogHelper;

namespace JsonReaderDemo
{
    //定义整个命名空间的全局变量
    public class GlobalValue
    {
        public static LogClass syslog = new LogClass("F:\\C#Workspace\\JsonReaderDemo\\JsonReaderDemo", "JsonReaderDemo",4);
    }
    public class JsonReader
    {
        
        public JsonReader(string jsonStr)
        {
            string jsonContext = jsonStr.Substring(1, jsonStr.Length - 1);
            GlobalValue.syslog.AddTrack("JosnReader", "begin");
            GlobalValue.syslog.AddTrack("读取内容：", jsonContext);
            GlobalValue.syslog.AddTrack("开始分割字符：", "");
            string[] jsonObject = jsonContext.Split(",");
            Dictionary<string, string> jsonElement = new Dictionary<string, string>();
            for (int i = 0; i < jsonObject.Length; i++)
            {
                GlobalValue.syslog.AddTrack("开始取出第"+ (i+1).ToString()+"个元素：", jsonObject[i]);
                string []temp = jsonObject[i].Split(":");
                jsonElement.Add(temp[0], temp[1]);
            }
            GlobalValue.syslog.AddTrack("写入字典完成！", "共写入"+jsonElement.Count +"条记录");
            GlobalValue.syslog.AddTrack("开始从字典还原json内容", "");
            string showText = "";
            foreach (KeyValuePair<string, string> pair in jsonElement)
            {
                showText =  showText + pair.Key + ":" + pair.Value + "\r\n";
            }
            GlobalValue.syslog.AddTrack(showText, "");
            GlobalValue.syslog.AddTrack("JosnReader", "End");
        }
    }
}
