public sealed class PhotoCaptureFrame : IDisposable // TypeDefIndex: 3615
{	// Fields
	private IntPtr m_NativePtr; // 0x10
	[DebuggerBrowsableAttribute] // RVA: 0x70760 Offset: 0x6FB60 VA: 0x180070760
	[CompilerGeneratedAttribute] // RVA: 0x70760 Offset: 0x6FB60 VA: 0x180070760
	private int <dataLength>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x708D0 Offset: 0x6FCD0 VA: 0x1800708D0
	[DebuggerBrowsableAttribute] // RVA: 0x708D0 Offset: 0x6FCD0 VA: 0x1800708D0
	private bool <hasLocationData>k__BackingField; // 0x1C
	[CompilerGeneratedAttribute] // RVA: 0x708D0 Offset: 0x6FCD0 VA: 0x1800708D0
	[DebuggerBrowsableAttribute] // RVA: 0x708D0 Offset: 0x6FCD0 VA: 0x1800708D0
	private CapturePixelFormat <pixelFormat>k__BackingField; // 0x20

	// Properties
	public int dataLength { get; set; }
	private bool hasLocationData { set; }
	private CapturePixelFormat pixelFormat { set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x4C1470 Offset: 0x4BFA70 VA: 0x1804C1470
	public int get_dataLength() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x7D0C80 Offset: 0x7CF280 VA: 0x1807D0C80
	private void set_dataLength(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x7D0CA0 Offset: 0x7CF2A0 VA: 0x1807D0CA0
	private void set_hasLocationData(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x69D620 Offset: 0x69BC20 VA: 0x18069D620
	private void set_pixelFormat(CapturePixelFormat value) { }

	[ThreadAndSerializationSafeAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x2178B00 Offset: 0x2177100 VA: 0x182178B00
	private int GetDataLength() { }

	[ThreadAndSerializationSafeAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x2178B40 Offset: 0x2177140 VA: 0x182178B40
	private bool GetHasLocationData() { }

	[ThreadAndSerializationSafeAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x2178AC0 Offset: 0x21770C0 VA: 0x182178AC0
	private CapturePixelFormat GetCapturePixelFormat() { }

	// RVA: 0x2178B80 Offset: 0x2177180 VA: 0x182178B80
	internal void .ctor(IntPtr nativePtr) { }

	// RVA: 0x21788F0 Offset: 0x2176EF0 VA: 0x1821788F0
	private void Cleanup() { }

	[ThreadAndSerializationSafeAttribute] // RVA: 0xDBFD0 Offset: 0xDB3D0 VA: 0x1800DBFD0
	[NativeNameAttribute] // RVA: 0xDBFD0 Offset: 0xDB3D0 VA: 0x1800DBFD0
	[NativeConditionalAttribute] // RVA: 0xDBFD0 Offset: 0xDB3D0 VA: 0x1800DBFD0
	// RVA: 0x2178990 Offset: 0x2176F90 VA: 0x182178990
	private void Dispose_Internal() { }

	// RVA: 0x21789D0 Offset: 0x2176FD0 VA: 0x1821789D0 Slot: 4
	public void Dispose() { }

	// RVA: 0x2178A30 Offset: 0x2177030 VA: 0x182178A30 Slot: 1
	protected override void Finalize() { }

}

