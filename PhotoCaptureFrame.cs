public sealed class PhotoCaptureFrame : IDisposable // TypeDefIndex: 3615
{	private IntPtr m_NativePtr; // 0x10
	[DebuggerBrowsableAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	[CompilerGeneratedAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	private int <dataLength>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	[DebuggerBrowsableAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	private bool <hasLocationData>k__BackingField; // 0x1C
	[DebuggerBrowsableAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	[CompilerGeneratedAttribute] // RVA: 0x70770 Offset: 0x6FB70 VA: 0x180070770
	private CapturePixelFormat <pixelFormat>k__BackingField; // 0x20

	public int dataLength { get; set; }
	private bool hasLocationData { set; }
	private CapturePixelFormat pixelFormat { set; }


	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public int get_dataLength() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_dataLength(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_hasLocationData(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private void set_pixelFormat(CapturePixelFormat value) { }

	[ThreadAndSerializationSafeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int GetDataLength() { }

	[ThreadAndSerializationSafeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool GetHasLocationData() { }

	[ThreadAndSerializationSafeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private CapturePixelFormat GetCapturePixelFormat() { }

	internal void .ctor(IntPtr nativePtr) { }

	private void Cleanup() { }

	[NativeConditionalAttribute] // RVA: 0xDC030 Offset: 0xDB430 VA: 0x1800DC030
	[ThreadAndSerializationSafeAttribute] // RVA: 0xDC030 Offset: 0xDB430 VA: 0x1800DC030
	[NativeNameAttribute] // RVA: 0xDC030 Offset: 0xDB430 VA: 0x1800DC030
	private void Dispose_Internal() { }

	public void Dispose() { }

	protected override void Finalize() { }

}

