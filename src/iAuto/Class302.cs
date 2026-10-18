using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Token: 0x020001C2 RID: 450
[Serializable]
internal class Class302 : GClass38, IDisposable
{
	// Token: 0x06001879 RID: 6265 RVA: 0x00010CED File Offset: 0x0000EEED
	public Class302(int int_0)
	{
		if (int_0 > 0)
		{
			this.IntPtr_0 = Marshal.AllocHGlobal(int_0);
			this.Int32_0 = int_0;
			return;
		}
		this.IntPtr_0 = IntPtr.Zero;
		this.Int32_0 = 0;
	}

	// Token: 0x170004B8 RID: 1208
	// (get) Token: 0x0600187A RID: 6266 RVA: 0x00010D1F File Offset: 0x0000EF1F
	// (set) Token: 0x0600187B RID: 6267 RVA: 0x00010D27 File Offset: 0x0000EF27
	public IntPtr IntPtr_0 { get; private set; }

	// Token: 0x170004B9 RID: 1209
	// (get) Token: 0x0600187C RID: 6268 RVA: 0x00010D30 File Offset: 0x0000EF30
	// (set) Token: 0x0600187D RID: 6269 RVA: 0x00010D38 File Offset: 0x0000EF38
	public int Int32_0 { get; private set; }

	// Token: 0x0600187E RID: 6270 RVA: 0x00010D41 File Offset: 0x0000EF41
	public void Dispose()
	{
		this.method_3(true);
		GC.SuppressFinalize(this);
	}

	// Token: 0x0600187F RID: 6271 RVA: 0x000CC228 File Offset: 0x000CA428
	private bool method_0(int int_0)
	{
		bool flag;
		try
		{
			if (int_0 > this.Int32_0)
			{
				this.IntPtr_0 = ((this.IntPtr_0 == IntPtr.Zero) ? Marshal.AllocHGlobal(int_0) : Marshal.ReAllocHGlobal(this.IntPtr_0, new IntPtr(int_0)));
				this.Int32_0 = int_0;
			}
			flag = true;
		}
		catch (Exception ex)
		{
			flag = this.vmethod_2(ex);
		}
		return flag;
	}

	// Token: 0x06001880 RID: 6272 RVA: 0x000CC298 File Offset: 0x000CA498
	public bool method_1<T>(T gparam_0) where T : struct
	{
		bool flag;
		try
		{
			if (this.method_0(Marshal.SizeOf(typeof(T))))
			{
				Marshal.StructureToPtr<T>(gparam_0, this.IntPtr_0, false);
				flag = true;
			}
			else
			{
				flag = false;
			}
		}
		catch (Exception ex)
		{
			flag = this.vmethod_2(ex);
		}
		return flag;
	}

	// Token: 0x06001881 RID: 6273 RVA: 0x00010D50 File Offset: 0x0000EF50
	public bool method_2(byte[] byte_0, int int_0, int int_1)
	{
		if (byte_0 != null && this.method_0(int_1))
		{
			Marshal.Copy(byte_0, int_0, this.IntPtr_0, int_1);
			return true;
		}
		if (byte_0 == null)
		{
			this.vmethod_2(new ArgumentException("Attempting to commit a null reference", "data"));
		}
		return false;
	}

	// Token: 0x06001882 RID: 6274 RVA: 0x00010D88 File Offset: 0x0000EF88
	private void method_3(bool bool_0)
	{
		if (!this._disposed)
		{
			if (bool_0)
			{
				this.method_6(0);
			}
			this._disposed = true;
		}
	}

	// Token: 0x06001883 RID: 6275 RVA: 0x000CC2F0 File Offset: 0x000CA4F0
	public byte[] method_4(int int_0)
	{
		byte[] array2;
		try
		{
			if (int_0 > this.Int32_0 || int_0 <= 0)
			{
				throw new ArgumentException("There is either not enough memory allocated to read 'count' bytes, or 'count' is negative (" + int_0.ToString() + ")", "count");
			}
			byte[] array = new byte[int_0];
			Marshal.Copy(this.IntPtr_0, array, 0, int_0);
			array2 = array;
		}
		catch (Exception ex)
		{
			this.vmethod_2(ex);
			array2 = null;
		}
		return array2;
	}

