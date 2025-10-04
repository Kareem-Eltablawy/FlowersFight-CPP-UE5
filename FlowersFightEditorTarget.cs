using UnrealBuildTool;
using System.Collections.Generic;

public class FlowersFightEditorTarget : TargetRules
{
    public FlowersFightEditorTarget(TargetInfo Target) : base(Target)
    {
        Type = TargetType.Editor;
        DefaultBuildSettings = BuildSettingsVersion.V5;
        IncludeOrderVersion = EngineIncludeOrderVersion.Unreal5_3;
        ExtraModuleNames.Add("FlowersFight");
    }
}
