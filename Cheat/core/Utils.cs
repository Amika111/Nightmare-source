using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SDG.Unturned;
using Steamworks;
using UnityEngine;

namespace Cheat.core
{
	// Token: 0x02000025 RID: 37
	internal static class Utils
	{
		// Token: 0x06000247 RID: 583 RVA: 0x0001ABA4 File Offset: 0x00018DA4
		internal static Transform GetLimb(Transform root, ELimb limb)
		{
			if (Utils.\u200C\u200D\u202B\u206B\u206F\u206C\u206B\u206B\u200B\u200F\u202C\u202E\u200F\u200B\u202B\u206F\u202C\u206E\u202E\u200E\u200B\u206E\u202B\u206A\u200F\u206E\u202A\u202A\u202E\u202C\u202D\u202A\u200E\u206A\u206F\u202D\u200F\u202B\u206C\u206F\u202E(root, null))
			{
				goto IL_0C;
			}
			goto IL_144;
			uint num2;
			Dictionary<ELimb, Transform> dictionary;
			for (;;)
			{
				IL_11:
				uint num;
				switch ((num = (num2 ^ 525590165U)) % 17U)
				{
				case 0U:
				{
					Transform transform;
					return transform;
				}
				case 1U:
				{
					Transform transform2;
					num2 = (((!Utils.\u200D\u202B\u202C\u200E\u206A\u200B\u206B\u200E\u202E\u202C\u202B\u200D\u202C\u202E\u206C\u202D\u200D\u200E\u206D\u200F\u206B\u206B\u200D\u206F\u202A\u202E\u200F\u200C\u202E\u206F\u202E\u202E\u200D\u206A\u206A\u202B\u202E\u206F\u206F\u202A\u202E(transform2, null)) ? 973942166U : 2121568593U) ^ num * 3089753164U);
					continue;
				}
				case 2U:
				{
					int num3;
					num3++;
					num2 = 545267762U;
					continue;
				}
				case 3U:
				{
					Transform transform2;
					return transform2;
				}
				case 4U:
					num2 = (num * 2793395383U ^ 272983935U);
					continue;
				case 5U:
					goto IL_144;
				case 6U:
				{
					Transform transform;
					dictionary[limb] = transform;
					num2 = (num * 3675427536U ^ 1230261477U);
					continue;
				}
				case 7U:
				{
					Transform transform;
					num2 = (((Utils.\u202C\u202A\u202E\u206B\u202B\u200C\u206A\u202A\u200B\u200B\u200E\u202B\u202D\u202C\u202D\u202A\u202D\u206D\u202D\u202B\u202D\u202A\u202A\u206C\u206D\u202D\u200E\u206D\u202E\u206C\u200E\u202B\u200E\u202C\u206F\u202E\u202D\u206D\u206B\u202D\u202E(transform) != limb) ? 1873427458U : 386681619U) ^ num * 707003383U);
					continue;
				}
				case 8U:
					goto IL_0C;
				case 9U:
				{
					Transform[] componentsInChildren = root.GetComponentsInChildren<Transform>();
					int num3 = 0;
					num2 = 13579918U;
					continue;
				}
				case 10U:
					Utils.limbCache[root] = dictionary;
					num2 = (num * 534348617U ^ 4084916409U);
					continue;
				case 11U:
				{
					int num3;
					Transform[] componentsInChildren;
					Transform transform = componentsInChildren[num3];
					num2 = 958526253U;
					continue;
				}
				case 12U:
				{
					Transform transform2;
					num2 = (dictionary.TryGetValue(limb, out transform2) ? 2134984873U : 2028151878U);
					continue;
				}
				case 13U:
					dictionary = new Dictionary<ELimb, Transform>();
					num2 = (num * 3560217410U ^ 2812219513U);
					continue;
				case 14U:
					goto IL_8E;
				case 15U:
				{
					int num3;
					Transform[] componentsInChildren;
					num2 = ((num3 >= componentsInChildren.Length) ? 901139259U : 315595645U);
					continue;
				}
				}
				break;
			}
			goto IL_1E5;
			IL_8E:
			return null;
			IL_1E5:
			return null;
			IL_0C:
			num2 = 1295029643U;
			goto IL_11;
			IL_144:
			num2 = (Utils.limbCache.TryGetValue(root, out dictionary) ? 1202076777U : 931132683U);
			goto IL_11;
		}

		// Token: 0x06000248 RID: 584 RVA: 0x0001AD98 File Offset: 0x00018F98
		internal static void CleanLimbCache()
		{
			using (List<Transform>.Enumerator enumerator = (from k in Utils.limbCache.Keys
			where Utils.<>c.\u202A\u200D\u206E\u206C\u206C\u200D\u202E\u206B\u206C\u200C\u206A\u200D\u200C\u206A\u206F\u200C\u206B\u206D\u202E\u200F\u200D\u200C\u200C\u206F\u202A\u206E\u200F\u202A\u206B\u200F\u206E\u200B\u202A\u202E\u206A\u206F\u206E\u202A\u206D\u206C\u202E(k, null)
			select k).ToList<Transform>().GetEnumerator())
			{
				for (;;)
				{
					IL_65:
					uint num = enumerator.MoveNext() ? 1866882347U : 2057625546U;
					for (;;)
					{
						uint num2;
						switch ((num2 = (num ^ 1392520594U)) % 5U)
						{
						case 1U:
							goto IL_65;
						case 2U:
						{
							Transform key = enumerator.Current;
							num = 2099802912U;
							continue;
						}
						case 3U:
						{
							Transform key;
							Utils.limbCache.Remove(key);
							num = (num2 * 260419829U ^ 2781677593U);
							continue;
						}
						case 4U:
							num = 1866882347U;
							continue;
						}
						goto Block_4;
					}
				}
				Block_4:;
			}
		}

		// Token: 0x06000249 RID: 585 RVA: 0x0001AE70 File Offset: 0x00019070
		internal static bool SetPrivateField(object obj, string fieldName, object value)
		{
			FieldInfo fieldInfo = Utils.\u206F\u206E\u206A\u206D\u202C\u200C\u202A\u206B\u206C\u206C\u206B\u200F\u200F\u206A\u202E\u206F\u202D\u200D\u200E\u202D\u206A\u206A\u202A\u200C\u200D\u200D\u200B\u202C\u206C\u200B\u202D\u202E\u206E\u206D\u206E\u202B\u202D\u202E\u202C\u200E\u202E(Utils.\u202C\u206B\u206E\u200C\u202B\u206C\u206C\u202A\u200E\u200F\u206F\u202B\u206F\u206A\u202B\u200F\u202A\u200D\u202C\u206E\u206A\u200F\u200B\u206A\u200D\u202D\u206D\u200F\u202A\u200D\u200F\u202E\u206B\u200B\u200F\u202C\u202B\u202A\u202E\u202E(obj), fieldName, BindingFlags.Instance | BindingFlags.NonPublic);
			if (Utils.\u206A\u206E\u202B\u206C\u206F\u206D\u206D\u206C\u200B\u202C\u206E\u202E\u200E\u206C\u202D\u206C\u200C\u206E\u202E\u200B\u200D\u202B\u206D\u206B\u206C\u200E\u202B\u202D\u206D\u200D\u206D\u206E\u202C\u206D\u206A\u206E\u206D\u200E\u202D\u200E\u202E(fieldInfo, null))
			{
				for (;;)
				{
					switch ((-944138778 ^ -1318241314) % 3)
					{
					case 0:
						continue;
					case 2:
						return false;
					}
					break;
				}
			}
			Utils.\u206F\u206D\u202D\u202D\u206B\u200B\u202C\u206E\u200C\u200F\u206A\u206C\u200E\u200F\u200B\u200D\u202C\u206C\u200B\u206F\u206F\u202B\u202D\u200C\u200F\u200F\u206F\u202A\u200D\u202D\u202E\u200D\u200D\u200F\u202B\u200B\u206D\u202E\u202D\u206E\u202E(fieldInfo, obj, value);
			return true;
		}

		// Token: 0x0600024A RID: 586 RVA: 0x0001AED4 File Offset: 0x000190D4
		internal static object GetPrivateField(object obj, string fieldName)
		{
			FieldInfo fieldInfo = Utils.\u206F\u206E\u206A\u206D\u202C\u200C\u202A\u206B\u206C\u206C\u206B\u200F\u200F\u206A\u202E\u206F\u202D\u200D\u200E\u202D\u206A\u206A\u202A\u200C\u200D\u200D\u200B\u202C\u206C\u200B\u202D\u202E\u206E\u206D\u206E\u202B\u202D\u202E\u202C\u200E\u202E(Utils.\u202C\u206B\u206E\u200C\u202B\u206C\u206C\u202A\u200E\u200F\u206F\u202B\u206F\u206A\u202B\u200F\u202A\u200D\u202C\u206E\u206A\u200F\u200B\u206A\u200D\u202D\u206D\u200F\u202A\u200D\u200F\u202E\u206B\u200B\u200F\u202C\u202B\u202A\u202E\u202E(obj), fieldName, BindingFlags.Instance | BindingFlags.NonPublic);
			if (fieldInfo == null)
			{
				return null;
			}
			return Utils.\u202C\u202E\u206C\u206C\u202A\u206E\u200E\u200B\u206C\u206B\u200B\u206D\u200D\u200B\u200B\u202D\u200B\u200E\u202C\u206D\u202C\u206E\u200C\u200C\u200D\u206B\u206B\u200C\u202E\u200D\u200F\u200D\u200B\u200C\u200F\u202B\u202E\u206C\u202C\u202E\u202E(fieldInfo, obj);
		}

