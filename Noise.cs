public static class Noise // TypeDefIndex: 10290
{	// Fields
	public const float MIN = -1000000;
	public const float MAX = 1000000;

	// Methods

	// RVA: 0x9D2AF0 Offset: 0x9D10F0 VA: 0x1809D2AF0
	public static float Simplex1D(float x) { }

	// RVA: 0x9D2B00 Offset: 0x9D1100 VA: 0x1809D2B00
	public static float Simplex2D(float x, float y) { }

	// RVA: 0x9D2B30 Offset: 0x9D1130 VA: 0x1809D2B30
	public static float Turbulence(float x, float y, int octaves = 1, float frequency = 1, float amplitude = 1, float lacunarity = 2, float gain = 0,5) { }

	// RVA: 0x9D2A00 Offset: 0x9D1000 VA: 0x1809D2A00
	public static float Billow(float x, float y, int octaves = 1, float frequency = 1, float amplitude = 1, float lacunarity = 2, float gain = 0,5) { }

	// RVA: 0x9D2AB0 Offset: 0x9D10B0 VA: 0x1809D2AB0
	public static float Ridge(float x, float y, int octaves = 1, float frequency = 1, float amplitude = 1, float lacunarity = 2, float gain = 0,5) { }

	// RVA: 0x9D2AE0 Offset: 0x9D10E0 VA: 0x1809D2AE0
	public static float Sharp(float x, float y, int octaves = 1, float frequency = 1, float amplitude = 1, float lacunarity = 2, float gain = 0,5) { }

	// RVA: 0x9D2B10 Offset: 0x9D1110 VA: 0x1809D2B10
	public static float TurbulenceIQ(float x, float y, int octaves = 1, float frequency = 1, float amplitude = 1, float lacunarity = 2, float gain = 0,5) { }

	// RVA: 0x9D29E0 Offset: 0x9D0FE0 VA: 0x1809D29E0
	public static float BillowIQ(float x, float y, int octaves = 1, float frequency = 1, float amplitude = 1, float lacunarity = 2, float gain = 0,5) { }

	// RVA: 0x9D2A90 Offset: 0x9D1090 VA: 0x1809D2A90
	public static float RidgeIQ(float x, float y, int octaves = 1, float frequency = 1, float amplitude = 1, float lacunarity = 2, float gain = 0,5) { }

	// RVA: 0x9D2AC0 Offset: 0x9D10C0 VA: 0x1809D2AC0
	public static float SharpIQ(float x, float y, int octaves = 1, float frequency = 1, float amplitude = 1, float lacunarity = 2, float gain = 0,5) { }

	// RVA: 0x9D2B20 Offset: 0x9D1120 VA: 0x1809D2B20
	public static float TurbulenceWarp(float x, float y, int octaves = 1, float frequency = 1, float amplitude = 1, float lacunarity = 2, float gain = 0,5, float warp = 0,25) { }

	// RVA: 0x9D29F0 Offset: 0x9D0FF0 VA: 0x1809D29F0
	public static float BillowWarp(float x, float y, int octaves = 1, float frequency = 1, float amplitude = 1, float lacunarity = 2, float gain = 0,5, float warp = 0,25) { }

	// RVA: 0x9D2AA0 Offset: 0x9D10A0 VA: 0x1809D2AA0
	public static float RidgeWarp(float x, float y, int octaves = 1, float frequency = 1, float amplitude = 1, float lacunarity = 2, float gain = 0,5, float warp = 0,25) { }

	// RVA: 0x9D2AD0 Offset: 0x9D10D0 VA: 0x1809D2AD0
	public static float SharpWarp(float x, float y, int octaves = 1, float frequency = 1, float amplitude = 1, float lacunarity = 2, float gain = 0,5, float warp = 0,25) { }

	// RVA: 0x9D2A10 Offset: 0x9D1010 VA: 0x1809D2A10
	public static float Jordan(float x, float y, int octaves = 1, float frequency = 1, float amplitude = 1, float lacunarity = 2, float gain = 0,5, float warp = 1, float damp = 1, float damp_scale = 1) { }

}

