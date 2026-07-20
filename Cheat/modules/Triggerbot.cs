using System;
using System.Runtime.CompilerServices;
using Cheat.core;
using SDG.Unturned;
using UnityEngine;

namespace Cheat.modules
{
	// Token: 0x0200001A RID: 26
	public class Triggerbot : MonoBehaviour
	{
		// Token: 0x06000140 RID: 320 RVA: 0x0000EAE8 File Offset: 0x0000CCE8
		public void Toggle()
		{
			this.enabled = !this.enabled;
			if (!this.enabled)
			{
				for (;;)
				{
					IL_17:
					uint num = 3941763994U;
					for (;;)
					{
						uint num2;
						switch ((num2 = (num ^ 2925023101U)) % 4U)
						{
						case 0U:
							goto IL_17;
						case 1U:
							this.StopFire();
							num = (num2 * 631985641U ^ 2002498758U);
							continue;
						case 3U:
							num = ((this.bModified ? 1798315864U : 577301995U) ^ num2 * 3988836208U);
							continue;
						}
						goto Block_1;
					}
				}
				Block_1:;
			}
		}

		// Token: 0x06000141 RID: 321 RVA: 0x0000EB68 File Offset: 0x0000CD68
		private void Update()
		{
			if (this.enabled)
			{
				goto IL_0B;
			}
			goto IL_2A0;
			uint num2;
			for (;;)
			{
				IL_10:
				uint num;
				float gunRange;
				float num3;
				switch ((num = (num2 ^ 3624418859U)) % 28U)
				{
				case 0U:
					num2 = ((!this.bModified) ? 2275389120U : 2826133401U);
					continue;
				case 1U:
					this.StopFire();
					num2 = (num * 1086690979U ^ 2874248808U);
					continue;
				case 2U:
					num2 = (((!Triggerbot.\u200F\u206E\u200B\u200B\u202C\u206C\u200F\u206B\u200C\u206C\u202C\u202A\u206F\u200D\u206C\u206F\u206A\u200D\u206F\u206A\u206A\u200E\u200B\u202A\u206A\u206F\u200D\u206D\u206C\u200B\u202B\u202E\u200E\u202B\u202B\u206B\u206C\u202D\u206D\u200D\u202E(Triggerbot.\u206A\u206F\u206D\u206D\u206E\u206B\u200E\u206F\u206A\u200D\u200B\u206B\u200C\u206A\u206E\u200B\u202A\u206A\u206E\u202A\u200E\u200C\u200E\u206E\u206A\u202C\u206E\u200B\u202D\u206B\u202E\u200D\u200D\u206B\u206C\u206D\u202B\u200B\u206D\u202E\u202E(), null)) ? 1761505874U : 885204499U) ^ num * 1089215608U);
					continue;
				case 3U:
					if (!this.useWeaponRange)
					{
						num2 = 2157181678U;
						continue;
					}
					gunRange = Utils.GetGunRange();
					goto IL_1FE;
				case 4U:
					goto IL_2A0;
				case 5U:
				{
					PlayerEquipment playerEquipment;
					num2 = ((Triggerbot.\u206C\u200B\u206A\u200D\u202C\u202D\u200D\u202E\u200E\u202D\u202D\u206E\u206E\u202C\u202D\u206B\u202C\u202C\u202E\u206B\u206F\u200E\u206F\u202A\u202B\u200F\u202D\u200C\u206A\u202E\u200F\u202C\u202B\u200D\u200B\u206A\u206F\u202C\u202A\u206C\u202E(playerEquipment) ? 1664462964U : 799106701U) ^ num * 4272220192U);
					continue;
				}
				case 6U:
					num2 = (this.bModified ? 3064060594U : 2156576003U);
					continue;
				case 7U:
				{
					PlayerEquipment playerEquipment;
					num2 = ((Triggerbot.\u200F\u206E\u200B\u200B\u202C\u206C\u200F\u206B\u200C\u206C\u202C\u202A\u206F\u200D\u206C\u206F\u206A\u200D\u206F\u206A\u206A\u200E\u200B\u202A\u206A\u206F\u200D\u206D\u206C\u200B\u202B\u202E\u200E\u202B\u202B\u206B\u206C\u202D\u206D\u200D\u202E(playerEquipment, null) ? 2014199042U : 1666969951U) ^ num * 1156568765U);
					continue;
				}
				case 8U:
				{
					Vector3 vector = Triggerbot.\u206B\u206A\u202B\u206A\u202E\u202D\u200C\u206F\u202B\u200F\u206B\u202A\u202E\u202D\u206C\u200F\u202A\u202E\u200D\u200D\u206F\u202C\u206C\u200C\u206C\u200C\u206F\u206C\u202A\u202C\u206F\u200F\u206E\u200D\u206D\u206A\u200B\u206E\u202C\u200D\u202E(Triggerbot.\u206A\u206F\u200B\u200F\u206B\u200F\u206A\u200D\u200F\u202D\u206E\u200F\u202D\u202D\u206D\u206C\u202A\u206C\u202B\u200F\u200E\u200E\u206A\u202E\u206D\u206F\u200C\u206C\u202B\u202D\u202C\u202D\u206A\u202D\u206C\u206A\u200E\u202E\u206E\u206F\u202E(Triggerbot.\u206B\u200E\u200E\u200B\u202E\u206E\u202A\u200B\u206E\u200B\u200F\u206B\u200C\u202C\u200F\u206D\u206B\u206D\u206D\u202A\u206F\u206C\u206E\u202E\u202A\u200F\u202E\u206A\u206E\u206F\u202A\u200F\u202A\u200E\u202C\u202A\u206D\u202B\u202A\u202B\u202E(Triggerbot.\u206A\u206F\u206D\u206D\u206E\u206B\u200E\u206F\u206A\u200D\u200B\u206B\u200C\u206A\u206E\u200B\u202A\u206A\u206E\u202A\u200E\u200C\u200E\u206E\u206A\u202C\u206E\u200B\u202D\u206B\u202E\u200D\u200D\u206B\u206C\u206D\u202B\u200B\u206D\u202E\u202E())));
					Vector3 vector2 = Triggerbot.\u206D\u206B\u202D\u206A\u206F\u206B\u206C\u200F\u202B\u206E\u206F\u200F\u206E\u206F\u206C\u202C\u202A\u202B\u200C\u202E\u200E\u206F\u200B\u200D\u202C\u206F\u206C\u200E\u200D\u206C\u206E\u202D\u200E\u202A\u202A\u200C\u202D\u206C\u202B\u206C\u202E(Triggerbot.\u206A\u206F\u200B\u200F\u206B\u200F\u206A\u200D\u200F\u202D\u206E\u200F\u202D\u202D\u206D\u206C\u202A\u206C\u202B\u200F\u200E\u200E\u206A\u202E\u206D\u206F\u200C\u206C\u202B\u202D\u202C\u202D\u206A\u202D\u206C\u206A\u200E\u202E\u206E\u206F\u202E(Triggerbot.\u206B\u200E\u200E\u200B\u202E\u206E\u202A\u200B\u206E\u200B\u200F\u206B\u200C\u202C\u200F\u206D\u206B\u206D\u206D\u202A\u206F\u206C\u206E\u202E\u202A\u200F\u202E\u206A\u206E\u206F\u202A\u200F\u202A\u200E\u202C\u202A\u206D\u202B\u202A\u202B\u202E(Triggerbot.\u206A\u206F\u206D\u206D\u206E\u206B\u200E\u206F\u206A\u200D\u200B\u206B\u200C\u206A\u206E\u200B\u202A\u206A\u206E\u202A\u200E\u200C\u200E\u206E\u206A\u202C\u206E\u200B\u202D\u206B\u202E\u200D\u200D\u206B\u206C\u206D\u202B\u200B\u206D\u202E\u202E())));
					Player player = null;
					RaycastHit raycastHit;
					num2 = ((Triggerbot.\u200E\u200D\u206E\u206E\u202E\u202C\u206D\u206D\u200B\u200E\u200B\u200D\u200B\u206C\u200E\u206C\u206A\u206C\u200C\u200F\u202A\u200E\u202E\u202D\u202D\u202C\u200F\u206E\u206D\u206A\u206A\u202D\u202E\u200E\u200C\u202B\u202B\u206F\u200B\u206E\u202E(vector, vector2, ref raycastHit, num3, RayMasks.DAMAGE_CLIENT) ? 1348160296U : 413700838U) ^ num * 3951546947U);
					continue;
				}
				case 9U:
				{
					Player player;
					num2 = (Triggerbot.\u200F\u206E\u200B\u200B\u202C\u206C\u200F\u206B\u200C\u206C\u202C\u202A\u206F\u200D\u206C\u206F\u206A\u200D\u206F\u206A\u206A\u200E\u200B\u202A\u206A\u206F\u200D\u206D\u206C\u200B\u202B\u202E\u200E\u202B\u202B\u206B\u206C\u202D\u206D\u200D\u202E(player, null) ? 2302417407U : 3149812975U);
					continue;
				}
				case 10U:
					num2 = ((Triggerbot.\u200F\u206F\u202D\u206B\u200E\u206B\u206B\u206A\u200C\u202A\u200F\u200F\u206B\u202A\u200F\u200F\u200D\u206E\u202B\u200E\u206E\u202A\u206E\u200E\u206B\u202C\u206A\u202C\u202B\u206D\u206E\u206F\u200B\u200F\u200B\u200E\u200F\u206D\u202E\u202D\u202E() ? 1942991555U : 1110471417U) ^ num * 2928894080U);
					continue;
				case 11U:
					return;
				case 12U:
				{
					Player player;
					num2 = ((Triggerbot.\u200F\u206E\u200B\u200B\u202C\u206C\u200F\u206B\u200C\u206C\u202C\u202A\u206F\u200D\u206C\u206F\u206A\u200D\u206F\u206A\u206A\u200E\u200B\u202A\u206A\u206F\u200D\u206D\u206C\u200B\u202B\u202E\u200E\u202B\u202B\u206B\u206C\u202D\u206D\u200D\u202E(player, Triggerbot.\u206A\u206F\u206D\u206D\u206E\u206B\u200E\u206F\u206A\u200D\u200B\u206B\u200C\u206A\u206E\u200B\u202A\u206A\u206E\u202A\u200E\u200C\u200E\u206E\u206A\u202C\u206E\u200B\u202D\u206B\u202E\u200D\u200D\u206B\u206C\u206D\u202B\u200B\u206D\u202E\u202E()) ? 2940939007U : 4239606949U) ^ num * 2892515520U);
					continue;
				}
				case 13U:
					return;
				case 14U:
					this.StopFire();
					num2 = (num * 667287321U ^ 2848552610U);
					continue;
				case 15U:
					this.StartFire();
					num2 = 4228905041U;
					continue;
				case 16U:
					return;
				case 17U:
					goto IL_0B;
				case 18U:
				{
					Player player;
					num2 = (((!Triggerbot.\u202C\u206E\u206D\u200B\u202B\u200B\u206B\u200E\u200E\u202A\u206E\u206B\u202C\u202E\u206D\u206E\u206E\u200E\u206F\u200F\u202A\u202D\u202D\u206F\u200C\u206D\u202B\u200B\u200E\u206B\u206A\u202E\u206D\u202C\u206F\u200B\u206B\u200C\u206B\u202C\u202E(Triggerbot.\u202A\u200E\u202C\u206F\u206D\u200E\u202D\u206C\u200B\u206C\u206D\u206B\u206F\u202D\u200C\u202C\u202B\u200E\u202A\u200C\u206B\u202E\u206D\u202B\u206E\u200E\u200C\u202D\u202D\u200D\u206F\u200B\u200E\u202D\u200B\u202B\u202D\u206E\u202C\u202B\u202E(player))) ? 2885769486U : 2414039449U) ^ num * 1542504757U);
					continue;
				}
				case 19U:
				{
					RaycastHit raycastHit;
					Player player = Triggerbot.\u206B\u206D\u200C\u200C\u202C\u202A\u206D\u200D\u202D\u200B\u200D\u200C\u200F\u202A\u206B\u200F\u206A\u202E\u200C\u202B\u206A\u200F\u206F\u202C\u202D\u200F\u202C\u206B\u200F\u200C\u200C\u200C\u206F\u200D\u200D\u206C\u202C\u206B\u202D\u206C\u202E(raycastHit.transform);
					num2 = (num * 2148630394U ^ 2903396920U);
					continue;
				}
				case 20U:
					this.StopFire();
					num2 = (num * 108556505U ^ 1767766034U);
					continue;
				case 21U:
					gunRange = this.customMaxDistance;
					goto IL_1FE;
				case 22U:
				{
					PlayerEquipment playerEquipment = Triggerbot.\u206D\u202B\u200F\u202E\u206B\u206B\u206E\u206B\u206C\u202E\u206E\u202D\u206C\u200C\u200D\u202A\u200F\u200E\u206D\u200F\u202A\u206D\u202D\u206B\u206B\u206B\u200D\u202D\u202D\u200F\u206D\u200E\u200E\u200F\u200D\u206A\u206A\u200B\u200E\u200F\u202E(Triggerbot.\u206A\u206F\u206D\u206D\u206E\u206B\u200E\u206F\u206A\u200D\u200B\u206B\u200C\u206A\u206E\u200B\u202A\u206A\u206E\u202A\u200E\u200C\u200E\u206E\u206A\u202C\u206E\u200B\u202D\u206B\u202E\u200D\u200D\u206B\u206C\u206D\u202B\u200B\u206D\u202E\u202E());
					num2 = 3422300272U;
					continue;
				}
				case 23U:
				{
					PlayerEquipment playerEquipment;
					num2 = (((Triggerbot.\u206C\u206D\u202A\u206C\u206A\u200F\u202D\u202A\u200B\u206C\u202E\u200B\u200D\u206E\u202E\u200C\u202D\u206D\u202B\u200D\u202B\u206A\u202D\u206F\u200B\u200E\u206B\u200D\u200B\u206B\u200E\u206D\u202E\u202B\u200B\u202B\u200F\u200E\u200F\u202B\u202E(playerEquipment) == null) ? 1409966310U : 1323467493U) ^ num * 2348786257U);
					continue;
				}
				case 24U:
				{
					PlayerEquipment playerEquipment;
					this.currentFiremode = this.GetFiremode(Triggerbot.\u206C\u206D\u202A\u206C\u206A\u200F\u202D\u202A\u200B\u206C\u202E\u200B\u200D\u206E\u202E\u200C\u202D\u206D\u202B\u200D\u202B\u206A\u202D\u206F\u200B\u200E\u206B\u200D\u200B\u206B\u200E\u206D\u202E\u202B\u200B\u202B\u200F\u200E\u200F\u202B\u202E(playerEquipment));
					num2 = (num * 2290667208U ^ 3525503515U);
					continue;
				}
				case 25U:
					num2 = ((Triggerbot.\u200F\u206E\u202E\u200C\u200E\u202C\u206F\u200D\u202B\u202C\u206C\u206E\u200C\u202D\u202A\u202C\u202C\u206F\u206A\u206F\u206D\u200E\u202C\u200E\u200F\u206A\u202A\u206B\u202B\u202B\u200F\u206E\u202C\u206E\u200E\u200E\u206A\u200B\u206D\u206F\u202E() ? 4023197308U : 2183340062U) ^ num * 1139458325U);
					continue;
				case 27U:
				{
					Player player;
					num2 = (((!Utils.IsFriendly(player)) ? 805627678U : 1750656833U) ^ num * 3959787370U);
					continue;
				}
				}
				break;
				IL_1FE:
				num3 = gunRange;
				num2 = 2877204867U;
			}
			return;
			IL_0B:
			num2 = 3878816525U;
			goto IL_10;
			IL_2A0:
			num2 = (this.bModified ? 3229711671U : 2676742830U);
			goto IL_10;
		}

