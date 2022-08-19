public static class ScreenCapture // TypeDefIndex: 4558
{
// Namespace: UnityEngine
[NativeHeaderAttribute] // RVA: 0x78410 Offset: 0x77810 VA: 0x180078410
public static class ScreenCapture // TypeDefIndex: 4558
	// Methods

	// RVA: 0x23232D0 Offset: 0x23218D0 VA: 0x1823232D0
	public static void CaptureScreenshot(string filename, int superSize) { }

	// RVA: 0x2323320 Offset: 0x2321920 VA: 0x182323320
	private static void CaptureScreenshot(string filename, int superSize, ScreenCapture.StereoScreenCaptureMode CaptureMode) { }

}

public enum ScreenCapture.StereoScreenCaptureMode // TypeDefIndex: 4559
{	// Fields
	public int value__; // 0x0
	public const ScreenCapture.StereoScreenCaptureMode LeftEye = 1;
	public const ScreenCapture.StereoScreenCaptureMode RightEye = 2;
	public const ScreenCapture.StereoScreenCaptureMode BothEyes = 3;

}

