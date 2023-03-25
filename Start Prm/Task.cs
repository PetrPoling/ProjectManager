namespace Project_Manager;

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