		// Token: 0x06000142 RID: 322 RVA: 0x0000EF34 File Offset: 0x0000D134
		[MethodImpl(MethodImplOptions.NoInlining)]
		private EFiremode GetFiremode(ItemAsset asset)
		{
			ItemGunAsset itemGunAsset = asset as ItemGunAsset;
			object privateField;
			for (;;)
			{
				IL_07:
				uint num = 2850190458U;
				for (;;)
				{
					uint num2;
					switch ((num2 = (num ^ 2254162325U)) % 6U)
					{
					case 0U:
						goto IL_07;
					case 1U:
						num = (((privateField is EFiremode) ? 3894938279U : 3570579886U) ^ num2 * 2640382530U);
						continue;
					case 2U:
						privateField = Utils.GetPrivateField(itemGunAsset, <Module>.\u202B\u200B\u202C\u206C\u206D\u202C\u206B\u200F\u206D\u206D\u200E\u206A\u202E\u206D\u200D\u206A\u202D\u202B\u200B\u200F\u202C\u206D\u200E\u202D\u200D\u206A\u200F\u206E\u206F\u206F\u200D\u202D\u202C\u200B\u206F\u202C\u202A\u200D\u206E\u202E\u202E<string>(177719169));
						num = 2371900822U;
						continue;
					case 3U:
						num = (((itemGunAsset == null) ? 945689900U : 306658097U) ^ num2 * 2044997116U);
						continue;
					case 4U:
						goto IL_51;
					}
					goto Block_1;
				}
			}
			Block_1:
			return 2;
			IL_51:
			return (EFiremode)privateField;
		}

