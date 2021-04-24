using BepInEx;
using HarmonyLib;
using MT_ShardEnhancementsPreview.Managers;

namespace MT_ShardEnhancementsPreview
{
    [BepInPlugin(GUID, "Shard Enhancements Preview", "1.0.0.0")]
    [BepInProcess("MonsterTrain.exe")]
    public class MT_ShardEnhancementsPreviewPlugin : BaseUnityPlugin
    {
        public const string GUID = "rawsome.modster-train.shard-enhancements-preview";

        void Awake()
        {
            DepInjector.AddClient(new ProviderManager());

            var harmony = new Harmony(GUID);
            harmony.PatchAll();
        }
    }
}
