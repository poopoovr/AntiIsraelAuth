using BepInEx;

namespace AntiIAuth
{
    [BepInPlugin(PLUGIN_GUID, PLUGIN_NAME, PLUGIN_VERSION)]
    public class AntiIAuthPlugin : BaseUnityPlugin
    {
        public const string PLUGIN_GUID = "0000.poopoovr.anti-iAuth";
        public const string PLUGIN_NAME = "AntiIAuth";
        public const string PLUGIN_VERSION = "1.0.0";

        private void Awake()
        {
            AntiIAuthProtection.Initialize(this);
        }
    }
}
