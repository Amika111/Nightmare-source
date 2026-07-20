using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Cheat.modules;
using UnityEngine;

namespace Cheat.core
{
	// Token: 0x02000028 RID: 40
	public class Main : MonoBehaviour
	{
		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600028C RID: 652 RVA: 0x0001BFD4 File Offset: 0x0001A1D4
		// (set) Token: 0x0600028D RID: 653 RVA: 0x0001BFE8 File Offset: 0x0001A1E8
		public static Main Instance { get; private set; }

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600028E RID: 654 RVA: 0x0001BFFC File Offset: 0x0001A1FC
		// (set) Token: 0x0600028F RID: 655 RVA: 0x0001C010 File Offset: 0x0001A210
		public static Camera CachedCamera { get; private set; }

		// Token: 0x06000290 RID: 656 RVA: 0x0001C024 File Offset: 0x0001A224
		private void Awake()
		{
			if (Main.\u206C\u206E\u206D\u206B\u206E\u202A\u206E\u206A\u202E\u202C\u200F\u206A\u206C\u202A\u202D\u202E\u202B\u206C\u200D\u200D\u200D\u206A\u200F\u200F\u206B\u206B\u206D\u202B\u202B\u202E\u206F\u206C\u200F\u206A\u206A\u200E\u206F\u206D\u206E\u206E\u202E(Main.Instance, null))
			{
				goto IL_10;
			}
			goto IL_1B9;
			uint num2;
			for (;;)
			{
				IL_15:
				uint num;
				switch ((num = (num2 ^ 941431253U)) % 15U)
				{
				case 0U:
					this.weaponMods = Main.\u202D\u202A\u200E\u206B\u206D\u206B\u206A\u202A\u206A\u202C\u200D\u202E\u202B\u202D\u202A\u200C\u200D\u206D\u202C\u206D\u202E\u200E\u202A\u206D\u200E\u202B\u202C\u206E\u206E\u206E\u200F\u202B\u206C\u200B\u206A\u200C\u200B\u206F\u200D\u200C\u202E(this).AddComponent<WeaponMods>();
					this.chatSpam = Main.\u202D\u202A\u200E\u206B\u206D\u206B\u206A\u202A\u206A\u202C\u200D\u202E\u202B\u202D\u202A\u200C\u200D\u206D\u202C\u206D\u202E\u200E\u202A\u206D\u200E\u202B\u202C\u206E\u206E\u206E\u200F\u202B\u206C\u200B\u206A\u200C\u200B\u206F\u200D\u200C\u202E(this).AddComponent<ChatSpam>();
					num2 = (num * 1787598036U ^ 2566396653U);
					continue;
				case 1U:
					Config.Load();
					num2 = (num * 3459933670U ^ 2669852774U);
					continue;
				case 2U:
					this.aimbot = Main.\u202D\u202A\u200E\u206B\u206D\u206B\u206A\u202A\u206A\u202C\u200D\u202E\u202B\u202D\u202A\u200C\u200D\u206D\u202C\u206D\u202E\u200E\u202A\u206D\u200E\u202B\u202C\u206E\u206E\u206E\u200F\u202B\u206C\u200B\u206A\u200C\u200B\u206F\u200D\u200C\u202E(this).AddComponent<Aimbot>();
					num2 = (num * 109401581U ^ 302879158U);
					continue;
				case 3U:
					goto IL_10;
				case 4U:
					Main.\u206E\u206B\u206A\u200B\u202A\u200C\u202C\u200C\u206A\u202A\u206A\u202B\u200B\u206D\u206C\u202A\u202C\u206C\u200B\u200E\u206B\u200B\u202C\u202D\u202E\u202B\u206C\u206F\u206C\u200C\u200D\u206F\u200F\u200F\u202E\u202E\u202D\u206B\u206E\u206B\u202E(this, DisableBattlEyePanel.DisablePanelRoutine());
					num2 = (num * 350331813U ^ 1004049153U);
					continue;
				case 6U:
					goto IL_1B9;
				case 7U:
					Overrides.Awake();
					num2 = (num * 1275473124U ^ 4193159495U);
					continue;
				case 8U:
					Main.\u206F\u206C\u206C\u200D\u206F\u202B\u200D\u202A\u202E\u200D\u202D\u200E\u206D\u200C\u202B\u202A\u200B\u200C\u206B\u200D\u202B\u202E\u202D\u202B\u200D\u200E\u206D\u206C\u200E\u206C\u206D\u202E\u202D\u200B\u206A\u206F\u206F\u200D\u206C\u200D\u202E(Main.\u202D\u202A\u200E\u206B\u206D\u206B\u206A\u202A\u206A\u202C\u200D\u202E\u202B\u202D\u202A\u200C\u200D\u206D\u202C\u206D\u202E\u200E\u202A\u206D\u200E\u202B\u202C\u206E\u206E\u206E\u200F\u202B\u206C\u200B\u206A\u200C\u200B\u206F\u200D\u200C\u202E(this));
					num2 = (num * 1578365388U ^ 1578741706U);
					continue;
				case 9U:
					this.entities = Main.\u202D\u202A\u200E\u206B\u206D\u206B\u206A\u202A\u206A\u202C\u200D\u202E\u202B\u202D\u202A\u200C\u200D\u206D\u202C\u206D\u202E\u200E\u202A\u206D\u200E\u202B\u202C\u206E\u206E\u206E\u200F\u202B\u206C\u200B\u206A\u200C\u200B\u206F\u200D\u200C\u202E(this).AddComponent<Entities>();
					this.esp = Main.\u202D\u202A\u200E\u206B\u206D\u206B\u206A\u202A\u206A\u202C\u200D\u202E\u202B\u202D\u202A\u200C\u200D\u206D\u202C\u206D\u202E\u200E\u202A\u206D\u200E\u202B\u202C\u206E\u206E\u206E\u200F\u202B\u206C\u200B\u206A\u200C\u200B\u206F\u200D\u200C\u202E(this).AddComponent<ESP>();
					num2 = (num * 2995489163U ^ 1819001739U);
					continue;
				case 10U:
					this.freeCam = Main.\u202D\u202A\u200E\u206B\u206D\u206B\u206A\u202A\u206A\u202C\u200D\u202E\u202B\u202D\u202A\u200C\u200D\u206D\u202C\u206D\u202E\u200E\u202A\u206D\u200E\u202B\u202C\u206E\u206E\u206E\u200F\u202B\u206C\u200B\u206A\u200C\u200B\u206F\u200D\u200C\u202E(this).AddComponent<FreeCam>();
					this.menu = new Menu(this);
					num2 = (num * 2498943140U ^ 3298807023U);
					continue;
				case 11U:
					this.visuals = Main.\u202D\u202A\u200E\u206B\u206D\u206B\u206A\u202A\u206A\u202C\u200D\u202E\u202B\u202D\u202A\u200C\u200D\u206D\u202C\u206D\u202E\u200E\u202A\u206D\u200E\u202B\u202C\u206E\u206E\u206E\u200F\u202B\u206C\u200B\u206A\u200C\u200B\u206F\u200D\u200C\u202E(this).AddComponent<Visuals>();
					this.triggerbot = Main.\u202D\u202A\u200E\u206B\u206D\u206B\u206A\u202A\u206A\u202C\u200D\u202E\u202B\u202D\u202A\u200C\u200D\u206D\u202C\u206D\u202E\u200E\u202A\u206D\u200E\u202B\u202C\u206E\u206E\u206E\u200F\u202B\u206C\u200B\u206A\u200C\u200B\u206F\u200D\u200C\u202E(this).AddComponent<Triggerbot>();
					num2 = (num * 2340826041U ^ 2186813542U);
					continue;
				case 12U:
					return;
				case 13U:
					Main.\u200B\u206D\u206E\u202B\u206F\u202A\u206C\u206F\u200B\u206B\u202D\u206C\u206F\u206F\u206B\u206E\u206B\u206A\u200C\u206C\u202C\u200D\u202A\u200B\u200D\u202D\u202B\u206C\u206E\u202B\u202E\u206A\u206B\u206E\u206A\u202D\u202E\u206B\u200D\u206F\u202E(Main.\u202D\u202A\u200E\u206B\u206D\u206B\u206A\u202A\u206A\u202C\u200D\u202E\u202B\u202D\u202A\u200C\u200D\u206D\u202C\u206D\u202E\u200E\u202A\u206D\u200E\u202B\u202C\u206E\u206E\u206E\u200F\u202B\u206C\u200B\u206A\u200C\u200B\u206F\u200D\u200C\u202E(this));
					num2 = (num * 546844672U ^ 3810990762U);
					continue;
				case 14U:
					this.vehicleNoclip = Main.\u202D\u202A\u200E\u206B\u206D\u206B\u206A\u202A\u206A\u202C\u200D\u202E\u202B\u202D\u202A\u200C\u200D\u206D\u202C\u206D\u202E\u200E\u202A\u206D\u200E\u202B\u202C\u206E\u206E\u206E\u200F\u202B\u206C\u200B\u206A\u200C\u200B\u206F\u200D\u200C\u202E(this).AddComponent<VehicleNoclip>();
					this.itemVacuum = Main.\u202D\u202A\u200E\u206B\u206D\u206B\u206A\u202A\u206A\u202C\u200D\u202E\u202B\u202D\u202A\u200C\u200D\u206D\u202C\u206D\u202E\u200E\u202A\u206D\u200E\u202B\u202C\u206E\u206E\u206E\u200F\u202B\u206C\u200B\u206A\u200C\u200B\u206F\u200D\u200C\u202E(this).AddComponent<ItemVacuum>();
					num2 = (num * 4207341421U ^ 1170634501U);
					continue;
				}
				break;
			}
			return;
			IL_10:
			num2 = 742268164U;
			goto IL_15;
			IL_1B9:
			Main.Instance = this;
			num2 = 2021216538U;
			goto IL_15;
		}

