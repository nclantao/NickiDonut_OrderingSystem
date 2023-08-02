using System;
using System.Linq;
using System.Collections.Generic;

namespace NickiDonut;

class Donut
{
    public string Name { get; set; }

    public double Price { get; set; }

    public Donut(string Name, double Price)
    {
        this.Name = Name;

        this.Price = Price;
    }
}
