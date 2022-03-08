using Ganss.Excel;
using Shop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Services
{
    internal class CandyFileReaderService
    {
        public List<Candy> ReadExcelFileToCandyObjectList(string path)
        {
            var listOfCandies = new ExcelMapper(path).Fetch<Candy>().ToList();
            return listOfCandies;
        }
    }
}
