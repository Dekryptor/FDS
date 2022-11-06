using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

// Token: 0x0200003A RID: 58
public static class GClass18
{
	// Token: 0x06000178 RID: 376 RVA: 0x00047AAC File Offset: 0x00045CAC
	public static string smethod_0(byte[] byte_0)
	{
		return Encoding.UTF8.GetString(byte_0).TrimEnd(new char[1]);
	}

	// Token: 0x06000179 RID: 377 RVA: 0x00047AD0 File Offset: 0x00045CD0
	public static string smethod_1(ushort ushort_0)
	{
		string text = "unknown";
		if (ushort_0 <= 497)
		{
			if (ushort_0 > 388)
			{
				if (ushort_0 <= 450)
				{
					switch (ushort_0)
					{
					case 418:
						text = "Hitachi SH3";
						break;
					case 419:
						text = "Hitachi SH3 DSP";
						break;
					case 420:
						text = "Hitachi SH3E";
						break;
					case 421:
					case 423:
						break;
					case 422:
						text = "Hitachi SH4";
						break;
					case 424:
						text = "Hitachi SH5";
						break;
					default:
						if (ushort_0 != 448)
						{
							if (ushort_0 == 450)
							{
								text = "Thumb";
							}
						}
						else
						{
							text = "ARM little endian";
						}
						break;
					}
				}
				else if (ushort_0 == 467)
				{
					text = "Matsushita AM33";
				}
				else if (ushort_0 == 496)
				{
					text = "PowerPC little endian";
				}
				else if (ushort_0 == 497)
				{
					text = "PowerPC with floating point support";
				}
			}
			else if (ushort_0 > 354)
			{
				switch (ushort_0)
				{
				case 358:
					text = "MIPS little endian (R4000)";
					break;
				case 359:
					break;
				case 360:
					text = "MIPS R10000";
					break;
				case 361:
					text = "MIPS little endian WCI v2";
					break;
				default:
					if (ushort_0 != 387)
					{
						if (ushort_0 == 388)
						{
							text = "Alpha AXP";
						}
					}
					else
					{
						text = "old Alpha AXP";
					}
					break;
				}
			}
			else if (ushort_0 != 332)
			{
				if (ushort_0 != 333)
				{
					if (ushort_0 == 354)
					{
						text = "MIPS R3000";
					}
				}
				else
				{
					text = "Intel i860";
				}
			}
			else
			{
				text = "Intel 386";
			}
		}
		else if (ushort_0 <= 1126)
		{
			if (ushort_0 <= 616)
			{
				if (ushort_0 == 512)
				{
					text = "Intel IA64";
				}
				else if (ushort_0 != 614)
				{
					if (ushort_0 == 616)
					{
						text = "Motorola 68000 series";
					}
				}
				else
				{
					text = "MIPS16";
				}
			}
			else if (ushort_0 == 644)
			{
				text = "Alpha AXP 64-bit";
			}
			else if (ushort_0 == 870)
			{
				text = "MIPS with FPU";
			}
			else if (ushort_0 == 1126)
			{
				text = "MIPS16 with FPU";
			}
		}
		else if (ushort_0 > 3772)
		{
			if (ushort_0 != 34404)
			{
				if (ushort_0 == 36929)
				{
					text = "Mitsubishi M32R little endian";
				}
				else if (ushort_0 == 49390)
				{
					text = "clr pure MSIL";
				}
			}
			else
			{
				text = "AMD AMD64";
			}
		}
		else if (ushort_0 == 1312)
		{
			text = "Tricore";
		}
		else if (ushort_0 == 3311)
		{
			text = "CEF";
		}
		else if (ushort_0 == 3772)
		{
			text = "EFI Byte Code";
		}
		return text;
	}

	// Token: 0x0600017A RID: 378 RVA: 0x00047D60 File Offset: 0x00045F60
	public static GClass18.GClass19 smethod_2(ushort ushort_0)
	{
		return new GClass18.GClass19(ushort_0);
	}

