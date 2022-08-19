public class SeedRandom // TypeDefIndex: 6592
{	// Fields
	public uint Seed; // 0x10

	// Methods

	// RVA: 0x1BABB80 Offset: 0x1BAA180 VA: 0x181BABB80
	public void .ctor(uint seed = 0) { }

	// RVA: 0x1BAB7D0 Offset: 0x1BA9DD0 VA: 0x181BAB7D0
	public int Range(int min, int max) { }

	// RVA: 0x1BAB7A0 Offset: 0x1BA9DA0 VA: 0x181BAB7A0
	public static int Range(uint seed, int min, int max) { }

	// RVA: 0x1BAB850 Offset: 0x1BA9E50 VA: 0x181BAB850
	public static int Range(ref uint seed, int min, int max) { }

	// RVA: 0x1BAB880 Offset: 0x1BA9E80 VA: 0x181BAB880
	public float Range(float min, float max) { }

	// RVA: 0x1BAB760 Offset: 0x1BA9D60 VA: 0x181BAB760
	public static float Range(uint seed, float min, float max) { }

	// RVA: 0x1BAB810 Offset: 0x1BA9E10 VA: 0x181BAB810
	public static float Range(ref uint seed, float min, float max) { }

	// RVA: 0x1BAB8C0 Offset: 0x1BA9EC0 VA: 0x181BAB8C0
	public int Sign() { }

	// RVA: 0x1BAB8F0 Offset: 0x1BA9EF0 VA: 0x181BAB8F0
	public static int Sign(uint seed) { }

	// RVA: 0x1BAB910 Offset: 0x1BA9F10 VA: 0x181BAB910
	public static int Sign(ref uint seed) { }

	// RVA: 0x1BABA40 Offset: 0x1BAA040 VA: 0x181BABA40
	public float Value() { }

	// RVA: 0x1BABA80 Offset: 0x1BAA080 VA: 0x181BABA80
	public static float Value(uint seed) { }

	// RVA: 0x1BABAB0 Offset: 0x1BAA0B0 VA: 0x181BABAB0
	public static float Value(ref uint seed) { }

	// RVA: 0x1BAB940 Offset: 0x1BA9F40 VA: 0x181BAB940
	public Vector2 Value2D() { }

	// RVA: 0x1BABA20 Offset: 0x1BAA020 VA: 0x181BABA20
	public static Vector2 Value2D(uint seed) { }

	// RVA: 0x1BAB950 Offset: 0x1BA9F50 VA: 0x181BAB950
	public static Vector2 Value2D(ref uint seed) { }

	// RVA: 0x1BABB30 Offset: 0x1BAA130 VA: 0x181BABB30
	public static uint Wanghash(ref uint x) { }

	// RVA: 0x1BABAF0 Offset: 0x1BAA0F0 VA: 0x181BABAF0
	public static float Wanghash01(ref uint x) { }

	// RVA: 0x1BABB60 Offset: 0x1BAA160 VA: 0x181BABB60
	public static uint Xorshift(ref uint x) { }

	// RVA: 0x1BABAB0 Offset: 0x1BAA0B0 VA: 0x181BABAB0
	public static float Xorshift01(ref uint x) { }

}

