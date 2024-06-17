using Core.Common;
using Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    /*
     * Encapsulation yani Kapsülleme kavramı bir özeliği başka sınıflardan saklamak ya da dışarıdan müdaheleye korumaktır.
     * // Kapsülleme sayesinden nesneler bilinçsiz olarak kullanımdan korunmuş olur. Fakat bazı durumlarda private field'lara erişmemiz ve özelliklerini değiştirmemiz gerekebilir. 
    /// Bu durumda Property Kavramı devreye girer. Property bir field'ın değerini geri döndürmeye(Get) ve yeni bir değer(Set) atamaya olanak sağlar.
    /// */
    public class Product : IEntity
    {
        private Guid id = Guid.NewGuid();
        private string name = ""; //field
        private string description = "";
        private Categories category = Categories.Unlisted;

        public string Name //Property
        {
            get { return name; }
            set { name = value; }
        }

        public string Description { get { return description; } set { description = value; } } //Property
        public Categories Category { get { return category; } set { category = value; } } //Property

        public override string ToString()
        {
            return $"{id} {name} {description} {category}";
        }

    }
}
