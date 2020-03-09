using System.Collections.Generic;
using System;

namespace DataLife
{
    public static class CommendDictionary
    {
        public static Dictionary<string,string> Com = new Dictionary<string, string>{
            {"ShowAllBooks", "show books"},
            {"StartReadBook", "start read"},
            {"Quit","q"}

        };

        public static void ShowAllCommend()
        {
            Console.WriteLine(String.Format("{0, -20}\t{1, -10}", "Name", "<color=#FFFF00 >Commend<color>"));
            foreach(var commend in Com)
            {
				Console.WriteLine(String.Format("{0, -20}\t{1, -10}", "\""+commend.Key+"\"", "-"+commend.Value));
			}
        }
    }
}