		// Token: 0x06000143 RID: 323 RVA: 0x0000EFEC File Offset: 0x0000D1EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void StartFire()
		{
			PlayerEquipment obj = Triggerbot.\u206D\u202B\u200F\u202E\u206B\u206B\u206E\u206B\u206C\u202E\u206E\u202D\u206C\u200C\u200D\u202A\u200F\u200E\u206D\u200F\u202A\u206D\u202D\u206B\u206B\u206B\u200D\u202D\u202D\u200F\u206D\u200E\u200E\u200F\u200D\u206A\u206A\u200B\u200E\u200F\u202E(Triggerbot.\u206A\u206F\u206D\u206D\u206E\u206B\u200E\u206F\u206A\u200D\u200B\u206B\u200C\u206A\u206E\u200B\u202A\u206A\u206E\u202A\u200E\u200C\u200E\u206E\u206A\u202C\u206E\u200B\u202D\u206B\u202E\u200D\u200D\u206B\u206C\u206D\u202B\u200B\u206D\u202E\u202E());
			for (;;)
			{
				IL_0B:
				uint num = 2926837090U;
				for (;;)
				{
					uint num2;
					switch ((num2 = (num ^ 3736849075U)) % 8U)
					{
					case 1U:
						num = (((this.currentFiremode == 1) ? 3921083294U : 3925862205U) ^ num2 * 3383696770U);
						continue;
					case 2U:
						Utils.SetPrivateField(obj, <Module>.\u202E\u206C\u206E\u202C\u202D\u202D\u206D\u206B\u202B\u206F\u200B\u206E\u200B\u202C\u202A\u200D\u202D\u200B\u202D\u202E\u200D\u206F\u206C\u202C\u200B\u202C\u206D\u202B\u206C\u206E\u200E\u206A\u200D\u206F\u200E\u206E\u206A\u200C\u200D\u206B\u202E<string>(2092034841), false);
						num = 3117369323U;
						continue;
					case 3U:
						goto IL_0B;
					case 4U:
						num = (((this.currentFiremode == 3) ? 3840695224U : 3589686233U) ^ num2 * 3349217347U);
						continue;
					case 5U:
						Utils.SetPrivateField(obj, <Module>.\u206A\u202C\u206A\u206C\u202A\u206F\u200B\u206C\u206C\u206B\u206F\u206C\u200C\u206D\u200C\u200C\u206C\u206A\u202A\u206B\u200B\u202E\u200C\u206E\u202D\u202A\u200E\u202D\u200E\u200E\u200D\u200E\u202B\u202A\u206E\u202A\u200B\u200B\u202D\u202E<string>(-596050305), true);
						num = 3117369323U;
						continue;
					case 6U:
						Utils.SetPrivateField(obj, <Module>.\u202E\u206C\u206E\u202C\u202D\u202D\u206D\u206B\u202B\u206F\u200B\u206E\u200B\u202C\u202A\u200D\u202D\u200B\u202D\u202E\u200D\u206F\u206C\u202C\u200B\u202C\u206D\u202B\u206C\u206E\u200E\u206A\u200D\u206F\u200E\u206E\u206A\u200C\u200D\u206B\u202E<string>(585271058), true);
						num = 2587007993U;
						continue;
					case 7U:
						Utils.SetPrivateField(obj, <Module>.\u200F\u206F\u200E\u202A\u200D\u200C\u206A\u200E\u202E\u202C\u200D\u202D\u200D\u202B\u200F\u200C\u200F\u200D\u206B\u206D\u206E\u202A\u206C\u206B\u200B\u200F\u206D\u206A\u202E\u206C\u206F\u206A\u200C\u200C\u206C\u202A\u206F\u206A\u202D\u206E\u202E<string>(-812100934), true);
						num = 2288355390U;
						continue;
					}
					goto Block_1;
				}
			}
			Block_1:
			this.bModified = true;
		}

