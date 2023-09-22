namespace Raziee.Bpms.Bpmn;

public interface ICatchEvent : IEvent
{
    IDataOutput DataOutput { get; }
    IDataOutputAssociation DataOutputAssociation { get; }
    IOutputSet OutputSet { get; }
}