		// Token: 0x06000291 RID: 657 RVA: 0x0001C260 File Offset: 0x0001A460
		private void OnGUI()
		{
			Menu menu = this.menu;
			if (menu == null)
			{
				goto IL_33;
			}
			menu.Draw();
			IL_11:
			int num = 1117578964;
			IL_16:
			switch ((num ^ 70095441) % 3)
			{
			case 0:
				goto IL_11;
			case 1:
			{
				IL_33:
				ESP esp = this.esp;
				if (esp != null)
				{
					esp.Draw();
					num = 945129965;
					goto IL_16;
				}
				break;
			}
			}
			Aimbot aimbot = this.aimbot;
			if (aimbot == null)
			{
				return;
			}
			aimbot.Draw();
		}

		// Token: 0x06000292 RID: 658 RVA: 0x0001C2C8 File Offset: 0x0001A4C8
		private void Update()
		{
			if (!Main.\u206D\u206D\u206D\u202D\u206E\u202D\u202B\u206C\u206E\u202E\u202D\u206C\u202C\u202E\u202A\u202E\u202A\u200C\u202C\u202B\u206E\u206F\u200E\u206F\u202A\u202A\u200F\u200B\u206E\u202A\u206E\u206B\u206B\u206E\u206B\u202C\u200C\u200C\u206E\u202B\u202E(Main.CachedCamera, null))
			{
				goto IL_10;
			}
			goto IL_18D;
			uint num2;
			for (;;)
			{
				IL_15:
				uint num;
				switch ((num = (num2 ^ 1301591377U)) % 37U)
				{
				case 0U:
				{
					KeyCode[] allKeyCodes = Menu.allKeyCodes;
					int num3 = 0;
					num2 = (num * 126445892U ^ 634675411U);
					continue;
				}
				case 2U:
				{
					KeyCode[] allKeyCodes;
					int num3;
					KeyCode keyCode = allKeyCodes[num3];
					num2 = (Main.\u200B\u202B\u202E\u206E\u202D\u200D\u200D\u206F\u206B\u202A\u206A\u206F\u200D\u206D\u200C\u206D\u200B\u202C\u200C\u206E\u200D\u200F\u206E\u206F\u202B\u200F\u206C\u202E\u202B\u206B\u200C\u206A\u206B\u202D\u200C\u202D\u206C\u200D\u202A\u202A\u202E(keyCode) ? 224601809U : 1963362780U);
					continue;
				}
				case 3U:
					num2 = (((!Main.\u206B\u200C\u202C\u206E\u202D\u202B\u200F\u206C\u202C\u206D\u202C\u202E\u202C\u202A\u202A\u206E\u200E\u202A\u206B\u206A\u202D\u206D\u200B\u202C\u206D\u200C\u200C\u200C\u202D\u206A\u202C\u200E\u206E\u206A\u202D\u202A\u206C\u202D\u200F\u200D\u202E(Main.CachedCamera)) ? 3951493517U : 4006461084U) ^ num * 1532485501U);
					continue;
				case 4U:
					num2 = (Main.\u200B\u202B\u202E\u206E\u202D\u200D\u200D\u206F\u206B\u202A\u206A\u206F\u200D\u206D\u200C\u206D\u200B\u202C\u200C\u206E\u200D\u200F\u206E\u206F\u202B\u200F\u206C\u202E\u202B\u206B\u200C\u206A\u206B\u202D\u200C\u202D\u206C\u200D\u202A\u202A\u202E(this.KeyToggleVehicleNoclip) ? 1479379729U : 358296218U);
					continue;
				case 5U:
					this.esp.espEnabled = !this.esp.espEnabled;
					num2 = (num * 2865900954U ^ 803572016U);
					continue;
				case 6U:
					this.freeCam.Enabled = !this.freeCam.Enabled;
					num2 = (num * 1887922937U ^ 3260410483U);
					continue;
				case 7U:
					num2 = (Main.\u200B\u202B\u202E\u206E\u202D\u200D\u200D\u206F\u206B\u202A\u206A\u206F\u200D\u206D\u200C\u206D\u200B\u202C\u200C\u206E\u200D\u200F\u206E\u206F\u202B\u200F\u206C\u202E\u202B\u206B\u200C\u206A\u206B\u202D\u200C\u202D\u206C\u200D\u202A\u202A\u202E(this.KeyToggleChatSpam) ? 871443585U : 1428251374U);
					continue;
				case 8U:
					num2 = ((!Main.\u200B\u202B\u202E\u206E\u202D\u200D\u200D\u206F\u206B\u202A\u206A\u206F\u200D\u206D\u200C\u206D\u200B\u202C\u200C\u206E\u200D\u200F\u206E\u206F\u202B\u200F\u206C\u202E\u202B\u206B\u200C\u206A\u206B\u202D\u200C\u202D\u206C\u200D\u202A\u202A\u202E(this.KeyToggleMenu)) ? 809735989U : 1070818083U);
					continue;
				case 9U:
					num2 = (Main.\u200B\u202B\u202E\u206E\u202D\u200D\u200D\u206F\u206B\u202A\u206A\u206F\u200D\u206D\u200C\u206D\u200B\u202C\u200C\u206E\u200D\u200F\u206E\u206F\u202B\u200F\u206C\u202E\u202B\u206B\u200C\u206A\u206B\u202D\u200C\u202D\u206C\u200D\u202A\u202A\u202E(this.KeyFreeCam) ? 1463951217U : 1984516947U);
					continue;
				case 10U:
					this.menu.RebindingModule = null;
					Config.Save();
					num2 = (num * 3055727685U ^ 726178655U);
					continue;
				case 11U:
					num2 = ((!Main.\u206D\u206C\u200C\u202A\u200F\u206E\u202A\u200C\u200F\u200F\u200C\u206D\u202D\u200D\u206D\u200D\u200B\u202D\u206E\u200F\u202A\u202D\u206B\u200C\u206B\u206B\u200F\u206B\u202E\u200C\u202E\u200F\u200F\u206D\u202B\u206B\u202C\u200E\u200C\u206B\u202E(this.menu.RebindingModule)) ? 1243623822U : 1236760944U);
					continue;
				case 12U:
					num2 = (Main.\u200B\u202B\u202E\u206E\u202D\u200D\u200D\u206F\u206B\u202A\u206A\u206F\u200D\u206D\u200C\u206D\u200B\u202C\u200C\u206E\u200D\u200F\u206E\u206F\u202B\u200F\u206C\u202E\u202B\u206B\u200C\u206A\u206B\u202D\u200C\u202D\u206C\u200D\u202A\u202A\u202E(this.KeyItemVacuum) ? 1599452387U : 1459027222U);
					continue;
				case 13U:
					Config.Save();
					num2 = (num * 1776964410U ^ 1134203490U);
					continue;
				case 14U:
					this.vehicleNoclip.active = !this.vehicleNoclip.active;
					num2 = (num * 1445884937U ^ 1986206426U);
					continue;
				case 15U:
					return;
				case 16U:
					this.triggerbot.enabled = !this.triggerbot.enabled;
					num2 = (num * 3198267780U ^ 1491487645U);
					continue;
				case 17U:
					num2 = ((!Main.\u200B\u202B\u202E\u206E\u202D\u200D\u200D\u206F\u206B\u202A\u206A\u206F\u200D\u206D\u200C\u206D\u200B\u202C\u200C\u206E\u200D\u200F\u206E\u206F\u202B\u200F\u206C\u202E\u202B\u206B\u200C\u206A\u206B\u202D\u200C\u202D\u206C\u200D\u202A\u202A\u202E(this.KeyToggleAimbot)) ? 2133340603U : 1119043897U);
					continue;
				case 18U:
					return;
				case 19U:
					return;
				case 20U:
					this.itemVacuum.Enabled = !this.itemVacuum.Enabled;
					num2 = (num * 1084760295U ^ 4292360840U);
					continue;
				case 21U:
					this.aimbot.enabled = !this.aimbot.enabled;
					num2 = (num * 2271650957U ^ 1412173043U);
					continue;
				case 22U:
				{
					int num3;
					num3++;
					num2 = 1864213231U;
					continue;
				}
				case 23U:
					goto IL_10;
				case 24U:
					this.PanicDisable();
					num2 = (num * 1485459603U ^ 2828943840U);
					continue;
				case 25U:
					this.menu.RebindingModule = null;
					num2 = (num * 2192406713U ^ 1737199861U);
					continue;
				case 26U:
				{
					KeyCode keyCode;
					this.SetKey(this.menu.RebindingModule, keyCode);
					num2 = 1288244484U;
					continue;
				}
				case 27U:
					num2 = (Main.\u200B\u202B\u202E\u206E\u202D\u200D\u200D\u206F\u206B\u202A\u206A\u206F\u200D\u206D\u200C\u206D\u200B\u202C\u200C\u206E\u200D\u200F\u206E\u206F\u202B\u200F\u206C\u202E\u202B\u206B\u200C\u206A\u206B\u202D\u200C\u202D\u206C\u200D\u202A\u202A\u202E(this.KeyPanic) ? 1167120372U : 1993635167U);
					continue;
				case 28U:
					this.SetKey(this.menu.RebindingModule, 0);
					num2 = (num * 589787609U ^ 1328185194U);
					continue;
				case 29U:
				{
					KeyCode[] allKeyCodes;
					int num3;
					num2 = ((num3 >= allKeyCodes.Length) ? 1524127000U : 1385926852U);
					continue;
				}
				case 30U:
					num2 = (((this.menu == null) ? 668167023U : 55065930U) ^ num * 3506914965U);
					continue;
				case 31U:
					this.chatSpam.Enabled = !this.chatSpam.Enabled;
					num2 = (num * 1449365676U ^ 991507758U);
					continue;
				case 32U:
					num2 = (Main.\u200B\u202B\u202E\u206E\u202D\u200D\u200D\u206F\u206B\u202A\u206A\u206F\u200D\u206D\u200C\u206D\u200B\u202C\u200C\u206E\u200D\u200F\u206E\u206F\u202B\u200F\u206C\u202E\u202B\u206B\u200C\u206A\u206B\u202D\u200C\u202D\u206C\u200D\u202A\u202A\u202E(this.KeyToggleTrigger) ? 1783376727U : 2120215173U);
					continue;
				case 33U:
					this.menu.showMenu = !this.menu.showMenu;
					num2 = (num * 1400275022U ^ 673348859U);
					continue;
				case 34U:
				{
					KeyCode keyCode;
					num2 = (((keyCode != 27) ? 477703787U : 1026508794U) ^ num * 2980700691U);
					continue;
				}
				case 35U:
					num2 = (Main.\u200B\u202B\u202E\u206E\u202D\u200D\u200D\u206F\u206B\u202A\u206A\u206F\u200D\u206D\u200C\u206D\u200B\u202C\u200C\u206E\u200D\u200F\u206E\u206F\u202B\u200F\u206C\u202E\u202B\u206B\u200C\u206A\u206B\u202D\u200C\u202D\u206C\u200D\u202A\u202A\u202E(this.KeyToggleESP) ? 488248400U : 1795788458U);
					continue;
				case 36U:
					goto IL_18D;
				}
				break;
			}
			return;
			IL_10:
			num2 = 1558316641U;
			goto IL_15;
			IL_18D:
			Main.CachedCamera = (Main.\u206F\u206C\u200E\u200E\u202A\u206B\u206E\u202C\u200C\u200D\u202B\u206C\u202C\u202A\u202B\u200F\u200E\u202C\u202E\u200D\u200F\u200B\u202D\u206A\u200D\u202B\u206D\u202E\u202A\u200C\u206F\u206F\u202A\u202D\u202B\u202A\u206B\u202E\u206A\u202E() ?? Main.\u206B\u206D\u206D\u206D\u200D\u202B\u200D\u206D\u202E\u206D\u200F\u206A\u206D\u202D\u202B\u206A\u202D\u206A\u202B\u206B\u200E\u206F\u200C\u202C\u202C\u200F\u206A\u202D\u200C\u202B\u200B\u200B\u200B\u200B\u206A\u200F\u202C\u200C\u202B\u202E());
			num2 = 210890988U;
			goto IL_15;
		}

