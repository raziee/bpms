namespace Raziee.Bpms.Bpmn;

public interface IItemDefinition : IElement
{
    string Id { get; }
    string ItemSubjectRef { get; }
}