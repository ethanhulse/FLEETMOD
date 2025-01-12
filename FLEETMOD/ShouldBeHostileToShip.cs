﻿using System;
using HarmonyLib;

namespace FLEETMOD
{
	[HarmonyPatch(typeof(PLShipInfoBase), "ShouldBeHostileToShip")]
	internal class ShouldBeHostileToShip
	{
		public static bool Prefix(PLShipInfoBase __instance, PLShipInfoBase inShip)
		{
			if (!MyVariables.isrunningmod)
			{
				return true;
			}
			else
			{
                return !(inShip == __instance || (inShip.GetIsPlayerShip() && __instance.GetIsPlayerShip()));
			}
		}
	}
}
