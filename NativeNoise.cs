public static class NativeNoise // TypeDefIndex: 10289
{	// Methods

	// RVA: 0x7CA090 Offset: 0x7C8690 VA: 0x1807CA090
	public static extern float Simplex1D(float x) { }

	// RVA: 0x7CA000 Offset: 0x7C8600 VA: 0x1807CA000
	public static extern float Simplex1D(float x, out float dx) { }

	// RVA: 0x7CA110 Offset: 0x7C8710 VA: 0x1807CA110
	public static extern float Simplex2D(float x, float y) { }

	// RVA: 0x7CA1A0 Offset: 0x7C87A0 VA: 0x1807CA1A0
	public static extern float Simplex2D(float x, float y, out float dx, out float dy) { }

	// RVA: 0x7CA430 Offset: 0x7C8A30 VA: 0x1807CA430
	public static extern float Turbulence(float x, float y, int octaves, float frequency, float amplitude, float lacunarity, float gain) { }

	// RVA: 0x7C9860 Offset: 0x7C7E60 VA: 0x1807C9860
	public static extern float Billow(float x, float y, int octaves, float frequency, float amplitude, float lacunarity, float gain) { }

	// RVA: 0x7C9C40 Offset: 0x7C8240 VA: 0x1807C9C40
	public static extern float Ridge(float x, float y, int octaves, float frequency, float amplitude, float lacunarity, float gain) { }

	// RVA: 0x7C9F10 Offset: 0x7C8510 VA: 0x1807C9F10
	public static extern float Sharp(float x, float y, int octaves, float frequency, float amplitude, float lacunarity, float gain) { }

	// RVA: 0x7CA250 Offset: 0x7C8850 VA: 0x1807CA250
	public static extern float TurbulenceIQ(float x, float y, int octaves, float frequency, float amplitude, float lacunarity, float gain) { }

	// RVA: 0x7C9680 Offset: 0x7C7C80 VA: 0x1807C9680
	public static extern float BillowIQ(float x, float y, int octaves, float frequency, float amplitude, float lacunarity, float gain) { }

	// RVA: 0x7C9A60 Offset: 0x7C8060 VA: 0x1807C9A60
	public static extern float RidgeIQ(float x, float y, int octaves, float frequency, float amplitude, float lacunarity, float gain) { }

	// RVA: 0x7C9D30 Offset: 0x7C8330 VA: 0x1807C9D30
	public static extern float SharpIQ(float x, float y, int octaves, float frequency, float amplitude, float lacunarity, float gain) { }

	// RVA: 0x7CA340 Offset: 0x7C8940 VA: 0x1807CA340
	public static extern float TurbulenceWarp(float x, float y, int octaves, float frequency, float amplitude, float lacunarity, float gain, float warp) { }

	// RVA: 0x7C9770 Offset: 0x7C7D70 VA: 0x1807C9770
	public static extern float BillowWarp(float x, float y, int octaves, float frequency, float amplitude, float lacunarity, float gain, float warp) { }

	// RVA: 0x7C9B50 Offset: 0x7C8150 VA: 0x1807C9B50
	public static extern float RidgeWarp(float x, float y, int octaves, float frequency, float amplitude, float lacunarity, float gain, float warp) { }

	// RVA: 0x7C9E20 Offset: 0x7C8420 VA: 0x1807C9E20
	public static extern float SharpWarp(float x, float y, int octaves, float frequency, float amplitude, float lacunarity, float gain, float warp) { }

	// RVA: 0x7C9950 Offset: 0x7C7F50 VA: 0x1807C9950
	public static extern float Jordan(float x, float y, int octaves, float frequency, float amplitude, float lacunarity, float gain, float warp, float damp, float damp_scale) { }

}

