using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net.Sockets;

namespace ClassLib.Data
{
    public static class Data
    {

        public static List <Werknemer> ReadFile(string path)
        {
            List <Werknemer> werknemers = new List <Werknemer>();


            using (StreamReader sr = new StreamReader(path))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();

                    string firstName = line.Substring(0, 15).Trim();
                    string lastName = line.Substring(15,20).Trim();

                    char type = Convert.ToChar(line.Substring(35, 1).Trim());

                    switch (type)
                    {

                        case 'K':
                            decimal wageK = decimal.Parse(line.Substring(37, 9).Trim());
                            werknemers.Add(new Kader(firstName, lastName, type, wageK));
                            break;

                        case 'B':
                            decimal uurLoon = decimal.Parse(line.Substring(45, 6).Trim());
                            decimal urenGewerkt = decimal.Parse(line.Substring(54, 7).Trim());
                            werknemers.Add(new Bediende(firstName, lastName, type, uurLoon, urenGewerkt));
                            break;

                        case 'C':
                            decimal wageC = decimal.Parse(line.Substring(36, 9).Trim());
                            decimal percentage = decimal.Parse(line.Substring(63, 5).Trim());
                            decimal omzet = decimal.Parse(line.Substring(68, 9).Trim());
                            werknemers.Add(new Commissie(firstName, lastName, type, percentage,omzet,wageC));
                            break;

                    }


                }

            }

            return werknemers;

        }

    }
}
