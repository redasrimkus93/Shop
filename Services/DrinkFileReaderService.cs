using Ganss.Excel;
using Shop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Services
{
    internal class DrinkFileReaderService
    {
        public List<Drink> ReadExcelFileToDrinkObjectList(string path)
        {
            var listOfDrinks = new ExcelMapper(path).Fetch<Drink>().ToList();
            return listOfDrinks;
        }
    }
}
