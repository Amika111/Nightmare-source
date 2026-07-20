using System;
using System.Collections.Generic;
using SDG.Unturned;
using UnityEngine;

namespace Cheat.core
{
	// Token: 0x02000021 RID: 33
	public class Entities : MonoBehaviour
	{
		// Token: 0x17000005 RID: 5
		// (get) Token: 0x060001C3 RID: 451 RVA: 0x000137D4 File Offset: 0x000119D4
		// (set) Token: 0x060001C4 RID: 452 RVA: 0x000137E8 File Offset: 0x000119E8
		internal List<Player> Players { get; private set; } = new List<Player>();

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x060001C5 RID: 453 RVA: 0x000137FC File Offset: 0x000119FC
		// (set) Token: 0x060001C6 RID: 454 RVA: 0x00013810 File Offset: 0x00011A10
		internal List<Zombie> Zombies { get; private set; } = new List<Zombie>();

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x060001C7 RID: 455 RVA: 0x00013824 File Offset: 0x00011A24
		// (set) Token: 0x060001C8 RID: 456 RVA: 0x00013838 File Offset: 0x00011A38
		internal List<InteractableItem> Items { get; private set; } = new List<InteractableItem>();

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x060001C9 RID: 457 RVA: 0x0001384C File Offset: 0x00011A4C
		// (set) Token: 0x060001CA RID: 458 RVA: 0x00013860 File Offset: 0x00011A60
		internal List<InteractableVehicle> Vehicles { get; private set; } = new List<InteractableVehicle>();

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x060001CB RID: 459 RVA: 0x00013874 File Offset: 0x00011A74
		// (set) Token: 0x060001CC RID: 460 RVA: 0x00013888 File Offset: 0x00011A88
		internal List<BarricadeDrop> Beds { get; private set; } = new List<BarricadeDrop>();

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x060001CD RID: 461 RVA: 0x0001389C File Offset: 0x00011A9C
		// (set) Token: 0x060001CE RID: 462 RVA: 0x000138B0 File Offset: 0x00011AB0
		internal List<BarricadeDrop> Claims { get; private set; } = new List<BarricadeDrop>();

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x060001CF RID: 463 RVA: 0x000138C4 File Offset: 0x00011AC4
		// (set) Token: 0x060001D0 RID: 464 RVA: 0x000138D8 File Offset: 0x00011AD8
		internal List<BarricadeDrop> Furniture { get; private set; } = new List<BarricadeDrop>();

