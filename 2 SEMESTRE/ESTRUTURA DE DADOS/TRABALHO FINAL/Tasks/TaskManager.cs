using System;
using System.Collections.Generic;
using System.Linq;

namespace Tasks;

public class TaskManager
{
    private List<Task> TaskList = new List<Task>();
    private Stack<Task> HistoricoRemovidas = new Stack<Task>();
    private int proximoId = 1;

    public int GerarId()
    {
        return proximoId++;
    }

    public void Create(Task task)
    {
        TaskList.Add(task);
    }

    public List<Task> GetAll()
    {
        return TaskList;
    }

    public Task FindById(int id)
    {
        foreach (Task task in TaskList)
        {
            if (task.Id == id)
            {
                return task;
            }
        }
        return null;
    }

    public List<Task> GetByPriority()
    {
        return TaskList
            .OrderByDescending(t => t.Priority)
            .ToList();
    }

    public List<Task> FilterByStatus(Enumeradores.Status status)
    {
        return TaskList
            .Where(t => t.Status == status)
            .ToList();
    }

    public bool Complete(int id)
    {
        Task? task = FindById(id);
        if (task == null)
        {
            return false;
        }

        task.Status = Enumeradores.Status.COMPLETED;
        return true;
    }

    public bool Update(int id, string novaDescricao, Enumeradores.Priority novaPrioridade)
    {
        Task? task = FindById(id);
        if (task == null)
        {
            return false;
        }

        task.Description = novaDescricao;
        task.Priority = novaPrioridade;
        return true;
    }

    public bool Remove(int id)
    {
        Task? task = FindById(id);
        if (task == null)
        {
            return false;
        }

        HistoricoRemovidas.Push(task);
        TaskList.Remove(task);
        return true;
    }

    public Task? UndoRemove()
    {
        if (HistoricoRemovidas.Count == 0)
        {
            return null;
        }

        Task task = HistoricoRemovidas.Pop();
        TaskList.Add(task);
        return task;
    }
}
