internal class DeflateStreamNative // TypeDefIndex: 2865
{	// Fields
	private DeflateStreamNative.UnmanagedReadOrWrite feeder; // 0x10
	private Stream base_stream; // 0x18
	private DeflateStreamNative.SafeDeflateStreamHandle z_stream; // 0x20
	private GCHandle data; // 0x28
	private bool disposed; // 0x2C
	private byte[] io_buffer; // 0x30

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	private void .ctor() { }

	// RVA: 0x152AE50 Offset: 0x1529450 VA: 0x18152AE50
	public static DeflateStreamNative Create(Stream compressedStream, CompressionMode mode, bool gzip) { }

	// RVA: 0x152B0C0 Offset: 0x15296C0 VA: 0x18152B0C0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x152B010 Offset: 0x1529610 VA: 0x18152B010
	public void Dispose(bool disposing) { }

	// RVA: 0x152B180 Offset: 0x1529780 VA: 0x18152B180
	public void Flush() { }

	// RVA: 0x152B310 Offset: 0x1529910 VA: 0x18152B310
	public int ReadZStream(IntPtr buffer, int length) { }

	// RVA: 0x152B9D0 Offset: 0x1529FD0 VA: 0x18152B9D0
	public void WriteZStream(IntPtr buffer, int length) { }

	[MonoPInvokeCallbackAttribute] // RVA: 0xB3170 Offset: 0xB2570 VA: 0x1800B3170
	// RVA: 0x152B4F0 Offset: 0x1529AF0 VA: 0x18152B4F0
	private static int UnmanagedRead(IntPtr buffer, int length, IntPtr data) { }

	// RVA: 0x152B3C0 Offset: 0x15299C0 VA: 0x18152B3C0
	private int UnmanagedRead(IntPtr buffer, int length) { }

	[MonoPInvokeCallbackAttribute] // RVA: 0xB31F0 Offset: 0xB25F0 VA: 0x1800B31F0
	// RVA: 0x152B7F0 Offset: 0x1529DF0 VA: 0x18152B7F0
	private static int UnmanagedWrite(IntPtr buffer, int length, IntPtr data) { }

	// RVA: 0x152B6A0 Offset: 0x1529CA0 VA: 0x18152B6A0
	private int UnmanagedWrite(IntPtr buffer, int length) { }

	// RVA: 0x152AC70 Offset: 0x1529270 VA: 0x18152AC70
	private static void CheckResult(int result, string where) { }

	// RVA: 0x152ADA0 Offset: 0x15293A0 VA: 0x18152ADA0
	private static extern DeflateStreamNative.SafeDeflateStreamHandle CreateZStream(CompressionMode compress, bool gzip, DeflateStreamNative.UnmanagedReadOrWrite feeder, IntPtr data) { }

	// RVA: 0x152AD90 Offset: 0x1529390 VA: 0x18152AD90
	private static extern int CloseZStream(IntPtr stream) { }

	// RVA: 0x152B220 Offset: 0x1529820 VA: 0x18152B220
	private static extern int Flush(DeflateStreamNative.SafeDeflateStreamHandle stream) { }

	// RVA: 0x152B290 Offset: 0x1529890 VA: 0x18152B290
	private static extern int ReadZStream(DeflateStreamNative.SafeDeflateStreamHandle stream, IntPtr buffer, int length) { }

	// RVA: 0x152BA80 Offset: 0x152A080 VA: 0x18152BA80
	private static extern int WriteZStream(DeflateStreamNative.SafeDeflateStreamHandle stream, IntPtr buffer, int length) { }

}

private sealed class DeflateStreamNative.UnmanagedReadOrWrite : MulticastDelegate // TypeDefIndex: 2866
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1536940 Offset: 0x1534F40 VA: 0x181536940 Slot: 12
	public virtual int Invoke(IntPtr buffer, int length, IntPtr data) { }

	// RVA: 0x15368A0 Offset: 0x1534EA0 VA: 0x1815368A0 Slot: 13
	public virtual IAsyncResult BeginInvoke(IntPtr buffer, int length, IntPtr data, AsyncCallback callback, object object) { }

	// RVA: 0xB9AEA0 Offset: 0xB994A0 VA: 0x180B9AEA0 Slot: 14
	public virtual int EndInvoke(IAsyncResult result) { }

}

private sealed class DeflateStreamNative.SafeDeflateStreamHandle : SafeHandle // TypeDefIndex: 2867
{	// Properties
	public override bool IsInvalid { get; }

	// Methods

	// RVA: 0x1536140 Offset: 0x1534740 VA: 0x181536140 Slot: 5
	public override bool get_IsInvalid() { }

	// RVA: 0x1536100 Offset: 0x1534700 VA: 0x181536100
	private void .ctor() { }

	// RVA: 0x15360E0 Offset: 0x15346E0 VA: 0x1815360E0 Slot: 7
	protected override bool ReleaseHandle() { }

}

