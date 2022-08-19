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

	// RVA: 0x152BAC0 Offset: 0x152A0C0 VA: 0x18152BAC0
	public static DeflateStreamNative Create(Stream compressedStream, CompressionMode mode, bool gzip) { }

	// RVA: 0x152BD30 Offset: 0x152A330 VA: 0x18152BD30 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x152BC80 Offset: 0x152A280 VA: 0x18152BC80
	public void Dispose(bool disposing) { }

	// RVA: 0x152BDF0 Offset: 0x152A3F0 VA: 0x18152BDF0
	public void Flush() { }

	// RVA: 0x152BF80 Offset: 0x152A580 VA: 0x18152BF80
	public int ReadZStream(IntPtr buffer, int length) { }

	// RVA: 0x152C640 Offset: 0x152AC40 VA: 0x18152C640
	public void WriteZStream(IntPtr buffer, int length) { }

	[MonoPInvokeCallbackAttribute] // RVA: 0xB30D0 Offset: 0xB24D0 VA: 0x1800B30D0
	// RVA: 0x152C160 Offset: 0x152A760 VA: 0x18152C160
	private static int UnmanagedRead(IntPtr buffer, int length, IntPtr data) { }

	// RVA: 0x152C030 Offset: 0x152A630 VA: 0x18152C030
	private int UnmanagedRead(IntPtr buffer, int length) { }

	[MonoPInvokeCallbackAttribute] // RVA: 0xB31C0 Offset: 0xB25C0 VA: 0x1800B31C0
	// RVA: 0x152C460 Offset: 0x152AA60 VA: 0x18152C460
	private static int UnmanagedWrite(IntPtr buffer, int length, IntPtr data) { }

	// RVA: 0x152C310 Offset: 0x152A910 VA: 0x18152C310
	private int UnmanagedWrite(IntPtr buffer, int length) { }

	// RVA: 0x152B8E0 Offset: 0x1529EE0 VA: 0x18152B8E0
	private static void CheckResult(int result, string where) { }

	// RVA: 0x152BA10 Offset: 0x152A010 VA: 0x18152BA10
	private static extern DeflateStreamNative.SafeDeflateStreamHandle CreateZStream(CompressionMode compress, bool gzip, DeflateStreamNative.UnmanagedReadOrWrite feeder, IntPtr data) { }

	// RVA: 0x152BA00 Offset: 0x152A000 VA: 0x18152BA00
	private static extern int CloseZStream(IntPtr stream) { }

	// RVA: 0x152BE90 Offset: 0x152A490 VA: 0x18152BE90
	private static extern int Flush(DeflateStreamNative.SafeDeflateStreamHandle stream) { }

	// RVA: 0x152BF00 Offset: 0x152A500 VA: 0x18152BF00
	private static extern int ReadZStream(DeflateStreamNative.SafeDeflateStreamHandle stream, IntPtr buffer, int length) { }

	// RVA: 0x152C6F0 Offset: 0x152ACF0 VA: 0x18152C6F0
	private static extern int WriteZStream(DeflateStreamNative.SafeDeflateStreamHandle stream, IntPtr buffer, int length) { }

}

private sealed class DeflateStreamNative.UnmanagedReadOrWrite : MulticastDelegate // TypeDefIndex: 2866
{	// Methods

	// RVA: 0x49A360 Offset: 0x498960 VA: 0x18049A360
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x15375B0 Offset: 0x1535BB0 VA: 0x1815375B0 Slot: 12
	public virtual int Invoke(IntPtr buffer, int length, IntPtr data) { }

	// RVA: 0x1537510 Offset: 0x1535B10 VA: 0x181537510 Slot: 13
	public virtual IAsyncResult BeginInvoke(IntPtr buffer, int length, IntPtr data, AsyncCallback callback, object object) { }

	// RVA: 0xB9A710 Offset: 0xB98D10 VA: 0x180B9A710 Slot: 14
	public virtual int EndInvoke(IAsyncResult result) { }

}

private sealed class DeflateStreamNative.SafeDeflateStreamHandle : SafeHandle // TypeDefIndex: 2867
{	// Properties
	public override bool IsInvalid { get; }

	// Methods

	// RVA: 0x1536DB0 Offset: 0x15353B0 VA: 0x181536DB0 Slot: 5
	public override bool get_IsInvalid() { }

	// RVA: 0x1536D70 Offset: 0x1535370 VA: 0x181536D70
	private void .ctor() { }

	// RVA: 0x1536D50 Offset: 0x1535350 VA: 0x181536D50 Slot: 7
	protected override bool ReleaseHandle() { }

}

