using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Develop03
{
    public class Reference
    {
        private  string _book;
        private  int _chapter;
        private  int _verse;
        public Reference(string book, int chapter, int verse)
        {
            _book = book;
            _chapter = chapter;
            _verse = verse;
        }
        public  void DislpayReference()
        {
            Console.WriteLine( $"{_book} {_chapter}:{_verse}");
        }

    }
}
