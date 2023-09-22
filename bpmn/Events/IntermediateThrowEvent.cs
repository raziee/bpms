namespace Raziee.Bpms.Bpmn;

public class IntermediateThrowEvent : IThrowEvent
{
    public DataInput DataInput => throw new NotImplementedException();

    public DataInputAssociation DataInputAssociation => throw new NotImplementedException();

    public InputSet InputSet => throw new NotImplementedException();

    public IEventDefinition EventDefinition => throw new NotImplementedException();

    public string Id => throw new NotImplementedException();

    public string Name => throw new NotImplementedException();

    IDataInput IThrowEvent.DataInput => throw new NotImplementedException();

    IDataInputAssociation IThrowEvent.DataInputAssociation => throw new NotImplementedException();

    IInputSet IThrowEvent.InputSet => throw new NotImplementedException();
}