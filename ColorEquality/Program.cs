using System;
using System.Collections.Generic;

Color color1 = new Color(255, 0, 0);
Color color2 = new Color(0, 0, 255);
Color color3 = new Color(250, 5, 3);
Color color4 = new Color(200, 50, 50);

Color color5 = new Color(255, 0, 0);
Color color6 = new Color(0, 255, 0);
int threshold = 10;

HashSet<Color> colors = new HashSet<Color>();
colors.Add(color1);
colors.Add(color2);
colors.Add(color5);
colors.Add(color6);

Console.WriteLine("=== 동등성 비교 ===");
Console.WriteLine($"{color1} == {color5}: {color1.Equals(color5)}");
Console.WriteLine($"{color1} == {color2}: {color1.Equals(color2)}");
Console.WriteLine();
Console.WriteLine("=== 유사 색상 판정 ===");
Console.WriteLine($"{color1}과 {color3}은 유사한가 (임계값 {threshold}): {color1.IsSimilar(color3, threshold)}");
Console.WriteLine($"{color1}과 {color4}은 유사한가 (임계값 {threshold}): {color1.IsSimilar(color4, threshold)}");
Console.WriteLine();
Console.WriteLine("=== HashSet 중복 제거 ===");
Console.WriteLine("팔레트에 추가된 색상:");

foreach (Color color in colors)
{
    Console.WriteLine($"  {color}");
}
Console.WriteLine($"색상 수: {colors.Count}");
Console.WriteLine();
Console.WriteLine($"{color1} 포함 여부: {colors.Contains(color1)}");


