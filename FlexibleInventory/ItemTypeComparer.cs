using System;
using System.Collections.Generic;
using System.Text;

class ItemTypeComparer : EqualityComparer<Item>
{
    public override bool Equals(Item x, Item y)
    {
        if (x == null && y == null) return true;
        if (x == null || y == null) return false;

        return x.Type == y.Type;    
    }
    public override int GetHashCode(Item obj)
    {
        return HashCode.Combine(obj.Type, obj.Name);
    }
}