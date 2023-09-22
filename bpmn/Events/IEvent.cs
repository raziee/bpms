namespace Raziee.Bpms.Bpmn;

public interface IEvent : IFlowElement
{
    IEventDefinition EventDefinition { get; }
}