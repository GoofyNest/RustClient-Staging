public class Time // TypeDefIndex: 3558
{	// Properties
	[NativePropertyAttribute] // RVA: 0xCD960 Offset: 0xCCD60 VA: 0x1800CD960
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
	[NativePropertyAttribute] // RVA: 0xCD9F0 Offset: 0xCCDF0 VA: 0x1800CD9F0
	public static int renderedFrameCount { get; }
	[NativePropertyAttribute] // RVA: 0xCDB30 Offset: 0xCCF30 VA: 0x1800CDB30
	public static float realtimeSinceStartup { get; }

	// Methods

	// RVA: 0x217CB00 Offset: 0x217B100 VA: 0x18217CB00
	public static float get_time() { }

	// RVA: 0x217C950 Offset: 0x217AF50 VA: 0x18217C950
	public static float get_deltaTime() { }

	// RVA: 0x217C9B0 Offset: 0x217AFB0 VA: 0x18217C9B0
	public static float get_fixedTime() { }

	// RVA: 0x217CB60 Offset: 0x217B160 VA: 0x18217CB60
	public static float get_unscaledTime() { }

	// RVA: 0x217CB30 Offset: 0x217B130 VA: 0x18217CB30
	public static float get_unscaledDeltaTime() { }

	// RVA: 0x217C980 Offset: 0x217AF80 VA: 0x18217C980
	public static float get_fixedDeltaTime() { }

	// RVA: 0x217CB90 Offset: 0x217B190 VA: 0x18217CB90
	public static void set_fixedDeltaTime(float value) { }

	// RVA: 0x217CA10 Offset: 0x217B010 VA: 0x18217CA10
	public static float get_maximumDeltaTime() { }

	// RVA: 0x217CBD0 Offset: 0x217B1D0 VA: 0x18217CBD0
	public static void set_maximumDeltaTime(float value) { }

	// RVA: 0x217CAA0 Offset: 0x217B0A0 VA: 0x18217CAA0
	public static float get_smoothDeltaTime() { }

	// RVA: 0x217CAD0 Offset: 0x217B0D0 VA: 0x18217CAD0
	public static float get_timeScale() { }

	// RVA: 0x217CC10 Offset: 0x217B210 VA: 0x18217CC10
	public static void set_timeScale(float value) { }

	// RVA: 0x217C9E0 Offset: 0x217AFE0 VA: 0x18217C9E0
	public static int get_frameCount() { }

	// RVA: 0x217CA70 Offset: 0x217B070 VA: 0x18217CA70
	public static int get_renderedFrameCount() { }

	// RVA: 0x217CA40 Offset: 0x217B040 VA: 0x18217CA40
	public static float get_realtimeSinceStartup() { }

}

public class Time : ConsoleSystem // TypeDefIndex: 11969
{	// Methods

	// RVA: 0x36C030 Offset: 0x36A630 VA: 0x18036C030
	public void .ctor() { }

}