		// Token: 0x0600024B RID: 587 RVA: 0x0001AEFC File Offset: 0x000190FC
		internal static void DrawBox(float x, float y, float w, float h, float thickness, Color color)
		{
			Utils.\u202B\u200E\u200E\u200C\u202B\u200C\u202B\u206A\u202C\u206C\u206F\u202D\u206B\u202A\u202C\u200F\u202E\u200D\u200B\u202E\u202A\u202B\u200C\u200F\u206A\u200B\u206E\u206B\u206F\u202B\u202A\u206C\u206F\u202A\u200D\u200E\u200B\u200C\u206D\u202D\u202E(color);
			Utils.\u206F\u202A\u200D\u202D\u200B\u206F\u202A\u206D\u206B\u202C\u202E\u206A\u206D\u200D\u206E\u206B\u200D\u202A\u206F\u206A\u206B\u200D\u206F\u206F\u202B\u206C\u206C\u206F\u202C\u202D\u202D\u202E\u206B\u206B\u202D\u202D\u200F\u200B\u200F\u202E(new Rect(x, y, w, thickness), Utils.\u206E\u200D\u206D\u202C\u202C\u202D\u202D\u200E\u202E\u206B\u202A\u200E\u206A\u202C\u200D\u200C\u202B\u200E\u200C\u206B\u206A\u202C\u202D\u200C\u206C\u206F\u202A\u206D\u200D\u200C\u200E\u200D\u206C\u202A\u200C\u200E\u202A\u200E\u202C\u202E\u202E());
			Utils.\u206F\u202A\u200D\u202D\u200B\u206F\u202A\u206D\u206B\u202C\u202E\u206A\u206D\u200D\u206E\u206B\u200D\u202A\u206F\u206A\u206B\u200D\u206F\u206F\u202B\u206C\u206C\u206F\u202C\u202D\u202D\u202E\u206B\u206B\u202D\u202D\u200F\u200B\u200F\u202E(new Rect(x, y + h - thickness, w, thickness), Utils.\u206E\u200D\u206D\u202C\u202C\u202D\u202D\u200E\u202E\u206B\u202A\u200E\u206A\u202C\u200D\u200C\u202B\u200E\u200C\u206B\u206A\u202C\u202D\u200C\u206C\u206F\u202A\u206D\u200D\u200C\u200E\u200D\u206C\u202A\u200C\u200E\u202A\u200E\u202C\u202E\u202E());
			Utils.\u206F\u202A\u200D\u202D\u200B\u206F\u202A\u206D\u206B\u202C\u202E\u206A\u206D\u200D\u206E\u206B\u200D\u202A\u206F\u206A\u206B\u200D\u206F\u206F\u202B\u206C\u206C\u206F\u202C\u202D\u202D\u202E\u206B\u206B\u202D\u202D\u200F\u200B\u200F\u202E(new Rect(x, y, thickness, h), Utils.\u206E\u200D\u206D\u202C\u202C\u202D\u202D\u200E\u202E\u206B\u202A\u200E\u206A\u202C\u200D\u200C\u202B\u200E\u200C\u206B\u206A\u202C\u202D\u200C\u206C\u206F\u202A\u206D\u200D\u200C\u200E\u200D\u206C\u202A\u200C\u200E\u202A\u200E\u202C\u202E\u202E());
			Utils.\u206F\u202A\u200D\u202D\u200B\u206F\u202A\u206D\u206B\u202C\u202E\u206A\u206D\u200D\u206E\u206B\u200D\u202A\u206F\u206A\u206B\u200D\u206F\u206F\u202B\u206C\u206C\u206F\u202C\u202D\u202D\u202E\u206B\u206B\u202D\u202D\u200F\u200B\u200F\u202E(new Rect(x + w - thickness, y, thickness, h), Utils.\u206E\u200D\u206D\u202C\u202C\u202D\u202D\u200E\u202E\u206B\u202A\u200E\u206A\u202C\u200D\u200C\u202B\u200E\u200C\u206B\u206A\u202C\u202D\u200C\u206C\u206F\u202A\u206D\u200D\u200C\u200E\u200D\u206C\u202A\u200C\u200E\u202A\u200E\u202C\u202E\u202E());
		}

		// Token: 0x0600024C RID: 588 RVA: 0x0001AF6C File Offset: 0x0001916C
		internal static void DrawLine(float x1, float y1, float x2, float y2, float thickness, Color color)
		{
			Utils.\u202B\u200E\u200E\u200C\u202B\u200C\u202B\u206A\u202C\u206C\u206F\u202D\u206B\u202A\u202C\u200F\u202E\u200D\u200B\u202E\u202A\u202B\u200C\u200F\u206A\u200B\u206E\u206B\u206F\u202B\u202A\u206C\u206F\u202A\u200D\u200E\u200B\u200C\u206D\u202D\u202E(color);
			Vector2 vector;
			vector..ctor(x1, y1);
			Matrix4x4 matrix4x;
			for (;;)
			{
				IL_10:
				uint num = 3851121533U;
				for (;;)
				{
					uint num2;
					switch ((num2 = (num ^ 2444753284U)) % 5U)
					{
					case 0U:
						goto IL_10;
					case 1U:
					{
						Vector2 vector2;
						float num3 = Mathf.Atan2(vector2.y, vector2.x) * 57.29578f;
						matrix4x = Utils.\u202C\u202C\u200E\u206C\u200D\u200F\u206F\u200C\u202E\u202C\u200C\u206B\u202E\u200E\u202A\u206B\u202A\u200F\u200C\u206E\u206B\u206F\u200E\u200D\u206B\u206D\u200E\u202C\u202E\u202B\u206A\u202B\u200E\u200D\u206A\u202E\u200E\u202B\u206D\u202A\u202E();
						Utils.\u200E\u202B\u200D\u206F\u202C\u202A\u200E\u200F\u200F\u202D\u202C\u200C\u206A\u200D\u200F\u206B\u202C\u200F\u206E\u202D\u202E\u202C\u200C\u206B\u206A\u200F\u202C\u200D\u206D\u206F\u200E\u200E\u200D\u200E\u200F\u206D\u206A\u200C\u206A\u206D\u202E(num3, vector);
						float magnitude;
						Utils.\u206F\u202A\u200D\u202D\u200B\u206F\u202A\u206D\u206B\u202C\u202E\u206A\u206D\u200D\u206E\u206B\u200D\u202A\u206F\u206A\u206B\u200D\u206F\u206F\u202B\u206C\u206C\u206F\u202C\u202D\u202D\u202E\u206B\u206B\u202D\u202D\u200F\u200B\u200F\u202E(new Rect(vector.x, vector.y - thickness / 2f, magnitude, thickness), Utils.\u206E\u200D\u206D\u202C\u202C\u202D\u202D\u200E\u202E\u206B\u202A\u200E\u206A\u202C\u200D\u200C\u202B\u200E\u200C\u206B\u206A\u202C\u202D\u200C\u206C\u206F\u202A\u206D\u200D\u200C\u200E\u200D\u206C\u202A\u200C\u200E\u202A\u200E\u202C\u202E\u202E());
						num = 2340067174U;
						continue;
					}
					case 3U:
					{
						Vector2 vector2 = new Vector2(x2, y2) - vector;
						float magnitude = vector2.magnitude;
						num = (((magnitude >= 0.001f) ? 3611278207U : 3545630157U) ^ num2 * 3529955213U);
						continue;
					}
					case 4U:
						return;
					}
					goto Block_1;
				}
			}
			Block_1:
			Utils.\u200C\u206B\u202B\u206D\u206B\u202E\u206D\u206E\u206A\u206F\u200B\u206A\u202B\u206A\u206F\u200C\u202E\u202A\u202A\u200E\u206E\u202D\u206E\u206F\u206B\u206D\u206C\u202C\u200B\u202C\u200B\u202C\u206F\u206B\u206D\u206F\u206E\u202C\u206F\u206F\u202E(matrix4x);
		}

		// Token: 0x0600024D RID: 589 RVA: 0x0001B060 File Offset: 0x00019260
		internal static void DrawLineFixed(float x1, float y1, float x2, float y2, float thickness, Color color)
		{
			Utils.\u202B\u200E\u200E\u200C\u202B\u200C\u202B\u206A\u202C\u206C\u206F\u202D\u206B\u202A\u202C\u200F\u202E\u200D\u200B\u202E\u202A\u202B\u200C\u200F\u206A\u200B\u206E\u206B\u206F\u202B\u202A\u206C\u206F\u202A\u200D\u200E\u200B\u200C\u206D\u202D\u202E(color);
			Vector2 vector;
			vector..ctor(x1, y1);
			for (;;)
			{
				IL_10:
				uint num = 443581275U;
				for (;;)
				{
					uint num2;
					switch ((num2 = (num ^ 131812233U)) % 6U)
					{
					case 0U:
						goto IL_10;
					case 1U:
					{
						Vector2 vector2;
						float num3 = Mathf.Atan2(vector2.y, vector2.x) * 57.29578f;
						Matrix4x4 matrix4x = Utils.\u202C\u202C\u200E\u206C\u200D\u200F\u206F\u200C\u202E\u202C\u200C\u206B\u202E\u200E\u202A\u206B\u202A\u200F\u200C\u206E\u206B\u206F\u200E\u200D\u206B\u206D\u200E\u202C\u202E\u202B\u206A\u202B\u200E\u200D\u206A\u202E\u200E\u202B\u206D\u202A\u202E();
						Utils.\u200C\u206B\u202B\u206D\u206B\u202E\u206D\u206E\u206A\u206F\u200B\u206A\u202B\u206A\u206F\u200C\u202E\u202A\u202A\u200E\u206E\u202D\u206E\u206F\u206B\u206D\u206C\u202C\u200B\u202C\u200B\u202C\u206F\u206B\u206D\u206F\u206E\u202C\u206F\u206F\u202E(Matrix4x4.TRS(vector, Quaternion.Euler(0f, 0f, num3), Vector3.one));
						float magnitude;
						Utils.\u206F\u202A\u200D\u202D\u200B\u206F\u202A\u206D\u206B\u202C\u202E\u206A\u206D\u200D\u206E\u206B\u200D\u202A\u206F\u206A\u206B\u200D\u206F\u206F\u202B\u206C\u206C\u206F\u202C\u202D\u202D\u202E\u206B\u206B\u202D\u202D\u200F\u200B\u200F\u202E(new Rect(0f, -thickness / 2f, magnitude, thickness), Utils.\u206E\u200D\u206D\u202C\u202C\u202D\u202D\u200E\u202E\u206B\u202A\u200E\u206A\u202C\u200D\u200C\u202B\u200E\u200C\u206B\u206A\u202C\u202D\u200C\u206C\u206F\u202A\u206D\u200D\u200C\u200E\u200D\u206C\u202A\u200C\u200E\u202A\u200E\u202C\u202E\u202E());
						float num4 = thickness * 0.6f;
						Utils.\u202B\u200E\u200E\u200C\u202B\u200C\u202B\u206A\u202C\u206C\u206F\u202D\u206B\u202A\u202C\u200F\u202E\u200D\u200B\u202E\u202A\u202B\u200C\u200F\u206A\u200B\u206E\u206B\u206F\u202B\u202A\u206C\u206F\u202A\u200D\u200E\u200B\u200C\u206D\u202D\u202E(new Color(color.r, color.g, color.b, color.a * 0.35f));
						Utils.\u206F\u202A\u200D\u202D\u200B\u206F\u202A\u206D\u206B\u202C\u202E\u206A\u206D\u200D\u206E\u206B\u200D\u202A\u206F\u206A\u206B\u200D\u206F\u206F\u202B\u206C\u206C\u206F\u202C\u202D\u202D\u202E\u206B\u206B\u202D\u202D\u200F\u200B\u200F\u202E(new Rect(-num4, -thickness / 2f, num4 * 2f, thickness), Utils.\u206E\u200D\u206D\u202C\u202C\u202D\u202D\u200E\u202E\u206B\u202A\u200E\u206A\u202C\u200D\u200C\u202B\u200E\u200C\u206B\u206A\u202C\u202D\u200C\u206C\u206F\u202A\u206D\u200D\u200C\u200E\u200D\u206C\u202A\u200C\u200E\u202A\u200E\u202C\u202E\u202E());
						Utils.\u206F\u202A\u200D\u202D\u200B\u206F\u202A\u206D\u206B\u202C\u202E\u206A\u206D\u200D\u206E\u206B\u200D\u202A\u206F\u206A\u206B\u200D\u206F\u206F\u202B\u206C\u206C\u206F\u202C\u202D\u202D\u202E\u206B\u206B\u202D\u202D\u200F\u200B\u200F\u202E(new Rect(magnitude - num4, -thickness / 2f, num4 * 2f, thickness), Utils.\u206E\u200D\u206D\u202C\u202C\u202D\u202D\u200E\u202E\u206B\u202A\u200E\u206A\u202C\u200D\u200C\u202B\u200E\u200C\u206B\u206A\u202C\u202D\u200C\u206C\u206F\u202A\u206D\u200D\u200C\u200E\u200D\u206C\u202A\u200C\u200E\u202A\u200E\u202C\u202E\u202E());
						Utils.\u200C\u206B\u202B\u206D\u206B\u202E\u206D\u206E\u206A\u206F\u200B\u206A\u202B\u206A\u206F\u200C\u202E\u202A\u202A\u200E\u206E\u202D\u206E\u206F\u206B\u206D\u206C\u202C\u200B\u202C\u200B\u202C\u206F\u206B\u206D\u206F\u206E\u202C\u206F\u206F\u202E(matrix4x);
						num = 1161764830U;
						continue;
					}
					case 2U:
					{
						float magnitude;
						num = (((magnitude >= 1f) ? 171660432U : 35814598U) ^ num2 * 245349915U);
						continue;
					}
					case 4U:
					{
						Vector2 vector2 = new Vector2(x2, y2) - vector;
						float magnitude = vector2.magnitude;
						num = (num2 * 3598788048U ^ 3077192605U);
						continue;
					}
					case 5U:
						return;
					}
					goto Block_1;
				}
			}
			Block_1:
			Utils.\u202B\u200E\u200E\u200C\u202B\u200C\u202B\u206A\u202C\u206C\u206F\u202D\u206B\u202A\u202C\u200F\u202E\u200D\u200B\u202E\u202A\u202B\u200C\u200F\u206A\u200B\u206E\u206B\u206F\u202B\u202A\u206C\u206F\u202A\u200D\u200E\u200B\u200C\u206D\u202D\u202E(color);
		}

