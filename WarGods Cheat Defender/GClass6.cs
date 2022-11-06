using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

// Token: 0x02000018 RID: 24
public class GClass6 : GInterface0
{
	// Token: 0x0600008B RID: 139 RVA: 0x0003FEB0 File Offset: 0x0003E0B0
	public GClass6(byte[] byte_1, string string_1)
	{
		this.String_0 = string_1;
		this.Byte_0 = byte_1;
		byte[] array = new byte[84];
		Buffer.BlockCopy(byte_1, 0, array, 0, 84);
		this.GClass2_0 = new GClass2(array);
		FileInfo fileInfo = new FileInfo(string_1);
		this.DateTimeOffset_0 = new DateTimeOffset(fileInfo.CreationTimeUtc);
		this.DateTimeOffset_1 = new DateTimeOffset(fileInfo.LastWriteTimeUtc);
		this.DateTimeOffset_2 = new DateTimeOffset(fileInfo.LastAccessTimeUtc);
		byte[] array2 = new byte[68];
		Buffer.BlockCopy(byte_1, 84, array2, 0, 68);
		this.Int32_0 = BitConverter.ToInt32(array2, 0);
		this.Int32_1 = BitConverter.ToInt32(array2, 4);
		this.Int32_2 = BitConverter.ToInt32(array2, 8);
		this.Int32_3 = BitConverter.ToInt32(array2, 12);
		this.Int32_4 = BitConverter.ToInt32(array2, 16);
		this.Int32_5 = BitConverter.ToInt32(array2, 20);
		this.Int32_6 = BitConverter.ToInt32(array2, 24);
		this.Int32_7 = BitConverter.ToInt32(array2, 28);
		this.Int32_8 = BitConverter.ToInt32(array2, 32);
		long num = BitConverter.ToInt64(array2, 36);
		this.Prop_0 = new List<DateTimeOffset>();
		this.Prop_0.Add(DateTimeOffset.FromFileTime(num).ToUniversalTime());
		this.Int32_9 = -1;
		this.Int32_10 = BitConverter.ToInt32(array2, 60);
		byte[] array3 = new byte[this.Int32_1 * 20];
		Buffer.BlockCopy(byte_1, this.Int32_0, array3, 0, this.Int32_1 * 20);
		int i = 0;
		this.Prop_3 = new List<GClass1>();
		byte[] array4 = new byte[20];
		while (i < array3.Length)
		{
			Buffer.BlockCopy(array3, i, array4, 0, 20);
			this.Prop_3.Add(new GClass1(array4, true));
			i += 20;
		}
		this.Prop_4 = new List<GClass4>();
		byte[] array5 = new byte[12 * this.Int32_3];
		Buffer.BlockCopy(byte_1, this.Int32_2, array5, 0, 12 * this.Int32_3);
		int j = 0;
		byte[] array6 = new byte[12];
		while (j < array5.Length)
		{
			Buffer.BlockCopy(array5, j, array6, 0, 12);
			this.Prop_4.Add(new GClass4(array6, false));
			j += 12;
		}
		byte[] array7 = new byte[this.Int32_5];
		Buffer.BlockCopy(byte_1, this.Int32_4, array7, 0, this.Int32_5);
		string[] array8 = Encoding.Unicode.GetString(array7).Split(new char[1], StringSplitOptions.RemoveEmptyEntries);
		this.Prop_2 = new List<string>();
		this.Prop_2.AddRange(array8);
		byte[] array9 = new byte[this.Int32_8];
		Buffer.BlockCopy(byte_1, this.Int32_6, array9, 0, this.Int32_8);
		this.Prop_1 = new List<GClass11>();
		byte[] array10 = new byte[40];
		for (int k = 0; k < this.Int32_7; k++)
		{
			int num2 = k * 40;
			Buffer.BlockCopy(array9, num2, array10, 0, 40);
			int num3 = BitConverter.ToInt32(array10, 0);
			int num4 = BitConverter.ToInt32(array10, 4);
			long num5 = BitConverter.ToInt64(array10, 8);
			byte[] array11 = new byte[num4 * 2];
			Buffer.BlockCopy(byte_1, this.Int32_6 + num3, array11, 0, num4 * 2);
			string @string = Encoding.Unicode.GetString(array11);
			string text = BitConverter.ToInt32(array10, 16).ToString("X");
			this.Prop_1.Add(new GClass11(num3, DateTimeOffset.FromFileTime(num5).ToUniversalTime(), text, @string));
			int num6 = BitConverter.ToInt32(array10, 20);
			int num7 = BitConverter.ToInt32(array10, 24);
			int num8 = BitConverter.ToInt32(array10, 28);
			int num9 = BitConverter.ToInt32(array10, 32);
			int num10 = this.Int32_6 + num6;
			byte[] array12 = new byte[num7];
			Buffer.BlockCopy(byte_1, num10, array12, 0, num7);
			BitConverter.ToInt32(array12, 0);
			int num11 = BitConverter.ToInt32(array12, 4);
			i = 8;
			byte[] array13 = new byte[8];
			while (i < array12.Length && this.Prop_1[this.Prop_1.Count - 1].List_0.Count < num11)
			{
				Buffer.BlockCopy(array12, i, array13, 0, 8);
				this.Prop_1[this.Prop_1.Count - 1].List_0.Add(new GClass3(array13));
				i += 8;
			}
			int num12 = this.Int32_6 + num8;
			byte[] array14 = new byte[byte_1.Length - num12];
			Buffer.BlockCopy(byte_1, num12, array14, 0, byte_1.Length - num12);
			i = 0;
			for (int l = 0; l < num9; l++)
			{
				int num13 = (int)(BitConverter.ToInt16(array14, i) * 2 + 2);
				i += 2;
				string text2 = Encoding.Unicode.GetString(array14, i, num13).Trim(new char[1]);
				this.Prop_1[this.Prop_1.Count - 1].List_1.Add(text2);
				i += num13;
			}
		}
	}

