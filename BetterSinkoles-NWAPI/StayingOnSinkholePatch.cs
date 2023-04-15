using CustomPlayerEffects;
using HarmonyLib;
using Hazards;
using PlayerRoles;
using PluginAPI.Core;
using System;
using UnityEngine;

namespace BetterSinkoles_NWAPI
{
    [HarmonyPatch(typeof(SinkholeEnvironmentalHazard), nameof(SinkholeEnvironmentalHazard.OnEnter))]
    internal static class StayingOnSinkholePatch
    {
        [HarmonyPrefix]
        private static bool OnEnter(SinkholeEnvironmentalHazard __instance, ReferenceHub player)
        {
            try
            {
                var ply = Player.Get(player);
                bool allow = !(ply.Team == Team.SCPs || ply.IsGodModeEnabled);

                if (!((double)Vector3.Distance(ply.Position, __instance.transform.position) > (double)__instance.MaxDistance * Plugin.Instance.Config.TeleportDistance))
                {
                    ply.EffectsManager.DisableEffect<Sinkhole>();
                    ply.EffectsManager.EnableEffect<Corroding>();
                    ply.SendBroadcast(Plugin.Instance.Config.TeleportMessage, Plugin.Instance.Config.TeleportMessageDuration);
                    allow = true;
                }
                else
                {
                    allow = false;
                }

                return allow;
            }
            catch (Exception ex)
            {
                Log.Error($"StayingOnSinkholePatch failed!\n{ex}");
                return true;
            }
        }
    }
}
