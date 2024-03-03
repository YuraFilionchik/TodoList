using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
namespace TodoList;

public class TodoItem
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public bool IsDone { get; set; } = false;
    public string? Description { get; set; }
    [DataType(DataType.DateTime)]
    public DateTime CreatedDate { get; set; } = DateTime.Now;

    [DataType(DataType.DateTime)]
    public DateTime? UpdatedDate { get; set; } = DateTime.Now;
    public bool IsDeleted { get; set; } = false;
    [DataType(DataType.DateTime)]
    public DateTime? DueDate { get; set; }
    public string Tags { get; set; } = string.Empty;
    public PriorityType Priority { get; set; } = PriorityType.Medium;
    
}

public class testItem
{
    public int Id { get; set; }
    public string name { get; set; }
}
