using Shop.Model;
using Shop.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Repositories
{
    internal class VegetablesRepository
    {
        private readonly VegetableFileReaderService _vegetableFileReaderService;
        public List<Vegetable> vegetables;
        public VegetablesRepository(VegetableFileReaderService vegetableFileReaderService)
        {
            _vegetableFileReaderService = vegetableFileReaderService;
            vegetables = _vegetableFileReaderService.ReadExcelFileToVegerableObjectList(@"source\vegetables");
        }




    }
}
