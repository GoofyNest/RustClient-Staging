public sealed class MemoryProfiler // TypeDefIndex: 3584
{	[CompilerGeneratedAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	[DebuggerBrowsableAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	private static Action<string, bool> m_SnapshotFinished; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	[DebuggerBrowsableAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	private static Action<string, bool, DebugScreenCapture> m_SaveScreenshotToDisk; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	[DebuggerBrowsableAttribute] // RVA: 0x70860 Offset: 0x6FC60 VA: 0x180070860
	private static Action<MetaData> createMetaData; // 0x10


	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static void add_m_SnapshotFinished(Action<string, bool> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static void remove_m_SnapshotFinished(Action<string, bool> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static void add_m_SaveScreenshotToDisk(Action<string, bool, DebugScreenCapture> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static void remove_m_SaveScreenshotToDisk(Action<string, bool, DebugScreenCapture> value) { }

	[NativeMethodAttribute] // RVA: 0xD74D0 Offset: 0xD68D0 VA: 0x1800D74D0
	[StaticAccessorAttribute] // RVA: 0xD74D0 Offset: 0xD68D0 VA: 0x1800D74D0
	[NativeConditionalAttribute] // RVA: 0xD74D0 Offset: 0xD68D0 VA: 0x1800D74D0
	private static void StartOperation(uint captureFlag, bool requestScreenshot, string path) { }

	public static void TakeSnapshot(string path, Action<string, bool> finishCallback, CaptureFlags captureFlags = 3) { }

	public static void TakeSnapshot(string path, Action<string, bool> finishCallback, Action<string, bool, DebugScreenCapture> screenshotCallback, CaptureFlags captureFlags = 3) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static byte[] PrepareMetadata() { }

	internal static int WriteIntToByteArray(byte[] array, int offset, int value) { }

	internal static int WriteStringToByteArray(byte[] array, int offset, string value) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static void FinalizeSnapshot(string path, bool result) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static void SaveScreenshotToDisk(string path, bool result, IntPtr pixelsPtr, int pixelsCount, TextureFormat format, int width, int height) { }

}

