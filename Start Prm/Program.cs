using System;

namespace Project_Manager
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Project project = new Project();
            project.CreateProject("My project", "My project description", DateTime.Now, DateTime.Now.AddDays(30), 10000);

            Task task1 = new Task();
            task1.CreateTask("Task 1", "Task 1 description", DateTime.Now, DateTime.Now.AddDays(15), 1000);
            project.AddTask(task1);

            TeamMember teamMember1 = new TeamMember();
            teamMember1.CreateTeamMember("John Doe", "john.doe@email.com");
            task1.AddTeamMember(teamMember1);
        
            project.GenerateReport();
        }
    }
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double Budget { get; set; }
        public List<Task> Tasks { get; set; }
        public List<TeamMember> TeamMembers { get; set; }
        public Project()
        {
            Tasks = new List<Task>();
            TeamMembers = new List<TeamMember>();
        }

        public void CreateProject(string Name, string Description, DateTime StartDate, DateTime EndDate, double Budget)
        {
            this.Name = Name;
            this.Description = Description;
            this.StartDate = StartDate;
            this.EndDate = EndDate;
            this.Budget = Budget;
        }

        public void AddTask(Task task)
        {
            Tasks.Add(task);
        }

        public void RemoveTask(Task task)
        {
            Tasks.Remove(task);
        }

        public void AddTeamMember(TeamMember teamMember)
        {
            TeamMembers.Add(teamMember);
        }

        public void RemoveTeamMember(TeamMember teamMember)
        {
            TeamMembers.Remove(teamMember);
        }

        public void ChangeTaskStatus(Task task, TaskStatus status)
        {
            task.Status = status;
        }

        public void GenerateReport()
        {

        }
        
    }
    
    public class Task
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double Budget { get; set; }
        public TaskStatus Status { get; set; }
        public List<TeamMember> TeamMembers { get; set; }
        public Task()
            { 
                TeamMembers = new List<TeamMember>();
            }
        public void CreateTask(string name, string description, DateTime startDate, DateTime endDate, double budget)
        {
            Name = name;
            Description = description;
            StartDate = startDate;
            EndDate = endDate;
            Budget = budget;
        }

        public void AddTeamMember(TeamMember teamMember)
        {
            TeamMembers.Add(teamMember);
        }

        public void RemoveTeamMember(TeamMember teamMember)
        {
            TeamMembers.Remove(teamMember);
        }

        public void ChangeTaskStatus(TaskStatus status)
        {
            Status = status;
        }

    }
    
    public class TeamMember
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public TaskStatus Status { get; set; }

        public void CreateTeamMember(string name, string email)
        {
            Name = name;
            Email = email;
        }

        public void ChangeStatus(TaskStatus status)
        {
            Status = status;
        }
    }


    public class TaskStatus
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public static TaskStatus NotStarted = new TaskStatus { Id = 1, Name = "Не начато" };
        public static TaskStatus InProgress = new TaskStatus { Id = 2, Name = "В процессе" };
        public static TaskStatus Completed = new TaskStatus { Id = 3, Name = "Завершено" };
    }
    
    
}


