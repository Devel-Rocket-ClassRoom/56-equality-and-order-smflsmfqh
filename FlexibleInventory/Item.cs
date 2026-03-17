using System;
using System.Collections.Generic;
using System.Text;

class Item
{
    public string Name;
    public string Type;
    public string Grade;

    public Item(string name, string type, string grade)
    {
        Name = name;
        Type = type;
        Grade = grade;
    }

    public override string ToString()
    {
        return $"  -{Name} ({Grade})";
    }
}