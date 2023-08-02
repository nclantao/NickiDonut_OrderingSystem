using System;
using System.Linq;
using System.Collections.Generic;

namespace NickiDonut;

class Addon
{
    public string Name { get; set; }

    public double Price { get; set; }

    public Addon(string Name, double Price)
    {
        this.Name = Name;

        this.Price = Price;
    }
}
