using System;

namespace Tasks;

public class Task
{
    public int Id { get; set; } = 0;
    public string? Description { get; set; }
    public DateTime CreationDate { get; set; }
    public Enumeradores.Status Status { get; set; }
    public Enumeradores.Priority Priority { get; set; }

    public Task(int id, string description, Enumeradores.Priority priority)
    {
        this.Id = id;
        this.Description = description;
        this.Status = Enumeradores.Status.PENDING;
        this.Priority = priority;
        this.CreationDate = DateTime.Now;
    }
}