		// Token: 0x06000293 RID: 659 RVA: 0x0000D304 File Offset: 0x0000B504
		private void PanicDisable()
		{
		}

		// Token: 0x06000294 RID: 660 RVA: 0x0001C810 File Offset: 0x0001AA10
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void SetKey(string module, KeyCode key)
		{
			if (module != null)
			{
				for (;;)
				{
					IL_06:
					uint num = 2860207131U;
					for (;;)
					{
						uint num2;
						char c;
						switch ((num2 = (num ^ 2787057974U)) % 44U)
						{
						case 0U:
							return;
						case 1U:
						{
							int num3 = Main.\u200E\u200D\u202B\u200B\u202C\u200E\u206B\u200C\u206C\u202D\u200B\u202A\u206E\u206A\u200C\u200F\u202E\u200B\u200F\u200F\u200B\u202A\u206D\u206F\u206B\u200C\u202D\u206C\u202A\u200C\u202B\u206F\u206D\u200F\u206F\u206A\u200F\u202E\u200C\u202D\u202E(module);
							num = (num2 * 2145698654U ^ 272128675U);
							continue;
						}
						case 2U:
							goto IL_06;
						case 3U:
							goto IL_2CD;
						case 4U:
							goto IL_18A;
						case 5U:
							num = (Main.\u200B\u206F\u200B\u200E\u206A\u200D\u200D\u200B\u206A\u200D\u202B\u202B\u200C\u200B\u202B\u206D\u206E\u202C\u200D\u206B\u206D\u200E\u202A\u202E\u206F\u200D\u206C\u206B\u206C\u202D\u206F\u206B\u200D\u200D\u206D\u206A\u200B\u206D\u206F\u206F\u202E(module, <Module>.\u200F\u206F\u200E\u202A\u200D\u200C\u206A\u200E\u202E\u202C\u200D\u202D\u200D\u202B\u200F\u200C\u200F\u200D\u206B\u206D\u206E\u202A\u206C\u206B\u200B\u200F\u206D\u206A\u202E\u206C\u206F\u206A\u200C\u200C\u206C\u202A\u206F\u206A\u202D\u206E\u202E<string>(426713319)) ? 4219140850U : 2512357448U);
							continue;
						case 6U:
							return;
						case 7U:
							return;
						case 8U:
							num = (((c != 'T') ? 3199915999U : 4161306371U) ^ num2 * 3175640592U);
							continue;
						case 9U:
							return;
						case 11U:
						{
							int num3;
							switch (num3)
							{
							case 3:
								goto IL_427;
							case 4:
								goto IL_3D9;
							case 5:
								goto IL_4EB;
							case 6:
								goto IL_230;
							case 7:
								goto IL_34E;
							case 8:
								goto IL_376;
							case 9:
							case 11:
							case 12:
								break;
							case 10:
								goto IL_18A;
							case 13:
								goto IL_2CD;
							default:
								num = (num2 * 3418775023U ^ 1023919703U);
								continue;
							}
							break;
						}
						case 12U:
							num = ((!Main.\u200B\u206F\u200B\u200E\u206A\u200D\u200D\u200B\u206A\u200D\u202B\u202B\u200C\u200B\u202B\u206D\u206E\u202C\u200D\u206B\u206D\u200E\u202A\u202E\u206F\u200D\u206C\u206B\u206C\u202D\u206F\u206B\u200D\u200D\u206D\u206A\u200B\u206D\u206F\u206F\u202E(module, <Module>.\u200F\u206F\u200E\u202A\u200D\u200C\u206A\u200E\u202E\u202C\u200D\u202D\u200D\u202B\u200F\u200C\u200F\u200D\u206B\u206D\u206E\u202A\u206C\u206B\u200B\u200F\u206D\u206A\u202E\u206C\u206F\u206A\u200C\u200C\u206C\u202A\u206F\u206A\u202D\u206E\u202E<string>(-201563242))) ? 3973137900U : 3933742466U);
							continue;
						case 13U:
							this.KeyPanic = key;
							num = 3280478000U;
							continue;
						case 14U:
							return;
						case 15U:
							this.KeyToggleAimbot = key;
							num = 3384761116U;
							continue;
						case 16U:
							goto IL_167;
						case 17U:
							this.KeyItemVacuum = key;
							num = 4022261385U;
							continue;
						case 18U:
							return;
						case 19U:
							goto IL_34E;
						case 20U:
							goto IL_3D9;
						case 21U:
							return;
						case 22U:
							return;
						case 23U:
							return;
						case 24U:
							num = (((c == 'I') ? 1373040235U : 706700242U) ^ num2 * 3849187358U);
							continue;
						case 25U:
							goto IL_230;
						case 26U:
							goto IL_427;
						case 27U:
							goto IL_258;
						case 28U:
							return;
						case 29U:
							return;
						case 30U:
							return;
						case 31U:
							return;
						case 32U:
							return;
						case 33U:
							goto IL_33C;
						case 34U:
							return;
						case 35U:
							this.KeyToggleESP = key;
							num = 2892470936U;
							continue;
						case 36U:
							goto IL_F6;
						case 37U:
							num = ((!Main.\u200B\u206F\u200B\u200E\u206A\u200D\u200D\u200B\u206A\u200D\u202B\u202B\u200C\u200B\u202B\u206D\u206E\u202C\u200D\u206B\u206D\u200E\u202A\u202E\u206F\u200D\u206C\u206B\u206C\u202D\u206F\u206B\u200D\u200D\u206D\u206A\u200B\u206D\u206F\u206F\u202E(module, <Module>.\u200F\u206F\u200E\u202A\u200D\u200C\u206A\u200E\u202E\u202C\u200D\u202D\u200D\u202B\u200F\u200C\u200F\u200D\u206B\u206D\u206E\u202A\u206C\u206B\u200B\u200F\u206D\u206A\u202E\u206C\u206F\u206A\u200C\u200C\u206C\u202A\u206F\u206A\u202D\u206E\u202E<string>(30497894))) ? 3952980344U : 2928713003U);
							continue;
						case 38U:
							return;
						case 39U:
							this.KeyToggleVehicleNoclip = key;
							num = 2534890548U;
							continue;
						case 40U:
							goto IL_376;
						case 41U:
							return;
						case 42U:
							goto IL_4EB;
						case 43U:
							this.KeyToggleMenu = key;
							num = 3436089233U;
							continue;
						}
						goto Block_1;
						IL_18A:
						c = Main.\u200D\u206F\u200C\u202B\u206B\u202B\u206E\u206E\u200F\u206A\u200C\u206A\u200C\u202C\u200B\u202C\u206F\u206B\u200E\u200C\u206F\u202C\u200C\u200D\u206E\u200E\u202D\u200B\u206E\u202B\u206A\u200B\u200B\u202B\u200F\u200C\u202C\u200B\u200B\u206B\u202E(module, 0);
						num = ((c == 'A') ? 2861081914U : 4243775550U);
						continue;
						IL_230:
						num = ((!Main.\u200B\u206F\u200B\u200E\u206A\u200D\u200D\u200B\u206A\u200D\u202B\u202B\u200C\u200B\u202B\u206D\u206E\u202C\u200D\u206B\u206D\u200E\u202A\u202E\u206F\u200D\u206C\u206B\u206C\u202D\u206F\u206B\u200D\u200D\u206D\u206A\u200B\u206D\u206F\u206F\u202E(module, <Module>.\u200B\u206C\u200C\u200C\u206A\u200B\u200D\u206C\u206B\u206D\u202B\u200F\u200E\u206E\u206A\u200D\u206B\u202E\u206A\u200E\u200B\u202E\u200F\u206C\u200F\u202A\u202B\u200F\u200D\u200C\u202D\u200E\u206B\u200D\u202A\u200E\u202E\u206A\u202B\u200C\u202E<string>(412957430))) ? 3118763201U : 2781376573U);
						continue;
						IL_2CD:
						num = (Main.\u200B\u206F\u200B\u200E\u206A\u200D\u200D\u200B\u206A\u200D\u202B\u202B\u200C\u200B\u202B\u206D\u206E\u202C\u200D\u206B\u206D\u200E\u202A\u202E\u206F\u200D\u206C\u206B\u206C\u202D\u206F\u206B\u200D\u200D\u206D\u206A\u200B\u206D\u206F\u206F\u202E(module, <Module>.\u200B\u206C\u200C\u200C\u206A\u200B\u200D\u206C\u206B\u206D\u202B\u200F\u200E\u206E\u206A\u200D\u206B\u202E\u206A\u200E\u200B\u202E\u200F\u206C\u200F\u202A\u202B\u200F\u200D\u200C\u202D\u200E\u206B\u200D\u202A\u200E\u202E\u206A\u202B\u200C\u202E<string>(-1534800753)) ? 3542483533U : 4212922238U);
						continue;
						IL_34E:
						num = (Main.\u200B\u206F\u200B\u200E\u206A\u200D\u200D\u200B\u206A\u200D\u202B\u202B\u200C\u200B\u202B\u206D\u206E\u202C\u200D\u206B\u206D\u200E\u202A\u202E\u206F\u200D\u206C\u206B\u206C\u202D\u206F\u206B\u200D\u200D\u206D\u206A\u200B\u206D\u206F\u206F\u202E(module, <Module>.\u200F\u206F\u200E\u202A\u200D\u200C\u206A\u200E\u202E\u202C\u200D\u202D\u200D\u202B\u200F\u200C\u200F\u200D\u206B\u206D\u206E\u202A\u206C\u206B\u200B\u200F\u206D\u206A\u202E\u206C\u206F\u206A\u200C\u200C\u206C\u202A\u206F\u206A\u202D\u206E\u202E<string>(2061950974)) ? 3747437343U : 3547158384U);
						continue;
						IL_376:
						num = (Main.\u200B\u206F\u200B\u200E\u206A\u200D\u200D\u200B\u206A\u200D\u202B\u202B\u200C\u200B\u202B\u206D\u206E\u202C\u200D\u206B\u206D\u200E\u202A\u202E\u206F\u200D\u206C\u206B\u206C\u202D\u206F\u206B\u200D\u200D\u206D\u206A\u200B\u206D\u206F\u206F\u202E(module, <Module>.\u206A\u202C\u206A\u206C\u202A\u206F\u200B\u206C\u206C\u206B\u206F\u206C\u200C\u206D\u200C\u200C\u206C\u206A\u202A\u206B\u200B\u202E\u200C\u206E\u202D\u202A\u200E\u202D\u200E\u200E\u200D\u200E\u202B\u202A\u206E\u202A\u200B\u200B\u202D\u202E<string>(1953082814)) ? 3695599685U : 4002003399U);
						continue;
						IL_3D9:
						num = (Main.\u200B\u206F\u200B\u200E\u206A\u200D\u200D\u200B\u206A\u200D\u202B\u202B\u200C\u200B\u202B\u206D\u206E\u202C\u200D\u206B\u206D\u200E\u202A\u202E\u206F\u200D\u206C\u206B\u206C\u202D\u206F\u206B\u200D\u200D\u206D\u206A\u200B\u206D\u206F\u206F\u202E(module, <Module>.\u200F\u206F\u200E\u202A\u200D\u200C\u206A\u200E\u202E\u202C\u200D\u202D\u200D\u202B\u200F\u200C\u200F\u200D\u206B\u206D\u206E\u202A\u206C\u206B\u200B\u200F\u206D\u206A\u202E\u206C\u206F\u206A\u200C\u200C\u206C\u202A\u206F\u206A\u202D\u206E\u202E<string>(-1115533500)) ? 3166213237U : 2962254947U);
						continue;
						IL_427:
						num = ((!Main.\u200B\u206F\u200B\u200E\u206A\u200D\u200D\u200B\u206A\u200D\u202B\u202B\u200C\u200B\u202B\u206D\u206E\u202C\u200D\u206B\u206D\u200E\u202A\u202E\u206F\u200D\u206C\u206B\u206C\u202D\u206F\u206B\u200D\u200D\u206D\u206A\u200B\u206D\u206F\u206F\u202E(module, <Module>.\u202E\u206C\u206E\u202C\u202D\u202D\u206D\u206B\u202B\u206F\u200B\u206E\u200B\u202C\u202A\u200D\u202D\u200B\u202D\u202E\u200D\u206F\u206C\u202C\u200B\u202C\u206D\u202B\u206C\u206E\u200E\u206A\u200D\u206F\u200E\u206E\u206A\u200C\u200D\u206B\u202E<string>(488137165))) ? 2891022794U : 2570878465U);
						continue;
						IL_4EB:
						num = ((!Main.\u200B\u206F\u200B\u200E\u206A\u200D\u200D\u200B\u206A\u200D\u202B\u202B\u200C\u200B\u202B\u206D\u206E\u202C\u200D\u206B\u206D\u200E\u202A\u202E\u206F\u200D\u206C\u206B\u206C\u202D\u206F\u206B\u200D\u200D\u206D\u206A\u200B\u206D\u206F\u206F\u202E(module, <Module>.\u206A\u202C\u206A\u206C\u202A\u206F\u200B\u206C\u206C\u206B\u206F\u206C\u200C\u206D\u200C\u200C\u206C\u206A\u202A\u206B\u200B\u202E\u200C\u206E\u202D\u202A\u200E\u202D\u200E\u200E\u200D\u200E\u202B\u202A\u206E\u202A\u200B\u200B\u202D\u202E<string>(1669719977))) ? 3842053475U : 2313363839U);
					}
				}
				Block_1:
				return;
				IL_F6:
				this.KeyAimbotHold = key;
				return;
				IL_167:
				this.KeyToggleTrigger = key;
				return;
				IL_258:
				this.KeyToggleChatSpam = key;
				return;
				IL_33C:
				this.KeyFreeCam = key;
				return;
			}
		}

