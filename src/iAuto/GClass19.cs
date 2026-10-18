using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Principal;
using WebSocketSharp.Net;

// Token: 0x02000070 RID: 112
public sealed class GClass19 : IDisposable
{
	// Token: 0x060004B1 RID: 1201 RVA: 0x0002D624 File Offset: 0x0002B824
	public GClass19()
	{
		this.authenticationSchemes_0 = AuthenticationSchemes.Anonymous;
		this.dictionary_0 = new Dictionary<Class62, Class62>();
		this.object_0 = ((ICollection)this.dictionary_0).SyncRoot;
		this.list_0 = new List<GClass20>();
		this.object_1 = ((ICollection)this.list_0).SyncRoot;
		this.dictionary_1 = new Dictionary<GClass20, GClass20>();
		this.object_2 = ((ICollection)this.dictionary_1).SyncRoot;
		this.gclass6_0 = new GClass6();
		this.gclass21_0 = new GClass21(this);
		this.list_1 = new List<Class65>();
		this.object_3 = ((ICollection)this.list_1).SyncRoot;
	}

	// Token: 0x17000126 RID: 294
	// (get) Token: 0x060004B2 RID: 1202 RVA: 0x000062C6 File Offset: 0x000044C6
	internal bool Boolean_0
	{
		get
		{
			return this.bool_0;
		}
	}

	// Token: 0x17000127 RID: 295
	// (get) Token: 0x060004B3 RID: 1203 RVA: 0x000062CE File Offset: 0x000044CE
	// (set) Token: 0x060004B4 RID: 1204 RVA: 0x000062D6 File Offset: 0x000044D6
	internal bool Boolean_1
	{
		get
		{
			return this.bool_3;
		}
		set
		{
			this.bool_3 = value;
		}
	}

	// Token: 0x17000128 RID: 296
	// (get) Token: 0x060004B5 RID: 1205 RVA: 0x000062DF File Offset: 0x000044DF
	// (set) Token: 0x060004B6 RID: 1206 RVA: 0x000062ED File Offset: 0x000044ED
	public AuthenticationSchemes AuthenticationSchemes_0
	{
		get
		{
			this.method_9();
			return this.authenticationSchemes_0;
		}
		set
		{
			this.method_9();
			this.authenticationSchemes_0 = value;
		}
	}

	// Token: 0x17000129 RID: 297
	// (get) Token: 0x060004B7 RID: 1207 RVA: 0x000062FC File Offset: 0x000044FC
	// (set) Token: 0x060004B8 RID: 1208 RVA: 0x0000630A File Offset: 0x0000450A
	public Func<GClass22, AuthenticationSchemes> Func_0
	{
		get
		{
			this.method_9();
			return this.func_0;
		}
		set
		{
			this.method_9();
			this.func_0 = value;
		}
	}

	// Token: 0x1700012A RID: 298
	// (get) Token: 0x060004B9 RID: 1209 RVA: 0x00006319 File Offset: 0x00004519
	// (set) Token: 0x060004BA RID: 1210 RVA: 0x00006327 File Offset: 0x00004527
	public string String_0
	{
		get
		{
			this.method_9();
			return this.string_0;
		}
		set
		{
			this.method_9();
			this.string_0 = value;
		}
	}

	// Token: 0x1700012B RID: 299
	// (get) Token: 0x060004BB RID: 1211 RVA: 0x00006336 File Offset: 0x00004536
	// (set) Token: 0x060004BC RID: 1212 RVA: 0x00006344 File Offset: 0x00004544
	public bool Boolean_2
	{
		get
		{
			this.method_9();
			return this.bool_1;
		}
		set
		{
			this.method_9();
			this.bool_1 = value;
		}
	}

	// Token: 0x1700012C RID: 300
	// (get) Token: 0x060004BD RID: 1213 RVA: 0x00006353 File Offset: 0x00004553
	public bool Boolean_3
	{
		get
		{
			return this.bool_2;
		}
	}

	// Token: 0x1700012D RID: 301
	// (get) Token: 0x060004BE RID: 1214 RVA: 0x00005BAB File Offset: 0x00003DAB
	public static bool Boolean_4
	{
		get
		{
			return true;
		}
	}

	// Token: 0x1700012E RID: 302
	// (get) Token: 0x060004BF RID: 1215 RVA: 0x0000635D File Offset: 0x0000455D
	public GClass6 GClass6_0
	{
		get
		{
			return this.gclass6_0;
		}
	}

	// Token: 0x1700012F RID: 303
	// (get) Token: 0x060004C0 RID: 1216 RVA: 0x00006365 File Offset: 0x00004565
	public GClass21 GClass21_0
	{
		get
		{
			this.method_9();
			return this.gclass21_0;
		}
	}

