namespace UnrealBuildTool.Rules
{
    using System.IO;

    public class Libuv : ModuleRules
    {
        public Libuv(ReadOnlyTargetRules Target) : base(Target)
        {
            Type = ModuleType.External;
            UndefinedIdentifierWarningLevel = WarningLevel.Off;
            bEnableExceptions = true;

            if (Target.Platform == UnrealTargetPlatform.Win64)
            {
                bUseRTTI = true;

                PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "Win64", "include"));
                PublicAdditionalLibraries.Add(Path.Combine(ModuleDirectory, "Win64", "lib", "libuv.lib"));
            }
        }
    }
}
