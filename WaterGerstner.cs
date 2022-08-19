public class WaterGerstner // TypeDefIndex: 10611
{	// Fields
	public const int WaveCount = 6;

	// Methods

	// RVA: 0xC11FE0 Offset: 0xC105E0 VA: 0x180C11FE0
	public static void UpdatePrecomputedWaves(WaterGerstner.WaveParams[] waves, ref WaterGerstner.PrecomputedWave[] precomputed) { }

	// RVA: 0xC11D00 Offset: 0xC10300 VA: 0x180C11D00
	public static void UpdatePrecomputedShoreWaves(WaterGerstner.ShoreWaveParams shoreWaves, ref WaterGerstner.PrecomputedShoreWaves precomputed) { }

	// RVA: 0xC126B0 Offset: 0xC10CB0 VA: 0x180C126B0
	public static void UpdateWaveArray(WaterGerstner.PrecomputedWave[] precomputed, ref Vector4[] array) { }

	// RVA: 0xC123E0 Offset: 0xC109E0 VA: 0x180C123E0
	public static void UpdateShoreWaveArray(WaterGerstner.PrecomputedShoreWaves precomputed, ref Vector4[] array) { }

	// RVA: 0xC10720 Offset: 0xC0ED20 VA: 0x180C10720
	private static void GerstnerWave(WaterGerstner.PrecomputedWave wave, Vector2 pos, Vector2 shoreVec, ref float outH) { }

	// RVA: 0xC105D0 Offset: 0xC0EBD0 VA: 0x180C105D0
	private static void GerstnerWave(WaterGerstner.PrecomputedWave wave, Vector2 pos, Vector2 shoreVec, ref Vector3 outP) { }

	// RVA: 0xC104C0 Offset: 0xC0EAC0 VA: 0x180C104C0
	private static void GerstnerShoreWave(WaterGerstner.PrecomputedShoreWaves wave, Vector2 waveDir, Vector2 pos, Vector2 shoreVec, float variation_t, ref float outH) { }

	// RVA: 0xC10340 Offset: 0xC0E940 VA: 0x180C10340
	private static void GerstnerShoreWave(WaterGerstner.PrecomputedShoreWaves wave, Vector2 waveDir, Vector2 pos, Vector2 shoreVec, float variation_t, ref Vector3 outP) { }

	// RVA: 0xC107F0 Offset: 0xC0EDF0 VA: 0x180C107F0
	public static Vector3 SampleDisplacement(WaterSystem instance, Vector3 location, Vector3 shore) { }

	// RVA: 0xC114B0 Offset: 0xC0FAB0 VA: 0x180C114B0
	private static float SampleHeightREF(WaterSystem instance, Vector3 location, Vector3 shore) { }

	// RVA: 0xC10DF0 Offset: 0xC0F3F0 VA: 0x180C10DF0
	private static void SampleHeightArrayREF(WaterSystem instance, Vector2[] location, Vector3[] shore, float[] height) { }

	// RVA: 0xC11900 Offset: 0xC0FF00 VA: 0x180C11900
	public static float SampleHeight(WaterSystem instance, Vector3 location, Vector3 shore) { }

	// RVA: 0xC10F90 Offset: 0xC0F590 VA: 0x180C10F90
	public static void SampleHeightArray(WaterSystem instance, Vector2[] location, Vector3[] shore, float[] height) { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

public class WaterGerstner.WaveParams // TypeDefIndex: 10612
{	// Fields
	[RangeAttribute] // RVA: 0x9F130 Offset: 0x9E530 VA: 0x18009F130
	public float Angle; // 0x10
	[RangeAttribute] // RVA: 0xE7090 Offset: 0xE6490 VA: 0x1800E7090
	public float Steepness; // 0x14
	[RangeAttribute] // RVA: 0xE7210 Offset: 0xE6610 VA: 0x1800E7210
	public float Length; // 0x18
	[RangeAttribute] // RVA: 0xBED60 Offset: 0xBE160 VA: 0x1800BED60
	public float Speed; // 0x1C

	// Methods

	// RVA: 0xC2BF80 Offset: 0xC2A580 VA: 0x180C2BF80
	public void .ctor() { }

}

public class WaterGerstner.ShoreWaveParams // TypeDefIndex: 10613
{	// Fields
	[RangeAttribute] // RVA: 0x711F0 Offset: 0x705F0 VA: 0x1800711F0
	public float Steepness; // 0x10
	[RangeAttribute] // RVA: 0x71300 Offset: 0x70700 VA: 0x180071300
	public float Amplitude; // 0x14
	[RangeAttribute] // RVA: 0xE7210 Offset: 0xE6610 VA: 0x1800E7210
	public float Length; // 0x18
	[RangeAttribute] // RVA: 0xBED60 Offset: 0xBE160 VA: 0x1800BED60
	public float Speed; // 0x1C
	public float[] DirectionAngles; // 0x20
	public float DirectionVarFreq; // 0x28
	public float DirectionVarAmp; // 0x2C

	// Methods

	// RVA: 0xC0FEC0 Offset: 0xC0E4C0 VA: 0x180C0FEC0
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

	// RVA: 0xC0FDD0 Offset: 0xC0E3D0 VA: 0x180C0FDD0
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

	// RVA: 0xC0FB70 Offset: 0xC0E170 VA: 0x180C0FB70
	private static void .cctor() { }

}

