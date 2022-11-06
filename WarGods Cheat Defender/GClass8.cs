using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

// Token: 0x0200001A RID: 26
public class GClass8 : GInterface0
{
	// Token: 0x060000B9 RID: 185 RVA: 0x00040BFC File Offset: 0x0003EDFC
	public GClass8(byte[] byte_1, string string_1)
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
		byte[] array2 = new byte[224];
		Buffer.BlockCopy(byte_1, 84, array2, 0, 224);
		this.Int32_0 = BitConverter.ToInt32(array2, 0);
		this.Int32_1 = BitConverter.ToInt32(array2, 4);
		this.Int32_2 = BitConverter.ToInt32(array2, 8);
		this.Int32_3 = BitConverter.ToInt32(array2, 12);
		this.Int32_4 = BitConverter.ToInt32(array2, 16);
		this.Int32_5 = BitConverter.ToInt32(array2, 20);
		this.Int32_6 = BitConverter.ToInt32(array2, 24);
		this.Int32_7 = BitConverter.ToInt32(array2, 28);
		this.Int32_8 = BitConverter.ToInt32(array2, 32);
		this.Int32_9 = BitConverter.ToInt32(array2, 36);
		byte[] array3 = GClass5.smethod_0(array2, 44, 64);
		this.Prop_0 = new List<DateTimeOffset>();
		for (int i = 0; i < 8; i++)
		{
			long num = BitConverter.ToInt64(array3, i * 8);
			if (num > 0L)
			{
				this.Prop_0.Add(DateTimeOffset.FromFileTime(num).ToUniversalTime());
			}
		}
		this.Int32_10 = BitConverter.ToInt32(array2, 124);
		BitConverter.ToInt32(array2, 128);
		BitConverter.ToInt32(array2, 132);
		BitConverter.ToInt32(array2, 128);
		byte[] array4 = new byte[this.Int32_1 * 32];
		Buffer.BlockCopy(byte_1, this.Int32_0, array4, 0, this.Int32_1 * 32);
		int j = 0;
		this.Prop_3 = new List<GClass1>();
		byte[] array5 = new byte[32];
		while (j < array4.Length)
		{
			Buffer.BlockCopy(array4, j, array5, 0, 32);
			this.Prop_3.Add(new GClass1(array5, false));
			j += 32;
		}
		this.Prop_4 = new List<GClass4>();
		byte[] array6 = new byte[12 * this.Int32_3];
		Buffer.BlockCopy(byte_1, this.Int32_2, array6, 0, 12 * this.Int32_3);
		int k = 0;
		byte[] array7 = new byte[12];
		while (k < array6.Length)
		{
			Buffer.BlockCopy(array6, k, array7, 0, 12);
			this.Prop_4.Add(new GClass4(array7, false));
			k += 12;
		}
		byte[] array8 = new byte[this.Int32_5];
		Buffer.BlockCopy(byte_1, this.Int32_4, array8, 0, this.Int32_5);
		string[] array9 = Encoding.Unicode.GetString(array8).Split(new char[1], StringSplitOptions.RemoveEmptyEntries);
		this.Prop_2 = new List<string>();
		this.Prop_2.AddRange(array9);
		byte[] array10 = new byte[this.Int32_8];
		Buffer.BlockCopy(byte_1, this.Int32_6, array10, 0, this.Int32_8);
		this.Prop_1 = new List<GClass11>();
		byte[] array11 = new byte[104];
		for (int l = 0; l < this.Int32_7; l++)
		{
			int num2 = l * 104;
			Buffer.BlockCopy(array10, num2, array11, 0, 104);
			int num3 = BitConverter.ToInt32(array11, 0);
			int num4 = BitConverter.ToInt32(array11, 4);
			long num5 = BitConverter.ToInt64(array11, 8);
			byte[] array12 = new byte[num4 * 2];
			Buffer.BlockCopy(byte_1, this.Int32_6 + num3, array12, 0, num4 * 2);
			string @string = Encoding.Unicode.GetString(array12);
			string text = BitConverter.ToInt32(array11, 16).ToString("X");
			this.Prop_1.Add(new GClass11(num3, DateTimeOffset.FromFileTime(num5).ToUniversalTime(), text, @string));
			int num6 = BitConverter.ToInt32(array11, 20);
			int num7 = BitConverter.ToInt32(array11, 24);
			int num8 = BitConverter.ToInt32(array11, 28);
			int num9 = BitConverter.ToInt32(array11, 32);
			int num10 = this.Int32_6 + num6;
			byte[] array13 = new byte[num7];
			Buffer.BlockCopy(byte_1, num10, array13, 0, num7);
			BitConverter.ToInt32(array13, 0);
			int num11 = BitConverter.ToInt32(array13, 4);
			j = 8;
			byte[] array14 = new byte[8];
			while (j < array13.Length && this.Prop_1[this.Prop_1.Count - 1].List_0.Count < num11)
			{
				Buffer.BlockCopy(array13, j, array14, 0, 8);
				this.Prop_1[this.Prop_1.Count - 1].List_0.Add(new GClass3(array14));
				j += 8;
			}
			int num12 = this.Int32_6 + num8;
			byte[] array15 = new byte[byte_1.Length - num12];
			Buffer.BlockCopy(byte_1, num12, array15, 0, byte_1.Length - num12);
			j = 0;
			for (int m = 0; m < num9; m++)
			{
				int num13 = (int)(BitConverter.ToInt16(array15, j) * 2 + 2);
				j += 2;
				string text2 = Encoding.Unicode.GetString(array15, j, num13).Trim(new char[1]);
				this.Prop_1[this.Prop_1.Count - 1].List_1.Add(text2);
				j += num13;
			}
		}
	}

	// Token: 0x1700005A RID: 90
	// (get) Token: 0x060000BA RID: 186 RVA: 0x00041140 File Offset: 0x0003F340
	public byte[] Byte_0 { get; }

	// Token: 0x1700005B RID: 91
	// (get) Token: 0x060000BB RID: 187 RVA: 0x00041154 File Offset: 0x0003F354
	public string String_0 { get; }

	// Token: 0x1700005C RID: 92
	// (get) Token: 0x060000BC RID: 188 RVA: 0x00041168 File Offset: 0x0003F368
	public DateTimeOffset DateTimeOffset_0 { get; }

	// Token: 0x1700005D RID: 93
	// (get) Token: 0x060000BD RID: 189 RVA: 0x0004117C File Offset: 0x0003F37C
	public DateTimeOffset DateTimeOffset_1 { get; }

	// Token: 0x1700005E RID: 94
	// (get) Token: 0x060000BE RID: 190 RVA: 0x00041190 File Offset: 0x0003F390
	public DateTimeOffset DateTimeOffset_2 { get; }

	// Token: 0x1700005F RID: 95
	// (get) Token: 0x060000BF RID: 191 RVA: 0x000411A4 File Offset: 0x0003F3A4
	public GClass2 GClass2_0 { get; }

	// Token: 0x17000060 RID: 96
	// (get) Token: 0x060000C0 RID: 192 RVA: 0x000411B8 File Offset: 0x0003F3B8
	public int Int32_0 { get; }

	// Token: 0x17000061 RID: 97
	// (get) Token: 0x060000C1 RID: 193 RVA: 0x000411CC File Offset: 0x0003F3CC
	public int Int32_1 { get; }

	// Token: 0x17000062 RID: 98
	// (get) Token: 0x060000C2 RID: 194 RVA: 0x000411E0 File Offset: 0x0003F3E0
	public int Int32_2 { get; }

	// Token: 0x17000063 RID: 99
	// (get) Token: 0x060000C3 RID: 195 RVA: 0x000411F4 File Offset: 0x0003F3F4
	public int Int32_3 { get; }

	// Token: 0x17000064 RID: 100
	// (get) Token: 0x060000C4 RID: 196 RVA: 0x00041208 File Offset: 0x0003F408
	public int Int32_4 { get; }

	// Token: 0x17000065 RID: 101
	// (get) Token: 0x060000C5 RID: 197 RVA: 0x0004121C File Offset: 0x0003F41C
	public int Int32_5 { get; }

	// Token: 0x17000066 RID: 102
	// (get) Token: 0x060000C6 RID: 198 RVA: 0x00041230 File Offset: 0x0003F430
	public int Int32_6 { get; }

	// Token: 0x17000067 RID: 103
	// (get) Token: 0x060000C7 RID: 199 RVA: 0x00041244 File Offset: 0x0003F444
	public int Int32_7 { get; }

	// Token: 0x17000068 RID: 104
	// (get) Token: 0x060000C8 RID: 200 RVA: 0x00041258 File Offset: 0x0003F458
	public int Int32_8 { get; }

	// Token: 0x17000069 RID: 105
	// (get) Token: 0x060000C9 RID: 201 RVA: 0x0004126C File Offset: 0x0003F46C
	public int Int32_9 { get; }

	// Token: 0x1700006A RID: 106
	// (get) Token: 0x060000CA RID: 202 RVA: 0x00041280 File Offset: 0x0003F480
	public List<DateTimeOffset> Prop_0 { get; }

	// Token: 0x1700006B RID: 107
	// (get) Token: 0x060000CB RID: 203 RVA: 0x00041294 File Offset: 0x0003F494
	public List<GClass11> Prop_1 { get; }

	// Token: 0x1700006C RID: 108
	// (get) Token: 0x060000CC RID: 204 RVA: 0x000412A8 File Offset: 0x0003F4A8
	public int Int32_10 { get; }

	// Token: 0x1700006D RID: 109
	// (get) Token: 0x060000CD RID: 205 RVA: 0x000412BC File Offset: 0x0003F4BC
	public List<string> Prop_2 { get; }

	// Token: 0x1700006E RID: 110
	// (get) Token: 0x060000CE RID: 206 RVA: 0x000412D0 File Offset: 0x0003F4D0
	public List<GClass1> Prop_3 { get; }

	// Token: 0x1700006F RID: 111
	// (get) Token: 0x060000CF RID: 207 RVA: 0x000412E4 File Offset: 0x0003F4E4
	public List<GClass4> Prop_4 { get; }

	// Token: 0x04000089 RID: 137
	[CompilerGenerated]
	private readonly byte[] byte_0;

	// Token: 0x0400008A RID: 138
	[CompilerGenerated]
	private readonly string string_0;

	// Token: 0x0400008B RID: 139
	[CompilerGenerated]
	private readonly DateTimeOffset dateTimeOffset_0;

	// Token: 0x0400008C RID: 140
	[CompilerGenerated]
	private readonly DateTimeOffset dateTimeOffset_1;

	// Token: 0x0400008D RID: 141
	[CompilerGenerated]
	private readonly DateTimeOffset dateTimeOffset_2;

	// Token: 0x0400008E RID: 142
	[CompilerGenerated]
	private readonly GClass2 gclass2_0;

	// Token: 0x0400008F RID: 143
	[CompilerGenerated]
	private readonly int int_0;

	// Token: 0x04000090 RID: 144
	[CompilerGenerated]
	private readonly int int_1;

	// Token: 0x04000091 RID: 145
	[CompilerGenerated]
	private readonly int int_2;

	// Token: 0x04000092 RID: 146
	[CompilerGenerated]
	private readonly int int_3;

	// Token: 0x04000093 RID: 147
	[CompilerGenerated]
	private readonly int int_4;

	// Token: 0x04000094 RID: 148
	[CompilerGenerated]
	private readonly int int_5;

	// Token: 0x04000095 RID: 149
	[CompilerGenerated]
	private readonly int int_6;

	// Token: 0x04000096 RID: 150
	[CompilerGenerated]
	private readonly int int_7;

	// Token: 0x04000097 RID: 151
	[CompilerGenerated]
	private readonly int int_8;

	// Token: 0x04000098 RID: 152
	[CompilerGenerated]
	private readonly int int_9;

	// Token: 0x04000099 RID: 153
	[CompilerGenerated]
	private readonly List<DateTimeOffset> list_0;

	// Token: 0x0400009A RID: 154
	[CompilerGenerated]
	private readonly List<GClass11> list_1;

	// Token: 0x0400009B RID: 155
	[CompilerGenerated]
	private readonly int int_10;

	// Token: 0x0400009C RID: 156
	[CompilerGenerated]
	private readonly List<string> list_2;

	// Token: 0x0400009D RID: 157
	[CompilerGenerated]
	private readonly List<GClass1> list_3;

	// Token: 0x0400009E RID: 158
	[CompilerGenerated]
	private readonly List<GClass4> list_4;
}
