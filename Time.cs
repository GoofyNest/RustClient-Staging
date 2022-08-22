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

	// RVA: 0x217C940 Offset: 0x217AF40 VA: 0x18217C940
	public static float get_time() { }

	// RVA: 0x217C790 Offset: 0x217AD90 VA: 0x18217C790
	public static float get_deltaTime() { }

	// RVA: 0x217C7F0 Offset: 0x217ADF0 VA: 0x18217C7F0
	public static float get_fixedTime() { }

	// RVA: 0x217C9A0 Offset: 0x217AFA0 VA: 0x18217C9A0
	public static float get_unscaledTime() { }

	// RVA: 0x217C970 Offset: 0x217AF70 VA: 0x18217C970
	public static float get_unscaledDeltaTime() { }

	// RVA: 0x217C7C0 Offset: 0x217ADC0 VA: 0x18217C7C0
	public static float get_fixedDeltaTime() { }

	// RVA: 0x217C9D0 Offset: 0x217AFD0 VA: 0x18217C9D0
	public static void set_fixedDeltaTime(float value) { }

	// RVA: 0x217C850 Offset: 0x217AE50 VA: 0x18217C850
	public static float get_maximumDeltaTime() { }

	// RVA: 0x217CA10 Offset: 0x217B010 VA: 0x18217CA10
	public static void set_maximumDeltaTime(float value) { }

	// RVA: 0x217C8E0 Offset: 0x217AEE0 VA: 0x18217C8E0
	public static float get_smoothDeltaTime() { }

	// RVA: 0x217C910 Offset: 0x217AF10 VA: 0x18217C910
	public static float get_timeScale() { }

	// RVA: 0x217CA50 Offset: 0x217B050 VA: 0x18217CA50
	public static void set_timeScale(float value) { }

	// RVA: 0x217C820 Offset: 0x217AE20 VA: 0x18217C820
	public static int get_frameCount() { }

	// RVA: 0x217C8B0 Offset: 0x217AEB0 VA: 0x18217C8B0
	public static int get_renderedFrameCount() { }

	// RVA: 0x217C880 Offset: 0x217AE80 VA: 0x18217C880
	public static float get_realtimeSinceStartup() { }

}

public class Time : ConsoleSystem // TypeDefIndex: 11969
{	// Methods

	// RVA: 0x36C030 Offset: 0x36A630 VA: 0x18036C030
	public void .ctor() { }

}

