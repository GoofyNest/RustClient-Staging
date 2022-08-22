public static class NativeNoise // TypeDefIndex: 10289
{	// Methods

	// RVA: 0x7E8590 Offset: 0x7E6B90 VA: 0x1807E8590
	public static extern float Simplex1D(float x) { }

	// RVA: 0x7E8500 Offset: 0x7E6B00 VA: 0x1807E8500
	public static extern float Simplex1D(float x, out float dx) { }

	// RVA: 0x7E8610 Offset: 0x7E6C10 VA: 0x1807E8610
	public static extern float Simplex2D(float x, float y) { }

	// RVA: 0x7E86A0 Offset: 0x7E6CA0 VA: 0x1807E86A0
	public static extern float Simplex2D(float x, float y, out float dx, out float dy) { }

	// RVA: 0x7E8930 Offset: 0x7E6F30 VA: 0x1807E8930
	public static extern float Turbulence(float x, float y, int octaves, float frequency, float amplitude, float lacunarity, float gain) { }

	// RVA: 0x7E7D60 Offset: 0x7E6360 VA: 0x1807E7D60
	public static extern float Billow(float x, float y, int octaves, float frequency, float amplitude, float lacunarity, float gain) { }

	// RVA: 0x7E8140 Offset: 0x7E6740 VA: 0x1807E8140
	public static extern float Ridge(float x, float y, int octaves, float frequency, float amplitude, float lacunarity, float gain) { }

	// RVA: 0x7E8410 Offset: 0x7E6A10 VA: 0x1807E8410
	public static extern float Sharp(float x, float y, int octaves, float frequency, float amplitude, float lacunarity, float gain) { }

	// RVA: 0x7E8750 Offset: 0x7E6D50 VA: 0x1807E8750
	public static extern float TurbulenceIQ(float x, float y, int octaves, float frequency, float amplitude, float lacunarity, float gain) { }

	// RVA: 0x7E7B80 Offset: 0x7E6180 VA: 0x1807E7B80
	public static extern float BillowIQ(float x, float y, int octaves, float frequency, float amplitude, float lacunarity, float gain) { }

	// RVA: 0x7E7F60 Offset: 0x7E6560 VA: 0x1807E7F60
	public static extern float RidgeIQ(float x, float y, int octaves, float frequency, float amplitude, float lacunarity, float gain) { }

	// RVA: 0x7E8230 Offset: 0x7E6830 VA: 0x1807E8230
	public static extern float SharpIQ(float x, float y, int octaves, float frequency, float amplitude, float lacunarity, float gain) { }

	// RVA: 0x7E8840 Offset: 0x7E6E40 VA: 0x1807E8840
	public static extern float TurbulenceWarp(float x, float y, int octaves, float frequency, float amplitude, float lacunarity, float gain, float warp) { }

	// RVA: 0x7E7C70 Offset: 0x7E6270 VA: 0x1807E7C70
	public static extern float BillowWarp(float x, float y, int octaves, float frequency, float amplitude, float lacunarity, float gain, float warp) { }

	// RVA: 0x7E8050 Offset: 0x7E6650 VA: 0x1807E8050
	public static extern float RidgeWarp(float x, float y, int octaves, float frequency, float amplitude, float lacunarity, float gain, float warp) { }

	// RVA: 0x7E8320 Offset: 0x7E6920 VA: 0x1807E8320
	public static extern float SharpWarp(float x, float y, int octaves, float frequency, float amplitude, float lacunarity, float gain, float warp) { }

	// RVA: 0x7E7E50 Offset: 0x7E6450 VA: 0x1807E7E50
	public static extern float Jordan(float x, float y, int octaves, float frequency, float amplitude, float lacunarity, float gain, float warp, float damp, float damp_scale) { }

}

