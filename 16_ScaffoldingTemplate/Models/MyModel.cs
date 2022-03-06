using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _16_ScaffoldingTemplate.Models
{
    [Bind("Name,Title")]
    public class MyModel
    {
        
        public string Name { get; set; }

        public string Title { get; set; }

        public int DemoID { get; set; }
    }

}
