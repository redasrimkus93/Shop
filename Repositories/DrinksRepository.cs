using Shop.Model;
using Shop.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Repositories
{
    internal class DrinksRepository
    {
        private readonly DrinkFileReaderService _drinkFileReaderService;
        public List<Drink> drinks;

        public DrinksRepository(DrinkFileReaderService drinkFileReaderService)
        {
            _drinkFileReaderService = drinkFileReaderService;
            drinks = _drinkFileReaderService.ReadExcelFileToDrinkObjectList(@"source\drinks.xlsx");
        }
    }
}