		// Token: 0x0600024E RID: 590 RVA: 0x0001B204 File Offset: 0x00019404
		internal static void DrawCircleFixed(Vector2 center, float radius, float thickness = 1.5f, Color? overrideColor = null)
		{
			Color? color = overrideColor;
			for (;;)
			{
				IL_02:
				uint num = 1344057783U;
				for (;;)
				{
					uint num2;
					Color color2;
					int num5;
					Color color3;
					switch ((num2 = (num ^ 373558972U)) % 7U)
					{
					case 0U:
						goto IL_02;
					case 1U:
					{
						float num3;
						float x = center.x + Mathf.Cos(num3) * radius;
						float y = center.y + Mathf.Sin(num3) * radius;
						float num4;
						float x2 = center.x + Mathf.Cos(num4) * radius;
						float y2 = center.y + Mathf.Sin(num4) * radius;
						Utils.DrawLineFixed(x, y, x2, y2, thickness, color2);
						num5++;
						num = (num2 * 755600006U ^ 2406016711U);
						continue;
					}
					case 2U:
						num = ((num5 <= 140) ? 552779137U : 598341466U);
						continue;
					case 4U:
						color3 = new Color(1f, 0.3f, 0.3f, 0.7f);
						goto IL_12A;
					case 5U:
					{
						float num3 = (float)num5 * 2.5714285f * 0.017453292f;
						float num4 = (float)(num5 + 1) * 2.5714285f * 0.017453292f;
						num = 1529520194U;
						continue;
					}
					case 6U:
						if (color == null)
						{
							num = (num2 * 4123993738U ^ 2062378693U);
							continue;
						}
						color3 = color.GetValueOrDefault();
						goto IL_12A;
					}
					return;
					IL_12A:
					color2 = color3;
					Utils.\u202B\u200E\u200E\u200C\u202B\u200C\u202B\u206A\u202C\u206C\u206F\u202D\u206B\u202A\u202C\u200F\u202E\u200D\u200B\u202E\u202A\u202B\u200C\u200F\u206A\u200B\u206E\u206B\u206F\u202B\u202A\u206C\u206F\u202A\u200D\u200E\u200B\u200C\u206D\u202D\u202E(color2);
					num5 = 0;
					num = 1884971571U;
				}
			}
		}

		// Token: 0x0600024F RID: 591 RVA: 0x0001B354 File Offset: 0x00019554
		internal static void DrawCircle(Vector2 center, float radius, int segments, float thickness, Color color)
		{
			Utils.\u202B\u200E\u200E\u200C\u202B\u200C\u202B\u206A\u202C\u206C\u206F\u202D\u206B\u202A\u202C\u200F\u202E\u200D\u200B\u202E\u202A\u202B\u200C\u200F\u206A\u200B\u206E\u206B\u206F\u202B\u202A\u206C\u206F\u202A\u200D\u200E\u200B\u200C\u206D\u202D\u202E(color);
			float num = 360f / (float)segments;
			for (;;)
			{
				IL_10:
				uint num2 = 826362307U;
				for (;;)
				{
					uint num3;
					switch ((num3 = (num2 ^ 1628762390U)) % 8U)
					{
					case 0U:
						goto IL_10;
					case 2U:
					{
						Vector2 vector;
						Vector2 vector2;
						Utils.DrawLine(vector.x, vector.y, vector2.x, vector2.y, thickness, color);
						vector = vector2;
						int num4;
						num4++;
						num2 = (num3 * 3683315843U ^ 3268679860U);
						continue;
					}
					case 3U:
					{
						float num5;
						Vector2 vector2 = center + new Vector2(Mathf.Cos(num5) * radius, Mathf.Sin(num5) * radius);
						num2 = (num3 * 3536380612U ^ 720776112U);
						continue;
					}
					case 4U:
					{
						int num4;
						num2 = ((num4 > segments) ? 1044399751U : 1165413017U);
						continue;
					}
					case 5U:
					{
						Vector2 vector = center + new Vector2(Mathf.Cos(0f) * radius, Mathf.Sin(0f) * radius);
						int num4 = 1;
						num2 = (num3 * 2714862049U ^ 3044977701U);
						continue;
					}
					case 6U:
						num2 = (num3 * 1751757504U ^ 2494793642U);
						continue;
					case 7U:
					{
						int num4;
						float num5 = (float)num4 * num * 0.017453292f;
						num2 = 1286118573U;
						continue;
					}
					}
					return;
				}
			}
		}

		// Token: 0x06000250 RID: 592 RVA: 0x0001B490 File Offset: 0x00019690
		internal static Vector3 DirectionDiff(Vector3 worldPos, Camera cam)
		{
			if (!Utils.\u200C\u200D\u202B\u206B\u206F\u206C\u206B\u206B\u200B\u200F\u202C\u202E\u200F\u200B\u202B\u206F\u202C\u206E\u202E\u200E\u200B\u206E\u202B\u206A\u200F\u206E\u202A\u202A\u202E\u202C\u202D\u202A\u200E\u206A\u206F\u202D\u200F\u202B\u206C\u206F\u202E(cam, null))
			{
				goto IL_44;
			}
			IL_09:
			int num = -1464646818;
			IL_0E:
			Vector3 vector;
			switch ((num ^ -1492715681) % 4)
			{
			case 0:
				goto IL_09;
			case 1:
				return Vector3.zero;
			case 2:
				IL_44:
				vector = worldPos - Utils.\u200E\u200C\u202E\u206D\u206A\u206C\u202A\u202B\u202E\u202C\u206C\u206C\u200B\u202B\u206C\u202D\u202A\u200C\u206C\u206C\u206B\u200C\u206B\u202A\u202E\u206F\u206B\u206C\u200F\u206A\u200D\u206B\u206A\u202E\u200D\u206C\u206D\u206F\u200C\u202D\u202E(Utils.\u206C\u206D\u202A\u202C\u202A\u206C\u200E\u202D\u202A\u206D\u202E\u202E\u206F\u200B\u202D\u206F\u206B\u200C\u200F\u200B\u202C\u202A\u200E\u206A\u200B\u202A\u206D\u202B\u202B\u200F\u206C\u206D\u206F\u206E\u206C\u200F\u206D\u202A\u200E\u202A\u202E(cam));
				num = -1041341764;
				goto IL_0E;
			}
			Vector3 normalized = vector.normalized;
			Vector3 vector2 = Utils.\u200C\u202A\u202A\u206B\u200F\u200C\u202A\u202C\u206F\u202D\u206E\u206D\u200E\u202A\u202A\u200C\u200C\u200F\u202C\u200F\u200F\u200C\u202C\u200C\u206D\u202B\u200D\u206E\u202A\u202E\u206D\u200C\u206F\u206F\u200E\u200C\u202A\u200E\u206E\u200C\u202E(Utils.\u206C\u206D\u202A\u202C\u202A\u206C\u200E\u202D\u202A\u206D\u202E\u202E\u206F\u200B\u202D\u206F\u206B\u200C\u200F\u200B\u202C\u202A\u200E\u206A\u200B\u202A\u206D\u202B\u202B\u200F\u206C\u206D\u206F\u206E\u206C\u200F\u206D\u202A\u200E\u202A\u202E(cam));
			return normalized - vector2;
		}

