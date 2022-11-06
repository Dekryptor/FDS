using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

// Token: 0x0200001B RID: 27
public class GClass9 : GInterface0
{
	// Token: 0x060000D0 RID: 208 RVA: 0x000412F8 File Offset: 0x0003F4F8
	public GClass9(byte[] byte_1, string string_1)
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
		byte[] array3 = new byte[64];
		Buffer.BlockCopy(array2, 44, array3, 0, 64);
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
			this.Prop_3.Add(new GClass1(array4, false));
			j += 32;
		}
		this.Prop_4 = new List<GClass4>();
		byte[] array6 = new byte[8 * this.Int32_3];
		Buffer.BlockCopy(byte_1, this.Int32_2, array6, 0, 8 * this.Int32_3);
		int k = 0;
		byte[] array7 = new byte[8];
		while (k < array6.Length)
		{
			Buffer.BlockCopy(array6, k, array7, 0, 8);
			this.Prop_4.Add(new GClass4(array7, true));
			k += 8;
		}
		byte[] array8 = new byte[this.Int32_5];
		Buffer.BlockCopy(byte_1, this.Int32_4, array8, 0, this.Int32_5);
		string[] array9 = Encoding.Unicode.GetString(array8).Split(new char[1], StringSplitOptions.RemoveEmptyEntries);
		this.Prop_2 = new List<string>();
		this.Prop_2.AddRange(array9);
		byte[] array10 = new byte[this.Int32_8];
		Buffer.BlockCopy(byte_1, this.Int32_6, array10, 0, this.Int32_8);
		this.Prop_1 = new List<GClass11>();
		byte[] array11 = new byte[96];
		for (int l = 0; l < this.Int32_7; l++)
		{
			int num2 = l * 96;
			Buffer.BlockCopy(array10, num2, array11, 0, 96);
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

	// Token: 0x17000070 RID: 112
	// (get) Token: 0x060000D1 RID: 209 RVA: 0x00041840 File Offset: 0x0003FA40
	public byte[] Byte_0 { get; }

	// Token: 0x17000071 RID: 113
	// (get) Token: 0x060000D2 RID: 210 RVA: 0x00041854 File Offset: 0x0003FA54
	public string String_0 { get; }

	// Token: 0x17000072 RID: 114
	// (get) Token: 0x060000D3 RID: 211 RVA: 0x00041868 File Offset: 0x0003FA68
	public DateTimeOffset DateTimeOffset_0 { get; }

	// Token: 0x17000073 RID: 115
	// (get) Token: 0x060000D4 RID: 212 RVA: 0x0004187C File Offset: 0x0003FA7C
	public DateTimeOffset DateTimeOffset_1 { get; }

	// Token: 0x17000074 RID: 116
	// (get) Token: 0x060000D5 RID: 213 RVA: 0x00041890 File Offset: 0x0003FA90
	public DateTimeOffset DateTimeOffset_2 { get; }

	// Token: 0x17000075 RID: 117
	// (get) Token: 0x060000D6 RID: 214 RVA: 0x000418A4 File Offset: 0x0003FAA4
	public GClass2 GClass2_0 { get; }

	// Token: 0x17000076 RID: 118
	// (get) Token: 0x060000D7 RID: 215 RVA: 0x000418B8 File Offset: 0x0003FAB8
	public int Int32_0 { get; }

	// Token: 0x17000077 RID: 119
	// (get) Token: 0x060000D8 RID: 216 RVA: 0x000418CC File Offset: 0x0003FACC
	public int Int32_1 { get; }

	// Token: 0x17000078 RID: 120
	// (get) Token: 0x060000D9 RID: 217 RVA: 0x000418E0 File Offset: 0x0003FAE0
	public int Int32_2 { get; }

	// Token: 0x17000079 RID: 121
	// (get) Token: 0x060000DA RID: 218 RVA: 0x000418F4 File Offset: 0x0003FAF4
	public int Int32_3 { get; }

	// Token: 0x1700007A RID: 122
	// (get) Token: 0x060000DB RID: 219 RVA: 0x00041908 File Offset: 0x0003FB08
	public int Int32_4 { get; }

	// Token: 0x1700007B RID: 123
	// (get) Token: 0x060000DC RID: 220 RVA: 0x0004191C File Offset: 0x0003FB1C
	public int Int32_5 { get; }

	// Token: 0x1700007C RID: 124
	// (get) Token: 0x060000DD RID: 221 RVA: 0x00041930 File Offset: 0x0003FB30
	public int Int32_6 { get; }

	// Token: 0x1700007D RID: 125
	// (get) Token: 0x060000DE RID: 222 RVA: 0x00041944 File Offset: 0x0003FB44
	public int Int32_7 { get; }

	// Token: 0x1700007E RID: 126
	// (get) Token: 0x060000DF RID: 223 RVA: 0x00041958 File Offset: 0x0003FB58
	public int Int32_8 { get; }

	// Token: 0x1700007F RID: 127
	// (get) Token: 0x060000E0 RID: 224 RVA: 0x0004196C File Offset: 0x0003FB6C
	public int Int32_9 { get; }

	// Token: 0x17000080 RID: 128
	// (get) Token: 0x060000E1 RID: 225 RVA: 0x00041980 File Offset: 0x0003FB80
	public List<DateTimeOffset> Prop_0 { get; }

	// Token: 0x17000081 RID: 129
	// (get) Token: 0x060000E2 RID: 226 RVA: 0x00041994 File Offset: 0x0003FB94
	public List<GClass11> Prop_1 { get; }

	// Token: 0x17000082 RID: 130
	// (get) Token: 0x060000E3 RID: 227 RVA: 0x000419A8 File Offset: 0x0003FBA8
	public int Int32_10 { get; }

	// Token: 0x17000083 RID: 131
	// (get) Token: 0x060000E4 RID: 228 RVA: 0x000419BC File Offset: 0x0003FBBC
	public List<string> Prop_2 { get; }

	// Token: 0x17000084 RID: 132
	// (get) Token: 0x060000E5 RID: 229 RVA: 0x000419D0 File Offset: 0x0003FBD0
	public List<GClass1> Prop_3 { get; }

	// Token: 0x17000085 RID: 133
	// (get) Token: 0x060000E6 RID: 230 RVA: 0x000419E4 File Offset: 0x0003FBE4
	public List<GClass4> Prop_4 { get; }

	// Token: 0x0400009F RID: 159
	[CompilerGenerated]
	private readonly byte[] byte_0;

	// Token: 0x040000A0 RID: 160
	[CompilerGenerated]
	private readonly string string_0;

	// Token: 0x040000A1 RID: 161
	[CompilerGenerated]
	private readonly DateTimeOffset dateTimeOffset_0;

	// Token: 0x040000A2 RID: 162
	[CompilerGenerated]
	private readonly DateTimeOffset dateTimeOffset_1;

	// Token: 0x040000A3 RID: 163
	[CompilerGenerated]
	private readonly DateTimeOffset dateTimeOffset_2;

	// Token: 0x040000A4 RID: 164
	[CompilerGenerated]
	private readonly GClass2 gclass2_0;

	// Token: 0x040000A5 RID: 165
	[CompilerGenerated]
	private readonly int int_0;

	// Token: 0x040000A6 RID: 166
	[CompilerGenerated]
	private readonly int int_1;

	// Token: 0x040000A7 RID: 167
	[CompilerGenerated]
	private readonly int int_2;

	// Token: 0x040000A8 RID: 168
	[CompilerGenerated]
	private readonly int int_3;

	// Token: 0x040000A9 RID: 169
	[CompilerGenerated]
	private readonly int int_4;

	// Token: 0x040000AA RID: 170
	[CompilerGenerated]
	private readonly int int_5;

	// Token: 0x040000AB RID: 171
	[CompilerGenerated]
	private readonly int int_6;

	// Token: 0x040000AC RID: 172
	[CompilerGenerated]
	private readonly int int_7;

	// Token: 0x040000AD RID: 173
	[CompilerGenerated]
	private readonly int int_8;

	// Token: 0x040000AE RID: 174
	[CompilerGenerated]
	private readonly int int_9;

	// Token: 0x040000AF RID: 175
	[CompilerGenerated]
	private readonly List<DateTimeOffset> list_0;

	// Token: 0x040000B0 RID: 176
	[CompilerGenerated]
	private readonly List<GClass11> list_1;

	// Token: 0x040000B1 RID: 177
	[CompilerGenerated]
	private readonly int int_10;

	// Token: 0x040000B2 RID: 178
	[CompilerGenerated]
	private readonly List<string> list_2;

	// Token: 0x040000B3 RID: 179
	[CompilerGenerated]
	private readonly List<GClass1> list_3;

	// Token: 0x040000B4 RID: 180
	[CompilerGenerated]
	private readonly List<GClass4> list_4;
}
