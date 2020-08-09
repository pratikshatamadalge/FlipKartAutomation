using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FlipcartAutomation.DataProvider
{
    class JsonReader
    {

        public string mobileNo = "";
        public string password = "";
        public string search = "";
        public string email = "";
        public string password1 = "";
        public string json = "";

        public JsonReader()
        {
            using (StreamReader r = new StreamReader("C:\\Users\\rohit\\source\\repos\\FlipcartAutomation\\FlipcartAutomation\\DataProvider\\Data.json"))
            {
                json = r.ReadToEnd();
            }

            dynamic array = JsonConvert.DeserializeObject(json);

            mobileNo = array["mobileNo"];
            password = array["password"];
            search = array["Iphone"];
            email = array["email"];
            password1 =array["password1"];
        }
    }
}
