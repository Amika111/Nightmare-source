using System;
using System.Collections;
using SDG.Unturned;
using UnityEngine;

namespace Cheat.modules
{
	// Token: 0x02000015 RID: 21
	internal class hkPlayer : MonoBehaviour
	{
		// Token: 0x06000102 RID: 258 RVA: 0x0000D304 File Offset: 0x0000B504
		internal void Ov_onMoonUpdated(bool isFullMoon)
		{
		}

		// Token: 0x06000103 RID: 259 RVA: 0x0000D314 File Offset: 0x0000B514
		[SteamCall(1, legacyName = "askScreenshot")]
		internal void Ov_ReceiveTakeScreenshot()
		{
			if (!Overrides.bBeingSpied)
			{
				goto IL_3D;
			}
			IL_07:
			int num = -1042009080;
			IL_0C:
			switch ((num ^ -1552796479) % 4)
			{
			case 0:
				IL_3D:
				hkPlayer.\u200F\u206D\u200E\u206F\u200C\u202C\u202B\u206C\u200F\u206C\u206F\u200C\u200C\u206B\u206D\u206A\u206E\u206A\u206E\u202A\u200C\u200F\u202D\u202E\u200E\u206C\u206E\u200B\u202B\u202C\u202C\u206E\u202C\u202C\u206A\u202D\u206D\u206A\u200D\u206C\u202E(this, hkPlayer.TakeScreenshot());
				num = -1825052625;
				goto IL_0C;
			case 1:
				return;
			case 3:
				goto IL_07;
			}
		}

		// Token: 0x06000104 RID: 260 RVA: 0x0000D374 File Offset: 0x0000B574
		private static IEnumerator TakeScreenshot()
		{
			return new hkPlayer.<TakeScreenshot>d__3(0);
		}

		// Token: 0x06000107 RID: 263 RVA: 0x0000D3C0 File Offset: 0x0000B5C0
		static Coroutine \u200F\u206D\u200E\u206F\u200C\u202C\u202B\u206C\u200F\u206C\u206F\u200C\u200C\u206B\u206D\u206A\u206E\u206A\u206E\u202A\u200C\u200F\u202D\u202E\u200E\u206C\u206E\u200B\u202B\u202C\u202C\u206E\u202C\u202C\u206A\u202D\u206D\u206A\u200D\u206C\u202E(MonoBehaviour A_0, IEnumerator A_1)
		{
			return A_0.StartCoroutine(A_1);
		}

		// Token: 0x04000075 RID: 117
		internal static StaticResourceRef<AudioClip> hitCriticalSound = new StaticResourceRef<AudioClip>(<Module>.\u202E\u206C\u206E\u202C\u202D\u202D\u206D\u206B\u202B\u206F\u200B\u206E\u200B\u202C\u202A\u200D\u202D\u200B\u202D\u202E\u200D\u206F\u206C\u202C\u200B\u202C\u206D\u202B\u206C\u206E\u200E\u206A\u200D\u206F\u200E\u206E\u206A\u200C\u200D\u206B\u202E<string>(379175529));
	}
}
