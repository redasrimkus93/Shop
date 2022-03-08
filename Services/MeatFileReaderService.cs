using Ganss.Excel;
using Shop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Services
{
    internal class MeatFileReaderService
    {
        public List<Meat> ReadExcelFileToMeatObjectList(string path)
        {
            var listOfMeat = new ExcelMapper(path).Fetch<Meat>().ToList();
            return listOfMeat;
        }
    }
}
