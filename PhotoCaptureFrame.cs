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
	// RVA: 0x7D0D90 Offset: 0x7CF390 VA: 0x1807D0D90
	private void set_dataLength(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7D0DB0 Offset: 0x7CF3B0 VA: 0x1807D0DB0
	private void set_hasLocationData(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x69D730 Offset: 0x69BD30 VA: 0x18069D730
	private void set_pixelFormat(CapturePixelFormat value) { }

	[ThreadAndSerializationSafeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2178C00 Offset: 0x2177200 VA: 0x182178C00
	private int GetDataLength() { }

	[ThreadAndSerializationSafeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2178C40 Offset: 0x2177240 VA: 0x182178C40
	private bool GetHasLocationData() { }

	[ThreadAndSerializationSafeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2178BC0 Offset: 0x21771C0 VA: 0x182178BC0
	private CapturePixelFormat GetCapturePixelFormat() { }

	// RVA: 0x2178C80 Offset: 0x2177280 VA: 0x182178C80
	internal void .ctor(IntPtr nativePtr) { }

	// RVA: 0x21789F0 Offset: 0x2176FF0 VA: 0x1821789F0
	private void Cleanup() { }

	[NativeConditionalAttribute] // RVA: 0xDC030 Offset: 0xDB430 VA: 0x1800DC030
	[ThreadAndSerializationSafeAttribute] // RVA: 0xDC030 Offset: 0xDB430 VA: 0x1800DC030
	[NativeNameAttribute] // RVA: 0xDC030 Offset: 0xDB430 VA: 0x1800DC030
	// RVA: 0x2178A90 Offset: 0x2177090 VA: 0x182178A90
	private void Dispose_Internal() { }

	// RVA: 0x2178AD0 Offset: 0x21770D0 VA: 0x182178AD0 Slot: 4
	public void Dispose() { }

	// RVA: 0x2178B30 Offset: 0x2177130 VA: 0x182178B30 Slot: 1
	protected override void Finalize() { }

}

