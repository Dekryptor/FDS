using System;
using System.Collections.Generic;
using System.IO;

// Token: 0x0200005A RID: 90
internal class Class11
{
	// Token: 0x06000316 RID: 790 RVA: 0x0004BBB4 File Offset: 0x00049DB4
	private GClass15[] method_0(byte[] byte_0, GClass27[] gclass27_0, GClass31[] gclass31_0, bool bool_0, uint uint_0)
	{
		List<GClass15> list = new List<GClass15>();
		uint num = ((!bool_0) ? 4U : 8U);
		ulong num2 = (bool_0 ? 9223372036854775808UL : 2147483648UL);
		ulong num3 = (bool_0 ? 9223372036854775807UL : 2147483647UL);
		foreach (GClass27 gclass in gclass27_0)
		{
			string text = GClass18.smethod_12((ulong)GClass18.smethod_10(gclass.UInt32_3, gclass31_0), byte_0);
			uint num4 = ((gclass.UInt32_0 != 0U) ? gclass.UInt32_0 : gclass.UInt32_4);
			if (num4 != 0U)
			{
				uint num5 = GClass18.smethod_10(num4, gclass31_0);
				if (num5 > 0U && (ulong)num5 < (ulong)((long)byte_0.Length))
				{
					for (uint num6 = 0U; num6 < uint_0; num6 += 1U)
					{
						GClass32 gclass2 = new GClass32(byte_0, (int)(num5 + num6 * num), bool_0);
						if (gclass2.UInt64_0 == 0UL)
						{
							break;
						}
						if ((gclass2.UInt64_1 & num2) == num2)
						{
							list.Add(new GClass15(null, text, (ushort)(gclass2.UInt64_1 & num3), 0UL));
						}
						else
						{
							int num7 = (int)GClass18.smethod_11(gclass2.UInt64_0, gclass31_0);
							if (num7 < 0 || num7 >= byte_0.Length)
							{
								break;
							}
							GClass26 gclass3 = new GClass26(byte_0, GClass18.smethod_11(gclass2.UInt64_0, gclass31_0));
							list.Add(new GClass15(gclass3.String_0, text, gclass3.UInt16_0, 0UL));
						}
					}
				}
			}
		}
		return list.ToArray();
	}

	// Token: 0x06000317 RID: 791 RVA: 0x0004BD3C File Offset: 0x00049F3C
	private GClass15[] method_1(BinaryReader binaryReader_0, GClass27[] gclass27_0, GClass31[] gclass31_0, bool bool_0, uint uint_0, uint uint_1, uint uint_2)
	{
		List<GClass15> list = new List<GClass15>();
		uint num = (bool_0 ? 8U : 4U);
		ulong num2 = (bool_0 ? 9223372036854775808UL : 2147483648UL);
		ulong num3 = (bool_0 ? 9223372036854775807UL : 2147483647UL);
		byte[] array = new byte[uint_1];
		byte[] array2 = new byte[uint_2 + 2U];
		int num4 = 50;
		byte[] array3 = new byte[(ulong)num * 50UL];
		foreach (GClass27 gclass in gclass27_0)
		{
			uint num5 = ((gclass.UInt32_0 != 0U) ? gclass.UInt32_0 : gclass.UInt32_4);
			if (num5 != 0U)
			{
				uint num6 = GClass18.smethod_10(num5, gclass31_0);
				if ((ulong)num6 < (ulong)binaryReader_0.BaseStream.Length)
				{
					uint num7 = GClass18.smethod_10(gclass.UInt32_3, gclass31_0);
					string text = null;
					if ((ulong)num7 < (ulong)binaryReader_0.BaseStream.Length)
					{
						binaryReader_0.BaseStream.Seek((long)((ulong)num7), SeekOrigin.Begin);
						Array.Clear(array, 0, array.Length);
						if (binaryReader_0.Read(array, 0, array.Length) > 0)
						{
							text = GClass18.smethod_13(array);
						}
					}
					uint num8 = 0U;
					bool flag = true;
					while (num8 < uint_0)
					{
						if (flag)
						{
							binaryReader_0.BaseStream.Seek((long)((ulong)(num6 + num8 * num)), SeekOrigin.Begin);
						}
						if ((long)binaryReader_0.Read(array3, 0, array3.Length) < (long)((ulong)num))
						{
							break;
						}
						uint num9 = 0U;
						while ((ulong)num9 < (ulong)((long)num4))
						{
							GClass32 gclass2 = new GClass32(array3, (int)num9, bool_0);
							if (gclass2.UInt64_0 == 0UL || gclass2.UInt64_0 >= (ulong)binaryReader_0.BaseStream.Length)
							{
								num8 = uint_0;
								break;
							}
							if ((gclass2.UInt64_1 & num2) == num2)
							{
								list.Add(new GClass15(null, text, (ushort)(gclass2.UInt64_1 & num3), 0UL));
								flag = false;
							}
							else
							{
								int num10 = (int)GClass18.smethod_11(gclass2.UInt64_0, gclass31_0);
								if (num10 < 0 || (long)num10 >= binaryReader_0.BaseStream.Length)
								{
									num8 = uint_0;
									break;
								}
								flag = true;
								binaryReader_0.BaseStream.Seek((long)num10, SeekOrigin.Begin);
								Array.Clear(array2, 0, array2.Length);
								if (binaryReader_0.Read(array2, 0, array2.Length) > 0)
								{
									GClass26 gclass3 = new GClass26(array2, 0UL);
									list.Add(new GClass15(gclass3.String_0, text, gclass3.UInt16_0, 0UL));
								}
							}
							num8 += 1U;
							num9 += num;
						}
					}
				}
			}
		}
		return list.ToArray();
	}

