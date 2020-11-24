using CsvHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickRMS.Classes
{
    class CsvManager
    {
        string Import_FilePath { get; set; }
        string Eksport_FilePath { get; set; }


        public IEnumerable<Server> Import(string filename)
        {
            Import_FilePath = filename;
            var Servers = new List<Server>();

            using (StreamReader streamReader = new StreamReader(Import_FilePath))
            {
                using (CsvReader csvReader = new CsvReader(streamReader, System.Globalization.CultureInfo.CreateSpecificCulture("en-US")))
                {
                    // указываем используемый разделитель
                    csvReader.Configuration.Delimiter = ";";
                    // получаем строки
                    Servers = csvReader.GetRecords<Server>().ToList();
                }
            }
            return Servers;
        }

        public void Export(string filename, IEnumerable<Server> servers)
        {
            Eksport_FilePath = filename;
            using (StreamWriter streamReader = new StreamWriter(Eksport_FilePath))
            {
                using (CsvWriter csvReader = new CsvWriter(streamReader, System.Globalization.CultureInfo.CreateSpecificCulture("en-US")))
                {
                    // указываем разделитель, который будет использоваться в файле
                    csvReader.Configuration.Delimiter = ";";
                    // записываем данные в csv файл
                    csvReader.WriteRecords(servers);
                }
            }
        }
    }
}
