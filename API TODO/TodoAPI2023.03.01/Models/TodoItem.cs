namespace TodoAPI2023._03._01.Models
{
    public class TodoItem
    {
        public int Id { get; set; }
        public string TaskToBeDone { get; set; } = string.Empty;
        public bool TaskIsCompleted { get; set; }
        public DateTime LastChange { get; set; } // keeps last edited time.
    }
}
