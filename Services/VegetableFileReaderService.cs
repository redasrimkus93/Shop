using Ganss.Excel;
using Shop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Services
{
    internal class VegetableFileReaderService
    {
        public List<Vegetable> ReadExcelFileToVegerableObjectList(string path)
        {
            var listOfVegetables = new ExcelMapper(path).Fetch<Vegetable>().ToList();
            return listOfVegetables;
        }
    }
}
