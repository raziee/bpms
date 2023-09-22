namespace Raziee.Bpms.Bpmn;

public class IntermediateCatchEvent : ICatchEvent
{
    public IntermediateCatchEventType Type { get; set; }
    public DataOutput DataOutput => throw new NotImplementedException();

    public DataOutputAssociation DataOutputAssociation => throw new NotImplementedException();

    public OutputSet OutputSet => throw new NotImplementedException();

    public IEventDefinition EventDefinition => throw new NotImplementedException();

    public string Id => throw new NotImplementedException();

    public string Name => throw new NotImplementedException();

    IDataOutput ICatchEvent.DataOutput => throw new NotImplementedException();

    IDataOutputAssociation ICatchEvent.DataOutputAssociation => throw new NotImplementedException();

    IOutputSet ICatchEvent.OutputSet => throw new NotImplementedException();
}
