public class Time // TypeDefIndex: 3558
{	// Properties
	[NativePropertyAttribute] // RVA: 0xCD9A0 Offset: 0xCCDA0 VA: 0x1800CD9A0
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
	[NativePropertyAttribute] // RVA: 0xCDAD0 Offset: 0xCCED0 VA: 0x1800CDAD0
	public static int renderedFrameCount { get; }
	[NativePropertyAttribute] // RVA: 0xCDBC0 Offset: 0xCCFC0 VA: 0x1800CDBC0
	public static float realtimeSinceStartup { get; }

	// Methods

	// RVA: 0x217D420 Offset: 0x217BA20 VA: 0x18217D420
	public static float get_time() { }

	// RVA: 0x217D270 Offset: 0x217B870 VA: 0x18217D270
	public static float get_deltaTime() { }

	// RVA: 0x217D2D0 Offset: 0x217B8D0 VA: 0x18217D2D0
	public static float get_fixedTime() { }

	// RVA: 0x217D480 Offset: 0x217BA80 VA: 0x18217D480
	public static float get_unscaledTime() { }

	// RVA: 0x217D450 Offset: 0x217BA50 VA: 0x18217D450
	public static float get_unscaledDeltaTime() { }

	// RVA: 0x217D2A0 Offset: 0x217B8A0 VA: 0x18217D2A0
	public static float get_fixedDeltaTime() { }

	// RVA: 0x217D4B0 Offset: 0x217BAB0 VA: 0x18217D4B0
	public static void set_fixedDeltaTime(float value) { }

	// RVA: 0x217D330 Offset: 0x217B930 VA: 0x18217D330
	public static float get_maximumDeltaTime() { }

	// RVA: 0x217D4F0 Offset: 0x217BAF0 VA: 0x18217D4F0
	public static void set_maximumDeltaTime(float value) { }

	// RVA: 0x217D3C0 Offset: 0x217B9C0 VA: 0x18217D3C0
	public static float get_smoothDeltaTime() { }

	// RVA: 0x217D3F0 Offset: 0x217B9F0 VA: 0x18217D3F0
	public static float get_timeScale() { }

	// RVA: 0x217D530 Offset: 0x217BB30 VA: 0x18217D530
	public static void set_timeScale(float value) { }

	// RVA: 0x217D300 Offset: 0x217B900 VA: 0x18217D300
	public static int get_frameCount() { }

	// RVA: 0x217D390 Offset: 0x217B990 VA: 0x18217D390
	public static int get_renderedFrameCount() { }

	// RVA: 0x217D360 Offset: 0x217B960 VA: 0x18217D360
	public static float get_realtimeSinceStartup() { }

}

public class Time : ConsoleSystem // TypeDefIndex: 11969
{	// Methods

	// RVA: 0x36C030 Offset: 0x36A630 VA: 0x18036C030
	public void .ctor() { }

}

