using System.Collections.Generic;
using Lab2.Model;
using Lab2.View;
using Lab2.Controller;

namespace Lab2;

public static class Program
{
    public static void Main(string[] args)
    {
        var tasks = new List<TaskItem>();
        var view = new TaskView();
        var controller = new TaskController(tasks, view);
        controller.Run();
    }
}