		// Token: 0x060001D1 RID: 465 RVA: 0x000138EC File Offset: 0x00011AEC
		private void Awake()
		{
			Entities.\u200E\u206D\u206A\u206F\u202C\u202B\u200B\u206B\u200F\u200C\u202E\u202D\u206C\u200F\u206F\u202B\u202B\u202A\u202B\u206B\u202B\u206A\u206B\u202A\u206E\u202B\u206E\u202E\u206D\u202C\u206F\u206F\u202B\u202A\u200C\u200C\u206F\u202E\u206D\u202D\u202E(Entities.\u200C\u202A\u202D\u202C\u202B\u202D\u202C\u202B\u200D\u202A\u202A\u202C\u202C\u202B\u200B\u206E\u206C\u200B\u206A\u206B\u206B\u202B\u206D\u206F\u206E\u200F\u200E\u206F\u200F\u202A\u206C\u206A\u206E\u200E\u200E\u202B\u200E\u202E\u206B\u202A\u202E(this));
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x00013904 File Offset: 0x00011B04
		private void Update()
		{
			if (Entities.\u200B\u200F\u206D\u200C\u200B\u202A\u206D\u202B\u206F\u202E\u206C\u206F\u206F\u206E\u202C\u202E\u200D\u200B\u202D\u202A\u206F\u202D\u202C\u206A\u206B\u206C\u200C\u200F\u200B\u202A\u200F\u200F\u206B\u200F\u200B\u202E\u200E\u206C\u206E\u206A\u202E(Entities.\u200C\u206E\u202C\u206B\u200F\u206D\u206A\u202A\u202D\u202B\u206B\u202A\u200E\u200D\u206F\u202A\u206C\u202E\u202B\u206D\u200F\u206D\u200F\u200E\u200D\u202C\u202E\u202C\u206C\u202E\u200B\u202C\u200C\u206B\u206E\u206C\u206C\u200F\u206D\u202A\u202E(), null))
			{
				goto IL_0D;
			}
			goto IL_49;
			uint num2;
			for (;;)
			{
				IL_12:
				uint num;
				switch ((num = (num2 ^ 4229726941U)) % 5U)
				{
				case 0U:
					goto IL_49;
				case 2U:
					if (Entities.\u202A\u200E\u200D\u202C\u206C\u200F\u202A\u200E\u202D\u200D\u200F\u206C\u202D\u200B\u206A\u200C\u200E\u200B\u200C\u202C\u206F\u206C\u206F\u200C\u200C\u202D\u202E\u206D\u202A\u202B\u206E\u206F\u202D\u206F\u200E\u200D\u200C\u206A\u206D\u202A\u202E() != null)
					{
						num2 = (num * 4286831920U ^ 3155591275U);
						continue;
					}
					goto IL_1AF;
				case 3U:
					goto IL_0D;
				case 4U:
					return;
				}
				break;
			}
			using (List<SteamPlayer>.Enumerator enumerator = Entities.\u202A\u200E\u200D\u202C\u206C\u200F\u202A\u200E\u202D\u200D\u200F\u206C\u202D\u200B\u206A\u200C\u200E\u200B\u200C\u202C\u206F\u206C\u206F\u200C\u200C\u202D\u202E\u206D\u202A\u202B\u206E\u206F\u202D\u206F\u200E\u200D\u200C\u206A\u206D\u202A\u202E().GetEnumerator())
			{
				for (;;)
				{
					IL_16D:
					uint num3 = enumerator.MoveNext() ? 3269987298U : 3196445276U;
					for (;;)
					{
						uint num;
						Object @object;
						switch ((num = (num3 ^ 4229726941U)) % 8U)
						{
						case 0U:
							@object = null;
							goto IL_122;
						case 2U:
						{
							SteamPlayer steamPlayer;
							num3 = ((Entities.\u202A\u202B\u206D\u202D\u200E\u200F\u202A\u200D\u200F\u202B\u200B\u202A\u202B\u202A\u200B\u200D\u200D\u206E\u200E\u206A\u202E\u200F\u200F\u206E\u206F\u206B\u206F\u200F\u202E\u206A\u200C\u206F\u206A\u202A\u202C\u206F\u200C\u202A\u200D\u206E\u202E(Entities.\u206D\u200C\u206E\u202E\u206C\u206B\u200C\u202C\u206F\u206D\u206A\u200F\u206D\u206B\u206B\u206B\u206E\u202E\u202A\u200C\u202A\u202C\u202D\u200F\u202A\u200B\u202E\u206F\u202C\u206C\u202E\u206C\u202E\u202E\u200C\u200D\u202D\u206F\u202E\u206A\u202E(Entities.\u202E\u200F\u202B\u200F\u202E\u200B\u206D\u202D\u206F\u206D\u202B\u202D\u202C\u206B\u206C\u200F\u202D\u206C\u202B\u202B\u202E\u206C\u200D\u206E\u206E\u206D\u202B\u200E\u200B\u206A\u202E\u202B\u202D\u200F\u202B\u206E\u200C\u202B\u202C\u206A\u202E(steamPlayer))) ? 2922891861U : 2857420538U) ^ num * 1502019794U);
							continue;
						}
						case 3U:
						{
							SteamPlayer steamPlayer;
							this.Players.Add(Entities.\u202E\u200F\u202B\u200F\u202E\u200B\u206D\u202D\u206F\u206D\u202B\u202D\u202C\u206B\u206C\u200F\u202D\u206C\u202B\u202B\u202E\u206C\u200D\u206E\u206E\u206D\u202B\u200E\u200B\u206A\u202E\u202B\u202D\u200F\u202B\u206E\u200C\u202B\u202C\u206A\u202E(steamPlayer));
							num3 = (num * 3678208778U ^ 1862935135U);
							continue;
						}
						case 4U:
							goto IL_16D;
						case 5U:
						{
							SteamPlayer steamPlayer;
							num3 = ((Entities.\u200B\u200F\u206D\u200C\u200B\u202A\u206D\u202B\u206F\u202E\u206C\u206F\u206F\u206E\u202C\u202E\u200D\u200B\u202D\u202A\u206F\u202D\u202C\u206A\u206B\u206C\u200C\u200F\u200B\u202A\u200F\u200F\u206B\u200F\u200B\u202E\u200E\u206C\u206E\u206A\u202E(Entities.\u202E\u200F\u202B\u200F\u202E\u200B\u206D\u202D\u206F\u206D\u202B\u202D\u202C\u206B\u206C\u200F\u202D\u206C\u202B\u202B\u202E\u206C\u200D\u206E\u206E\u206D\u202B\u200E\u200B\u206A\u202E\u202B\u202D\u200F\u202B\u206E\u200C\u202B\u202C\u206A\u202E(steamPlayer), Entities.\u200C\u206E\u202C\u206B\u200F\u206D\u206A\u202A\u202D\u202B\u206B\u202A\u200E\u200D\u206F\u202A\u206C\u202E\u202B\u206D\u200F\u206D\u200F\u200E\u200D\u202C\u202E\u202C\u206C\u202E\u200B\u202C\u200C\u206B\u206E\u206C\u206C\u200F\u206D\u202A\u202E()) ? 1243006278U : 1383447600U) ^ num * 1102399459U);
							continue;
						}
						case 6U:
							num3 = 3269987298U;
							continue;
						case 7U:
						{
							SteamPlayer steamPlayer = enumerator.Current;
							if (steamPlayer == null)
							{
								num3 = 3030036461U;
								continue;
							}
							@object = Entities.\u202E\u206F\u200C\u206B\u202E\u200D\u200E\u206F\u202C\u206F\u202D\u200D\u200E\u202C\u202E\u202D\u200B\u206E\u202E\u206C\u200C\u206D\u206F\u200C\u202E\u206A\u202A\u202D\u200C\u200C\u202C\u202E\u200E\u200B\u206D\u202B\u206B\u202C\u202D\u200C\u202E(steamPlayer);
							goto IL_122;
						}
						}
						goto Block_24;
						IL_122:
						num3 = ((!Entities.\u200B\u200F\u206D\u200C\u200B\u202A\u206D\u202B\u206F\u202E\u206C\u206F\u206F\u206E\u202C\u202E\u200D\u200B\u202D\u202A\u206F\u202D\u202C\u206A\u206B\u206C\u200C\u200F\u200B\u202A\u200F\u200F\u206B\u200F\u200B\u202E\u200E\u206C\u206E\u206A\u202E(@object, null)) ? 2191881392U : 2421717217U);
					}
				}
				Block_24:;
			}
			goto IL_1AF;
			IL_0D:
			num2 = 2913260273U;
			goto IL_12;
			IL_49:
			this.Players.Clear();
			if (Entities.\u206E\u200E\u202E\u202E\u202E\u206F\u200E\u200E\u202B\u202E\u200E\u202A\u200E\u202A\u202A\u200F\u202B\u200C\u200F\u206B\u206F\u206C\u200F\u202E\u200C\u202B\u200F\u200F\u202D\u202A\u202E\u200F\u200B\u206C\u200E\u200D\u200C\u202A\u200C\u206B\u202E())
			{
				num2 = 4057457004U;
				goto IL_12;
			}
			IL_1AF:
			if (!this.Players.Contains(Entities.\u200C\u206E\u202C\u206B\u200F\u206D\u206A\u202A\u202D\u202B\u206B\u202A\u200E\u200D\u206F\u202A\u206C\u202E\u202B\u206D\u200F\u206D\u200F\u200E\u200D\u202C\u202E\u202C\u206C\u202E\u200B\u202C\u200C\u206B\u206E\u206C\u206C\u200F\u206D\u202A\u202E()))
			{
				goto IL_1C1;
			}
			goto IL_217;
			uint num4;
			for (;;)
			{
				IL_1C6:
				uint num;
				switch ((num = (num4 ^ 4229726941U)) % 5U)
				{
				case 0U:
					goto IL_1C1;
				case 2U:
					goto IL_217;
				case 3U:
					num4 = (((!Entities.\u202A\u202B\u206D\u202D\u200E\u200F\u202A\u200D\u200F\u202B\u200B\u202A\u202B\u202A\u200B\u200D\u200D\u206E\u200E\u206A\u202E\u200F\u200F\u206E\u206F\u206B\u206F\u200F\u202E\u206A\u200C\u206F\u206A\u202A\u202C\u206F\u200C\u202A\u200D\u206E\u202E(Entities.\u206D\u200C\u206E\u202E\u206C\u206B\u200C\u202C\u206F\u206D\u206A\u200F\u206D\u206B\u206B\u206B\u206E\u202E\u202A\u200C\u202A\u202C\u202D\u200F\u202A\u200B\u202E\u206F\u202C\u206C\u202E\u206C\u202E\u202E\u200C\u200D\u202D\u206F\u202E\u206A\u202E(Entities.\u200C\u206E\u202C\u206B\u200F\u206D\u206A\u202A\u202D\u202B\u206B\u202A\u200E\u200D\u206F\u202A\u206C\u202E\u202B\u206D\u200F\u206D\u200F\u200E\u200D\u202C\u202E\u202C\u206C\u202E\u200B\u202C\u200C\u206B\u206E\u206C\u206C\u200F\u206D\u202A\u202E()))) ? 2626278484U : 2479871285U) ^ num * 3818891825U);
					continue;
				case 4U:
					this.Players.Add(Entities.\u200C\u206E\u202C\u206B\u200F\u206D\u206A\u202A\u202D\u202B\u206B\u202A\u200E\u200D\u206F\u202A\u206C\u202E\u202B\u206D\u200F\u206D\u200F\u200E\u200D\u202C\u202E\u202C\u206C\u202E\u200B\u202C\u200C\u206B\u206E\u206C\u206C\u200F\u206D\u202A\u202E());
					num4 = (num * 2666697962U ^ 1818889803U);
					continue;
				}
				break;
			}
			using (List<InteractableVehicle>.Enumerator enumerator2 = Entities.\u202D\u202E\u202A\u206F\u200C\u200E\u200D\u206F\u202E\u200C\u206A\u206F\u206C\u202D\u200E\u200E\u200D\u206B\u200E\u200D\u200E\u202B\u206B\u202A\u200D\u206A\u200D\u202A\u206D\u202E\u200E\u206C\u200F\u202C\u202A\u206F\u200D\u206A\u206F\u206E\u202E().GetEnumerator())
			{
				for (;;)
				{
					IL_297:
					uint num5 = (!enumerator2.MoveNext()) ? 3593088688U : 4206997407U;
					for (;;)
					{
						uint num;
						switch ((num = (num5 ^ 4229726941U)) % 6U)
						{
						case 0U:
							goto IL_297;
						case 1U:
						{
							InteractableVehicle interactableVehicle;
							num5 = ((Entities.\u206E\u206A\u202D\u200C\u206C\u202E\u206F\u202E\u206D\u202C\u202C\u202A\u200F\u202C\u200B\u200D\u206A\u200D\u202E\u202E\u206B\u200F\u200E\u206E\u206E\u202E\u200F\u202E\u200D\u200B\u200B\u202A\u200B\u200F\u200D\u202E\u200E\u200C\u206B\u200F\u202E(interactableVehicle, null) ? 3661046433U : 2220212440U) ^ num * 1062230793U);
							continue;
						}
						case 2U:
						{
							InteractableVehicle interactableVehicle = enumerator2.Current;
							num5 = 2591663460U;
							continue;
						}
						case 3U:
						{
							InteractableVehicle interactableVehicle;
							this.Vehicles.Add(interactableVehicle);
							num5 = (num * 1688499308U ^ 2273347301U);
							continue;
						}
						case 4U:
							num5 = 4206997407U;
							continue;
						}
						goto Block_32;
					}
				}
				Block_32:;
			}
			this.Zombies.Clear();
			for (;;)
			{
				IL_30E:
				int num6 = -198713954;
				for (;;)
				{
					ZombieRegion[] array;
					int num7;
					ZombieRegion zombieRegion;
					switch ((num6 ^ -65240355) % 4)
					{
					case 0:
						goto IL_30E;
					case 1:
						goto IL_369;
					case 2:
						IL_354:
						zombieRegion = array[num7];
						if (zombieRegion != null)
						{
							num6 = -316012;
							continue;
						}
						goto IL_459;
					case 3:
						array = Entities.\u202B\u202D\u202C\u206B\u202A\u200E\u200E\u200B\u202A\u202B\u206E\u200D\u200E\u202C\u202A\u202D\u200B\u202E\u200E\u200C\u202A\u206D\u202D\u200E\u206A\u206E\u206E\u206B\u202B\u200E\u202A\u206A\u206A\u200E\u200C\u206B\u200C\u206C\u206C\u202A\u202E();
						num7 = 0;
						goto IL_609;
					default:
						goto IL_369;
					}
					uint num8;
					for (;;)
					{
						IL_464:
						uint num;
						int num9;
						int num10;
						BarricadeRegion barricadeRegion;
						int num11;
						switch ((num = (num8 ^ 4229726941U)) % 27U)
						{
						case 0U:
							num8 = (num * 2321001550U ^ 1283265669U);
							continue;
						case 1U:
						{
							BarricadeRegion[,] array2;
							num7 = Entities.\u206A\u202D\u202D\u202B\u206E\u206C\u206A\u200E\u206B\u206A\u200F\u200B\u202E\u206F\u200D\u200D\u206A\u206E\u206D\u200C\u206F\u200B\u206D\u202B\u206C\u200D\u202A\u200D\u200D\u206B\u206F\u206C\u202B\u206E\u206B\u206B\u200E\u200F\u200D\u206C\u202E(array2, 0);
							num8 = (num * 2180402138U ^ 2920899501U);
							continue;
						}
						case 2U:
						{
							InteractableItem[] array3;
							InteractableItem interactableItem = array3[num7];
							num8 = (Entities.\u206E\u206A\u202D\u200C\u206C\u202E\u206F\u202E\u206D\u202C\u202C\u202A\u200F\u202C\u200B\u200D\u206A\u200D\u202E\u202E\u206B\u200F\u200E\u206E\u206E\u202E\u200F\u202E\u200D\u200B\u200B\u202A\u200B\u200F\u200D\u202E\u200E\u200C\u206B\u200F\u202E(interactableItem, null) ? 2697147309U : 3560286738U);
							continue;
						}
						case 3U:
							num7 = 0;
							num8 = (num * 1761667218U ^ 2564384797U);
							continue;
						case 4U:
						{
							InteractableItem[] array3;
							num8 = ((num7 >= array3.Length) ? 4113306674U : 2771081021U);
							continue;
						}
						case 5U:
						{
							InteractableItem interactableItem;
							num8 = (((!Entities.\u200D\u206B\u206E\u206F\u206B\u206D\u200B\u200C\u206A\u206C\u202B\u200F\u202E\u206B\u202A\u206A\u200B\u206D\u206E\u206A\u206F\u200F\u206C\u202A\u202E\u206A\u202E\u202C\u202C\u200F\u206B\u206B\u206D\u202E\u200C\u200F\u206D\u202E\u202D\u202E\u202E(Entities.\u202E\u206C\u206D\u206A\u200C\u206A\u206C\u202B\u202B\u202E\u200C\u200D\u202E\u200E\u206A\u206F\u200D\u200E\u200C\u206E\u206A\u206C\u200C\u200D\u206A\u202B\u206C\u200D\u202A\u206B\u200D\u202B\u206D\u206A\u200D\u200F\u206F\u206F\u206C\u206E\u202E(interactableItem))) ? 2252084766U : 3742677348U) ^ num * 2656956556U);
							continue;
						}
						case 6U:
							this.Claims.Clear();
							num8 = (num * 3165683927U ^ 287903374U);
							continue;
						case 7U:
						{
							InteractableItem interactableItem;
							num8 = (((interactableItem.asset == null) ? 322271090U : 1529094172U) ^ num * 3488239258U);
							continue;
						}
						case 8U:
						{
							BarricadeRegion[,] array2;
							num9 = Entities.\u206A\u202D\u202D\u202B\u206E\u206C\u206A\u200E\u206B\u206A\u200F\u200B\u202E\u206F\u200D\u200D\u206A\u206E\u206D\u200C\u206F\u200B\u206D\u202B\u206C\u200D\u202A\u200D\u200D\u206B\u206F\u206C\u202B\u206E\u206B\u206B\u200E\u200F\u200D\u206C\u202E(array2, 1);
							num8 = (num * 163035881U ^ 1767728879U);
							continue;
						}
						case 9U:
							if (Entities.\u206D\u206A\u202D\u202D\u206D\u206B\u206F\u206E\u206B\u200D\u206C\u202B\u202B\u202B\u202A\u206F\u202D\u200B\u206E\u206A\u206C\u206E\u202C\u206D\u200C\u206A\u202E\u206E\u206D\u200F\u200D\u206C\u200C\u206D\u202E\u200E\u206F\u202C\u206A\u206E\u202E() - this.lastItemScanTime >= 2f)
							{
								num8 = (num * 1853583289U ^ 4039440525U);
								continue;
							}
							return;
						case 10U:
							num7++;
							num8 = 4001759045U;
							continue;
						case 11U:
						{
							BarricadeRegion[,] array2;
							num10 = Entities.\u200E\u202D\u202C\u202A\u200E\u200B\u200F\u206F\u206F\u206E\u202C\u202D\u206A\u206A\u206C\u202E\u202D\u206A\u206E\u200B\u200D\u200E\u200C\u200F\u200E\u200F\u202E\u206C\u200C\u200D\u200E\u206D\u202E\u202C\u202B\u202D\u200F\u202D\u200F\u202D\u202E(array2, 0);
							num8 = (num * 775982345U ^ 2226510672U);
							continue;
						}
						case 12U:
							this.Furniture.Clear();
							num8 = (num * 1157562541U ^ 3752329136U);
							continue;
						case 13U:
							this.Items.Clear();
							num8 = (num * 2927851639U ^ 1145862574U);
							continue;
						case 14U:
							goto IL_A3E;
						case 15U:
							this.lastItemScanTime = Entities.\u206D\u206A\u202D\u202D\u206D\u206B\u206F\u206E\u206B\u200D\u206C\u202B\u202B\u202B\u202A\u206F\u202D\u200B\u206E\u206A\u206C\u206E\u202C\u206D\u200C\u206A\u202E\u206E\u206D\u200F\u200D\u206C\u200C\u206D\u202E\u200E\u206F\u202C\u206A\u206E\u202E();
							num8 = (num * 4133902765U ^ 3195528683U);
							continue;
						case 16U:
							if (barricadeRegion != null)
							{
								num8 = (num * 1727674999U ^ 2195380899U);
								continue;
							}
							goto IL_9E7;
						case 17U:
						{
							InteractableItem[] array3 = Object.FindObjectsOfType<InteractableItem>();
							num8 = (num * 572303116U ^ 2143388305U);
							continue;
						}
						case 18U:
							goto IL_A18;
						case 19U:
							goto IL_45F;
						case 20U:
						{
							IL_719:
							BarricadeRegion[,] array2;
							barricadeRegion = array2[num10, num11];
							num8 = 2620230955U;
							continue;
						}
						case 21U:
							goto IL_609;
						case 22U:
						{
							InteractableItem interactableItem;
							this.Items.Add(interactableItem);
							num8 = (num * 2640159481U ^ 3828032287U);
							continue;
						}
						case 23U:
							this.Beds.Clear();
							num8 = (num * 962334099U ^ 2497310682U);
							continue;
						case 24U:
						{
							BarricadeRegion[,] array2 = Entities.\u200E\u202D\u200C\u200F\u206D\u202E\u206F\u202C\u200B\u202E\u206E\u202D\u206C\u202C\u200B\u206F\u200B\u206D\u206F\u202A\u206D\u200F\u206C\u206D\u200C\u200C\u200C\u202B\u206D\u200C\u206D\u202A\u200D\u200E\u206D\u202B\u202B\u206F\u206D\u202D\u202E();
							num8 = (num * 3834411014U ^ 3711823174U);
							continue;
						}
						case 25U:
							goto IL_7A5;
						case 26U:
						{
							IL_576:
							BarricadeRegion[,] array2;
							num11 = Entities.\u200E\u202D\u202C\u202A\u200E\u200B\u200F\u206F\u206F\u206E\u202C\u202D\u206A\u206A\u206C\u202E\u202D\u206A\u206E\u200B\u200D\u200E\u200C\u200F\u200E\u200F\u202E\u206C\u200C\u200D\u200E\u206D\u202E\u202C\u202B\u202D\u200F\u202D\u200F\u202D\u202E(array2, 1);
							num8 = 3016549702U;
							continue;
						}
						default:
							goto IL_7A5;
						}
						uint num12;
						for (;;)
						{
							IL_9F2:
							switch ((num = (num12 ^ 4229726941U)) % 5U)
							{
							case 0U:
								num10++;
								num12 = (num * 3210451224U ^ 3591935239U);
								continue;
							case 1U:
								goto IL_A3E;
							case 3U:
								goto IL_9ED;
							case 4U:
								goto IL_A18;
							}
							return;
						}
						IL_A18:
						if (num10 > num7)
						{
							num12 = 2937681468U;
							goto IL_9F2;
						}
						goto IL_576;
						IL_A3E:
						if (num11 > num9)
						{
							num12 = 4094232551U;
							goto IL_9F2;
						}
						goto IL_719;
						IL_9ED:
						num12 = 3566638895U;
						goto IL_9F2;
						IL_9E7:
						num11++;
						goto IL_9ED;
						IL_7A5:
						using (List<BarricadeDrop>.Enumerator enumerator3 = Entities.\u202B\u202D\u200C\u206A\u202B\u200B\u202D\u200E\u200E\u200C\u202A\u206E\u200C\u206E\u202C\u206C\u202D\u202D\u206C\u200F\u202B\u206C\u200B\u206C\u200C\u206D\u206E\u206B\u202E\u200D\u206F\u200B\u202D\u202B\u200F\u200B\u200B\u206B\u200C\u206C\u202E(barricadeRegion).GetEnumerator())
						{
							for (;;)
							{
								IL_85A:
								uint num13 = (!enumerator3.MoveNext()) ? 3567613654U : 2916180657U;
								for (;;)
								{
									Object object2;
									switch ((num = (num13 ^ 4229726941U)) % 16U)
									{
									case 0U:
									{
										BarricadeDrop barricadeDrop;
										this.Beds.Add(barricadeDrop);
										num13 = (num * 3601325771U ^ 1861228772U);
										continue;
									}
									case 1U:
									{
										BarricadeDrop barricadeDrop;
										num13 = (((!(Entities.\u200C\u200F\u206E\u206C\u202C\u206A\u200E\u206E\u206E\u206F\u202B\u206F\u200E\u200D\u200E\u206C\u206E\u202D\u200E\u200C\u206F\u202C\u206D\u202C\u206D\u202B\u206D\u202B\u206E\u200F\u202B\u202B\u200C\u200E\u202D\u202E\u206D\u206F\u206B\u202C\u202E(barricadeDrop) is InteractableGenerator)) ? 3116897034U : 3097072128U) ^ num * 3100750051U);
										continue;
									}
									case 2U:
									{
										BarricadeDrop barricadeDrop;
										this.Claims.Add(barricadeDrop);
										num13 = (num * 3158230218U ^ 1241490100U);
										continue;
									}
									case 3U:
										num13 = 2916180657U;
										continue;
									case 4U:
										goto IL_85A;
									case 5U:
									{
										BarricadeDrop barricadeDrop;
										num13 = (((Entities.\u200C\u200F\u206E\u206C\u202C\u206A\u200E\u206E\u206E\u206F\u202B\u206F\u200E\u200D\u200E\u206C\u206E\u202D\u200E\u200C\u206F\u202C\u206D\u202C\u206D\u202B\u206D\u202B\u206E\u200F\u202B\u202B\u200C\u200E\u202D\u202E\u206D\u206F\u206B\u202C\u202E(barricadeDrop) is InteractableTrap) ? 4021653115U : 4034227268U) ^ num * 2576870584U);
										continue;
									}
									case 6U:
									{
										BarricadeDrop barricadeDrop;
										num13 = ((Entities.\u200C\u200F\u206E\u206C\u202C\u206A\u200E\u206E\u206E\u206F\u202B\u206F\u200E\u200D\u200E\u206C\u206E\u202D\u200E\u200C\u206F\u202C\u206D\u202C\u206D\u202B\u206D\u202B\u206E\u200F\u202B\u202B\u200C\u200E\u202D\u202E\u206D\u206F\u206B\u202C\u202E(barricadeDrop) is InteractableStorage) ? 3644835427U : 2312735239U);
										continue;
									}
									case 7U:
									{
										BarricadeDrop barricadeDrop;
										num13 = ((!(Entities.\u200C\u200F\u206E\u206C\u202C\u206A\u200E\u206E\u206E\u206F\u202B\u206F\u200E\u200D\u200E\u206C\u206E\u202D\u200E\u200C\u206F\u202C\u206D\u202C\u206D\u202B\u206D\u202B\u206E\u200F\u202B\u202B\u200C\u200E\u202D\u202E\u206D\u206F\u206B\u202C\u202E(barricadeDrop) is InteractableClaim)) ? 4269317931U : 2564899871U);
										continue;
									}
									case 8U:
										object2 = null;
										goto IL_990;
									case 9U:
										num13 = (num * 2807009921U ^ 1702303952U);
										continue;
									case 10U:
									{
										BarricadeDrop barricadeDrop;
										num13 = (((Entities.\u200C\u200F\u206E\u206C\u202C\u206A\u200E\u206E\u206E\u206F\u202B\u206F\u200E\u200D\u200E\u206C\u206E\u202D\u200E\u200C\u206F\u202C\u206D\u202C\u206D\u202B\u206D\u202B\u206E\u200F\u202B\u202B\u200C\u200E\u202D\u202E\u206D\u206F\u206B\u202C\u202E(barricadeDrop) is InteractableDoor) ? 3350774819U : 2619446760U) ^ num * 3557527968U);
										continue;
									}
									case 12U:
									{
										BarricadeDrop barricadeDrop = enumerator3.Current;
										if (barricadeDrop == null)
										{
											num13 = 2336889781U;
											continue;
										}
										object2 = Entities.\u206F\u200B\u202D\u202C\u200E\u206E\u202E\u206E\u200D\u206D\u200F\u200F\u200F\u202A\u206F\u202D\u200F\u202C\u202A\u202C\u206E\u206A\u206D\u200C\u202C\u200B\u206D\u206C\u200C\u200E\u200D\u206D\u202E\u200D\u206A\u206E\u202D\u206C\u202E\u202A\u202E(barricadeDrop);
										goto IL_990;
									}
									case 13U:
										num13 = (num * 2207729788U ^ 794605541U);
										continue;
									case 14U:
									{
										BarricadeDrop barricadeDrop;
										this.Furniture.Add(barricadeDrop);
										num13 = 3631105897U;
										continue;
									}
									case 15U:
									{
										BarricadeDrop barricadeDrop;
										num13 = (((!(Entities.\u200C\u200F\u206E\u206C\u202C\u206A\u200E\u206E\u206E\u206F\u202B\u206F\u200E\u200D\u200E\u206C\u206E\u202D\u200E\u200C\u206F\u202C\u206D\u202C\u206D\u202B\u206D\u202B\u206E\u200F\u202B\u202B\u200C\u200E\u202D\u202E\u206D\u206F\u206B\u202C\u202E(barricadeDrop) is InteractableBed)) ? 67786035U : 186702420U) ^ num * 2477778359U);
										continue;
									}
									}
									goto Block_43;
									IL_990:
									num13 = ((!Entities.\u200B\u200F\u206D\u200C\u200B\u202A\u206D\u202B\u206F\u202E\u206C\u206F\u206F\u206E\u202C\u202E\u200D\u200B\u202D\u202A\u206F\u202D\u202C\u206A\u206B\u206C\u200C\u200F\u200B\u202A\u200F\u200F\u206B\u200F\u200B\u202E\u200E\u206C\u206E\u206A\u202E(object2, null)) ? 3335497826U : 3631105897U);
								}
							}
							Block_43:;
						}
						goto IL_9E7;
					}
					IL_609:
					if (num7 >= array.Length)
					{
						num8 = 3939719185U;
						goto IL_464;
					}
					goto IL_354;
					IL_45F:
					num8 = 3891343739U;
					goto IL_464;
					IL_459:
					num7++;
					goto IL_45F;
					IL_369:
					using (List<Zombie>.Enumerator enumerator4 = Entities.\u200C\u200F\u206C\u206A\u200F\u206D\u206F\u200E\u200F\u200B\u202A\u202B\u200E\u206B\u206D\u206C\u206C\u206E\u206F\u202C\u202E\u206E\u206C\u202C\u200F\u206F\u206A\u206E\u202A\u200C\u200F\u202C\u202A\u202D\u206E\u206D\u202A\u200F\u200E\u206D\u202E(zombieRegion).GetEnumerator())
					{
						for (;;)
						{
							IL_405:
							uint num14 = (!enumerator4.MoveNext()) ? 2952869695U : 3512911726U;
							for (;;)
							{
								uint num;
								switch ((num = (num14 ^ 4229726941U)) % 7U)
								{
								case 0U:
									num14 = 3512911726U;
									continue;
								case 1U:
								{
									Zombie zombie;
									num14 = ((Entities.\u206E\u206A\u202D\u200C\u206C\u202E\u206F\u202E\u206D\u202C\u202C\u202A\u200F\u202C\u200B\u200D\u206A\u200D\u202E\u202E\u206B\u200F\u200E\u206E\u206E\u202E\u200F\u202E\u200D\u200B\u200B\u202A\u200B\u200F\u200D\u202E\u200E\u200C\u206B\u200F\u202E(zombie, null) ? 2629900526U : 2966336855U) ^ num * 130355322U);
									continue;
								}
								case 2U:
								{
									Zombie zombie;
									num14 = (((!zombie.isDead) ? 2160267262U : 3675828711U) ^ num * 359440696U);
									continue;
								}
								case 3U:
								{
									Zombie zombie = enumerator4.Current;
									num14 = 2898206465U;
									continue;
								}
								case 4U:
									goto IL_405;
								case 5U:
								{
									Zombie zombie;
									this.Zombies.Add(zombie);
									num14 = (num * 3049277911U ^ 3094509938U);
									continue;
								}
								}
								goto Block_37;
							}
						}
						Block_37:;
					}
					goto IL_459;
				}
			}
			return;
			IL_1C1:
			num4 = 2772680881U;
			goto IL_1C6;
			IL_217:
			this.Vehicles.Clear();
			num4 = 3058756057U;
			goto IL_1C6;
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x000143C4 File Offset: 0x000125C4
		internal float DistanceToLocal(Vector3 pos)
		{
			if (Entities.\u200B\u200F\u206D\u200C\u200B\u202A\u206D\u202B\u206F\u202E\u206C\u206F\u206F\u206E\u202C\u202E\u200D\u200B\u202D\u202A\u206F\u202D\u202C\u206A\u206B\u206C\u200C\u200F\u200B\u202A\u200F\u200F\u206B\u200F\u200B\u202E\u200E\u206C\u206E\u206A\u202E(Entities.\u200C\u206E\u202C\u206B\u200F\u206D\u206A\u202A\u202D\u202B\u206B\u202A\u200E\u200D\u206F\u202A\u206C\u202E\u202B\u206D\u200F\u206D\u200F\u200E\u200D\u202C\u202E\u202C\u206C\u202E\u200B\u202C\u200C\u206B\u206E\u206C\u206C\u200F\u206D\u202A\u202E(), null))
			{
				for (;;)
				{
					switch ((-622343484 ^ -242427366) % 3)
					{
					case 0:
						continue;
					case 1:
						goto IL_2F;
					}
					break;
				}
				goto IL_44;
				IL_2F:
				return float.MaxValue;
			}
			IL_44:
			return Vector3.Distance(Entities.\u202D\u206C\u202E\u202B\u200E\u200B\u200E\u206A\u206C\u200F\u200E\u206C\u200E\u202C\u202D\u200E\u200B\u200B\u200F\u202C\u206A\u202E\u200E\u202B\u200B\u206B\u202D\u206B\u202A\u202E\u202B\u200F\u200E\u200D\u200D\u202B\u200E\u202E\u202C\u202A\u202E(Entities.\u200F\u200F\u200F\u202C\u202E\u200B\u206A\u202E\u200D\u200B\u206C\u200E\u200B\u206E\u202B\u206F\u200D\u200B\u202C\u200B\u202B\u206A\u206C\u206B\u206A\u206E\u200F\u200D\u202B\u200E\u202C\u202D\u206B\u202A\u206C\u206D\u202C\u202D\u200E\u200E\u202E(Entities.\u200C\u206E\u202C\u206B\u200F\u206D\u206A\u202A\u202D\u202B\u206B\u202A\u200E\u200D\u206F\u202A\u206C\u202E\u202B\u206D\u200F\u206D\u200F\u200E\u200D\u202C\u202E\u202C\u206C\u202E\u200B\u202C\u200C\u206B\u206E\u206C\u206C\u200F\u206D\u202A\u202E())), pos);
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x0000C870 File Offset: 0x0000AA70
		static GameObject \u200C\u202A\u202D\u202C\u202B\u202D\u202C\u202B\u200D\u202A\u202A\u202C\u202C\u202B\u200B\u206E\u206C\u200B\u206A\u206B\u206B\u202B\u206D\u206F\u206E\u200F\u200E\u206F\u200F\u202A\u206C\u206A\u206E\u200E\u200E\u202B\u200E\u202E\u206B\u202A\u202E(Component A_0)
		{
			return A_0.gameObject;
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x000061D4 File Offset: 0x000043D4
		static void \u200E\u206D\u206A\u206F\u202C\u202B\u200B\u206B\u200F\u200C\u202E\u202D\u206C\u200F\u206F\u202B\u202B\u202A\u202B\u206B\u202B\u206A\u206B\u202A\u206E\u202B\u206E\u202E\u206D\u202C\u206F\u206F\u202B\u202A\u200C\u200C\u206F\u202E\u206D\u202D\u202E(Object A_0)
		{
			Object.DontDestroyOnLoad(A_0);
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x00007690 File Offset: 0x00005890
		static Player \u200C\u206E\u202C\u206B\u200F\u206D\u206A\u202A\u202D\u202B\u206B\u202A\u200E\u200D\u206F\u202A\u206C\u202E\u202B\u206D\u200F\u206D\u200F\u200E\u200D\u202C\u202E\u202C\u206C\u202E\u200B\u202C\u200C\u206B\u206E\u206C\u206C\u200F\u206D\u202A\u202E()
		{
			return Player.LocalPlayer;
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x000076A4 File Offset: 0x000058A4
		static bool \u200B\u200F\u206D\u200C\u200B\u202A\u206D\u202B\u206F\u202E\u206C\u206F\u206F\u206E\u202C\u202E\u200D\u200B\u202D\u202A\u206F\u202D\u202C\u206A\u206B\u206C\u200C\u200F\u200B\u202A\u200F\u200F\u206B\u200F\u200B\u202E\u200E\u206C\u206E\u206A\u202E(Object A_0, Object A_1)
		{
			return A_0 == A_1;
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x000076B8 File Offset: 0x000058B8
		static bool \u206E\u200E\u202E\u202E\u202E\u206F\u200E\u200E\u202B\u202E\u200E\u202A\u200E\u202A\u202A\u200F\u202B\u200C\u200F\u206B\u206F\u206C\u200F\u202E\u200C\u202B\u200F\u200F\u202D\u202A\u202E\u200F\u200B\u206C\u200E\u200D\u200C\u202A\u200C\u206B\u202E()
		{
			return Provider.isConnected;
		}

		// Token: 0x060001DA RID: 474 RVA: 0x0000CA78 File Offset: 0x0000AC78
		static List<SteamPlayer> \u202A\u200E\u200D\u202C\u206C\u200F\u202A\u200E\u202D\u200D\u200F\u206C\u202D\u200B\u206A\u200C\u200E\u200B\u200C\u202C\u206F\u206C\u206F\u200C\u200C\u202D\u202E\u206D\u202A\u202B\u206E\u206F\u202D\u206F\u200E\u200D\u200C\u206A\u206D\u202A\u202E()
		{
			return Provider.clients;
		}

		// Token: 0x060001DB RID: 475 RVA: 0x0000CBE8 File Offset: 0x0000ADE8
		static Player \u202E\u206F\u200C\u206B\u202E\u200D\u200E\u206F\u202C\u206F\u202D\u200D\u200E\u202C\u202E\u202D\u200B\u206E\u202E\u206C\u200C\u206D\u206F\u200C\u202E\u206A\u202A\u202D\u200C\u200C\u202C\u202E\u200E\u200B\u206D\u202B\u206B\u202C\u202D\u200C\u202E(SteamPlayer A_0)
		{
			return A_0.player;
		}

		// Token: 0x060001DC RID: 476 RVA: 0x00014498 File Offset: 0x00012698
		static Player \u202E\u200F\u202B\u200F\u202E\u200B\u206D\u202D\u206F\u206D\u202B\u202D\u202C\u206B\u206C\u200F\u202D\u206C\u202B\u202B\u202E\u206C\u200D\u206E\u206E\u206D\u202B\u200E\u200B\u206A\u202E\u202B\u202D\u200F\u202B\u206E\u200C\u202B\u202C\u206A\u202E(SteamPlayer A_0)
		{
			return A_0.player;
		}

		// Token: 0x060001DD RID: 477 RVA: 0x00007824 File Offset: 0x00005A24
		static PlayerLife \u206D\u200C\u206E\u202E\u206C\u206B\u200C\u202C\u206F\u206D\u206A\u200F\u206D\u206B\u206B\u206B\u206E\u202E\u202A\u200C\u202A\u202C\u202D\u200F\u202A\u200B\u202E\u206F\u202C\u206C\u202E\u206C\u202E\u202E\u200C\u200D\u202D\u206F\u202E\u206A\u202E(Player A_0)
		{
			return A_0.life;
		}

		// Token: 0x060001DE RID: 478 RVA: 0x00007838 File Offset: 0x00005A38
		static bool \u202A\u202B\u206D\u202D\u200E\u200F\u202A\u200D\u200F\u202B\u200B\u202A\u202B\u202A\u200B\u200D\u200D\u206E\u200E\u206A\u202E\u200F\u200F\u206E\u206F\u206B\u206F\u200F\u202E\u206A\u200C\u206F\u206A\u202A\u202C\u206F\u200C\u202A\u200D\u206E\u202E(PlayerLife A_0)
		{
			return A_0.isDead;
		}

		// Token: 0x060001DF RID: 479 RVA: 0x000144AC File Offset: 0x000126AC
		static List<InteractableVehicle> \u202D\u202E\u202A\u206F\u200C\u200E\u200D\u206F\u202E\u200C\u206A\u206F\u206C\u202D\u200E\u200E\u200D\u206B\u200E\u200D\u200E\u202B\u206B\u202A\u200D\u206A\u200D\u202A\u206D\u202E\u200E\u206C\u200F\u202C\u202A\u206F\u200D\u206A\u206F\u206E\u202E()
		{
			return VehicleManager.vehicles;
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x000061E8 File Offset: 0x000043E8
		static bool \u206E\u206A\u202D\u200C\u206C\u202E\u206F\u202E\u206D\u202C\u202C\u202A\u200F\u202C\u200B\u200D\u206A\u200D\u202E\u202E\u206B\u200F\u200E\u206E\u206E\u202E\u200F\u202E\u200D\u200B\u200B\u202A\u200B\u200F\u200D\u202E\u200E\u200C\u206B\u200F\u202E(Object A_0, Object A_1)
		{
			return A_0 != A_1;
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x000144C0 File Offset: 0x000126C0
		static ZombieRegion[] \u202B\u202D\u202C\u206B\u202A\u200E\u200E\u200B\u202A\u202B\u206E\u200D\u200E\u202C\u202A\u202D\u200B\u202E\u200E\u200C\u202A\u206D\u202D\u200E\u206A\u206E\u206E\u206B\u202B\u200E\u202A\u206A\u206A\u200E\u200C\u206B\u200C\u206C\u206C\u202A\u202E()
		{
			return ZombieManager.regions;
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x000144D4 File Offset: 0x000126D4
		static List<Zombie> \u200C\u200F\u206C\u206A\u200F\u206D\u206F\u200E\u200F\u200B\u202A\u202B\u200E\u206B\u206D\u206C\u206C\u206E\u206F\u202C\u202E\u206E\u206C\u202C\u200F\u206F\u206A\u206E\u202A\u200C\u200F\u202C\u202A\u202D\u206E\u206D\u202A\u200F\u200E\u206D\u202E(ZombieRegion A_0)
		{
			return A_0.zombies;
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x00007730 File Offset: 0x00005930
		static float \u206D\u206A\u202D\u202D\u206D\u206B\u206F\u206E\u206B\u200D\u206C\u202B\u202B\u202B\u202A\u206F\u202D\u200B\u206E\u206A\u206C\u206E\u202C\u206D\u200C\u206A\u202E\u206E\u206D\u200F\u200D\u206C\u200C\u206D\u202E\u200E\u206F\u202C\u206A\u206E\u202E()
		{
			return Time.time;
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x0000C884 File Offset: 0x0000AA84
		static GameObject \u202E\u206C\u206D\u206A\u200C\u206A\u206C\u202B\u202B\u202E\u200C\u200D\u202E\u200E\u206A\u206F\u200D\u200E\u200C\u206E\u206A\u206C\u200C\u200D\u206A\u202B\u206C\u200D\u202A\u206B\u200D\u202B\u206D\u206A\u200D\u200F\u206F\u206F\u206C\u206E\u202E(Component A_0)
		{
			return A_0.gameObject;
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x0000E9E0 File Offset: 0x0000CBE0
		static bool \u200D\u206B\u206E\u206F\u206B\u206D\u200B\u200C\u206A\u206C\u202B\u200F\u202E\u206B\u202A\u206A\u200B\u206D\u206E\u206A\u206F\u200F\u206C\u202A\u202E\u206A\u202E\u202C\u202C\u200F\u206B\u206B\u206D\u202E\u200C\u200F\u206D\u202E\u202D\u202E\u202E(GameObject A_0)
		{
			return A_0.activeInHierarchy;
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x000144E8 File Offset: 0x000126E8
		static BarricadeRegion[,] \u200E\u202D\u200C\u200F\u206D\u202E\u206F\u202C\u200B\u202E\u206E\u202D\u206C\u202C\u200B\u206F\u200B\u206D\u206F\u202A\u206D\u200F\u206C\u206D\u200C\u200C\u200C\u202B\u206D\u200C\u206D\u202A\u200D\u200E\u206D\u202B\u202B\u206F\u206D\u202D\u202E()
		{
			return BarricadeManager.regions;
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x000144FC File Offset: 0x000126FC
		static int \u206A\u202D\u202D\u202B\u206E\u206C\u206A\u200E\u206B\u206A\u200F\u200B\u202E\u206F\u200D\u200D\u206A\u206E\u206D\u200C\u206F\u200B\u206D\u202B\u206C\u200D\u202A\u200D\u200D\u206B\u206F\u206C\u202B\u206E\u206B\u206B\u200E\u200F\u200D\u206C\u202E(Array A_0, int A_1)
		{
			return A_0.GetUpperBound(A_1);
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x00014510 File Offset: 0x00012710
		static int \u200E\u202D\u202C\u202A\u200E\u200B\u200F\u206F\u206F\u206E\u202C\u202D\u206A\u206A\u206C\u202E\u202D\u206A\u206E\u200B\u200D\u200E\u200C\u200F\u200E\u200F\u202E\u206C\u200C\u200D\u200E\u206D\u202E\u202C\u202B\u202D\u200F\u202D\u200F\u202D\u202E(Array A_0, int A_1)
		{
			return A_0.GetLowerBound(A_1);
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x00014524 File Offset: 0x00012724
		static List<BarricadeDrop> \u202B\u202D\u200C\u206A\u202B\u200B\u202D\u200E\u200E\u200C\u202A\u206E\u200C\u206E\u202C\u206C\u202D\u202D\u206C\u200F\u202B\u206C\u200B\u206C\u200C\u206D\u206E\u206B\u202E\u200D\u206F\u200B\u202D\u202B\u200F\u200B\u200B\u206B\u200C\u206C\u202E(BarricadeRegion A_0)
		{
			return A_0.drops;
		}

		// Token: 0x060001EA RID: 490 RVA: 0x00014538 File Offset: 0x00012738
		static Interactable \u206F\u200B\u202D\u202C\u200E\u206E\u202E\u206E\u200D\u206D\u200F\u200F\u200F\u202A\u206F\u202D\u200F\u202C\u202A\u202C\u206E\u206A\u206D\u200C\u202C\u200B\u206D\u206C\u200C\u200E\u200D\u206D\u202E\u200D\u206A\u206E\u202D\u206C\u202E\u202A\u202E(BarricadeDrop A_0)
		{
			return A_0.interactable;
		}

		// Token: 0x060001EB RID: 491 RVA: 0x0001454C File Offset: 0x0001274C
		static Interactable \u200C\u200F\u206E\u206C\u202C\u206A\u200E\u206E\u206E\u206F\u202B\u206F\u200E\u200D\u200E\u206C\u206E\u202D\u200E\u200C\u206F\u202C\u206D\u202C\u206D\u202B\u206D\u202B\u206E\u200F\u202B\u202B\u200C\u200E\u202D\u202E\u206D\u206F\u206B\u202C\u202E(BarricadeDrop A_0)
		{
			return A_0.interactable;
		}

		// Token: 0x060001EC RID: 492 RVA: 0x00007708 File Offset: 0x00005908
		static Transform \u200F\u200F\u200F\u202C\u202E\u200B\u206A\u202E\u200D\u200B\u206C\u200E\u200B\u206E\u202B\u206F\u200D\u200B\u202C\u200B\u202B\u206A\u206C\u206B\u206A\u206E\u200F\u200D\u202B\u200E\u202C\u202D\u206B\u202A\u206C\u206D\u202C\u202D\u200E\u200E\u202E(Component A_0)
		{
			return A_0.transform;
		}

		// Token: 0x060001ED RID: 493 RVA: 0x0000771C File Offset: 0x0000591C
		static Vector3 \u202D\u206C\u202E\u202B\u200E\u200B\u200E\u206A\u206C\u200F\u200E\u206C\u200E\u202C\u202D\u200E\u200B\u200B\u200F\u202C\u206A\u202E\u200E\u202B\u200B\u206B\u202D\u206B\u202A\u202E\u202B\u200F\u200E\u200D\u200D\u202B\u200E\u202E\u202C\u202A\u202E(Transform A_0)
		{
			return A_0.position;
		}

		// Token: 0x04000122 RID: 290
		private float lastItemScanTime = -10f;

		// Token: 0x04000123 RID: 291
		private const float ITEM_SCAN_INTERVAL = 2f;
	}
}