	// Token: 0x0600017B RID: 379 RVA: 0x00047D74 File Offset: 0x00045F74
	public static string smethod_3(uint uint_0)
	{
		switch (uint_0)
		{
		case 1U:
			return "Curser";
		case 2U:
			return "Bitmap";
		case 3U:
			return "Icon";
		case 4U:
			return "Menu";
		case 5U:
			return "Dialog";
		case 6U:
			return "String";
		case 7U:
			return "FontDirectory";
		case 8U:
			return "Fonst";
		case 9U:
			return "Accelerator";
		case 10U:
			return "RcData";
		case 11U:
			return "MessageTable";
		case 14U:
			return "GroupIcon";
		case 16U:
			return "Version";
		case 17U:
			return "DlgInclude";
		case 19U:
			return "PlugAndPlay";
		case 20U:
			return "VXD";
		case 21U:
			return "AnimatedCurser";
		case 22U:
			return "AnimatedIcon";
		case 23U:
			return "HTML";
		case 24U:
			return "Manifest";
		}
		return "unknown";
	}

	// Token: 0x0600017C RID: 380 RVA: 0x00047E68 File Offset: 0x00046068
	public static string smethod_4(ushort ushort_0)
	{
		string text = "unknown";
		switch (ushort_0)
		{
		case 1:
			text = "native";
			break;
		case 2:
			text = "Windows/GUI";
			break;
		case 3:
			text = "Windows non-GUI";
			break;
		case 5:
			text = "OS/2";
			break;
		case 7:
			text = "POSIX";
			break;
		case 8:
			text = "Native Windows 9x Driver";
			break;
		case 9:
			text = "Windows CE";
			break;
		case 10:
			text = "EFI Application";
			break;
		case 11:
			text = "EFI boot service device";
			break;
		case 12:
			text = "EFI runtime driver";
			break;
		case 13:
			text = "EFI ROM";
			break;
		case 14:
			text = "XBox";
			break;
		}
		return text;
	}

	// Token: 0x0600017D RID: 381 RVA: 0x00047F1C File Offset: 0x0004611C
	public static List<string> smethod_5(uint uint_0)
	{
		List<string> list = new List<string>();
		foreach (GClass12.SectionFlags sectionFlags in (GClass12.SectionFlags[])Enum.GetValues(typeof(GClass12.SectionFlags)))
		{
			if ((uint_0 & (uint)sectionFlags) == (uint)sectionFlags)
			{
				list.Add(sectionFlags.ToString());
			}
		}
		return list;
	}

	// Token: 0x0600017E RID: 382 RVA: 0x00047F74 File Offset: 0x00046174
	public static void smethod_6(ushort ushort_0, ulong ulong_0, byte[] byte_0)
	{
		byte[] bytes = BitConverter.GetBytes(ushort_0);
		checked
		{
			byte_0[(int)((IntPtr)ulong_0)] = bytes[0];
			byte_0[(int)((IntPtr)(unchecked(ulong_0 + 1UL)))] = bytes[1];
		}
	}

	// Token: 0x0600017F RID: 383 RVA: 0x00047FA0 File Offset: 0x000461A0
	public static void smethod_7(uint uint_0, uint uint_1, byte[] byte_0)
	{
		byte[] bytes = BitConverter.GetBytes(uint_0);
		byte_0[(int)uint_1] = bytes[0];
		byte_0[(int)(uint_1 + 1U)] = bytes[1];
		byte_0[(int)(uint_1 + 2U)] = bytes[2];
		byte_0[(int)(uint_1 + 3U)] = bytes[3];
	}

