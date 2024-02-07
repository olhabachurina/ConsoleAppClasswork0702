using ConsoleAppClasswork0702.Context;

namespace ConsoleAppClasswork0702;
 class Program
{
    static void Main()
    {
        var ApplicationDBcontext = new ApplicationDBcontext();
        var taskRepository = new TaskRepository(ApplicationDBcontext);

        int taskId1 = taskRepository.AddTask(new Task { Title = "Задача 1", Description = "Посмотреть урок" });
        int taskId2 = taskRepository.AddTask(new Task { Title = "Задача 2", Description = "Получит домашнее задание" });
        int taskId3 = taskRepository.AddTask(new Task { Title = "Задача 3", Description = "Выполнить задание" });

        Console.WriteLine("Добавлены новые задачи.");

        
    }
}
    

