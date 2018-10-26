using System;
using System.Collections.Generic;
using System.Text;

namespace Experience.Models
{
    public class BaseTemplate : IBaseTemplate
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
