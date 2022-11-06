using System;

// Token: 0x02000021 RID: 33
public static class GClass12
{
	// Token: 0x02000022 RID: 34
	public enum GEnum2
	{
		// Token: 0x040000BD RID: 189
		const_0,
		// Token: 0x040000BE RID: 190
		const_1,
		// Token: 0x040000BF RID: 191
		const_2,
		// Token: 0x040000C0 RID: 192
		const_3,
		// Token: 0x040000C1 RID: 193
		const_4,
		// Token: 0x040000C2 RID: 194
		const_5,
		// Token: 0x040000C3 RID: 195
		const_6,
		// Token: 0x040000C4 RID: 196
		const_7,
		// Token: 0x040000C5 RID: 197
		const_8,
		// Token: 0x040000C6 RID: 198
		const_9,
		// Token: 0x040000C7 RID: 199
		const_10,
		// Token: 0x040000C8 RID: 200
		const_11,
		// Token: 0x040000C9 RID: 201
		const_12,
		// Token: 0x040000CA RID: 202
		const_13,
		// Token: 0x040000CB RID: 203
		const_14,
		// Token: 0x040000CC RID: 204
		const_15
	}

	// Token: 0x02000023 RID: 35
	[Flags]
	public enum GEnum3 : ushort
	{
		// Token: 0x040000CE RID: 206
		flag_0 = 1,
		// Token: 0x040000CF RID: 207
		flag_1 = 2,
		// Token: 0x040000D0 RID: 208
		flag_2 = 4,
		// Token: 0x040000D1 RID: 209
		flag_3 = 8,
		// Token: 0x040000D2 RID: 210
		flag_4 = 16,
		// Token: 0x040000D3 RID: 211
		flag_5 = 32,
		// Token: 0x040000D4 RID: 212
		flag_6 = 128,
		// Token: 0x040000D5 RID: 213
		flag_7 = 256,
		// Token: 0x040000D6 RID: 214
		flag_8 = 512,
		// Token: 0x040000D7 RID: 215
		flag_9 = 1024,
		// Token: 0x040000D8 RID: 216
		flag_10 = 2048,
		// Token: 0x040000D9 RID: 217
		flag_11 = 4096,
		// Token: 0x040000DA RID: 218
		flag_12 = 8192,
		// Token: 0x040000DB RID: 219
		flag_13 = 16384,
		// Token: 0x040000DC RID: 220
		flag_14 = 32768
	}

	// Token: 0x02000024 RID: 36
	[Flags]
	public enum GEnum4 : ushort
	{
		// Token: 0x040000DE RID: 222
		flag_0 = 0,
		// Token: 0x040000DF RID: 223
		flag_1 = 332,
		// Token: 0x040000E0 RID: 224
		flag_2 = 333,
		// Token: 0x040000E1 RID: 225
		flag_3 = 354,
		// Token: 0x040000E2 RID: 226
		flag_4 = 358,
		// Token: 0x040000E3 RID: 227
		flag_5 = 360,
		// Token: 0x040000E4 RID: 228
		flag_6 = 361,
		// Token: 0x040000E5 RID: 229
		flag_7 = 387,
		// Token: 0x040000E6 RID: 230
		flag_8 = 388,
		// Token: 0x040000E7 RID: 231
		flag_9 = 418,
		// Token: 0x040000E8 RID: 232
		flag_10 = 419,
		// Token: 0x040000E9 RID: 233
		flag_11 = 420,
		// Token: 0x040000EA RID: 234
		flag_12 = 422,
		// Token: 0x040000EB RID: 235
		flag_13 = 424,
		// Token: 0x040000EC RID: 236
		flag_14 = 448,
		// Token: 0x040000ED RID: 237
		flag_15 = 450,
		// Token: 0x040000EE RID: 238
		flag_16 = 467,
		// Token: 0x040000EF RID: 239
		flag_17 = 496,
		// Token: 0x040000F0 RID: 240
		flag_18 = 497,
		// Token: 0x040000F1 RID: 241
		flag_19 = 512,
		// Token: 0x040000F2 RID: 242
		flag_20 = 614,
		// Token: 0x040000F3 RID: 243
		flag_21 = 616,
		// Token: 0x040000F4 RID: 244
		flag_22 = 644,
		// Token: 0x040000F5 RID: 245
		flag_23 = 870,
		// Token: 0x040000F6 RID: 246
		flag_24 = 1126,
		// Token: 0x040000F7 RID: 247
		flag_25 = 644,
		// Token: 0x040000F8 RID: 248
		flag_26 = 1312,
		// Token: 0x040000F9 RID: 249
		flag_27 = 3311,
		// Token: 0x040000FA RID: 250
		flag_28 = 3772,
		// Token: 0x040000FB RID: 251
		flag_29 = 34404,
		// Token: 0x040000FC RID: 252
		flag_30 = 36929,
		// Token: 0x040000FD RID: 253
		flag_31 = 49390
	}

