namespace Raziee.Bpms.Bpmn;

public interface IServiceTask : IActivity
{
    string OperationRef { get; }
    IIoSpecification IoSpecification { get; }
    IDataInputAssociation DataInputAssociation { get; }
    IDataOutputAssociation DataOutputAssociation { get; }
}