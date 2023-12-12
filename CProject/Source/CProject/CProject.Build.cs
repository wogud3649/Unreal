using UnrealBuildTool;

public class CProject : ModuleRules
{
	public CProject(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[]
		{
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"GameplayTasks",
		});

		PublicIncludePaths.Add(ModuleDirectory);
	}
}