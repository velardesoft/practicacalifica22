using eb7429u20211c221.Projects.Domain.Model.ValueObjects;

namespace eb7429u20211c221.Projects.Domain.Model.Aggregates;

public partial class Project
{
    public int Id { get; set; }
    public int WorkSpaceId { get; private set; }
    public string Name { get; private set; }
    public bool Billable { get; private set; }
    public EProjectStatus Status { get; private set; }
    
    protected Project()
    {
        WorkSpaceId = 0;
        Name = string.Empty;
        Billable = false;
        Status = EProjectStatus.CREATED; 
    }
    public Project(int workSpaceId, string name,  bool billable, EProjectStatus status)
    {
        WorkSpaceId = workSpaceId;
        Name = name;
        Billable = billable;
        Status = status;
    }
}