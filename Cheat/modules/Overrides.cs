using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cheat.core;
using SDG.Unturned;

namespace Cheat.modules
{
	// Token: 0x02000019 RID: 25
	internal static class Overrides
	{
		// Token: 0x0600013D RID: 317 RVA: 0x0000EA38 File Offset: 0x0000CC38
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Awake()
		{
			Utils.OverrideMethod(Overrides.\u206E\u200B\u206B\u202A\u202A\u200D\u206C\u202A\u202A\u206D\u200C\u202B\u202E\u202B\u202C\u200E\u200F\u206E\u206A\u206D\u206B\u206E\u206A\u206E\u206B\u200D\u200B\u200F\u206B\u200D\u202E\u206F\u206E\u202B\u200B\u206C\u202B\u202C\u202A\u200D\u202E(typeof(Player).TypeHandle), Overrides.\u206E\u200B\u206B\u202A\u202A\u200D\u206C\u202A\u202A\u206D\u200C\u202B\u202E\u202B\u202C\u200E\u200F\u206E\u206A\u206D\u206B\u206E\u206A\u206E\u206B\u200D\u200B\u200F\u206B\u200D\u202E\u206F\u206E\u202B\u200B\u206C\u202B\u202C\u202A\u200D\u202E(typeof(hkPlayer).TypeHandle), <Module>.\u202B\u200B\u202C\u206C\u206D\u202C\u206B\u200F\u206D\u206D\u200E\u206A\u202E\u206D\u200D\u206A\u202D\u202B\u200B\u200F\u202C\u206D\u200E\u202D\u200D\u206A\u200F\u206E\u206F\u206F\u200D\u202D\u202C\u200B\u206F\u202C\u202A\u200D\u206E\u202E\u202E<string>(-1465004699), BindingFlags.Instance | BindingFlags.Public, BindingFlags.Instance | BindingFlags.NonPublic);
			Utils.OverrideMethod(Overrides.\u206E\u200B\u206B\u202A\u202A\u200D\u206C\u202A\u202A\u206D\u200C\u202B\u202E\u202B\u202C\u200E\u200F\u206E\u206A\u206D\u206B\u206E\u206A\u206E\u206B\u200D\u200B\u200F\u206B\u200D\u202E\u206F\u206E\u202B\u200B\u206C\u202B\u202C\u202A\u200D\u202E(typeof(PlayerUI).TypeHandle), Overrides.\u206E\u200B\u206B\u202A\u202A\u200D\u206C\u202A\u202A\u206D\u200C\u202B\u202E\u202B\u202C\u200E\u200F\u206E\u206A\u206D\u206B\u206E\u206A\u206E\u206B\u200D\u200B\u200F\u206B\u200D\u202E\u206F\u206E\u202B\u200B\u206C\u202B\u202C\u202A\u200D\u202E(typeof(hkPlayer).TypeHandle), <Module>.\u202B\u200B\u202C\u206C\u206D\u202C\u206B\u200F\u206D\u206D\u200E\u206A\u202E\u206D\u200D\u206A\u202D\u202B\u200B\u200F\u202C\u206D\u200E\u202D\u200D\u206A\u200F\u206E\u206F\u206F\u200D\u202D\u202C\u200B\u206F\u202C\u202A\u200D\u206E\u202E\u202E<string>(-232961798), BindingFlags.Instance | BindingFlags.NonPublic, BindingFlags.Instance | BindingFlags.NonPublic);
		}

		// Token: 0x0600013E RID: 318 RVA: 0x0000EA98 File Offset: 0x0000CC98
		// Note: this type is marked as 'beforefieldinit'.
		static Overrides()
		{
			for (;;)
			{
				IL_06:
				uint num = 4157606373U;
				for (;;)
				{
					uint num2;
					switch ((num2 = (num ^ 2759144555U)) % 3U)
					{
					case 0U:
						goto IL_06;
					case 1U:
						Overrides.bBeingSpied = false;
						num = (num2 * 778234249U ^ 3167347301U);
						continue;
					}
					goto Block_1;
				}
			}
			Block_1:
			Overrides.bPlaySpySound = true;
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00007860 File Offset: 0x00005A60
		static Type \u206E\u200B\u206B\u202A\u202A\u200D\u206C\u202A\u202A\u206D\u200C\u202B\u202E\u202B\u202C\u200E\u200F\u206E\u206A\u206D\u206B\u206E\u206A\u206E\u206B\u200D\u200B\u200F\u206B\u200D\u202E\u206F\u206E\u202B\u200B\u206C\u202B\u202C\u202A\u200D\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		// Token: 0x04000090 RID: 144
		public static bool bHideOnSpy = true;

		// Token: 0x04000091 RID: 145
		public static bool bBeingSpied;

		// Token: 0x04000092 RID: 146
		public static bool bPlaySpySound;
	}
}
