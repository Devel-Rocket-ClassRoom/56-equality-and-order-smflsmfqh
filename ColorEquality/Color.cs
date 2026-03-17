using System;
using System.Collections.Generic;
using System.Text;

class Color : IEquatable<Color>
{
    public int R;
    public int G;
    public int B;
    public Color(int r, int g, int b)
    {
        R = r;
        G = g;
        B = b;
    }
    public override string ToString()
    {
        return $"RGB({R}, {G}, {B})";
    }

    public bool IsSimilar(Color other, int threshold)
    {
        if (other == null) return false ;
        int rSub = Math.Abs(R - other.R);
        int gSub = Math.Abs(G - other.G);
        int bSub = Math.Abs(B - other.B);

        return rSub <= threshold && G <= threshold && B <= threshold ;
    }
    public bool Equals(Color other)
    {
        if (other == null) return false;
        return R.Equals(other.R) && G.Equals(other.G) && B.Equals(other.B) ;    
    }
    public override bool Equals(Object obj)
    {
        return Equals(obj as Color);
    }
    public override int GetHashCode()
    {
        return HashCode.Combine(R, G, B);
    }
}