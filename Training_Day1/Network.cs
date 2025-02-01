using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Training_Day1
{
    public class Network
    {
        public int Id { get; set; }
        public int Source { get; set; }
        public int Destination { get; set; }

        public DateTime Date { get; set; }

        public string Status { get; set; }

        public string Networks { get; set; }

        public Network(int id, int source, int destination, DateTime date, string status, string networks)
        {
            Id = id;
            Source = source;
            Destination = destination;
            Date = date;
            Status = status;
            Networks = networks;

        }

        //public void AppendingFile()
        //{
        //    FileStream fs = new FileStream("networklog.txt", FileMode.Append, FileAccess.Write);
        //    StreamWriter sw = new StreamWriter(fs);
        //    sw.WriteLine(Id);
        //    sw.WriteLine(Source);
        //    sw.WriteLine(Destination);
        //    sw.WriteLine(Date);
        //    sw.WriteLine(Status);
        //    sw.WriteLine(Networks);
        //}

        public void ReadFile()
        {

            List<Network> list1 = new List<Network>();

            FileStream fs = new FileStream("networklog.txt", FileMode.Open, FileAccess.Read);

            StreamReader sr = new StreamReader(fs);

            int id = 0; int source = 0; int destination = 0; DateTime date = DateTime.MinValue;  string status = ""; string networks = "";

            while (sr.Peek() > 0)
            {
                string line = sr.ReadLine().Trim();
                if (line.StartsWith("Id"))
                {
                    string[] s = line.Split(':'); //"Id:1" -> s[0]="Id"  s[1]="1"
                    id = Convert.ToInt32(s[1]);
                   // Console.WriteLine($"Parsed Id: {id}");
                }
                else if (line.StartsWith("Source"))
                {
                    string[] s = line.Split(":");
                    source = Convert.ToInt32(s[1]);
                 //   Console.WriteLine($"Parsed Source: {source}");
                }
                else if (line.StartsWith("Destination"))
                {
                    string[] s = line.Split(":");
                    destination = Convert.ToInt32(s[1]);
                   // Console.WriteLine($"Parsed Destination: {destination}");
                }
                else if (line.StartsWith("Date"))
                {
                    string dateString = line.Substring(line.IndexOf(':') + 1).Trim(); // Extract value after ':'

                    string[] formats = { "M/d/yyyy h:mm:ss tt", "M/d/yyyy h:mm tt", "MM/dd/yyyy", "yyyy-MM-dd" };

                    if (DateTime.TryParseExact(dateString, formats, System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out date))
                    {
                       // Console.WriteLine($"Parsed Date: {date}");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid Date format: {dateString}");
                        continue; // Skip this entry if the date is invalid
                    }
                }
                else if (line.StartsWith("Status"))
                {
                    string[] s = line.Split(":");
                    status = s[1];
                   // Console.WriteLine($"Parsed Status: {status}");
                }
                else if (line.StartsWith("Network"))
                {
                    string[] s = line.Split(":");
                    networks = s[1];
                   // Console.WriteLine($"Parsed Networks: {networks}");
                }
                //if(id != 0 && source!=0 && destination!=0 && date != DateTime.MinValue && status!="" && networks != "")
                  if (id != 0 && source != 0 && destination != 0 && date != DateTime.MinValue && !string.IsNullOrEmpty(status) && !string.IsNullOrEmpty(networks))
                 {
                    Network n = new Network(id, source, destination, date, status, networks);
                    list1.Add(n);
                    id = 0;
                    source = 0;
                    destination = 0;
                    date = DateTime.MinValue;
                    status = "";
                    networks = "";
                }
                
            }
            fs.Close();
            Console.WriteLine("Id\t\tSource\t\tDestination\t\tDate\t\tStatus\t\tNetworks");
            Console.WriteLine("************************************************************************************************************************");
            foreach (var item in list1)
            {
                //if(item.Id==1)
               
                    Console.WriteLine($"{item.Id}\t\t{item.Source}\t\t{item.Destination}\t\t{item.Date}\t\t{item.Status}\t\t{item.Networks}");
                }
            }
        }
    }

