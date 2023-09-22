namespace Raziee.Bpms.Bpmn;

public interface ITask : IActivity
{
    IIoSpecification IoSpecification { get; }
    IDataInputAssociation DataInputAssociation { get; }
    IDataOutputAssociation DataOutputAssociation { get; }
}