namespace Raziee.Bpms.Bpmn;

public interface ISendTask : IActivity
{
    string MessageRef { get; }
    IIoSpecification IoSpecification { get; }
    IDataInputAssociation DataInputAssociation { get; }
}
