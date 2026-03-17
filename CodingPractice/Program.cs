using System;
using System.Collections.Generic;

// 1
{
    string s1 = "hello";
    string s2 = "hello";    
    string s3 = new string("hello".ToCharArray());

    Console.WriteLine(s1 == s2);
    Console.WriteLine(s2 == s3);
    Console.WriteLine(object.ReferenceEquals(s1, s2));
    Console.WriteLine(object.ReferenceEquals(s1, s3));
    Console.WriteLine();
}

// 2
{
    Player p1 = new Player("a", 1);
    Player p2 = new Player("a", 1);
    Player p3 = p1;
    Console.WriteLine($"p1 == p2: {p1 == p2}");
    Console.WriteLine($"p1 == p3: {p1 == p3}");
    Console.WriteLine($"p1.Equals(p2): {p1.Equals(p2)}");
    Console.WriteLine($"p1.Equals(p3): {p1.Equals(p3)}");
    Console.WriteLine();

}

// 3
{
    Position pos1 = new Position(10, 20);
    Position pos2 = new Position(10, 20);
    Position pos3 = new Position(30, 40);

    Console.WriteLine($"pos1.Equals(pos2): {pos1.Equals(pos2)}");
    Console.WriteLine($"pos1.Equals(pos3): {pos1.Equals(pos3)}");
    Console.WriteLine();
}

// 4
{
    Item item1 = new Item("포션", 1);
    Item item2 = new Item("포션", 1);
    Item item3 = new Item("d", 2);
    HashSet<Item> inventory = new HashSet<Item>();
    inventory.Add(item1);
    //inventory.Add(item2);
    inventory.Add(item3);

    Console.WriteLine($"item1.Equals(item2): {item1.Equals(item2)}");
    Console.WriteLine($"item1.Equals(item3): {item1.Equals(item3)}");
    Console.WriteLine($"inventory.Contains(item2): {inventory.Contains(item2)}");
    Console.WriteLine();

}

// 5
{
    BadItem b1 = new BadItem("1");
    BadItem b2 = new BadItem("1");
    Dictionary<BadItem, int> stock = new Dictionary<BadItem, int>();
    stock.Add(b1, 1);
    
    Console.WriteLine($"b1.Equals(b2): {b1.Equals(b2)}");
    Console.WriteLine($"stock.ContainsKey(b2): {stock.ContainsKey(b2)}");
    Console.WriteLine();

}

// 6
{
    List<Monster> monsters = new List<Monster>
    {
        new Monster("Goblin", 30),
        new Monster("Dragon", 100),
        new Monster("Slime", 10),
        new Monster("Orc", 50)
    };
    Console.WriteLine("정렬 전: ");
    foreach( Monster monster in monsters )
    {
        Console.WriteLine(monster);
    }
    Console.WriteLine();
    monsters.Sort();
    Console.WriteLine("정렬 후: ");
    foreach (Monster monster in monsters)
    {
        Console.WriteLine(monster);
    }
    Console.WriteLine();
}

// 7
{
    List<Student> students = new List<Student>
    {
        new Student("이영희", 1, 92),
        new Student("정수진", 1, 88),
        new Student("최동훈", 2, 90),
        new Student("김철수", 2, 85),
        new Student("박민수", 2, 85),
    };
    students.Sort();
    Console.WriteLine("정렬 결과: ");
    foreach (Student student in students)
    {
        Console.WriteLine(student);
    }
    Console.WriteLine();
}

// 8
{
    Customer c1 = new Customer("haneul", "lee");
    Customer c2 = new Customer("haneul", "lee");
    Dictionary<Customer, string> dict1 = new Dictionary<Customer, string>();
    dict1[c1] = "VIP";
    Dictionary<Customer, string> dict2 = new Dictionary<Customer, string>(new CustomerNameCoomparer());
    dict2[c1] = "VIP";
    Console.WriteLine($"기본 Dictionary - c2 검색: {dict1.ContainsKey(c2)}");
    Console.WriteLine($"커스텀 Dictionary - c2 검색: {dict2.ContainsKey(c2)}");
    Console.WriteLine();
}

