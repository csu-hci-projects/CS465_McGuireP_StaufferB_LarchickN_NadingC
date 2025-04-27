using UnrealBuildTool;

public class TaskListUITarget : TargetRules
{
	public TaskListUITarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("TaskListUI");
	}
}
