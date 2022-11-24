using WebApplication.Model.Enum;

namespace WebApplication.Model.Entities
{
    public class Project
    {
        public int Id { get; set; }
        public string Title { get; set; }    
        public string CustomerCompany { get; set; }
        public string ContractorCompany { get; set; }
        public Employee Employee { get; set; }  
        public Supervisor Supervisor { get; set; }  
        public DateTime DateOfStart {get; set; }
        public DateTime DateOfEnd { get; set; }
        public ProjectPriority ProjectPriority { get; set; }    
    }
}
