using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

// Token: 0x02000019 RID: 25
public class GClass7 : GInterface0
{
	// Token: 0x060000A2 RID: 162 RVA: 0x00040550 File Offset: 0x0003E750
	public GClass7(byte[] byte_1, string string_1)
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
		byte[] array2 = new byte[156];
		Buffer.BlockCopy(byte_1, 84, array2, 0, 156);
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
		long num = BitConverter.ToInt64(array2, 44);
		this.Prop_0 = new List<DateTimeOffset>();
		this.Prop_0.Add(DateTimeOffset.FromFileTime(num).ToUniversalTime());
		this.Int32_10 = BitConverter.ToInt32(array2, 68);
		byte[] array3 = new byte[this.Int32_1 * 32];
		Buffer.BlockCopy(byte_1, this.Int32_0, array3, 0, this.Int32_1 * 32);
		int i = 0;
		this.Prop_3 = new List<GClass1>();
		byte[] array4 = new byte[32];
		while (i < array3.Length)
		{
			Buffer.BlockCopy(array3, i, array4, 0, 32);
			this.Prop_3.Add(new GClass1(array4, false));
			i += 32;
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
		byte[] array10 = new byte[104];
		for (int k = 0; k < this.Int32_7; k++)
		{
			int num2 = k * 104;
			Buffer.BlockCopy(array9, num2, array10, 0, 104);
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

	// Token: 0x17000044 RID: 68
	// (get) Token: 0x060000A3 RID: 163 RVA: 0x00040A44 File Offset: 0x0003EC44
	public byte[] Byte_0 { get; }

	// Token: 0x17000045 RID: 69
	// (get) Token: 0x060000A4 RID: 164 RVA: 0x00040A58 File Offset: 0x0003EC58
	public string String_0 { get; }

	// Token: 0x17000046 RID: 70
	// (get) Token: 0x060000A5 RID: 165 RVA: 0x00040A6C File Offset: 0x0003EC6C
	public DateTimeOffset DateTimeOffset_0 { get; }

	// Token: 0x17000047 RID: 71
	// (get) Token: 0x060000A6 RID: 166 RVA: 0x00040A80 File Offset: 0x0003EC80
	public DateTimeOffset DateTimeOffset_1 { get; }

	// Token: 0x17000048 RID: 72
	// (get) Token: 0x060000A7 RID: 167 RVA: 0x00040A94 File Offset: 0x0003EC94
	public DateTimeOffset DateTimeOffset_2 { get; }

	// Token: 0x17000049 RID: 73
	// (get) Token: 0x060000A8 RID: 168 RVA: 0x00040AA8 File Offset: 0x0003ECA8
	public GClass2 GClass2_0 { get; }

	// Token: 0x1700004A RID: 74
	// (get) Token: 0x060000A9 RID: 169 RVA: 0x00040ABC File Offset: 0x0003ECBC
	public int Int32_0 { get; }

	// Token: 0x1700004B RID: 75
	// (get) Token: 0x060000AA RID: 170 RVA: 0x00040AD0 File Offset: 0x0003ECD0
	public int Int32_1 { get; }

	// Token: 0x1700004C RID: 76
	// (get) Token: 0x060000AB RID: 171 RVA: 0x00040AE4 File Offset: 0x0003ECE4
	public int Int32_2 { get; }

	// Token: 0x1700004D RID: 77
	// (get) Token: 0x060000AC RID: 172 RVA: 0x00040AF8 File Offset: 0x0003ECF8
	public int Int32_3 { get; }

	// Token: 0x1700004E RID: 78
	// (get) Token: 0x060000AD RID: 173 RVA: 0x00040B0C File Offset: 0x0003ED0C
	public int Int32_4 { get; }

	// Token: 0x1700004F RID: 79
	// (get) Token: 0x060000AE RID: 174 RVA: 0x00040B20 File Offset: 0x0003ED20
	public int Int32_5 { get; }

	// Token: 0x17000050 RID: 80
	// (get) Token: 0x060000AF RID: 175 RVA: 0x00040B34 File Offset: 0x0003ED34
	public int Int32_6 { get; }

	// Token: 0x17000051 RID: 81
	// (get) Token: 0x060000B0 RID: 176 RVA: 0x00040B48 File Offset: 0x0003ED48
	public int Int32_7 { get; }

	// Token: 0x17000052 RID: 82
	// (get) Token: 0x060000B1 RID: 177 RVA: 0x00040B5C File Offset: 0x0003ED5C
	public int Int32_8 { get; }

	// Token: 0x17000053 RID: 83
	// (get) Token: 0x060000B2 RID: 178 RVA: 0x00040B70 File Offset: 0x0003ED70
	public int Int32_9 { get; }

	// Token: 0x17000054 RID: 84
	// (get) Token: 0x060000B3 RID: 179 RVA: 0x00040B84 File Offset: 0x0003ED84
	public List<DateTimeOffset> Prop_0 { get; }

	// Token: 0x17000055 RID: 85
	// (get) Token: 0x060000B4 RID: 180 RVA: 0x00040B98 File Offset: 0x0003ED98
	public List<GClass11> Prop_1 { get; }

	// Token: 0x17000056 RID: 86
	// (get) Token: 0x060000B5 RID: 181 RVA: 0x00040BAC File Offset: 0x0003EDAC
	public int Int32_10 { get; }

	// Token: 0x17000057 RID: 87
	// (get) Token: 0x060000B6 RID: 182 RVA: 0x00040BC0 File Offset: 0x0003EDC0
	public List<string> Prop_2 { get; }

	// Token: 0x17000058 RID: 88
	// (get) Token: 0x060000B7 RID: 183 RVA: 0x00040BD4 File Offset: 0x0003EDD4
	public List<GClass1> Prop_3 { get; }

	// Token: 0x17000059 RID: 89
	// (get) Token: 0x060000B8 RID: 184 RVA: 0x00040BE8 File Offset: 0x0003EDE8
	public List<GClass4> Prop_4 { get; }

	// Token: 0x04000073 RID: 115
	[CompilerGenerated]
	private readonly byte[] byte_0;

	// Token: 0x04000074 RID: 116
	[CompilerGenerated]
	private readonly string string_0;

	// Token: 0x04000075 RID: 117
	[CompilerGenerated]
	private readonly DateTimeOffset dateTimeOffset_0;

	// Token: 0x04000076 RID: 118
	[CompilerGenerated]
	private readonly DateTimeOffset dateTimeOffset_1;

	// Token: 0x04000077 RID: 119
	[CompilerGenerated]
	private readonly DateTimeOffset dateTimeOffset_2;

	// Token: 0x04000078 RID: 120
	[CompilerGenerated]
	private readonly GClass2 gclass2_0;

	// Token: 0x04000079 RID: 121
	[CompilerGenerated]
	private readonly int int_0;

	// Token: 0x0400007A RID: 122
	[CompilerGenerated]
	private readonly int int_1;

	// Token: 0x0400007B RID: 123
	[CompilerGenerated]
	private readonly int int_2;

	// Token: 0x0400007C RID: 124
	[CompilerGenerated]
	private readonly int int_3;

	// Token: 0x0400007D RID: 125
	[CompilerGenerated]
	private readonly int int_4;

	// Token: 0x0400007E RID: 126
	[CompilerGenerated]
	private readonly int int_5;

	// Token: 0x0400007F RID: 127
	[CompilerGenerated]
	private readonly int int_6;

	// Token: 0x04000080 RID: 128
	[CompilerGenerated]
	private readonly int int_7;

	// Token: 0x04000081 RID: 129
	[CompilerGenerated]
	private readonly int int_8;

	// Token: 0x04000082 RID: 130
	[CompilerGenerated]
	private readonly int int_9;

	// Token: 0x04000083 RID: 131
	[CompilerGenerated]
	private readonly List<DateTimeOffset> list_0;

	// Token: 0x04000084 RID: 132
	[CompilerGenerated]
	private readonly List<GClass11> list_1;

	// Token: 0x04000085 RID: 133
	[CompilerGenerated]
	private readonly int int_10;

	// Token: 0x04000086 RID: 134
	[CompilerGenerated]
	private readonly List<string> list_2;

	// Token: 0x04000087 RID: 135
	[CompilerGenerated]
	private readonly List<GClass1> list_3;

	// Token: 0x04000088 RID: 136
	[CompilerGenerated]
	private readonly List<GClass4> list_4;
}
