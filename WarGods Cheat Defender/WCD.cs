using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Authentication;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;
using static System.Windows.Forms.LinkLabel;

// Token: 0x020000BA RID: 186
public partial class WCD : Form
{
	// Token: 0x060005EF RID: 1519 RVA: 0x00056F70 File Offset: 0x00055170
	public WCD()
	{
		this.InitializeComponent();
		this.bool_0 = false;
		this.gclass43_0 = new GClass43(false);
		Class12.Boolean_0 = true;

        //string text2 = Class50.smethod_0(this.method_80(this.byte_0), this.string_1);
		//MessageBox.Show(text2);
        //File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + "/data.txt", text2);
    }

    // Token: 0x060005F0 RID: 1520 RVA: 0x00056FE4 File Offset: 0x000551E4
    private void scan_Click(object sender, EventArgs e)
	{
		this.string_4 = null;
		if (!this.method_81())
		{
			MessageBox.Show(this, "Could not read/write your unique id. Please contact the support: " + Class12.smethod_1(true), "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			Application.Exit();
		}
		try
		{
			this.bool_2 = GClass49.smethod_16();
			this.wCDScanner = new Thread(new ThreadStart(this.method_3));
			this.wCDScanner.Name = "wCDScanner";
			this.wCDScanner.IsBackground = true;
			this.wCDScanner.Priority = ThreadPriority.Normal;
			this.wCDScanner.SetApartmentState(ApartmentState.STA);
			this.wCDScanner.Start();
		}
		catch
		{
			MessageBox.Show(this, "Something went wrong. Make sure you have properly installed .Net Framework & try to run wCD again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}
	}

	// Token: 0x060005F1 RID: 1521 RVA: 0x000570B0 File Offset: 0x000552B0
	public void method_0(GEnum49 genum49_0, Stopwatch stopwatch_0)
	{
		object obj = this.object_4;
		lock (obj)
		{
			this.gclass51_0.dictionary_0.Add(genum49_0, stopwatch_0.ElapsedMilliseconds);
		}
	}

	// Token: 0x060005F2 RID: 1522 RVA: 0x00057104 File Offset: 0x00055304
	private void report_Click(object sender, EventArgs e)
	{
		MessageBox.Show(this, "Due to security reasons we disabled this option!\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
	}

	// Token: 0x060005F3 RID: 1523 RVA: 0x00057128 File Offset: 0x00055328
	public string method_1()
	{
		try
		{
			return new StackTrace().GetFrame(1).GetMethod().Name;
		}
		catch
		{
		}
		return string.Empty;
	}

	// Token: 0x060005F4 RID: 1524 RVA: 0x00057168 File Offset: 0x00055368
	public void method_2()
	{
		if (this.gclass51_0 != null)
		{
			string text = this.method_1();
			object obj = this.object_5;
			lock (obj)
			{
				this.gclass51_0.List_8.Add(text);
			}
		}
	}

	// Token: 0x060005F5 RID: 1525 RVA: 0x000571C4 File Offset: 0x000553C4
	private void method_3()
	{
		this.string_3 = string.Empty;
		base.Invoke(new MethodInvoker(this.method_84));
		if (GClass45.smethod_0("SeDebugPrivilege", true))
		{
			this.gclass51_0 = new GClass51();
			this.gclass51_0.String_0 = this.string_0;
			this.bool_1 = false;
			this.int_0 = 0;
			int num = this.method_21();
			if (num != 0)
			{
				if (num == 1)
				{
					base.Invoke(new MethodInvoker(this.method_87));
				}
				else if (num == 2)
				{
					base.Invoke(new MethodInvoker(this.method_88));
				}
				else if (num == 3)
				{
					base.Invoke(new MethodInvoker(this.method_89));
				}
				else if (num == 4)
				{
					base.Invoke(new MethodInvoker(this.method_90));
				}
				else
				{
					base.Invoke(new MethodInvoker(this.method_91));
				}
			}
			else if (!this.method_47())
			{
				this.method_74();
			}
			else
			{
				base.Invoke(new MethodInvoker(this.method_86));
			}
			this.gclass51_0 = null;
			GClass45.smethod_0("SeDebugPrivilege", false);
			return;
		}
		base.Invoke(new MethodInvoker(this.method_85));
	}

	// Token: 0x060005F6 RID: 1526 RVA: 0x000572FC File Offset: 0x000554FC
	private GClass41 method_4(GEnum21 genum21_0, string string_6, int int_2 = -1, long long_0 = -1L, GEnum23 genum23_0 = GEnum23.const_0)
	{
		GClass41 gclass = new GClass41();
		gclass.GEnum21_0 = genum21_0;
		gclass.Int32_0 = int_2;
		gclass.String_0 = Class15.smethod_22(string_6);
		gclass.Int64_0 = long_0;
		gclass.GEnum23_0 = genum23_0;
		object obj = WCD.object_1;
		lock (obj)
		{
			this.gclass51_0.List_0.Add(gclass);
		}
		return gclass;
	}

	// Token: 0x060005F7 RID: 1527 RVA: 0x00057378 File Offset: 0x00055578
	private long method_5(GEnum21 genum21_0, GEnum48 genum48_0, string string_6, DateTime? nullable_0 = null, GEnum51 genum51_0 = GEnum51.const_0)
	{
		long num = -1L;
		if (string_6 != null && string_6.Length != 0)
		{
			string_6 = GClass44.smethod_0(string_6, this.bool_2, ref genum51_0);
			string text = string_6.ToLowerInvariant();
			object obj = WCD.object_0;
			lock (obj)
			{
				int num2 = 0;
				while (num2 < this.gclass51_0.List_1.Count && !this.method_47())
				{
					if (this.gclass51_0.List_1[num2].String_1.ToLowerInvariant() == text)
					{
						this.gclass51_0.List_1[num2].GEnum48_0 |= genum48_0;
						this.gclass51_0.List_1[num2].GEnum21_0 |= genum21_0;
						if (nullable_0 != null)
						{
							try
							{
								if (this.gclass51_0.List_1[num2].Nullable_0 != null)
								{
									int num3 = (nullable_0.Value - this.gclass51_0.DateTime_0).Seconds;
									if (num3 < 0)
									{
										num3 = 0 - num3;
									}
									int num4 = (this.gclass51_0.List_1[num2].Nullable_0.Value - this.gclass51_0.DateTime_0).Seconds;
									if (num4 < 0)
									{
										num4 = 0 - num4;
									}
									if (num3 < num4)
									{
										this.gclass51_0.List_1[num2].Nullable_0 = nullable_0;
									}
								}
								else
								{
									this.gclass51_0.List_1[num2].Nullable_0 = nullable_0;
								}
							}
							catch
							{
							}
						}
						num = (long)num2;
						break;
					}
					num2++;
				}
				if (num == -1L && !this.method_47())
				{
					GClass44 gclass = new GClass44(string_6, genum48_0, false);
					gclass.Nullable_0 = nullable_0;
					gclass.GEnum21_0 = genum21_0;
					gclass.Int64_0 = (long)this.gclass51_0.List_1.Count;
					this.gclass51_0.List_1.Add(gclass);
					num = gclass.Int64_0;
				}
			}
			return num;
		}
		this.method_7(GEnum22.const_0, string.Format("{0}-{1}", (int)genum21_0, (int)genum48_0));
		return num;
	}

	// Token: 0x060005F8 RID: 1528 RVA: 0x00057600 File Offset: 0x00055800
	private long method_6(GClass44 gclass44_0)
	{
		long num = -1L;
		string text = gclass44_0.String_1.ToLowerInvariant();
		object obj = WCD.object_0;
		lock (obj)
		{
			int num2 = 0;
			while (num2 < this.gclass51_0.List_1.Count && !this.method_47())
			{
				if (this.gclass51_0.List_1[num2].String_1.ToLowerInvariant() == text)
				{
					this.gclass51_0.List_1[num2].GEnum48_0 |= gclass44_0.GEnum48_0;
					if (gclass44_0.Nullable_0 != null)
					{
						try
						{
							if (this.gclass51_0.List_1[num2].Nullable_0 != null)
							{
								int num3 = (gclass44_0.Nullable_0.Value - this.gclass51_0.DateTime_0).Seconds;
								if (num3 < 0)
								{
									num3 = 0 - num3;
								}
								int num4 = (this.gclass51_0.List_1[num2].Nullable_0.Value - this.gclass51_0.DateTime_0).Seconds;
								if (num4 < 0)
								{
									num4 = 0 - num4;
								}
								if (num3 < num4)
								{
									this.gclass51_0.List_1[num2].Nullable_0 = gclass44_0.Nullable_0;
								}
							}
							else
							{
								this.gclass51_0.List_1[num2].Nullable_0 = gclass44_0.Nullable_0;
							}
						}
						catch
						{
						}
					}
					num = (long)num2;
					break;
				}
				num2++;
			}
			if (num == -1L)
			{
				if (!this.method_47())
				{
					gclass44_0.Int64_0 = (long)this.gclass51_0.List_1.Count;
					this.gclass51_0.List_1.Add(gclass44_0);
					num = gclass44_0.Int64_0;
				}
			}
		}
		return num;
	}

	// Token: 0x060005F9 RID: 1529 RVA: 0x00057830 File Offset: 0x00055A30
	private void method_7(GEnum22 genum22_0, string string_6)
	{
		object obj = WCD.object_3;
		lock (obj)
		{
			if (this.string_3 != "")
			{
				this.string_3 += Class15.char_0.ToString();
			}
			string text = Class15.smethod_22(string_6).Replace("\n", "\\n").Replace("\r", "\\r")
				.Replace("\t", "\\t");
			string text2 = this.string_3;
			int num = (int)genum22_0;
			this.string_3 = text2 + num.ToString() + Class15.char_2.ToString() + text;
		}
	}

	// Token: 0x060005FA RID: 1530 RVA: 0x000578F8 File Offset: 0x00055AF8
	private string method_8(Process process_1)
	{
		try
		{
			ReadOnlyCollectionBase modules = process_1.Modules;
			string string_ = Class14.String_116;
			string string_2 = Class14.String_176;
            /*using (IEnumerator enumerator = modules.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					string text = ((ProcessModule)enumerator.Current).ModuleName.ToLower();
					if (text == string_)
					{
						return Class14.String_77;
					}
					if (text == string_2)
					{
						return Class14.String_125;
					}
				}
			}*/
            foreach (ProcessModule pm in modules)
            {
                string text = pm.ModuleName.ToLower();
                if (text == string_)
                {
                    return Class14.String_77;
                }
                if (text == string_2)
                {
                    return Class14.String_125;
                }
            }
            return Class14.String_94;
		}
		catch (Win32Exception)
		{
			this.method_48();
		}
		catch (Exception ex)
		{
			this.method_7(GEnum22.const_31, ex.ToString());
		}
		return Class14.String_215;
	}

	// Token: 0x060005FB RID: 1531 RVA: 0x000579D4 File Offset: 0x00055BD4
	public long method_9(Process process_1)
	{
		long num = 0L;
		if (process_1 != null && !process_1.HasExited)
		{
			List<GClass52> list = new List<GClass52>();
			byte[] byte_ = Class14.Byte_32;
			string string_ = Class14.String_139;
			GClass53 gclass = new GClass53(byte_, string_, new int[] { 11, 19 });
			GClass52 gclass2 = new GClass52(Class14.String_3, Class15.smethod_7(Path.Combine(this.gclass51_0.String_2, Class14.String_3)), new List<GClass53> { gclass }, false);
			list.Add(gclass2);
			byte[] byte_2 = Class14.Byte_53;
			string string_2 = Class14.String_190;
			GClass53 gclass3 = new GClass53(byte_2, string_2, new int[] { 42, 48 });
			GClass52 gclass4 = new GClass52(Class14.String_126, Class15.smethod_7(Path.Combine(this.gclass51_0.String_2, Class14.String_126)), new List<GClass53> { gclass3 }, false);
			list.Add(gclass4);
			return this.method_10(process_1, list);
		}
		return num;
	}

	// Token: 0x060005FC RID: 1532 RVA: 0x00057ACC File Offset: 0x00055CCC
	public long method_10(Process process_1, List<GClass52> list_0)
	{
		long num = 0L;
		IntPtr intPtr = IntPtr.Zero;
		uint num2 = 240U;
		try
		{
			GClass45.GStruct5 gstruct = default(GClass45.GStruct5);
			uint num3 = gstruct.uint_1;
			if (num3 == 0U)
			{
				num3 = 4096U;
			}
			uint num4 = num3;
			byte[] array = new byte[8];
			byte[] array2 = new byte[num4];
			GClass45.GStruct4 gstruct2 = default(GClass45.GStruct4);
			int num5 = Marshal.SizeOf(gstruct2);
			intPtr = GClass45.OpenProcess(1040, false, process_1.Id);
			if (intPtr != IntPtr.Zero)
			{
				int num6 = 0;
				while (num6 < list_0.Count && !this.method_47())
				{
					GClass52 gclass = list_0[num6];
					ProcessModule processModule = GClass49.smethod_5(process_1, gclass.String_0, gclass.String_1, GClass49.GEnum43.const_3);
					if (processModule != null)
					{
						try
						{
							int num7 = gclass.method_0();
							IntPtr intPtr2 = processModule.BaseAddress;
							IntPtr intPtr3 = (IntPtr)(processModule.BaseAddress.ToInt64() + (long)processModule.ModuleMemorySize);
							bool flag = false;
							while (!this.method_47() && !flag && intPtr2.ToInt64() < intPtr3.ToInt64() && GClass45.VirtualQueryEx(intPtr, intPtr2, out gstruct2, num5) > 0)
							{
								IntPtr intPtr4 = (IntPtr)(intPtr2.ToInt64() + gstruct2.intptr_2.ToInt64());
								if (((gstruct2.uint_0 & num2) != 0U || (gstruct2.uint_2 & num2) != 0U) && GClass49.smethod_9(gstruct2))
								{
									IntPtr intPtr5 = intPtr2;
									IntPtr intPtr6 = intPtr5;
									num4 = num3;
									do
									{
										if (intPtr5.ToInt64() + (long)((ulong)num4) > intPtr4.ToInt64())
										{
											num4 = (uint)(intPtr4.ToInt64() - intPtr5.ToInt64());
											Array.Clear(array2, 0, array2.Length);
										}
										uint num8 = 0;
										if (!GClass45.ReadProcessMemory(intPtr, intPtr5, array2, num4, ref num8) || num8 != num4)
										{
											break;
										}
										int num9 = 0;
										while (num9 < gclass.List_0.Count && !this.method_47())
										{
											GClass53 gclass2 = gclass.List_0[num9];
											int num10 = 0;
											do
											{
												num10 = Class15.smethod_23(array2, gclass2.Byte_0, gclass2.String_0, num10, 0);
												if (num10 == -1)
												{
													break;
												}
												int num11 = num10 + gclass2.Int32_0[0];
												uint num12;
												IntPtr intPtr7;
												if (!gclass.Boolean_0)
												{
													num12 = 4U;
													if ((long)num11 + 4L >= (long)((ulong)num4))
													{
														break;
													}
													intPtr7 = (IntPtr)((long)((ulong)BitConverter.ToUInt32(array2, num11)));
												}
												else
												{
													num12 = 8U;
													if ((long)(num11 + 4) >= (long)((ulong)num4))
													{
														break;
													}
													intPtr7 = (IntPtr)(intPtr5.ToInt64() + (long)num11 + 4L + (long)((ulong)BitConverter.ToUInt32(array2, num11)));
												}
												if (intPtr7.ToInt64() >= processModule.BaseAddress.ToInt64() && intPtr7.ToInt64() < intPtr3.ToInt64())
												{
													if (GClass45.ReadProcessMemory(intPtr, intPtr7, array, num12, ref num8))
													{
														if (num8 == num12)
														{
															if (!gclass.Boolean_0)
															{
																int num13 = BitConverter.ToInt32(array, 0);
																num11 = num10 + gclass2.Int32_0[1];
																if ((long)num11 + (long)((ulong)num12) >= (long)((ulong)num4))
																{
																	break;
																}
																IntPtr intPtr8 = (IntPtr)((long)((ulong)BitConverter.ToUInt32(array2, num11)));
																if (intPtr8.ToInt64() < processModule.BaseAddress.ToInt64() || intPtr8.ToInt64() >= intPtr3.ToInt64())
																{
																	num10 += list_0[num6].List_0[num9].Byte_0.Length;
																	goto IL_39D;
																}
																if (!GClass45.ReadProcessMemory(intPtr, intPtr8, array, num12, ref num8) || num8 != num12)
																{
																	num10 += gclass2.Byte_0.Length;
																	goto IL_39D;
																}
																long num14 = (long)BitConverter.ToInt32(array, 0);
																num = 0L;
																num = (num14 << 32) + (long)num13;
															}
															else
															{
																num = BitConverter.ToInt64(array, 0);
															}
															if (!Class15.smethod_25(num))
															{
																num10 += gclass2.Byte_0.Length;
																goto IL_39D;
															}
															goto IL_3D0;
														}
													}
													num10 += gclass2.Byte_0.Length;
												}
												else
												{
													num10 += list_0[num6].List_0[num9].Byte_0.Length;
												}
												IL_39D:
												if (num10 == -1)
												{
													break;
												}
											}
											while (!this.method_47());
											IL_3D3:
											if (!flag)
											{
												num9++;
												continue;
											}
											break;
											goto IL_3D3;
											IL_3D0:
											flag = true;
											goto IL_3D3;
										}
										if (flag)
										{
											break;
										}
										intPtr6 = (IntPtr)(intPtr6.ToInt64() + (long)((ulong)num4));
										intPtr5 = (IntPtr)(intPtr6.ToInt64() - (long)num7);
										if ((ulong)num4 == (ulong)((long)num7))
										{
											break;
										}
									}
									while (intPtr5.ToInt64() < intPtr4.ToInt64());
									IL_470:
									if (!flag)
									{
										intPtr2 = intPtr4;
										continue;
									}
									break;
									goto IL_470;
								}
								intPtr2 = intPtr4;
							}
							if (flag)
							{
								break;
							}
						}
						catch (Exception ex)
						{
							this.method_7(GEnum22.const_11, ex.ToString());
						}
					}
					num6++;
				}
			}
		}
		catch (Exception ex2)
		{
			this.method_7(GEnum22.const_12, ex2.ToString());
		}
		finally
		{
			if (intPtr != IntPtr.Zero)
			{
				GClass45.CloseHandle(intPtr);
			}
		}
		return num;
	}

	// Token: 0x060005FD RID: 1533 RVA: 0x00058000 File Offset: 0x00056200
	private Process method_11()
	{
		try
		{
			string string_ = Class14.String_22;
			Process[] array = null;
			int num = 0;
			do
			{
				Process process = array[num];
				try
				{
					string directoryName = Path.GetDirectoryName(process.MainModule.FileName);
					if (Directory.Exists(Path.Combine(directoryName, string_)))
					{
						string text = null;
						if (Directory.Exists(Path.Combine(directoryName, text)))
						{
							return process;
						}
					}
				}
				catch
				{
				}
				num++;
			}
			while (num < array.Length);
		}
		catch
		{
		}
		return null;
	}

	// Token: 0x060005FE RID: 1534 RVA: 0x00058088 File Offset: 0x00056288
	private void method_12()
	{
		try
		{
			Process process = this.method_11();
			if (process != null && this.gclass51_0.String_2.ToLower().Contains(Class14.String_155))
			{
				try
				{
					this.gclass51_0.String_3 = Path.GetDirectoryName(process.MainModule.FileName);
					this.gclass51_0.long_2 = this.method_5(GEnum21.const_0, GEnum48.const_3, process.MainModule.FileName, null, GEnum51.const_2);
				}
				catch
				{
				}
				string text = this.method_13();
				if (text == null)
				{
					string directoryName = Path.GetDirectoryName(process.MainModule.FileName);
					text = this.method_14(Path.Combine(directoryName, Class14.String_214));
					if (text == null)
					{
						long num = this.method_9(this.process_0);
						if (num == 0L)
						{
							this.gclass51_0.GEnum23_0 |= GEnum23.const_3;
						}
						else
						{
							text = WCD.smethod_0(num);
						}
						if (text == null)
						{
							this.gclass51_0.String_5 = Class14.String_161;
						}
						else
						{
							this.gclass51_0.String_5 = Class14.String_236 + text;
						}
					}
					else
					{
						this.gclass51_0.String_5 = Class14.String_236 + text;
					}
				}
				else
				{
					this.gclass51_0.String_5 = Class14.String_236 + text;
				}
			}
			else
			{
				this.gclass51_0.String_5 = Class14.String_161;
			}
		}
		catch
		{
			this.gclass51_0.String_5 = Class14.String_161;
		}
	}

	// Token: 0x060005FF RID: 1535 RVA: 0x00058224 File Offset: 0x00056424
	private string method_13()
	{
		try
		{
			uint num = 0U;
			if (GClass50.smethod_8(Registry.CurrentUser, Class14.String_178, Class14.String_82, out num) && num > 0U)
			{
				long num2 = Convert.ToInt64(num) + 76561197960265728L;
				if (num2 > 0L)
				{
					return WCD.smethod_0(num2);
				}
			}
		}
		catch
		{
		}
		return null;
	}

	// Token: 0x06000600 RID: 1536 RVA: 0x00058290 File Offset: 0x00056490
	private string method_14(string string_6)
	{
		FileStream fileStream = null;
		StreamReader streamReader = null;
		try
		{
			if (!File.Exists(string_6))
			{
				return null;
			}
			try
			{
				fileStream = new FileStream(string_6, FileMode.Open, FileAccess.Read, FileShare.Read);
			}
			catch
			{
				fileStream = new FileStream(string_6, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
			}
			streamReader = new StreamReader(fileStream);
			if (streamReader == null)
			{
				return null;
			}
			int num = -1;
			string string_7 = Class14.String_29;
			string text;
			while ((text = streamReader.ReadLine()) != null)
			{
				text = text.Trim();
				num = text.IndexOf(string_7);
				if (num > -1)
				{
					num += string_7.Length;
					break;
				}
			}
			if (text != null && num > -1)
			{
				text = text.Trim();
				num = text.IndexOf("\"", num);
				if (num > -1)
				{
					num++;
					int num2 = text.IndexOf("\"", num);
					if (num2 > -1)
					{
						long num3 = Convert.ToInt64(text.Substring(num, num2 - num));
						if (num3 >= 0L)
						{
							return WCD.smethod_0(num3);
						}
					}
				}
			}
		}
		catch (Exception ex)
		{
			this.method_7(GEnum22.const_15, ex.ToString());
		}
		finally
		{
			if (fileStream != null)
			{
				try
				{
					fileStream.Close();
				}
				catch
				{
				}
			}
			if (streamReader != null)
			{
				try
				{
					streamReader.Close();
				}
				catch
				{
				}
			}
		}
		return null;
	}

	// Token: 0x06000601 RID: 1537 RVA: 0x000583E8 File Offset: 0x000565E8
	private static string smethod_0(long long_0)
	{
		try
		{
			long_0 -= 76561197960265728L;
			long num = long_0 % 2L;
			long_0 -= num;
			long num2 = long_0 / 2L;
			return string.Format("STEAM_0:{0}:{1}", num, num2);
		}
		catch
		{
		}
		return null;
	}

	// Token: 0x06000602 RID: 1538 RVA: 0x00058450 File Offset: 0x00056650
	private static string smethod_1()
	{
		string[] array = new string[]
		{
			"http://checkip.dyndns.org", "http://ipv4bot.whatismyipaddress.com", "https://api.ipify.org", "https://ipv4.wtfismyip.com/text", "https://ipinfo.io", "https://ipv4.adresameaip.ro/ip", "http://www.ip-adress.eu", "http://whatismyip.host", "http://www.adresa-mea.ro", "https://ip4.seeip.org/",
			"https://ipapi.co/ip/"
		};
		int num = 0;
		do
		{
			string text = array[num];
			try
			{
				string text2 = WCD.smethod_2(text);
				if (Class15.smethod_24(text2))
				{
					return text2;
				}
			}
			catch
			{
			}
			num++;
		}
		while (num < array.Length);
		return string.Format("{0}.{1}.{2}.{3}", new object[]
		{
			Class14.String_215,
			Class14.String_215,
			Class14.String_215,
			Class14.String_215
		});
	}

	// Token: 0x06000603 RID: 1539 RVA: 0x0005852C File Offset: 0x0005672C
	private static string smethod_2(string string_6)
	{
		WebResponse webResponse = null;
		try
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(string_6);
			httpWebRequest.Proxy = null;
			httpWebRequest.Timeout = Class15.int_0;
			httpWebRequest.Method = "GET";
			webResponse = httpWebRequest.GetResponse();
			using (StreamReader streamReader = new StreamReader(webResponse.GetResponseStream()))
			{
				Match match = WCD.regex_0.Match(streamReader.ReadToEnd());
				if (match.Success)
				{
					return match.ToString();
				}
			}
		}
		catch
		{
		}
		finally
		{
			if (webResponse != null)
			{
				try
				{
					webResponse.Close();
				}
				catch
				{
				}
			}
		}
		return null;
	}

	// Token: 0x06000604 RID: 1540 RVA: 0x000585F0 File Offset: 0x000567F0
	private string method_15(byte[] byte_2)
	{
		string text = null;
		if (byte_2 != null && byte_2.Length >= 1)
		{
			string text3;
			try
			{
				string text2 = Encoding.UTF8.GetString(byte_2, 0, byte_2.Length).TrimEnd(new char[1]);
				if (text2.Length >= 1 && text2[0] == '\\')
				{
					string string_ = Class14.String_213;
					string[] array = text2.Split(new char[] { '\\' });
					if (array.Length != 0)
					{
						for (int i = 1; i < array.Length; i += 2)
						{
							if (array[i].ToLower() == string_ && i + 1 < array.Length)
							{
								text = array[i + 1];
								int num = text.IndexOf('\0');
								if (num > 0)
								{
									text = text.Substring(0, num);
								}
								text = text.Trim();
								break;
							}
						}
					}
					return text;
				}
				text3 = text;
			}
			catch (Exception ex)
			{
				this.method_7(GEnum22.const_13, ex.ToString());
				return text;
			}
			return text3;
		}
		return text;
	}

	// Token: 0x06000605 RID: 1541 RVA: 0x000586E0 File Offset: 0x000568E0
	public string method_16()
	{
		IntPtr intPtr = IntPtr.Zero;
		if (this.process_0 != null && !this.method_47())
		{
			GClass45.GStruct4 gstruct = default(GClass45.GStruct4);
			GClass45.GStruct5 gstruct2 = default(GClass45.GStruct5);
			GClass45.GetSystemInfo(ref gstruct2);
			uint num = 0U;
			List<GClass52> list = new List<GClass52>();
			try
			{
				List<GClass53> list2 = new List<GClass53>
				{
					new GClass53(Class14.Byte_46, Class14.String_188, Class14.int_73),
					new GClass53(Class14.Byte_12, Class14.String_23, Class14.int_255),
					new GClass53(Class14.Byte_29, Class14.String_204, Class14.int_121),
					new GClass53(Class14.Byte_45, Class14.String_123, Class14.int_105),
					new GClass53(Class14.Byte_15, Class14.String_239, Class14.int_279)
				};
				GClass52 gclass = new GClass52(Class14.String_235, Class15.smethod_7(Path.Combine(this.gclass51_0.String_2, Class14.String_235)), list2, false);
				list.Add(gclass);
				GClass52 gclass2 = new GClass52(Class14.String_116, Class15.smethod_7(Path.Combine(this.gclass51_0.String_2, Class14.String_116)), list2, false);
				list.Add(gclass2);
				GClass52 gclass3 = new GClass52(this.process_0.MainModule.ModuleName, this.process_0.MainModule.FileName, list2, false);
				list.Add(gclass3);
				uint num2 = 244U;
				IntPtr intPtr2 = IntPtr.Zero;
				byte[] array = new byte[4096];
				Array.Clear(array, 0, array.Length);
				uint num3 = gstruct2.uint_1;
				if (num3 == 0U)
				{
					num3 = 4096U;
				}
				uint num4 = num3;
				byte[] array2 = new byte[num4];
				intPtr = GClass45.OpenProcess(1040, false, this.process_0.Id);
				if (intPtr != IntPtr.Zero)
				{
					int num5 = 0;
					while (num5 < list.Count && !this.method_47())
					{
						GClass52 gclass4 = list[num5];
						ProcessModule processModule = GClass49.smethod_5(this.process_0, gclass4.String_0, gclass4.String_1, GClass49.GEnum43.const_3);
						if (processModule != null)
						{
							int num6 = gclass4.method_0();
							IntPtr intPtr3 = processModule.BaseAddress;
							IntPtr intPtr4 = (IntPtr)(processModule.BaseAddress.ToInt64() + (long)processModule.ModuleMemorySize);
							try
							{
								while (!this.method_47() && intPtr3.ToInt64() < intPtr4.ToInt64() && GClass45.VirtualQueryEx(intPtr, intPtr3, out gstruct, Marshal.SizeOf(gstruct)) > 0)
								{
									IntPtr intPtr5 = (IntPtr)(intPtr3.ToInt64() + gstruct.intptr_2.ToInt64());
									if ((gstruct.uint_2 & num2) != 0U && GClass49.smethod_9(gstruct))
									{
										IntPtr intPtr6 = intPtr3;
										IntPtr intPtr7 = intPtr6;
										num4 = num3;
										string text;
										do
										{
											if (intPtr6.ToInt64() + (long)((ulong)num4) > intPtr5.ToInt64())
											{
												num4 = (uint)(intPtr5.ToInt64() - intPtr6.ToInt64());
												Array.Clear(array2, 0, array2.Length);
											}
											if (!GClass45.ReadProcessMemory(intPtr, intPtr6, array2, num4, ref num) || num != num4)
											{
												break;
											}
											int num7 = 0;
											while (num7 < gclass4.List_0.Count && !this.method_47())
											{
												GClass53 gclass5 = gclass4.List_0[num7];
												int num8 = 0;
												do
												{
													num8 = Class15.smethod_23(array2, gclass5.Byte_0, gclass5.String_0, num8, 0);
													if (num8 > -1)
													{
														int num9 = num8 + gclass5.Int32_0[0];
														if ((long)(num9 + 4) >= (long)((ulong)num4))
														{
															break;
														}
														intPtr2 = (IntPtr)((long)((ulong)BitConverter.ToUInt32(array2, num9)));
														if (intPtr2.ToInt64() >= processModule.BaseAddress.ToInt64() && intPtr2.ToInt64() < intPtr4.ToInt64())
														{
															if (!GClass45.ReadProcessMemory(intPtr, intPtr2, array, (uint)array.Length, ref num) || num <= 0U)
															{
																break;
															}
															text = this.method_15(array);
															if (text != null)
															{
																goto IL_47D;
															}
															Array.Clear(array, 0, array.Length);
														}
														num8 += gclass5.Byte_0.Length;
													}
												}
												while (num8 > -1 && !this.method_47());
												num7++;
											}
											intPtr7 = (IntPtr)(intPtr7.ToInt64() + (long)((ulong)num4));
											intPtr6 = (IntPtr)(intPtr7.ToInt64() - (long)num6);
										}
										while ((ulong)num4 != (ulong)((long)num6) && intPtr6.ToInt64() < intPtr5.ToInt64() && !this.method_47());
										intPtr3 = intPtr5;
										continue;
										IL_47D:
										return text;
									}
									intPtr3 = intPtr5;
								}
							}
							catch (Exception ex)
							{
								this.method_7(GEnum22.const_34, ex.ToString());
							}
						}
						num5++;
					}
				}
			}
			catch (Exception ex2)
			{
				this.method_7(GEnum22.const_35, ex2.ToString());
			}
			finally
			{
				if (intPtr != IntPtr.Zero)
				{
					GClass45.CloseHandle(intPtr);
				}
			}
			return null;
		}
		return null;
	}

	// Token: 0x06000606 RID: 1542 RVA: 0x00058C0C File Offset: 0x00056E0C
	private string method_17()
	{
		string text = this.method_16();
		if (text != null)
		{
			return text;
		}
		this.gclass51_0.GEnum23_0 |= GEnum23.const_1;
		text = this.method_19();
		if (text != null)
		{
			return text;
		}
		text = GClass50.smethod_6(Registry.CurrentUser, Class14.String_146, Class14.String_20);
		if (text == null)
		{
			return Class14.String_215;
		}
		return text;
	}

	// Token: 0x06000607 RID: 1543 RVA: 0x00058C64 File Offset: 0x00056E64
	private string method_18(string string_6)
	{
		int num = string_6.IndexOf('"');
		if (num != -1 && num <= 0)
		{
			int num2 = string_6.IndexOf('"', num + 1);
			if (num2 == 0)
			{
				return null;
			}
			if (num2 > 0)
			{
				num++;
				num2 -= num;
				if (num2 > 0 && num + num2 < string_6.Length)
				{
					string_6 = string_6.Substring(num, num2);
				}
			}
		}
		else
		{
			int num3 = string_6.IndexOf(' ');
			if (num3 == -1)
			{
				if (num > 0)
				{
					string_6 = string_6.Substring(0, num);
				}
			}
			else if (num != -1)
			{
				int num2 = num3 - num;
				if (num2 > 0 && num + num2 < string_6.Length)
				{
					string_6 = string_6.Substring(num, num2);
				}
			}
			else
			{
				string_6 = string_6.Substring(0, num3);
			}
		}
		return string_6;
	}

	// Token: 0x06000608 RID: 1544 RVA: 0x00058D08 File Offset: 0x00056F08
	private string method_19()
	{
		string text = null;
		FileStream fileStream = null;
		try
		{
			string text2 = Path.Combine(this.gclass51_0.String_2, Class14.String_66);
			if (!File.Exists(text2))
			{
				return text;
			}
			try
			{
				fileStream = new FileStream(text2, FileMode.Open, FileAccess.Read, FileShare.Read);
			}
			catch
			{
				fileStream = new FileStream(text2, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
			}
			using (StreamReader streamReader = new StreamReader(fileStream))
			{
				bool flag = false;
				string string_ = Class14.String_213;
				string text3;
				while ((text3 = streamReader.ReadLine()) != null && !this.method_47())
				{
					bool flag2 = false;
					if (text3.Contains("/*") && !flag)
					{
						flag = true;
					}
					if (text3.Contains("*/") && flag)
					{
						flag = false;
					}
					if (!flag)
					{
						for (int i = 0; i < text3.Length - 1; i++)
						{
							if (text3[i] == '/')
							{
								if (text3[i + 1] == '/')
								{
									flag2 = true;
									IL_D6:
									if (flag2 && i > 0)
									{
										flag2 = false;
										text3 = text3.Substring(0, i);
										goto IL_EE;
									}
									goto IL_EE;
								}
							}
						}
						//goto IL_D6;
					}
					IL_EE:
					if (!flag && !flag2 && text3.Length > string_.Length + 2)
					{
						int num = text3.IndexOf(string_);
						if (num != -1)
						{
							if (num == 0)
							{
								text = text3.Substring(string_.Length);
								text = text.Trim(new char[] { ' ' });
								text = this.method_18(text);
								break;
							}
							if (--num >= 0 && num + 1 + string_.Length < text3.Length)
							{
								if (text3[num] != ' ')
								{
									if (text3[num] != ';')
									{
										if (text3[num] != '"')
										{
											continue;
										}
									}
								}
								text = text3.Substring(num + 1 + string_.Length);
								text = text.Trim(new char[] { ' ' });
								text = this.method_18(text);
								break;
							}
						}
					}
				}
			}
		}
		catch (Exception ex)
		{
			this.method_7(GEnum22.const_14, ex.ToString());
		}
		finally
		{
			if (fileStream != null)
			{
				try
				{
					fileStream.Close();
				}
				catch
				{
				}
			}
		}
		return text;
	}

	// Token: 0x06000609 RID: 1545 RVA: 0x00058F9C File Offset: 0x0005719C
	private Process method_20(string string_6)
	{
		if (string_6 == null)
		{
			return null;
		}
		try
		{
			Process[] processesByName = Process.GetProcessesByName(string_6);
			if (processesByName.Length == 0)
			{
				return null;
			}
			string string_7 = Class14.String_83;
			string string_8 = Class14.String_164;
			string string_9 = Class14.String_185;
			foreach (Process process in processesByName)
			{
				try
				{
					string directoryName = Path.GetDirectoryName(process.MainModule.FileName);
					if (Directory.Exists(Path.Combine(directoryName, string_7)))
					{
						if (Directory.Exists(Path.Combine(directoryName, string_8)))
						{
							if (Directory.Exists(Path.Combine(directoryName, string_9)))
							{
								if (GClass49.smethod_18(process))
								{
									return process;
								}
							}
						}
					}
				}
				catch
				{
				}
			}
		}
		catch
		{
		}
		return null;
	}

	// Token: 0x0600060A RID: 1546 RVA: 0x00059070 File Offset: 0x00057270
	private int method_21()
	{
		WCD.Class20 @class = new WCD.Class20();
		@class.wcd_0 = this;
		Stopwatch stopwatch = new Stopwatch();
		stopwatch.Start();
		@class.process_0 = this.method_20(Class14.String_80);
		if (@class.process_0 == null)
		{
			@class.process_0 = this.method_20(Class14.String_83);
			if (@class.process_0 == null)
			{
				stopwatch.Stop();
				return 1;
			}
			this.string_5 = Class14.String_83;
		}
		else
		{
			this.string_5 = Class14.String_80;
		}
		int num;
		try
		{
			@class.process_0.EnableRaisingEvents = true;
			@class.process_0.Exited += this.method_50;
			goto IL_A0;
		}
		catch
		{
			stopwatch.Stop();
			num = 2;
		}
		return num;
		IL_A0:
		if (@class.process_0.HasExited)
		{
			stopwatch.Stop();
			return 2;
		}
		stopwatch.Stop();
		this.method_0(GEnum49.const_6, stopwatch);
		stopwatch.Reset();
		stopwatch.Start();
		this.gclass51_0.String_8 = this.method_70();
		if (this.gclass51_0.String_8 == null)
		{
			stopwatch.Stop();
			return 4;
		}
		stopwatch.Stop();
		this.method_0(GEnum49.const_36, stopwatch);
		stopwatch.Reset();
		base.Invoke(new MethodInvoker(@class.method_0));
		stopwatch.Start();
		this.process_0 = @class.process_0;
		this.gclass51_0.DateTime_0 = @class.process_0.StartTime;
		this.gclass51_0.Boolean_0 = GClass49.smethod_25(@class.process_0.Id);
		this.gclass51_0.String_2 = Path.GetDirectoryName(@class.process_0.MainModule.FileName);
		this.gclass51_0.String_7 = this.method_8(@class.process_0);
		this.gclass51_0.String_9 = Class15.smethod_22(@class.process_0.MainWindowTitle);
		this.method_2();
		stopwatch.Stop();
		this.method_0(GEnum49.const_7, stopwatch);
		stopwatch.Reset();
		if (@class.process_0.HasExited || this.method_47())
		{
			return 2;
		}
		stopwatch.Start();
		this.method_25(@class.process_0, GEnum23.const_19);
		stopwatch.Stop();
		this.method_0(GEnum49.const_10, stopwatch);
		stopwatch.Reset();
		stopwatch.Start();
		try
		{
			StringBuilder stringBuilder = new StringBuilder(256);
			if (GClass45.GetClassName(@class.process_0.MainWindowHandle, stringBuilder, stringBuilder.Capacity) > 0)
			{
				string text = stringBuilder.ToString().Trim();
				if (text.Length > 0)
				{
					this.gclass51_0.String_10 = Class15.smethod_22(text);
				}
			}
		}
		catch
		{
		}
		try
		{
			if (@class.process_0.MainWindowHandle != IntPtr.Zero)
			{
				GClass45.GDelegate0 gdelegate = new GClass45.GDelegate0(this.method_26);
				GClass45.EnumChildWindows(@class.process_0.MainWindowHandle, gdelegate, 0);
			}
		}
		catch
		{
		}
		try
		{
			GClass45.EnumWindows(new GClass45.GDelegate1(this.method_27), 0);
		}
		catch
		{
		}
		stopwatch.Stop();
		this.method_0(GEnum49.const_38, stopwatch);
		stopwatch.Reset();
		Thread thread = new Thread(new ThreadStart(@class.method_1));
		thread.IsBackground = true;
		thread.Priority = ThreadPriority.Normal;
		thread.SetApartmentState(ApartmentState.STA);
		thread.Start();
		Thread thread2 = new Thread(new ThreadStart(@class.method_2));
		thread2.IsBackground = true;
		thread2.Priority = ThreadPriority.Normal;
		thread2.SetApartmentState(ApartmentState.STA);
		thread2.Start();
		Thread thread3 = new Thread(new ThreadStart(@class.method_3));
		thread3.IsBackground = true;
		thread3.Priority = ThreadPriority.Normal;
		thread3.SetApartmentState(ApartmentState.STA);
		thread3.Start();
		stopwatch.Start();
		if (!this.method_63(@class.process_0, false))
		{
			stopwatch.Stop();
			this.method_48();
			thread.Join();
			thread2.Join();
			thread3.Join();
			return 3;
		}
		this.method_69();
		stopwatch.Stop();
		this.method_0(GEnum49.const_8, stopwatch);
		stopwatch.Reset();
		thread.Join();
		thread2.Join();
		thread3.Join();
		if (this.method_47())
		{
			return 3;
		}
		stopwatch.Start();
		try
		{
			foreach (GClass44 gclass in this.gclass43_0.method_3(true))
			{
				this.method_6(gclass);
			}
		}
		catch (Exception ex)
		{
			this.method_7(GEnum22.const_41, ex.ToString());
		}
		stopwatch.Stop();
		this.method_0(GEnum49.const_37, stopwatch);
		stopwatch.Reset();
		if (this.method_47())
		{
			return 3;
		}
		stopwatch.Start();
		this.method_44();
		this.method_69();
		stopwatch.Stop();
		this.method_0(GEnum49.const_11, stopwatch);
		stopwatch.Reset();
		if (this.method_47())
		{
			return 3;
		}
		stopwatch.Start();
		this.method_42(this.process_0);
		this.method_69();
		stopwatch.Stop();
		this.method_0(GEnum49.const_13, stopwatch);
		stopwatch.Reset();
		if (this.method_47())
		{
			return 3;
		}
		stopwatch.Start();
		this.method_25(@class.process_0, GEnum23.const_20);
		stopwatch.Stop();
		this.method_0(GEnum49.const_9, stopwatch);
		if (this.method_47())
		{
			return 3;
		}
		if (!@class.process_0.HasExited)
		{
			this.gclass51_0.bool_1 = @class.process_0.Responding;
			return 0;
		}
		return 2;
	}

	// Token: 0x0600060B RID: 1547 RVA: 0x000595C8 File Offset: 0x000577C8
	public bool method_22(string string_6, string string_7 = null, string[] string_8 = null)
	{
		IntPtr intPtr = IntPtr.Zero;
		GEnum48 genum = GEnum48.const_0;
		bool flag = false;
		if (string_6 == null)
		{
			return flag;
		}
		Process currentProcess = Process.GetCurrentProcess();
		ProcessModule processModule = GClass49.smethod_5(currentProcess, string_6, string_7, GClass49.GEnum43.const_1);
		if (processModule == null)
		{
			return flag;
		}
		try
		{
			intPtr = GClass45.OpenProcess(1040, false, currentProcess.Id);
			if (intPtr == IntPtr.Zero)
			{
				return flag;
			}
			GClass14[] array = new GClass17(intPtr, processModule.BaseAddress, GEnum15.const_2).GClass14_0;
			if (array == null)
			{
				throw new Exception(Class14.String_112);
			}
			int i;
			if (string_8 != null)
			{
				List<GClass14> list = new List<GClass14>();
				for (i = 0; i < string_8.Length; i++)
				{
					string text = string_8[i].ToLowerInvariant();
					foreach (GClass14 gclass in array)
					{
						if (gclass.String_0 != null && gclass.String_0.ToLowerInvariant() == text)
						{
							list.Add(gclass);
							break;
						}
					}
				}
				array = list.ToArray();
			}
			long num = processModule.BaseAddress.ToInt64();
			long num2 = processModule.BaseAddress.ToInt64() + (long)processModule.ModuleMemorySize;
			long num3 = 0L;
			GClass14[] array2 = array;
			i = 0;
			while (i < array2.Length)
			{
				GClass14 gclass2 = array2[i];
				try
				{
					num3 = (long)((ulong)gclass2.UInt32_0 + (ulong)num);
					goto IL_278;
				}
				catch
				{
					num3 = (long)((ulong)gclass2.UInt32_0);
					goto IL_278;
				}
				goto IL_162;
				IL_26D:
				i++;
				continue;
				IL_162:
				if (num3 < num2)
				{
					goto IL_26D;
				}
				IL_16B:
				string text2 = GClass49.smethod_2(currentProcess, (IntPtr)((long)((ulong)gclass2.UInt32_0)));
				if (text2 == null)
				{
					text2 = GClass45.smethod_7(intPtr, (IntPtr)((long)((ulong)gclass2.UInt32_0)));
					if (text2 == null)
					{
						text2 = string.Empty;
					}
					genum = GEnum48.const_4;
				}
				genum |= GEnum48.const_5;
				string text3 = GClass49.smethod_19(currentProcess, (IntPtr)((long)((ulong)gclass2.UInt32_0)));
				GClass41 gclass3 = this.method_4(GEnum21.const_11, string.Concat(new string[]
				{
					string_6,
					"_",
					gclass2.String_0 ?? Class14.String_208,
					":",
					gclass2.UInt32_0.ToString("X8"),
					"_",
					text3
				}), -1, -1L, GEnum23.const_23);
				long num4;
				if (text2 != null && text2.Length > 0)
				{
					num4 = this.method_5(gclass3.GEnum21_0, genum, text2, null, GEnum51.const_2);
				}
				else
				{
					num4 = -1L;
				}
				gclass3.Int64_0 = num4;
				goto IL_26D;
				IL_278:
				if (num3 >= num)
				{
					goto IL_162;
				}
				goto IL_16B;
			}
			flag = true;
		}
		catch
		{
			this.gclass51_0.GEnum23_0 |= GEnum23.const_24;
		}
		finally
		{
			if (intPtr != IntPtr.Zero)
			{
				GClass45.CloseHandle(intPtr);
			}
		}
		return flag;
	}

	// Token: 0x0600060C RID: 1548 RVA: 0x000598F0 File Offset: 0x00057AF0
	private void method_23()
	{
		Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>
		{
			{
				Class14.String_132,
				new List<string>
				{
					Class14.String_138,
					Class14.String_157,
					Class14.String_147,
					Class14.String_12
				}
			},
			{
				Class14.String_30,
				new List<string>
				{
					Class14.String_138,
					Class14.String_157,
					Class14.String_147,
					Class14.String_12
				}
			}
		};
		try
		{
			Process currentProcess = Process.GetCurrentProcess();
			uint num = 0U;
			uint num2 = 10U;
			foreach (KeyValuePair<string, List<string>> keyValuePair in dictionary)
			{
				IntPtr moduleHandle = GClass45.GetModuleHandle(keyValuePair.Key);
				ProcessModule processModule = GClass49.smethod_3(currentProcess, keyValuePair.Key);
				if (processModule != null && !(moduleHandle != processModule.BaseAddress) && !(moduleHandle == IntPtr.Zero))
				{
					long num3 = processModule.BaseAddress.ToInt64();
					long num4 = num3 + (long)processModule.ModuleMemorySize;
					using (List<string>.Enumerator enumerator2 = keyValuePair.Value.GetEnumerator())
					{
						while (enumerator2.MoveNext())
						{
							string text = enumerator2.Current;
							IntPtr procAddress = GClass45.GetProcAddress(moduleHandle, text);
							if (!(procAddress == IntPtr.Zero))
							{
								long num5 = procAddress.ToInt64();
								if (num5 >= num3 && num5 <= num4)
								{
									byte[] array = null;
									if (GClass45.ReadProcessMemory(currentProcess.Handle, procAddress, array, num2, ref num) && num2 == num)
									{
										byte[] array2 = null;
										if (GClass45.NtReadVirtualMemory(currentProcess.Handle, procAddress, array2, num2, ref num) == 0U)
										{
											if (num2 == num)
											{
												byte b = Marshal.ReadByte(procAddress);
												if (array[0] != 233 && array[0] != 232 && array[0] != 0)
												{
													if (b == array[0])
													{
														int num6 = 0;
														if (Class15.smethod_26(array, array2, (int)num2, ref num6) == 0)
														{
															continue;
														}
													}
												}
												long num7 = -1L;
												string text2 = "";
												if (text2 == "")
												{
													text2 = Class15.smethod_14(array);
												}
												GClass41 gclass = this.method_4(GEnum21.const_2, string.Concat(new string[] { keyValuePair.Key, "_", text, "_", text2 }), -1, -1L, GEnum23.const_5);
												if (array[0] != 0)
												{
													IntPtr intPtr = (IntPtr)BitConverter.ToInt32(array, 1);
													string text3 = GClass45.smethod_7(currentProcess.Handle, intPtr);
													if (text3 != null && text3.Length != 0)
													{
														text2 = GClass49.smethod_19(currentProcess, intPtr);
														if (!GClass49.smethod_21(text3))
														{
															num7 = this.method_5(gclass.GEnum21_0, GEnum48.const_4, text3.ToString(), null, GEnum51.const_2);
														}
														else
														{
															num7 = -1L;
														}
													}
													else
													{
														num7 = -1L;
													}
												}
												gclass.Int64_0 = num7;
												this.gclass51_0.GEnum23_0 |= GEnum23.const_5;
												continue;
											}
										}
										this.gclass51_0.GEnum23_0 |= GEnum23.const_15;
										this.method_4(GEnum21.const_2, keyValuePair.Key + "_" + text, -1, -1L, GEnum23.const_15);
									}
									else
									{
										this.gclass51_0.GEnum23_0 |= GEnum23.const_15;
										this.method_4(GEnum21.const_2, keyValuePair.Key + "_" + text, -1, -1L, GEnum23.const_15);
									}
								}
								else
								{
									this.gclass51_0.GEnum23_0 |= GEnum23.const_4;
									string text4 = GClass45.smethod_7(currentProcess.Handle, procAddress);
									string text5 = GClass49.smethod_19(currentProcess, procAddress);
									GClass41 gclass = this.method_4(GEnum21.const_2, string.Concat(new string[] { keyValuePair.Key, "_", text, "_", text5 }), -1, -1L, GEnum23.const_4);
									long num7;
									if (text4 != null && text4.Length != 0)
									{
										if (!GClass49.smethod_21(text4))
										{
											num7 = this.method_5(gclass.GEnum21_0, GEnum48.const_4, text4.ToString(), null, GEnum51.const_2);
										}
										else
										{
											num7 = -1L;
										}
									}
									else
									{
										num7 = -1L;
									}
									gclass.Int64_0 = num7;
								}
							}
							else if (Marshal.GetLastWin32Error() != 127)
							{
								this.gclass51_0.GEnum23_0 |= GEnum23.const_13;
								this.method_4(GEnum21.const_2, keyValuePair.Key + "_" + text, -1, -1L, GEnum23.const_13);
							}
						}
						continue;
					}
				}
				if (processModule != null)
				{
					if (!(moduleHandle == IntPtr.Zero))
					{
						this.gclass51_0.GEnum23_0 |= GEnum23.const_14;
						this.method_4(GEnum21.const_2, keyValuePair.Key, -1, -1L, GEnum23.const_14);
					}
					else
					{
						this.gclass51_0.GEnum23_0 |= GEnum23.const_11;
						this.method_4(GEnum21.const_2, keyValuePair.Key, -1, -1L, GEnum23.const_11);
					}
				}
				else
				{
					this.gclass51_0.GEnum23_0 |= GEnum23.const_12;
					this.method_4(GEnum21.const_2, keyValuePair.Key, -1, -1L, GEnum23.const_12);
				}
			}
		}
		catch
		{
			this.gclass51_0.GEnum23_0 |= GEnum23.const_21;
		}
	}

	// Token: 0x0600060D RID: 1549 RVA: 0x00059EE0 File Offset: 0x000580E0
	private bool method_24(Process process_1)
	{
		bool flag = false;
		IntPtr intPtr = IntPtr.Zero;
		try
		{
			intPtr = GClass45.OpenProcess(1040, false, process_1.Id);
			if (intPtr == IntPtr.Zero)
			{
				this.gclass51_0.GEnum23_0 |= GEnum23.const_6;
				return flag;
			}
			GClass45.GStruct4 gstruct = default(GClass45.GStruct4);
			IntPtr intPtr2 = IntPtr.Zero;
			IntPtr intPtr3 = IntPtr.Zero;
			GClass45.GStruct5 gstruct2 = default(GClass45.GStruct5);
			GClass45.GetSystemInfo(ref gstruct2);
			intPtr2 = gstruct2.intptr_0;
			intPtr3 = gstruct2.intptr_1;
			uint num = gstruct2.uint_1;
			if (num == 0U)
			{
				this.gclass51_0.GEnum23_0 |= GEnum23.const_18;
				num = 4096U;
			}
			byte[] array = new byte[num];
			uint num2 = 0;
			while (intPtr2.ToInt64() < intPtr3.ToInt64() && !this.method_47())
			{
				if (GClass45.VirtualQueryEx(intPtr, intPtr2, out gstruct, Marshal.SizeOf(gstruct)) <= 0)
				{
					this.gclass51_0.GEnum23_0 |= GEnum23.const_7;
					break;
				}
				if (gstruct.intptr_2.ToInt64() == 0L)
				{
					break;
				}
				if (GClass49.smethod_9(gstruct))
				{
					this.gclass51_0.GEnum23_0 |= GEnum23.const_10;
					if (GClass45.ReadProcessMemory(intPtr, intPtr2, array, num, ref num2))
					{
						if (num2 == num)
						{
							goto IL_120;
						}
					}
					this.gclass51_0.GEnum23_0 |= GEnum23.const_8;
					break;
				}
				IL_120:
				intPtr2 = (IntPtr)(intPtr2.ToInt64() + gstruct.intptr_2.ToInt64());
			}
			if (intPtr2.ToInt64() < intPtr3.ToInt64())
			{
				this.gclass51_0.GEnum23_0 |= GEnum23.const_17;
			}
			if (GClass45.ReadProcessMemory(intPtr, process_1.MainModule.BaseAddress, array, num, ref num2) && num2 == num)
			{
				int num3 = 0;
				while (num3 < array.Length && array[num3] == 0)
				{
					num3++;
				}
				if (num3 == array.Length)
				{
					this.gclass51_0.GEnum23_0 |= GEnum23.const_16;
				}
			}
			else
			{
				this.gclass51_0.GEnum23_0 |= GEnum23.const_8;
			}
			flag = true;
		}
		catch
		{
			this.gclass51_0.GEnum23_0 |= GEnum23.const_9;
		}
		finally
		{
			if (intPtr != IntPtr.Zero)
			{
				GClass45.CloseHandle(intPtr);
			}
		}
		return flag;
	}

	// Token: 0x0600060E RID: 1550 RVA: 0x0005A168 File Offset: 0x00058368
	private void method_25(Process process_1, GEnum23 genum23_0)
	{
		this.method_24(process_1);
		this.method_23();
		this.method_22(Class14.String_132, null, Class14.String_181);
		this.gclass51_0.GEnum23_0 |= genum23_0;
		if (genum23_0 != GEnum23.const_20)
		{
			return;
		}
		this.method_65(Process.GetCurrentProcess(), true, this.gclass51_0.Boolean_0);
		this.method_64(Process.GetCurrentProcess(), true);
		double num = 0.0;
		double num2 = 0.0;
		int num3 = 0;
		this.method_67(Process.GetCurrentProcess(), GEnum48.const_5, false, GEnum23.const_25, ref num3, ref num, ref num2);
	}

	// Token: 0x0600060F RID: 1551 RVA: 0x0005A208 File Offset: 0x00058408
	private bool method_26(IntPtr intptr_0, int int_2)
	{
		StringBuilder stringBuilder = new StringBuilder(256);
		if (GClass45.GetWindowText(intptr_0, stringBuilder, stringBuilder.Capacity) > 0)
		{
			string text = stringBuilder.ToString().Trim();
			if (text.Length > 0)
			{
				string text2 = Class15.smethod_22(text);
				if (!Class15.smethod_30(this.gclass51_0.List_4, text2, false))
				{
					this.gclass51_0.List_4.Add(text2);
				}
			}
		}
		return true;
	}

	// Token: 0x06000610 RID: 1552 RVA: 0x0005A274 File Offset: 0x00058474
	private bool method_27(IntPtr intptr_0, int int_2)
	{
		StringBuilder stringBuilder = new StringBuilder(256);
		if (GClass45.GetWindowText(intptr_0, stringBuilder, stringBuilder.Capacity) > 0)
		{
			string text = stringBuilder.ToString().Trim();
			if (text.Length > 0)
			{
				try
				{
					uint num = 0U;
					GClass45.GetWindowThreadProcessId(intptr_0, out num);
					if (num > 4U)
					{
						Process processById = Process.GetProcessById((int)num);
						if (processById != null)
						{
							long num2 = -1L;
							if (!GClass49.smethod_18(processById))
							{
								string text2 = null;
								if (GClass49.smethod_22(processById, out text2) && text2 != null)
								{
									num2 = this.method_5(GEnum21.const_0, GEnum48.const_3, text2, null, GEnum51.const_1);
								}
							}
							else
							{
								num2 = this.method_5(GEnum21.const_0, GEnum48.const_3, processById.MainModule.FileName, new DateTime?(processById.StartTime), GEnum51.const_2);
							}
							if (num2 != -1L)
							{
								GClass45.GStruct3 gstruct = default(GClass45.GStruct3);
								GClass45.GetWindowInfo(intptr_0, ref gstruct);
								stringBuilder = new StringBuilder(256);
								string text3 = string.Empty;
								if (GClass45.GetClassName(intptr_0, stringBuilder, stringBuilder.Capacity) > 0)
								{
									text3 = stringBuilder.ToString().Trim();
								}
								this.gclass51_0.List_1[(int)num2].method_2(text, text3, gstruct.uint_1, gstruct.uint_2);
							}
						}
					}
				}
				catch
				{
				}
			}
		}
		return true;
	}

	// Token: 0x06000611 RID: 1553 RVA: 0x0005A3C4 File Offset: 0x000585C4
	public string method_28(string string_6)
	{
		if (string_6 == null)
		{
			return null;
		}
		DriveInfo[] drives = DriveInfo.GetDrives();
		uint num = 0U;
		uint num2 = 0U;
		foreach (DriveInfo driveInfo in drives)
		{
			if (driveInfo.IsReady)
			{
				try
				{
					GClass45.GEnum40 genum;
					if (GClass45.GetVolumeInformation_1(driveInfo.Name, null, 0, out num, out num2, out genum, null, 0) > 0 && num.ToString("X2") == string_6)
					{
						if (driveInfo.Name.Length == 3)
						{
							return driveInfo.Name.Substring(0, 2);
						}
						return driveInfo.Name;
					}
				}
				catch (Exception ex)
				{
					this.method_7(GEnum22.const_37, ex.ToString());
				}
			}
		}
		return null;
	}

	// Token: 0x06000612 RID: 1554 RVA: 0x0005A48C File Offset: 0x0005868C
	private void method_29(GEnum57 genum57_0)
	{
		try
		{
			GEnum48 genum = GEnum48.const_9;
			if (genum57_0 != GEnum57.const_1)
			{
				genum = GEnum48.const_10;
			}
			string text = Class54.smethod_2();
			if (text != null && text.Length > 0)
			{
				foreach (Class58 @class in Class59.smethod_1(text, genum57_0))
				{
					if (@class.String_0.Length > 0)
					{
						this.method_5(GEnum21.const_0, genum, @class.String_0, @class.Nullable_0, GEnum51.const_2);
					}
				}
			}
		}
		catch (NotSupportedException)
		{
		}
		catch (Exception ex)
		{
			this.method_7(GEnum22.const_5, ex.ToString());
		}
	}

	// Token: 0x06000613 RID: 1555 RVA: 0x0005A530 File Offset: 0x00058730
	private void method_30()
	{
		try
		{
			GClass58[] array = GClass59.smethod_1(Class14.String_162);
			int i = 0;
			while (i < array.Length)
			{
				GClass58 gclass = array[i];
				if (gclass.String_0.Length <= 3)
				{
					goto IL_46;
				}
				if (gclass.String_0[1] != ':')
				{
					goto IL_46;
				}
				if (gclass.String_0[2] != '\\')
				{
					goto IL_46;
				}
				goto IL_76;
				IL_9E:
				i++;
				continue;
				IL_46:
				if (gclass.String_0.Length <= 38 || gclass.String_0[0] != '{' || gclass.String_0[37] != '}')
				{
					goto IL_9E;
				}
				IL_76:
				if (gclass.String_0.Length > 0)
				{
					this.method_5(GEnum21.const_0, GEnum48.const_8, gclass.String_0, gclass.Nullable_0, GEnum51.const_2);
					goto IL_9E;
				}
				goto IL_9E;
			}
		}
		catch (NotSupportedException)
		{
		}
		catch (Exception ex)
		{
			this.method_7(GEnum22.const_36, ex.ToString());
		}
	}

	// Token: 0x06000614 RID: 1556 RVA: 0x0005A61C File Offset: 0x0005881C
	private void method_31(GEnum21 genum21_0, Class57 class57_0, Process process_1, IntPtr intptr_0, IntPtr intptr_1)
	{
		if (class57_0 != null && !(intptr_0 == IntPtr.Zero) && !(intptr_1 == IntPtr.Zero))
		{
			string text = GClass49.smethod_2(process_1, intptr_1);
			GEnum48 genum;
			if (text == null)
			{
				text = GClass45.smethod_7(intptr_0, intptr_1);
				if (text == null)
				{
					text = string.Empty;
				}
				genum = GEnum48.const_4;
			}
			else
			{
				genum = GEnum48.const_1;
			}
			string text2 = GClass49.smethod_19(process_1, intptr_1);
			string text3 = string.Format("{0}_{1}", class57_0.String_0, text2);
			GClass41 gclass = this.method_4(genum21_0, text3, -1, -1L, GEnum23.const_0);
			long num;
			if (text != null && text.Length > 0)
			{
				num = this.method_5(gclass.GEnum21_0, genum, text.ToString(), null, GEnum51.const_2);
			}
			else
			{
				num = -1L;
			}
			gclass.Int64_0 = num;
			return;
		}
	}

	// Token: 0x06000615 RID: 1557 RVA: 0x0005A6EC File Offset: 0x000588EC
	private void method_32(Process process_1)
	{
		IntPtr intPtr = IntPtr.Zero;
		try
		{
			intPtr = GClass45.OpenProcess(1040, false, process_1.Id);
			if (!(intPtr == IntPtr.Zero))
			{
				List<GClass53> list = new List<GClass53>
				{
					new GClass53(Class14.Byte_47, Class14.String_223, Class14.int_256),
					new GClass53(Class14.Byte_50, Class14.String_199, Class14.int_189),
					new GClass53(Class14.Byte_42, Class14.String_198, Class14.int_63),
					new GClass53(Class14.Byte_9, Class14.String_206, Class14.int_101),
					new GClass53(Class14.Byte_10, Class14.String_229, Class14.int_47),
					new GClass53(Class14.Byte_7, Class14.String_227, Class14.int_113),
					new GClass53(Class14.Byte_25, Class14.String_175, Class14.int_72),
					new GClass53(Class14.Byte_21, Class14.String_28, Class14.int_136),
					new GClass53(Class14.Byte_27, Class14.String_107, Class14.int_359),
					new GClass53(Class14.Byte_30, Class14.String_237, Class14.int_270),
					new GClass53(Class14.Byte_1, Class14.String_212, Class14.int_289),
					new GClass53(Class14.Byte_24, Class14.String_0, Class14.int_335)
				};
				ProcessModule[] array = new ProcessModule[]
				{
					GClass49.smethod_3(process_1, Class14.String_235),
					GClass49.smethod_3(process_1, Class14.String_116),
					process_1.MainModule
				};
				_ = (new byte[IntPtr.Size]);
				bool flag = false;
				foreach (ProcessModule processModule in array)
				{
					if (processModule != null)
					{
						if (this.method_47())
						{
							break;
						}
						flag = false;
						using (List<GClass53>.Enumerator enumerator = list.GetEnumerator())
						{
							if (!enumerator.MoveNext())
							{
							}
						}
						if (flag)
						{
							break;
						}
					}
				}
			}
		}
		catch (Exception ex)
		{
			this.method_7(GEnum22.const_3, ex.ToString());
		}
		finally
		{
			if (intPtr != IntPtr.Zero)
			{
				GClass45.CloseHandle(intPtr);
			}
		}
	}

	// Token: 0x06000616 RID: 1558 RVA: 0x0005A960 File Offset: 0x00058B60
	private void method_33(Process process_1)
	{
		IntPtr intPtr = IntPtr.Zero;
		try
		{
			intPtr = GClass45.OpenProcess(1040, false, process_1.Id);
			if (!(intPtr == IntPtr.Zero))
			{
				List<GClass53> list = new List<GClass53>
				{
					new GClass53(Class14.Byte_60, Class14.String_48, Class14.int_343),
					new GClass53(Class14.Byte_33, Class14.String_43, Class14.int_307),
					new GClass53(Class14.Byte_38, Class14.String_49, Class14.int_118),
					new GClass53(Class14.Byte_14, Class14.String_210, Class14.int_116),
					new GClass53(Class14.Byte_2, Class14.String_129, Class14.int_46),
					new GClass53(Class14.Byte_19, Class14.String_5, Class14.int_34),
					new GClass53(Class14.Byte_37, Class14.String_171, Class14.int_340),
					new GClass53(Class14.Byte_44, Class14.String_156, Class14.int_196),
					new GClass53(Class14.Byte_43, Class14.String_46, Class14.int_192),
					new GClass53(Class14.Byte_49, Class14.String_197, Class14.int_257),
					new GClass53(Class14.Byte_36, Class14.String_128, Class14.int_37),
					new GClass53(Class14.Byte_63, Class14.String_110, Class14.int_219),
					new GClass53(Class14.Byte_5, Class14.String_196, Class14.int_296),
					new GClass53(Class14.Byte_56, Class14.String_201, Class14.int_6),
					new GClass53(Class14.Byte_4, Class14.String_195, Class14.int_205)
				};
				ProcessModule[] array = new ProcessModule[]
				{
					GClass49.smethod_3(process_1, Class14.String_235),
					GClass49.smethod_3(process_1, Class14.String_116),
					process_1.MainModule
				};
				IntPtr intPtr2 = IntPtr.Zero;
				IntPtr intPtr3 = IntPtr.Zero;
				byte[] array2 = new byte[IntPtr.Size];
				uint num = 0U;
				bool flag = false;
				foreach (ProcessModule processModule in array)
				{
					if (processModule != null)
					{
						if (this.method_47())
						{
							break;
						}
						flag = false;
						foreach (GClass53 gclass in list)
						{
							intPtr3 = WCD.smethod_3(intPtr, processModule.BaseAddress, (IntPtr)processModule.ModuleMemorySize, gclass.Byte_0, gclass.String_0, true, gclass.Int32_0[0], 4, 0U);
							if (intPtr3 != IntPtr.Zero && !this.method_47() && GClass45.ReadProcessMemory(intPtr, intPtr3, array2, (uint)array2.Length, ref num) && (ulong)num == (ulong)((long)array2.Length))
							{
								intPtr2 = (IntPtr)BitConverter.ToInt32(array2, 0);
								GClass62[] array4 = GClass62.smethod_2(intPtr, intPtr2);
								if (array4 != null)
								{
									IntPtr baseAddress = processModule.BaseAddress;
									IntPtr intPtr4 = (IntPtr)(processModule.BaseAddress.ToInt64() + (long)processModule.ModuleMemorySize);
									int num2 = 0;
									string string_ = Class14.String_169;
									foreach (GClass62 gclass2 in array4)
									{
										if (gclass2.String_0 == string_)
										{
											flag = true;
											break;
										}
										if (gclass2.String_0 != null && gclass2.String_0.Length > 0 && Class15.smethod_19(gclass2.String_0) && ++num2 >= 5)
										{
											flag = true;
											break;
										}
									}
									if (flag)
									{
										foreach (GClass62 gclass3 in array4)
										{
											long num3 = gclass3.IntPtr_0.ToInt64();
											if (num3 != 0L && (baseAddress.ToInt64() > num3 || num3 >= intPtr4.ToInt64()))
											{
												string text = GClass49.smethod_2(process_1, gclass3.IntPtr_0);
												GEnum48 genum;
												if (text == null)
												{
													text = GClass45.smethod_7(intPtr, gclass3.IntPtr_0);
													if (text == null)
													{
														text = string.Empty;
													}
													genum = GEnum48.const_4;
												}
												else
												{
													genum = GEnum48.const_1;
												}
												string text2 = GClass49.smethod_19(process_1, gclass3.IntPtr_0);
												string text3 = string.Format("{0}_{1}", gclass3.String_0, text2);
												GClass41 gclass4 = this.method_4(GEnum21.const_19, text3, -1, -1L, GEnum23.const_0);
												long num4;
												if (text != null && text.Length > 0)
												{
													num4 = this.method_5(gclass4.GEnum21_0, genum, text.ToString(), null, GEnum51.const_2);
												}
												else
												{
													num4 = -1L;
												}
												gclass4.Int64_0 = num4;
											}
											if (gclass3.String_0 != string.Empty)
											{
												this.gclass51_0.List_10.Add(gclass3.String_0);
											}
										}
										break;
									}
								}
							}
							if (!flag)
							{
								continue;
							}
							break;
						}
						if (flag)
						{
							break;
						}
					}
				}
			}
		}
		catch (Exception ex)
		{
			this.method_7(GEnum22.const_4, ex.ToString());
		}
		finally
		{
			if (intPtr != IntPtr.Zero)
			{
				GClass45.CloseHandle(intPtr);
			}
		}
	}

	// Token: 0x06000617 RID: 1559 RVA: 0x0005AED0 File Offset: 0x000590D0
	private void method_34(Process process_1)
	{
		try
		{
			this.method_35(process_1.MainModule.ModuleName, process_1.MainModule.FileName, GEnum51.const_2);
		}
		catch (Exception ex)
		{
			this.method_7(GEnum22.const_18, ex.ToString());
		}
		try
		{
			this.method_35(Class14.String_180, Class14.String_180, GEnum51.const_1);
		}
		catch (Exception ex2)
		{
			this.method_7(GEnum22.const_18, ex2.ToString());
		}
		try
		{
			this.method_35(Class14.String_127, Class14.String_127, GEnum51.const_1);
		}
		catch (Exception ex3)
		{
			this.method_7(GEnum22.const_18, ex3.ToString());
		}
		try
		{
			this.method_35(Class14.String_114, Class14.String_114, GEnum51.const_1);
		}
		catch (Exception ex4)
		{
			this.method_7(GEnum22.const_18, ex4.ToString());
		}
	}

	// Token: 0x06000618 RID: 1560 RVA: 0x0005AFB4 File Offset: 0x000591B4
	private bool method_35(string string_6, string string_7 = null, GEnum51 genum51_0 = GEnum51.const_2)
	{
		bool flag = false;
		if (string_6 != null && !this.method_47())
		{
			bool flag2;
			try
			{
				string[] array = Class15.smethod_15(Path.Combine(Path.GetDirectoryName(Environment.GetFolderPath(Environment.SpecialFolder.System)), Class14.String_109), Class14.String_207, false);
				if (array != null && array.Length != 0 && !this.method_47())
				{
					if (string_7 != null)
					{
						Path.GetFullPath(string_7).ToLowerInvariant();
					}
					_ = string_6.ToLowerInvariant() + "-";
					new List<string>();
					string[] array2 = new string[]
					{
						Class14.String_2,
						Class14.String_13,
						Class14.String_51,
						Class14.String_136,
						Class14.String_63,
						Class14.String_106
					};
					Class14.String_143.ToLowerInvariant();
					return true;
				}
				flag2 = flag;
			}
			catch (Exception ex)
			{
				this.method_7(GEnum22.const_19, ex.ToString());
				return flag;
			}
			return flag2;
		}
		return flag;
	}

	// Token: 0x06000619 RID: 1561 RVA: 0x0005B0A4 File Offset: 0x000592A4
	private void method_36()
	{
		IntPtr intPtr = IntPtr.Zero;
		bool flag = false;
		try
		{
			int num = Marshal.SizeOf(typeof(GClass45.GStruct17));
			int num2 = 0;
			intPtr = Marshal.AllocHGlobal(num);
			Marshal.StructureToPtr(new GClass45.GStruct17
			{
				uint_0 = (uint)num
			}, intPtr, false);
			GClass45.NtQuerySystemInformation(103, intPtr, num, ref num2);
			if (num != num2)
			{
				flag = true;
			}
			else
			{
				GClass45.GStruct17 gstruct = (GClass45.GStruct17)Marshal.PtrToStructure(intPtr, typeof(GClass45.GStruct17));
				this.gclass51_0.GEnum34_0 = gstruct.genum34_0;
			}
		}
		catch
		{
			flag = true;
		}
		finally
		{
			if (flag)
			{
				string text = GClass50.smethod_6(Registry.LocalMachine, Class14.String_150, Class14.String_133);
				if (text != null)
				{
					if (text.ToLowerInvariant().Contains(Class14.String_166))
					{
						this.gclass51_0.GEnum34_0 = GClass45.GEnum34.const_2;
					}
				}
				else
				{
					this.gclass51_0.GEnum34_0 = (GClass45.GEnum34)2147483648U;
				}
			}
			if (intPtr != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(intPtr);
			}
		}
	}

	// Token: 0x0600061A RID: 1562 RVA: 0x0005B1B4 File Offset: 0x000593B4
	private void method_37()
	{
		try
		{
			List<string> list = GClass45.smethod_8(Class14.String_60, 1024);
			Regex regex = new Regex(Class14.String_209, RegexOptions.IgnoreCase);
			Regex regex2 = new Regex(Class14.String_165, RegexOptions.None);
			Regex regex3 = new Regex(Class14.String_42, RegexOptions.None);
			Regex regex4 = new Regex(Class14.String_98, RegexOptions.None);
			Regex regex5 = new Regex(Class14.String_1, RegexOptions.None);
			Regex regex6 = new Regex(Class14.String_68, RegexOptions.None);
			Regex regex7 = new Regex(Class14.String_137, RegexOptions.None);
			Regex regex8 = new Regex(Class14.String_118, RegexOptions.None);
			string[] string_ = Class14.String_96;
			foreach (string text in list)
			{
				if (!regex.IsMatch(text) && !regex2.IsMatch(text) && !regex3.IsMatch(text) && !regex4.IsMatch(text) && !regex5.IsMatch(text) && !regex7.IsMatch(text) && !regex8.IsMatch(text) && !regex6.IsMatch(text) && (text.Length < 2 || text[1] != ':'))
				{
					int num = 0;
					while (num < string_.Length && !(string_[num] == text))
					{
						num++;
					}
					if (num >= string_.Length)
					{
						string text2 = Class15.smethod_22(text);
						if (!Class15.smethod_30(this.gclass51_0.List_6, text2, false))
						{
							this.gclass51_0.List_6.Add(text2);
						}
					}
				}
			}
		}
		catch (Exception ex)
		{
			this.method_7(GEnum22.const_6, ex.ToString());
		}
	}

	// Token: 0x0600061B RID: 1563 RVA: 0x0005B38C File Offset: 0x0005958C
	private void method_38()
	{
		try
		{
			using (List<string>.Enumerator enumerator = GClass45.smethod_8(Class14.String_104, 1024).GetEnumerator())
			{
				for (;;)
				{
					IL_80:
					int num = ((!enumerator.MoveNext()) ? 1542789778 : 1558539268);
					for (;;)
					{
						int num2 = num;
						switch ((~(num2 - -575617711) ^ 1210863131 ^ -1607653936) % 4)
						{
						case 0:
							goto IL_80;
						case 2:
							num = 1558539268;
							continue;
						case 3:
						{
							string text = enumerator.Current;
							this.gclass51_0.List_7.Add(Class15.smethod_22(text));
							num = -18989347;
							continue;
						}
						}
						goto Block_4;
					}
				}
				Block_4:;
			}
		}
		catch (Exception ex)
		{
			this.method_7(GEnum22.const_7, ex.ToString());
		}
	}

	// Token: 0x0600061C RID: 1564 RVA: 0x0005B464 File Offset: 0x00059664
	private void method_39(Process process_1)
	{
		IntPtr intPtr = IntPtr.Zero;
		try
		{
			intPtr = GClass45.OpenProcess(1104, false, process_1.Id);
			if (!(intPtr == IntPtr.Zero))
			{
				new List<GClass45.GClass48>();
				List<GClass45.GStruct16> list = GClass45.smethod_3(process_1);
				string string_ = Class14.String_11;
				List<string> list2 = new List<string> { string_ };
				for (int i = 0; i < list.Count; i++)
				{
					GClass45.GClass48 gclass = GClass45.smethod_2(list[i], intPtr, list2);
					if (gclass != null && gclass.String_0 != null)
					{
						this.gclass51_0.List_5.Add(Class15.smethod_22(gclass.String_0));
					}
				}
			}
		}
		catch (Exception ex)
		{
			this.method_7(GEnum22.const_17, ex.ToString());
		}
		finally
		{
			if (intPtr != IntPtr.Zero)
			{
				GClass45.CloseHandle(intPtr);
			}
		}
	}

	// Token: 0x0600061D RID: 1565 RVA: 0x0005B550 File Offset: 0x00059750
	private GClass41 method_40(string string_6)
	{
		FileStream fileStream = null;
		List<GClass40> list = GClass40.smethod_0(this.string_4);
		try
		{
			try
			{
				fileStream = new FileStream(string_6, FileMode.Open, FileAccess.Read, FileShare.Read);
			}
			catch
			{
				fileStream = new FileStream(string_6, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
			}
			using (StreamReader streamReader = new StreamReader(fileStream))
			{
				string text;
				while ((text = streamReader.ReadLine()) != null)
				{
					if (text.Length != 0)
					{
						string text2 = text.ToLower();
						int num = 0;
						foreach (GClass40 gclass in list)
						{
							if ((gclass.GEnum20_0 & GEnum20.const_2) == GEnum20.const_2)
							{
								if ((gclass.GEnum20_0 & GEnum20.const_4) == GEnum20.const_4)
								{
									if (gclass.String_0 != null && !(gclass.String_0 == string.Empty))
									{
										if (!text2.Contains(gclass.String_0))
										{
											num++;
											continue;
										}
										string text3 = string_6 + "_" + gclass.String_0.Trim().Trim(new char[] { '\n' }).Trim(new char[1]);
										return this.method_4(GEnum21.const_10, text3, num, -1L, GEnum23.const_0);
									}
								}
							}
							num++;
						}
					}
				}
			}
		}
		finally
		{
			if (fileStream != null)
			{
				fileStream.Close();
			}
		}
		return null;
	}

	// Token: 0x0600061E RID: 1566 RVA: 0x0005B708 File Offset: 0x00059908
	private GClass41 method_41(DateTime dateTime_0, int int_2, string string_6, bool bool_3 = false)
	{
		if (string_6 == null)
		{
			return null;
		}
		string[] array = string_6.Split(new char[] { '|' });
		string text = null;
		string text2 = null;
		string text3 = null;
		if (array.Length == 4)
		{
			text = array[0];
			text2 = array[1];
			text3 = array[2];
			try
			{
				int num = int.Parse(array[3]);
				foreach (string text4 in Class15.smethod_29(text, text2, num))
				{
					if (File.Exists(text4))
					{
						try
						{
							if (Class15.smethod_18(text4).IndexOf(text3) > -1)
							{
								try
								{
									FileInfo fileInfo = new FileInfo(text4);
									if (!(fileInfo.CreationTime >= dateTime_0) && !(fileInfo.LastAccessTime >= dateTime_0) && !(fileInfo.LastWriteTime >= dateTime_0))
									{
										return this.method_4(GEnum21.const_16, text4 + "_" + string_6, int_2, -1L, GEnum23.const_0);
									}
									return this.method_4(GEnum21.const_15, text4 + "_" + string_6, int_2, -1L, GEnum23.const_0);
								}
								catch
								{
									return this.method_4(GEnum21.const_16, text4 + "_" + string_6, int_2, -1L, GEnum23.const_0);
								}
							}
						}
						catch
						{
						}
					}
				}
				goto IL_6E6;
			}
			catch
			{
				goto IL_6E6;
			}
		}
		GClass41 gclass;
		if (array.Length == 3)
		{
			text = array[0];
			text2 = array[1];
			text3 = array[2];
			if (!(text == Class14.String_54) && !(text == Class14.String_231))
			{
				(new string[1])[0] = text;
				try
				{
					foreach (string text5 in Directory.GetFiles(text, text2))
					{
						if (File.Exists(text5))
						{
							try
							{
								if (Class15.smethod_18(text5).IndexOf(text3) > -1)
								{
									try
									{
										FileInfo fileInfo2 = new FileInfo(text5);
										if (!(fileInfo2.CreationTime >= dateTime_0) && !(fileInfo2.LastAccessTime >= dateTime_0) && !(fileInfo2.LastWriteTime >= dateTime_0))
										{
											return this.method_4(GEnum21.const_16, text5 + "_" + string_6, int_2, -1L, GEnum23.const_0);
										}
										return this.method_4(GEnum21.const_15, text5 + "_" + string_6, int_2, -1L, GEnum23.const_0);
									}
									catch
									{
										return this.method_4(GEnum21.const_16, text5 + "_" + string_6, int_2, -1L, GEnum23.const_0);
									}
								}
							}
							catch
							{
							}
						}
					}
					goto IL_6E6;
				}
				catch (SecurityException)
				{
					return this.method_4(GEnum21.const_16, string_6, int_2, -1L, GEnum23.const_0);
				}
				catch (Exception)
				{
					return null;
				}
			}
			if (GClass50.smethod_2(text, text2, text3) && bool_3)
			{
				return this.method_4(GEnum21.const_16, string_6, int_2, -1L, GEnum23.const_0);
			}
			goto IL_6E6;
		}
		else if (array.Length == 2)
		{
			text = array[0];
			text2 = array[1];
			if (!(text == Class14.String_54) && !(text == Class14.String_231))
			{
				List<string> list = new List<string>();
				try
				{
					foreach (string text6 in Directory.GetFiles(text, text2))
					{
						list.Add(text6);
					}
				}
				catch (SecurityException)
				{
					return this.method_4(GEnum21.const_16, string_6, int_2, -1L, GEnum23.const_0);
				}
				catch (Exception)
				{
					return null;
				}
				try
				{
					foreach (string text7 in Directory.GetDirectories(text, text2))
					{
						list.Add(text7);
					}
				}
				catch (SecurityException)
				{
					return this.method_4(GEnum21.const_16, string_6, int_2, -1L, GEnum23.const_0);
				}
				catch (Exception)
				{
					return null;
				}
				using (List<string>.Enumerator enumerator = list.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						string text8 = enumerator.Current;
						if (!Directory.Exists(text8))
						{
							if (!File.Exists(text8))
							{
								continue;
							}
							try
							{
								FileInfo fileInfo3 = new FileInfo(text8);
								if (!(fileInfo3.CreationTime >= dateTime_0) && !(fileInfo3.LastAccessTime >= dateTime_0) && !(fileInfo3.LastWriteTime >= dateTime_0))
								{
									return this.method_4(GEnum21.const_16, text8 + "_" + string_6, int_2, -1L, GEnum23.const_0);
								}
								return this.method_4(GEnum21.const_15, text8 + "_" + string_6, int_2, -1L, GEnum23.const_0);
							}
							catch
							{
								return this.method_4(GEnum21.const_16, text8 + "_" + string_6, int_2, -1L, GEnum23.const_0);
							}
						}
						try
						{
							DirectoryInfo directoryInfo = new DirectoryInfo(text8);
							if (!(directoryInfo.CreationTime >= dateTime_0) && !(directoryInfo.LastAccessTime >= dateTime_0) && !(directoryInfo.LastWriteTime >= dateTime_0))
							{
								return this.method_4(GEnum21.const_16, text8 + "_" + string_6, int_2, -1L, GEnum23.const_0);
							}
							return this.method_4(GEnum21.const_15, text8 + "_" + string_6, int_2, -1L, GEnum23.const_0);
						}
						catch
						{
							return this.method_4(GEnum21.const_16, text8 + "_" + string_6, int_2, -1L, GEnum23.const_0);
						}
						IL_53D:
						goto IL_6E6;
					}
					//goto IL_53D;
				}
			}
			if (bool_3 && GClass50.smethod_2(text, text2, null))
			{
				return this.method_4(GEnum21.const_16, string_6, int_2, -1L, GEnum23.const_0);
			}
			goto IL_6E6;
		}
		else
		{
			if (array.Length != 1)
			{
				goto IL_6E6;
			}
			text = array[0];
			if (Directory.Exists(text))
			{
				try
				{
					DirectoryInfo directoryInfo2 = new DirectoryInfo(text);
					if (!(directoryInfo2.CreationTime >= dateTime_0) && !(directoryInfo2.LastAccessTime >= dateTime_0) && !(directoryInfo2.LastWriteTime >= dateTime_0))
					{
						return this.method_4(GEnum21.const_16, text + "_" + string_6, int_2, -1L, GEnum23.const_0);
					}
					return this.method_4(GEnum21.const_15, text + "_" + string_6, int_2, -1L, GEnum23.const_0);
				}
				catch
				{
					return this.method_4(GEnum21.const_16, text + "_" + string_6, int_2, -1L, GEnum23.const_0);
				}
			}
			if (!File.Exists(text))
			{
				goto IL_6E6;
			}
			try
			{
				FileInfo fileInfo4 = new FileInfo(text);
				if (!(fileInfo4.CreationTime >= dateTime_0) && !(fileInfo4.LastAccessTime >= dateTime_0) && !(fileInfo4.LastWriteTime >= dateTime_0))
				{
					gclass = this.method_4(GEnum21.const_16, text + "_" + string_6, int_2, -1L, GEnum23.const_0);
				}
				else
				{
					gclass = this.method_4(GEnum21.const_15, text + "_" + string_6, int_2, -1L, GEnum23.const_0);
				}
			}
			catch
			{
				gclass = this.method_4(GEnum21.const_16, text + "_" + string_6, int_2, -1L, GEnum23.const_0);
			}
		}
		return gclass;
		IL_6E6:
		return null;
	}

	// Token: 0x0600061F RID: 1567 RVA: 0x0005BF80 File Offset: 0x0005A180
	public bool method_42(Process process_1)
	{
		if (this.string_4 != null && this.string_4.Length != 0)
		{
			bool flag;
			try
			{
				List<GClass40> list = GClass40.smethod_0(this.string_4);
				string string_ = Class14.String_158;
				string string_2 = Class14.String_148;
				string string_3 = Class14.String_65;
				string string_4 = Class14.String_6;
				string string_5 = Class14.String_224;
				int num = 0;
				while (num < this.gclass51_0.List_1.Count && !this.method_47())
				{
					string directoryName;
					string fileNameWithoutExtension;
					try
					{
						directoryName = Path.GetDirectoryName(this.gclass51_0.List_1[num].String_1);
						fileNameWithoutExtension = Path.GetFileNameWithoutExtension(this.gclass51_0.List_1[num].String_1);
					}
					catch
					{
						goto IL_1A4;
					}
					goto IL_A0;
					IL_1A4:
					num++;
					continue;
					IL_A0:
					for (int i = 0; i < list.Count; i++)
					{
						GClass40 gclass = list[i];
						if ((gclass.GEnum20_0 & GEnum20.const_2) == GEnum20.const_2)
						{
							if ((gclass.GEnum20_0 & GEnum20.const_6) == GEnum20.const_6)
							{
								if (gclass.String_0 != null && !(gclass.String_0 == string.Empty))
								{
									if (gclass.String_0[0] == '%')
									{
										string text;
										if ((this.gclass51_0.List_1[num].GEnum48_0 & GEnum48.const_1) == GEnum48.const_1 && gclass.String_0.StartsWith(string_))
										{
											text = gclass.String_0.Replace(string_, directoryName);
											text = text.Replace(string_2, fileNameWithoutExtension);
										}
										else
										{
											if (!gclass.String_0.StartsWith(string_3))
											{
												goto IL_194;
											}
											text = gclass.String_0.Replace(string_3, directoryName);
											text = text.Replace(string_4, fileNameWithoutExtension);
										}
										this.method_41(this.gclass51_0.DateTime_0, i, text, false);
									}
								}
							}
						}
						IL_194:;
					}
					goto IL_1A4;
				}
				for (int i = 0; i < list.Count; i++)
				{
					GClass40 gclass = list[i];
					if ((gclass.GEnum20_0 & GEnum20.const_2) == GEnum20.const_2)
					{
						if ((gclass.GEnum20_0 & GEnum20.const_6) == GEnum20.const_6 && gclass.String_0 != null && !(gclass.String_0 == string.Empty))
						{
							string text;
							if (gclass.String_0.StartsWith(string_5))
							{
								text = gclass.String_0.Replace(string_5, string_5);
							}
							else
							{
								if (gclass.String_0.StartsWith(string_) || gclass.String_0.StartsWith(string_3))
								{
									goto IL_271;
								}
								text = Environment.ExpandEnvironmentVariables(gclass.String_0);
							}
							this.method_41(this.gclass51_0.DateTime_0, i, text, true);
						}
					}
					IL_271:;
				}
				return true;
			}
			catch
			{
				flag = false;
			}
			return flag;
		}
		return false;
	}

	// Token: 0x06000620 RID: 1568 RVA: 0x0005C250 File Offset: 0x0005A450
	private void method_43(string string_6)
	{
		string text = ("." + string_6 + Class14.String_51).ToLowerInvariant();
		string text2 = Class14.String_2;
		List<GClass44> list = new List<GClass44>();
		int num = 0;
		while (num < this.gclass51_0.List_1.Count && !this.method_47())
		{
			try
			{
				if (this.gclass51_0.List_1[num].String_1.ToLowerInvariant().EndsWith(text))
				{
					string text3 = this.gclass51_0.List_1[num].String_1.Substring(0, this.gclass51_0.List_1[num].String_1.Length - text.Length) + text2;
					if (File.Exists(text3))
					{
						GClass44 gclass = new GClass44(text3, this.gclass51_0.List_1[num].GEnum48_0, this.bool_2, this.gclass51_0.List_1[num].GEnum51_0, false);
						list.Add(gclass);
					}
				}
			}
			catch
			{
			}
			num++;
		}
		num = 0;
		while (num < list.Count && !this.method_47())
		{
			this.method_6(list[num]);
			num++;
		}
	}

	// Token: 0x06000621 RID: 1569 RVA: 0x0005C3A4 File Offset: 0x0005A5A4
	private void method_44()
	{
		string[] array = new string[5];
		array[0] = Class14.String_24;
		array[1] = Class14.String_186;
		array[2] = Class14.String_58;
		array[3] = Class14.String_37;
		string[] array2 = array;
		Stopwatch stopwatch = new Stopwatch();
		int num;
		if (this.gclass51_0.GClass55_0 != null && this.gclass51_0.GClass55_0.List_0.Count > 0)
		{
			stopwatch.Start();
			List<string> list = new List<string>();
			num = 0;
			while (num < this.gclass51_0.List_1.Count && !this.method_47())
			{
				try
				{
					string directoryName = Path.GetDirectoryName(this.gclass51_0.List_1[num].String_1);
					if (!Class15.smethod_30(list, directoryName, false))
					{
						list.Add(directoryName);
					}
				}
				catch
				{
				}
				num++;
			}
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
			if (!Class15.smethod_30(list, folderPath, false))
			{
				list.Add(folderPath);
			}
			stopwatch.Stop();
			stopwatch.Reset();
			stopwatch.Start();
			List<GClass54> list_ = this.gclass51_0.GClass55_0.List_0;
			num = 0;
			while (num < list_.Count && !this.method_47())
			{
				GClass54 gclass = list_[num];
				string text = gclass.String_0;
				if (text.Length > 0)
				{
					int num2 = 0;
					while (num2 < list.Count && !this.method_47())
					{
						try
						{
							string text2 = Path.Combine(list[num2], text);
							if (GClass39.smethod_3(text2))
							{
								long num3 = this.method_5(GEnum21.const_0, GEnum48.const_7, text2, null, GEnum51.const_2);
								if (num3 != -1L)
								{
									if (gclass.List_0.IndexOf(num3) == -1)
									{
										gclass.List_0.Add(num3);
									}
								}
							}
							goto IL_1CB;
						}
						catch
						{
							goto IL_1CB;
						}
						break;
						IL_1CB:
						num2++;
					}
				}
				num++;
			}
			stopwatch.Stop();
			stopwatch.Reset();
		}
		if (this.string_5 == Class14.String_80)
		{
			this.method_43(Class14.String_80);
		}
		else
		{
			this.method_43(Class14.String_83);
		}
		uint num4 = 11U;
		stopwatch.Start();
		num = 0;
		while (num < this.gclass51_0.List_1.Count && !this.method_47())
		{
			this.gclass51_0.List_1[num].method_3();
			if ((this.gclass51_0.List_1[num].GEnum48_0 & (GEnum48)num4) != GEnum48.const_0)
			{
				string text3 = this.gclass51_0.List_1[num].String_1;
				foreach (string text4 in array2)
				{
					string text5 = Path.ChangeExtension(text3, text4);
					try
					{
						if (File.Exists(text5))
						{
							this.gclass51_0.List_1[num].UInt32_0 |= 1U;
							GClass41 gclass2 = this.method_40(text5);
							if (gclass2 == null)
							{
								this.gclass51_0.List_1[num].UInt32_0 |= 4U;
							}
							else
							{
								gclass2.Int64_0 = this.gclass51_0.List_1[num].Int64_0;
								this.gclass51_0.List_1[num].UInt32_0 |= 2U;
							}
						}
						goto IL_375;
					}
					catch (Exception ex)
					{
						this.gclass51_0.List_1[num].UInt32_0 |= 8U;
						this.method_7(GEnum22.const_21, ex.ToString());
						goto IL_375;
					}
					break;
					IL_375:;
				}
			}
			num++;
		}
		stopwatch.Stop();
		stopwatch.Reset();
		stopwatch.Start();
		num = 0;
		while (num < this.gclass51_0.List_1.Count && !this.method_47())
		{
			this.gclass51_0.List_1[num].method_3();
			num++;
		}
		stopwatch.Stop();
		stopwatch.Reset();
	}

	// Token: 0x06000622 RID: 1570 RVA: 0x0005C7B8 File Offset: 0x0005A9B8
	private void method_45(Process process_1)
	{
		Stopwatch stopwatch = new Stopwatch();
		stopwatch.Start();
		this.method_56(Process.GetCurrentProcess(), GEnum48.const_5);
		this.method_69();
		stopwatch.Stop();
		this.method_0(GEnum49.const_34, stopwatch);
		stopwatch.Reset();
		if (this.method_47())
		{
			return;
		}
		stopwatch.Start();
		this.method_12();
		this.method_69();
		stopwatch.Stop();
		this.method_0(GEnum49.const_30, stopwatch);
		stopwatch.Reset();
		if (this.method_47())
		{
			return;
		}
		stopwatch.Start();
		this.gclass51_0.String_6 = this.method_17();
		this.method_69();
		stopwatch.Stop();
		this.method_0(GEnum49.const_25, stopwatch);
		stopwatch.Reset();
		if (this.method_47())
		{
			return;
		}
		stopwatch.Start();
		string text = this.method_68();
		if (text == null)
		{
			this.gclass51_0.GEnum23_0 |= GEnum23.const_2;
		}
		else
		{
			this.gclass51_0.String_14 = text;
		}
		this.method_69();
		stopwatch.Stop();
		this.method_0(GEnum49.const_29, stopwatch);
		stopwatch.Reset();
		if (this.method_47())
		{
			return;
		}
		stopwatch.Start();
		this.method_59();
		this.method_69();
		stopwatch.Stop();
		this.method_0(GEnum49.const_22, stopwatch);
		stopwatch.Reset();
		if (this.method_47())
		{
			return;
		}
		stopwatch.Start();
		this.method_58();
		this.method_69();
		stopwatch.Stop();
		this.method_0(GEnum49.const_12, stopwatch);
		stopwatch.Reset();
		if (this.method_47())
		{
			return;
		}
		stopwatch.Start();
		this.gclass51_0.String_4 = WCD.smethod_1();
		this.method_69();
		stopwatch.Stop();
		this.method_0(GEnum49.const_4, stopwatch);
		stopwatch.Reset();
		if (this.method_47())
		{
			return;
		}
		stopwatch.Start();
		this.method_39(process_1);
		this.method_69();
		stopwatch.Stop();
		this.method_0(GEnum49.const_24, stopwatch);
		stopwatch.Reset();
		if (this.method_47())
		{
			return;
		}
		stopwatch.Start();
		this.method_38();
		this.method_69();
		stopwatch.Stop();
		this.method_0(GEnum49.const_3, stopwatch);
		stopwatch.Reset();
		if (this.method_47())
		{
			return;
		}
		stopwatch.Start();
		this.method_37();
		this.method_69();
		stopwatch.Stop();
		this.method_0(GEnum49.const_2, stopwatch);
		stopwatch.Reset();
		if (this.method_47())
		{
			return;
		}
		stopwatch.Start();
		this.method_36();
		this.method_69();
		stopwatch.Stop();
		this.method_0(GEnum49.const_35, stopwatch);
		stopwatch.Reset();
		if (this.method_47())
		{
			return;
		}
		stopwatch.Start();
		this.method_2();
		this.gclass51_0.string_15 = GClass49.smethod_24(process_1.Id);
		stopwatch.Stop();
		this.method_0(GEnum49.const_5, stopwatch);
		stopwatch.Reset();
		stopwatch.Start();
		this.method_29(GEnum57.const_1);
		this.method_69();
		stopwatch.Stop();
		this.method_0(GEnum49.const_0, stopwatch);
		stopwatch.Reset();
		if (!this.method_47())
		{
			stopwatch.Start();
			this.method_29(GEnum57.const_0);
			this.method_69();
			stopwatch.Stop();
			this.method_0(GEnum49.const_1, stopwatch);
			stopwatch.Reset();
			this.method_47();
			return;
		}
	}

	// Token: 0x06000623 RID: 1571 RVA: 0x0005CAC0 File Offset: 0x0005ACC0
	private void method_46(Process process_1)
	{
		if (process_1 == null)
		{
			this.method_48();
			return;
		}
		Stopwatch stopwatch = new Stopwatch();
		try
		{
			this.gclass51_0.long_0 = this.method_5(GEnum21.const_0, GEnum48.const_1, process_1.MainModule.FileName, null, GEnum51.const_2);
		}
		catch
		{
		}
		try
		{
			Process currentProcess = Process.GetCurrentProcess();
			this.gclass51_0.long_1 = this.method_5(GEnum21.const_0, GEnum48.const_3, currentProcess.MainModule.FileName, null, GEnum51.const_2);
		}
		catch
		{
		}
		stopwatch.Start();
		this.method_56(process_1, GEnum48.const_1);
		this.method_69();
		stopwatch.Stop();
		this.method_0(GEnum49.const_19, stopwatch);
		stopwatch.Reset();
		if (this.method_47())
		{
			return;
		}
		stopwatch.Start();
		this.method_32(this.process_0);
		this.method_69();
		stopwatch.Stop();
		this.method_0(GEnum49.const_14, stopwatch);
		stopwatch.Reset();
		if (this.method_47())
		{
			return;
		}
		stopwatch.Start();
		this.method_33(this.process_0);
		this.method_69();
		stopwatch.Stop();
		this.method_0(GEnum49.const_15, stopwatch);
		stopwatch.Reset();
		if (this.method_47())
		{
			return;
		}
		stopwatch.Start();
		this.method_55(Process.GetCurrentProcess(), out this.gclass51_0.long_4);
		this.method_69();
		if (this.method_47())
		{
			stopwatch.Stop();
			return;
		}
		this.method_55(this.process_0, out this.gclass51_0.long_3);
		this.method_69();
		if (this.method_47())
		{
			stopwatch.Stop();
			return;
		}
		stopwatch.Start();
		this.method_54();
		this.method_69();
		stopwatch.Stop();
		this.method_0(GEnum49.const_28, stopwatch);
		stopwatch.Reset();
		if (this.method_47())
		{
			return;
		}
		stopwatch.Start();
		this.method_34(process_1);
		this.method_69();
		stopwatch.Stop();
		this.method_0(GEnum49.const_26, stopwatch);
		stopwatch.Reset();
		if (!this.method_47())
		{
			stopwatch.Start();
			try
			{
				this.gclass51_0.GClass55_0 = new GClass55(process_1);
			}
			catch
			{
				this.gclass51_0.GClass55_0 = null;
			}
			this.method_2();
			stopwatch.Stop();
			this.method_0(GEnum49.const_31, stopwatch);
			return;
		}
	}

	// Token: 0x06000624 RID: 1572 RVA: 0x0005CD08 File Offset: 0x0005AF08
	public bool method_47()
	{
		object obj = WCD.object_2;
		bool flag2;
		lock (obj)
		{
			flag2 = this.bool_1;
		}
		return flag2;
	}

	// Token: 0x06000625 RID: 1573 RVA: 0x0005CD4C File Offset: 0x0005AF4C
	public void method_48()
	{
		object obj = WCD.object_2;
		lock (obj)
		{
			this.bool_1 = true;
		}
	}

	// Token: 0x06000626 RID: 1574 RVA: 0x0005CD8C File Offset: 0x0005AF8C
	private void method_49(Process process_1)
	{
		if (process_1 == null)
		{
			this.method_48();
			return;
		}
		Stopwatch stopwatch = new Stopwatch();
		stopwatch.Start();
		this.method_53();
		this.method_69();
		stopwatch.Stop();
		this.method_0(GEnum49.const_27, stopwatch);
		stopwatch.Reset();
		if (this.method_47())
		{
			return;
		}
		stopwatch.Start();
		if (!this.method_65(process_1, false, this.gclass51_0.Boolean_0))
		{
			stopwatch.Stop();
			this.method_48();
			return;
		}
		this.method_69();
		stopwatch.Stop();
		this.method_0(GEnum49.const_20, stopwatch);
		stopwatch.Reset();
		if (this.method_47())
		{
			return;
		}
		stopwatch.Start();
		if (!this.method_67(process_1, GEnum48.const_1, this.gclass51_0.Boolean_0, GEnum23.const_0, ref this.gclass51_0.int_0, ref this.gclass51_0.double_0, ref this.gclass51_0.double_1))
		{
			stopwatch.Stop();
			this.method_48();
			return;
		}
		this.method_69();
		stopwatch.Stop();
		this.method_0(GEnum49.const_21, stopwatch);
		stopwatch.Reset();
		if (this.method_47())
		{
			return;
		}
		stopwatch.Start();
		this.method_64(process_1, false);
		this.method_69();
		stopwatch.Stop();
		this.method_0(GEnum49.const_23, stopwatch);
		stopwatch.Reset();
		if (this.method_47())
		{
			return;
		}
		stopwatch.Start();
		this.method_51(process_1, Class14.String_132, null, Class14.String_141, true);
		this.method_69();
		if (this.method_47())
		{
			stopwatch.Stop();
			return;
		}
		this.method_51(process_1, Class14.String_30, null, Class14.String_141, true);
		this.method_69();
		if (this.method_47())
		{
			stopwatch.Stop();
			return;
		}
		this.method_51(process_1, Class14.String_176, null, Class14.String_45, true);
		this.method_69();
		stopwatch.Stop();
		this.method_0(GEnum49.const_17, stopwatch);
		stopwatch.Reset();
		if (this.method_47())
		{
			return;
		}
		stopwatch.Start();
		this.method_52(process_1);
		this.method_69();
		stopwatch.Stop();
		this.method_0(GEnum49.const_18, stopwatch);
		stopwatch.Reset();
		if (this.method_47())
		{
			return;
		}
		stopwatch.Start();
		if (!this.method_62(process_1))
		{
			stopwatch.Stop();
			this.method_48();
			return;
		}
		this.method_69();
		stopwatch.Stop();
		this.method_0(GEnum49.const_33, stopwatch);
		stopwatch.Reset();
		if (this.method_47())
		{
			return;
		}
		this.method_2();
		if (this.method_47())
		{
			return;
		}
		stopwatch.Start();
		this.method_57();
		this.method_69();
		stopwatch.Stop();
		this.method_0(GEnum49.const_16, stopwatch);
		stopwatch.Reset();
		if (this.method_47())
		{
			return;
		}
		stopwatch.Start();
		this.method_30();
		this.method_69();
		stopwatch.Stop();
		this.method_0(GEnum49.const_32, stopwatch);
		stopwatch.Reset();
		this.method_47();
	}

	// Token: 0x06000627 RID: 1575 RVA: 0x0005D044 File Offset: 0x0005B244
	private void method_50(object sender, EventArgs e)
	{
		this.method_48();
	}

	// Token: 0x06000628 RID: 1576 RVA: 0x0005D058 File Offset: 0x0005B258
	public bool method_51(Process process_1, string string_6, string string_7 = null, string[] string_8 = null, bool bool_3 = false)
	{
		IntPtr intPtr = IntPtr.Zero;
		bool flag = false;
		if (process_1 == null || string_6 == null)
		{
			return flag;
		}
		string moduleName = process_1.MainModule.ModuleName;
		ProcessModule processModule = GClass49.smethod_5(process_1, string_6, string_7, GClass49.GEnum43.const_1);
		if (processModule == null)
		{
			return flag;
		}
		try
		{
			intPtr = GClass45.OpenProcess(1040, false, process_1.Id);
			if (intPtr == IntPtr.Zero)
			{
				return flag;
			}
			GClass14[] array = new GClass17(intPtr, processModule.BaseAddress, GEnum15.const_2).GClass14_0;
			if (array == null)
			{
				return flag;
			}
			int i;
			if (string_8 != null)
			{
				List<GClass14> list = new List<GClass14>();
				for (i = 0; i < string_8.Length; i++)
				{
					string text = string_8[i].ToLowerInvariant();
					foreach (GClass14 gclass in array)
					{
						if (gclass.String_0 != null && gclass.String_0.ToLowerInvariant() == text)
						{
							list.Add(gclass);
							break;
						}
					}
				}
				array = list.ToArray();
			}
			long num = processModule.BaseAddress.ToInt64();
			long num2 = processModule.BaseAddress.ToInt64() + (long)processModule.ModuleMemorySize;
			GEnum21 genum = GEnum21.const_11;
			if (bool_3)
			{
				genum |= GEnum21.const_21;
			}
			GClass14[] array2 = array;
			i = 0;
			while (i < array2.Length)
			{
				GClass14 gclass2 = array2[i];
				long num3;
				try
				{
					num3 = (long)((ulong)gclass2.UInt32_0 + (ulong)num);
					goto IL_264;
				}
				catch
				{
					num3 = (long)((ulong)gclass2.UInt32_0);
					goto IL_264;
				}
				goto IL_16C;
				IL_259:
				i++;
				continue;
				IL_16C:
				if (num3 < num2)
				{
					goto IL_259;
				}
				IL_175:
				string text2 = GClass49.smethod_2(process_1, (IntPtr)((long)((ulong)gclass2.UInt32_0)));
				GEnum48 genum2;
				if (text2 != null)
				{
					genum2 = GEnum48.const_1;
				}
				else
				{
					text2 = GClass45.smethod_7(intPtr, (IntPtr)((long)((ulong)gclass2.UInt32_0)));
					if (text2 == null)
					{
						text2 = string.Empty;
					}
					genum2 = GEnum48.const_4;
				}
				long num4;
				if (text2 != null && text2.Length > 0)
				{
					num4 = this.method_5(genum, genum2, text2.ToString(), null, GEnum51.const_2);
				}
				else
				{
					num4 = -1L;
				}
				string text3 = GClass49.smethod_19(process_1, (IntPtr)((long)((ulong)gclass2.UInt32_0)));
				this.method_4(genum, string.Concat(new object[]
				{
					string_6,
					"_",
					gclass2.String_0 ?? Class14.String_208,
					":",
					gclass2.UInt32_0,
					"_",
					text3
				}), -1, num4, GEnum23.const_0);
				goto IL_259;
				IL_264:
				if (num3 >= num)
				{
					goto IL_16C;
				}
				goto IL_175;
			}
			flag = true;
		}
		catch (Exception ex)
		{
			this.method_7(GEnum22.const_10, ex.ToString());
		}
		finally
		{
			if (intPtr != IntPtr.Zero)
			{
				GClass45.CloseHandle(intPtr);
			}
		}
		return flag;
	}

	// Token: 0x06000629 RID: 1577 RVA: 0x0005D35C File Offset: 0x0005B55C
	public static IntPtr smethod_3(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2, byte[] byte_2, string string_6, bool bool_3, int int_2, int int_3, uint uint_0)
	{
		if (!(intptr_0 == IntPtr.Zero))
		{
			if (int_3 != 4)
			{
				if (int_3 != 8)
				{
					goto IL_289;
				}
			}
			GClass45.GStruct4 gstruct = default(GClass45.GStruct4);
			GClass45.GStruct5 gstruct2 = default(GClass45.GStruct5);
			uint num = 4096U;
			GClass45.GetSystemInfo(ref gstruct2);
			if (gstruct2.uint_1 > 0U)
			{
				num = gstruct2.uint_1;
			}
			IntPtr intPtr = intptr_1;
			IntPtr intPtr2 = (IntPtr)(intptr_1.ToInt64() + intptr_2.ToInt64());
			IntPtr intPtr3 = IntPtr.Zero;
			uint num2 = 0U;
			byte[] array = new byte[num];
			while (intPtr.ToInt64() < intPtr2.ToInt64())
			{
				if (GClass45.VirtualQueryEx(intptr_0, intPtr, out gstruct, Marshal.SizeOf(gstruct)) <= 0 || gstruct.intptr_0.ToInt64() == 0L || gstruct.intptr_2.ToInt64() == 0L)
				{
					IL_273:
					while (intPtr.ToInt64() < intPtr2.ToInt64())
					{
					}
					return IntPtr.Zero;
				}
				IntPtr intPtr4 = (IntPtr)(gstruct.intptr_0.ToInt64() + gstruct.intptr_2.ToInt64());
				if (!GClass49.smethod_9(gstruct))
				{
					intPtr = intPtr4;
				}
				else
				{
					if (uint_0 == 0U || (gstruct.uint_2 & uint_0) == uint_0)
					{
						IntPtr intPtr5 = intPtr;
						IntPtr intPtr6 = intPtr;
						uint num3 = num;
						for (;;)
						{
							if (intPtr5.ToInt64() + (long)((ulong)num3) >= intPtr4.ToInt64())
							{
								num3 = (uint)(intPtr4.ToInt64() - intPtr5.ToInt64());
							}
							if (!GClass45.ReadProcessMemory(intptr_0, intPtr5, array, num3, ref num2) || num2 <= 0U)
							{
								goto IL_257;
							}
							if (num2 < num3)
							{
								Array.Clear(array, (int)num2, array.Length - (int)num2);
							}
							int num4 = Class15.smethod_23(array, byte_2, string_6, 0, (int)num2);
							if (num4 > -1)
							{
								num4 += int_2;
								if (int_3 != 4)
								{
									if (int_3 == 8)
									{
										intPtr3 = (IntPtr)BitConverter.ToInt64(array, num4);
										if (!bool_3)
										{
											intPtr3 = (IntPtr)(intptr_1.ToInt64() + intPtr3.ToInt64());
										}
									}
									else
									{
										intPtr3 = (IntPtr)(intPtr5.ToInt64() + intPtr3.ToInt64());
									}
								}
								else
								{
									intPtr3 = (IntPtr)BitConverter.ToInt32(array, num4);
									if (!bool_3)
									{
										intPtr3 = (IntPtr)(intptr_1.ToInt64() + intPtr3.ToInt64());
									}
								}
								if (GClass49.smethod_11(intptr_0, intPtr3))
								{
									break;
								}
							}
							intPtr6 = (IntPtr)(intPtr6.ToInt64() + (long)((ulong)num3));
							intPtr5 = (IntPtr)(intPtr6.ToInt64() - (long)byte_2.Length);
							if ((ulong)num3 == (ulong)((long)byte_2.Length))
							{
								goto Block_18;
							}
							if (intPtr5.ToInt64() >= intPtr4.ToInt64())
							{
								goto IL_257;
							}
						}
						return intPtr3;
						IL_257:
						intPtr = intPtr4;
						continue;
						Block_18:
						goto IL_257;
					}
					intPtr = intPtr4;
				}
			}
			//goto IL_273;
		}
		IL_289:
		return IntPtr.Zero;
	}

	// Token: 0x0600062A RID: 1578 RVA: 0x0005D5F8 File Offset: 0x0005B7F8
	public bool method_52(Process process_1)
	{
		IntPtr intPtr = IntPtr.Zero;
		bool flag = false;
		if (process_1 != null && !process_1.HasExited)
		{
			try
			{
				intPtr = GClass45.OpenProcess(1040, false, process_1.Id);
				if (intPtr == IntPtr.Zero)
				{
					return flag;
				}
				List<GClass53> list = new List<GClass53>
				{
					new GClass53(Class14.Byte_55, Class14.String_203, Class14.int_91),
					new GClass53(Class14.Byte_64, Class14.String_233, Class14.int_2),
					new GClass53(Class14.Byte_31, Class14.String_149, Class14.int_137),
					new GClass53(Class14.Byte_41, Class14.String_59, Class14.int_25),
					new GClass53(Class14.Byte_48, Class14.String_39, Class14.int_314),
					new GClass53(Class14.Byte_40, Class14.String_85, Class14.int_19),
					new GClass53(Class14.Byte_0, Class14.String_103, Class14.int_100)
				};
				List<GClass53> list2 = new List<GClass53>
				{
					new GClass53(Class14.Byte_62, Class14.String_225, Class14.int_217),
					new GClass53(Class14.Byte_39, Class14.String_135, Class14.int_106),
					new GClass53(Class14.Byte_11, Class14.String_15, Class14.int_114),
					new GClass53(Class14.Byte_20, Class14.String_40, Class14.int_287),
					new GClass53(Class14.Byte_61, Class14.String_113, Class14.int_333),
					new GClass53(Class14.Byte_52, Class14.String_142, Class14.int_26),
					new GClass53(Class14.Byte_59, Class14.String_4, Class14.int_23),
					new GClass53(Class14.Byte_57, Class14.String_130, Class14.int_31),
					new GClass53(Class14.Byte_58, Class14.String_26, Class14.int_346),
					new GClass53(Class14.Byte_3, Class14.String_232, Class14.int_187),
					new GClass53(Class14.Byte_22, Class14.String_25, Class14.int_364)
				};
				List<GClass53> list3 = new List<GClass53>
				{
					new GClass53(Class14.Byte_34, Class14.String_31, Class14.int_76),
					new GClass53(Class14.Byte_51, Class14.String_21, Class14.int_89),
					new GClass53(Class14.Byte_26, Class14.String_90, Class14.int_220),
					new GClass53(Class14.Byte_35, Class14.String_144, Class14.int_83),
					new GClass53(Class14.Byte_28, Class14.String_151, Class14.int_304)
				};
				ProcessModule[] array = new ProcessModule[]
				{
					GClass49.smethod_3(process_1, Class14.String_235),
					GClass49.smethod_3(process_1, Class14.String_116),
					GClass49.smethod_3(process_1, Class14.String_34),
					process_1.MainModule
				};
				IntPtr intPtr2 = IntPtr.Zero;
				IntPtr intPtr3 = IntPtr.Zero;
				IntPtr intPtr4 = IntPtr.Zero;
				bool flag2 = false;
				bool flag3 = false;
				bool flag4 = false;
				Dictionary<GEnum53, bool> dictionary = new Dictionary<GEnum53, bool>
				{
					{
						GEnum53.const_33,
						true
					},
					{
						GEnum53.const_14,
						false
					},
					{
						GEnum53.const_3,
						false
					},
					{
						GEnum53.const_19,
						false
					},
					{
						GEnum53.const_25,
						false
					},
					{
						GEnum53.const_34,
						false
					},
					{
						GEnum53.const_1,
						false
					},
					{
						GEnum53.const_2,
						false
					},
					{
						GEnum53.const_11,
						false
					},
					{
						GEnum53.const_39,
						false
					},
					{
						GEnum53.const_6,
						false
					},
					{
						GEnum53.const_7,
						false
					},
					{
						GEnum53.const_8,
						false
					},
					{
						GEnum53.const_4,
						true
					},
					{
						GEnum53.const_20,
						true
					},
					{
						GEnum53.const_26,
						true
					},
					{
						GEnum53.const_35,
						true
					},
					{
						GEnum53.const_38,
						true
					}
				};
				Dictionary<GEnum56, bool> dictionary2 = new Dictionary<GEnum56, bool>
				{
					{
						GEnum56.const_25,
						true
					},
					{
						GEnum56.const_23,
						true
					}
				};
				Dictionary<GEnum54, bool> dictionary3 = new Dictionary<GEnum54, bool>
				{
					{
						GEnum54.const_69,
						true
					},
					{
						GEnum54.const_11,
						true
					},
					{
						GEnum54.const_20,
						true
					},
					{
						GEnum54.const_5,
						true
					}
				};
				foreach (ProcessModule processModule in array)
				{
					if (processModule != null)
					{
						long num = processModule.BaseAddress.ToInt64();
						long num2 = processModule.BaseAddress.ToInt64() + (long)processModule.ModuleMemorySize;
						if (!flag2)
						{
							foreach (GClass53 gclass in list2)
							{
								intPtr2 = WCD.smethod_3(intPtr, processModule.BaseAddress, (IntPtr)processModule.ModuleMemorySize, gclass.Byte_0, gclass.String_0, true, gclass.Int32_0[0], 4, 0U);
								if (intPtr2 != IntPtr.Zero)
								{
									int[] array3 = GClass60.smethod_0(intPtr, intPtr2);
									if (array3 != null)
									{
										flag2 = true;
										foreach (KeyValuePair<GEnum53, bool> keyValuePair in dictionary)
										{
											long num3 = (long)array3[(int)keyValuePair.Key];
											if ((num3 < num || num3 >= num2) && GClass49.smethod_13(intPtr, (IntPtr)num3))
											{
												GEnum21 genum = GEnum21.const_12;
												if (keyValuePair.Value)
												{
													genum |= GEnum21.const_21;
												}
												string text = GClass49.smethod_2(process_1, (IntPtr)num3);
												GEnum48 genum2;
												if (text != null)
												{
													genum2 = GEnum48.const_1;
												}
												else
												{
													text = GClass45.smethod_7(intPtr, (IntPtr)num3);
													if (text == null)
													{
														text = string.Empty;
													}
													genum2 = GEnum48.const_4;
												}
												long num4;
												if (text != null && text.Length > 0)
												{
													num4 = this.method_5(genum, genum2, text.ToString(), null, GEnum51.const_2);
												}
												else
												{
													num4 = -1L;
												}
												string text2 = GClass49.smethod_19(process_1, (IntPtr)num3);
												string text3 = string.Format("{0}_{1}_{2}", Class14.String_33, (int)keyValuePair.Key, text2);
												this.method_4(genum, text3, -1, num4, GEnum23.const_0);
											}
										}
										break;
									}
									intPtr2 = IntPtr.Zero;
								}
							}
						}
						if (!flag3)
						{
							foreach (GClass53 gclass2 in list)
							{
								intPtr3 = WCD.smethod_3(intPtr, processModule.BaseAddress, (IntPtr)processModule.ModuleMemorySize, gclass2.Byte_0, gclass2.String_0, true, gclass2.Int32_0[0], 4, 0U);
								if (intPtr3 != IntPtr.Zero)
								{
									int[] array4 = GClass61.smethod_0(intPtr, intPtr3);
									if (array4 != null)
									{
										flag3 = true;
										foreach (KeyValuePair<GEnum54, bool> keyValuePair2 in dictionary3)
										{
											long num3 = (long)array4[(int)keyValuePair2.Key];
											if ((num3 < num || num3 >= num2) && GClass49.smethod_13(intPtr, (IntPtr)num3))
											{
												GEnum21 genum = GEnum21.const_12;
												if (keyValuePair2.Value)
												{
													genum |= GEnum21.const_21;
												}
												string text4 = GClass49.smethod_2(process_1, (IntPtr)num3);
												GEnum48 genum2;
												if (text4 == null)
												{
													text4 = GClass45.smethod_7(intPtr, (IntPtr)num3);
													if (text4 == null)
													{
														text4 = string.Empty;
													}
													genum2 = GEnum48.const_4;
												}
												else
												{
													genum2 = GEnum48.const_1;
												}
												long num4;
												if (text4 != null && text4.Length > 0)
												{
													num4 = this.method_5(genum, genum2, text4.ToString(), null, GEnum51.const_2);
												}
												else
												{
													num4 = -1L;
												}
												string text5 = GClass49.smethod_19(process_1, (IntPtr)num3);
												string text6 = string.Format("{0}_{1}_{2}", Class14.String_75, (int)keyValuePair2.Key, text5);
												this.method_4(genum, text6, -1, num4, GEnum23.const_0);
											}
										}
										break;
									}
									intPtr3 = IntPtr.Zero;
								}
							}
						}
						if (!flag4)
						{
							foreach (GClass53 gclass3 in list3)
							{
								intPtr4 = WCD.smethod_3(intPtr, processModule.BaseAddress, (IntPtr)processModule.ModuleMemorySize, gclass3.Byte_0, gclass3.String_0, true, gclass3.Int32_0[0], 4, 0U);
								if (intPtr4 != IntPtr.Zero)
								{
									int[] array5 = GClass63.smethod_0(intPtr, intPtr4);
									if (array5 != null)
									{
										flag4 = true;
										foreach (KeyValuePair<GEnum56, bool> keyValuePair3 in dictionary2)
										{
											long num3 = (long)array5[(int)keyValuePair3.Key];
											if ((num3 < num || num3 >= num2) && GClass49.smethod_13(intPtr, (IntPtr)num3))
											{
												GEnum21 genum = GEnum21.const_12;
												if (keyValuePair3.Value)
												{
													genum |= GEnum21.const_21;
												}
												string text7 = GClass49.smethod_2(process_1, (IntPtr)num3);
												GEnum48 genum2;
												if (text7 != null)
												{
													genum2 = GEnum48.const_1;
												}
												else
												{
													text7 = GClass45.smethod_7(intPtr, (IntPtr)num3);
													if (text7 == null)
													{
														text7 = string.Empty;
													}
													genum2 = GEnum48.const_4;
												}
												long num4;
												if (text7 != null && text7.Length > 0)
												{
													num4 = this.method_5(genum, genum2, text7.ToString(), null, GEnum51.const_2);
												}
												else
												{
													num4 = -1L;
												}
												string text8 = GClass49.smethod_19(process_1, (IntPtr)num3);
												string text9 = string.Format("{0}_{1}_{2}", Class14.String_131, (int)keyValuePair3.Key, text8);
												this.method_4(genum, text9, -1, num4, GEnum23.const_0);
											}
										}
										break;
									}
									intPtr4 = IntPtr.Zero;
								}
							}
						}
					}
				}
				if (!flag2)
				{
					this.method_7(GEnum22.const_1, "1");
				}
				if (!flag3)
				{
					this.method_7(GEnum22.const_2, "1");
				}
				if (!flag4)
				{
					this.method_7(GEnum22.const_9, "1");
				}
				flag = true;
			}
			catch (Exception ex)
			{
				this.method_7(GEnum22.const_8, ex.ToString());
			}
			finally
			{
				if (intPtr != IntPtr.Zero)
				{
					GClass45.CloseHandle(intPtr);
				}
			}
			return flag;
		}
		return flag;
	}

	// Token: 0x0600062B RID: 1579 RVA: 0x0005E088 File Offset: 0x0005C288
	private void method_53()
	{
		try
		{
			Process.GetProcesses();
		}
		catch
		{
			this.method_48();
		}
	}

	// Token: 0x0600062C RID: 1580 RVA: 0x0005E0B8 File Offset: 0x0005C2B8
	private void method_54()
	{
		try
		{
			Process.GetProcesses();
		}
		catch (Exception ex)
		{
			this.method_7(GEnum22.const_30, ex.ToString());
		}
	}

	// Token: 0x0600062D RID: 1581 RVA: 0x0005E0F0 File Offset: 0x0005C2F0
	private bool method_55(Process process_1, out long long_0)
	{
		long_0 = -1L;
		try
		{
			Process process = GClass49.smethod_27(process_1);
			if (process != null)
			{
				string text = null;
				try
				{
					text = process.MainModule.FileName;
				}
				catch (Win32Exception)
				{
					GClass49.smethod_22(process, out text);
				}
				if (text != null)
				{
					long_0 = this.method_5(GEnum21.const_0, GEnum48.const_3, text, null, GEnum51.const_2);
				}
				return true;
			}
		}
		catch (Exception ex)
		{
			this.method_7(GEnum22.const_29, ex.ToString());
		}
		return false;
	}

	// Token: 0x0600062E RID: 1582 RVA: 0x0005E180 File Offset: 0x0005C380
	private void method_56(Process process_1, GEnum48 genum48_0 = GEnum48.const_1)
	{
		IntPtr intPtr = IntPtr.Zero;
		if (process_1 == null)
		{
			return;
		}
		try
		{
			intPtr = GClass45.OpenProcess(1040, false, process_1.Id);
			bool flag = GClass49.smethod_16();
			string text = Class15.smethod_6().ToLowerInvariant();
			string text2 = Class15.smethod_4().ToLowerInvariant();
			foreach (object obj in process_1.Modules)
			{
				ProcessModule processModule = (ProcessModule)obj;
				this.method_5(GEnum21.const_0, genum48_0, processModule.FileName, null, GEnum51.const_2);
				if (intPtr != IntPtr.Zero)
				{
					string text3 = GClass45.smethod_7(intPtr, processModule.BaseAddress);
					string text4;
					if (text3 == null)
					{
						text4 = string.Empty;
					}
					else
					{
						text4 = text3.ToLowerInvariant();
						if (flag)
						{
							text4 = text4.Replace(text, text2);
						}
					}
					string text5 = Path.GetFullPath(processModule.FileName);
					text5 = text5.ToLowerInvariant();
					if (flag)
					{
						text5 = text5.Replace(text, text2);
					}
					if (text4 != text5)
					{
						bool flag2 = true;
						string text6;
						long num;
						if (text4.Length <= 0)
						{
							text6 = Class14.String_208 + Class14.String_9 + processModule.FileName;
							num = -1L;
						}
						else
						{
							string text7 = Class15.smethod_8(text3);
							string text8 = Class15.smethod_8(processModule.FileName);
							if (text7 == text8 && text7 != Class14.String_215)
							{
								flag2 = false;
								text6 = "";
								num = -1L;
							}
							else
							{
								text6 = text3 + Class14.String_9 + processModule.FileName;
								num = this.method_5(GEnum21.const_9, GEnum48.const_4, text3, null, GEnum51.const_2);
							}
						}
						if (flag2)
						{
							this.method_4(GEnum21.const_9, text6, -1, num, GEnum23.const_0);
						}
					}
				}
			}
		}
		catch
		{
			this.method_48();
		}
		finally
		{
			if (intPtr != IntPtr.Zero)
			{
				GClass45.CloseHandle(intPtr);
			}
		}
	}

	// Token: 0x0600062F RID: 1583 RVA: 0x0005E3C0 File Offset: 0x0005C5C0
	private void method_57()
	{
		try
		{
			string string_ = Class14.String_73;
			string text = Class14.String_2;
			string string_2 = Class14.String_13;
			string string_3 = Class14.String_51;
			string string_4 = Class14.String_136;
			string string_5 = Class14.String_63;
			string string_6 = Class14.String_106;
			string[] array = Class15.smethod_15(this.gclass51_0.String_2, string_, true);
			if (array != null)
			{
				for (int i = 0; i < array.Length; i++)
				{
					try
					{
						string text2 = array[i].ToLower();
						if (!text2.EndsWith(text) && !text2.EndsWith(string_2) && !text2.EndsWith(string_3) && !text2.EndsWith(string_4) && !text2.EndsWith(string_5) && !text2.EndsWith(string_6))
						{
							if (GClass17.smethod_2(array[i], false))
							{
								this.method_5(GEnum21.const_0, GEnum48.const_2, array[i], null, GEnum51.const_2);
							}
						}
						else
						{
							this.method_5(GEnum21.const_0, GEnum48.const_2, array[i], null, GEnum51.const_2);
						}
					}
					catch (Exception ex)
					{
						this.method_7(GEnum22.const_25, ex.ToString());
					}
				}
			}
		}
		catch (Exception ex2)
		{
			this.method_7(GEnum22.const_26, ex2.ToString());
		}
	}

	// Token: 0x06000630 RID: 1584 RVA: 0x0005E4F8 File Offset: 0x0005C6F8
	private void method_58()
	{
		try
		{
			string[] array = Class15.smethod_15(this.gclass51_0.String_2, Class14.String_159, true);
			this.method_60(array);
		}
		catch (Exception ex)
		{
			this.method_7(GEnum22.const_23, ex.ToString());
		}
		try
		{
			string[] array2 = Class15.smethod_15(this.gclass51_0.String_2, Class14.String_219, true);
			this.method_60(array2);
		}
		catch (Exception ex2)
		{
			this.method_7(GEnum22.const_23, ex2.ToString());
		}
	}

	// Token: 0x06000631 RID: 1585 RVA: 0x0005E584 File Offset: 0x0005C784
	private void method_59()
	{
		string[] string_ = Class14.String_57;
		for (int i = 0; i < string_.Length; i++)
		{
			string text = Path.Combine(this.gclass51_0.String_2, string_[i]);
			if (File.Exists(text))
			{
				string text2 = Class15.smethod_11(text);
				string text3 = Class15.smethod_8(text);
				text = string.Format("{0}|{1}|{2}", Path.GetFileName(string_[i]), text2, text3);
				this.gclass51_0.List_2.Add(text);
			}
		}
		StringBuilder stringBuilder = new StringBuilder();
		foreach (string text4 in string_)
		{
			stringBuilder.Append(text4);
		}
		this.gclass51_0.String_11 = Class15.smethod_13(stringBuilder.ToString());
	}

	// Token: 0x06000632 RID: 1586 RVA: 0x0005E648 File Offset: 0x0005C848
	private void method_60(string[] string_6)
	{
		if (string_6 == null)
		{
			return;
		}
		try
		{
			string string_7 = Class14.String_61;
			int i = 0;
			while (i < string_6.Length)
			{
				long num = Class15.smethod_17(string_6[i]);
				string fileName = Path.GetFileName(string_6[i]);
				bool flag = false;
				long num2 = -1L;
				int num3;
				try
				{
					string text = Class15.smethod_18(string_6[i]);
					flag = Class15.smethod_16(text);
					num3 = Class15.smethod_20(text, string_7);
				}
				catch
				{
					num3 = -1;
				}
				try
				{
					IL_62:
					num2 = new FileInfo(string_6[i]).Length;
				}
				catch
				{
					num2 = -1L;
				}
				string text2 = string.Format("{0}|{1}|{2}|{3}|{4}|{5}|{6}", new object[]
				{
					Class15.smethod_22(fileName),
					Class15.smethod_11(string_6[i]),
					Class15.smethod_8(string_6[i]),
					flag ? "1" : "0",
					num3,
					num,
					num2
				});
				this.gclass51_0.List_3.Add(text2);
				i++;
				continue;
				//goto IL_62;
			}
		}
		catch (Exception ex)
		{
			this.method_7(GEnum22.const_22, ex.ToString());
		}
	}

	// Token: 0x06000633 RID: 1587 RVA: 0x0005E7BC File Offset: 0x0005C9BC
	private IntPtr[] method_61(string[] string_6)
	{
		IntPtr zero = IntPtr.Zero;
		try
		{
			IntPtr[] array = new IntPtr[string_6.Length];
			int num = 0;
			do
			{
				try
				{
					IntPtr procAddress = GClass45.GetProcAddress(zero, string_6[num]);
					if (!(procAddress != IntPtr.Zero))
					{
						array[num] = procAddress;
					}
					else
					{
						IntPtr intPtr = IntPtr.Zero;
						array[num] = (IntPtr)(procAddress.ToInt64() - intPtr.ToInt64());
					}
				}
				catch
				{
				}
				num++;
			}
			while (num < string_6.Length);
			return array;
		}
		catch (Win32Exception)
		{
			this.method_48();
		}
		catch (Exception ex)
		{
			this.method_7(GEnum22.const_40, ex.ToString());
		}
		finally
		{
			if (zero != IntPtr.Zero)
			{
				GClass45.FreeLibrary(zero);
			}
		}
		return null;
	}

	// Token: 0x06000634 RID: 1588 RVA: 0x0005E894 File Offset: 0x0005CA94
	private static ProcessModule smethod_4(ProcessModuleCollection processModuleCollection_0, string string_6)
	{
		if (processModuleCollection_0 != null && string_6 != null)
		{
			string text = string_6.ToLower();
			for (int i = 0; i < processModuleCollection_0.Count; i++)
			{
				if (processModuleCollection_0[i].FileName.ToLower() == text)
				{
					return processModuleCollection_0[i];
				}
			}
			return null;
		}
		return null;
	}

	// Token: 0x06000635 RID: 1589 RVA: 0x0005E8E8 File Offset: 0x0005CAE8
	private bool method_62(Process process_1)
	{
		IntPtr intPtr = IntPtr.Zero;
		string[] string_ = Class14.String_45;
		bool flag2;
		try
		{
			intPtr = GClass45.OpenProcess(1040, false, process_1.Id);
			if (!(intPtr == IntPtr.Zero))
			{
				IntPtr[] array = this.method_61(string_);
				if (array != null && array.Length != 0)
				{
					ProcessModuleCollection modules = process_1.Modules;
					IntPtr intPtr2 = IntPtr.Zero;
					string string_2 = Class14.String_176;
					bool flag = GClass49.smethod_16();
					string text = Class15.smethod_4().ToLower();
					string text2 = Class15.smethod_6().ToLower();
					for (int i = 0; i < modules.Count; i++)
					{
						if (modules[i].ModuleName.ToLower() == string_2)
						{
							string text3 = modules[i].FileName.ToLower();
							if (text3.Contains(text) || (flag && text3.Contains(text2)))
							{
								intPtr2 = modules[i].BaseAddress;
								break;
							}
						}
					}
					if (intPtr2 != IntPtr.Zero)
					{
						byte[] array2 = new byte[5];
						Array.Clear(array2, 0, array2.Length);
						uint num = 0U;
						for (int j = 0; j < string_.Length; j++)
						{
							if (!(array[j] == IntPtr.Zero))
							{
								IntPtr intPtr3;
								try
								{
									intPtr3 = (IntPtr)(intPtr2.ToInt64() + array[j].ToInt64());
								}
								catch (Exception ex)
								{
									string text4 = ex.ToString() + "_" + string.Format("{0}_{1}", intPtr2.ToString("X8"), array[j].ToString("X8"));
									this.method_7(GEnum22.const_39, text4);
									goto IL_2EC;
								}
								if (GClass45.ReadProcessMemory(intPtr, intPtr3, array2, (uint)array2.Length, ref num) && (ulong)num == (ulong)((long)array2.Length))
								{
									if (array2[0] != 233)
									{
										if (array2[0] != 232)
										{
											if (array2[0] != 0)
											{
												goto IL_2EC;
											}
										}
									}
									IntPtr intPtr4 = (IntPtr)BitConverter.ToInt32(array2, 1);
									if (array2[0] == 233)
									{
										goto IL_205;
									}
									if (array2[0] == 232)
									{
										goto IL_205;
									}
									goto IL_2F7;
									IL_246:
									string text4;
									GEnum48 genum;
									long num2;
									if (text4 != null && text4.Length > 0)
									{
										num2 = this.method_5(GEnum21.const_2, genum, text4, null, GEnum51.const_2);
									}
									else
									{
										num2 = -1L;
									}
									string text5 = GClass49.smethod_19(this.process_0, intPtr4);
									this.method_4(GEnum21.const_2, string.Concat(new string[]
									{
										string_[j].ToString(),
										":",
										intPtr4.ToString("X8"),
										"_",
										array2[0].ToString("X2"),
										"_",
										text5
									}), -1, num2, GEnum23.const_0);
									goto IL_2EC;
									IL_2F7:
									text4 = GClass49.smethod_2(process_1, intPtr4);
									if (text4 != null)
									{
										goto IL_229;
									}
									text4 = GClass45.smethod_7(intPtr, intPtr4);
									if (text4 == null)
									{
										text4 = string.Empty;
									}
									genum = GEnum48.const_4;
									goto IL_246;
									IL_205:
									try
									{
										intPtr4 = (IntPtr)(intPtr3.ToInt32() + 5 + intPtr4.ToInt32());
										goto IL_2F7;
									}
									catch
									{
										goto IL_2F7;
									}
									IL_229:
									genum = GEnum48.const_1;
									goto IL_246;
								}
							}
							IL_2EC:;
						}
					}
					return true;
				}
				if (!this.method_47())
				{
					flag2 = true;
				}
				else
				{
					flag2 = false;
				}
			}
			else
			{
				flag2 = false;
			}
		}
		catch (Exception ex2)
		{
			this.method_7(GEnum22.const_38, ex2.ToString());
			return true;
		}
		finally
		{
			StringBuilder stringBuilder = new StringBuilder();
			foreach (string text6 in string_)
			{
				stringBuilder.Append(text6);
			}
			this.gclass51_0.String_12 = Class15.smethod_13(stringBuilder.ToString());
			if (intPtr != IntPtr.Zero)
			{
				GClass45.CloseHandle(intPtr);
			}
		}
		return flag2;
	}

	// Token: 0x06000636 RID: 1590 RVA: 0x0005ECF4 File Offset: 0x0005CEF4
	private bool method_63(Process process_1, bool bool_3 = false)
	{
		uint num = 0U;
		uint num2 = 0U;
		IntPtr intPtr = IntPtr.Zero;
		List<GClass40> list = null;
		try
		{
			list = GClass40.smethod_0(this.string_4);
		}
		catch
		{
			return false;
		}
		if (list != null && list.Count != 0)
		{
			try
			{
				intPtr = GClass45.OpenProcess(1040, false, process_1.Id);
				if (intPtr == IntPtr.Zero)
				{
					return false;
				}
				GClass45.GStruct4 gstruct = default(GClass45.GStruct4);
				IntPtr intPtr2 = IntPtr.Zero;
				IntPtr intPtr3 = IntPtr.Zero;
				IntPtr intPtr4 = IntPtr.Zero;
				GClass45.GStruct5 gstruct2 = default(GClass45.GStruct5);
				GClass45.GetSystemInfo(ref gstruct2);
				intPtr2 = gstruct2.intptr_0;
				intPtr3 = gstruct2.intptr_1;
				int num3 = 100;
				foreach (GClass40 gclass in list)
				{
					if (gclass.Byte_0 != null && num3 < gclass.Byte_0.Length)
					{
						num3 = gclass.Byte_0.Length;
					}
					if (gclass.String_0 != null && num3 < gclass.String_0.Length)
					{
						num3 = gclass.String_0.Length;
					}
				}
				bool flag = false;
				uint num4 = gstruct2.uint_1;
				if (num4 == 0U)
				{
					num4 = 4096U;
				}
				num2 = num4;
				byte[] array = new byte[num2];
				while (intPtr2.ToInt64() < intPtr3.ToInt64() && !this.method_47() && GClass45.VirtualQueryEx(intPtr, intPtr2, out gstruct, Marshal.SizeOf(gstruct)) > 0 && gstruct.intptr_2.ToInt64() != 0L)
				{
					intPtr4 = (IntPtr)(intPtr2.ToInt64() + gstruct.intptr_2.ToInt64());
					if (GClass49.smethod_9(gstruct))
					{
						uint num5 = GClass49.smethod_12(gstruct.uint_2);
						if (gstruct.uint_3 == 16777216U)
						{
							if (gstruct.uint_2 == 64U)
							{
								goto IL_241;
							}
							if (gstruct.uint_2 == 16U && gstruct.intptr_2.ToInt64() <= 65535L)
							{
								goto IL_241;
							}
							if ((num5 & 4U) != 4U && (num5 & 8U) != 8U && (num5 & 2U) == 2U)
							{
								goto IL_241;
							}
						}
						if (gstruct.uint_3 != 262144U)
						{
							if (gstruct.uint_3 != 131072U)
							{
								goto IL_63B;
							}
						}
						if ((num5 & 8U) != 8U)
						{
							goto IL_63B;
						}
						IL_241:
						IntPtr intPtr5 = intPtr2;
						IntPtr intPtr6 = intPtr5;
						num2 = num4;
						for (;;)
						{
							if (intPtr5.ToInt64() + (long)((ulong)num2) >= intPtr4.ToInt64())
							{
								num2 = (uint)(intPtr4.ToInt64() - intPtr5.ToInt64());
								Array.Clear(array, 0, array.Length);
							}
							if (!GClass45.ReadProcessMemory(intPtr, intPtr5, array, num2, ref num) || num <= 0U)
							{
								break;
							}
							try
							{
								int num6 = 0;
								foreach (GClass40 gclass2 in list)
								{
									if ((gclass2.GEnum20_0 & GEnum20.const_1) == GEnum20.const_1)
									{
										if ((gclass2.GEnum20_0 & GEnum20.const_3) == GEnum20.const_3)
										{
											int num7 = Class15.smethod_23(array, gclass2.Byte_0, gclass2.String_0, 0, 0);
											if (num7 >= 0)
											{
												bool flag2 = (gclass2.GEnum20_0 & GEnum20.const_5) == GEnum20.const_5;
												GEnum21 genum = GEnum21.const_1;
												if (flag2)
												{
													genum |= GEnum21.const_21;
												}
												string text = GClass49.smethod_2(process_1, gstruct.intptr_0);
												GEnum48 genum2;
												if (text != null)
												{
													genum2 = GEnum48.const_1;
												}
												else
												{
													text = GClass45.smethod_7(intPtr, gstruct.intptr_0);
													if (text == null)
													{
														text = string.Empty;
													}
													genum2 = GEnum48.const_4;
												}
												long num8;
												if (text != null && text.Length > 0)
												{
													num8 = this.method_5(genum, genum2, text.ToString(), null, GEnum51.const_2);
												}
												else
												{
													num8 = -1L;
												}
												string text2 = GClass49.smethod_19(process_1, gstruct.intptr_0);
												string text3 = Convert.ToBase64String(gclass2.Byte_0);
												string text4 = (intPtr5.ToInt32() + num7).ToString("X8");
												string text5 = string.Empty;
												try
												{
													byte[] array2 = new byte[gclass2.Byte_0.Length];
													Array.Copy(array, num7, array2, 0, array2.Length);
													text5 = "_" + Convert.ToBase64String(array2);
													goto IL_3EC;
												}
												catch
												{
													goto IL_3EC;
												}
												goto IL_3E1;
												IL_3EC:
												this.method_4(genum, string.Concat(new string[] { text2, "_", text3, "__", text4, text5 }), num6, num8, GEnum23.const_0);
												if (!flag2)
												{
													flag = true;
													break;
												}
											}
											IL_3E1:
											num6++;
											continue;
										}
									}
									num6++;
								}
								if (flag)
								{
									break;
								}
								string text6 = Encoding.UTF8.GetString(array).Replace("\0", "").ToLowerInvariant();
								num6 = 0;
								foreach (GClass40 gclass3 in list)
								{
									if ((gclass3.GEnum20_0 & GEnum20.const_2) == GEnum20.const_2)
									{
										if ((gclass3.GEnum20_0 & GEnum20.const_3) == GEnum20.const_3)
										{
											int num7 = text6.IndexOf(gclass3.String_0, StringComparison.Ordinal);
											if (num7 > -1)
											{
												bool flag3 = (gclass3.GEnum20_0 & GEnum20.const_5) == GEnum20.const_5;
												GEnum21 genum = GEnum21.const_1;
												if (flag3)
												{
													genum |= GEnum21.const_21;
												}
												string text7 = GClass49.smethod_2(process_1, gstruct.intptr_0);
												GEnum48 genum2;
												if (text7 != null)
												{
													genum2 = GEnum48.const_1;
												}
												else
												{
													text7 = GClass45.smethod_7(intPtr, gstruct.intptr_0);
													if (text7 == null)
													{
														text7 = string.Empty;
													}
													genum2 = GEnum48.const_4;
												}
												long num8;
												if (text7 != null && text7.Length > 0)
												{
													num8 = this.method_5(genum, genum2, text7.ToString(), null, GEnum51.const_2);
												}
												else
												{
													num8 = -1L;
												}
												string text8 = GClass49.smethod_19(process_1, gstruct.intptr_0);
												this.method_4(genum, text8 + "_" + gclass3.String_0.Trim().Trim(new char[] { '\n' }).Trim(new char[1]), num6, num8, GEnum23.const_0);
												if (!flag3)
												{
													flag = true;
													break;
												}
											}
											num6++;
											continue;
										}
									}
									num6++;
								}
								goto IL_644;
							}
							catch
							{
								goto IL_644;
							}
							IL_5CE:
							intPtr6 = (IntPtr)(intPtr6.ToInt64() + (long)((ulong)num2));
							intPtr5 = (IntPtr)(intPtr6.ToInt64() - (long)num3);
							if ((ulong)num2 == (ulong)((long)num3))
							{
								break;
							}
							if (intPtr5.ToInt64() >= intPtr4.ToInt64())
							{
								break;
							}
							if (this.method_47())
							{
								break;
							}
							continue;
							IL_644:
							if (!flag)
							{
								goto IL_5CE;
							}
							break;
						}
						IL_637:
						if (!flag)
						{
							goto IL_63B;
						}
						break;
						goto IL_637;
					}
					IL_63B:
					intPtr2 = intPtr4;
				}
			}
			catch (Exception ex)
			{
				this.method_7(GEnum22.const_24, ex.ToString());
			}
			finally
			{
				StringBuilder stringBuilder = new StringBuilder();
				foreach (GClass40 gclass4 in list)
				{
					stringBuilder.Append(gclass4.String_0);
					if ((gclass4.GEnum20_0 & GEnum20.const_1) == GEnum20.const_1)
					{
						stringBuilder.Append(Convert.ToBase64String(gclass4.Byte_0));
					}
				}
				this.gclass51_0.String_13 = Class15.smethod_13(stringBuilder.ToString());
				if (intPtr != IntPtr.Zero)
				{
					GClass45.CloseHandle(intPtr);
				}
			}
			return true;
		}
		return false;
	}

	// Token: 0x06000637 RID: 1591 RVA: 0x0005F4DC File Offset: 0x0005D6DC
	private bool method_64(Process process_1, bool bool_3 = false)
	{
		IntPtr intPtr = IntPtr.Zero;
		GClass45.GStruct4 gstruct = default(GClass45.GStruct4);
		IntPtr intPtr2 = IntPtr.Zero;
		GClass45.GStruct5 gstruct2 = default(GClass45.GStruct5);
		GClass45.GetSystemInfo(ref gstruct2);
		IntPtr intPtr3 = gstruct2.intptr_0;
		IntPtr intptr_ = gstruct2.intptr_1;
		GEnum48 genum = GEnum48.const_4;
		GEnum23 genum2;
		if (bool_3)
		{
			genum |= GEnum48.const_5;
			genum2 = GEnum23.const_22;
		}
		else
		{
			genum2 = GEnum23.const_0;
		}
		intPtr = GClass45.OpenProcess(1040, false, process_1.Id);
		if (!(intPtr == IntPtr.Zero))
		{
			List<WCD.Class18> list = new List<WCD.Class18>();
			while (GClass45.VirtualQueryEx(intPtr, intPtr3, out gstruct, Marshal.SizeOf(gstruct)) != 0 && !this.method_47() && intPtr3.ToInt64() < intptr_.ToInt64() && gstruct.intptr_2.ToInt64() != 0L)
			{
				if (GClass49.smethod_9(gstruct))
				{
					uint num;
					intPtr2 = GClass49.smethod_20(process_1, intPtr, gstruct.intptr_0, out num, true);
					if (gstruct.uint_3 == 16777216U)
					{
						string text = GClass45.smethod_7(intPtr, gstruct.intptr_0);
						if (text != null && text != "")
						{
							WCD.Class18 @class = WCD.Class18.smethod_0(list, text);
							if (@class != null)
							{
								string text2 = GClass49.smethod_19(process_1, gstruct.intptr_0);
								string text3 = GClass49.smethod_19(process_1, @class.IntPtr_0);
								string text4 = string.Format("{0}{1}{2}", text2, Class15.char_0, text3);
								this.method_4(GEnum21.const_20, text4, -1, -1L, genum2);
							}
							else
							{
								list.Add(new WCD.Class18(text, gstruct.intptr_0, intPtr2));
							}
						}
					}
					if (intPtr3.ToInt64() == intPtr2.ToInt64())
					{
						intPtr3 = (IntPtr)(intPtr3.ToInt64() + gstruct.intptr_2.ToInt64());
					}
					else
					{
						intPtr3 = intPtr2;
					}
				}
				else
				{
					intPtr3 = (IntPtr)(intPtr3.ToInt64() + gstruct.intptr_2.ToInt64());
				}
			}
			GClass45.CloseHandle(intPtr);
			return true;
		}
		return false;
	}

	// Token: 0x06000638 RID: 1592 RVA: 0x0005F6CC File Offset: 0x0005D8CC
	private bool method_65(Process process_1, bool bool_3 = false, bool bool_4 = false)
	{
		IntPtr intPtr = IntPtr.Zero;
		GClass45.GStruct4 gstruct = default(GClass45.GStruct4);
		IntPtr intPtr2 = IntPtr.Zero;
		IntPtr intPtr3 = IntPtr.Zero;
		GClass45.GStruct5 gstruct2 = default(GClass45.GStruct5);
		GClass45.GetSystemInfo(ref gstruct2);
		IntPtr intPtr4 = gstruct2.intptr_0;
		IntPtr intptr_ = gstruct2.intptr_1;
		GEnum48 genum = GEnum48.const_4;
		GEnum23 genum2 = GEnum23.const_0;
		if (!bool_3)
		{
			genum2 = GEnum23.const_0;
		}
		else
		{
			genum |= GEnum48.const_5;
			genum2 = GEnum23.const_22;
		}
		intPtr = GClass45.OpenProcess(1040, false, process_1.Id);
		if (!(intPtr == IntPtr.Zero))
		{
			uint num = 32U;
			uint num2 = gstruct2.uint_1;
			if (num2 == 0U)
			{
				num2 = 4096U;
			}
			_ = (new byte[num * num2]);
			while (GClass45.VirtualQueryEx(intPtr, intPtr4, out gstruct, Marshal.SizeOf(gstruct)) != 0 && !this.method_47() && intPtr4.ToInt64() < intptr_.ToInt64() && gstruct.intptr_2.ToInt64() != 0L)
			{
				if (!GClass49.smethod_9(gstruct))
				{
					intPtr4 = (IntPtr)(intPtr4.ToInt64() + gstruct.intptr_2.ToInt64());
				}
				else if (gstruct.uint_3 == 16777216U)
				{
					uint num3;
					intPtr2 = GClass49.smethod_20(process_1, intPtr, gstruct.intptr_0, out num3, true);
					if (intPtr2 != IntPtr.Zero)
					{
						string text = GClass45.smethod_7(intPtr, gstruct.intptr_0);
						if (text != null && text.Length != 0)
						{
							if (text.Length > 0 && (GClass49.smethod_14(num3) || (!bool_4 && GClass17.smethod_5(intPtr, gstruct.intptr_0)) || !GClass17.smethod_1(intPtr, gstruct.intptr_0)) && !GClass49.smethod_7(process_1, gstruct.intptr_0) && !GClass49.smethod_21(text))
							{
								long num4 = this.method_5(GEnum21.const_5, genum, text.ToString(), null, GEnum51.const_1);
								string text2 = GClass49.smethod_19(process_1, gstruct.intptr_0);
								this.method_4(GEnum21.const_5, text2, -1, num4, genum2);
							}
						}
						else
						{
							string text3 = GClass49.smethod_19(process_1, gstruct.intptr_0);
							this.method_4(GEnum21.const_14, text3, -1, -1L, genum2);
						}
					}
					if (intPtr4.ToInt64() == intPtr2.ToInt64())
					{
						intPtr4 = (IntPtr)(intPtr4.ToInt64() + gstruct.intptr_2.ToInt64());
					}
					else
					{
						intPtr4 = intPtr2;
					}
				}
				else
				{
					if (gstruct.uint_3 == 262144U && (GClass49.smethod_14(gstruct.uint_2) || (!bool_4 && GClass17.smethod_5(intPtr, gstruct.intptr_0))))
					{
						string text4 = GClass45.smethod_7(intPtr, gstruct.intptr_0);
						if (GClass17.smethod_1(intPtr, gstruct.intptr_0))
						{
							long num4;
							if (text4 != null && text4.Length > 0)
							{
								num4 = this.method_5(GEnum21.const_6, genum, text4.ToString(), null, GEnum51.const_2);
							}
							else
							{
								num4 = -1L;
							}
							string text5 = GClass49.smethod_19(process_1, gstruct.intptr_0);
							this.method_4(GEnum21.const_6, text5, -1, num4, genum2);
						}
						else
						{
							if (text4 != null && text4.Length > 0)
							{
								try
								{
									if (GClass17.smethod_2(text4.ToString(), false))
									{
										long num4 = this.method_5(GEnum21.const_8, genum, text4.ToString(), null, GEnum51.const_2);
										string text6 = GClass49.smethod_19(process_1, gstruct.intptr_0);
										this.method_4(GEnum21.const_7, text6, -1, num4, genum2);
									}
									goto IL_47D;
								}
								catch
								{
									goto IL_47D;
								}
							}
							string text7 = GClass49.smethod_19(process_1, gstruct.intptr_0);
							this.method_4(GEnum21.const_6, text7, -1, -1L, genum2);
						}
					}
					else if (gstruct.uint_3 == 131072U)
					{
						if (GClass17.smethod_1(intPtr, gstruct.intptr_0) && (GClass49.smethod_14(gstruct.uint_2) || (!bool_4 && GClass17.smethod_5(intPtr, gstruct.intptr_0))))
						{
							string text8 = GClass49.smethod_19(process_1, gstruct.intptr_0);
							this.method_4(GEnum21.const_8, text8, -1, -1L, genum2);
						}
						else if (gstruct.uint_2 == 2U)
						{
							if (GClass17.smethod_1(intPtr, gstruct.intptr_0))
							{
								intPtr3 = (IntPtr)(intPtr4.ToInt64() + gstruct.intptr_2.ToInt64());
								if (GClass49.smethod_13(intPtr, intPtr3))
								{
									string text9 = GClass49.smethod_19(process_1, gstruct.intptr_0);
									this.method_4(GEnum21.const_8, text9, -1, -1L, genum2);
								}
							}
						}
					}
					IL_47D:
					uint num3;
					intPtr2 = GClass49.smethod_20(process_1, intPtr, gstruct.intptr_0, out num3, true);
					if (intPtr4.ToInt64() == intPtr2.ToInt64())
					{
						intPtr4 = (IntPtr)(intPtr4.ToInt64() + gstruct.intptr_2.ToInt64());
					}
					else
					{
						intPtr4 = intPtr2;
					}
				}
			}
			GClass45.CloseHandle(intPtr);
			return true;
		}
		return false;
	}

	// Token: 0x06000639 RID: 1593 RVA: 0x0005FB94 File Offset: 0x0005DD94
	private IntPtr method_66(int int_2)
	{
		IntPtr intPtr = IntPtr.Zero;
		IntPtr intPtr2 = IntPtr.Zero;
		try
		{
			intPtr2 = GClass45.OpenThread(8U, false, (uint)int_2);
			if (intPtr2 == IntPtr.Zero)
			{
				return intPtr;
			}
			GClass45.GStruct12 gstruct = default(GClass45.GStruct12);
			gstruct.uint_0 = 65543U;
			if (GClass45.GetThreadContext(intPtr2, ref gstruct))
			{
				intPtr = (IntPtr)((long)((ulong)gstruct.uint_18));
			}
		}
		catch (Exception ex)
		{
			this.method_7(GEnum22.const_16, ex.ToString());
		}
		finally
		{
			if (intPtr2 != IntPtr.Zero)
			{
				GClass45.CloseHandle(intPtr2);
			}
		}
		return intPtr;
	}

	// Token: 0x0600063A RID: 1594 RVA: 0x0005FC3C File Offset: 0x0005DE3C
	private bool method_67(Process process_1, GEnum48 genum48_0, bool bool_3, GEnum23 genum23_0, ref int int_2, ref double double_0, ref double double_1)
	{
		IntPtr intPtr = IntPtr.Zero;
		bool flag = false;
		GClass45.GStruct4 gstruct = default(GClass45.GStruct4);
		double_0 = 0.0;
		double_1 = 0.0;
		int_2 = 0;
		bool flag3;
		try
		{
			intPtr = GClass45.OpenProcess(1040, false, process_1.Id);
			if (!(intPtr == IntPtr.Zero))
			{
				ProcessThreadCollection threads = process_1.Threads;
				GClass49.smethod_16();
				Environment.GetFolderPath(Environment.SpecialFolder.System).ToLower();
				TimeSpan timeSpan = default(TimeSpan);
				TimeSpan timeSpan2 = default(TimeSpan);
				List<WCD.Class19> list = new List<WCD.Class19>();
				long num = process_1.MainModule.BaseAddress.ToInt64();
				long num2 = num + (long)process_1.MainModule.ModuleMemorySize;
				int num3 = 0;
				while (num3 < threads.Count && !this.method_47())
				{
					try
					{
						timeSpan += threads[num3].TotalProcessorTime;
					}
					catch (Win32Exception)
					{
					}
					catch (InvalidOperationException)
					{
					}
					IntPtr intPtr2 = GClass49.smethod_0((uint)threads[num3].Id);
					if (!(intPtr2 != IntPtr.Zero))
					{
						goto IL_280;
					}
					IntPtr intPtr3 = GClass49.smethod_8(process_1, intPtr2);
					if (!(intPtr3 == IntPtr.Zero))
					{
						if (intPtr2.ToInt64() >= num && intPtr2.ToInt64() < num2)
						{
							int_2++;
							try
							{
								if (threads[num3].TotalProcessorTime < timeSpan2)
								{
									timeSpan2 = threads[num3].TotalProcessorTime;
								}
								goto IL_32A;
							}
							catch (Win32Exception)
							{
								goto IL_32A;
							}
							catch (InvalidOperationException)
							{
								goto IL_32A;
							}
						}
						try
						{
							list.Add(new WCD.Class19(threads[num3].Id, threads[num3].TotalProcessorTime, intPtr2, intPtr3));
							goto IL_32A;
						}
						catch (Win32Exception)
						{
							goto IL_32A;
						}
						catch (InvalidOperationException)
						{
							goto IL_32A;
						}
						goto IL_280;
					}
					try
					{
						list.Add(new WCD.Class19(threads[num3].Id, threads[num3].TotalProcessorTime, intPtr2, intPtr3));
					}
					catch (Win32Exception)
					{
					}
					catch (InvalidOperationException)
					{
					}
					bool flag2 = false;
					if (GClass49.smethod_13(intPtr, intPtr2))
					{
						flag2 = true;
					}
					else if (!bool_3 && GClass45.VirtualQueryEx(intPtr, intPtr2, out gstruct, Marshal.SizeOf(gstruct)) > 0 && GClass17.smethod_5(intPtr, intPtr2))
					{
						flag2 = true;
					}
					if (flag2)
					{
						string text = GClass45.smethod_7(intPtr, intPtr2);
						long num4;
						if (text != null && text.Length > 0)
						{
							num4 = this.method_5(GEnum21.const_3, genum48_0, text, null, GEnum51.const_2);
						}
						else
						{
							num4 = -1L;
						}
						string text2 = GClass49.smethod_19(process_1, intPtr2);
						this.method_4(GEnum21.const_3, text2, -1, num4, genum23_0);
						goto IL_32A;
					}
					goto IL_32A;
					IL_31F:
					num3++;
					continue;
					IL_2B7:
					IntPtr intPtr4;
					intPtr3 = GClass49.smethod_8(process_1, intPtr4);
					if (intPtr3 == IntPtr.Zero)
					{
						string text3 = GClass45.smethod_7(intPtr, intPtr2);
						long num4;
						if (text3 != null && text3.Length > 0)
						{
							num4 = this.method_5(GEnum21.const_4, genum48_0, text3, null, GEnum51.const_2);
						}
						else
						{
							num4 = -1L;
						}
						string text2 = GClass49.smethod_19(process_1, intPtr4);
						this.method_4(GEnum21.const_4, text2, -1, num4, genum23_0);
						goto IL_31F;
					}
					goto IL_31F;
					IL_280:
					try
					{
						list.Add(new WCD.Class19(threads[num3].Id, threads[num3].TotalProcessorTime, intPtr2, IntPtr.Zero));
						goto IL_32A;
					}
					catch (Win32Exception)
					{
						goto IL_32A;
					}
					catch (InvalidOperationException)
					{
						goto IL_32A;
					}
					goto IL_2B7;
					IL_32A:
					intPtr4 = this.method_66(threads[num3].Id);
					if (intPtr4 != IntPtr.Zero)
					{
						goto IL_2B7;
					}
					goto IL_31F;
				}
				double_0 = (process_1.TotalProcessorTime - timeSpan).TotalMilliseconds;
				if (list.Count > 0)
				{
					WCD.Class19 @class = list[0];
					for (int i = 1; i < list.Count; i++)
					{
						if (list[i].TimeSpan_0 > @class.TimeSpan_0)
						{
							@class = list[i];
						}
					}
					double_1 = @class.TimeSpan_0.TotalMilliseconds;
					string text4 = GClass45.smethod_7(intPtr, @class.IntPtr_0);
					long num4;
					if (text4 != null && text4.Length > 0)
					{
						num4 = this.method_5(GEnum21.const_22, genum48_0, text4, null, GEnum51.const_2);
					}
					else
					{
						num4 = -1L;
					}
					string text2 = GClass49.smethod_19(process_1, @class.IntPtr_0);
					this.method_4(GEnum21.const_22, text2, -1, num4, genum23_0);
				}
				return true;
			}
			this.method_7(GEnum22.const_27, Marshal.GetLastWin32Error().ToString());
			flag3 = flag;
		}
		catch (Exception ex)
		{
			this.method_7(GEnum22.const_28, ex.ToString());
			return flag;
		}
		finally
		{
			if (intPtr != IntPtr.Zero)
			{
				GClass45.CloseHandle(intPtr);
			}
		}
		return flag3;
	}

	// Token: 0x0600063B RID: 1595 RVA: 0x000601F4 File Offset: 0x0005E3F4
	public string method_68()
	{
		IntPtr intPtr = IntPtr.Zero;
		if (this.process_0 != null && !this.method_47())
		{
			GClass45.GStruct4 gstruct = default(GClass45.GStruct4);
			GClass45.GStruct5 gstruct2 = default(GClass45.GStruct5);
			GClass45.GetSystemInfo(ref gstruct2);
			uint num = 0U;
			List<GClass52> list = new List<GClass52>();
			string text = null;
			try
			{
				List<GClass53> list2 = new List<GClass53>
				{
					new GClass53(Class14.Byte_6, Class14.String_168, Class14.int_366),
					new GClass53(Class14.Byte_8, Class14.String_153, Class14.int_358),
					new GClass53(Class14.Byte_23, Class14.String_70, Class14.int_242),
					new GClass53(Class14.Byte_16, Class14.String_211, Class14.int_27),
					new GClass53(Class14.Byte_17, Class14.String_27, Class14.int_180),
					new GClass53(Class14.Byte_54, Class14.String_120, Class14.int_32),
					new GClass53(Class14.Byte_18, Class14.String_192, Class14.int_155)
				};
				GClass52 gclass = new GClass52(Class14.String_235, Class15.smethod_7(Path.Combine(this.gclass51_0.String_2, Class14.String_235)), list2, false);
				list.Add(gclass);
				GClass52 gclass2 = new GClass52(Class14.String_116, Class15.smethod_7(Path.Combine(this.gclass51_0.String_2, Class14.String_116)), list2, false);
				list.Add(gclass2);
				GClass52 gclass3 = new GClass52(this.process_0.MainModule.ModuleName, this.process_0.MainModule.FileName, list2, false);
				list.Add(gclass3);
				IntPtr intPtr2 = IntPtr.Zero;
				byte[] array = new byte[40];
				Array.Clear(array, 0, array.Length);
				uint num2 = gstruct2.uint_1;
				if (num2 == 0U)
				{
					num2 = 4096U;
				}
				uint num3 = num2;
				byte[] array2 = new byte[num3];
				int num4 = 100;
				intPtr = GClass45.OpenProcess(1040, false, this.process_0.Id);
				if (intPtr != IntPtr.Zero)
				{
					int num5 = 0;
					while (num5 < list.Count && !this.method_47())
					{
						GClass52 gclass4 = list[num5];
						ProcessModule processModule = GClass49.smethod_5(this.process_0, gclass4.String_0, gclass4.String_1, GClass49.GEnum43.const_3);
						if (processModule != null)
						{
							num4 = gclass4.method_0();
							IntPtr intPtr3 = processModule.BaseAddress;
							IntPtr intPtr4 = (IntPtr)(processModule.BaseAddress.ToInt64() + (long)processModule.ModuleMemorySize);
							try
							{
								while (!this.method_47() && intPtr3.ToInt64() < intPtr4.ToInt64() && GClass45.VirtualQueryEx(intPtr, intPtr3, out gstruct, Marshal.SizeOf(gstruct)) > 0)
								{
									IntPtr intPtr5 = (IntPtr)(intPtr3.ToInt64() + gstruct.intptr_2.ToInt64());
									if (gstruct.uint_2 != 16U && gstruct.uint_2 != 32U)
									{
										if (gstruct.uint_2 != 64U)
										{
											if (gstruct.uint_2 != 128U)
											{
												if (gstruct.uint_2 != 4U)
												{
													goto IL_5C6;
												}
											}
										}
									}
									if (GClass49.smethod_9(gstruct))
									{
										IntPtr intPtr6 = intPtr3;
										IntPtr intPtr7 = intPtr6;
										num3 = num2;
										do
										{
											if (intPtr6.ToInt64() + (long)((ulong)num3) > intPtr5.ToInt64())
											{
												num3 = (uint)(intPtr5.ToInt64() - intPtr6.ToInt64());
												Array.Clear(array2, 0, array2.Length);
											}
											if (!GClass45.ReadProcessMemory(intPtr, intPtr6, array2, num3, ref num) || num != num3)
											{
												break;
											}
											int num6 = 0;
											while (num6 < gclass4.List_0.Count && !this.method_47())
											{
												GClass53 gclass5 = gclass4.List_0[num6];
												int num7 = 0;
												do
												{
													num7 = Class15.smethod_23(array2, gclass5.Byte_0, gclass5.String_0, num7, 0);
													if (num7 > -1)
													{
														int num8 = num7 + gclass5.Int32_0[0];
														try
														{
															if ((long)(num8 + 4) >= (long)((ulong)num3))
															{
																break;
															}
															intPtr2 = (IntPtr)((long)((ulong)BitConverter.ToUInt32(array2, num8)));
															if (intPtr2.ToInt64() >= processModule.BaseAddress.ToInt64() && intPtr2.ToInt64() < intPtr4.ToInt64())
															{
																if (!GClass45.ReadProcessMemory(intPtr, intPtr2, array, (uint)array.Length, ref num) || (ulong)num != (ulong)((long)array.Length))
																{
																	Array.Clear(array, 0, array.Length);
																	break;
																}
																uint num9 = BitConverter.ToUInt32(array, 0);
																if (num9 == 1U)
																{
																	text = "loopback";
																	return text;
																}
																if (num9 != 3U)
																{
																	if (num9 != 0U)
																	{
																		int num10 = 0;
																		int i = 4;
																		while (i < 18)
																		{
																			num10++;
																			string text2 = text;
																			string text3 = array[i].ToString("X2");
																			if (i == 4 || num10 % 2 != 0)
																			{
																				goto IL_492;
																			}
																			if (i + 1 == 18)
																			{
																				goto IL_492;
																			}
																			string text4 = ":";
																			IL_497:
																			text = text2 + text3 + text4;
																			i++;
																			continue;
																			IL_492:
																			text4 = "";
																			goto IL_497;
																		}
																	}
																}
																else
																{
																	for (int j = 4; j < 8; j++)
																	{
																		string text5 = text;
																		int num11 = (int)array[j];
																		text = text5 + num11.ToString() + ((j + 1 == 8) ? "" : ".");
																	}
																}
																if (num9 != 0U && Class15.smethod_24(text))
																{
																	text = string.Format("{0}:{1}", text, (ushort)(((int)array[18] << 8) | (int)array[19]));
																	return text;
																}
															}
															goto IL_5CD;
														}
														catch (OverflowException)
														{
															goto IL_5CD;
														}
														goto IL_546;
														IL_5CD:
														num7 += gclass5.Byte_0.Length;
													}
													if (num7 <= -1)
													{
														break;
													}
												}
												while (!this.method_47());
												IL_5B4:
												num6++;
												continue;
												goto IL_5B4;
											}
											IL_546:
											intPtr7 = (IntPtr)(intPtr7.ToInt64() + (long)((ulong)num3));
											intPtr6 = (IntPtr)(intPtr7.ToInt64() - (long)num4);
											if ((ulong)num3 == (ulong)((long)num4))
											{
												break;
											}
											if (intPtr6.ToInt64() >= intPtr5.ToInt64())
											{
												break;
											}
										}
										while (!this.method_47());
										IL_5BF:
										intPtr3 = intPtr5;
										continue;
										goto IL_5BF;
									}
									IL_5C6:
									intPtr3 = intPtr5;
								}
							}
							catch (Exception ex)
							{
								this.method_7(GEnum22.const_32, ex.ToString());
							}
						}
						num5++;
					}
				}
			}
			catch (Exception ex2)
			{
				this.method_7(GEnum22.const_33, ex2.ToString());
			}
			finally
			{
				if (intPtr != IntPtr.Zero)
				{
					GClass45.CloseHandle(intPtr);
				}
			}
			return text;
		}
		return null;
	}

	// Token: 0x0600063C RID: 1596 RVA: 0x00060898 File Offset: 0x0005EA98
	private void method_69()
	{
		if (!this.method_47())
		{
			Interlocked.Increment(ref this.int_0);
			base.Invoke(new MethodInvoker(this.method_92));
		}
	}

	// Token: 0x0600063D RID: 1597 RVA: 0x000608CC File Offset: 0x0005EACC
	private string method_70()
	{
		string text = null;
		try
		{
            base.Invoke(new MethodInvoker(this.method_93));
			GClass56 gclass = new GClass56();
			gclass.Proxy = null;
			gclass.Int32_0 = Class15.int_0;
			gclass.Headers.Add(HttpRequestHeader.UserAgent, Class12.String_5);
			gclass.Headers.Add(HttpRequestHeader.ContentType, "application/x-www-form-urlencoded");
			NameValueCollection nameValueCollection = new NameValueCollection();
            string text2 = Class50.smethod_0(this.method_80(this.byte_0), this.string_1);
			byte[] array = Class13.smethod_1(32);
			string text3 = Class13.smethod_5(text2, array);
			string text4 = Class13.smethod_13(Convert.ToBase64String(array));
			string text5 = Class13.smethod_14(text3 + text4);
			nameValueCollection["sd"] = text3;
			nameValueCollection["sa"] = text4;
			nameValueCollection["sn"] = text5;
			byte[] array2 = null;

			try
			{
				array2 = gclass.UploadValues(Class12.smethod_2(Class12.Boolean_0, "token"), "POST", nameValueCollection);
			}
			catch (WebException ex)
			{
				if (ex.InnerException == null)
				{
					throw ex;
				}
				if (!(ex.InnerException is AuthenticationException) && !(ex.InnerException is IOException))
				{
					throw ex;
				}

				Class12.Boolean_0 = false;
				gclass = new GClass56();
				gclass.Proxy = null;
				gclass.Int32_0 = Class15.int_0;
				gclass.Headers.Add(HttpRequestHeader.UserAgent, Class12.String_5);
				gclass.Headers.Add(HttpRequestHeader.ContentType, "application/x-www-form-urlencoded");
				array2 = gclass.UploadValues(Class12.smethod_2(Class12.Boolean_0, "token"), "POST", nameValueCollection);
			}

			string @string = Encoding.UTF8.GetString(array2);
			bool flag = false;
			if (!@string.Contains(Class14.String_220))
			{
				if (!@string.Contains(Class14.String_183))
				{
					if (!@string.Contains(Class14.String_78))
					{
						if (@string.Contains(Class14.String_97))
						{
							WCD.Class24 @class = new WCD.Class24();
							@class.wcd_0 = this;
							@class.string_0 = DateTime.Now.ToString(Class15.string_0, CultureInfo.InvariantCulture);
							base.Invoke(new MethodInvoker(this.method_95));
							int num = @string.IndexOf(Class14.String_97);
							if (num != -1)
							{
								int num2 = @string.IndexOf(";");
								if (num2 != -1)
								{
									WCD.Class25 class2 = new WCD.Class25();
									class2.class24_0 = @class;
									class2.string_0 = @string.Substring(num + 6, num2 - 6 - num);
									flag = true;
									base.Invoke(new MethodInvoker(class2.method_0));
								}
							}
						}
					}
					else
					{
						WCD.Class22 class3 = new WCD.Class22();
						class3.wcd_0 = this;
						class3.string_0 = DateTime.Now.ToString(Class15.string_0, CultureInfo.InvariantCulture);
						base.Invoke(new MethodInvoker(class3.method_0));
						int num3 = @string.IndexOf(Class14.String_78);
						if (num3 != -1)
						{
							int num4 = @string.IndexOf(";");
							if (num4 != -1)
							{
								WCD.Class23 class4 = new WCD.Class23();
								class4.class22_0 = class3;
								class4.string_0 = @string.Substring(num3 + 7, num4 - 7 - num3);
								flag = true;
								base.Invoke(new MethodInvoker(class4.method_0));
							}
						}
					}
				}
				else
				{
					base.Invoke(new MethodInvoker(this.method_94));
					int num5 = @string.IndexOf(Class14.String_183);
					if (num5 != -1)
					{
						int num6 = @string.IndexOf(";");
						if (num6 != -1)
						{
							WCD.Class21 class5 = new WCD.Class21();
							class5.wcd_0 = this;
							class5.string_0 = @string.Substring(num5 + 4, num6 - 4 - num5);
							flag = true;
							base.Invoke(new MethodInvoker(class5.method_0));
						}
					}
				}
			}
			else
			{
				int num7 = @string.IndexOf(Class14.String_220);
				if (num7 != -1)
				{
					int num8 = @string.IndexOf(";");
					if (num8 != -1)
					{
						string[] array3 = @string.Substring(num7 + 6, num8 - 6 - num7).Split(new char[] { '!' });
						if (array3.Length == 2 && Class13.smethod_15(array3[0], array3[1]))
						{
							string[] array4 = Encoding.UTF8.GetString(Convert.FromBase64String(array3[0])).Split(new char[] { ';' });
							if (array4.Length == 2)
							{
								byte[] array5 = Class13.smethod_12(array4[0]);
								string text6 = Class13.smethod_6(array4[1], array5);
								if (text6 != null && text6 != string.Empty)
								{
									string[] array6 = text6.Split(new char[] { '|' });
									if (array6.Length == 2)
									{
										text = array6[0];
										this.string_4 = Encoding.UTF8.GetString(Convert.FromBase64String(array6[1]));
										flag = true;
									}
								}
							}
						}
					}
				}
			}
			if (!flag)
			{
				WCD.Class26 class6 = new WCD.Class26();
				class6.wcd_0 = this;
				class6.string_0 = DateTime.Now.ToString(Class15.string_0, CultureInfo.InvariantCulture);
				base.Invoke(new MethodInvoker(class6.method_0));
			}
			gclass.Dispose();
		}
		catch (WebException ex2)
		{
			WCD.Class27 class7 = new WCD.Class27();
			class7.wcd_0 = this;
			class7.string_0 = DateTime.Now.ToString(Class15.string_0, CultureInfo.InvariantCulture);
			if (ex2.Status == WebExceptionStatus.Timeout)
			{
				base.Invoke(new MethodInvoker(class7.method_0));
			}
			else
			{
				WCD.Class28 class8 = new WCD.Class28();
				class8.class27_0 = class7;
				class8.httpWebResponse_0 = GClass56.smethod_0(ex2);
				base.Invoke(new MethodInvoker(class8.method_0));
			}
		}
		catch (CryptographicException)
		{
			WCD.Class29 class9 = new WCD.Class29();
			class9.wcd_0 = this;
			class9.string_0 = DateTime.Now.ToString(Class15.string_0, CultureInfo.InvariantCulture);
			base.Invoke(new MethodInvoker(class9.method_0));
		}
		catch (Exception)
		{
			WCD.Class30 class10 = new WCD.Class30();
			class10.wcd_0 = this;
			class10.string_0 = DateTime.Now.ToString(Class15.string_0, CultureInfo.InvariantCulture);
			base.Invoke(new MethodInvoker(class10.method_0));
		}
		return text;
	}

	// Token: 0x0600063E RID: 1598 RVA: 0x00060F58 File Offset: 0x0005F158
	private Dictionary<string, long> method_71()
	{
		Process[] processes = Process.GetProcesses();
		Dictionary<string, long> dictionary = new Dictionary<string, long>();
		long num = 1L;
		int num2 = 0;
		while (num2 < processes.Length && !this.method_47())
		{
			try
			{
				ProcessModuleCollection modules = processes[num2].Modules;
				int num3 = 0;
				while (num3 < modules.Count && !this.method_47())
				{
					string text = modules[num3].FileName.ToLower();
					GEnum51 genum = GEnum51.const_2;
					text = GClass44.smethod_0(text, this.bool_2, ref genum);
					if (dictionary.TryGetValue(text, out num))
					{
						num = (dictionary[text] = num + 1L);
					}
					else
					{
						dictionary.Add(text, 1L);
					}
					num3++;
				}
			}
			catch
			{
			}
			num2++;
		}
		return dictionary;
	}

	// Token: 0x0600063F RID: 1599 RVA: 0x00061034 File Offset: 0x0005F234
	private string method_72()
	{
		Dictionary<string, long> dictionary = this.method_71();
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < this.gclass51_0.List_1.Count; i++)
		{
			GClass44 gclass = this.gclass51_0.List_1[i];
			string text = gclass.String_1.ToLower();
			long num;
			if (!dictionary.TryGetValue(text, out num))
			{
				gclass.Int64_1 = 1L;
			}
			else
			{
				gclass.Int64_1 = num;
			}
			stringBuilder.Append(gclass.ToString());
			if (i + 1 < this.gclass51_0.List_1.Count)
			{
				stringBuilder.Append(';');
			}
		}
		return stringBuilder.ToString();
	}

	// Token: 0x06000640 RID: 1600 RVA: 0x000610E8 File Offset: 0x0005F2E8
	private string method_73(List<GClass41> list_0)
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < list_0.Count; i++)
		{
			stringBuilder.Append(list_0[i].ToString());
			if (i + 1 < list_0.Count)
			{
				stringBuilder.Append(';');
			}
		}
		return stringBuilder.ToString();
	}

	// Token: 0x06000641 RID: 1601 RVA: 0x0006113C File Offset: 0x0005F33C
	private void method_74()
	{
		try
		{
			base.Invoke(new MethodInvoker(this.method_96));
			this.gclass51_0.String_1 = DateTime.Now.ToString(Class15.string_0, CultureInfo.InvariantCulture);
			GClass56 gclass = new GClass56();
			gclass.Proxy = null;
			gclass.Int32_0 = Class15.int_0;
			gclass.Headers.Add(HttpRequestHeader.UserAgent, Class12.String_5);
			gclass.Headers.Add(HttpRequestHeader.ContentType, "application/x-www-form-urlencoded");
			NameValueCollection nameValueCollection = new NameValueCollection();
			byte[] array = Class13.smethod_1(32);
			string text = Class13.smethod_13(Convert.ToBase64String(array));
			string text2 = Class13.smethod_5(this.string_1, array);
			string text3 = Class13.smethod_5(this.gclass51_0.String_6, array);
			string text4 = Class13.smethod_5(this.gclass51_0.String_14, array);
			string text5 = Class13.smethod_5(this.gclass51_0.String_5, array);
			string text6 = Class13.smethod_5(this.gclass51_0.String_7, array);
			string text7 = Class13.smethod_5(this.gclass51_0.DateTime_0.ToString(Class15.string_0, CultureInfo.InvariantCulture), array);
			string text8 = this.method_73(this.gclass51_0.List_0);
			string text9 = Class13.smethod_5(this.gclass51_0.String_10, array);
			string text10 = Class13.smethod_5(this.gclass51_0.String_9, array);
			string text11 = Class13.smethod_5(this.gclass51_0.String_11, array);
			string text12 = Class13.smethod_5(this.gclass51_0.String_12, array);
			string text13 = Class13.smethod_5(this.gclass51_0.String_13, array);
			string text14 = Class13.smethod_5(Class15.smethod_0(this.gclass51_0.List_4, ';'), array);
			string text15 = Class13.smethod_5(text8, array);
			string text16 = Class13.smethod_5(this.gclass51_0.String_4, array);
			string text17 = Class13.smethod_5(this.gclass51_0.String_0, array);
			string text18 = Class13.smethod_5(this.gclass51_0.String_1, array);
			string text19 = Class13.smethod_5(this.gclass51_0.String_8, array);
			string text20 = Class13.smethod_5(Class15.smethod_0(this.gclass51_0.List_3, ';'), array);
			string text21 = Class13.smethod_5(Class15.smethod_0(this.gclass51_0.List_2, ';'), array);
			string text22 = Class13.smethod_5(Class15.smethod_0(this.gclass51_0.List_5, ';'), array);
			string text23 = Class13.smethod_5(Class15.smethod_0(this.gclass51_0.List_7, ';'), array);
			string text24 = Class13.smethod_5(Class15.smethod_0(this.gclass51_0.List_6, ';'), array);
			string text25 = Class13.smethod_5(((int)this.gclass51_0.GEnum34_0).ToString(), array);
			string text26 = Class13.smethod_5(((int)this.gclass51_0.GEnum23_0).ToString(), array);
			string text27 = Class13.smethod_5(this.gclass51_0.long_0.ToString(), array);
			string text28 = Class13.smethod_5(this.gclass51_0.long_1.ToString(), array);
			string text29 = Class13.smethod_5(this.gclass51_0.string_15.ToString(), array);
			string text30 = Class13.smethod_5(Class15.smethod_0(this.gclass51_0.List_9, ';'), array);
			string text31 = Class13.smethod_5(Class15.smethod_0(this.gclass51_0.List_10, ';'), array);
			string text32 = Class13.smethod_5(Class15.smethod_1(this.gclass51_0.List_11, ';'), array);
			string text33 = Class13.smethod_5(this.gclass51_0.long_3.ToString(), array);
			string text34 = Class13.smethod_5(this.gclass51_0.long_4.ToString(), array);
			string text35 = Class13.smethod_5(this.gclass51_0.long_2.ToString(), array);
			string text36 = "";
			if (this.gclass51_0.GClass55_0 == null)
			{
				text36 = Class13.smethod_5("", array);
			}
			else
			{
				text36 = Class13.smethod_5(GClass55.smethod_0(this.gclass51_0.GClass55_0.List_0), array);
			}
			string text37 = Class13.smethod_5(this.gclass51_0.double_0.ToString(), array);
			string text38 = Class13.smethod_5(this.gclass51_0.double_1.ToString(), array);
			string text39 = Class13.smethod_5(this.gclass51_0.int_0.ToString(), array);
			string text40 = Class13.smethod_5(this.gclass51_0.Boolean_0 ? "1" : "0", array);
			string text41 = Class13.smethod_5(Class12.Boolean_0 ? "1" : "0", array);
			string text42 = Class13.smethod_5(this.bool_0 ? "1" : "0", array);
			string text43 = Class13.smethod_5(GClass51.smethod_0(this.gclass51_0.dictionary_0), array);
			List<string> list = new List<string>();
			foreach (string text44 in this.gclass51_0.List_8)
			{
				string text45 = Class15.smethod_13(text44);
				if (Class15.smethod_30(list, text45, false))
				{
					list.Add(text45);
				}
			}
			string text46 = Class13.smethod_5(Class15.smethod_0(list, ';'), array);
			string text47 = Class13.smethod_5(Class15.smethod_0(new List<string>
			{
				Class15.smethod_22(Environment.GetFolderPath(Environment.SpecialFolder.Desktop)),
				Class15.smethod_22(this.gclass51_0.String_2),
				Class15.smethod_22(this.gclass51_0.String_3),
				Class15.smethod_22(Class15.smethod_3())
			}, ';'), array);
			string text48 = Class13.smethod_5((!this.gclass51_0.bool_1) ? "0" : "1", array);
			string text49 = Class13.smethod_5(this.method_72(), array);
			string text50 = Class13.smethod_5(this.string_3, array);
			string text51 = Class13.smethod_14(Class15.smethod_2(new string[]
			{
				text2, text3, text4, text5, text6, text7, text15, text16, text17, text18,
				text9, text10, text11, text12, text13, text14, text19, text, text49, text21,
				text20, text22, text23, text24, text25, text27, text29, text46, text30, text31,
				text32, text33, text28, text34, text35, text36, text37, text38, text39, text26,
				text43, text40, text41, text47, text48, text42
			}, Class15.char_1));
			nameValueCollection["d0"] = text19;
			nameValueCollection["d1"] = text2;
			nameValueCollection["d2"] = text3;
			nameValueCollection["d3"] = text4;
			nameValueCollection["d4"] = text5;
			nameValueCollection["d5"] = text6;
			nameValueCollection["d6"] = text7;
			nameValueCollection["d7"] = text15;
			nameValueCollection["d8"] = text16;
			nameValueCollection["d9"] = text17;
			nameValueCollection["d10"] = text18;
			nameValueCollection["e0"] = text;
			nameValueCollection["e1"] = text51;
			nameValueCollection["e2"] = text50;
			nameValueCollection["a0"] = text49;
			nameValueCollection["a1"] = text21;
			nameValueCollection["a2"] = text20;
			nameValueCollection["a3"] = text9;
			nameValueCollection["a4"] = text10;
			nameValueCollection["a5"] = text11;
			nameValueCollection["a6"] = text12;
			nameValueCollection["a7"] = text13;
			nameValueCollection["a8"] = text14;
			nameValueCollection["b0"] = text22;
			nameValueCollection["b1"] = text23;
			nameValueCollection["b2"] = text24;
			nameValueCollection["b3"] = text25;
			nameValueCollection["b4"] = text27;
			nameValueCollection["b5"] = text46;
			nameValueCollection["b6"] = text29;
			nameValueCollection["b8"] = text30;
			nameValueCollection["b9"] = text31;
			nameValueCollection["b10"] = text32;
			nameValueCollection["b11"] = text33;
			nameValueCollection["b12"] = text28;
			nameValueCollection["b13"] = text34;
			nameValueCollection["b14"] = text35;
			nameValueCollection["b15"] = text36;
			nameValueCollection["b16"] = text37;
			nameValueCollection["b17"] = text38;
			nameValueCollection["b18"] = text39;
			nameValueCollection["n0"] = text26;
			nameValueCollection["n1"] = text43;
			nameValueCollection["n2"] = text40;
			nameValueCollection["n3"] = text41;
			nameValueCollection["n4"] = text47;
			nameValueCollection["n5"] = text48;
			nameValueCollection["n6"] = text42;
			gclass.UploadValuesCompleted += this.method_76;
			gclass.UploadProgressChanged += this.method_75;
			gclass.UploadValuesAsync(new Uri(Class12.smethod_2(Class12.Boolean_0, "submit")), "POST", nameValueCollection);
		}
		catch
		{
			WCD.Class31 @class = new WCD.Class31();
			@class.wcd_0 = this;
			@class.string_0 = DateTime.Now.ToString(Class15.string_0, CultureInfo.InvariantCulture);
			base.Invoke(new MethodInvoker(@class.method_0));
		}
	}

	// Token: 0x06000642 RID: 1602 RVA: 0x00061B1C File Offset: 0x0005FD1C
	private void method_75(object sender, UploadProgressChangedEventArgs e)
	{
		WCD.Class32 @class = new WCD.Class32();
		@class.uploadProgressChangedEventArgs_0 = e;
		@class.wcd_0 = this;
		base.Invoke(new MethodInvoker(@class.method_0));
	}

	// Token: 0x06000643 RID: 1603 RVA: 0x00061B50 File Offset: 0x0005FD50
	private void method_76(object sender, UploadValuesCompletedEventArgs e)
	{
		WCD.Class33 @class = new WCD.Class33();
		@class.wcd_0 = this;
		@class.uploadValuesCompletedEventArgs_0 = e;
		@class.string_0 = DateTime.Now.ToString(Class15.string_0, CultureInfo.InvariantCulture);
		if (@class.uploadValuesCompletedEventArgs_0.Error != null)
		{
			if (@class.uploadValuesCompletedEventArgs_0.Error is CryptographicException)
			{
				base.Invoke(new MethodInvoker(@class.method_6));
				return;
			}
			WCD.Class39 class2 = new WCD.Class39();
			class2.class33_0 = @class;
			class2.httpWebResponse_0 = GClass56.smethod_0(class2.class33_0.uploadValuesCompletedEventArgs_0.Error);
			base.Invoke(new MethodInvoker(class2.method_0));
		}
		else
		{
			if (@class.uploadValuesCompletedEventArgs_0.Result == null)
			{
				base.Invoke(new MethodInvoker(@class.method_5));
				return;
			}
			string @string = Encoding.UTF8.GetString(@class.uploadValuesCompletedEventArgs_0.Result);
			if (!@string.Contains(Class14.String_202))
			{
				if (!@string.Contains(Class14.String_183))
				{
					if (@string.Contains(Class14.String_78))
					{
						base.Invoke(new MethodInvoker(@class.method_2));
						int num = @string.IndexOf(Class14.String_78);
						if (num != -1)
						{
							int num2 = @string.IndexOf(";");
							if (num2 != -1)
							{
								WCD.Class37 class3 = new WCD.Class37();
								class3.class33_0 = @class;
								class3.string_0 = @string.Substring(num + 7, num2 - 7 - num);
								base.Invoke(new MethodInvoker(class3.method_0));
								return;
							}
						}
					}
					else
					{
						if (!@string.Contains(Class14.String_97))
						{
							base.Invoke(new MethodInvoker(@class.method_4));
							return;
						}
						base.Invoke(new MethodInvoker(@class.method_3));
						int num3 = @string.IndexOf(Class14.String_97);
						if (num3 != -1)
						{
							int num4 = @string.IndexOf(";");
							if (num4 != -1)
							{
								WCD.Class38 class4 = new WCD.Class38();
								class4.class33_0 = @class;
								class4.string_0 = @string.Substring(num3 + 6, num4 - 6 - num3);
								base.Invoke(new MethodInvoker(class4.method_0));
								return;
							}
						}
					}
				}
				else
				{
					base.Invoke(new MethodInvoker(@class.method_1));
					int num5 = @string.IndexOf(Class14.String_183);
					if (num5 != -1)
					{
						int num6 = @string.IndexOf(";");
						if (num6 != -1)
						{
							WCD.Class36 class5 = new WCD.Class36();
							class5.class33_0 = @class;
							class5.string_0 = @string.Substring(num5 + 4, num6 - 4 - num5);
							base.Invoke(new MethodInvoker(class5.method_0));
							return;
						}
					}
				}
			}
			else
			{
				bool flag = true;
				int num7 = @string.IndexOf(Class14.String_202);
				if (num7 != -1)
				{
					int num8 = @string.IndexOf("#");
					if (num8 != -1)
					{
						WCD.Class34 class6 = new WCD.Class34();
						class6.class33_0 = @class;
						class6.string_0 = @string.Substring(num7 + 3, num8 - 3 - num7);
						class6.string_0 = Class12.smethod_3(true, Convert.ToInt64(class6.string_0));
						num7 = @string.IndexOf(";");
						if (num7 != -1)
						{
							WCD.Class35 class7 = new WCD.Class35();
							class7.class34_0 = class6;
							class7.string_0 = @string.Substring(num8 + 1, num7 - num8 - 1);
							flag = false;
							base.Invoke(new MethodInvoker(class7.method_0));
						}
					}
				}
				if (flag)
				{
					base.Invoke(new MethodInvoker(@class.method_0));
					return;
				}
			}
		}
	}

	// Token: 0x06000644 RID: 1604 RVA: 0x00061ED4 File Offset: 0x000600D4
	private void WCD_Load(object sender, EventArgs e)
	{
		this.method_83();
		this.string_0 = DateTime.Now.ToString(Class15.string_0, CultureInfo.InvariantCulture);
		try
		{
			this.gclass43_0.method_0();
			this.bool_0 = true;
		}
		catch
		{
			this.bool_0 = false;
		}
	}

	// Token: 0x06000645 RID: 1605 RVA: 0x00061F34 File Offset: 0x00060134
	private void method_77()
	{
		if (this.string_2 == null || this.string_2 == string.Empty || this.string_2.Length == 0)
		{
			this.string_2 = Guid.NewGuid().ToString("N").ToUpper();
			this.byte_0 = this.method_79(this.string_2);
		}
	}

	// Token: 0x06000646 RID: 1606 RVA: 0x00061F98 File Offset: 0x00060198
	private bool method_78()
	{
		bool flag = GClass50.smethod_12(Registry.CurrentUser, "Software\\wCD", "ID", this.string_2, true);
		bool flag2 = GClass50.smethod_13(Registry.LocalMachine, "Software\\wCD", "DATA", this.byte_0, true);
		return flag && flag2;
	}

	// Token: 0x06000647 RID: 1607 RVA: 0x00061FE4 File Offset: 0x000601E4
	private byte[] method_79(string string_6)
	{
		if (string_6 != null && string_6.Length != 0)
		{
			try
			{
				string_6 = string_6.ToUpper();
				byte[] array = Class13.smethod_1(32);
				byte[] array2 = Convert.FromBase64String(Class13.smethod_2(string_6, array, WCD.byte_1));
				byte[] array3 = new byte[array.Length + array2.Length];
				Array.Copy(array, 0, array3, 0, array.Length);
				Array.Copy(array2, 0, array3, array.Length, array2.Length);
				return array3;
			}
			catch
			{
			}
			return null;
		}
		return null;
	}

	// Token: 0x06000648 RID: 1608 RVA: 0x00062064 File Offset: 0x00060264
	private string method_80(byte[] byte_2)
	{
		if (byte_2 != null && byte_2.Length != 0)
		{
			try
			{
				byte b = 32;
				if (32 < byte_2.Length)
				{
					byte[] array = new byte[(int)b];
					Array.Copy(byte_2, 0, array, 0, (int)b);
					byte[] array2 = new byte[byte_2.Length - (int)b];
					Array.Copy(byte_2, array.Length, array2, 0, array2.Length);
					return Class13.smethod_3(Convert.ToBase64String(array2), array, WCD.byte_1);
				}
				return null;
			}
			catch
			{
			}
			return null;
		}
		return null;
	}

	// Token: 0x06000649 RID: 1609 RVA: 0x000620E0 File Offset: 0x000602E0
	private bool method_81()
	{
		bool flag = false;
		try
		{
			this.string_2 = GClass50.smethod_6(Registry.CurrentUser, "Software\\wCD", "ID");
			if (this.string_2 != null)
			{
				this.string_2 = this.string_2.ToUpper();
				if (Class15.smethod_21(this.string_2))
				{
					this.byte_0 = GClass50.smethod_5(Registry.LocalMachine, "Software\\wCD", "DATA");
					bool flag2 = false;
					if (this.byte_0 == null)
					{
						flag2 = true;
					}
					else
					{
						string text = this.method_80(this.byte_0);
						if (!Class15.smethod_21(text))
						{
							flag2 = true;
						}
						else if (text != this.string_2)
						{
							this.string_2 = text;
							flag = this.method_78();
						}
					}
					if (!flag2)
					{
						flag = true;
					}
					else
					{
						this.byte_0 = this.method_79(this.string_2);
						flag = this.method_78();
					}
				}
				else
				{
					this.byte_0 = GClass50.smethod_5(Registry.LocalMachine, "Software\\wCD", "DATA");
					if (this.byte_0 != null)
					{
						string text2 = this.method_80(this.byte_0);
						if (Class15.smethod_21(text2))
						{
							this.string_2 = text2;
							flag = this.method_78();
						}
					}
				}
			}
			else
			{
				this.byte_0 = GClass50.smethod_5(Registry.LocalMachine, "Software\\wCD", "DATA");
				if (this.byte_0 != null)
				{
					string text3 = this.method_80(this.byte_0);
					if (!Class15.smethod_21(text3))
					{
						this.method_77();
						flag = this.method_78();
					}
					else
					{
						this.string_2 = text3;
						flag = this.method_78();
					}
				}
				else
				{
					this.method_77();
					flag = this.method_78();
				}
			}
			this.byte_0 = this.method_79(this.string_2);
		}
		catch
		{
		}
		return flag;
	}

	// Token: 0x0600064A RID: 1610 RVA: 0x000622A0 File Offset: 0x000604A0
	private void WCD_FormClosing(object sender, FormClosingEventArgs e)
	{
		try
		{
			this.method_48();
			this.wCDScanner.Abort();
		}
		catch
		{
		}
		try
		{
			this.gclass43_0.method_1();
		}
		catch
		{
		}
	}

	// Token: 0x0600064B RID: 1611 RVA: 0x000622F0 File Offset: 0x000604F0
	private void label1_Click(object sender, EventArgs e)
	{
		Process.Start(Class12.smethod_1(true));
	}

	// Token: 0x0600064C RID: 1612 RVA: 0x0006230C File Offset: 0x0006050C
	private void label2_Click(object sender, EventArgs e)
	{
		MessageBox.Show(this, string.Concat(new string[]
		{
			"WarGods Cheat Defender v",
			this.string_1,
			"\n",
			Environment.NewLine,
			"Created by Tiger",
			Environment.NewLine,
			"Email: amx.tiger@gmail.com",
			Environment.NewLine,
			"wCD Project: ",
			Class12.smethod_1(true),
			Environment.NewLine,
			"Support: ",
			Class12.smethod_0(true),
			Environment.NewLine,
			Environment.NewLine,
			"© WarGods Community"
		}), "About", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
	}

	// Token: 0x0600064D RID: 1613
	[DllImport("gdi32.dll")]
	private static extern IntPtr AddFontMemResourceEx(IntPtr intptr_0, uint uint_0, IntPtr intptr_1, [In] ref uint uint_1);

	// Token: 0x0600064E RID: 1614 RVA: 0x000623C0 File Offset: 0x000605C0
	private void method_82()
	{
		byte[] array = WarGodsCheatDefender.Properties.Properties.Resources.ethnocentric;
		int num = WarGodsCheatDefender.Properties.Properties.Resources.ethnocentric.Length;
		IntPtr intPtr = Marshal.AllocCoTaskMem(num);
		Marshal.Copy(array, 0, intPtr, num);
		uint num2 = 0U;
		WCD.AddFontMemResourceEx(intPtr, (uint)array.Length, IntPtr.Zero, ref num2);
		PrivateFontCollection privateFontCollection = new PrivateFontCollection();
		privateFontCollection.AddMemoryFont(intPtr, num);
		this.fontFamily_0 = privateFontCollection.Families[0];
		this.font_0 = new Font(this.fontFamily_0, 15f, FontStyle.Regular);
	}

	// Token: 0x0600064F RID: 1615 RVA: 0x00062434 File Offset: 0x00060634
	private void method_83()
	{
		try
		{
			this.method_82();
			this.label1.Font = new Font(this.fontFamily_0, 9f, FontStyle.Regular);
			this.label2.Font = new Font(this.fontFamily_0, 9f, FontStyle.Regular);
			this.label3.Font = new Font(this.fontFamily_0, 9f, FontStyle.Regular);
			this.label4.Font = new Font(this.fontFamily_0, 9f, FontStyle.Regular);
		}
		catch
		{
			this.label1.Font = new Font("Arial", this.label1.Font.Size, FontStyle.Bold);
			this.label2.Font = new Font("Arial", this.label1.Font.Size, FontStyle.Bold);
			this.label3.Font = new Font("Arial", this.label1.Font.Size, FontStyle.Bold);
			this.label4.Font = new Font("Arial", this.label1.Font.Size, FontStyle.Bold);
		}
	}

	// Token: 0x06000650 RID: 1616 RVA: 0x00062568 File Offset: 0x00060768
	protected virtual void Dispose(bool disposing)
	{
		if (disposing && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	// Token: 0x06000653 RID: 1619 RVA: 0x00062D48 File Offset: 0x00060F48
	[CompilerGenerated]
	private void method_84()
	{
		this.scan.Enabled = false;
	}

	// Token: 0x06000654 RID: 1620 RVA: 0x00062D64 File Offset: 0x00060F64
	[CompilerGenerated]
	private void method_85()
	{
		this.scan.Enabled = true;
		this.scan.Text = "ReScan";
		this.label4.Text = "Internal error...";
	}

	// Token: 0x06000655 RID: 1621 RVA: 0x00062DA0 File Offset: 0x00060FA0
	[CompilerGenerated]
	private void method_86()
	{
		this.scan.Enabled = true;
		this.scan.Text = "ReScan";
		this.label4.Text = "CS has been exited...";
	}

	// Token: 0x06000656 RID: 1622 RVA: 0x00062DDC File Offset: 0x00060FDC
	[CompilerGenerated]
	private void method_87()
	{
		this.scan.Enabled = true;
		this.scan.Text = "ReScan";
		this.label4.Text = "CS not found...";
	}

	// Token: 0x06000657 RID: 1623 RVA: 0x00062DA0 File Offset: 0x00060FA0
	[CompilerGenerated]
	private void method_88()
	{
		this.scan.Enabled = true;
		this.scan.Text = "ReScan";
		this.label4.Text = "CS has been exited...";
	}

	// Token: 0x06000658 RID: 1624 RVA: 0x00062E18 File Offset: 0x00061018
	[CompilerGenerated]
	private void method_89()
	{
		this.scan.Enabled = true;
		this.scan.Text = "ReScan";
		this.label4.Text = "Scan error...";
	}

	// Token: 0x06000659 RID: 1625 RVA: 0x00062E54 File Offset: 0x00061054
	[CompilerGenerated]
	private void method_90()
	{
		this.scan.Enabled = true;
		this.scan.Text = "Scan";
		this.label4.Text = "Server error...";
	}

	// Token: 0x0600065A RID: 1626 RVA: 0x00062D64 File Offset: 0x00060F64
	[CompilerGenerated]
	private void method_91()
	{
		this.scan.Enabled = true;
		this.scan.Text = "ReScan";
		this.label4.Text = "Internal error...";
	}

	// Token: 0x0600065B RID: 1627 RVA: 0x00062E90 File Offset: 0x00061090
	[CompilerGenerated]
	private void method_92()
	{
		this.label4.Text = string.Format("Scanning ({0}%)...", this.int_0 * 100 / this.int_1);
	}

	// Token: 0x0600065C RID: 1628 RVA: 0x00062EC8 File Offset: 0x000610C8
	[CompilerGenerated]
	private void method_93()
	{
		this.label4.Text = "Connecting with server...";
	}

	// Token: 0x0600065D RID: 1629 RVA: 0x00062EE8 File Offset: 0x000610E8
	[CompilerGenerated]
	private void method_94()
	{
		this.label4.Text = "Sending failed";
		this.scan.Enabled = true;
	}

	// Token: 0x0600065E RID: 1630 RVA: 0x00062F14 File Offset: 0x00061114
	[CompilerGenerated]
	private void method_95()
	{
		this.label4.Text = "Communication failed";
		this.scan.Enabled = true;
	}

	// Token: 0x0600065F RID: 1631 RVA: 0x00062F40 File Offset: 0x00061140
	[CompilerGenerated]
	private void method_96()
	{
		this.label4.Text = "Sending report (0%)...";
	}

	// Token: 0x04000947 RID: 2375
	private Thread wCDScanner;

	// Token: 0x04000948 RID: 2376
	private GClass51 gclass51_0;

	// Token: 0x04000949 RID: 2377
	private Process process_0;

	// Token: 0x0400094A RID: 2378
	private GClass43 gclass43_0;

	// Token: 0x0400094B RID: 2379
	private bool bool_0;

	// Token: 0x0400094C RID: 2380
	private string string_0;

	// Token: 0x0400094D RID: 2381
	private string string_1 = Application.ProductVersion;

	// Token: 0x0400094E RID: 2382
	private string string_2;

	// Token: 0x0400094F RID: 2383
	private byte[] byte_0;

	// Token: 0x04000950 RID: 2384
	private string string_3 = string.Empty;

	// Token: 0x04000951 RID: 2385
	private bool bool_1;

	// Token: 0x04000952 RID: 2386
	private int int_0;

	// Token: 0x04000953 RID: 2387
	private int int_1 = 34;

	// Token: 0x04000954 RID: 2388
	private static object object_0 = new object();

	// Token: 0x04000955 RID: 2389
	private static object object_1 = new object();

	// Token: 0x04000956 RID: 2390
	private static object object_2 = new object();

	// Token: 0x04000957 RID: 2391
	private static object object_3 = new object();

	// Token: 0x04000958 RID: 2392
	private string string_4;

	// Token: 0x04000959 RID: 2393
	private bool bool_2;

	// Token: 0x0400095A RID: 2394
	private string string_5 = string.Empty;

	// Token: 0x0400095B RID: 2395
	private object object_4 = new object();

	// Token: 0x0400095C RID: 2396
	private object object_5 = new object();

	// Token: 0x0400095D RID: 2397
	private static readonly Regex regex_0 = new Regex("\\d{1,3}\\.\\d{1,3}\\.\\d{1,3}\\.\\d{1,3}", RegexOptions.IgnoreCase | RegexOptions.Singleline);

	// Token: 0x0400095E RID: 2398
	private static byte[] byte_1 = new byte[]
	{
		167, 0, 79, 138, 238, 156, 34, 179, 52, 160,
		121, 246, 17, 170, 36, 116
	};

	// Token: 0x0400095F RID: 2399
	private FontFamily fontFamily_0;

	// Token: 0x04000960 RID: 2400
	private Font font_0;

	// Token: 0x04000961 RID: 2401
	private IContainer icontainer_0;

	// Token: 0x020000BB RID: 187
	private class Class17
	{
		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x06000660 RID: 1632 RVA: 0x00062F60 File Offset: 0x00061160
		// (set) Token: 0x06000661 RID: 1633 RVA: 0x00062F74 File Offset: 0x00061174
		public string String_0 { get; set; }

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x06000662 RID: 1634 RVA: 0x00062F88 File Offset: 0x00061188
		// (set) Token: 0x06000663 RID: 1635 RVA: 0x00062F9C File Offset: 0x0006119C
		public string String_1 { get; set; }

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x06000664 RID: 1636 RVA: 0x00062FB0 File Offset: 0x000611B0
		// (set) Token: 0x06000665 RID: 1637 RVA: 0x00062FC4 File Offset: 0x000611C4
		public string String_2 { get; set; }

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x06000666 RID: 1638 RVA: 0x00062FD8 File Offset: 0x000611D8
		// (set) Token: 0x06000667 RID: 1639 RVA: 0x00062FEC File Offset: 0x000611EC
		public string String_3 { get; set; }

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x06000668 RID: 1640 RVA: 0x00063000 File Offset: 0x00061200
		// (set) Token: 0x06000669 RID: 1641 RVA: 0x00063014 File Offset: 0x00061214
		public string String_4 { get; set; }

		// Token: 0x04000968 RID: 2408
		[CompilerGenerated]
		private string string_0;

		// Token: 0x04000969 RID: 2409
		[CompilerGenerated]
		private string string_1;

		// Token: 0x0400096A RID: 2410
		[CompilerGenerated]
		private string string_2;

		// Token: 0x0400096B RID: 2411
		[CompilerGenerated]
		private string string_3;

		// Token: 0x0400096C RID: 2412
		[CompilerGenerated]
		private string string_4;
	}

	// Token: 0x020000BC RID: 188
	private class Class18
	{
		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x0600066B RID: 1643 RVA: 0x00063028 File Offset: 0x00061228
		// (set) Token: 0x0600066C RID: 1644 RVA: 0x0006303C File Offset: 0x0006123C
		public string String_0 { get; private set; }

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x0600066D RID: 1645 RVA: 0x00063050 File Offset: 0x00061250
		// (set) Token: 0x0600066E RID: 1646 RVA: 0x00063064 File Offset: 0x00061264
		public IntPtr IntPtr_0 { get; private set; }

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x0600066F RID: 1647 RVA: 0x00063078 File Offset: 0x00061278
		// (set) Token: 0x06000670 RID: 1648 RVA: 0x0006308C File Offset: 0x0006128C
		public IntPtr IntPtr_1 { get; private set; }

		// Token: 0x06000671 RID: 1649 RVA: 0x000630A0 File Offset: 0x000612A0
		public Class18(string string_1, IntPtr intptr_2, IntPtr intptr_3)
		{
			this.String_0 = string_1;
			this.IntPtr_0 = intptr_2;
			this.IntPtr_1 = intptr_3;
		}

		// Token: 0x06000672 RID: 1650 RVA: 0x000630C8 File Offset: 0x000612C8
		public virtual string ToString()
		{
			return string.Format("{0}{1}{2}{3}{4}{5}", new object[]
			{
				Class15.smethod_22(this.String_0),
				Class15.char_1,
				this.IntPtr_0.ToString("X"),
				Class15.char_1,
				this.IntPtr_1.ToString("X"),
				Class15.char_1
			});
		}

		// Token: 0x06000673 RID: 1651 RVA: 0x00063148 File Offset: 0x00061348
		public static WCD.Class18 smethod_0(List<WCD.Class18> list_0, string string_1)
		{
			string text = string_1.ToLowerInvariant();
			using (List<WCD.Class18>.Enumerator enumerator = list_0.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					WCD.Class18 @class = enumerator.Current;
					if (@class.String_0.ToLowerInvariant() == text)
					{
						return @class;
					}
				}
				goto IL_4B;
			}
			WCD.Class18 class2;
			return class2;
			IL_4B:
			return null;
		}

		// Token: 0x0400096D RID: 2413
		[CompilerGenerated]
		private string string_0;

		// Token: 0x0400096E RID: 2414
		[CompilerGenerated]
		private IntPtr intptr_0;

		// Token: 0x0400096F RID: 2415
		[CompilerGenerated]
		private IntPtr intptr_1;
	}

	// Token: 0x020000BD RID: 189
	private class Class19
	{
		// Token: 0x170002DB RID: 731
		// (get) Token: 0x06000674 RID: 1652 RVA: 0x000631B4 File Offset: 0x000613B4
		// (set) Token: 0x06000675 RID: 1653 RVA: 0x000631C8 File Offset: 0x000613C8
		public int Int32_0 { get; private set; }

		// Token: 0x170002DC RID: 732
		// (get) Token: 0x06000676 RID: 1654 RVA: 0x000631DC File Offset: 0x000613DC
		// (set) Token: 0x06000677 RID: 1655 RVA: 0x000631F0 File Offset: 0x000613F0
		public TimeSpan TimeSpan_0 { get; private set; }

		// Token: 0x170002DD RID: 733
		// (get) Token: 0x06000678 RID: 1656 RVA: 0x00063204 File Offset: 0x00061404
		// (set) Token: 0x06000679 RID: 1657 RVA: 0x00063218 File Offset: 0x00061418
		public IntPtr IntPtr_0 { get; private set; }

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x0600067A RID: 1658 RVA: 0x0006322C File Offset: 0x0006142C
		// (set) Token: 0x0600067B RID: 1659 RVA: 0x00063240 File Offset: 0x00061440
		public IntPtr IntPtr_1 { get; private set; }

		// Token: 0x0600067C RID: 1660 RVA: 0x00063254 File Offset: 0x00061454
		public Class19(int int_1, TimeSpan timeSpan_1, IntPtr intptr_2, IntPtr intptr_3)
		{
			this.Int32_0 = int_1;
			this.TimeSpan_0 = timeSpan_1;
			this.IntPtr_0 = intptr_2;
			this.IntPtr_1 = intptr_3;
		}

		// Token: 0x04000970 RID: 2416
		[CompilerGenerated]
		private int int_0;

		// Token: 0x04000971 RID: 2417
		[CompilerGenerated]
		private TimeSpan timeSpan_0;

		// Token: 0x04000972 RID: 2418
		[CompilerGenerated]
		private IntPtr intptr_0;

		// Token: 0x04000973 RID: 2419
		[CompilerGenerated]
		private IntPtr intptr_1;
	}

	// Token: 0x020000BE RID: 190
	[CompilerGenerated]
	private sealed class Class20
	{
		// Token: 0x0600067E RID: 1662 RVA: 0x00063284 File Offset: 0x00061484
		internal void method_0()
		{
			this.wcd_0.label4.Text = "Scanning...";
		}

		// Token: 0x0600067F RID: 1663 RVA: 0x000632A8 File Offset: 0x000614A8
		internal void method_1()
		{
			this.wcd_0.method_45(this.process_0);
		}

		// Token: 0x06000680 RID: 1664 RVA: 0x000632C8 File Offset: 0x000614C8
		internal void method_2()
		{
			this.wcd_0.method_46(this.process_0);
		}

		// Token: 0x06000681 RID: 1665 RVA: 0x000632E8 File Offset: 0x000614E8
		internal void method_3()
		{
			this.wcd_0.method_49(this.process_0);
		}

		// Token: 0x04000974 RID: 2420
		public WCD wcd_0;

		// Token: 0x04000975 RID: 2421
		public Process process_0;
	}

	// Token: 0x020000BF RID: 191
	[CompilerGenerated]
	private sealed class Class21
	{
		// Token: 0x06000683 RID: 1667 RVA: 0x00063308 File Offset: 0x00061508
		internal void method_0()
		{
			MessageBox.Show(this.wcd_0, this.string_0, "Message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x04000976 RID: 2422
		public string string_0;

		// Token: 0x04000977 RID: 2423
		public WCD wcd_0;
	}

	// Token: 0x020000C0 RID: 192
	[CompilerGenerated]
	private sealed class Class22
	{
		// Token: 0x06000685 RID: 1669 RVA: 0x00063330 File Offset: 0x00061530
		internal void method_0()
		{
			this.wcd_0.label4.Text = "Banned - " + this.string_0;
			this.wcd_0.scan.Enabled = false;
		}

		// Token: 0x04000978 RID: 2424
		public string string_0;

		// Token: 0x04000979 RID: 2425
		public WCD wcd_0;
	}

	// Token: 0x020000C1 RID: 193
	[CompilerGenerated]
	private sealed class Class23
	{
		// Token: 0x06000687 RID: 1671 RVA: 0x00063370 File Offset: 0x00061570
		internal void method_0()
		{
			MessageBox.Show(this.class22_0.wcd_0, this.string_0, "Banned - " + this.class22_0.string_0, MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}

		// Token: 0x0400097A RID: 2426
		public string string_0;

		// Token: 0x0400097B RID: 2427
		public WCD.Class22 class22_0;
	}

	// Token: 0x020000C2 RID: 194
	[CompilerGenerated]
	private sealed class Class24
	{
		// Token: 0x0400097C RID: 2428
		public string string_0;

		// Token: 0x0400097D RID: 2429
		public WCD wcd_0;
	}

	// Token: 0x020000C3 RID: 195
	[CompilerGenerated]
	private sealed class Class25
	{
		// Token: 0x0600068A RID: 1674 RVA: 0x000633AC File Offset: 0x000615AC
		internal void method_0()
		{
			MessageBox.Show(this.class24_0.wcd_0, this.string_0, "Error - " + this.class24_0.string_0, MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}

		// Token: 0x0400097E RID: 2430
		public string string_0;

		// Token: 0x0400097F RID: 2431
		public WCD.Class24 class24_0;
	}

	// Token: 0x020000C4 RID: 196
	[CompilerGenerated]
	private sealed class Class26
	{
		// Token: 0x0600068C RID: 1676 RVA: 0x000633E8 File Offset: 0x000615E8
		internal void method_0()
		{
			this.wcd_0.label4.Text = "Communication failed...";
			this.wcd_0.scan.Enabled = true;
			MessageBox.Show(this.wcd_0, "We encountered an error while trying to communicate with the server! Reason: Invalid response received!\nTimestamp: " + this.string_0, "Error - " + this.string_0, MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}

		// Token: 0x04000980 RID: 2432
		public string string_0;

		// Token: 0x04000981 RID: 2433
		public WCD wcd_0;
	}

	// Token: 0x020000C5 RID: 197
	[CompilerGenerated]
	private sealed class Class27
	{
		// Token: 0x0600068E RID: 1678 RVA: 0x0006344C File Offset: 0x0006164C
		internal void method_0()
		{
			this.wcd_0.label4.Text = "Communication failed (timeout)...";
			this.wcd_0.scan.Enabled = true;
			MessageBox.Show(this.wcd_0, "We encountered a timeout exception while trying to communicate with the server! Please try again later!\nTimestamp: " + this.string_0, "Error - " + this.string_0, MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}

		// Token: 0x04000982 RID: 2434
		public string string_0;

		// Token: 0x04000983 RID: 2435
		public WCD wcd_0;
	}

	// Token: 0x020000C6 RID: 198
	[CompilerGenerated]
	private sealed class Class28
	{
		// Token: 0x06000690 RID: 1680 RVA: 0x000634B0 File Offset: 0x000616B0
		internal void method_0()
		{
			this.class27_0.wcd_0.label4.Text = "Communication failed...";
			this.class27_0.wcd_0.scan.Enabled = true;
			string text = string.Empty;
			if (this.httpWebResponse_0 == null)
			{
				text = "We encountered an error while trying to communicate with the server! Please try again later!\nTimestamp: " + this.class27_0.string_0;
			}
			else
			{
				text = string.Format("We encountered an error while trying to communicate with the server! Please try again later!\n\nError code: {0}\nReason: {1}\nTimestamp: {2}", (int)this.httpWebResponse_0.StatusCode, this.httpWebResponse_0.StatusDescription, this.class27_0.string_0);
			}
			MessageBox.Show(this.class27_0.wcd_0, text, "Error - " + this.class27_0.string_0, MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}

		// Token: 0x04000984 RID: 2436
		public HttpWebResponse httpWebResponse_0;

		// Token: 0x04000985 RID: 2437
		public WCD.Class27 class27_0;
	}

	// Token: 0x020000C7 RID: 199
	[CompilerGenerated]
	private sealed class Class29
	{
		// Token: 0x06000692 RID: 1682 RVA: 0x00063570 File Offset: 0x00061770
		internal void method_0()
		{
			this.wcd_0.label4.Text = "Communication failed...";
			this.wcd_0.scan.Enabled = true;
			MessageBox.Show(this.wcd_0, "We encountered an error while trying to communicate with the server! Reason: Cryptographic error! Try another build version of wCD, your .NET Framework might be corrupted.\nTimestamp: " + this.string_0, "Error - " + this.string_0, MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}

		// Token: 0x04000986 RID: 2438
		public string string_0;

		// Token: 0x04000987 RID: 2439
		public WCD wcd_0;
	}

	// Token: 0x020000C8 RID: 200
	[CompilerGenerated]
	private sealed class Class30
	{
		// Token: 0x06000694 RID: 1684 RVA: 0x000635D4 File Offset: 0x000617D4
		internal void method_0()
		{
			this.wcd_0.label4.Text = "Communication failed...";
			this.wcd_0.scan.Enabled = true;
			MessageBox.Show(this.wcd_0, "We encountered an error while trying to communicate with the server!\nTimestamp: " + this.string_0, "Error - " + this.string_0, MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}

		// Token: 0x04000988 RID: 2440
		public string string_0;

		// Token: 0x04000989 RID: 2441
		public WCD wcd_0;
	}

	// Token: 0x020000C9 RID: 201
	[CompilerGenerated]
	private sealed class Class31
	{
		// Token: 0x06000696 RID: 1686 RVA: 0x00063638 File Offset: 0x00061838
		internal void method_0()
		{
			this.wcd_0.label4.Text = "Sending failed";
			this.wcd_0.scan.Enabled = true;
			MessageBox.Show(this.wcd_0, "Internal error: We encountered an error while trying to send the report!\nTimestamp: " + this.string_0, "Error - " + this.string_0, MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}

		// Token: 0x0400098A RID: 2442
		public string string_0;

		// Token: 0x0400098B RID: 2443
		public WCD wcd_0;
	}

	// Token: 0x020000CA RID: 202
	[CompilerGenerated]
	private sealed class Class32
	{
		// Token: 0x06000698 RID: 1688 RVA: 0x0006369C File Offset: 0x0006189C
		internal void method_0()
		{
			int num = this.uploadProgressChangedEventArgs_0.ProgressPercentage;
			if (num > 100)
			{
				num = 100;
			}
			this.wcd_0.label4.Text = string.Format("Sending report ({0}%)...", num);
		}

		// Token: 0x0400098C RID: 2444
		public UploadProgressChangedEventArgs uploadProgressChangedEventArgs_0;

		// Token: 0x0400098D RID: 2445
		public WCD wcd_0;
	}

	// Token: 0x020000CB RID: 203
	[CompilerGenerated]
	private sealed class Class33
	{
		// Token: 0x0600069A RID: 1690 RVA: 0x000636E0 File Offset: 0x000618E0
		internal void method_0()
		{
			this.wcd_0.label4.Text = "Sending failed";
			this.wcd_0.scan.Enabled = true;
			this.wcd_0.scan.Text = "ReScan";
			MessageBox.Show(this.wcd_0, "We encountered an error while trying to send the report! Reason: Invalid response received!\nTimestamp: " + this.string_0, "Error - " + this.string_0, MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}

		// Token: 0x0600069B RID: 1691 RVA: 0x00063758 File Offset: 0x00061958
		internal void method_1()
		{
			this.wcd_0.label4.Text = "Sending failed";
			this.wcd_0.scan.Enabled = false;
		}

		// Token: 0x0600069C RID: 1692 RVA: 0x0006378C File Offset: 0x0006198C
		internal void method_2()
		{
			this.wcd_0.label4.Text = "Banned";
			this.wcd_0.scan.Enabled = false;
		}

		// Token: 0x0600069D RID: 1693 RVA: 0x000637C0 File Offset: 0x000619C0
		internal void method_3()
		{
			this.wcd_0.label4.Text = "Sending failed";
			this.wcd_0.scan.Enabled = false;
		}

		// Token: 0x0600069E RID: 1694 RVA: 0x000637F4 File Offset: 0x000619F4
		internal void method_4()
		{
			this.wcd_0.label4.Text = "Sending failed";
			this.wcd_0.scan.Enabled = true;
			MessageBox.Show(this.wcd_0, "We encountered an error while trying to send the report! Reason: Invalid data!\nTimestamp: " + this.string_0, "Error - " + this.string_0, MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}

		// Token: 0x0600069F RID: 1695 RVA: 0x00063858 File Offset: 0x00061A58
		internal void method_5()
		{
			this.wcd_0.label4.Text = "Sending failed";
			this.wcd_0.scan.Enabled = true;
			MessageBox.Show(this.wcd_0, "We encountered an error while trying to send the report! Reason: Invalid response received!\nTimestamp: " + this.string_0, "Error - " + this.string_0, MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}

		// Token: 0x060006A0 RID: 1696 RVA: 0x000638BC File Offset: 0x00061ABC
		internal void method_6()
		{
			this.wcd_0.label4.Text = "Communication failed...";
			this.wcd_0.scan.Enabled = true;
			MessageBox.Show(this.wcd_0, "We encountered an error while trying to send the report! Reason: Cryptographic error!\nTimestamp: " + this.string_0, "Error - " + this.string_0, MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}

		// Token: 0x0400098E RID: 2446
		public WCD wcd_0;

		// Token: 0x0400098F RID: 2447
		public string string_0;

		// Token: 0x04000990 RID: 2448
		public UploadValuesCompletedEventArgs uploadValuesCompletedEventArgs_0;
	}

	// Token: 0x020000CC RID: 204
	[CompilerGenerated]
	private sealed class Class34
	{
		// Token: 0x04000991 RID: 2449
		public string string_0;

		// Token: 0x04000992 RID: 2450
		public WCD.Class33 class33_0;
	}

	// Token: 0x020000CD RID: 205
	[CompilerGenerated]
	private sealed class Class35
	{
		// Token: 0x060006A3 RID: 1699 RVA: 0x00063920 File Offset: 0x00061B20
		internal void method_0()
		{
			this.class34_0.class33_0.wcd_0.label4.Text = "Send successful";
			this.class34_0.class33_0.wcd_0.scan.Enabled = true;
			this.class34_0.class33_0.wcd_0.scan.Text = "ReScan";
			Clipboard.SetText(this.class34_0.string_0);
			MessageBox.Show(this.class34_0.class33_0.wcd_0, this.string_0, "Report Link - " + this.class34_0.class33_0.string_0, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x04000993 RID: 2451
		public string string_0;

		// Token: 0x04000994 RID: 2452
		public WCD.Class34 class34_0;
	}

	// Token: 0x020000CE RID: 206
	[CompilerGenerated]
	private sealed class Class36
	{
		// Token: 0x060006A5 RID: 1701 RVA: 0x000639D0 File Offset: 0x00061BD0
		internal void method_0()
		{
			MessageBox.Show(this.class33_0.wcd_0, this.string_0, "Message - " + this.class33_0.string_0, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x04000995 RID: 2453
		public string string_0;

		// Token: 0x04000996 RID: 2454
		public WCD.Class33 class33_0;
	}

	// Token: 0x020000CF RID: 207
	[CompilerGenerated]
	private sealed class Class37
	{
		// Token: 0x060006A7 RID: 1703 RVA: 0x00063A0C File Offset: 0x00061C0C
		internal void method_0()
		{
			MessageBox.Show(this.class33_0.wcd_0, this.string_0, "Banned - " + this.class33_0.string_0, MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}

		// Token: 0x04000997 RID: 2455
		public string string_0;

		// Token: 0x04000998 RID: 2456
		public WCD.Class33 class33_0;
	}

	// Token: 0x020000D0 RID: 208
	[CompilerGenerated]
	private sealed class Class38
	{
		// Token: 0x060006A9 RID: 1705 RVA: 0x00063A48 File Offset: 0x00061C48
		internal void method_0()
		{
			MessageBox.Show(this.class33_0.wcd_0, this.string_0, "Error - " + this.class33_0.string_0, MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}

		// Token: 0x04000999 RID: 2457
		public string string_0;

		// Token: 0x0400099A RID: 2458
		public WCD.Class33 class33_0;
	}

	// Token: 0x020000D1 RID: 209
	[CompilerGenerated]
	private sealed class Class39
	{
		// Token: 0x060006AB RID: 1707 RVA: 0x00063A84 File Offset: 0x00061C84
		internal void method_0()
		{
			this.class33_0.wcd_0.label4.Text = "Sending failed";
			this.class33_0.wcd_0.scan.Enabled = true;
			string text = string.Empty;
			if (this.httpWebResponse_0 == null)
			{
				if (!this.class33_0.uploadValuesCompletedEventArgs_0.Cancelled && !(this.class33_0.uploadValuesCompletedEventArgs_0.Error.ToString() == "System.Net.UploadValuesCompletedEventArgs"))
				{
					if (Class12.Boolean_0 && this.class33_0.uploadValuesCompletedEventArgs_0.Error.InnerException != null && (this.class33_0.uploadValuesCompletedEventArgs_0.Error.InnerException is AuthenticationException || this.class33_0.uploadValuesCompletedEventArgs_0.Error.InnerException is IOException))
					{
						text = "We encountered a TLS error while trying to send the report! Please contact support: " + Class12.smethod_1(false) + "!";
					}
					else
					{
						text = "We encountered an error while trying to send the report! Please try again later!";
					}
				}
				else
				{
					text = "The connection has been interrupted by an application. Please make sure the connection is not blocked by firewall, antimalware or any other application that could do that and try again.";
				}
			}
			else
			{
				text = string.Format("We encountered an error while trying to send the report! Please try again later!\n\nError code: {0}\nReason: {1}\nTimestamp: {2}", (int)this.httpWebResponse_0.StatusCode, this.httpWebResponse_0.StatusDescription, this.class33_0.string_0);
			}
			MessageBox.Show(this.class33_0.wcd_0, text, "Error - " + this.class33_0.string_0, MessageBoxButtons.OK, MessageBoxIcon.Hand);
		}

		// Token: 0x0400099B RID: 2459
		public HttpWebResponse httpWebResponse_0;

		// Token: 0x0400099C RID: 2460
		public WCD.Class33 class33_0;
	}
}
