public class Task
{
    public string Title { get; set; }
    public string Description { get; set; }
    public Date DueDate { get; set; }
    public Status Status { get; set; }

    public Priority Priority { get; set; }
}

public enum Status
{
    Null,
    InProgress,
    Completed
}
public enum Priority
{
    Low,
    Flexible,
    High
}