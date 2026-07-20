using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using SDG.Unturned;
using UnityEngine;

namespace Cheat.modules
{
	// Token: 0x0200001C RID: 28
	public class Visuals : MonoBehaviour
	{
		// Token: 0x0600017B RID: 379 RVA: 0x000101E0 File Offset: 0x0000E3E0
		private void Awake()
		{
			Provider.onClientConnected = (Provider.ClientConnected)Visuals.\u202C\u200F\u200E\u202D\u202C\u200F\u206C\u200B\u200D\u200C\u206E\u202C\u200C\u200F\u206E\u200D\u202B\u200E\u206D\u206E\u202A\u202D\u202C\u202E\u200C\u206B\u202D\u200D\u200C\u202A\u206C\u200F\u206D\u202C\u200B\u202E\u202A\u202E\u200C\u206A\u202E(Provider.onClientConnected, new Provider.ClientConnected(this.OnConnected));
			Provider.onClientDisconnected = (Provider.ClientDisconnected)Visuals.\u202C\u200F\u200E\u202D\u202C\u200F\u206C\u200B\u200D\u200C\u206E\u202C\u200C\u200F\u206E\u200D\u202B\u200E\u206D\u206E\u202A\u202D\u202C\u202E\u200C\u206B\u202D\u200D\u200C\u202A\u206C\u200F\u206D\u202C\u200B\u202E\u202A\u202E\u200C\u206A\u202E(Provider.onClientDisconnected, new Provider.ClientDisconnected(this.OnDisconnected));
		}

		// Token: 0x0600017C RID: 380 RVA: 0x00010230 File Offset: 0x0000E430
		private void OnDestroy()
		{
			Provider.onClientConnected = (Provider.ClientConnected)Visuals.\u206E\u206C\u202C\u206F\u200D\u206B\u206C\u200D\u206B\u206C\u206F\u202A\u200F\u200B\u206E\u202C\u202A\u206E\u200C\u202B\u202E\u206A\u202E\u202E\u200D\u200D\u206C\u202A\u200E\u206C\u202B\u202A\u206F\u202C\u202D\u200C\u202E\u200B\u206B\u202D\u202E(Provider.onClientConnected, new Provider.ClientConnected(this.OnConnected));
			for (;;)
			{
				IL_20:
				uint num = 2505089535U;
				for (;;)
				{
					uint num2;
					switch ((num2 = (num ^ 3895779707U)) % 3U)
					{
					case 0U:
						goto IL_20;
					case 1U:
						Provider.onClientDisconnected = (Provider.ClientDisconnected)Visuals.\u206E\u206C\u202C\u206F\u200D\u206B\u206C\u200D\u206B\u206C\u206F\u202A\u200F\u200B\u206E\u202C\u202A\u206E\u200C\u202B\u202E\u206A\u202E\u202E\u200D\u200D\u206C\u202A\u200E\u206C\u202B\u202A\u206F\u202C\u202D\u200C\u202E\u200B\u206B\u202D\u202E(Provider.onClientDisconnected, new Provider.ClientDisconnected(this.OnDisconnected));
						num = (num2 * 2389563737U ^ 2589398559U);
						continue;
					}
					return;
				}
			}
		}

		// Token: 0x0600017D RID: 381 RVA: 0x000102B0 File Offset: 0x0000E4B0
		private void OnConnected()
		{
			this.ResetStates();
		}

		// Token: 0x0600017E RID: 382 RVA: 0x000102B0 File Offset: 0x0000E4B0
		private void OnDisconnected()
		{
			this.ResetStates();
		}

		// Token: 0x0600017F RID: 383 RVA: 0x000102C4 File Offset: 0x0000E4C4
		private void ResetStates()
		{
			this.statesCaptured = false;
			this.dayOffset = 0U;
		}

		// Token: 0x06000180 RID: 384 RVA: 0x000102E0 File Offset: 0x0000E4E0
		private void Update()
		{
			if (Overrides.bBeingSpied)
			{
				goto IL_0A;
			}
			goto IL_154;
			uint num2;
			for (;;)
			{
				IL_0F:
				uint num;
				switch ((num = (num2 ^ 1928680915U)) % 14U)
				{
				case 0U:
					goto IL_154;
				case 1U:
					this.HandleSatellite();
					this.HandleCompass();
					num2 = (num * 3143192621U ^ 1915909125U);
					continue;
				case 2U:
					this.CaptureServerStates();
					num2 = (num * 3946167781U ^ 750750244U);
					continue;
				case 3U:
					goto IL_0A;
				case 4U:
					return;
				case 6U:
					goto IL_8C;
				case 7U:
					return;
				case 8U:
					return;
				case 9U:
					num2 = ((Visuals.\u206B\u206A\u200D\u202C\u200F\u200B\u202D\u206A\u206A\u202B\u200F\u202B\u206F\u200D\u202D\u206B\u202B\u200F\u200E\u206A\u200F\u202C\u206F\u206C\u200B\u206D\u202B\u206C\u202B\u206B\u206F\u200B\u202E\u200D\u206E\u202A\u206A\u206D\u200B\u200C\u202E() ? 1665803420U : 850134437U) ^ num * 3409040171U);
					continue;
				case 10U:
					num2 = ((Overrides.bHideOnSpy ? 3264118343U : 3766339355U) ^ num * 3802880545U);
					continue;
				case 11U:
					num2 = (((!Visuals.\u200C\u206A\u202D\u206B\u200E\u200D\u206D\u206F\u202C\u200F\u202C\u206D\u206C\u206E\u202A\u206B\u202D\u206D\u206B\u202B\u200F\u206D\u206F\u206B\u200C\u202A\u202B\u206D\u202A\u202B\u200C\u206F\u200C\u202C\u202E\u200C\u202A\u200E\u200E\u206C\u202E()) ? 468733415U : 1867948731U) ^ num * 3780355301U);
					continue;
				case 12U:
				{
					ModeConfigData modeConfigData = Visuals.\u206A\u206E\u206E\u202B\u202E\u200B\u202C\u206D\u206B\u206C\u200F\u202A\u200F\u200D\u200B\u202E\u206E\u200D\u200D\u200D\u206E\u202E\u200F\u200E\u202B\u200B\u206B\u202E\u206E\u202C\u200D\u202D\u206E\u206C\u200E\u200C\u202A\u200E\u202E\u200C\u202E();
					if (((modeConfigData != null) ? modeConfigData.Gameplay : null) == null)
					{
						num2 = 717306001U;
						continue;
					}
					goto IL_8C;
				}
				case 13U:
					this.HandleAlwaysDay();
					num2 = 1764082986U;
					continue;
				}
				break;
				IL_8C:
				num2 = ((!this.statesCaptured) ? 174052377U : 865448342U);
			}
			return;
			IL_0A:
			num2 = 691547039U;
			goto IL_0F;
			IL_154:
			num2 = ((!Visuals.\u200C\u206A\u202B\u200B\u206D\u206E\u200D\u206E\u200B\u206A\u206F\u206A\u206A\u206A\u200E\u200E\u202C\u200C\u202C\u206C\u200B\u202B\u200B\u200D\u202B\u202A\u202B\u206F\u200F\u206E\u206B\u200E\u202E\u202C\u200B\u206E\u202E\u200F\u202D\u206B\u202E()) ? 1728424846U : 1496320962U);
			goto IL_0F;
		}

