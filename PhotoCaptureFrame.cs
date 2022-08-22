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
	// RVA: 0x4C1400 Offset: 0x4BFA00 VA: 0x1804C1400
	public int get_dataLength() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x79C6B0 Offset: 0x79ACB0 VA: 0x18079C6B0
	private void set_dataLength(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x79C6D0 Offset: 0x79ACD0 VA: 0x18079C6D0
	private void set_hasLocationData(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x69D6C0 Offset: 0x69BCC0 VA: 0x18069D6C0
	private void set_pixelFormat(CapturePixelFormat value) { }

	[ThreadAndSerializationSafeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2179420 Offset: 0x2177A20 VA: 0x182179420
	private int GetDataLength() { }

	[ThreadAndSerializationSafeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2179460 Offset: 0x2177A60 VA: 0x182179460
	private bool GetHasLocationData() { }

	[ThreadAndSerializationSafeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x21793E0 Offset: 0x21779E0 VA: 0x1821793E0
	private CapturePixelFormat GetCapturePixelFormat() { }

	// RVA: 0x21794A0 Offset: 0x2177AA0 VA: 0x1821794A0
	internal void .ctor(IntPtr nativePtr) { }

	// RVA: 0x2179210 Offset: 0x2177810 VA: 0x182179210
	private void Cleanup() { }

	[NativeConditionalAttribute] // RVA: 0xDC030 Offset: 0xDB430 VA: 0x1800DC030
	[ThreadAndSerializationSafeAttribute] // RVA: 0xDC030 Offset: 0xDB430 VA: 0x1800DC030
	[NativeNameAttribute] // RVA: 0xDC030 Offset: 0xDB430 VA: 0x1800DC030
	// RVA: 0x21792B0 Offset: 0x21778B0 VA: 0x1821792B0
	private void Dispose_Internal() { }

	// RVA: 0x21792F0 Offset: 0x21778F0 VA: 0x1821792F0 Slot: 4
	public void Dispose() { }

	// RVA: 0x2179350 Offset: 0x2177950 VA: 0x182179350 Slot: 1
	protected override void Finalize() { }

}