		// Token: 0x06000144 RID: 324 RVA: 0x0000F114 File Offset: 0x0000D314
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void StopFire()
		{
			if (!this.bModified)
			{
				goto IL_08;
			}
			goto IL_5B;
			uint num2;
			for (;;)
			{
				IL_0D:
				uint num;
				switch ((num = (num2 ^ 702763354U)) % 5U)
				{
				case 0U:
					goto IL_08;
				case 1U:
					this.bModified = false;
					num2 = (num * 3528896373U ^ 3010417105U);
					continue;
				case 2U:
					goto IL_5B;
				case 3U:
					return;
				}
				break;
			}
			return;
			IL_08:
			num2 = 1680891915U;
			goto IL_0D;
			IL_5B:
			PlayerEquipment obj = Triggerbot.\u206D\u202B\u200F\u202E\u206B\u206B\u206E\u206B\u206C\u202E\u206E\u202D\u206C\u200C\u200D\u202A\u200F\u200E\u206D\u200F\u202A\u206D\u202D\u206B\u206B\u206B\u200D\u202D\u202D\u200F\u206D\u200E\u200E\u200F\u200D\u206A\u206A\u200B\u200E\u200F\u202E(Triggerbot.\u206A\u206F\u206D\u206D\u206E\u206B\u200E\u206F\u206A\u200D\u200B\u206B\u200C\u206A\u206E\u200B\u202A\u206A\u206E\u202A\u200E\u200C\u200E\u206E\u206A\u202C\u206E\u200B\u202D\u206B\u202E\u200D\u200D\u206B\u206C\u206D\u202B\u200B\u206D\u202E\u202E());
			Utils.SetPrivateField(obj, <Module>.\u200B\u206C\u200C\u200C\u206A\u200B\u200D\u206C\u206B\u206D\u202B\u200F\u200E\u206E\u206A\u200D\u206B\u202E\u206A\u200E\u200B\u202E\u200F\u206C\u200F\u202A\u202B\u200F\u200D\u200C\u202D\u200E\u206B\u200D\u202A\u200E\u202E\u206A\u202B\u200C\u202E<string>(-1901607184), false);
			Utils.SetPrivateField(obj, <Module>.\u202E\u206C\u206E\u202C\u202D\u202D\u206D\u206B\u202B\u206F\u200B\u206E\u200B\u202C\u202A\u200D\u202D\u200B\u202D\u202E\u200D\u206F\u206C\u202C\u200B\u202C\u206D\u202B\u206C\u206E\u200E\u206A\u200D\u206F\u200E\u206E\u206A\u200C\u200D\u206B\u202E<string>(2092034841), true);
			Utils.SetPrivateField(obj, <Module>.\u202B\u200B\u202C\u206C\u206D\u202C\u206B\u200F\u206D\u206D\u200E\u206A\u202E\u206D\u200D\u206A\u202D\u202B\u200B\u200F\u202C\u206D\u200E\u202D\u200D\u206A\u200F\u206E\u206F\u206F\u200D\u202D\u202C\u200B\u206F\u202C\u202A\u200D\u206E\u202E\u202E<string>(-831800391), true);
			num2 = 2140503182U;
			goto IL_0D;
		}

