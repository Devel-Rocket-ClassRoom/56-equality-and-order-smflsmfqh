using System;
using System.Collections.Generic;

List<TodoTask> tasks = new List<TodoTask>
{
    new TodoTask("보고서 작성", 3, "2026-03-15", false ),
    new TodoTask("이메일 확인", 1, "2026-03-10", false ),
    new TodoTask("버그 수정", 3, "2026-03-10", false ),
    new TodoTask("회의 준비", 2, "2026-03-12", false ),
    new TodoTask("코드 리뷰", 3, "2026-03-10", false ),

};

Console.WriteLine("=== 정렬 전 ===");
Console.WriteLine(string.Join("\n", tasks));
Console.WriteLine();
Console.WriteLine("=== 정렬 후 ===");
tasks.Sort();
Console.WriteLine(string.Join("\n", tasks));

