using System;
using System.Collections.Generic;
using System.Text;

class BidComparer : Comparer<AuctionItem>
{
    public override int Compare(AuctionItem x, AuctionItem y)
    {
        if (x == null && y == null) return 0;
        if (x == null) return 1;
        if (y == null) return -1;
        int result = y.CurrentBid.CompareTo(x.CurrentBid);
        if (result != 0)
        {
            return result;
        }
        result = x.Name.CompareTo(y.Name);

        return result;
    }
}

