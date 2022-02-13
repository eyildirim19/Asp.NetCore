using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _11_LayoutPagesTemplateGiydirme.Models
{
    // Generic interface...
    public interface IRepository<T>
    {
        // List metodu ilgili repository sınıfında implemenet edilecektir.. (bkz) Polimorphism
        List<T> List();
    }
}