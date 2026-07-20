using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cheat.core;
using HighlightingSystem;
using SDG.Unturned;
using UnityEngine;

namespace Cheat.modules
{
	// Token: 0x02000011 RID: 17
	public class ESP : MonoBehaviour
	{
		// Token: 0x06000089 RID: 137 RVA: 0x00007DE0 File Offset: 0x00005FE0
		private void InitGUIStyles()
		{
			if (this.objectTextStyle == null)
			{
				goto IL_0B;
			}
			goto IL_F6;
			uint num2;
			for (;;)
			{
				IL_10:
				uint num;
				switch ((num = (num2 ^ 2448812776U)) % 7U)
				{
				case 0U:
					goto IL_0B;
				case 1U:
				{
					GUIStyle guistyle = ESP.\u206F\u206B\u202B\u202E\u202A\u206C\u206C\u202B\u206A\u200E\u202C\u206C\u206C\u200E\u200B\u200D\u206F\u202C\u202D\u206B\u206B\u200D\u202E\u206D\u206B\u206C\u206F\u202A\u200C\u200B\u202D\u200F\u200C\u200B\u206B\u202C\u200E\u200D\u202A\u202D\u202E(ESP.\u200B\u206D\u206F\u200B\u206F\u206D\u200D\u206E\u202D\u206D\u206A\u200B\u206E\u202A\u200E\u200F\u206A\u206F\u202E\u202C\u202A\u202E\u202D\u200C\u202B\u202A\u206D\u200B\u202D\u202C\u206A\u206C\u206D\u206C\u202C\u206A\u206A\u200D\u200C\u206E\u202E(ESP.\u202E\u206B\u200C\u206C\u206D\u206C\u206C\u200B\u206B\u202E\u200C\u202B\u200B\u202A\u202C\u202D\u202C\u202E\u206D\u200F\u200F\u206D\u202D\u202B\u200E\u200E\u200D\u200B\u200D\u206C\u206D\u206A\u202E\u200E\u200C\u200C\u206D\u200F\u202C\u206D\u202E()));
					ESP.\u206C\u206B\u202C\u200B\u202C\u200B\u206F\u206D\u206A\u202E\u202A\u200E\u200F\u206A\u200D\u202D\u200D\u200C\u200E\u206C\u200B\u200E\u206F\u202E\u206E\u202A\u202A\u206E\u202D\u202C\u202C\u206F\u206F\u206A\u202D\u202E\u200D\u202C\u200D\u200E\u202E(guistyle, 4);
					ESP.\u206D\u202B\u206E\u200F\u202D\u200F\u202B\u200F\u202D\u206F\u200B\u200B\u202D\u206C\u200C\u200D\u206F\u206C\u202B\u202E\u200F\u200B\u202D\u200F\u206C\u200B\u206D\u206A\u200F\u206D\u202B\u202B\u206F\u200C\u206C\u206B\u202A\u202A\u202B\u202E(guistyle, 12);
					ESP.\u200C\u202A\u200B\u206D\u202A\u206F\u202A\u206D\u200F\u200D\u200D\u200B\u200D\u206E\u206B\u202D\u202A\u206E\u206E\u206C\u200E\u202A\u202E\u200B\u200D\u206F\u200E\u202D\u206F\u202E\u206F\u200D\u200E\u206B\u206C\u206C\u206D\u200D\u206A\u202E\u202E(guistyle, 1);
					this.objectTextStyle = guistyle;
					num2 = (num * 1018362416U ^ 1549898673U);
					continue;
				}
				case 2U:
				{
					GUIStyle guistyle2 = ESP.\u206F\u206B\u202B\u202E\u202A\u206C\u206C\u202B\u206A\u200E\u202C\u206C\u206C\u200E\u200B\u200D\u206F\u202C\u202D\u206B\u206B\u200D\u202E\u206D\u206B\u206C\u206F\u202A\u200C\u200B\u202D\u200F\u200C\u200B\u206B\u202C\u200E\u200D\u202A\u202D\u202E(ESP.\u200B\u206D\u206F\u200B\u206F\u206D\u200D\u206E\u202D\u206D\u206A\u200B\u206E\u202A\u200E\u200F\u206A\u206F\u202E\u202C\u202A\u202E\u202D\u200C\u202B\u202A\u206D\u200B\u202D\u202C\u206A\u206C\u206D\u206C\u202C\u206A\u206A\u200D\u200C\u206E\u202E(ESP.\u202E\u206B\u200C\u206C\u206D\u206C\u206C\u200B\u206B\u202E\u200C\u202B\u200B\u202A\u202C\u202D\u202C\u202E\u206D\u200F\u200F\u206D\u202D\u202B\u200E\u200E\u200D\u200B\u200D\u206C\u206D\u206A\u202E\u200E\u200C\u200C\u206D\u200F\u202C\u206D\u202E()));
					ESP.\u206C\u206B\u202C\u200B\u202C\u200B\u206F\u206D\u206A\u202E\u202A\u200E\u200F\u206A\u200D\u202D\u200D\u200C\u200E\u206C\u200B\u200E\u206F\u202E\u206E\u202A\u202A\u206E\u202D\u202C\u202C\u206F\u206F\u206A\u202D\u202E\u200D\u202C\u200D\u200E\u202E(guistyle2, 4);
					ESP.\u200C\u202A\u200B\u206D\u202A\u206F\u202A\u206D\u200F\u200D\u200D\u200B\u200D\u206E\u206B\u202D\u202A\u206E\u206E\u206C\u200E\u202A\u202E\u200B\u200D\u206F\u200E\u202D\u206F\u202E\u206F\u200D\u200E\u206B\u206C\u206C\u206D\u200D\u206A\u202E\u202E(guistyle2, 1);
					this.itemTextStyle = guistyle2;
					num2 = (num * 1142686629U ^ 3703346772U);
					continue;
				}
				case 4U:
					goto IL_F6;
				case 5U:
				{
					GUIStyle guistyle3 = ESP.\u206F\u206B\u202B\u202E\u202A\u206C\u206C\u202B\u206A\u200E\u202C\u206C\u206C\u200E\u200B\u200D\u206F\u202C\u202D\u206B\u206B\u200D\u202E\u206D\u206B\u206C\u206F\u202A\u200C\u200B\u202D\u200F\u200C\u200B\u206B\u202C\u200E\u200D\u202A\u202D\u202E(ESP.\u200B\u206D\u206F\u200B\u206F\u206D\u200D\u206E\u202D\u206D\u206A\u200B\u206E\u202A\u200E\u200F\u206A\u206F\u202E\u202C\u202A\u202E\u202D\u200C\u202B\u202A\u206D\u200B\u202D\u202C\u206A\u206C\u206D\u206C\u202C\u206A\u206A\u200D\u200C\u206E\u202E(ESP.\u202E\u206B\u200C\u206C\u206D\u206C\u206C\u200B\u206B\u202E\u200C\u202B\u200B\u202A\u202C\u202D\u202C\u202E\u206D\u200F\u200F\u206D\u202D\u202B\u200E\u200E\u200D\u200B\u200D\u206C\u206D\u206A\u202E\u200E\u200C\u200C\u206D\u200F\u202C\u206D\u202E()));
					ESP.\u206C\u206B\u202C\u200B\u202C\u200B\u206F\u206D\u206A\u202E\u202A\u200E\u200F\u206A\u200D\u202D\u200D\u200C\u200E\u206C\u200B\u200E\u206F\u202E\u206E\u202A\u202A\u206E\u202D\u202C\u202C\u206F\u206F\u206A\u202D\u202E\u200D\u202C\u200D\u200E\u202E(guistyle3, 4);
					this.playerInfoTextStyle = guistyle3;
					num2 = (num * 2769799082U ^ 2409560582U);
					continue;
				}
				case 6U:
					num2 = ((this.playerInfoTextStyle != null) ? 2790508656U : 3469085223U);
					continue;
				}
				break;
			}
			return;
			IL_0B:
			num2 = 2367326973U;
			goto IL_10;
			IL_F6:
			num2 = ((this.itemTextStyle == null) ? 2465450892U : 3774555936U);
			goto IL_10;
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00007F00 File Offset: 0x00006100
		private void Awake()
		{
			Main main = Object.FindObjectOfType<Main>();
			this.entities = ((main != null) ? main.entities : null);
			for (;;)
			{
				IL_17:
				uint num = 1403262031U;
				for (;;)
				{
					uint num2;
					switch ((num2 = (num ^ 784321533U)) % 4U)
					{
					case 1U:
						this.entities = ESP.\u202A\u202E\u206E\u202C\u200B\u202C\u206A\u202D\u206D\u206B\u200E\u202B\u202B\u202A\u206D\u202E\u202B\u200B\u202E\u200B\u206B\u200F\u202D\u206B\u206E\u200E\u202C\u202D\u202D\u200B\u202A\u202D\u206A\u202B\u200E\u200D\u206D\u202A\u200E\u206A\u202E(this).AddComponent<Entities>();
						num = (num2 * 2457084353U ^ 1317903020U);
						continue;
					case 2U:
						num = ((ESP.\u200D\u200E\u202A\u200E\u206F\u202E\u206D\u200D\u200C\u206F\u200F\u206A\u206B\u202C\u200B\u202C\u206D\u200F\u200E\u206A\u202E\u206D\u206E\u206B\u206C\u200B\u206E\u206A\u200F\u206B\u200F\u202A\u206C\u202E\u200C\u202D\u200C\u202C\u206F\u202D\u202E(this.entities, null) ? 2067310844U : 483279725U) ^ num2 * 1623882776U);
						continue;
					case 3U:
						goto IL_17;
					}
					return;
				}
			}
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00007F94 File Offset: 0x00006194
		private void Start()
		{
			this.CheckHighlightingRenderer();
			this.InitializeHighlighters();
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00007FB0 File Offset: 0x000061B0
		private void InitializeHighlighters()
		{
			if (ESP.\u200D\u200E\u202A\u200E\u206F\u202E\u206D\u200D\u200C\u206F\u200F\u206A\u206B\u202C\u200B\u202C\u206D\u200F\u200E\u206A\u202E\u206D\u206E\u206B\u206C\u200B\u206E\u206A\u200F\u206B\u200F\u202A\u206C\u202E\u200C\u202D\u200C\u202C\u206F\u202D\u202E(this.entities, null))
			{
				for (;;)
				{
					switch ((1750669019 ^ 563961912) % 3)
					{
					case 0:
						continue;
					case 2:
						return;
					}
					break;
				}
			}
			using (List<Player>.Enumerator enumerator = this.entities.Players.GetEnumerator())
			{
				for (;;)
				{
					IL_8F:
					uint num = enumerator.MoveNext() ? 1595126433U : 1465079471U;
					for (;;)
					{
						uint num2;
						switch ((num2 = (num ^ 563961912U)) % 8U)
						{
						case 0U:
						{
							Player player;
							num = (((!ESP.\u200E\u202D\u202D\u200C\u206F\u206A\u202A\u200B\u202B\u202B\u200E\u206C\u202D\u200F\u202C\u206C\u200D\u206E\u200C\u202D\u206D\u206F\u200E\u200C\u202D\u200F\u202B\u202D\u202D\u200D\u200F\u206C\u206B\u200B\u202A\u206C\u200E\u200B\u200D\u206F\u202E(player, ESP.\u202E\u206A\u200D\u206A\u206F\u206B\u202A\u206A\u202C\u202A\u206D\u206B\u202A\u206C\u202B\u206E\u200D\u202C\u200F\u206B\u206B\u206A\u200B\u206D\u206A\u202E\u206E\u202A\u200F\u206A\u202E\u202E\u206E\u202E\u202C\u202B\u202A\u206E\u200E\u200E\u202E())) ? 960903685U : 1288396044U) ^ num2 * 2784455079U);
							continue;
						}
						case 1U:
						{
							Player player = enumerator.Current;
							num = 132042790U;
							continue;
						}
						case 2U:
						{
							Player player;
							this.AddHighlighter(ESP.\u200E\u202D\u200C\u206D\u202D\u200B\u202C\u202E\u206F\u202C\u200B\u206E\u206D\u200C\u200E\u200F\u200C\u200E\u200B\u200F\u200C\u202B\u200C\u202E\u200C\u202A\u202B\u200B\u206A\u206A\u206E\u206A\u202B\u202B\u202A\u202A\u206C\u202E\u200D\u206F\u202E(player));
							num = (num2 * 2957332878U ^ 213700057U);
							continue;
						}
						case 3U:
							num = 1595126433U;
							continue;
						case 4U:
						{
							Player player;
							num = (((!ESP.\u206E\u200B\u202A\u206C\u200B\u200B\u200C\u200E\u206A\u202B\u206E\u202B\u200F\u206C\u206A\u202D\u200B\u206F\u206F\u206F\u200F\u206B\u200E\u200B\u200F\u202D\u200F\u202E\u202D\u206A\u206C\u206B\u200B\u200E\u202C\u200E\u200B\u206C\u202D\u206B\u202E(ESP.\u202E\u206C\u206C\u206C\u206E\u206C\u206F\u206D\u202B\u200F\u200B\u202D\u202B\u200D\u200D\u202E\u206A\u202C\u200B\u206D\u200B\u200E\u206A\u202C\u206B\u202D\u202C\u206A\u206D\u202E\u200C\u206D\u206D\u202D\u206F\u200C\u206F\u206D\u200C\u200E\u202E(player))) ? 3200985758U : 3841364361U) ^ num2 * 705040431U);
							continue;
						}
						case 5U:
							goto IL_8F;
						case 6U:
						{
							Player player;
							num = (((!ESP.\u200E\u202D\u202D\u200C\u206F\u206A\u202A\u200B\u202B\u202B\u200E\u206C\u202D\u200F\u202C\u206C\u200D\u206E\u200C\u202D\u206D\u206F\u200E\u200C\u202D\u200F\u202B\u202D\u202D\u200D\u200F\u206C\u206B\u200B\u202A\u206C\u200E\u200B\u200D\u206F\u202E(player, null)) ? 1022072631U : 700543594U) ^ num2 * 2463630639U);
							continue;
						}
						}
						goto Block_6;
					}
				}
				Block_6:;
			}
			if (this.showItemGlow)
			{
				using (List<InteractableItem>.Enumerator enumerator2 = this.entities.Items.GetEnumerator())
				{
					for (;;)
					{
						IL_22B:
						uint num3 = enumerator2.MoveNext() ? 1275014592U : 236308515U;
						for (;;)
						{
							uint num2;
							switch ((num2 = (num3 ^ 563961912U)) % 7U)
							{
							case 0U:
							{
								InteractableItem interactableItem;
								num3 = (((!ESP.\u200E\u202D\u202D\u200C\u206F\u206A\u202A\u200B\u202B\u202B\u200E\u206C\u202D\u200F\u202C\u206C\u200D\u206E\u200C\u202D\u206D\u206F\u200E\u200C\u202D\u200F\u202B\u202D\u202D\u200D\u200F\u206C\u206B\u200B\u202A\u206C\u200E\u200B\u200D\u206F\u202E(interactableItem, null)) ? 1051661668U : 1891316950U) ^ num2 * 1892205350U);
								continue;
							}
							case 1U:
								goto IL_22B;
							case 2U:
								num3 = 1275014592U;
								continue;
							case 4U:
							{
								InteractableItem interactableItem = enumerator2.Current;
								num3 = 282139140U;
								continue;
							}
							case 5U:
							{
								InteractableItem interactableItem;
								num3 = (((interactableItem.asset == null) ? 1498057920U : 495202589U) ^ num2 * 2277230306U);
								continue;
							}
							case 6U:
							{
								InteractableItem interactableItem;
								this.AddHighlighter(ESP.\u200E\u202D\u200C\u206D\u202D\u200B\u202C\u202E\u206F\u202C\u200B\u206E\u206D\u200C\u200E\u200F\u200C\u200E\u200B\u200F\u200C\u202B\u200C\u202E\u200C\u202A\u202B\u200B\u206A\u206A\u206E\u206A\u202B\u202B\u202A\u202A\u206C\u202E\u200D\u206F\u202E(interactableItem));
								num3 = (num2 * 3367465108U ^ 2348851512U);
								continue;
							}
							}
							goto Block_13;
						}
					}
					Block_13:;
				}
			}
		}

		// Token: 0x0600008D RID: 141 RVA: 0x0000824C File Offset: 0x0000644C
		private void AddHighlighter(Transform target)
		{
			if (!ESP.\u200D\u200E\u202A\u200E\u206F\u202E\u206D\u200D\u200C\u206F\u200F\u206A\u206B\u202C\u200B\u202C\u206D\u200F\u200E\u206A\u202E\u206D\u206E\u206B\u206C\u200B\u206E\u206A\u200F\u206B\u200F\u202A\u206C\u202E\u200C\u202D\u200C\u202C\u206F\u202D\u202E(target, null))
			{
				for (;;)
				{
					IL_0C:
					uint num = 486960273U;
					for (;;)
					{
						uint num2;
						switch ((num2 = (num ^ 182871460U)) % 13U)
						{
						case 0U:
						{
							Highlighter highlighter;
							ESP.\u200C\u202B\u206A\u200F\u206C\u206F\u202A\u206F\u202D\u206A\u206F\u202D\u206E\u200C\u200C\u200D\u206A\u202C\u202A\u200D\u206E\u202A\u206E\u206E\u200B\u200F\u202E\u202E\u206D\u202B\u200C\u200F\u206C\u200B\u206F\u202D\u200B\u206F\u202D\u202E\u202E(highlighter, true);
							num = (num2 * 239965657U ^ 2136371597U);
							continue;
						}
						case 1U:
						{
							Highlighter highlighter = ESP.\u206D\u206C\u202B\u206D\u202B\u202E\u202B\u200B\u200D\u200B\u202D\u206A\u200D\u206A\u206A\u206F\u200B\u200B\u206A\u202E\u206B\u206D\u206A\u206C\u206F\u202B\u206A\u200D\u206D\u202D\u206F\u202E\u206E\u200B\u202E\u206F\u200B\u202E\u202E\u200C\u202E(target).AddComponent<Highlighter>();
							num = (num2 * 1192378660U ^ 212286636U);
							continue;
						}
						case 2U:
							return;
						case 3U:
						{
							Highlighter highlighter;
							num = (((!ESP.\u200D\u200E\u202A\u200E\u206F\u202E\u206D\u200D\u200C\u206F\u200F\u206A\u206B\u202C\u200B\u202C\u206D\u200F\u200E\u206A\u202E\u206D\u206E\u206B\u206C\u200B\u206E\u206A\u200F\u206B\u200F\u202A\u206C\u202E\u200C\u202D\u200C\u202C\u206F\u202D\u202E(highlighter, null)) ? 2328351304U : 2910934820U) ^ num2 * 3915560314U);
							continue;
						}
						case 4U:
						{
							Highlighter highlighter;
							ESP.\u206C\u200C\u200F\u202D\u206B\u206C\u206D\u202B\u206C\u200E\u202A\u202B\u206C\u206B\u202D\u200F\u206B\u200C\u206C\u202A\u200E\u200C\u200D\u200B\u202A\u206B\u206A\u206F\u206E\u200E\u200F\u200C\u200C\u202A\u200D\u206D\u200B\u200E\u200E\u202E\u202E(highlighter, true);
							num = (num2 * 4027571697U ^ 62936476U);
							continue;
						}
						case 5U:
							goto IL_0C;
						case 6U:
						{
							Highlighter highlighter;
							this.highlighters[target] = highlighter;
							num = 2058030316U;
							continue;
						}
						case 7U:
						{
							Highlighter highlighter;
							num = ((ESP.\u200D\u200E\u202A\u200E\u206F\u202E\u206D\u200D\u200C\u206F\u200F\u206A\u206B\u202C\u200B\u202C\u206D\u200F\u200E\u206A\u202E\u206D\u206E\u206B\u206C\u200B\u206E\u206A\u200F\u206B\u200F\u202A\u206C\u202E\u200C\u202D\u200C\u202C\u206F\u202D\u202E(highlighter, null) ? 688944776U : 1965895860U) ^ num2 * 3535799404U);
							continue;
						}
						case 9U:
						{
							Highlighter highlighter = target.GetComponent<Highlighter>();
							num = 1812111561U;
							continue;
						}
						case 10U:
							num = (((!ESP.\u200D\u200E\u202A\u200E\u206F\u202E\u206D\u200D\u200C\u206F\u200F\u206A\u206B\u202C\u200B\u202C\u206D\u200F\u200E\u206A\u202E\u206D\u206E\u206B\u206C\u200B\u206E\u206A\u200F\u206B\u200F\u202A\u206C\u202E\u200C\u202D\u200C\u202C\u206F\u202D\u202E(ESP.\u206D\u206C\u202B\u206D\u202B\u202E\u202B\u200B\u200D\u200B\u202D\u206A\u200D\u206A\u206A\u206F\u200B\u200B\u206A\u202E\u206B\u206D\u206A\u206C\u206F\u202B\u206A\u200D\u206D\u202D\u206F\u202E\u206E\u200B\u202E\u206F\u200B\u202E\u202E\u200C\u202E(target), null)) ? 1811060377U : 1474910999U) ^ num2 * 3476988773U);
							continue;
						case 11U:
						{
							Highlighter highlighter;
							ESP.\u206A\u200D\u206C\u206E\u202D\u206E\u206A\u202C\u206F\u200D\u206D\u202A\u200D\u202B\u202B\u206B\u200D\u206D\u202B\u200E\u206B\u206C\u206F\u200C\u202C\u202D\u206D\u200E\u206C\u206B\u200F\u206F\u202B\u202A\u202A\u200B\u202D\u206C\u200B\u202A\u202E(highlighter, 0.25f);
							num = (num2 * 2375694167U ^ 3478986339U);
							continue;
						}
						case 12U:
						{
							Highlighter highlighter;
							num = (this.highlighters.TryGetValue(target, out highlighter) ? 541733126U : 647383760U);
							continue;
						}
						}
						return;
					}
				}
				return;
			}
		}

		// Token: 0x0600008E RID: 142 RVA: 0x000083E8 File Offset: 0x000065E8
		private void Update()
		{
			if (this.espEnabled)
			{
				for (;;)
				{
					IL_08:
					uint num = 1048191431U;
					for (;;)
					{
						uint num2;
						switch ((num2 = (num ^ 946781718U)) % 5U)
						{
						case 0U:
							num = (((!ESP.\u200D\u200E\u202A\u200E\u206F\u202E\u206D\u200D\u200C\u206F\u200F\u206A\u206B\u202C\u200B\u202C\u206D\u200F\u200E\u206A\u202E\u206D\u206E\u206B\u206C\u200B\u206E\u206A\u200F\u206B\u200F\u202A\u206C\u202E\u200C\u202D\u200C\u202C\u206F\u202D\u202E(this.entities, null)) ? 193829439U : 700104141U) ^ num2 * 3742406349U);
							continue;
						case 1U:
							return;
						case 2U:
							goto IL_08;
						case 4U:
							num = ((ESP.\u200D\u200E\u202A\u200E\u206F\u202E\u206D\u200D\u200C\u206F\u200F\u206A\u206B\u202C\u200B\u202C\u206D\u200F\u200E\u206A\u202E\u206D\u206E\u206B\u206C\u200B\u206E\u206A\u200F\u206B\u200F\u202A\u206C\u202E\u200C\u202D\u200C\u202C\u206F\u202D\u202E(ESP.\u202E\u206A\u200D\u206A\u206F\u206B\u202A\u206A\u202C\u202A\u206D\u206B\u202A\u206C\u202B\u206E\u200D\u202C\u200F\u206B\u206B\u206A\u200B\u206D\u206A\u202E\u206E\u202A\u200F\u206A\u202E\u202E\u206E\u202E\u202C\u202B\u202A\u206E\u200E\u200E\u202E(), null) ? 3242869934U : 3782235377U) ^ num2 * 3238042978U);
							continue;
						}
						goto Block_1;
					}
				}
				Block_1:
				using (List<Player>.Enumerator enumerator = this.entities.Players.GetEnumerator())
				{
					for (;;)
					{
						IL_320:
						uint num3 = enumerator.MoveNext() ? 243889573U : 1920585091U;
						for (;;)
						{
							uint num2;
							bool flag;
							bool flag2;
							Player player;
							Highlighter highlighter;
							switch ((num2 = (num3 ^ 946781718U)) % 19U)
							{
							case 0U:
								num3 = (num2 * 712546028U ^ 528490274U);
								continue;
							case 1U:
							{
								float num4;
								flag = (num4 <= this.maxDistance);
								goto IL_1E3;
							}
							case 2U:
								if (this.showGlow)
								{
									num3 = (num2 * 1406620243U ^ 1419966067U);
									continue;
								}
								goto IL_1E2;
							case 3U:
								num3 = (flag2 ? 1416428906U : 639601561U);
								continue;
							case 4U:
							{
								float num4 = this.entities.DistanceToLocal(ESP.\u206B\u202A\u206E\u200C\u202B\u200D\u206D\u200C\u206A\u202B\u202B\u200C\u200D\u200D\u202E\u206B\u202C\u200D\u202E\u202B\u206B\u200D\u202B\u200D\u200C\u200C\u206D\u200D\u200B\u206C\u200C\u200E\u202C\u202C\u206C\u202B\u206E\u200D\u202E\u206B\u202E(ESP.\u200E\u202D\u200C\u206D\u202D\u200B\u202C\u202E\u206F\u202C\u200B\u206E\u206D\u200C\u200E\u200F\u200C\u200E\u200B\u200F\u200C\u202B\u200C\u202E\u200C\u202A\u202B\u200B\u206A\u206A\u206E\u206A\u202B\u202B\u202A\u202A\u206C\u202E\u200D\u206F\u202E(player)));
								num3 = (num2 * 3524769720U ^ 3916603351U);
								continue;
							}
							case 5U:
								player = enumerator.Current;
								num3 = ((!ESP.\u200D\u200E\u202A\u200E\u206F\u202E\u206D\u200D\u200C\u206F\u200F\u206A\u206B\u202C\u200B\u202C\u206D\u200F\u200E\u206A\u202E\u206D\u206E\u206B\u206C\u200B\u206E\u206A\u200F\u206B\u200F\u202A\u206C\u202E\u200C\u202D\u200C\u202C\u206F\u202D\u202E(player, null)) ? 320597224U : 1274886870U);
								continue;
							case 6U:
								ESP.\u206C\u200C\u200F\u202D\u206B\u206C\u206D\u202B\u206C\u200E\u202A\u202B\u206C\u206B\u202D\u200F\u206B\u200C\u206C\u202A\u200E\u200C\u200D\u200B\u202A\u206B\u206A\u206F\u206E\u200E\u200F\u200C\u200C\u202A\u200D\u206D\u200B\u200E\u200E\u202E\u202E(highlighter, false);
								num3 = (num2 * 940299050U ^ 51286636U);
								continue;
							case 7U:
								this.AddHighlighter(ESP.\u200E\u202D\u200C\u206D\u202D\u200B\u202C\u202E\u206F\u202C\u200B\u206E\u206D\u200C\u200E\u200F\u200C\u200E\u200B\u200F\u200C\u202B\u200C\u202E\u200C\u202A\u202B\u200B\u206A\u206A\u206E\u206A\u202B\u202B\u202A\u202A\u206C\u202E\u200D\u206F\u202E(player));
								num3 = 1274886870U;
								continue;
							case 8U:
								ESP.\u206A\u200D\u206C\u206E\u202D\u206E\u206A\u202C\u206F\u200D\u206D\u202A\u200D\u202B\u202B\u206B\u200D\u206D\u202B\u200E\u206B\u206C\u206F\u200C\u202C\u202D\u206D\u200E\u206C\u206B\u200F\u206F\u202B\u202A\u202A\u200B\u202D\u206C\u200B\u202A\u202E(highlighter, 0.25f);
								num3 = 1083663295U;
								continue;
							case 9U:
								num3 = (((!ESP.\u206E\u200B\u202A\u206C\u200B\u200B\u200C\u200E\u206A\u202B\u206E\u202B\u200F\u206C\u206A\u202D\u200B\u206F\u206F\u206F\u200F\u206B\u200E\u200B\u200F\u202D\u200F\u202E\u202D\u206A\u206C\u206B\u200B\u200E\u202C\u200E\u200B\u206C\u202D\u206B\u202E(ESP.\u202E\u206C\u206C\u206C\u206E\u206C\u206F\u206D\u202B\u200F\u200B\u202D\u202B\u200D\u200D\u202E\u206A\u202C\u200B\u206D\u200B\u200E\u206A\u202C\u206B\u202D\u202C\u206A\u206D\u202E\u200C\u206D\u206D\u202D\u206F\u200C\u206F\u206D\u200C\u200E\u202E(player))) ? 2245906191U : 2316780002U) ^ num2 * 2368732572U);
								continue;
							case 10U:
								num3 = 243889573U;
								continue;
							case 11U:
								ESP.\u206B\u200D\u200D\u202B\u200B\u200B\u200E\u200B\u200D\u202A\u202D\u202E\u200D\u206C\u200C\u200B\u200C\u200C\u202C\u206D\u206C\u202A\u206B\u206E\u206E\u200D\u202B\u202B\u206E\u200E\u200E\u206B\u206D\u206C\u206C\u206B\u202B\u202A\u206B\u202E\u202E(highlighter, Color.white, 0.25f);
								ESP.\u200C\u202B\u206A\u200F\u206C\u206F\u202A\u206F\u202D\u206A\u206F\u202D\u206E\u200C\u200C\u200D\u206A\u202C\u202A\u200D\u206E\u202A\u206E\u206E\u200B\u200F\u202E\u202E\u206D\u202B\u200C\u200F\u206C\u200B\u206F\u202D\u200B\u206F\u202D\u202E\u202E(highlighter, true);
								ESP.\u206C\u200C\u200F\u202D\u206B\u206C\u206D\u202B\u206C\u200E\u202A\u202B\u206C\u206B\u202D\u200F\u206B\u200C\u206C\u202A\u200E\u200C\u200D\u200B\u202A\u206B\u206A\u206F\u206E\u200E\u200F\u200C\u200C\u202A\u200D\u206D\u200B\u200E\u200E\u202E\u202E(highlighter, true);
								num3 = (num2 * 1289089724U ^ 277251873U);
								continue;
							case 13U:
								goto IL_320;
							case 14U:
								if (this.espEnabled)
								{
									num3 = (num2 * 3481448810U ^ 1744571022U);
									continue;
								}
								goto IL_1E2;
							case 15U:
								num3 = ((ESP.\u200D\u200E\u202A\u200E\u206F\u202E\u206D\u200D\u200C\u206F\u200F\u206A\u206B\u202C\u200B\u202C\u206D\u200F\u200E\u206A\u202E\u206D\u206E\u206B\u206C\u200B\u206E\u206A\u200F\u206B\u200F\u202A\u206C\u202E\u200C\u202D\u200C\u202C\u206F\u202D\u202E(ESP.\u202E\u206C\u206C\u206C\u206E\u206C\u206F\u206D\u202B\u200F\u200B\u202D\u202B\u200D\u200D\u202E\u206A\u202C\u200B\u206D\u200B\u200E\u206A\u202C\u206B\u202D\u202C\u206A\u206D\u202E\u200C\u206D\u206D\u202D\u206F\u200C\u206F\u206D\u200C\u200E\u202E(player), null) ? 2319228623U : 3139545508U) ^ num2 * 1696281471U);
								continue;
							case 16U:
								num3 = (((!ESP.\u200D\u200E\u202A\u200E\u206F\u202E\u206D\u200D\u200C\u206F\u200F\u206A\u206B\u202C\u200B\u202C\u206D\u200F\u200E\u206A\u202E\u206D\u206E\u206B\u206C\u200B\u206E\u206A\u200F\u206B\u200F\u202A\u206C\u202E\u200C\u202D\u200C\u202C\u206F\u202D\u202E(ESP.\u200E\u202D\u200C\u206D\u202D\u200B\u202C\u202E\u206F\u202C\u200B\u206E\u206D\u200C\u200E\u200F\u200C\u200E\u200B\u200F\u200C\u202B\u200C\u202E\u200C\u202A\u202B\u200B\u206A\u206A\u206E\u206A\u202B\u202B\u202A\u202A\u206C\u202E\u200D\u206F\u202E(player), null)) ? 29619281U : 523088564U) ^ num2 * 4132506191U);
								continue;
							case 17U:
								num3 = ((ESP.\u200D\u200E\u202A\u200E\u206F\u202E\u206D\u200D\u200C\u206F\u200F\u206A\u206B\u202C\u200B\u202C\u206D\u200F\u200E\u206A\u202E\u206D\u206E\u206B\u206C\u200B\u206E\u206A\u200F\u206B\u200F\u202A\u206C\u202E\u200C\u202D\u200C\u202C\u206F\u202D\u202E(player, ESP.\u202E\u206A\u200D\u206A\u206F\u206B\u202A\u206A\u202C\u202A\u206D\u206B\u202A\u206C\u202B\u206E\u200D\u202C\u200F\u206B\u206B\u206A\u200B\u206D\u206A\u202E\u206E\u202A\u200F\u206A\u202E\u202E\u206E\u202E\u202C\u202B\u202A\u206E\u200E\u200E\u202E()) ? 3288594652U : 3735447675U) ^ num2 * 834435778U);
								continue;
							case 18U:
								num3 = (((!ESP.\u200D\u200E\u202A\u200E\u206F\u202E\u206D\u200D\u200C\u206F\u200F\u206A\u206B\u202C\u200B\u202C\u206D\u200F\u200E\u206A\u202E\u206D\u206E\u206B\u206C\u200B\u206E\u206A\u200F\u206B\u200F\u202A\u206C\u202E\u200C\u202D\u200C\u202C\u206F\u202D\u202E(highlighter, null)) ? 58264322U : 2133209046U) ^ num2 * 1105711562U);
								continue;
							}
							goto Block_13;
							IL_1E3:
							flag2 = flag;
							num3 = ((!this.highlighters.TryGetValue(ESP.\u200E\u202D\u200C\u206D\u202D\u200B\u202C\u202E\u206F\u202C\u200B\u206E\u206D\u200C\u200E\u200F\u200C\u200E\u200B\u200F\u200C\u202B\u200C\u202E\u200C\u202A\u202B\u200B\u206A\u206A\u206E\u206A\u202B\u202B\u202A\u202A\u206C\u202E\u200D\u206F\u202E(player), out highlighter)) ? 2080043738U : 599356440U);
							continue;
							IL_1E2:
							flag = false;
							goto IL_1E3;
						}
					}
					Block_13:;
				}
				using (List<InteractableItem>.Enumerator enumerator2 = this.entities.Items.GetEnumerator())
				{
					for (;;)
					{
						IL_3FE:
						uint num5 = (!enumerator2.MoveNext()) ? 1485341747U : 1292259023U;
						for (;;)
						{
							uint num2;
							bool flag3;
							bool flag4;
							switch ((num2 = (num5 ^ 946781718U)) % 21U)
							{
							case 0U:
							{
								InteractableItem interactableItem;
								this.AddHighlighter(ESP.\u200E\u202D\u200C\u206D\u202D\u200B\u202C\u202E\u206F\u202C\u200B\u206E\u206D\u200C\u200E\u200F\u200C\u200E\u200B\u200F\u200C\u202B\u200C\u202E\u200C\u202A\u202B\u200B\u206A\u206A\u206E\u206A\u202B\u202B\u202A\u202A\u206C\u202E\u200D\u206F\u202E(interactableItem));
								num5 = 608418401U;
								continue;
							}
							case 1U:
								num5 = (num2 * 4117574462U ^ 4111247098U);
								continue;
							case 2U:
								if (this.espEnabled)
								{
									num5 = (num2 * 2805971271U ^ 28401953U);
									continue;
								}
								goto IL_63B;
							case 3U:
							{
								Highlighter highlighter2;
								num5 = ((ESP.\u200D\u200E\u202A\u200E\u206F\u202E\u206D\u200D\u200C\u206F\u200F\u206A\u206B\u202C\u200B\u202C\u206D\u200F\u200E\u206A\u202E\u206D\u206E\u206B\u206C\u200B\u206E\u206A\u200F\u206B\u200F\u202A\u206C\u202E\u200C\u202D\u200C\u202C\u206F\u202D\u202E(highlighter2, null) ? 1058876914U : 758438434U) ^ num2 * 3068148265U);
								continue;
							}
							case 4U:
							{
								Highlighter highlighter2;
								ESP.\u206C\u200C\u200F\u202D\u206B\u206C\u206D\u202B\u206C\u200E\u202A\u202B\u206C\u206B\u202D\u200F\u206B\u200C\u206C\u202A\u200E\u200C\u200D\u200B\u202A\u206B\u206A\u206F\u206E\u200E\u200F\u200C\u200C\u202A\u200D\u206D\u200B\u200E\u200E\u202E\u202E(highlighter2, false);
								num5 = (num2 * 1883289875U ^ 3955210320U);
								continue;
							}
							case 5U:
							{
								InteractableItem interactableItem;
								num5 = ((ESP.\u200D\u200E\u202A\u200E\u206F\u202E\u206D\u200D\u200C\u206F\u200F\u206A\u206B\u202C\u200B\u202C\u206D\u200F\u200E\u206A\u202E\u206D\u206E\u206B\u206C\u200B\u206E\u206A\u200F\u206B\u200F\u202A\u206C\u202E\u200C\u202D\u200C\u202C\u206F\u202D\u202E(interactableItem, null) ? 2200673752U : 2629321938U) ^ num2 * 1690290426U);
								continue;
							}
							case 6U:
								num5 = (num2 * 573742185U ^ 128647650U);
								continue;
							case 7U:
							{
								Highlighter highlighter2;
								ESP.\u206A\u200D\u206C\u206E\u202D\u206E\u206A\u202C\u206F\u200D\u206D\u202A\u200D\u202B\u202B\u206B\u200D\u206D\u202B\u200E\u206B\u206C\u206F\u200C\u202C\u202D\u206D\u200E\u206C\u206B\u200F\u206F\u202B\u202A\u202A\u200B\u202D\u206C\u200B\u202A\u202E(highlighter2, 0.25f);
								num5 = 1041944510U;
								continue;
							}
							case 8U:
								if (this.showItemGlow)
								{
									num5 = (num2 * 2097525515U ^ 1131877220U);
									continue;
								}
								goto IL_63B;
							case 9U:
							{
								InteractableItem interactableItem;
								float num6 = this.entities.DistanceToLocal(ESP.\u206B\u202A\u206E\u200C\u202B\u200D\u206D\u200C\u206A\u202B\u202B\u200C\u200D\u200D\u202E\u206B\u202C\u200D\u202E\u202B\u206B\u200D\u202B\u200D\u200C\u200C\u206D\u200D\u200B\u206C\u200C\u200E\u202C\u202C\u206C\u202B\u206E\u200D\u202E\u206B\u202E(ESP.\u200E\u202D\u200C\u206D\u202D\u200B\u202C\u202E\u206F\u202C\u200B\u206E\u206D\u200C\u200E\u200F\u200C\u200E\u200B\u200F\u200C\u202B\u200C\u202E\u200C\u202A\u202B\u200B\u206A\u206A\u206E\u206A\u202B\u202B\u202A\u202A\u206C\u202E\u200D\u206F\u202E(interactableItem)));
								num5 = (num2 * 176294567U ^ 730640473U);
								continue;
							}
							case 10U:
							{
								InteractableItem interactableItem;
								Highlighter highlighter2;
								ESP.\u206B\u200D\u200D\u202B\u200B\u200B\u200E\u200B\u200D\u202A\u202D\u202E\u200D\u206C\u200C\u200B\u200C\u200C\u202C\u206D\u206C\u202A\u206B\u206E\u206E\u200D\u202B\u202B\u206E\u200E\u200E\u206B\u206D\u206C\u206C\u206B\u202B\u202A\u206B\u202E\u202E(highlighter2, ESP.\u202E\u202B\u206E\u206A\u200E\u200C\u206B\u206B\u206A\u200C\u200D\u206B\u200D\u206E\u200C\u200F\u200F\u202E\u200D\u202E\u200C\u202C\u206B\u200B\u206D\u200B\u206F\u206F\u202C\u200F\u200B\u206A\u202C\u202B\u200F\u200B\u206E\u200F\u202B\u200D\u202E(interactableItem.asset.rarity), 0.25f);
								num5 = (num2 * 387920992U ^ 2401372473U);
								continue;
							}
							case 11U:
								goto IL_3FE;
							case 12U:
							{
								float num6;
								flag3 = (num6 <= this.maxDistance);
								goto IL_63C;
							}
							case 14U:
								num5 = 1292259023U;
								continue;
							case 15U:
							{
								InteractableItem interactableItem;
								Highlighter highlighter2;
								num5 = (((!this.highlighters.TryGetValue(ESP.\u200E\u202D\u200C\u206D\u202D\u200B\u202C\u202E\u206F\u202C\u200B\u206E\u206D\u200C\u200E\u200F\u200C\u200E\u200B\u200F\u200C\u202B\u200C\u202E\u200C\u202A\u202B\u200B\u206A\u206A\u206E\u206A\u202B\u202B\u202A\u202A\u206C\u202E\u200D\u206F\u202E(interactableItem), out highlighter2)) ? 3106268874U : 3369836422U) ^ num2 * 773675403U);
								continue;
							}
							case 16U:
								num5 = (flag4 ? 1450960263U : 2025656461U);
								continue;
							case 17U:
							{
								Highlighter highlighter2;
								ESP.\u200C\u202B\u206A\u200F\u206C\u206F\u202A\u206F\u202D\u206A\u206F\u202D\u206E\u200C\u200C\u200D\u206A\u202C\u202A\u200D\u206E\u202A\u206E\u206E\u200B\u200F\u202E\u202E\u206D\u202B\u200C\u200F\u206C\u200B\u206F\u202D\u200B\u206F\u202D\u202E\u202E(highlighter2, true);
								ESP.\u206C\u200C\u200F\u202D\u206B\u206C\u206D\u202B\u206C\u200E\u202A\u202B\u206C\u206B\u202D\u200F\u206B\u200C\u206C\u202A\u200E\u200C\u200D\u200B\u202A\u206B\u206A\u206F\u206E\u200E\u200F\u200C\u200C\u202A\u200D\u206D\u200B\u200E\u200E\u202E\u202E(highlighter2, true);
								num5 = (num2 * 2349161573U ^ 3808644359U);
								continue;
							}
							case 18U:
							{
								InteractableItem interactableItem = enumerator2.Current;
								num5 = 1241304782U;
								continue;
							}
							case 19U:
							{
								InteractableItem interactableItem;
								num5 = (((!ESP.\u200D\u200E\u202A\u200E\u206F\u202E\u206D\u200D\u200C\u206F\u200F\u206A\u206B\u202C\u200B\u202C\u206D\u200F\u200E\u206A\u202E\u206D\u206E\u206B\u206C\u200B\u206E\u206A\u200F\u206B\u200F\u202A\u206C\u202E\u200C\u202D\u200C\u202C\u206F\u202D\u202E(ESP.\u200E\u202D\u200C\u206D\u202D\u200B\u202C\u202E\u206F\u202C\u200B\u206E\u206D\u200C\u200E\u200F\u200C\u200E\u200B\u200F\u200C\u202B\u200C\u202E\u200C\u202A\u202B\u200B\u206A\u206A\u206E\u206A\u202B\u202B\u202A\u202A\u206C\u202E\u200D\u206F\u202E(interactableItem), null)) ? 3910262951U : 3789507500U) ^ num2 * 4250280549U);
								continue;
							}
							case 20U:
							{
								InteractableItem interactableItem;
								num5 = (((interactableItem.asset != null) ? 3993720427U : 3754809745U) ^ num2 * 1185938165U);
								continue;
							}
							}
							goto Block_27;
							IL_63C:
							flag4 = flag3;
							num5 = 1850698891U;
							continue;
							IL_63B:
							flag3 = false;
							goto IL_63C;
						}
					}
					Block_27:;
				}
				using (List<InteractableVehicle>.Enumerator enumerator3 = this.entities.Vehicles.GetEnumerator())
				{
					for (;;)
					{
						IL_856:
						uint num7 = (!enumerator3.MoveNext()) ? 1282827239U : 1448414589U;
						for (;;)
						{
							uint num2;
							bool flag5;
							bool flag6;
							switch ((num2 = (num7 ^ 946781718U)) % 17U)
							{
							case 0U:
							{
								Highlighter highlighter3;
								ESP.\u206A\u200D\u206C\u206E\u202D\u206E\u206A\u202C\u206F\u200D\u206D\u202A\u200D\u202B\u202B\u206B\u200D\u206D\u202B\u200E\u206B\u206C\u206F\u200C\u202C\u202D\u206D\u200E\u206C\u206B\u200F\u206F\u202B\u202A\u202A\u200B\u202D\u206C\u200B\u202A\u202E(highlighter3, 0.25f);
								ESP.\u206C\u200C\u200F\u202D\u206B\u206C\u206D\u202B\u206C\u200E\u202A\u202B\u206C\u206B\u202D\u200F\u206B\u200C\u206C\u202A\u200E\u200C\u200D\u200B\u202A\u206B\u206A\u206F\u206E\u200E\u200F\u200C\u200C\u202A\u200D\u206D\u200B\u200E\u200E\u202E\u202E(highlighter3, false);
								num7 = 520650258U;
								continue;
							}
							case 1U:
							{
								InteractableVehicle interactableVehicle;
								num7 = (((ESP.\u206A\u206A\u202D\u200B\u202E\u202A\u200B\u200D\u202E\u202E\u206E\u202B\u206F\u200C\u200F\u202B\u206F\u206A\u206A\u200C\u202B\u206B\u202B\u200D\u202C\u206B\u200B\u206E\u200B\u202A\u200D\u202D\u202D\u206C\u202A\u202D\u202A\u200F\u202A\u202E(interactableVehicle) == null) ? 1924660352U : 1307294085U) ^ num2 * 901561990U);
								continue;
							}
							case 2U:
								num7 = (num2 * 1912078891U ^ 2320400308U);
								continue;
							case 3U:
							{
								Highlighter highlighter3;
								num7 = ((ESP.\u200D\u200E\u202A\u200E\u206F\u202E\u206D\u200D\u200C\u206F\u200F\u206A\u206B\u202C\u200B\u202C\u206D\u200F\u200E\u206A\u202E\u206D\u206E\u206B\u206C\u200B\u206E\u206A\u200F\u206B\u200F\u202A\u206C\u202E\u200C\u202D\u200C\u202C\u206F\u202D\u202E(highlighter3, null) ? 2527506454U : 2589595253U) ^ num2 * 207127501U);
								continue;
							}
							case 4U:
							{
								float num8;
								flag5 = (num8 <= this.maxDistance);
								goto IL_883;
							}
							case 5U:
							{
								InteractableVehicle interactableVehicle;
								num7 = (((!ESP.\u200D\u200E\u202A\u200E\u206F\u202E\u206D\u200D\u200C\u206F\u200F\u206A\u206B\u202C\u200B\u202C\u206D\u200F\u200E\u206A\u202E\u206D\u206E\u206B\u206C\u200B\u206E\u206A\u200F\u206B\u200F\u202A\u206C\u202E\u200C\u202D\u200C\u202C\u206F\u202D\u202E(ESP.\u200E\u202D\u200C\u206D\u202D\u200B\u202C\u202E\u206F\u202C\u200B\u206E\u206D\u200C\u200E\u200F\u200C\u200E\u200B\u200F\u200C\u202B\u200C\u202E\u200C\u202A\u202B\u200B\u206A\u206A\u206E\u206A\u202B\u202B\u202A\u202A\u206C\u202E\u200D\u206F\u202E(interactableVehicle), null)) ? 3446752386U : 2852540933U) ^ num2 * 2827493263U);
								continue;
							}
							case 6U:
							{
								Highlighter highlighter3;
								InteractableVehicle interactableVehicle;
								num7 = (((!this.highlighters.TryGetValue(ESP.\u200E\u202D\u200C\u206D\u202D\u200B\u202C\u202E\u206F\u202C\u200B\u206E\u206D\u200C\u200E\u200F\u200C\u200E\u200B\u200F\u200C\u202B\u200C\u202E\u200C\u202A\u202B\u200B\u206A\u206A\u206E\u206A\u202B\u202B\u202A\u202A\u206C\u202E\u200D\u206F\u202E(interactableVehicle), out highlighter3)) ? 716304640U : 278140732U) ^ num2 * 716403985U);
								continue;
							}
							case 8U:
							{
								InteractableVehicle interactableVehicle;
								this.AddHighlighter(ESP.\u200E\u202D\u200C\u206D\u202D\u200B\u202C\u202E\u206F\u202C\u200B\u206E\u206D\u200C\u200E\u200F\u200C\u200E\u200B\u200F\u200C\u202B\u200C\u202E\u200C\u202A\u202B\u200B\u206A\u206A\u206E\u206A\u202B\u202B\u202A\u202A\u206C\u202E\u200D\u206F\u202E(interactableVehicle));
								num7 = 1132257764U;
								continue;
							}
							case 9U:
								num7 = (flag6 ? 961748175U : 1350879149U);
								continue;
							case 10U:
								if (this.showVehicleGlow)
								{
									num7 = (num2 * 1806126539U ^ 1648595252U);
									continue;
								}
								goto IL_882;
							case 11U:
							{
								InteractableVehicle interactableVehicle;
								num7 = ((ESP.\u200D\u200E\u202A\u200E\u206F\u202E\u206D\u200D\u200C\u206F\u200F\u206A\u206B\u202C\u200B\u202C\u206D\u200F\u200E\u206A\u202E\u206D\u206E\u206B\u206C\u200B\u206E\u206A\u200F\u206B\u200F\u202A\u206C\u202E\u200C\u202D\u200C\u202C\u206F\u202D\u202E(interactableVehicle, null) ? 1563622451U : 1110956750U) ^ num2 * 357386605U);
								continue;
							}
							case 12U:
							{
								InteractableVehicle interactableVehicle;
								float num8 = this.entities.DistanceToLocal(ESP.\u206B\u202A\u206E\u200C\u202B\u200D\u206D\u200C\u206A\u202B\u202B\u200C\u200D\u200D\u202E\u206B\u202C\u200D\u202E\u202B\u206B\u200D\u202B\u200D\u200C\u200C\u206D\u200D\u200B\u206C\u200C\u200E\u202C\u202C\u206C\u202B\u206E\u200D\u202E\u206B\u202E(ESP.\u200E\u202D\u200C\u206D\u202D\u200B\u202C\u202E\u206F\u202C\u200B\u206E\u206D\u200C\u200E\u200F\u200C\u200E\u200B\u200F\u200C\u202B\u200C\u202E\u200C\u202A\u202B\u200B\u206A\u206A\u206E\u206A\u202B\u202B\u202A\u202A\u206C\u202E\u200D\u206F\u202E(interactableVehicle)));
								if (this.espEnabled)
								{
									num7 = (num2 * 501411308U ^ 1152575417U);
									continue;
								}
								goto IL_882;
							}
							case 13U:
							{
								InteractableVehicle interactableVehicle = enumerator3.Current;
								num7 = 1845084435U;
								continue;
							}
							case 14U:
								goto IL_856;
							case 15U:
								num7 = 1448414589U;
								continue;
							case 16U:
							{
								Highlighter highlighter3;
								ESP.\u206B\u200D\u200D\u202B\u200B\u200B\u200E\u200B\u200D\u202A\u202D\u202E\u200D\u206C\u200C\u200B\u200C\u200C\u202C\u206D\u206C\u202A\u206B\u206E\u206E\u200D\u202B\u202B\u206E\u200E\u200E\u206B\u206D\u206C\u206C\u206B\u202B\u202A\u206B\u202E\u202E(highlighter3, new Color(1f, 0.65f, 0f, 1f), 0.25f);
								ESP.\u200C\u202B\u206A\u200F\u206C\u206F\u202A\u206F\u202D\u206A\u206F\u202D\u206E\u200C\u200C\u200D\u206A\u202C\u202A\u200D\u206E\u202A\u206E\u206E\u200B\u200F\u202E\u202E\u206D\u202B\u200C\u200F\u206C\u200B\u206F\u202D\u200B\u206F\u202D\u202E\u202E(highlighter3, true);
								ESP.\u206C\u200C\u200F\u202D\u206B\u206C\u206D\u202B\u206C\u200E\u202A\u202B\u206C\u206B\u202D\u200F\u206B\u200C\u206C\u202A\u200E\u200C\u200D\u200B\u202A\u206B\u206A\u206F\u206E\u200E\u200F\u200C\u200C\u202A\u200D\u206D\u200B\u200E\u200E\u202E\u202E(highlighter3, true);
								num7 = (num2 * 4198007339U ^ 344781409U);
								continue;
							}
							}
							goto Block_39;
							IL_883:
							flag6 = flag5;
							num7 = 1001460069U;
							continue;
							IL_882:
							flag5 = false;
							goto IL_883;
						}
					}
					Block_39:;
				}
				using (List<BarricadeDrop>.Enumerator enumerator4 = this.entities.Beds.GetEnumerator())
				{
					for (;;)
					{
						IL_B15:
						uint num9 = enumerator4.MoveNext() ? 876619576U : 1615735411U;
						for (;;)
						{
							uint num2;
							bool flag7;
							bool flag8;
							switch ((num2 = (num9 ^ 946781718U)) % 17U)
							{
							case 0U:
								num9 = ((!flag7) ? 1427406764U : 488711628U);
								continue;
							case 1U:
								if (this.espEnabled)
								{
									num9 = (num2 * 4043546328U ^ 114571311U);
									continue;
								}
								goto IL_AA6;
							case 2U:
							{
								BarricadeDrop barricadeDrop = enumerator4.Current;
								num9 = ((barricadeDrop != null) ? 1068842799U : 730337398U);
								continue;
							}
							case 3U:
							{
								BarricadeDrop barricadeDrop;
								Highlighter highlighter4;
								num9 = ((this.highlighters.TryGetValue(ESP.\u202D\u200B\u202B\u206E\u202C\u206F\u202E\u202E\u206E\u202C\u202A\u202E\u202C\u202E\u202A\u206F\u206F\u200D\u206B\u200B\u202A\u200E\u206C\u200B\u206A\u202C\u200E\u202C\u206E\u200F\u206E\u206B\u200B\u202B\u202E\u206F\u200E\u206A\u206E\u202E(barricadeDrop), out highlighter4) ? 224108649U : 503733950U) ^ num2 * 1375822437U);
								continue;
							}
							case 4U:
							{
								BarricadeDrop barricadeDrop;
								num9 = ((ESP.\u200D\u200E\u202A\u200E\u206F\u202E\u206D\u200D\u200C\u206F\u200F\u206A\u206B\u202C\u200B\u202C\u206D\u200F\u200E\u206A\u202E\u206D\u206E\u206B\u206C\u200B\u206E\u206A\u200F\u206B\u200F\u202A\u206C\u202E\u200C\u202D\u200C\u202C\u206F\u202D\u202E(ESP.\u202D\u200B\u202B\u206E\u202C\u206F\u202E\u202E\u206E\u202C\u202A\u202E\u202C\u202E\u202A\u206F\u206F\u200D\u206B\u200B\u202A\u200E\u206C\u200B\u206A\u202C\u200E\u202C\u206E\u200F\u206E\u206B\u200B\u202B\u202E\u206F\u200E\u206A\u206E\u202E(barricadeDrop), null) ? 3214980794U : 2835772801U) ^ num2 * 229570860U);
								continue;
							}
							case 5U:
							{
								Highlighter highlighter4;
								ESP.\u206C\u200C\u200F\u202D\u206B\u206C\u206D\u202B\u206C\u200E\u202A\u202B\u206C\u206B\u202D\u200F\u206B\u200C\u206C\u202A\u200E\u200C\u200D\u200B\u202A\u206B\u206A\u206F\u206E\u200E\u200F\u200C\u200C\u202A\u200D\u206D\u200B\u200E\u200E\u202E\u202E(highlighter4, true);
								num9 = (num2 * 3305516550U ^ 1322605202U);
								continue;
							}
							case 6U:
								num9 = (num2 * 3233477221U ^ 2583519911U);
								continue;
							case 7U:
							{
								BarricadeDrop barricadeDrop;
								this.AddHighlighter(ESP.\u202D\u200B\u202B\u206E\u202C\u206F\u202E\u202E\u206E\u202C\u202A\u202E\u202C\u202E\u202A\u206F\u206F\u200D\u206B\u200B\u202A\u200E\u206C\u200B\u206A\u202C\u200E\u202C\u206E\u200F\u206E\u206B\u200B\u202B\u202E\u206F\u200E\u206A\u206E\u202E(barricadeDrop));
								num9 = 1720532971U;
								continue;
							}
							case 8U:
							{
								float num10;
								flag8 = (num10 <= this.maxDistance);
								goto IL_AA7;
							}
							case 9U:
								goto IL_B15;
							case 10U:
							{
								Highlighter highlighter4;
								num9 = ((ESP.\u200D\u200E\u202A\u200E\u206F\u202E\u206D\u200D\u200C\u206F\u200F\u206A\u206B\u202C\u200B\u202C\u206D\u200F\u200E\u206A\u202E\u206D\u206E\u206B\u206C\u200B\u206E\u206A\u200F\u206B\u200F\u202A\u206C\u202E\u200C\u202D\u200C\u202C\u206F\u202D\u202E(highlighter4, null) ? 2246853845U : 4159182420U) ^ num2 * 3269002133U);
								continue;
							}
							case 11U:
								if (this.showBedGlow)
								{
									num9 = (num2 * 4175502786U ^ 2653795791U);
									continue;
								}
								goto IL_AA6;
							case 13U:
							{
								Highlighter highlighter4;
								ESP.\u206B\u200D\u200D\u202B\u200B\u200B\u200E\u200B\u200D\u202A\u202D\u202E\u200D\u206C\u200C\u200B\u200C\u200C\u202C\u206D\u206C\u202A\u206B\u206E\u206E\u200D\u202B\u202B\u206E\u200E\u200E\u206B\u206D\u206C\u206C\u206B\u202B\u202A\u206B\u202E\u202E(highlighter4, new Color(0f, 0.8f, 1f, 1f), 0.25f);
								ESP.\u200C\u202B\u206A\u200F\u206C\u206F\u202A\u206F\u202D\u206A\u206F\u202D\u206E\u200C\u200C\u200D\u206A\u202C\u202A\u200D\u206E\u202A\u206E\u206E\u200B\u200F\u202E\u202E\u206D\u202B\u200C\u200F\u206C\u200B\u206F\u202D\u200B\u206F\u202D\u202E\u202E(highlighter4, true);
								num9 = (num2 * 89983506U ^ 3771510372U);
								continue;
							}
							case 14U:
							{
								BarricadeDrop barricadeDrop;
								float num10 = this.entities.DistanceToLocal(ESP.\u206B\u202A\u206E\u200C\u202B\u200D\u206D\u200C\u206A\u202B\u202B\u200C\u200D\u200D\u202E\u206B\u202C\u200D\u202E\u202B\u206B\u200D\u202B\u200D\u200C\u200C\u206D\u200D\u200B\u206C\u200C\u200E\u202C\u202C\u206C\u202B\u206E\u200D\u202E\u206B\u202E(ESP.\u202D\u200B\u202B\u206E\u202C\u206F\u202E\u202E\u206E\u202C\u202A\u202E\u202C\u202E\u202A\u206F\u206F\u200D\u206B\u200B\u202A\u200E\u206C\u200B\u206A\u202C\u200E\u202C\u206E\u200F\u206E\u206B\u200B\u202B\u202E\u206F\u200E\u206A\u206E\u202E(barricadeDrop)));
								num9 = (num2 * 4117445070U ^ 643998225U);
								continue;
							}
							case 15U:
							{
								Highlighter highlighter4;
								ESP.\u206A\u200D\u206C\u206E\u202D\u206E\u206A\u202C\u206F\u200D\u206D\u202A\u200D\u202B\u202B\u206B\u200D\u206D\u202B\u200E\u206B\u206C\u206F\u200C\u202C\u202D\u206D\u200E\u206C\u206B\u200F\u206F\u202B\u202A\u202A\u200B\u202D\u206C\u200B\u202A\u202E(highlighter4, 0.25f);
								ESP.\u206C\u200C\u200F\u202D\u206B\u206C\u206D\u202B\u206C\u200E\u202A\u202B\u206C\u206B\u202D\u200F\u206B\u200C\u206C\u202A\u200E\u200C\u200D\u200B\u202A\u206B\u206A\u206F\u206E\u200E\u200F\u200C\u200C\u202A\u200D\u206D\u200B\u200E\u200E\u202E\u202E(highlighter4, false);
								num9 = 730337398U;
								continue;
							}
							case 16U:
								num9 = 876619576U;
								continue;
							}
							goto Block_51;
							IL_AA7:
							flag7 = flag8;
							num9 = 2568526U;
							continue;
							IL_AA6:
							flag8 = false;
							goto IL_AA7;
						}
					}
					Block_51:;
				}
				using (List<BarricadeDrop>.Enumerator enumerator4 = this.entities.Claims.GetEnumerator())
				{
					for (;;)
					{
						IL_CB8:
						uint num11 = enumerator4.MoveNext() ? 291562655U : 2022200277U;
						for (;;)
						{
							uint num2;
							bool flag9;
							bool flag10;
							switch ((num2 = (num11 ^ 946781718U)) % 20U)
							{
							case 0U:
							{
								float num12;
								flag9 = (num12 <= this.maxDistance);
								goto IL_C14;
							}
							case 1U:
							{
								BarricadeDrop barricadeDrop2;
								num11 = ((ESP.\u200D\u200E\u202A\u200E\u206F\u202E\u206D\u200D\u200C\u206F\u200F\u206A\u206B\u202C\u200B\u202C\u206D\u200F\u200E\u206A\u202E\u206D\u206E\u206B\u206C\u200B\u206E\u206A\u200F\u206B\u200F\u202A\u206C\u202E\u200C\u202D\u200C\u202C\u206F\u202D\u202E(ESP.\u202D\u200B\u202B\u206E\u202C\u206F\u202E\u202E\u206E\u202C\u202A\u202E\u202C\u202E\u202A\u206F\u206F\u200D\u206B\u200B\u202A\u200E\u206C\u200B\u206A\u202C\u200E\u202C\u206E\u200F\u206E\u206B\u200B\u202B\u202E\u206F\u200E\u206A\u206E\u202E(barricadeDrop2), null) ? 4196077634U : 3721058339U) ^ num2 * 2877642974U);
								continue;
							}
							case 2U:
							{
								Highlighter highlighter5;
								num11 = ((ESP.\u200D\u200E\u202A\u200E\u206F\u202E\u206D\u200D\u200C\u206F\u200F\u206A\u206B\u202C\u200B\u202C\u206D\u200F\u200E\u206A\u202E\u206D\u206E\u206B\u206C\u200B\u206E\u206A\u200F\u206B\u200F\u202A\u206C\u202E\u200C\u202D\u200C\u202C\u206F\u202D\u202E(highlighter5, null) ? 1261958974U : 1486093815U) ^ num2 * 177310390U);
								continue;
							}
							case 3U:
							{
								Highlighter highlighter5;
								ESP.\u206B\u200D\u200D\u202B\u200B\u200B\u200E\u200B\u200D\u202A\u202D\u202E\u200D\u206C\u200C\u200B\u200C\u200C\u202C\u206D\u206C\u202A\u206B\u206E\u206E\u200D\u202B\u202B\u206E\u200E\u200E\u206B\u206D\u206C\u206C\u206B\u202B\u202A\u206B\u202E\u202E(highlighter5, new Color(0f, 0.8f, 1f, 1f), 0.25f);
								ESP.\u200C\u202B\u206A\u200F\u206C\u206F\u202A\u206F\u202D\u206A\u206F\u202D\u206E\u200C\u200C\u200D\u206A\u202C\u202A\u200D\u206E\u202A\u206E\u206E\u200B\u200F\u202E\u202E\u206D\u202B\u200C\u200F\u206C\u200B\u206F\u202D\u200B\u206F\u202D\u202E\u202E(highlighter5, true);
								num11 = (num2 * 2978405526U ^ 3712770609U);
								continue;
							}
							case 4U:
								num11 = (num2 * 3997625199U ^ 2506143308U);
								continue;
							case 5U:
							{
								Highlighter highlighter5;
								ESP.\u206C\u200C\u200F\u202D\u206B\u206C\u206D\u202B\u206C\u200E\u202A\u202B\u206C\u206B\u202D\u200F\u206B\u200C\u206C\u202A\u200E\u200C\u200D\u200B\u202A\u206B\u206A\u206F\u206E\u200E\u200F\u200C\u200C\u202A\u200D\u206D\u200B\u200E\u200E\u202E\u202E(highlighter5, true);
								num11 = (num2 * 1453956542U ^ 1059288992U);
								continue;
							}
							case 6U:
								if (this.showClaimGlow)
								{
									num11 = (num2 * 2025823691U ^ 1076200204U);
									continue;
								}
								goto IL_C13;
							case 7U:
							{
								BarricadeDrop barricadeDrop2;
								num11 = (((barricadeDrop2 != null) ? 1729840987U : 2145715700U) ^ num2 * 3298631024U);
								continue;
							}
							case 8U:
								num11 = (num2 * 3358204765U ^ 534273428U);
								continue;
							case 9U:
								num11 = ((!flag10) ? 298715586U : 1372656865U);
								continue;
							case 10U:
								if (this.espEnabled)
								{
									num11 = (num2 * 3189729893U ^ 4195886478U);
									continue;
								}
								goto IL_C13;
							case 12U:
							{
								BarricadeDrop barricadeDrop2;
								this.AddHighlighter(ESP.\u202D\u200B\u202B\u206E\u202C\u206F\u202E\u202E\u206E\u202C\u202A\u202E\u202C\u202E\u202A\u206F\u206F\u200D\u206B\u200B\u202A\u200E\u206C\u200B\u206A\u202C\u200E\u202C\u206E\u200F\u206E\u206B\u200B\u202B\u202E\u206F\u200E\u206A\u206E\u202E(barricadeDrop2));
								num11 = 353599950U;
								continue;
							}
							case 13U:
							{
								Highlighter highlighter5;
								ESP.\u206C\u200C\u200F\u202D\u206B\u206C\u206D\u202B\u206C\u200E\u202A\u202B\u206C\u206B\u202D\u200F\u206B\u200C\u206C\u202A\u200E\u200C\u200D\u200B\u202A\u206B\u206A\u206F\u206E\u200E\u200F\u200C\u200C\u202A\u200D\u206D\u200B\u200E\u200E\u202E\u202E(highlighter5, false);
								num11 = (num2 * 915872751U ^ 1460665979U);
								continue;
							}
							case 14U:
								num11 = 291562655U;
								continue;
							case 15U:
							{
								BarricadeDrop barricadeDrop2;
								Highlighter highlighter5;
								num11 = ((this.highlighters.TryGetValue(ESP.\u202D\u200B\u202B\u206E\u202C\u206F\u202E\u202E\u206E\u202C\u202A\u202E\u202C\u202E\u202A\u206F\u206F\u200D\u206B\u200B\u202A\u200E\u206C\u200B\u206A\u202C\u200E\u202C\u206E\u200F\u206E\u206B\u200B\u202B\u202E\u206F\u200E\u206A\u206E\u202E(barricadeDrop2), out highlighter5) ? 2386817004U : 2692129514U) ^ num2 * 3448180360U);
								continue;
							}
							case 16U:
							{
								Highlighter highlighter5;
								ESP.\u206A\u200D\u206C\u206E\u202D\u206E\u206A\u202C\u206F\u200D\u206D\u202A\u200D\u202B\u202B\u206B\u200D\u206D\u202B\u200E\u206B\u206C\u206F\u200C\u202C\u202D\u206D\u200E\u206C\u206B\u200F\u206F\u202B\u202A\u202A\u200B\u202D\u206C\u200B\u202A\u202E(highlighter5, 0.25f);
								num11 = 112272967U;
								continue;
							}
							case 17U:
							{
								BarricadeDrop barricadeDrop2 = enumerator4.Current;
								num11 = 337549313U;
								continue;
							}
							case 18U:
								goto IL_CB8;
							case 19U:
							{
								BarricadeDrop barricadeDrop2;
								float num12 = this.entities.DistanceToLocal(ESP.\u206B\u202A\u206E\u200C\u202B\u200D\u206D\u200C\u206A\u202B\u202B\u200C\u200D\u200D\u202E\u206B\u202C\u200D\u202E\u202B\u206B\u200D\u202B\u200D\u200C\u200C\u206D\u200D\u200B\u206C\u200C\u200E\u202C\u202C\u206C\u202B\u206E\u200D\u202E\u206B\u202E(ESP.\u202D\u200B\u202B\u206E\u202C\u206F\u202E\u202E\u206E\u202C\u202A\u202E\u202C\u202E\u202A\u206F\u206F\u200D\u206B\u200B\u202A\u200E\u206C\u200B\u206A\u202C\u200E\u202C\u206E\u200F\u206E\u206B\u200B\u202B\u202E\u206F\u200E\u206A\u206E\u202E(barricadeDrop2)));
								num11 = (num2 * 4211728148U ^ 1507359896U);
								continue;
							}
							}
							goto Block_62;
							IL_C14:
							flag10 = flag9;
							num11 = 404915073U;
							continue;
							IL_C13:
							flag9 = false;
							goto IL_C14;
						}
					}
					Block_62:;
				}
				using (List<BarricadeDrop>.Enumerator enumerator4 = this.entities.Furniture.GetEnumerator())
				{
					for (;;)
					{
						IL_F33:
						uint num13 = enumerator4.MoveNext() ? 1705737227U : 499029856U;
						for (;;)
						{
							uint num2;
							Highlighter highlighter6;
							BarricadeDrop barricadeDrop3;
							bool flag11;
							bool flag12;
							switch ((num2 = (num13 ^ 946781718U)) % 16U)
							{
							case 0U:
								num13 = ((ESP.\u200D\u200E\u202A\u200E\u206F\u202E\u206D\u200D\u200C\u206F\u200F\u206A\u206B\u202C\u200B\u202C\u206D\u200F\u200E\u206A\u202E\u206D\u206E\u206B\u206C\u200B\u206E\u206A\u200F\u206B\u200F\u202A\u206C\u202E\u200C\u202D\u200C\u202C\u206F\u202D\u202E(highlighter6, null) ? 2826504461U : 3600161811U) ^ num2 * 963630801U);
								continue;
							case 1U:
								ESP.\u206C\u200C\u200F\u202D\u206B\u206C\u206D\u202B\u206C\u200E\u202A\u202B\u206C\u206B\u202D\u200F\u206B\u200C\u206C\u202A\u200E\u200C\u200D\u200B\u202A\u206B\u206A\u206F\u206E\u200E\u200F\u200C\u200C\u202A\u200D\u206D\u200B\u200E\u200E\u202E\u202E(highlighter6, true);
								num13 = (num2 * 831243182U ^ 3719772678U);
								continue;
							case 2U:
								ESP.\u206A\u200D\u206C\u206E\u202D\u206E\u206A\u202C\u206F\u200D\u206D\u202A\u200D\u202B\u202B\u206B\u200D\u206D\u202B\u200E\u206B\u206C\u206F\u200C\u202C\u202D\u206D\u200E\u206C\u206B\u200F\u206F\u202B\u202A\u202A\u200B\u202D\u206C\u200B\u202A\u202E(highlighter6, 0.25f);
								num13 = 15202129U;
								continue;
							case 3U:
							{
								float num14 = this.entities.DistanceToLocal(ESP.\u206B\u202A\u206E\u200C\u202B\u200D\u206D\u200C\u206A\u202B\u202B\u200C\u200D\u200D\u202E\u206B\u202C\u200D\u202E\u202B\u206B\u200D\u202B\u200D\u200C\u200C\u206D\u200D\u200B\u206C\u200C\u200E\u202C\u202C\u206C\u202B\u206E\u200D\u202E\u206B\u202E(ESP.\u202D\u200B\u202B\u206E\u202C\u206F\u202E\u202E\u206E\u202C\u202A\u202E\u202C\u202E\u202A\u206F\u206F\u200D\u206B\u200B\u202A\u200E\u206C\u200B\u206A\u202C\u200E\u202C\u206E\u200F\u206E\u206B\u200B\u202B\u202E\u206F\u200E\u206A\u206E\u202E(barricadeDrop3)));
								if (this.espEnabled)
								{
									num13 = (num2 * 588832411U ^ 3868640799U);
									continue;
								}
								goto IL_FF7;
							}
							case 4U:
								ESP.\u206B\u200D\u200D\u202B\u200B\u200B\u200E\u200B\u200D\u202A\u202D\u202E\u200D\u206C\u200C\u200B\u200C\u200C\u202C\u206D\u206C\u202A\u206B\u206E\u206E\u200D\u202B\u202B\u206E\u200E\u200E\u206B\u206D\u206C\u206C\u206B\u202B\u202A\u206B\u202E\u202E(highlighter6, new Color(1f, 0.55f, 0f, 1f), 0.25f);
								ESP.\u200C\u202B\u206A\u200F\u206C\u206F\u202A\u206F\u202D\u206A\u206F\u202D\u206E\u200C\u200C\u200D\u206A\u202C\u202A\u200D\u206E\u202A\u206E\u206E\u200B\u200F\u202E\u202E\u206D\u202B\u200C\u200F\u206C\u200B\u206F\u202D\u200B\u206F\u202D\u202E\u202E(highlighter6, true);
								num13 = (num2 * 3498227952U ^ 3712685095U);
								continue;
							case 5U:
								num13 = ((!flag11) ? 155909028U : 1188461634U);
								continue;
							case 7U:
								ESP.\u206C\u200C\u200F\u202D\u206B\u206C\u206D\u202B\u206C\u200E\u202A\u202B\u206C\u206B\u202D\u200F\u206B\u200C\u206C\u202A\u200E\u200C\u200D\u200B\u202A\u206B\u206A\u206F\u206E\u200E\u200F\u200C\u200C\u202A\u200D\u206D\u200B\u200E\u200E\u202E\u202E(highlighter6, false);
								num13 = (num2 * 745441184U ^ 1261649786U);
								continue;
							case 8U:
								if (this.showFurnitureGlow)
								{
									num13 = (num2 * 3378231676U ^ 1529579609U);
									continue;
								}
								goto IL_FF7;
							case 9U:
								num13 = 1705737227U;
								continue;
							case 10U:
								num13 = ((ESP.\u200D\u200E\u202A\u200E\u206F\u202E\u206D\u200D\u200C\u206F\u200F\u206A\u206B\u202C\u200B\u202C\u206D\u200F\u200E\u206A\u202E\u206D\u206E\u206B\u206C\u200B\u206E\u206A\u200F\u206B\u200F\u202A\u206C\u202E\u200C\u202D\u200C\u202C\u206F\u202D\u202E(ESP.\u202D\u200B\u202B\u206E\u202C\u206F\u202E\u202E\u206E\u202C\u202A\u202E\u202C\u202E\u202A\u206F\u206F\u200D\u206B\u200B\u202A\u200E\u206C\u200B\u206A\u202C\u200E\u202C\u206E\u200F\u206E\u206B\u200B\u202B\u202E\u206F\u200E\u206A\u206E\u202E(barricadeDrop3), null) ? 675816474U : 690472197U) ^ num2 * 709570304U);
								continue;
							case 11U:
								this.AddHighlighter(ESP.\u202D\u200B\u202B\u206E\u202C\u206F\u202E\u202E\u206E\u202C\u202A\u202E\u202C\u202E\u202A\u206F\u206F\u200D\u206B\u200B\u202A\u200E\u206C\u200B\u206A\u202C\u200E\u202C\u206E\u200F\u206E\u206B\u200B\u202B\u202E\u206F\u200E\u206A\u206E\u202E(barricadeDrop3));
								num13 = 549913114U;
								continue;
							case 12U:
								goto IL_F33;
							case 13U:
								barricadeDrop3 = enumerator4.Current;
								num13 = ((barricadeDrop3 == null) ? 549913114U : 991428524U);
								continue;
							case 14U:
								num13 = (num2 * 3022696657U ^ 2685443364U);
								continue;
							case 15U:
							{
								float num14;
								flag12 = (num14 <= this.maxDistance);
								goto IL_FF8;
							}
							}
							goto Block_73;
							IL_FF8:
							flag11 = flag12;
							num13 = ((!this.highlighters.TryGetValue(ESP.\u202D\u200B\u202B\u206E\u202C\u206F\u202E\u202E\u206E\u202C\u202A\u202E\u202C\u202E\u202A\u206F\u206F\u200D\u206B\u200B\u202A\u200E\u206C\u200B\u206A\u202C\u200E\u202C\u206E\u200F\u206E\u206B\u200B\u202B\u202E\u206F\u200E\u206A\u206E\u202E(barricadeDrop3), out highlighter6)) ? 956533261U : 1213705494U);
							continue;
							IL_FF7:
							flag12 = false;
							goto IL_FF8;
						}
					}
					Block_73:;
				}
				if (ESP.\u206D\u206D\u200B\u200E\u200B\u206F\u200E\u202D\u200C\u206E\u202D\u206C\u206D\u200E\u202D\u200B\u200B\u200D\u206F\u200D\u202E\u206D\u206C\u206E\u200F\u202D\u200D\u206E\u202C\u200D\u202A\u206D\u206F\u206C\u206A\u202E\u200B\u200C\u202B\u200E\u202E() - this.lastCleanupTime > 10f)
				{
					goto IL_10BB;
				}
				goto IL_10FC;
				uint num15;
				for (;;)
				{
					IL_10C0:
					uint num2;
					switch ((num2 = (num15 ^ 946781718U)) % 5U)
					{
					case 0U:
						goto IL_10BB;
					case 1U:
						goto IL_10FC;
					case 3U:
						this.InitializeHighlighters();
						num15 = (num2 * 2628318594U ^ 218767008U);
						continue;
					case 4U:
						this.CleanUpCaches();
						this.lastCleanupTime = ESP.\u206D\u206D\u200B\u200E\u200B\u206F\u200E\u202D\u200C\u206E\u202D\u206C\u206D\u200E\u202D\u200B\u200B\u200D\u206F\u200D\u202E\u206D\u206C\u206E\u200F\u202D\u200D\u206E\u202C\u200D\u202A\u206D\u206F\u206C\u206A\u202E\u200B\u200C\u202B\u200E\u202E();
						num15 = (num2 * 4179845077U ^ 3145523931U);
						continue;
					}
					break;
				}
				return;
				IL_10BB:
				num15 = 224211342U;
				goto IL_10C0;
				IL_10FC:
				num15 = ((ESP.\u200D\u202E\u206C\u202D\u206D\u200C\u200B\u206F\u200B\u200D\u206F\u202D\u202C\u200C\u206F\u202B\u206A\u202B\u202B\u200E\u202B\u202D\u200E\u206A\u202A\u200E\u200C\u202D\u200F\u202B\u200D\u206F\u206F\u200E\u202D\u200C\u206E\u206D\u200B\u200F\u202E() % 480 != 0) ? 23418338U : 213712119U);
				goto IL_10C0;
			}
		}

		// Token: 0x0600008F RID: 143 RVA: 0x000095C4 File Offset: 0x000077C4
		private void CleanUpCaches()
		{
			List<InteractableItem> list = new List<InteractableItem>();
			using (Dictionary<InteractableItem, ValueTuple<Vector3, float>>.KeyCollection.Enumerator enumerator = this.textPositionCache.Keys.GetEnumerator())
			{
				for (;;)
				{
					IL_82:
					uint num = enumerator.MoveNext() ? 2338520148U : 3080686948U;
					for (;;)
					{
						uint num2;
						switch ((num2 = (num ^ 3371874635U)) % 6U)
						{
						case 0U:
						{
							InteractableItem interactableItem;
							list.Add(interactableItem);
							num = (num2 * 1644624711U ^ 4244238126U);
							continue;
						}
						case 1U:
						{
							InteractableItem interactableItem = enumerator.Current;
							num = 3564700087U;
							continue;
						}
						case 2U:
							num = 2338520148U;
							continue;
						case 4U:
						{
							InteractableItem interactableItem;
							num = (((!ESP.\u200D\u200E\u202A\u200E\u206F\u202E\u206D\u200D\u200C\u206F\u200F\u206A\u206B\u202C\u200B\u202C\u206D\u200F\u200E\u206A\u202E\u206D\u206E\u206B\u206C\u200B\u206E\u206A\u200F\u206B\u200F\u202A\u206C\u202E\u200C\u202D\u200C\u202C\u206F\u202D\u202E(interactableItem, null)) ? 2389338484U : 2783387965U) ^ num2 * 1123936581U);
							continue;
						}
						case 5U:
							goto IL_82;
						}
						goto Block_7;
					}
				}
				Block_7:;
			}
			using (List<InteractableItem>.Enumerator enumerator2 = list.GetEnumerator())
			{
				for (;;)
				{
					IL_121:
					uint num3 = (!enumerator2.MoveNext()) ? 2193050350U : 4181456856U;
					for (;;)
					{
						uint num2;
						switch ((num2 = (num3 ^ 3371874635U)) % 5U)
						{
						case 0U:
							num3 = 4181456856U;
							continue;
						case 1U:
						{
							InteractableItem key;
							this.textPositionCache.Remove(key);
							num3 = (num2 * 3861175707U ^ 3195454509U);
							continue;
						}
						case 2U:
						{
							InteractableItem key = enumerator2.Current;
							num3 = 2743289614U;
							continue;
						}
						case 3U:
							goto IL_121;
						}
						goto Block_12;
					}
				}
				Block_12:;
			}
			List<Transform> list2 = new List<Transform>();
			using (Dictionary<Transform, Highlighter>.KeyCollection.Enumerator enumerator3 = this.highlighters.Keys.GetEnumerator())
			{
				for (;;)
				{
					IL_194:
					uint num4 = enumerator3.MoveNext() ? 2189390700U : 4188110653U;
					for (;;)
					{
						uint num2;
						switch ((num2 = (num4 ^ 3371874635U)) % 6U)
						{
						case 1U:
						{
							Transform transform = enumerator3.Current;
							num4 = 3291848005U;
							continue;
						}
						case 2U:
						{
							Transform transform;
							num4 = (((!ESP.\u200D\u200E\u202A\u200E\u206F\u202E\u206D\u200D\u200C\u206F\u200F\u206A\u206B\u202C\u200B\u202C\u206D\u200F\u200E\u206A\u202E\u206D\u206E\u206B\u206C\u200B\u206E\u206A\u200F\u206B\u200F\u202A\u206C\u202E\u200C\u202D\u200C\u202C\u206F\u202D\u202E(transform, null)) ? 3879794372U : 3602289216U) ^ num2 * 2933384752U);
							continue;
						}
						case 3U:
						{
							Transform transform;
							list2.Add(transform);
							num4 = (num2 * 1235571842U ^ 1445547186U);
							continue;
						}
						case 4U:
							num4 = 2189390700U;
							continue;
						case 5U:
							goto IL_194;
						}
						goto Block_16;
					}
				}
				Block_16:;
			}
			using (List<Transform>.Enumerator enumerator4 = list2.GetEnumerator())
			{
				for (;;)
				{
					IL_25C:
					int num5 = (!enumerator4.MoveNext()) ? -2022346989 : -1028878698;
					for (;;)
					{
						switch ((num5 ^ -923092661) % 4)
						{
						case 1:
						{
							Transform key2 = enumerator4.Current;
							this.highlighters.Remove(key2);
							num5 = -1406143847;
							continue;
						}
						case 2:
							goto IL_25C;
						case 3:
							num5 = -1028878698;
							continue;
						}
						goto Block_21;
					}
				}
				Block_21:;
			}
			if (ESP.itemIconCache.Count > 1000)
			{
				for (;;)
				{
					IL_297:
					uint num6 = 2429131617U;
					for (;;)
					{
						uint num2;
						switch ((num2 = (num6 ^ 3371874635U)) % 3U)
						{
						case 0U:
							goto IL_297;
						case 2U:
							ESP.itemIconCache.Clear();
							num6 = (num2 * 164956256U ^ 221021284U);
							continue;
						}
						goto Block_5;
					}
				}
				Block_5:;
			}
			Utils.CleanLimbCache();
		}

		// Token: 0x06000090 RID: 144 RVA: 0x000098E0 File Offset: 0x00007AE0
		private void CheckHighlightingRenderer()
		{
			if (this.cameraChecked)
			{
				goto IL_0B;
			}
			goto IL_A4;
			uint num2;
			Camera cachedCamera;
			for (;;)
			{
				IL_10:
				uint num;
				switch ((num = (num2 ^ 3326287599U)) % 8U)
				{
				case 0U:
					return;
				case 1U:
					num2 = (((!ESP.\u200D\u200E\u202A\u200E\u206F\u202E\u206D\u200D\u200C\u206F\u200F\u206A\u206B\u202C\u200B\u202C\u206D\u200F\u200E\u206A\u202E\u206D\u206E\u206B\u206C\u200B\u206E\u206A\u200F\u206B\u200F\u202A\u206C\u202E\u200C\u202D\u200C\u202C\u206F\u202D\u202E(cachedCamera, null)) ? 2118506609U : 625743846U) ^ num * 2932170457U);
					continue;
				case 2U:
					return;
				case 3U:
					goto IL_A4;
				case 4U:
					goto IL_0B;
				case 6U:
					ESP.\u206D\u206C\u202B\u206D\u202B\u202E\u202B\u200B\u200D\u200B\u202D\u206A\u200D\u206A\u206A\u206F\u200B\u200B\u206A\u202E\u206B\u206D\u206A\u206C\u206F\u202B\u206A\u200D\u206D\u202D\u206F\u202E\u206E\u200B\u202E\u206F\u200B\u202E\u202E\u200C\u202E(cachedCamera).AddComponent<HighlightingRenderer>();
					num2 = (num * 2793146701U ^ 846920932U);
					continue;
				case 7U:
					num2 = ((!ESP.\u200D\u200E\u202A\u200E\u206F\u202E\u206D\u200D\u200C\u206F\u200F\u206A\u206B\u202C\u200B\u202C\u206D\u200F\u200E\u206A\u202E\u206D\u206E\u206B\u206C\u200B\u206E\u206A\u200F\u206B\u200F\u202A\u206C\u202E\u200C\u202D\u200C\u202C\u206F\u202D\u202E(cachedCamera.GetComponent<HighlightingRenderer>(), null)) ? 2847202386U : 4119578209U);
					continue;
				}
				break;
			}
			return;
			IL_0B:
			num2 = 3633891165U;
			goto IL_10;
			IL_A4:
			this.cameraChecked = true;
			cachedCamera = Main.CachedCamera;
			num2 = 2981290062U;
			goto IL_10;
		}

		// Token: 0x06000091 RID: 145 RVA: 0x000099CC File Offset: 0x00007BCC
		public void ToggleESP()
		{
			this.espEnabled = !this.espEnabled;
		}

		// Token: 0x06000092 RID: 146 RVA: 0x000099E8 File Offset: 0x00007BE8
		public void ToggleBoxes()
		{
			this.showBoxes = !this.showBoxes;
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00009A04 File Offset: 0x00007C04
		public void ToggleSkeleton()
		{
			this.showSkeleton = !this.showSkeleton;
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00009A20 File Offset: 0x00007C20
		public void ToggleGlow()
		{
			this.showGlow = !this.showGlow;
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00009A3C File Offset: 0x00007C3C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Draw()
		{
			Camera cachedCamera = Main.CachedCamera;
			for (;;)
			{
				IL_06:
				uint num = 328495693U;
				for (;;)
				{
					uint num2;
					switch ((num2 = (num ^ 1035936800U)) % 11U)
					{
					case 0U:
						num = (((!Overrides.bHideOnSpy) ? 3744784057U : 3136952504U) ^ num2 * 3173406682U);
						continue;
					case 1U:
						num = ((ESP.\u200D\u200E\u202A\u200E\u206F\u202E\u206D\u200D\u200C\u206F\u200F\u206A\u206B\u202C\u200B\u202C\u206D\u200F\u200E\u206A\u202E\u206D\u206E\u206B\u206C\u200B\u206E\u206A\u200F\u206B\u200F\u202A\u206C\u202E\u200C\u202D\u200C\u202C\u206F\u202D\u202E(ESP.\u202E\u206A\u200D\u206A\u206F\u206B\u202A\u206A\u202C\u202A\u206D\u206B\u202A\u206C\u202B\u206E\u200D\u202C\u200F\u206B\u206B\u206A\u200B\u206D\u206A\u202E\u206E\u202A\u200F\u206A\u202E\u202E\u206E\u202E\u202C\u202B\u202A\u206E\u200E\u200E\u202E(), null) ? 805378638U : 1635849086U) ^ num2 * 1660160525U);
						continue;
					case 2U:
						num = ((Overrides.bBeingSpied ? 406372099U : 1939996597U) ^ num2 * 4271925782U);
						continue;
					case 3U:
						return;
					case 4U:
						num = (ESP.\u200D\u200E\u202A\u200E\u206F\u202E\u206D\u200D\u200C\u206F\u200F\u206A\u206B\u202C\u200B\u202C\u206D\u200F\u200E\u206A\u202E\u206D\u206E\u206B\u206C\u200B\u206E\u206A\u200F\u206B\u200F\u202A\u206C\u202E\u200C\u202D\u200C\u202C\u206F\u202D\u202E(cachedCamera, null) ? 20210698U : 34037364U);
						continue;
					case 5U:
						num = ((this.espEnabled ? 114411181U : 34942842U) ^ num2 * 2945651504U);
						continue;
					case 7U:
						if (this.showItemName)
						{
							num = (num2 * 3245143494U ^ 1238412535U);
							continue;
						}
						goto IL_7EA;
					case 8U:
						goto IL_06;
					case 9U:
						num = (((!ESP.\u200D\u200E\u202A\u200E\u206F\u202E\u206D\u200D\u200C\u206F\u200F\u206A\u206B\u202C\u200B\u202C\u206D\u200F\u200E\u206A\u202E\u206D\u206E\u206B\u206C\u200B\u206E\u206A\u200F\u206B\u200F\u202A\u206C\u202E\u200C\u202D\u200C\u202C\u206F\u202D\u202E(this.entities, null)) ? 52265156U : 2060430786U) ^ num2 * 370665844U);
						continue;
					case 10U:
						this.InitGUIStyles();
						num = (this.showItemIcons ? 144636427U : 1002859722U);
						continue;
					}
					goto Block_1;
				}
			}
			Block_1:
			using (List<InteractableItem>.Enumerator enumerator = this.entities.Items.GetEnumerator())
			{
				for (;;)
				{
					IL_50D:
					uint num3 = enumerator.MoveNext() ? 1394370417U : 1014775715U;
					for (;;)
					{
						uint num2;
						string text;
						string text2;
						switch ((num2 = (num3 ^ 1035936800U)) % 33U)
						{
						case 0U:
						{
							InteractableItem interactableItem;
							Texture2D itemIcon = this.GetItemIcon(interactableItem.asset.id, interactableItem.item.quality, interactableItem.item.state);
							num3 = (num2 * 275650370U ^ 4248201142U);
							continue;
						}
						case 1U:
						{
							float num4 = 1f;
							Vector3 vector2;
							Vector3 vector = vector2;
							num3 = (num2 * 1333287726U ^ 1497264107U);
							continue;
						}
						case 2U:
						{
							InteractableItem interactableItem;
							Vector3 vector3 = ESP.\u206B\u202A\u206E\u200C\u202B\u200D\u206D\u200C\u206A\u202B\u202B\u200C\u200D\u200D\u202E\u206B\u202C\u200D\u202E\u202B\u206B\u200D\u202B\u200D\u200C\u200C\u206D\u200D\u200B\u206C\u200C\u200E\u202C\u202C\u206C\u202B\u206E\u200D\u202E\u206B\u202E(ESP.\u200E\u202D\u200C\u206D\u202D\u200B\u202C\u202E\u206F\u202C\u200B\u206E\u206D\u200C\u200E\u200F\u200C\u200E\u200B\u200F\u200C\u202B\u200C\u202E\u200C\u202A\u202B\u200B\u206A\u206A\u206E\u206A\u202B\u202B\u202A\u202A\u206C\u202E\u200D\u206F\u202E(interactableItem)) + Vector3.up * 0.45f;
							num3 = (num2 * 2929590111U ^ 4038895040U);
							continue;
						}
						case 4U:
						{
							float num5 = 25f * this.itemIconScale;
							num3 = (num2 * 2277080394U ^ 2028083730U);
							continue;
						}
						case 5U:
						{
							float num6;
							num3 = (((num6 >= 8f) ? 974431970U : 236123387U) ^ num2 * 1700887683U);
							continue;
						}
						case 6U:
							num3 = 1394370417U;
							continue;
						case 7U:
						{
							float num7;
							ESP.\u206D\u202B\u206E\u200F\u202D\u200F\u202B\u200F\u202D\u206F\u200B\u200B\u202D\u206C\u200C\u200D\u206F\u206C\u202B\u202E\u200F\u200B\u202D\u200F\u206C\u200B\u206D\u206A\u200F\u206D\u202B\u202B\u206F\u200C\u206C\u206B\u202A\u202A\u202B\u202E(this.itemTextStyle, (num7 < 35f) ? 12 : ((num7 < 70f) ? 11 : 9));
							num3 = 2071540611U;
							continue;
						}
						case 8U:
						{
							Texture2D itemIcon;
							num3 = (((!ESP.\u200E\u202D\u202D\u200C\u206F\u206A\u202A\u200B\u202B\u202B\u200E\u206C\u202D\u200F\u202C\u206C\u200D\u206E\u200C\u202D\u206D\u206F\u200E\u200C\u202D\u200F\u202B\u202D\u202D\u200D\u200F\u206C\u206B\u200B\u202A\u206C\u200E\u200B\u200D\u206F\u202E(itemIcon, null)) ? 1773506195U : 1916065560U) ^ num2 * 1649070418U);
							continue;
						}
						case 9U:
							num3 = ((!this.showItemName) ? 105582701U : 116943741U);
							continue;
						case 10U:
						{
							float num4;
							ESP.\u200C\u202B\u202B\u202A\u206B\u202B\u200C\u202D\u206D\u206E\u202E\u206B\u202B\u200D\u206A\u200C\u206C\u200B\u200F\u202E\u206F\u200E\u200B\u206E\u200F\u206A\u200D\u206D\u206C\u200C\u200E\u200C\u206F\u202A\u200D\u200C\u206E\u202C\u202E\u206D\u202E(ESP.\u200C\u202D\u202B\u206E\u200F\u202E\u206C\u202E\u200B\u206C\u202D\u202D\u202B\u202A\u206F\u206B\u206E\u202C\u200D\u206D\u206E\u202B\u200C\u206E\u202C\u200B\u206E\u206A\u206A\u206B\u206F\u202A\u206B\u200C\u206D\u200D\u200D\u202B\u206C\u202E(this.itemTextStyle), new Color(1f, 1f, 1f, num4));
							num3 = (num2 * 2626410768U ^ 496298688U);
							continue;
						}
						case 11U:
						{
							InteractableItem interactableItem;
							num3 = (((interactableItem.asset != null) ? 1221133465U : 1622530767U) ^ num2 * 1714054955U);
							continue;
						}
						case 12U:
						{
							InteractableItem interactableItem;
							float num5;
							float num8 = (float)interactableItem.asset.size_y * num5;
							num3 = (num2 * 3246246239U ^ 2363182451U);
							continue;
						}
						case 13U:
						{
							Vector3 vector;
							Vector2 vector4;
							float num9;
							ESP.\u200D\u206C\u206F\u200C\u206F\u202D\u206C\u202B\u202B\u202C\u202B\u200D\u206E\u200D\u206B\u200C\u200B\u202E\u200F\u200C\u206F\u206B\u202C\u202A\u206D\u200D\u206A\u202B\u206E\u202A\u200C\u202E\u202B\u200F\u200D\u202E\u202B\u202B\u206B\u206E\u202E(new Rect(vector.x - vector4.x / 2f, num9, vector4.x, vector4.y), text, this.itemTextStyle);
							num3 = (num2 * 2069739646U ^ 475643891U);
							continue;
						}
						case 14U:
						{
							Vector3 vector;
							float num9 = (float)ESP.\u202C\u206B\u202C\u206A\u200D\u202E\u206F\u200F\u202B\u200B\u202D\u202E\u206E\u206D\u206E\u206D\u206D\u206B\u206B\u200E\u206C\u206F\u200F\u206D\u206B\u200C\u200D\u206F\u206E\u200C\u202B\u206C\u200B\u202E\u200E\u200F\u206F\u200D\u206B\u206B\u202E() - vector.y - 55f;
							num3 = (num2 * 3391717706U ^ 1909323459U);
							continue;
						}
						case 15U:
						{
							InteractableItem interactableItem;
							num3 = (((!ESP.\u200D\u200E\u202A\u200E\u206F\u202E\u206D\u200D\u200C\u206F\u200F\u206A\u206B\u202C\u200B\u202C\u206D\u200F\u200E\u206A\u202E\u206D\u206E\u206B\u206C\u200B\u206E\u206A\u200F\u206B\u200F\u202A\u206C\u202E\u200C\u202D\u200C\u202C\u206F\u202D\u202E(ESP.\u200E\u202D\u200C\u206D\u202D\u200B\u202C\u202E\u206F\u202C\u200B\u206E\u206D\u200C\u200E\u200F\u200C\u200E\u200B\u200F\u200C\u202B\u200C\u202E\u200C\u202A\u202B\u200B\u206A\u206A\u206E\u206A\u202B\u202B\u202A\u202A\u206C\u202E\u200D\u206F\u202E(interactableItem), null)) ? 1010301798U : 1059488205U) ^ num2 * 1237891408U);
							continue;
						}
						case 16U:
						{
							ESP.\u206A\u206B\u206E\u206D\u206D\u200B\u202D\u202B\u202B\u202D\u200B\u206F\u200C\u206E\u202E\u200B\u206A\u202D\u206F\u206C\u206E\u202B\u200D\u202B\u206E\u206D\u200E\u206A\u206E\u200E\u200D\u200E\u206A\u206B\u206B\u200D\u202D\u202E\u202E\u200D\u202E(new Color(0f, 0f, 0f, 0.95f));
							Vector3 vector;
							Vector2 vector4;
							float num9;
							ESP.\u200D\u206C\u206F\u200C\u206F\u202D\u206C\u202B\u202B\u202C\u202B\u200D\u206E\u200D\u206B\u200C\u200B\u202E\u200F\u200C\u206F\u206B\u202C\u202A\u206D\u200D\u206A\u202B\u206E\u202A\u200C\u202E\u202B\u200F\u200D\u202E\u202B\u202B\u206B\u206E\u202E(new Rect(vector.x - vector4.x / 2f - 1f, num9 - 1f, vector4.x, vector4.y), text, this.itemTextStyle);
							ESP.\u206A\u206B\u206E\u206D\u206D\u200B\u202D\u202B\u202B\u202D\u200B\u206F\u200C\u206E\u202E\u200B\u206A\u202D\u206F\u206C\u206E\u202B\u200D\u202B\u206E\u206D\u200E\u206A\u206E\u200E\u200D\u200E\u206A\u206B\u206B\u200D\u202D\u202E\u202E\u200D\u202E(ESP.\u200E\u206F\u202C\u202D\u200E\u200C\u200D\u200E\u202A\u206D\u202A\u202A\u206A\u202D\u202A\u206F\u202E\u202D\u206F\u206B\u200F\u202C\u202E\u200D\u200B\u206B\u206C\u202B\u202B\u200C\u206A\u200F\u206D\u200D\u206A\u202B\u200B\u202C\u202A\u200F\u202E(ESP.\u200C\u202D\u202B\u206E\u200F\u202E\u206C\u202E\u200B\u206C\u202D\u202D\u202B\u202A\u206F\u206B\u206E\u202C\u200D\u206D\u206E\u202B\u200C\u206E\u202C\u200B\u206E\u206A\u206A\u206B\u206F\u202A\u206B\u200C\u206D\u200D\u200D\u202B\u206C\u202E(this.itemTextStyle)));
							num3 = (num2 * 2259615462U ^ 2679081039U);
							continue;
						}
						case 17U:
						{
							InteractableItem interactableItem;
							Vector3 vector;
							this.textPositionCache[interactableItem] = new ValueTuple<Vector3, float>(vector, ESP.\u206D\u206D\u200B\u200E\u200B\u206F\u200E\u202D\u200C\u206E\u202D\u206C\u206D\u200E\u202D\u200B\u200B\u200D\u206F\u200D\u202E\u206D\u206C\u206E\u200F\u202D\u200D\u206E\u202C\u200D\u202A\u206D\u206F\u206C\u206A\u202E\u200B\u200C\u202B\u200E\u202E());
							num3 = 801900102U;
							continue;
						}
						case 18U:
							goto IL_50D;
						case 19U:
						{
							InteractableItem interactableItem;
							ValueTuple<Vector3, float> valueTuple;
							num3 = (((!this.textPositionCache.TryGetValue(interactableItem, out valueTuple)) ? 1487878050U : 693038170U) ^ num2 * 1984894782U);
							continue;
						}
						case 20U:
							num3 = ((this.showItemIcons ? 1072893260U : 400744859U) ^ num2 * 3292465222U);
							continue;
						case 21U:
						{
							ValueTuple<Vector3, float> valueTuple;
							Vector3 vector = valueTuple.Item1;
							num3 = (num2 * 1218280788U ^ 2137999688U);
							continue;
						}
						case 22U:
						{
							InteractableItem interactableItem = enumerator.Current;
							num3 = ((!ESP.\u200D\u200E\u202A\u200E\u206F\u202E\u206D\u200D\u200C\u206F\u200F\u206A\u206B\u202C\u200B\u202C\u206D\u200F\u200E\u206A\u202E\u206D\u206E\u206B\u206C\u200B\u206E\u206A\u200F\u206B\u200F\u202A\u206C\u202E\u200C\u202D\u200C\u202C\u206F\u202D\u202E(interactableItem, null)) ? 423664146U : 105582701U);
							continue;
						}
						case 23U:
						{
							InteractableItem interactableItem;
							Vector3 vector5 = ESP.\u206E\u200B\u206A\u206A\u200B\u206D\u206A\u200B\u202A\u202D\u202E\u206D\u206B\u202E\u202E\u206C\u200D\u200F\u202E\u202C\u202C\u202E\u200B\u200D\u200E\u200F\u202B\u200E\u202E\u200F\u202B\u202E\u200B\u202D\u200B\u200B\u202B\u206A\u200F\u206B\u202E(Main.CachedCamera, ESP.\u206B\u202A\u206E\u200C\u202B\u200D\u206D\u200C\u206A\u202B\u202B\u200C\u200D\u200D\u202E\u206B\u202C\u200D\u202E\u202B\u206B\u200D\u202B\u200D\u200C\u200C\u206D\u200D\u200B\u206C\u200C\u200E\u202C\u202C\u206C\u202B\u206E\u200D\u202E\u206B\u202E(ESP.\u200E\u202D\u200C\u206D\u202D\u200B\u202C\u202E\u206F\u202C\u200B\u206E\u206D\u200C\u200E\u200F\u200C\u200E\u200B\u200F\u200C\u202B\u200C\u202E\u200C\u202A\u202B\u200B\u206A\u206A\u206E\u206A\u202B\u202B\u202A\u202A\u206C\u202E\u200D\u206F\u202E(interactableItem)));
							num3 = (((vector5.z <= 0.05f) ? 800874897U : 1737417412U) ^ num2 * 1355120931U);
							continue;
						}
						case 24U:
						{
							Texture2D itemIcon;
							float num8;
							Vector3 vector5;
							float num10;
							ESP.\u202C\u206D\u202E\u200E\u206A\u202E\u202A\u206F\u206C\u206F\u206F\u200F\u202D\u206C\u202A\u206B\u200D\u206E\u206C\u202C\u202D\u202B\u206B\u206B\u200F\u206B\u200C\u206D\u206F\u206C\u202D\u200F\u206D\u206A\u202B\u202B\u206B\u202A\u200B\u206F\u202E(new Rect(vector5.x - num10 / 2f, (float)ESP.\u202C\u206B\u202C\u206A\u200D\u202E\u206F\u200F\u202B\u200B\u202D\u202E\u206E\u206D\u206E\u206D\u206D\u206B\u206B\u200E\u206C\u206F\u200F\u206D\u206B\u200C\u200D\u206F\u206E\u200C\u202B\u206C\u200B\u202E\u200E\u200F\u206F\u200D\u206B\u206B\u202E() - vector5.y - num8 / 2f, num10, num8), itemIcon, 2);
							num3 = (num2 * 495750549U ^ 3915277269U);
							continue;
						}
						case 25U:
						{
							ValueTuple<Vector3, float> valueTuple;
							float num11 = ESP.\u206D\u206D\u200B\u200E\u200B\u206F\u200E\u202D\u200C\u206E\u202D\u206C\u206D\u200E\u202D\u200B\u200B\u200D\u206F\u200D\u202E\u206D\u206C\u206E\u200F\u202D\u200D\u206E\u202C\u200D\u202A\u206D\u206F\u206C\u206A\u202E\u200B\u200C\u202B\u200E\u202E() - valueTuple.Item2;
							Vector3 vector2;
							float num6 = Vector3.Distance(valueTuple.Item1, vector2);
							num3 = (((num11 >= 0.4f) ? 2234497120U : 4246829046U) ^ num2 * 980925775U);
							continue;
						}
						case 26U:
						{
							Vector2 vector4 = ESP.\u206F\u202B\u202E\u202E\u202B\u202A\u202C\u200C\u200F\u206D\u206A\u200D\u206B\u202A\u202E\u206D\u206F\u202C\u206C\u202E\u206C\u206B\u200B\u202E\u206D\u202A\u206E\u202B\u200E\u206A\u200E\u200B\u202B\u206B\u206B\u206D\u206F\u206A\u206B\u200D\u202E(this.itemTextStyle, ESP.\u200F\u206B\u206D\u206F\u206F\u202A\u202C\u202B\u206A\u206B\u202A\u200F\u202D\u200E\u206E\u200F\u206F\u200D\u202C\u202E\u200E\u200C\u202C\u206B\u206F\u202A\u206E\u202B\u202B\u206C\u202A\u202B\u200D\u202C\u202A\u200D\u202D\u206B\u202E\u206D\u202E(text));
							num3 = (num2 * 3962753060U ^ 4130446863U);
							continue;
						}
						case 27U:
							text2 = "";
							goto IL_259;
						case 28U:
						{
							InteractableItem interactableItem;
							float num7 = this.entities.DistanceToLocal(ESP.\u206B\u202A\u206E\u200C\u202B\u200D\u206D\u200C\u206A\u202B\u202B\u200C\u200D\u200D\u202E\u206B\u202C\u200D\u202E\u202B\u206B\u200D\u202B\u200D\u200C\u200C\u206D\u200D\u200B\u206C\u200C\u200E\u202C\u202C\u206C\u202B\u206E\u200D\u202E\u206B\u202E(ESP.\u200E\u202D\u200C\u206D\u202D\u200B\u202C\u202E\u206F\u202C\u200B\u206E\u206D\u200C\u200E\u200F\u200C\u200E\u200B\u200F\u200C\u202B\u200C\u202E\u200C\u202A\u202B\u200B\u206A\u206A\u206E\u206A\u202B\u202B\u202A\u202A\u206C\u202E\u200D\u206F\u202E(interactableItem)));
							num3 = (((num7 <= this.maxDistance) ? 2167852704U : 4288633106U) ^ num2 * 3369132319U);
							continue;
						}
						case 29U:
						{
							InteractableItem interactableItem;
							float num5;
							float num10 = (float)interactableItem.asset.size_x * num5;
							num3 = (num2 * 506582171U ^ 2563442073U);
							continue;
						}
						case 30U:
							num3 = (((!ESP.\u206B\u202A\u206B\u206A\u206B\u202B\u206C\u200D\u200E\u206C\u200D\u206A\u206C\u206C\u206E\u200E\u206C\u202B\u206C\u206F\u206B\u202E\u200C\u200D\u206F\u200D\u202C\u202A\u200C\u202D\u202C\u202E\u206C\u200E\u200C\u200F\u200F\u206B\u206E\u206F\u202E(text)) ? 1125828835U : 173016037U) ^ num2 * 965674892U);
							continue;
						case 31U:
						{
							Vector3 vector3;
							Vector3 vector2 = ESP.\u206E\u200B\u206A\u206A\u200B\u206D\u206A\u200B\u202A\u202D\u202E\u206D\u206B\u202E\u202E\u206C\u200D\u200F\u202E\u202C\u202C\u202E\u200B\u200D\u200E\u200F\u202B\u200E\u202E\u200F\u202B\u202E\u200B\u202D\u200B\u200B\u202B\u206A\u200F\u206B\u202E(cachedCamera, vector3);
							num3 = (((vector2.z <= 0.1f) ? 242477261U : 932083489U) ^ num2 * 3645189152U);
							continue;
						}
						case 32U:
						{
							if (!this.showItemName)
							{
								num3 = (num2 * 2972907300U ^ 3810747042U);
								continue;
							}
							InteractableItem interactableItem;
							text2 = ESP.\u206B\u200C\u206F\u202D\u202E\u202B\u202E\u200C\u206B\u200C\u202C\u200E\u202B\u200B\u200D\u202D\u202B\u202B\u206E\u206F\u200E\u206C\u202A\u202A\u206A\u206D\u200D\u200C\u200C\u202D\u202D\u206E\u202A\u200C\u202C\u200B\u202C\u206C\u206B\u202A\u202E(interactableItem.asset);
							goto IL_259;
						}
						}
						goto Block_17;
						IL_259:
						text = text2;
						num3 = 980545814U;
					}
				}
				Block_17:;
			}
			IL_7EA:
			ESP.\u206A\u206B\u206E\u206D\u206D\u200B\u202D\u202B\u202B\u202D\u200B\u206F\u200C\u206E\u202E\u200B\u206A\u202D\u206F\u206C\u206E\u202B\u200D\u202B\u206E\u206D\u200E\u206A\u206E\u200E\u200D\u200E\u206A\u206B\u206B\u200D\u202D\u202E\u202E\u200D\u202E(Color.white);
			using (List<InteractableVehicle>.Enumerator enumerator2 = this.entities.Vehicles.GetEnumerator())
			{
				for (;;)
				{
					IL_A4C:
					uint num12 = (!enumerator2.MoveNext()) ? 1168865861U : 361569380U;
					for (;;)
					{
						uint num2;
						Color color;
						string text3;
						string text4;
						Color color3;
						switch ((num2 = (num12 ^ 1035936800U)) % 23U)
						{
						case 0U:
						{
							Highlighter highlighter;
							num12 = ((ESP.\u200D\u200E\u202A\u200E\u206F\u202E\u206D\u200D\u200C\u206F\u200F\u206A\u206B\u202C\u200B\u202C\u206D\u200F\u200E\u206A\u202E\u206D\u206E\u206B\u206C\u200B\u206E\u206A\u200F\u206B\u200F\u202A\u206C\u202E\u200C\u202D\u200C\u202C\u206F\u202D\u202E(highlighter, null) ? 27971447U : 1794162138U) ^ num2 * 4053617703U);
							continue;
						}
						case 1U:
						{
							Highlighter highlighter;
							ESP.\u200C\u202B\u206A\u200F\u206C\u206F\u202A\u206F\u202D\u206A\u206F\u202D\u206E\u200C\u200C\u200D\u206A\u202C\u202A\u200D\u206E\u202A\u206E\u206E\u200B\u200F\u202E\u202E\u206D\u202B\u200C\u200F\u206C\u200B\u206F\u202D\u200B\u206F\u202D\u202E\u202E(highlighter, true);
							ESP.\u206C\u200C\u200F\u202D\u206B\u206C\u206D\u202B\u206C\u200E\u202A\u202B\u206C\u206B\u202D\u200F\u206B\u200C\u206C\u202A\u200E\u200C\u200D\u200B\u202A\u206B\u206A\u206F\u206E\u200E\u200F\u200C\u200C\u202A\u200D\u206D\u200B\u200E\u200E\u202E\u202E(highlighter, true);
							num12 = (num2 * 2297078902U ^ 2086613766U);
							continue;
						}
						case 2U:
							num12 = ((this.showVehicleGlow ? 2812143953U : 2222276596U) ^ num2 * 3369862182U);
							continue;
						case 3U:
						{
							InteractableVehicle interactableVehicle;
							num12 = (((ESP.\u206A\u206A\u202D\u200B\u202E\u202A\u200B\u200D\u202E\u202E\u206E\u202B\u206F\u200C\u200F\u202B\u206F\u206A\u206A\u200C\u202B\u206B\u202B\u200D\u202C\u206B\u200B\u206E\u200B\u202A\u200D\u202D\u202D\u206C\u202A\u202D\u202A\u200F\u202A\u202E(interactableVehicle) != null) ? 549365669U : 918499422U) ^ num2 * 3623277761U);
							continue;
						}
						case 4U:
							goto IL_A4C;
						case 5U:
						{
							InteractableVehicle interactableVehicle;
							if (!ESP.\u202E\u202A\u206F\u202E\u206E\u200B\u206E\u202D\u202B\u200C\u206D\u206F\u200F\u200D\u202D\u202E\u202C\u206A\u206F\u202A\u206F\u200F\u206B\u200B\u202E\u206B\u206E\u202A\u206F\u200B\u206D\u200C\u200E\u200C\u202B\u206A\u206F\u206D\u200E\u200E\u202E(interactableVehicle))
							{
								num12 = 621675470U;
								continue;
							}
							color = new Color(1f, 0.2f, 0.2f, 1f);
							goto IL_8B6;
						}
						case 6U:
							text3 = <Module>.\u202B\u200B\u202C\u206C\u206D\u202C\u206B\u200F\u206D\u206D\u200E\u206A\u202E\u206D\u200D\u206A\u202D\u202B\u200B\u200F\u202C\u206D\u200E\u202D\u200D\u206A\u200F\u206E\u206F\u206F\u200D\u202D\u202C\u200B\u206F\u202C\u202A\u200D\u206E\u202E\u202E<string>(2117140825);
							goto IL_9A8;
						case 7U:
						{
							InteractableVehicle interactableVehicle;
							num12 = ((ESP.\u200D\u200E\u202A\u200E\u206F\u202E\u206D\u200D\u200C\u206F\u200F\u206A\u206B\u202C\u200B\u202C\u206D\u200F\u200E\u206A\u202E\u206D\u206E\u206B\u206C\u200B\u206E\u206A\u200F\u206B\u200F\u202A\u206C\u202E\u200C\u202D\u200C\u202C\u206F\u202D\u202E(ESP.\u200E\u202D\u200C\u206D\u202D\u200B\u202C\u202E\u206F\u202C\u200B\u206E\u206D\u200C\u200E\u200F\u200C\u200E\u200B\u200F\u200C\u202B\u200C\u202E\u200C\u202A\u202B\u200B\u206A\u206A\u206E\u206A\u202B\u202B\u202A\u202A\u206C\u202E\u200D\u206F\u202E(interactableVehicle), null) ? 2288989396U : 2507671530U) ^ num2 * 541620109U);
							continue;
						}
						case 9U:
						{
							Vector3 vector6;
							Color color2;
							this.DrawObjectText(vector6 + new Vector3(0f, -14f, 0f), text4, color2);
							num12 = (num2 * 2857436505U ^ 2077092447U);
							continue;
						}
						case 10U:
						{
							Vector3 vector7;
							Vector3 vector6 = vector7;
							InteractableVehicle interactableVehicle;
							float num13;
							string text5 = ESP.\u206D\u202C\u202B\u202C\u206D\u206B\u206C\u200C\u206B\u206D\u206E\u200D\u200D\u206F\u206C\u202B\u206D\u200C\u200F\u200C\u200E\u202E\u202C\u206F\u206F\u206A\u200F\u200D\u202E\u200D\u200D\u206F\u200B\u202C\u206D\u202B\u206F\u206D\u200B\u206E\u202E(<Module>.\u200B\u206C\u200C\u200C\u206A\u200B\u200D\u206C\u206B\u206D\u202B\u200F\u200E\u206E\u206A\u200D\u206B\u202E\u206A\u200E\u200B\u202E\u200F\u206C\u200F\u202A\u202B\u200F\u200D\u200C\u202D\u200E\u206B\u200D\u202A\u200E\u202E\u206A\u202B\u200C\u202E<string>(1960563893), ESP.\u202E\u200B\u202E\u206C\u206E\u202E\u200D\u206D\u206A\u200F\u202B\u202B\u202B\u202C\u206D\u206A\u200D\u206B\u206E\u202E\u202A\u206E\u200E\u206A\u202A\u202E\u200E\u206C\u202B\u202E\u200D\u206F\u202D\u206D\u200E\u206B\u202C\u206A\u206A\u206E\u202E(ESP.\u206A\u206A\u202D\u200B\u202E\u202A\u200B\u200D\u202E\u202E\u206E\u202B\u206F\u200C\u200F\u202B\u206F\u206A\u206A\u200C\u202B\u206B\u202B\u200D\u202C\u206B\u200B\u206E\u200B\u202A\u200D\u202D\u202D\u206C\u202A\u202D\u202A\u200F\u202A\u202E(interactableVehicle)), Mathf.RoundToInt(num13));
							if (!ESP.\u202E\u202A\u206F\u202E\u206E\u200B\u206E\u202D\u202B\u200C\u206D\u206F\u200F\u200D\u202D\u202E\u202C\u206A\u206F\u202A\u206F\u200F\u206B\u200B\u202E\u206B\u206E\u202A\u206F\u200B\u206D\u200C\u200E\u200C\u202B\u206A\u206F\u206D\u200E\u200E\u202E(interactableVehicle))
							{
								num12 = 57090343U;
								continue;
							}
							text3 = <Module>.\u200F\u206F\u200E\u202A\u200D\u200C\u206A\u200E\u202E\u202C\u200D\u202D\u200D\u202B\u200F\u200C\u200F\u200D\u206B\u206D\u206E\u202A\u206C\u206B\u200B\u200F\u206D\u206A\u202E\u206C\u206F\u206A\u200C\u200C\u206C\u202A\u206F\u206A\u202D\u206E\u202E<string>(-1915309470);
							goto IL_9A8;
						}
						case 11U:
						{
							Highlighter highlighter;
							ESP.\u206B\u200D\u200D\u202B\u200B\u200B\u200E\u200B\u200D\u202A\u202D\u202E\u200D\u206C\u200C\u200B\u200C\u200C\u202C\u206D\u206C\u202A\u206B\u206E\u206E\u200D\u202B\u202B\u206E\u200E\u200E\u206B\u206D\u206C\u206C\u206B\u202B\u202A\u206B\u202E\u202E(highlighter, color3, 0.25f);
							num12 = (num2 * 551056918U ^ 1403254250U);
							continue;
						}
						case 12U:
							num12 = (this.showVehicleName ? 457110938U : 292401673U);
							continue;
						case 13U:
						{
							InteractableVehicle interactableVehicle;
							Vector3 vector7 = ESP.\u206E\u200B\u206A\u206A\u200B\u206D\u206A\u200B\u202A\u202D\u202E\u206D\u206B\u202E\u202E\u206C\u200D\u200F\u202E\u202C\u202C\u202E\u200B\u200D\u200E\u200F\u202B\u200E\u202E\u200F\u202B\u202E\u200B\u202D\u200B\u200B\u202B\u206A\u200F\u206B\u202E(cachedCamera, ESP.\u206B\u202A\u206E\u200C\u202B\u200D\u206D\u200C\u206A\u202B\u202B\u200C\u200D\u200D\u202E\u206B\u202C\u200D\u202E\u202B\u206B\u200D\u202B\u200D\u200C\u200C\u206D\u200D\u200B\u206C\u200C\u200E\u202C\u202C\u206C\u202B\u206E\u200D\u202E\u206B\u202E(ESP.\u200E\u202D\u200C\u206D\u202D\u200B\u202C\u202E\u206F\u202C\u200B\u206E\u206D\u200C\u200E\u200F\u200C\u200E\u200B\u200F\u200C\u202B\u200C\u202E\u200C\u202A\u202B\u200B\u206A\u206A\u206E\u206A\u202B\u202B\u202A\u202A\u206C\u202E\u200D\u206F\u202E(interactableVehicle)) + Vector3.up * 2.5f);
							num12 = (num2 * 4068617172U ^ 851382405U);
							continue;
						}
						case 14U:
							num12 = 361569380U;
							continue;
						case 15U:
						{
							Color color2;
							color2..ctor(1f, 0.8f, 0f, 1f);
							Vector3 vector6;
							string text5;
							this.DrawObjectText(vector6, text5, color2);
							num12 = (num2 * 4149712589U ^ 2511068093U);
							continue;
						}
						case 16U:
						{
							Vector3 vector7;
							num12 = (((vector7.z <= 0.05f) ? 2603583225U : 3696875077U) ^ num2 * 248474864U);
							continue;
						}
						case 17U:
						{
							InteractableVehicle interactableVehicle;
							this.AddHighlighter(ESP.\u200E\u202D\u200C\u206D\u202D\u200B\u202C\u202E\u206F\u202C\u200B\u206E\u206D\u200C\u200E\u200F\u200C\u200E\u200B\u200F\u200C\u202B\u200C\u202E\u200C\u202A\u202B\u200B\u206A\u206A\u206E\u206A\u202B\u202B\u202A\u202A\u206C\u202E\u200D\u206F\u202E(interactableVehicle));
							num12 = 435089898U;
							continue;
						}
						case 18U:
						{
							InteractableVehicle interactableVehicle = enumerator2.Current;
							num12 = 559103763U;
							continue;
						}
						case 19U:
						{
							Highlighter highlighter;
							InteractableVehicle interactableVehicle;
							num12 = (((!this.highlighters.TryGetValue(ESP.\u200E\u202D\u200C\u206D\u202D\u200B\u202C\u202E\u206F\u202C\u200B\u206E\u206D\u200C\u200E\u200F\u200C\u200E\u200B\u200F\u200C\u202B\u200C\u202E\u200C\u202A\u202B\u200B\u206A\u206A\u206E\u206A\u202B\u202B\u202A\u202A\u206C\u202E\u200D\u206F\u202E(interactableVehicle), out highlighter)) ? 1467650655U : 400607204U) ^ num2 * 2113786462U);
							continue;
						}
						case 20U:
							color = new Color(0.2f, 1f, 0.2f, 1f);
							goto IL_8B6;
						case 21U:
						{
							InteractableVehicle interactableVehicle;
							float num13 = this.entities.DistanceToLocal(ESP.\u206B\u202A\u206E\u200C\u202B\u200D\u206D\u200C\u206A\u202B\u202B\u200C\u200D\u200D\u202E\u206B\u202C\u200D\u202E\u202B\u206B\u200D\u202B\u200D\u200C\u200C\u206D\u200D\u200B\u206C\u200C\u200E\u202C\u202C\u206C\u202B\u206E\u200D\u202E\u206B\u202E(ESP.\u200E\u202D\u200C\u206D\u202D\u200B\u202C\u202E\u206F\u202C\u200B\u206E\u206D\u200C\u200E\u200F\u200C\u200E\u200B\u200F\u200C\u202B\u200C\u202E\u200C\u202A\u202B\u200B\u206A\u206A\u206E\u206A\u202B\u202B\u202A\u202A\u206C\u202E\u200D\u206F\u202E(interactableVehicle)));
							num12 = (((num13 <= this.maxDistance) ? 4149495429U : 3737025961U) ^ num2 * 201934672U);
							continue;
						}
						case 22U:
						{
							InteractableVehicle interactableVehicle;
							num12 = (((!ESP.\u200D\u200E\u202A\u200E\u206F\u202E\u206D\u200D\u200C\u206F\u200F\u206A\u206B\u202C\u200B\u202C\u206D\u200F\u200E\u206A\u202E\u206D\u206E\u206B\u206C\u200B\u206E\u206A\u200F\u206B\u200F\u202A\u206C\u202E\u200C\u202D\u200C\u202C\u206F\u202D\u202E(interactableVehicle, null)) ? 1781415411U : 84589387U) ^ num2 * 835551670U);
							continue;
						}
						}
						goto Block_37;
						IL_8B6:
						color3 = color;
						num12 = 1252390028U;
						continue;
						IL_9A8:
						text4 = text3;
						num12 = 107037543U;
					}
				}
				Block_37:;
			}
			using (List<BarricadeDrop>.Enumerator enumerator3 = this.entities.Beds.GetEnumerator())
			{
				for (;;)
				{
					IL_DE1:
					uint num14 = (!enumerator3.MoveNext()) ? 1757727477U : 1049064910U;
					for (;;)
					{
						uint num2;
						switch ((num2 = (num14 ^ 1035936800U)) % 17U)
						{
						case 0U:
							goto IL_DE1;
						case 1U:
						{
							Vector3 vector8;
							BarricadeDrop barricadeDrop;
							float num15;
							this.DrawObjectText(vector8, ESP.\u200F\u206A\u202E\u206E\u200E\u206C\u200D\u200D\u202C\u200E\u206F\u200D\u200D\u202D\u202B\u202B\u202B\u200C\u202A\u206E\u206E\u200D\u200E\u202C\u202D\u200F\u206D\u206A\u206E\u200E\u200B\u202B\u206D\u202A\u206B\u202A\u200C\u202C\u200D\u202A\u202E(ESP.\u206B\u200C\u206F\u202D\u202E\u202B\u202E\u200C\u206B\u200C\u202C\u200E\u202B\u200B\u200D\u202D\u202B\u202B\u206E\u206F\u200E\u206C\u202A\u202A\u206A\u206D\u200D\u200C\u200C\u202D\u202D\u206E\u202A\u200C\u202C\u200B\u202C\u206C\u206B\u202A\u202E(ESP.\u202B\u202D\u200C\u206A\u202D\u200C\u202A\u200D\u200B\u206B\u200B\u202A\u206A\u200D\u206C\u200C\u200D\u206B\u200B\u202C\u206A\u206B\u202E\u202E\u200C\u200E\u206C\u206D\u206A\u206A\u200B\u200C\u200C\u202C\u202D\u206A\u200B\u202E\u206E\u202B\u202E(barricadeDrop)), <Module>.\u200B\u206C\u200C\u200C\u206A\u200B\u200D\u206C\u206B\u206D\u202B\u200F\u200E\u206E\u206A\u200D\u206B\u202E\u206A\u200E\u200B\u202E\u200F\u206C\u200F\u202A\u202B\u200F\u200D\u200C\u202D\u200E\u206B\u200D\u202A\u200E\u202E\u206A\u202B\u200C\u202E<string>(-753802046), Mathf.RoundToInt(num15).ToString(), <Module>.\u202E\u206C\u206E\u202C\u202D\u202D\u206D\u206B\u202B\u206F\u200B\u206E\u200B\u202C\u202A\u200D\u202D\u200B\u202D\u202E\u200D\u206F\u206C\u202C\u200B\u202C\u206D\u202B\u206C\u206E\u200E\u206A\u200D\u206F\u200E\u206E\u206A\u200C\u200D\u206B\u202E<string>(604499582)), new Color(0f, 0.8f, 1f, 1f));
							num14 = 1012137733U;
							continue;
						}
						case 2U:
						{
							BarricadeDrop barricadeDrop;
							Highlighter highlighter2;
							num14 = ((this.highlighters.TryGetValue(ESP.\u202D\u200B\u202B\u206E\u202C\u206F\u202E\u202E\u206E\u202C\u202A\u202E\u202C\u202E\u202A\u206F\u206F\u200D\u206B\u200B\u202A\u200E\u206C\u200B\u206A\u202C\u200E\u202C\u206E\u200F\u206E\u206B\u200B\u202B\u202E\u206F\u200E\u206A\u206E\u202E(barricadeDrop), out highlighter2) ? 318648434U : 1832572222U) ^ num2 * 3185498651U);
							continue;
						}
						case 3U:
						{
							BarricadeDrop barricadeDrop;
							Vector3 vector8 = ESP.\u206E\u200B\u206A\u206A\u200B\u206D\u206A\u200B\u202A\u202D\u202E\u206D\u206B\u202E\u202E\u206C\u200D\u200F\u202E\u202C\u202C\u202E\u200B\u200D\u200E\u200F\u202B\u200E\u202E\u200F\u202B\u202E\u200B\u202D\u200B\u200B\u202B\u206A\u200F\u206B\u202E(cachedCamera, ESP.\u206B\u202A\u206E\u200C\u202B\u200D\u206D\u200C\u206A\u202B\u202B\u200C\u200D\u200D\u202E\u206B\u202C\u200D\u202E\u202B\u206B\u200D\u202B\u200D\u200C\u200C\u206D\u200D\u200B\u206C\u200C\u200E\u202C\u202C\u206C\u202B\u206E\u200D\u202E\u206B\u202E(ESP.\u202D\u200B\u202B\u206E\u202C\u206F\u202E\u202E\u206E\u202C\u202A\u202E\u202C\u202E\u202A\u206F\u206F\u200D\u206B\u200B\u202A\u200E\u206C\u200B\u206A\u202C\u200E\u202C\u206E\u200F\u206E\u206B\u200B\u202B\u202E\u206F\u200E\u206A\u206E\u202E(barricadeDrop)) + Vector3.up * 1.2f);
							num14 = (((vector8.z <= 0.05f) ? 2418248653U : 3692846234U) ^ num2 * 3228699895U);
							continue;
						}
						case 4U:
						{
							BarricadeDrop barricadeDrop = enumerator3.Current;
							num14 = ((barricadeDrop != null) ? 1378083447U : 1012137733U);
							continue;
						}
						case 5U:
						{
							Highlighter highlighter2;
							num14 = (((!ESP.\u200D\u200E\u202A\u200E\u206F\u202E\u206D\u200D\u200C\u206F\u200F\u206A\u206B\u202C\u200B\u202C\u206D\u200F\u200E\u206A\u202E\u206D\u206E\u206B\u206C\u200B\u206E\u206A\u200F\u206B\u200F\u202A\u206C\u202E\u200C\u202D\u200C\u202C\u206F\u202D\u202E(highlighter2, null)) ? 163424760U : 217158930U) ^ num2 * 375804031U);
							continue;
						}
						case 6U:
							num14 = (((!this.showBedGlow) ? 1112270265U : 1757801757U) ^ num2 * 148473432U);
							continue;
						case 7U:
							num14 = (this.showBedName ? 622611398U : 1012137733U);
							continue;
						case 8U:
						{
							BarricadeDrop barricadeDrop;
							num14 = (((!ESP.\u200D\u200E\u202A\u200E\u206F\u202E\u206D\u200D\u200C\u206F\u200F\u206A\u206B\u202C\u200B\u202C\u206D\u200F\u200E\u206A\u202E\u206D\u206E\u206B\u206C\u200B\u206E\u206A\u200F\u206B\u200F\u202A\u206C\u202E\u200C\u202D\u200C\u202C\u206F\u202D\u202E(ESP.\u202D\u200B\u202B\u206E\u202C\u206F\u202E\u202E\u206E\u202C\u202A\u202E\u202C\u202E\u202A\u206F\u206F\u200D\u206B\u200B\u202A\u200E\u206C\u200B\u206A\u202C\u200E\u202C\u206E\u200F\u206E\u206B\u200B\u202B\u202E\u206F\u200E\u206A\u206E\u202E(barricadeDrop), null)) ? 2282638938U : 2202502799U) ^ num2 * 1780979846U);
							continue;
						}
						case 9U:
						{
							BarricadeDrop barricadeDrop;
							float num15 = this.entities.DistanceToLocal(ESP.\u206B\u202A\u206E\u200C\u202B\u200D\u206D\u200C\u206A\u202B\u202B\u200C\u200D\u200D\u202E\u206B\u202C\u200D\u202E\u202B\u206B\u200D\u202B\u200D\u200C\u200C\u206D\u200D\u200B\u206C\u200C\u200E\u202C\u202C\u206C\u202B\u206E\u200D\u202E\u206B\u202E(ESP.\u202D\u200B\u202B\u206E\u202C\u206F\u202E\u202E\u206E\u202C\u202A\u202E\u202C\u202E\u202A\u206F\u206F\u200D\u206B\u200B\u202A\u200E\u206C\u200B\u206A\u202C\u200E\u202C\u206E\u200F\u206E\u206B\u200B\u202B\u202E\u206F\u200E\u206A\u206E\u202E(barricadeDrop)));
							num14 = (num2 * 1977486213U ^ 3871513700U);
							continue;
						}
						case 10U:
						{
							Highlighter highlighter2;
							ESP.\u206B\u200D\u200D\u202B\u200B\u200B\u200E\u200B\u200D\u202A\u202D\u202E\u200D\u206C\u200C\u200B\u200C\u200C\u202C\u206D\u206C\u202A\u206B\u206E\u206E\u200D\u202B\u202B\u206E\u200E\u200E\u206B\u206D\u206C\u206C\u206B\u202B\u202A\u206B\u202E\u202E(highlighter2, new Color(0f, 0.8f, 1f, 1f), 0.25f);
							num14 = 110312555U;
							continue;
						}
						case 11U:
						{
							BarricadeDrop barricadeDrop;
							this.AddHighlighter(ESP.\u202D\u200B\u202B\u206E\u202C\u206F\u202E\u202E\u206E\u202C\u202A\u202E\u202C\u202E\u202A\u206F\u206F\u200D\u206B\u200B\u202A\u200E\u206C\u200B\u206A\u202C\u200E\u202C\u206E\u200F\u206E\u206B\u200B\u202B\u202E\u206F\u200E\u206A\u206E\u202E(barricadeDrop));
							num14 = 402265737U;
							continue;
						}
						case 12U:
						{
							Highlighter highlighter2;
							ESP.\u206C\u200C\u200F\u202D\u206B\u206C\u206D\u202B\u206C\u200E\u202A\u202B\u206C\u206B\u202D\u200F\u206B\u200C\u206C\u202A\u200E\u200C\u200D\u200B\u202A\u206B\u206A\u206F\u206E\u200E\u200F\u200C\u200C\u202A\u200D\u206D\u200B\u200E\u200E\u202E\u202E(highlighter2, true);
							num14 = (num2 * 3863572516U ^ 3665562509U);
							continue;
						}
						case 14U:
						{
							float num15;
							num14 = (((num15 > this.maxDistance) ? 143706893U : 837384016U) ^ num2 * 1308426666U);
							continue;
						}
						case 15U:
						{
							Highlighter highlighter2;
							ESP.\u200C\u202B\u206A\u200F\u206C\u206F\u202A\u206F\u202D\u206A\u206F\u202D\u206E\u200C\u200C\u200D\u206A\u202C\u202A\u200D\u206E\u202A\u206E\u206E\u200B\u200F\u202E\u202E\u206D\u202B\u200C\u200F\u206C\u200B\u206F\u202D\u200B\u206F\u202D\u202E\u202E(highlighter2, true);
							num14 = (num2 * 2332840085U ^ 524892414U);
							continue;
						}
						case 16U:
							num14 = 1049064910U;
							continue;
						}
						goto Block_52;
					}
				}
				Block_52:;
			}
			using (List<BarricadeDrop>.Enumerator enumerator3 = this.entities.Claims.GetEnumerator())
			{
				for (;;)
				{
					IL_1009:
					uint num16 = enumerator3.MoveNext() ? 935688604U : 407452182U;
					for (;;)
					{
						uint num2;
						switch ((num2 = (num16 ^ 1035936800U)) % 16U)
						{
						case 0U:
						{
							BarricadeDrop barricadeDrop2;
							num16 = (((!ESP.\u200D\u200E\u202A\u200E\u206F\u202E\u206D\u200D\u200C\u206F\u200F\u206A\u206B\u202C\u200B\u202C\u206D\u200F\u200E\u206A\u202E\u206D\u206E\u206B\u206C\u200B\u206E\u206A\u200F\u206B\u200F\u202A\u206C\u202E\u200C\u202D\u200C\u202C\u206F\u202D\u202E(ESP.\u202D\u200B\u202B\u206E\u202C\u206F\u202E\u202E\u206E\u202C\u202A\u202E\u202C\u202E\u202A\u206F\u206F\u200D\u206B\u200B\u202A\u200E\u206C\u200B\u206A\u202C\u200E\u202C\u206E\u200F\u206E\u206B\u200B\u202B\u202E\u206F\u200E\u206A\u206E\u202E(barricadeDrop2), null)) ? 3809573875U : 2620808065U) ^ num2 * 1081177761U);
							continue;
						}
						case 1U:
							goto IL_1009;
						case 2U:
							num16 = (this.showClaimName ? 325111893U : 1467942769U);
							continue;
						case 3U:
						{
							BarricadeDrop barricadeDrop2;
							float num17 = this.entities.DistanceToLocal(ESP.\u206B\u202A\u206E\u200C\u202B\u200D\u206D\u200C\u206A\u202B\u202B\u200C\u200D\u200D\u202E\u206B\u202C\u200D\u202E\u202B\u206B\u200D\u202B\u200D\u200C\u200C\u206D\u200D\u200B\u206C\u200C\u200E\u202C\u202C\u206C\u202B\u206E\u200D\u202E\u206B\u202E(ESP.\u202D\u200B\u202B\u206E\u202C\u206F\u202E\u202E\u206E\u202C\u202A\u202E\u202C\u202E\u202A\u206F\u206F\u200D\u206B\u200B\u202A\u200E\u206C\u200B\u206A\u202C\u200E\u202C\u206E\u200F\u206E\u206B\u200B\u202B\u202E\u206F\u200E\u206A\u206E\u202E(barricadeDrop2)));
							num16 = (num2 * 3586393728U ^ 2418559817U);
							continue;
						}
						case 4U:
							num16 = 935688604U;
							continue;
						case 5U:
						{
							BarricadeDrop barricadeDrop2;
							float num17;
							Vector3 vector9;
							this.DrawObjectText(vector9, ESP.\u200F\u206A\u202E\u206E\u200E\u206C\u200D\u200D\u202C\u200E\u206F\u200D\u200D\u202D\u202B\u202B\u202B\u200C\u202A\u206E\u206E\u200D\u200E\u202C\u202D\u200F\u206D\u206A\u206E\u200E\u200B\u202B\u206D\u202A\u206B\u202A\u200C\u202C\u200D\u202A\u202E(ESP.\u206B\u200C\u206F\u202D\u202E\u202B\u202E\u200C\u206B\u200C\u202C\u200E\u202B\u200B\u200D\u202D\u202B\u202B\u206E\u206F\u200E\u206C\u202A\u202A\u206A\u206D\u200D\u200C\u200C\u202D\u202D\u206E\u202A\u200C\u202C\u200B\u202C\u206C\u206B\u202A\u202E(ESP.\u202B\u202D\u200C\u206A\u202D\u200C\u202A\u200D\u200B\u206B\u200B\u202A\u206A\u200D\u206C\u200C\u200D\u206B\u200B\u202C\u206A\u206B\u202E\u202E\u200C\u200E\u206C\u206D\u206A\u206A\u200B\u200C\u200C\u202C\u202D\u206A\u200B\u202E\u206E\u202B\u202E(barricadeDrop2)), <Module>.\u202B\u200B\u202C\u206C\u206D\u202C\u206B\u200F\u206D\u206D\u200E\u206A\u202E\u206D\u200D\u206A\u202D\u202B\u200B\u200F\u202C\u206D\u200E\u202D\u200D\u206A\u200F\u206E\u206F\u206F\u200D\u202D\u202C\u200B\u206F\u202C\u202A\u200D\u206E\u202E\u202E<string>(212084884), Mathf.RoundToInt(num17).ToString(), <Module>.\u200B\u206C\u200C\u200C\u206A\u200B\u200D\u206C\u206B\u206D\u202B\u200F\u200E\u206E\u206A\u200D\u206B\u202E\u206A\u200E\u200B\u202E\u200F\u206C\u200F\u202A\u202B\u200F\u200D\u200C\u202D\u200E\u206B\u200D\u202A\u200E\u202E\u206A\u202B\u200C\u202E<string>(205861292)), new Color(0f, 0.8f, 1f, 1f));
							num16 = 1467942769U;
							continue;
						}
						case 7U:
							num16 = (((!this.showClaimGlow) ? 2227235348U : 2628614505U) ^ num2 * 2501022394U);
							continue;
						case 8U:
						{
							BarricadeDrop barricadeDrop2;
							Vector3 vector9 = ESP.\u206E\u200B\u206A\u206A\u200B\u206D\u206A\u200B\u202A\u202D\u202E\u206D\u206B\u202E\u202E\u206C\u200D\u200F\u202E\u202C\u202C\u202E\u200B\u200D\u200E\u200F\u202B\u200E\u202E\u200F\u202B\u202E\u200B\u202D\u200B\u200B\u202B\u206A\u200F\u206B\u202E(cachedCamera, ESP.\u206B\u202A\u206E\u200C\u202B\u200D\u206D\u200C\u206A\u202B\u202B\u200C\u200D\u200D\u202E\u206B\u202C\u200D\u202E\u202B\u206B\u200D\u202B\u200D\u200C\u200C\u206D\u200D\u200B\u206C\u200C\u200E\u202C\u202C\u206C\u202B\u206E\u200D\u202E\u206B\u202E(ESP.\u202D\u200B\u202B\u206E\u202C\u206F\u202E\u202E\u206E\u202C\u202A\u202E\u202C\u202E\u202A\u206F\u206F\u200D\u206B\u200B\u202A\u200E\u206C\u200B\u206A\u202C\u200E\u202C\u206E\u200F\u206E\u206B\u200B\u202B\u202E\u206F\u200E\u206A\u206E\u202E(barricadeDrop2)) + Vector3.up * 1.5f);
							num16 = (((vector9.z > 0.05f) ? 3835508599U : 2799703889U) ^ num2 * 1377592932U);
							continue;
						}
						case 9U:
						{
							float num17;
							num16 = (((num17 <= this.maxDistance) ? 2554819031U : 3042372558U) ^ num2 * 2492793703U);
							continue;
						}
						case 10U:
						{
							Highlighter highlighter3;
							ESP.\u206B\u200D\u200D\u202B\u200B\u200B\u200E\u200B\u200D\u202A\u202D\u202E\u200D\u206C\u200C\u200B\u200C\u200C\u202C\u206D\u206C\u202A\u206B\u206E\u206E\u200D\u202B\u202B\u206E\u200E\u200E\u206B\u206D\u206C\u206C\u206B\u202B\u202A\u206B\u202E\u202E(highlighter3, new Color(0f, 0.8f, 1f, 1f), 0.25f);
							ESP.\u200C\u202B\u206A\u200F\u206C\u206F\u202A\u206F\u202D\u206A\u206F\u202D\u206E\u200C\u200C\u200D\u206A\u202C\u202A\u200D\u206E\u202A\u206E\u206E\u200B\u200F\u202E\u202E\u206D\u202B\u200C\u200F\u206C\u200B\u206F\u202D\u200B\u206F\u202D\u202E\u202E(highlighter3, true);
							ESP.\u206C\u200C\u200F\u202D\u206B\u206C\u206D\u202B\u206C\u200E\u202A\u202B\u206C\u206B\u202D\u200F\u206B\u200C\u206C\u202A\u200E\u200C\u200D\u200B\u202A\u206B\u206A\u206F\u206E\u200E\u200F\u200C\u200C\u202A\u200D\u206D\u200B\u200E\u200E\u202E\u202E(highlighter3, true);
							num16 = 1651279970U;
							continue;
						}
						case 11U:
						{
							BarricadeDrop barricadeDrop2;
							this.AddHighlighter(ESP.\u202D\u200B\u202B\u206E\u202C\u206F\u202E\u202E\u206E\u202C\u202A\u202E\u202C\u202E\u202A\u206F\u206F\u200D\u206B\u200B\u202A\u200E\u206C\u200B\u206A\u202C\u200E\u202C\u206E\u200F\u206E\u206B\u200B\u202B\u202E\u206F\u200E\u206A\u206E\u202E(barricadeDrop2));
							num16 = 1651279970U;
							continue;
						}
						case 12U:
						{
							BarricadeDrop barricadeDrop2 = enumerator3.Current;
							num16 = 135715438U;
							continue;
						}
						case 13U:
						{
							Highlighter highlighter3;
							num16 = ((ESP.\u200D\u200E\u202A\u200E\u206F\u202E\u206D\u200D\u200C\u206F\u200F\u206A\u206B\u202C\u200B\u202C\u206D\u200F\u200E\u206A\u202E\u206D\u206E\u206B\u206C\u200B\u206E\u206A\u200F\u206B\u200F\u202A\u206C\u202E\u200C\u202D\u200C\u202C\u206F\u202D\u202E(highlighter3, null) ? 3339342958U : 3532212031U) ^ num2 * 502109849U);
							continue;
						}
						case 14U:
						{
							BarricadeDrop barricadeDrop2;
							num16 = (((barricadeDrop2 == null) ? 3536884533U : 2415318676U) ^ num2 * 157628942U);
							continue;
						}
						case 15U:
						{
							BarricadeDrop barricadeDrop2;
							Highlighter highlighter3;
							num16 = ((this.highlighters.TryGetValue(ESP.\u202D\u200B\u202B\u206E\u202C\u206F\u202E\u202E\u206E\u202C\u202A\u202E\u202C\u202E\u202A\u206F\u206F\u200D\u206B\u200B\u202A\u200E\u206C\u200B\u206A\u202C\u200E\u202C\u206E\u200F\u206E\u206B\u200B\u202B\u202E\u206F\u200E\u206A\u206E\u202E(barricadeDrop2), out highlighter3) ? 1363626327U : 1146234577U) ^ num2 * 2188147542U);
							continue;
						}
						}
						goto Block_64;
					}
				}
				Block_64:;
			}
			using (List<BarricadeDrop>.Enumerator enumerator3 = this.entities.Furniture.GetEnumerator())
			{
				for (;;)
				{
					IL_14F0:
					uint num18 = enumerator3.MoveNext() ? 1861769775U : 1268483887U;
					for (;;)
					{
						uint num2;
						switch ((num2 = (num18 ^ 1035936800U)) % 17U)
						{
						case 0U:
						{
							BarricadeDrop barricadeDrop3;
							Vector3 vector10 = ESP.\u206E\u200B\u206A\u206A\u200B\u206D\u206A\u200B\u202A\u202D\u202E\u206D\u206B\u202E\u202E\u206C\u200D\u200F\u202E\u202C\u202C\u202E\u200B\u200D\u200E\u200F\u202B\u200E\u202E\u200F\u202B\u202E\u200B\u202D\u200B\u200B\u202B\u206A\u200F\u206B\u202E(cachedCamera, ESP.\u206B\u202A\u206E\u200C\u202B\u200D\u206D\u200C\u206A\u202B\u202B\u200C\u200D\u200D\u202E\u206B\u202C\u200D\u202E\u202B\u206B\u200D\u202B\u200D\u200C\u200C\u206D\u200D\u200B\u206C\u200C\u200E\u202C\u202C\u206C\u202B\u206E\u200D\u202E\u206B\u202E(ESP.\u202D\u200B\u202B\u206E\u202C\u206F\u202E\u202E\u206E\u202C\u202A\u202E\u202C\u202E\u202A\u206F\u206F\u200D\u206B\u200B\u202A\u200E\u206C\u200B\u206A\u202C\u200E\u202C\u206E\u200F\u206E\u206B\u200B\u202B\u202E\u206F\u200E\u206A\u206E\u202E(barricadeDrop3)) + Vector3.up * 1.2f);
							num18 = (num2 * 2455952334U ^ 3483595464U);
							continue;
						}
						case 1U:
						{
							Vector3 vector10;
							num18 = (((vector10.z > 0.05f) ? 2020208941U : 64420001U) ^ num2 * 3606868405U);
							continue;
						}
						case 2U:
							goto IL_14F0;
						case 3U:
							num18 = 1861769775U;
							continue;
						case 4U:
						{
							BarricadeDrop barricadeDrop3;
							Highlighter highlighter4;
							num18 = ((this.highlighters.TryGetValue(ESP.\u202D\u200B\u202B\u206E\u202C\u206F\u202E\u202E\u206E\u202C\u202A\u202E\u202C\u202E\u202A\u206F\u206F\u200D\u206B\u200B\u202A\u200E\u206C\u200B\u206A\u202C\u200E\u202C\u206E\u200F\u206E\u206B\u200B\u202B\u202E\u206F\u200E\u206A\u206E\u202E(barricadeDrop3), out highlighter4) ? 665495910U : 1938170247U) ^ num2 * 4051962407U);
							continue;
						}
						case 5U:
						{
							BarricadeDrop barricadeDrop3;
							num18 = (((barricadeDrop3 == null) ? 2744396213U : 3047535336U) ^ num2 * 1366240018U);
							continue;
						}
						case 6U:
						{
							BarricadeDrop barricadeDrop3 = enumerator3.Current;
							num18 = 925437211U;
							continue;
						}
						case 7U:
							num18 = (((!this.showFurnitureGlow) ? 2902244686U : 3066654772U) ^ num2 * 3503289650U);
							continue;
						case 8U:
						{
							BarricadeDrop barricadeDrop3;
							num18 = (((!ESP.\u200D\u200E\u202A\u200E\u206F\u202E\u206D\u200D\u200C\u206F\u200F\u206A\u206B\u202C\u200B\u202C\u206D\u200F\u200E\u206A\u202E\u206D\u206E\u206B\u206C\u200B\u206E\u206A\u200F\u206B\u200F\u202A\u206C\u202E\u200C\u202D\u200C\u202C\u206F\u202D\u202E(ESP.\u202D\u200B\u202B\u206E\u202C\u206F\u202E\u202E\u206E\u202C\u202A\u202E\u202C\u202E\u202A\u206F\u206F\u200D\u206B\u200B\u202A\u200E\u206C\u200B\u206A\u202C\u200E\u202C\u206E\u200F\u206E\u206B\u200B\u202B\u202E\u206F\u200E\u206A\u206E\u202E(barricadeDrop3), null)) ? 4170494075U : 3061632887U) ^ num2 * 1711386654U);
							continue;
						}
						case 10U:
						{
							Highlighter highlighter4;
							ESP.\u206C\u200C\u200F\u202D\u206B\u206C\u206D\u202B\u206C\u200E\u202A\u202B\u206C\u206B\u202D\u200F\u206B\u200C\u206C\u202A\u200E\u200C\u200D\u200B\u202A\u206B\u206A\u206F\u206E\u200E\u200F\u200C\u200C\u202A\u200D\u206D\u200B\u200E\u200E\u202E\u202E(highlighter4, true);
							num18 = (num2 * 3112414348U ^ 3301642816U);
							continue;
						}
						case 11U:
						{
							BarricadeDrop barricadeDrop3;
							float num19 = this.entities.DistanceToLocal(ESP.\u206B\u202A\u206E\u200C\u202B\u200D\u206D\u200C\u206A\u202B\u202B\u200C\u200D\u200D\u202E\u206B\u202C\u200D\u202E\u202B\u206B\u200D\u202B\u200D\u200C\u200C\u206D\u200D\u200B\u206C\u200C\u200E\u202C\u202C\u206C\u202B\u206E\u200D\u202E\u206B\u202E(ESP.\u202D\u200B\u202B\u206E\u202C\u206F\u202E\u202E\u206E\u202C\u202A\u202E\u202C\u202E\u202A\u206F\u206F\u200D\u206B\u200B\u202A\u200E\u206C\u200B\u206A\u202C\u200E\u202C\u206E\u200F\u206E\u206B\u200B\u202B\u202E\u206F\u200E\u206A\u206E\u202E(barricadeDrop3)));
							num18 = (((num19 > this.maxDistance) ? 2680085393U : 2581107349U) ^ num2 * 85288830U);
							continue;
						}
						case 12U:
						{
							BarricadeDrop barricadeDrop3;
							Vector3 vector10;
							float num19;
							this.DrawObjectText(vector10, ESP.\u200F\u206A\u202E\u206E\u200E\u206C\u200D\u200D\u202C\u200E\u206F\u200D\u200D\u202D\u202B\u202B\u202B\u200C\u202A\u206E\u206E\u200D\u200E\u202C\u202D\u200F\u206D\u206A\u206E\u200E\u200B\u202B\u206D\u202A\u206B\u202A\u200C\u202C\u200D\u202A\u202E(ESP.\u206B\u200C\u206F\u202D\u202E\u202B\u202E\u200C\u206B\u200C\u202C\u200E\u202B\u200B\u200D\u202D\u202B\u202B\u206E\u206F\u200E\u206C\u202A\u202A\u206A\u206D\u200D\u200C\u200C\u202D\u202D\u206E\u202A\u200C\u202C\u200B\u202C\u206C\u206B\u202A\u202E(ESP.\u202B\u202D\u200C\u206A\u202D\u200C\u202A\u200D\u200B\u206B\u200B\u202A\u206A\u200D\u206C\u200C\u200D\u206B\u200B\u202C\u206A\u206B\u202E\u202E\u200C\u200E\u206C\u206D\u206A\u206A\u200B\u200C\u200C\u202C\u202D\u206A\u200B\u202E\u206E\u202B\u202E(barricadeDrop3)), <Module>.\u206A\u202C\u206A\u206C\u202A\u206F\u200B\u206C\u206C\u206B\u206F\u206C\u200C\u206D\u200C\u200C\u206C\u206A\u202A\u206B\u200B\u202E\u200C\u206E\u202D\u202A\u200E\u202D\u200E\u200E\u200D\u200E\u202B\u202A\u206E\u202A\u200B\u200B\u202D\u202E<string>(-880545556), Mathf.RoundToInt(num19).ToString(), <Module>.\u202E\u206C\u206E\u202C\u202D\u202D\u206D\u206B\u202B\u206F\u200B\u206E\u200B\u202C\u202A\u200D\u202D\u200B\u202D\u202E\u200D\u206F\u206C\u202C\u200B\u202C\u206D\u202B\u206C\u206E\u200E\u206A\u200D\u206F\u200E\u206E\u206A\u200C\u200D\u206B\u202E<string>(604499582)), new Color(1f, 0.55f, 0f, 1f));
							num18 = 545580691U;
							continue;
						}
						case 13U:
							num18 = ((!this.showFurnitureName) ? 545580691U : 1176305478U);
							continue;
						case 14U:
						{
							Highlighter highlighter4;
							ESP.\u206B\u200D\u200D\u202B\u200B\u200B\u200E\u200B\u200D\u202A\u202D\u202E\u200D\u206C\u200C\u200B\u200C\u200C\u202C\u206D\u206C\u202A\u206B\u206E\u206E\u200D\u202B\u202B\u206E\u200E\u200E\u206B\u206D\u206C\u206C\u206B\u202B\u202A\u206B\u202E\u202E(highlighter4, new Color(1f, 0.55f, 0f, 1f), 0.25f);
							ESP.\u200C\u202B\u206A\u200F\u206C\u206F\u202A\u206F\u202D\u206A\u206F\u202D\u206E\u200C\u200C\u200D\u206A\u202C\u202A\u200D\u206E\u202A\u206E\u206E\u200B\u200F\u202E\u202E\u206D\u202B\u200C\u200F\u206C\u200B\u206F\u202D\u200B\u206F\u202D\u202E\u202E(highlighter4, true);
							num18 = 49729040U;
							continue;
						}
						case 15U:
						{
							BarricadeDrop barricadeDrop3;
							this.AddHighlighter(ESP.\u202D\u200B\u202B\u206E\u202C\u206F\u202E\u202E\u206E\u202C\u202A\u202E\u202C\u202E\u202A\u206F\u206F\u200D\u206B\u200B\u202A\u200E\u206C\u200B\u206A\u202C\u200E\u202C\u206E\u200F\u206E\u206B\u200B\u202B\u202E\u206F\u200E\u206A\u206E\u202E(barricadeDrop3));
							num18 = 144654336U;
							continue;
						}
						case 16U:
						{
							Highlighter highlighter4;
							num18 = ((ESP.\u200D\u200E\u202A\u200E\u206F\u202E\u206D\u200D\u200C\u206F\u200F\u206A\u206B\u202C\u200B\u202C\u206D\u200F\u200E\u206A\u202E\u206D\u206E\u206B\u206C\u200B\u206E\u206A\u200F\u206B\u200F\u202A\u206C\u202E\u200C\u202D\u200C\u202C\u206F\u202D\u202E(highlighter4, null) ? 2187742817U : 3138596895U) ^ num2 * 3955683499U);
							continue;
						}
						}
						goto Block_76;
					}
				}
				Block_76:;
			}
			using (List<Player>.Enumerator enumerator4 = this.entities.Players.GetEnumerator())
			{
				for (;;)
				{
					IL_1AD8:
					uint num20 = enumerator4.MoveNext() ? 317694851U : 1854487488U;
					for (;;)
					{
						uint num2;
						bool flag3;
						float num22;
						float num23;
						Vector3 worldPos2;
						Vector3 vector12;
						switch ((num2 = (num20 ^ 1035936800U)) % 36U)
						{
						case 0U:
						{
							float num21;
							this.DrawPlayerBox(CS$<>8__locals1.player, num21, cachedCamera);
							num20 = (num2 * 2528280446U ^ 277211560U);
							continue;
						}
						case 1U:
						{
							Vector3 vector11 = ESP.\u206B\u202A\u206E\u200C\u202B\u200D\u206D\u200C\u206A\u202B\u202B\u200C\u200D\u200D\u202E\u206B\u202C\u200D\u202E\u202B\u206B\u200D\u202B\u200D\u200C\u200C\u206D\u200D\u200B\u206C\u200C\u200E\u202C\u202C\u206C\u202B\u206E\u200D\u202E\u206B\u202E(ESP.\u200E\u202D\u200C\u206D\u202D\u200B\u202C\u202E\u206F\u202C\u200B\u206E\u206D\u200C\u200E\u200F\u200C\u200E\u200B\u200F\u200C\u202B\u200C\u202E\u200C\u202A\u202B\u200B\u206A\u206A\u206E\u206A\u202B\u202B\u202A\u202A\u206C\u202E\u200D\u206F\u202E(CS$<>8__locals1.player));
							num20 = (num2 * 3961153632U ^ 978670090U);
							continue;
						}
						case 2U:
						{
							Vector3 from = ESP.\u206B\u202A\u206E\u200C\u202B\u200D\u206D\u200C\u206A\u202B\u202B\u200C\u200D\u200D\u202E\u206B\u202C\u200D\u202E\u202B\u206B\u200D\u202B\u200D\u200C\u200C\u206D\u200D\u200B\u206C\u200C\u200E\u202C\u202C\u206C\u202B\u206E\u200D\u202E\u206B\u202E(ESP.\u200F\u202A\u206A\u206C\u200E\u206B\u206C\u206A\u202A\u206E\u206B\u206F\u202E\u206C\u200B\u200E\u202A\u206B\u206B\u202B\u206C\u202C\u206E\u200B\u202B\u206F\u200F\u202D\u200E\u200B\u200E\u202D\u200B\u200E\u202A\u206C\u206B\u206C\u202E(ESP.\u202D\u206B\u200B\u200D\u206A\u200C\u202E\u206A\u200D\u200B\u206C\u206F\u206D\u200D\u206A\u200D\u202A\u206A\u202B\u206D\u202E\u202C\u200F\u206E\u202E\u200C\u206D\u202D\u206F\u200D\u206E\u206D\u206C\u206C\u206C\u200B\u206D\u206F\u206D\u202B\u202E(ESP.\u202E\u206A\u200D\u206A\u206F\u206B\u202A\u206A\u202C\u202A\u206D\u206B\u202A\u206C\u202B\u206E\u200D\u202C\u200F\u206B\u206B\u206A\u200B\u206D\u206A\u202E\u206E\u202A\u200F\u206A\u202E\u202E\u206E\u202E\u202C\u202B\u202A\u206E\u200E\u200E\u202E())));
							num20 = (num2 * 2514435806U ^ 707121353U);
							continue;
						}
						case 3U:
							num20 = (((!ESP.\u200D\u200E\u202A\u200E\u206F\u202E\u206D\u200D\u200C\u206F\u200F\u206A\u206B\u202C\u200B\u202C\u206D\u200F\u200E\u206A\u202E\u206D\u206E\u206B\u206C\u200B\u206E\u206A\u200F\u206B\u200F\u202A\u206C\u202E\u200C\u202D\u200C\u202C\u206F\u202D\u202E(ESP.\u200E\u202D\u200C\u206D\u202D\u200B\u202C\u202E\u206F\u202C\u200B\u206E\u206D\u200C\u200E\u200F\u200C\u200E\u200B\u200F\u200C\u202B\u200C\u202E\u200C\u202A\u202B\u200B\u206A\u206A\u206E\u206A\u202B\u202B\u202A\u202A\u206C\u202E\u200D\u206F\u202E(CS$<>8__locals1.player), null)) ? 1356029623U : 1783613501U) ^ num2 * 86764128U);
							continue;
						case 4U:
							num20 = ((!this.showInfoText) ? 1988448669U : 710475074U);
							continue;
						case 5U:
							num20 = (num2 * 3568784263U ^ 4095217053U);
							continue;
						case 6U:
							num20 = ((ESP.\u200D\u200E\u202A\u200E\u206F\u202E\u206D\u200D\u200C\u206F\u200F\u206A\u206B\u202C\u200B\u202C\u206D\u200F\u200E\u206A\u202E\u206D\u206E\u206B\u206C\u200B\u206E\u206A\u200F\u206B\u200F\u202A\u206C\u202E\u200C\u202D\u200C\u202C\u206F\u202D\u202E(CS$<>8__locals1.player, null) ? 4123369699U : 3671671297U) ^ num2 * 1496497131U);
							continue;
						case 7U:
						{
							Color color4;
							color4..ctor(0.2f, 1f, 0.2f, 0.92f);
							num20 = (num2 * 3370215383U ^ 344949990U);
							continue;
						}
						case 9U:
						{
							Vector3 from;
							Vector3 aimPosition;
							bool flag = this.IsVisible(from, aimPosition, CS$<>8__locals1.player);
							bool flag2 = Utils.IsFriendly(CS$<>8__locals1.player);
							flag3 = false;
							List<SteamPlayer> list = ESP.\u202B\u200C\u206A\u202B\u202C\u202E\u202A\u206B\u200C\u200D\u206C\u206B\u200F\u206B\u200B\u200C\u200F\u202C\u200B\u202B\u200B\u200B\u202B\u202A\u202C\u206D\u202A\u202E\u202B\u200C\u202A\u202B\u202E\u202B\u202E\u206B\u202B\u200B\u200B\u200E\u202E();
							SteamPlayer steamPlayer = (list != null) ? list.FirstOrDefault((SteamPlayer s) => ESP.<>c__DisplayClass52_0.\u200E\u202A\u202A\u200E\u206A\u202E\u200C\u206E\u206F\u202C\u206E\u206F\u206C\u200C\u206F\u202B\u202B\u206F\u206A\u200C\u200C\u206F\u206A\u200D\u206D\u202D\u202C\u200E\u200B\u206B\u206E\u202B\u206B\u202E\u202A\u200B\u202A\u202E\u202E\u202E((s != null) ? ESP.<>c__DisplayClass52_0.\u202B\u206D\u202C\u200E\u200D\u206E\u200F\u206B\u202C\u200F\u200F\u202B\u200B\u206C\u200D\u202E\u202E\u200E\u200B\u200E\u206E\u202B\u200B\u206C\u202A\u200F\u202A\u206A\u202E\u200D\u206D\u206F\u202B\u206B\u202B\u206A\u202A\u202D\u206F\u206C\u202E(s) : null, CS$<>8__locals1.player)) : null;
							if (steamPlayer != null)
							{
								string text6 = ESP.\u206B\u206D\u206F\u202E\u202C\u200E\u202B\u202B\u200D\u206C\u206C\u206A\u202E\u200B\u200D\u200E\u202A\u206E\u206D\u206B\u200F\u206A\u206D\u206C\u200B\u200B\u202B\u200E\u200B\u206F\u200B\u206A\u200B\u206C\u206A\u206E\u200D\u202A\u202A\u202E(ESP.\u200B\u200E\u202E\u202E\u202D\u200C\u202A\u206A\u200F\u206D\u206B\u202A\u200C\u206D\u202C\u200E\u200B\u206B\u202B\u206C\u206F\u200B\u206D\u202B\u202C\u200C\u202C\u200C\u202A\u206C\u206E\u200D\u202D\u206D\u206A\u202B\u200B\u206F\u206A\u200E\u202E(ESP.\u200F\u200B\u200B\u200C\u202D\u202D\u202E\u200E\u206D\u200B\u206A\u206E\u206B\u206D\u202D\u202E\u206C\u202E\u206C\u206D\u202B\u206F\u206D\u200C\u202D\u200C\u206C\u206F\u200C\u206B\u202E\u200E\u206C\u202A\u202D\u202A\u206E\u200E\u200F\u202E(steamPlayer)));
								flag3 = (ESP.\u200E\u202B\u200F\u206D\u202C\u206E\u200F\u200D\u200C\u206B\u206F\u200E\u200D\u200B\u202B\u206C\u206A\u206D\u206A\u200B\u206F\u206D\u200C\u206E\u202E\u200D\u202E\u200F\u202B\u206A\u200B\u206C\u202A\u200B\u200C\u202C\u202E\u202B\u200E\u206F\u202E(steamPlayer) || ESP.\u200B\u200F\u200C\u206A\u206E\u200E\u202C\u202A\u200E\u206E\u200F\u206F\u202E\u200D\u202C\u206C\u202B\u206D\u202E\u200F\u200D\u202B\u206A\u200E\u200F\u206E\u206B\u200C\u200E\u200D\u206F\u200B\u202C\u202B\u206D\u206D\u202C\u206E\u202A\u202E\u202E(text6, <Module>.\u202B\u200B\u202C\u206C\u206D\u202C\u206B\u200F\u206D\u206D\u200E\u206A\u202E\u206D\u200D\u206A\u202D\u202B\u200B\u200F\u202C\u206D\u200E\u202D\u200D\u206A\u200F\u206E\u206F\u206F\u200D\u202D\u202C\u200B\u206F\u202C\u202A\u200D\u206E\u202E\u202E<string>(-2103652024)) || ESP.\u200B\u200F\u200C\u206A\u206E\u200E\u202C\u202A\u200E\u206E\u200F\u206F\u202E\u200D\u202C\u206C\u202B\u206D\u202E\u200F\u200D\u202B\u206A\u200E\u200F\u206E\u206B\u200C\u200E\u200D\u206F\u200B\u202C\u202B\u206D\u206D\u202C\u206E\u202A\u202E\u202E(text6, <Module>.\u202E\u206C\u206E\u202C\u202D\u202D\u206D\u206B\u202B\u206F\u200B\u206E\u200B\u202C\u202A\u200D\u202D\u200B\u202D\u202E\u200D\u206F\u206C\u202C\u200B\u202C\u206D\u202B\u206C\u206E\u200E\u206A\u200D\u206F\u200E\u206E\u206A\u200C\u200D\u206B\u202E<string>(-1327274275)) || ESP.\u200B\u200F\u200C\u206A\u206E\u200E\u202C\u202A\u200E\u206E\u200F\u206F\u202E\u200D\u202C\u206C\u202B\u206D\u202E\u200F\u200D\u202B\u206A\u200E\u200F\u206E\u206B\u200C\u200E\u200D\u206F\u200B\u202C\u202B\u206D\u206D\u202C\u206E\u202A\u202E\u202E(text6, <Module>.\u202E\u206C\u206E\u202C\u202D\u202D\u206D\u206B\u202B\u206F\u200B\u206E\u200B\u202C\u202A\u200D\u202D\u200B\u202D\u202E\u200D\u206F\u206C\u202C\u200B\u202C\u206D\u202B\u206C\u206E\u200E\u206A\u200D\u206F\u200E\u206E\u206A\u200C\u200D\u206B\u202E<string>(-251930074)) || ESP.\u200B\u200F\u200C\u206A\u206E\u200E\u202C\u202A\u200E\u206E\u200F\u206F\u202E\u200D\u202C\u206C\u202B\u206D\u202E\u200F\u200D\u202B\u206A\u200E\u200F\u206E\u206B\u200C\u200E\u200D\u206F\u200B\u202C\u202B\u206D\u206D\u202C\u206E\u202A\u202E\u202E(text6, <Module>.\u200F\u206F\u200E\u202A\u200D\u200C\u206A\u200E\u202E\u202C\u200D\u202D\u200D\u202B\u200F\u200C\u200F\u200D\u206B\u206D\u206E\u202A\u206C\u206B\u200B\u200F\u206D\u206A\u202E\u206C\u206F\u206A\u200C\u200C\u206C\u202A\u206F\u206A\u202D\u206E\u202E<string>(-1465461484)) || ESP.\u200B\u200F\u200C\u206A\u206E\u200E\u202C\u202A\u200E\u206E\u200F\u206F\u202E\u200D\u202C\u206C\u202B\u206D\u202E\u200F\u200D\u202B\u206A\u200E\u200F\u206E\u206B\u200C\u200E\u200D\u206F\u200B\u202C\u202B\u206D\u206D\u202C\u206E\u202A\u202E\u202E(text6, <Module>.\u200F\u206F\u200E\u202A\u200D\u200C\u206A\u200E\u202E\u202C\u200D\u202D\u200D\u202B\u200F\u200C\u200F\u200D\u206B\u206D\u206E\u202A\u206C\u206B\u200B\u200F\u206D\u206A\u202E\u206C\u206F\u206A\u200C\u200C\u206C\u202A\u206F\u206A\u202D\u206E\u202E<string>(-101643240)) || ESP.\u200B\u200F\u200C\u206A\u206E\u200E\u202C\u202A\u200E\u206E\u200F\u206F\u202E\u200D\u202C\u206C\u202B\u206D\u202E\u200F\u200D\u202B\u206A\u200E\u200F\u206E\u206B\u200C\u200E\u200D\u206F\u200B\u202C\u202B\u206D\u206D\u202C\u206E\u202A\u202E\u202E(text6, <Module>.\u202E\u206C\u206E\u202C\u202D\u202D\u206D\u206B\u202B\u206F\u200B\u206E\u200B\u202C\u202A\u200D\u202D\u200B\u202D\u202E\u200D\u206F\u206C\u202C\u200B\u202C\u206D\u202B\u206C\u206E\u200E\u206A\u200D\u206F\u200E\u206E\u206A\u200C\u200D\u206B\u202E<string>(1898758328)));
							}
							if (flag2)
							{
								num20 = 1574422692U;
								continue;
							}
							goto IL_17F0;
						}
						case 10U:
							num20 = 317694851U;
							continue;
						case 11U:
							num20 = (this.showBoxes ? 426571844U : 10615952U);
							continue;
						case 12U:
							goto IL_17F0;
						case 13U:
							goto IL_1AD8;
						case 14U:
						{
							Vector3 vector11;
							Vector3 worldPos = vector11 + Vector3.up * this.infoTextOffsetY;
							num20 = (num2 * 1706488680U ^ 3850659305U);
							continue;
						}
						case 15U:
							num20 = ((ESP.\u200D\u200E\u202A\u200E\u206F\u202E\u206D\u200D\u200C\u206F\u200F\u206A\u206B\u202C\u200B\u202C\u206D\u200F\u200E\u206A\u202E\u206D\u206E\u206B\u206C\u200B\u206E\u206A\u200F\u206B\u200F\u202A\u206C\u202E\u200C\u202D\u200C\u202C\u206F\u202D\u202E(CS$<>8__locals1.player, ESP.\u202E\u206A\u200D\u206A\u206F\u206B\u202A\u206A\u202C\u202A\u206D\u206B\u202A\u206C\u202B\u206E\u200D\u202C\u200F\u206B\u206B\u206A\u200B\u206D\u206A\u202E\u206E\u202A\u200F\u206A\u202E\u202E\u206E\u202E\u202C\u202B\u202A\u206E\u200E\u200E\u202E()) ? 210062985U : 539682480U) ^ num2 * 2651556748U);
							continue;
						case 16U:
							num22 = 1f;
							goto IL_1649;
						case 17U:
						{
							bool flag;
							num20 = ((!flag) ? 2018068119U : 1976050311U);
							continue;
						}
						case 18U:
						{
							Color color4;
							color4..ctor(0f, 0.85f, 1f, 0.95f);
							num20 = (num2 * 833557377U ^ 3398228136U);
							continue;
						}
						case 19U:
							num20 = (num2 * 3202600554U ^ 1868782244U);
							continue;
						case 20U:
							num20 = (((!ESP.\u200D\u200E\u202A\u200E\u206F\u202E\u206D\u200D\u200C\u206F\u200F\u206A\u206B\u202C\u200B\u202C\u206D\u200F\u200E\u206A\u202E\u206D\u206E\u206B\u206C\u200B\u206E\u206A\u200F\u206B\u200F\u202A\u206C\u202E\u200C\u202D\u200C\u202C\u206F\u202D\u202E(ESP.\u202E\u206C\u206C\u206C\u206E\u206C\u206F\u206D\u202B\u200F\u200B\u202D\u202B\u200D\u200D\u202E\u206A\u202C\u200B\u206D\u200B\u200E\u206A\u202C\u206B\u202D\u202C\u206A\u206D\u202E\u200C\u206D\u206D\u202D\u206F\u200C\u206F\u206D\u200C\u200E\u202E(CS$<>8__locals1.player), null)) ? 1569194556U : 1294706561U) ^ num2 * 941368807U);
							continue;
						case 21U:
						{
							Vector3 aimPosition = this.GetAimPosition(CS$<>8__locals1.player);
							num20 = (num2 * 2700210656U ^ 22977485U);
							continue;
						}
						case 22U:
							num20 = (((!this.showSnaplines) ? 2125088987U : 1710908747U) ^ num2 * 4044181894U);
							continue;
						case 23U:
							num20 = 835898777U;
							continue;
						case 24U:
							num20 = ((!this.showSkeleton) ? 374923852U : 1394559707U);
							continue;
						case 25U:
						{
							Color color4;
							color4.a *= num23;
							Utils.DrawSnapline(new Vector2((float)ESP.\u202C\u206F\u200E\u206C\u206F\u200F\u206D\u202C\u200D\u206C\u202A\u206E\u200E\u202B\u200F\u200E\u200B\u202A\u200D\u200D\u206F\u202A\u202A\u206E\u202B\u206A\u202B\u200D\u206D\u200D\u206C\u200E\u202C\u202A\u200F\u200B\u200B\u202B\u206D\u206A\u202E() * 0.5f, (float)ESP.\u202C\u206B\u202C\u206A\u200D\u202E\u206F\u200F\u202B\u200B\u202D\u202E\u206E\u206D\u206E\u206D\u206D\u206B\u206B\u200E\u206C\u206F\u200F\u206D\u206B\u200C\u200D\u206F\u206E\u200C\u202B\u206C\u200B\u202E\u200E\u200F\u206F\u200D\u206B\u206B\u202E() - (float)ESP.\u202C\u206B\u202C\u206A\u200D\u202E\u206F\u200F\u202B\u200B\u202D\u202E\u206E\u206D\u206E\u206D\u206D\u206B\u206B\u200E\u206C\u206F\u200F\u206D\u206B\u200C\u200D\u206F\u206E\u200C\u202B\u206C\u200B\u202E\u200E\u200F\u206F\u200D\u206B\u206B\u202E() / 8f), worldPos2, color4, this.snaplineThickness, cachedCamera);
							num20 = (num2 * 3387209207U ^ 1812557228U);
							continue;
						}
						case 26U:
						{
							if (!this.snaplineAlphaFalloff)
							{
								num20 = 1147298168U;
								continue;
							}
							float num21;
							num22 = Mathf.Clamp01(1.85f - num21 / 750f);
							goto IL_1649;
						}
						case 27U:
						{
							if (!this.snaplineToFeet)
							{
								num20 = (num2 * 211029326U ^ 1790351204U);
								continue;
							}
							Vector3 vector11;
							vector12 = vector11;
							goto IL_1A9C;
						}
						case 28U:
						{
							Color color4;
							color4..ctor(0f, 0.65f, 1f, 0.95f);
							num20 = (num2 * 2484444226U ^ 4002532289U);
							continue;
						}
						case 29U:
							CS$<>8__locals1.player = enumerator4.Current;
							num20 = (num2 * 2494139559U ^ 63982965U);
							continue;
						case 30U:
						{
							Vector3 vector11;
							vector12 = vector11 + Vector3.up * this.GetHeadHeight(ESP.\u206F\u206F\u202B\u200C\u206D\u200E\u206F\u206B\u206B\u206D\u202C\u206F\u202A\u206F\u202D\u206D\u206A\u200D\u202B\u202B\u206E\u206B\u206D\u206E\u202C\u200F\u206E\u206F\u206F\u202C\u206E\u202E\u200D\u206B\u206D\u206C\u200D\u202B\u206A\u202E(ESP.\u206A\u200E\u206B\u200B\u206F\u202B\u206C\u200C\u200F\u206E\u200D\u206B\u202A\u202A\u200F\u200B\u202E\u206B\u200B\u202B\u206E\u202D\u200F\u206D\u200E\u206A\u200E\u200C\u206B\u202B\u206A\u202C\u206E\u200D\u202A\u206F\u202E\u202A\u202A\u206B\u202E(CS$<>8__locals1.player)));
							goto IL_1A9C;
						}
						case 31U:
						{
							float num21;
							this.DrawSkeleton(CS$<>8__locals1.player, num21, cachedCamera);
							num20 = (num2 * 4280069419U ^ 1044291941U);
							continue;
						}
						case 32U:
							num20 = (((!ESP.\u206E\u200B\u202A\u206C\u200B\u200B\u200C\u200E\u206A\u202B\u206E\u202B\u200F\u206C\u206A\u202D\u200B\u206F\u206F\u206F\u200F\u206B\u200E\u200B\u200F\u202D\u200F\u202E\u202D\u206A\u206C\u206B\u200B\u200E\u202C\u200E\u200B\u206C\u202D\u206B\u202E(ESP.\u202E\u206C\u206C\u206C\u206E\u206C\u206F\u206D\u202B\u200F\u200B\u202D\u202B\u200D\u200D\u202E\u206A\u202C\u200B\u206D\u200B\u200E\u206A\u202C\u206B\u202D\u202C\u206A\u206D\u202E\u200C\u206D\u206D\u202D\u206F\u200C\u206F\u206D\u200C\u200E\u202E(CS$<>8__locals1.player))) ? 1768398465U : 1266237853U) ^ num2 * 3575760757U);
							continue;
						case 33U:
						{
							float num21;
							Vector3 worldPos;
							this.DrawPlayerInfoText(CS$<>8__locals1.player, worldPos, num21, cachedCamera);
							num20 = (num2 * 192907468U ^ 1486690929U);
							continue;
						}
						case 34U:
						{
							Vector3 vector11;
							float num21 = this.entities.DistanceToLocal(vector11);
							num20 = (((num21 > this.maxDistance) ? 3471189387U : 2355354428U) ^ num2 * 1953056623U);
							continue;
						}
						case 35U:
						{
							Color color4;
							color4..ctor(1f, 0.2f, 0.2f, 0.92f);
							num20 = 303113538U;
							continue;
						}
						}
						goto Block_88;
						IL_1649:
						num23 = num22;
						num20 = 1747471213U;
						continue;
						IL_17F0:
						num20 = ((!flag3) ? 965619429U : 1465650890U);
						continue;
						IL_1A9C:
						worldPos2 = vector12;
						num20 = 1735868674U;
					}
				}
				Block_88:;
			}
		}

		// Token: 0x06000096 RID: 150 RVA: 0x0000B6A0 File Offset: 0x000098A0
		private void DrawObjectText(Vector3 screen, string text, Color color)
		{
			if (screen.z <= 0.05f)
			{
				goto IL_0D;
			}
			goto IL_73;
			uint num2;
			Vector2 vector;
			float num3;
			for (;;)
			{
				IL_12:
				uint num;
				switch ((num = (num2 ^ 4026322979U)) % 7U)
				{
				case 0U:
					ESP.\u206A\u206B\u206E\u206D\u206D\u200B\u202D\u202B\u202B\u202D\u200B\u206F\u200C\u206E\u202E\u200B\u206A\u202D\u206F\u206C\u206E\u202B\u200D\u202B\u206E\u206D\u200E\u206A\u206E\u200E\u200D\u200E\u206A\u206B\u206B\u200D\u202D\u202E\u202E\u200D\u202E(new Color(0f, 0f, 0f, 0.9f));
					ESP.\u200D\u206C\u206F\u200C\u206F\u202D\u206C\u202B\u202B\u202C\u202B\u200D\u206E\u200D\u206B\u200C\u200B\u202E\u200F\u200C\u206F\u206B\u202C\u202A\u206D\u200D\u206A\u202B\u206E\u202A\u200C\u202E\u202B\u200F\u200D\u202E\u202B\u202B\u206B\u206E\u202E(new Rect(screen.x - vector.x / 2f - 1f, num3 - 1f, vector.x, vector.y), text, this.objectTextStyle);
					num2 = (num * 573407862U ^ 3791282043U);
					continue;
				case 1U:
					return;
				case 2U:
					goto IL_73;
				case 4U:
					vector = ESP.\u206F\u202B\u202E\u202E\u202B\u202A\u202C\u200C\u200F\u206D\u206A\u200D\u206B\u202A\u202E\u206D\u206F\u202C\u206C\u202E\u206C\u206B\u200B\u202E\u206D\u202A\u206E\u202B\u200E\u206A\u200E\u200B\u202B\u206B\u206B\u206D\u206F\u206A\u206B\u200D\u202E(this.objectTextStyle, ESP.\u200F\u206B\u206D\u206F\u206F\u202A\u202C\u202B\u206A\u206B\u202A\u200F\u202D\u200E\u206E\u200F\u206F\u200D\u202C\u202E\u200E\u200C\u202C\u206B\u206F\u202A\u206E\u202B\u202B\u206C\u202A\u202B\u200D\u202C\u202A\u200D\u202D\u206B\u202E\u206D\u202E(text));
					num2 = (num * 3979487578U ^ 970958749U);
					continue;
				case 5U:
					goto IL_0D;
				case 6U:
					num3 = (float)ESP.\u202C\u206B\u202C\u206A\u200D\u202E\u206F\u200F\u202B\u200B\u202D\u202E\u206E\u206D\u206E\u206D\u206D\u206B\u206B\u200E\u206C\u206F\u200F\u206D\u206B\u200C\u200D\u206F\u206E\u200C\u202B\u206C\u200B\u202E\u200E\u200F\u206F\u200D\u206B\u206B\u202E() - screen.y - 10f;
					num2 = (num * 2667644458U ^ 35926031U);
					continue;
				}
				break;
			}
			ESP.\u206A\u206B\u206E\u206D\u206D\u200B\u202D\u202B\u202B\u202D\u200B\u206F\u200C\u206E\u202E\u200B\u206A\u202D\u206F\u206C\u206E\u202B\u200D\u202B\u206E\u206D\u200E\u206A\u206E\u200E\u200D\u200E\u206A\u206B\u206B\u200D\u202D\u202E\u202E\u200D\u202E(color);
			ESP.\u200D\u206C\u206F\u200C\u206F\u202D\u206C\u202B\u202B\u202C\u202B\u200D\u206E\u200D\u206B\u200C\u200B\u202E\u200F\u200C\u206F\u206B\u202C\u202A\u206D\u200D\u206A\u202B\u206E\u202A\u200C\u202E\u202B\u200F\u200D\u202E\u202B\u202B\u206B\u206E\u202E(new Rect(screen.x - vector.x / 2f, num3, vector.x, vector.y), text, this.objectTextStyle);
			return;
			IL_0D:
			num2 = 3186633390U;
			goto IL_12;
			IL_73:
			ESP.\u200C\u202B\u202B\u202A\u206B\u202B\u200C\u202D\u206D\u206E\u202E\u206B\u202B\u200D\u206A\u200C\u206C\u200B\u200F\u202E\u206F\u200E\u200B\u206E\u200F\u206A\u200D\u206D\u206C\u200C\u200E\u200C\u206F\u202A\u200D\u200C\u206E\u202C\u202E\u206D\u202E(ESP.\u200C\u202D\u202B\u206E\u200F\u202E\u206C\u202E\u200B\u206C\u202D\u202D\u202B\u202A\u206F\u206B\u206E\u202C\u200D\u206D\u206E\u202B\u200C\u206E\u202C\u200B\u206E\u206A\u206A\u206B\u206F\u202A\u206B\u200C\u206D\u200D\u200D\u202B\u206C\u202E(this.objectTextStyle), color);
			num2 = 3012660393U;
			goto IL_12;
		}

		// Token: 0x06000097 RID: 151 RVA: 0x0000B804 File Offset: 0x00009A04
		private Texture2D GetItemIcon(ushort id, byte quality, byte[] state)
		{
			ushort id;
			for (;;)
			{
				IL_06:
				uint num = 4148460545U;
				for (;;)
				{
					uint num2;
					switch ((num2 = (num ^ 4149517684U)) % 6U)
					{
					case 0U:
						goto IL_06;
					case 1U:
						id = id2;
						num = (num2 * 2513598233U ^ 768797292U);
						continue;
					case 3U:
					{
						Texture2D texture2D;
						num = (((!ESP.\u200E\u202D\u202D\u200C\u206F\u206A\u202A\u200B\u202B\u202B\u200E\u206C\u202D\u200F\u202C\u206C\u200D\u206E\u200C\u202D\u206D\u206F\u200E\u200C\u202D\u200F\u202B\u202D\u202D\u200D\u200F\u206C\u206B\u200B\u202A\u206C\u200E\u200B\u200D\u206F\u202E(texture2D, null)) ? 3696854467U : 2353211075U) ^ num2 * 186052665U);
						continue;
					}
					case 4U:
					{
						Texture2D texture2D;
						return texture2D;
					}
					case 5U:
					{
						Texture2D texture2D;
						num = ((ESP.itemIconCache.TryGetValue(id, out texture2D) ? 605525659U : 373901652U) ^ num2 * 2391850480U);
						continue;
					}
					}
					goto Block_1;
				}
			}
			Block_1:
			ESP.\u200D\u206C\u202A\u200D\u202B\u200F\u206D\u202A\u206A\u202C\u200F\u206B\u206E\u200C\u206C\u206D\u206E\u202B\u206D\u206A\u202D\u206C\u200C\u206E\u206C\u200C\u206D\u206D\u202A\u200E\u202E\u200B\u202E\u200E\u206D\u206D\u200D\u200C\u202E\u202E\u202E(id, quality, state, delegate(int handle, Texture2D texture)
			{
				if (ESP.<>c__DisplayClass54_0.\u200C\u200D\u202B\u200B\u206B\u200C\u206C\u202E\u200F\u206A\u200C\u202E\u200F\u206E\u200F\u206D\u200F\u202A\u200D\u202E\u202B\u202A\u200D\u202B\u200E\u202E\u202D\u200F\u200F\u202B\u202C\u200E\u206A\u200F\u200D\u202D\u206F\u202B\u206F\u200E\u202E(texture, null))
				{
					for (;;)
					{
						IL_09:
						uint num3 = 2477342142U;
						for (;;)
						{
							uint num4;
							switch ((num4 = (num3 ^ 2781552787U)) % 4U)
							{
							case 1U:
								num3 = ((ESP.itemIconCache.ContainsKey(id) ? 2050703196U : 537031522U) ^ num4 * 919550819U);
								continue;
							case 2U:
								ESP.itemIconCache[id] = texture;
								num3 = (num4 * 3384603360U ^ 2676316027U);
								continue;
							case 3U:
								goto IL_09;
							}
							goto Block_1;
						}
					}
					Block_1:;
				}
			});
			return null;
		}

		// Token: 0x06000098 RID: 152 RVA: 0x0000B8DC File Offset: 0x00009ADC
		private float GetHeadHeight(EPlayerStance stance)
		{
			switch (stance)
			{
			case 1:
			case 5:
				goto IL_62;
			case 2:
			case 3:
				goto IL_6F;
			case 4:
				break;
			default:
				for (;;)
				{
					IL_1C:
					uint num = 4203816915U;
					for (;;)
					{
						uint num2;
						switch ((num2 = (num ^ 2577782897U)) % 5U)
						{
						case 0U:
							goto IL_1C;
						case 1U:
							goto IL_62;
						case 3U:
							num = (num2 * 1582013959U ^ 2041241056U);
							continue;
						case 4U:
							goto IL_55;
						}
						goto Block_1;
					}
				}
				Block_1:
				goto IL_6F;
			}
			IL_55:
			return 1.4f;
			IL_62:
			return 0.4f;
			IL_6F:
			return 1.95f;
		}

		// Token: 0x06000099 RID: 153 RVA: 0x0000B960 File Offset: 0x00009B60
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void DrawPlayerInfoText(Player player, Vector3 worldPos, float distance, Camera cam)
		{
			Vector3 vector = ESP.\u206E\u200B\u206A\u206A\u200B\u206D\u206A\u200B\u202A\u202D\u202E\u206D\u206B\u202E\u202E\u206C\u200D\u200F\u202E\u202C\u202C\u202E\u200B\u200D\u200E\u200F\u202B\u200E\u202E\u200F\u202B\u202E\u200B\u202D\u200B\u200B\u202B\u206A\u200F\u206B\u202E(cam, worldPos);
			string text;
			for (;;)
			{
				IL_09:
				uint num = 3355454784U;
				for (;;)
				{
					uint num2;
					switch ((num2 = (num ^ 3364427154U)) % 7U)
					{
					case 0U:
						return;
					case 1U:
						num = (((vector.z > 0.05f) ? 224900337U : 689083090U) ^ num2 * 4257115763U);
						continue;
					case 2U:
						goto IL_09;
					case 3U:
					{
						string text2;
						text = ESP.\u206E\u206E\u202A\u202A\u206F\u200E\u206D\u206D\u202B\u206C\u200F\u202E\u200C\u206E\u200E\u206F\u200B\u206A\u202C\u206A\u206B\u206D\u200B\u200B\u202A\u206F\u200E\u206D\u206A\u200D\u200D\u206D\u200E\u206A\u206C\u206C\u206C\u200B\u202B\u206D\u202E(text, <Module>.\u206A\u202C\u206A\u206C\u202A\u206F\u200B\u206C\u206C\u206B\u206F\u206C\u200C\u206D\u200C\u200C\u206C\u206A\u202A\u206B\u200B\u202E\u200C\u206E\u202D\u202A\u200E\u202D\u200E\u200E\u200D\u200E\u202B\u202A\u206E\u202A\u200B\u200B\u202D\u202E<string>(-29324631), text2);
						num = 2890139142U;
						continue;
					}
					case 4U:
					{
						SteamChannel steamChannel = ESP.\u200E\u202E\u200F\u202E\u200F\u200C\u200B\u206C\u200D\u202B\u206B\u206B\u200F\u206B\u202D\u206B\u200C\u200C\u206D\u200C\u206F\u200D\u200F\u200F\u200E\u206B\u206C\u202E\u200D\u206D\u202B\u206F\u200F\u200C\u202A\u202B\u206E\u206F\u206D\u206E\u202E(player);
						string text3;
						if (steamChannel == null)
						{
							text3 = null;
						}
						else
						{
							SteamPlayer owner = steamChannel.owner;
							if (owner == null)
							{
								text3 = null;
							}
							else
							{
								SteamPlayerID steamPlayerID = ESP.\u206E\u206B\u206D\u206D\u206D\u206C\u202A\u206D\u206B\u206C\u206B\u202A\u206E\u206F\u202E\u202E\u206A\u206C\u202D\u200B\u206E\u202B\u206B\u202A\u206D\u202A\u202A\u202B\u206E\u202B\u200F\u206A\u202A\u206F\u202A\u200B\u200B\u202C\u206B\u200F\u202E(owner);
								text3 = ((steamPlayerID != null) ? ESP.\u206F\u206F\u206A\u202D\u202C\u200E\u202C\u206E\u200C\u200C\u206B\u200D\u200D\u200E\u202C\u206E\u202D\u206A\u202B\u206A\u206D\u202D\u206D\u202C\u200B\u200C\u200F\u200F\u200B\u206B\u206B\u206C\u202E\u200C\u200F\u202E\u200F\u202A\u206C\u206C\u202E(steamPlayerID) : null);
							}
						}
						string text4 = text3 ?? <Module>.\u202B\u200B\u202C\u206C\u206D\u202C\u206B\u200F\u206D\u206D\u200E\u206A\u202E\u206D\u200D\u206A\u202D\u202B\u200B\u200F\u202C\u206D\u200E\u202D\u200D\u206A\u200F\u206E\u206F\u206F\u200D\u202D\u202C\u200B\u206F\u202C\u202A\u200D\u206E\u202E\u202E<string>(-1208115643);
						string text5 = ESP.\u200E\u200E\u206F\u202B\u206C\u206A\u200B\u200F\u206A\u202C\u206B\u202D\u200B\u200E\u200B\u202B\u202B\u200B\u202B\u206C\u202C\u206A\u206E\u202E\u206D\u202E\u200F\u200D\u206C\u206C\u202E\u206A\u200D\u200D\u202B\u202B\u200B\u206F\u202B\u206D\u202E(Mathf.RoundToInt(distance).ToString(), <Module>.\u202E\u206C\u206E\u202C\u202D\u202D\u206D\u206B\u202B\u206F\u200B\u206E\u200B\u202C\u202A\u200D\u202D\u200B\u202D\u202E\u200D\u206F\u206C\u202C\u200B\u202C\u206D\u202B\u206C\u206E\u200E\u206A\u200D\u206F\u200E\u206E\u206A\u200C\u200D\u206B\u202E<string>(604499582));
						string text2 = <Module>.\u200B\u206C\u200C\u200C\u206A\u200B\u200D\u206C\u206B\u206D\u202B\u200F\u200E\u206E\u206A\u200D\u206B\u202E\u206A\u200E\u200B\u202E\u200F\u206C\u200F\u202A\u202B\u200F\u200D\u200C\u202D\u200E\u206B\u200D\u202A\u200E\u202E\u206A\u202B\u200C\u202E<string>(1094971455);
						PlayerEquipment playerEquipment = ESP.\u200E\u206F\u202C\u206C\u202E\u200E\u206B\u200C\u206A\u200E\u206F\u206E\u206E\u202C\u202D\u200F\u202E\u202E\u200C\u206B\u206A\u202B\u206E\u200B\u200C\u206B\u202E\u202B\u206C\u202B\u200E\u206E\u202C\u206A\u200B\u200F\u200B\u206E\u202C\u202E\u202E(player);
						if (((playerEquipment != null) ? ESP.\u206B\u206B\u206F\u202B\u200E\u200C\u200E\u202A\u206F\u206F\u202D\u202A\u206C\u200C\u206C\u202E\u206A\u202C\u202D\u200F\u202B\u206E\u202B\u206F\u206C\u200C\u202E\u202C\u200B\u202E\u200B\u202B\u206F\u200F\u202B\u200C\u206F\u202B\u202D\u200F\u202E(playerEquipment) : null) != null)
						{
							text2 = ESP.\u206B\u200C\u206F\u202D\u202E\u202B\u202E\u200C\u206B\u200C\u202C\u200E\u202B\u200B\u200D\u202D\u202B\u202B\u206E\u206F\u200E\u206C\u202A\u202A\u206A\u206D\u200D\u200C\u200C\u202D\u202D\u206E\u202A\u200C\u202C\u200B\u202C\u206C\u206B\u202A\u202E(ESP.\u200B\u202B\u200C\u200B\u200B\u200B\u206D\u202C\u206E\u200F\u202E\u200C\u202D\u202C\u206A\u200F\u206E\u202B\u200F\u200E\u200F\u202C\u200E\u206F\u200E\u200C\u206D\u202D\u206D\u202A\u200C\u206F\u200E\u200E\u206F\u200E\u202C\u202B\u200C\u202D\u202E(ESP.\u200E\u206F\u202C\u206C\u202E\u200E\u206B\u200C\u206A\u200E\u206F\u206E\u206E\u202C\u202D\u200F\u202E\u202E\u200C\u206B\u206A\u202B\u206E\u200B\u200C\u206B\u202E\u202B\u206C\u202B\u200E\u206E\u202C\u206A\u200B\u200F\u200B\u206E\u202C\u202E\u202E(player)));
							if (ESP.\u206D\u200E\u206F\u206B\u206E\u202A\u206D\u202A\u206B\u202D\u200E\u200D\u206F\u206E\u206C\u206D\u200F\u206D\u202E\u202D\u200C\u206C\u206B\u206F\u200F\u206B\u206A\u206A\u202C\u200E\u206B\u202D\u206E\u206B\u206A\u202A\u206B\u200B\u206A\u202D\u202E(text2) > 18)
							{
								text2 = ESP.\u200E\u200E\u206F\u202B\u206C\u206A\u200B\u200F\u206A\u202C\u206B\u202D\u200B\u200E\u200B\u202B\u202B\u200B\u202B\u206C\u202C\u206A\u206E\u202E\u206D\u202E\u200F\u200D\u206C\u206C\u202E\u206A\u200D\u200D\u202B\u202B\u200B\u206F\u202B\u206D\u202E(ESP.\u202E\u202B\u202B\u206D\u202E\u202C\u206A\u206D\u202D\u200F\u202E\u206D\u202D\u206A\u200E\u202D\u202B\u202D\u206B\u206C\u206F\u200E\u202C\u200D\u200D\u200F\u202B\u200F\u200F\u206A\u200C\u200F\u200B\u206E\u206D\u202C\u202B\u200D\u206F\u202E(text2, 0, 15), <Module>.\u206A\u202C\u206A\u206C\u202A\u206F\u200B\u206C\u206C\u206B\u206F\u206C\u200C\u206D\u200C\u200C\u206C\u206A\u202A\u206B\u200B\u202E\u200C\u206E\u202D\u202A\u200E\u202D\u200E\u200E\u200D\u200E\u202B\u202A\u206E\u202A\u200B\u200B\u202D\u202E<string>(1550867136));
							}
						}
						text = ESP.\u206E\u206E\u202A\u202A\u206F\u200E\u206D\u206D\u202B\u206C\u200F\u202E\u200C\u206E\u200E\u206F\u200B\u206A\u202C\u206A\u206B\u206D\u200B\u200B\u202A\u206F\u200E\u206D\u206A\u200D\u200D\u206D\u200E\u206A\u206C\u206C\u206C\u200B\u202B\u206D\u202E(text4, <Module>.\u206A\u202C\u206A\u206C\u202A\u206F\u200B\u206C\u206C\u206B\u206F\u206C\u200C\u206D\u200C\u200C\u206C\u206A\u202A\u206B\u200B\u202E\u200C\u206E\u202D\u202A\u200E\u202D\u200E\u200E\u200D\u200E\u202B\u202A\u206E\u202A\u200B\u200B\u202D\u202E<string>(497405958), text5);
						num = 4073815561U;
						continue;
					}
					case 5U:
						num = (((!this.infoTextShowWeapon) ? 2571562219U : 2429638866U) ^ num2 * 1097318423U);
						continue;
					}
					goto Block_1;
				}
			}
			Block_1:
			ESP.\u206D\u202B\u206E\u200F\u202D\u200F\u202B\u200F\u202D\u206F\u200B\u200B\u202D\u206C\u200C\u200D\u206F\u206C\u202B\u202E\u200F\u200B\u202D\u200F\u206C\u200B\u206D\u206A\u200F\u206D\u202B\u202B\u206F\u200C\u206C\u206B\u202A\u202A\u202B\u202E(this.playerInfoTextStyle, this.infoTextSize);
			Vector2 vector2 = ESP.\u206F\u202B\u202E\u202E\u202B\u202A\u202C\u200C\u200F\u206D\u206A\u200D\u206B\u202A\u202E\u206D\u206F\u202C\u206C\u202E\u206C\u206B\u200B\u202E\u206D\u202A\u206E\u202B\u200E\u206A\u200E\u200B\u202B\u206B\u206B\u206D\u206F\u206A\u206B\u200D\u202E(this.playerInfoTextStyle, ESP.\u200F\u206B\u206D\u206F\u206F\u202A\u202C\u202B\u206A\u206B\u202A\u200F\u202D\u200E\u206E\u200F\u206F\u200D\u202C\u202E\u200E\u200C\u202C\u206B\u206F\u202A\u206E\u202B\u202B\u206C\u202A\u202B\u200D\u202C\u202A\u200D\u202D\u206B\u202E\u206D\u202E(text));
			float num3 = vector.x - vector2.x / 2f;
			float num4 = (float)ESP.\u202C\u206B\u202C\u206A\u200D\u202E\u206F\u200F\u202B\u200B\u202D\u202E\u206E\u206D\u206E\u206D\u206D\u206B\u206B\u200E\u206C\u206F\u200F\u206D\u206B\u200C\u200D\u206F\u206E\u200C\u202B\u206C\u200B\u202E\u200E\u200F\u206F\u200D\u206B\u206B\u202E() - vector.y - 5f;
			ESP.\u206A\u206B\u206E\u206D\u206D\u200B\u202D\u202B\u202B\u202D\u200B\u206F\u200C\u206E\u202E\u200B\u206A\u202D\u206F\u206C\u206E\u202B\u200D\u202B\u206E\u206D\u200E\u206A\u206E\u200E\u200D\u200E\u206A\u206B\u206B\u200D\u202D\u202E\u202E\u200D\u202E(ESP.COLOR_TEXT_SHADOW);
			ESP.\u200D\u206C\u206F\u200C\u206F\u202D\u206C\u202B\u202B\u202C\u202B\u200D\u206E\u200D\u206B\u200C\u200B\u202E\u200F\u200C\u206F\u206B\u202C\u202A\u206D\u200D\u206A\u202B\u206E\u202A\u200C\u202E\u202B\u200F\u200D\u202E\u202B\u202B\u206B\u206E\u202E(new Rect(num3 - 1f, num4 - 1f, vector2.x + 2f, vector2.y + 2f), text, this.playerInfoTextStyle);
			ESP.\u206A\u206B\u206E\u206D\u206D\u200B\u202D\u202B\u202B\u202D\u200B\u206F\u200C\u206E\u202E\u200B\u206A\u202D\u206F\u206C\u206E\u202B\u200D\u202B\u206E\u206D\u200E\u206A\u206E\u200E\u200D\u200E\u206A\u206B\u206B\u200D\u202D\u202E\u202E\u200D\u202E(ESP.COLOR_TEXT);
			ESP.\u200D\u206C\u206F\u200C\u206F\u202D\u206C\u202B\u202B\u202C\u202B\u200D\u206E\u200D\u206B\u200C\u200B\u202E\u200F\u200C\u206F\u206B\u202C\u202A\u206D\u200D\u206A\u202B\u206E\u202A\u200C\u202E\u202B\u200F\u200D\u202E\u202B\u202B\u206B\u206E\u202E(new Rect(num3, num4, vector2.x, vector2.y), text, this.playerInfoTextStyle);
		}

		// Token: 0x0600009A RID: 154 RVA: 0x0000BBB8 File Offset: 0x00009DB8
		private void DrawPlayerBox(Player player, float distance, Camera cam)
		{
			Vector3 vector = ESP.\u206B\u202A\u206E\u200C\u202B\u200D\u206D\u200C\u206A\u202B\u202B\u200C\u200D\u200D\u202E\u206B\u202C\u200D\u202E\u202B\u206B\u200D\u202B\u200D\u200C\u200C\u206D\u200D\u200B\u206C\u200C\u200E\u202C\u202C\u206C\u202B\u206E\u200D\u202E\u206B\u202E(ESP.\u200E\u202D\u200C\u206D\u202D\u200B\u202C\u202E\u206F\u202C\u200B\u206E\u206D\u200C\u200E\u200F\u200C\u200E\u200B\u200F\u200C\u202B\u200C\u202E\u200C\u202A\u202B\u200B\u206A\u206A\u206E\u206A\u202B\u202B\u202A\u202A\u206C\u202E\u200D\u206F\u202E(player));
			Vector3 vector2 = vector;
			EPlayerStance eplayerStance = ESP.\u206F\u206F\u202B\u200C\u206D\u200E\u206F\u206B\u206B\u206D\u202C\u206F\u202A\u206F\u202D\u206D\u206A\u200D\u202B\u202B\u206E\u206B\u206D\u206E\u202C\u200F\u206E\u206F\u206F\u202C\u206E\u202E\u200D\u206B\u206D\u206C\u200D\u202B\u206A\u202E(ESP.\u206A\u200E\u206B\u200B\u206F\u202B\u206C\u200C\u200F\u206E\u200D\u206B\u202A\u202A\u200F\u200B\u202E\u206B\u200B\u202B\u206E\u202D\u200F\u206D\u200E\u206A\u200E\u200C\u206B\u202B\u206A\u202C\u206E\u200D\u202A\u206F\u202E\u202A\u202A\u206B\u202E(player));
			if (eplayerStance == 4)
			{
				goto IL_21;
			}
			goto IL_1AB;
			uint num2;
			for (;;)
			{
				IL_26:
				uint num;
				switch ((num = (num2 ^ 1809841166U)) % 15U)
				{
				case 0U:
					num2 = (((eplayerStance == 1) ? 2452606875U : 3195409160U) ^ num * 2096885625U);
					continue;
				case 1U:
				{
					Vector3 vector3;
					num2 = (((vector3.z > 0.05f) ? 2320475252U : 2952034790U) ^ num * 1844939854U);
					continue;
				}
				case 2U:
				{
					Vector3 vector4;
					num2 = (((vector4.z > 0.05f) ? 3579707644U : 3093844406U) ^ num * 3430929291U);
					continue;
				}
				case 3U:
				{
					Vector3 vector3;
					Vector3 vector4;
					float num3 = Mathf.Abs((float)ESP.\u202C\u206B\u202C\u206A\u200D\u202E\u206F\u200F\u202B\u200B\u202D\u202E\u206E\u206D\u206E\u206D\u206D\u206B\u206B\u200E\u206C\u206F\u200F\u206D\u206B\u200C\u200D\u206F\u206E\u200C\u202B\u206C\u200B\u202E\u200E\u200F\u206F\u200D\u206B\u206B\u202E() - vector4.y - ((float)ESP.\u202C\u206B\u202C\u206A\u200D\u202E\u206F\u200F\u202B\u200B\u202D\u202E\u206E\u206D\u206E\u206D\u206D\u206B\u206B\u200E\u206C\u206F\u200F\u206D\u206B\u200C\u200D\u206F\u206E\u200C\u202B\u206C\u200B\u202E\u200E\u200F\u206F\u200D\u206B\u206B\u202E() - vector3.y));
					num2 = 1461375280U;
					continue;
				}
				case 4U:
				{
					float num3;
					float num4 = num3 * 0.55f;
					num2 = (num * 1548771629U ^ 3859813648U);
					continue;
				}
				case 5U:
				{
					Vector3 vector5 = vector + Vector3.up * 1.4f;
					num2 = (num * 406884876U ^ 1651907305U);
					continue;
				}
				case 6U:
				{
					Vector3 vector5 = vector + Vector3.up * 1.95f;
					num2 = 1787838149U;
					continue;
				}
				case 7U:
				{
					Vector3 vector5 = vector + Vector3.up * 0.4f;
					num2 = 324989383U;
					continue;
				}
				case 8U:
					return;
				case 10U:
					goto IL_21;
				case 11U:
					goto IL_1AB;
				case 12U:
				{
					Vector3 vector5;
					Vector3 vector4 = ESP.\u206E\u200B\u206A\u206A\u200B\u206D\u206A\u200B\u202A\u202D\u202E\u206D\u206B\u202E\u202E\u206C\u200D\u200F\u202E\u202C\u202C\u202E\u200B\u200D\u200E\u200F\u202B\u200E\u202E\u200F\u202B\u202E\u200B\u202D\u200B\u200B\u202B\u206A\u200F\u206B\u202E(cam, vector5);
					Vector3 vector3 = ESP.\u206E\u200B\u206A\u206A\u200B\u206D\u206A\u200B\u202A\u202D\u202E\u206D\u206B\u202E\u202E\u206C\u200D\u200F\u202E\u202C\u202C\u202E\u200B\u200D\u200E\u200F\u202B\u200E\u202E\u200F\u202B\u202E\u200B\u202D\u200B\u200B\u202B\u206A\u200F\u206B\u202E(cam, vector2);
					num2 = 1489662242U;
					continue;
				}
				case 13U:
					num2 = (num * 1751847856U ^ 3176291317U);
					continue;
				case 14U:
				{
					Vector3 vector4;
					float num4;
					float x = vector4.x - num4 / 2f;
					float y = (float)ESP.\u202C\u206B\u202C\u206A\u200D\u202E\u206F\u200F\u202B\u200B\u202D\u202E\u206E\u206D\u206E\u206D\u206D\u206B\u206B\u200E\u206C\u206F\u200F\u206D\u206B\u200C\u200D\u206F\u206E\u200C\u202B\u206C\u200B\u202E\u200E\u200F\u206F\u200D\u206B\u206B\u202E() - vector4.y;
					float num3;
					Utils.DrawBox(x, y, num4, num3, 2f, ESP.COLOR_BOX);
					num2 = (num * 3114025399U ^ 760092067U);
					continue;
				}
				}
				break;
			}
			return;
			IL_21:
			num2 = 1132252887U;
			goto IL_26;
			IL_1AB:
			num2 = ((eplayerStance == 5) ? 1758484697U : 671689436U);
			goto IL_26;
		}

		// Token: 0x0600009B RID: 155 RVA: 0x0000BE00 File Offset: 0x0000A000
		private void DrawSkeleton(Player p, float distance, Camera cam)
		{
			Transform limb = Utils.GetLimb(ESP.\u200E\u202D\u200C\u206D\u202D\u200B\u202C\u202E\u206F\u202C\u200B\u206E\u206D\u200C\u200E\u200F\u200C\u200E\u200B\u200F\u200C\u202B\u200C\u202E\u200C\u202A\u202B\u200B\u206A\u206A\u206E\u206A\u202B\u202B\u202A\u202A\u206C\u202E\u200D\u206F\u202E(p), 12);
			if (ESP.\u200D\u200E\u202A\u200E\u206F\u202E\u206D\u200D\u200C\u206F\u200F\u206A\u206B\u202C\u200B\u202C\u206D\u200F\u200E\u206A\u202E\u206D\u206E\u206B\u206C\u200B\u206E\u206A\u200F\u206B\u200F\u202A\u206C\u202E\u200C\u202D\u200C\u202C\u206F\u202D\u202E(limb, null))
			{
				goto IL_1A;
			}
			goto IL_A6;
			uint num2;
			Vector3 vector;
			for (;;)
			{
				IL_1F:
				uint num;
				switch ((num = (num2 ^ 3286234854U)) % 8U)
				{
				case 0U:
					goto IL_1A;
				case 1U:
				{
					this.DrawBoneFromPoint(vector, 3, p, distance, cam);
					Transform limb2 = Utils.GetLimb(ESP.\u200E\u202D\u200C\u206D\u202D\u200B\u202C\u202E\u206F\u202C\u200B\u206E\u206D\u200C\u200E\u200F\u200C\u200E\u200B\u200F\u200C\u202B\u200C\u202E\u200C\u202A\u202B\u200B\u206A\u206A\u206E\u206A\u202B\u202B\u202A\u202A\u206C\u202E\u200D\u206F\u202E(p), 3);
					this.DrawBoneFromPoint((limb2 != null) ? ESP.\u200E\u200F\u206E\u206B\u202C\u200B\u202C\u206F\u200E\u200E\u200D\u200B\u202D\u202A\u200E\u202E\u200C\u200B\u206B\u200E\u200D\u200B\u206C\u206E\u202E\u202C\u206D\u206A\u206B\u206E\u200D\u200D\u200C\u202C\u206D\u202C\u200D\u200B\u206A\u202C\u202E(limb2) : vector, 2, p, distance, cam);
					num2 = 2440949276U;
					continue;
				}
				case 3U:
					this.DrawBoneFromPoint(vector, 5, p, distance, cam);
					num2 = (num * 2945964752U ^ 3898031664U);
					continue;
				case 4U:
				{
					this.DrawBoneFromPoint(vector, 1, p, distance, cam);
					Transform limb3 = Utils.GetLimb(ESP.\u200E\u202D\u200C\u206D\u202D\u200B\u202C\u202E\u206F\u202C\u200B\u206E\u206D\u200C\u200E\u200F\u200C\u200E\u200B\u200F\u200C\u202B\u200C\u202E\u200C\u202A\u202B\u200B\u206A\u206A\u206E\u206A\u202B\u202B\u202A\u202A\u206C\u202E\u200D\u206F\u202E(p), 1);
					this.DrawBoneFromPoint((limb3 != null) ? ESP.\u200E\u200F\u206E\u206B\u202C\u200B\u202C\u206F\u200E\u200E\u200D\u200B\u202D\u202A\u200E\u202E\u200C\u200B\u206B\u200E\u200D\u200B\u206C\u206E\u202E\u202C\u206D\u206A\u206B\u206E\u200D\u200D\u200C\u202C\u206D\u202C\u200D\u200B\u206A\u202C\u202E(limb3) : vector, 0, p, distance, cam);
					num2 = 2265492375U;
					continue;
				}
				case 5U:
					goto IL_A6;
				case 6U:
				{
					Transform limb4 = Utils.GetLimb(ESP.\u200E\u202D\u200C\u206D\u202D\u200B\u202C\u202E\u206F\u202C\u200B\u206E\u206D\u200C\u200E\u200F\u200C\u200E\u200B\u200F\u200C\u202B\u200C\u202E\u200C\u202A\u202B\u200B\u206A\u206A\u206E\u206A\u202B\u202B\u202A\u202A\u206C\u202E\u200D\u206F\u202E(p), 5);
					this.DrawBoneFromPoint((limb4 != null) ? ESP.\u200E\u200F\u206E\u206B\u202C\u200B\u202C\u206F\u200E\u200E\u200D\u200B\u202D\u202A\u200E\u202E\u200C\u200B\u206B\u200E\u200D\u200B\u206C\u206E\u202E\u202C\u206D\u206A\u206B\u206E\u200D\u200D\u200C\u202C\u206D\u202C\u200D\u200B\u206A\u202C\u202E(limb4) : vector, 4, p, distance, cam);
					this.DrawBoneFromPoint(vector, 7, p, distance, cam);
					Transform limb5 = Utils.GetLimb(ESP.\u200E\u202D\u200C\u206D\u202D\u200B\u202C\u202E\u206F\u202C\u200B\u206E\u206D\u200C\u200E\u200F\u200C\u200E\u200B\u200F\u200C\u202B\u200C\u202E\u200C\u202A\u202B\u200B\u206A\u206A\u206E\u206A\u202B\u202B\u202A\u202A\u206C\u202E\u200D\u206F\u202E(p), 7);
					this.DrawBoneFromPoint((limb5 != null) ? ESP.\u200E\u200F\u206E\u206B\u202C\u200B\u202C\u206F\u200E\u200E\u200D\u200B\u202D\u202A\u200E\u202E\u200C\u200B\u206B\u200E\u200D\u200B\u206C\u206E\u202E\u202C\u206D\u206A\u206B\u206E\u200D\u200D\u200C\u202C\u206D\u202C\u200D\u200B\u206A\u202C\u202E(limb5) : vector, 6, p, distance, cam);
					num2 = 3573073082U;
					continue;
				}
				case 7U:
					return;
				}
				break;
			}
			return;
			IL_1A:
			num2 = 3393846425U;
			goto IL_1F;
			IL_A6:
			Vector3 vector2 = ESP.\u206B\u202A\u206E\u200C\u202B\u200D\u206D\u200C\u206A\u202B\u202B\u200C\u200D\u200D\u202E\u206B\u202C\u200D\u202E\u202B\u206B\u200D\u202B\u200D\u200C\u200C\u206D\u200D\u200B\u206C\u200C\u200E\u202C\u202C\u206C\u202B\u206E\u200D\u202E\u206B\u202E(limb);
			EPlayerStance eplayerStance = ESP.\u206F\u206F\u202B\u200C\u206D\u200E\u206F\u206B\u206B\u206D\u202C\u206F\u202A\u206F\u202D\u206D\u206A\u200D\u202B\u202B\u206E\u206B\u206D\u206E\u202C\u200F\u206E\u206F\u206F\u202C\u206E\u202E\u200D\u206B\u206D\u206C\u200D\u202B\u206A\u202E(ESP.\u206A\u200E\u206B\u200B\u206F\u202B\u206C\u200C\u200F\u206E\u200D\u206B\u202A\u202A\u200F\u200B\u202E\u206B\u200B\u202B\u206E\u202D\u200F\u206D\u200E\u206A\u200E\u200C\u206B\u202B\u206A\u202C\u206E\u200D\u202A\u206F\u202E\u202A\u202A\u206B\u202E(p));
			float num3 = (eplayerStance == 3 || eplayerStance == 2) ? 1f : ((eplayerStance == 4) ? 0.75f : ((eplayerStance == 5 || eplayerStance == 1) ? 0f : 0.8f));
			vector = vector2 + Vector3.up * num3;
			num2 = 4179569733U;
			goto IL_1F;
		}

		// Token: 0x0600009C RID: 156 RVA: 0x0000BFB4 File Offset: 0x0000A1B4
		private void DrawBoneFromPoint(Vector3 startPos, ELimb limb, Player p, float distance, Camera cam)
		{
			Transform limb2 = Utils.GetLimb(ESP.\u200E\u202D\u200C\u206D\u202D\u200B\u202C\u202E\u206F\u202C\u200B\u206E\u206D\u200C\u200E\u200F\u200C\u200E\u200B\u200F\u200C\u202B\u200C\u202E\u200C\u202A\u202B\u200B\u206A\u206A\u206E\u206A\u202B\u202B\u202A\u202A\u206C\u202E\u200D\u206F\u202E(p), limb);
			if (ESP.\u200D\u200E\u202A\u200E\u206F\u202E\u206D\u200D\u200C\u206F\u200F\u206A\u206B\u202C\u200B\u202C\u206D\u200F\u200E\u206A\u202E\u206D\u206E\u206B\u206C\u200B\u206E\u206A\u200F\u206B\u200F\u202A\u206C\u202E\u200C\u202D\u200C\u202C\u206F\u202D\u202E(limb2, null))
			{
				goto IL_19;
			}
			goto IL_194;
			uint num2;
			Vector3 vector;
			Color color;
			Vector3 vector3;
			float thickness;
			for (;;)
			{
				IL_1E:
				uint num;
				switch ((num = (num2 ^ 3138734045U)) % 13U)
				{
				case 0U:
					vector = ESP.\u206E\u200B\u206A\u206A\u200B\u206D\u206A\u200B\u202A\u202D\u202E\u206D\u206B\u202E\u202E\u206C\u200D\u200F\u202E\u202C\u202C\u202E\u200B\u200D\u200E\u200F\u202B\u200E\u202E\u200F\u202B\u202E\u200B\u202D\u200B\u200B\u202B\u206A\u200F\u206B\u202E(cam, startPos);
					num2 = (num * 3923683784U ^ 21355374U);
					continue;
				case 1U:
					return;
				case 2U:
					goto IL_19;
				case 3U:
				{
					float num3 = Mathf.Clamp01(1.3f - distance / 1000f);
					color..ctor(ESP.COLOR_SKELETON.r, ESP.COLOR_SKELETON.g, ESP.COLOR_SKELETON.b, num3 * ESP.COLOR_SKELETON.a);
					num2 = (num * 2223861978U ^ 562574896U);
					continue;
				}
				case 4U:
				{
					Vector3 vector2 = ESP.\u206B\u202A\u206E\u200C\u202B\u200D\u206D\u200C\u206A\u202B\u202B\u200C\u200D\u200D\u202E\u206B\u202C\u200D\u202E\u202B\u206B\u200D\u202B\u200D\u200C\u200C\u206D\u200D\u200B\u206C\u200C\u200E\u202C\u202C\u206C\u202B\u206E\u200D\u202E\u206B\u202E(limb2);
					num2 = (num * 1762590356U ^ 3181908427U);
					continue;
				}
				case 5U:
					vector3.y = (float)ESP.\u202C\u206B\u202C\u206A\u200D\u202E\u206F\u200F\u202B\u200B\u202D\u202E\u206E\u206D\u206E\u206D\u206D\u206B\u206B\u200E\u206C\u206F\u200F\u206D\u206B\u200C\u200D\u206F\u206E\u200C\u202B\u206C\u200B\u202E\u200E\u200F\u206F\u200D\u206B\u206B\u202E() - vector3.y;
					num2 = (num * 3355563592U ^ 3575970938U);
					continue;
				case 6U:
				{
					Vector3 vector2;
					vector3 = ESP.\u206E\u200B\u206A\u206A\u200B\u206D\u206A\u200B\u202A\u202D\u202E\u206D\u206B\u202E\u202E\u206C\u200D\u200F\u202E\u202C\u202C\u202E\u200B\u200D\u200E\u200F\u202B\u200E\u202E\u200F\u202B\u202E\u200B\u202D\u200B\u200B\u202B\u206A\u200F\u206B\u202E(cam, vector2);
					num2 = (((vector.z > 0.05f) ? 2202028982U : 2456909556U) ^ num * 492563188U);
					continue;
				}
				case 7U:
					return;
				case 9U:
					thickness = Mathf.Lerp(0.8f, 2.2f, Mathf.Clamp01(1f - distance / 1200f));
					num2 = (num * 3225873656U ^ 3897517061U);
					continue;
				case 10U:
					goto IL_194;
				case 11U:
					vector.y = (float)ESP.\u202C\u206B\u202C\u206A\u200D\u202E\u206F\u200F\u202B\u200B\u202D\u202E\u206E\u206D\u206E\u206D\u206D\u206B\u206B\u200E\u206C\u206F\u200F\u206D\u206B\u200C\u200D\u206F\u206E\u200C\u202B\u206C\u200B\u202E\u200E\u200F\u206F\u200D\u206B\u206B\u202E() - vector.y;
					num2 = 2355335100U;
					continue;
				case 12U:
					num2 = (((vector3.z <= 0.05f) ? 2760226301U : 3190852264U) ^ num * 2917037779U);
					continue;
				}
				break;
			}
			Utils.DrawLine(vector.x, vector.y, vector3.x, vector3.y, thickness, color);
			return;
			IL_19:
			num2 = 3662373643U;
			goto IL_1E;
			IL_194:
			num2 = 4236357770U;
			goto IL_1E;
		}

		// Token: 0x0600009D RID: 157 RVA: 0x0000C1E0 File Offset: 0x0000A3E0
		private Vector3 GetAimPosition(Player target)
		{
			if (this.preferHead)
			{
				goto IL_0B;
			}
			goto IL_156;
			uint num2;
			Transform limb;
			Transform limb2;
			for (;;)
			{
				IL_10:
				uint num;
				switch ((num = (num2 ^ 777711534U)) % 11U)
				{
				case 0U:
				{
					EPlayerStance eplayerStance;
					if (eplayerStance != 2)
					{
						num2 = (num * 2500205151U ^ 1773202566U);
						continue;
					}
					goto IL_C4;
				}
				case 1U:
				{
					EPlayerStance eplayerStance = ESP.\u206F\u206F\u202B\u200C\u206D\u200E\u206F\u206B\u206B\u206D\u202C\u206F\u202A\u206F\u202D\u206D\u206A\u200D\u202B\u202B\u206E\u206B\u206D\u206E\u202C\u200F\u206E\u206F\u206F\u202C\u206E\u202E\u200D\u206B\u206D\u206C\u200D\u202B\u206A\u202E(ESP.\u206A\u200E\u206B\u200B\u206F\u202B\u206C\u200C\u200F\u206E\u200D\u206B\u202A\u202A\u200F\u200B\u202E\u206B\u200B\u202B\u206E\u202D\u200F\u206D\u200E\u206A\u200E\u200C\u206B\u202B\u206A\u202C\u206E\u200D\u202A\u206F\u202E\u202A\u202A\u206B\u202E(target));
					num2 = (num * 1038169247U ^ 3282500712U);
					continue;
				}
				case 2U:
					goto IL_111;
				case 3U:
				{
					EPlayerStance eplayerStance;
					if (eplayerStance != 3)
					{
						num2 = (num * 291988780U ^ 1408859479U);
						continue;
					}
					goto IL_C4;
				}
				case 4U:
					goto IL_0B;
				case 6U:
					goto IL_B6;
				case 7U:
					goto IL_156;
				case 8U:
					num2 = ((ESP.\u200E\u202D\u202D\u200C\u206F\u206A\u202A\u200B\u202B\u202B\u200E\u206C\u202D\u200F\u202C\u206C\u200D\u206E\u200C\u202D\u206D\u206F\u200E\u200C\u202D\u200F\u202B\u202D\u202D\u200D\u200F\u206C\u206B\u200B\u202A\u206C\u200E\u200B\u200D\u206F\u202E(limb, null) ? 730662787U : 414940374U) ^ num * 4175637521U);
					continue;
				case 9U:
				{
					EPlayerStance eplayerStance;
					if (eplayerStance != 4)
					{
						num2 = (num * 1941254879U ^ 578878819U);
						continue;
					}
					goto IL_BD;
				}
				case 10U:
					limb2 = Utils.GetLimb(ESP.\u200E\u202D\u200C\u206D\u202D\u200B\u202C\u202E\u206F\u202C\u200B\u206E\u206D\u200C\u200E\u200F\u200C\u200E\u200B\u200F\u200C\u202B\u200C\u202E\u200C\u202A\u202B\u200B\u206A\u206A\u206E\u206A\u202B\u202B\u202A\u202A\u206C\u202E\u200D\u206F\u202E(target), 13);
					num2 = (((!ESP.\u200E\u202D\u202D\u200C\u206F\u206A\u202A\u200B\u202B\u202B\u200E\u206C\u202D\u200F\u202C\u206C\u200D\u206E\u200C\u202D\u206D\u206F\u200E\u200C\u202D\u200F\u202B\u202D\u202D\u200D\u200F\u206C\u206B\u200B\u202A\u206C\u200E\u200B\u200D\u206F\u202E(limb2, null)) ? 2976082443U : 3825908835U) ^ num * 3043889713U);
					continue;
				}
				break;
			}
			goto IL_188;
			IL_B6:
			float num3 = 0.15f;
			goto IL_C9;
			IL_BD:
			num3 = 0.75f;
			goto IL_C9;
			IL_C4:
			num3 = 1f;
			IL_C9:
			float num4 = num3;
			return ESP.\u206B\u202A\u206E\u200C\u202B\u200D\u206D\u200C\u206A\u202B\u202B\u200C\u200D\u200D\u202E\u206B\u202C\u200D\u202E\u202B\u206B\u200D\u202B\u200D\u200C\u200C\u206D\u200D\u200B\u206C\u200C\u200E\u202C\u202C\u206C\u202B\u206E\u200D\u202E\u206B\u202E(limb) + Vector3.up * num4;
			IL_111:
			return ESP.\u206B\u202A\u206E\u200C\u202B\u200D\u206D\u200C\u206A\u202B\u202B\u200C\u200D\u200D\u202E\u206B\u202C\u200D\u202E\u202B\u206B\u200D\u202B\u200D\u200C\u200C\u206D\u200D\u200B\u206C\u200C\u200E\u202C\u202C\u206C\u202B\u206E\u200D\u202E\u206B\u202E(limb2) + Vector3.up * 0.22f;
			IL_188:
			return ESP.\u206B\u202A\u206E\u200C\u202B\u200D\u206D\u200C\u206A\u202B\u202B\u200C\u200D\u200D\u202E\u206B\u202C\u200D\u202E\u202B\u206B\u200D\u202B\u200D\u200C\u200C\u206D\u200D\u200B\u206C\u200C\u200E\u202C\u202C\u206C\u202B\u206E\u200D\u202E\u206B\u202E(ESP.\u200E\u202D\u200C\u206D\u202D\u200B\u202C\u202E\u206F\u202C\u200B\u206E\u206D\u200C\u200E\u200F\u200C\u200E\u200B\u200F\u200C\u202B\u200C\u202E\u200C\u202A\u202B\u200B\u206A\u206A\u206E\u206A\u202B\u202B\u202A\u202A\u206C\u202E\u200D\u206F\u202E(target)) + Vector3.up * 1.4f;
			IL_0B:
			num2 = 223102458U;
			goto IL_10;
			IL_156:
			limb = Utils.GetLimb(ESP.\u200E\u202D\u200C\u206D\u202D\u200B\u202C\u202E\u206F\u202C\u200B\u206E\u206D\u200C\u200E\u200F\u200C\u200E\u200B\u200F\u200C\u202B\u200C\u202E\u200C\u202A\u202B\u200B\u206A\u206A\u206E\u206A\u202B\u202B\u202A\u202A\u206C\u202E\u200D\u206F\u202E(target), 12);
			num2 = 1205109485U;
			goto IL_10;
		}

		// Token: 0x0600009E RID: 158 RVA: 0x0000C394 File Offset: 0x0000A594
		private bool IsVisible(Vector3 from, Vector3 to, Player target)
		{
			Vector3 vector = to - from;
			for (;;)
			{
				IL_08:
				uint num = 3529385547U;
				for (;;)
				{
					uint num2;
					switch ((num2 = (num ^ 3204044591U)) % 9U)
					{
					case 0U:
					{
						Vector3 normalized;
						RaycastHit raycastHit;
						float num3;
						num = (((!ESP.\u206D\u206F\u202B\u206D\u200C\u200F\u200D\u200E\u206F\u200C\u200E\u202D\u202A\u202B\u202C\u206C\u200B\u206A\u202E\u200C\u202B\u200C\u206C\u202A\u206C\u206A\u206B\u206A\u206C\u202E\u202E\u200E\u200D\u206A\u206E\u206A\u206A\u202C\u206C\u206E\u202E(from + Vector3.up * 0.08f, normalized, ref raycastHit, num3 + 0.4f, RayMasks.DAMAGE_CLIENT)) ? 3301236485U : 3083376914U) ^ num2 * 3037475058U);
						continue;
					}
					case 1U:
					{
						Vector3 normalized = vector.normalized;
						float num3 = Vector3.Distance(from, to);
						num = (num2 * 1249259006U ^ 1248383162U);
						continue;
					}
					case 2U:
						return true;
					case 3U:
					{
						Vector3 normalized;
						RaycastHit raycastHit;
						float num3;
						num = (ESP.\u206D\u206F\u202B\u206D\u200C\u200F\u200D\u200E\u206F\u200C\u200E\u202D\u202A\u202B\u202C\u206C\u200B\u206A\u202E\u200C\u202B\u200C\u206C\u202A\u206C\u206A\u206B\u206A\u206C\u202E\u202E\u200E\u200D\u206A\u206E\u206A\u206A\u202C\u206C\u206E\u202E(from + Vector3.up * 0.03f, normalized, ref raycastHit, num3 + 0.4f, RayMasks.DAMAGE_CLIENT) ? 2357755748U : 2494362514U);
						continue;
					}
					case 4U:
					{
						RaycastHit raycastHit;
						num = ((ESP.\u200D\u200E\u202A\u200E\u206F\u202E\u206D\u200D\u200C\u206F\u200F\u206A\u206B\u202C\u200B\u202C\u206D\u200F\u200E\u206A\u202E\u206D\u206E\u206B\u206C\u200B\u206E\u206A\u200F\u206B\u200F\u202A\u206C\u202E\u200C\u202D\u200C\u202C\u206F\u202D\u202E(ESP.\u200E\u200C\u206F\u206E\u200C\u200F\u200F\u206D\u202B\u202C\u206E\u200C\u206A\u202D\u200F\u200C\u200E\u206A\u202E\u206F\u202D\u202A\u206A\u202E\u206E\u200E\u202B\u206B\u206F\u206A\u206B\u200F\u202D\u206F\u206A\u200E\u202A\u202D\u202D\u206A\u202E(raycastHit.transform), target) ? 3522808856U : 2809579805U) ^ num2 * 303453261U);
						continue;
					}
					case 5U:
						goto IL_08;
					case 6U:
					{
						RaycastHit raycastHit;
						num = ((ESP.\u200D\u200E\u202A\u200E\u206F\u202E\u206D\u200D\u200C\u206F\u200F\u206A\u206B\u202C\u200B\u202C\u206D\u200F\u200E\u206A\u202E\u206D\u206E\u206B\u206C\u200B\u206E\u206A\u200F\u206B\u200F\u202A\u206C\u202E\u200C\u202D\u200C\u202C\u206F\u202D\u202E(ESP.\u200E\u200C\u206F\u206E\u200C\u200F\u200F\u206D\u202B\u202C\u206E\u200C\u206A\u202D\u200F\u200C\u200E\u206A\u202E\u206F\u202D\u202A\u206A\u202E\u206E\u200E\u202B\u206B\u206F\u206A\u206B\u200F\u202D\u206F\u206A\u200E\u202A\u202D\u202D\u206A\u202E(raycastHit.transform), target) ? 1258163630U : 1450676978U) ^ num2 * 3124755819U);
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

		// Token: 0x0600009F RID: 159 RVA: 0x0000C51C File Offset: 0x0000A71C
		public void HardCleanGlow()
		{
			if (this.highlighters == null)
			{
				for (;;)
				{
					switch ((1151590846 ^ 1994134900) % 3)
					{
					case 0:
						continue;
					case 2:
						return;
					}
					break;
				}
			}
			using (List<Transform>.Enumerator enumerator = this.highlighters.Keys.ToList<Transform>().GetEnumerator())
			{
				IL_C5:
				while (enumerator.MoveNext())
				{
					Highlighter highlighter;
					for (;;)
					{
						IL_78:
						Transform key = enumerator.Current;
						uint num = 889704024U;
						for (;;)
						{
							uint num2;
							switch ((num2 = (num ^ 1994134900U)) % 4U)
							{
							case 0U:
								if (this.highlighters.TryGetValue(key, out highlighter))
								{
									num = (num2 * 976681533U ^ 368727105U);
									continue;
								}
								goto IL_C5;
							case 2U:
								num = 56715743U;
								continue;
							case 3U:
								goto IL_78;
							}
							goto Block_4;
						}
					}
					IL_A6:
					if (ESP.\u200E\u202D\u202D\u200C\u206F\u206A\u202A\u200B\u202B\u202B\u200E\u206C\u202D\u200F\u202C\u206C\u200D\u206E\u200C\u202D\u206D\u206F\u200E\u200C\u202D\u200F\u202B\u202D\u202D\u200D\u200F\u206C\u206B\u200B\u202A\u206C\u200E\u200B\u200D\u206F\u202E(highlighter, null))
					{
						try
						{
							ESP.\u206A\u200D\u206C\u206E\u202D\u206E\u206A\u202C\u206F\u200D\u206D\u202A\u200D\u202B\u202B\u206B\u200D\u206D\u202B\u200E\u206B\u206C\u206F\u200C\u202C\u202D\u206D\u200E\u206C\u206B\u200F\u206F\u202B\u202A\u202A\u200B\u202D\u206C\u200B\u202A\u202E(highlighter, 0.25f);
							ESP.\u206C\u206C\u206F\u202B\u202C\u206D\u202A\u206F\u202C\u200E\u202E\u206A\u202C\u206D\u200B\u206B\u206F\u202C\u206D\u200B\u202E\u206C\u206E\u206F\u202D\u202E\u202C\u202A\u200F\u206E\u206A\u200D\u200C\u202C\u206B\u206D\u200D\u206B\u206D\u200D\u202E(highlighter);
						}
						catch
						{
						}
						continue;
					}
					continue;
					Block_4:
					goto IL_A6;
				}
			}
			this.highlighters.Clear();
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x0000C720 File Offset: 0x0000A920
		// Note: this type is marked as 'beforefieldinit'.
		static ESP()
		{
			for (;;)
			{
				IL_3C:
				uint num = 422111877U;
				for (;;)
				{
					uint num2;
					switch ((num2 = (num ^ 1519194708U)) % 5U)
					{
					case 0U:
						ESP.itemIconCache = new Dictionary<ushort, Texture2D>();
						num = (num2 * 1584347194U ^ 1897774160U);
						continue;
					case 1U:
						ESP.COLOR_TEXT_SHADOW = new Color(0f, 0f, 0f, 0.9f);
						num = (num2 * 2052157862U ^ 3149158449U);
						continue;
					case 3U:
						goto IL_3C;
					case 4U:
						ESP.COLOR_TEXT = Color.white;
						num = (num2 * 2397755258U ^ 3355028555U);
						continue;
					}
					return;
				}
			}
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x0000C7F8 File Offset: 0x0000A9F8
		static GUISkin \u202E\u206B\u200C\u206C\u206D\u206C\u206C\u200B\u206B\u202E\u200C\u202B\u200B\u202A\u202C\u202D\u202C\u202E\u206D\u200F\u200F\u206D\u202D\u202B\u200E\u200E\u200D\u200B\u200D\u206C\u206D\u206A\u202E\u200E\u200C\u200C\u206D\u200F\u202C\u206D\u202E()
		{
			return GUI.skin;
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x0000C80C File Offset: 0x0000AA0C
		static GUIStyle \u200B\u206D\u206F\u200B\u206F\u206D\u200D\u206E\u202D\u206D\u206A\u200B\u206E\u202A\u200E\u200F\u206A\u206F\u202E\u202C\u202A\u202E\u202D\u200C\u202B\u202A\u206D\u200B\u202D\u202C\u206A\u206C\u206D\u206C\u202C\u206A\u206A\u200D\u200C\u206E\u202E(GUISkin A_0)
		{
			return A_0.label;
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x0000C820 File Offset: 0x0000AA20
		static GUIStyle \u206F\u206B\u202B\u202E\u202A\u206C\u206C\u202B\u206A\u200E\u202C\u206C\u206C\u200E\u200B\u200D\u206F\u202C\u202D\u206B\u206B\u200D\u202E\u206D\u206B\u206C\u206F\u202A\u200C\u200B\u202D\u200F\u200C\u200B\u206B\u202C\u200E\u200D\u202A\u202D\u202E(GUIStyle A_0)
		{
			return new GUIStyle(A_0);
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x0000C834 File Offset: 0x0000AA34
		static void \u206C\u206B\u202C\u200B\u202C\u200B\u206F\u206D\u206A\u202E\u202A\u200E\u200F\u206A\u200D\u202D\u200D\u200C\u200E\u206C\u200B\u200E\u206F\u202E\u206E\u202A\u202A\u206E\u202D\u202C\u202C\u206F\u206F\u206A\u202D\u202E\u200D\u202C\u200D\u200E\u202E(GUIStyle A_0, TextAnchor A_1)
		{
			A_0.alignment = A_1;
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x0000C848 File Offset: 0x0000AA48
		static void \u206D\u202B\u206E\u200F\u202D\u200F\u202B\u200F\u202D\u206F\u200B\u200B\u202D\u206C\u200C\u200D\u206F\u206C\u202B\u202E\u200F\u200B\u202D\u200F\u206C\u200B\u206D\u206A\u200F\u206D\u202B\u202B\u206F\u200C\u206C\u206B\u202A\u202A\u202B\u202E(GUIStyle A_0, int A_1)
		{
			A_0.fontSize = A_1;
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x0000C85C File Offset: 0x0000AA5C
		static void \u200C\u202A\u200B\u206D\u202A\u206F\u202A\u206D\u200F\u200D\u200D\u200B\u200D\u206E\u206B\u202D\u202A\u206E\u206E\u206C\u200E\u202A\u202E\u200B\u200D\u206F\u200E\u202D\u206F\u202E\u206F\u200D\u200E\u206B\u206C\u206C\u206D\u200D\u206A\u202E\u202E(GUIStyle A_0, FontStyle A_1)
		{
			A_0.fontStyle = A_1;
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x000076A4 File Offset: 0x000058A4
		static bool \u200D\u200E\u202A\u200E\u206F\u202E\u206D\u200D\u200C\u206F\u200F\u206A\u206B\u202C\u200B\u202C\u206D\u200F\u200E\u206A\u202E\u206D\u206E\u206B\u206C\u200B\u206E\u206A\u200F\u206B\u200F\u202A\u206C\u202E\u200C\u202D\u200C\u202C\u206F\u202D\u202E(Object A_0, Object A_1)
		{
			return A_0 == A_1;
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x0000C870 File Offset: 0x0000AA70
		static GameObject \u202A\u202E\u206E\u202C\u200B\u202C\u206A\u202D\u206D\u206B\u200E\u202B\u202B\u202A\u206D\u202E\u202B\u200B\u202E\u200B\u206B\u200F\u202D\u206B\u206E\u200E\u202C\u202D\u202D\u200B\u202A\u202D\u206A\u202B\u200E\u200D\u206D\u202A\u200E\u206A\u202E(Component A_0)
		{
			return A_0.gameObject;
		}

		// Token: 0x060000AA RID: 170 RVA: 0x000061E8 File Offset: 0x000043E8
		static bool \u200E\u202D\u202D\u200C\u206F\u206A\u202A\u200B\u202B\u202B\u200E\u206C\u202D\u200F\u202C\u206C\u200D\u206E\u200C\u202D\u206D\u206F\u200E\u200C\u202D\u200F\u202B\u202D\u202D\u200D\u200F\u206C\u206B\u200B\u202A\u206C\u200E\u200B\u200D\u206F\u202E(Object A_0, Object A_1)
		{
			return A_0 != A_1;
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00007690 File Offset: 0x00005890
		static Player \u202E\u206A\u200D\u206A\u206F\u206B\u202A\u206A\u202C\u202A\u206D\u206B\u202A\u206C\u202B\u206E\u200D\u202C\u200F\u206B\u206B\u206A\u200B\u206D\u206A\u202E\u206E\u202A\u200F\u206A\u202E\u202E\u206E\u202E\u202C\u202B\u202A\u206E\u200E\u200E\u202E()
		{
			return Player.LocalPlayer;
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00007824 File Offset: 0x00005A24
		static PlayerLife \u202E\u206C\u206C\u206C\u206E\u206C\u206F\u206D\u202B\u200F\u200B\u202D\u202B\u200D\u200D\u202E\u206A\u202C\u200B\u206D\u200B\u200E\u206A\u202C\u206B\u202D\u202C\u206A\u206D\u202E\u200C\u206D\u206D\u202D\u206F\u200C\u206F\u206D\u200C\u200E\u202E(Player A_0)
		{
			return A_0.life;
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00007838 File Offset: 0x00005A38
		static bool \u206E\u200B\u202A\u206C\u200B\u200B\u200C\u200E\u206A\u202B\u206E\u202B\u200F\u206C\u206A\u202D\u200B\u206F\u206F\u206F\u200F\u206B\u200E\u200B\u200F\u202D\u200F\u202E\u202D\u206A\u206C\u206B\u200B\u200E\u202C\u200E\u200B\u206C\u202D\u206B\u202E(PlayerLife A_0)
		{
			return A_0.isDead;
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00007708 File Offset: 0x00005908
		static Transform \u200E\u202D\u200C\u206D\u202D\u200B\u202C\u202E\u206F\u202C\u200B\u206E\u206D\u200C\u200E\u200F\u200C\u200E\u200B\u200F\u200C\u202B\u200C\u202E\u200C\u202A\u202B\u200B\u206A\u206A\u206E\u206A\u202B\u202B\u202A\u202A\u206C\u202E\u200D\u206F\u202E(Component A_0)
		{
			return A_0.transform;
		}

		// Token: 0x060000AF RID: 175 RVA: 0x0000C884 File Offset: 0x0000AA84
		static GameObject \u206D\u206C\u202B\u206D\u202B\u202E\u202B\u200B\u200D\u200B\u202D\u206A\u200D\u206A\u206A\u206F\u200B\u200B\u206A\u202E\u206B\u206D\u206A\u206C\u206F\u202B\u206A\u200D\u206D\u202D\u206F\u202E\u206E\u200B\u202E\u206F\u200B\u202E\u202E\u200C\u202E(Component A_0)
		{
			return A_0.gameObject;
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x0000C898 File Offset: 0x0000AA98
		static void \u206A\u200D\u206C\u206E\u202D\u206E\u206A\u202C\u206F\u200D\u206D\u202A\u200D\u202B\u202B\u206B\u200D\u206D\u202B\u200E\u206B\u206C\u206F\u200C\u202C\u202D\u206D\u200E\u206C\u206B\u200F\u206F\u202B\u202A\u202A\u200B\u202D\u206C\u200B\u202A\u202E(Highlighter A_0, float A_1)
		{
			A_0.ConstantOff(A_1);
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x0000C8AC File Offset: 0x0000AAAC
		static void \u200C\u202B\u206A\u200F\u206C\u206F\u202A\u206F\u202D\u206A\u206F\u202D\u206E\u200C\u200C\u200D\u206A\u202C\u202A\u200D\u206E\u202A\u206E\u206E\u200B\u200F\u202E\u202E\u206D\u202B\u200C\u200F\u206C\u200B\u206F\u202D\u200B\u206F\u202D\u202E\u202E(Highlighter A_0, bool A_1)
		{
			A_0.overlay = A_1;
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x0000C8C0 File Offset: 0x0000AAC0
		static void \u206C\u200C\u200F\u202D\u206B\u206C\u206D\u202B\u206C\u200E\u202A\u202B\u206C\u206B\u202D\u200F\u206B\u200C\u206C\u202A\u200E\u200C\u200D\u200B\u202A\u206B\u206A\u206F\u206E\u200E\u200F\u200C\u200C\u202A\u200D\u206D\u200B\u200E\u200E\u202E\u202E(Behaviour A_0, bool A_1)
		{
			A_0.enabled = A_1;
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x0000771C File Offset: 0x0000591C
		static Vector3 \u206B\u202A\u206E\u200C\u202B\u200D\u206D\u200C\u206A\u202B\u202B\u200C\u200D\u200D\u202E\u206B\u202C\u200D\u202E\u202B\u206B\u200D\u202B\u200D\u200C\u200C\u206D\u200D\u200B\u206C\u200C\u200E\u202C\u202C\u206C\u202B\u206E\u200D\u202E\u206B\u202E(Transform A_0)
		{
			return A_0.position;
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x0000C8D4 File Offset: 0x0000AAD4
		static void \u206B\u200D\u200D\u202B\u200B\u200B\u200E\u200B\u200D\u202A\u202D\u202E\u200D\u206C\u200C\u200B\u200C\u200C\u202C\u206D\u206C\u202A\u206B\u206E\u206E\u200D\u202B\u202B\u206E\u200E\u200E\u206B\u206D\u206C\u206C\u206B\u202B\u202A\u206B\u202E\u202E(Highlighter A_0, Color A_1, float A_2)
		{
			A_0.ConstantOn(A_1, A_2);
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x0000C8EC File Offset: 0x0000AAEC
		static Color \u202E\u202B\u206E\u206A\u200E\u200C\u206B\u206B\u206A\u200C\u200D\u206B\u200D\u206E\u200C\u200F\u200F\u202E\u200D\u202E\u200C\u202C\u206B\u200B\u206D\u200B\u206F\u206F\u202C\u200F\u200B\u206A\u202C\u202B\u200F\u200B\u206E\u200F\u202B\u200D\u202E(EItemRarity A_0)
		{
			return ItemTool.getRarityColorHighlight(A_0);
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x0000C900 File Offset: 0x0000AB00
		static VehicleAsset \u206A\u206A\u202D\u200B\u202E\u202A\u200B\u200D\u202E\u202E\u206E\u202B\u206F\u200C\u200F\u202B\u206F\u206A\u206A\u200C\u202B\u206B\u202B\u200D\u202C\u206B\u200B\u206E\u200B\u202A\u200D\u202D\u202D\u206C\u202A\u202D\u202A\u200F\u202A\u202E(InteractableVehicle A_0)
		{
			return A_0.asset;
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x0000C914 File Offset: 0x0000AB14
		static Transform \u202D\u200B\u202B\u206E\u202C\u206F\u202E\u202E\u206E\u202C\u202A\u202E\u202C\u202E\u202A\u206F\u206F\u200D\u206B\u200B\u202A\u200E\u206C\u200B\u206A\u202C\u200E\u202C\u206E\u200F\u206E\u206B\u200B\u202B\u202E\u206F\u200E\u206A\u206E\u202E(BarricadeDrop A_0)
		{
			return A_0.model;
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00007730 File Offset: 0x00005930
		static float \u206D\u206D\u200B\u200E\u200B\u206F\u200E\u202D\u200C\u206E\u202D\u206C\u206D\u200E\u202D\u200B\u200B\u200D\u206F\u200D\u202E\u206D\u206C\u206E\u200F\u202D\u200D\u206E\u202C\u200D\u202A\u206D\u206F\u206C\u206A\u202E\u200B\u200C\u202B\u200E\u202E()
		{
			return Time.time;
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x0000C928 File Offset: 0x0000AB28
		static int \u200D\u202E\u206C\u202D\u206D\u200C\u200B\u206F\u200B\u200D\u206F\u202D\u202C\u200C\u206F\u202B\u206A\u202B\u202B\u200E\u202B\u202D\u200E\u206A\u202A\u200E\u200C\u202D\u200F\u202B\u200D\u206F\u206F\u200E\u202D\u200C\u206E\u206D\u200B\u200F\u202E()
		{
			return Time.frameCount;
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00007744 File Offset: 0x00005944
		static Vector3 \u206E\u200B\u206A\u206A\u200B\u206D\u206A\u200B\u202A\u202D\u202E\u206D\u206B\u202E\u202E\u206C\u200D\u200F\u202E\u202C\u202C\u202E\u200B\u200D\u200E\u200F\u202B\u200E\u202E\u200F\u202B\u202E\u200B\u202D\u200B\u200B\u202B\u206A\u200F\u206B\u202E(Camera A_0, Vector3 A_1)
		{
			return A_0.WorldToScreenPoint(A_1);
		}

		// Token: 0x060000BB RID: 187 RVA: 0x0000776C File Offset: 0x0000596C
		static int \u202C\u206B\u202C\u206A\u200D\u202E\u206F\u200F\u202B\u200B\u202D\u202E\u206E\u206D\u206E\u206D\u206D\u206B\u206B\u200E\u206C\u206F\u200F\u206D\u206B\u200C\u200D\u206F\u206E\u200C\u202B\u206C\u200B\u202E\u200E\u200F\u206F\u200D\u206B\u206B\u202E()
		{
			return Screen.height;
		}

		// Token: 0x060000BC RID: 188 RVA: 0x0000C93C File Offset: 0x0000AB3C
		static void \u202C\u206D\u202E\u200E\u206A\u202E\u202A\u206F\u206C\u206F\u206F\u200F\u202D\u206C\u202A\u206B\u200D\u206E\u206C\u202C\u202D\u202B\u206B\u206B\u200F\u206B\u200C\u206D\u206F\u206C\u202D\u200F\u206D\u206A\u202B\u202B\u206B\u202A\u200B\u206F\u202E(Rect A_0, Texture A_1, ScaleMode A_2)
		{
			GUI.DrawTexture(A_0, A_1, A_2);
		}

		// Token: 0x060000BD RID: 189 RVA: 0x0000C954 File Offset: 0x0000AB54
		static string \u206B\u200C\u206F\u202D\u202E\u202B\u202E\u200C\u206B\u200C\u202C\u200E\u202B\u200B\u200D\u202D\u202B\u202B\u206E\u206F\u200E\u206C\u202A\u202A\u206A\u206D\u200D\u200C\u200C\u202D\u202D\u206E\u202A\u200C\u202C\u200B\u202C\u206C\u206B\u202A\u202E(Asset A_0)
		{
			return A_0.FriendlyName;
		}

		// Token: 0x060000BE RID: 190 RVA: 0x0000C968 File Offset: 0x0000AB68
		static bool \u206B\u202A\u206B\u206A\u206B\u202B\u206C\u200D\u200E\u206C\u200D\u206A\u206C\u206C\u206E\u200E\u206C\u202B\u206C\u206F\u206B\u202E\u200C\u200D\u206F\u200D\u202C\u202A\u200C\u202D\u202C\u202E\u206C\u200E\u200C\u200F\u200F\u206B\u206E\u206F\u202E(string A_0)
		{
			return string.IsNullOrEmpty(A_0);
		}

		// Token: 0x060000BF RID: 191 RVA: 0x0000C97C File Offset: 0x0000AB7C
		static GUIStyleState \u200C\u202D\u202B\u206E\u200F\u202E\u206C\u202E\u200B\u206C\u202D\u202D\u202B\u202A\u206F\u206B\u206E\u202C\u200D\u206D\u206E\u202B\u200C\u206E\u202C\u200B\u206E\u206A\u206A\u206B\u206F\u202A\u206B\u200C\u206D\u200D\u200D\u202B\u206C\u202E(GUIStyle A_0)
		{
			return A_0.normal;
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x0000C990 File Offset: 0x0000AB90
		static void \u200C\u202B\u202B\u202A\u206B\u202B\u200C\u202D\u206D\u206E\u202E\u206B\u202B\u200D\u206A\u200C\u206C\u200B\u200F\u202E\u206F\u200E\u200B\u206E\u200F\u206A\u200D\u206D\u206C\u200C\u200E\u200C\u206F\u202A\u200D\u200C\u206E\u202C\u202E\u206D\u202E(GUIStyleState A_0, Color A_1)
		{
			A_0.textColor = A_1;
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x0000C9A4 File Offset: 0x0000ABA4
		static GUIContent \u200F\u206B\u206D\u206F\u206F\u202A\u202C\u202B\u206A\u206B\u202A\u200F\u202D\u200E\u206E\u200F\u206F\u200D\u202C\u202E\u200E\u200C\u202C\u206B\u206F\u202A\u206E\u202B\u202B\u206C\u202A\u202B\u200D\u202C\u202A\u200D\u202D\u206B\u202E\u206D\u202E(string A_0)
		{
			return new GUIContent(A_0);
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x0000C9B8 File Offset: 0x0000ABB8
		static Vector2 \u206F\u202B\u202E\u202E\u202B\u202A\u202C\u200C\u200F\u206D\u206A\u200D\u206B\u202A\u202E\u206D\u206F\u202C\u206C\u202E\u206C\u206B\u200B\u202E\u206D\u202A\u206E\u202B\u200E\u206A\u200E\u200B\u202B\u206B\u206B\u206D\u206F\u206A\u206B\u200D\u202E(GUIStyle A_0, GUIContent A_1)
		{
			return A_0.CalcSize(A_1);
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x0000C9CC File Offset: 0x0000ABCC
		static void \u206A\u206B\u206E\u206D\u206D\u200B\u202D\u202B\u202B\u202D\u200B\u206F\u200C\u206E\u202E\u200B\u206A\u202D\u206F\u206C\u206E\u202B\u200D\u202B\u206E\u206D\u200E\u206A\u206E\u200E\u200D\u200E\u206A\u206B\u206B\u200D\u202D\u202E\u202E\u200D\u202E(Color A_0)
		{
			GUI.color = A_0;
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x0000C9E0 File Offset: 0x0000ABE0
		static void \u200D\u206C\u206F\u200C\u206F\u202D\u206C\u202B\u202B\u202C\u202B\u200D\u206E\u200D\u206B\u200C\u200B\u202E\u200F\u200C\u206F\u206B\u202C\u202A\u206D\u200D\u206A\u202B\u206E\u202A\u200C\u202E\u202B\u200F\u200D\u202E\u202B\u202B\u206B\u206E\u202E(Rect A_0, string A_1, GUIStyle A_2)
		{
			GUI.Label(A_0, A_1, A_2);
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x0000C9F8 File Offset: 0x0000ABF8
		static Color \u200E\u206F\u202C\u202D\u200E\u200C\u200D\u200E\u202A\u206D\u202A\u202A\u206A\u202D\u202A\u206F\u202E\u202D\u206F\u206B\u200F\u202C\u202E\u200D\u200B\u206B\u206C\u202B\u202B\u200C\u206A\u200F\u206D\u200D\u206A\u202B\u200B\u202C\u202A\u200F\u202E(GUIStyleState A_0)
		{
			return A_0.textColor;
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x0000CA0C File Offset: 0x0000AC0C
		static bool \u202E\u202A\u206F\u202E\u206E\u200B\u206E\u202D\u202B\u200C\u206D\u206F\u200F\u200D\u202D\u202E\u202C\u206A\u206F\u202A\u206F\u200F\u206B\u200B\u202E\u206B\u206E\u202A\u206F\u200B\u206D\u200C\u200E\u200C\u202B\u206A\u206F\u206D\u200E\u200E\u202E(InteractableVehicle A_0)
		{
			return A_0.isLocked;
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x0000CA20 File Offset: 0x0000AC20
		static string \u202E\u200B\u202E\u206C\u206E\u202E\u200D\u206D\u206A\u200F\u202B\u202B\u202B\u202C\u206D\u206A\u200D\u206B\u206E\u202E\u202A\u206E\u200E\u206A\u202A\u202E\u200E\u206C\u202B\u202E\u200D\u206F\u202D\u206D\u200E\u206B\u202C\u206A\u206A\u206E\u202E(VehicleAsset A_0)
		{
			return A_0.vehicleName;
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x0000CA34 File Offset: 0x0000AC34
		static string \u206D\u202C\u202B\u202C\u206D\u206B\u206C\u200C\u206B\u206D\u206E\u200D\u200D\u206F\u206C\u202B\u206D\u200C\u200F\u200C\u200E\u202E\u202C\u206F\u206F\u206A\u200F\u200D\u202E\u200D\u200D\u206F\u200B\u202C\u206D\u202B\u206F\u206D\u200B\u206E\u202E(string A_0, object A_1, object A_2)
		{
			return string.Format(A_0, A_1, A_2);
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x0000CA4C File Offset: 0x0000AC4C
		static ItemBarricadeAsset \u202B\u202D\u200C\u206A\u202D\u200C\u202A\u200D\u200B\u206B\u200B\u202A\u206A\u200D\u206C\u200C\u200D\u206B\u200B\u202C\u206A\u206B\u202E\u202E\u200C\u200E\u206C\u206D\u206A\u206A\u200B\u200C\u200C\u202C\u202D\u206A\u200B\u202E\u206E\u202B\u202E(BarricadeDrop A_0)
		{
			return A_0.asset;
		}

		// Token: 0x060000CA RID: 202 RVA: 0x0000CA60 File Offset: 0x0000AC60
		static string \u200F\u206A\u202E\u206E\u200E\u206C\u200D\u200D\u202C\u200E\u206F\u200D\u200D\u202D\u202B\u202B\u202B\u200C\u202A\u206E\u206E\u200D\u200E\u202C\u202D\u200F\u206D\u206A\u206E\u200E\u200B\u202B\u206D\u202A\u206B\u202A\u200C\u202C\u200D\u202A\u202E(string A_0, string A_1, string A_2, string A_3)
		{
			return A_0 + A_1 + A_2 + A_3;
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00007794 File Offset: 0x00005994
		static PlayerStance \u206A\u200E\u206B\u200B\u206F\u202B\u206C\u200C\u200F\u206E\u200D\u206B\u202A\u202A\u200F\u200B\u202E\u206B\u200B\u202B\u206E\u202D\u200F\u206D\u200E\u206A\u200E\u200C\u206B\u202B\u206A\u202C\u206E\u200D\u202A\u206F\u202E\u202A\u202A\u206B\u202E(Player A_0)
		{
			return A_0.stance;
		}

		// Token: 0x060000CC RID: 204 RVA: 0x000077A8 File Offset: 0x000059A8
		static EPlayerStance \u206F\u206F\u202B\u200C\u206D\u200E\u206F\u206B\u206B\u206D\u202C\u206F\u202A\u206F\u202D\u206D\u206A\u200D\u202B\u202B\u206E\u206B\u206D\u206E\u202C\u200F\u206E\u206F\u206F\u202C\u206E\u202E\u200D\u206B\u206D\u206C\u200D\u202B\u206A\u202E(PlayerStance A_0)
		{
			return A_0.stance;
		}

		// Token: 0x060000CD RID: 205 RVA: 0x000077E8 File Offset: 0x000059E8
		static PlayerLook \u202D\u206B\u200B\u200D\u206A\u200C\u202E\u206A\u200D\u200B\u206C\u206F\u206D\u200D\u206A\u200D\u202A\u206A\u202B\u206D\u202E\u202C\u200F\u206E\u202E\u200C\u206D\u202D\u206F\u200D\u206E\u206D\u206C\u206C\u206C\u200B\u206D\u206F\u206D\u202B\u202E(Player A_0)
		{
			return A_0.look;
		}

		// Token: 0x060000CE RID: 206 RVA: 0x000077FC File Offset: 0x000059FC
		static Transform \u200F\u202A\u206A\u206C\u200E\u206B\u206C\u206A\u202A\u206E\u206B\u206F\u202E\u206C\u200B\u200E\u202A\u206B\u206B\u202B\u206C\u202C\u206E\u200B\u202B\u206F\u200F\u202D\u200E\u200B\u200E\u202D\u200B\u200E\u202A\u206C\u206B\u206C\u202E(PlayerLook A_0)
		{
			return A_0.aim;
		}

		// Token: 0x060000CF RID: 207 RVA: 0x0000CA78 File Offset: 0x0000AC78
		static List<SteamPlayer> \u202B\u200C\u206A\u202B\u202C\u202E\u202A\u206B\u200C\u200D\u206C\u206B\u200F\u206B\u200B\u200C\u200F\u202C\u200B\u202B\u200B\u200B\u202B\u202A\u202C\u206D\u202A\u202E\u202B\u200C\u202A\u202B\u202E\u202B\u202E\u206B\u202B\u200B\u200B\u200E\u202E()
		{
			return Provider.clients;
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x0000CA8C File Offset: 0x0000AC8C
		static SteamPlayerID \u200F\u200B\u200B\u200C\u202D\u202D\u202E\u200E\u206D\u200B\u206A\u206E\u206B\u206D\u202D\u202E\u206C\u202E\u206C\u206D\u202B\u206F\u206D\u200C\u202D\u200C\u206C\u206F\u200C\u206B\u202E\u200E\u206C\u202A\u202D\u202A\u206E\u200E\u200F\u202E(SteamPlayer A_0)
		{
			return A_0.playerID;
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x0000CAA0 File Offset: 0x0000ACA0
		static string \u200B\u200E\u202E\u202E\u202D\u200C\u202A\u206A\u200F\u206D\u206B\u202A\u200C\u206D\u202C\u200E\u200B\u206B\u202B\u206C\u206F\u200B\u206D\u202B\u202C\u200C\u202C\u200C\u202A\u206C\u206E\u200D\u202D\u206D\u206A\u202B\u200B\u206F\u206A\u200E\u202E(SteamPlayerID A_0)
		{
			return A_0.characterName;
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x0000CAB4 File Offset: 0x0000ACB4
		static string \u206B\u206D\u206F\u202E\u202C\u200E\u202B\u202B\u200D\u206C\u206C\u206A\u202E\u200B\u200D\u200E\u202A\u206E\u206D\u206B\u200F\u206A\u206D\u206C\u200B\u200B\u202B\u200E\u200B\u206F\u200B\u206A\u200B\u206C\u206A\u206E\u200D\u202A\u202A\u202E(string A_0)
		{
			return A_0.ToUpperInvariant();
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x0000CAC8 File Offset: 0x0000ACC8
		static bool \u200E\u202B\u200F\u206D\u202C\u206E\u200F\u200D\u200C\u206B\u206F\u200E\u200D\u200B\u202B\u206C\u206A\u206D\u206A\u200B\u206F\u206D\u200C\u206E\u202E\u200D\u202E\u200F\u202B\u206A\u200B\u206C\u202A\u200B\u200C\u202C\u202E\u202B\u200E\u206F\u202E(SteamPlayer A_0)
		{
			return A_0.isAdmin;
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x0000CADC File Offset: 0x0000ACDC
		static bool \u200B\u200F\u200C\u206A\u206E\u200E\u202C\u202A\u200E\u206E\u200F\u206F\u202E\u200D\u202C\u206C\u202B\u206D\u202E\u200F\u200D\u202B\u206A\u200E\u200F\u206E\u206B\u200C\u200E\u200D\u206F\u200B\u202C\u202B\u206D\u206D\u202C\u206E\u202A\u202E\u202E(string A_0, string A_1)
		{
			return A_0.Contains(A_1);
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00007758 File Offset: 0x00005958
		static int \u202C\u206F\u200E\u206C\u206F\u200F\u206D\u202C\u200D\u206C\u202A\u206E\u200E\u202B\u200F\u200E\u200B\u202A\u200D\u200D\u206F\u202A\u202A\u206E\u202B\u206A\u202B\u200D\u206D\u200D\u206C\u200E\u202C\u202A\u200F\u200B\u200B\u202B\u206D\u206A\u202E()
		{
			return Screen.width;
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x0000CAF0 File Offset: 0x0000ACF0
		static int \u200D\u206C\u202A\u200D\u202B\u200F\u206D\u202A\u206A\u202C\u200F\u206B\u206E\u200C\u206C\u206D\u206E\u202B\u206D\u206A\u202D\u206C\u200C\u206E\u206C\u200C\u206D\u206D\u202A\u200E\u202E\u200B\u202E\u200E\u206D\u206D\u200D\u200C\u202E\u202E\u202E(ushort A_0, byte A_1, byte[] A_2, ItemIconReady A_3)
		{
			return ItemTool.getIcon(A_0, A_1, A_2, A_3);
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x0000CB08 File Offset: 0x0000AD08
		static SteamChannel \u200E\u202E\u200F\u202E\u200F\u200C\u200B\u206C\u200D\u202B\u206B\u206B\u200F\u206B\u202D\u206B\u200C\u200C\u206D\u200C\u206F\u200D\u200F\u200F\u200E\u206B\u206C\u202E\u200D\u206D\u202B\u206F\u200F\u200C\u202A\u202B\u206E\u206F\u206D\u206E\u202E(Player A_0)
		{
			return A_0.channel;
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x0000CB1C File Offset: 0x0000AD1C
		static SteamPlayerID \u206E\u206B\u206D\u206D\u206D\u206C\u202A\u206D\u206B\u206C\u206B\u202A\u206E\u206F\u202E\u202E\u206A\u206C\u202D\u200B\u206E\u202B\u206B\u202A\u206D\u202A\u202A\u202B\u206E\u202B\u200F\u206A\u202A\u206F\u202A\u200B\u200B\u202C\u206B\u200F\u202E(SteamPlayer A_0)
		{
			return A_0.playerID;
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x0000CB30 File Offset: 0x0000AD30
		static string \u206F\u206F\u206A\u202D\u202C\u200E\u202C\u206E\u200C\u200C\u206B\u200D\u200D\u200E\u202C\u206E\u202D\u206A\u202B\u206A\u206D\u202D\u206D\u202C\u200B\u200C\u200F\u200F\u200B\u206B\u206B\u206C\u202E\u200C\u200F\u202E\u200F\u202A\u206C\u206C\u202E(SteamPlayerID A_0)
		{
			return A_0.characterName;
		}

		// Token: 0x060000DA RID: 218 RVA: 0x0000CB44 File Offset: 0x0000AD44
		static string \u200E\u200E\u206F\u202B\u206C\u206A\u200B\u200F\u206A\u202C\u206B\u202D\u200B\u200E\u200B\u202B\u202B\u200B\u202B\u206C\u202C\u206A\u206E\u202E\u206D\u202E\u200F\u200D\u206C\u206C\u202E\u206A\u200D\u200D\u202B\u202B\u200B\u206F\u202B\u206D\u202E(string A_0, string A_1)
		{
			return A_0 + A_1;
		}

		// Token: 0x060000DB RID: 219 RVA: 0x000078CC File Offset: 0x00005ACC
		static PlayerEquipment \u200E\u206F\u202C\u206C\u202E\u200E\u206B\u200C\u206A\u200E\u206F\u206E\u206E\u202C\u202D\u200F\u202E\u202E\u200C\u206B\u206A\u202B\u206E\u200B\u200C\u206B\u202E\u202B\u206C\u202B\u200E\u206E\u202C\u206A\u200B\u200F\u200B\u206E\u202C\u202E\u202E(Player A_0)
		{
			return A_0.equipment;
		}

		// Token: 0x060000DC RID: 220 RVA: 0x0000CB58 File Offset: 0x0000AD58
		static ItemAsset \u206B\u206B\u206F\u202B\u200E\u200C\u200E\u202A\u206F\u206F\u202D\u202A\u206C\u200C\u206C\u202E\u206A\u202C\u202D\u200F\u202B\u206E\u202B\u206F\u206C\u200C\u202E\u202C\u200B\u202E\u200B\u202B\u206F\u200F\u202B\u200C\u206F\u202B\u202D\u200F\u202E(PlayerEquipment A_0)
		{
			return A_0.asset;
		}

		// Token: 0x060000DD RID: 221 RVA: 0x000078E0 File Offset: 0x00005AE0
		static ItemAsset \u200B\u202B\u200C\u200B\u200B\u200B\u206D\u202C\u206E\u200F\u202E\u200C\u202D\u202C\u206A\u200F\u206E\u202B\u200F\u200E\u200F\u202C\u200E\u206F\u200E\u200C\u206D\u202D\u206D\u202A\u200C\u206F\u200E\u200E\u206F\u200E\u202C\u202B\u200C\u202D\u202E(PlayerEquipment A_0)
		{
			return A_0.asset;
		}

		// Token: 0x060000DE RID: 222 RVA: 0x0000CB6C File Offset: 0x0000AD6C
		static int \u206D\u200E\u206F\u206B\u206E\u202A\u206D\u202A\u206B\u202D\u200E\u200D\u206F\u206E\u206C\u206D\u200F\u206D\u202E\u202D\u200C\u206C\u206B\u206F\u200F\u206B\u206A\u206A\u202C\u200E\u206B\u202D\u206E\u206B\u206A\u202A\u206B\u200B\u206A\u202D\u202E(string A_0)
		{
			return A_0.Length;
		}

		// Token: 0x060000DF RID: 223 RVA: 0x0000CB80 File Offset: 0x0000AD80
		static string \u202E\u202B\u202B\u206D\u202E\u202C\u206A\u206D\u202D\u200F\u202E\u206D\u202D\u206A\u200E\u202D\u202B\u202D\u206B\u206C\u206F\u200E\u202C\u200D\u200D\u200F\u202B\u200F\u200F\u206A\u200C\u200F\u200B\u206E\u206D\u202C\u202B\u200D\u206F\u202E(string A_0, int A_1, int A_2)
		{
			return A_0.Substring(A_1, A_2);
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x0000CB98 File Offset: 0x0000AD98
		static string \u206E\u206E\u202A\u202A\u206F\u200E\u206D\u206D\u202B\u206C\u200F\u202E\u200C\u206E\u200E\u206F\u200B\u206A\u202C\u206A\u206B\u206D\u200B\u200B\u202A\u206F\u200E\u206D\u206A\u200D\u200D\u206D\u200E\u206A\u206C\u206C\u206C\u200B\u202B\u206D\u202E(string A_0, string A_1, string A_2)
		{
			return A_0 + A_1 + A_2;
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x0000CBB0 File Offset: 0x0000ADB0
		static Vector3 \u200E\u200F\u206E\u206B\u202C\u200B\u202C\u206F\u200E\u200E\u200D\u200B\u202D\u202A\u200E\u202E\u200C\u200B\u206B\u200E\u200D\u200B\u206C\u206E\u202E\u202C\u206D\u206A\u206B\u206E\u200D\u200D\u200C\u202C\u206D\u202C\u200D\u200B\u206A\u202C\u202E(Transform A_0)
		{
			return A_0.position;
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x000077BC File Offset: 0x000059BC
		static bool \u206D\u206F\u202B\u206D\u200C\u200F\u200D\u200E\u206F\u200C\u200E\u202D\u202A\u202B\u202C\u206C\u200B\u206A\u202E\u200C\u202B\u200C\u206C\u202A\u206C\u206A\u206B\u206A\u206C\u202E\u202E\u200E\u200D\u206A\u206E\u206A\u206A\u202C\u206C\u206E\u202E(Vector3 A_0, Vector3 A_1, ref RaycastHit A_2, float A_3, int A_4)
		{
			return Physics.Raycast(A_0, A_1, ref A_2, A_3, A_4);
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x000077D4 File Offset: 0x000059D4
		static Player \u200E\u200C\u206F\u206E\u200C\u200F\u200F\u206D\u202B\u202C\u206E\u200C\u206A\u202D\u200F\u200C\u200E\u206A\u202E\u206F\u202D\u202A\u206A\u202E\u206E\u200E\u202B\u206B\u206F\u206A\u206B\u200F\u202D\u206F\u206A\u200E\u202A\u202D\u202D\u206A\u202E(Transform A_0)
		{
			return DamageTool.getPlayer(A_0);
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x000061FC File Offset: 0x000043FC
		static void \u206C\u206C\u206F\u202B\u202C\u206D\u202A\u206F\u202C\u200E\u202E\u206A\u202C\u206D\u200B\u206B\u206F\u202C\u206D\u200B\u202E\u206C\u206E\u206F\u202D\u202E\u202C\u202A\u200F\u206E\u206A\u200D\u200C\u202C\u206B\u206D\u200D\u206B\u206D\u200D\u202E(Object A_0)
		{
			Object.Destroy(A_0);
		}

		// Token: 0x04000047 RID: 71
		private Entities entities;

		// Token: 0x04000048 RID: 72
		public bool espEnabled = true;

		// Token: 0x04000049 RID: 73
		public float maxDistance = 2000f;

		// Token: 0x0400004A RID: 74
		public bool showInfoText = true;

		// Token: 0x0400004B RID: 75
		public float infoTextOffsetY = -0.15f;

		// Token: 0x0400004C RID: 76
		public bool infoTextShowWeapon = true;

		// Token: 0x0400004D RID: 77
		public int infoTextSize = 11;

		// Token: 0x0400004E RID: 78
		public bool showBoxes = true;

		// Token: 0x0400004F RID: 79
		public bool showSkeleton = true;

		// Token: 0x04000050 RID: 80
		public bool showGlow = true;

		// Token: 0x04000051 RID: 81
		public bool showSnaplines = true;

		// Token: 0x04000052 RID: 82
		public float snaplineThickness = 1.4f;

		// Token: 0x04000053 RID: 83
		public bool snaplineToFeet = true;

		// Token: 0x04000054 RID: 84
		public bool snaplineAlphaFalloff = true;

		// Token: 0x04000055 RID: 85
		private bool preferHead = true;

		// Token: 0x04000056 RID: 86
		public bool showItemGlow = true;

		// Token: 0x04000057 RID: 87
		public bool showItemIcons = true;

		// Token: 0x04000058 RID: 88
		public float itemIconScale = 0.8f;

		// Token: 0x04000059 RID: 89
		public bool showItemName = true;

		// Token: 0x0400005A RID: 90
		private float lastCleanupTime;

		// Token: 0x0400005B RID: 91
		public bool showVehicleGlow = true;

		// Token: 0x0400005C RID: 92
		public bool showVehicleName = true;

		// Token: 0x0400005D RID: 93
		public bool showBedGlow = true;

		// Token: 0x0400005E RID: 94
		public bool showBedName = true;

		// Token: 0x0400005F RID: 95
		public bool showClaimGlow = true;

		// Token: 0x04000060 RID: 96
		public bool showClaimName = true;

		// Token: 0x04000061 RID: 97
		public bool showFurnitureGlow = true;

		// Token: 0x04000062 RID: 98
		public bool showFurnitureName = true;

		// Token: 0x04000063 RID: 99
		private const float POSITION_CACHE_DURATION = 0.4f;

		// Token: 0x04000064 RID: 100
		private static readonly Color COLOR_BOX = new Color(1f, 1f, 1f, 0.92f);

		// Token: 0x04000065 RID: 101
		private static readonly Color COLOR_SKELETON = new Color(1f, 0f, 0f, 0.85f);

		// Token: 0x04000066 RID: 102
		private static readonly Color COLOR_TEXT;

		// Token: 0x04000067 RID: 103
		private static readonly Color COLOR_TEXT_SHADOW;

		// Token: 0x04000068 RID: 104
		private GUIStyle objectTextStyle;

		// Token: 0x04000069 RID: 105
		private GUIStyle itemTextStyle;

		// Token: 0x0400006A RID: 106
		private GUIStyle playerInfoTextStyle;

		// Token: 0x0400006B RID: 107
		private bool cameraChecked;

		// Token: 0x0400006C RID: 108
		public readonly Dictionary<Transform, Highlighter> highlighters = new Dictionary<Transform, Highlighter>();

		// Token: 0x0400006D RID: 109
		private static readonly Dictionary<ushort, Texture2D> itemIconCache;

		// Token: 0x0400006E RID: 110
		[TupleElementNames(new string[]
		{
			"screenPos",
			"lastUpdateTime"
		})]
		private Dictionary<InteractableItem, ValueTuple<Vector3, float>> textPositionCache = new Dictionary<InteractableItem, ValueTuple<Vector3, float>>();
	}
}