		// Token: 0x06000145 RID: 325 RVA: 0x0000F1DC File Offset: 0x0000D3DC
		private void OnDisable()
		{
			if (this.bModified)
			{
				for (;;)
				{
					IL_08:
					uint num = 1418322669U;
					for (;;)
					{
						uint num2;
						switch ((num2 = (num ^ 1724404622U)) % 3U)
						{
						case 1U:
							this.StopFire();
							num = (num2 * 3363399842U ^ 3347691227U);
							continue;
						case 2U:
							goto IL_08;
						}
						goto Block_1;
					}
				}
				Block_1:;
			}
		}

		// Token: 0x06000147 RID: 327 RVA: 0x00007690 File Offset: 0x00005890
		static Player \u206A\u206F\u206D\u206D\u206E\u206B\u200E\u206F\u206A\u200D\u200B\u206B\u200C\u206A\u206E\u200B\u202A\u206A\u206E\u202A\u200E\u200C\u200E\u206E\u206A\u202C\u206E\u200B\u202D\u206B\u202E\u200D\u200D\u206B\u206C\u206D\u202B\u200B\u206D\u202E\u202E()
		{
			return Player.LocalPlayer;
		}

		// Token: 0x06000148 RID: 328 RVA: 0x000076A4 File Offset: 0x000058A4
		static bool \u200F\u206E\u200B\u200B\u202C\u206C\u200F\u206B\u200C\u206C\u202C\u202A\u206F\u200D\u206C\u206F\u206A\u200D\u206F\u206A\u206A\u200E\u200B\u202A\u206A\u206F\u200D\u206D\u206C\u200B\u202B\u202E\u200E\u202B\u202B\u206B\u206C\u202D\u206D\u200D\u202E(Object A_0, Object A_1)
		{
			return A_0 == A_1;
		}

