using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_livros
{
    internal class Livro
    {
        private int _id;
        public int Id { get { return _id; } set 
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("O valor deve ser maior do que zero.");
                _id = value;
            } 
        }
        private long _isbn;
        public long Isbn { get { return _isbn; } set {

            }
        }
    }
}
