
namespace Raziee.Bpms.Bpmn;
public class Process : IProcess
{
    public string ProcessType => throw new NotImplementedException();

    public bool IsExecutable => throw new NotImplementedException();

    public IEnumerable<IFlowElement> FlowElements => throw new NotImplementedException();

    public ILaneSet LaneSet => throw new NotImplementedException();

    public string Id => throw new NotImplementedException();

    public string Name => throw new NotImplementedException();

    public IProperty Property => throw new NotImplementedException();
}
