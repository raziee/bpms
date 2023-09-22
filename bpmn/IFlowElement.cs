namespace Raziee.Bpms.Bpmn;

public interface IFlowElement : IElement
{
    string Id { get; }
    string Name { get; }
}