	// Token: 0x02000025 RID: 37
	[Flags]
	public enum GEnum5 : ushort
	{
		// Token: 0x040000FF RID: 255
		flag_0 = 64,
		// Token: 0x04000100 RID: 256
		flag_1 = 128,
		// Token: 0x04000101 RID: 257
		flag_2 = 256,
		// Token: 0x04000102 RID: 258
		flag_3 = 512,
		// Token: 0x04000103 RID: 259
		flag_4 = 1024,
		// Token: 0x04000104 RID: 260
		flag_5 = 1025,
		// Token: 0x04000105 RID: 261
		flag_6 = 8192,
		// Token: 0x04000106 RID: 262
		flag_7 = 32768
	}

	// Token: 0x02000026 RID: 38
	[Flags]
	public enum GEnum6 : ushort
	{
		// Token: 0x04000108 RID: 264
		flag_0 = 267,
		// Token: 0x04000109 RID: 265
		flag_1 = 523,
		// Token: 0x0400010A RID: 266
		flag_2 = 263
	}

	// Token: 0x02000027 RID: 39
	[Flags]
	public enum GEnum7 : ushort
	{
		// Token: 0x0400010C RID: 268
		flag_0 = 1,
		// Token: 0x0400010D RID: 269
		flag_1 = 2,
		// Token: 0x0400010E RID: 270
		flag_2 = 3
	}

	// Token: 0x02000028 RID: 40
	public enum GEnum8 : uint
	{
		// Token: 0x04000110 RID: 272
		const_0 = 1U,
		// Token: 0x04000111 RID: 273
		const_1,
		// Token: 0x04000112 RID: 274
		const_2,
		// Token: 0x04000113 RID: 275
		const_3,
		// Token: 0x04000114 RID: 276
		const_4,
		// Token: 0x04000115 RID: 277
		const_5,
		// Token: 0x04000116 RID: 278
		const_6,
		// Token: 0x04000117 RID: 279
		const_7,
		// Token: 0x04000118 RID: 280
		const_8,
		// Token: 0x04000119 RID: 281
		const_9,
		// Token: 0x0400011A RID: 282
		const_10,
		// Token: 0x0400011B RID: 283
		const_11 = 14U,
		// Token: 0x0400011C RID: 284
		const_12 = 16U,
		// Token: 0x0400011D RID: 285
		const_13,
		// Token: 0x0400011E RID: 286
		const_14 = 19U,
		// Token: 0x0400011F RID: 287
		const_15,
		// Token: 0x04000120 RID: 288
		const_16,
		// Token: 0x04000121 RID: 289
		const_17,
		// Token: 0x04000122 RID: 290
		const_18,
		// Token: 0x04000123 RID: 291
		const_19
	}

