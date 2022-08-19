public sealed class MemoryProfiler // TypeDefIndex: 3584
{	// Fields
	[DebuggerBrowsableAttribute] // RVA: 0x70760 Offset: 0x6FB60 VA: 0x180070760
	[CompilerGeneratedAttribute] // RVA: 0x70760 Offset: 0x6FB60 VA: 0x180070760
	private static Action<string, bool> m_SnapshotFinished; // 0x0
	[DebuggerBrowsableAttribute] // RVA: 0x70760 Offset: 0x6FB60 VA: 0x180070760
	[CompilerGeneratedAttribute] // RVA: 0x70760 Offset: 0x6FB60 VA: 0x180070760
	private static Action<string, bool, DebugScreenCapture> m_SaveScreenshotToDisk; // 0x8
	[CompilerGeneratedAttribute] // RVA: 0x708D0 Offset: 0x6FCD0 VA: 0x1800708D0
	[DebuggerBrowsableAttribute] // RVA: 0x708D0 Offset: 0x6FCD0 VA: 0x1800708D0
	private static Action<MetaData> createMetaData; // 0x10

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x18F33F0 Offset: 0x18F19F0 VA: 0x1818F33F0
	private static void add_m_SnapshotFinished(Action<string, bool> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x18F3550 Offset: 0x18F1B50 VA: 0x1818F3550
	private static void remove_m_SnapshotFinished(Action<string, bool> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x18F3340 Offset: 0x18F1940 VA: 0x1818F3340
	private static void add_m_SaveScreenshotToDisk(Action<string, bool, DebugScreenCapture> value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x18F34A0 Offset: 0x18F1AA0 VA: 0x1818F34A0
	private static void remove_m_SaveScreenshotToDisk(Action<string, bool, DebugScreenCapture> value) { }

	[StaticAccessorAttribute] // RVA: 0xD7460 Offset: 0xD6860 VA: 0x1800D7460
	[NativeMethodAttribute] // RVA: 0xD7460 Offset: 0xD6860 VA: 0x1800D7460
	[NativeConditionalAttribute] // RVA: 0xD7460 Offset: 0xD6860 VA: 0x1800D7460
	// RVA: 0x18F2F50 Offset: 0x18F1550 VA: 0x1818F2F50
	private static void StartOperation(uint captureFlag, bool requestScreenshot, string path) { }

	// RVA: 0x18F2FB0 Offset: 0x18F15B0 VA: 0x1818F2FB0
	public static void TakeSnapshot(string path, Action<string, bool> finishCallback, CaptureFlags captureFlags = 3) { }

	// RVA: 0x18F2FD0 Offset: 0x18F15D0 VA: 0x1818F2FD0
	public static void TakeSnapshot(string path, Action<string, bool> finishCallback, Action<string, bool, DebugScreenCapture> screenshotCallback, CaptureFlags captureFlags = 3) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x18F2B00 Offset: 0x18F1100 VA: 0x1818F2B00
	private static byte[] PrepareMetadata() { }

	// RVA: 0x18F31F0 Offset: 0x18F17F0 VA: 0x1818F31F0
	internal static int WriteIntToByteArray(byte[] array, int offset, int value) { }

	// RVA: 0x18F32A0 Offset: 0x18F18A0 VA: 0x1818F32A0
	internal static int WriteStringToByteArray(byte[] array, int offset, string value) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x18F2A80 Offset: 0x18F1080 VA: 0x1818F2A80
	private static void FinalizeSnapshot(string path, bool result) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x18F2E40 Offset: 0x18F1440 VA: 0x1818F2E40
	private static void SaveScreenshotToDisk(string path, bool result, IntPtr pixelsPtr, int pixelsCount, TextureFormat format, int width, int height) { }

}

