using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace async_await
{
    class People
    {
        public static List<Person> PeopleList { get; set; } = new List<Person>();

        public static bool LoadFromPath(string filePath)
        {
            try
            {
                string content = System.IO.File.ReadAllText(filePath);
                PeopleList = JsonConvert.DeserializeObject<List<Person>>(content);
            } catch(Exception e)
            {
                return false;
            }
            return true;
        }
    }
}
