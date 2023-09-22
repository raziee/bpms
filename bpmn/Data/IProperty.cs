namespace Raziee.Bpms.Bpmn;

public interface IProperty : IElement
{
    string Id { get; }
    string ItemSubjectRef { get; }
}