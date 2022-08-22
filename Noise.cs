public static class Noise // TypeDefIndex: 10290
{	// Fields
	public const float MIN = -1000000;
	public const float MAX = 1000000;

	// Methods

	// RVA: 0x9D2DB0 Offset: 0x9D13B0 VA: 0x1809D2DB0
	public static float Simplex1D(float x) { }

	// RVA: 0x9D2DC0 Offset: 0x9D13C0 VA: 0x1809D2DC0
	public static float Simplex2D(float x, float y) { }

	// RVA: 0x9D2DF0 Offset: 0x9D13F0 VA: 0x1809D2DF0
	public static float Turbulence(float x, float y, int octaves = 1, float frequency = 1, float amplitude = 1, float lacunarity = 2, float gain = 0,5) { }

	// RVA: 0x9D2CC0 Offset: 0x9D12C0 VA: 0x1809D2CC0
	public static float Billow(float x, float y, int octaves = 1, float frequency = 1, float amplitude = 1, float lacunarity = 2, float gain = 0,5) { }

	// RVA: 0x9D2D70 Offset: 0x9D1370 VA: 0x1809D2D70
	public static float Ridge(float x, float y, int octaves = 1, float frequency = 1, float amplitude = 1, float lacunarity = 2, float gain = 0,5) { }

	// RVA: 0x9D2DA0 Offset: 0x9D13A0 VA: 0x1809D2DA0
	public static float Sharp(float x, float y, int octaves = 1, float frequency = 1, float amplitude = 1, float lacunarity = 2, float gain = 0,5) { }

	// RVA: 0x9D2DD0 Offset: 0x9D13D0 VA: 0x1809D2DD0
	public static float TurbulenceIQ(float x, float y, int octaves = 1, float frequency = 1, float amplitude = 1, float lacunarity = 2, float gain = 0,5) { }

	// RVA: 0x9D2CA0 Offset: 0x9D12A0 VA: 0x1809D2CA0
	public static float BillowIQ(float x, float y, int octaves = 1, float frequency = 1, float amplitude = 1, float lacunarity = 2, float gain = 0,5) { }

	// RVA: 0x9D2D50 Offset: 0x9D1350 VA: 0x1809D2D50
	public static float RidgeIQ(float x, float y, int octaves = 1, float frequency = 1, float amplitude = 1, float lacunarity = 2, float gain = 0,5) { }

	// RVA: 0x9D2D80 Offset: 0x9D1380 VA: 0x1809D2D80
	public static float SharpIQ(float x, float y, int octaves = 1, float frequency = 1, float amplitude = 1, float lacunarity = 2, float gain = 0,5) { }

	// RVA: 0x9D2DE0 Offset: 0x9D13E0 VA: 0x1809D2DE0
	public static float TurbulenceWarp(float x, float y, int octaves = 1, float frequency = 1, float amplitude = 1, float lacunarity = 2, float gain = 0,5, float warp = 0,25) { }

	// RVA: 0x9D2CB0 Offset: 0x9D12B0 VA: 0x1809D2CB0
	public static float BillowWarp(float x, float y, int octaves = 1, float frequency = 1, float amplitude = 1, float lacunarity = 2, float gain = 0,5, float warp = 0,25) { }

	// RVA: 0x9D2D60 Offset: 0x9D1360 VA: 0x1809D2D60
	public static float RidgeWarp(float x, float y, int octaves = 1, float frequency = 1, float amplitude = 1, float lacunarity = 2, float gain = 0,5, float warp = 0,25) { }

	// RVA: 0x9D2D90 Offset: 0x9D1390 VA: 0x1809D2D90
	public static float SharpWarp(float x, float y, int octaves = 1, float frequency = 1, float amplitude = 1, float lacunarity = 2, float gain = 0,5, float warp = 0,25) { }

	// RVA: 0x9D2CD0 Offset: 0x9D12D0 VA: 0x1809D2CD0
	public static float Jordan(float x, float y, int octaves = 1, float frequency = 1, float amplitude = 1, float lacunarity = 2, float gain = 0,5, float warp = 1, float damp = 1, float damp_scale = 1) { }

}

