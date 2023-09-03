using HarmonyLib;
using System;
using System.Collections;
using UnityEngine;

namespace WarlockGoldenBarryModNS
{
    public class WarlockGoldenBarryMod : Mod
    {
        public override void Ready()
        {
            WorldManager.instance.GameDataLoader.AddCardToSetCardBag(SetCardBagType.CookingIdea, "wk_firstmod_golden_berry", 1);
            Logger.Log("Ready!");
        }
    }
}