		// Token: 0x06000251 RID: 593 RVA: 0x0001B514 File Offset: 0x00019714
		internal static void DrawSnapline(Vector2 startScreenPoint, Vector3 worldPos, Color color, float thickness, Camera cam)
		{
			if (Utils.\u200C\u200D\u202B\u206B\u206F\u206C\u206B\u206B\u200B\u200F\u202C\u202E\u200F\u200B\u202B\u206F\u202C\u206E\u202E\u200E\u200B\u206E\u202B\u206A\u200F\u206E\u202A\u202A\u202E\u202C\u202D\u202A\u200E\u206A\u206F\u202D\u200F\u202B\u206C\u206F\u202E(cam, null))
			{
				goto IL_0D;
			}
			goto IL_165;
			uint num2;
			Vector3 vector;
			Vector3 vector2;
			for (;;)
			{
				IL_12:
				uint num;
				bool flag;
				bool flag2;
				switch ((num = (num2 ^ 2954165693U)) % 12U)
				{
				case 0U:
					num2 = (((!flag) ? 2391564095U : 2735760107U) ^ num * 657643498U);
					continue;
				case 1U:
					flag2 = (Mathf.Abs(vector.z) < 1f);
					goto IL_6C;
				case 2U:
					num2 = (((vector.y > 0f) ? 2880469910U : 2472737017U) ^ num * 100083193U);
					continue;
				case 3U:
					goto IL_0D;
				case 4U:
					num2 = (num * 228335481U ^ 5307741U);
					continue;
				case 5U:
					vector2.y = (float)Utils.\u200E\u206D\u206E\u200D\u206A\u200B\u206D\u202B\u200C\u206F\u202A\u202E\u206F\u206E\u200D\u206E\u202E\u200F\u200D\u200D\u206C\u200B\u202E\u202E\u202B\u200D\u202C\u200B\u206D\u206C\u200C\u202B\u206F\u202C\u200C\u206D\u202C\u200D\u206F\u200E\u202E() - vector2.y;
					num2 = 3340822785U;
					continue;
				case 6U:
					if (Mathf.Abs(vector.x) < 1f)
					{
						num2 = (num * 2879286566U ^ 902772328U);
						continue;
					}
					flag2 = false;
					goto IL_6C;
				case 8U:
					Utils.DrawLine(startScreenPoint.x, startScreenPoint.y, vector2.x, vector2.y, thickness, color);
					num2 = 3391029838U;
					continue;
				case 9U:
					return;
				case 10U:
					vector2.x = (float)Utils.\u202B\u202D\u206B\u206A\u202E\u202D\u206D\u206B\u206D\u200D\u202E\u202A\u206D\u206C\u202A\u206D\u206E\u200E\u206E\u206A\u202E\u202C\u200F\u200C\u200D\u206C\u206D\u206E\u200D\u202E\u202A\u206E\u202C\u202C\u202C\u200E\u206A\u202A\u202C\u200C\u202E() - vector2.x;
					vector2.y = (float)Utils.\u200E\u206D\u206E\u200D\u206A\u200B\u206D\u202B\u200C\u206F\u202A\u202E\u206F\u206E\u200D\u206E\u202E\u200F\u200D\u200D\u206C\u200B\u202E\u202E\u202B\u200D\u202C\u200B\u206D\u206C\u200C\u202B\u206F\u202C\u200C\u206D\u202C\u200D\u206F\u200E\u202E();
					num2 = 3571477889U;
					continue;
				case 11U:
					goto IL_165;
				}
				break;
				IL_6C:
				flag = flag2;
				num2 = ((vector2.z >= 0f) ? 3468959880U : 4079300737U);
			}
			return;
			IL_0D:
			num2 = 4039551740U;
			goto IL_12;
			IL_165:
			vector2 = Utils.\u200E\u202B\u206E\u202B\u202B\u206C\u200E\u200F\u206C\u200B\u202C\u206C\u200E\u202C\u202D\u200B\u206C\u206A\u202E\u200F\u202C\u206F\u202B\u202E\u206E\u206D\u206E\u200D\u206F\u202E\u206E\u202C\u206A\u202B\u200D\u200B\u206F\u200F\u202A\u206D\u202E(cam, worldPos);
			vector = Utils.DirectionDiff(worldPos, cam);
			num2 = 3141678411U;
			goto IL_12;
		}

		// Token: 0x06000252 RID: 594 RVA: 0x0001B6CC File Offset: 0x000198CC
		internal static Vector2 CalcAngles(Vector3 playerPos, Vector3 targetPos)
		{
			Vector3 vector = targetPos - playerPos;
			Vector2 vector2;
			for (;;)
			{
				IL_08:
				uint num = 673938513U;
				for (;;)
				{
					uint num2;
					switch ((num2 = (num ^ 349516248U)) % 19U)
					{
					case 0U:
						num = ((vector2.y < 0f) ? 1707190906U : 1217358443U);
						continue;
					case 1U:
						num = ((Utils.\u206F\u202C\u200E\u206B\u202C\u206A\u200B\u200F\u206F\u202A\u200C\u206D\u206B\u206F\u202B\u200C\u202C\u202D\u200C\u206E\u202D\u206C\u200F\u202C\u206F\u206D\u202D\u206B\u206F\u206F\u206F\u200E\u202C\u206D\u206E\u206D\u200F\u202D\u206C\u206F\u202E(Utils.\u202A\u206D\u206B\u206A\u202D\u200B\u200F\u202E\u200F\u206C\u200E\u202A\u200C\u200E\u206A\u200C\u202E\u200C\u206B\u200B\u200E\u202C\u200F\u202D\u200C\u202B\u206F\u202A\u200E\u206F\u206A\u200B\u206B\u200F\u202B\u202C\u200C\u206B\u200C\u206A\u202E(Utils.\u200C\u206E\u200F\u200E\u206A\u206D\u202A\u202C\u202B\u202B\u200C\u200C\u200E\u200D\u200D\u202D\u206A\u206F\u206C\u200D\u202B\u202C\u206D\u202C\u200E\u200B\u200E\u200F\u206A\u206F\u200B\u202C\u200F\u202A\u202B\u202B\u206F\u202B\u200B\u206C\u202E())) != 1) ? 373401177U : 1604401238U);
						continue;
					case 2U:
						num = (num2 * 27411361U ^ 2058208497U);
						continue;
					case 3U:
						vector2.x = -vector2.x;
						num = (num2 * 3243035593U ^ 3508965225U);
						continue;
					case 4U:
						goto IL_08;
					case 5U:
						num = (((vector.x < 0f) ? 3487584786U : 3205059639U) ^ num2 * 2912722878U);
						continue;
					case 6U:
					{
						float num3;
						vector2.x += num3;
						num = 268107240U;
						continue;
					}
					case 7U:
						vector2.y = (float)(Utils.\u206F\u206E\u206C\u202C\u206A\u202E\u206C\u200F\u202C\u200F\u202C\u206B\u206B\u200F\u206A\u206A\u200F\u202A\u202D\u200C\u200B\u206F\u200E\u206B\u200D\u202E\u200C\u206F\u202D\u202D\u202C\u202D\u206F\u200F\u200D\u200F\u202A\u206C\u202B\u200D\u202E((double)(vector.y / vector.magnitude)) * 57.29577951308232);
						num = (num2 * 624271533U ^ 3796463056U);
						continue;
					case 9U:
						num = (num2 * 3168732366U ^ 2872486137U);
						continue;
					case 10U:
						vector2.y -= 180f;
						num = 263471202U;
						continue;
					case 11U:
						vector2.x += 90f;
						num = 66004975U;
						continue;
					case 12U:
						vector2.x = (float)(Utils.\u206D\u202B\u200C\u202D\u200C\u206E\u206A\u206E\u200B\u206C\u206D\u200C\u206B\u200F\u202C\u206E\u200D\u206D\u206E\u202B\u206F\u202B\u200E\u200E\u200D\u206E\u202D\u202C\u206C\u206C\u202D\u202A\u200D\u200E\u200F\u206B\u206D\u202B\u200C\u200C\u202E((double)(vector.z / vector.x)) * 57.29577951308232);
						num = (num2 * 2006915246U ^ 539767103U);
						continue;
					case 13U:
					{
						float num3;
						vector2.x -= num3;
						num = (num2 * 3272801138U ^ 2985293443U);
						continue;
					}
					case 14U:
						vector2.x -= 90f;
						num = (num2 * 4039188632U ^ 519381138U);
						continue;
					case 15U:
						num = ((vector2.y <= 180f) ? 165929170U : 771499998U);
						continue;
					case 16U:
						vector2.y += 180f;
						num = 373401177U;
						continue;
					case 17U:
					{
						float num3 = 5f;
						num = (((!Utils.\u202B\u200F\u202E\u202A\u202C\u206B\u200B\u206E\u200E\u206E\u206D\u206D\u202C\u206B\u200F\u206B\u202C\u206B\u200C\u202D\u200C\u200F\u200C\u202A\u200C\u206E\u200E\u200E\u202A\u200B\u206D\u200C\u206E\u202A\u206D\u202A\u200F\u206E\u206E\u206B\u202E(Utils.\u200D\u200E\u206A\u200C\u200F\u200C\u206A\u206D\u206E\u206C\u200B\u206A\u200B\u202A\u202D\u202B\u200F\u206B\u202C\u206E\u206C\u206A\u200E\u200F\u200F\u202D\u202B\u202C\u202A\u202D\u202A\u202D\u202A\u206E\u206F\u206F\u200B\u200C\u202C\u200E\u202E(Utils.\u200C\u206E\u200F\u200E\u206A\u206D\u202A\u202C\u202B\u202B\u200C\u200C\u200E\u200D\u200D\u202D\u206A\u206F\u206C\u200D\u202B\u202C\u206D\u202C\u200E\u200B\u200E\u200F\u206A\u206F\u200B\u202C\u200F\u202A\u202B\u202B\u206F\u202B\u200B\u206C\u202E()))) ? 2650144975U : 2535975349U) ^ num2 * 4017091076U);
						continue;
					}
					case 18U:
						num = (num2 * 1105061383U ^ 2625625401U);
						continue;
					}
					return vector2;
				}
			}
			return vector2;
		}

