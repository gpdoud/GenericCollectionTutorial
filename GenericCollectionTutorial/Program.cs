using System;
using System.Collections.Generic;

namespace GenericCollectionTutorial {
    class Program {
        static void Main(string[] args) {

            var WxHistory = new List<Weather>(3);
            var DtThr = new Weather {
                Today = new DateTime(2021, 2, 18),
                Temperature = 19,
                Percipitation = 3
            };
            WxHistory.Add(DtThr);
            var DtWed = new Weather {
                Today = new DateTime(2021, 2, 17),
                Temperature = 4,
                Percipitation = 0
            };
            WxHistory.Add(DtWed);
            var DtTue = new Weather {
                Today = new DateTime(2021, 2, 16),
                Temperature = 25,
                Percipitation = 2
            };
            WxHistory.Add(DtTue);

            foreach(var day in WxHistory) {
                var msg = $"Weather for {day.Today.ToString("MMM dd, yyyy")}" +
                            $" Percipitation was {day.Percipitation} inches" +
                            $" Temperature was {day.Temperature} degrees";
                Console.WriteLine(msg);
            }

            var strs = new List<string> {
                "orange", "blue", "gray", 
                "red", "black", "green"
            };
            Console.WriteLine($"Favorite color count is {strs.Count}");
            strs.Sort();
            foreach(var color in strs) {
                Console.WriteLine($"Color is {color}");
            }

            var ints = new List<int>();
            ints.Add(7);
            ints.Add(10);
            ints.Add(3);
            ints.Add(6);
            ints.Add(96);
            ints.Add(22);

            foreach(var i in ints) {
                Console.WriteLine($"Favorite number is {i}");
            }
        }
    }
}
