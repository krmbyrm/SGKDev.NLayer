using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGKDev.NLayer.Entity.Contract.Base
{
    public class BaseDTO
    {
        public Guid Id { get; set; } //Entitynin PrimarKey değişkeni 
        public bool IsDeleted { get; set; } // ileride bu değeri cons olarak set edebilmek için tutuyorum
    }
}