	// Token: 0x06000180 RID: 384 RVA: 0x00047FD4 File Offset: 0x000461D4
	public static void smethod_8(ulong ulong_0, ulong ulong_1, byte[] byte_0)
	{
		byte[] bytes = BitConverter.GetBytes(ulong_0);
		checked
		{
			byte_0[(int)((IntPtr)ulong_1)] = bytes[0];
			byte_0[(int)((IntPtr)(unchecked(ulong_1 + 1UL)))] = bytes[1];
			byte_0[(int)((IntPtr)(unchecked(ulong_1 + 2UL)))] = bytes[2];
			byte_0[(int)((IntPtr)(unchecked(ulong_1 + 3UL)))] = bytes[3];
			byte_0[(int)((IntPtr)(unchecked(ulong_1 + 4UL)))] = bytes[4];
			byte_0[(int)((IntPtr)(unchecked(ulong_1 + 5UL)))] = bytes[5];
			byte_0[(int)((IntPtr)(unchecked(ulong_1 + 6UL)))] = bytes[6];
			byte_0[(int)((IntPtr)(unchecked(ulong_1 + 7UL)))] = bytes[7];
		}
	}

	// Token: 0x06000181 RID: 385 RVA: 0x00048068 File Offset: 0x00046268
	internal static string smethod_9(object object_0, string string_0)
	{
		PropertyInfo[] properties = object_0.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public);
		StringBuilder stringBuilder = new StringBuilder();
		PropertyInfo[] array = properties;
		for (int i = 0; i < array.Length; i++)
		{
			bool isArray = array[i].PropertyType.IsArray;
		}
		return stringBuilder.ToString();
	}

	// Token: 0x06000182 RID: 386 RVA: 0x000480AC File Offset: 0x000462AC
	public static uint smethod_10(uint uint_0, GClass31[] gclass31_0)
	{
		uint num = 0U;
		while ((ulong)num < (ulong)((long)gclass31_0.Length) && (gclass31_0[(int)num].UInt32_2 > uint_0 || uint_0 >= gclass31_0[(int)num].UInt32_2 + gclass31_0[(int)num].UInt32_1))
		{
			num += 1U;
		}
		if ((ulong)num >= (ulong)((long)gclass31_0.Length))
		{
			throw new Exception("Cannot find corresponding section.");
		}
		return uint_0 - gclass31_0[(int)num].UInt32_2 + gclass31_0[(int)num].UInt32_4;
	}

	// Token: 0x06000183 RID: 387 RVA: 0x00048110 File Offset: 0x00046310
	public static ulong smethod_11(ulong ulong_0, GClass31[] gclass31_0)
	{
		uint num = 0U;
		while ((ulong)num < (ulong)((long)gclass31_0.Length) && ((ulong)gclass31_0[(int)num].UInt32_2 > ulong_0 || ulong_0 >= (ulong)(gclass31_0[(int)num].UInt32_2 + gclass31_0[(int)num].UInt32_1)))
		{
			num += 1U;
		}
		if ((ulong)num >= (ulong)((long)gclass31_0.Length))
		{
			throw new Exception("Cannot find corresponding section.");
		}
		return ulong_0 - (ulong)gclass31_0[(int)num].UInt32_2 + (ulong)gclass31_0[(int)num].UInt32_4;
	}

	// Token: 0x06000184 RID: 388 RVA: 0x00048178 File Offset: 0x00046378
	public static string smethod_12(ulong ulong_0, byte[] byte_0)
	{
		ulong num = GClass18.smethod_15(ulong_0, byte_0);
		char[] array = new char[num + 1UL];
		Array.Clear(array, 0, array.Length);
		for (ulong num2 = 0UL; num2 < num; num2 += 1UL)
		{
			checked
			{
				array[(int)((IntPtr)num2)] = (char)byte_0[(int)((IntPtr)(unchecked(ulong_0 + num2)))];
			}
		}
		return new string(array).TrimEnd(new char[1]);
	}

	// Token: 0x06000185 RID: 389 RVA: 0x000481E0 File Offset: 0x000463E0
	public static string smethod_13(byte[] byte_0)
	{
		ulong num = GClass18.smethod_14(byte_0);
		char[] array = new char[num + 1UL];
		Array.Clear(array, 0, array.Length);
		for (ulong num2 = 0UL; num2 < num; num2 += 1UL)
		{
			checked
			{
				array[(int)((IntPtr)num2)] = (char)byte_0[(int)((IntPtr)num2)];
			}
		}
		return new string(array).TrimEnd(new char[1]);
	}

	// Token: 0x06000186 RID: 390 RVA: 0x00048248 File Offset: 0x00046448
	public static ulong smethod_14(byte[] byte_0)
	{
		ulong num = 0UL;
		while (byte_0[(int)(checked((IntPtr)num))] != 0 && num < (ulong)byte_0.Length)
		{
			num += 1UL;
		}
		return num;
	}

	// Token: 0x06000187 RID: 391 RVA: 0x0004827C File Offset: 0x0004647C
	public static ulong smethod_15(ulong ulong_0, byte[] byte_0)
	{
		ulong num = ulong_0;
		ulong num2 = 0UL;
		while (byte_0[(int)(checked((IntPtr)num))] != 0)
		{
			num2 += 1UL;
			num += 1UL;
		}
		return num2;
	}

	// Token: 0x06000188 RID: 392 RVA: 0x000482B8 File Offset: 0x000464B8
	public static int smethod_16(IEnumerable ienumerable_0)
	{
		ICollection collection = ienumerable_0 as ICollection;
		if (collection != null)
		{
			return collection.Count;
		}
		int num = 0;
		IEnumerator enumerator = ienumerable_0.GetEnumerator();
		while (enumerator.MoveNext())
		{
			num++;
		}
		return num;
	}

	// Token: 0x06000189 RID: 393 RVA: 0x000482F0 File Offset: 0x000464F0
	public static string smethod_17(IEnumerable<byte> ienumerable_0)
	{
		StringBuilder stringBuilder = new StringBuilder(GClass18.smethod_16(ienumerable_0) * 2);
		foreach (byte b in ienumerable_0)
		{
			stringBuilder.AppendFormat("{0:X2}", b);
		}
		return stringBuilder.ToString();
	}

	// Token: 0x0600018A RID: 394 RVA: 0x00048358 File Offset: 0x00046558
	public static string smethod_18(IEnumerable<ushort> ienumerable_0)
	{
		StringBuilder stringBuilder = new StringBuilder(GClass18.smethod_16(ienumerable_0) * 2);
		foreach (ushort num in ienumerable_0)
		{
			stringBuilder.AppendFormat("{0:X4}", num);
		}
		return stringBuilder.ToString();
	}

	// Token: 0x0600018B RID: 395 RVA: 0x000483C0 File Offset: 0x000465C0
	public static string smethod_19(ushort ushort_0)
	{
		return "0x" + ushort_0.ToString("X4");
	}

	// Token: 0x0600018C RID: 396 RVA: 0x000483E4 File Offset: 0x000465E4
	public static string smethod_20(uint uint_0)
	{
		return "0x" + uint_0.ToString("X8");
	}

	// Token: 0x0600018D RID: 397 RVA: 0x00048408 File Offset: 0x00046608
	public static string smethod_21(ulong ulong_0)
	{
		return "0x" + ulong_0.ToString("X16");
	}

	// Token: 0x0600018E RID: 398 RVA: 0x0004842C File Offset: 0x0004662C
	public static bool smethod_22(string string_0)
	{
		bool flag;
		try
		{
			new X509Certificate2(X509Certificate.CreateFromSignedFile(string_0));
			return true;
		}
		catch (Exception)
		{
			flag = false;
		}
		return flag;
	}

	// Token: 0x0600018F RID: 399 RVA: 0x00048460 File Offset: 0x00046660
	public static bool smethod_23(string string_0, bool bool_0)
	{
		X509Certificate2 x509Certificate;
		bool flag;
		try
		{
			x509Certificate = new X509Certificate2(X509Certificate.CreateFromSignedFile(string_0));
			goto IL_15;
		}
		catch (Exception)
		{
			flag = false;
		}
		return flag;
		IL_15:
		return GClass18.smethod_25(x509Certificate, bool_0);
	}

	// Token: 0x06000190 RID: 400 RVA: 0x0004849C File Offset: 0x0004669C
	public static bool smethod_24(string string_0)
	{
		return Class8.smethod_1(string_0);
	}

	// Token: 0x06000191 RID: 401 RVA: 0x000484B0 File Offset: 0x000466B0
	public static bool smethod_25(X509Certificate2 x509Certificate2_0, bool bool_0)
	{
		return new X509Chain
		{
			ChainPolicy = 
			{
				RevocationFlag = X509RevocationFlag.ExcludeRoot,
				RevocationMode = (bool_0 ? X509RevocationMode.Online : X509RevocationMode.Offline),
				UrlRetrievalTimeout = new TimeSpan(0, 0, 5),
				VerificationFlags = X509VerificationFlags.NoFlag
			}
		}.Build(x509Certificate2_0);
	}

	// Token: 0x040001BD RID: 445
	public static readonly int int_0 = 256;

	// Token: 0x0200003B RID: 59
	public class GClass19
	{
		// Token: 0x06000193 RID: 403 RVA: 0x00048520 File Offset: 0x00046720
		public GClass19(ushort ushort_0)
		{
			if ((ushort_0 & 1) > 0)
			{
				this.Boolean_0 = true;
			}
			if ((ushort_0 & 2) > 0)
			{
				this.Boolean_1 = true;
			}
			if ((ushort_0 & 4) > 0)
			{
				this.Boolean_2 = true;
			}
			if ((ushort_0 & 8) > 0)
			{
				this.Boolean_3 = true;
			}
			if ((ushort_0 & 16) > 0)
			{
				this.Boolean_4 = true;
			}
			if ((ushort_0 & 32) > 0)
			{
				this.Boolean_5 = true;
			}
			if ((ushort_0 & 128) > 0)
			{
				this.Boolean_6 = true;
			}
			if ((ushort_0 & 256) > 0)
			{
				this.Boolean_7 = true;
			}
			if ((ushort_0 & 512) > 0)
			{
				this.Boolean_8 = true;
			}
			if ((ushort_0 & 1024) > 0)
			{
				this.Boolean_9 = true;
			}
			if ((ushort_0 & 2048) > 0)
			{
				this.Boolean_10 = true;
			}
			if ((ushort_0 & 4096) > 0)
			{
				this.Boolean_11 = true;
			}
			if ((ushort_0 & 8192) > 0)
			{
				this.Boolean_12 = true;
			}
			if ((ushort_0 & 16384) > 0)
			{
				this.Boolean_13 = true;
			}
			if ((ushort_0 & 32768) > 0)
			{
				this.Boolean_14 = true;
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x06000194 RID: 404 RVA: 0x0004861C File Offset: 0x0004681C
		// (set) Token: 0x06000195 RID: 405 RVA: 0x00048630 File Offset: 0x00046830
		public bool Boolean_0 { get; private set; }

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x06000196 RID: 406 RVA: 0x00048644 File Offset: 0x00046844
		// (set) Token: 0x06000197 RID: 407 RVA: 0x00048658 File Offset: 0x00046858
		public bool Boolean_1 { get; private set; }

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x06000198 RID: 408 RVA: 0x0004866C File Offset: 0x0004686C
		// (set) Token: 0x06000199 RID: 409 RVA: 0x00048680 File Offset: 0x00046880
		public bool Boolean_2 { get; private set; }

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x0600019A RID: 410 RVA: 0x00048694 File Offset: 0x00046894
		// (set) Token: 0x0600019B RID: 411 RVA: 0x000486A8 File Offset: 0x000468A8
		public bool Boolean_3 { get; private set; }

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x0600019C RID: 412 RVA: 0x000486BC File Offset: 0x000468BC
		// (set) Token: 0x0600019D RID: 413 RVA: 0x000486D0 File Offset: 0x000468D0
		public bool Boolean_4 { get; private set; }

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x0600019E RID: 414 RVA: 0x000486E4 File Offset: 0x000468E4
		// (set) Token: 0x0600019F RID: 415 RVA: 0x000486F8 File Offset: 0x000468F8
		public bool Boolean_5 { get; private set; }

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x060001A0 RID: 416 RVA: 0x0004870C File Offset: 0x0004690C
		// (set) Token: 0x060001A1 RID: 417 RVA: 0x00048720 File Offset: 0x00046920
		public bool Boolean_6 { get; private set; }

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x060001A2 RID: 418 RVA: 0x00048734 File Offset: 0x00046934
		// (set) Token: 0x060001A3 RID: 419 RVA: 0x00048748 File Offset: 0x00046948
		public bool Boolean_7 { get; private set; }

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x060001A4 RID: 420 RVA: 0x0004875C File Offset: 0x0004695C
		// (set) Token: 0x060001A5 RID: 421 RVA: 0x00048770 File Offset: 0x00046970
		public bool Boolean_8 { get; private set; }

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x060001A6 RID: 422 RVA: 0x00048784 File Offset: 0x00046984
		// (set) Token: 0x060001A7 RID: 423 RVA: 0x00048798 File Offset: 0x00046998
		public bool Boolean_9 { get; private set; }

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x060001A8 RID: 424 RVA: 0x000487AC File Offset: 0x000469AC
		// (set) Token: 0x060001A9 RID: 425 RVA: 0x000487C0 File Offset: 0x000469C0
		public bool Boolean_10 { get; private set; }

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x060001AA RID: 426 RVA: 0x000487D4 File Offset: 0x000469D4
		// (set) Token: 0x060001AB RID: 427 RVA: 0x000487E8 File Offset: 0x000469E8
		public bool Boolean_11 { get; private set; }

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x060001AC RID: 428 RVA: 0x000487FC File Offset: 0x000469FC
		// (set) Token: 0x060001AD RID: 429 RVA: 0x00048810 File Offset: 0x00046A10
		public bool Boolean_12 { get; private set; }

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x060001AE RID: 430 RVA: 0x00048824 File Offset: 0x00046A24
		// (set) Token: 0x060001AF RID: 431 RVA: 0x00048838 File Offset: 0x00046A38
		public bool Boolean_13 { get; private set; }

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x060001B0 RID: 432 RVA: 0x0004884C File Offset: 0x00046A4C
		// (set) Token: 0x060001B1 RID: 433 RVA: 0x00048860 File Offset: 0x00046A60
		public bool Boolean_14 { get; private set; }

		// Token: 0x060001B2 RID: 434 RVA: 0x00048874 File Offset: 0x00046A74
		public virtual string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder("File Characteristics\n");
			stringBuilder.Append(GClass18.smethod_9(this, "{0,-30}:{1,10:X}\n"));
			return stringBuilder.ToString();
		}

		// Token: 0x040001BE RID: 446
		[CompilerGenerated]
		private bool bool_0;

		// Token: 0x040001BF RID: 447
		[CompilerGenerated]
		private bool bool_1;

		// Token: 0x040001C0 RID: 448
		[CompilerGenerated]
		private bool bool_2;

		// Token: 0x040001C1 RID: 449
		[CompilerGenerated]
		private bool bool_3;

		// Token: 0x040001C2 RID: 450
		[CompilerGenerated]
		private bool bool_4;

		// Token: 0x040001C3 RID: 451
		[CompilerGenerated]
		private bool bool_5;

		// Token: 0x040001C4 RID: 452
		[CompilerGenerated]
		private bool bool_6;

		// Token: 0x040001C5 RID: 453
		[CompilerGenerated]
		private bool bool_7;

		// Token: 0x040001C6 RID: 454
		[CompilerGenerated]
		private bool bool_8;

		// Token: 0x040001C7 RID: 455
		[CompilerGenerated]
		private bool bool_9;

		// Token: 0x040001C8 RID: 456
		[CompilerGenerated]
		private bool bool_10;

		// Token: 0x040001C9 RID: 457
		[CompilerGenerated]
		private bool bool_11;

		// Token: 0x040001CA RID: 458
		[CompilerGenerated]
		private bool bool_12;

		// Token: 0x040001CB RID: 459
		[CompilerGenerated]
		private bool bool_13;

		// Token: 0x040001CC RID: 460
		[CompilerGenerated]
		private bool bool_14;
	}
}
