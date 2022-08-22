public static class ScreenCapture // TypeDefIndex: 4558
{
[NativeHeaderAttribute] // RVA: 0x78510 Offset: 0x77910 VA: 0x180078510
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

