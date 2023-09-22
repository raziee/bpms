namespace Raziee.Bpms.Bpmn;

public interface IThrowEvent : IEvent
{
    IDataInput DataInput { get; }
    IDataInputAssociation DataInputAssociation { get; }
    IInputSet InputSet { get; }
}