		// Token: 0x06000149 RID: 329 RVA: 0x000076B8 File Offset: 0x000058B8
		static bool \u200F\u206E\u202E\u200C\u200E\u202C\u206F\u200D\u202B\u202C\u206C\u206E\u200C\u202D\u202A\u202C\u202C\u206F\u206A\u206F\u206D\u200E\u202C\u200E\u200F\u206A\u202A\u206B\u202B\u202B\u200F\u206E\u202C\u206E\u200E\u200E\u206A\u200B\u206D\u206F\u202E()
		{
			return Provider.isConnected;
		}

		// Token: 0x0600014A RID: 330 RVA: 0x000076CC File Offset: 0x000058CC
		static bool \u200F\u206F\u202D\u206B\u200E\u206B\u206B\u206A\u200C\u202A\u200F\u200F\u206B\u202A\u200F\u200F\u200D\u206E\u202B\u200E\u206E\u202A\u206E\u200E\u206B\u202C\u206A\u202C\u202B\u206D\u206E\u206F\u200B\u200F\u200B\u200E\u200F\u206D\u202E\u202D\u202E()
		{
			return Provider.isLoading;
		}

		// Token: 0x0600014B RID: 331 RVA: 0x000078CC File Offset: 0x00005ACC
		static PlayerEquipment \u206D\u202B\u200F\u202E\u206B\u206B\u206E\u206B\u206C\u202E\u206E\u202D\u206C\u200C\u200D\u202A\u200F\u200E\u206D\u200F\u202A\u206D\u202D\u206B\u206B\u206B\u200D\u202D\u202D\u200F\u206D\u200E\u200E\u200F\u200D\u206A\u206A\u200B\u200E\u200F\u202E(Player A_0)
		{
			return A_0.equipment;
		}

