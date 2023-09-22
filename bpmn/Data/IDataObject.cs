namespace Raziee.Bpms.Bpmn;

public interface IDataObject : IElement
{
    string Id { get; }
    string ItemSubjectRef { get; }
}