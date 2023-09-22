namespace Raziee.Bpms.Bpmn;

public interface IScriptTask : IActivity
{
    string ScriptFormat { get; }
    Script Script { get; }
}