	// Token: 0x1700002E RID: 46
	// (get) Token: 0x0600008C RID: 140 RVA: 0x00040398 File Offset: 0x0003E598
	public byte[] Byte_0 { get; }

	// Token: 0x1700002F RID: 47
	// (get) Token: 0x0600008D RID: 141 RVA: 0x000403AC File Offset: 0x0003E5AC
	public string String_0 { get; }

	// Token: 0x17000030 RID: 48
	// (get) Token: 0x0600008E RID: 142 RVA: 0x000403C0 File Offset: 0x0003E5C0
	public DateTimeOffset DateTimeOffset_0 { get; }

	// Token: 0x17000031 RID: 49
	// (get) Token: 0x0600008F RID: 143 RVA: 0x000403D4 File Offset: 0x0003E5D4
	public DateTimeOffset DateTimeOffset_1 { get; }

	// Token: 0x17000032 RID: 50
	// (get) Token: 0x06000090 RID: 144 RVA: 0x000403E8 File Offset: 0x0003E5E8
	public DateTimeOffset DateTimeOffset_2 { get; }

	// Token: 0x17000033 RID: 51
	// (get) Token: 0x06000091 RID: 145 RVA: 0x000403FC File Offset: 0x0003E5FC
	public GClass2 GClass2_0 { get; }

	// Token: 0x17000034 RID: 52
	// (get) Token: 0x06000092 RID: 146 RVA: 0x00040410 File Offset: 0x0003E610
	public int Int32_0 { get; }

	// Token: 0x17000035 RID: 53
	// (get) Token: 0x06000093 RID: 147 RVA: 0x00040424 File Offset: 0x0003E624
	public int Int32_1 { get; }

	// Token: 0x17000036 RID: 54
	// (get) Token: 0x06000094 RID: 148 RVA: 0x00040438 File Offset: 0x0003E638
	public int Int32_2 { get; }

	// Token: 0x17000037 RID: 55
	// (get) Token: 0x06000095 RID: 149 RVA: 0x0004044C File Offset: 0x0003E64C
	public int Int32_3 { get; }

	// Token: 0x17000038 RID: 56
	// (get) Token: 0x06000096 RID: 150 RVA: 0x00040460 File Offset: 0x0003E660
	public int Int32_4 { get; }

	// Token: 0x17000039 RID: 57
	// (get) Token: 0x06000097 RID: 151 RVA: 0x00040474 File Offset: 0x0003E674
	public int Int32_5 { get; }

	// Token: 0x1700003A RID: 58
	// (get) Token: 0x06000098 RID: 152 RVA: 0x00040488 File Offset: 0x0003E688
	public int Int32_6 { get; }

