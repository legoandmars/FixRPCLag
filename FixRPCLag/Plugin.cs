using BepInEx;
using BepInEx.Configuration;
using HarmonyLib;
using System.Reflection;
using Unity.Netcode;

namespace FixRPCLag
{
    [BepInPlugin("dev.bobbie.fixrpclag", "FixRPCLag", "1.0.0")]
    public class Plugin : BaseUnityPlugin
    {
        public static ConfigEntry<LogLevel> ConfigLogLevel;

        private void Awake()
        {
            // Plugin startup logic
            Logger.LogInfo($"Plugin dev.bobbie.fixrpclag is loaded!");

            ConfigLogLevel = Config.Bind("General",      // The section under which the option is shown
                             "LogLevel",  // The key of the configuration option in the configuration file
                             LogLevel.Normal, // The default value
                             "The network manager's LogLevel. If you want absolutely no debug messages related to networking, set it to \"Nothing\". If you want all debug messages related to networking (not recommended), set it to \"Developer\""); // Description of the option to show in the config file

            Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly());
        }
    }
}