using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

// Token: 0x020001C1 RID: 449
[Serializable]
internal class Class300 : GClass38, IDisposable
{
	// Token: 0x0600186E RID: 6254 RVA: 0x00010C49 File Offset: 0x0000EE49
	public Class300(byte[] byte_0)
	{
		if (byte_0 == null)
		{
			throw new ArgumentException("Unable to iterate a null reference", "iterable");
		}
		this._base = new MemoryStream(byte_0, 0, byte_0.Length, true);
		this._ubuffer = new Class302(256);
	}

	// Token: 0x0600186F RID: 6255 RVA: 0x00010C85 File Offset: 0x0000EE85
	public void Dispose()
	{
		this.vmethod_4(true);
		GC.SuppressFinalize(this);
	}

	// Token: 0x06001870 RID: 6256 RVA: 0x00010C94 File Offset: 0x0000EE94
	protected virtual void vmethod_4(bool bool_0)
	{
		if (!this._disposed)
		{
			if (bool_0)
			{
				this._ubuffer.Dispose();
				this._base.Dispose();
			}
			this._disposed = true;
		}
	}

	// Token: 0x06001871 RID: 6257 RVA: 0x00010CBE File Offset: 0x0000EEBE
	protected byte[] method_0()
	{
		return this._base.ToArray();
	}

	// Token: 0x06001872 RID: 6258 RVA: 0x00010CCB File Offset: 0x0000EECB
	public bool method_1<T>(out T gparam_0) where T : struct
	{
		return this.method_3<T>(0L, SeekOrigin.Current, out gparam_0);
	}

	// Token: 0x06001873 RID: 6259 RVA: 0x000CBF7C File Offset: 0x000CA17C
	public bool method_2(long long_0, SeekOrigin seekOrigin_0, byte[] byte_0)
	{
		if (byte_0 == null)
		{
			throw new ArgumentNullException("buffer", "Parameter cannot be null");
		}
		try
		{
			this._base.Seek(long_0, seekOrigin_0);
			this._base.Read(byte_0, 0, byte_0.Length);
		}
		catch (Exception ex)
		{
			this.vmethod_2(ex);
			byte_0 = null;
		}
		return byte_0 != null;
	}

	// Token: 0x06001874 RID: 6260 RVA: 0x000CBFE0 File Offset: 0x000CA1E0
	public bool method_3<T>(long long_0, SeekOrigin seekOrigin_0, out T gparam_0) where T : struct
	{
		gparam_0 = default(T);
		bool flag;
		try
		{
			this._base.Seek(long_0, seekOrigin_0);
			byte[] array = new byte[Marshal.SizeOf(typeof(T))];
			this._base.Read(array, 0, array.Length);
			if (!this._ubuffer.method_9<T>(array, out gparam_0))
			{
				throw this._ubuffer.vmethod_1();
			}
			flag = true;
		}
		catch (Exception ex)
		{
			flag = base.vmethod_2(ex);
		}
		return flag;
	}

	// Token: 0x06001875 RID: 6261 RVA: 0x000CC064 File Offset: 0x000CA264
	public bool method_4(long long_0, SeekOrigin seekOrigin_0, out string string_0, int int_0 = -1, Encoding encoding_0 = null)
	{
		string_0 = null;
		byte[] array = new byte[(int_0 > 0) ? int_0 : 64];
		if (encoding_0 == null)
		{
			encoding_0 = Encoding.ASCII;
		}
		bool flag;
		try
		{
			this._base.Seek(long_0, seekOrigin_0);
			StringBuilder stringBuilder = new StringBuilder((int_0 > 0) ? int_0 : 260);
			int num = -1;
			int num2 = 0;
			int num3;
			while (num == -1 && (num3 = this._base.Read(array, 0, array.Length)) > 0)
			{
				stringBuilder.Append(encoding_0.GetString(array));
				num = stringBuilder.ToString().IndexOf('\0', num2);
				num2 += num3;
				if (int_0 > 0 && num2 >= int_0)
				{
					break;
				}
			}
			if (num > -1)
			{
				string_0 = stringBuilder.ToString().Substring(0, num);
			}
			else if (num2 >= int_0 && int_0 > 0)
			{
				string_0 = stringBuilder.ToString().Substring(0, int_0);
			}
			flag = string_0 != null;
		}
		catch (Exception ex)
		{
			flag = this.vmethod_2(ex);
		}
		return flag;
	}

	// Token: 0x06001876 RID: 6262 RVA: 0x00010CDE File Offset: 0x0000EEDE
	public long method_5(long long_0, SeekOrigin seekOrigin_0)
	{
		return this._base.Seek(long_0, seekOrigin_0);
	}

	// Token: 0x06001877 RID: 6263 RVA: 0x000CC160 File Offset: 0x000CA360
	public bool method_6(long long_0, SeekOrigin seekOrigin_0, byte[] byte_0)
	{
		if (byte_0 == null)
		{
			throw new ArgumentNullException("Parameter 'data' cannot be null");
		}
		bool flag;
		try
		{
			this._base.Seek(long_0, seekOrigin_0);
			this._base.Write(byte_0, 0, byte_0.Length);
			flag = true;
		}
		catch (Exception ex)
		{
			flag = this.vmethod_2(ex);
		}
		return flag;
	}

	// Token: 0x06001878 RID: 6264 RVA: 0x000CC1BC File Offset: 0x000CA3BC
	public bool method_7<T>(long long_0, SeekOrigin seekOrigin_0, T gparam_0) where T : struct
	{
		bool flag;
		try
		{
			this._base.Seek(long_0, seekOrigin_0);
			byte[] array = null;
			if (!this._ubuffer.method_8<T>(gparam_0, out array))
			{
				throw this._ubuffer.vmethod_1();
			}
			this._base.Write(array, 0, array.Length);
			flag = true;
		}
		catch (Exception ex)
		{
			flag = this.vmethod_2(ex);
		}
		return flag;
	}

	// Token: 0x0400102B RID: 4139
	private MemoryStream _base;

	// Token: 0x0400102C RID: 4140
	private bool _disposed;

	// Token: 0x0400102D RID: 4141
	private Class302 _ubuffer;
}
