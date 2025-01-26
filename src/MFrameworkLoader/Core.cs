using MelonLoader;

[assembly: MelonInfo(typeof(MFrameworkLoader.Core), "MFrameworkLoader", "1.0.0", "Russell", null)]
[assembly: MelonGame("infiniteloop", "DesktopMate")]

namespace MFrameworkLoader
{
    public class Core : MelonMod
    {
        public override void OnInitializeMelon()
        {
            LoggerInstance.Msg("Getting Framework...");

            try
            {
                FrameworkLoader.LoadFrameworkAssemblies();
            }

            catch 
            {
                LoggerInstance.Error("Failure to Load Libraries, is .NET 6.0 Installed?");
            }
        }
    }
}