		// Token: 0x06000181 RID: 385 RVA: 0x0001047C File Offset: 0x0000E67C
		private void CaptureServerStates()
		{
			this.serverSatellite = Visuals.\u206A\u206E\u206E\u202B\u202E\u200B\u202C\u206D\u206B\u206C\u200F\u202A\u200F\u200D\u200B\u202E\u206E\u200D\u200D\u200D\u206E\u202E\u200F\u200E\u202B\u200B\u206B\u202E\u206E\u202C\u200D\u202D\u206E\u206C\u200E\u200C\u202A\u200E\u202E\u200C\u202E().Gameplay.Satellite;
			for (;;)
			{
				IL_15:
				uint num = 3388632902U;
				for (;;)
				{
					uint num2;
					switch ((num2 = (num ^ 2237718661U)) % 3U)
					{
					case 0U:
						goto IL_15;
					case 1U:
						this.serverChart = Visuals.\u206A\u206E\u206E\u202B\u202E\u200B\u202C\u206D\u206B\u206C\u200F\u202A\u200F\u200D\u200B\u202E\u206E\u200D\u200D\u200D\u206E\u202E\u200F\u200E\u202B\u200B\u206B\u202E\u206E\u202C\u200D\u202D\u206E\u206C\u200E\u200C\u202A\u200E\u202E\u200C\u202E().Gameplay.Chart;
						this.serverCompass = Visuals.\u206A\u206E\u206E\u202B\u202E\u200B\u202C\u206D\u206B\u206C\u200F\u202A\u200F\u200D\u200B\u202E\u206E\u200D\u200D\u200D\u206E\u202E\u200F\u200E\u202B\u200B\u206B\u202E\u206E\u202C\u200D\u202D\u206E\u206C\u200E\u200C\u202A\u200E\u202E\u200C\u202E().Gameplay.Compass;
						num = (num2 * 1828168274U ^ 2726656537U);
						continue;
					}
					goto Block_1;
				}
			}
			Block_1:
			this.statesCaptured = true;
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00010500 File Offset: 0x0000E700
		public void HandleAlwaysDay()
		{
			if (this.AlwaysDay)
			{
				goto IL_0B;
			}
			goto IL_121;
			uint num2;
			for (;;)
			{
				IL_10:
				uint num;
				switch ((num = (num2 ^ 4092143090U)) % 10U)
				{
				case 0U:
					goto IL_121;
				case 1U:
					num2 = (((this.dayOffset == 0U) ? 2420580760U : 3970593317U) ^ num * 1789907249U);
					continue;
				case 2U:
					Visuals.\u206E\u202D\u200E\u200B\u200F\u200E\u206A\u202D\u206F\u202C\u206C\u200D\u206E\u200B\u206C\u206E\u202B\u200B\u202D\u202A\u200B\u202D\u200D\u202E\u206F\u206D\u200D\u202B\u200E\u200F\u202B\u202A\u200C\u200C\u206F\u202C\u200C\u202E\u200E\u206E\u202E(Visuals.\u202E\u202C\u200D\u200B\u206B\u202A\u202C\u206A\u200B\u202A\u200C\u202B\u206A\u206B\u206B\u206F\u206D\u206B\u200F\u200D\u200B\u206B\u206D\u206F\u206F\u200D\u200E\u206A\u206B\u202C\u202A\u206C\u200E\u200E\u202C\u206A\u200E\u202D\u200F\u202A\u202E() - this.dayOffset);
					this.dayOffset = 0U;
					num2 = (num * 2872081351U ^ 2956462520U);
					continue;
				case 3U:
					return;
				case 4U:
					this.dayOffset = Visuals.\u200E\u202C\u202D\u200C\u206A\u206A\u200B\u200C\u200B\u202B\u202A\u206E\u206D\u206D\u200C\u206D\u206A\u202C\u200E\u202C\u206E\u200C\u200C\u202E\u206F\u206E\u206F\u200D\u200E\u206A\u202E\u202C\u206C\u200B\u200D\u206F\u202B\u202D\u200D\u202E();
					num2 = (num * 1457348137U ^ 1096871548U);
					continue;
				case 5U:
					goto IL_0B;
				case 6U:
					num2 = ((this.dayOffset != 0U) ? 4006312177U : 3247770606U);
					continue;
				case 7U:
					num2 = (((Visuals.\u200E\u202C\u202D\u200C\u206A\u206A\u200B\u200C\u200B\u202B\u202A\u206E\u206D\u206D\u200C\u206D\u206A\u202C\u200E\u202C\u206E\u200C\u200C\u202E\u206F\u206E\u206F\u200D\u200E\u206A\u202E\u202C\u206C\u200B\u200D\u206F\u202B\u202D\u200D\u202E() == 0U) ? 170482290U : 1339572076U) ^ num * 366863400U);
					continue;
				case 9U:
					Visuals.\u206E\u202D\u200E\u200B\u200F\u200E\u206A\u202D\u206F\u202C\u206C\u200D\u206E\u200B\u206C\u206E\u202B\u200B\u202D\u202A\u200B\u202D\u200D\u202E\u206F\u206D\u200D\u202B\u200E\u200F\u202B\u202A\u200C\u200C\u206F\u202C\u200C\u202E\u200E\u206E\u202E(this.CustomDayTime);
					num2 = (num * 3874411558U ^ 233142473U);
					continue;
				}
				break;
			}
			return;
			IL_0B:
			num2 = 2593772989U;
			goto IL_10;
			IL_121:
			num2 = ((this.dayOffset != 0U) ? 3332369160U : 3247770606U);
			goto IL_10;
		}

		// Token: 0x06000183 RID: 387 RVA: 0x0001064C File Offset: 0x0000E84C
		public void HandleSatellite()
		{
			if (!this.statesCaptured)
			{
				goto IL_0B;
			}
			goto IL_103;
			uint num2;
			bool flag;
			for (;;)
			{
				IL_10:
				uint num;
				switch ((num = (num2 ^ 1402382894U)) % 11U)
				{
				case 0U:
					goto IL_103;
				case 1U:
					return;
				case 2U:
					goto IL_9E;
				case 3U:
					Visuals.\u206A\u206E\u206E\u202B\u202E\u200B\u202C\u206D\u206B\u206C\u200F\u202A\u200F\u200D\u200B\u202E\u206E\u200D\u200D\u200D\u206E\u202E\u200F\u200E\u202B\u200B\u206B\u202E\u206E\u202C\u200D\u202D\u206E\u206C\u200E\u200C\u202A\u200E\u202E\u200C\u202E().Gameplay.Chart = false;
					num2 = (num * 1345084659U ^ 3291768086U);
					continue;
				case 4U:
					Visuals.\u206A\u206E\u206E\u202B\u202E\u200B\u202C\u206D\u206B\u206C\u200F\u202A\u200F\u200D\u200B\u202E\u206E\u200D\u200D\u200D\u206E\u202E\u200F\u200E\u202B\u200B\u206B\u202E\u206E\u202C\u200D\u202D\u206E\u206C\u200E\u200C\u202A\u200E\u202E\u200C\u202E().Gameplay.Chart = this.serverChart;
					num2 = 880543446U;
					continue;
				case 5U:
					goto IL_0B;
				case 6U:
					num2 = (num * 1696892684U ^ 1981089378U);
					continue;
				case 8U:
					this.RefreshMapUI();
					num2 = 86538206U;
					continue;
				case 9U:
					num2 = (((Visuals.\u206A\u206E\u206E\u202B\u202E\u200B\u202C\u206D\u206B\u206C\u200F\u202A\u200F\u200D\u200B\u202E\u206E\u200D\u200D\u200D\u206E\u202E\u200F\u200E\u202B\u200B\u206B\u202E\u206E\u202C\u200D\u202D\u206E\u206C\u200E\u200C\u202A\u200E\u202E\u200C\u202E().Gameplay.Satellite != flag) ? 4018934025U : 3785545894U) ^ num * 289689758U);
					continue;
				case 10U:
					Visuals.\u206A\u206E\u206E\u202B\u202E\u200B\u202C\u206D\u206B\u206C\u200F\u202A\u200F\u200D\u200B\u202E\u206E\u200D\u200D\u200D\u206E\u202E\u200F\u200E\u202B\u200B\u206B\u202E\u206E\u202C\u200D\u202D\u206E\u206C\u200E\u200C\u202A\u200E\u202E\u200C\u202E().Gameplay.Satellite = flag;
					num2 = ((this.AlwaysSatellite ? 3961362734U : 4208130300U) ^ num * 1211792051U);
					continue;
				}
				break;
			}
			return;
			IL_9E:
			bool flag2 = this.serverSatellite;
			goto IL_A7;
			IL_0B:
			num2 = 2120212207U;
			goto IL_10;
			IL_A7:
			flag = flag2;
			num2 = 1690135466U;
			goto IL_10;
			IL_103:
			if (!this.AlwaysSatellite)
			{
				num2 = 1559573006U;
				goto IL_10;
			}
			flag2 = true;
			goto IL_A7;
		}

		// Token: 0x06000184 RID: 388 RVA: 0x000107A4 File Offset: 0x0000E9A4
		public void HandleCompass()
		{
			if (!this.statesCaptured)
			{
				goto IL_0B;
			}
			goto IL_94;
			uint num2;
			bool flag;
			for (;;)
			{
				IL_10:
				uint num;
				switch ((num = (num2 ^ 1300370996U)) % 7U)
				{
				case 1U:
					Visuals.\u206A\u206E\u206E\u202B\u202E\u200B\u202C\u206D\u206B\u206C\u200F\u202A\u200F\u200D\u200B\u202E\u206E\u200D\u200D\u200D\u206E\u202E\u200F\u200E\u202B\u200B\u206B\u202E\u206E\u202C\u200D\u202D\u206E\u206C\u200E\u200C\u202A\u200E\u202E\u200C\u202E().Gameplay.Compass = flag;
					num2 = (num * 1761648850U ^ 2530420952U);
					continue;
				case 2U:
					return;
				case 3U:
					goto IL_0B;
				case 4U:
					Visuals.\u200C\u206E\u206D\u206D\u200B\u206E\u206B\u206F\u202A\u202A\u200D\u202D\u202D\u200D\u206D\u200F\u200B\u202C\u206F\u202A\u206D\u206D\u200C\u206A\u202D\u200D\u202B\u202A\u200B\u200F\u200E\u202B\u202D\u206A\u200E\u206E\u202E\u202C\u206C\u206A\u202E();
					num2 = (num * 2633448159U ^ 1950334257U);
					continue;
				case 5U:
					goto IL_94;
				case 6U:
					goto IL_64;
				}
				break;
			}
			return;
			IL_64:
			bool flag2 = this.serverCompass;
			goto IL_6D;
			IL_0B:
			num2 = 307556439U;
			goto IL_10;
			IL_6D:
			flag = flag2;
			num2 = ((Visuals.\u206A\u206E\u206E\u202B\u202E\u200B\u202C\u206D\u206B\u206C\u200F\u202A\u200F\u200D\u200B\u202E\u206E\u200D\u200D\u200D\u206E\u202E\u200F\u200E\u202B\u200B\u206B\u202E\u206E\u202C\u200D\u202D\u206E\u206C\u200E\u200C\u202A\u200E\u202E\u200C\u202E().Gameplay.Compass != flag) ? 1276403706U : 1624704193U);
			goto IL_10;
			IL_94:
			if (!this.AlwaysCompass)
			{
				num2 = 1220076270U;
				goto IL_10;
			}
			flag2 = true;
			goto IL_6D;
		}

		// Token: 0x06000185 RID: 389 RVA: 0x0001087C File Offset: 0x0000EA7C
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void RefreshMapUI()
		{
			try
			{
				Type type = Visuals.\u200B\u202D\u202E\u202E\u202E\u200B\u200F\u200B\u206E\u202D\u206E\u206A\u202B\u206B\u206C\u202B\u202A\u200C\u206F\u202A\u202C\u206A\u202A\u206F\u206A\u202D\u202E\u202B\u206C\u206C\u200F\u206F\u206D\u200B\u200C\u206F\u202D\u200F\u202A\u202E\u202E(typeof(PlayerDashboardInformationUI).TypeHandle);
				for (;;)
				{
					IL_0B:
					uint num = 1330584832U;
					for (;;)
					{
						uint num2;
						BindingFlags bindingFlags;
						bool flag;
						bool flag2;
						bool flag3;
						int num3;
						MethodInfo methodInfo;
						bool flag4;
						switch ((num2 = (num ^ 251398970U)) % 21U)
						{
						case 0U:
							goto IL_8D;
						case 1U:
						{
							FieldInfo fieldInfo = Visuals.\u206D\u206B\u202C\u202A\u200F\u200C\u202E\u200E\u202E\u206E\u200C\u200C\u202D\u202C\u206C\u200F\u202A\u206D\u200F\u202C\u206E\u200B\u206E\u206B\u206E\u206A\u202B\u200B\u200E\u206A\u202E\u206A\u206C\u202A\u202A\u202A\u200C\u206C\u206D\u202C\u202E(type, <Module>.\u200F\u206F\u200E\u202A\u200D\u200C\u206A\u200E\u202E\u202C\u200D\u202D\u200D\u202B\u200F\u200C\u200F\u200D\u206B\u206D\u206E\u202A\u206C\u206B\u200B\u200F\u206D\u206A\u202E\u206C\u206F\u206A\u200C\u200C\u206C\u202A\u206F\u206A\u202D\u206E\u202E<string>(-1640425476), bindingFlags);
							if (fieldInfo == null)
							{
								goto IL_8D;
							}
							fieldInfo.\u200C\u202B\u200D\u200C\u200B\u202C\u206F\u202D\u206E\u202A\u202D\u206C\u206B\u200B\u200F\u206B\u200C\u202C\u200B\u202D\u202A\u202E\u200E\u206A\u200B\u200C\u206A\u202E\u202A\u206B\u206F\u202C\u202E\u206A\u202B\u206E\u206C\u202E\u206A\u202A\u202E(null, flag);
							num = 1443025072U;
							continue;
						}
						case 2U:
						{
							FieldInfo fieldInfo2;
							num = (((!Visuals.\u202A\u200E\u206A\u206D\u200E\u206E\u202E\u206B\u202D\u202D\u202A\u200F\u200D\u206F\u206C\u206F\u206E\u200F\u200B\u206F\u200B\u200D\u202D\u206D\u200D\u206C\u202A\u202A\u206D\u200C\u200C\u200B\u200E\u202B\u206D\u200C\u206F\u202D\u206B\u200C\u202E(fieldInfo2, null)) ? 2611419502U : 2425008438U) ^ num2 * 1729218675U);
							continue;
						}
						case 3U:
							flag2 = (Visuals.\u206F\u206E\u200D\u202A\u200F\u206F\u200B\u202C\u206C\u206F\u202B\u200B\u202D\u202B\u206D\u200F\u200E\u202B\u200F\u206F\u206F\u202B\u200F\u200D\u206B\u200D\u202A\u206C\u202C\u200C\u206F\u200D\u200B\u206E\u202E\u206D\u202B\u206B\u206B\u200F\u202E(Visuals.\u200F\u202B\u200F\u200C\u206A\u206F\u206F\u200D\u202C\u206C\u206F\u200D\u202A\u206F\u202B\u200E\u206C\u206C\u202C\u206A\u202B\u206C\u206B\u202C\u202E\u206E\u206D\u206E\u202D\u200E\u206C\u200D\u206A\u206F\u206E\u200B\u200F\u200E\u202B\u202E\u202E()) > 0);
							goto IL_2E6;
						case 4U:
							goto IL_BF;
						case 5U:
						{
							object[] array;
							flag3 = (bool)array[1];
							num = (num2 * 1504402365U ^ 325459140U);
							continue;
						}
						case 6U:
							goto IL_0B;
						case 7U:
						{
							object[] array = new object[]
							{
								flag,
								flag3
							};
							num = (num2 * 3426651829U ^ 3735169145U);
							continue;
						}
						case 8U:
						{
							FieldInfo fieldInfo2;
							object obj = Visuals.\u200C\u202C\u202D\u206F\u200E\u202B\u206A\u202E\u206C\u202E\u202C\u202E\u206A\u200D\u200B\u200F\u200C\u206C\u206B\u200F\u200D\u206B\u206F\u202C\u206B\u200C\u202B\u202A\u206F\u202D\u202D\u206F\u200F\u206A\u202A\u200E\u202D\u206B\u206B\u200D\u202E(fieldInfo2, null);
							num = (num2 * 2355608140U ^ 1725788934U);
							continue;
						}
						case 9U:
							bindingFlags = (BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
							num = (num2 * 1782754478U ^ 3885958549U);
							continue;
						case 10U:
						{
							object obj;
							num = (((obj == null) ? 330344081U : 156010178U) ^ num2 * 1055621181U);
							continue;
						}
						case 11U:
							goto IL_1A5;
						case 12U:
							num3 = ((flag3 > false) ? 1 : 0);
							num = (num2 * 2734472582U ^ 3495168723U);
							continue;
						case 13U:
						{
							object[] array;
							Visuals.\u206E\u206D\u206B\u206D\u202A\u206C\u200D\u202A\u206B\u206C\u206F\u206E\u200D\u200D\u206D\u200C\u202E\u206D\u200D\u202E\u206D\u202D\u206C\u202E\u206B\u200B\u202C\u206F\u200C\u202B\u200D\u206C\u206A\u202D\u206C\u206F\u200E\u202C\u202E\u202C\u202E(methodInfo, null, array);
							num = (num2 * 3320877063U ^ 3259623945U);
							continue;
						}
						case 14U:
						{
							FieldInfo fieldInfo2 = Visuals.\u206D\u206B\u202C\u202A\u200F\u200C\u202E\u200E\u202E\u206E\u200C\u200C\u202D\u202C\u206C\u200F\u202A\u206D\u200F\u202C\u206E\u200B\u206E\u206B\u206E\u206A\u202B\u200B\u200E\u206A\u202E\u206A\u206C\u202A\u202A\u202A\u200C\u206C\u206D\u202C\u202E(type, <Module>.\u200F\u206F\u200E\u202A\u200D\u200C\u206A\u200E\u202E\u202C\u200D\u202D\u200D\u202B\u200F\u200C\u200F\u200D\u206B\u206D\u206E\u202A\u206C\u206B\u200B\u200F\u206D\u206A\u202E\u206C\u206F\u206A\u200C\u200C\u206C\u202A\u206F\u206A\u202D\u206E\u202E<string>(-1190577490), bindingFlags);
							num = 1845324935U;
							continue;
						}
						case 15U:
							goto IL_33E;
						case 17U:
						{
							object[] array;
							flag = (bool)array[0];
							num = (num2 * 1493903143U ^ 4223667103U);
							continue;
						}
						case 18U:
						{
							object obj;
							PropertyInfo propertyInfo = Visuals.\u200B\u206F\u206B\u206E\u202E\u202A\u206E\u202D\u200F\u202B\u200C\u206D\u200C\u200F\u200D\u202D\u200F\u202B\u200C\u200E\u206A\u206A\u202B\u206F\u206C\u206A\u206F\u202B\u200D\u206B\u206F\u202C\u202B\u200E\u200B\u200C\u200C\u200B\u206E\u206E\u202E(Visuals.\u200D\u200D\u206F\u206B\u200C\u206C\u200B\u206D\u200F\u206F\u206D\u206F\u206B\u206E\u200D\u206D\u202D\u200F\u206E\u206A\u200D\u202E\u202D\u206A\u200E\u206E\u206C\u206F\u200F\u200F\u202D\u200B\u200D\u206E\u200C\u202E\u206E\u202A\u200C\u206E\u202E(obj), <Module>.\u202B\u200B\u202C\u206C\u206D\u202C\u206B\u200F\u206D\u206D\u200E\u206A\u202E\u206D\u200D\u206A\u202D\u202B\u200B\u200F\u202C\u206D\u200E\u202D\u200D\u206A\u200F\u206E\u206F\u206F\u200D\u202D\u202C\u200B\u206F\u202C\u202A\u200D\u206E\u202E\u202E<string>(-1960746147));
							if (propertyInfo == null)
							{
								goto IL_BF;
							}
							Visuals.\u202D\u202E\u206C\u202A\u202B\u200D\u200F\u202A\u200B\u202E\u202B\u206A\u200F\u206F\u202C\u202D\u202E\u206A\u202D\u202E\u202A\u206B\u206F\u202A\u206C\u206A\u202C\u206B\u206B\u202D\u206C\u202E\u202D\u206F\u206D\u202A\u200F\u202A\u200D\u206C\u202E(propertyInfo, obj, num3);
							num = 446519433U;
							continue;
						}
						case 19U:
							if (!Visuals.\u206A\u206E\u206E\u202B\u202E\u200B\u202C\u206D\u206B\u206C\u200F\u202A\u200F\u200D\u200B\u202E\u206E\u200D\u200D\u200D\u206E\u202E\u200F\u200E\u202B\u200B\u206B\u202E\u206E\u202C\u200D\u202D\u206E\u206C\u200E\u200C\u202A\u200E\u202E\u200C\u202E().Gameplay.Chart)
							{
								num = (num2 * 1135814452U ^ 1862281417U);
								continue;
							}
							flag2 = true;
							goto IL_2E6;
						case 20U:
							flag4 = (Visuals.\u206F\u206E\u200D\u202A\u200F\u206F\u200B\u202C\u206C\u206F\u202B\u200B\u202D\u202B\u206D\u200F\u200E\u202B\u200F\u206F\u206F\u202B\u200F\u200D\u206B\u200D\u202A\u206C\u202C\u200C\u206F\u200D\u200B\u206E\u202E\u206D\u202B\u206B\u206B\u200F\u202E(Visuals.\u200F\u202B\u200F\u200C\u206A\u206F\u206F\u200D\u202C\u206C\u206F\u200D\u202A\u206F\u202B\u200E\u206C\u206C\u202C\u206A\u202B\u206C\u206B\u202C\u202E\u206E\u206D\u206E\u202D\u200E\u206C\u200D\u206A\u206F\u206E\u200B\u200F\u200E\u202B\u202E\u202E()) > 0);
							goto IL_24B;
						}
						goto Block_2;
						IL_8D:
						FieldInfo fieldInfo3 = Visuals.\u206D\u206B\u202C\u202A\u200F\u200C\u202E\u200E\u202E\u206E\u200C\u200C\u202D\u202C\u206C\u200F\u202A\u206D\u200F\u202C\u206E\u200B\u206E\u206B\u206E\u206A\u202B\u200B\u200E\u206A\u202E\u206A\u206C\u202A\u202A\u202A\u200C\u206C\u206D\u202C\u202E(type, <Module>.\u206A\u202C\u206A\u206C\u202A\u206F\u200B\u206C\u206C\u206B\u206F\u206C\u200C\u206D\u200C\u200C\u206C\u206A\u202A\u206B\u200B\u202E\u200C\u206E\u202D\u202A\u200E\u202D\u200E\u200E\u200D\u200E\u202B\u202A\u206E\u202A\u200B\u200B\u202D\u202E<string>(2078730139), bindingFlags);
						if (fieldInfo3 == null)
						{
							goto IL_1A5;
						}
						fieldInfo3.\u200C\u202B\u200D\u200C\u200B\u202C\u206F\u202D\u206E\u202A\u202D\u206C\u206B\u200B\u200F\u206B\u200C\u202C\u200B\u202D\u202A\u202E\u200E\u206A\u200B\u200C\u206A\u202E\u202A\u206B\u206F\u202C\u202E\u206A\u202B\u206E\u206C\u202E\u206A\u202A\u202E(null, flag3);
						num = 419654024U;
						continue;
						IL_BF:
						MethodInfo methodInfo2 = Visuals.\u202B\u202C\u206A\u200C\u200F\u206F\u200B\u206F\u202C\u206B\u202C\u200E\u202D\u200D\u202A\u202E\u206F\u206B\u202D\u200F\u206D\u202A\u200F\u202A\u202A\u200B\u202D\u206D\u206F\u202E\u206B\u200D\u202B\u206E\u200B\u206A\u200D\u206E\u200C\u206C\u202E(type, <Module>.\u202E\u206C\u206E\u202C\u202D\u202D\u206D\u206B\u202B\u206F\u200B\u206E\u200B\u202C\u202A\u200D\u202D\u200B\u202D\u202E\u200D\u206F\u206C\u202C\u200B\u202C\u206D\u202B\u206C\u206E\u200E\u206A\u200D\u206F\u200E\u206E\u206A\u200C\u200D\u206B\u202E<string>(-290387122), bindingFlags);
						if (methodInfo2 == null)
						{
							goto IL_33E;
						}
						methodInfo2.\u206F\u200B\u200D\u202B\u206E\u206B\u202B\u200B\u206E\u206A\u206E\u202E\u206D\u200E\u206D\u202C\u202D\u200E\u206B\u202C\u202A\u202C\u200F\u202C\u202D\u200E\u202D\u200D\u202B\u200B\u200E\u202A\u202D\u200D\u202B\u206F\u206E\u200C\u200B\u206A\u202E(null, new object[]
						{
							num3
						});
						num = 892126318U;
						continue;
						IL_1A5:
						num = (PlayerDashboardInformationUI.active ? 434096390U : 901408321U);
						continue;
						IL_24B:
						flag3 = flag4;
						methodInfo = Visuals.\u202B\u202C\u206A\u200C\u200F\u206F\u200B\u206F\u202C\u206B\u202C\u200E\u202D\u200D\u202A\u202E\u206F\u206B\u202D\u200F\u206D\u202A\u200F\u202A\u202A\u200B\u202D\u206D\u206F\u202E\u206B\u200D\u202B\u206E\u200B\u206A\u200D\u206E\u200C\u206C\u202E(type, <Module>.\u200B\u206C\u200C\u200C\u206A\u200B\u200D\u206C\u206B\u206D\u202B\u200F\u200E\u206E\u206A\u200D\u206B\u202E\u206A\u200E\u200B\u202E\u200F\u206C\u200F\u202A\u202B\u200F\u200D\u200C\u202D\u200E\u206B\u200D\u202A\u200E\u202E\u206A\u202B\u200C\u202E<string>(1833498099), bindingFlags);
						num = ((!Visuals.\u200E\u202A\u202A\u206A\u200E\u200E\u202D\u202D\u200D\u206A\u206A\u200E\u200B\u202E\u206A\u202E\u206E\u200D\u202B\u200C\u206E\u202D\u202D\u206A\u206E\u200D\u206C\u200F\u206B\u200D\u200B\u202A\u200B\u206E\u202A\u200C\u206B\u206E\u200B\u200D\u202E(methodInfo, null)) ? 1594477043U : 433629782U);
						continue;
						IL_2E6:
						flag = flag2;
						if (!Visuals.\u206A\u206E\u206E\u202B\u202E\u200B\u202C\u206D\u206B\u206C\u200F\u202A\u200F\u200D\u200B\u202E\u206E\u200D\u200D\u200D\u206E\u202E\u200F\u200E\u202B\u200B\u206B\u202E\u206E\u202C\u200D\u202D\u206E\u206C\u200E\u200C\u202A\u200E\u202E\u200C\u202E().Gameplay.Satellite)
						{
							num = 1498037510U;
							continue;
						}
						flag4 = true;
						goto IL_24B;
						IL_33E:
						MethodInfo methodInfo3 = Visuals.\u202B\u202C\u206A\u200C\u200F\u206F\u200B\u206F\u202C\u206B\u202C\u200E\u202D\u200D\u202A\u202E\u206F\u206B\u202D\u200F\u206D\u202A\u200F\u202A\u202A\u200B\u202D\u206D\u206F\u202E\u206B\u200D\u202B\u206E\u200B\u206A\u200D\u206E\u200C\u206C\u202E(type, <Module>.\u200F\u206F\u200E\u202A\u200D\u200C\u206A\u200E\u202E\u202C\u200D\u202D\u200D\u202B\u200F\u200C\u200F\u200D\u206B\u206D\u206E\u202A\u206C\u206B\u200B\u200F\u206D\u206A\u202E\u206C\u206F\u206A\u200C\u200C\u206C\u202A\u206F\u206A\u202D\u206E\u202E<string>(848012733), bindingFlags);
						if (methodInfo3 == null)
						{
							goto Block_13;
						}
						methodInfo3.\u206F\u200B\u200D\u202B\u206E\u206B\u202B\u200B\u206E\u206A\u206E\u202E\u206D\u200E\u206D\u202C\u202D\u200E\u206B\u202C\u202A\u202C\u200F\u202C\u202D\u200E\u202D\u200D\u202B\u200B\u200E\u202A\u202D\u200D\u202B\u206F\u206E\u200C\u200B\u206A\u202E(null, null);
						num = 901408321U;
					}
				}
				Block_2:
				Block_13:;
			}
			catch
			{
			}
		}

		// Token: 0x06000186 RID: 390 RVA: 0x00010C14 File Offset: 0x0000EE14
		public void ToggleAlwaysDay()
		{
			this.AlwaysDay = !this.AlwaysDay;
		}

		// Token: 0x06000187 RID: 391 RVA: 0x00010C30 File Offset: 0x0000EE30
		public void ToggleSatellite()
		{
			this.AlwaysSatellite = !this.AlwaysSatellite;
		}

		// Token: 0x06000188 RID: 392 RVA: 0x00010C4C File Offset: 0x0000EE4C
		public void ToggleCompass()
		{
			this.AlwaysCompass = !this.AlwaysCompass;
		}

		// Token: 0x0600018A RID: 394 RVA: 0x00010C88 File Offset: 0x0000EE88
		static Delegate \u202C\u200F\u200E\u202D\u202C\u200F\u206C\u200B\u200D\u200C\u206E\u202C\u200C\u200F\u206E\u200D\u202B\u200E\u206D\u206E\u202A\u202D\u202C\u202E\u200C\u206B\u202D\u200D\u200C\u202A\u206C\u200F\u206D\u202C\u200B\u202E\u202A\u202E\u200C\u206A\u202E(Delegate A_0, Delegate A_1)
		{
			return Delegate.Combine(A_0, A_1);
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00010C9C File Offset: 0x0000EE9C
		static Delegate \u206E\u206C\u202C\u206F\u200D\u206B\u206C\u200D\u206B\u206C\u206F\u202A\u200F\u200B\u206E\u202C\u202A\u206E\u200C\u202B\u202E\u206A\u202E\u202E\u200D\u200D\u206C\u202A\u200E\u206C\u202B\u202A\u206F\u202C\u202D\u200C\u202E\u200B\u206B\u202D\u202E(Delegate A_0, Delegate A_1)
		{
			return Delegate.Remove(A_0, A_1);
		}

		// Token: 0x0600018C RID: 396 RVA: 0x000076B8 File Offset: 0x000058B8
		static bool \u200C\u206A\u202B\u200B\u206D\u206E\u200D\u206E\u200B\u206A\u206F\u206A\u206A\u206A\u200E\u200E\u202C\u200C\u202C\u206C\u200B\u202B\u200B\u200D\u202B\u202A\u202B\u206F\u200F\u206E\u206B\u200E\u202E\u202C\u200B\u206E\u202E\u200F\u202D\u206B\u202E()
		{
			return Provider.isConnected;
		}

		// Token: 0x0600018D RID: 397 RVA: 0x000076CC File Offset: 0x000058CC
		static bool \u200C\u206A\u202D\u206B\u200E\u200D\u206D\u206F\u202C\u200F\u202C\u206D\u206C\u206E\u202A\u206B\u202D\u206D\u206B\u202B\u200F\u206D\u206F\u206B\u200C\u202A\u202B\u206D\u202A\u202B\u200C\u206F\u200C\u202C\u202E\u200C\u202A\u200E\u200E\u206C\u202E()
		{
			return Provider.isLoading;
		}

		// Token: 0x0600018E RID: 398 RVA: 0x00010CB0 File Offset: 0x0000EEB0
		static bool \u206B\u206A\u200D\u202C\u200F\u200B\u202D\u206A\u206A\u202B\u200F\u202B\u206F\u200D\u202D\u206B\u202B\u200F\u200E\u206A\u200F\u202C\u206F\u206C\u200B\u206D\u202B\u206C\u202B\u206B\u206F\u200B\u202E\u200D\u206E\u202A\u206A\u206D\u200B\u200C\u202E()
		{
			return Level.isLoaded;
		}

		// Token: 0x0600018F RID: 399 RVA: 0x00010CC4 File Offset: 0x0000EEC4
		static ModeConfigData \u206A\u206E\u206E\u202B\u202E\u200B\u202C\u206D\u206B\u206C\u200F\u202A\u200F\u200D\u200B\u202E\u206E\u200D\u200D\u200D\u206E\u202E\u200F\u200E\u202B\u200B\u206B\u202E\u206E\u202C\u200D\u202D\u206E\u206C\u200E\u200C\u202A\u200E\u202E\u200C\u202E()
		{
			return Provider.modeConfigData;
		}

		// Token: 0x06000190 RID: 400 RVA: 0x00010CD8 File Offset: 0x0000EED8
		static uint \u200E\u202C\u202D\u200C\u206A\u206A\u200B\u200C\u200B\u202B\u202A\u206E\u206D\u206D\u200C\u206D\u206A\u202C\u200E\u202C\u206E\u200C\u200C\u202E\u206F\u206E\u206F\u200D\u200E\u206A\u202E\u202C\u206C\u200B\u200D\u206F\u202B\u202D\u200D\u202E()
		{
			return LightingManager.offset;
		}

		// Token: 0x06000191 RID: 401 RVA: 0x00010CEC File Offset: 0x0000EEEC
		static void \u206E\u202D\u200E\u200B\u200F\u200E\u206A\u202D\u206F\u202C\u206C\u200D\u206E\u200B\u206C\u206E\u202B\u200B\u202D\u202A\u200B\u202D\u200D\u202E\u206F\u206D\u200D\u202B\u200E\u200F\u202B\u202A\u200C\u200C\u206F\u202C\u200C\u202E\u200E\u206E\u202E(uint A_0)
		{
			LightingManager.time = A_0;
		}

		// Token: 0x06000192 RID: 402 RVA: 0x0000E3C0 File Offset: 0x0000C5C0
		static uint \u202E\u202C\u200D\u200B\u206B\u202A\u202C\u206A\u200B\u202A\u200C\u202B\u206A\u206B\u206B\u206F\u206D\u206B\u200F\u200D\u200B\u206B\u206D\u206F\u206F\u200D\u200E\u206A\u206B\u202C\u202A\u206C\u200E\u200E\u202C\u206A\u200E\u202D\u200F\u202A\u202E()
		{
			return Provider.time;
		}

		// Token: 0x06000193 RID: 403 RVA: 0x00010D00 File Offset: 0x0000EF00
		static void \u200C\u206E\u206D\u206D\u200B\u206E\u206B\u206F\u202A\u202A\u200D\u202D\u202D\u200D\u206D\u200F\u200B\u202C\u206F\u202A\u206D\u206D\u200C\u206A\u202D\u200D\u202B\u202A\u200B\u200F\u200E\u202B\u202D\u206A\u200E\u206E\u202E\u202C\u206C\u206A\u202E()
		{
			PlayerLifeUI.updateCompass();
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00007860 File Offset: 0x00005A60
		static Type \u200B\u202D\u202E\u202E\u202E\u200B\u200F\u200B\u206E\u202D\u206E\u206A\u202B\u206B\u206C\u202B\u202A\u200C\u206F\u202A\u202C\u206A\u202A\u206F\u206A\u202D\u202E\u202B\u206C\u206C\u200F\u206F\u206D\u200B\u200C\u206F\u202D\u200F\u202A\u202E\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		// Token: 0x06000195 RID: 405 RVA: 0x00010D14 File Offset: 0x0000EF14
		static LevelInfo \u200F\u202B\u200F\u200C\u206A\u206F\u206F\u200D\u202C\u206C\u206F\u200D\u202A\u206F\u202B\u200E\u206C\u206C\u202C\u206A\u202B\u206C\u206B\u202C\u202E\u206E\u206D\u206E\u202D\u200E\u206C\u200D\u206A\u206F\u206E\u200B\u200F\u200E\u202B\u202E\u202E()
		{
			return Level.info;
		}

		// Token: 0x06000196 RID: 406 RVA: 0x00010D28 File Offset: 0x0000EF28
		static ELevelType \u206F\u206E\u200D\u202A\u200F\u206F\u200B\u202C\u206C\u206F\u202B\u200B\u202D\u202B\u206D\u200F\u200E\u202B\u200F\u206F\u206F\u202B\u200F\u200D\u206B\u200D\u202A\u206C\u202C\u200C\u206F\u200D\u200B\u206E\u202E\u206D\u202B\u206B\u206B\u200F\u202E(LevelInfo A_0)
		{
			return A_0.type;
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00010D3C File Offset: 0x0000EF3C
		static MethodInfo \u202B\u202C\u206A\u200C\u200F\u206F\u200B\u206F\u202C\u206B\u202C\u200E\u202D\u200D\u202A\u202E\u206F\u206B\u202D\u200F\u206D\u202A\u200F\u202A\u202A\u200B\u202D\u206D\u206F\u202E\u206B\u200D\u202B\u206E\u200B\u206A\u200D\u206E\u200C\u206C\u202E(Type A_0, string A_1, BindingFlags A_2)
		{
			return A_0.GetMethod(A_1, A_2);
		}

		// Token: 0x06000198 RID: 408 RVA: 0x00010D54 File Offset: 0x0000EF54
		static bool \u200E\u202A\u202A\u206A\u200E\u200E\u202D\u202D\u200D\u206A\u206A\u200E\u200B\u202E\u206A\u202E\u206E\u200D\u202B\u200C\u206E\u202D\u202D\u206A\u206E\u200D\u206C\u200F\u206B\u200D\u200B\u202A\u200B\u206E\u202A\u200C\u206B\u206E\u200B\u200D\u202E(MethodInfo A_0, MethodInfo A_1)
		{
			return A_0 != A_1;
		}

		// Token: 0x06000199 RID: 409 RVA: 0x00010D68 File Offset: 0x0000EF68
		static object \u206E\u206D\u206B\u206D\u202A\u206C\u200D\u202A\u206B\u206C\u206F\u206E\u200D\u200D\u206D\u200C\u202E\u206D\u200D\u202E\u206D\u202D\u206C\u202E\u206B\u200B\u202C\u206F\u200C\u202B\u200D\u206C\u206A\u202D\u206C\u206F\u200E\u202C\u202E\u202C\u202E(MethodBase A_0, object A_1, object[] A_2)
		{
			return A_0.Invoke(A_1, A_2);
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00007874 File Offset: 0x00005A74
		static FieldInfo \u206D\u206B\u202C\u202A\u200F\u200C\u202E\u200E\u202E\u206E\u200C\u200C\u202D\u202C\u206C\u200F\u202A\u206D\u200F\u202C\u206E\u200B\u206E\u206B\u206E\u206A\u202B\u200B\u200E\u206A\u202E\u206A\u206C\u202A\u202A\u202A\u200C\u206C\u206D\u202C\u202E(Type A_0, string A_1, BindingFlags A_2)
		{
			return A_0.GetField(A_1, A_2);
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00010D80 File Offset: 0x0000EF80
		void \u200C\u202B\u200D\u200C\u200B\u202C\u206F\u202D\u206E\u202A\u202D\u206C\u206B\u200B\u200F\u206B\u200C\u202C\u200B\u202D\u202A\u202E\u200E\u206A\u200B\u200C\u206A\u202E\u202A\u206B\u206F\u202C\u202E\u206A\u202B\u206E\u206C\u202E\u206A\u202A\u202E(object A_1, object A_2)
		{
			base.SetValue(A_1, A_2);
		}

		// Token: 0x0600019C RID: 412 RVA: 0x00007B48 File Offset: 0x00005D48
		static bool \u202A\u200E\u206A\u206D\u200E\u206E\u202E\u206B\u202D\u202D\u202A\u200F\u200D\u206F\u206C\u206F\u206E\u200F\u200B\u206F\u200B\u200D\u202D\u206D\u200D\u206C\u202A\u202A\u206D\u200C\u200C\u200B\u200E\u202B\u206D\u200C\u206F\u202D\u206B\u200C\u202E(FieldInfo A_0, FieldInfo A_1)
		{
			return A_0 != A_1;
		}

		// Token: 0x0600019D RID: 413 RVA: 0x0000788C File Offset: 0x00005A8C
		static object \u200C\u202C\u202D\u206F\u200E\u202B\u206A\u202E\u206C\u202E\u202C\u202E\u206A\u200D\u200B\u200F\u200C\u206C\u206B\u200F\u200D\u206B\u206F\u202C\u206B\u200C\u202B\u202A\u206F\u202D\u202D\u206F\u200F\u206A\u202A\u200E\u202D\u206B\u206B\u200D\u202E(FieldInfo A_0, object A_1)
		{
			return A_0.GetValue(A_1);
		}

		// Token: 0x0600019E RID: 414 RVA: 0x00010D98 File Offset: 0x0000EF98
		static Type \u200D\u200D\u206F\u206B\u200C\u206C\u200B\u206D\u200F\u206F\u206D\u206F\u206B\u206E\u200D\u206D\u202D\u200F\u206E\u206A\u200D\u202E\u202D\u206A\u200E\u206E\u206C\u206F\u200F\u200F\u202D\u200B\u200D\u206E\u200C\u202E\u206E\u202A\u200C\u206E\u202E(object A_0)
		{
			return A_0.GetType();
		}

		// Token: 0x0600019F RID: 415 RVA: 0x00010DAC File Offset: 0x0000EFAC
		static PropertyInfo \u200B\u206F\u206B\u206E\u202E\u202A\u206E\u202D\u200F\u202B\u200C\u206D\u200C\u200F\u200D\u202D\u200F\u202B\u200C\u200E\u206A\u206A\u202B\u206F\u206C\u206A\u206F\u202B\u200D\u206B\u206F\u202C\u202B\u200E\u200B\u200C\u200C\u200B\u206E\u206E\u202E(Type A_0, string A_1)
		{
			return A_0.GetProperty(A_1);
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x00010DC0 File Offset: 0x0000EFC0
		static void \u202D\u202E\u206C\u202A\u202B\u200D\u200F\u202A\u200B\u202E\u202B\u206A\u200F\u206F\u202C\u202D\u202E\u206A\u202D\u202E\u202A\u206B\u206F\u202A\u206C\u206A\u202C\u206B\u206B\u202D\u206C\u202E\u202D\u206F\u206D\u202A\u200F\u202A\u200D\u206C\u202E(PropertyInfo A_0, object A_1, object A_2)
		{
			A_0.SetValue(A_1, A_2);
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x00010DD8 File Offset: 0x0000EFD8
		object \u206F\u200B\u200D\u202B\u206E\u206B\u202B\u200B\u206E\u206A\u206E\u202E\u206D\u200E\u206D\u202C\u202D\u200E\u206B\u202C\u202A\u202C\u200F\u202C\u202D\u200E\u202D\u200D\u202B\u200B\u200E\u202A\u202D\u200D\u202B\u206F\u206E\u200C\u200B\u206A\u202E(object A_1, object[] A_2)
		{
			return base.Invoke(A_1, A_2);
		}

		// Token: 0x040000A7 RID: 167
		public bool AlwaysDay;

		// Token: 0x040000A8 RID: 168
		public uint CustomDayTime = 1200U;

		// Token: 0x040000A9 RID: 169
		public bool AlwaysSatellite;

		// Token: 0x040000AA RID: 170
		public bool AlwaysCompass;

		// Token: 0x040000AB RID: 171
		private uint dayOffset;

		// Token: 0x040000AC RID: 172
		private bool statesCaptured;

		// Token: 0x040000AD RID: 173
		private bool serverSatellite;

		// Token: 0x040000AE RID: 174
		private bool serverChart;

		// Token: 0x040000AF RID: 175
		private bool serverCompass;
	}
}
