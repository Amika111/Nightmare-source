using System;
using System.Runtime.CompilerServices;
using Cheat.core;
using UnityEngine;

namespace Cheat
{
	// Token: 0x0200000C RID: 12
	public static class Loader
	{
		// Token: 0x06000039 RID: 57 RVA: 0x000060CC File Offset: 0x000042CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Load()
		{
			Loader.cheatObject = Loader.\u200D\u200B\u200F\u200D\u202D\u206F\u206D\u206B\u206A\u206D\u202A\u202D\u200C\u202E\u202E\u206C\u200B\u200C\u200B\u206C\u200E\u200E\u206E\u206A\u200D\u202C\u206A\u200E\u200B\u206F\u202B\u200D\u206B\u202E\u202A\u202D\u200B\u206B\u206A\u200C\u202E(<Module>.\u200B\u206C\u200C\u200C\u206A\u200B\u200D\u206C\u206B\u206D\u202B\u200F\u200E\u206E\u206A\u200D\u206B\u202E\u206A\u200E\u200B\u202E\u200F\u206C\u200F\u202A\u202B\u200F\u200D\u200C\u202D\u200E\u206B\u200D\u202A\u200E\u202E\u206A\u202B\u200C\u202E<string>(111790392));
			for (;;)
			{
				IL_16:
				uint num = 3723915474U;
				for (;;)
				{
					uint num2;
					switch ((num2 = (num ^ 3436049668U)) % 4U)
					{
					case 0U:
						goto IL_16;
					case 2U:
						Loader.\u206A\u200B\u202C\u202E\u206B\u202A\u202B\u206B\u206A\u206A\u206E\u202C\u206A\u202A\u202C\u200F\u200F\u202A\u200B\u206C\u206E\u206B\u202B\u200B\u202C\u206F\u200C\u206A\u202C\u202D\u206D\u200D\u206C\u202D\u202B\u206F\u202E\u206A\u202D\u202B\u202E(Loader.cheatObject);
						num = (num2 * 599699566U ^ 97704387U);
						continue;
					case 3U:
						Loader.cheatObject.AddComponent<Main>();
						Log.Init();
						num = (num2 * 3762226773U ^ 2078197734U);
						continue;
					}
					return;
				}
			}
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00006150 File Offset: 0x00004350
		public static void Unload()
		{
			if (Loader.\u206B\u200C\u206E\u200B\u200F\u200F\u200B\u202C\u206A\u202A\u200D\u206A\u206A\u202B\u206E\u206F\u202B\u206B\u202B\u202E\u206D\u206F\u206F\u202D\u206F\u200B\u200D\u200C\u202E\u202E\u206B\u200C\u206C\u206F\u200C\u206F\u200D\u206F\u206A\u202C\u202E(Loader.cheatObject, null))
			{
				for (;;)
				{
					IL_0D:
					uint num = 304559026U;
					for (;;)
					{
						uint num2;
						switch ((num2 = (num ^ 717071756U)) % 4U)
						{
						case 1U:
							Loader.cheatObject = null;
							num = (num2 * 1412501897U ^ 199332365U);
							continue;
						case 2U:
							Loader.\u200E\u206D\u200B\u206B\u206D\u202D\u200F\u200F\u202B\u200F\u206F\u206B\u200F\u206C\u206E\u200C\u200B\u202A\u206F\u206D\u206D\u200C\u206C\u206F\u202B\u200B\u200C\u206A\u200F\u202E\u202A\u202B\u202B\u200C\u202C\u206C\u202D\u206B\u200C\u200C\u202E(Loader.cheatObject);
							num = (num2 * 1278929546U ^ 66941621U);
							continue;
						case 3U:
							goto IL_0D;
						}
						goto Block_1;
					}
				}
				Block_1:;
			}
		}

		// Token: 0x0600003B RID: 59 RVA: 0x000061C0 File Offset: 0x000043C0
		static GameObject \u200D\u200B\u200F\u200D\u202D\u206F\u206D\u206B\u206A\u206D\u202A\u202D\u200C\u202E\u202E\u206C\u200B\u200C\u200B\u206C\u200E\u200E\u206E\u206A\u200D\u202C\u206A\u200E\u200B\u206F\u202B\u200D\u206B\u202E\u202A\u202D\u200B\u206B\u206A\u200C\u202E(string A_0)
		{
			return new GameObject(A_0);
		}

		// Token: 0x0600003C RID: 60 RVA: 0x000061D4 File Offset: 0x000043D4
		static void \u206A\u200B\u202C\u202E\u206B\u202A\u202B\u206B\u206A\u206A\u206E\u202C\u206A\u202A\u202C\u200F\u200F\u202A\u200B\u206C\u206E\u206B\u202B\u200B\u202C\u206F\u200C\u206A\u202C\u202D\u206D\u200D\u206C\u202D\u202B\u206F\u202E\u206A\u202D\u202B\u202E(Object A_0)
		{
			Object.DontDestroyOnLoad(A_0);
		}

		// Token: 0x0600003D RID: 61 RVA: 0x000061E8 File Offset: 0x000043E8
		static bool \u206B\u200C\u206E\u200B\u200F\u200F\u200B\u202C\u206A\u202A\u200D\u206A\u206A\u202B\u206E\u206F\u202B\u206B\u202B\u202E\u206D\u206F\u206F\u202D\u206F\u200B\u200D\u200C\u202E\u202E\u206B\u200C\u206C\u206F\u200C\u206F\u200D\u206F\u206A\u202C\u202E(Object A_0, Object A_1)
		{
			return A_0 != A_1;
		}

		// Token: 0x0600003E RID: 62 RVA: 0x000061FC File Offset: 0x000043FC
		static void \u200E\u206D\u200B\u206B\u206D\u202D\u200F\u200F\u202B\u200F\u206F\u206B\u200F\u206C\u206E\u200C\u200B\u202A\u206F\u206D\u206D\u200C\u206C\u206F\u202B\u200B\u200C\u206A\u200F\u202E\u202A\u202B\u202B\u200C\u202C\u206C\u202D\u206B\u200C\u200C\u202E(Object A_0)
		{
			Object.Destroy(A_0);
		}

		// Token: 0x0400002C RID: 44
		private static GameObject cheatObject;
	}
}