		// Token: 0x06000296 RID: 662 RVA: 0x000061E8 File Offset: 0x000043E8
		static bool \u206C\u206E\u206D\u206B\u206E\u202A\u206E\u206A\u202E\u202C\u200F\u206A\u206C\u202A\u202D\u202E\u202B\u206C\u200D\u200D\u200D\u206A\u200F\u200F\u206B\u206B\u206D\u202B\u202B\u202E\u206F\u206C\u200F\u206A\u206A\u200E\u206F\u206D\u206E\u206E\u202E(Object A_0, Object A_1)
		{
			return A_0 != A_1;
		}

		// Token: 0x06000297 RID: 663 RVA: 0x0000C870 File Offset: 0x0000AA70
		static GameObject \u202D\u202A\u200E\u206B\u206D\u206B\u206A\u202A\u206A\u202C\u200D\u202E\u202B\u202D\u202A\u200C\u200D\u206D\u202C\u206D\u202E\u200E\u202A\u206D\u200E\u202B\u202C\u206E\u206E\u206E\u200F\u202B\u206C\u200B\u206A\u200C\u200B\u206F\u200D\u200C\u202E(Component A_0)
		{
			return A_0.gameObject;
		}

		// Token: 0x06000298 RID: 664 RVA: 0x000061FC File Offset: 0x000043FC
		static void \u200B\u206D\u206E\u202B\u206F\u202A\u206C\u206F\u200B\u206B\u202D\u206C\u206F\u206F\u206B\u206E\u206B\u206A\u200C\u206C\u202C\u200D\u202A\u200B\u200D\u202D\u202B\u206C\u206E\u202B\u202E\u206A\u206B\u206E\u206A\u202D\u202E\u206B\u200D\u206F\u202E(Object A_0)
		{
			Object.Destroy(A_0);
		}

