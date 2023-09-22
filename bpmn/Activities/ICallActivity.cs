namespace Raziee.Bpms.Bpmn;

public interface ICallActivity : IActivity
{
    string CalledElement { get; }
    IIoSpecification IoSpecification { get; }
    IDataInputAssociation DataInputAssociation { get; }
    IDataOutputAssociation DataOutputAssociation { get; }
}