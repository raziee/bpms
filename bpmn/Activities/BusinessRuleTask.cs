namespace Raziee.Bpms.Bpmn;

public class BusinessRuleTask : IBusinessRuleTask
{
    public string Id => throw new NotImplementedException();

    public string Name => throw new NotImplementedException();
}

public interface IBusinessRuleTask : IActivity
{
}