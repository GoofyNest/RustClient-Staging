public static class ScreenCapture // TypeDefIndex: 4558
{
// Namespace: UnityEngine
[NativeHeaderAttribute] // RVA: 0x78510 Offset: 0x77910 VA: 0x180078510
public static class ScreenCapture // TypeDefIndex: 4558
	// Methods

	// RVA: 0x2323BF0 Offset: 0x23221F0 VA: 0x182323BF0
	public static void CaptureScreenshot(string filename, int superSize) { }

	// RVA: 0x2323C40 Offset: 0x2322240 VA: 0x182323C40
	private static void CaptureScreenshot(string filename, int superSize, ScreenCapture.StereoScreenCaptureMode CaptureMode) { }

}

public enum ScreenCapture.StereoScreenCaptureMode // TypeDefIndex: 4559
{	// Fields
	public int value__; // 0x0
	public const ScreenCapture.StereoScreenCaptureMode LeftEye = 1;
	public const ScreenCapture.StereoScreenCaptureMode RightEye = 2;
	public const ScreenCapture.StereoScreenCaptureMode BothEyes = 3;

}

