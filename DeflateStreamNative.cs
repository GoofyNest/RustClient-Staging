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

	// RVA: 0x152BD80 Offset: 0x152A380 VA: 0x18152BD80
	public static DeflateStreamNative Create(Stream compressedStream, CompressionMode mode, bool gzip) { }

	// RVA: 0x152BFF0 Offset: 0x152A5F0 VA: 0x18152BFF0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x152BF40 Offset: 0x152A540 VA: 0x18152BF40
	public void Dispose(bool disposing) { }

	// RVA: 0x152C0B0 Offset: 0x152A6B0 VA: 0x18152C0B0
	public void Flush() { }

	// RVA: 0x152C240 Offset: 0x152A840 VA: 0x18152C240
	public int ReadZStream(IntPtr buffer, int length) { }

	// RVA: 0x152C900 Offset: 0x152AF00 VA: 0x18152C900
	public void WriteZStream(IntPtr buffer, int length) { }

	[MonoPInvokeCallbackAttribute] // RVA: 0xB3170 Offset: 0xB2570 VA: 0x1800B3170
	// RVA: 0x152C420 Offset: 0x152AA20 VA: 0x18152C420
	private static int UnmanagedRead(IntPtr buffer, int length, IntPtr data) { }

	// RVA: 0x152C2F0 Offset: 0x152A8F0 VA: 0x18152C2F0
	private int UnmanagedRead(IntPtr buffer, int length) { }

	[MonoPInvokeCallbackAttribute] // RVA: 0xB31F0 Offset: 0xB25F0 VA: 0x1800B31F0
	// RVA: 0x152C720 Offset: 0x152AD20 VA: 0x18152C720
	private static int UnmanagedWrite(IntPtr buffer, int length, IntPtr data) { }

	// RVA: 0x152C5D0 Offset: 0x152ABD0 VA: 0x18152C5D0
	private int UnmanagedWrite(IntPtr buffer, int length) { }

	// RVA: 0x152BBA0 Offset: 0x152A1A0 VA: 0x18152BBA0
	private static void CheckResult(int result, string where) { }

	// RVA: 0x152BCD0 Offset: 0x152A2D0 VA: 0x18152BCD0
	private static extern DeflateStreamNative.SafeDeflateStreamHandle CreateZStream(CompressionMode compress, bool gzip, DeflateStreamNative.UnmanagedReadOrWrite feeder, IntPtr data) { }

	// RVA: 0x152BCC0 Offset: 0x152A2C0 VA: 0x18152BCC0
	private static extern int CloseZStream(IntPtr stream) { }

	// RVA: 0x152C150 Offset: 0x152A750 VA: 0x18152C150
	private static extern int Flush(DeflateStreamNative.SafeDeflateStreamHandle stream) { }

	// RVA: 0x152C1C0 Offset: 0x152A7C0 VA: 0x18152C1C0
	private static extern int ReadZStream(DeflateStreamNative.SafeDeflateStreamHandle stream, IntPtr buffer, int length) { }

	// RVA: 0x152C9B0 Offset: 0x152AFB0 VA: 0x18152C9B0
	private static extern int WriteZStream(DeflateStreamNative.SafeDeflateStreamHandle stream, IntPtr buffer, int length) { }

}

private sealed class DeflateStreamNative.UnmanagedReadOrWrite : MulticastDelegate // TypeDefIndex: 2866
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1537870 Offset: 0x1535E70 VA: 0x181537870 Slot: 12
	public virtual int Invoke(IntPtr buffer, int length, IntPtr data) { }

	// RVA: 0x15377D0 Offset: 0x1535DD0 VA: 0x1815377D0 Slot: 13
	public virtual IAsyncResult BeginInvoke(IntPtr buffer, int length, IntPtr data, AsyncCallback callback, object object) { }

	// RVA: 0xB9A9D0 Offset: 0xB98FD0 VA: 0x180B9A9D0 Slot: 14
	public virtual int EndInvoke(IAsyncResult result) { }

}

private sealed class DeflateStreamNative.SafeDeflateStreamHandle : SafeHandle // TypeDefIndex: 2867
{	// Properties
	public override bool IsInvalid { get; }

	// Methods

	// RVA: 0x1537070 Offset: 0x1535670 VA: 0x181537070 Slot: 5
	public override bool get_IsInvalid() { }

	// RVA: 0x1537030 Offset: 0x1535630 VA: 0x181537030
	private void .ctor() { }

	// RVA: 0x1537010 Offset: 0x1535610 VA: 0x181537010 Slot: 7
	protected override bool ReleaseHandle() { }

}

