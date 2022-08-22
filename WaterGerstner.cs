public class WaterGerstner // TypeDefIndex: 10611
{	// Fields
	public const int WaveCount = 6;

	// Methods

	// RVA: 0xC12770 Offset: 0xC10D70 VA: 0x180C12770
	public static void UpdatePrecomputedWaves(WaterGerstner.WaveParams[] waves, ref WaterGerstner.PrecomputedWave[] precomputed) { }

	// RVA: 0xC12490 Offset: 0xC10A90 VA: 0x180C12490
	public static void UpdatePrecomputedShoreWaves(WaterGerstner.ShoreWaveParams shoreWaves, ref WaterGerstner.PrecomputedShoreWaves precomputed) { }

	// RVA: 0xC12E40 Offset: 0xC11440 VA: 0x180C12E40
	public static void UpdateWaveArray(WaterGerstner.PrecomputedWave[] precomputed, ref Vector4[] array) { }

	// RVA: 0xC12B70 Offset: 0xC11170 VA: 0x180C12B70
	public static void UpdateShoreWaveArray(WaterGerstner.PrecomputedShoreWaves precomputed, ref Vector4[] array) { }

	// RVA: 0xC10EB0 Offset: 0xC0F4B0 VA: 0x180C10EB0
	private static void GerstnerWave(WaterGerstner.PrecomputedWave wave, Vector2 pos, Vector2 shoreVec, ref float outH) { }

	// RVA: 0xC10D60 Offset: 0xC0F360 VA: 0x180C10D60
	private static void GerstnerWave(WaterGerstner.PrecomputedWave wave, Vector2 pos, Vector2 shoreVec, ref Vector3 outP) { }

	// RVA: 0xC10C50 Offset: 0xC0F250 VA: 0x180C10C50
	private static void GerstnerShoreWave(WaterGerstner.PrecomputedShoreWaves wave, Vector2 waveDir, Vector2 pos, Vector2 shoreVec, float variation_t, ref float outH) { }

	// RVA: 0xC10AD0 Offset: 0xC0F0D0 VA: 0x180C10AD0
	private static void GerstnerShoreWave(WaterGerstner.PrecomputedShoreWaves wave, Vector2 waveDir, Vector2 pos, Vector2 shoreVec, float variation_t, ref Vector3 outP) { }

	// RVA: 0xC10F80 Offset: 0xC0F580 VA: 0x180C10F80
	public static Vector3 SampleDisplacement(WaterSystem instance, Vector3 location, Vector3 shore) { }

	// RVA: 0xC11C40 Offset: 0xC10240 VA: 0x180C11C40
	private static float SampleHeightREF(WaterSystem instance, Vector3 location, Vector3 shore) { }

	// RVA: 0xC11580 Offset: 0xC0FB80 VA: 0x180C11580
	private static void SampleHeightArrayREF(WaterSystem instance, Vector2[] location, Vector3[] shore, float[] height) { }

	// RVA: 0xC12090 Offset: 0xC10690 VA: 0x180C12090
	public static float SampleHeight(WaterSystem instance, Vector3 location, Vector3 shore) { }

	// RVA: 0xC11720 Offset: 0xC0FD20 VA: 0x180C11720
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

	// RVA: 0xC2C710 Offset: 0xC2AD10 VA: 0x180C2C710
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

	// RVA: 0xC10650 Offset: 0xC0EC50 VA: 0x180C10650
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

	// RVA: 0xC10560 Offset: 0xC0EB60 VA: 0x180C10560
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

	// RVA: 0xC10300 Offset: 0xC0E900 VA: 0x180C10300
	private static void .cctor() { }

}