// 9
{
    Dictionary<string, int> dict = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
    Dictionary<string, int> dict1 = new Dictionary<string, int>();
    dict["ApPle"] = 100;
    dict["BaNana"] = 200;
    dict1["ApPle"] = 100;
    Console.WriteLine($"apple 검색: {dict["apple"]}");
    Console.WriteLine($"banana 검색: {dict["banana"]}");
    Console.WriteLine($"일반 Dictionary에서 'apple' 존재 여부: {dict1.ContainsKey("apple")}");
    Console.WriteLine();
}

// 10
{
    List<Quest> quests = new List<Quest>
    {
        new Quest("드래곤 처치", 1, 10000),
        new Quest("마을 방어", 2, 500),
        new Quest("보물 찾기", 2, 3000),
        new Quest("약초 수집", 3, 100)
    };
    quests.Sort(new QuestPriorityComparer());
    Console.WriteLine("우선 순위 기준 정렬: ");
    foreach(Quest quest in quests)
    {
        Console.WriteLine(quest);
    }
    Console.WriteLine();
    Console.WriteLine("보상 기준 정렬 (내림차순)");
    quests.Sort(new QuestRewardComparer());
    foreach (Quest quest in quests)
    {
        Console.WriteLine(quest);
    }
    Console.WriteLine();
}

// 11
{
    string[] strings = new string[]{ "apple", "Banana", "CHERRY", "date", "Elderberry" };
    Array.Sort(strings, StringComparer.Ordinal);
    Console.WriteLine("Ordinal 정렬 (대소문자 구분): ");
    Console.WriteLine(string.Join(", ", strings));
    Console.WriteLine();
    Array.Sort(strings, StringComparer.OrdinalIgnoreCase);
    Console.WriteLine("OrdinalIgnoreCase 정렬: ");
    Console.WriteLine(string.Join(", ", strings));
    Console.WriteLine();
}

// 12
{ 
    Comparer<Product> priceComparer = Comparer<Product>.Create((x, y) => x.Price.CompareTo(y.Price));
    Comparer<Product> nameComparer = Comparer<Product>.Create((x, y) => y.Name.CompareTo(x.Name));

    List<Product> products = new List<Product>
    { 
        new Product("마우스", 30000),
        new Product("키보드", 50000),
        new Product("헤드셋", 80000),
        new Product("모니터", 300000),
    };
    products.Sort(priceComparer);
    Console.WriteLine("가격 오름차순: ");
    Console.WriteLine(string.Join("\n", products));
    Console.WriteLine();
    products.Sort(nameComparer);
    Console.WriteLine("이름 내림차순: ");
    Console.WriteLine(string.Join("\n", products));
    Console.WriteLine();
}

// 13
{
    SortedDictionary<int, string> dict = new SortedDictionary<int, string>(Comparer<int>.Create((x, y) => y.CompareTo(x)));
    dict[92] = "Choi";
    dict[85] = "Kim";
    dict[78] = "Park";

    Console.WriteLine("점수 순위표:");
    int rank = 1;
    foreach (KeyValuePair<int, string> pair in dict)
    {
        Console.WriteLine($"  {rank}위: {pair.Value} ({pair.Key})");
        rank++;
    }
    Console.WriteLine();
}

// 14
{
    HashSet<Equipment> equips = new HashSet<Equipment>(new EquipmentTypeComparer());
    equips.Add(new Equipment("불꽃 검", "무기"));
    equips.Add(new Equipment("철 갑옷", "방어구"));
    equips.Add(new Equipment("가죽 장갑", "장갑"));

    Console.WriteLine("장착된 장비: ");
    foreach(Equipment equip in equips)
    {
        Console.WriteLine(equip);
    }
    Console.WriteLine();

}

// 15
{
    static bool Contains<T>(T[] array, T target)
    {
        EqualityComparer<T> comparer = EqualityComparer<T>.Default; 
        foreach(T item in array)
        {
            if (comparer.Equals(item, target) ) return true;
        }
        return false;
    }

    int[] numbers = { 3, 11 };
    string[] words = { "banana", "apple" };
    Console.WriteLine($"numbers에 3 포함: {Contains(numbers, 3)}");
    Console.WriteLine($"numbers에 10 포함: {Contains(numbers, 10)}");
    Console.WriteLine($"words에 'banana' 포함: {Contains(words, "banana")}");
    Console.WriteLine($"words에 'grape' 포함: {Contains(words, "grape")}");
}
class Equipment
{
    public string Name;
    public string Type;