		// Token: 0x0600014C RID: 332 RVA: 0x000078E0 File Offset: 0x00005AE0
		static ItemAsset \u206C\u206D\u202A\u206C\u206A\u200F\u202D\u202A\u200B\u206C\u202E\u200B\u200D\u206E\u202E\u200C\u202D\u206D\u202B\u200D\u202B\u206A\u202D\u206F\u200B\u200E\u206B\u200D\u200B\u206B\u200E\u206D\u202E\u202B\u200B\u202B\u200F\u200E\u200F\u202B\u202E(PlayerEquipment A_0)
		{
			return A_0.asset;
		}

		// Token: 0x0600014D RID: 333 RVA: 0x0000F254 File Offset: 0x0000D454
		static bool \u206C\u200B\u206A\u200D\u202C\u202D\u200D\u202E\u200E\u202D\u202D\u206E\u206E\u202C\u202D\u206B\u202C\u202C\u202E\u206B\u206F\u200E\u206F\u202A\u202B\u200F\u202D\u200C\u206A\u202E\u200F\u202C\u202B\u200D\u200B\u206A\u206F\u202C\u202A\u206C\u202E(PlayerEquipment A_0)
		{
			return A_0.IsEquipAnimationFinished;
		}

		// Token: 0x0600014E RID: 334 RVA: 0x000077E8 File Offset: 0x000059E8
		static PlayerLook \u206B\u200E\u200E\u200B\u202E\u206E\u202A\u200B\u206E\u200B\u200F\u206B\u200C\u202C\u200F\u206D\u206B\u206D\u206D\u202A\u206F\u206C\u206E\u202E\u202A\u200F\u202E\u206A\u206E\u206F\u202A\u200F\u202A\u200E\u202C\u202A\u206D\u202B\u202A\u202B\u202E(Player A_0)
		{
			return A_0.look;
		}

