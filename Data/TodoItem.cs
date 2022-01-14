namespace BlazorBeginners.Data;

public class TodoItem
{
  public string Name { get; set; } = string.Empty;
  public string Description { get; set; } = string.Empty;
  public DateTime? DueDate { get; set; }
  public bool IsDone { get; set; }

}
