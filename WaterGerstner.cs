public class WaterGerstner // TypeDefIndex: 10611
{	// Fields
	public const int WaveCount = 6;

	// Methods

	// RVA: 0xC122A0 Offset: 0xC108A0 VA: 0x180C122A0
	public static void UpdatePrecomputedWaves(WaterGerstner.WaveParams[] waves, ref WaterGerstner.PrecomputedWave[] precomputed) { }

	// RVA: 0xC11FC0 Offset: 0xC105C0 VA: 0x180C11FC0
	public static void UpdatePrecomputedShoreWaves(WaterGerstner.ShoreWaveParams shoreWaves, ref WaterGerstner.PrecomputedShoreWaves precomputed) { }

	// RVA: 0xC12970 Offset: 0xC10F70 VA: 0x180C12970
	public static void UpdateWaveArray(WaterGerstner.PrecomputedWave[] precomputed, ref Vector4[] array) { }

	// RVA: 0xC126A0 Offset: 0xC10CA0 VA: 0x180C126A0
	public static void UpdateShoreWaveArray(WaterGerstner.PrecomputedShoreWaves precomputed, ref Vector4[] array) { }

	// RVA: 0xC109E0 Offset: 0xC0EFE0 VA: 0x180C109E0
	private static void GerstnerWave(WaterGerstner.PrecomputedWave wave, Vector2 pos, Vector2 shoreVec, ref float outH) { }

	// RVA: 0xC10890 Offset: 0xC0EE90 VA: 0x180C10890
	private static void GerstnerWave(WaterGerstner.PrecomputedWave wave, Vector2 pos, Vector2 shoreVec, ref Vector3 outP) { }

	// RVA: 0xC10780 Offset: 0xC0ED80 VA: 0x180C10780
	private static void GerstnerShoreWave(WaterGerstner.PrecomputedShoreWaves wave, Vector2 waveDir, Vector2 pos, Vector2 shoreVec, float variation_t, ref float outH) { }

	// RVA: 0xC10600 Offset: 0xC0EC00 VA: 0x180C10600
	private static void GerstnerShoreWave(WaterGerstner.PrecomputedShoreWaves wave, Vector2 waveDir, Vector2 pos, Vector2 shoreVec, float variation_t, ref Vector3 outP) { }

	// RVA: 0xC10AB0 Offset: 0xC0F0B0 VA: 0x180C10AB0
	public static Vector3 SampleDisplacement(WaterSystem instance, Vector3 location, Vector3 shore) { }

	// RVA: 0xC11770 Offset: 0xC0FD70 VA: 0x180C11770
	private static float SampleHeightREF(WaterSystem instance, Vector3 location, Vector3 shore) { }

	// RVA: 0xC110B0 Offset: 0xC0F6B0 VA: 0x180C110B0
	private static void SampleHeightArrayREF(WaterSystem instance, Vector2[] location, Vector3[] shore, float[] height) { }

	// RVA: 0xC11BC0 Offset: 0xC101C0 VA: 0x180C11BC0
	public static float SampleHeight(WaterSystem instance, Vector3 location, Vector3 shore) { }

	// RVA: 0xC11250 Offset: 0xC0F850 VA: 0x180C11250
	public static void SampleHeightArray(WaterSystem instance, Vector2[] location, Vector3[] shore, float[] height) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public class WaterGerstner.WaveParams // TypeDefIndex: 10612
{	// Fields
	[RangeAttribute] // RVA: 0x9F1C0 Offset: 0x9E5C0 VA: 0x18009F1C0
	public float Angle; // 0x10
	[RangeAttribute] // RVA: 0xE7130 Offset: 0xE6530 VA: 0x1800E7130
	public float Steepness; // 0x14
	[RangeAttribute] // RVA: 0xE7370 Offset: 0xE6770 VA: 0x1800E7370
	public float Length; // 0x18
	[RangeAttribute] // RVA: 0xBEED0 Offset: 0xBE2D0 VA: 0x1800BEED0
	public float Speed; // 0x1C

	// Methods

	// RVA: 0xC2C240 Offset: 0xC2A840 VA: 0x180C2C240
	public void .ctor() { }

}

public class WaterGerstner.ShoreWaveParams // TypeDefIndex: 10613
{	// Fields
	[RangeAttribute] // RVA: 0x71350 Offset: 0x70750 VA: 0x180071350
	public float Steepness; // 0x10
	[RangeAttribute] // RVA: 0x714C0 Offset: 0x708C0 VA: 0x1800714C0
	public float Amplitude; // 0x14
	[RangeAttribute] // RVA: 0xE7370 Offset: 0xE6770 VA: 0x1800E7370
	public float Length; // 0x18
	[RangeAttribute] // RVA: 0xBEED0 Offset: 0xBE2D0 VA: 0x1800BEED0
	public float Speed; // 0x1C
	public float[] DirectionAngles; // 0x20
	public float DirectionVarFreq; // 0x28
	public float DirectionVarAmp; // 0x2C

	// Methods

	// RVA: 0xC10180 Offset: 0xC0E780 VA: 0x180C10180
	public void .ctor() { }

}

public struct WaterGerstner.PrecomputedWave // TypeDefIndex: 10614
{	// Fields
	public float Angle; // 0x0
	public Vector2 Direction; // 0x4
	public float Steepness; // 0xC
	public float K; // 0x10
	public float C; // 0x14
	public float A; // 0x18
	public static WaterGerstner.PrecomputedWave Default; // 0x0

	// Methods

	// RVA: 0xC10090 Offset: 0xC0E690 VA: 0x180C10090
	private static void .cctor() { }

}

public struct WaterGerstner.PrecomputedShoreWaves // TypeDefIndex: 10615
{	// Fields
	public Vector2[] Directions; // 0x0
	public float Steepness; // 0x8
	public float Amplitude; // 0xC
	public float K; // 0x10
	public float C; // 0x14
	public float A; // 0x18
	public float DirectionVarFreq; // 0x1C
	public float DirectionVarAmp; // 0x20
	public static WaterGerstner.PrecomputedShoreWaves Default; // 0x0

	// Methods

	// RVA: 0xC0FE30 Offset: 0xC0E430 VA: 0x180C0FE30
	private static void .cctor() { }

}

