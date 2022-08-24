public class Time // TypeDefIndex: 3558
{	[NativePropertyAttribute] // RVA: 0xCDA80 Offset: 0xCCE80 VA: 0x1800CDA80
	public static float time { get; }
	public static float deltaTime { get; }
	public static float fixedTime { get; }
	public static float unscaledTime { get; }
	public static float unscaledDeltaTime { get; }
	public static float fixedDeltaTime { get; set; }
	public static float maximumDeltaTime { get; set; }
	public static float smoothDeltaTime { get; }
	public static float timeScale { get; set; }
	public static int frameCount { get; }
	[NativePropertyAttribute] // RVA: 0xCDBB0 Offset: 0xCCFB0 VA: 0x1800CDBB0
	public static int renderedFrameCount { get; }
	[NativePropertyAttribute] // RVA: 0xCDC90 Offset: 0xCD090 VA: 0x1800CDC90
	public static float realtimeSinceStartup { get; }


	public static float get_time() { }

	public static float get_deltaTime() { }

	public static float get_fixedTime() { }

	public static float get_unscaledTime() { }

	public static float get_unscaledDeltaTime() { }

	public static float get_fixedDeltaTime() { }

	public static void set_fixedDeltaTime(float value) { }

	public static float get_maximumDeltaTime() { }

	public static void set_maximumDeltaTime(float value) { }

	public static float get_smoothDeltaTime() { }

	public static float get_timeScale() { }

	public static void set_timeScale(float value) { }

	public static int get_frameCount() { }

	public static int get_renderedFrameCount() { }

	public static float get_realtimeSinceStartup() { }

}

public class Time : ConsoleSystem // TypeDefIndex: 11973
{
	public void .ctor() { }

}

