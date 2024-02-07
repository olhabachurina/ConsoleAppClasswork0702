using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleAppClasswork0702.Context;
using Dapper;
namespace ConsoleAppClasswork0702
{
    public class TaskRepository
    {
        private readonly ApplicationDBcontext dbManager;

        public TaskRepository(ApplicationDBcontext dbManager)
        {
            this.dbManager = dbManager;
        }

        public int AddTask(Task task)
        {
            using (var connection = dbManager.GetConnection())
            {
                connection.Open();
                string sql = "INSERT INTO [dbo].[Table] (Title, Description) VALUES (@Title, @Description); SELECT SCOPE_IDENTITY();";
                int taskId = connection.QuerySingle<int>(sql, task);
                return taskId;
            }
        }
        
    }
}
