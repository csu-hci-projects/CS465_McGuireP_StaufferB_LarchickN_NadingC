using UnrealBuildTool;

public class TaskListUIServerTarget : TargetRules
{
	public TaskListUIServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("TaskListUI");
	}
}
