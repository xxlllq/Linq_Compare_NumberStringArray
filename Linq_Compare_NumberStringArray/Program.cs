using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Compare_NumberStringArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str1 = { "", "", "4" };
            List<string> lwt = null;
            
            List<Size> strList = new List<Size>();
            strList.Add(new Size { L = "225.00", W = "170.00", T = "38.00" });
            strList.Add(new Size { L = "505.00", W = "158.00", T = "162.00" });
            strList.Add(new Size { L = "480.00", W = "340.00", T = "130.00" });
            strList.Add(new Size { L = "163.00", W = "3.00", T = "406.00" });
            strList.Add(new Size { L = "54.00", W = "23.00", T = "41.00" });
            var sd = strList.Where(m =>
            {
                lwt = new List<string> { m.L, m.W, m.T};
                var filter = str1.Where(x => !string.IsNullOrEmpty(x));
                var count = 0;
                filter.ToList().ForEach(x =>
                {
                    var flag = false;
                    foreach (var item in lwt)
                    {
                        if (item.StartsWith(x))
                        {
                            count++;
                            lwt.Remove(item);
                            break;
                        }
                    }
                });

                if (filter.Count() == count)
                {
                    return true;
                }
                return false;
            }).ToList();

            var 代码 = "Program";
        }





        public class Size
        {
            /// <summary>
            /// Length
            /// </summary>
            public string L { get; set; }
            /// <summary>
            /// Weigh
            /// </summary>
            public string W { get; set; }
            /// <summary>
            /// Thick
            /// </summary>
            public string T { get; set; }
        }
    }
}
