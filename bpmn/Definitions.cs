namespace Raziee.Bpms.Bpmn;
public class Definitions
{
    Collaboration Collaboration { get; }
    IEnumerable<Process> Processes { get; } = new List<Process>();
    BPMNDiagram BPMNDiagram { get; }
}
