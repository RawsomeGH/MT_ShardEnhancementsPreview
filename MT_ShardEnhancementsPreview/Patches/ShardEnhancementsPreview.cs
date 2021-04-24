using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Text;

namespace MT_ShardEnhancementsPreview.Patches
{
    [HarmonyPatch(nameof(BattleIntroEnemy))]
    [HarmonyPatch(nameof(BattleIntroEnemy.Set))]
    class ShardEnhancementsPreview
    {
        static void Postfix()
        {
            throw new NotImplementedException();
        }
    }
}
