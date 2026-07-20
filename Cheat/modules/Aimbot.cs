using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cheat.core;
using SDG.Unturned;
using UnityEngine;

namespace Cheat.modules
{
	// Token: 0x0200000D RID: 13
	public class Aimbot : MonoBehaviour
	{
		// Token: 0x0600003F RID: 63 RVA: 0x00006210 File Offset: 0x00004410
		private void Awake()
		{
			Main main = Object.FindObjectOfType<Main>();
			this.entities = (((main != null) ? main.entities : null) ?? new Entities());
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00006240 File Offset: 0x00004440
		public void Toggle()
		{
			this.enabled = !this.enabled;
		}

		// Token: 0x06000041 RID: 65 RVA: 0x0000625C File Offset: 0x0000445C
		private void Update()
		{
			if (this.enabled)
			{
				for (;;)
				{
					IL_0B:
					uint num = 2450507517U;
					for (;;)
					{
						uint num2;
						switch ((num2 = (num ^ 3705166991U)) % 30U)
						{
						case 0U:
							num = (((!this.noFovMode) ? 685099583U : 1283464768U) ^ num2 * 1288793693U);
							continue;
						case 1U:
							num = ((!Aimbot.\u202C\u202C\u206E\u200C\u206E\u200C\u202C\u200C\u206F\u206F\u206A\u206A\u202E\u202E\u200D\u202A\u200F\u206A\u202A\u206D\u200D\u200F\u200C\u200D\u200D\u206F\u200D\u200F\u206D\u200C\u202C\u202E\u206F\u206C\u202C\u202E\u200E\u206E\u202E\u206D\u202E(this.lastValidTarget, null)) ? 3593631398U : 2909339631U);
							continue;
						case 2U:
							goto IL_0B;
						case 3U:
							this.currentTarget = null;
							num = (num2 * 2966753311U ^ 3756700385U);
							continue;
						case 4U:
							this.currentTarget = this.lastValidTarget;
							num = 2651227777U;
							continue;
						case 5U:
							num = (((!Aimbot.\u206D\u200D\u200B\u202E\u206D\u202E\u202A\u202B\u206F\u202D\u202D\u200B\u206F\u202E\u200D\u202A\u202A\u200E\u200F\u200D\u206E\u202A\u206C\u200B\u206A\u202E\u206E\u202E\u206D\u206E\u202A\u202D\u202E\u200C\u200D\u202B\u206C\u202B\u202E\u200F\u202E()) ? 4023718156U : 3758795169U) ^ num2 * 2062526236U);
							continue;
						case 6U:
							num = (((!Aimbot.\u200D\u206A\u206E\u206A\u206E\u202A\u202D\u206D\u206A\u206D\u202E\u202C\u206F\u206E\u206B\u200C\u206D\u206F\u206C\u202E\u206E\u202C\u200C\u202D\u206D\u202D\u206C\u206C\u200F\u200F\u200F\u202A\u202E\u206B\u206A\u200E\u206B\u202B\u206C\u206C\u202E(Aimbot.\u200D\u206E\u200F\u200F\u202E\u202E\u206D\u202B\u206C\u202B\u202A\u200D\u200C\u200B\u202D\u202D\u206E\u200F\u202E\u206E\u200B\u206E\u202A\u202C\u202D\u200E\u202B\u200C\u200C\u200E\u202D\u200B\u200D\u202C\u200D\u202D\u206B\u202E\u202B\u200D\u202E(), null)) ? 2794976154U : 4068119897U) ^ num2 * 3698127154U);
							continue;
						case 7U:
							this.currentTarget = this.GetBestTarget();
							num = 2836288967U;
							continue;
						case 8U:
							num = (((Aimbot.\u202B\u206E\u200D\u202D\u202E\u206A\u200B\u202B\u202B\u202E\u202B\u200F\u200D\u202C\u202D\u200C\u206A\u200D\u202C\u200C\u206B\u200B\u206C\u200F\u206F\u206E\u206F\u202D\u200C\u200C\u202D\u206F\u202D\u206F\u202E\u200C\u202B\u206D\u206D\u202E\u202E() - this.lastValidTime >= 0.45f) ? 1614799046U : 1460658873U) ^ num2 * 3111118921U);
							continue;
						case 9U:
						{
							Camera cachedCamera = Main.CachedCamera;
							bool flag = true;
							KeyCode keyAimbotHold = Main.Instance.KeyAimbotHold;
							num = (Main.Instance.AimbotHoldToAim ? 2585950461U : 3818940039U);
							continue;
						}
						case 10U:
							return;
						case 11U:
							this.toggleAiming = !this.toggleAiming;
							num = (num2 * 1387159749U ^ 2768640663U);
							continue;
						case 12U:
							return;
						case 13U:
							this.lastValidTime = 0f;
							num = (num2 * 646099404U ^ 3651805007U);
							continue;
						case 14U:
							return;
						case 15U:
							num = (((!Aimbot.\u206A\u206E\u200C\u200E\u206E\u200B\u202A\u200B\u200B\u206C\u206C\u206D\u206C\u202D\u200F\u206F\u200C\u200C\u200C\u206A\u200E\u202D\u200C\u200E\u206D\u206C\u200B\u200D\u200E\u206A\u202C\u202B\u206B\u206F\u200E\u200E\u206E\u200E\u200D\u202B\u202E()) ? 1040199411U : 1023556920U) ^ num2 * 1411596686U);
							continue;
						case 16U:
							goto IL_150;
						case 17U:
							this.currentTarget = null;
							this.lastValidTarget = null;
							num = 2302152067U;
							continue;
						case 18U:
						{
							Vector3 vector;
							num = (((Vector2.Distance(new Vector2((float)Aimbot.\u202B\u202C\u206B\u206E\u200F\u206D\u206E\u206F\u206D\u200D\u206A\u202E\u206A\u206D\u206B\u200E\u206E\u206A\u202E\u202A\u200B\u202E\u200C\u200F\u206B\u200D\u202E\u206F\u206A\u206D\u202C\u202C\u206F\u206B\u202A\u200B\u202B\u200D\u200C\u202D\u202E() / 2f, (float)Aimbot.\u206B\u200F\u202B\u200B\u200E\u200C\u206F\u200F\u206C\u200C\u202E\u206E\u206F\u200C\u202D\u202B\u206F\u200B\u202E\u206D\u206D\u206B\u202E\u206F\u202B\u202A\u200C\u202A\u200D\u206A\u206E\u206E\u202C\u202A\u202A\u200C\u200C\u206A\u200F\u206C\u202E() / 2f), new Vector2(vector.x, (float)Aimbot.\u206B\u200F\u202B\u200B\u200E\u200C\u206F\u200F\u206C\u200C\u202E\u206E\u206F\u200C\u202D\u202B\u206F\u200B\u202E\u206D\u206D\u206B\u202E\u206F\u202B\u202A\u200C\u202A\u200D\u206A\u206E\u206E\u202C\u202A\u202A\u200C\u200C\u206A\u200F\u206C\u202E() - vector.y)) > this.GetFOVScreenRadius()) ? 2015418130U : 744042879U) ^ num2 * 3792751853U);
							continue;
						}
						case 19U:
							this.currentTarget = this.lastValidTarget;
							num = 3593631398U;
							continue;
						case 20U:
						{
							KeyCode keyAimbotHold;
							bool flag = Aimbot.\u200C\u200E\u202B\u200B\u206F\u206E\u202B\u200B\u202D\u202B\u202B\u206F\u200B\u206B\u206C\u200D\u202D\u200E\u200B\u202B\u202A\u200D\u200B\u206D\u200B\u202D\u206E\u202E\u200D\u202D\u206F\u200E\u200B\u202C\u202C\u200D\u202A\u206C\u206D\u206C\u202E(keyAimbotHold);
							num = (num2 * 3886841186U ^ 2059984141U);
							continue;
						}
						case 21U:
						{
							bool flag = this.toggleAiming;
							num = 2817304392U;
							continue;
						}
						case 22U:
							num = ((Aimbot.\u202C\u202C\u206E\u200C\u206E\u200C\u202C\u200C\u206F\u206F\u206A\u206A\u202E\u202E\u200D\u202A\u200F\u206A\u202A\u206D\u200D\u200F\u200C\u200D\u200D\u206F\u200D\u200F\u206D\u200C\u202C\u202E\u206F\u206C\u202C\u202E\u200E\u206E\u202E\u206D\u202E(this.currentTarget, null) ? 736657434U : 1115262812U) ^ num2 * 197531831U);
							continue;
						case 23U:
							this.lastValidTarget = null;
							num = (num2 * 4012574751U ^ 3799709925U);
							continue;
						case 24U:
						{
							KeyCode keyAimbotHold;
							num = ((!Aimbot.\u202E\u206A\u206E\u202D\u206B\u202C\u206C\u206B\u202B\u206A\u206F\u206B\u202B\u200E\u206B\u206E\u200E\u206A\u200F\u200B\u202A\u206F\u206B\u200E\u206A\u202A\u206B\u200E\u206B\u202A\u202A\u206E\u202E\u206C\u206C\u206C\u200E\u200B\u200E\u200C\u202E(keyAimbotHold)) ? 2242567976U : 3122933820U);
							continue;
						}
						case 25U:
						{
							bool flag;
							num = ((!flag) ? 3947046012U : 2495499362U);
							continue;
						}
						case 26U:
							num = (num2 * 2337891652U ^ 981524304U);
							continue;
						case 28U:
						{
							Vector3 aimPosition = this.GetAimPosition(this.lastValidTarget);
							Camera cachedCamera;
							Vector3 vector = Aimbot.\u206C\u202C\u206D\u206B\u206D\u206A\u206B\u200F\u200B\u200F\u200F\u202D\u202E\u202E\u202E\u202D\u206A\u202C\u200B\u206C\u202C\u200B\u200F\u206D\u206A\u206D\u200F\u200F\u200B\u206F\u206A\u206D\u202A\u200F\u202D\u206C\u206B\u202D\u200E\u200E\u202E(cachedCamera, aimPosition);
							num = (((vector.z <= 0.05f) ? 3252615716U : 3685921913U) ^ num2 * 482989861U);
							continue;
						}
						case 29U:
							goto IL_2D6;
						}
						goto Block_1;
					}
				}
				Block_1:
				return;
				IL_2D6:
				this.lastValidTarget = this.currentTarget;
				this.lastTargetPosition = Aimbot.\u200D\u202C\u206F\u206E\u206E\u202A\u202A\u206E\u206F\u200F\u206F\u206A\u202C\u200C\u200D\u200B\u200B\u202D\u202E\u206F\u202E\u206D\u206D\u202D\u200F\u206A\u200D\u202D\u200C\u202D\u206E\u200D\u202A\u206B\u206A\u206B\u200F\u206D\u206F\u206E\u202E(Aimbot.\u206D\u200D\u202A\u206B\u202E\u202A\u200F\u200D\u200F\u202C\u202B\u206E\u200F\u200B\u206C\u206D\u200B\u202C\u206D\u200D\u202C\u206D\u202B\u206E\u202A\u206E\u206B\u200D\u206B\u200D\u202C\u206C\u200D\u202A\u202C\u200B\u200B\u200F\u202B\u206F\u202E(this.currentTarget));
				this.lastValidTime = Aimbot.\u202B\u206E\u200D\u202D\u202E\u206A\u200B\u202B\u202B\u202E\u202B\u200F\u200D\u202C\u202D\u200C\u206A\u200D\u202C\u200C\u206B\u200B\u206C\u200F\u206F\u206E\u206F\u202D\u200C\u200C\u202D\u206F\u202D\u206F\u202E\u200C\u202B\u206D\u206D\u202E\u202E();
				return;
			}
			IL_150:
			this.currentTarget = null;
		}

		// Token: 0x06000042 RID: 66 RVA: 0x000066C0 File Offset: 0x000048C0
		private void LateUpdate()
		{
			if (Aimbot.\u202C\u202C\u206E\u200C\u206E\u200C\u202C\u200C\u206F\u206F\u206A\u206A\u202E\u202E\u200D\u202A\u200F\u206A\u202A\u206D\u200D\u200F\u200C\u200D\u200D\u206F\u200D\u200F\u206D\u200C\u202C\u202E\u206F\u206C\u202C\u202E\u200E\u206E\u202E\u206D\u202E(this.currentTarget, null))
			{
				for (;;)
				{
					IL_0E:
					uint num = 3328321415U;
					for (;;)
					{
						uint num2;
						switch ((num2 = (num ^ 3180025450U)) % 3U)
						{
						case 1U:
							this.Aim(this.currentTarget);
							num = (num2 * 636472225U ^ 1235395091U);
							continue;
						case 2U:
							goto IL_0E;
						}
						goto Block_1;
					}
				}
				Block_1:;
			}
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00006718 File Offset: 0x00004918
		private float GetFOVScreenRadius()
		{
			Camera cachedCamera = Main.CachedCamera;
			float num3;
			for (;;)
			{
				IL_06:
				uint num = 2789845210U;
				for (;;)
				{
					uint num2;
					switch ((num2 = (num ^ 3156872862U)) % 5U)
					{
					case 0U:
						goto IL_60;
					case 2U:
						goto IL_06;
					case 3U:
						num3 = Aimbot.\u200F\u202B\u202E\u206B\u200B\u202B\u200B\u206A\u200B\u200B\u206F\u206F\u202D\u200C\u202E\u202D\u202C\u206C\u202E\u206B\u202A\u202C\u202C\u200D\u200D\u202A\u202B\u200B\u206E\u200D\u202E\u206A\u206C\u202D\u202A\u206F\u200C\u202C\u202B\u206F\u202E(cachedCamera);
						num = 3526780012U;
						continue;
					case 4U:
						num = (((!Aimbot.\u200D\u206A\u206E\u206A\u206E\u202A\u202D\u206D\u206A\u206D\u202E\u202C\u206F\u206E\u206B\u200C\u206D\u206F\u206C\u202E\u206E\u202C\u200C\u202D\u206D\u202D\u206C\u206C\u200F\u200F\u200F\u202A\u202E\u206B\u206A\u200E\u206B\u202B\u206C\u206C\u202E(cachedCamera, null)) ? 2947335077U : 2534101596U) ^ num2 * 1081770627U);
						continue;
					}
					goto Block_1;
				}
			}
			Block_1:
			goto IL_7C;
			IL_60:
			return this.fov * 11f;
			IL_7C:
			float num4 = this.fov * 0.5f * 0.017453292f;
			float num5 = num3 * 0.5f * 0.017453292f;
			return Mathf.Tan(num4) / Mathf.Tan(num5) * ((float)Aimbot.\u206B\u200F\u202B\u200B\u200E\u200C\u206F\u200F\u206C\u200C\u202E\u206E\u206F\u200C\u202D\u202B\u206F\u200B\u202E\u206D\u206D\u206B\u202E\u206F\u202B\u202A\u200C\u202A\u200D\u206A\u206E\u206E\u202C\u202A\u202A\u200C\u200C\u206A\u200F\u206C\u202E() * 0.5f);
		}

		// Token: 0x06000044 RID: 68 RVA: 0x000067DC File Offset: 0x000049DC
		private Vector3 GetAimPosition(Player target)
		{
			if (this.preferHead)
			{
				goto IL_0B;
			}
			goto IL_199;
			uint num2;
			Transform limb;
			Transform limb2;
			float num4;
			for (;;)
			{
				IL_10:
				uint num;
				float num3;
				switch ((num = (num2 ^ 1675457254U)) % 13U)
				{
				case 1U:
				{
					EPlayerStance eplayerStance;
					if (eplayerStance != 5)
					{
						num2 = (num * 2449328643U ^ 1923819581U);
						continue;
					}
					goto IL_E7;
				}
				case 2U:
					num2 = ((Aimbot.\u202C\u202C\u206E\u200C\u206E\u200C\u202C\u200C\u206F\u206F\u206A\u206A\u202E\u202E\u200D\u202A\u200F\u206A\u202A\u206D\u200D\u200F\u200C\u200D\u200D\u206F\u200D\u200F\u206D\u200C\u202C\u202E\u206F\u206C\u202C\u202E\u200E\u206E\u202E\u206D\u202E(limb, null) ? 144286755U : 725347697U) ^ num * 1149014049U);
					continue;
				case 3U:
					num3 = 0.8f;
					goto IL_FA;
				case 4U:
				{
					EPlayerStance eplayerStance = Aimbot.\u206F\u206F\u206B\u202E\u206E\u206C\u200E\u202D\u200F\u206E\u206C\u200F\u206A\u206A\u202D\u206E\u202C\u202C\u206F\u206C\u206F\u202D\u202D\u206B\u200D\u202B\u200E\u202B\u200C\u206D\u202C\u202B\u206F\u200E\u200F\u206A\u200B\u206D\u202A\u206A\u202E(Aimbot.\u206A\u202E\u202D\u200B\u206F\u202D\u200F\u202E\u200B\u206A\u202D\u206D\u206B\u202B\u206C\u202B\u206C\u206C\u206A\u202B\u206A\u202B\u206F\u206D\u206B\u206E\u206A\u206F\u206C\u206B\u202E\u202E\u202E\u200F\u206D\u206B\u202B\u200F\u202E\u206C\u202E(target));
					if (eplayerStance != 3)
					{
						num2 = (num * 1582777414U ^ 1567500987U);
						continue;
					}
					goto IL_F5;
				}
				case 5U:
					goto IL_71;
				case 6U:
					goto IL_9F;
				case 7U:
				{
					EPlayerStance eplayerStance;
					if (eplayerStance != 1)
					{
						num2 = (num * 1802504897U ^ 3286568578U);
						continue;
					}
					goto IL_E7;
				}
				case 8U:
					limb2 = Utils.GetLimb(Aimbot.\u206D\u200D\u202A\u206B\u202E\u202A\u200F\u200D\u200F\u202C\u202B\u206E\u200F\u200B\u206C\u206D\u200B\u202C\u206D\u200D\u202C\u206D\u202B\u206E\u202A\u206E\u206B\u200D\u206B\u200D\u202C\u206C\u200D\u202A\u202C\u200B\u200B\u200F\u202B\u206F\u202E(target), 13);
					num2 = (((!Aimbot.\u202C\u202C\u206E\u200C\u206E\u200C\u202C\u200C\u206F\u206F\u206A\u206A\u202E\u202E\u200D\u202A\u200F\u206A\u202A\u206D\u200D\u200F\u200C\u200D\u200D\u206F\u200D\u200F\u206D\u200C\u202C\u202E\u206F\u206C\u202C\u202E\u200E\u206E\u202E\u206D\u202E(limb2, null)) ? 1954748236U : 377698623U) ^ num * 61565280U);
					continue;
				case 9U:
				{
					EPlayerStance eplayerStance;
					if (eplayerStance != 4)
					{
						num2 = (num * 1889810364U ^ 2442148908U);
						continue;
					}
					num3 = 0.75f;
					goto IL_FA;
				}
				case 10U:
				{
					EPlayerStance eplayerStance;
					if (eplayerStance != 2)
					{
						num2 = (num * 791809660U ^ 849108132U);
						continue;
					}
					goto IL_F5;
				}
				case 11U:
					goto IL_199;
				case 12U:
					goto IL_0B;
				}
				break;
				IL_FA:
				num4 = num3;
				num2 = 2010135158U;
				continue;
				IL_E7:
				num3 = 0.15f;
				goto IL_FA;
				IL_F5:
				num3 = 1f;
				goto IL_FA;
			}
			goto IL_1CB;
			IL_71:
			return Aimbot.\u200D\u202C\u206F\u206E\u206E\u202A\u202A\u206E\u206F\u200F\u206F\u206A\u202C\u200C\u200D\u200B\u200B\u202D\u202E\u206F\u202E\u206D\u206D\u202D\u200F\u206A\u200D\u202D\u200C\u202D\u206E\u200D\u202A\u206B\u206A\u206B\u200F\u206D\u206F\u206E\u202E(limb2) + Vector3.up * 0.22f;
			IL_9F:
			return Aimbot.\u200D\u202C\u206F\u206E\u206E\u202A\u202A\u206E\u206F\u200F\u206F\u206A\u202C\u200C\u200D\u200B\u200B\u202D\u202E\u206F\u202E\u206D\u206D\u202D\u200F\u206A\u200D\u202D\u200C\u202D\u206E\u200D\u202A\u206B\u206A\u206B\u200F\u206D\u206F\u206E\u202E(limb) + Vector3.up * num4;
			IL_1CB:
			return Aimbot.\u200D\u202C\u206F\u206E\u206E\u202A\u202A\u206E\u206F\u200F\u206F\u206A\u202C\u200C\u200D\u200B\u200B\u202D\u202E\u206F\u202E\u206D\u206D\u202D\u200F\u206A\u200D\u202D\u200C\u202D\u206E\u200D\u202A\u206B\u206A\u206B\u200F\u206D\u206F\u206E\u202E(Aimbot.\u206D\u200D\u202A\u206B\u202E\u202A\u200F\u200D\u200F\u202C\u202B\u206E\u200F\u200B\u206C\u206D\u200B\u202C\u206D\u200D\u202C\u206D\u202B\u206E\u202A\u206E\u206B\u200D\u206B\u200D\u202C\u206C\u200D\u202A\u202C\u200B\u200B\u200F\u202B\u206F\u202E(target)) + Vector3.up * 1.4f;
			IL_0B:
			num2 = 147225053U;
			goto IL_10;
			IL_199:
			limb = Utils.GetLimb(Aimbot.\u206D\u200D\u202A\u206B\u202E\u202A\u200F\u200D\u200F\u202C\u202B\u206E\u200F\u200B\u206C\u206D\u200B\u202C\u206D\u200D\u202C\u206D\u202B\u206E\u202A\u206E\u206B\u200D\u206B\u200D\u202C\u206C\u200D\u202A\u202C\u200B\u200B\u200F\u202B\u206F\u202E(target), 12);
			num2 = 447324181U;
			goto IL_10;
		}

		// Token: 0x06000045 RID: 69 RVA: 0x000069D4 File Offset: 0x00004BD4
		private bool IsVisible(Vector3 from, Vector3 to, Player target)
		{
			Vector3 vector = to - from;
			for (;;)
			{
				IL_08:
				uint num = 3291609058U;
				for (;;)
				{
					uint num2;
					switch ((num2 = (num ^ 3098463225U)) % 9U)
					{
					case 0U:
					{
						Vector3 normalized;
						RaycastHit raycastHit;
						float num3;
						num = (Aimbot.\u202A\u200B\u202D\u202D\u200F\u202C\u200F\u202B\u202A\u206C\u206D\u202A\u200E\u206C\u200B\u206A\u200C\u200E\u206D\u200D\u206A\u202A\u206A\u200B\u200D\u206F\u200B\u200C\u202E\u202A\u202E\u206F\u206F\u206D\u200D\u200F\u206A\u206A\u206B\u202E\u202E(from + Vector3.up * 0.03f, normalized, ref raycastHit, num3 + 0.4f, RayMasks.DAMAGE_CLIENT) ? 3449731088U : 3674199067U);
						continue;
					}
					case 1U:
					{
						Vector3 normalized = vector.normalized;
						num = (num2 * 3349138664U ^ 4084938420U);
						continue;
					}
					case 2U:
						goto IL_08;
					case 3U:
					{
						RaycastHit raycastHit;
						num = ((Aimbot.\u200D\u206A\u206E\u206A\u206E\u202A\u202D\u206D\u206A\u206D\u202E\u202C\u206F\u206E\u206B\u200C\u206D\u206F\u206C\u202E\u206E\u202C\u200C\u202D\u206D\u202D\u206C\u206C\u200F\u200F\u200F\u202A\u202E\u206B\u206A\u200E\u206B\u202B\u206C\u206C\u202E(Aimbot.\u200C\u200C\u206F\u206A\u206B\u206E\u206C\u200C\u200D\u206D\u200B\u202A\u202B\u206E\u206C\u200D\u200E\u206D\u206E\u200C\u200E\u200C\u206B\u206D\u200C\u206E\u202A\u206E\u206A\u202B\u200E\u200D\u206D\u200B\u202E\u206C\u206B\u206E\u206B\u206C\u202E(raycastHit.transform), target) ? 1766768772U : 35370205U) ^ num2 * 1145445590U);
						continue;
					}
					case 4U:
						return true;
					case 5U:
					{
						float num3 = Vector3.Distance(from, to);
						Vector3 normalized;
						RaycastHit raycastHit;
						num = ((Aimbot.\u202A\u200B\u202D\u202D\u200F\u202C\u200F\u202B\u202A\u206C\u206D\u202A\u200E\u206C\u200B\u206A\u200C\u200E\u206D\u200D\u206A\u202A\u206A\u200B\u200D\u206F\u200B\u200C\u202E\u202A\u202E\u206F\u206F\u206D\u200D\u200F\u206A\u206A\u206B\u202E\u202E(from + Vector3.up * 0.08f, normalized, ref raycastHit, num3 + 0.4f, RayMasks.DAMAGE_CLIENT) ? 4010820464U : 4012966127U) ^ num2 * 2786618579U);
						continue;
					}
					case 6U:
					{
						RaycastHit raycastHit;
						num = (((!Aimbot.\u200D\u206A\u206E\u206A\u206E\u202A\u202D\u206D\u206A\u206D\u202E\u202C\u206F\u206E\u206B\u200C\u206D\u206F\u206C\u202E\u206E\u202C\u200C\u202D\u206D\u202D\u206C\u206C\u200F\u200F\u200F\u202A\u202E\u206B\u206A\u200E\u206B\u202B\u206C\u206C\u202E(Aimbot.\u200C\u200C\u206F\u206A\u206B\u206E\u206C\u200C\u200D\u206D\u200B\u202A\u202B\u206E\u206C\u200D\u200E\u206D\u206E\u200C\u200E\u200C\u206B\u206D\u200C\u206E\u202A\u206E\u206A\u202B\u200E\u200D\u206D\u200B\u202E\u206C\u206B\u206E\u206B\u206C\u202E(raycastHit.transform), target)) ? 1368534388U : 742450382U) ^ num2 * 1684124478U);
						continue;
					}
					case 8U:
						return true;
					}
					goto Block_1;
				}
			}
			Block_1:
			return false;
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00006B5C File Offset: 0x00004D5C
		private Player GetBestTarget()
		{
			Camera cachedCamera = Main.CachedCamera;
			float num3;
			Vector3 vector;
			Vector3 vector2;
			Vector2 vector3;
			float fovscreenRadius;
			Player result;
			float num4;
			for (;;)
			{
				IL_06:
				uint num = 1453642689U;
				for (;;)
				{
					uint num2;
					float gunRange;
					switch ((num2 = (num ^ 184194818U)) % 7U)
					{
					case 0U:
						num3 = float.MaxValue;
						num = (num2 * 3368234340U ^ 1787328469U);
						continue;
					case 1U:
						gunRange = this.customMaxDistance;
						goto IL_61;
					case 2U:
						goto IL_06;
					case 3U:
						vector = Aimbot.\u200D\u202C\u206F\u206E\u206E\u202A\u202A\u206E\u206F\u200F\u206F\u206A\u202C\u200C\u200D\u200B\u200B\u202D\u202E\u206F\u202E\u206D\u206D\u202D\u200F\u206A\u200D\u202D\u200C\u202D\u206E\u200D\u202A\u206B\u206A\u206B\u200F\u206D\u206F\u206E\u202E(Aimbot.\u206D\u206D\u206B\u206D\u202B\u206F\u200B\u200F\u206F\u202B\u202A\u206C\u202B\u200F\u200F\u200C\u200D\u200F\u202E\u202A\u202A\u200D\u200C\u202A\u206D\u206C\u206B\u202A\u206C\u200C\u200D\u206E\u202A\u206F\u206C\u200C\u206A\u206C\u202D\u206D\u202E(Aimbot.\u202B\u206C\u202D\u200C\u202E\u200C\u200C\u200D\u200C\u202D\u202D\u200F\u200F\u206E\u202B\u206E\u202C\u202D\u200B\u206A\u200F\u206D\u202A\u200D\u206C\u202B\u202B\u202C\u202D\u200F\u200C\u202E\u206C\u206F\u206A\u202B\u200D\u206F\u202A\u202D\u202E(Aimbot.\u200D\u206E\u200F\u200F\u202E\u202E\u206D\u202B\u206C\u202B\u202A\u200D\u200C\u200B\u202D\u202D\u206E\u200F\u202E\u206E\u200B\u206E\u202A\u202C\u202D\u200E\u202B\u200C\u200C\u200E\u202D\u200B\u200D\u202C\u200D\u202D\u206B\u202E\u202B\u200D\u202E())));
						vector2 = Aimbot.\u206A\u200B\u206C\u202B\u200D\u202C\u200B\u206A\u206B\u202E\u200D\u206A\u200C\u206C\u206A\u200D\u202C\u206C\u206A\u202A\u200E\u206D\u200C\u200C\u206C\u202A\u200D\u202E\u200F\u202A\u202A\u206E\u206E\u206C\u206E\u206D\u202E\u202A\u206B\u206E\u202E(Aimbot.\u206D\u206D\u206B\u206D\u202B\u206F\u200B\u200F\u206F\u202B\u202A\u206C\u202B\u200F\u200F\u200C\u200D\u200F\u202E\u202A\u202A\u200D\u200C\u202A\u206D\u206C\u206B\u202A\u206C\u200C\u200D\u206E\u202A\u206F\u206C\u200C\u206A\u206C\u202D\u206D\u202E(Aimbot.\u202B\u206C\u202D\u200C\u202E\u200C\u200C\u200D\u200C\u202D\u202D\u200F\u200F\u206E\u202B\u206E\u202C\u202D\u200B\u206A\u200F\u206D\u202A\u200D\u206C\u202B\u202B\u202C\u202D\u200F\u200C\u202E\u206C\u206F\u206A\u202B\u200D\u206F\u202A\u202D\u202E(Aimbot.\u200D\u206E\u200F\u200F\u202E\u202E\u206D\u202B\u206C\u202B\u202A\u200D\u200C\u200B\u202D\u202D\u206E\u200F\u202E\u206E\u200B\u206E\u202A\u202C\u202D\u200E\u202B\u200C\u200C\u200E\u202D\u200B\u200D\u202C\u200D\u202D\u206B\u202E\u202B\u200D\u202E())));
						vector3..ctor((float)Aimbot.\u202B\u202C\u206B\u206E\u200F\u206D\u206E\u206F\u206D\u200D\u206A\u202E\u206A\u206D\u206B\u200E\u206E\u206A\u202E\u202A\u200B\u202E\u200C\u200F\u206B\u200D\u202E\u206F\u206A\u206D\u202C\u202C\u206F\u206B\u202A\u200B\u202B\u200D\u200C\u202D\u202E() / 2f, (float)Aimbot.\u206B\u200F\u202B\u200B\u200E\u200C\u206F\u200F\u206C\u200C\u202E\u206E\u206F\u200C\u202D\u202B\u206F\u200B\u202E\u206D\u206D\u206B\u202E\u206F\u202B\u202A\u200C\u202A\u200D\u206A\u206E\u206E\u202C\u202A\u202A\u200C\u200C\u206A\u200F\u206C\u202E() / 2f);
						fovscreenRadius = this.GetFOVScreenRadius();
						num = (num2 * 501504842U ^ 2612548151U);
						continue;
					case 4U:
						if (!this.useWeaponRange)
						{
							num = (num2 * 1550706014U ^ 3302816975U);
							continue;
						}
						gunRange = Utils.GetGunRange();
						goto IL_61;
					case 5U:
						result = null;
						num = (num2 * 731395012U ^ 1022735730U);
						continue;
					}
					goto Block_1;
					IL_61:
					num4 = gunRange;
					num = 156767671U;
				}
			}
			Block_1:
			using (List<Player>.Enumerator enumerator = this.entities.Players.GetEnumerator())
			{
				for (;;)
				{
					IL_319:
					uint num5 = (!enumerator.MoveNext()) ? 1081672876U : 1456865103U;
					for (;;)
					{
						uint num2;
						switch ((num2 = (num5 ^ 184194818U)) % 23U)
						{
						case 0U:
						{
							Player player;
							result = player;
							num5 = (num2 * 2615124252U ^ 3992671485U);
							continue;
						}
						case 1U:
						{
							Player player;
							num5 = ((Utils.IsFriendly(player) ? 438159874U : 2033263527U) ^ num2 * 2782053549U);
							continue;
						}
						case 2U:
						{
							float num7;
							float num6 = num7 * 0.75f;
							num5 = ((!this.noFovMode) ? 1236133186U : 32428016U);
							continue;
						}
						case 3U:
						{
							Vector3 vector4;
							num5 = (((vector4.z > 0.05f) ? 2526360393U : 2582334619U) ^ num2 * 3689348250U);
							continue;
						}
						case 4U:
						{
							Player player;
							num5 = ((Aimbot.\u206C\u206E\u202E\u200F\u206E\u200F\u202A\u206C\u202B\u202A\u200D\u200E\u202A\u202A\u200C\u202D\u206B\u200E\u200E\u206C\u206A\u202A\u200C\u202D\u206A\u200D\u200D\u200C\u202C\u202D\u202A\u202A\u200C\u202E\u206C\u202E\u200B\u202A\u202D\u206D\u202E(Aimbot.\u200B\u206C\u200B\u200B\u200F\u206E\u200D\u200F\u206B\u202B\u200D\u200F\u206E\u200C\u206F\u200E\u202D\u206A\u202D\u202B\u202C\u202D\u202D\u202D\u202C\u206D\u206C\u206E\u206D\u202B\u206D\u206E\u206E\u200C\u206A\u206D\u206C\u202A\u200F\u206A\u202E(player)) ? 2250765049U : 3525044117U) ^ num2 * 1775119470U);
							continue;
						}
						case 5U:
						{
							Player player;
							Vector3 aimPosition;
							num5 = (((!this.IsVisible(vector, aimPosition, player)) ? 2640629788U : 2669074077U) ^ num2 * 1395709281U);
							continue;
						}
						case 6U:
						{
							Player player;
							num5 = ((Aimbot.\u200D\u206A\u206E\u206A\u206E\u202A\u202D\u206D\u206A\u206D\u202E\u202C\u206F\u206E\u206B\u200C\u206D\u206F\u206C\u202E\u206E\u202C\u200C\u202D\u206D\u202D\u206C\u206C\u200F\u200F\u200F\u202A\u202E\u206B\u206A\u200E\u206B\u202B\u206C\u206C\u202E(player, Aimbot.\u200D\u206E\u200F\u200F\u202E\u202E\u206D\u202B\u206C\u202B\u202A\u200D\u200C\u200B\u202D\u202D\u206E\u200F\u202E\u206E\u200B\u206E\u202A\u202C\u202D\u200E\u202B\u200C\u200C\u200E\u202D\u200B\u200D\u202C\u200D\u202D\u206B\u202E\u202B\u200D\u202E()) ? 510747760U : 1641532031U) ^ num2 * 2626782721U);
							continue;
						}
						case 7U:
						{
							Player player = enumerator.Current;
							num5 = 1691493804U;
							continue;
						}
						case 8U:
						{
							Vector3 aimPosition;
							Vector3 normalized = (aimPosition - vector).normalized;
							num5 = (num2 * 134608578U ^ 1359534390U);
							continue;
						}
						case 9U:
						{
							Player player;
							Vector3 aimPosition = this.GetAimPosition(player);
							num5 = (((!this.useVisibleCheck) ? 3022381654U : 2835885481U) ^ num2 * 437459577U);
							continue;
						}
						case 10U:
							num5 = 1456865103U;
							continue;
						case 11U:
						{
							float num7;
							num5 = (((num7 > num4) ? 2540709555U : 3910486502U) ^ num2 * 664115459U);
							continue;
						}
						case 12U:
						{
							Player player;
							float num7 = this.entities.DistanceToLocal(Aimbot.\u200D\u202C\u206F\u206E\u206E\u202A\u202A\u206E\u206F\u200F\u206F\u206A\u202C\u200C\u200D\u200B\u200B\u202D\u202E\u206F\u202E\u206D\u206D\u202D\u200F\u206A\u200D\u202D\u200C\u202D\u206E\u200D\u202A\u206B\u206A\u206B\u200F\u206D\u206F\u206E\u202E(Aimbot.\u206D\u200D\u202A\u206B\u202E\u202A\u200F\u200D\u200F\u202C\u202B\u206E\u200F\u200B\u206C\u206D\u200B\u202C\u206D\u200D\u202C\u206D\u202B\u206E\u202A\u206E\u206B\u200D\u206B\u200D\u202C\u206C\u200D\u202A\u202C\u200B\u200B\u200F\u202B\u206F\u202E(player)));
							num5 = 484154580U;
							continue;
						}
						case 13U:
						{
							Player player;
							num5 = ((Aimbot.\u200D\u206A\u206E\u206A\u206E\u202A\u202D\u206D\u206A\u206D\u202E\u202C\u206F\u206E\u206B\u200C\u206D\u206F\u206C\u202E\u206E\u202C\u200C\u202D\u206D\u202D\u206C\u206C\u200F\u200F\u200F\u202A\u202E\u206B\u206A\u200E\u206B\u202B\u206C\u206C\u202E(player, null) ? 785763995U : 1705980905U) ^ num2 * 219983795U);
							continue;
						}
						case 14U:
						{
							Vector2 vector5;
							num5 = (((Vector2.Distance(vector3, vector5) <= fovscreenRadius) ? 1876211837U : 508001941U) ^ num2 * 336524882U);
							continue;
						}
						case 15U:
							num5 = ((this.noFovMode ? 2417255533U : 2834098232U) ^ num2 * 829147326U);
							continue;
						case 16U:
						{
							float num6;
							num3 = num6;
							num5 = (num2 * 1221478714U ^ 871728365U);
							continue;
						}
						case 17U:
						{
							float num6;
							num5 = ((num6 >= num3) ? 393490225U : 46252595U);
							continue;
						}
						case 18U:
						{
							Vector3 vector4;
							Vector2 vector5;
							vector5..ctor(vector4.x, (float)Aimbot.\u206B\u200F\u202B\u200B\u200E\u200C\u206F\u200F\u206C\u200C\u202E\u206E\u206F\u200C\u202D\u202B\u206F\u200B\u202E\u206D\u206D\u206B\u202E\u206F\u202B\u202A\u200C\u202A\u200D\u206A\u206E\u206E\u202C\u202A\u202A\u200C\u200C\u206A\u200F\u206C\u202E() - vector4.y);
							num5 = (num2 * 4043963371U ^ 1486188299U);
							continue;
						}
						case 19U:
							goto IL_319;
						case 21U:
						{
							float num6;
							Vector3 normalized;
							num6 += Vector3.Angle(vector2, normalized) * 1.8f;
							num5 = (num2 * 3013155333U ^ 2274804340U);
							continue;
						}
						case 22U:
						{
							Vector3 aimPosition;
							Vector3 vector4 = Aimbot.\u206C\u202C\u206D\u206B\u206D\u206A\u206B\u200F\u200B\u200F\u200F\u202D\u202E\u202E\u202E\u202D\u206A\u202C\u200B\u206C\u202C\u200B\u200F\u206D\u206A\u206D\u200F\u200F\u200B\u206F\u206A\u206D\u202A\u200F\u202D\u206C\u206B\u202D\u200E\u200E\u202E(cachedCamera, aimPosition);
							num5 = (num2 * 2388515148U ^ 789045891U);
							continue;
						}
						}
						goto Block_5;
					}
				}
				Block_5:;
			}
			return result;
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00007010 File Offset: 0x00005210
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Aim(Player target)
		{
			Component cachedCamera = Main.CachedCamera;
			Vector3 aimPosition = this.GetAimPosition(target);
			Vector3 vector = Aimbot.\u200D\u202C\u206F\u206E\u206E\u202A\u202A\u206E\u206F\u200F\u206F\u206A\u202C\u200C\u200D\u200B\u200B\u202D\u202E\u206F\u202E\u206D\u206D\u202D\u200F\u206A\u200D\u202D\u200C\u202D\u206E\u200D\u202A\u206B\u206A\u206B\u200F\u206D\u206F\u206E\u202E(Aimbot.\u206D\u200D\u202A\u206B\u202E\u202A\u200F\u200D\u200F\u202C\u202B\u206E\u200F\u200B\u206C\u206D\u200B\u202C\u206D\u200D\u202C\u206D\u202B\u206E\u202A\u206E\u206B\u200D\u206B\u200D\u202C\u206C\u200D\u202A\u202C\u200B\u200B\u200F\u202B\u206F\u202E(target)) - this.lastTargetPosition;
			Vector3 vector2 = Vector3.zero;
			if (this.usePrediction)
			{
				vector2 += vector * this.entities.DistanceToLocal(Aimbot.\u200D\u202C\u206F\u206E\u206E\u202A\u202A\u206E\u206F\u200F\u206F\u206A\u202C\u200C\u200D\u200B\u200B\u202D\u202E\u206F\u202E\u206D\u206D\u202D\u200F\u206A\u200D\u202D\u200C\u202D\u206E\u200D\u202A\u206B\u206A\u206B\u200F\u206D\u206F\u206E\u202E(Aimbot.\u206D\u200D\u202A\u206B\u202E\u202A\u200F\u200D\u200F\u202C\u202B\u206E\u200F\u200B\u206C\u206D\u200B\u202C\u206D\u200D\u202C\u206D\u202B\u206E\u202A\u206E\u206B\u200D\u206B\u200D\u202C\u206C\u200D\u202A\u202C\u200B\u200B\u200F\u202B\u206F\u202E(target))) / (this.CalcPrediction() / this.predictionFactor);
			}
			if (this.useBallisticPrediction)
			{
				vector2 -= Aimbot.\u202A\u202D\u202D\u202A\u206F\u206A\u200B\u200D\u206A\u200D\u200E\u202D\u206B\u202B\u202C\u206C\u206A\u206A\u200C\u206A\u202B\u200D\u200B\u200D\u200E\u202A\u202E\u206C\u206E\u202A\u200E\u206A\u206F\u200B\u202C\u206D\u200D\u206A\u200F\u200C\u202E() * 0.018f * this.entities.DistanceToLocal(Aimbot.\u200D\u202C\u206F\u206E\u206E\u202A\u202A\u206E\u206F\u200F\u206F\u206A\u202C\u200C\u200D\u200B\u200B\u202D\u202E\u206F\u202E\u206D\u206D\u202D\u200F\u206A\u200D\u202D\u200C\u202D\u206E\u200D\u202A\u206B\u206A\u206B\u200F\u206D\u206F\u206E\u202E(Aimbot.\u206D\u200D\u202A\u206B\u202E\u202A\u200F\u200D\u200F\u202C\u202B\u206E\u200F\u200B\u206C\u206D\u200B\u202C\u206D\u200D\u202C\u206D\u202B\u206E\u202A\u206E\u206B\u200D\u206B\u200D\u202C\u206C\u200D\u202A\u202C\u200B\u200B\u200F\u202B\u206F\u202E(target))) / (this.CalcBallistics() * this.ballisticFactor);
			}
			Vector3 playerPos = Aimbot.\u200D\u202C\u206F\u206E\u206E\u202A\u202A\u206E\u206F\u200F\u206F\u206A\u202C\u200C\u200D\u200B\u200B\u202D\u202E\u206F\u202E\u206D\u206D\u202D\u200F\u206A\u200D\u202D\u200C\u202D\u206E\u200D\u202A\u206B\u206A\u206B\u200F\u206D\u206F\u206E\u202E(Aimbot.\u206D\u200D\u202A\u206B\u202E\u202A\u200F\u200D\u200F\u202C\u202B\u206E\u200F\u200B\u206C\u206D\u200B\u202C\u206D\u200D\u202C\u206D\u202B\u206E\u202A\u206E\u206B\u200D\u206B\u200D\u202C\u206C\u200D\u202A\u202C\u200B\u200B\u200F\u202B\u206F\u202E(cachedCamera));
			Vector3 targetPos = aimPosition + vector2;
			Vector2 vector3 = Utils.CalcAngles(playerPos, targetPos);
			for (;;)
			{
				IL_CC:
				uint num = 4263621950U;
				for (;;)
				{
					uint num2;
					switch ((num2 = (num ^ 2719484672U)) % 10U)
					{
					case 0U:
						return;
					case 1U:
					{
						float num3 = Mathf.LerpAngle(num3, vector3.x, Aimbot.\u206E\u202E\u206F\u200E\u206B\u202B\u200E\u200D\u200B\u206D\u200F\u206E\u200E\u202C\u206C\u202E\u200D\u200F\u206D\u202D\u202A\u206C\u200C\u206C\u206A\u202A\u200C\u206B\u206D\u202C\u202B\u202E\u200D\u202E\u200C\u206D\u206C\u202C\u200C\u206D\u202E() * this.smoothFactor);
						num = (num2 * 3392251027U ^ 1305819590U);
						continue;
					}
					case 2U:
					{
						float num4 = (float)Aimbot.\u206E\u200B\u202D\u200C\u200E\u200C\u200D\u202C\u206F\u206E\u202A\u206D\u206C\u200F\u202E\u206F\u206D\u206E\u202A\u206B\u202A\u206B\u202A\u206D\u200E\u200F\u200D\u202C\u202E\u202A\u200F\u206C\u200D\u202A\u202A\u202B\u200E\u206D\u206B\u206E\u202E(Aimbot.\u200B\u206A\u200D\u206F\u206B\u202A\u200E\u202C\u206E\u202D\u206C\u202E\u200F\u200F\u200B\u206D\u206E\u200D\u206E\u206D\u206F\u202C\u206F\u200C\u200C\u200C\u206F\u206C\u202C\u200D\u206B\u206A\u206D\u206C\u206E\u200E\u200C\u200E\u200B\u202C\u202E(Aimbot.\u206C\u200C\u202C\u206F\u206E\u202A\u202C\u202A\u200B\u200F\u200D\u206B\u202B\u200E\u206F\u200F\u200C\u202C\u206D\u206A\u202E\u200E\u202A\u206A\u206A\u200E\u200F\u206D\u206D\u200F\u202B\u202A\u206D\u206D\u202C\u206A\u200E\u202C\u202B\u206D\u202E(typeof(PlayerLook).TypeHandle), <Module>.\u200F\u206F\u200E\u202A\u200D\u200C\u206A\u200E\u202E\u202C\u200D\u202D\u200D\u202B\u200F\u200C\u200F\u200D\u206B\u206D\u206E\u202A\u206C\u206B\u200B\u200F\u206D\u206A\u202E\u206C\u206F\u206A\u200C\u200C\u206C\u202A\u206F\u206A\u202D\u206E\u202E<string>(333930460), BindingFlags.Instance | BindingFlags.NonPublic), Aimbot.\u202B\u206C\u202D\u200C\u202E\u200C\u200C\u200D\u200C\u202D\u202D\u200F\u200F\u206E\u202B\u206E\u202C\u202D\u200B\u206A\u200F\u206D\u202A\u200D\u206C\u202B\u202B\u202C\u202D\u200F\u200C\u202E\u206C\u206F\u206A\u202B\u200D\u206F\u202A\u202D\u202E(Aimbot.\u200D\u206E\u200F\u200F\u202E\u202E\u206D\u202B\u206C\u202B\u202A\u200D\u200C\u200B\u202D\u202D\u206E\u200F\u202E\u206E\u200B\u206E\u202A\u202C\u202D\u200E\u202B\u200C\u200C\u200E\u202D\u200B\u200D\u202C\u200D\u202D\u206B\u202E\u202B\u200D\u202E()));
						num = 3143792075U;
						continue;
					}
					case 3U:
					{
						float num4 = Mathf.LerpAngle(num4, vector3.y, Aimbot.\u206E\u202E\u206F\u200E\u206B\u202B\u200E\u200D\u200B\u206D\u200F\u206E\u200E\u202C\u206C\u202E\u200D\u200F\u206D\u202D\u202A\u206C\u200C\u206C\u206A\u202A\u200C\u206B\u206D\u202C\u202B\u202E\u200D\u202E\u200C\u206D\u206C\u202C\u200C\u206D\u202E() * this.smoothFactor);
						num = (num2 * 2143536381U ^ 4213671334U);
						continue;
					}
					case 4U:
					{
						float num3 = (float)Aimbot.\u206E\u200B\u202D\u200C\u200E\u200C\u200D\u202C\u206F\u206E\u202A\u206D\u206C\u200F\u202E\u206F\u206D\u206E\u202A\u206B\u202A\u206B\u202A\u206D\u200E\u200F\u200D\u202C\u202E\u202A\u200F\u206C\u200D\u202A\u202A\u202B\u200E\u206D\u206B\u206E\u202E(Aimbot.\u200B\u206A\u200D\u206F\u206B\u202A\u200E\u202C\u206E\u202D\u206C\u202E\u200F\u200F\u200B\u206D\u206E\u200D\u206E\u206D\u206F\u202C\u206F\u200C\u200C\u200C\u206F\u206C\u202C\u200D\u206B\u206A\u206D\u206C\u206E\u200E\u200C\u200E\u200B\u202C\u202E(Aimbot.\u206C\u200C\u202C\u206F\u206E\u202A\u202C\u202A\u200B\u200F\u200D\u206B\u202B\u200E\u206F\u200F\u200C\u202C\u206D\u206A\u202E\u200E\u202A\u206A\u206A\u200E\u200F\u206D\u206D\u200F\u202B\u202A\u206D\u206D\u202C\u206A\u200E\u202C\u202B\u206D\u202E(typeof(PlayerLook).TypeHandle), <Module>.\u200F\u206F\u200E\u202A\u200D\u200C\u206A\u200E\u202E\u202C\u200D\u202D\u200D\u202B\u200F\u200C\u200F\u200D\u206B\u206D\u206E\u202A\u206C\u206B\u200B\u200F\u206D\u206A\u202E\u206C\u206F\u206A\u200C\u200C\u206C\u202A\u206F\u206A\u202D\u206E\u202E<string>(-1247674634), BindingFlags.Instance | BindingFlags.NonPublic), Aimbot.\u202B\u206C\u202D\u200C\u202E\u200C\u200C\u200D\u200C\u202D\u202D\u200F\u200F\u206E\u202B\u206E\u202C\u202D\u200B\u206A\u200F\u206D\u202A\u200D\u206C\u202B\u202B\u202C\u202D\u200F\u200C\u202E\u206C\u206F\u206A\u202B\u200D\u206F\u202A\u202D\u202E(Aimbot.\u200D\u206E\u200F\u200F\u202E\u202E\u206D\u202B\u206C\u202B\u202A\u200D\u200C\u200B\u202D\u202D\u206E\u200F\u202E\u206E\u200B\u206E\u202A\u202C\u202D\u200E\u202B\u200C\u200C\u200E\u202D\u200B\u200D\u202C\u200D\u202D\u206B\u202E\u202B\u200D\u202E()));
						num = 3817030834U;
						continue;
					}
					case 5U:
					{
						float num3;
						Aimbot.\u200D\u202D\u206D\u202D\u202D\u200E\u200D\u200C\u200E\u206E\u206C\u206D\u206F\u206C\u206C\u200F\u202D\u206E\u206E\u206D\u202B\u200F\u206C\u202C\u202C\u206E\u206D\u202D\u202D\u206A\u202B\u200D\u200B\u202B\u202D\u206C\u200C\u200E\u200B\u200E\u202E(Aimbot.\u200B\u206A\u200D\u206F\u206B\u202A\u200E\u202C\u206E\u202D\u206C\u202E\u200F\u200F\u200B\u206D\u206E\u200D\u206E\u206D\u206F\u202C\u206F\u200C\u200C\u200C\u206F\u206C\u202C\u200D\u206B\u206A\u206D\u206C\u206E\u200E\u200C\u200E\u200B\u202C\u202E(Aimbot.\u206C\u200C\u202C\u206F\u206E\u202A\u202C\u202A\u200B\u200F\u200D\u206B\u202B\u200E\u206F\u200F\u200C\u202C\u206D\u206A\u202E\u200E\u202A\u206A\u206A\u200E\u200F\u206D\u206D\u200F\u202B\u202A\u206D\u206D\u202C\u206A\u200E\u202C\u202B\u206D\u202E(typeof(PlayerLook).TypeHandle), <Module>.\u202E\u206C\u206E\u202C\u202D\u202D\u206D\u206B\u202B\u206F\u200B\u206E\u200B\u202C\u202A\u200D\u202D\u200B\u202D\u202E\u200D\u206F\u206C\u202C\u200B\u202C\u206D\u202B\u206C\u206E\u200E\u206A\u200D\u206F\u200E\u206E\u206A\u200C\u200D\u206B\u202E<string>(1473748254), BindingFlags.Instance | BindingFlags.NonPublic), Aimbot.\u202B\u206C\u202D\u200C\u202E\u200C\u200C\u200D\u200C\u202D\u202D\u200F\u200F\u206E\u202B\u206E\u202C\u202D\u200B\u206A\u200F\u206D\u202A\u200D\u206C\u202B\u202B\u202C\u202D\u200F\u200C\u202E\u206C\u206F\u206A\u202B\u200D\u206F\u202A\u202D\u202E(Aimbot.\u200D\u206E\u200F\u200F\u202E\u202E\u206D\u202B\u206C\u202B\u202A\u200D\u200C\u200B\u202D\u202D\u206E\u200F\u202E\u206E\u200B\u206E\u202A\u202C\u202D\u200E\u202B\u200C\u200C\u200E\u202D\u200B\u200D\u202C\u200D\u202D\u206B\u202E\u202B\u200D\u202E()), num3);
						num = 4126912544U;
						continue;
					}
					case 6U:
						num = (((!this.smooth) ? 1591271845U : 1679923470U) ^ num2 * 1196860440U);
						continue;
					case 8U:
					{
						float num4;
						Aimbot.\u200D\u202D\u206D\u202D\u202D\u200E\u200D\u200C\u200E\u206E\u206C\u206D\u206F\u206C\u206C\u200F\u202D\u206E\u206E\u206D\u202B\u200F\u206C\u202C\u202C\u206E\u206D\u202D\u202D\u206A\u202B\u200D\u200B\u202B\u202D\u206C\u200C\u200E\u200B\u200E\u202E(Aimbot.\u200B\u206A\u200D\u206F\u206B\u202A\u200E\u202C\u206E\u202D\u206C\u202E\u200F\u200F\u200B\u206D\u206E\u200D\u206E\u206D\u206F\u202C\u206F\u200C\u200C\u200C\u206F\u206C\u202C\u200D\u206B\u206A\u206D\u206C\u206E\u200E\u200C\u200E\u200B\u202C\u202E(Aimbot.\u206C\u200C\u202C\u206F\u206E\u202A\u202C\u202A\u200B\u200F\u200D\u206B\u202B\u200E\u206F\u200F\u200C\u202C\u206D\u206A\u202E\u200E\u202A\u206A\u206A\u200E\u200F\u206D\u206D\u200F\u202B\u202A\u206D\u206D\u202C\u206A\u200E\u202C\u202B\u206D\u202E(typeof(PlayerLook).TypeHandle), <Module>.\u206A\u202C\u206A\u206C\u202A\u206F\u200B\u206C\u206C\u206B\u206F\u206C\u200C\u206D\u200C\u200C\u206C\u206A\u202A\u206B\u200B\u202E\u200C\u206E\u202D\u202A\u200E\u202D\u200E\u200E\u200D\u200E\u202B\u202A\u206E\u202A\u200B\u200B\u202D\u202E<string>(983009048), BindingFlags.Instance | BindingFlags.NonPublic), Aimbot.\u202B\u206C\u202D\u200C\u202E\u200C\u200C\u200D\u200C\u202D\u202D\u200F\u200F\u206E\u202B\u206E\u202C\u202D\u200B\u206A\u200F\u206D\u202A\u200D\u206C\u202B\u202B\u202C\u202D\u200F\u200C\u202E\u206C\u206F\u206A\u202B\u200D\u206F\u202A\u202D\u202E(Aimbot.\u200D\u206E\u200F\u200F\u202E\u202E\u206D\u202B\u206C\u202B\u202A\u200D\u200C\u200B\u202D\u202D\u206E\u200F\u202E\u206E\u200B\u206E\u202A\u202C\u202D\u200E\u202B\u200C\u200C\u200E\u202D\u200B\u200D\u202C\u200D\u202D\u206B\u202E\u202B\u200D\u202E()), num4);
						num = 2975213958U;
						continue;
					}
					case 9U:
						goto IL_CC;
					}
					goto Block_3;
				}
			}
			Block_3:
			Aimbot.\u200D\u202D\u206D\u202D\u202D\u200E\u200D\u200C\u200E\u206E\u206C\u206D\u206F\u206C\u206C\u200F\u202D\u206E\u206E\u206D\u202B\u200F\u206C\u202C\u202C\u206E\u206D\u202D\u202D\u206A\u202B\u200D\u200B\u202B\u202D\u206C\u200C\u200E\u200B\u200E\u202E(Aimbot.\u200B\u206A\u200D\u206F\u206B\u202A\u200E\u202C\u206E\u202D\u206C\u202E\u200F\u200F\u200B\u206D\u206E\u200D\u206E\u206D\u206F\u202C\u206F\u200C\u200C\u200C\u206F\u206C\u202C\u200D\u206B\u206A\u206D\u206C\u206E\u200E\u200C\u200E\u200B\u202C\u202E(Aimbot.\u206C\u200C\u202C\u206F\u206E\u202A\u202C\u202A\u200B\u200F\u200D\u206B\u202B\u200E\u206F\u200F\u200C\u202C\u206D\u206A\u202E\u200E\u202A\u206A\u206A\u200E\u200F\u206D\u206D\u200F\u202B\u202A\u206D\u206D\u202C\u206A\u200E\u202C\u202B\u206D\u202E(typeof(PlayerLook).TypeHandle), <Module>.\u200B\u206C\u200C\u200C\u206A\u200B\u200D\u206C\u206B\u206D\u202B\u200F\u200E\u206E\u206A\u200D\u206B\u202E\u206A\u200E\u200B\u202E\u200F\u206C\u200F\u202A\u202B\u200F\u200D\u200C\u202D\u200E\u206B\u200D\u202A\u200E\u202E\u206A\u202B\u200C\u202E<string>(2031117068), BindingFlags.Instance | BindingFlags.NonPublic), Aimbot.\u202B\u206C\u202D\u200C\u202E\u200C\u200C\u200D\u200C\u202D\u202D\u200F\u200F\u206E\u202B\u206E\u202C\u202D\u200B\u206A\u200F\u206D\u202A\u200D\u206C\u202B\u202B\u202C\u202D\u200F\u200C\u202E\u206C\u206F\u206A\u202B\u200D\u206F\u202A\u202D\u202E(Aimbot.\u200D\u206E\u200F\u200F\u202E\u202E\u206D\u202B\u206C\u202B\u202A\u200D\u200C\u200B\u202D\u202D\u206E\u200F\u202E\u206E\u200B\u206E\u202A\u202C\u202D\u200E\u202B\u200C\u200C\u200E\u202D\u200B\u200D\u202C\u200D\u202D\u206B\u202E\u202B\u200D\u202E()), vector3.x);
			Aimbot.\u200D\u202D\u206D\u202D\u202D\u200E\u200D\u200C\u200E\u206E\u206C\u206D\u206F\u206C\u206C\u200F\u202D\u206E\u206E\u206D\u202B\u200F\u206C\u202C\u202C\u206E\u206D\u202D\u202D\u206A\u202B\u200D\u200B\u202B\u202D\u206C\u200C\u200E\u200B\u200E\u202E(Aimbot.\u200B\u206A\u200D\u206F\u206B\u202A\u200E\u202C\u206E\u202D\u206C\u202E\u200F\u200F\u200B\u206D\u206E\u200D\u206E\u206D\u206F\u202C\u206F\u200C\u200C\u200C\u206F\u206C\u202C\u200D\u206B\u206A\u206D\u206C\u206E\u200E\u200C\u200E\u200B\u202C\u202E(Aimbot.\u206C\u200C\u202C\u206F\u206E\u202A\u202C\u202A\u200B\u200F\u200D\u206B\u202B\u200E\u206F\u200F\u200C\u202C\u206D\u206A\u202E\u200E\u202A\u206A\u206A\u200E\u200F\u206D\u206D\u200F\u202B\u202A\u206D\u206D\u202C\u206A\u200E\u202C\u202B\u206D\u202E(typeof(PlayerLook).TypeHandle), <Module>.\u200B\u206C\u200C\u200C\u206A\u200B\u200D\u206C\u206B\u206D\u202B\u200F\u200E\u206E\u206A\u200D\u206B\u202E\u206A\u200E\u200B\u202E\u200F\u206C\u200F\u202A\u202B\u200F\u200D\u200C\u202D\u200E\u206B\u200D\u202A\u200E\u202E\u206A\u202B\u200C\u202E<string>(-1304186890), BindingFlags.Instance | BindingFlags.NonPublic), Aimbot.\u202B\u206C\u202D\u200C\u202E\u200C\u200C\u200D\u200C\u202D\u202D\u200F\u200F\u206E\u202B\u206E\u202C\u202D\u200B\u206A\u200F\u206D\u202A\u200D\u206C\u202B\u202B\u202C\u202D\u200F\u200C\u202E\u206C\u206F\u206A\u202B\u200D\u206F\u202A\u202D\u202E(Aimbot.\u200D\u206E\u200F\u200F\u202E\u202E\u206D\u202B\u206C\u202B\u202A\u200D\u200C\u200B\u202D\u202D\u206E\u200F\u202E\u206E\u200B\u206E\u202A\u202C\u202D\u200E\u202B\u200C\u200C\u200E\u202D\u200B\u200D\u202C\u200D\u202D\u206B\u202E\u202B\u200D\u202E()), vector3.y);
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00007324 File Offset: 0x00005524
		private float CalcPrediction()
		{
			ItemGunAsset itemGunAsset = Aimbot.\u206D\u206F\u206F\u206A\u200C\u202B\u202C\u200C\u202B\u206E\u200E\u200E\u206A\u206E\u206D\u206A\u202E\u206E\u200C\u200B\u206C\u200B\u200F\u206A\u206D\u200B\u202D\u206A\u206F\u206D\u202B\u200B\u200B\u200C\u200C\u202C\u200C\u206D\u202B\u206D\u202E(Aimbot.\u202E\u206D\u202D\u202D\u200B\u202C\u200B\u206B\u206A\u206F\u206A\u206A\u200B\u202C\u206A\u206D\u206C\u202E\u200E\u206B\u200C\u202E\u200D\u200C\u202C\u200E\u200E\u202B\u206A\u200B\u202C\u206B\u202A\u202A\u206E\u200C\u206B\u206F\u206F\u202E(Aimbot.\u200D\u206E\u200F\u200F\u202E\u202E\u206D\u202B\u206C\u202B\u202A\u200D\u200C\u200B\u202D\u202D\u206E\u200F\u202E\u206E\u200B\u206E\u202A\u202C\u202D\u200E\u202B\u200C\u200C\u200E\u202D\u200B\u200D\u202C\u200D\u202D\u206B\u202E\u202B\u200D\u202E())) as ItemGunAsset;
			for (;;)
			{
				IL_15:
				uint num = 2356873758U;
				for (;;)
				{
					uint num2;
					switch ((num2 = (num ^ 3839614391U)) % 4U)
					{
					case 0U:
						goto IL_15;
					case 1U:
						num = (((itemGunAsset == null) ? 1425301091U : 494518914U) ^ num2 * 2396482266U);
						continue;
					case 2U:
						goto IL_57;
					}
					goto Block_1;
				}
			}
			Block_1:
			goto IL_6C;
			IL_57:
			return 1f;
			IL_6C:
			return (float)itemGunAsset.ballisticSteps * itemGunAsset.ballisticTravel;
		}

		// Token: 0x06000049 RID: 73 RVA: 0x000073AC File Offset: 0x000055AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		private float CalcBallistics()
		{
			UseableGun useableGun = Aimbot.\u206D\u206E\u202B\u206C\u200E\u206B\u202E\u206E\u200E\u200D\u202E\u206D\u206C\u200F\u202C\u200B\u206C\u206C\u206C\u202D\u200E\u200B\u206E\u206B\u206F\u206C\u200C\u202B\u200B\u202C\u200C\u206D\u200F\u206B\u206C\u206A\u202C\u200E\u206C\u202A\u202E(Aimbot.\u202E\u206D\u202D\u202D\u200B\u202C\u200B\u206B\u206A\u206F\u206A\u206A\u200B\u202C\u206A\u206D\u206C\u202E\u200E\u206B\u200C\u202E\u200D\u200C\u202C\u200E\u200E\u202B\u206A\u200B\u202C\u206B\u202A\u202A\u206E\u200C\u206B\u206F\u206F\u202E(Aimbot.\u200D\u206E\u200F\u200F\u202E\u202E\u206D\u202B\u206C\u202B\u202A\u200D\u200C\u200B\u202D\u202D\u206E\u200F\u202E\u206E\u200B\u206E\u202A\u202C\u202D\u200E\u202B\u200C\u200C\u200E\u202D\u200B\u200D\u202C\u200D\u202D\u206B\u202E\u202B\u200D\u202E())) as UseableGun;
			Attachments attachments;
			for (;;)
			{
				IL_15:
				uint num = 1535422488U;
				for (;;)
				{
					uint num2;
					bool flag;
					switch ((num2 = (num ^ 23222783U)) % 6U)
					{
					case 0U:
						flag = (null != null);
						goto IL_68;
					case 1U:
						num = (((useableGun == null) ? 3289713848U : 4237644919U) ^ num2 * 2318049023U);
						continue;
					case 3U:
						goto IL_71;
					case 4U:
						goto IL_15;
					case 5U:
						attachments = (Attachments)Aimbot.\u206E\u200B\u202D\u200C\u200E\u200C\u200D\u202C\u206F\u206E\u202A\u206D\u206C\u200F\u202E\u206F\u206D\u206E\u202A\u206B\u202A\u206B\u202A\u206D\u200E\u200F\u200D\u202C\u202E\u202A\u200F\u206C\u200D\u202A\u202A\u202B\u200E\u206D\u206B\u206E\u202E(Aimbot.\u200B\u206A\u200D\u206F\u206B\u202A\u200E\u202C\u206E\u202D\u206C\u202E\u200F\u200F\u200B\u206D\u206E\u200D\u206E\u206D\u206F\u202C\u206F\u200C\u200C\u200C\u206F\u206C\u202C\u200D\u206B\u206A\u206D\u206C\u206E\u200E\u200C\u200E\u200B\u202C\u202E(Aimbot.\u206C\u200C\u202C\u206F\u206E\u202A\u202C\u202A\u200B\u200F\u200D\u206B\u202B\u200E\u206F\u200F\u200C\u202C\u206D\u206A\u202E\u200E\u202A\u206A\u206A\u200E\u200F\u206D\u206D\u200F\u202B\u202A\u206D\u206D\u202C\u206A\u200E\u202C\u202B\u206D\u202E(typeof(UseableGun).TypeHandle), <Module>.\u202B\u200B\u202C\u206C\u206D\u202C\u206B\u200F\u206D\u206D\u200E\u206A\u202E\u206D\u200D\u206A\u202D\u202B\u200B\u200F\u202C\u206D\u200E\u202D\u200D\u206A\u200F\u206E\u206F\u206F\u200D\u202D\u202C\u200B\u206F\u202C\u202A\u200D\u206E\u202E\u202E<string>(810923477), BindingFlags.Instance | BindingFlags.NonPublic), useableGun);
						if (attachments == null)
						{
							num = 1546336033U;
							continue;
						}
						flag = (Aimbot.\u206B\u200D\u202C\u202D\u206A\u202B\u202E\u206A\u206F\u206B\u200C\u200C\u206E\u202D\u202D\u202C\u200D\u206D\u206A\u200F\u202A\u202D\u206C\u206D\u202B\u200D\u202A\u200F\u206E\u202D\u200B\u202B\u206B\u202A\u202D\u200C\u202B\u206D\u206D\u206E\u202E(attachments) != null);
						goto IL_68;
					}
					goto Block_1;
					IL_68:
					if (!flag)
					{
						goto IL_C2;
					}
					num = 1294930062U;
				}
			}
			Block_1:
			goto IL_C2;
			IL_71:
			return Aimbot.\u202D\u206F\u202A\u202C\u206A\u200B\u202A\u206C\u206E\u202E\u200F\u206D\u200D\u200D\u202C\u200B\u206B\u202B\u202B\u200D\u202E\u202B\u202B\u202B\u206E\u202B\u202C\u200E\u200C\u202E\u202E\u200C\u206F\u206F\u200D\u200F\u202A\u200B\u202D\u200D\u202E(Aimbot.\u206D\u202A\u200C\u200C\u202B\u200C\u202B\u206B\u206F\u200C\u206F\u200D\u206C\u200E\u200E\u206D\u202D\u202C\u206C\u202D\u206E\u202E\u206F\u200D\u206E\u206B\u206B\u202D\u200D\u206C\u200D\u206F\u206E\u200D\u200C\u200F\u200E\u206C\u206E\u202E\u202E(attachments));
			IL_C2:
			return 1f;
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00007480 File Offset: 0x00005680
		public void Draw()
		{
			Camera cachedCamera = Main.CachedCamera;
			if (this.enabled)
			{
				for (;;)
				{
					IL_11:
					uint num = 3684161817U;
					for (;;)
					{
						uint num2;
						switch ((num2 = (num ^ 2847758989U)) % 11U)
						{
						case 1U:
							num = ((Aimbot.\u206D\u200D\u200B\u202E\u206D\u202E\u202A\u202B\u206F\u202D\u202D\u200B\u206F\u202E\u200D\u202A\u202A\u200E\u200F\u200D\u206E\u202A\u206C\u200B\u206A\u202E\u206E\u202E\u206D\u206E\u202A\u202D\u202E\u200C\u200D\u202B\u206C\u202B\u202E\u200F\u202E() ? 2128918509U : 1443063186U) ^ num2 * 1867590009U);
							continue;
						case 2U:
							return;
						case 3U:
							num = (((!Aimbot.\u200D\u206A\u206E\u206A\u206E\u202A\u202D\u206D\u206A\u206D\u202E\u202C\u206F\u206E\u206B\u200C\u206D\u206F\u206C\u202E\u206E\u202C\u200C\u202D\u206D\u202D\u206C\u206C\u200F\u200F\u200F\u202A\u202E\u206B\u206A\u200E\u206B\u202B\u206C\u206C\u202E(cachedCamera, null)) ? 130504439U : 990040353U) ^ num2 * 1555130844U);
							continue;
						case 4U:
							num = (((!Overrides.bBeingSpied) ? 3329780970U : 2605930912U) ^ num2 * 1464532814U);
							continue;
						case 5U:
							num = ((Overrides.bHideOnSpy ? 208007522U : 348744053U) ^ num2 * 2176252747U);
							continue;
						case 6U:
							return;
						case 7U:
							num = ((!Aimbot.\u206A\u206E\u200C\u200E\u206E\u200B\u202A\u200B\u200B\u206C\u206C\u206D\u206C\u202D\u200F\u206F\u200C\u200C\u200C\u206A\u200E\u202D\u200C\u200E\u206D\u206C\u200B\u200D\u200E\u206A\u202C\u202B\u206B\u206F\u200E\u200E\u206E\u200E\u200D\u202B\u202E()) ? 2820175845U : 2740919493U);
							continue;
						case 8U:
							goto IL_11;
						case 9U:
						{
							Vector2 center = new Vector2((float)Aimbot.\u202B\u202C\u206B\u206E\u200F\u206D\u206E\u206F\u206D\u200D\u206A\u202E\u206A\u206D\u206B\u200E\u206E\u206A\u202E\u202A\u200B\u202E\u200C\u200F\u206B\u200D\u202E\u206F\u206A\u206D\u202C\u202C\u206F\u206B\u202A\u200B\u202B\u200D\u200C\u202D\u202E() / 2f, (float)Aimbot.\u206B\u200F\u202B\u200B\u200E\u200C\u206F\u200F\u206C\u200C\u202E\u206E\u206F\u200C\u202D\u202B\u206F\u200B\u202E\u206D\u206D\u206B\u202E\u206F\u202B\u202A\u200C\u202A\u200D\u206A\u206E\u206E\u202C\u202A\u202A\u200C\u200C\u206A\u200F\u206C\u202E() / 2f);
							float fovscreenRadius = this.GetFOVScreenRadius();
							Utils.DrawCircleFixed(center, fovscreenRadius, 1.6f, new Color?(new Color(1f, 0.3f, 0.3f, 0.78f)));
							num = 2348767500U;
							continue;
						}
						case 10U:
							num = (this.noFovMode ? 2355348147U : 3692206952U);
							continue;
						}
						goto Block_1;
					}
				}
				Block_1:
				return;
			}
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00007690 File Offset: 0x00005890
		static Player \u200D\u206E\u200F\u200F\u202E\u202E\u206D\u202B\u206C\u202B\u202A\u200D\u200C\u200B\u202D\u202D\u206E\u200F\u202E\u206E\u200B\u206E\u202A\u202C\u202D\u200E\u202B\u200C\u200C\u200E\u202D\u200B\u200D\u202C\u200D\u202D\u206B\u202E\u202B\u200D\u202E()
		{
			return Player.LocalPlayer;
		}

		// Token: 0x0600004D RID: 77 RVA: 0x000076A4 File Offset: 0x000058A4
		static bool \u200D\u206A\u206E\u206A\u206E\u202A\u202D\u206D\u206A\u206D\u202E\u202C\u206F\u206E\u206B\u200C\u206D\u206F\u206C\u202E\u206E\u202C\u200C\u202D\u206D\u202D\u206C\u206C\u200F\u200F\u200F\u202A\u202E\u206B\u206A\u200E\u206B\u202B\u206C\u206C\u202E(Object A_0, Object A_1)
		{
			return A_0 == A_1;
		}

		// Token: 0x0600004E RID: 78 RVA: 0x000076B8 File Offset: 0x000058B8
		static bool \u206A\u206E\u200C\u200E\u206E\u200B\u202A\u200B\u200B\u206C\u206C\u206D\u206C\u202D\u200F\u206F\u200C\u200C\u200C\u206A\u200E\u202D\u200C\u200E\u206D\u206C\u200B\u200D\u200E\u206A\u202C\u202B\u206B\u206F\u200E\u200E\u206E\u200E\u200D\u202B\u202E()
		{
			return Provider.isConnected;
		}

		// Token: 0x0600004F RID: 79 RVA: 0x000076CC File Offset: 0x000058CC
		static bool \u206D\u200D\u200B\u202E\u206D\u202E\u202A\u202B\u206F\u202D\u202D\u200B\u206F\u202E\u200D\u202A\u202A\u200E\u200F\u200D\u206E\u202A\u206C\u200B\u206A\u202E\u206E\u202E\u206D\u206E\u202A\u202D\u202E\u200C\u200D\u202B\u206C\u202B\u202E\u200F\u202E()
		{
			return Provider.isLoading;
		}

		// Token: 0x06000050 RID: 80 RVA: 0x000076E0 File Offset: 0x000058E0
		static bool \u200C\u200E\u202B\u200B\u206F\u206E\u202B\u200B\u202D\u202B\u202B\u206F\u200B\u206B\u206C\u200D\u202D\u200E\u200B\u202B\u202A\u200D\u200B\u206D\u200B\u202D\u206E\u202E\u200D\u202D\u206F\u200E\u200B\u202C\u202C\u200D\u202A\u206C\u206D\u206C\u202E(KeyCode A_0)
		{
			return Input.GetKey(A_0);
		}

		// Token: 0x06000051 RID: 81 RVA: 0x000076F4 File Offset: 0x000058F4
		static bool \u202E\u206A\u206E\u202D\u206B\u202C\u206C\u206B\u202B\u206A\u206F\u206B\u202B\u200E\u206B\u206E\u200E\u206A\u200F\u200B\u202A\u206F\u206B\u200E\u206A\u202A\u206B\u200E\u206B\u202A\u202A\u206E\u202E\u206C\u206C\u206C\u200E\u200B\u200E\u200C\u202E(KeyCode A_0)
		{
			return Input.GetKeyDown(A_0);
		}

		// Token: 0x06000052 RID: 82 RVA: 0x000061E8 File Offset: 0x000043E8
		static bool \u202C\u202C\u206E\u200C\u206E\u200C\u202C\u200C\u206F\u206F\u206A\u206A\u202E\u202E\u200D\u202A\u200F\u206A\u202A\u206D\u200D\u200F\u200C\u200D\u200D\u206F\u200D\u200F\u206D\u200C\u202C\u202E\u206F\u206C\u202C\u202E\u200E\u206E\u202E\u206D\u202E(Object A_0, Object A_1)
		{
			return A_0 != A_1;
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00007708 File Offset: 0x00005908
		static Transform \u206D\u200D\u202A\u206B\u202E\u202A\u200F\u200D\u200F\u202C\u202B\u206E\u200F\u200B\u206C\u206D\u200B\u202C\u206D\u200D\u202C\u206D\u202B\u206E\u202A\u206E\u206B\u200D\u206B\u200D\u202C\u206C\u200D\u202A\u202C\u200B\u200B\u200F\u202B\u206F\u202E(Component A_0)
		{
			return A_0.transform;
		}

		// Token: 0x06000054 RID: 84 RVA: 0x0000771C File Offset: 0x0000591C
		static Vector3 \u200D\u202C\u206F\u206E\u206E\u202A\u202A\u206E\u206F\u200F\u206F\u206A\u202C\u200C\u200D\u200B\u200B\u202D\u202E\u206F\u202E\u206D\u206D\u202D\u200F\u206A\u200D\u202D\u200C\u202D\u206E\u200D\u202A\u206B\u206A\u206B\u200F\u206D\u206F\u206E\u202E(Transform A_0)
		{
			return A_0.position;
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00007730 File Offset: 0x00005930
		static float \u202B\u206E\u200D\u202D\u202E\u206A\u200B\u202B\u202B\u202E\u202B\u200F\u200D\u202C\u202D\u200C\u206A\u200D\u202C\u200C\u206B\u200B\u206C\u200F\u206F\u206E\u206F\u202D\u200C\u200C\u202D\u206F\u202D\u206F\u202E\u200C\u202B\u206D\u206D\u202E\u202E()
		{
			return Time.time;
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00007744 File Offset: 0x00005944
		static Vector3 \u206C\u202C\u206D\u206B\u206D\u206A\u206B\u200F\u200B\u200F\u200F\u202D\u202E\u202E\u202E\u202D\u206A\u202C\u200B\u206C\u202C\u200B\u200F\u206D\u206A\u206D\u200F\u200F\u200B\u206F\u206A\u206D\u202A\u200F\u202D\u206C\u206B\u202D\u200E\u200E\u202E(Camera A_0, Vector3 A_1)
		{
			return A_0.WorldToScreenPoint(A_1);
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00007758 File Offset: 0x00005958
		static int \u202B\u202C\u206B\u206E\u200F\u206D\u206E\u206F\u206D\u200D\u206A\u202E\u206A\u206D\u206B\u200E\u206E\u206A\u202E\u202A\u200B\u202E\u200C\u200F\u206B\u200D\u202E\u206F\u206A\u206D\u202C\u202C\u206F\u206B\u202A\u200B\u202B\u200D\u200C\u202D\u202E()
		{
			return Screen.width;
		}

		// Token: 0x06000058 RID: 88 RVA: 0x0000776C File Offset: 0x0000596C
		static int \u206B\u200F\u202B\u200B\u200E\u200C\u206F\u200F\u206C\u200C\u202E\u206E\u206F\u200C\u202D\u202B\u206F\u200B\u202E\u206D\u206D\u206B\u202E\u206F\u202B\u202A\u200C\u202A\u200D\u206A\u206E\u206E\u202C\u202A\u202A\u200C\u200C\u206A\u200F\u206C\u202E()
		{
			return Screen.height;
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00007780 File Offset: 0x00005980
		static float \u200F\u202B\u202E\u206B\u200B\u202B\u200B\u206A\u200B\u200B\u206F\u206F\u202D\u200C\u202E\u202D\u202C\u206C\u202E\u206B\u202A\u202C\u202C\u200D\u200D\u202A\u202B\u200B\u206E\u200D\u202E\u206A\u206C\u202D\u202A\u206F\u200C\u202C\u202B\u206F\u202E(Camera A_0)
		{
			return A_0.fieldOfView;
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00007794 File Offset: 0x00005994
		static PlayerStance \u206A\u202E\u202D\u200B\u206F\u202D\u200F\u202E\u200B\u206A\u202D\u206D\u206B\u202B\u206C\u202B\u206C\u206C\u206A\u202B\u206A\u202B\u206F\u206D\u206B\u206E\u206A\u206F\u206C\u206B\u202E\u202E\u202E\u200F\u206D\u206B\u202B\u200F\u202E\u206C\u202E(Player A_0)
		{
			return A_0.stance;
		}

		// Token: 0x0600005B RID: 91 RVA: 0x000077A8 File Offset: 0x000059A8
		static EPlayerStance \u206F\u206F\u206B\u202E\u206E\u206C\u200E\u202D\u200F\u206E\u206C\u200F\u206A\u206A\u202D\u206E\u202C\u202C\u206F\u206C\u206F\u202D\u202D\u206B\u200D\u202B\u200E\u202B\u200C\u206D\u202C\u202B\u206F\u200E\u200F\u206A\u200B\u206D\u202A\u206A\u202E(PlayerStance A_0)
		{
			return A_0.stance;
		}

		// Token: 0x0600005C RID: 92 RVA: 0x000077BC File Offset: 0x000059BC
		static bool \u202A\u200B\u202D\u202D\u200F\u202C\u200F\u202B\u202A\u206C\u206D\u202A\u200E\u206C\u200B\u206A\u200C\u200E\u206D\u200D\u206A\u202A\u206A\u200B\u200D\u206F\u200B\u200C\u202E\u202A\u202E\u206F\u206F\u206D\u200D\u200F\u206A\u206A\u206B\u202E\u202E(Vector3 A_0, Vector3 A_1, ref RaycastHit A_2, float A_3, int A_4)
		{
			return Physics.Raycast(A_0, A_1, ref A_2, A_3, A_4);
		}

		// Token: 0x0600005D RID: 93 RVA: 0x000077D4 File Offset: 0x000059D4
		static Player \u200C\u200C\u206F\u206A\u206B\u206E\u206C\u200C\u200D\u206D\u200B\u202A\u202B\u206E\u206C\u200D\u200E\u206D\u206E\u200C\u200E\u200C\u206B\u206D\u200C\u206E\u202A\u206E\u206A\u202B\u200E\u200D\u206D\u200B\u202E\u206C\u206B\u206E\u206B\u206C\u202E(Transform A_0)
		{
			return DamageTool.getPlayer(A_0);
		}

		// Token: 0x0600005E RID: 94 RVA: 0x000077E8 File Offset: 0x000059E8
		static PlayerLook \u202B\u206C\u202D\u200C\u202E\u200C\u200C\u200D\u200C\u202D\u202D\u200F\u200F\u206E\u202B\u206E\u202C\u202D\u200B\u206A\u200F\u206D\u202A\u200D\u206C\u202B\u202B\u202C\u202D\u200F\u200C\u202E\u206C\u206F\u206A\u202B\u200D\u206F\u202A\u202D\u202E(Player A_0)
		{
			return A_0.look;
		}

		// Token: 0x0600005F RID: 95 RVA: 0x000077FC File Offset: 0x000059FC
		static Transform \u206D\u206D\u206B\u206D\u202B\u206F\u200B\u200F\u206F\u202B\u202A\u206C\u202B\u200F\u200F\u200C\u200D\u200F\u202E\u202A\u202A\u200D\u200C\u202A\u206D\u206C\u206B\u202A\u206C\u200C\u200D\u206E\u202A\u206F\u206C\u200C\u206A\u206C\u202D\u206D\u202E(PlayerLook A_0)
		{
			return A_0.aim;
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00007810 File Offset: 0x00005A10
		static Vector3 \u206A\u200B\u206C\u202B\u200D\u202C\u200B\u206A\u206B\u202E\u200D\u206A\u200C\u206C\u206A\u200D\u202C\u206C\u206A\u202A\u200E\u206D\u200C\u200C\u206C\u202A\u200D\u202E\u200F\u202A\u202A\u206E\u206E\u206C\u206E\u206D\u202E\u202A\u206B\u206E\u202E(Transform A_0)
		{
			return A_0.forward;
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00007824 File Offset: 0x00005A24
		static PlayerLife \u200B\u206C\u200B\u200B\u200F\u206E\u200D\u200F\u206B\u202B\u200D\u200F\u206E\u200C\u206F\u200E\u202D\u206A\u202D\u202B\u202C\u202D\u202D\u202D\u202C\u206D\u206C\u206E\u206D\u202B\u206D\u206E\u206E\u200C\u206A\u206D\u206C\u202A\u200F\u206A\u202E(Player A_0)
		{
			return A_0.life;
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00007838 File Offset: 0x00005A38
		static bool \u206C\u206E\u202E\u200F\u206E\u200F\u202A\u206C\u202B\u202A\u200D\u200E\u202A\u202A\u200C\u202D\u206B\u200E\u200E\u206C\u206A\u202A\u200C\u202D\u206A\u200D\u200D\u200C\u202C\u202D\u202A\u202A\u200C\u202E\u206C\u202E\u200B\u202A\u202D\u206D\u202E(PlayerLife A_0)
		{
			return A_0.isDead;
		}

		// Token: 0x06000063 RID: 99 RVA: 0x0000784C File Offset: 0x00005A4C
		static Vector3 \u202A\u202D\u202D\u202A\u206F\u206A\u200B\u200D\u206A\u200D\u200E\u202D\u206B\u202B\u202C\u206C\u206A\u206A\u200C\u206A\u202B\u200D\u200B\u200D\u200E\u202A\u202E\u206C\u206E\u202A\u200E\u206A\u206F\u200B\u202C\u206D\u200D\u206A\u200F\u200C\u202E()
		{
			return Physics.gravity;
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00007860 File Offset: 0x00005A60
		static Type \u206C\u200C\u202C\u206F\u206E\u202A\u202C\u202A\u200B\u200F\u200D\u206B\u202B\u200E\u206F\u200F\u200C\u202C\u206D\u206A\u202E\u200E\u202A\u206A\u206A\u200E\u200F\u206D\u206D\u200F\u202B\u202A\u206D\u206D\u202C\u206A\u200E\u202C\u202B\u206D\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00007874 File Offset: 0x00005A74
		static FieldInfo \u200B\u206A\u200D\u206F\u206B\u202A\u200E\u202C\u206E\u202D\u206C\u202E\u200F\u200F\u200B\u206D\u206E\u200D\u206E\u206D\u206F\u202C\u206F\u200C\u200C\u200C\u206F\u206C\u202C\u200D\u206B\u206A\u206D\u206C\u206E\u200E\u200C\u200E\u200B\u202C\u202E(Type A_0, string A_1, BindingFlags A_2)
		{
			return A_0.GetField(A_1, A_2);
		}

		// Token: 0x06000066 RID: 102 RVA: 0x0000788C File Offset: 0x00005A8C
		static object \u206E\u200B\u202D\u200C\u200E\u200C\u200D\u202C\u206F\u206E\u202A\u206D\u206C\u200F\u202E\u206F\u206D\u206E\u202A\u206B\u202A\u206B\u202A\u206D\u200E\u200F\u200D\u202C\u202E\u202A\u200F\u206C\u200D\u202A\u202A\u202B\u200E\u206D\u206B\u206E\u202E(FieldInfo A_0, object A_1)
		{
			return A_0.GetValue(A_1);
		}

		// Token: 0x06000067 RID: 103 RVA: 0x000078A0 File Offset: 0x00005AA0
		static float \u206E\u202E\u206F\u200E\u206B\u202B\u200E\u200D\u200B\u206D\u200F\u206E\u200E\u202C\u206C\u202E\u200D\u200F\u206D\u202D\u202A\u206C\u200C\u206C\u206A\u202A\u200C\u206B\u206D\u202C\u202B\u202E\u200D\u202E\u200C\u206D\u206C\u202C\u200C\u206D\u202E()
		{
			return Time.deltaTime;
		}

		// Token: 0x06000068 RID: 104 RVA: 0x000078B4 File Offset: 0x00005AB4
		static void \u200D\u202D\u206D\u202D\u202D\u200E\u200D\u200C\u200E\u206E\u206C\u206D\u206F\u206C\u206C\u200F\u202D\u206E\u206E\u206D\u202B\u200F\u206C\u202C\u202C\u206E\u206D\u202D\u202D\u206A\u202B\u200D\u200B\u202B\u202D\u206C\u200C\u200E\u200B\u200E\u202E(FieldInfo A_0, object A_1, object A_2)
		{
			A_0.SetValue(A_1, A_2);
		}

		// Token: 0x06000069 RID: 105 RVA: 0x000078CC File Offset: 0x00005ACC
		static PlayerEquipment \u202E\u206D\u202D\u202D\u200B\u202C\u200B\u206B\u206A\u206F\u206A\u206A\u200B\u202C\u206A\u206D\u206C\u202E\u200E\u206B\u200C\u202E\u200D\u200C\u202C\u200E\u200E\u202B\u206A\u200B\u202C\u206B\u202A\u202A\u206E\u200C\u206B\u206F\u206F\u202E(Player A_0)
		{
			return A_0.equipment;
		}

		// Token: 0x0600006A RID: 106 RVA: 0x000078E0 File Offset: 0x00005AE0
		static ItemAsset \u206D\u206F\u206F\u206A\u200C\u202B\u202C\u200C\u202B\u206E\u200E\u200E\u206A\u206E\u206D\u206A\u202E\u206E\u200C\u200B\u206C\u200B\u200F\u206A\u206D\u200B\u202D\u206A\u206F\u206D\u202B\u200B\u200B\u200C\u200C\u202C\u200C\u206D\u202B\u206D\u202E(PlayerEquipment A_0)
		{
			return A_0.asset;
		}

		// Token: 0x0600006B RID: 107 RVA: 0x000078F4 File Offset: 0x00005AF4
		static Useable \u206D\u206E\u202B\u206C\u200E\u206B\u202E\u206E\u200E\u200D\u202E\u206D\u206C\u200F\u202C\u200B\u206C\u206C\u206C\u202D\u200E\u200B\u206E\u206B\u206F\u206C\u200C\u202B\u200B\u202C\u200C\u206D\u200F\u206B\u206C\u206A\u202C\u200E\u206C\u202A\u202E(PlayerEquipment A_0)
		{
			return A_0.useable;
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00007908 File Offset: 0x00005B08
		static ItemBarrelAsset \u206B\u200D\u202C\u202D\u206A\u202B\u202E\u206A\u206F\u206B\u200C\u200C\u206E\u202D\u202D\u202C\u200D\u206D\u206A\u200F\u202A\u202D\u206C\u206D\u202B\u200D\u202A\u200F\u206E\u202D\u200B\u202B\u206B\u202A\u202D\u200C\u202B\u206D\u206D\u206E\u202E(Attachments A_0)
		{
			return A_0.barrelAsset;
		}

		// Token: 0x0600006D RID: 109 RVA: 0x0000791C File Offset: 0x00005B1C
		static ItemBarrelAsset \u206D\u202A\u200C\u200C\u202B\u200C\u202B\u206B\u206F\u200C\u206F\u200D\u206C\u200E\u200E\u206D\u202D\u202C\u206C\u202D\u206E\u202E\u206F\u200D\u206E\u206B\u206B\u202D\u200D\u206C\u200D\u206F\u206E\u200D\u200C\u200F\u200E\u206C\u206E\u202E\u202E(Attachments A_0)
		{
			return A_0.barrelAsset;
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00007930 File Offset: 0x00005B30
		static float \u202D\u206F\u202A\u202C\u206A\u200B\u202A\u206C\u206E\u202E\u200F\u206D\u200D\u200D\u202C\u200B\u206B\u202B\u202B\u200D\u202E\u202B\u202B\u202B\u206E\u202B\u202C\u200E\u200C\u202E\u202E\u200C\u206F\u206F\u200D\u200F\u202A\u200B\u202D\u200D\u202E(ItemBarrelAsset A_0)
		{
			return A_0.ballisticDrop;
		}

		// Token: 0x0400002D RID: 45
		private Entities entities;

		// Token: 0x0400002E RID: 46
		public bool enabled;

		// Token: 0x0400002F RID: 47
		private float lastValidTime;

		// Token: 0x04000030 RID: 48
		public bool noFovMode;

		// Token: 0x04000031 RID: 49
		public float fov = 35f;

		// Token: 0x04000032 RID: 50
		public bool smooth = true;

		// Token: 0x04000033 RID: 51
		public float smoothFactor = 12f;

		// Token: 0x04000034 RID: 52
		public bool useVisibleCheck = true;

		// Token: 0x04000035 RID: 53
		public bool usePrediction = true;

		// Token: 0x04000036 RID: 54
		public float predictionFactor = 38f;

		// Token: 0x04000037 RID: 55
		public bool useBallisticPrediction = true;

		// Token: 0x04000038 RID: 56
		public float ballisticFactor = 5.2f;

		// Token: 0x04000039 RID: 57
		public bool preferHead = true;

		// Token: 0x0400003A RID: 58
		private bool toggleAiming;

		// Token: 0x0400003B RID: 59
		public bool useWeaponRange = true;

		// Token: 0x0400003C RID: 60
		public float customMaxDistance = 300f;

		// Token: 0x0400003D RID: 61
		private Vector3 lastTargetPosition;

		// Token: 0x0400003E RID: 62
		private Player currentTarget;

		// Token: 0x0400003F RID: 63
		private Player lastValidTarget;
	}
}
