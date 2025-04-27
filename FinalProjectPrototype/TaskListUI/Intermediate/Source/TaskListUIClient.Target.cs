using UnrealBuildTool;

public class TaskListUIClientTarget : TargetRules
{
	public TaskListUIClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("TaskListUI");
	}
}