		// Token: 0x06000253 RID: 595 RVA: 0x0001B978 File Offset: 0x00019B78
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static void OverrideMethod(Type defaultClass, Type overrideClass, string method, BindingFlags sourceFlags, BindingFlags destFlags)
		{
			MethodInfo methodInfo = Utils.\u202A\u206B\u202D\u206C\u206A\u202D\u200F\u200C\u206E\u206A\u206C\u206E\u206E\u202E\u200C\u202D\u206D\u200D\u200C\u206F\u206C\u202B\u202C\u200E\u200E\u206F\u200B\u206D\u202C\u202A\u202B\u202D\u206A\u206F\u206D\u200E\u202C\u202B\u202C\u202A\u202E(defaultClass, method, sourceFlags);
			for (;;)
			{
				IL_09:
				uint num = 14478042U;
				for (;;)
				{
					uint num2;
					switch ((num2 = (num ^ 2070540451U)) % 7U)
					{
					case 0U:
					{
						MethodInfo methodInfo2;
						Utils.RedirectCalls(methodInfo, methodInfo2);
						num = 623248558U;
						continue;
					}
					case 1U:
					{
						MethodInfo methodInfo2;
						num = (((!Utils.\u200B\u206D\u206F\u200E\u202A\u200E\u206F\u206F\u206E\u202D\u206D\u200F\u202E\u206A\u206E\u202B\u200D\u206D\u206E\u206D\u206F\u202D\u200E\u200E\u206A\u202C\u206F\u206F\u202E\u206E\u206E\u202E\u200F\u200D\u200E\u206A\u206E\u200C\u202E\u200E\u202E(methodInfo2, null)) ? 2225595021U : 3577337200U) ^ num2 * 807541855U);
						continue;
					}
					case 3U:
					{
						MethodInfo methodInfo2 = Utils.\u202A\u206B\u202D\u206C\u206A\u202D\u200F\u200C\u206E\u206A\u206C\u206E\u206E\u202E\u200C\u202D\u206D\u200D\u200C\u206F\u206C\u202B\u202C\u200E\u200E\u206F\u200B\u206D\u202C\u202A\u202B\u202D\u206A\u206F\u206D\u200E\u202C\u202B\u202C\u202A\u202E(overrideClass, Utils.\u202A\u206F\u206A\u206F\u206E\u202E\u200D\u200B\u206D\u206D\u202E\u200F\u206F\u202A\u202C\u200E\u202B\u200B\u206C\u202A\u206C\u206A\u202A\u202B\u200E\u206B\u206A\u202A\u206A\u200B\u206B\u200D\u200C\u206B\u206D\u206A\u200B\u202D\u202E\u206A\u202E(<Module>.\u202B\u200B\u202C\u206C\u206D\u202C\u206B\u200F\u206D\u206D\u200E\u206A\u202E\u206D\u200D\u206A\u202D\u202B\u200B\u200F\u202C\u206D\u200E\u202D\u200D\u206A\u200F\u206E\u206F\u206F\u200D\u202D\u202C\u200B\u206F\u202C\u202A\u200D\u206E\u202E\u202E<string>(-46511785), method), destFlags);
						num = 667790310U;
						continue;
					}
					case 4U:
						return;
					case 5U:
						goto IL_09;
					case 6U:
						num = ((Utils.\u200B\u206D\u206F\u200E\u202A\u200E\u206F\u206F\u206E\u202D\u206D\u200F\u202E\u206A\u206E\u202B\u200D\u206D\u206E\u206D\u206F\u202D\u200E\u200E\u206A\u202C\u206F\u206F\u202E\u206E\u206E\u202E\u200F\u200D\u200E\u206A\u206E\u200C\u202E\u200E\u202E(methodInfo, null) ? 4205232753U : 2151049118U) ^ num2 * 409497451U);
						continue;
					}
					goto Block_1;
				}
			}
			Block_1:;
		}

		// Token: 0x06000254 RID: 596 RVA: 0x0001BA48 File Offset: 0x00019C48
		internal static void RedirectCalls(MethodInfo from, MethodInfo to)
		{
			IntPtr functionPointer = Utils.\u206A\u202E\u206E\u206F\u206D\u200B\u200F\u202B\u200D\u206A\u202B\u200D\u200E\u206C\u206B\u206D\u206F\u206E\u206F\u200B\u200F\u206F\u202A\u202E\u200E\u202A\u200F\u202E\u202D\u206A\u202B\u200D\u200F\u202A\u206D\u200C\u200E\u202D\u206A\u200D\u202E(from).GetFunctionPointer();
			IntPtr functionPointer2 = Utils.\u206A\u202E\u206E\u206F\u206D\u200B\u200F\u202B\u200D\u206A\u202B\u200D\u200E\u206C\u206B\u206D\u206F\u206E\u206F\u200B\u200F\u206F\u202A\u202E\u200E\u202A\u200F\u202E\u202D\u206A\u202B\u200D\u200F\u202A\u206D\u200C\u200E\u202D\u206A\u200D\u202E(to).GetFunctionPointer();
			Utils.PatchJumpTo(functionPointer, functionPointer2);
		}

		// Token: 0x06000255 RID: 597 RVA: 0x0001BA78 File Offset: 0x00019C78
		internal unsafe static void PatchJumpTo(IntPtr site, IntPtr target)
		{
			byte[] array = Utils.\u202C\u202D\u206E\u202E\u200F\u200D\u202B\u200F\u206F\u206A\u202C\u200E\u206C\u206A\u202C\u202E\u206F\u200D\u202D\u206C\u200B\u206C\u200D\u202A\u202E\u206E\u202B\u206F\u202A\u206B\u202E\u202E\u206E\u206D\u200B\u206F\u202C\u202A\u206C\u200D\u202E(target.ToInt64());
			byte[] array2 = new byte[13];
			Utils.\u200C\u202D\u200C\u206A\u206E\u200C\u206B\u202C\u206C\u206A\u202D\u206A\u206B\u206E\u200E\u206B\u206D\u202B\u206E\u200B\u202B\u202D\u206B\u206C\u200B\u200D\u206B\u200C\u206D\u206B\u206A\u200E\u202C\u206D\u200B\u200E\u206B\u200C\u202B\u202E(array2, fieldof(<PrivateImplementationDetails>.5960BD072C13E5EAC9B34FC9FAAC793E07F2EAE046247FF5486324B5012FBB46).FieldHandle);
			array2[2] = array[0];
			array2[3] = array[1];
			array2[4] = array[2];
			array2[5] = array[3];
			array2[6] = array[4];
			array2[7] = array[5];
			array2[8] = array[6];
			array2[9] = array[7];
			byte[] array3 = array2;
			byte[] array4;
			uint flNewProtect;
			for (;;)
			{
				IL_51:
				uint num = 1933847205U;
				for (;;)
				{
					uint num2;
					switch ((num2 = (num ^ 1981009843U)) % 12U)
					{
					case 0U:
					{
						int num3;
						num3++;
						num = (num2 * 1336048108U ^ 1402238057U);
						continue;
					}
					case 1U:
					{
						int num3 = 0;
						num = 257925229U;
						continue;
					}
					case 2U:
						num = (num2 * 3310066776U ^ 2816251753U);
						continue;
					case 3U:
						goto IL_51;
					case 5U:
					{
						int num3;
						byte* ptr;
						*(byte*)((void*)IntPtr.Add(site, num3)) = ptr[num3];
						num = 956425871U;
						continue;
					}
					case 6U:
					{
						int num3;
						num = ((num3 >= array3.Length) ? 1795911035U : 1673007566U);
						continue;
					}
					case 7U:
					{
						byte* ptr = &array4[0];
						num = 1919139474U;
						continue;
					}
					case 8U:
					{
						byte* ptr = null;
						num = 1919139474U;
						continue;
					}
					case 9U:
						num = (((array4.Length != 0) ? 361296176U : 721019771U) ^ num2 * 1479777736U);
						continue;
					case 10U:
						Utils.VirtualProtect(site, (UIntPtr)((ulong)((long)array3.Length)), 64U, out flNewProtect);
						num = (num2 * 3064518902U ^ 1905560988U);
						continue;
					case 11U:
						num = ((((array4 = array3) == null) ? 3011500288U : 3739054973U) ^ num2 * 2978026329U);
						continue;
					}
					goto Block_1;
				}
			}
			Block_1:
			array4 = null;
			uint num4;
			Utils.VirtualProtect(site, (UIntPtr)((ulong)((long)array3.Length)), flNewProtect, out num4);
		}

		// Token: 0x06000256 RID: 598
		[DllImport("kernel32.dll", SetLastError = true)]
		internal static extern bool VirtualProtect(IntPtr lpAddress, UIntPtr dwSize, uint flNewProtect, out uint lpflOldProtect);

		// Token: 0x06000257 RID: 599 RVA: 0x0001BC30 File Offset: 0x00019E30
		internal static float GetGunRange()
		{
			Player player = Utils.\u200C\u206E\u200F\u200E\u206A\u206D\u202A\u202C\u202B\u202B\u200C\u200C\u200E\u200D\u200D\u202D\u206A\u206F\u206C\u200D\u202B\u202C\u206D\u202C\u200E\u200B\u200E\u200F\u206A\u206F\u200B\u202C\u200F\u202A\u202B\u202B\u206F\u202B\u200B\u206C\u202E();
			object obj;
			if (player == null)
			{
				obj = null;
			}
			else
			{
				PlayerEquipment playerEquipment = Utils.\u206B\u202E\u202D\u202C\u200C\u206B\u206C\u206E\u200B\u206B\u200E\u206E\u202D\u200C\u200C\u206B\u200F\u200D\u202C\u206B\u206E\u202C\u206D\u200D\u206E\u206A\u200C\u202B\u200E\u200C\u200B\u206F\u202B\u200C\u202C\u202D\u202C\u206C\u202E\u202E(player);
				obj = ((playerEquipment != null) ? Utils.\u200C\u200D\u200E\u206C\u206E\u206C\u206B\u202E\u206E\u200F\u206F\u200F\u202E\u206D\u206E\u206A\u206E\u200E\u202D\u206A\u206D\u200B\u206E\u202B\u202C\u206F\u206B\u200B\u200E\u200E\u202E\u202B\u200F\u202E\u202A\u200E\u206F\u206A\u202B\u206B\u202E(playerEquipment) : null);
			}
			ItemGunAsset itemGunAsset = obj as ItemGunAsset;
			if (itemGunAsset != null)
			{
				for (;;)
				{
					switch ((-1821770364 ^ -116224086) % 3)
					{
					case 0:
						continue;
					case 2:
						goto IL_48;
					}
					break;
				}
				goto IL_5E;
				IL_48:
				return itemGunAsset.range;
			}
			IL_5E:
			return 15f;
		}

