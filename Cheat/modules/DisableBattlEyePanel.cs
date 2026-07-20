using System;
using System.Collections;
using System.Reflection;
using System.Runtime.CompilerServices;
using SDG.Unturned;

namespace Cheat.modules
{
	// Token: 0x0200000F RID: 15
	public class DisableBattlEyePanel
	{
		// Token: 0x06000076 RID: 118 RVA: 0x00007AA4 File Offset: 0x00005CA4
		public static IEnumerator DisablePanelRoutine()
		{
			return new DisableBattlEyePanel.<DisablePanelRoutine>d__0(0);
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00007AB8 File Offset: 0x00005CB8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void DisablePanel()
		{
			FieldInfo fieldInfo = DisableBattlEyePanel.\u202C\u206C\u202C\u206D\u206F\u206F\u202A\u206D\u202C\u206B\u202E\u200B\u202E\u202E\u202D\u206E\u200C\u202C\u202C\u200F\u206C\u206C\u200C\u202A\u202C\u206A\u206B\u206F\u200E\u206F\u206F\u206D\u206B\u202A\u206C\u202B\u202B\u206C\u200D\u202E\u202E(DisableBattlEyePanel.\u206D\u202C\u200D\u206A\u202A\u202E\u202D\u206D\u206A\u200F\u200F\u206C\u200C\u206B\u200C\u200B\u200D\u200C\u200C\u202D\u200E\u206D\u206C\u202C\u202A\u200F\u202B\u206B\u200B\u200C\u202B\u200F\u202C\u200D\u202E\u200B\u202E\u200F\u206B\u206E\u202E(typeof(Dedicator).TypeHandle), <Module>.\u200B\u206C\u200C\u200C\u206A\u200B\u200D\u206C\u206B\u206D\u202B\u200F\u200E\u206E\u206A\u200D\u206B\u202E\u206A\u200E\u200B\u202E\u200F\u206C\u200F\u202A\u202B\u200F\u200D\u200C\u202D\u200E\u206B\u200D\u202A\u200E\u202E\u206A\u202B\u200C\u202E<string>(-871390671), BindingFlags.Static | BindingFlags.NonPublic);
			for (;;)
			{
				IL_1E:
				uint num = 2752017990U;
				for (;;)
				{
					uint num2;
					switch ((num2 = (num ^ 3620469321U)) % 4U)
					{
					case 0U:
						goto IL_1E;
					case 2U:
						DisableBattlEyePanel.\u206D\u202B\u206B\u206E\u206E\u200D\u206C\u206F\u200B\u206E\u200C\u206E\u200D\u206F\u200C\u202B\u202B\u206A\u206C\u206F\u200B\u206B\u206A\u200E\u202B\u206E\u206A\u200B\u206D\u202C\u206B\u202A\u202A\u202B\u202A\u206C\u200F\u202A\u200D\u206A\u202E(fieldInfo, null, true);
						num = (num2 * 754437387U ^ 3159491262U);
						continue;
					case 3U:
						num = (((!DisableBattlEyePanel.\u202C\u206E\u202C\u206E\u206D\u202A\u206C\u206C\u200D\u206D\u202A\u206E\u206F\u200B\u202D\u206D\u206D\u202D\u206A\u202A\u202D\u202C\u200D\u200B\u206D\u200C\u202A\u200E\u206E\u200C\u202C\u206A\u200D\u206E\u202C\u202C\u206D\u200D\u200D\u206C\u202E(fieldInfo, null)) ? 3156674042U : 4021855001U) ^ num2 * 3768790658U);
						continue;
					}
					return;
				}
			}
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00007860 File Offset: 0x00005A60
		static Type \u206D\u202C\u200D\u206A\u202A\u202E\u202D\u206D\u206A\u200F\u200F\u206C\u200C\u206B\u200C\u200B\u200D\u200C\u200C\u202D\u200E\u206D\u206C\u202C\u202A\u200F\u202B\u206B\u200B\u200C\u202B\u200F\u202C\u200D\u202E\u200B\u202E\u200F\u206B\u206E\u202E(RuntimeTypeHandle A_0)
		{
			return Type.GetTypeFromHandle(A_0);
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00007874 File Offset: 0x00005A74
		static FieldInfo \u202C\u206C\u202C\u206D\u206F\u206F\u202A\u206D\u202C\u206B\u202E\u200B\u202E\u202E\u202D\u206E\u200C\u202C\u202C\u200F\u206C\u206C\u200C\u202A\u202C\u206A\u206B\u206F\u200E\u206F\u206F\u206D\u206B\u202A\u206C\u202B\u202B\u206C\u200D\u202E\u202E(Type A_0, string A_1, BindingFlags A_2)
		{
			return A_0.GetField(A_1, A_2);
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00007B48 File Offset: 0x00005D48
		static bool \u202C\u206E\u202C\u206E\u206D\u202A\u206C\u206C\u200D\u206D\u202A\u206E\u206F\u200B\u202D\u206D\u206D\u202D\u206A\u202A\u202D\u202C\u200D\u200B\u206D\u200C\u202A\u200E\u206E\u200C\u202C\u206A\u200D\u206E\u202C\u202C\u206D\u200D\u200D\u206C\u202E(FieldInfo A_0, FieldInfo A_1)
		{
			return A_0 != A_1;
		}

		// Token: 0x0600007C RID: 124 RVA: 0x000078B4 File Offset: 0x00005AB4
		static void \u206D\u202B\u206B\u206E\u206E\u200D\u206C\u206F\u200B\u206E\u200C\u206E\u200D\u206F\u200C\u202B\u202B\u206A\u206C\u206F\u200B\u206B\u206A\u200E\u202B\u206E\u206A\u200B\u206D\u202C\u206B\u202A\u202A\u202B\u202A\u206C\u200F\u202A\u200D\u206A\u202E(FieldInfo A_0, object A_1, object A_2)
		{
			A_0.SetValue(A_1, A_2);
		}
	}
}
