public sealed class PhotoCaptureFrame : IDisposable // TypeDefIndex: 3615
{	private IntPtr m_NativePtr; // 0x10
	[DebuggerBrowsableAttribute] // RVA: 0x70830 Offset: 0x6FC30 VA: 0x180070830
	[CompilerGeneratedAttribute] // RVA: 0x70830 Offset: 0x6FC30 VA: 0x180070830
	private int <dataLength>k__BackingField; // 0x18
	[DebuggerBrowsableAttribute] // RVA: 0x70830 Offset: 0x6FC30 VA: 0x180070830
	[CompilerGeneratedAttribute] // RVA: 0x70830 Offset: 0x6FC30 VA: 0x180070830
	private bool <hasLocationData>k__BackingField; // 0x1C
	[DebuggerBrowsableAttribute] // RVA: 0x70830 Offset: 0x6FC30 VA: 0x180070830
	[CompilerGeneratedAttribute] // RVA: 0x70830 Offset: 0x6FC30 VA: 0x180070830
	private CapturePixelFormat <pixelFormat>k__BackingField; // 0x20

	public int dataLength { get; set; }
	private bool hasLocationData { set; }
	private CapturePixelFormat pixelFormat { set; }


	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public int get_dataLength() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void set_dataLength(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void set_hasLocationData(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private void set_pixelFormat(CapturePixelFormat value) { }

	[ThreadAndSerializationSafeAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private int GetDataLength() { }

	[ThreadAndSerializationSafeAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private bool GetHasLocationData() { }

	[ThreadAndSerializationSafeAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private CapturePixelFormat GetCapturePixelFormat() { }

	internal void .ctor(IntPtr nativePtr) { }

	private void Cleanup() { }

	[NativeNameAttribute] // RVA: 0xDC140 Offset: 0xDB540 VA: 0x1800DC140
	[NativeConditionalAttribute] // RVA: 0xDC140 Offset: 0xDB540 VA: 0x1800DC140
	[ThreadAndSerializationSafeAttribute] // RVA: 0xDC140 Offset: 0xDB540 VA: 0x1800DC140
	private void Dispose_Internal() { }

	public void Dispose() { }

	protected override void Finalize() { }

}

