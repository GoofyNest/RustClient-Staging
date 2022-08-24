public class Time // TypeDefIndex: 3558
{	[NativePropertyAttribute] // RVA: 0xCDB80 Offset: 0xCCF80 VA: 0x1800CDB80
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
	[NativePropertyAttribute] // RVA: 0xCDCA0 Offset: 0xCD0A0 VA: 0x1800CDCA0
	public static int renderedFrameCount { get; }
	[NativePropertyAttribute] // RVA: 0xCDD70 Offset: 0xCD170 VA: 0x1800CDD70
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