	// Token: 0x02000029 RID: 41
	[Flags]
	public enum SectionFlags : uint
	{
		// Token: 0x04000125 RID: 293
		IMAGE_SCN_TYPE_NO_PAD = 8U,
		// Token: 0x04000126 RID: 294
		IMAGE_SCN_CNT_CODE = 32U,
		// Token: 0x04000127 RID: 295
		IMAGE_SCN_CNT_INITIALIZED_DATA = 64U,
		// Token: 0x04000128 RID: 296
		IMAGE_SCN_CNT_UNINITIALIZED_DATA = 128U,
		// Token: 0x04000129 RID: 297
		IMAGE_SCN_LNK_OTHER = 256U,
		// Token: 0x0400012A RID: 298
		IMAGE_SCN_LNK_INFO = 512U,
		// Token: 0x0400012B RID: 299
		IMAGE_SCN_LNK_REMOVE = 2048U,
		// Token: 0x0400012C RID: 300
		IMAGE_SCN_LNK_COMDAT = 4096U,
		// Token: 0x0400012D RID: 301
		IMAGE_SCN_NO_DEFER_SPEC_EXC = 16384U,
		// Token: 0x0400012E RID: 302
		IMAGE_SCN_GPREL = 32768U,
		// Token: 0x0400012F RID: 303
		IMAGE_SCN_MEM_FARDATA = 32768U,
		// Token: 0x04000130 RID: 304
		IMAGE_SCN_MEM_PURGEABLE = 131072U,
		// Token: 0x04000131 RID: 305
		IMAGE_SCN_MEM_16BIT = 131072U,
		// Token: 0x04000132 RID: 306
		IMAGE_SCN_MEM_LOCKED = 262144U,
		// Token: 0x04000133 RID: 307
		IMAGE_SCN_MEM_PRELOAD = 524288U,
		// Token: 0x04000134 RID: 308
		IMAGE_SCN_ALIGN_1BYTES = 1048576U,
		// Token: 0x04000135 RID: 309
		IMAGE_SCN_ALIGN_2BYTES = 2097152U,
		// Token: 0x04000136 RID: 310
		IMAGE_SCN_ALIGN_4BYTES = 3145728U,
		// Token: 0x04000137 RID: 311
		IMAGE_SCN_ALIGN_8BYTES = 4194304U,
		// Token: 0x04000138 RID: 312
		IMAGE_SCN_ALIGN_16BYTES = 5242880U,
		// Token: 0x04000139 RID: 313
		IMAGE_SCN_ALIGN_32BYTES = 6291456U,
		// Token: 0x0400013A RID: 314
		IMAGE_SCN_ALIGN_64BYTES = 7340032U,
		// Token: 0x0400013B RID: 315
		IMAGE_SCN_ALIGN_128BYTES = 8388608U,
		// Token: 0x0400013C RID: 316
		IMAGE_SCN_ALIGN_256BYTES = 9437184U,
		// Token: 0x0400013D RID: 317
		IMAGE_SCN_ALIGN_512BYTES = 10485760U,
		// Token: 0x0400013E RID: 318
		IMAGE_SCN_ALIGN_1024BYTES = 11534336U,
		// Token: 0x0400013F RID: 319
		IMAGE_SCN_ALIGN_2048BYTES = 12582912U,
		// Token: 0x04000140 RID: 320
		IMAGE_SCN_ALIGN_4096BYTES = 13631488U,
		// Token: 0x04000141 RID: 321
		IMAGE_SCN_ALIGN_8192BYTES = 14680064U,
		// Token: 0x04000142 RID: 322
		IMAGE_SCN_ALIGN_MASK = 15728640U,
		// Token: 0x04000143 RID: 323
		IMAGE_SCN_LNK_NRELOC_OVFL = 16777216U,
		// Token: 0x04000144 RID: 324
		IMAGE_SCN_MEM_DISCARDABLE = 33554432U,
		// Token: 0x04000145 RID: 325
		IMAGE_SCN_MEM_NOT_CACHED = 67108864U,
		// Token: 0x04000146 RID: 326
		IMAGE_SCN_MEM_NOT_PAGED = 134217728U,
		// Token: 0x04000147 RID: 327
		IMAGE_SCN_MEM_SHARED = 268435456U,
		// Token: 0x04000148 RID: 328
		IMAGE_SCN_MEM_EXECUTE = 536870912U,
		// Token: 0x04000149 RID: 329
		IMAGE_SCN_MEM_READ = 1073741824U,
		// Token: 0x0400014A RID: 330
		IMAGE_SCN_MEM_WRITE = 2147483648U
	}

	// Token: 0x0200002A RID: 42
	public enum GEnum9 : byte
	{
		// Token: 0x0400014C RID: 332
		const_0,
		// Token: 0x0400014D RID: 333
		const_1,
		// Token: 0x0400014E RID: 334
		const_2,
		// Token: 0x0400014F RID: 335
		const_3,
		// Token: 0x04000150 RID: 336
		const_4,
		// Token: 0x04000151 RID: 337
		const_5,
		// Token: 0x04000152 RID: 338
		const_6 = 8,
		// Token: 0x04000153 RID: 339
		const_7,
		// Token: 0x04000154 RID: 340
		const_8
	}

	// Token: 0x0200002B RID: 43
	[Flags]
	public enum GEnum10 : ushort
	{
		// Token: 0x04000156 RID: 342
		flag_0 = 1,
		// Token: 0x04000157 RID: 343
		flag_1 = 2,
		// Token: 0x04000158 RID: 344
		flag_2 = 3,
		// Token: 0x04000159 RID: 345
		flag_3 = 9
	}

	// Token: 0x0200002C RID: 44
	[Flags]
	public enum GEnum11 : uint
	{
		// Token: 0x0400015B RID: 347
		flag_0 = 0U,
		// Token: 0x0400015C RID: 348
		flag_1 = 1U,
		// Token: 0x0400015D RID: 349
		flag_2 = 2U,
		// Token: 0x0400015E RID: 350
		flag_3 = 3U,
		// Token: 0x0400015F RID: 351
		flag_4 = 4U,
		// Token: 0x04000160 RID: 352
		flag_5 = 5U,
		// Token: 0x04000161 RID: 353
		flag_6 = 6U,
		// Token: 0x04000162 RID: 354
		flag_7 = 9U
	}
}
