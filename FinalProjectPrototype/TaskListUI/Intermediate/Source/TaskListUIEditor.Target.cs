using UnrealBuildTool;

public class TaskListUIEditorTarget : TargetRules
{
	public TaskListUIEditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("TaskListUI");
	}
}
