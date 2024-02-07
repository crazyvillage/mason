namespace Mason.Data;

public class Group
{
    public int Id { get; set; }
    public int? ParentGroupId { get; set; }

    public Group? ParentGroup { get; set; }
}