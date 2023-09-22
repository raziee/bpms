namespace Raziee.Bpms.Bpmn;

public interface IReceiveTask : IActivity
{
    string MessageRef { get; }
    IIoSpecification IoSpecification { get; }
    IDataOutputAssociation DataOutputAssociation { get; }
}