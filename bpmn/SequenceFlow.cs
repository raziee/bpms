namespace Raziee.Bpms.Bpmn;
public class SequenceFlow
{
    public string SourceRef { get; set; }
    public string TargetRef { get; set; }
    public string Name { get; set; }
    public string Id { get; set; }

    public SequenceFlow(string id, string sourceRef, string targetRef, string name)
    {
        Id = id;
        SourceRef = sourceRef;
        TargetRef = targetRef;
        Name = name;
    }
}
