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
	// RVA: 0x18F3670 Offset: 0x18F1C70 VA: 0x1818F3670
	private static void add_m_SnapshotFinished(Action<string, bool> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x18F37D0 Offset: 0x18F1DD0 VA: 0x1818F37D0
	private static void remove_m_SnapshotFinished(Action<string, bool> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x18F35C0 Offset: 0x18F1BC0 VA: 0x1818F35C0
	private static void add_m_SaveScreenshotToDisk(Action<string, bool, DebugScreenCapture> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x18F3720 Offset: 0x18F1D20 VA: 0x1818F3720
	private static void remove_m_SaveScreenshotToDisk(Action<string, bool, DebugScreenCapture> value) { }

	[NativeMethodAttribute] // RVA: 0xD74D0 Offset: 0xD68D0 VA: 0x1800D74D0
	[StaticAccessorAttribute] // RVA: 0xD74D0 Offset: 0xD68D0 VA: 0x1800D74D0
	[NativeConditionalAttribute] // RVA: 0xD74D0 Offset: 0xD68D0 VA: 0x1800D74D0
	// RVA: 0x18F31D0 Offset: 0x18F17D0 VA: 0x1818F31D0
	private static void StartOperation(uint captureFlag, bool requestScreenshot, string path) { }

	// RVA: 0x18F3230 Offset: 0x18F1830 VA: 0x1818F3230
	public static void TakeSnapshot(string path, Action<string, bool> finishCallback, CaptureFlags captureFlags = 3) { }

	// RVA: 0x18F3250 Offset: 0x18F1850 VA: 0x1818F3250
	public static void TakeSnapshot(string path, Action<string, bool> finishCallback, Action<string, bool, DebugScreenCapture> screenshotCallback, CaptureFlags captureFlags = 3) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x18F2D80 Offset: 0x18F1380 VA: 0x1818F2D80
	private static byte[] PrepareMetadata() { }

	// RVA: 0x18F3470 Offset: 0x18F1A70 VA: 0x1818F3470
	internal static int WriteIntToByteArray(byte[] array, int offset, int value) { }

	// RVA: 0x18F3520 Offset: 0x18F1B20 VA: 0x1818F3520
	internal static int WriteStringToByteArray(byte[] array, int offset, string value) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x18F2D00 Offset: 0x18F1300 VA: 0x1818F2D00
	private static void FinalizeSnapshot(string path, bool result) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x18F30C0 Offset: 0x18F16C0 VA: 0x1818F30C0
	private static void SaveScreenshotToDisk(string path, bool result, IntPtr pixelsPtr, int pixelsCount, TextureFormat format, int width, int height) { }

}