		// Token: 0x06000299 RID: 665 RVA: 0x000061D4 File Offset: 0x000043D4
		static void \u206F\u206C\u206C\u200D\u206F\u202B\u200D\u202A\u202E\u200D\u202D\u200E\u206D\u200C\u202B\u202A\u200B\u200C\u206B\u200D\u202B\u202E\u202D\u202B\u200D\u200E\u206D\u206C\u200E\u206C\u206D\u202E\u202D\u200B\u206A\u206F\u206F\u200D\u206C\u200D\u202E(Object A_0)
		{
			Object.DontDestroyOnLoad(A_0);
		}

		// Token: 0x0600029A RID: 666 RVA: 0x0000D3C0 File Offset: 0x0000B5C0
		static Coroutine \u206E\u206B\u206A\u200B\u202A\u200C\u202C\u200C\u206A\u202A\u206A\u202B\u200B\u206D\u206C\u202A\u202C\u206C\u200B\u200E\u206B\u200B\u202C\u202D\u202E\u202B\u206C\u206F\u206C\u200C\u200D\u206F\u200F\u200F\u202E\u202E\u202D\u206B\u206E\u206B\u202E(MonoBehaviour A_0, IEnumerator A_1)
		{
			return A_0.StartCoroutine(A_1);
		}