		// Token: 0x06000258 RID: 600 RVA: 0x0001BCA0 File Offset: 0x00019EA0
		internal static bool IsFriendly(Player target)
		{
			Player target;
			SteamPlayer steamPlayer;
			for (;;)
			{
				IL_06:
				uint num = 2712288759U;
				for (;;)
				{
					uint num2;
					switch ((num2 = (num ^ 3347972165U)) % 12U)
					{
					case 0U:
						num = (((steamPlayer == null) ? 145585536U : 1512545488U) ^ num2 * 4179137271U);
						continue;
					case 1U:
						return true;
					case 2U:
						target = target2;
						num = (num2 * 3535918866U ^ 3109148930U);
						continue;
					case 3U:
						num = (((!Utils.\u206B\u200D\u206D\u206B\u200F\u206E\u202E\u200D\u202B\u202D\u200B\u206C\u202C\u202C\u206C\u200F\u206F\u206A\u202C\u206B\u200C\u206B\u202C\u206D\u206E\u200B\u202D\u206C\u206C\u206A\u206F\u206E\u200C\u206D\u206A\u200D\u202E\u202B\u206A\u202B\u202E(Utils.\u202C\u200D\u202B\u202C\u202C\u206F\u206C\u202E\u206B\u206F\u200E\u202D\u202E\u206D\u206E\u206B\u206A\u200D\u206A\u202B\u202C\u200C\u206B\u206A\u200D\u206B\u206E\u202D\u200B\u200B\u202D\u200F\u206C\u206C\u206D\u202D\u206C\u202A\u202E\u200F\u202E(target))) ? 842601414U : 933960248U) ^ num2 * 3806867231U);
						continue;
					case 4U:
						goto IL_06;
					case 5U:
						return false;
					case 7U:
						num = ((Utils.\u200C\u200D\u202B\u206B\u206F\u206C\u206B\u206B\u200B\u200F\u202C\u202E\u200F\u200B\u202B\u206F\u202C\u206E\u202E\u200E\u200B\u206E\u202B\u206A\u200F\u206E\u202A\u202A\u202E\u202C\u202D\u202A\u200E\u206A\u206F\u202D\u200F\u202B\u206C\u206F\u202E(target, Utils.\u200C\u206E\u200F\u200E\u206A\u206D\u202A\u202C\u202B\u202B\u200C\u200C\u200E\u200D\u200D\u202D\u206A\u206F\u206C\u200D\u202B\u202C\u206D\u202C\u200E\u200B\u200E\u200F\u206A\u206F\u200B\u202C\u200F\u202A\u202B\u202B\u206F\u202B\u200B\u206C\u202E()) ? 4264418385U : 3224542194U) ^ num2 * 1756850896U);
						continue;
					case 8U:
						return true;
					case 9U:
						num = ((!Utils.\u200C\u200C\u206C\u206A\u202D\u202C\u200C\u206E\u200F\u202E\u206F\u200C\u202C\u202E\u202E\u200D\u206A\u206F\u200F\u206B\u200C\u200F\u206E\u206C\u202A\u202E\u200D\u200D\u206B\u202C\u206E\u206D\u202D\u206F\u200B\u200B\u200B\u202C\u200C\u202D\u202E(Utils.\u200F\u202D\u200C\u206E\u202D\u206D\u200B\u202E\u206B\u206A\u206F\u202A\u202D\u200F\u206B\u202D\u200D\u206B\u206B\u206A\u202C\u206E\u200D\u202D\u202C\u202B\u200B\u206E\u206D\u202C\u200C\u206C\u202A\u206C\u202A\u202E\u202C\u206A\u206A\u206B\u202E(Utils.\u200C\u206E\u200F\u200E\u206A\u206D\u202A\u202C\u202B\u202B\u200C\u200C\u200E\u200D\u200D\u202D\u206A\u206F\u206C\u200D\u202B\u202C\u206D\u202C\u200E\u200B\u200E\u200F\u206A\u206F\u200B\u202C\u200F\u202A\u202B\u202B\u206F\u202B\u200B\u206C\u202E()).owner, steamPlayer)) ? 3031249991U : 2211913196U);
						continue;
					case 10U:
					{
						List<SteamPlayer> list = Utils.\u206F\u206B\u200B\u200C\u200C\u202E\u206A\u206E\u202E\u200F\u200D\u206C\u206E\u202A\u206A\u206F\u206D\u206F\u202C\u206D\u206B\u202E\u206B\u202C\u200D\u206F\u206D\u202E\u200E\u206B\u202D\u206E\u206D\u206F\u206C\u200D\u200B\u200E\u202D\u200E\u202E();
						steamPlayer = ((list != null) ? list.FirstOrDefault((SteamPlayer sp) => Utils.<>c__DisplayClass19_0.\u206C\u206E\u200C\u200D\u200C\u206A\u206E\u202E\u206B\u206D\u206A\u202B\u202C\u200E\u200C\u202C\u200F\u206B\u206A\u206D\u202E\u206A\u202C\u200E\u200D\u200B\u200E\u206C\u202C\u206D\u202C\u206A\u206B\u206B\u206E\u200F\u206D\u202E\u200E\u200D\u202E((sp != null) ? Utils.<>c__DisplayClass19_0.\u200F\u206C\u202C\u200D\u200C\u202E\u200D\u202A\u202E\u206A\u200D\u202E\u200B\u206D\u200B\u206C\u200E\u206D\u202E\u200F\u202E\u206D\u206B\u200E\u200B\u200D\u206E\u202D\u202E\u200C\u202E\u206C\u202E\u206B\u206B\u202D\u206A\u202A\u200C\u202E\u202E(sp) : null, target)) : null);
						num = 4160302157U;
						continue;
					}
					case 11U:
						num = (((!Utils.\u200C\u200D\u202B\u206B\u206F\u206C\u206B\u206B\u200B\u200F\u202C\u202E\u200F\u200B\u202B\u206F\u202C\u206E\u202E\u200E\u200B\u206E\u202B\u206A\u200F\u206E\u202A\u202A\u202E\u202C\u202D\u202A\u200E\u206A\u206F\u202D\u200F\u202B\u206C\u206F\u202E(target, null)) ? 1739363639U : 2100896704U) ^ num2 * 2324289163U);
						continue;
					}
					goto Block_1;
				}
			}
			Block_1:
			return Utils.ManualFriends.Contains(Utils.\u200D\u200B\u200F\u206D\u202D\u200C\u202B\u202A\u202D\u202D\u202B\u200B\u206F\u206A\u206E\u200D\u200F\u200E\u206E\u206A\u200E\u200E\u202D\u202A\u206A\u200B\u202E\u206E\u206C\u200F\u200E\u202E\u206F\u206F\u206C\u202C\u206F\u202D\u206D\u202B\u202E(Utils.\u202E\u206B\u200B\u202E\u202A\u202E\u200E\u202E\u206B\u200B\u206C\u200B\u202C\u200E\u200B\u202C\u200B\u200F\u206D\u202A\u206E\u202B\u206E\u200F\u202A\u202B\u206A\u206F\u200F\u202C\u206C\u206D\u200C\u206B\u200E\u206B\u202E\u202C\u206D\u206A\u202E(steamPlayer)).m_SteamID);
		}

		// Token: 0x0600025A RID: 602 RVA: 0x000076A4 File Offset: 0x000058A4
		static bool \u200C\u200D\u202B\u206B\u206F\u206C\u206B\u206B\u200B\u200F\u202C\u202E\u200F\u200B\u202B\u206F\u202C\u206E\u202E\u200E\u200B\u206E\u202B\u206A\u200F\u206E\u202A\u202A\u202E\u202C\u202D\u202A\u200E\u206A\u206F\u202D\u200F\u202B\u206C\u206F\u202E(Object A_0, Object A_1)
		{
			return A_0 == A_1;
		}

		// Token: 0x0600025B RID: 603 RVA: 0x000061E8 File Offset: 0x000043E8
		static bool \u200D\u202B\u202C\u200E\u206A\u200B\u206B\u200E\u202E\u202C\u202B\u200D\u202C\u202E\u206C\u202D\u200D\u200E\u206D\u200F\u206B\u206B\u200D\u206F\u202A\u202E\u200F\u200C\u202E\u206F\u202E\u202E\u200D\u206A\u206A\u202B\u202E\u206F\u206F\u202A\u202E(Object A_0, Object A_1)
		{
			return A_0 != A_1;
		}

		// Token: 0x0600025C RID: 604 RVA: 0x0001BE80 File Offset: 0x0001A080
		static ELimb \u202C\u202A\u202E\u206B\u202B\u200C\u206A\u202A\u200B\u200B\u200E\u202B\u202D\u202C\u202D\u202A\u202D\u206D\u202D\u202B\u202D\u202A\u202A\u206C\u206D\u202D\u200E\u206D\u202E\u206C\u200E\u202B\u200E\u202C\u206F\u202E\u202D\u206D\u206B\u202D\u202E(Transform A_0)
		{
			return DamageTool.getLimb(A_0);
		}

		// Token: 0x0600025D RID: 605 RVA: 0x00010100 File Offset: 0x0000E300
		static Type \u202C\u206B\u206E\u200C\u202B\u206C\u206C\u202A\u200E\u200F\u206F\u202B\u206F\u206A\u202B\u200F\u202A\u200D\u202C\u206E\u206A\u200F\u200B\u206A\u200D\u202D\u206D\u200F\u202A\u200D\u200F\u202E\u206B\u200B\u200F\u202C\u202B\u202A\u202E\u202E(object A_0)
		{
			return A_0.GetType();
		}

		// Token: 0x0600025E RID: 606 RVA: 0x00007874 File Offset: 0x00005A74
		static FieldInfo \u206F\u206E\u206A\u206D\u202C\u200C\u202A\u206B\u206C\u206C\u206B\u200F\u200F\u206A\u202E\u206F\u202D\u200D\u200E\u202D\u206A\u206A\u202A\u200C\u200D\u200D\u200B\u202C\u206C\u200B\u202D\u202E\u206E\u206D\u206E\u202B\u202D\u202E\u202C\u200E\u202E(Type A_0, string A_1, BindingFlags A_2)
		{
			return A_0.GetField(A_1, A_2);
		}

		// Token: 0x0600025F RID: 607 RVA: 0x000119E0 File Offset: 0x0000FBE0
		static bool \u206A\u206E\u202B\u206C\u206F\u206D\u206D\u206C\u200B\u202C\u206E\u202E\u200E\u206C\u202D\u206C\u200C\u206E\u202E\u200B\u200D\u202B\u206D\u206B\u206C\u200E\u202B\u202D\u206D\u200D\u206D\u206E\u202C\u206D\u206A\u206E\u206D\u200E\u202D\u200E\u202E(FieldInfo A_0, FieldInfo A_1)
		{
			return A_0 == A_1;
		}

		// Token: 0x06000260 RID: 608 RVA: 0x000078B4 File Offset: 0x00005AB4
		static void \u206F\u206D\u202D\u202D\u206B\u200B\u202C\u206E\u200C\u200F\u206A\u206C\u200E\u200F\u200B\u200D\u202C\u206C\u200B\u206F\u206F\u202B\u202D\u200C\u200F\u200F\u206F\u202A\u200D\u202D\u202E\u200D\u200D\u200F\u202B\u200B\u206D\u202E\u202D\u206E\u202E(FieldInfo A_0, object A_1, object A_2)
		{
			A_0.SetValue(A_1, A_2);
		}

