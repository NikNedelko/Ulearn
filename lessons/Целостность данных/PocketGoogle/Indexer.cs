using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// https://ulearn.me/course/basicprogramming/Praktika_Karmannyy_gugl__5caa9930-a3af-4ba0-9a8e-761bb7cb0ec5
/// </summary>
namespace PocketGoogle
{
    public class Indexer : IIndexer
    {
        public void Add(int id, string documentText)
        {
            var words = documentText.Split(' ', '.', ',', '!', '?', ':', '-', '\r', '\n');
        }

        public List<int> GetIds(string word)
        {
            throw new NotImplementedException();
        }

        public List<int> GetPositions(int id, string word)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }
    }
}
