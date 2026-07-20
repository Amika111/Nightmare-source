using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using SDG.Unturned;
using UnityEngine;

namespace Cheat.modules
{
	// Token: 0x0200001D RID: 29
	public class WeaponMods : MonoBehaviour
	{
		// Token: 0x060001A2 RID: 418 RVA: 0x00010DF0 File Offset: 0x0000EFF0
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void FixedUpdate()
		{
			if (WeaponMods.\u202B\u200E\u202B\u206E\u202E\u206C\u200D\u206B\u200F\u202A\u206F\u206C\u200F\u200B\u206E\u200B\u202C\u202A\u206E\u202A\u202C\u202E\u200E\u202E\u202A\u206F\u200B\u200B\u206D\u206E\u202D\u206B\u200B\u202D\u202D\u200D\u202B\u202C\u206B\u200D\u202E(WeaponMods.\u202B\u202C\u206D\u200C\u200F\u206B\u202D\u202C\u200D\u202D\u206C\u202E\u200B\u206C\u200C\u202D\u202D\u206F\u202E\u206C\u202D\u200C\u202B\u206C\u206A\u206A\u202E\u206E\u206F\u206E\u206F\u202E\u202E\u206C\u206E\u200E\u200F\u206E\u202A\u200C\u202E(), null))
			{
				goto IL_10;
			}
			goto IL_133;
			uint num2;
			PlayerEquipment playerEquipment;
			for (;;)
			{
				IL_15:
				uint num;
				switch ((num = (num2 ^ 1506803631U)) % 16U)
				{
				case 0U:
					WeaponMods.gravityField = WeaponMods.\u202E\u202A\u200F\u200B\u206D\u202E\u202C\u200C\u202A\u202C\u202A\u206E\u200E\u200E\u206C\u200B\u200E\u200D\u200C\u202D\u206F\u206A\u206C\u200E\u206E\u206D\u200B\u200F\u206F\u200E\u206A\u206C\u202B\u200D\u206C\u200B\u202C\u206F\u202A\u206B\u202E(WeaponMods.\u202E\u202C\u200C\u200D\u206A\u206E\u200C\u206C\u206A\u206B\u200C\u206E\u200C\u200C\u206B\u200E\u206A\u202E\u202A\u202B\u206C\u202E\u200C\u202B\u202B\u200B\u206B\u202C\u202B\u206B\u200D\u206E\u206B\u202D\u202C\u206C\u202A\u202C\u206E\u202E(typeof(ItemGunAsset).TypeHandle), <Module>.\u202B\u200B\u202C\u206C\u206D\u202C\u206B\u200F\u206D\u206D\u200E\u206A\u202E\u206D\u200D\u206A\u202D\u202B\u200B\u200F\u202C\u206D\u200E\u202D\u200D\u206A\u200F\u206E\u206F\u206F\u200D\u202D\u202C\u200B\u206F\u202C\u202A\u200D\u206E\u202E\u202E<string>(1255970159), BindingFlags.Instance | BindingFlags.NonPublic);
					num2 = 1307421836U;
					continue;
				case 1U:
					num2 = (((!WeaponMods.\u202B\u200E\u202B\u206E\u202E\u206C\u200D\u206B\u200F\u202A\u206F\u206C\u200F\u200B\u206E\u200B\u202C\u202A\u206E\u202A\u202C\u202E\u200E\u202E\u202A\u206F\u200B\u200B\u206D\u206E\u202D\u206B\u200B\u202D\u202D\u200D\u202B\u202C\u206B\u200D\u202E(playerEquipment, null)) ? 4204279080U : 3779373785U) ^ num * 595347087U);
					continue;
				case 2U:
					goto IL_133;
				case 3U:
				{
					ItemGunAsset itemGunAsset;
					num2 = ((!WeaponMods.pristineData.ContainsKey(itemGunAsset.id)) ? 683723914U : 708656210U);
					continue;
				}
				case 4U:
					WeaponMods.spreadField = WeaponMods.\u202E\u202A\u200F\u200B\u206D\u202E\u202C\u200C\u202A\u202C\u202A\u206E\u200E\u200E\u206C\u200B\u200E\u200D\u200C\u202D\u206F\u206A\u206C\u200E\u206E\u206D\u200B\u200F\u206F\u200E\u206A\u206C\u202B\u200D\u206C\u200B\u202C\u206F\u202A\u206B\u202E(WeaponMods.\u202E\u202C\u200C\u200D\u206A\u206E\u200C\u206C\u206A\u206B\u200C\u206E\u200C\u200C\u206B\u200E\u206A\u202E\u202A\u202B\u206C\u202E\u200C\u202B\u202B\u200B\u206B\u202C\u202B\u206B\u200D\u206E\u206B\u202D\u202C\u206C\u202A\u202C\u206E\u202E(typeof(ItemGunAsset).TypeHandle), <Module>.\u206A\u202C\u206A\u206C\u202A\u206F\u200B\u206C\u206C\u206B\u206F\u206C\u200C\u206D\u200C\u200C\u206C\u206A\u202A\u206B\u200B\u202E\u200C\u206E\u202D\u202A\u200E\u202D\u200E\u200E\u200D\u200E\u202B\u202A\u206E\u202A\u200B\u200B\u202D\u202E<string>(1795367302), BindingFlags.Instance | BindingFlags.NonPublic);
					num2 = 1054749155U;
					continue;
				case 5U:
				{
					ItemGunAsset itemGunAsset;
					this.SavePristine(itemGunAsset);
					num2 = (num * 288128177U ^ 3986257095U);
					continue;
				}
				case 7U:
					goto IL_10;
				case 8U:
					num2 = (((WeaponMods.\u206E\u200C\u200F\u206F\u206B\u202E\u206A\u200E\u200D\u202B\u200D\u200C\u200B\u206F\u200C\u202C\u200B\u202D\u202C\u206A\u206C\u202A\u206B\u202C\u202C\u202C\u206D\u206B\u200F\u206A\u200D\u202A\u202A\u202D\u202C\u200F\u202B\u206A\u202A\u200F\u202E(playerEquipment) == null) ? 159175838U : 1719816232U) ^ num * 1079124137U);
					continue;
				case 9U:
					return;
				case 10U:
				{
					ItemGunAsset itemGunAsset;
					num2 = (((itemGunAsset != null) ? 1958437042U : 1561220912U) ^ num * 1111310647U);
					continue;
				}
				case 11U:
					num2 = ((!WeaponMods.\u206D\u202B\u206E\u206A\u200B\u202C\u206E\u200C\u200D\u200C\u202C\u202B\u200B\u200D\u200D\u200C\u202C\u202D\u206D\u200D\u202B\u202B\u202B\u202B\u200D\u202E\u206B\u206B\u202B\u206E\u206F\u206E\u202E\u202D\u206D\u206D\u206D\u202D\u202C\u202E(WeaponMods.spreadField, null)) ? 1054749155U : 1974090587U);
					continue;
				case 12U:
					num2 = (WeaponMods.\u206D\u202B\u206E\u206A\u200B\u202C\u206E\u200C\u200D\u200C\u202C\u202B\u200B\u200D\u200D\u200C\u202C\u202D\u206D\u200D\u202B\u202B\u202B\u202B\u200D\u202E\u206B\u206B\u202B\u206E\u206F\u206E\u202E\u202D\u206D\u206D\u206D\u202D\u202C\u202E(WeaponMods.gravityField, null) ? 2012403439U : 1307421836U);
					continue;
				case 13U:
				{
					ItemGunAsset itemGunAsset;
					this.ApplyOrRestore(itemGunAsset);
					num2 = 1482103497U;
					continue;
				}
				case 14U:
					return;
				case 15U:
				{
					ItemGunAsset itemGunAsset = WeaponMods.\u206E\u200C\u200F\u206F\u206B\u202E\u206A\u200E\u200D\u202B\u200D\u200C\u200B\u206F\u200C\u202C\u200B\u202D\u202C\u206A\u206C\u202A\u206B\u202C\u202C\u202C\u206D\u206B\u200F\u206A\u200D\u202A\u202A\u202D\u202C\u200F\u202B\u206A\u202A\u200F\u202E(playerEquipment) as ItemGunAsset;
					num2 = (num * 1627136930U ^ 1279390811U);
					continue;
				}
				}
				break;
			}
			return;
			IL_10:
			num2 = 1352054673U;
			goto IL_15;
			IL_133:
			playerEquipment = WeaponMods.\u206B\u202A\u202C\u206A\u206B\u206A\u202A\u202B\u206C\u206A\u206B\u200B\u206A\u200B\u206A\u200E\u202B\u200F\u200C\u206E\u202A\u200D\u206B\u200F\u200F\u200D\u200C\u200F\u200C\u200B\u206A\u206B\u200F\u200F\u206F\u200B\u200D\u206D\u202A\u202C\u202E(WeaponMods.\u202B\u202C\u206D\u200C\u200F\u206B\u202D\u202C\u200D\u202D\u206C\u202E\u200B\u206C\u200C\u202D\u202D\u206F\u202E\u206C\u202D\u200C\u202B\u206C\u206A\u206A\u202E\u206E\u206F\u206E\u206F\u202E\u202E\u206C\u206E\u200E\u200F\u206E\u202A\u200C\u202E());
			num2 = 283127278U;
			goto IL_15;
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x00011008 File Offset: 0x0000F208
		private void SavePristine(ItemGunAsset gun)
		{
			WeaponMods.WeaponOriginalData weaponOriginalData = default(WeaponMods.WeaponOriginalData);
			for (;;)
			{
				IL_08:
				uint num = 3286162133U;
				for (;;)
				{
					uint num2;
					switch ((num2 = (num ^ 4032472144U)) % 13U)
					{
					case 0U:
						weaponOriginalData.recoilMin_x = gun.recoilMin_x;
						weaponOriginalData.recoilMin_y = gun.recoilMin_y;
						weaponOriginalData.spreadAim = gun.spreadAim;
						num = (num2 * 4178855756U ^ 349616574U);
						continue;
					case 2U:
						goto IL_08;
					case 3U:
						weaponOriginalData.shakeMin_z = gun.shakeMin_z;
						num = (num2 * 4120809273U ^ 4077841876U);
						continue;
					case 4U:
					{
						PlayerAnimator playerAnimator = WeaponMods.\u206F\u206E\u202C\u202E\u200E\u202C\u206A\u206F\u206F\u206B\u206D\u202A\u200D\u202C\u202D\u200E\u206F\u202A\u206C\u206A\u206C\u202D\u202D\u206A\u206D\u206B\u200B\u206C\u200E\u206B\u206E\u206F\u202A\u200F\u206A\u202A\u206F\u200C\u200F\u206F\u202E(WeaponMods.\u202B\u202C\u206D\u200C\u200F\u206B\u202D\u202C\u200D\u202D\u206C\u202E\u200B\u206C\u200C\u202D\u202D\u206F\u202E\u206C\u202D\u200C\u202B\u206C\u206A\u206A\u202E\u206E\u206F\u206E\u206F\u202E\u202E\u206C\u206E\u200E\u200F\u206E\u202A\u200C\u202E());
						weaponOriginalData.viewmodelSwayMultiplier = ((playerAnimator != null) ? playerAnimator.viewmodelSwayMultiplier : 1f);
						num = 2553896516U;
						continue;
					}
					case 5U:
						weaponOriginalData.spreadSprint = gun.spreadSprint;
						weaponOriginalData.spreadCrouch = gun.spreadCrouch;
						weaponOriginalData.spreadProne = gun.spreadProne;
						weaponOriginalData.shakeMax_x = gun.shakeMax_x;
						num = (num2 * 3565006357U ^ 4144138616U);
						continue;
					case 6U:
						weaponOriginalData.baseSpreadAngleRadians = (WeaponMods.\u206E\u200D\u202D\u200F\u200D\u202A\u206C\u200D\u200B\u202E\u206E\u206A\u206E\u202D\u206B\u200F\u202C\u206A\u206B\u206B\u202D\u206E\u206C\u206C\u200D\u206C\u202C\u206A\u200B\u206C\u206B\u202E\u206F\u200F\u206B\u206E\u200B\u200D\u206C\u202E(WeaponMods.spreadField, null) ? ((float)WeaponMods.\u206B\u206A\u200F\u206A\u200D\u202E\u206A\u206B\u206D\u200E\u206D\u206F\u200C\u206F\u206D\u200B\u206B\u202E\u206D\u206C\u202E\u206E\u202E\u200C\u206F\u206E\u202D\u202E\u206A\u202A\u200F\u206F\u200B\u206C\u206F\u206A\u200F\u200C\u200E\u200E\u202E(WeaponMods.spreadField, gun)) : 0f);
						num = 4129031294U;
						continue;
					case 7U:
						weaponOriginalData.shakeMax_y = gun.shakeMax_y;
						weaponOriginalData.shakeMax_z = gun.shakeMax_z;
						num = (num2 * 2367477301U ^ 957713649U);
						continue;
					case 8U:
					{
						weaponOriginalData.bulletGravityMultiplier = WeaponMods.\u200B\u206F\u206F\u200E\u206D\u200C\u200C\u202E\u206A\u206A\u200C\u206E\u206E\u200E\u202E\u206A\u200E\u200D\u206D\u200C\u206B\u206B\u206F\u200F\u202A\u206C\u200C\u206E\u206F\u200C\u202E\u202E\u206D\u206E\u206A\u202C\u200C\u202D\u206C\u206A\u202E(gun);
						PlayerAnimator playerAnimator2 = WeaponMods.\u206F\u206E\u202C\u202E\u200E\u202C\u206A\u206F\u206F\u206B\u206D\u202A\u200D\u202C\u202D\u200E\u206F\u202A\u206C\u206A\u206C\u202D\u202D\u206A\u206D\u206B\u200B\u206C\u200E\u206B\u206E\u206F\u202A\u200F\u206A\u202A\u206F\u200C\u200F\u206F\u202E(WeaponMods.\u202B\u202C\u206D\u200C\u200F\u206B\u202D\u202C\u200D\u202D\u206C\u202E\u200B\u206C\u200C\u202D\u202D\u206F\u202E\u206C\u202D\u200C\u202B\u206C\u206A\u206A\u202E\u206E\u206F\u206E\u206F\u202E\u202E\u206C\u206E\u200E\u200F\u206E\u202A\u200C\u202E());
						weaponOriginalData.scopeSway = ((playerAnimator2 != null) ? playerAnimator2.scopeSway : Vector3.zero);
						num = 2241339237U;
						continue;
					}
					case 9U:
					{
						WeaponMods.WeaponOriginalData value;
						WeaponMods.pristineData[gun.id] = value;
						num = (num2 * 457614901U ^ 3330226423U);
						continue;
					}
					case 10U:
						weaponOriginalData.shakeMin_x = gun.shakeMin_x;
						weaponOriginalData.shakeMin_y = gun.shakeMin_y;
						num = (num2 * 1149946390U ^ 3355212161U);
						continue;
					case 11U:
						weaponOriginalData.recoilMax_x = gun.recoilMax_x;
						weaponOriginalData.recoilMax_y = gun.recoilMax_y;
						num = (num2 * 2079355935U ^ 1937622219U);
						continue;
					case 12U:
					{
						WeaponMods.WeaponOriginalData value = weaponOriginalData;
						num = (num2 * 3033254156U ^ 3987628702U);
						continue;
					}
					}
					return;
				}
			}
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x0001125C File Offset: 0x0000F45C
		private void ApplyOrRestore(ItemGunAsset gun)
		{
			WeaponMods.WeaponOriginalData weaponOriginalData = WeaponMods.pristineData[gun.id];
			if (this.noRecoil)
			{
				goto IL_1C;
			}
			goto IL_136;
			uint num2;
			for (;;)
			{
				IL_21:
				uint num;
				switch ((num = (num2 ^ 923027978U)) % 32U)
				{
				case 0U:
					gun.shakeMin_z = weaponOriginalData.shakeMin_z;
					num2 = (num * 1244355831U ^ 831277016U);
					continue;
				case 1U:
					gun.recoilMin_y = weaponOriginalData.recoilMin_y;
					num2 = (num * 504810142U ^ 2255831851U);
					continue;
				case 2U:
					goto IL_1C;
				case 3U:
					num2 = (num * 557739224U ^ 3640664624U);
					continue;
				case 4U:
					goto IL_41C;
				case 5U:
					gun.shakeMax_x = (gun.shakeMax_y = (gun.shakeMax_z = 0f));
					gun.shakeMin_x = (gun.shakeMin_y = (gun.shakeMin_z = 0f));
					num2 = (num * 3836789534U ^ 1689959967U);
					continue;
				case 6U:
					goto IL_B6;
				case 7U:
					num2 = (num * 3761977122U ^ 3660903244U);
					continue;
				case 8U:
					num2 = (this.noShake ? 827621711U : 84745630U);
					continue;
				case 9U:
					gun.shakeMin_y = weaponOriginalData.shakeMin_y;
					num2 = (num * 1158407789U ^ 2512405887U);
					continue;
				case 10U:
					WeaponMods.\u206F\u206E\u202C\u202E\u200E\u202C\u206A\u206F\u206F\u206B\u206D\u202A\u200D\u202C\u202D\u200E\u206F\u202A\u206C\u206A\u206C\u202D\u202D\u206A\u206D\u206B\u200B\u206C\u200E\u206B\u206E\u206F\u202A\u200F\u206A\u202A\u206F\u200C\u200F\u206F\u202E(WeaponMods.\u202B\u202C\u206D\u200C\u200F\u206B\u202D\u202C\u200D\u202D\u206C\u202E\u200B\u206C\u200C\u202D\u202D\u206F\u202E\u206C\u202D\u200C\u202B\u206C\u206A\u206A\u202E\u206E\u206F\u206E\u206F\u202E\u202E\u206C\u206E\u200E\u200F\u206E\u202A\u200C\u202E()).viewmodelSwayMultiplier = 0f;
					num2 = (num * 3656438630U ^ 2954698598U);
					continue;
				case 11U:
					gun.recoilMin_x = weaponOriginalData.recoilMin_x;
					num2 = (num * 1915398576U ^ 4262051419U);
					continue;
				case 12U:
				{
					FieldInfo fieldInfo = WeaponMods.gravityField;
					if (fieldInfo == null)
					{
						return;
					}
					fieldInfo.\u200C\u202D\u202B\u200C\u206D\u206C\u206E\u206D\u200C\u202E\u206A\u206C\u206D\u200F\u202B\u202C\u202E\u202D\u200B\u202C\u200D\u202D\u206A\u202C\u200B\u206E\u200B\u202D\u206B\u200E\u206F\u206E\u200F\u202D\u200F\u206C\u200C\u202A\u200D\u200C\u202E(gun, weaponOriginalData.bulletGravityMultiplier);
					num2 = 595845042U;
					continue;
				}
				case 13U:
					goto IL_136;
				case 14U:
					num2 = (this.noSway ? 457067827U : 1376059286U);
					continue;
				case 15U:
					gun.spreadSprint = weaponOriginalData.spreadSprint;
					num2 = (num * 800711945U ^ 1177265180U);
					continue;
				case 16U:
					WeaponMods.\u206F\u206E\u202C\u202E\u200E\u202C\u206A\u206F\u206F\u206B\u206D\u202A\u200D\u202C\u202D\u200E\u206F\u202A\u206C\u206A\u206C\u202D\u202D\u206A\u206D\u206B\u200B\u206C\u200E\u206B\u206E\u206F\u202A\u200F\u206A\u202A\u206F\u200C\u200F\u206F\u202E(WeaponMods.\u202B\u202C\u206D\u200C\u200F\u206B\u202D\u202C\u200D\u202D\u206C\u202E\u200B\u206C\u200C\u202D\u202D\u206F\u202E\u206C\u202D\u200C\u202B\u206C\u206A\u206A\u202E\u206E\u206F\u206E\u206F\u202E\u202E\u206C\u206E\u200E\u200F\u206E\u202A\u200C\u202E()).scopeSway = Vector3.zero;
					num2 = (num * 398467616U ^ 3945983949U);
					continue;
				case 17U:
					gun.spreadCrouch = weaponOriginalData.spreadCrouch;
					num2 = (num * 1630663911U ^ 1971749831U);
					continue;
				case 18U:
					num2 = ((!this.noBulletGravity) ? 1853741638U : 745257017U);
					continue;
				case 19U:
					goto IL_1CD;
				case 20U:
					gun.shakeMax_x = weaponOriginalData.shakeMax_x;
					gun.shakeMax_y = weaponOriginalData.shakeMax_y;
					gun.shakeMax_z = weaponOriginalData.shakeMax_z;
					gun.shakeMin_x = weaponOriginalData.shakeMin_x;
					num2 = 1152565507U;
					continue;
				case 21U:
					gun.recoilMax_y = weaponOriginalData.recoilMax_y;
					num2 = (num * 275345605U ^ 3053615464U);
					continue;
				case 22U:
				{
					FieldInfo fieldInfo2 = WeaponMods.spreadField;
					if (fieldInfo2 == null)
					{
						goto IL_B6;
					}
					fieldInfo2.\u200C\u202D\u202B\u200C\u206D\u206C\u206E\u206D\u200C\u202E\u206A\u206C\u206D\u200F\u202B\u202C\u202E\u202D\u200B\u202C\u200D\u202D\u206A\u202C\u200B\u206E\u200B\u202D\u206B\u200E\u206F\u206E\u200F\u202D\u200F\u206C\u200C\u202A\u200D\u200C\u202E(gun, weaponOriginalData.baseSpreadAngleRadians);
					num2 = 389561836U;
					continue;
				}
				case 23U:
				{
					FieldInfo fieldInfo3 = WeaponMods.spreadField;
					if (fieldInfo3 == null)
					{
						goto IL_41C;
					}
					fieldInfo3.\u200C\u202D\u202B\u200C\u206D\u206C\u206E\u206D\u200C\u202E\u206A\u206C\u206D\u200F\u202B\u202C\u202E\u202D\u200B\u202C\u200D\u202D\u206A\u202C\u200B\u206E\u200B\u202D\u206B\u200E\u206F\u206E\u200F\u202D\u200F\u206C\u200C\u202A\u200D\u200C\u202E(gun, 0f);
					num2 = 2085117518U;
					continue;
				}
				case 25U:
					num2 = ((WeaponMods.\u206F\u206C\u200C\u200D\u202A\u200B\u202C\u202C\u202A\u202E\u202C\u206E\u202B\u206D\u206D\u206C\u202B\u200B\u202B\u206B\u202D\u206B\u202E\u202C\u206A\u200C\u200E\u200C\u202E\u206B\u202D\u206C\u200B\u200C\u202A\u206B\u202D\u200D\u200F\u200E\u202E(WeaponMods.\u206F\u206E\u202C\u202E\u200E\u202C\u206A\u206F\u206F\u206B\u206D\u202A\u200D\u202C\u202D\u200E\u206F\u202A\u206C\u206A\u206C\u202D\u202D\u206A\u206D\u206B\u200B\u206C\u200E\u206B\u206E\u206F\u202A\u200F\u206A\u202A\u206F\u200C\u200F\u206F\u202E(WeaponMods.\u202B\u202C\u206D\u200C\u200F\u206B\u202D\u202C\u200D\u202D\u206C\u202E\u200B\u206C\u200C\u202D\u202D\u206F\u202E\u206C\u202D\u200C\u202B\u206C\u206A\u206A\u202E\u206E\u206F\u206E\u206F\u202E\u202E\u206C\u206E\u200E\u200F\u206E\u202A\u200C\u202E()), null) ? 3308551077U : 2529199571U) ^ num * 657170285U);
					continue;
				case 26U:
					gun.spreadProne = weaponOriginalData.spreadProne;
					num2 = (num * 4025896175U ^ 3383548258U);
					continue;
				case 27U:
					WeaponMods.\u206F\u206E\u202C\u202E\u200E\u202C\u206A\u206F\u206F\u206B\u206D\u202A\u200D\u202C\u202D\u200E\u206F\u202A\u206C\u206A\u206C\u202D\u202D\u206A\u206D\u206B\u200B\u206C\u200E\u206B\u206E\u206F\u202A\u200F\u206A\u202A\u206F\u200C\u200F\u206F\u202E(WeaponMods.\u202B\u202C\u206D\u200C\u200F\u206B\u202D\u202C\u200D\u202D\u206C\u202E\u200B\u206C\u200C\u202D\u202D\u206F\u202E\u206C\u202D\u200C\u202B\u206C\u206A\u206A\u202E\u206E\u206F\u206E\u206F\u202E\u202E\u206C\u206E\u200E\u200F\u206E\u202A\u200C\u202E()).viewmodelSwayMultiplier = weaponOriginalData.viewmodelSwayMultiplier;
					WeaponMods.\u206F\u206E\u202C\u202E\u200E\u202C\u206A\u206F\u206F\u206B\u206D\u202A\u200D\u202C\u202D\u200E\u206F\u202A\u206C\u206A\u206C\u202D\u202D\u206A\u206D\u206B\u200B\u206C\u200E\u206B\u206E\u206F\u202A\u200F\u206A\u202A\u206F\u200C\u200F\u206F\u202E(WeaponMods.\u202B\u202C\u206D\u200C\u200F\u206B\u202D\u202C\u200D\u202D\u206C\u202E\u200B\u206C\u200C\u202D\u202D\u206F\u202E\u206C\u202D\u200C\u202B\u206C\u206A\u206A\u202E\u206E\u206F\u206E\u206F\u202E\u202E\u206C\u206E\u200E\u200F\u206E\u202A\u200C\u202E()).scopeSway = weaponOriginalData.scopeSway;
					num2 = (num * 1001381479U ^ 1319109471U);
					continue;
				case 28U:
					num2 = (WeaponMods.\u206F\u206C\u200C\u200D\u202A\u200B\u202C\u202C\u202A\u202E\u202C\u206E\u202B\u206D\u206D\u206C\u202B\u200B\u202B\u206B\u202D\u206B\u202E\u202C\u206A\u200C\u200E\u200C\u202E\u206B\u202D\u206C\u200B\u200C\u202A\u206B\u202D\u200D\u200F\u200E\u202E(WeaponMods.\u206F\u206E\u202C\u202E\u200E\u202C\u206A\u206F\u206F\u206B\u206D\u202A\u200D\u202C\u202D\u200E\u206F\u202A\u206C\u206A\u206C\u202D\u202D\u206A\u206D\u206B\u200B\u206C\u200E\u206B\u206E\u206F\u202A\u200F\u206A\u202A\u206F\u200C\u200F\u206F\u202E(WeaponMods.\u202B\u202C\u206D\u200C\u200F\u206B\u202D\u202C\u200D\u202D\u206C\u202E\u200B\u206C\u200C\u202D\u202D\u206F\u202E\u206C\u202D\u200C\u202B\u206C\u206A\u206A\u202E\u206E\u206F\u206E\u206F\u202E\u202E\u206C\u206E\u200E\u200F\u206E\u202A\u200C\u202E()), null) ? 1004324977U : 972565026U);
					continue;
				case 29U:
					num2 = (num * 3620948743U ^ 1350732399U);
					continue;
				case 30U:
					gun.recoilMax_x = (gun.recoilMax_y = (gun.recoilMin_x = (gun.recoilMin_y = 0f)));
					num2 = (num * 3490617052U ^ 2452450557U);
					continue;
				case 31U:
					num2 = ((!this.noSpread) ? 1356563228U : 733703261U);
					continue;
				}
				break;
				IL_B6:
				gun.spreadAim = weaponOriginalData.spreadAim;
				num2 = 992233029U;
				continue;
				IL_41C:
				gun.spreadAim = (gun.spreadSprint = (gun.spreadCrouch = (gun.spreadProne = 0f)));
				num2 = 435635415U;
			}
			return;
			IL_1CD:
			FieldInfo fieldInfo4 = WeaponMods.gravityField;
			if (fieldInfo4 == null)
			{
				return;
			}
			fieldInfo4.\u200C\u202D\u202B\u200C\u206D\u206C\u206E\u206D\u200C\u202E\u206A\u206C\u206D\u200F\u202B\u202C\u202E\u202D\u200B\u202C\u200D\u202D\u206A\u202C\u200B\u206E\u200B\u202D\u206B\u200E\u206F\u206E\u200F\u202D\u200F\u206C\u200C\u202A\u200D\u200C\u202E(gun, 0f);
			return;
			IL_1C:
			num2 = 1200146900U;
			goto IL_21;
			IL_136:
			gun.recoilMax_x = weaponOriginalData.recoilMax_x;
			num2 = 597725247U;
			goto IL_21;
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x00011748 File Offset: 0x0000F948
		private void OnDisable()
		{
			this.RestoreAll();
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x0001175C File Offset: 0x0000F95C
		public void RestoreAll()
		{
			if (WeaponMods.pristineData != null)
			{
				for (;;)
				{
					IL_0A:
					uint num = 1003321650U;
					for (;;)
					{
						uint num2;
						switch ((num2 = (num ^ 1869105309U)) % 5U)
						{
						case 0U:
							return;
						case 2U:
							goto IL_0A;
						case 3U:
							num = (((WeaponMods.pristineData.Count == 0) ? 3487111388U : 3404215617U) ^ num2 * 3702412600U);
							continue;
						case 4U:
							this.noRecoil = (this.noSpread = (this.noSway = (this.noShake = (this.noBulletGravity = false))));
							num = 1797182787U;
							continue;
						}
						goto Block_1;
					}
				}
				Block_1:
				using (Dictionary<ushort, WeaponMods.WeaponOriginalData>.Enumerator enumerator = WeaponMods.pristineData.GetEnumerator())
				{
					for (;;)
					{
						IL_103:
						uint num3 = enumerator.MoveNext() ? 1740256839U : 1764802374U;
						for (;;)
						{
							uint num2;
							switch ((num2 = (num3 ^ 1869105309U)) % 5U)
							{
							case 1U:
								goto IL_103;
							case 2U:
							{
								KeyValuePair<ushort, WeaponMods.WeaponOriginalData> keyValuePair = enumerator.Current;
								ushort key = keyValuePair.Key;
								ItemGunAsset itemGunAsset = WeaponMods.\u200B\u202C\u200B\u200D\u200E\u200F\u200D\u202B\u206B\u200C\u200D\u206F\u200D\u206D\u206A\u206F\u206C\u206E\u200F\u200D\u202A\u202E\u202B\u206B\u202D\u202C\u200E\u206C\u200D\u202C\u206C\u200B\u206B\u200D\u200E\u202B\u206D\u206A\u206F\u206E\u202E(1, key) as ItemGunAsset;
								num3 = ((itemGunAsset == null) ? 850895607U : 178400494U);
								continue;
							}
							case 3U:
							{
								ItemGunAsset itemGunAsset;
								this.ApplyOrRestore(itemGunAsset);
								num3 = (num2 * 3701509489U ^ 826150708U);
								continue;
							}
							case 4U:
								num3 = 1740256839U;
								continue;
							}
							goto Block_7;
						}
					}
					Block_7:;
				}
				if (WeaponMods.\u206F\u206C\u200C\u200D\u202A\u200B\u202C\u202C\u202A\u202E\u202C\u206E\u202B\u206D\u206D\u206C\u202B\u200B\u202B\u206B\u202D\u206B\u202E\u202C\u206A\u200C\u200E\u200C\u202E\u206B\u202D\u206C\u200B\u200C\u202A\u206B\u202D\u200D\u200F\u200E\u202E(WeaponMods.\u202B\u202C\u206D\u200C\u200F\u206B\u202D\u202C\u200D\u202D\u206C\u202E\u200B\u206C\u200C\u202D\u202D\u206F\u202E\u206C\u202D\u200C\u202B\u206C\u206A\u206A\u202E\u206E\u206F\u206E\u206F\u202E\u202E\u206C\u206E\u200E\u200F\u206E\u202A\u200C\u202E(), null))
				{
					goto IL_158;
				}
				goto IL_1DA;
				uint num4;
				for (;;)
				{
					IL_15D:
					uint num2;
					switch ((num2 = (num4 ^ 1869105309U)) % 6U)
					{
					case 0U:
						WeaponMods.\u206F\u206E\u202C\u202E\u200E\u202C\u206A\u206F\u206F\u206B\u206D\u202A\u200D\u202C\u202D\u200E\u206F\u202A\u206C\u206A\u206C\u202D\u202D\u206A\u206D\u206B\u200B\u206C\u200E\u206B\u206E\u206F\u202A\u200F\u206A\u202A\u206F\u200C\u200F\u206F\u202E(WeaponMods.\u202B\u202C\u206D\u200C\u200F\u206B\u202D\u202C\u200D\u202D\u206C\u202E\u200B\u206C\u200C\u202D\u202D\u206F\u202E\u206C\u202D\u200C\u202B\u206C\u206A\u206A\u202E\u206E\u206F\u206E\u206F\u202E\u202E\u206C\u206E\u200E\u200F\u206E\u202A\u200C\u202E()).scopeSway = Vector3.zero;
						num4 = (num2 * 3348910363U ^ 1883630077U);
						continue;
					case 1U:
						WeaponMods.\u206F\u206E\u202C\u202E\u200E\u202C\u206A\u206F\u206F\u206B\u206D\u202A\u200D\u202C\u202D\u200E\u206F\u202A\u206C\u206A\u206C\u202D\u202D\u206A\u206D\u206B\u200B\u206C\u200E\u206B\u206E\u206F\u202A\u200F\u206A\u202A\u206F\u200C\u200F\u206F\u202E(WeaponMods.\u202B\u202C\u206D\u200C\u200F\u206B\u202D\u202C\u200D\u202D\u206C\u202E\u200B\u206C\u200C\u202D\u202D\u206F\u202E\u206C\u202D\u200C\u202B\u206C\u206A\u206A\u202E\u206E\u206F\u206E\u206F\u202E\u202E\u206C\u206E\u200E\u200F\u206E\u202A\u200C\u202E()).viewmodelSwayMultiplier = 1f;
						num4 = (num2 * 824813885U ^ 1660709836U);
						continue;
					case 2U:
						goto IL_1DA;
					case 3U:
						goto IL_158;
					case 5U:
						num4 = (((!WeaponMods.\u206F\u206C\u200C\u200D\u202A\u200B\u202C\u202C\u202A\u202E\u202C\u206E\u202B\u206D\u206D\u206C\u202B\u200B\u202B\u206B\u202D\u206B\u202E\u202C\u206A\u200C\u200E\u200C\u202E\u206B\u202D\u206C\u200B\u200C\u202A\u206B\u202D\u200D\u200F\u200E\u202E(WeaponMods.\u206F\u206E\u202C\u202E\u200E\u202C\u206A\u206F\u206F\u206B\u206D\u202A\u200D\u202C\u202D\u200E\u206F\u202A\u206C\u206A\u206C\u202D\u202D\u206A\u206D\u206B\u200B\u206C\u200E\u206B\u206E\u206F\u202A\u200F\u206A\u202A\u206F\u200C\u200F\u206F\u202E(WeaponMods.\u202B\u202C\u206D\u200C\u200F\u206B\u202D\u202C\u200D\u202D\u206C\u202E\u200B\u206C\u200C\u202D\u202D\u206F\u202E\u206C\u202D\u200C\u202B\u206C\u206A\u206A\u202E\u206E\u206F\u206E\u206F\u202E\u202E\u206C\u206E\u200E\u200F\u206E\u202A\u200C\u202E()), null)) ? 1246770698U : 811846971U) ^ num2 * 243887651U);
						continue;
					}
					break;
				}
				return;
				IL_158:
				num4 = 1172391778U;
				goto IL_15D;
				IL_1DA:
				WeaponMods.pristineData.Clear();
				num4 = 1750684389U;
				goto IL_15D;
			}
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x00007690 File Offset: 0x00005890
		static Player \u202B\u202C\u206D\u200C\u200F\u206B\u202D\u202C\u200D\u202D\u206C\u202E\u200B\u206C\u200C\u202D\u202D\u206F\u202E\u206C\u202D\u200C\u202B\u206C\u206A\u206A\u202E\u206E\u206F\u206E\u206F\u202E\u202E\u206C\u206E\u200E\u200F\u206E\u202A\u200C\u202E()
		{
			return Player.LocalPlayer;
		}

		// Token: 0x060001AA RID: 426 RVA: 0x000076A4 File Offset: 0x000058A4
		static bool \u202B\u200E\u202B\u206E\u202E\u206C\u200D\u206B\u200F\u202A\u206F\u206C\u200F\u200B\u206E\u200B\u202C\u202A\u206E\u202A\u202C\u202E\u200E\u202E\u202A\u206F\u200B\u200B\u206D\u206E\u202D\u206B\u200B\u202D\u202D\u200D\u202B\u202C\u206B\u200D\u202E(Object A_0, Object A_1)
		{
			return A_0 == A_1;
		}

		// Token: 0x060001AB RID: 427 RVA: 0x000078CC File Offset: 0x00005ACC
		static PlayerEquipment \u206B\u202A\u202C\u206A\u206B\u206A\u202A\u202B\u206C\u206A\u206B\u200B\u206A\u200B\u206A\u200E\u202B\u200F\u200C\u206E\u202A\u200D\u206B\u200F\u200F\u200D\u200C\u200F\u200C\u200B\u206A\u206B\u200F\u200F\u206F\u200B\u200D\u206D\u202A\u202C\u202E(Player A_0)
		{
			return A_0.equipment;
		}

		// Token: 0x060001AC RID: 428 RVA: 0x000078E0 File Offset: 0x00005AE0
		static ItemAsset \u206E\u200C\u200F\u206F\u206B\u202E\u206A\u200E\u200D\u202B\u200D\u200C\u200B\u206F\u200C\u202C\u200B\u202D\u202C\u206A\u206C\u202A\u206B\u202C\u202C\u202C\u206D\u206B\u200F\u206A\u200D\u202A\u202A\u202D\u202C\u200F\u202B\u206A\u202A\u200F\u202E(PlayerEquipment A_0)
		{
			return A_0.asset;
		}

		// Token: 0x060001AD RID: 429 RVA: 0x000119E0 File Offset: 0x0000FBE0
		static bool \u206D\u202B\u206E\u206A\u200B\u202C\u206E\u200C\u200D\u200C\u202C\u202B\u200B\u200D\u200D\u200C\u202C\u202D\u206D\u200D\u202B\u202B\u202B\u202B\u200D\u202E\u206B\u206B\u202B\u206E\u206F\u206E\u202E\u202D\u206D\u206D\u206D\u202D\u202C\u202E(FieldInfo A_0, FieldInfo A_1)
		{
			return A_0 == A_1;
		}

		// Token: 0x060001AE RID: 430 RVA: 0x00007860 File Offset: 0x00005A60
		static Type \u202E\u202C\u200C\u200D\u206A\u206E\u200C\u206C\u206A\u206B\u200C\u206E\u200C\u200C\u206B\u200E\u206A\u202E\u202A\u202B\u206C\u202E\u200C\u202B\u202B\u200B\u206B\u202C\u202B\u206B\u200D\u206E\u206B\u202D\u202C\u206C\u202A\u202C\u206E\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		// Token: 0x060001AF RID: 431 RVA: 0x00007874 File Offset: 0x00005A74
		static FieldInfo \u202E\u202A\u200F\u200B\u206D\u202E\u202C\u200C\u202A\u202C\u202A\u206E\u200E\u200E\u206C\u200B\u200E\u200D\u200C\u202D\u206F\u206A\u206C\u200E\u206E\u206D\u200B\u200F\u206F\u200E\u206A\u206C\u202B\u200D\u206C\u200B\u202C\u206F\u202A\u206B\u202E(Type A_0, string A_1, BindingFlags A_2)
		{
			return A_0.GetField(A_1, A_2);
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x000119F4 File Offset: 0x0000FBF4
		static float \u200B\u206F\u206F\u200E\u206D\u200C\u200C\u202E\u206A\u206A\u200C\u206E\u206E\u200E\u202E\u206A\u200E\u200D\u206D\u200C\u206B\u206B\u206F\u200F\u202A\u206C\u200C\u206E\u206F\u200C\u202E\u202E\u206D\u206E\u206A\u202C\u200C\u202D\u206C\u206A\u202E(ItemGunAsset A_0)
		{
			return A_0.bulletGravityMultiplier;
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x00011A08 File Offset: 0x0000FC08
		static PlayerAnimator \u206F\u206E\u202C\u202E\u200E\u202C\u206A\u206F\u206F\u206B\u206D\u202A\u200D\u202C\u202D\u200E\u206F\u202A\u206C\u206A\u206C\u202D\u202D\u206A\u206D\u206B\u200B\u206C\u200E\u206B\u206E\u206F\u202A\u200F\u206A\u202A\u206F\u200C\u200F\u206F\u202E(Player A_0)
		{
			return A_0.animator;
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x00007B48 File Offset: 0x00005D48
		static bool \u206E\u200D\u202D\u200F\u200D\u202A\u206C\u200D\u200B\u202E\u206E\u206A\u206E\u202D\u206B\u200F\u202C\u206A\u206B\u206B\u202D\u206E\u206C\u206C\u200D\u206C\u202C\u206A\u200B\u206C\u206B\u202E\u206F\u200F\u206B\u206E\u200B\u200D\u206C\u202E(FieldInfo A_0, FieldInfo A_1)
		{
			return A_0 != A_1;
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x0000788C File Offset: 0x00005A8C
		static object \u206B\u206A\u200F\u206A\u200D\u202E\u206A\u206B\u206D\u200E\u206D\u206F\u200C\u206F\u206D\u200B\u206B\u202E\u206D\u206C\u202E\u206E\u202E\u200C\u206F\u206E\u202D\u202E\u206A\u202A\u200F\u206F\u200B\u206C\u206F\u206A\u200F\u200C\u200E\u200E\u202E(FieldInfo A_0, object A_1)
		{
			return A_0.GetValue(A_1);
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x00010D80 File Offset: 0x0000EF80
		void \u200C\u202D\u202B\u200C\u206D\u206C\u206E\u206D\u200C\u202E\u206A\u206C\u206D\u200F\u202B\u202C\u202E\u202D\u200B\u202C\u200D\u202D\u206A\u202C\u200B\u206E\u200B\u202D\u206B\u200E\u206F\u206E\u200F\u202D\u200F\u206C\u200C\u202A\u200D\u200C\u202E(object A_1, object A_2)
		{
			base.SetValue(A_1, A_2);
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x000061E8 File Offset: 0x000043E8
		static bool \u206F\u206C\u200C\u200D\u202A\u200B\u202C\u202C\u202A\u202E\u202C\u206E\u202B\u206D\u206D\u206C\u202B\u200B\u202B\u206B\u202D\u206B\u202E\u202C\u206A\u200C\u200E\u200C\u202E\u206B\u202D\u206C\u200B\u200C\u202A\u206B\u202D\u200D\u200F\u200E\u202E(Object A_0, Object A_1)
		{
			return A_0 != A_1;
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x00011A1C File Offset: 0x0000FC1C
		static Asset \u200B\u202C\u200B\u200D\u200E\u200F\u200D\u202B\u206B\u200C\u200D\u206F\u200D\u206D\u206A\u206F\u206C\u206E\u200F\u200D\u202A\u202E\u202B\u206B\u202D\u202C\u200E\u206C\u200D\u202C\u206C\u200B\u206B\u200D\u200E\u202B\u206D\u206A\u206F\u206E\u202E(EAssetType A_0, ushort A_1)
		{
			return Assets.find(A_0, A_1);
		}

		// Token: 0x040000B0 RID: 176
		public bool noRecoil = true;

		// Token: 0x040000B1 RID: 177
		public bool noSpread = true;

		// Token: 0x040000B2 RID: 178
		public bool noSway = true;

		// Token: 0x040000B3 RID: 179
		public bool noShake = true;

		// Token: 0x040000B4 RID: 180
		public bool noBulletGravity = true;

		// Token: 0x040000B5 RID: 181
		private static readonly Dictionary<ushort, WeaponMods.WeaponOriginalData> pristineData = new Dictionary<ushort, WeaponMods.WeaponOriginalData>();

		// Token: 0x040000B6 RID: 182
		private static FieldInfo spreadField;

		// Token: 0x040000B7 RID: 183
		private static FieldInfo gravityField;

		// Token: 0x0200001E RID: 30
		private struct WeaponOriginalData
		{
			// Token: 0x040000B8 RID: 184
			public float recoilMax_x;

			// Token: 0x040000B9 RID: 185
			public float recoilMax_y;

			// Token: 0x040000BA RID: 186
			public float recoilMin_x;

			// Token: 0x040000BB RID: 187
			public float recoilMin_y;

			// Token: 0x040000BC RID: 188
			public float baseSpreadAngleRadians;

			// Token: 0x040000BD RID: 189
			public float spreadAim;

			// Token: 0x040000BE RID: 190
			public float spreadSprint;

			// Token: 0x040000BF RID: 191
			public float spreadCrouch;

			// Token: 0x040000C0 RID: 192
			public float spreadProne;

			// Token: 0x040000C1 RID: 193
			public float shakeMax_x;

			// Token: 0x040000C2 RID: 194
			public float shakeMax_y;

			// Token: 0x040000C3 RID: 195
			public float shakeMax_z;

			// Token: 0x040000C4 RID: 196
			public float shakeMin_x;

			// Token: 0x040000C5 RID: 197
			public float shakeMin_y;

			// Token: 0x040000C6 RID: 198
			public float shakeMin_z;

			// Token: 0x040000C7 RID: 199
			public float bulletGravityMultiplier;

			// Token: 0x040000C8 RID: 200
			public Vector3 scopeSway;

			// Token: 0x040000C9 RID: 201
			public float viewmodelSwayMultiplier;
		}
	}
}
