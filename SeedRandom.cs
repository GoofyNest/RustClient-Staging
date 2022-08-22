public class SeedRandom // TypeDefIndex: 6592
{	// Fields
	public uint Seed; // 0x10

	// Methods

	// RVA: 0x1BAB9C0 Offset: 0x1BA9FC0 VA: 0x181BAB9C0
	public void .ctor(uint seed = 0) { }

	// RVA: 0x1BAB610 Offset: 0x1BA9C10 VA: 0x181BAB610
	public int Range(int min, int max) { }

	// RVA: 0x1BAB5E0 Offset: 0x1BA9BE0 VA: 0x181BAB5E0
	public static int Range(uint seed, int min, int max) { }

	// RVA: 0x1BAB690 Offset: 0x1BA9C90 VA: 0x181BAB690
	public static int Range(ref uint seed, int min, int max) { }

	// RVA: 0x1BAB6C0 Offset: 0x1BA9CC0 VA: 0x181BAB6C0
	public float Range(float min, float max) { }

	// RVA: 0x1BAB5A0 Offset: 0x1BA9BA0 VA: 0x181BAB5A0
	public static float Range(uint seed, float min, float max) { }

	// RVA: 0x1BAB650 Offset: 0x1BA9C50 VA: 0x181BAB650
	public static float Range(ref uint seed, float min, float max) { }

	// RVA: 0x1BAB700 Offset: 0x1BA9D00 VA: 0x181BAB700
	public int Sign() { }

	// RVA: 0x1BAB730 Offset: 0x1BA9D30 VA: 0x181BAB730
	public static int Sign(uint seed) { }

	// RVA: 0x1BAB750 Offset: 0x1BA9D50 VA: 0x181BAB750
	public static int Sign(ref uint seed) { }

	// RVA: 0x1BAB880 Offset: 0x1BA9E80 VA: 0x181BAB880
	public float Value() { }

	// RVA: 0x1BAB8C0 Offset: 0x1BA9EC0 VA: 0x181BAB8C0
	public static float Value(uint seed) { }

	// RVA: 0x1BAB8F0 Offset: 0x1BA9EF0 VA: 0x181BAB8F0
	public static float Value(ref uint seed) { }

	// RVA: 0x1BAB780 Offset: 0x1BA9D80 VA: 0x181BAB780
	public Vector2 Value2D() { }

	// RVA: 0x1BAB860 Offset: 0x1BA9E60 VA: 0x181BAB860
	public static Vector2 Value2D(uint seed) { }

	// RVA: 0x1BAB790 Offset: 0x1BA9D90 VA: 0x181BAB790
	public static Vector2 Value2D(ref uint seed) { }

	// RVA: 0x1BAB970 Offset: 0x1BA9F70 VA: 0x181BAB970
	public static uint Wanghash(ref uint x) { }

	// RVA: 0x1BAB930 Offset: 0x1BA9F30 VA: 0x181BAB930
	public static float Wanghash01(ref uint x) { }

	// RVA: 0x1BAB9A0 Offset: 0x1BA9FA0 VA: 0x181BAB9A0
	public static uint Xorshift(ref uint x) { }

	// RVA: 0x1BAB8F0 Offset: 0x1BA9EF0 VA: 0x181BAB8F0
	public static float Xorshift01(ref uint x) { }

}

