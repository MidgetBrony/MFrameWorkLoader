using System.Reflection;

public static class FrameworkLoader
{
    private static readonly string RuntimePath = Path.Combine(
        Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles), "dotnet", "shared");

    public static void LoadFrameworkAssemblies(string targetFramework = "Microsoft.WindowsDesktop.App", string version = "6.0.36")
    {
        try
        {
            string frameworkDir = Path.Combine(RuntimePath, targetFramework, version);

            if (!Directory.Exists(frameworkDir))
            {
                Console.WriteLine($"Framework directory not found: {frameworkDir}");
                return;
            }

            var dllFiles = Directory.GetFiles(frameworkDir, "*.dll");

            foreach (var dll in dllFiles)
            {
                try
                {
                    Assembly.LoadFrom(dll);
                    Console.WriteLine($"Loaded: {Path.GetFileName(dll)}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Failed to load {dll}: {ex.Message}");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error while loading framework assemblies: {ex.Message}");
        }
    }
}