public class WaterGerstner // TypeDefIndex: 10615
{	public const int WaveCount = 6;


	public static void UpdatePrecomputedWaves(WaterGerstner.WaveParams[] waves, ref WaterGerstner.PrecomputedWave[] precomputed) { }

	public static void UpdatePrecomputedShoreWaves(WaterGerstner.ShoreWaveParams shoreWaves, ref WaterGerstner.PrecomputedShoreWaves precomputed) { }

	public static void UpdateWaveArray(WaterGerstner.PrecomputedWave[] precomputed, ref Vector4[] array) { }

	public static void UpdateShoreWaveArray(WaterGerstner.PrecomputedShoreWaves precomputed, ref Vector4[] array) { }

	private static void GerstnerWave(WaterGerstner.PrecomputedWave wave, Vector2 pos, Vector2 shoreVec, ref float outH) { }

	private static void GerstnerWave(WaterGerstner.PrecomputedWave wave, Vector2 pos, Vector2 shoreVec, ref Vector3 outP) { }

	private static void GerstnerShoreWave(WaterGerstner.PrecomputedShoreWaves wave, Vector2 waveDir, Vector2 pos, Vector2 shoreVec, float variation_t, ref float outH) { }

	private static void GerstnerShoreWave(WaterGerstner.PrecomputedShoreWaves wave, Vector2 waveDir, Vector2 pos, Vector2 shoreVec, float variation_t, ref Vector3 outP) { }

	public static Vector3 SampleDisplacement(WaterSystem instance, Vector3 location, Vector3 shore) { }

	private static float SampleHeightREF(WaterSystem instance, Vector3 location, Vector3 shore) { }

	private static void SampleHeightArrayREF(WaterSystem instance, Vector2[] location, Vector3[] shore, float[] height) { }

	public static float SampleHeight(WaterSystem instance, Vector3 location, Vector3 shore) { }

	public static void SampleHeightArray(WaterSystem instance, Vector2[] location, Vector3[] shore, float[] height) { }

	public void .ctor() { }

}

public class WaterGerstner.WaveParams // TypeDefIndex: 10616
{	[RangeAttribute] // RVA: 0x9F370 Offset: 0x9E770 VA: 0x18009F370
	public float Angle; // 0x10
	[RangeAttribute] // RVA: 0xE74C0 Offset: 0xE68C0 VA: 0x1800E74C0
	public float Steepness; // 0x14
	[RangeAttribute] // RVA: 0xE7520 Offset: 0xE6920 VA: 0x1800E7520
	public float Length; // 0x18
	[RangeAttribute] // RVA: 0xBF030 Offset: 0xBE430 VA: 0x1800BF030
	public float Speed; // 0x1C


	public void .ctor() { }

}

public class WaterGerstner.ShoreWaveParams // TypeDefIndex: 10617
{	[RangeAttribute] // RVA: 0x715C0 Offset: 0x709C0 VA: 0x1800715C0
	public float Steepness; // 0x10
	[RangeAttribute] // RVA: 0x717B0 Offset: 0x70BB0 VA: 0x1800717B0
	public float Amplitude; // 0x14
	[RangeAttribute] // RVA: 0xE7520 Offset: 0xE6920 VA: 0x1800E7520
	public float Length; // 0x18
	[RangeAttribute] // RVA: 0xBF030 Offset: 0xBE430 VA: 0x1800BF030
	public float Speed; // 0x1C
	public float[] DirectionAngles; // 0x20
	public float DirectionVarFreq; // 0x28
	public float DirectionVarAmp; // 0x2C


	public void .ctor() { }

}

public struct WaterGerstner.PrecomputedWave // TypeDefIndex: 10618
{	public float Angle; // 0x0
	public Vector2 Direction; // 0x4
	public float Steepness; // 0xC
	public float K; // 0x10
	public float C; // 0x14
	public float A; // 0x18
	public static WaterGerstner.PrecomputedWave Default; // 0x0


	private static void .cctor() { }

}

public struct WaterGerstner.PrecomputedShoreWaves // TypeDefIndex: 10619
{	public Vector2[] Directions; // 0x0
	public float Steepness; // 0x8
	public float Amplitude; // 0xC
	public float K; // 0x10
	public float C; // 0x14
	public float A; // 0x18
	public float DirectionVarFreq; // 0x1C
	public float DirectionVarAmp; // 0x20
	public static WaterGerstner.PrecomputedShoreWaves Default; // 0x0


	private static void .cctor() { }

}

