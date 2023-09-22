namespace Raziee.Bpms.Bpmn;
public interface ILane : IElement
{
    IEnumerable<IFlowNodeRef> FlowNodeRefs { get; }
}

public class Lane : ILane
{
    public IEnumerable<IFlowNodeRef> FlowNodeRefs => throw new NotImplementedException();

    public string Id => throw new NotImplementedException();

    public string Name => throw new NotImplementedException();
}
