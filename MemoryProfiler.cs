public sealed class MemoryProfiler // TypeDefIndex: 3584
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	[DebuggerBrowsableAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	private static Action<string, bool> m_SnapshotFinished; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	[DebuggerBrowsableAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	private static Action<string, bool, DebugScreenCapture> m_SaveScreenshotToDisk; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	[DebuggerBrowsableAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	private static Action<MetaData> createMetaData; // 0x10

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x18F33B0 Offset: 0x18F19B0 VA: 0x1818F33B0
	private static void add_m_SnapshotFinished(Action<string, bool> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x18F3510 Offset: 0x18F1B10 VA: 0x1818F3510
	private static void remove_m_SnapshotFinished(Action<string, bool> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x18F3300 Offset: 0x18F1900 VA: 0x1818F3300
	private static void add_m_SaveScreenshotToDisk(Action<string, bool, DebugScreenCapture> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x18F3460 Offset: 0x18F1A60 VA: 0x1818F3460
	private static void remove_m_SaveScreenshotToDisk(Action<string, bool, DebugScreenCapture> value) { }

	[NativeMethodAttribute] // RVA: 0xD74D0 Offset: 0xD68D0 VA: 0x1800D74D0
	[StaticAccessorAttribute] // RVA: 0xD74D0 Offset: 0xD68D0 VA: 0x1800D74D0
	[NativeConditionalAttribute] // RVA: 0xD74D0 Offset: 0xD68D0 VA: 0x1800D74D0
	// RVA: 0x18F2F10 Offset: 0x18F1510 VA: 0x1818F2F10
	private static void StartOperation(uint captureFlag, bool requestScreenshot, string path) { }

	// RVA: 0x18F2F70 Offset: 0x18F1570 VA: 0x1818F2F70
	public static void TakeSnapshot(string path, Action<string, bool> finishCallback, CaptureFlags captureFlags = 3) { }

	// RVA: 0x18F2F90 Offset: 0x18F1590 VA: 0x1818F2F90
	public static void TakeSnapshot(string path, Action<string, bool> finishCallback, Action<string, bool, DebugScreenCapture> screenshotCallback, CaptureFlags captureFlags = 3) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x18F2AC0 Offset: 0x18F10C0 VA: 0x1818F2AC0
	private static byte[] PrepareMetadata() { }

	// RVA: 0x18F31B0 Offset: 0x18F17B0 VA: 0x1818F31B0
	internal static int WriteIntToByteArray(byte[] array, int offset, int value) { }

	// RVA: 0x18F3260 Offset: 0x18F1860 VA: 0x1818F3260
	internal static int WriteStringToByteArray(byte[] array, int offset, string value) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x18F2A40 Offset: 0x18F1040 VA: 0x1818F2A40
	private static void FinalizeSnapshot(string path, bool result) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x18F2E00 Offset: 0x18F1400 VA: 0x1818F2E00
	private static void SaveScreenshotToDisk(string path, bool result, IntPtr pixelsPtr, int pixelsCount, TextureFormat format, int width, int height) { }

}

