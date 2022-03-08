using Shop.Model;
using Shop.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Repositories
{
    internal class MeatRepository
    {
        private readonly MeatFileReaderService _meatFileReaderService;
        public List<Meat> meats;

        public MeatRepository(MeatFileReaderService meatFileReaderService)
        {
            _meatFileReaderService = meatFileReaderService;
            meats = _meatFileReaderService.ReadExcelFileToMeatObjectList(@"source\meat.xlsx");
        }


    }
}
