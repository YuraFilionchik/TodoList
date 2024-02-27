using System.ComponentModel.DataAnnotations;
namespace TodoList;

public class TodoItem
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public bool IsDone { get; set; } = false;
    public string? Description { get; set; }
    [DataType(DataType.DateTime)]
    public DateTime? CreatedDate { get; set; } = default(DateTime?);
    [DataType(DataType.DateTime)]
    public DateTime? UpdatedDate { get; } = default(DateTime?);
    public bool? IsDeleted { get; set; } = false;
    [DataType(DataType.DateTime)]
    public DateTime? DueDate { get; set; }
    public String Tags { get; set; } = String.Empty;
    public PriorityType Priority { get; set; } = PriorityType.Medium;
    
}