	// Token: 0x06000318 RID: 792 RVA: 0x0004BFD8 File Offset: 0x0004A1D8
	private GClass15[] method_2(IntPtr intptr_0, IntPtr intptr_1, GClass27[] gclass27_0, bool bool_0, uint uint_0, uint uint_1, uint uint_2, bool bool_1 = true)
	{
		List<GClass15> list = new List<GClass15>();
		uint num = ((!bool_0) ? 4U : 8U);
		ulong num2 = ((!bool_0) ? 2147483648UL : 9223372036854775808UL);
		ulong num3 = ((!bool_0) ? 2147483647UL : 9223372036854775807UL);
		byte[] array = new byte[uint_1];
		byte[] array2 = new byte[uint_2 + 2U];
		byte[] array3 = new byte[(ulong)num * 50UL];
		byte[] array4 = new byte[(ulong)num * 50UL];
		uint num4 = 0U;
		uint num5 = 0U;
		uint num6 = 0U;
		bool flag = false;
		IntPtr intPtr = IntPtr.Zero;
		IntPtr intPtr2 = IntPtr.Zero;
		ulong num7 = 0UL;
		foreach (GClass27 gclass in gclass27_0)
		{
			uint num8;
			if (bool_1)
			{
				num8 = gclass.UInt32_4;
			}
			else
			{
				num8 = 0U;
			}
			uint num9;
			if (gclass.UInt32_0 != 0U)
			{
				flag = false;
				num9 = gclass.UInt32_0;
			}
			else
			{
				flag = true;
				num9 = gclass.UInt32_4;
				num8 = 0U;
			}
			if (num9 != 0U)
			{
				IntPtr intPtr3 = (IntPtr)(intptr_1.ToInt64() + (long)((ulong)num9));
				if (num8 == 0U)
				{
					intPtr = IntPtr.Zero;
				}
				else
				{
					intPtr = (IntPtr)(intptr_1.ToInt64() + (long)((ulong)num8));
				}
				if (intPtr3 != IntPtr.Zero && GClass16.smethod_1(intptr_0, intPtr3))
				{
					IntPtr intPtr4 = (IntPtr)(intptr_1.ToInt64() + (long)((ulong)gclass.UInt32_3));
					string text = null;
					if (intPtr4 != IntPtr.Zero && GClass16.smethod_1(intptr_0, intPtr4))
					{
						Array.Clear(array, 0, array.Length);
						if (GClass16.ReadProcessMemory(intptr_0, intPtr4, array, (uint)array.Length, ref num4) && array.Length != 0)
						{
							text = GClass18.smethod_13(array);
						}
					}
					if (intPtr == IntPtr.Zero || !GClass16.smethod_1(intptr_0, intPtr))
					{
						intPtr = IntPtr.Zero;
					}
					uint num10 = 0U;
					while (num10 < uint_0)
					{
						IntPtr intPtr5 = (IntPtr)(intPtr3.ToInt64() + (long)((ulong)(num10 * num)));
						if (intPtr3 == IntPtr.Zero || !GClass16.smethod_1(intptr_0, intPtr5) || !GClass16.ReadProcessMemory(intptr_0, intPtr5, array3, (uint)array3.Length, ref num5) || num5 < num)
						{
							break;
						}
						if (intPtr != IntPtr.Zero)
						{
							intPtr2 = (IntPtr)(intPtr.ToInt64() + (long)((ulong)(num10 * num)));
							if (!(intPtr2 == IntPtr.Zero) && GClass16.smethod_1(intptr_0, intPtr2))
							{
								if (!GClass16.ReadProcessMemory(intptr_0, intPtr2, array4, (uint)array4.Length, ref num6) || num6 < num)
								{
									intPtr2 = IntPtr.Zero;
									num6 = 0U;
								}
							}
							else
							{
								intPtr2 = IntPtr.Zero;
								num6 = 0U;
							}
						}
						else
						{
							num6 = 0U;
							intPtr2 = IntPtr.Zero;
						}
						for (uint num11 = 0U; num11 < num5; num11 += num)
						{
							GClass32 gclass2 = new GClass32(array3, (int)num11, bool_0);
							if (gclass2.UInt64_0 == 0UL)
							{
								num10 = uint_0;
								break;
							}
							if ((gclass2.UInt64_1 & num2) == num2)
							{
								if (num11 < num6)
								{
									try
									{
										GClass32 gclass3 = new GClass32(array4, (int)num11, bool_0);
										if (gclass3.UInt64_0 != 0UL && GClass16.smethod_1(intptr_0, (IntPtr)((long)gclass3.UInt64_0)))
										{
											num7 = gclass3.UInt64_0;
										}
										else
										{
											num6 = 0U;
											num7 = 0UL;
										}
										goto IL_482;
									}
									catch
									{
										num6 = 0U;
										num7 = 0UL;
										goto IL_482;
									}
									goto IL_32D;
								}
								goto IL_32D;
								IL_482:
								list.Add(new GClass15(null, text, (ushort)(gclass2.UInt64_1 & num3), num7));
								goto IL_42C;
								IL_32D:
								num7 = 0UL;
								goto IL_482;
							}
							IntPtr intPtr6 = (IntPtr)((long)gclass2.UInt64_0);
							if (!flag)
							{
								intPtr6 = (IntPtr)(intptr_1.ToInt64() + intPtr6.ToInt64());
							}
							if (intPtr6 == IntPtr.Zero || !GClass16.smethod_1(intptr_0, intPtr6))
							{
								num10 = uint_0;
								break;
							}
							Array.Clear(array2, 0, array2.Length);
							if (GClass16.ReadProcessMemory(intptr_0, intPtr6, array2, (uint)array2.Length, ref num4) && (ulong)num4 == (ulong)((long)array2.Length))
							{
								GClass26 gclass4 = new GClass26(array2, 0UL);
								if (num11 < num6)
								{
									try
									{
										GClass32 gclass3 = new GClass32(array4, (int)num11, bool_0);
										if (gclass3.UInt64_0 != 0UL && GClass16.smethod_1(intptr_0, (IntPtr)((long)gclass3.UInt64_0)))
										{
											num7 = gclass3.UInt64_0;
										}
										else
										{
											num6 = 0U;
											num7 = 0UL;
										}
										goto IL_458;
									}
									catch
									{
										num6 = 0U;
										num7 = 0UL;
										goto IL_458;
									}
									goto IL_41F;
								}
								goto IL_41F;
								IL_458:
								list.Add(new GClass15(gclass4.String_0, text, gclass4.UInt16_0, num7));
								goto IL_42C;
								IL_41F:
								num7 = 0UL;
								goto IL_458;
							}
							num10 = uint_0;
							break;
							IL_42C:
							num10 += 1U;
						}
					}
				}
			}
		}
		return list.ToArray();
	}
}