	// Token: 0x17000130 RID: 304
	// (get) Token: 0x060004C1 RID: 1217 RVA: 0x00006373 File Offset: 0x00004573
	// (set) Token: 0x060004C2 RID: 1218 RVA: 0x00006381 File Offset: 0x00004581
	public string String_1
	{
		get
		{
			this.method_9();
			return this.string_2;
		}
		set
		{
			this.method_9();
			this.string_2 = value;
		}
	}

	// Token: 0x17000131 RID: 305
	// (get) Token: 0x060004C3 RID: 1219 RVA: 0x0002D6CC File Offset: 0x0002B8CC
	// (set) Token: 0x060004C4 RID: 1220 RVA: 0x00006390 File Offset: 0x00004590
	public GClass26 GClass26_0
	{
		get
		{
			this.method_9();
			GClass26 gclass;
			if ((gclass = this.gclass26_0) == null)
			{
				gclass = (this.gclass26_0 = new GClass26());
			}
			return gclass;
		}
		set
		{
			this.method_9();
			this.gclass26_0 = value;
		}
	}

	// Token: 0x17000132 RID: 306
	// (get) Token: 0x060004C5 RID: 1221 RVA: 0x00003657 File Offset: 0x00001857
	// (set) Token: 0x060004C6 RID: 1222 RVA: 0x00003657 File Offset: 0x00001857
	public bool Boolean_5
	{
		get
		{
			throw new NotSupportedException();
		}
		set
		{
			throw new NotSupportedException();
		}
	}

	// Token: 0x17000133 RID: 307
	// (get) Token: 0x060004C7 RID: 1223 RVA: 0x0000639F File Offset: 0x0000459F
	// (set) Token: 0x060004C8 RID: 1224 RVA: 0x000063AD File Offset: 0x000045AD
	public Func<IIdentity, GClass25> Func_1
	{
		get
		{
			this.method_9();
			return this.func_1;
		}
		set
		{
			this.method_9();
			this.func_1 = value;
		}
	}

	// Token: 0x060004C9 RID: 1225 RVA: 0x0002D6F8 File Offset: 0x0002B8F8
	private void method_0()
	{
		Class62[] array = null;
		object obj = this.object_0;
		lock (obj)
		{
			if (this.dictionary_0.Count == 0)
			{
				return;
			}
			Dictionary<Class62, Class62>.KeyCollection keys = this.dictionary_0.Keys;
			array = new Class62[keys.Count];
			keys.CopyTo(array, 0);
			this.dictionary_0.Clear();
		}
		for (int i = array.Length - 1; i >= 0; i--)
		{
			array[i].method_10(true);
		}
	}

	// Token: 0x060004CA RID: 1226 RVA: 0x0002D788 File Offset: 0x0002B988
	private void method_1(bool bool_4)
	{
		GClass20[] array = null;
		object obj = this.object_1;
		lock (obj)
		{
			if (this.list_0.Count == 0)
			{
				return;
			}
			array = this.list_0.ToArray();
			this.list_0.Clear();
		}
		if (!bool_4)
		{
			return;
		}
		GClass20[] array2 = array;
		for (int i = 0; i < array2.Length; i++)
		{
			GClass23 gclass23_ = array2[i].GClass23_0;
			gclass23_.Int32_0 = 503;
			gclass23_.method_10();
		}
	}

	// Token: 0x060004CB RID: 1227 RVA: 0x0002D81C File Offset: 0x0002BA1C
	private void method_2()
	{
		GClass20[] array = null;
		object obj = this.object_2;
		lock (obj)
		{
			if (this.dictionary_1.Count == 0)
			{
				return;
			}
			Dictionary<GClass20, GClass20>.KeyCollection keys = this.dictionary_1.Keys;
			array = new GClass20[keys.Count];
			keys.CopyTo(array, 0);
			this.dictionary_1.Clear();
		}
		for (int i = array.Length - 1; i >= 0; i--)
		{
			array[i].Class62_0.method_10(true);
		}
	}

	// Token: 0x060004CC RID: 1228 RVA: 0x0002D8B0 File Offset: 0x0002BAB0
	private void method_3(Exception exception_0)
	{
		Class65[] array = null;
		object obj = this.object_3;
		lock (obj)
		{
			if (this.list_1.Count == 0)
			{
				return;
			}
			array = this.list_1.ToArray();
			this.list_1.Clear();
		}
		Class65[] array2 = array;
		for (int i = 0; i < array2.Length; i++)
		{
			array2[i].method_0(exception_0);
		}
	}

	// Token: 0x060004CD RID: 1229 RVA: 0x0002D930 File Offset: 0x0002BB30
	private void method_4(bool bool_4)
	{
		if (this.bool_2)
		{
			this.bool_2 = false;
			Class61.smethod_6(this);
		}
		object obj = this.object_2;
		lock (obj)
		{
			this.method_1(!bool_4);
		}
		this.method_2();
		this.method_0();
		this.method_3(new ObjectDisposedException(base.GetType().ToString()));
		this.bool_0 = true;
	}