		// Token: 0x0600029B RID: 667 RVA: 0x000076A4 File Offset: 0x000058A4
		static bool \u206D\u206D\u206D\u202D\u206E\u202D\u202B\u206C\u206E\u202E\u202D\u206C\u202C\u202E\u202A\u202E\u202A\u200C\u202C\u202B\u206E\u206F\u200E\u206F\u202A\u202A\u200F\u200B\u206E\u202A\u206E\u206B\u206B\u206E\u206B\u202C\u200C\u200C\u206E\u202B\u202E(Object A_0, Object A_1)
		{
			return A_0 == A_1;
		}

		// Token: 0x0600029C RID: 668 RVA: 0x0001CDB8 File Offset: 0x0001AFB8
		static bool \u206B\u200C\u202C\u206E\u202D\u202B\u200F\u206C\u202C\u206D\u202C\u202E\u202C\u202A\u202A\u206E\u200E\u202A\u206B\u206A\u202D\u206D\u200B\u202C\u206D\u200C\u200C\u200C\u202D\u206A\u202C\u200E\u206E\u206A\u202D\u202A\u206C\u202D\u200F\u200D\u202E(Behaviour A_0)
		{
			return A_0.isActiveAndEnabled;
		}

		// Token: 0x0600029D RID: 669 RVA: 0x0001CDCC File Offset: 0x0001AFCC
		static Camera \u206F\u206C\u200E\u200E\u202A\u206B\u206E\u202C\u200C\u200D\u202B\u206C\u202C\u202A\u202B\u200F\u200E\u202C\u202E\u200D\u200F\u200B\u202D\u206A\u200D\u202B\u206D\u202E\u202A\u200C\u206F\u206F\u202A\u202D\u202B\u202A\u206B\u202E\u206A\u202E()
		{
			return Camera.main;
		}

