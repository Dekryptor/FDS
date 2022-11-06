using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;

// Token: 0x02000039 RID: 57
public class GClass17
{
	// Token: 0x0600011D RID: 285 RVA: 0x00043FF8 File Offset: 0x000421F8
	public GClass17(string string_4, GEnum15 genum15_0 = GEnum15.const_0)
	{
		this.String_3 = string_4;
		FileStream fileStream = null;
		BinaryReader binaryReader = null;
		try
		{
			if (string_4.Length <= GClass18.int_0 && !string_4.Contains(":"))
			{
				try
				{
					fileStream = new FileStream(string_4, FileMode.Open, FileAccess.Read, FileShare.Read);
					goto IL_5F;
				}
				catch
				{
					fileStream = new FileStream(string_4, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					goto IL_5F;
				}
			}
			try
			{
				fileStream = GClass39.smethod_2(string_4, FileMode.Open, FileAccess.Read, FileShare.Read);
			}
			catch
			{
				fileStream = GClass39.smethod_2(string_4, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
			}
			IL_5F:
			binaryReader = new BinaryReader(fileStream);
			if (fileStream.Length > GClass17.long_0)
			{
				this.method_1(binaryReader, genum15_0);
			}
			else
			{
				byte[] array = new byte[fileStream.Length];
				binaryReader.Read(array, 0, array.Length);
				this.method_0(array, genum15_0);
			}
		}
		finally
		{
			if (binaryReader != null)
			{
				binaryReader.Close();
			}
			if (fileStream != null)
			{
				fileStream.Close();
			}
		}
	}

	// Token: 0x0600011E RID: 286 RVA: 0x000440E0 File Offset: 0x000422E0
	public GClass17(FileStream fileStream_0, GEnum15 genum15_0 = GEnum15.const_0)
	{
		this.String_3 = fileStream_0.Name;
		fileStream_0.Seek(0L, SeekOrigin.Begin);
		BinaryReader binaryReader = new BinaryReader(fileStream_0);
		this.method_1(binaryReader, genum15_0);
	}

	// Token: 0x0600011F RID: 287 RVA: 0x00044120 File Offset: 0x00042320
	public GClass17(IntPtr intptr_0, IntPtr intptr_1, GEnum15 genum15_0 = GEnum15.const_0)
	{
		this.String_3 = "memory_0x" + intptr_1.ToString("X8");
		this.method_2(intptr_0, intptr_1, genum15_0);
	}

	// Token: 0x06000120 RID: 288 RVA: 0x00044158 File Offset: 0x00042358
	private void method_0(byte[] byte_0, GEnum15 genum15_0)
	{
		try
		{
			this.GClass23_0 = new GClass23(byte_0);
			if (this.GClass23_0.UInt16_0 != 23117)
			{
				this.GClass23_0 = null;
				throw new GException3("Invalid MZ file!");
			}
			this.Boolean_9 = BitConverter.ToUInt16(byte_0, (int)(this.GClass23_0.UInt32_0 + 4U)) == 34404;
			uint num = (this.Boolean_9 ? 264U : 248U);
			this.GClass28_0 = new GClass28(byte_0, this.GClass23_0.UInt32_0, this.Boolean_9);
			short num2 = (short)this.GClass28_0.UInt32_0;
			if (num2 != 17744)
			{
				if (num2 != 17742)
				{
					if (num2 != 17740)
					{
						if (num2 != 22604)
						{
							this.GClass23_0 = null;
							this.GClass28_0 = null;
							throw new GException4(string.Format("Invalid executable file -> Signature: {0}", num2.ToString("X")));
						}
					}
				}
			}
			this.GClass31_0 = this.method_16(byte_0, this.GClass28_0.GClass25_0.UInt16_1, (int)(this.GClass23_0.UInt32_0 + num), this.GClass28_0.GClass29_0.UInt32_7, (genum15_0 & GEnum15.const_12) == GEnum15.const_12 || genum15_0 == GEnum15.const_13);
			if ((genum15_0 & GEnum15.const_1) != GEnum15.const_1)
			{
				if (genum15_0 != GEnum15.const_13)
				{
					this.GClass30_0 = null;
					this.String_0 = null;
					goto IL_21D;
				}
			}
			try
			{
				this.GClass30_0 = this.method_19(byte_0, this.GClass31_0, this.GClass28_0.GClass29_0.UInt32_7, this.GClass28_0.GClass29_0.GClass20_0[4], (genum15_0 & GEnum15.const_12) == GEnum15.const_12 || genum15_0 == GEnum15.const_13);
				if ((genum15_0 & GEnum15.const_12) != GEnum15.const_12)
				{
					if (genum15_0 != GEnum15.const_13)
					{
						goto IL_203;
					}
				}
				try
				{
					string text = "???";
					if (Class6.smethod_3(byte_0, out text, 0L, (long)((ulong)this.GClass30_0.UInt32_1), 4096))
					{
						this.String_0 = text;
					}
					else
					{
						this.String_0 = null;
					}
					goto IL_20A;
				}
				catch
				{
					this.String_0 = null;
					goto IL_20A;
				}
				IL_203:
				this.String_0 = null;
				IL_20A:;
			}
			catch (Exception)
			{
				this.GClass30_0 = null;
				this.String_0 = null;
			}
			IL_21D:
			if ((genum15_0 & GEnum15.const_2) != GEnum15.const_2)
			{
				if (genum15_0 != GEnum15.const_13)
				{
					this.GClass24_0 = null;
					this.GClass14_0 = null;
					this.Boolean_1 = false;
					goto IL_2FA;
				}
			}
			if (this.GClass28_0.GClass29_0.GClass20_0[0].UInt32_0 != 0U && this.GClass28_0.GClass29_0.GClass20_0[0].UInt32_1 > 0U)
			{
				try
				{
					this.GClass24_0 = new GClass24(byte_0, (int)GClass18.smethod_10(this.GClass28_0.GClass29_0.GClass20_0[0].UInt32_0, this.GClass31_0));
					this.GClass14_0 = this.method_13(byte_0, this.GClass24_0, this.GClass31_0);
					this.Boolean_1 = true;
					goto IL_2FA;
				}
				catch
				{
					this.GClass24_0 = null;
					this.GClass14_0 = null;
					this.Boolean_1 = false;
					goto IL_2FA;
				}
			}
			this.GClass24_0 = null;
			this.GClass14_0 = null;
			this.Boolean_1 = false;
			IL_2FA:
			if ((genum15_0 & GEnum15.const_3) != GEnum15.const_3)
			{
				if (genum15_0 != GEnum15.const_13)
				{
					this.Boolean_2 = false;
					this.GClass27_0 = null;
					goto IL_3C9;
				}
			}
			if (this.GClass28_0.GClass29_0.GClass20_0[1].UInt32_0 != 0U && this.GClass28_0.GClass29_0.GClass20_0[1].UInt32_1 > 0U)
			{
				try
				{
					this.GClass27_0 = this.method_10(byte_0, GClass18.smethod_10(this.GClass28_0.GClass29_0.GClass20_0[1].UInt32_0, this.GClass31_0), this.GClass31_0);
					this.GClass15_0 = this.method_7(byte_0, this.GClass27_0, this.GClass31_0);
					this.Boolean_2 = true;
					goto IL_3C9;
				}
				catch
				{
					this.Boolean_2 = false;
					this.GClass27_0 = null;
					goto IL_3C9;
				}
			}
			this.Boolean_2 = false;
			this.GClass27_0 = null;
			IL_3C9:
			if ((genum15_0 & GEnum15.const_5) != GEnum15.const_5)
			{
				if (genum15_0 != GEnum15.const_13)
				{
					this.GClass21_0 = null;
					this.Boolean_3 = false;
					this.Boolean_4 = false;
					this.GClass35_0 = null;
					goto IL_502;
				}
			}
			if (this.GClass28_0.GClass29_0.GClass20_0[6].UInt32_0 != 0U && this.GClass28_0.GClass29_0.GClass20_0[6].UInt32_1 > 0U)
			{
				try
				{
					this.GClass21_0 = this.method_21(byte_0, GClass18.smethod_10(this.GClass28_0.GClass29_0.GClass20_0[6].UInt32_0, this.GClass31_0));
					this.Boolean_3 = true;
					try
					{
						if (2U == this.GClass21_0.UInt32_2)
						{
							this.GClass35_0 = new GClass35(byte_0, (int)this.GClass21_0.UInt32_5, (int)this.GClass21_0.UInt32_3);
							this.Boolean_4 = true;
						}
						else
						{
							this.GClass35_0 = null;
							this.Boolean_4 = false;
						}
					}
					catch
					{
						this.GClass35_0 = null;
						this.Boolean_4 = false;
					}
					goto IL_502;
				}
				catch
				{
					this.GClass21_0 = null;
					this.Boolean_3 = false;
					this.Boolean_4 = false;
					this.GClass35_0 = null;
					goto IL_502;
				}
			}
			this.GClass21_0 = null;
			this.Boolean_3 = false;
			this.Boolean_4 = false;
			this.GClass35_0 = null;
			IL_502:
			if ((genum15_0 & GEnum15.const_11) != GEnum15.const_11)
			{
				if (genum15_0 != GEnum15.const_13)
				{
					this.GClass36_0 = null;
					this.GClass37_0 = null;
					this.Boolean_5 = false;
					goto IL_5C1;
				}
			}
			if (this.GClass28_0.GClass29_0.GClass20_0[4].UInt32_0 != 0U && this.GClass28_0.GClass29_0.GClass20_0[4].UInt32_1 > 0U)
			{
				try
				{
					this.GClass36_0 = this.method_5(byte_0, this.GClass28_0.GClass29_0.GClass20_0[4].UInt32_0);
					this.Boolean_5 = true;
					goto IL_5C1;
				}
				catch
				{
					this.GClass36_0 = null;
					this.GClass37_0 = null;
					this.Boolean_5 = false;
					goto IL_5C1;
				}
			}
			this.GClass36_0 = null;
			this.GClass37_0 = null;
			this.Boolean_5 = false;
			IL_5C1:;
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x06000121 RID: 289 RVA: 0x000447F0 File Offset: 0x000429F0
	private void method_1(BinaryReader binaryReader_0, GEnum15 genum15_0)
	{
		/*
An exception occurred when decompiling this method (06000121)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void GClass17::method_1(System.IO.BinaryReader,GEnum15)

 ---> System.Exception: Inconsistent stack size at IL_5DC
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 460
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 278
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1595
*/;
	}

	// Token: 0x06000122 RID: 290 RVA: 0x00044F18 File Offset: 0x00043118
	private void method_2(IntPtr intptr_0, IntPtr intptr_1, GEnum15 genum15_0)
	{
		uint num = 0U;
		try
		{
			if (!GClass16.smethod_1(intptr_0, intptr_1))
			{
				throw new GException3("Invalid MZ file!");
			}
			byte[] array = new byte[GClass23.int_0];
			if (!GClass16.ReadProcessMemory(intptr_0, intptr_1, array, (uint)array.Length, ref num) || (ulong)num != (ulong)((long)array.Length))
			{
				this.GClass23_0 = null;
				throw new GException3("Invalid MZ file!");
			}
			this.GClass23_0 = new GClass23(array);
			if (this.GClass23_0.UInt16_0 != 23117)
			{
				this.GClass23_0 = null;
				throw new GException3("Invalid MZ file!");
			}
			IntPtr intPtr = (IntPtr)(intptr_1.ToInt64() + (long)((ulong)this.GClass23_0.UInt32_0));
			if (!GClass16.smethod_1(intptr_0, intPtr))
			{
				throw new GException4("Invalid MZ file!");
			}
			array = new byte[GClass28.uint_1];
			if (GClass16.ReadProcessMemory(intptr_0, intPtr, array, (uint)array.Length, ref num))
			{
				if ((ulong)num == (ulong)((long)array.Length))
				{
					this.Boolean_9 = BitConverter.ToUInt16(array, 4) == 34404;
					uint num2 = (this.Boolean_9 ? 264U : 248U);
					this.GClass28_0 = new GClass28(array, this.Boolean_9);
					short num3 = (short)this.GClass28_0.UInt32_0;
					if (num3 != 17744)
					{
						if (num3 != 17742)
						{
							if (num3 != 17740)
							{
								if (num3 != 22604)
								{
									throw new GException3(string.Format("Invalid executable file -> signature: {0}", num3.ToString("X")));
								}
							}
						}
					}
					IntPtr intPtr2 = (IntPtr)(intPtr.ToInt64() + (long)((ulong)num2));
					this.GClass31_0 = this.method_18(intptr_0, this.GClass28_0.GClass25_0.UInt16_1, intPtr2, this.GClass28_0.GClass29_0.UInt32_6, (genum15_0 & GEnum15.const_12) == GEnum15.const_12 || genum15_0 == GEnum15.const_13);
					this.GClass30_0 = null;
					this.String_0 = null;
					if ((genum15_0 & GEnum15.const_2) != GEnum15.const_2)
					{
						if (genum15_0 != GEnum15.const_13)
						{
							this.GClass24_0 = null;
							this.GClass14_0 = null;
							this.Boolean_1 = false;
							goto IL_2DC;
						}
					}
					if (this.GClass28_0.GClass29_0.GClass20_0[0].UInt32_0 != 0U && this.GClass28_0.GClass29_0.GClass20_0[0].UInt32_1 > 0U)
					{
						try
						{
							IntPtr intPtr3 = (IntPtr)((long)(this.GClass28_0.GClass29_0.UInt64_1 + (ulong)this.GClass28_0.GClass29_0.GClass20_0[0].UInt32_0));
							if (!GClass16.smethod_1(intptr_0, intPtr3))
							{
								throw new IOException();
							}
							array = new byte[GClass24.int_0];
							if (!GClass16.ReadProcessMemory(intptr_0, intPtr3, array, (uint)array.Length, ref num) || (ulong)num != (ulong)((long)array.Length))
							{
								this.GClass23_0 = null;
								throw new GException4("Invalid MZPE file!");
							}
							this.GClass24_0 = new GClass24(array, 0);
							this.GClass14_0 = this.method_15(intptr_0, intptr_1, this.GClass24_0);
							this.Boolean_1 = true;
							goto IL_2DC;
						}
						catch (Exception)
						{
							this.GClass24_0 = null;
							this.GClass14_0 = null;
							this.Boolean_1 = false;
							goto IL_2DC;
						}
					}
					this.GClass24_0 = null;
					this.GClass14_0 = null;
					this.Boolean_1 = false;
					IL_2DC:
					if ((genum15_0 & GEnum15.const_3) != GEnum15.const_3)
					{
						if (genum15_0 != GEnum15.const_13)
						{
							this.Boolean_2 = false;
							this.GClass27_0 = null;
							goto IL_3D2;
						}
					}
					if (this.GClass28_0.GClass29_0.GClass20_0[1].UInt32_0 != 0U && this.GClass28_0.GClass29_0.GClass20_0[1].UInt32_1 > 0U)
					{
						try
						{
							this.GClass27_0 = this.method_12(intptr_0, intptr_1, (IntPtr)((long)((ulong)this.GClass28_0.GClass29_0.GClass20_0[1].UInt32_0)));
							this.GClass15_0 = this.method_9(intptr_0, intptr_1, this.GClass27_0, true);
							this.Boolean_2 = true;
							goto IL_3D2;
						}
						catch (Exception)
						{
							this.Boolean_2 = false;
							this.GClass27_0 = null;
							goto IL_3D2;
						}
					}
					this.Boolean_2 = false;
					this.GClass27_0 = null;
					IL_3D2:
					this.GClass36_0 = null;
					this.GClass37_0 = null;
					this.Boolean_5 = false;
					return;
				}
			}
			this.GClass23_0 = null;
			throw new GException4("Invalid MZPE file!");
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x17000094 RID: 148
	// (get) Token: 0x06000123 RID: 291 RVA: 0x00045360 File Offset: 0x00043560
	public bool Boolean_0
	{
		get
		{
			return this.Boolean_1 && this.Boolean_2 && this.Boolean_5 && this.GClass23_0.UInt16_0 == 23117;
		}
	}

	// Token: 0x17000095 RID: 149
	// (get) Token: 0x06000124 RID: 292 RVA: 0x0004539C File Offset: 0x0004359C
	// (set) Token: 0x06000125 RID: 293 RVA: 0x000453B0 File Offset: 0x000435B0
	public bool Boolean_1 { get; private set; }

	// Token: 0x17000096 RID: 150
	// (get) Token: 0x06000126 RID: 294 RVA: 0x000453C4 File Offset: 0x000435C4
	// (set) Token: 0x06000127 RID: 295 RVA: 0x000453D8 File Offset: 0x000435D8
	public bool Boolean_2 { get; private set; }

	// Token: 0x17000097 RID: 151
	// (get) Token: 0x06000128 RID: 296 RVA: 0x000453EC File Offset: 0x000435EC
	// (set) Token: 0x06000129 RID: 297 RVA: 0x00045400 File Offset: 0x00043600
	public bool Boolean_3 { get; private set; }

	// Token: 0x17000098 RID: 152
	// (get) Token: 0x0600012A RID: 298 RVA: 0x00045414 File Offset: 0x00043614
	// (set) Token: 0x0600012B RID: 299 RVA: 0x00045428 File Offset: 0x00043628
	public bool Boolean_4 { get; private set; }

	// Token: 0x17000099 RID: 153
	// (get) Token: 0x0600012C RID: 300 RVA: 0x0004543C File Offset: 0x0004363C
	// (set) Token: 0x0600012D RID: 301 RVA: 0x00045450 File Offset: 0x00043650
	public bool Boolean_5 { get; private set; }

	// Token: 0x1700009A RID: 154
	// (get) Token: 0x0600012E RID: 302 RVA: 0x00045464 File Offset: 0x00043664
	// (set) Token: 0x0600012F RID: 303 RVA: 0x0004548C File Offset: 0x0004368C
	public bool Boolean_6
	{
		get
		{
			return (this.GClass28_0.GClass25_0.UInt16_3 & 8192) > 0;
		}
		private set
		{
		}
	}

	// Token: 0x1700009B RID: 155
	// (get) Token: 0x06000130 RID: 304 RVA: 0x0004549C File Offset: 0x0004369C
	// (set) Token: 0x06000131 RID: 305 RVA: 0x0004548C File Offset: 0x0004368C
	public bool Boolean_7
	{
		get
		{
			return (this.GClass28_0.GClass25_0.UInt16_3 & 2) > 0;
		}
		private set
		{
		}
	}

	// Token: 0x1700009C RID: 156
	// (get) Token: 0x06000132 RID: 306 RVA: 0x000454C0 File Offset: 0x000436C0
	// (set) Token: 0x06000133 RID: 307 RVA: 0x0004548C File Offset: 0x0004368C
	public bool Boolean_8
	{
		get
		{
			return this.GetX509Certificate2_2() != null;
		}
		private set
		{
		}
	}

	// Token: 0x06000134 RID: 308 RVA: 0x000454D8 File Offset: 0x000436D8
	public bool method_3(bool bool_6)
	{
		return this.Boolean_8 && GClass18.smethod_25(this.GetX509Certificate2_2(), bool_6);
	}

	// Token: 0x1700009D RID: 157
	// (get) Token: 0x06000135 RID: 309 RVA: 0x000454FC File Offset: 0x000436FC
	// (set) Token: 0x06000136 RID: 310 RVA: 0x00045510 File Offset: 0x00043710
	public bool Boolean_9 { get; private set; }

	// Token: 0x1700009E RID: 158
	// (get) Token: 0x06000137 RID: 311 RVA: 0x00045524 File Offset: 0x00043724
	// (set) Token: 0x06000138 RID: 312 RVA: 0x0004548C File Offset: 0x0004368C
	public bool Boolean_10
	{
		get
		{
			return !this.Boolean_9;
		}
		private set
		{
		}
	}

	// Token: 0x1700009F RID: 159
	// (get) Token: 0x06000139 RID: 313 RVA: 0x0004553C File Offset: 0x0004373C
	// (set) Token: 0x0600013A RID: 314 RVA: 0x00045550 File Offset: 0x00043750
	public GClass23 GClass23_0 { get; private set; }

	// Token: 0x170000A0 RID: 160
	// (get) Token: 0x0600013B RID: 315 RVA: 0x00045564 File Offset: 0x00043764
	// (set) Token: 0x0600013C RID: 316 RVA: 0x00045578 File Offset: 0x00043778
	public GClass28 GClass28_0 { get; private set; }

	// Token: 0x170000A1 RID: 161
	// (get) Token: 0x0600013D RID: 317 RVA: 0x0004558C File Offset: 0x0004378C
	// (set) Token: 0x0600013E RID: 318 RVA: 0x000455A0 File Offset: 0x000437A0
	public GClass31[] GClass31_0 { get; private set; }

	// Token: 0x170000A2 RID: 162
	// (get) Token: 0x0600013F RID: 319 RVA: 0x000455B4 File Offset: 0x000437B4
	// (set) Token: 0x06000140 RID: 320 RVA: 0x000455C8 File Offset: 0x000437C8
	public GClass30 GClass30_0 { get; private set; }

	// Token: 0x170000A3 RID: 163
	// (get) Token: 0x06000141 RID: 321 RVA: 0x000455DC File Offset: 0x000437DC
	// (set) Token: 0x06000142 RID: 322 RVA: 0x000455F0 File Offset: 0x000437F0
	public string String_0 { get; private set; }

	// Token: 0x170000A4 RID: 164
	// (get) Token: 0x06000143 RID: 323 RVA: 0x00045604 File Offset: 0x00043804
	// (set) Token: 0x06000144 RID: 324 RVA: 0x00045618 File Offset: 0x00043818
	public GClass24 GClass24_0 { get; private set; }

	// Token: 0x170000A5 RID: 165
	// (get) Token: 0x06000145 RID: 325 RVA: 0x0004562C File Offset: 0x0004382C
	// (set) Token: 0x06000146 RID: 326 RVA: 0x00045640 File Offset: 0x00043840
	public GClass27[] GClass27_0 { get; private set; }

	// Token: 0x170000A6 RID: 166
	// (get) Token: 0x06000147 RID: 327 RVA: 0x00045654 File Offset: 0x00043854
	// (set) Token: 0x06000148 RID: 328 RVA: 0x00045668 File Offset: 0x00043868
	public GClass14[] GClass14_0 { get; private set; }

	// Token: 0x170000A7 RID: 167
	// (get) Token: 0x06000149 RID: 329 RVA: 0x0004567C File Offset: 0x0004387C
	// (set) Token: 0x0600014A RID: 330 RVA: 0x00045690 File Offset: 0x00043890
	public GClass15[] GClass15_0 { get; private set; }

	// Token: 0x170000A8 RID: 168
	// (get) Token: 0x0600014B RID: 331 RVA: 0x000456A4 File Offset: 0x000438A4
	// (set) Token: 0x0600014C RID: 332 RVA: 0x000456B8 File Offset: 0x000438B8
	public GClass21 GClass21_0 { get; private set; }

	// Token: 0x170000A9 RID: 169
	// (get) Token: 0x0600014D RID: 333 RVA: 0x000456CC File Offset: 0x000438CC
	// (set) Token: 0x0600014E RID: 334 RVA: 0x000456E0 File Offset: 0x000438E0
	public GClass35 GClass35_0 { get; private set; }

	// Token: 0x170000AA RID: 170
	// (get) Token: 0x0600014F RID: 335 RVA: 0x000456F4 File Offset: 0x000438F4
	// (set) Token: 0x06000150 RID: 336 RVA: 0x00045708 File Offset: 0x00043908
	public GClass36 GClass36_0 { get; private set; }

	private X509Certificate2 x509Certificate2_2;

	// Token: 0x170000AB RID: 171
	// (get) Token: 0x06000151 RID: 337 RVA: 0x0004571C File Offset: 0x0004391C
	// (set) Token: 0x06000152 RID: 338 RVA: 0x00045730 File Offset: 0x00043930
	private X509Certificate2 GetX509Certificate2_2()
	{
		return x509Certificate2_2;
	}

	// Token: 0x170000AB RID: 171
	// (get) Token: 0x06000151 RID: 337 RVA: 0x0004571C File Offset: 0x0004391C
	// (set) Token: 0x06000152 RID: 338 RVA: 0x00045730 File Offset: 0x00043930
	private void SetX509Certificate2_2(X509Certificate2 value)
	{
		x509Certificate2_2 = value;
	}

	// Token: 0x170000AC RID: 172
	// (get) Token: 0x06000153 RID: 339 RVA: 0x00045744 File Offset: 0x00043944
	// (set) Token: 0x06000154 RID: 340 RVA: 0x00045758 File Offset: 0x00043958
	public GClass37 GClass37_0 { get; private set; }

	// Token: 0x170000AD RID: 173
	// (get) Token: 0x06000155 RID: 341 RVA: 0x0004576C File Offset: 0x0004396C
	// (set) Token: 0x06000156 RID: 342 RVA: 0x0004548C File Offset: 0x0004368C
	public string String_1
	{
		get
		{
			string text;
			if ((text = this.string_0) == null)
			{
				text = (this.string_0 = this.method_23());
			}
			return text;
		}
		private set
		{
		}
	}

	// Token: 0x170000AE RID: 174
	// (get) Token: 0x06000157 RID: 343 RVA: 0x00045794 File Offset: 0x00043994
	// (set) Token: 0x06000158 RID: 344 RVA: 0x0004548C File Offset: 0x0004368C
	public string String_2
	{
		get
		{
			string text;
			if ((text = this.string_1) == null)
			{
				text = (this.string_1 = this.method_24());
			}
			return text;
		}
		private set
		{
		}
	}

	// Token: 0x170000AF RID: 175
	// (get) Token: 0x06000159 RID: 345 RVA: 0x000457BC File Offset: 0x000439BC
	// (set) Token: 0x0600015A RID: 346 RVA: 0x000457D0 File Offset: 0x000439D0
	public string String_3 { get; private set; }

	// Token: 0x0600015B RID: 347 RVA: 0x000457E4 File Offset: 0x000439E4
	public GClass13 method_4()
	{
		if (this.GetX509Certificate2_2() == null)
		{
			return null;
		}
		return new GClass13(this.GetX509Certificate2_2());
	}

	// Token: 0x0600015C RID: 348 RVA: 0x00045808 File Offset: 0x00043A08
	private GClass36 method_5(byte[] byte_0, uint uint_0)
	{
		GClass36 gclass = new GClass36(byte_0, (int)uint_0);
		if (gclass.UInt16_1 == 2)
		{
			byte[] byte_ = gclass.Byte_0;
			this.SetX509Certificate2_2(new X509Certificate2(byte_));
			try
			{
				this.GClass37_0 = new GClass37(this.GetX509Certificate2_2());
			}
			catch
			{
				this.GClass37_0 = null;
			}
		}
		return gclass;
	}

	// Token: 0x0600015D RID: 349 RVA: 0x00045868 File Offset: 0x00043A68
	private GClass36 method_6(BinaryReader binaryReader_0, uint uint_0)
	{
		GClass36 gclass = new GClass36(binaryReader_0, (int)uint_0);
		if (gclass.UInt16_1 == 2)
		{
			byte[] byte_ = gclass.Byte_0;
			this.SetX509Certificate2_2(new X509Certificate2(byte_));
			try
			{
				this.GClass37_0 = new GClass37(this.GetX509Certificate2_2());
			}
			catch
			{
				this.GClass37_0 = null;
			}
		}
		return gclass;
	}

	// Token: 0x0600015E RID: 350 RVA: 0x000458C8 File Offset: 0x00043AC8
	private GClass15[] method_7(byte[] byte_0, GClass27[] gclass27_1, GClass31[] gclass31_1)
	{
		List<GClass15> list = new List<GClass15>();
		uint num = ((!this.Boolean_9) ? 4U : 8U);
		ulong num2 = (this.Boolean_9 ? 9223372036854775808UL : 2147483648UL);
		ulong num3 = (this.Boolean_9 ? 9223372036854775807UL : 2147483647UL);
		foreach (GClass27 gclass in gclass27_1)
		{
			string text = GClass18.smethod_12((ulong)GClass18.smethod_10(gclass.UInt32_3, gclass31_1), byte_0);
			uint num4 = ((gclass.UInt32_0 != 0U) ? gclass.UInt32_0 : gclass.UInt32_4);
			if (num4 != 0U)
			{
				uint num5 = GClass18.smethod_10(num4, gclass31_1);
				if (num5 > 0U && (ulong)num5 < (ulong)((long)byte_0.Length))
				{
					uint num6 = 0U;
					while ((ulong)num6 < (ulong)((long)GClass17.int_3))
					{
						GClass32 gclass2 = new GClass32(byte_0, (int)(num5 + num6 * num), this.Boolean_9);
						if (gclass2.UInt64_0 == 0UL)
						{
							break;
						}
						if ((gclass2.UInt64_1 & num2) != num2)
						{
							int num7 = (int)GClass18.smethod_11(gclass2.UInt64_0, gclass31_1);
							if (num7 < 0 || num7 >= byte_0.Length)
							{
								break;
							}
							GClass26 gclass3 = new GClass26(byte_0, GClass18.smethod_11(gclass2.UInt64_0, gclass31_1));
							list.Add(new GClass15(gclass3.String_0, text, gclass3.UInt16_0, 0UL));
						}
						else
						{
							list.Add(new GClass15(null, text, (ushort)(gclass2.UInt64_1 & num3), 0UL));
						}
						num6 += 1U;
					}
				}
			}
		}
		return list.ToArray();
	}

	// Token: 0x0600015F RID: 351 RVA: 0x00045A64 File Offset: 0x00043C64
	private GClass15[] method_8(BinaryReader binaryReader_0, GClass27[] gclass27_1, GClass31[] gclass31_1)
	{
		List<GClass15> list = new List<GClass15>();
		uint num = (this.Boolean_9 ? 8U : 4U);
		ulong num2 = (this.Boolean_9 ? 9223372036854775808UL : 2147483648UL);
		ulong num3 = (this.Boolean_9 ? 9223372036854775807UL : 2147483647UL);
		byte[] array = new byte[GClass17.int_0];
		byte[] array2 = new byte[GClass17.int_1 + 2];
		int num4 = 50;
		byte[] array3 = new byte[(ulong)num * 50UL];
		foreach (GClass27 gclass in gclass27_1)
		{
			uint num5 = ((gclass.UInt32_0 != 0U) ? gclass.UInt32_0 : gclass.UInt32_4);
			if (num5 != 0U)
			{
				uint num6 = GClass18.smethod_10(num5, gclass31_1);
				if ((ulong)num6 < (ulong)binaryReader_0.BaseStream.Length)
				{
					uint num7 = GClass18.smethod_10(gclass.UInt32_3, gclass31_1);
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
					while ((ulong)num8 < (ulong)((long)GClass17.int_3))
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
							GClass32 gclass2 = new GClass32(array3, (int)num9, this.Boolean_9);
							if (gclass2.UInt64_0 == 0UL || gclass2.UInt64_0 >= (ulong)binaryReader_0.BaseStream.Length)
							{
								num8 = (uint)GClass17.int_3;
								break;
							}
							if ((gclass2.UInt64_1 & num2) == num2)
							{
								list.Add(new GClass15(null, text, (ushort)(gclass2.UInt64_1 & num3), 0UL));
								flag = false;
							}
							else
							{
								int num10 = (int)GClass18.smethod_11(gclass2.UInt64_0, gclass31_1);
								if (num10 < 0 || (long)num10 >= binaryReader_0.BaseStream.Length)
								{
									num8 = (uint)GClass17.int_3;
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

	// Token: 0x06000160 RID: 352 RVA: 0x00045D20 File Offset: 0x00043F20
	private GClass15[] method_9(IntPtr intptr_0, IntPtr intptr_1, GClass27[] gclass27_1, bool bool_6 = true)
	{
		List<GClass15> list = new List<GClass15>();
		uint num = ((!this.Boolean_9) ? 4U : 8U);
		ulong num2 = ((!this.Boolean_9) ? 2147483648UL : 9223372036854775808UL);
		ulong num3 = ((!this.Boolean_9) ? 2147483647UL : 9223372036854775807UL);
		byte[] array = new byte[GClass17.int_0];
		byte[] array2 = new byte[GClass17.int_1 + 2];
		byte[] array3 = new byte[(ulong)num * 50UL];
		byte[] array4 = new byte[(ulong)num * 50UL];
		uint num4 = 0U;
		uint num5 = 0U;
		uint num6 = 0U;
		bool flag = false;
		IntPtr intPtr = IntPtr.Zero;
		IntPtr intPtr2 = IntPtr.Zero;
		ulong num7 = 0UL;
		foreach (GClass27 gclass in gclass27_1)
		{
			uint num8;
			if (bool_6)
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
					while ((ulong)num10 < (ulong)((long)GClass17.int_3))
					{
						IntPtr intPtr5 = (IntPtr)(intPtr3.ToInt64() + (long)((ulong)(num10 * num)));
						if (intPtr3 == IntPtr.Zero || !GClass16.smethod_1(intptr_0, intPtr5) || !GClass16.ReadProcessMemory(intptr_0, intPtr5, array3, (uint)array3.Length, ref num5) || num5 < num)
						{
							break;
						}
						if (!(intPtr != IntPtr.Zero))
						{
							num6 = 0U;
							intPtr2 = IntPtr.Zero;
						}
						else
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
						for (uint num11 = 0U; num11 < num5; num11 += num)
						{
							GClass32 gclass2 = new GClass32(array3, (int)num11, this.Boolean_9);
							if (gclass2.UInt64_0 == 0UL)
							{
								num10 = (uint)GClass17.int_3;
								break;
							}
							if ((gclass2.UInt64_1 & num2) == num2)
							{
								if (num11 < num6)
								{
									try
									{
										GClass32 gclass3 = new GClass32(array4, (int)num11, this.Boolean_9);
										if (gclass3.UInt64_0 != 0UL && GClass16.smethod_1(intptr_0, (IntPtr)((long)gclass3.UInt64_0)))
										{
											num7 = gclass3.UInt64_0;
										}
										else
										{
											num6 = 0U;
											num7 = 0UL;
										}
										goto IL_4AD;
									}
									catch
									{
										num6 = 0U;
										num7 = 0UL;
										goto IL_4AD;
									}
									goto IL_34B;
								}
								goto IL_34B;
								IL_4AD:
								list.Add(new GClass15(null, text, (ushort)(gclass2.UInt64_1 & num3), num7));
								goto IL_44E;
								IL_34B:
								num7 = 0UL;
								goto IL_4AD;
							}
							IntPtr intPtr6 = (IntPtr)((long)gclass2.UInt64_0);
							if (!flag)
							{
								intPtr6 = (IntPtr)(intptr_1.ToInt64() + intPtr6.ToInt64());
							}
							if (intPtr6 == IntPtr.Zero || !GClass16.smethod_1(intptr_0, intPtr6))
							{
								num10 = (uint)GClass17.int_3;
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
										GClass32 gclass3 = new GClass32(array4, (int)num11, this.Boolean_9);
										if (gclass3.UInt64_0 != 0UL && GClass16.smethod_1(intptr_0, (IntPtr)((long)gclass3.UInt64_0)))
										{
											num7 = gclass3.UInt64_0;
										}
										else
										{
											num6 = 0U;
											num7 = 0UL;
										}
										goto IL_483;
									}
									catch
									{
										num6 = 0U;
										num7 = 0UL;
										goto IL_483;
									}
									goto IL_441;
								}
								goto IL_441;
								IL_483:
								list.Add(new GClass15(gclass4.String_0, text, gclass4.UInt16_0, num7));
								goto IL_44E;
								IL_441:
								num7 = 0UL;
								goto IL_483;
							}
							num10 = (uint)GClass17.int_3;
							break;
							IL_44E:
							num10 += 1U;
						}
					}
				}
			}
		}
		return list.ToArray();
	}

	// Token: 0x06000161 RID: 353 RVA: 0x00046218 File Offset: 0x00044418
	private GClass27[] method_10(byte[] byte_0, uint uint_0, GClass31[] gclass31_1)
	{
		List<GClass27> list = new List<GClass27>();
		uint num = 0U;
		while ((ulong)num < (ulong)((long)GClass17.int_2))
		{
			GClass27 gclass = new GClass27(byte_0, (int)((ulong)uint_0 + (ulong)((long)GClass27.int_0 * (long)((ulong)num))));
			if (gclass.UInt32_0 == 0U && gclass.UInt32_2 == 0U && gclass.UInt32_3 == 0U && gclass.UInt32_4 == 0U)
			{
				break;
			}
			list.Add(gclass);
			num += 1U;
		}
		return list.ToArray();
	}

	// Token: 0x06000162 RID: 354 RVA: 0x00046280 File Offset: 0x00044480
	private GClass27[] method_11(BinaryReader binaryReader_0, uint uint_0, GClass31[] gclass31_1)
	{
		if ((ulong)uint_0 < (ulong)binaryReader_0.BaseStream.Length)
		{
			List<GClass27> list = new List<GClass27>();
			uint num = 0U;
			byte[] array = new byte[GClass27.int_0];
			binaryReader_0.BaseStream.Seek((long)((ulong)uint_0), SeekOrigin.Begin);
			while ((ulong)num < (ulong)((long)GClass17.int_2))
			{
				if (binaryReader_0.Read(array, 0, array.Length) != array.Length)
				{
					break;
				}
				GClass27 gclass = new GClass27(array, 0);
				if (gclass.UInt32_0 == 0U && gclass.UInt32_2 == 0U && gclass.UInt32_3 == 0U && gclass.UInt32_4 == 0U)
				{
					break;
				}
				list.Add(gclass);
				num += 1U;
			}
			return list.ToArray();
		}
		throw new IOException();
	}

	// Token: 0x06000163 RID: 355 RVA: 0x00046320 File Offset: 0x00044520
	private GClass27[] method_12(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2)
	{
		if (intptr_0 == IntPtr.Zero)
		{
			throw new IOException();
		}
		IntPtr intPtr = (IntPtr)(intptr_1.ToInt64() + intptr_2.ToInt64());
		if (GClass16.smethod_1(intptr_0, intPtr))
		{
			List<GClass27> list = new List<GClass27>();
			uint num = 0U;
			byte[] array = new byte[GClass27.int_0];
			uint num2 = 0U;
			while ((ulong)num < (ulong)((long)GClass17.int_2) && GClass16.ReadProcessMemory(intptr_0, intPtr, array, (uint)array.Length, ref num2))
			{
				if ((ulong)num2 != (ulong)((long)array.Length))
				{
					break;
				}
				GClass27 gclass = new GClass27(array, 0);
				if (gclass.UInt32_0 == 0U && gclass.UInt32_2 == 0U && gclass.UInt32_3 == 0U && gclass.UInt32_4 == 0U)
				{
					break;
				}
				list.Add(gclass);
				num += 1U;
				intPtr = (IntPtr)(intPtr.ToInt64() + (long)array.Length);
			}
			return list.ToArray();
		}
		throw new IOException();
	}

	// Token: 0x06000164 RID: 356 RVA: 0x000463F8 File Offset: 0x000445F8
	private GClass14[] method_13(byte[] byte_0, GClass24 gclass24_1, GClass31[] gclass31_1)
	{
		GClass14[] array = new GClass14[gclass24_1.UInt32_4];
		uint num = GClass18.smethod_10(gclass24_1.UInt32_6, gclass31_1);
		uint num2 = GClass18.smethod_10(gclass24_1.UInt32_8, gclass31_1);
		uint num3 = GClass18.smethod_10(gclass24_1.UInt32_7, gclass31_1);
		BitConverter.ToUInt32(byte_0, (int)num);
		uint num4 = 0U;
		while ((ulong)num4 < (ulong)((long)array.Length))
		{
			uint num5 = num4 + gclass24_1.UInt32_3;
			uint num6 = BitConverter.ToUInt32(byte_0, (int)(num + 4U * num4));
			array[(int)num4] = new GClass14(null, num6, (ushort)num5);
			num4 += 1U;
		}
		if ((ulong)num3 < (ulong)((long)byte_0.Length) && (ulong)num2 < (ulong)((long)byte_0.Length))
		{
			byte[] array2 = new byte[GClass17.int_0];
			for (uint num7 = 0U; num7 < gclass24_1.UInt32_5; num7 += 1U)
			{
				uint num8 = BitConverter.ToUInt32(byte_0, (int)(num3 + 4U * num7));
				if (num8 == 0U && (ulong)num8 >= (ulong)((long)byte_0.Length))
				{
					break;
				}
				uint num9 = GClass18.smethod_10(num8, gclass31_1);
				if (num9 == 0U && (ulong)num9 >= (ulong)((long)byte_0.Length))
				{
					break;
				}
				uint num10 = (uint)((long)byte_0.Length - (long)((ulong)num9));
				if ((ulong)num10 > (ulong)((long)GClass17.int_0))
				{
					num10 = (uint)GClass17.int_0;
				}
				Array.Clear(array2, 0, array2.Length);
				Array.Copy(byte_0, (long)((ulong)num9), array2, 0L, (long)((ulong)num10));
				string text = GClass18.smethod_13(array2);
				uint num11 = (uint)BitConverter.ToUInt16(byte_0, (int)(num2 + 2U * num7));
				if ((ulong)num11 > (ulong)((long)array.Length))
				{
					break;
				}
				array[(int)num11] = new GClass14(text, array[(int)num11].UInt32_0, array[(int)num11].UInt16_0);
			}
		}
		return array;
	}

	// Token: 0x06000165 RID: 357 RVA: 0x00046570 File Offset: 0x00044770
	private GClass14[] method_14(BinaryReader binaryReader_0, GClass24 gclass24_1, GClass31[] gclass31_1)
	{
		if (gclass24_1.UInt32_4 == 0U)
		{
			throw new IOException("Export functions: NumberOfFunctions = 0");
		}
		GClass14[] array = new GClass14[gclass24_1.UInt32_4];
		uint num = GClass18.smethod_10(gclass24_1.UInt32_6, gclass31_1);
		uint num2 = GClass18.smethod_10(gclass24_1.UInt32_8, gclass31_1);
		uint num3 = GClass18.smethod_10(gclass24_1.UInt32_7, gclass31_1);
		binaryReader_0.BaseStream.Seek((long)((ulong)num), SeekOrigin.Begin);
		byte[] array2 = new byte[gclass24_1.UInt32_4 * 4U];
		if (binaryReader_0.Read(array2, 0, array2.Length) == array2.Length)
		{
			uint num4 = 0U;
			while ((ulong)num4 < (ulong)((long)array.Length))
			{
				uint num5 = num4 + gclass24_1.UInt32_3;
				uint num6 = BitConverter.ToUInt32(array2, (int)(4U * num4));
				array[(int)num4] = new GClass14(null, num6, (ushort)num5);
				num4 += 1U;
			}
			if ((ulong)num3 < (ulong)binaryReader_0.BaseStream.Length && (ulong)num2 < (ulong)binaryReader_0.BaseStream.Length)
			{
				binaryReader_0.BaseStream.Seek((long)((ulong)num3), SeekOrigin.Begin);
				if (gclass24_1.UInt32_5 > gclass24_1.UInt32_4)
				{
					array2 = new byte[gclass24_1.UInt32_5 * 4U];
				}
				else
				{
					Array.Clear(array2, 0, array2.Length);
				}
				if (binaryReader_0.Read(array2, 0, array2.Length) == array2.Length)
				{
					byte[] array3 = new byte[gclass24_1.UInt32_5 * 2U];
					binaryReader_0.BaseStream.Seek((long)((ulong)num2), SeekOrigin.Begin);
					if (binaryReader_0.Read(array3, 0, array3.Length) == array3.Length)
					{
						byte[] array4 = new byte[GClass17.int_0];
						for (num4 = 0U; num4 < gclass24_1.UInt32_5; num4 += 1U)
						{
							uint num7 = BitConverter.ToUInt32(array2, (int)(4U * num4));
							if (num7 == 0U && (ulong)num7 >= (ulong)binaryReader_0.BaseStream.Length)
							{
								break;
							}
							uint num8 = GClass18.smethod_10(num7, gclass31_1);
							if (num8 == 0U && (ulong)num8 >= (ulong)binaryReader_0.BaseStream.Length)
							{
								break;
							}
							binaryReader_0.BaseStream.Seek((long)((ulong)num8), SeekOrigin.Begin);
							Array.Clear(array4, 0, array4.Length);
							binaryReader_0.Read(array4, 0, array4.Length);
							string text = GClass18.smethod_13(array4);
							uint num9 = (uint)BitConverter.ToUInt16(array3, (int)(2U * num4));
							array[(int)num9] = new GClass14(text, array[(int)num9].UInt32_0, array[(int)num9].UInt16_0);
						}
					}
				}
			}
			return array;
		}
		throw new IOException("Export functions read failed");
	}

	// Token: 0x06000166 RID: 358 RVA: 0x000467B4 File Offset: 0x000449B4
	private GClass14[] method_15(IntPtr intptr_0, IntPtr intptr_1, GClass24 gclass24_1)
	{
		if (gclass24_1.UInt32_4 == 0U)
		{
			throw new IOException("Export functions: NumberOfFunctions = 0");
		}
		GClass14[] array = new GClass14[gclass24_1.UInt32_4];
		IntPtr intPtr = (IntPtr)(intptr_1.ToInt64() + (long)((ulong)gclass24_1.UInt32_6));
		IntPtr intPtr2 = (IntPtr)(intptr_1.ToInt64() + (long)((ulong)gclass24_1.UInt32_8));
		IntPtr intPtr3 = (IntPtr)(intptr_1.ToInt64() + (long)((ulong)gclass24_1.UInt32_7));
		if (!GClass16.smethod_1(intptr_0, intPtr))
		{
			throw new IOException("Export functions read failed");
		}
		byte[] array2 = new byte[gclass24_1.UInt32_4 * 4U];
		uint num = 0U;
		if (GClass16.ReadProcessMemory(intptr_0, intPtr, array2, (uint)array2.Length, ref num) && (ulong)num == (ulong)((long)array2.Length))
		{
			uint num2 = 0U;
			while ((ulong)num2 < (ulong)((long)array.Length))
			{
				uint num3 = num2 + gclass24_1.UInt32_3;
				uint num4 = BitConverter.ToUInt32(array2, (int)(4U * num2));
				array[(int)num2] = new GClass14(null, num4, (ushort)num3);
				num2 += 1U;
			}
			if (intPtr3.ToInt64() >= 0L && GClass16.smethod_1(intptr_0, intPtr3) && GClass16.smethod_1(intptr_0, intPtr2))
			{
				if (gclass24_1.UInt32_5 > gclass24_1.UInt32_4)
				{
					array2 = new byte[gclass24_1.UInt32_5 * 4U];
				}
				else
				{
					Array.Clear(array2, 0, array2.Length);
				}
				if (GClass16.ReadProcessMemory(intptr_0, intPtr3, array2, (uint)array2.Length, ref num))
				{
					if ((ulong)num == (ulong)((long)array2.Length))
					{
						byte[] array3 = new byte[gclass24_1.UInt32_5 * 2U];
						if (GClass16.ReadProcessMemory(intptr_0, intPtr2, array3, (uint)array3.Length, ref num) && (ulong)num == (ulong)((long)array3.Length))
						{
							byte[] array4 = new byte[GClass17.int_0];
							for (num2 = 0U; num2 < gclass24_1.UInt32_5; num2 += 1U)
							{
								IntPtr intPtr4 = (IntPtr)(intptr_1.ToInt64() + (long)((ulong)BitConverter.ToUInt32(array2, (int)(4U * num2))));
								if (intPtr4 == IntPtr.Zero || !GClass16.smethod_1(intptr_0, intPtr4))
								{
									break;
								}
								Array.Clear(array4, 0, array4.Length);
								if (GClass16.ReadProcessMemory(intptr_0, intPtr4, array4, (uint)array4.Length, ref num))
								{
									string text = GClass18.smethod_13(array4);
									uint num5 = (uint)BitConverter.ToUInt16(array3, (int)(2U * num2));
									array[(int)num5] = new GClass14(text, array[(int)num5].UInt32_0, array[(int)num5].UInt16_0);
								}
							}
						}
					}
				}
			}
			return array;
		}
		throw new IOException("Export functions read failed");
	}

	// Token: 0x06000167 RID: 359 RVA: 0x00046A08 File Offset: 0x00044C08
	private GClass31[] method_16(byte[] byte_0, ushort ushort_0, int int_4, uint uint_0, bool bool_6)
	{
		if (ushort_0 == 0)
		{
			throw new ArgumentException("Section: Invalid number of sections");
		}
		GClass31[] array = new GClass31[(int)ushort_0];
		for (uint num = 0U; num < (uint)ushort_0; num += 1U)
		{
			array[(int)num] = new GClass31(byte_0, (int)((long)int_4 + (long)((ulong)(num * GClass31.uint_0))), uint_0, bool_6);
		}
		return array;
	}

	// Token: 0x06000168 RID: 360 RVA: 0x00046A50 File Offset: 0x00044C50
	private GClass31[] method_17(BinaryReader binaryReader_0, ushort ushort_0, int int_4, uint uint_0, bool bool_6)
	{
		if (ushort_0 == 0)
		{
			throw new ArgumentException("Section: Invalid number of sections");
		}
		binaryReader_0.BaseStream.Seek((long)int_4, SeekOrigin.Begin);
		GClass31[] array = new GClass31[(int)ushort_0];
		for (uint num = 0U; num < (uint)ushort_0; num += 1U)
		{
			array[(int)num] = new GClass31(binaryReader_0, 0, uint_0, bool_6);
		}
		return array;
	}

	// Token: 0x06000169 RID: 361 RVA: 0x00046A9C File Offset: 0x00044C9C
	private GClass31[] method_18(IntPtr intptr_0, ushort ushort_0, IntPtr intptr_1, uint uint_0, bool bool_6)
	{
		if (ushort_0 == 0)
		{
			throw new ArgumentException("Section: Invalid number of sections");
		}
		GClass31[] array = new GClass31[(int)ushort_0];
		for (uint num = 0U; num < (uint)ushort_0; num += 1U)
		{
			array[(int)num] = new GClass31(intptr_0, (IntPtr)(intptr_1.ToInt64() + (long)((ulong)(num * GClass31.uint_0))), uint_0, bool_6);
		}
		return array;
	}

	// Token: 0x0600016A RID: 362 RVA: 0x00046AF0 File Offset: 0x00044CF0
	private GClass30 method_19(byte[] byte_0, GClass31[] gclass31_1, uint uint_0, GClass20 gclass20_0, bool bool_6)
	{
		if (gclass31_1 != null && gclass31_1.Length != 0)
		{
			int i = 0;
			long num = (long)byte_0.Length;
			if (gclass20_0.UInt32_0 > 0U && gclass20_0.UInt32_1 > 0U)
			{
				long num2 = (long)((ulong)GClass18.smethod_10(gclass20_0.UInt32_0, this.GClass31_0));
				if (num2 > 0L)
				{
					num = num2;
				}
			}
			long num3 = (long)((ulong)(gclass31_1[0].UInt32_4 + gclass31_1[0].UInt32_3));
			long num4;
			for (i++; i < gclass31_1.Length; i++)
			{
				num4 = (long)((ulong)(gclass31_1[i].UInt32_4 + gclass31_1[i].UInt32_3));
				if (num4 > num3)
				{
					num3 = num4;
				}
			}
			if (uint_0 > 0U && num3 % (long)((ulong)uint_0) != 0L)
			{
				int num5 = (int)((double)num3 / uint_0);
				num5++;
				num3 = (long)((ulong)uint_0 * (ulong)((long)num5));
			}
			num4 = num - num3;
			if (num4 != (long)byte_0.Length)
			{
				if (num4 > 0L)
				{
					return new GClass30(byte_0, num3, num4, bool_6);
				}
			}
			return null;
		}
		throw new ArgumentException("Overlay: Invalid number of sections");
	}

	// Token: 0x0600016B RID: 363 RVA: 0x00046BD8 File Offset: 0x00044DD8
	private GClass30 method_20(BinaryReader binaryReader_0, GClass31[] gclass31_1, uint uint_0, GClass20 gclass20_0, bool bool_6)
	{
		if (gclass31_1 == null || gclass31_1.Length == 0)
		{
			throw new ArgumentException("Overlay: Invalid number of sections");
		}
		int i = 0;
		long num = binaryReader_0.BaseStream.Length;
		if (gclass20_0.UInt32_0 > 0U && gclass20_0.UInt32_1 > 0U)
		{
			long num2 = (long)((ulong)GClass18.smethod_10(gclass20_0.UInt32_0, this.GClass31_0));
			if (num2 > 0L)
			{
				num = num2;
			}
		}
		long num3 = (long)((ulong)(gclass31_1[0].UInt32_4 + gclass31_1[0].UInt32_3));
		long num4;
		for (i++; i < gclass31_1.Length; i++)
		{
			num4 = (long)((ulong)(gclass31_1[i].UInt32_4 + gclass31_1[i].UInt32_3));
			if (num4 > num3)
			{
				num3 = num4;
			}
		}
		if (uint_0 > 0U && num3 % (long)((ulong)uint_0) != 0L)
		{
			int num5 = (int)((double)num3 / uint_0);
			num5++;
			num3 = (long)((ulong)uint_0 * (ulong)((long)num5));
		}
		num4 = num - num3;
		if (num4 != binaryReader_0.BaseStream.Length && num4 > 0L)
		{
			return new GClass30(binaryReader_0, num3, num4, bool_6);
		}
		return null;
	}

	// Token: 0x0600016C RID: 364 RVA: 0x00046CCC File Offset: 0x00044ECC
	private GClass21 method_21(byte[] byte_0, uint uint_0)
	{
		return new GClass21(byte_0, (int)uint_0);
	}

	// Token: 0x0600016D RID: 365 RVA: 0x00046CE0 File Offset: 0x00044EE0
	private GClass21 method_22(BinaryReader binaryReader_0, uint uint_0)
	{
		return new GClass21(binaryReader_0, (int)uint_0);
	}

	// Token: 0x0600016E RID: 366 RVA: 0x00046CF4 File Offset: 0x00044EF4
	public virtual string ToString()
	{
		List<string> list = new List<string>();
		list.Add(this.Boolean_9 ? "1" : "0");
		string text = string.Empty;
		try
		{
			text = this.String_2;
			if (text == null)
			{
				text = string.Empty;
			}
		}
		catch
		{
		}
		list.Add(text);
		list.Add(this.GClass28_0.GClass29_0.UInt16_8.ToString());
		list.Add(this.GClass28_0.GClass25_0.UInt32_0.ToString());
		list.Add(this.GClass28_0.GClass29_0.UInt32_11.ToString());
		string text2 = string.Empty;
		try
		{
			text2 = this.String_1;
			if (text2 == null)
			{
				text2 = string.Empty;
			}
		}
		catch
		{
		}
		list.Add(text2);
		List<string> list2 = new List<string>();
		try
		{
			if (this.Boolean_2 && this.GClass15_0 != null)
			{
				using (Dictionary<string, string[]>.Enumerator enumerator = new Dictionary<string, string[]>
				{
					{
						Class14.String_176.ToLowerInvariant(),
						Class14.String_45
					},
					{
						Class14.String_132.ToLowerInvariant(),
						new string[]
						{
							Class14.String_157,
							Class14.String_44,
							Class14.String_147,
							Class14.String_163,
							Class14.String_56
						}
					},
					{
						Class14.String_172.ToLowerInvariant(),
						new string[]
						{
							Class14.String_86,
							Class14.String_102,
							Class14.String_108
						}
					}
				}.GetEnumerator())
				{
					if (!enumerator.MoveNext())
					{
					}
				}
			}
		}
		catch
		{
		}
		list.Add(Class15.smethod_0(list2, ';'));
		List<string> list3 = new List<string>();
		if (this.GClass35_0 != null && this.Boolean_4)
		{
			if (this.GClass35_0.String_1 == null)
			{
				list3.Add("");
			}
			else
			{
				list3.Add(Class15.smethod_22(this.GClass35_0.String_1));
			}
			if (this.GClass35_0.String_0 != null)
			{
				list3.Add(Class15.smethod_22(this.GClass35_0.String_0));
			}
			else
			{
				list3.Add("");
			}
		}
		list.Add(Class15.smethod_0(list3, '!'));
		List<string> list4 = new List<string>();
		try
		{
			if (this.GClass31_0 != null)
			{
				foreach (GClass31 gclass in this.GClass31_0)
				{
					list4.Add(gclass.ToString());
				}
			}
		}
		catch
		{
		}
		list.Add(Class15.smethod_0(list4, ';'));
		string text3 = string.Empty;
		try
		{
			if (this.GClass30_0 != null)
			{
				text3 = this.GClass30_0.ToString();
				if (text3 == null)
				{
					text3 = string.Empty;
				}
			}
		}
		catch
		{
			text3 = string.Empty;
		}
		list.Add(text3);
		if (this.String_0 != null)
		{
			list.Add(Class15.smethod_22(this.String_0));
		}
		else
		{
			list.Add(Class14.String_215);
		}
		string text4 = Class15.smethod_0(list, '|');
		return Convert.ToBase64String(Encoding.UTF8.GetBytes(text4));
	}

	// Token: 0x0600016F RID: 367 RVA: 0x00047048 File Offset: 0x00045248
	public static bool smethod_0(string string_4)
	{
		return new GClass17(string_4, GEnum15.const_0).Boolean_0;
	}

	// Token: 0x06000170 RID: 368 RVA: 0x00047064 File Offset: 0x00045264
	public static bool smethod_1(IntPtr intptr_0, IntPtr intptr_1)
	{
		byte[] array = new byte[GClass23.int_0];
		uint num = 0U;
		if (intptr_0 == IntPtr.Zero || intptr_1 == IntPtr.Zero || !GClass16.smethod_1(intptr_0, intptr_1))
		{
			return false;
		}
		if (!GClass16.ReadProcessMemory(intptr_0, intptr_1, array, (uint)GClass23.int_0, ref num) || num != 64U)
		{
			return false;
		}
		GClass23 gclass = new GClass23(array);
		if (gclass.UInt16_0 != 23117)
		{
			return false;
		}
		IntPtr intPtr = (IntPtr)(intptr_1.ToInt64() + (long)((ulong)gclass.UInt32_0));
		if (GClass16.smethod_1(intptr_0, intPtr))
		{
			if (GClass16.ReadProcessMemory(intptr_0, intPtr, array, 2U, ref num))
			{
				if (num == 2U)
				{
					ushort num2 = BitConverter.ToUInt16(array, 0);
					if (num2 != 17744)
					{
						if (num2 != 17742 && num2 != 17740)
						{
							return num2 == 22604;
						}
					}
					return true;
				}
			}
			return false;
		}
		return false;
	}

	// Token: 0x06000171 RID: 369 RVA: 0x00047144 File Offset: 0x00045344
	public static bool smethod_2(string string_4, bool bool_6 = false)
	{
		FileStream fileStream = null;
		BinaryReader binaryReader = null;
		try
		{
			string text = string_4;
			if (bool_6 && GClass49.smethod_16())
			{
				string text2 = Class15.smethod_4();
				if (text.ToLowerInvariant().StartsWith(text2.ToLowerInvariant()))
				{
					text = Class15.smethod_5() + text.Substring(text2.Length);
				}
			}
			if (text.Length <= GClass18.int_0 && !text.Contains(":"))
			{
				try
				{
					fileStream = new FileStream(text, FileMode.Open, FileAccess.Read, FileShare.Read);
					goto IL_9E;
				}
				catch
				{
					fileStream = new FileStream(text, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					goto IL_9E;
				}
			}
			try
			{
				fileStream = GClass39.smethod_2(text, FileMode.Open, FileAccess.Read, FileShare.Read);
			}
			catch
			{
				fileStream = GClass39.smethod_2(text, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
			}
			IL_9E:
			int num = (int)fileStream.Length;
			if (num < GClass23.int_0)
			{
				return false;
			}
			byte[] array = new byte[GClass23.int_0];
			binaryReader = new BinaryReader(fileStream);
			if (binaryReader.Read(array, 0, GClass23.int_0) < GClass23.int_0)
			{
				return false;
			}
			GClass23 gclass = new GClass23(array);
			if (gclass.UInt16_0 != 23117)
			{
				return false;
			}
			if ((long)num < (long)((ulong)(gclass.UInt32_0 + 4U)))
			{
				return false;
			}
			binaryReader.BaseStream.Seek((long)((ulong)gclass.UInt32_0), SeekOrigin.Begin);
			ushort num2 = binaryReader.ReadUInt16();
			return num2 == 17744 || num2 == 17742 || num2 == 17740 || num2 == 22604;
		}
		catch
		{
		}
		finally
		{
			if (binaryReader != null)
			{
				binaryReader.Close();
			}
			if (fileStream != null)
			{
				fileStream.Close();
			}
		}
		return false;
	}

	// Token: 0x06000172 RID: 370 RVA: 0x0004732C File Offset: 0x0004552C
	public static bool smethod_3(string string_4, bool bool_6 = false)
	{
		FileStream fileStream = null;
		BinaryReader binaryReader = null;
		bool flag;
		try
		{
			string text = string_4;
			if (bool_6 && GClass49.smethod_16())
			{
				string text2 = Class15.smethod_4();
				if (text.ToLowerInvariant().StartsWith(text2.ToLowerInvariant()))
				{
					text = Class15.smethod_5() + text.Substring(text2.Length);
				}
			}
			if (text.Length <= GClass18.int_0 && !text.Contains(":"))
			{
				try
				{
					fileStream = new FileStream(text, FileMode.Open, FileAccess.Read, FileShare.Read);
					goto IL_9D;
				}
				catch
				{
					fileStream = new FileStream(text, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					goto IL_9D;
				}
			}
			try
			{
				fileStream = GClass39.smethod_2(text, FileMode.Open, FileAccess.Read, FileShare.Read);
			}
			catch
			{
				fileStream = GClass39.smethod_2(text, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
			}
			IL_9D:
			int num = (int)fileStream.Length;
			if (num < GClass23.int_0)
			{
				flag = false;
			}
			else
			{
				byte[] array = new byte[GClass23.int_0];
				binaryReader = new BinaryReader(fileStream);
				if (binaryReader.Read(array, 0, GClass23.int_0) >= GClass23.int_0)
				{
					GClass23 gclass = new GClass23(array);
					if (gclass.UInt16_0 != 23117)
					{
						flag = false;
					}
					else if ((long)num >= (long)((ulong)(gclass.UInt32_0 + 6U)))
					{
						binaryReader.BaseStream.Seek((long)((ulong)gclass.UInt32_0), SeekOrigin.Begin);
						array = new byte[6];
						binaryReader.Read(array, 0, 6);
						ushort num2 = BitConverter.ToUInt16(array, 0);
						if (num2 != 17744)
						{
							if (num2 != 17742)
							{
								if (num2 != 17740)
								{
									if (num2 != 22604)
									{
										return false;
									}
								}
							}
						}
						if (BitConverter.ToUInt16(array, 4) == 34404)
						{
							flag = true;
						}
						else
						{
							flag = false;
						}
					}
					else
					{
						flag = false;
					}
				}
				else
				{
					flag = false;
				}
			}
		}
		finally
		{
			if (binaryReader != null)
			{
				binaryReader.Close();
			}
			if (fileStream != null)
			{
				fileStream.Close();
			}
		}
		return flag;
	}

	// Token: 0x06000173 RID: 371 RVA: 0x00047528 File Offset: 0x00045728
	public static bool smethod_4(string string_4, bool bool_6 = false)
	{
		FileStream fileStream = null;
		BinaryReader binaryReader = null;
		bool flag;
		try
		{
			string text = string_4;
			if (bool_6 && GClass49.smethod_16())
			{
				string text2 = Class15.smethod_4();
				if (text.ToLowerInvariant().StartsWith(text2.ToLowerInvariant()))
				{
					text = Class15.smethod_5() + text.Substring(text2.Length);
				}
			}
			if (text.Length <= GClass18.int_0 && !text.Contains(":"))
			{
				try
				{
					fileStream = new FileStream(text, FileMode.Open, FileAccess.Read, FileShare.Read);
					goto IL_9D;
				}
				catch
				{
					fileStream = new FileStream(text, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
					goto IL_9D;
				}
			}
			try
			{
				fileStream = GClass39.smethod_2(text, FileMode.Open, FileAccess.Read, FileShare.Read);
			}
			catch
			{
				fileStream = GClass39.smethod_2(text, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
			}
			IL_9D:
			int num = (int)fileStream.Length;
			if (num >= GClass23.int_0)
			{
				byte[] array = new byte[GClass23.int_0];
				binaryReader = new BinaryReader(fileStream);
				if (binaryReader.Read(array, 0, GClass23.int_0) < GClass23.int_0)
				{
					flag = false;
				}
				else
				{
					GClass23 gclass = new GClass23(array);
					if (gclass.UInt16_0 != 23117)
					{
						flag = false;
					}
					else if ((long)num >= (long)((ulong)(gclass.UInt32_0 + 6U)))
					{
						binaryReader.BaseStream.Seek((long)((ulong)gclass.UInt32_0), SeekOrigin.Begin);
						array = new byte[6];
						binaryReader.Read(array, 0, 6);
						ushort num2 = BitConverter.ToUInt16(array, 0);
						if (num2 != 17744)
						{
							if (num2 != 17742)
							{
								if (num2 != 17740)
								{
									if (num2 != 22604)
									{
										return false;
									}
								}
							}
						}
						if (BitConverter.ToUInt16(array, 4) == 332)
						{
							flag = true;
						}
						else
						{
							flag = false;
						}
					}
					else
					{
						flag = false;
					}
				}
			}
			else
			{
				flag = false;
			}
		}
		finally
		{
			if (binaryReader != null)
			{
				binaryReader.Close();
			}
			if (fileStream != null)
			{
				fileStream.Close();
			}
		}
		return flag;
	}

	// Token: 0x06000174 RID: 372 RVA: 0x00047724 File Offset: 0x00045924
	public string method_23()
	{
		if (this.GClass15_0 != null && this.GClass15_0.Length != 0)
		{
			List<string> list = new List<string>();
			foreach (GClass15 gclass in this.GClass15_0)
			{
				string text = gclass.String_1.Split(new char[] { '.' })[0];
				text += ".";
				if (gclass.String_0 == null)
				{
					if (!(gclass.String_1 == "oleaut32.dll"))
					{
						if (!(gclass.String_1 == "ws2_32.dll"))
						{
							if (!(gclass.String_1 == "wsock32.dll"))
							{
								text += "ord";
								text += gclass.UInt16_0.ToString();
							}
							else
							{
								text += Class7.smethod_0(Class7.Enum0.const_2, (uint)gclass.UInt16_0);
							}
						}
						else
						{
							text += Class7.smethod_0(Class7.Enum0.const_1, (uint)gclass.UInt16_0);
						}
					}
					else
					{
						text += Class7.smethod_0(Class7.Enum0.const_0, (uint)gclass.UInt16_0);
					}
				}
				else
				{
					text += gclass.String_0;
				}
				list.Add(text.ToLower());
			}
			string text2 = string.Join(",", list.ToArray());
			HashAlgorithm hashAlgorithm = MD5.Create();
			byte[] bytes = Encoding.ASCII.GetBytes(text2);
			byte[] array2 = hashAlgorithm.ComputeHash(bytes);
			StringBuilder stringBuilder = new StringBuilder();
			for (int j = 0; j < array2.Length; j++)
			{
				stringBuilder.Append(array2[j].ToString("X2"));
			}
			return stringBuilder.ToString();
		}
		return null;
	}

	// Token: 0x06000175 RID: 373 RVA: 0x000478D8 File Offset: 0x00045AD8
	public string method_24()
	{
		if (this.GClass14_0 != null && this.GClass14_0.Length != 0)
		{
			List<string> list = new List<string>();
			foreach (GClass14 gclass in this.GClass14_0)
			{
				string text = "";
				if (gclass.String_0 != null)
				{
					text += gclass.String_0;
				}
				else
				{
					text += "ord";
					text += gclass.UInt16_0.ToString();
				}
				list.Add(text.ToLower());
			}
			string text2 = string.Join(",", list.ToArray());
			HashAlgorithm hashAlgorithm = MD5.Create();
			byte[] bytes = Encoding.ASCII.GetBytes(text2);
			byte[] array2 = hashAlgorithm.ComputeHash(bytes);
			StringBuilder stringBuilder = new StringBuilder();
			for (int j = 0; j < array2.Length; j++)
			{
				stringBuilder.Append(array2[j].ToString("X2"));
			}
			return stringBuilder.ToString();
		}
		return null;
	}

	// Token: 0x06000176 RID: 374 RVA: 0x000479E0 File Offset: 0x00045BE0
	public static bool smethod_5(IntPtr intptr_0, IntPtr intptr_1)
	{
		try
		{
			GClass17 gclass = new GClass17(intptr_0, intptr_1, GEnum15.const_0);
			if (gclass.GClass28_0 != null && gclass.GClass31_0 != null)
			{
				for (int i = 0; i < gclass.GClass31_0.Length; i++)
				{
					if ((gclass.GClass31_0[i].UInt32_7 & 536870912U) == 536870912U || (gclass.GClass31_0[i].UInt32_7 & 32U) == 32U)
					{
						return true;
					}
				}
			}
		}
		catch
		{
		}
		return false;
	}

	// Token: 0x040001A1 RID: 417
	private static readonly int int_0 = 1024;

	// Token: 0x040001A2 RID: 418
	private static readonly int int_1 = 1024;

	// Token: 0x040001A3 RID: 419
	private static readonly int int_2 = 2048;

	// Token: 0x040001A4 RID: 420
	private static readonly int int_3 = 4096;

	// Token: 0x040001A5 RID: 421
	private static readonly long long_0 = 5242880L;

	// Token: 0x040001A6 RID: 422
	private string string_0;

	// Token: 0x040001A7 RID: 423
	private string string_1;

	// Token: 0x040001A8 RID: 424
	[CompilerGenerated]
	private bool bool_0;

	// Token: 0x040001A9 RID: 425
	[CompilerGenerated]
	private bool bool_1;

	// Token: 0x040001AA RID: 426
	[CompilerGenerated]
	private bool bool_2;

	// Token: 0x040001AB RID: 427
	[CompilerGenerated]
	private bool bool_3;

	// Token: 0x040001AC RID: 428
	[CompilerGenerated]
	private bool bool_4;

	// Token: 0x040001AD RID: 429
	[CompilerGenerated]
	private bool bool_5;

	// Token: 0x040001AE RID: 430
	[CompilerGenerated]
	private GClass23 gclass23_0;

	// Token: 0x040001AF RID: 431
	[CompilerGenerated]
	private GClass28 gclass28_0;

	// Token: 0x040001B0 RID: 432
	[CompilerGenerated]
	private GClass31[] gclass31_0;

	// Token: 0x040001B1 RID: 433
	[CompilerGenerated]
	private GClass30 gclass30_0;

	// Token: 0x040001B2 RID: 434
	[CompilerGenerated]
	private string string_2;

	// Token: 0x040001B3 RID: 435
	[CompilerGenerated]
	private GClass24 gclass24_0;

	// Token: 0x040001B4 RID: 436
	[CompilerGenerated]
	private GClass27[] gclass27_0;

	// Token: 0x040001B5 RID: 437
	[CompilerGenerated]
	private GClass14[] gclass14_0;

	// Token: 0x040001B6 RID: 438
	[CompilerGenerated]
	private GClass15[] gclass15_0;

	// Token: 0x040001B7 RID: 439
	[CompilerGenerated]
	private GClass21 gclass21_0;

	// Token: 0x040001B8 RID: 440
	[CompilerGenerated]
	private GClass35 gclass35_0;

	// Token: 0x040001B9 RID: 441
	[CompilerGenerated]
	private GClass36 gclass36_0;

	private X509Certificate2 x509Certificate2_1;

	// Token: 0x040001BB RID: 443
	[CompilerGenerated]
	private GClass37 gclass37_0;

	// Token: 0x040001BC RID: 444
	[CompilerGenerated]
	private string string_3;
}