    public Equipment(string name, string type)
    {
        Name = name;
        Type = type;
    }
    public override string ToString()
    {
        return $"  {Type}: {Name}";
    }

}

class EquipmentTypeComparer : EqualityComparer<Equipment>
{
    public override bool Equals(Equipment x, Equipment y)
    {
        if (x == null && y == null) return true;
        if (x == null || y == null) return false;

        return x.Type == y.Type && x.Name == y.Name;
    }

    public override int GetHashCode(Equipment obj)
    {
        if (obj == null) return 0;
        return HashCode.Combine(obj.Name, obj.Type);
    }
}


class Product
{
    public string Name;
    public int Price;
    public Product(string name, int price)
    {
        Name = name;
        Price = price;
    }
    public override string ToString()
    {
        return $"  {Name}: {Price}원";
    }
}
class Quest
{
    public string questName;
    public int priority;
    public int reward;
    public Quest(string questName, int priority, int reward)
    {
        this.questName = questName;
        this.priority = priority;
        this.reward = reward;
    }

    public override string ToString()
    {
        return $"  [우선순위 {priority}] {questName} (보상: {reward}골드)";
    }
}

class QuestPriorityComparer : Comparer<Quest>
{
    public override int Compare(Quest x, Quest y)
    {
        if (x == null && y == null) return 0;
        if (x == null) return -1;
        if (y == null) return 1;

        return x.priority.CompareTo(y.priority);
    }
}

class QuestRewardComparer : Comparer<Quest>
{
    public override int Compare(Quest x, Quest y)
    {
        if (x == null && y == null) return 0;
        if (x == null) return 1;
        if (y == null) return -1;

        return y.reward.CompareTo(x.reward);
    }
}


class Customer
{
    public string FirstName;
    public string LastName;
    public Customer(string firstName, string lastName) 
    {
        FirstName = firstName;
        LastName = lastName;
    }
}

class CustomerNameCoomparer : EqualityComparer<Customer>
{
    public override bool Equals(Customer x, Customer y)
    {
        if (x == null && y == null) return true;
        if (x == null || y == null) return false;

        return x.FirstName == y.FirstName && x.LastName == y.LastName;     
    }

    public override int GetHashCode(Customer obj)
    {
        if (obj == null) return 0;
        return HashCode.Combine(obj.FirstName, obj.LastName);
    }
}

class Student : IComparable<Student>
{
    private string Name;
    private int Grade;
    private int Score;
    public Student(string name, int grade, int score)
    {
        Name = name;
        Grade = grade;
        Score = score;
    }

    public int CompareTo(Student other)
    {
        if (other == null) return 1;
        
        int result = other.Grade.CompareTo(Grade);    
        if (result != 0)
        {
            return result; 
        }
        result = Name.CompareTo(other.Name);
        if (result != 0)
        {
            return result;
        }
        result = Score.CompareTo(other.Score);
        return result;

    }
    public override string ToString()
    {
        return $"  {Grade}학년 {Name} ({Score}점)";
            
    }
}

class Monster : IComparable<Monster>
{
    private string Name;
    private int Power;
    public Monster( string name, int power )
    {
        Name = name;
        Power = power;
    }

    public int CompareTo(Monster monster)
    {
        if (monster == null) { return 1; }
        return Power.CompareTo(monster.Power);
    }
    public override string ToString()
    {
        return $"  {Name}(전투력: {Power})";
    }
}


class BadItem : IEquatable<BadItem> 
{
    private string name;
    public BadItem(string name ) { this.name = name; }
    public bool Equals(BadItem item)
    {
        if (item == null) { return false; }
        return name == item.name;   
    }

    public override bool Equals(object obj)
    {
        return Equals(obj as BadItem);
    }
}
class Item : IEquatable<Item>
{
    private string Name;
    private int Id;

    public Item(string name, int id )
    {
        Name = name;
        Id = id;
    }
    public bool Equals(Item item)
    {
        if (item == null) return false;

        return Id == item.Id && Name == item.Name;
    }

    public override bool Equals(object obj)
    {
        return Equals(obj as Item);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Name, Id);
    }
}

struct Position
{
    public int X;
    public int Y; 

    public Position(int x, int y)
    {
        X = x; Y = y;   
    }
}
class Player
{
    private string Name;
    private int Level;
    public Player(string name, int level)
    {
        Name = name;
        Level = level;
    }
}