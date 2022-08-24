public sealed class MemoryProfiler // TypeDefIndex: 3584
{	[CompilerGeneratedAttribute] // RVA: 0x70950 Offset: 0x6FD50 VA: 0x180070950
	[DebuggerBrowsableAttribute] // RVA: 0x70950 Offset: 0x6FD50 VA: 0x180070950
	private static Action<string, bool> m_SnapshotFinished; // 0x0
	[DebuggerBrowsableAttribute] // RVA: 0x70830 Offset: 0x6FC30 VA: 0x180070830
	[CompilerGeneratedAttribute] // RVA: 0x70830 Offset: 0x6FC30 VA: 0x180070830
	private static Action<string, bool, DebugScreenCapture> m_SaveScreenshotToDisk; // 0x8
	[DebuggerBrowsableAttribute] // RVA: 0x70830 Offset: 0x6FC30 VA: 0x180070830
	[CompilerGeneratedAttribute] // RVA: 0x70830 Offset: 0x6FC30 VA: 0x180070830
	private static Action<MetaData> createMetaData; // 0x10


	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private static void add_m_SnapshotFinished(Action<string, bool> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private static void remove_m_SnapshotFinished(Action<string, bool> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private static void add_m_SaveScreenshotToDisk(Action<string, bool, DebugScreenCapture> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private static void remove_m_SaveScreenshotToDisk(Action<string, bool, DebugScreenCapture> value) { }

	[StaticAccessorAttribute] // RVA: 0xD7600 Offset: 0xD6A00 VA: 0x1800D7600
	[NativeConditionalAttribute] // RVA: 0xD7600 Offset: 0xD6A00 VA: 0x1800D7600
	[NativeMethodAttribute] // RVA: 0xD7600 Offset: 0xD6A00 VA: 0x1800D7600
	private static void StartOperation(uint captureFlag, bool requestScreenshot, string path) { }

	public static void TakeSnapshot(string path, Action<string, bool> finishCallback, CaptureFlags captureFlags = 3) { }

	public static void TakeSnapshot(string path, Action<string, bool> finishCallback, Action<string, bool, DebugScreenCapture> screenshotCallback, CaptureFlags captureFlags = 3) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private static byte[] PrepareMetadata() { }

	internal static int WriteIntToByteArray(byte[] array, int offset, int value) { }

	internal static int WriteStringToByteArray(byte[] array, int offset, string value) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private static void FinalizeSnapshot(string path, bool result) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private static void SaveScreenshotToDisk(string path, bool result, IntPtr pixelsPtr, int pixelsCount, TextureFormat format, int width, int height) { }

}