	// Token: 0x060004CE RID: 1230 RVA: 0x000063BC File Offset: 0x000045BC
	private Class65 method_5()
	{
		if (this.list_1.Count == 0)
		{
			return null;
		}
		Class65 @class = this.list_1[0];
		this.list_1.RemoveAt(0);
		return @class;
	}

	// Token: 0x060004CF RID: 1231 RVA: 0x000063E5 File Offset: 0x000045E5
	private GClass20 method_6()
	{
		if (this.list_0.Count == 0)
		{
			return null;
		}
		GClass20 gclass = this.list_0[0];
		this.list_0.RemoveAt(0);
		return gclass;
	}

	// Token: 0x060004D0 RID: 1232 RVA: 0x0002D9B8 File Offset: 0x0002BBB8
	internal bool method_7(Class62 class62_0)
	{
		if (!this.bool_2)
		{
			return false;
		}
		object obj = this.object_0;
		bool flag2;
		lock (obj)
		{
			if (!this.bool_2)
			{
				flag2 = false;
			}
			else
			{
				this.dictionary_0[class62_0] = class62_0;
				flag2 = true;
			}
		}
		return flag2;
	}

	// Token: 0x060004D1 RID: 1233 RVA: 0x0002DA1C File Offset: 0x0002BC1C
	internal Class65 method_8(Class65 class65_0)
	{
		object obj = this.object_2;
		lock (obj)
		{
			if (!this.bool_2)
			{
				throw new GException2(995);
			}
			GClass20 gclass = this.method_6();
			if (gclass == null)
			{
				this.list_1.Add(class65_0);
			}
			else
			{
				class65_0.method_2(gclass, true);
			}
		}
		return class65_0;
	}

	// Token: 0x060004D2 RID: 1234 RVA: 0x0000640E File Offset: 0x0000460E
	internal void method_9()
	{
		if (this.bool_0)
		{
			throw new ObjectDisposedException(base.GetType().ToString());
		}
	}

	// Token: 0x060004D3 RID: 1235 RVA: 0x0002DA90 File Offset: 0x0002BC90
	internal string method_10()
	{
		string text = this.string_2;
		if (text != null && text.Length > 0)
		{
			return text;
		}
		return GClass19.string_1;
	}

	// Token: 0x060004D4 RID: 1236 RVA: 0x00006429 File Offset: 0x00004629
	internal Func<IIdentity, GClass25> method_11()
	{
		return this.func_1;
	}

	// Token: 0x060004D5 RID: 1237 RVA: 0x0002DAB8 File Offset: 0x0002BCB8
	internal bool method_12(GClass20 gclass20_0)
	{
		if (!this.bool_2)
		{
			return false;
		}
		object obj = this.object_2;
		bool flag2;
		lock (obj)
		{
			if (!this.bool_2)
			{
				flag2 = false;
			}
			else
			{
				this.dictionary_1[gclass20_0] = gclass20_0;
				Class65 @class = this.method_5();
				if (@class == null)
				{
					this.list_0.Add(gclass20_0);
				}
				else
				{
					@class.method_1(gclass20_0);
				}
				flag2 = true;
			}
		}
		return flag2;
	}

	// Token: 0x060004D6 RID: 1238 RVA: 0x0002DB3C File Offset: 0x0002BD3C
	internal void method_13(Class62 class62_0)
	{
		object obj = this.object_0;
		lock (obj)
		{
			this.dictionary_0.Remove(class62_0);
		}
	}

	// Token: 0x060004D7 RID: 1239 RVA: 0x0002DB84 File Offset: 0x0002BD84
	internal AuthenticationSchemes method_14(GClass22 gclass22_0)
	{
		Func<GClass22, AuthenticationSchemes> func = this.func_0;
		if (func == null)
		{
			return this.authenticationSchemes_0;
		}
		AuthenticationSchemes authenticationSchemes;
		try
		{
			authenticationSchemes = func(gclass22_0);
		}
		catch
		{
			authenticationSchemes = AuthenticationSchemes.None;
		}
		return authenticationSchemes;
	}

	// Token: 0x060004D8 RID: 1240 RVA: 0x0002DBC4 File Offset: 0x0002BDC4
	internal void method_15(GClass20 gclass20_0)
	{
		object obj = this.object_2;
		lock (obj)
		{
			this.dictionary_1.Remove(gclass20_0);
		}
	}

	// Token: 0x060004D9 RID: 1241 RVA: 0x00006431 File Offset: 0x00004631
	public void method_16()
	{
		if (this.bool_0)
		{
			return;
		}
		this.method_4(true);
	}

