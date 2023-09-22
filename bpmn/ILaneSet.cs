namespace Raziee.Bpms.Bpmn;

public interface ILaneSet
{
    IEnumerable<ILane> Lanes { get; }
}
