namespace Raziee.Bpms.Bpmn;

public interface IProcess : IRootElement
{
    string ProcessType { get; }
    bool IsExecutable { get; }
    ILaneSet LaneSet { get; }
    IProperty Property { get; }
    IEnumerable<IFlowElement> FlowElements { get; }
}
