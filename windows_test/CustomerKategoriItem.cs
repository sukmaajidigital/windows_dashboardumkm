using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace windows_test
{
    internal class CustomerKategoriItem
    {
        public int Id { get; set; }
        public string Nama { get; set; }

        public override string ToString()
        {
            return Nama;
        }
    }
}
