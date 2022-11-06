using System;
using System.Runtime.CompilerServices;

// Token: 0x02000030 RID: 48
public class GClass15
{
	// Token: 0x0600010D RID: 269 RVA: 0x00042094 File Offset: 0x00040294
	public GClass15(string string_2, string string_3, ushort ushort_1, ulong ulong_0 = 0UL)
	{
		this.String_0 = string_2;
		this.String_1 = string_3;
		this.UInt16_0 = ushort_1;
		this.IntPtr_0 = (IntPtr)((long)ulong_0);
	}

	// Token: 0x17000090 RID: 144
	// (get) Token: 0x0600010E RID: 270 RVA: 0x000420CC File Offset: 0x000402CC
	// (set) Token: 0x0600010F RID: 271 RVA: 0x000420E0 File Offset: 0x000402E0
	public string String_0 { get; set; }

	// Token: 0x17000091 RID: 145
	// (get) Token: 0x06000110 RID: 272 RVA: 0x000420F4 File Offset: 0x000402F4
	// (set) Token: 0x06000111 RID: 273 RVA: 0x00042108 File Offset: 0x00040308
	public IntPtr IntPtr_0 { get; set; }

	// Token: 0x17000092 RID: 146
	// (get) Token: 0x06000112 RID: 274 RVA: 0x0004211C File Offset: 0x0004031C
	// (set) Token: 0x06000113 RID: 275 RVA: 0x00042130 File Offset: 0x00040330
	public string String_1 { get; set; }

	// Token: 0x17000093 RID: 147
	// (get) Token: 0x06000114 RID: 276 RVA: 0x00042144 File Offset: 0x00040344
	// (set) Token: 0x06000115 RID: 277 RVA: 0x00042158 File Offset: 0x00040358
	public ushort UInt16_0 { get; set; }

	// Token: 0x04000167 RID: 359
	[CompilerGenerated]
	private string string_0;

	// Token: 0x04000168 RID: 360
	[CompilerGenerated]
	private IntPtr intptr_0;

	// Token: 0x04000169 RID: 361
	[CompilerGenerated]
	private string string_1;

	// Token: 0x0400016A RID: 362
	[CompilerGenerated]
	private ushort ushort_0;
}
