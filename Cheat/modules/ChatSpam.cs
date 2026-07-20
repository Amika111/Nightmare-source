using System;
using System.Runtime.CompilerServices;
using SDG.Unturned;
using UnityEngine;

namespace Cheat.modules
{
	// Token: 0x0200000E RID: 14
	public class ChatSpam : MonoBehaviour
	{
		// Token: 0x0600006F RID: 111 RVA: 0x00007944 File Offset: 0x00005B44
		private void Update()
		{
			if (this.Enabled)
			{
				for (;;)
				{
					IL_0B:
					uint num = 2697969088U;
					for (;;)
					{
						uint num2;
						switch ((num2 = (num ^ 4088552025U)) % 8U)
						{
						case 0U:
							this.lastSpamTime = ChatSpam.\u202A\u206E\u200B\u202A\u202A\u206F\u206D\u200D\u202B\u206E\u206C\u202C\u202A\u200C\u202E\u202A\u202A\u202E\u200E\u206F\u206A\u206E\u200B\u202B\u202D\u200F\u202A\u200F\u200B\u202C\u202C\u206E\u206D\u206A\u200D\u206C\u200C\u206E\u200E\u202E\u202E();
							num = (num2 * 710534842U ^ 1434751638U);
							continue;
						case 1U:
							num = (((!ChatSpam.\u202C\u206F\u206B\u200B\u206F\u200D\u206A\u206A\u200E\u202C\u202E\u200B\u206D\u200B\u206B\u202A\u200C\u200F\u200E\u206A\u200D\u200C\u202C\u206A\u202A\u202D\u200B\u206F\u206A\u202E\u206B\u206D\u200E\u202D\u206D\u200E\u200E\u202E\u200F\u202D\u202E()) ? 3382032622U : 2209646789U) ^ num2 * 1507479609U);
							continue;
						case 2U:
							ChatSpam.\u202A\u202D\u200B\u202A\u200B\u200F\u202C\u200D\u206E\u200C\u200B\u206E\u206D\u200B\u206E\u202D\u200F\u202A\u202B\u200D\u206A\u206F\u200B\u200E\u202A\u206C\u200B\u202C\u200E\u202A\u200E\u200C\u206C\u202C\u202A\u202C\u206C\u202E\u202E\u206C\u202E(0, this.SpamText);
							num = (num2 * 254559280U ^ 4190476697U);
							continue;
						case 3U:
							num = ((ChatSpam.\u202A\u206E\u200B\u202A\u202A\u206F\u206D\u200D\u202B\u206E\u206C\u202C\u202A\u200C\u202E\u202A\u202A\u202E\u200E\u206F\u206A\u206E\u200B\u202B\u202D\u200F\u202A\u200F\u200B\u202C\u202C\u206E\u206D\u206A\u200D\u206C\u200C\u206E\u200E\u202E\u202E() - this.lastSpamTime < this.Interval) ? 4218647766U : 3695433851U);
							continue;
						case 4U:
							goto IL_0B;
						case 5U:
							num = ((ChatSpam.\u206D\u202B\u202C\u202E\u202B\u200D\u200C\u206A\u200E\u202B\u202E\u202A\u202D\u206C\u200E\u206E\u206F\u206E\u206B\u200E\u202C\u206D\u206F\u206D\u200E\u200B\u200E\u200D\u206A\u206A\u206A\u206C\u200E\u200B\u200D\u206A\u206C\u200D\u206F\u206D\u202E() ? 3456374795U : 3256718854U) ^ num2 * 1544286916U);
							continue;
						case 6U:
							return;
						}
						return;
					}
				}
				return;
			}
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00007A44 File Offset: 0x00005C44
		public void Toggle()
		{
			this.Enabled = !this.Enabled;
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00007A60 File Offset: 0x00005C60
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ChatSpam()
		{
		}

		// Token: 0x06000072 RID: 114 RVA: 0x000076B8 File Offset: 0x000058B8
		static bool \u202C\u206F\u206B\u200B\u206F\u200D\u206A\u206A\u200E\u202C\u202E\u200B\u206D\u200B\u206B\u202A\u200C\u200F\u200E\u206A\u200D\u200C\u202C\u206A\u202A\u202D\u200B\u206F\u206A\u202E\u206B\u206D\u200E\u202D\u206D\u200E\u200E\u202E\u200F\u202D\u202E()
		{
			return Provider.isConnected;
		}

		// Token: 0x06000073 RID: 115 RVA: 0x000076CC File Offset: 0x000058CC
		static bool \u206D\u202B\u202C\u202E\u202B\u200D\u200C\u206A\u200E\u202B\u202E\u202A\u202D\u206C\u200E\u206E\u206F\u206E\u206B\u200E\u202C\u206D\u206F\u206D\u200E\u200B\u200E\u200D\u206A\u206A\u206A\u206C\u200E\u200B\u200D\u206A\u206C\u200D\u206F\u206D\u202E()
		{
			return Provider.isLoading;
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00007730 File Offset: 0x00005930
		static float \u202A\u206E\u200B\u202A\u202A\u206F\u206D\u200D\u202B\u206E\u206C\u202C\u202A\u200C\u202E\u202A\u202A\u202E\u200E\u206F\u206A\u206E\u200B\u202B\u202D\u200F\u202A\u200F\u200B\u202C\u202C\u206E\u206D\u206A\u200D\u206C\u200C\u206E\u200E\u202E\u202E()
		{
			return Time.time;
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00007A90 File Offset: 0x00005C90
		static void \u202A\u202D\u200B\u202A\u200B\u200F\u202C\u200D\u206E\u200C\u200B\u206E\u206D\u200B\u206E\u202D\u200F\u202A\u202B\u200D\u206A\u206F\u200B\u200E\u202A\u206C\u200B\u202C\u200E\u202A\u200E\u200C\u206C\u202C\u202A\u202C\u206C\u202E\u202E\u206C\u202E(EChatMode A_0, string A_1)
		{
			ChatManager.sendChat(A_0, A_1);
		}

		// Token: 0x04000040 RID: 64
		public bool Enabled;

		// Token: 0x04000041 RID: 65
		public string SpamText = <Module>.\u200B\u206C\u200C\u200C\u206A\u200B\u200D\u206C\u206B\u206D\u202B\u200F\u200E\u206E\u206A\u200D\u206B\u202E\u206A\u200E\u200B\u202E\u200F\u206C\u200F\u202A\u202B\u200F\u200D\u200C\u202D\u200E\u206B\u200D\u202A\u200E\u202E\u206A\u202B\u200C\u202E<string>(-847872946);

		// Token: 0x04000042 RID: 66
		public float Interval = 0.5f;

		// Token: 0x04000043 RID: 67
		private float lastSpamTime;
	}
}