		// Token: 0x06000261 RID: 609 RVA: 0x0000788C File Offset: 0x00005A8C
		static object \u202C\u202E\u206C\u206C\u202A\u206E\u200E\u200B\u206C\u206B\u200B\u206D\u200D\u200B\u200B\u202D\u200B\u200E\u202C\u206D\u202C\u206E\u200C\u200C\u200D\u206B\u206B\u200C\u202E\u200D\u200F\u200D\u200B\u200C\u200F\u202B\u202E\u206C\u202C\u202E\u202E(FieldInfo A_0, object A_1)
		{
			return A_0.GetValue(A_1);
		}

		// Token: 0x06000262 RID: 610 RVA: 0x0000C9CC File Offset: 0x0000ABCC
		static void \u202B\u200E\u200E\u200C\u202B\u200C\u202B\u206A\u202C\u206C\u206F\u202D\u206B\u202A\u202C\u200F\u202E\u200D\u200B\u202E\u202A\u202B\u200C\u200F\u206A\u200B\u206E\u206B\u206F\u202B\u202A\u206C\u206F\u202A\u200D\u200E\u200B\u200C\u206D\u202D\u202E(Color A_0)
		{
			GUI.color = A_0;
		}

		// Token: 0x06000263 RID: 611 RVA: 0x0001A7EC File Offset: 0x000189EC
		static Texture2D \u206E\u200D\u206D\u202C\u202C\u202D\u202D\u200E\u202E\u206B\u202A\u200E\u206A\u202C\u200D\u200C\u202B\u200E\u200C\u206B\u206A\u202C\u202D\u200C\u206C\u206F\u202A\u206D\u200D\u200C\u200E\u200D\u206C\u202A\u200C\u200E\u202A\u200E\u202C\u202E\u202E()
		{
			return Texture2D.whiteTexture;
		}

		// Token: 0x06000264 RID: 612 RVA: 0x0001A814 File Offset: 0x00018A14
		static void \u206F\u202A\u200D\u202D\u200B\u206F\u202A\u206D\u206B\u202C\u202E\u206A\u206D\u200D\u206E\u206B\u200D\u202A\u206F\u206A\u206B\u200D\u206F\u206F\u202B\u206C\u206C\u206F\u202C\u202D\u202D\u202E\u206B\u206B\u202D\u202D\u200F\u200B\u200F\u202E(Rect A_0, Texture A_1)
		{
			GUI.DrawTexture(A_0, A_1);
		}

		// Token: 0x06000265 RID: 613 RVA: 0x0001BE94 File Offset: 0x0001A094
		static Matrix4x4 \u202C\u202C\u200E\u206C\u200D\u200F\u206F\u200C\u202E\u202C\u200C\u206B\u202E\u200E\u202A\u206B\u202A\u200F\u200C\u206E\u206B\u206F\u200E\u200D\u206B\u206D\u200E\u202C\u202E\u202B\u206A\u202B\u200E\u200D\u206A\u202E\u200E\u202B\u206D\u202A\u202E()
		{
			return GUI.matrix;
		}

		// Token: 0x06000266 RID: 614 RVA: 0x0001BEA8 File Offset: 0x0001A0A8
		static void \u200E\u202B\u200D\u206F\u202C\u202A\u200E\u200F\u200F\u202D\u202C\u200C\u206A\u200D\u200F\u206B\u202C\u200F\u206E\u202D\u202E\u202C\u200C\u206B\u206A\u200F\u202C\u200D\u206D\u206F\u200E\u200E\u200D\u200E\u200F\u206D\u206A\u200C\u206A\u206D\u202E(float A_0, Vector2 A_1)
		{
			GUIUtility.RotateAroundPivot(A_0, A_1);
		}

		// Token: 0x06000267 RID: 615 RVA: 0x0001BEBC File Offset: 0x0001A0BC
		static void \u200C\u206B\u202B\u206D\u206B\u202E\u206D\u206E\u206A\u206F\u200B\u206A\u202B\u206A\u206F\u200C\u202E\u202A\u202A\u200E\u206E\u202D\u206E\u206F\u206B\u206D\u206C\u202C\u200B\u202C\u200B\u202C\u206F\u206B\u206D\u206F\u206E\u202C\u206F\u206F\u202E(Matrix4x4 A_0)
		{
			GUI.matrix = A_0;
		}

		// Token: 0x06000268 RID: 616 RVA: 0x00007708 File Offset: 0x00005908
		static Transform \u206C\u206D\u202A\u202C\u202A\u206C\u200E\u202D\u202A\u206D\u202E\u202E\u206F\u200B\u202D\u206F\u206B\u200C\u200F\u200B\u202C\u202A\u200E\u206A\u200B\u202A\u206D\u202B\u202B\u200F\u206C\u206D\u206F\u206E\u206C\u200F\u206D\u202A\u200E\u202A\u202E(Component A_0)
		{
			return A_0.transform;
		}

		// Token: 0x06000269 RID: 617 RVA: 0x0000771C File Offset: 0x0000591C
		static Vector3 \u200E\u200C\u202E\u206D\u206A\u206C\u202A\u202B\u202E\u202C\u206C\u206C\u200B\u202B\u206C\u202D\u202A\u200C\u206C\u206C\u206B\u200C\u206B\u202A\u202E\u206F\u206B\u206C\u200F\u206A\u200D\u206B\u206A\u202E\u200D\u206C\u206D\u206F\u200C\u202D\u202E(Transform A_0)
		{
			return A_0.position;
		}

		// Token: 0x0600026A RID: 618 RVA: 0x00007810 File Offset: 0x00005A10
		static Vector3 \u200C\u202A\u202A\u206B\u200F\u200C\u202A\u202C\u206F\u202D\u206E\u206D\u200E\u202A\u202A\u200C\u200C\u200F\u202C\u200F\u200F\u200C\u202C\u200C\u206D\u202B\u200D\u206E\u202A\u202E\u206D\u200C\u206F\u206F\u200E\u200C\u202A\u200E\u206E\u200C\u202E(Transform A_0)
		{
			return A_0.forward;
		}

		// Token: 0x0600026B RID: 619 RVA: 0x00007744 File Offset: 0x00005944
		static Vector3 \u200E\u202B\u206E\u202B\u202B\u206C\u200E\u200F\u206C\u200B\u202C\u206C\u200E\u202C\u202D\u200B\u206C\u206A\u202E\u200F\u202C\u206F\u202B\u202E\u206E\u206D\u206E\u200D\u206F\u202E\u206E\u202C\u206A\u202B\u200D\u200B\u206F\u200F\u202A\u206D\u202E(Camera A_0, Vector3 A_1)
		{
			return A_0.WorldToScreenPoint(A_1);
		}

		// Token: 0x0600026C RID: 620 RVA: 0x0000776C File Offset: 0x0000596C
		static int \u200E\u206D\u206E\u200D\u206A\u200B\u206D\u202B\u200C\u206F\u202A\u202E\u206F\u206E\u200D\u206E\u202E\u200F\u200D\u200D\u206C\u200B\u202E\u202E\u202B\u200D\u202C\u200B\u206D\u206C\u200C\u202B\u206F\u202C\u200C\u206D\u202C\u200D\u206F\u200E\u202E()
		{
			return Screen.height;
		}

		// Token: 0x0600026D RID: 621 RVA: 0x00007758 File Offset: 0x00005958
		static int \u202B\u202D\u206B\u206A\u202E\u202D\u206D\u206B\u206D\u200D\u202E\u202A\u206D\u206C\u202A\u206D\u206E\u200E\u206E\u206A\u202E\u202C\u200F\u200C\u200D\u206C\u206D\u206E\u200D\u202E\u202A\u206E\u202C\u202C\u202C\u200E\u206A\u202A\u202C\u200C\u202E()
		{
			return Screen.width;
		}

		// Token: 0x0600026E RID: 622 RVA: 0x0001BED0 File Offset: 0x0001A0D0
		static double \u206D\u202B\u200C\u202D\u200C\u206E\u206A\u206E\u200B\u206C\u206D\u200C\u206B\u200F\u202C\u206E\u200D\u206D\u206E\u202B\u206F\u202B\u200E\u200E\u200D\u206E\u202D\u202C\u206C\u206C\u202D\u202A\u200D\u200E\u200F\u206B\u206D\u202B\u200C\u200C\u202E(double A_0)
		{
			return Math.Atan(A_0);
		}

		// Token: 0x0600026F RID: 623 RVA: 0x0001BEE4 File Offset: 0x0001A0E4
		static double \u206F\u206E\u206C\u202C\u206A\u202E\u206C\u200F\u202C\u200F\u202C\u206B\u206B\u200F\u206A\u206A\u200F\u202A\u202D\u200C\u200B\u206F\u200E\u206B\u200D\u202E\u200C\u206F\u202D\u202D\u202C\u202D\u206F\u200F\u200D\u200F\u202A\u206C\u202B\u200D\u202E(double A_0)
		{
			return Math.Acos(A_0);
		}

		// Token: 0x06000270 RID: 624 RVA: 0x00007690 File Offset: 0x00005890
		static Player \u200C\u206E\u200F\u200E\u206A\u206D\u202A\u202C\u202B\u202B\u200C\u200C\u200E\u200D\u200D\u202D\u206A\u206F\u206C\u200D\u202B\u202C\u206D\u202C\u200E\u200B\u200E\u200F\u206A\u206F\u200B\u202C\u200F\u202A\u202B\u202B\u206F\u202B\u200B\u206C\u202E()
		{
			return Player.LocalPlayer;
		}

		// Token: 0x06000271 RID: 625 RVA: 0x000077E8 File Offset: 0x000059E8
		static PlayerLook \u202A\u206D\u206B\u206A\u202D\u200B\u200F\u202E\u200F\u206C\u200E\u202A\u200C\u200E\u206A\u200C\u202E\u200C\u206B\u200B\u200E\u202C\u200F\u202D\u200C\u202B\u206F\u202A\u200E\u206F\u206A\u200B\u206B\u200F\u202B\u202C\u200C\u206B\u200C\u206A\u202E(Player A_0)
		{
			return A_0.look;
		}

		// Token: 0x06000272 RID: 626 RVA: 0x0001BEF8 File Offset: 0x0001A0F8
		static EPlayerPerspective \u206F\u202C\u200E\u206B\u202C\u206A\u200B\u200F\u206F\u202A\u200C\u206D\u206B\u206F\u202B\u200C\u202C\u202D\u200C\u206E\u202D\u206C\u200F\u202C\u206F\u206D\u202D\u206B\u206F\u206F\u206F\u200E\u202C\u206D\u206E\u206D\u200F\u202D\u206C\u206F\u202E(PlayerLook A_0)
		{
			return A_0.perspective;
		}

