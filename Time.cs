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

	// RVA: 0x217CC00 Offset: 0x217B200 VA: 0x18217CC00
	public static float get_time() { }

	// RVA: 0x217CA50 Offset: 0x217B050 VA: 0x18217CA50
	public static float get_deltaTime() { }

	// RVA: 0x217CAB0 Offset: 0x217B0B0 VA: 0x18217CAB0
	public static float get_fixedTime() { }

	// RVA: 0x217CC60 Offset: 0x217B260 VA: 0x18217CC60
	public static float get_unscaledTime() { }

	// RVA: 0x217CC30 Offset: 0x217B230 VA: 0x18217CC30
	public static float get_unscaledDeltaTime() { }

	// RVA: 0x217CA80 Offset: 0x217B080 VA: 0x18217CA80
	public static float get_fixedDeltaTime() { }

	// RVA: 0x217CC90 Offset: 0x217B290 VA: 0x18217CC90
	public static void set_fixedDeltaTime(float value) { }

	// RVA: 0x217CB10 Offset: 0x217B110 VA: 0x18217CB10
	public static float get_maximumDeltaTime() { }

	// RVA: 0x217CCD0 Offset: 0x217B2D0 VA: 0x18217CCD0
	public static void set_maximumDeltaTime(float value) { }

	// RVA: 0x217CBA0 Offset: 0x217B1A0 VA: 0x18217CBA0
	public static float get_smoothDeltaTime() { }

	// RVA: 0x217CBD0 Offset: 0x217B1D0 VA: 0x18217CBD0
	public static float get_timeScale() { }

	// RVA: 0x217CD10 Offset: 0x217B310 VA: 0x18217CD10
	public static void set_timeScale(float value) { }

	// RVA: 0x217CAE0 Offset: 0x217B0E0 VA: 0x18217CAE0
	public static int get_frameCount() { }

	// RVA: 0x217CB70 Offset: 0x217B170 VA: 0x18217CB70
	public static int get_renderedFrameCount() { }

	// RVA: 0x217CB40 Offset: 0x217B140 VA: 0x18217CB40
	public static float get_realtimeSinceStartup() { }

}

public class Time : ConsoleSystem // TypeDefIndex: 11969
{	// Methods

	// RVA: 0x36C030 Offset: 0x36A630 VA: 0x18036C030
	public void .ctor() { }

}

