public static class ScreenCapture // TypeDefIndex: 4558
{
[NativeHeaderAttribute] // RVA: 0x785E0 Offset: 0x779E0 VA: 0x1800785E0
public static class ScreenCapture // TypeDefIndex: 4558

	public static void CaptureScreenshot(string filename, int superSize) { }

	private static void CaptureScreenshot(string filename, int superSize, ScreenCapture.StereoScreenCaptureMode CaptureMode) { }

}

public enum ScreenCapture.StereoScreenCaptureMode // TypeDefIndex: 4559
{	public int value__; // 0x0
	public const ScreenCapture.StereoScreenCaptureMode LeftEye = 1;
	public const ScreenCapture.StereoScreenCaptureMode RightEye = 2;
	public const ScreenCapture.StereoScreenCaptureMode BothEyes = 3;

}

