namespace Raziee.Bpms.Bpmn;

public interface IAdHocSubProcess : IActivity
{
    string CancelRemainingInstances { get; }
    string CompletionCondition { get; }
    IEnumerable<IFlowElement> FlowElements { get; }
    IProperty Property { get; }
}