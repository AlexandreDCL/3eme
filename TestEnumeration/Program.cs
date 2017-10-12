using System;

namespace TestEnumeration
{
    class Program
    {
        
        public enum DayOfWeek
                {
                    Dimanche = 1,
                    Lundi,
                    Mardi,
                    Mercredi,
                    Jeudi,
                    Vendredi,
                    Samedi
                }
        static void Main()
            {
                    DayOfWeek Day;
                    Day = DayOfWeek.Dimanche;
                    Array dayArray = Enum.GetValues(typeof(DayOfWeek));
                    foreach (DayOfWeek Days in dayArray)
                        {
                            Console.WriteLine("Le jour n°{0} est le {1}",(int)Days,Days);
                        }
            Console.ReadKey();//ceci est un commentaire
            }
        }
    }