	// Token: 0x1700003B RID: 59
	// (get) Token: 0x06000099 RID: 153 RVA: 0x0004049C File Offset: 0x0003E69C
	public int Int32_7 { get; }

	// Token: 0x1700003C RID: 60
	// (get) Token: 0x0600009A RID: 154 RVA: 0x000404B0 File Offset: 0x0003E6B0
	public int Int32_8 { get; }

	// Token: 0x1700003D RID: 61
	// (get) Token: 0x0600009B RID: 155 RVA: 0x000404C4 File Offset: 0x0003E6C4
	public int Int32_9 { get; }

	// Token: 0x1700003E RID: 62
	// (get) Token: 0x0600009C RID: 156 RVA: 0x000404D8 File Offset: 0x0003E6D8
	public List<DateTimeOffset> Prop_0 { get; }

	// Token: 0x1700003F RID: 63
	// (get) Token: 0x0600009D RID: 157 RVA: 0x000404EC File Offset: 0x0003E6EC
	public List<GClass11> Prop_1 { get; }

	// Token: 0x17000040 RID: 64
	// (get) Token: 0x0600009E RID: 158 RVA: 0x00040500 File Offset: 0x0003E700
	public int Int32_10 { get; }

	// Token: 0x17000041 RID: 65
	// (get) Token: 0x0600009F RID: 159 RVA: 0x00040514 File Offset: 0x0003E714
	public List<string> Prop_2 { get; }

	// Token: 0x17000042 RID: 66
	// (get) Token: 0x060000A0 RID: 160 RVA: 0x00040528 File Offset: 0x0003E728
	public List<GClass1> Prop_3 { get; }

	// Token: 0x17000043 RID: 67
	// (get) Token: 0x060000A1 RID: 161 RVA: 0x0004053C File Offset: 0x0003E73C
	public List<GClass4> Prop_4 { get; }

	// Token: 0x0400005D RID: 93
	[CompilerGenerated]
	private readonly byte[] byte_0;

	// Token: 0x0400005E RID: 94
	[CompilerGenerated]
	private readonly string string_0;

	// Token: 0x0400005F RID: 95
	[CompilerGenerated]
	private readonly DateTimeOffset dateTimeOffset_0;

	// Token: 0x04000060 RID: 96
	[CompilerGenerated]
	private readonly DateTimeOffset dateTimeOffset_1;

	// Token: 0x04000061 RID: 97
	[CompilerGenerated]
	private readonly DateTimeOffset dateTimeOffset_2;

	// Token: 0x04000062 RID: 98
	[CompilerGenerated]
	private readonly GClass2 gclass2_0;

	// Token: 0x04000063 RID: 99
	[CompilerGenerated]
	private readonly int int_0;

	// Token: 0x04000064 RID: 100
	[CompilerGenerated]
	private readonly int int_1;

	// Token: 0x04000065 RID: 101
	[CompilerGenerated]
	private readonly int int_2;

	// Token: 0x04000066 RID: 102
	[CompilerGenerated]
	private readonly int int_3;

	// Token: 0x04000067 RID: 103
	[CompilerGenerated]
	private readonly int int_4;

	// Token: 0x04000068 RID: 104
	[CompilerGenerated]
	private readonly int int_5;

	// Token: 0x04000069 RID: 105
	[CompilerGenerated]
	private readonly int int_6;

	// Token: 0x0400006A RID: 106
	[CompilerGenerated]
	private readonly int int_7;

	// Token: 0x0400006B RID: 107
	[CompilerGenerated]
	private readonly int int_8;

	// Token: 0x0400006C RID: 108
	[CompilerGenerated]
	private readonly int int_9;

	// Token: 0x0400006D RID: 109
	[CompilerGenerated]
	private readonly List<DateTimeOffset> list_0;

	// Token: 0x0400006E RID: 110
	[CompilerGenerated]
	private readonly List<GClass11> list_1;

	// Token: 0x0400006F RID: 111
	[CompilerGenerated]
	private readonly int int_10;

	// Token: 0x04000070 RID: 112
	[CompilerGenerated]
	private readonly List<string> list_2;

	// Token: 0x04000071 RID: 113
	[CompilerGenerated]
	private readonly List<GClass1> list_3;

	// Token: 0x04000072 RID: 114
	[CompilerGenerated]
	private readonly List<GClass4> list_4;
}