	// Token: 0x060004DA RID: 1242 RVA: 0x0002DC0C File Offset: 0x0002BE0C
	public IAsyncResult method_17(AsyncCallback asyncCallback_0, object object_4)
	{
		this.method_9();
		if (this.gclass21_0.Count == 0)
		{
			throw new InvalidOperationException("The listener has no URI prefix on which listens.");
		}
		if (!this.bool_2)
		{
			throw new InvalidOperationException("The listener hasn't been started.");
		}
		return this.method_8(new Class65(asyncCallback_0, object_4));
	}

	// Token: 0x060004DB RID: 1243 RVA: 0x00006443 File Offset: 0x00004643
	public void method_18()
	{
		if (this.bool_0)
		{
			return;
		}
		this.method_4(false);
	}

	// Token: 0x060004DC RID: 1244 RVA: 0x0002DC5C File Offset: 0x0002BE5C
	public GClass20 method_19(IAsyncResult iasyncResult_0)
	{
		this.method_9();
		if (iasyncResult_0 == null)
		{
			throw new ArgumentNullException("asyncResult");
		}
		Class65 @class = iasyncResult_0 as Class65;
		if (@class == null)
		{
			throw new ArgumentException("A wrong IAsyncResult.", "asyncResult");
		}
		if (@class.Boolean_0)
		{
			throw new InvalidOperationException("This IAsyncResult cannot be reused.");
		}
		@class.Boolean_0 = true;
		if (!@class.IsCompleted)
		{
			@class.AsyncWaitHandle.WaitOne();
		}
		return @class.method_3();
	}

	// Token: 0x060004DD RID: 1245 RVA: 0x0002DCCC File Offset: 0x0002BECC
	public GClass20 method_20()
	{
		this.method_9();
		if (this.gclass21_0.Count == 0)
		{
			throw new InvalidOperationException("The listener has no URI prefix on which listens.");
		}
		if (!this.bool_2)
		{
			throw new InvalidOperationException("The listener hasn't been started.");
		}
		Class65 @class = this.method_8(new Class65(null, null));
		@class.Boolean_1 = true;
		return this.method_19(@class);
	}

	// Token: 0x060004DE RID: 1246 RVA: 0x00006455 File Offset: 0x00004655
	public void method_21()
	{
		this.method_9();
		if (this.bool_2)
		{
			return;
		}
		Class61.smethod_4(this);
		this.bool_2 = true;
	}

	// Token: 0x060004DF RID: 1247 RVA: 0x0002DD28 File Offset: 0x0002BF28
	public void method_22()
	{
		this.method_9();
		if (!this.bool_2)
		{
			return;
		}
		this.bool_2 = false;
		Class61.smethod_6(this);
		object obj = this.object_2;
		lock (obj)
		{
			this.method_1(true);
		}
		this.method_2();
		this.method_0();
		this.method_3(new GException2(995, "The listener is stopped."));
	}

	// Token: 0x060004E0 RID: 1248 RVA: 0x00006431 File Offset: 0x00004631
	public void Dispose()
	{
		if (this.bool_0)
		{
			return;
		}
		this.method_4(true);
	}

	// Token: 0x0400023A RID: 570
	private AuthenticationSchemes authenticationSchemes_0;

	// Token: 0x0400023B RID: 571
	private Func<GClass22, AuthenticationSchemes> func_0;

	// Token: 0x0400023C RID: 572
	private string string_0;

	// Token: 0x0400023D RID: 573
	private Dictionary<Class62, Class62> dictionary_0;

	// Token: 0x0400023E RID: 574
	private object object_0;

	// Token: 0x0400023F RID: 575
	private List<GClass20> list_0;

	// Token: 0x04000240 RID: 576
	private object object_1;

	// Token: 0x04000241 RID: 577
	private Dictionary<GClass20, GClass20> dictionary_1;

	// Token: 0x04000242 RID: 578
	private object object_2;

	// Token: 0x04000243 RID: 579
	private static readonly string string_1 = "SECRET AREA";

	// Token: 0x04000244 RID: 580
	private bool bool_0;

	// Token: 0x04000245 RID: 581
	private bool bool_1;

	// Token: 0x04000246 RID: 582
	private volatile bool bool_2;

	// Token: 0x04000247 RID: 583
	private GClass6 gclass6_0;

	// Token: 0x04000248 RID: 584
	private GClass21 gclass21_0;

	// Token: 0x04000249 RID: 585
	private string string_2;

	// Token: 0x0400024A RID: 586
	private bool bool_3;

	// Token: 0x0400024B RID: 587
	private GClass26 gclass26_0;

	// Token: 0x0400024C RID: 588
	private Func<IIdentity, GClass25> func_1;

	// Token: 0x0400024D RID: 589
	private List<Class65> list_1;

	// Token: 0x0400024E RID: 590
	private object object_3;
}
