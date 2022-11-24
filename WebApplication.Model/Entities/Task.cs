using WebApplication.Model.Enum;
using TaskStatus = WebApplication.Model.Enum.TaskStatus;

namespace WebApplication.Model.Entities
{
    public class Task
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string AuthorOfTask { get; set; }  
        public string PerformerOfTask { get; set; } 
        public TaskStatus Status { get; set; }
        public string Comment { get; set; } 
        public TaskPriority TaskPriority { get; set; }   
    }
}
