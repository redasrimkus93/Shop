using Shop.Model;
using Shop.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Repositories
{
    internal class CandiesRepository
    {
        private List<Candy> candies;
        private readonly CandyFileReaderService _candyFileReaderService;

        public CandiesRepository(CandyFileReaderService candyFileReaderService)
        {
            _candyFileReaderService = candyFileReaderService;
            candies = _candyFileReaderService.ReadExcelFileToCandyObjectList(@"source\candies.xlsx");
        }

        public List<Candy> GetAll()
        {
            return candies;
        }

        public Candy GetByName(string name)
        {
            foreach (var candy in candies)
            {
                if (candy.Name == name)
                {
                    return candy;
                }
            }

            return null;
        }


    }
}
