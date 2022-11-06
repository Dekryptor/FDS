using System;
using System.Globalization;
using System.Runtime.CompilerServices;

// Token: 0x020000DE RID: 222
internal class Class45
{
	// Token: 0x17000307 RID: 775
	// (get) Token: 0x0600070D RID: 1805 RVA: 0x00064C78 File Offset: 0x00062E78
	// (set) Token: 0x0600070E RID: 1806 RVA: 0x00064C8C File Offset: 0x00062E8C
	public bool Boolean_0 { get; set; }

	// Token: 0x17000308 RID: 776
	// (get) Token: 0x0600070F RID: 1807 RVA: 0x00064CA0 File Offset: 0x00062EA0
	// (set) Token: 0x06000710 RID: 1808 RVA: 0x00064CB4 File Offset: 0x00062EB4
	public string String_0 { get; set; }

	// Token: 0x17000309 RID: 777
	// (get) Token: 0x06000711 RID: 1809 RVA: 0x00064CC8 File Offset: 0x00062EC8
	// (set) Token: 0x06000712 RID: 1810 RVA: 0x00064CDC File Offset: 0x00062EDC
	public bool Boolean_1 { get; set; }

	// Token: 0x1700030A RID: 778
	// (get) Token: 0x06000713 RID: 1811 RVA: 0x00064CF0 File Offset: 0x00062EF0
	// (set) Token: 0x06000714 RID: 1812 RVA: 0x00064D04 File Offset: 0x00062F04
	public DateTime DateTime_0 { get; set; }

	// Token: 0x1700030B RID: 779
	// (get) Token: 0x06000715 RID: 1813 RVA: 0x00064D18 File Offset: 0x00062F18
	// (set) Token: 0x06000716 RID: 1814 RVA: 0x00064D2C File Offset: 0x00062F2C
	public string String_1 { get; set; }

	// Token: 0x1700030C RID: 780
	// (get) Token: 0x06000717 RID: 1815 RVA: 0x00064D40 File Offset: 0x00062F40
	// (set) Token: 0x06000718 RID: 1816 RVA: 0x00064D54 File Offset: 0x00062F54
	public string String_2 { get; set; }

	// Token: 0x06000719 RID: 1817 RVA: 0x00064D68 File Offset: 0x00062F68
	public Class45()
	{
		/*
An exception occurred when decompiling this method (06000719)

ICSharpCode.Decompiler.DecompilerException: Error decompiling System.Void Class45::.ctor()

 ---> System.Exception: Inconsistent stack size at IL_170
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.StackAnalysis(MethodDef methodDef) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 460
   at ICSharpCode.Decompiler.ILAst.ILAstBuilder.Build(MethodDef methodDef, Boolean optimize, DecompilerContext context) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\ILAst\ILAstBuilder.cs:line 278
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(IEnumerable`1 parameters, MethodDebugInfoBuilder& builder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 112
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   --- End of inner exception stack trace ---
   at ICSharpCode.Decompiler.Ast.AstMethodBodyBuilder.CreateMethodBody(MethodDef methodDef, DecompilerContext context, AutoPropertyProvider autoPropertyProvider, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, StringBuilder sb, MethodDebugInfoBuilder& stmtsBuilder) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstMethodBodyBuilder.cs:line 99
   at ICSharpCode.Decompiler.Ast.AstBuilder.AddMethodBody(EntityDeclaration methodNode, EntityDeclaration& updatedNode, MethodDef method, IEnumerable`1 parameters, Boolean valueParameterIsKeyword, MethodKind methodKind) in D:\a\dnSpy\dnSpy\Extensions\ILSpy.Decompiler\ICSharpCode.Decompiler\ICSharpCode.Decompiler\Ast\AstBuilder.cs:line 1595
*/;
	}

	// Token: 0x0600071A RID: 1818 RVA: 0x00064F08 File Offset: 0x00063108
	public virtual string ToString()
	{
		return string.Format("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}{10}", new object[]
		{
			this.Boolean_0 ? "1" : "0",
			Class15.char_2,
			Class15.smethod_22(this.String_0),
			Class15.char_2,
			this.Boolean_1 ? "1" : "0",
			Class15.char_2,
			this.DateTime_0.ToString(Class15.string_0, CultureInfo.InvariantCulture),
			Class15.char_2,
			this.String_1,
			Class15.char_2,
			this.String_2
		});
	}

	// Token: 0x0600071B RID: 1819 RVA: 0x00064FD4 File Offset: 0x000631D4
	public static string smethod_0()
	{
		return new Class45().ToString();
	}

	// Token: 0x040009CD RID: 2509
	[CompilerGenerated]
	private bool bool_0;

	// Token: 0x040009CE RID: 2510
	[CompilerGenerated]
	private string string_0;

	// Token: 0x040009CF RID: 2511
	[CompilerGenerated]
	private bool bool_1;

	// Token: 0x040009D0 RID: 2512
	[CompilerGenerated]
	private DateTime dateTime_0;

	// Token: 0x040009D1 RID: 2513
	[CompilerGenerated]
	private string string_1;

	// Token: 0x040009D2 RID: 2514
	[CompilerGenerated]
	private string string_2;
}
