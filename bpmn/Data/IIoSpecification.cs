namespace Raziee.Bpms.Bpmn;

public interface IIoSpecification : IElement
{
    IDataInput DataInput { get; }
    IDataOutput DataOutput { get; }
    IInputSet InputSet { get; }
    IOutputSet OutputSet { get; }
}