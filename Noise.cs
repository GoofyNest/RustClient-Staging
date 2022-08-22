public static class Noise // TypeDefIndex: 10290
{	// Fields
	public const float MIN = -1000000;
	public const float MAX = 1000000;

	// Methods

	// RVA: 0x9D32A0 Offset: 0x9D18A0 VA: 0x1809D32A0
	public static float Simplex1D(float x) { }

	// RVA: 0x9D32B0 Offset: 0x9D18B0 VA: 0x1809D32B0
	public static float Simplex2D(float x, float y) { }

	// RVA: 0x9D32E0 Offset: 0x9D18E0 VA: 0x1809D32E0
	public static float Turbulence(float x, float y, int octaves = 1, float frequency = 1, float amplitude = 1, float lacunarity = 2, float gain = 0,5) { }

	// RVA: 0x9D31B0 Offset: 0x9D17B0 VA: 0x1809D31B0
	public static float Billow(float x, float y, int octaves = 1, float frequency = 1, float amplitude = 1, float lacunarity = 2, float gain = 0,5) { }

	// RVA: 0x9D3260 Offset: 0x9D1860 VA: 0x1809D3260
	public static float Ridge(float x, float y, int octaves = 1, float frequency = 1, float amplitude = 1, float lacunarity = 2, float gain = 0,5) { }

	// RVA: 0x9D3290 Offset: 0x9D1890 VA: 0x1809D3290
	public static float Sharp(float x, float y, int octaves = 1, float frequency = 1, float amplitude = 1, float lacunarity = 2, float gain = 0,5) { }

	// RVA: 0x9D32C0 Offset: 0x9D18C0 VA: 0x1809D32C0
	public static float TurbulenceIQ(float x, float y, int octaves = 1, float frequency = 1, float amplitude = 1, float lacunarity = 2, float gain = 0,5) { }

	// RVA: 0x9D3190 Offset: 0x9D1790 VA: 0x1809D3190
	public static float BillowIQ(float x, float y, int octaves = 1, float frequency = 1, float amplitude = 1, float lacunarity = 2, float gain = 0,5) { }

	// RVA: 0x9D3240 Offset: 0x9D1840 VA: 0x1809D3240
	public static float RidgeIQ(float x, float y, int octaves = 1, float frequency = 1, float amplitude = 1, float lacunarity = 2, float gain = 0,5) { }

	// RVA: 0x9D3270 Offset: 0x9D1870 VA: 0x1809D3270
	public static float SharpIQ(float x, float y, int octaves = 1, float frequency = 1, float amplitude = 1, float lacunarity = 2, float gain = 0,5) { }

	// RVA: 0x9D32D0 Offset: 0x9D18D0 VA: 0x1809D32D0
	public static float TurbulenceWarp(float x, float y, int octaves = 1, float frequency = 1, float amplitude = 1, float lacunarity = 2, float gain = 0,5, float warp = 0,25) { }

	// RVA: 0x9D31A0 Offset: 0x9D17A0 VA: 0x1809D31A0
	public static float BillowWarp(float x, float y, int octaves = 1, float frequency = 1, float amplitude = 1, float lacunarity = 2, float gain = 0,5, float warp = 0,25) { }

	// RVA: 0x9D3250 Offset: 0x9D1850 VA: 0x1809D3250
	public static float RidgeWarp(float x, float y, int octaves = 1, float frequency = 1, float amplitude = 1, float lacunarity = 2, float gain = 0,5, float warp = 0,25) { }

	// RVA: 0x9D3280 Offset: 0x9D1880 VA: 0x1809D3280
	public static float SharpWarp(float x, float y, int octaves = 1, float frequency = 1, float amplitude = 1, float lacunarity = 2, float gain = 0,5, float warp = 0,25) { }

	// RVA: 0x9D31C0 Offset: 0x9D17C0 VA: 0x1809D31C0
	public static float Jordan(float x, float y, int octaves = 1, float frequency = 1, float amplitude = 1, float lacunarity = 2, float gain = 0,5, float warp = 1, float damp = 1, float damp_scale = 1) { }

}

