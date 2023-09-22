namespace Raziee.Bpms.Bpmn;

public interface IUserTask : IActivity
{
    IIoSpecification IoSpecification { get; }
    IDataInputAssociation DataInputAssociation { get; }
    IDataOutputAssociation DataOutputAssociation { get; }
    IResourceRole ResourceRole { get; }
}

public interface IResourceRole
{
}