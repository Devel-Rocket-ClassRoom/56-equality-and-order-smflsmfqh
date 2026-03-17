using System;
using System.Collections.Generic;
using System.Text;

class TodoTask : IComparable<TodoTask>
{
    private string Title;
    private int Priority;
    private string DueDate;
    private bool IsCompleted;

    public TodoTask(string title, int priority, string dueDate, bool isCompleted)
    {
        Title = title;
        Priority = priority;
        DueDate = dueDate;
        IsCompleted = isCompleted;
    }

    public override string ToString()
    {
        return $"  [우선순위 {Priority}] {Title} (마감: {DueDate})";
    }
    public int CompareTo(TodoTask other)
    {
        if (other == null) { return 1; }
        int result = other.Priority.CompareTo(Priority);
        if (result != 0)
        {
            return result;
        }
        result = DueDate.CompareTo(other.DueDate); 
        if (result != 0) 
        { 
            return result; 
        }
        result = Title.CompareTo(other.Title);

        return result;
    }

}