		// Token: 0x0600014F RID: 335 RVA: 0x000077FC File Offset: 0x000059FC
		static Transform \u206A\u206F\u200B\u200F\u206B\u200F\u206A\u200D\u200F\u202D\u206E\u200F\u202D\u202D\u206D\u206C\u202A\u206C\u202B\u200F\u200E\u200E\u206A\u202E\u206D\u206F\u200C\u206C\u202B\u202D\u202C\u202D\u206A\u202D\u206C\u206A\u200E\u202E\u206E\u206F\u202E(PlayerLook A_0)
		{
			return A_0.aim;
		}

		// Token: 0x06000150 RID: 336 RVA: 0x0000771C File Offset: 0x0000591C
		static Vector3 \u206B\u206A\u202B\u206A\u202E\u202D\u200C\u206F\u202B\u200F\u206B\u202A\u202E\u202D\u206C\u200F\u202A\u202E\u200D\u200D\u206F\u202C\u206C\u200C\u206C\u200C\u206F\u206C\u202A\u202C\u206F\u200F\u206E\u200D\u206D\u206A\u200B\u206E\u202C\u200D\u202E(Transform A_0)
		{
			return A_0.position;
		}

		// Token: 0x06000151 RID: 337 RVA: 0x00007810 File Offset: 0x00005A10
		static Vector3 \u206D\u206B\u202D\u206A\u206F\u206B\u206C\u200F\u202B\u206E\u206F\u200F\u206E\u206F\u206C\u202C\u202A\u202B\u200C\u202E\u200E\u206F\u200B\u200D\u202C\u206F\u206C\u200E\u200D\u206C\u206E\u202D\u200E\u202A\u202A\u200C\u202D\u206C\u202B\u206C\u202E(Transform A_0)
		{
			return A_0.forward;
		}

		// Token: 0x06000152 RID: 338 RVA: 0x000077BC File Offset: 0x000059BC
		static bool \u200E\u200D\u206E\u206E\u202E\u202C\u206D\u206D\u200B\u200E\u200B\u200D\u200B\u206C\u200E\u206C\u206A\u206C\u200C\u200F\u202A\u200E\u202E\u202D\u202D\u202C\u200F\u206E\u206D\u206A\u206A\u202D\u202E\u200E\u200C\u202B\u202B\u206F\u200B\u206E\u202E(Vector3 A_0, Vector3 A_1, ref RaycastHit A_2, float A_3, int A_4)
		{
			return Physics.Raycast(A_0, A_1, ref A_2, A_3, A_4);
		}

		// Token: 0x06000153 RID: 339 RVA: 0x000077D4 File Offset: 0x000059D4
		static Player \u206B\u206D\u200C\u200C\u202C\u202A\u206D\u200D\u202D\u200B\u200D\u200C\u200F\u202A\u206B\u200F\u206A\u202E\u200C\u202B\u206A\u200F\u206F\u202C\u202D\u200F\u202C\u206B\u200F\u200C\u200C\u200C\u206F\u200D\u200D\u206C\u202C\u206B\u202D\u206C\u202E(Transform A_0)
		{
			return DamageTool.getPlayer(A_0);
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00007824 File Offset: 0x00005A24
		static PlayerLife \u202A\u200E\u202C\u206F\u206D\u200E\u202D\u206C\u200B\u206C\u206D\u206B\u206F\u202D\u200C\u202C\u202B\u200E\u202A\u200C\u206B\u202E\u206D\u202B\u206E\u200E\u200C\u202D\u202D\u200D\u206F\u200B\u200E\u202D\u200B\u202B\u202D\u206E\u202C\u202B\u202E(Player A_0)
		{
			return A_0.life;
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00007838 File Offset: 0x00005A38
		static bool \u202C\u206E\u206D\u200B\u202B\u200B\u206B\u200E\u200E\u202A\u206E\u206B\u202C\u202E\u206D\u206E\u206E\u200E\u206F\u200F\u202A\u202D\u202D\u206F\u200C\u206D\u202B\u200B\u200E\u206B\u206A\u202E\u206D\u202C\u206F\u200B\u206B\u200C\u206B\u202C\u202E(PlayerLife A_0)
		{
			return A_0.isDead;
		}

		// Token: 0x04000093 RID: 147
		public bool enabled;

		// Token: 0x04000094 RID: 148
		public bool useWeaponRange = true;

		// Token: 0x04000095 RID: 149
		public float customMaxDistance = 300f;

		// Token: 0x04000096 RID: 150
		private bool bModified;

		// Token: 0x04000097 RID: 151
		private EFiremode currentFiremode = 2;
	}
}