		// Token: 0x06000273 RID: 627 RVA: 0x00011A08 File Offset: 0x0000FC08
		static PlayerAnimator \u200D\u200E\u206A\u200C\u200F\u200C\u206A\u206D\u206E\u206C\u200B\u206A\u200B\u202A\u202D\u202B\u200F\u206B\u202C\u206E\u206C\u206A\u200E\u200F\u200F\u202D\u202B\u202C\u202A\u202D\u202A\u202D\u202A\u206E\u206F\u206F\u200B\u200C\u202C\u200E\u202E(Player A_0)
		{
			return A_0.animator;
		}

		// Token: 0x06000274 RID: 628 RVA: 0x0001BF0C File Offset: 0x0001A10C
		static bool \u202B\u200F\u202E\u202A\u202C\u206B\u200B\u206E\u200E\u206E\u206D\u206D\u202C\u206B\u200F\u206B\u202C\u206B\u200C\u202D\u200C\u200F\u200C\u202A\u200C\u206E\u200E\u200E\u202A\u200B\u206D\u200C\u206E\u202A\u206D\u202A\u200F\u206E\u206E\u206B\u202E(PlayerAnimator A_0)
		{
			return A_0.side;
		}

		// Token: 0x06000275 RID: 629 RVA: 0x00010D3C File Offset: 0x0000EF3C
		static MethodInfo \u202A\u206B\u202D\u206C\u206A\u202D\u200F\u200C\u206E\u206A\u206C\u206E\u206E\u202E\u200C\u202D\u206D\u200D\u200C\u206F\u206C\u202B\u202C\u200E\u200E\u206F\u200B\u206D\u202C\u202A\u202B\u202D\u206A\u206F\u206D\u200E\u202C\u202B\u202C\u202A\u202E(Type A_0, string A_1, BindingFlags A_2)
		{
			return A_0.GetMethod(A_1, A_2);
		}

		// Token: 0x06000276 RID: 630 RVA: 0x0000CB44 File Offset: 0x0000AD44
		static string \u202A\u206F\u206A\u206F\u206E\u202E\u200D\u200B\u206D\u206D\u202E\u200F\u206F\u202A\u202C\u200E\u202B\u200B\u206C\u202A\u206C\u206A\u202A\u202B\u200E\u206B\u206A\u202A\u206A\u200B\u206B\u200D\u200C\u206B\u206D\u206A\u200B\u202D\u202E\u206A\u202E(string A_0, string A_1)
		{
			return A_0 + A_1;
		}

		// Token: 0x06000277 RID: 631 RVA: 0x0001BF20 File Offset: 0x0001A120
		static bool \u200B\u206D\u206F\u200E\u202A\u200E\u206F\u206F\u206E\u202D\u206D\u200F\u202E\u206A\u206E\u202B\u200D\u206D\u206E\u206D\u206F\u202D\u200E\u200E\u206A\u202C\u206F\u206F\u202E\u206E\u206E\u202E\u200F\u200D\u200E\u206A\u206E\u200C\u202E\u200E\u202E(MethodInfo A_0, MethodInfo A_1)
		{
			return A_0 == A_1;
		}

		// Token: 0x06000278 RID: 632 RVA: 0x0001BF34 File Offset: 0x0001A134
		static RuntimeMethodHandle \u206A\u202E\u206E\u206F\u206D\u200B\u200F\u202B\u200D\u206A\u202B\u200D\u200E\u206C\u206B\u206D\u206F\u206E\u206F\u200B\u200F\u206F\u202A\u202E\u200E\u202A\u200F\u202E\u202D\u206A\u202B\u200D\u200F\u202A\u206D\u200C\u200E\u202D\u206A\u200D\u202E(MethodBase A_0)
		{
			return A_0.MethodHandle;
		}

		// Token: 0x06000279 RID: 633 RVA: 0x0001BF48 File Offset: 0x0001A148
		static byte[] \u202C\u202D\u206E\u202E\u200F\u200D\u202B\u200F\u206F\u206A\u202C\u200E\u206C\u206A\u202C\u202E\u206F\u200D\u202D\u206C\u200B\u206C\u200D\u202A\u202E\u206E\u202B\u206F\u202A\u206B\u202E\u202E\u206E\u206D\u200B\u206F\u202C\u202A\u206C\u200D\u202E(long A_0)
		{
			return BitConverter.GetBytes(A_0);
		}

		// Token: 0x0600027A RID: 634 RVA: 0x0001BF5C File Offset: 0x0001A15C
		static void \u200C\u202D\u200C\u206A\u206E\u200C\u206B\u202C\u206C\u206A\u202D\u206A\u206B\u206E\u200E\u206B\u206D\u202B\u206E\u200B\u202B\u202D\u206B\u206C\u200B\u200D\u206B\u200C\u206D\u206B\u206A\u200E\u202C\u206D\u200B\u200E\u206B\u200C\u202B\u202E(Array A_0, RuntimeFieldHandle A_1)
		{
			RuntimeHelpers.InitializeArray(A_0, A_1);
		}

		// Token: 0x0600027B RID: 635 RVA: 0x0001BF70 File Offset: 0x0001A170
		static PlayerEquipment \u206B\u202E\u202D\u202C\u200C\u206B\u206C\u206E\u200B\u206B\u200E\u206E\u202D\u200C\u200C\u206B\u200F\u200D\u202C\u206B\u206E\u202C\u206D\u200D\u206E\u206A\u200C\u202B\u200E\u200C\u200B\u206F\u202B\u200C\u202C\u202D\u202C\u206C\u202E\u202E(Player A_0)
		{
			return A_0.equipment;
		}

		// Token: 0x0600027C RID: 636 RVA: 0x0000CB58 File Offset: 0x0000AD58
		static ItemAsset \u200C\u200D\u200E\u206C\u206E\u206C\u206B\u202E\u206E\u200F\u206F\u200F\u202E\u206D\u206E\u206A\u206E\u200E\u202D\u206A\u206D\u200B\u206E\u202B\u202C\u206F\u206B\u200B\u200E\u200E\u202E\u202B\u200F\u202E\u202A\u200E\u206F\u206A\u202B\u206B\u202E(PlayerEquipment A_0)
		{
			return A_0.asset;
		}

		// Token: 0x0600027D RID: 637 RVA: 0x00007824 File Offset: 0x00005A24
		static PlayerLife \u202C\u200D\u202B\u202C\u202C\u206F\u206C\u202E\u206B\u206F\u200E\u202D\u202E\u206D\u206E\u206B\u206A\u200D\u206A\u202B\u202C\u200C\u206B\u206A\u200D\u206B\u206E\u202D\u200B\u200B\u202D\u200F\u206C\u206C\u206D\u202D\u206C\u202A\u202E\u200F\u202E(Player A_0)
		{
			return A_0.life;
		}

		// Token: 0x0600027E RID: 638 RVA: 0x00007838 File Offset: 0x00005A38
		static bool \u206B\u200D\u206D\u206B\u200F\u206E\u202E\u200D\u202B\u202D\u200B\u206C\u202C\u202C\u206C\u200F\u206F\u206A\u202C\u206B\u200C\u206B\u202C\u206D\u206E\u200B\u202D\u206C\u206C\u206A\u206F\u206E\u200C\u206D\u206A\u200D\u202E\u202B\u206A\u202B\u202E(PlayerLife A_0)
		{
			return A_0.isDead;
		}

		// Token: 0x0600027F RID: 639 RVA: 0x0000CA78 File Offset: 0x0000AC78
		static List<SteamPlayer> \u206F\u206B\u200B\u200C\u200C\u202E\u206A\u206E\u202E\u200F\u200D\u206C\u206E\u202A\u206A\u206F\u206D\u206F\u202C\u206D\u206B\u202E\u206B\u202C\u200D\u206F\u206D\u202E\u200E\u206B\u202D\u206E\u206D\u206F\u206C\u200D\u200B\u200E\u202D\u200E\u202E()
		{
			return Provider.clients;
		}

		// Token: 0x06000280 RID: 640 RVA: 0x0000CB08 File Offset: 0x0000AD08
		static SteamChannel \u200F\u202D\u200C\u206E\u202D\u206D\u200B\u202E\u206B\u206A\u206F\u202A\u202D\u200F\u206B\u202D\u200D\u206B\u206B\u206A\u202C\u206E\u200D\u202D\u202C\u202B\u200B\u206E\u206D\u202C\u200C\u206C\u202A\u206C\u202A\u202E\u202C\u206A\u206A\u206B\u202E(Player A_0)
		{
			return A_0.channel;
		}

		// Token: 0x06000281 RID: 641 RVA: 0x0001AA80 File Offset: 0x00018C80
		static bool \u200C\u200C\u206C\u206A\u202D\u202C\u200C\u206E\u200F\u202E\u206F\u200C\u202C\u202E\u202E\u200D\u206A\u206F\u200F\u206B\u200C\u200F\u206E\u206C\u202A\u202E\u200D\u200D\u206B\u202C\u206E\u206D\u202D\u206F\u200B\u200B\u200B\u202C\u200C\u202D\u202E(SteamPlayer A_0, SteamPlayer A_1)
		{
			return A_0.isMemberOfSameGroupAs(A_1);
		}

		// Token: 0x06000282 RID: 642 RVA: 0x0000CA8C File Offset: 0x0000AC8C
		static SteamPlayerID \u202E\u206B\u200B\u202E\u202A\u202E\u200E\u202E\u206B\u200B\u206C\u200B\u202C\u200E\u200B\u202C\u200B\u200F\u206D\u202A\u206E\u202B\u206E\u200F\u202A\u202B\u206A\u206F\u200F\u202C\u206C\u206D\u200C\u206B\u200E\u206B\u202E\u202C\u206D\u206A\u202E(SteamPlayer A_0)
		{
			return A_0.playerID;
		}

		// Token: 0x06000283 RID: 643 RVA: 0x0001AA94 File Offset: 0x00018C94
		static CSteamID \u200D\u200B\u200F\u206D\u202D\u200C\u202B\u202A\u202D\u202D\u202B\u200B\u206F\u206A\u206E\u200D\u200F\u200E\u206E\u206A\u200E\u200E\u202D\u202A\u206A\u200B\u202E\u206E\u206C\u200F\u200E\u202E\u206F\u206F\u206C\u202C\u206F\u202D\u206D\u202B\u202E(SteamPlayerID A_0)
		{
			return A_0.steamID;
		}

		// Token: 0x0400013A RID: 314
		private static readonly Dictionary<Transform, Dictionary<ELimb, Transform>> limbCache = new Dictionary<Transform, Dictionary<ELimb, Transform>>();

		// Token: 0x0400013B RID: 315
		internal static readonly HashSet<ulong> ManualFriends = new HashSet<ulong>();
	}
}
