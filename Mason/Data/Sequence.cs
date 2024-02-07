namespace Mason.Data;

public class Sequence
{
    public int Id { get; set; }
    public int? NextSequenceId { get; set; }

    public Sequence? NextSequence { get; set; }
}