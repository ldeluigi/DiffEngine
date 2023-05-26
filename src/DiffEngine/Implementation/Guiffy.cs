static partial class Implementation
{
    public static Definition Guiffy()
    {
        var launchArguments = new LaunchArguments(
            Left: (temp, target) => $"\"{target}\" \"{temp}\" -ge2",
            Right: (temp, target) => $"\"{temp}\" \"{target}\" -ge1");

        var environmentVariable = $"${DefaultEnvironmentVariablePrefix}_{nameof(DiffTool.Guiffy)}";
        return new(
            Tool: DiffTool.Guiffy,
            Url: "https://www.guiffy.com/",
            AutoRefresh: false,
            IsMdi: false,
            SupportsText: true,
            RequiresTarget: true,
            Cost: "Paid",
            BinaryExtensions: new[]
            {
                "bmp",
                "gif",
                "jpeg",
                "jpg",
                "png",
                "wbmp"
            },
            OsSupport: new(
                Windows: new(
                    "guiffy.exe",
                    launchArguments,
                    @"%ProgramFiles%\Guiffy\"),
                Osx: new(
                    "guiffyCL.command",
                    launchArguments,
                    "/Applications/Guiffy/")),
            Notes: """
                 * [Command line reference](https://www.guiffy.com/help/GuiffyHelp/GuiffyCmd.html)
                 * [Image Diff Tool](https://www.guiffy.com/Image-Diff-Tool.html)
                 * `-ge1`: Forbid first file view Editing
                 * `-ge2`: Forbid second file view Editing
                """);
    }
}