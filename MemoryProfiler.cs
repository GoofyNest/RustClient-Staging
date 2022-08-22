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
	// RVA: 0x18F2D90 Offset: 0x18F1390 VA: 0x1818F2D90
	private static void add_m_SnapshotFinished(Action<string, bool> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x18F2EF0 Offset: 0x18F14F0 VA: 0x1818F2EF0
	private static void remove_m_SnapshotFinished(Action<string, bool> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x18F2CE0 Offset: 0x18F12E0 VA: 0x1818F2CE0
	private static void add_m_SaveScreenshotToDisk(Action<string, bool, DebugScreenCapture> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x18F2E40 Offset: 0x18F1440 VA: 0x1818F2E40
	private static void remove_m_SaveScreenshotToDisk(Action<string, bool, DebugScreenCapture> value) { }

	[NativeMethodAttribute] // RVA: 0xD74D0 Offset: 0xD68D0 VA: 0x1800D74D0
	[StaticAccessorAttribute] // RVA: 0xD74D0 Offset: 0xD68D0 VA: 0x1800D74D0
	[NativeConditionalAttribute] // RVA: 0xD74D0 Offset: 0xD68D0 VA: 0x1800D74D0
	// RVA: 0x18F28F0 Offset: 0x18F0EF0 VA: 0x1818F28F0
	private static void StartOperation(uint captureFlag, bool requestScreenshot, string path) { }

	// RVA: 0x18F2950 Offset: 0x18F0F50 VA: 0x1818F2950
	public static void TakeSnapshot(string path, Action<string, bool> finishCallback, CaptureFlags captureFlags = 3) { }

	// RVA: 0x18F2970 Offset: 0x18F0F70 VA: 0x1818F2970
	public static void TakeSnapshot(string path, Action<string, bool> finishCallback, Action<string, bool, DebugScreenCapture> screenshotCallback, CaptureFlags captureFlags = 3) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x18F24A0 Offset: 0x18F0AA0 VA: 0x1818F24A0
	private static byte[] PrepareMetadata() { }

	// RVA: 0x18F2B90 Offset: 0x18F1190 VA: 0x1818F2B90
	internal static int WriteIntToByteArray(byte[] array, int offset, int value) { }

	// RVA: 0x18F2C40 Offset: 0x18F1240 VA: 0x1818F2C40
	internal static int WriteStringToByteArray(byte[] array, int offset, string value) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x18F2420 Offset: 0x18F0A20 VA: 0x1818F2420
	private static void FinalizeSnapshot(string path, bool result) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x18F27E0 Offset: 0x18F0DE0 VA: 0x1818F27E0
	private static void SaveScreenshotToDisk(string path, bool result, IntPtr pixelsPtr, int pixelsCount, TextureFormat format, int width, int height) { }

}