	// Token: 0x06001884 RID: 6276 RVA: 0x000CC364 File Offset: 0x000CA564
	public bool method_5<T>(out T gparam_0) where T : struct
	{
		gparam_0 = default(T);
		bool flag;
		try
		{
			if (this.Int32_0 < Marshal.SizeOf(typeof(T)))
			{
				throw new InvalidCastException("Not enough unmanaged memory is allocated to contain this structure type.");
			}
			gparam_0 = (T)((object)Marshal.PtrToStructure(this.IntPtr_0, typeof(T)));
			flag = true;
		}
		catch (Exception ex)
		{
			flag = this.vmethod_2(ex);
		}
		return flag;
	}

	// Token: 0x06001885 RID: 6277 RVA: 0x000CC3DC File Offset: 0x000CA5DC
	public bool method_6(int int_0)
	{
		if (int_0 < 0)
		{
			return this.vmethod_2(new ArgumentException("Attempting to resize to less than zero bytes of memory", "size"));
		}
		if (int_0 == this.Int32_0)
		{
			return true;
		}
		if (int_0 > this.Int32_0)
		{
			return this.method_0(int_0);
		}
		bool flag;
		try
		{
			if (int_0 == 0)
			{
				Marshal.FreeHGlobal(this.IntPtr_0);
				this.IntPtr_0 = IntPtr.Zero;
			}
			else if (int_0 > 0)
			{
				this.IntPtr_0 = Marshal.ReAllocHGlobal(this.IntPtr_0, new IntPtr(int_0));
			}
			this.Int32_0 = int_0;
			flag = true;
		}
		catch (Exception ex)
		{
			flag = this.vmethod_2(ex);
		}
		return flag;
	}

	// Token: 0x06001886 RID: 6278 RVA: 0x000CC480 File Offset: 0x000CA680
	public bool method_7<T>() where T : struct
	{
		bool flag;
		try
		{
			if (this.Int32_0 < Marshal.SizeOf(typeof(T)))
			{
				throw new InvalidCastException("Not enough unmanaged memory is allocated to contain this structure type.");
			}
			Marshal.DestroyStructure(this.IntPtr_0, typeof(T));
			flag = true;
		}
		catch (Exception ex)
		{
			flag = this.vmethod_2(ex);
		}
		return flag;
	}

	// Token: 0x06001887 RID: 6279 RVA: 0x00010DA4 File Offset: 0x0000EFA4
	public bool method_8<T>(T gparam_0, out byte[] byte_0) where T : struct
	{
		byte_0 = null;
		if (this.method_1<T>(gparam_0))
		{
			byte_0 = this.method_4(Marshal.SizeOf(typeof(T)));
			this.method_7<T>();
		}
		return byte_0 != null;
	}

	// Token: 0x06001888 RID: 6280 RVA: 0x00010DD5 File Offset: 0x0000EFD5
	public bool method_9<T>(byte[] byte_0, out T gparam_0) where T : struct
	{
		gparam_0 = default(T);
		if (byte_0 == null)
		{
			return this.vmethod_2(new ArgumentException("Attempted to translate a null reference to a structure.", "buffer"));
		}
		return this.method_2(byte_0, 0, byte_0.Length) && this.method_5<T>(out gparam_0);
	}

	// Token: 0x06001889 RID: 6281 RVA: 0x00010E0D File Offset: 0x0000F00D
	public bool method_10<T, U>(T gparam_0, out U gparam_1) where T : struct where U : struct
	{
		gparam_1 = default(U);
		return this.method_1<T>(gparam_0) && this.method_5<U>(out gparam_1) && this.method_7<T>();
	}

	// Token: 0x0400102E RID: 4142
	private bool _disposed;

	// Token: 0x0400102F RID: 4143
	[CompilerGenerated]
	private IntPtr f_0EC3CA5E;

	// Token: 0x04001030 RID: 4144
	[CompilerGenerated]
	private int f_BC092CCC;
}
