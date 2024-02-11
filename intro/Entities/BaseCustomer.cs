using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intro.Entities
{
    public class BaseCustomer //bu sınıfı miras alan sınıflar bu sınıfı inherit((inheritance)-miras almak) etmiş oldu.
    {
        public int Id { get; set; }
        public string CustomerNumber { get; set; }
    }
}
