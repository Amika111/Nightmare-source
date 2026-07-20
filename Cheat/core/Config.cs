using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using Cheat.modules;
using Newtonsoft.Json;
using UnityEngine;

namespace Cheat.core
{
	// Token: 0x0200001F RID: 31
	internal static class Config
	{
		// Token: 0x060001B7 RID: 439 RVA: 0x00011A30 File Offset: 0x0000FC30
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void ApplyDefaultPreset(Main main)
		{
			if (Config.\u202B\u202B\u206E\u202B\u206B\u206E\u206D\u206E\u202D\u206C\u200D\u202C\u200B\u206F\u200C\u200D\u206E\u200C\u206F\u200B\u200E\u202A\u200B\u202E\u200F\u206D\u206C\u202B\u206B\u200C\u202B\u202C\u200F\u202A\u206B\u202C\u206D\u202B\u206D\u200C\u202E(main, null))
			{
				goto IL_0C;
			}
			goto IL_349;
			uint num2;
			for (;;)
			{
				IL_11:
				uint num;
				switch ((num = (num2 ^ 3813179422U)) % 49U)
				{
				case 0U:
					main.vehicleNoclip.mouseControl = true;
					main.vehicleNoclip.useArrowKeys = true;
					num2 = (num * 2868866826U ^ 580192205U);
					continue;
				case 1U:
					main.triggerbot.useWeaponRange = true;
					main.triggerbot.customMaxDistance = 200f;
					main.weaponMods.noRecoil = true;
					main.weaponMods.noSpread = true;
					main.weaponMods.noSway = true;
					main.weaponMods.noShake = true;
					num2 = (num * 724016817U ^ 1380985481U);
					continue;
				case 2U:
					main.weaponMods.noBulletGravity = true;
					num2 = (num * 1887137641U ^ 1459239729U);
					continue;
				case 4U:
					main.KeyToggleMenu = 282;
					num2 = (num * 915835290U ^ 3898580458U);
					continue;
				case 5U:
					main.esp.showBedGlow = false;
					main.esp.showBedName = false;
					num2 = (num * 1944723215U ^ 173292939U);
					continue;
				case 6U:
					main.vehicleNoclip.stabilizeRoll = true;
					num2 = (num * 3557555399U ^ 3827553343U);
					continue;
				case 7U:
					main.esp.showItemIcons = false;
					main.esp.itemIconScale = 0.6845238f;
					num2 = (num * 4260001372U ^ 4201983491U);
					continue;
				case 8U:
					main.visuals.AlwaysCompass = true;
					num2 = (num * 1187117377U ^ 1426791496U);
					continue;
				case 9U:
					main.KeyToggleTrigger = 285;
					num2 = (num * 2968957765U ^ 2938032206U);
					continue;
				case 10U:
					return;
				case 11U:
					main.freeCam.Speed = 15f;
					main.KeyToggleESP = 283;
					num2 = (num * 3310351971U ^ 3273800879U);
					continue;
				case 12U:
					main.esp.infoTextShowWeapon = true;
					num2 = (num * 2817113919U ^ 1956557903U);
					continue;
				case 13U:
					main.vehicleNoclip.nullRoll = true;
					num2 = (num * 3869866764U ^ 3276442290U);
					continue;
				case 14U:
					main.aimbot.fov = 14.444445f;
					main.aimbot.smooth = false;
					main.aimbot.smoothFactor = 12f;
					main.aimbot.useVisibleCheck = true;
					num2 = (num * 1168850796U ^ 109012545U);
					continue;
				case 15U:
					main.aimbot.useBallisticPrediction = false;
					main.aimbot.ballisticFactor = 5.2f;
					main.aimbot.preferHead = true;
					num2 = (num * 3103073499U ^ 1590687202U);
					continue;
				case 16U:
					main.esp.showClaimName = false;
					num2 = (num * 2192913323U ^ 1973785824U);
					continue;
				case 17U:
					main.esp.showVehicleName = false;
					num2 = (num * 2043187290U ^ 3219500338U);
					continue;
				case 18U:
					main.KeyToggleChatSpam = 286;
					num2 = (num * 2084541867U ^ 1194783886U);
					continue;
				case 19U:
					main.triggerbot.enabled = false;
					num2 = (num * 3791477325U ^ 283688814U);
					continue;
				case 20U:
					main.esp.infoTextSize = 11;
					main.esp.showSnaplines = true;
					num2 = (num * 926593066U ^ 149757344U);
					continue;
				case 21U:
					goto IL_349;
				case 22U:
					main.itemVacuum.PickupClothing = true;
					num2 = (num * 2025277409U ^ 1958881107U);
					continue;
				case 23U:
					main.esp.showVehicleGlow = false;
					num2 = (num * 996986956U ^ 803612816U);
					continue;
				case 24U:
					Utils.ManualFriends.Clear();
					num2 = (num * 307006946U ^ 2916327727U);
					continue;
				case 25U:
					main.itemVacuum.PickupSupplies = true;
					main.itemVacuum.PickupEverything = false;
					num2 = (num * 1635072774U ^ 3195945435U);
					continue;
				case 26U:
					main.esp.snaplineToFeet = true;
					main.esp.snaplineAlphaFalloff = true;
					main.esp.showItemGlow = true;
					num2 = (num * 395852144U ^ 1561244682U);
					continue;
				case 27U:
					main.freeCam.Enabled = false;
					num2 = (num * 3485024161U ^ 3942737294U);
					continue;
				case 28U:
					main.vehicleNoclip.active = false;
					main.vehicleNoclip.speedMultiplier = 1f;
					num2 = (num * 2542781481U ^ 169229050U);
					continue;
				case 29U:
					main.aimbot.noFovMode = false;
					main.aimbot.useWeaponRange = true;
					num2 = (num * 1287434611U ^ 3616588005U);
					continue;
				case 30U:
					main.esp.showClaimGlow = false;
					num2 = (num * 2460092483U ^ 2024147191U);
					continue;
				case 31U:
					main.visuals.AlwaysDay = true;
					main.visuals.CustomDayTime = 1200U;
					main.visuals.AlwaysSatellite = true;
					num2 = (num * 1575735918U ^ 903488989U);
					continue;
				case 32U:
					main.esp.showFurnitureGlow = false;
					main.esp.showFurnitureName = false;
					main.aimbot.enabled = true;
					num2 = (num * 371809587U ^ 4163977844U);
					continue;
				case 33U:
					main.aimbot.customMaxDistance = 200f;
					num2 = (num * 419682903U ^ 699007626U);
					continue;
				case 34U:
					main.vehicleNoclip.arrowRotationSpeed = 90f;
					main.itemVacuum.Enabled = false;
					main.itemVacuum.Range = 15f;
					main.itemVacuum.PickupWeapons = true;
					num2 = (num * 51730756U ^ 1334952950U);
					continue;
				case 35U:
					main.esp.showGlow = true;
					main.esp.showInfoText = true;
					num2 = (num * 1100737925U ^ 3710901083U);
					continue;
				case 36U:
					main.KeyItemVacuum = 287;
					num2 = (num * 4068389532U ^ 856741479U);
					continue;
				case 37U:
					main.chatSpam.Interval = 0.4863462f;
					Overrides.bHideOnSpy = true;
					num2 = (num * 3521808564U ^ 34955933U);
					continue;
				case 38U:
					main.esp.showBoxes = false;
					num2 = (num * 3296219804U ^ 136940817U);
					continue;
				case 39U:
					main.esp.maxDistance = 853.1746f;
					num2 = (num * 1295914656U ^ 1724379014U);
					continue;
				case 40U:
					main.esp.showItemName = false;
					num2 = (num * 407804432U ^ 3611443921U);
					continue;
				case 41U:
					main.chatSpam.Enabled = false;
					main.chatSpam.SpamText = <Module>.\u200F\u206F\u200E\u202A\u200D\u200C\u206A\u200E\u202E\u202C\u200D\u202D\u200D\u202B\u200F\u200C\u200F\u200D\u206B\u206D\u206E\u202A\u206C\u206B\u200B\u200F\u206D\u206A\u202E\u206C\u206F\u206A\u200C\u200C\u206C\u202A\u206F\u206A\u202D\u206E\u202E<string>(1494236140);
					num2 = 2831923930U;
					continue;
				case 42U:
					goto IL_0C;
				case 43U:
					main.aimbot.usePrediction = false;
					main.aimbot.predictionFactor = 38f;
					num2 = (num * 3088152964U ^ 495601987U);
					continue;
				case 44U:
					main.KeyFreeCam = 288;
					main.KeyAimbotHold = 324;
					num2 = (num * 3804056583U ^ 2091267415U);
					continue;
				case 45U:
					main.KeyToggleVehicleNoclip = 304;
					main.KeyPanic = 127;
					main.AimbotHoldToAim = true;
					num2 = (num * 3270522343U ^ 1304631870U);
					continue;
				case 46U:
					main.esp.snaplineThickness = 1.4f;
					num2 = (num * 3957283621U ^ 591199886U);
					continue;
				case 47U:
					main.KeyToggleAimbot = 284;
					num2 = (num * 2528332877U ^ 3763452386U);
					continue;
				case 48U:
					main.esp.showSkeleton = false;
					num2 = (num * 1477152269U ^ 542019714U);
					continue;
				}
				break;
			}
			return;
			IL_0C:
			num2 = 3763202908U;
			goto IL_11;
			IL_349:
			main.esp.espEnabled = true;
			num2 = 3051673525U;
			goto IL_11;
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x00012254 File Offset: 0x00010454
		internal static void Load()
		{
			Main main = Object.FindObjectOfType<Main>();
			Config.ConfigData configData;
			for (;;)
			{
				IL_06:
				uint num = 1532840980U;
				for (;;)
				{
					uint num2;
					switch ((num2 = (num ^ 1412932326U)) % 55U)
					{
					case 0U:
						main.weaponMods.noSway = configData.WeaponMods_NoSway;
						num = (num2 * 4284515177U ^ 3917056847U);
						continue;
					case 1U:
						main.itemVacuum.PickupClothing = configData.ItemVacuum_Clothing;
						num = (num2 * 1006094136U ^ 2056794668U);
						continue;
					case 2U:
						main.chatSpam.SpamText = configData.ChatSpam_Text;
						num = (num2 * 3450680335U ^ 715631886U);
						continue;
					case 3U:
						Config.Save();
						num = (num2 * 1329752545U ^ 2903987763U);
						continue;
					case 4U:
						main.esp.showItemName = configData.ESP_ItemName;
						num = (num2 * 396592440U ^ 1811857286U);
						continue;
					case 5U:
						main.weaponMods.noShake = configData.WeaponMods_NoShake;
						main.weaponMods.noBulletGravity = configData.WeaponMods_NoBulletGravity;
						num = (num2 * 641773027U ^ 981200512U);
						continue;
					case 6U:
						main.esp.snaplineThickness = configData.ESP_SnaplineThickness;
						num = (num2 * 2039146071U ^ 4005336557U);
						continue;
					case 7U:
						main.vehicleNoclip.active = configData.VehicleNoClip_Enabled;
						num = (num2 * 1069865611U ^ 3312113897U);
						continue;
					case 8U:
						main.itemVacuum.PickupWeapons = configData.ItemVacuum_Weapons;
						num = (num2 * 747303486U ^ 4103106751U);
						continue;
					case 9U:
						main.aimbot.useWeaponRange = configData.Aimbot_UseWeaponRange;
						num = (num2 * 1006477608U ^ 3670210757U);
						continue;
					case 10U:
						main.esp.infoTextShowWeapon = configData.ESP_InfoTextShowWeapon;
						main.esp.infoTextSize = configData.ESP_InfoTextSize;
						num = (num2 * 3844754678U ^ 1350359240U);
						continue;
					case 11U:
						main.freeCam.Speed = configData.FreeCam_Speed;
						Utils.ManualFriends.Clear();
						num = (num2 * 875866415U ^ 2071340869U);
						continue;
					case 12U:
						main.visuals.AlwaysDay = configData.AlwaysDay;
						num = (num2 * 349668858U ^ 2536414675U);
						continue;
					case 13U:
						main.visuals.CustomDayTime = configData.CustomDayTime;
						num = (num2 * 3098902871U ^ 2958639369U);
						continue;
					case 14U:
						main.esp.showVehicleName = configData.ESP_VehicleName;
						num = (num2 * 3185474142U ^ 3499115689U);
						continue;
					case 15U:
						Config.ApplyDefaultPreset(main);
						num = (num2 * 2356959475U ^ 911838422U);
						continue;
					case 16U:
						num = ((Config.\u202B\u202B\u206E\u202B\u206B\u206E\u206D\u206E\u202D\u206C\u200D\u202C\u200B\u206F\u200C\u200D\u206E\u200C\u206F\u200B\u200E\u202A\u200B\u202E\u200F\u206D\u206C\u202B\u206B\u200C\u202B\u202C\u200F\u202A\u206B\u202C\u206D\u202B\u206D\u200C\u202E(main, null) ? 375797369U : 1157764008U) ^ num2 * 3005072336U);
						continue;
					case 17U:
						main.aimbot.smooth = configData.Aimbot_Smooth;
						main.aimbot.smoothFactor = configData.Aimbot_SmoothFactor;
						main.aimbot.useVisibleCheck = configData.Aimbot_VisibleCheck;
						main.aimbot.usePrediction = configData.Aimbot_Prediction;
						num = (num2 * 2669512820U ^ 3263340101U);
						continue;
					case 18U:
						main.esp.showBedGlow = configData.ESP_BedGlow;
						main.esp.showBedName = configData.ESP_BedName;
						num = (num2 * 1061984566U ^ 1364506573U);
						continue;
					case 19U:
						main.aimbot.noFovMode = configData.Aimbot_NoFovMode;
						num = (num2 * 2185468761U ^ 2784081720U);
						continue;
					case 20U:
						main.vehicleNoclip.nullRoll = configData.VehicleNoClip_NullRoll;
						num = (num2 * 821183097U ^ 1431977174U);
						continue;
					case 21U:
						main.itemVacuum.PickupSupplies = configData.ItemVacuum_Supplies;
						num = (num2 * 2878123024U ^ 2140268885U);
						continue;
					case 22U:
						return;
					case 23U:
						main.esp.showVehicleGlow = configData.ESP_VehicleGlow;
						num = (num2 * 232567746U ^ 2435527486U);
						continue;
					case 24U:
						main.esp.snaplineToFeet = configData.ESP_SnaplineToFeet;
						num = (num2 * 2695146191U ^ 3006687012U);
						continue;
					case 25U:
						main.esp.maxDistance = configData.ESP_MaxDistance;
						num = (num2 * 586635099U ^ 1500015203U);
						continue;
					case 26U:
						goto IL_06;
					case 28U:
						if (configData.Friends != null)
						{
							num = (num2 * 1978636817U ^ 189180144U);
							continue;
						}
						goto IL_A41;
					case 29U:
						main.esp.showFurnitureGlow = configData.ESP_FurnitureGlow;
						num = (num2 * 1470983184U ^ 2080932513U);
						continue;
					case 30U:
						main.itemVacuum.Enabled = configData.ItemVacuum_Enabled;
						main.itemVacuum.Range = configData.ItemVacuum_Range;
						num = (num2 * 1221214688U ^ 3695446020U);
						continue;
					case 31U:
						main.esp.showSnaplines = configData.ESP_Snaplines;
						num = (num2 * 3362417289U ^ 1128866604U);
						continue;
					case 32U:
						return;
					case 33U:
						configData = JsonConvert.DeserializeObject<Config.ConfigData>(Config.\u206C\u206F\u202E\u200F\u200C\u206D\u206D\u206A\u206C\u202C\u202A\u206F\u206E\u202C\u206A\u206D\u200D\u206A\u200F\u202D\u200E\u202D\u206B\u206C\u202B\u206B\u206F\u202E\u206D\u202E\u202B\u206A\u206F\u200C\u200C\u206F\u200B\u202E\u206B\u206D\u202E(Config.path));
						num = 2128839513U;
						continue;
					case 34U:
						main.vehicleNoclip.mouseControl = configData.VehicleNoClip_MouseControl;
						main.vehicleNoclip.useArrowKeys = configData.VehicleNoClip_UseArrowKeys;
						main.vehicleNoclip.arrowRotationSpeed = configData.VehicleNoClip_ArrowSpeed;
						num = (num2 * 1843348776U ^ 917895574U);
						continue;
					case 35U:
						main.esp.showItemIcons = configData.ESP_ItemIcons;
						main.esp.itemIconScale = configData.ESP_ItemIconScale;
						num = (num2 * 4062462775U ^ 2247466358U);
						continue;
					case 36U:
						main.aimbot.customMaxDistance = configData.Aimbot_CustomMaxDistance;
						main.triggerbot.enabled = configData.Triggerbot_Enabled;
						num = (num2 * 549615934U ^ 2298153049U);
						continue;
					case 37U:
						num = (Config.\u200E\u200C\u206D\u200B\u200C\u202D\u206C\u206E\u200C\u200B\u202A\u202D\u202B\u206D\u202E\u206D\u202E\u200D\u202C\u200D\u202D\u200F\u202B\u200D\u202D\u206C\u206D\u206E\u200B\u202B\u206A\u206C\u202C\u206A\u200C\u202E\u200C\u206F\u206F\u202E(Config.path) ? 1494414987U : 1775331721U);
						continue;
					case 38U:
						main.aimbot.useBallisticPrediction = configData.Aimbot_BallisticPrediction;
						num = (num2 * 4171560327U ^ 1391840493U);
						continue;
					case 39U:
						main.visuals.AlwaysSatellite = configData.AlwaysSatellite;
						main.visuals.AlwaysCompass = configData.AlwaysCompass;
						num = (num2 * 255785782U ^ 3026464523U);
						continue;
					case 40U:
						main.chatSpam.Interval = configData.ChatSpam_Interval;
						Overrides.bHideOnSpy = configData.AntiSpy_HideOnSpy;
						num = (num2 * 1189196950U ^ 1474811002U);
						continue;
					case 41U:
						main.esp.showFurnitureName = configData.ESP_FurnitureName;
						num = (num2 * 2223582408U ^ 477927378U);
						continue;
					case 42U:
						main.vehicleNoclip.speedMultiplier = configData.VehicleNoClip_SpeedMultiplier;
						main.vehicleNoclip.stabilizeRoll = configData.VehicleNoClip_StabilizeRoll;
						num = (num2 * 2857560009U ^ 309308928U);
						continue;
					case 43U:
						main.esp.espEnabled = configData.ESP_Enabled;
						num = (num2 * 611918928U ^ 1984182064U);
						continue;
					case 44U:
						main.aimbot.enabled = configData.Aimbot_Enabled;
						main.aimbot.fov = configData.Aimbot_FOV;
						num = (num2 * 1126744768U ^ 896413722U);
						continue;
					case 45U:
						main.chatSpam.Enabled = configData.ChatSpam_Enabled;
						num = (num2 * 1864986878U ^ 3510204210U);
						continue;
					case 46U:
						main.aimbot.predictionFactor = configData.Aimbot_PredictionFactor;
						num = (num2 * 2948170626U ^ 3059095069U);
						continue;
					case 47U:
						main.itemVacuum.PickupEverything = configData.ItemVacuum_Everything;
						main.freeCam.Enabled = configData.FreeCam_Enabled;
						num = (num2 * 3654983378U ^ 2272020523U);
						continue;
					case 48U:
						main.esp.showClaimGlow = configData.ESP_ClaimGlow;
						main.esp.showClaimName = configData.ESP_ClaimName;
						num = (num2 * 1912092594U ^ 516720483U);
						continue;
					case 49U:
						main.triggerbot.useWeaponRange = configData.Triggerbot_UseWeaponRange;
						main.triggerbot.customMaxDistance = configData.Triggerbot_CustomMaxDistance;
						main.weaponMods.noRecoil = configData.WeaponMods_NoRecoil;
						main.weaponMods.noSpread = configData.WeaponMods_NoSpread;
						num = (num2 * 1965427237U ^ 4274571479U);
						continue;
					case 50U:
						main.esp.snaplineAlphaFalloff = configData.ESP_SnaplineAlphaFalloff;
						main.esp.showItemGlow = configData.ESP_ItemGlow;
						num = (num2 * 2555510176U ^ 2402866044U);
						continue;
					case 51U:
						main.esp.showBoxes = configData.ESP_Boxes;
						main.esp.showSkeleton = configData.ESP_Skeleton;
						num = (num2 * 1196223444U ^ 73823622U);
						continue;
					case 52U:
						main.esp.showGlow = configData.ESP_Glow;
						num = (num2 * 2576744545U ^ 2827674478U);
						continue;
					case 53U:
						main.aimbot.ballisticFactor = configData.Aimbot_BallisticFactor;
						main.aimbot.preferHead = configData.Aimbot_PreferHead;
						num = (num2 * 2058993810U ^ 1267256746U);
						continue;
					case 54U:
						main.esp.showInfoText = configData.ESP_InfoText;
						num = (num2 * 1285976539U ^ 3440749248U);
						continue;
					}
					goto Block_1;
				}
			}
			Block_1:
			using (List<ulong>.Enumerator enumerator = configData.Friends.GetEnumerator())
			{
				for (;;)
				{
					IL_9EC:
					uint num3 = (!enumerator.MoveNext()) ? 782626974U : 1347666198U;
					for (;;)
					{
						uint num2;
						switch ((num2 = (num3 ^ 1412932326U)) % 5U)
						{
						case 1U:
							goto IL_9EC;
						case 2U:
							num3 = 1347666198U;
							continue;
						case 3U:
						{
							ulong item = enumerator.Current;
							num3 = 2042513339U;
							continue;
						}
						case 4U:
						{
							ulong item;
							Utils.ManualFriends.Add(item);
							num3 = (num2 * 2476260961U ^ 1988259780U);
							continue;
						}
						}
						goto Block_8;
					}
				}
				Block_8:;
			}
			IL_A41:
			main.KeyToggleESP = (KeyCode)Config.\u206D\u200C\u202D\u200D\u202E\u200D\u206B\u200F\u202D\u206C\u202E\u200D\u206F\u202C\u200D\u200E\u202D\u206D\u200D\u206E\u202C\u202D\u200B\u202D\u200C\u202A\u206F\u202A\u200F\u202C\u200E\u200F\u206D\u202C\u200B\u200F\u200D\u206C\u202A\u206D\u202E(Config.\u202A\u200B\u202A\u206E\u206E\u202E\u200B\u202D\u200D\u200E\u200F\u206B\u200F\u206A\u206B\u200D\u206C\u206E\u200C\u206E\u200B\u200C\u206E\u206A\u206E\u206A\u200D\u202E\u206C\u202E\u202D\u200B\u200B\u206F\u206C\u206D\u206A\u202A\u202B\u202C\u202E(typeof(KeyCode).TypeHandle), configData.KeyESP);
			for (;;)
			{
				IL_A61:
				uint num4 = 1787765356U;
				for (;;)
				{
					uint num2;
					switch ((num2 = (num4 ^ 1412932326U)) % 9U)
					{
					case 0U:
						main.KeyPanic = (KeyCode)Config.\u206D\u200C\u202D\u200D\u202E\u200D\u206B\u200F\u202D\u206C\u202E\u200D\u206F\u202C\u200D\u200E\u202D\u206D\u200D\u206E\u202C\u202D\u200B\u202D\u200C\u202A\u206F\u202A\u200F\u202C\u200E\u200F\u206D\u202C\u200B\u200F\u200D\u206C\u202A\u206D\u202E(Config.\u202A\u200B\u202A\u206E\u206E\u202E\u200B\u202D\u200D\u200E\u200F\u206B\u200F\u206A\u206B\u200D\u206C\u206E\u200C\u206E\u200B\u200C\u206E\u206A\u206E\u206A\u200D\u202E\u206C\u202E\u202D\u200B\u200B\u206F\u206C\u206D\u206A\u202A\u202B\u202C\u202E(typeof(KeyCode).TypeHandle), configData.KeyPanic);
						num4 = (num2 * 218552743U ^ 1718181665U);
						continue;
					case 1U:
						main.KeyToggleChatSpam = (KeyCode)Config.\u206D\u200C\u202D\u200D\u202E\u200D\u206B\u200F\u202D\u206C\u202E\u200D\u206F\u202C\u200D\u200E\u202D\u206D\u200D\u206E\u202C\u202D\u200B\u202D\u200C\u202A\u206F\u202A\u200F\u202C\u200E\u200F\u206D\u202C\u200B\u200F\u200D\u206C\u202A\u206D\u202E(Config.\u202A\u200B\u202A\u206E\u206E\u202E\u200B\u202D\u200D\u200E\u200F\u206B\u200F\u206A\u206B\u200D\u206C\u206E\u200C\u206E\u200B\u200C\u206E\u206A\u206E\u206A\u200D\u202E\u206C\u202E\u202D\u200B\u200B\u206F\u206C\u206D\u206A\u202A\u202B\u202C\u202E(typeof(KeyCode).TypeHandle), configData.KeyChatSpam);
						num4 = (num2 * 3880154406U ^ 365325096U);
						continue;
					case 2U:
						main.KeyToggleAimbot = (KeyCode)Config.\u206D\u200C\u202D\u200D\u202E\u200D\u206B\u200F\u202D\u206C\u202E\u200D\u206F\u202C\u200D\u200E\u202D\u206D\u200D\u206E\u202C\u202D\u200B\u202D\u200C\u202A\u206F\u202A\u200F\u202C\u200E\u200F\u206D\u202C\u200B\u200F\u200D\u206C\u202A\u206D\u202E(Config.\u202A\u200B\u202A\u206E\u206E\u202E\u200B\u202D\u200D\u200E\u200F\u206B\u200F\u206A\u206B\u200D\u206C\u206E\u200C\u206E\u200B\u200C\u206E\u206A\u206E\u206A\u200D\u202E\u206C\u202E\u202D\u200B\u200B\u206F\u206C\u206D\u206A\u202A\u202B\u202C\u202E(typeof(KeyCode).TypeHandle), configData.KeyAimbot);
						main.KeyToggleTrigger = (KeyCode)Config.\u206D\u200C\u202D\u200D\u202E\u200D\u206B\u200F\u202D\u206C\u202E\u200D\u206F\u202C\u200D\u200E\u202D\u206D\u200D\u206E\u202C\u202D\u200B\u202D\u200C\u202A\u206F\u202A\u200F\u202C\u200E\u200F\u206D\u202C\u200B\u200F\u200D\u206C\u202A\u206D\u202E(Config.\u202A\u200B\u202A\u206E\u206E\u202E\u200B\u202D\u200D\u200E\u200F\u206B\u200F\u206A\u206B\u200D\u206C\u206E\u200C\u206E\u200B\u200C\u206E\u206A\u206E\u206A\u200D\u202E\u206C\u202E\u202D\u200B\u200B\u206F\u206C\u206D\u206A\u202A\u202B\u202C\u202E(typeof(KeyCode).TypeHandle), configData.KeyTriggerbot);
						num4 = (num2 * 2400664920U ^ 566269358U);
						continue;
					case 3U:
						main.KeyItemVacuum = (KeyCode)Config.\u206D\u200C\u202D\u200D\u202E\u200D\u206B\u200F\u202D\u206C\u202E\u200D\u206F\u202C\u200D\u200E\u202D\u206D\u200D\u206E\u202C\u202D\u200B\u202D\u200C\u202A\u206F\u202A\u200F\u202C\u200E\u200F\u206D\u202C\u200B\u200F\u200D\u206C\u202A\u206D\u202E(Config.\u202A\u200B\u202A\u206E\u206E\u202E\u200B\u202D\u200D\u200E\u200F\u206B\u200F\u206A\u206B\u200D\u206C\u206E\u200C\u206E\u200B\u200C\u206E\u206A\u206E\u206A\u200D\u202E\u206C\u202E\u202D\u200B\u200B\u206F\u206C\u206D\u206A\u202A\u202B\u202C\u202E(typeof(KeyCode).TypeHandle), configData.KeyItemVacuum);
						num4 = (num2 * 2977432148U ^ 112328803U);
						continue;
					case 4U:
						main.KeyFreeCam = (KeyCode)Config.\u206D\u200C\u202D\u200D\u202E\u200D\u206B\u200F\u202D\u206C\u202E\u200D\u206F\u202C\u200D\u200E\u202D\u206D\u200D\u206E\u202C\u202D\u200B\u202D\u200C\u202A\u206F\u202A\u200F\u202C\u200E\u200F\u206D\u202C\u200B\u200F\u200D\u206C\u202A\u206D\u202E(Config.\u202A\u200B\u202A\u206E\u206E\u202E\u200B\u202D\u200D\u200E\u200F\u206B\u200F\u206A\u206B\u200D\u206C\u206E\u200C\u206E\u200B\u200C\u206E\u206A\u206E\u206A\u200D\u202E\u206C\u202E\u202D\u200B\u200B\u206F\u206C\u206D\u206A\u202A\u202B\u202C\u202E(typeof(KeyCode).TypeHandle), configData.KeyFreeCam);
						num4 = (num2 * 714580213U ^ 2269931368U);
						continue;
					case 6U:
						main.KeyAimbotHold = (KeyCode)Config.\u206D\u200C\u202D\u200D\u202E\u200D\u206B\u200F\u202D\u206C\u202E\u200D\u206F\u202C\u200D\u200E\u202D\u206D\u200D\u206E\u202C\u202D\u200B\u202D\u200C\u202A\u206F\u202A\u200F\u202C\u200E\u200F\u206D\u202C\u200B\u200F\u200D\u206C\u202A\u206D\u202E(Config.\u202A\u200B\u202A\u206E\u206E\u202E\u200B\u202D\u200D\u200E\u200F\u206B\u200F\u206A\u206B\u200D\u206C\u206E\u200C\u206E\u200B\u200C\u206E\u206A\u206E\u206A\u200D\u202E\u206C\u202E\u202D\u200B\u200B\u206F\u206C\u206D\u206A\u202A\u202B\u202C\u202E(typeof(KeyCode).TypeHandle), configData.KeyAimbotHold);
						num4 = (num2 * 2698369568U ^ 3160748927U);
						continue;
					case 7U:
						main.KeyToggleMenu = (KeyCode)Config.\u206D\u200C\u202D\u200D\u202E\u200D\u206B\u200F\u202D\u206C\u202E\u200D\u206F\u202C\u200D\u200E\u202D\u206D\u200D\u206E\u202C\u202D\u200B\u202D\u200C\u202A\u206F\u202A\u200F\u202C\u200E\u200F\u206D\u202C\u200B\u200F\u200D\u206C\u202A\u206D\u202E(Config.\u202A\u200B\u202A\u206E\u206E\u202E\u200B\u202D\u200D\u200E\u200F\u206B\u200F\u206A\u206B\u200D\u206C\u206E\u200C\u206E\u200B\u200C\u206E\u206A\u206E\u206A\u200D\u202E\u206C\u202E\u202D\u200B\u200B\u206F\u206C\u206D\u206A\u202A\u202B\u202C\u202E(typeof(KeyCode).TypeHandle), configData.KeyMenu);
						main.KeyToggleVehicleNoclip = (KeyCode)Config.\u206D\u200C\u202D\u200D\u202E\u200D\u206B\u200F\u202D\u206C\u202E\u200D\u206F\u202C\u200D\u200E\u202D\u206D\u200D\u206E\u202C\u202D\u200B\u202D\u200C\u202A\u206F\u202A\u200F\u202C\u200E\u200F\u206D\u202C\u200B\u200F\u200D\u206C\u202A\u206D\u202E(Config.\u202A\u200B\u202A\u206E\u206E\u202E\u200B\u202D\u200D\u200E\u200F\u206B\u200F\u206A\u206B\u200D\u206C\u206E\u200C\u206E\u200B\u200C\u206E\u206A\u206E\u206A\u200D\u202E\u206C\u202E\u202D\u200B\u200B\u206F\u206C\u206D\u206A\u202A\u202B\u202C\u202E(typeof(KeyCode).TypeHandle), configData.KeyVehicleNoClip);
						num4 = (num2 * 2643081969U ^ 2953016034U);
						continue;
					case 8U:
						goto IL_A61;
					}
					goto Block_6;
				}
			}
			Block_6:
			main.AimbotHoldToAim = configData.AimbotHoldToAim;
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x00012EC0 File Offset: 0x000110C0
		internal static void Save()
		{
			Main main = Object.FindObjectOfType<Main>();
			for (;;)
			{
				IL_06:
				uint num = 2662075049U;
				for (;;)
				{
					uint num2;
					switch ((num2 = (num ^ 2804745324U)) % 6U)
					{
					case 1U:
						num = ((Config.\u202B\u202B\u206E\u202B\u206B\u206E\u206D\u206E\u202D\u206C\u200D\u202C\u200B\u206F\u200C\u200D\u206E\u200C\u206F\u200B\u200E\u202A\u200B\u202E\u200F\u206D\u206C\u202B\u206B\u200C\u202B\u202C\u200F\u202A\u206B\u202C\u206D\u202B\u206D\u200C\u202E(main, null) ? 964798368U : 1971114873U) ^ num2 * 2615059535U);
						continue;
					case 2U:
					{
						string text = Config.\u200C\u200D\u206F\u206A\u200F\u206A\u202B\u200C\u206F\u202C\u200D\u202E\u206B\u206D\u206D\u202C\u200D\u202C\u200D\u202B\u200B\u200E\u206C\u206F\u200C\u206F\u206F\u200D\u206C\u202E\u206A\u206B\u206F\u200F\u202A\u202B\u206B\u206A\u206C\u206B\u202E(new Config.ConfigData
						{
							ESP_Enabled = main.esp.espEnabled,
							ESP_MaxDistance = main.esp.maxDistance,
							ESP_Boxes = main.esp.showBoxes,
							ESP_Skeleton = main.esp.showSkeleton,
							ESP_Glow = main.esp.showGlow,
							ESP_InfoText = main.esp.showInfoText,
							ESP_InfoTextShowWeapon = main.esp.infoTextShowWeapon,
							ESP_InfoTextSize = main.esp.infoTextSize,
							ESP_Snaplines = main.esp.showSnaplines,
							ESP_SnaplineThickness = main.esp.snaplineThickness,
							ESP_SnaplineToFeet = main.esp.snaplineToFeet,
							ESP_SnaplineAlphaFalloff = main.esp.snaplineAlphaFalloff,
							ESP_ItemGlow = main.esp.showItemGlow,
							ESP_ItemIcons = main.esp.showItemIcons,
							ESP_ItemIconScale = main.esp.itemIconScale,
							ESP_ItemName = main.esp.showItemName,
							ESP_VehicleGlow = main.esp.showVehicleGlow,
							ESP_VehicleName = main.esp.showVehicleName,
							ESP_BedGlow = main.esp.showBedGlow,
							ESP_BedName = main.esp.showBedName,
							ESP_ClaimGlow = main.esp.showClaimGlow,
							ESP_ClaimName = main.esp.showClaimName,
							ESP_FurnitureGlow = main.esp.showFurnitureGlow,
							ESP_FurnitureName = main.esp.showFurnitureName,
							Aimbot_Enabled = main.aimbot.enabled,
							Aimbot_FOV = main.aimbot.fov,
							Aimbot_Smooth = main.aimbot.smooth,
							Aimbot_SmoothFactor = main.aimbot.smoothFactor,
							Aimbot_VisibleCheck = main.aimbot.useVisibleCheck,
							Aimbot_Prediction = main.aimbot.usePrediction,
							Aimbot_PredictionFactor = main.aimbot.predictionFactor,
							Aimbot_BallisticPrediction = main.aimbot.useBallisticPrediction,
							Aimbot_BallisticFactor = main.aimbot.ballisticFactor,
							Aimbot_PreferHead = main.aimbot.preferHead,
							Aimbot_NoFovMode = main.aimbot.noFovMode,
							Aimbot_UseWeaponRange = main.aimbot.useWeaponRange,
							Aimbot_CustomMaxDistance = main.aimbot.customMaxDistance,
							Triggerbot_Enabled = main.triggerbot.enabled,
							Triggerbot_UseWeaponRange = main.triggerbot.useWeaponRange,
							Triggerbot_CustomMaxDistance = main.triggerbot.customMaxDistance,
							WeaponMods_NoRecoil = main.weaponMods.noRecoil,
							WeaponMods_NoSpread = main.weaponMods.noSpread,
							WeaponMods_NoSway = main.weaponMods.noSway,
							WeaponMods_NoShake = main.weaponMods.noShake,
							WeaponMods_NoBulletGravity = main.weaponMods.noBulletGravity,
							AlwaysDay = main.visuals.AlwaysDay,
							CustomDayTime = main.visuals.CustomDayTime,
							AlwaysSatellite = main.visuals.AlwaysSatellite,
							AlwaysCompass = main.visuals.AlwaysCompass,
							ChatSpam_Enabled = main.chatSpam.Enabled,
							ChatSpam_Text = main.chatSpam.SpamText,
							ChatSpam_Interval = main.chatSpam.Interval,
							AntiSpy_HideOnSpy = Overrides.bHideOnSpy,
							VehicleNoClip_Enabled = main.vehicleNoclip.active,
							VehicleNoClip_SpeedMultiplier = main.vehicleNoclip.speedMultiplier,
							VehicleNoClip_StabilizeRoll = main.vehicleNoclip.stabilizeRoll,
							VehicleNoClip_NullRoll = main.vehicleNoclip.nullRoll,
							VehicleNoClip_MouseControl = main.vehicleNoclip.mouseControl,
							VehicleNoClip_UseArrowKeys = main.vehicleNoclip.useArrowKeys,
							VehicleNoClip_ArrowSpeed = main.vehicleNoclip.arrowRotationSpeed,
							ItemVacuum_Enabled = main.itemVacuum.Enabled,
							ItemVacuum_Range = main.itemVacuum.Range,
							ItemVacuum_Weapons = main.itemVacuum.PickupWeapons,
							ItemVacuum_Clothing = main.itemVacuum.PickupClothing,
							ItemVacuum_Supplies = main.itemVacuum.PickupSupplies,
							ItemVacuum_Everything = main.itemVacuum.PickupEverything,
							FreeCam_Enabled = main.freeCam.Enabled,
							FreeCam_Speed = main.freeCam.Speed,
							KeyESP = main.KeyToggleESP.ToString(),
							KeyAimbot = main.KeyToggleAimbot.ToString(),
							KeyTriggerbot = main.KeyToggleTrigger.ToString(),
							KeyChatSpam = main.KeyToggleChatSpam.ToString(),
							KeyAimbotHold = main.KeyAimbotHold.ToString(),
							KeyMenu = main.KeyToggleMenu.ToString(),
							KeyVehicleNoClip = main.KeyToggleVehicleNoclip.ToString(),
							KeyItemVacuum = main.KeyItemVacuum.ToString(),
							KeyFreeCam = main.KeyFreeCam.ToString(),
							KeyPanic = main.KeyPanic.ToString(),
							AimbotHoldToAim = main.AimbotHoldToAim,
							Friends = Utils.ManualFriends.ToList<ulong>()
						}, 1);
						num = 3719863462U;
						continue;
					}
					case 3U:
						goto IL_06;
					case 4U:
					{
						string text;
						Config.\u200F\u202E\u206E\u200F\u200F\u200B\u200D\u206D\u206F\u202C\u206E\u200C\u206E\u200B\u206D\u200F\u200F\u200E\u206D\u200D\u202B\u206D\u206A\u206B\u206F\u206F\u200C\u200F\u202D\u202E\u200E\u200C\u200C\u206C\u206B\u200E\u206D\u200F\u200C\u202B\u202E(Config.path, text);
						num = (num2 * 38814175U ^ 3384289486U);
						continue;
					}
					case 5U:
						return;
					}
					goto Block_1;
				}
			}
			Block_1:;
		}

		// Token: 0x060001BB RID: 443 RVA: 0x000076A4 File Offset: 0x000058A4
		static bool \u202B\u202B\u206E\u202B\u206B\u206E\u206D\u206E\u202D\u206C\u200D\u202C\u200B\u206F\u200C\u200D\u206E\u200C\u206F\u200B\u200E\u202A\u200B\u202E\u200F\u206D\u206C\u202B\u206B\u200C\u202B\u202C\u200F\u202A\u206B\u202C\u206D\u202B\u206D\u200C\u202E(Object A_0, Object A_1)
		{
			return A_0 == A_1;
		}

		// Token: 0x060001BC RID: 444 RVA: 0x0001350C File Offset: 0x0001170C
		static bool \u200E\u200C\u206D\u200B\u200C\u202D\u206C\u206E\u200C\u200B\u202A\u202D\u202B\u206D\u202E\u206D\u202E\u200D\u202C\u200D\u202D\u200F\u202B\u200D\u202D\u206C\u206D\u206E\u200B\u202B\u206A\u206C\u202C\u206A\u200C\u202E\u200C\u206F\u206F\u202E(string A_0)
		{
			return File.Exists(A_0);
		}

		// Token: 0x060001BD RID: 445 RVA: 0x00013520 File Offset: 0x00011720
		static string \u206C\u206F\u202E\u200F\u200C\u206D\u206D\u206A\u206C\u202C\u202A\u206F\u206E\u202C\u206A\u206D\u200D\u206A\u200F\u202D\u200E\u202D\u206B\u206C\u202B\u206B\u206F\u202E\u206D\u202E\u202B\u206A\u206F\u200C\u200C\u206F\u200B\u202E\u206B\u206D\u202E(string A_0)
		{
			return File.ReadAllText(A_0);
		}

		// Token: 0x060001BE RID: 446 RVA: 0x00007860 File Offset: 0x00005A60
		static Type \u202A\u200B\u202A\u206E\u206E\u202E\u200B\u202D\u200D\u200E\u200F\u206B\u200F\u206A\u206B\u200D\u206C\u206E\u200C\u206E\u200B\u200C\u206E\u206A\u206E\u206A\u200D\u202E\u206C\u202E\u202D\u200B\u200B\u206F\u206C\u206D\u206A\u202A\u202B\u202C\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		// Token: 0x060001BF RID: 447 RVA: 0x00013534 File Offset: 0x00011734
		static object \u206D\u200C\u202D\u200D\u202E\u200D\u206B\u200F\u202D\u206C\u202E\u200D\u206F\u202C\u200D\u200E\u202D\u206D\u200D\u206E\u202C\u202D\u200B\u202D\u200C\u202A\u206F\u202A\u200F\u202C\u200E\u200F\u206D\u202C\u200B\u200F\u200D\u206C\u202A\u206D\u202E(Type A_0, string A_1)
		{
			return Enum.Parse(A_0, A_1);
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x00013548 File Offset: 0x00011748
		static string \u200C\u200D\u206F\u206A\u200F\u206A\u202B\u200C\u206F\u202C\u200D\u202E\u206B\u206D\u206D\u202C\u200D\u202C\u200D\u202B\u200B\u200E\u206C\u206F\u200C\u206F\u206F\u200D\u206C\u202E\u206A\u206B\u206F\u200F\u202A\u202B\u206B\u206A\u206C\u206B\u202E(object A_0, Formatting A_1)
		{
			return JsonConvert.SerializeObject(A_0, A_1);
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x0001355C File Offset: 0x0001175C
		static void \u200F\u202E\u206E\u200F\u200F\u200B\u200D\u206D\u206F\u202C\u206E\u200C\u206E\u200B\u206D\u200F\u200F\u200E\u206D\u200D\u202B\u206D\u206A\u206B\u206F\u206F\u200C\u200F\u202D\u202E\u200E\u200C\u200C\u206C\u206B\u200E\u206D\u200F\u200C\u202B\u202E(string A_0, string A_1)
		{
			File.WriteAllText(A_0, A_1);
		}

		// Token: 0x040000CA RID: 202
		private static readonly string path = <Module>.\u200B\u206C\u200C\u200C\u206A\u200B\u200D\u206C\u206B\u206D\u202B\u200F\u200E\u206E\u206A\u200D\u206B\u202E\u206A\u200E\u200B\u202E\u200F\u206C\u200F\u202A\u202B\u200F\u200D\u200C\u202D\u200E\u206B\u200D\u202A\u200E\u202E\u206A\u202B\u200C\u202E<string>(-250452652);

		// Token: 0x02000020 RID: 32
		[Serializable]
		private class ConfigData
		{
			// Token: 0x060001C2 RID: 450 RVA: 0x00013570 File Offset: 0x00011770
			[MethodImpl(MethodImplOptions.NoInlining)]
			public ConfigData()
			{
			}

			// Token: 0x040000CB RID: 203
			public bool ESP_Enabled = true;

			// Token: 0x040000CC RID: 204
			public float ESP_MaxDistance = 853.1746f;

			// Token: 0x040000CD RID: 205
			public bool ESP_Boxes;

			// Token: 0x040000CE RID: 206
			public bool ESP_Skeleton;

			// Token: 0x040000CF RID: 207
			public bool ESP_Glow = true;

			// Token: 0x040000D0 RID: 208
			public bool ESP_InfoText = true;

			// Token: 0x040000D1 RID: 209
			public bool ESP_InfoTextShowWeapon = true;

			// Token: 0x040000D2 RID: 210
			public int ESP_InfoTextSize = 11;

			// Token: 0x040000D3 RID: 211
			public bool ESP_Snaplines = true;

			// Token: 0x040000D4 RID: 212
			public float ESP_SnaplineThickness = 1.4f;

			// Token: 0x040000D5 RID: 213
			public bool ESP_SnaplineToFeet = true;

			// Token: 0x040000D6 RID: 214
			public bool ESP_SnaplineAlphaFalloff = true;

			// Token: 0x040000D7 RID: 215
			public bool ESP_ItemGlow = true;

			// Token: 0x040000D8 RID: 216
			public bool ESP_ItemIcons;

			// Token: 0x040000D9 RID: 217
			public float ESP_ItemIconScale = 0.6845238f;

			// Token: 0x040000DA RID: 218
			public bool ESP_ItemName;

			// Token: 0x040000DB RID: 219
			public bool ESP_VehicleGlow;

			// Token: 0x040000DC RID: 220
			public bool ESP_VehicleName;

			// Token: 0x040000DD RID: 221
			public bool ESP_BedGlow;

			// Token: 0x040000DE RID: 222
			public bool ESP_BedName;

			// Token: 0x040000DF RID: 223
			public bool ESP_ClaimGlow;

			// Token: 0x040000E0 RID: 224
			public bool ESP_ClaimName;

			// Token: 0x040000E1 RID: 225
			public bool ESP_FurnitureGlow;

			// Token: 0x040000E2 RID: 226
			public bool ESP_FurnitureName;

			// Token: 0x040000E3 RID: 227
			public bool Aimbot_Enabled = true;

			// Token: 0x040000E4 RID: 228
			public float Aimbot_FOV = 14.444445f;

			// Token: 0x040000E5 RID: 229
			public bool Aimbot_Smooth;

			// Token: 0x040000E6 RID: 230
			public float Aimbot_SmoothFactor = 12f;

			// Token: 0x040000E7 RID: 231
			public bool Aimbot_VisibleCheck = true;

			// Token: 0x040000E8 RID: 232
			public bool Aimbot_Prediction;

			// Token: 0x040000E9 RID: 233
			public float Aimbot_PredictionFactor = 38f;

			// Token: 0x040000EA RID: 234
			public bool Aimbot_BallisticPrediction;

			// Token: 0x040000EB RID: 235
			public float Aimbot_BallisticFactor = 5.2f;

			// Token: 0x040000EC RID: 236
			public bool Aimbot_PreferHead = true;

			// Token: 0x040000ED RID: 237
			public bool Aimbot_NoFovMode;

			// Token: 0x040000EE RID: 238
			public bool Aimbot_UseWeaponRange = true;

			// Token: 0x040000EF RID: 239
			public float Aimbot_CustomMaxDistance = 200f;

			// Token: 0x040000F0 RID: 240
			public bool Triggerbot_Enabled;

			// Token: 0x040000F1 RID: 241
			public bool Triggerbot_UseWeaponRange = true;

			// Token: 0x040000F2 RID: 242
			public float Triggerbot_CustomMaxDistance = 200f;

			// Token: 0x040000F3 RID: 243
			public bool WeaponMods_NoRecoil = true;

			// Token: 0x040000F4 RID: 244
			public bool WeaponMods_NoSpread = true;

			// Token: 0x040000F5 RID: 245
			public bool WeaponMods_NoSway = true;

			// Token: 0x040000F6 RID: 246
			public bool WeaponMods_NoShake = true;

			// Token: 0x040000F7 RID: 247
			public bool WeaponMods_NoBulletGravity = true;

			// Token: 0x040000F8 RID: 248
			public bool AlwaysDay = true;

			// Token: 0x040000F9 RID: 249
			public uint CustomDayTime = 1200U;

			// Token: 0x040000FA RID: 250
			public bool AlwaysSatellite = true;

			// Token: 0x040000FB RID: 251
			public bool AlwaysCompass = true;

			// Token: 0x040000FC RID: 252
			public bool ChatSpam_Enabled;

			// Token: 0x040000FD RID: 253
			public string ChatSpam_Text = <Module>.\u200F\u206F\u200E\u202A\u200D\u200C\u206A\u200E\u202E\u202C\u200D\u202D\u200D\u202B\u200F\u200C\u200F\u200D\u206B\u206D\u206E\u202A\u206C\u206B\u200B\u200F\u206D\u206A\u202E\u206C\u206F\u206A\u200C\u200C\u206C\u202A\u206F\u206A\u202D\u206E\u202E<string>(1494236140);

			// Token: 0x040000FE RID: 254
			public float ChatSpam_Interval = 0.4863462f;

			// Token: 0x040000FF RID: 255
			public bool AntiSpy_HideOnSpy = true;

			// Token: 0x04000100 RID: 256
			public bool VehicleNoClip_Enabled;

			// Token: 0x04000101 RID: 257
			public float VehicleNoClip_SpeedMultiplier = 1f;

			// Token: 0x04000102 RID: 258
			public bool VehicleNoClip_StabilizeRoll = true;

			// Token: 0x04000103 RID: 259
			public bool VehicleNoClip_NullRoll = true;

			// Token: 0x04000104 RID: 260
			public bool VehicleNoClip_MouseControl = true;

			// Token: 0x04000105 RID: 261
			public bool VehicleNoClip_UseArrowKeys = true;

			// Token: 0x04000106 RID: 262
			public float VehicleNoClip_ArrowSpeed = 90f;

			// Token: 0x04000107 RID: 263
			public bool ItemVacuum_Enabled;

			// Token: 0x04000108 RID: 264
			public float ItemVacuum_Range = 15f;

			// Token: 0x04000109 RID: 265
			public bool ItemVacuum_Weapons = true;

			// Token: 0x0400010A RID: 266
			public bool ItemVacuum_Clothing = true;

			// Token: 0x0400010B RID: 267
			public bool ItemVacuum_Supplies = true;

			// Token: 0x0400010C RID: 268
			public bool ItemVacuum_Everything;

			// Token: 0x0400010D RID: 269
			public bool FreeCam_Enabled;

			// Token: 0x0400010E RID: 270
			public float FreeCam_Speed = 15f;

			// Token: 0x0400010F RID: 271
			public string KeyESP = <Module>.\u206A\u202C\u206A\u206C\u202A\u206F\u200B\u206C\u206C\u206B\u206F\u206C\u200C\u206D\u200C\u200C\u206C\u206A\u202A\u206B\u200B\u202E\u200C\u206E\u202D\u202A\u200E\u202D\u200E\u200E\u200D\u200E\u202B\u202A\u206E\u202A\u200B\u200B\u202D\u202E<string>(539665871);

			// Token: 0x04000110 RID: 272
			public string KeyAimbot = <Module>.\u206A\u202C\u206A\u206C\u202A\u206F\u200B\u206C\u206C\u206B\u206F\u206C\u200C\u206D\u200C\u200C\u206C\u206A\u202A\u206B\u200B\u202E\u200C\u206E\u202D\u202A\u200E\u202D\u200E\u200E\u200D\u200E\u202B\u202A\u206E\u202A\u200B\u200B\u202D\u202E<string>(-513795307);

			// Token: 0x04000111 RID: 273
			public string KeyTriggerbot = <Module>.\u202B\u200B\u202C\u206C\u206D\u202C\u206B\u200F\u206D\u206D\u200E\u206A\u202E\u206D\u200D\u206A\u202D\u202B\u200B\u200F\u202C\u206D\u200E\u202D\u200D\u206A\u200F\u206E\u206F\u206F\u200D\u202D\u202C\u200B\u206F\u202C\u202A\u200D\u206E\u202E\u202E<string>(1067812533);

			// Token: 0x04000112 RID: 274
			public string KeyChatSpam = <Module>.\u206A\u202C\u206A\u206C\u202A\u206F\u200B\u206C\u206C\u206B\u206F\u206C\u200C\u206D\u200C\u200C\u206C\u206A\u202A\u206B\u200B\u202E\u200C\u206E\u202D\u202A\u200E\u202D\u200E\u200E\u200D\u200E\u202B\u202A\u206E\u202A\u200B\u200B\u202D\u202E<string>(1674249633);

			// Token: 0x04000113 RID: 275
			public string KeyItemVacuum = <Module>.\u200B\u206C\u200C\u200C\u206A\u200B\u200D\u206C\u206B\u206D\u202B\u200F\u200E\u206E\u206A\u200D\u206B\u202E\u206A\u200E\u200B\u202E\u200F\u206C\u200F\u202A\u202B\u200F\u200D\u200C\u202D\u200E\u206B\u200D\u202A\u200E\u202E\u206A\u202B\u200C\u202E<string>(1786462649);

			// Token: 0x04000114 RID: 276
			public string KeyFreeCam = <Module>.\u200B\u206C\u200C\u200C\u206A\u200B\u200D\u206C\u206B\u206D\u202B\u200F\u200E\u206E\u206A\u200D\u206B\u202E\u206A\u200E\u200B\u202E\u200F\u206C\u200F\u202A\u202B\u200F\u200D\u200C\u202D\u200E\u206B\u200D\u202A\u200E\u202E\u206A\u202B\u200C\u202E<string>(-1548841309);

			// Token: 0x04000115 RID: 277
			public string KeyAimbotHold = <Module>.\u206A\u202C\u206A\u206C\u202A\u206F\u200B\u206C\u206C\u206B\u206F\u206C\u200C\u206D\u200C\u200C\u206C\u206A\u202A\u206B\u200B\u202E\u200C\u206E\u202D\u202A\u200E\u202D\u200E\u200E\u200D\u200E\u202B\u202A\u206E\u202A\u200B\u200B\u202D\u202E<string>(-1486133901);

			// Token: 0x04000116 RID: 278
			public string KeyMenu = <Module>.\u200F\u206F\u200E\u202A\u200D\u200C\u206A\u200E\u202E\u202C\u200D\u202D\u200D\u202B\u200F\u200C\u200F\u200D\u206B\u206D\u206E\u202A\u206C\u206B\u200B\u200F\u206D\u206A\u202E\u206C\u206F\u206A\u200C\u200C\u206C\u202A\u206F\u206A\u202D\u206E\u202E<string>(376753318);

			// Token: 0x04000117 RID: 279
			public string KeyVehicleNoClip = <Module>.\u200B\u206C\u200C\u200C\u206A\u200B\u200D\u206C\u206B\u206D\u202B\u200F\u200E\u206E\u206A\u200D\u206B\u202E\u206A\u200E\u200B\u202E\u200F\u206C\u200F\u202A\u202B\u200F\u200D\u200C\u202D\u200E\u206B\u200D\u202A\u200E\u202E\u206A\u202B\u200C\u202E<string>(-1572359034);

			// Token: 0x04000118 RID: 280
			public string KeyPanic = <Module>.\u206A\u202C\u206A\u206C\u202A\u206F\u200B\u206C\u206C\u206B\u206F\u206C\u200C\u206D\u200C\u200C\u206C\u206A\u202A\u206B\u200B\u202E\u200C\u206E\u202D\u202A\u200E\u202D\u200E\u200E\u200D\u200E\u202B\u202A\u206E\u202A\u200B\u200B\u202D\u202E<string>(1309764212);

			// Token: 0x04000119 RID: 281
			public bool AimbotHoldToAim = true;

			// Token: 0x0400011A RID: 282
			public List<ulong> Friends = new List<ulong>();
		}
	}
}
