using System;
using System.Collections.Generic;

Dictionary<Item, string> dict1 = new Dictionary<Item, string>(new ItemTypeComparer());
Dictionary<Item, string> dict2 = new Dictionary<Item, string>(new ItemGradeComparer());

Item item1 = new Item("불꽃 검", "무기", "전설");
Item item2 = new Item("얼음 단검", "무기", "희귀");
Item item3 = new Item("철 갑옷", "방어구", "일반");
Item item4 = new Item("미스릴 방패", "방어구", "희귀");
Item item5 = new Item("체력 물약", "소비", "일반");

HashSet<string> printed = new HashSet<string>();

dict1.Add(item1, item1.Type);
dict1.Add(item2, item2.Type);
dict1.Add(item3, item3.Type);
dict1.Add(item4, item4.Type);
dict1.Add(item5, item5.Type);

dict2.Add(item1, item1.Grade);


foreach (var type in dict1)
{
    if (printed.Contains(type.Value)) continue;
    {
        Console.WriteLine($"[{type.Value}]");
        printed.Add(type.Value);
    }
    foreach (var item in dict1 )
    {
        if (type.Equals(item))
        {
            Console.WriteLine(item.Key);
        }
    }
}






