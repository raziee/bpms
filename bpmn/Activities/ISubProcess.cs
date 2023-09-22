namespace Raziee.Bpms.Bpmn;

public interface ISubProcess : IActivity
{
    IEnumerable<IFlowElement> FlowElements { get; }
    IProperty Property { get; }
    ILoopCharacteristics LoopCharacteristics { get; }
}

public interface ILoopCharacteristics
{
}