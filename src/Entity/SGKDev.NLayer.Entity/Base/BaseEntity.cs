using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGKDev.NLayer.Entity.EntityBase
{
    internal class BaseEntity
    {
        public Guid Id { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }

        public BaseEntity() //default cons oluşturma nedenimiz db update i sırasında oluşabilecek nullable atamalarının önüne geçmek
        {
            Id = Guid.NewGuid();// Id değişkeni bizim Primary key olacağı için Guid ref olarak create alındı.
            IsDeleted = false;
            CreatedDate = DateTime.Now; // Class oluşumu esnasında çalışan default cons tarih değişkenini referanslar ama bu durum INSERT dışında kullanılabilir mi test edilecek
            UpdatedDate = DateTime.Now; // Class oluşturulduğunda bu value nun atamasını yapmak CreatedTime gibi BussinessExp oluşturmayacağını düşünüyorum
            UpdatedBy = "admin";
        }

    }
}
