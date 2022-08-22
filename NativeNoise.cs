public static class NativeNoise // TypeDefIndex: 10289
{	// Methods

	// RVA: 0x7CA1A0 Offset: 0x7C87A0 VA: 0x1807CA1A0
	public static extern float Simplex1D(float x) { }

	// RVA: 0x7CA110 Offset: 0x7C8710 VA: 0x1807CA110
	public static extern float Simplex1D(float x, out float dx) { }

	// RVA: 0x7CA220 Offset: 0x7C8820 VA: 0x1807CA220
	public static extern float Simplex2D(float x, float y) { }

	// RVA: 0x7CA2B0 Offset: 0x7C88B0 VA: 0x1807CA2B0
	public static extern float Simplex2D(float x, float y, out float dx, out float dy) { }

	// RVA: 0x7CA540 Offset: 0x7C8B40 VA: 0x1807CA540
	public static extern float Turbulence(float x, float y, int octaves, float frequency, float amplitude, float lacunarity, float gain) { }

	// RVA: 0x7C9970 Offset: 0x7C7F70 VA: 0x1807C9970
	public static extern float Billow(float x, float y, int octaves, float frequency, float amplitude, float lacunarity, float gain) { }

	// RVA: 0x7C9D50 Offset: 0x7C8350 VA: 0x1807C9D50
	public static extern float Ridge(float x, float y, int octaves, float frequency, float amplitude, float lacunarity, float gain) { }

	// RVA: 0x7CA020 Offset: 0x7C8620 VA: 0x1807CA020
	public static extern float Sharp(float x, float y, int octaves, float frequency, float amplitude, float lacunarity, float gain) { }

	// RVA: 0x7CA360 Offset: 0x7C8960 VA: 0x1807CA360
	public static extern float TurbulenceIQ(float x, float y, int octaves, float frequency, float amplitude, float lacunarity, float gain) { }

	// RVA: 0x7C9790 Offset: 0x7C7D90 VA: 0x1807C9790
	public static extern float BillowIQ(float x, float y, int octaves, float frequency, float amplitude, float lacunarity, float gain) { }

	// RVA: 0x7C9B70 Offset: 0x7C8170 VA: 0x1807C9B70
	public static extern float RidgeIQ(float x, float y, int octaves, float frequency, float amplitude, float lacunarity, float gain) { }

	// RVA: 0x7C9E40 Offset: 0x7C8440 VA: 0x1807C9E40
	public static extern float SharpIQ(float x, float y, int octaves, float frequency, float amplitude, float lacunarity, float gain) { }

	// RVA: 0x7CA450 Offset: 0x7C8A50 VA: 0x1807CA450
	public static extern float TurbulenceWarp(float x, float y, int octaves, float frequency, float amplitude, float lacunarity, float gain, float warp) { }

	// RVA: 0x7C9880 Offset: 0x7C7E80 VA: 0x1807C9880
	public static extern float BillowWarp(float x, float y, int octaves, float frequency, float amplitude, float lacunarity, float gain, float warp) { }

	// RVA: 0x7C9C60 Offset: 0x7C8260 VA: 0x1807C9C60
	public static extern float RidgeWarp(float x, float y, int octaves, float frequency, float amplitude, float lacunarity, float gain, float warp) { }

	// RVA: 0x7C9F30 Offset: 0x7C8530 VA: 0x1807C9F30
	public static extern float SharpWarp(float x, float y, int octaves, float frequency, float amplitude, float lacunarity, float gain, float warp) { }

	// RVA: 0x7C9A60 Offset: 0x7C8060 VA: 0x1807C9A60
	public static extern float Jordan(float x, float y, int octaves, float frequency, float amplitude, float lacunarity, float gain, float warp, float damp, float damp_scale) { }

}

