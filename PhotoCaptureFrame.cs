public sealed class PhotoCaptureFrame : IDisposable // TypeDefIndex: 3615
{	// Fields
	private IntPtr m_NativePtr; // 0x10
	[DebuggerBrowsableAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	[CompilerGeneratedAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	private int <dataLength>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	[DebuggerBrowsableAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	private bool <hasLocationData>k__BackingField; // 0x1C
	[DebuggerBrowsableAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	[CompilerGeneratedAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	private CapturePixelFormat <pixelFormat>k__BackingField; // 0x20

	// Properties
	public int dataLength { get; set; }
	private bool hasLocationData { set; }
	private CapturePixelFormat pixelFormat { set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4C1470 Offset: 0x4BFA70 VA: 0x1804C1470
	public int get_dataLength() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7D0C80 Offset: 0x7CF280 VA: 0x1807D0C80
	private void set_dataLength(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7D0CA0 Offset: 0x7CF2A0 VA: 0x1807D0CA0
	private void set_hasLocationData(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x69D620 Offset: 0x69BC20 VA: 0x18069D620
	private void set_pixelFormat(CapturePixelFormat value) { }

	[ThreadAndSerializationSafeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2178940 Offset: 0x2176F40 VA: 0x182178940
	private int GetDataLength() { }

	[ThreadAndSerializationSafeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2178980 Offset: 0x2176F80 VA: 0x182178980
	private bool GetHasLocationData() { }

	[ThreadAndSerializationSafeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2178900 Offset: 0x2176F00 VA: 0x182178900
	private CapturePixelFormat GetCapturePixelFormat() { }

	// RVA: 0x21789C0 Offset: 0x2176FC0 VA: 0x1821789C0
	internal void .ctor(IntPtr nativePtr) { }

	// RVA: 0x2178730 Offset: 0x2176D30 VA: 0x182178730
	private void Cleanup() { }

	[NativeConditionalAttribute] // RVA: 0xDC030 Offset: 0xDB430 VA: 0x1800DC030
	[ThreadAndSerializationSafeAttribute] // RVA: 0xDC030 Offset: 0xDB430 VA: 0x1800DC030
	[NativeNameAttribute] // RVA: 0xDC030 Offset: 0xDB430 VA: 0x1800DC030
	// RVA: 0x21787D0 Offset: 0x2176DD0 VA: 0x1821787D0
	private void Dispose_Internal() { }

	// RVA: 0x2178810 Offset: 0x2176E10 VA: 0x182178810 Slot: 4
	public void Dispose() { }

	// RVA: 0x2178870 Offset: 0x2176E70 VA: 0x182178870 Slot: 1
	protected override void Finalize() { }

}