		// Token: 0x0600029E RID: 670 RVA: 0x0001CDE0 File Offset: 0x0001AFE0
		static Camera \u206B\u206D\u206D\u206D\u200D\u202B\u200D\u206D\u202E\u206D\u200F\u206A\u206D\u202D\u202B\u206A\u202D\u206A\u202B\u206B\u200E\u206F\u200C\u202C\u202C\u200F\u206A\u202D\u200C\u202B\u200B\u200B\u200B\u200B\u206A\u200F\u202C\u200C\u202B\u202E()
		{
			return Camera.current;
		}

		// Token: 0x0600029F RID: 671 RVA: 0x0000C968 File Offset: 0x0000AB68
		static bool \u206D\u206C\u200C\u202A\u200F\u206E\u202A\u200C\u200F\u200F\u200C\u206D\u202D\u200D\u206D\u200D\u200B\u202D\u206E\u200F\u202A\u202D\u206B\u200C\u206B\u206B\u200F\u206B\u202E\u200C\u202E\u200F\u200F\u206D\u202B\u206B\u202C\u200E\u200C\u206B\u202E(string A_0)
		{
			return string.IsNullOrEmpty(A_0);
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x000076F4 File Offset: 0x000058F4
		static bool \u200B\u202B\u202E\u206E\u202D\u200D\u200D\u206F\u206B\u202A\u206A\u206F\u200D\u206D\u200C\u206D\u200B\u202C\u200C\u206E\u200D\u200F\u206E\u206F\u202B\u200F\u206C\u202E\u202B\u206B\u200C\u206A\u206B\u202D\u200C\u202D\u206C\u200D\u202A\u202A\u202E(KeyCode A_0)
		{
			return Input.GetKeyDown(A_0);
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x0001AB34 File Offset: 0x00018D34
		static int \u200E\u200D\u202B\u200B\u202C\u200E\u206B\u200C\u206C\u202D\u200B\u202A\u206E\u206A\u200C\u200F\u202E\u200B\u200F\u200F\u200B\u202A\u206D\u206F\u206B\u200C\u202D\u206C\u202A\u200C\u202B\u206F\u206D\u200F\u206F\u206A\u200F\u202E\u200C\u202D\u202E(string A_0)
		{
			return A_0.Length;
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x0001AB48 File Offset: 0x00018D48
		static char \u200D\u206F\u200C\u202B\u206B\u202B\u206E\u206E\u200F\u206A\u200C\u206A\u200C\u202C\u200B\u202C\u206F\u206B\u200E\u200C\u206F\u202C\u200C\u200D\u206E\u200E\u202D\u200B\u206E\u202B\u206A\u200B\u200B\u202B\u200F\u200C\u202C\u200B\u200B\u206B\u202E(string A_0, int A_1)
		{
			return A_0[A_1];
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x0001AB20 File Offset: 0x00018D20
		static bool \u200B\u206F\u200B\u200E\u206A\u200D\u200D\u200B\u206A\u200D\u202B\u202B\u200C\u200B\u202B\u206D\u206E\u202C\u200D\u206B\u206D\u200E\u202A\u202E\u206F\u200D\u206C\u206B\u206C\u202D\u206F\u206B\u200D\u200D\u206D\u206A\u200B\u206D\u206F\u206F\u202E(string A_0, string A_1)
		{
			return A_0 == A_1;
		}

		// Token: 0x04000141 RID: 321
		public ESP esp;

		// Token: 0x04000142 RID: 322
		public Aimbot aimbot;

		// Token: 0x04000143 RID: 323
		public Visuals visuals;

		// Token: 0x04000144 RID: 324
		public Triggerbot triggerbot;

		// Token: 0x04000145 RID: 325
		public WeaponMods weaponMods;

		// Token: 0x04000146 RID: 326
		public ChatSpam chatSpam;

		// Token: 0x04000147 RID: 327
		public Entities entities;

		// Token: 0x04000148 RID: 328
		public VehicleNoclip vehicleNoclip;

		// Token: 0x04000149 RID: 329
		public ItemVacuum itemVacuum;

		// Token: 0x0400014A RID: 330
		public FreeCam freeCam;

		// Token: 0x0400014B RID: 331
		public KeyCode KeyToggleMenu = 282;

		// Token: 0x0400014C RID: 332
		public KeyCode KeyToggleESP = 283;

		// Token: 0x0400014D RID: 333
		public KeyCode KeyToggleAimbot = 284;

		// Token: 0x0400014E RID: 334
		public KeyCode KeyAimbotHold = 324;

		// Token: 0x0400014F RID: 335
		public KeyCode KeyToggleTrigger = 285;

		// Token: 0x04000150 RID: 336
		public KeyCode KeyToggleChatSpam = 286;

		// Token: 0x04000151 RID: 337
		public KeyCode KeyToggleVehicleNoclip = 304;

		// Token: 0x04000152 RID: 338
		public KeyCode KeyItemVacuum = 287;

		// Token: 0x04000153 RID: 339
		public KeyCode KeyFreeCam = 288;

		// Token: 0x04000154 RID: 340
		public KeyCode KeyPanic = 127;

		// Token: 0x04000155 RID: 341
		public bool AimbotHoldToAim = true;

		// Token: 0x04000156 RID: 342
		internal Menu menu;
	}
}
