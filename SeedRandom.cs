public class SeedRandom // TypeDefIndex: 6592
{	// Fields
	public uint Seed; // 0x10

	// Methods

	// RVA: 0x1BABC80 Offset: 0x1BAA280 VA: 0x181BABC80
	public void .ctor(uint seed = 0) { }

	// RVA: 0x1BAB8D0 Offset: 0x1BA9ED0 VA: 0x181BAB8D0
	public int Range(int min, int max) { }

	// RVA: 0x1BAB8A0 Offset: 0x1BA9EA0 VA: 0x181BAB8A0
	public static int Range(uint seed, int min, int max) { }

	// RVA: 0x1BAB950 Offset: 0x1BA9F50 VA: 0x181BAB950
	public static int Range(ref uint seed, int min, int max) { }

	// RVA: 0x1BAB980 Offset: 0x1BA9F80 VA: 0x181BAB980
	public float Range(float min, float max) { }

	// RVA: 0x1BAB860 Offset: 0x1BA9E60 VA: 0x181BAB860
	public static float Range(uint seed, float min, float max) { }

	// RVA: 0x1BAB910 Offset: 0x1BA9F10 VA: 0x181BAB910
	public static float Range(ref uint seed, float min, float max) { }

	// RVA: 0x1BAB9C0 Offset: 0x1BA9FC0 VA: 0x181BAB9C0
	public int Sign() { }

	// RVA: 0x1BAB9F0 Offset: 0x1BA9FF0 VA: 0x181BAB9F0
	public static int Sign(uint seed) { }

	// RVA: 0x1BABA10 Offset: 0x1BAA010 VA: 0x181BABA10
	public static int Sign(ref uint seed) { }

	// RVA: 0x1BABB40 Offset: 0x1BAA140 VA: 0x181BABB40
	public float Value() { }

	// RVA: 0x1BABB80 Offset: 0x1BAA180 VA: 0x181BABB80
	public static float Value(uint seed) { }

	// RVA: 0x1BABBB0 Offset: 0x1BAA1B0 VA: 0x181BABBB0
	public static float Value(ref uint seed) { }

	// RVA: 0x1BABA40 Offset: 0x1BAA040 VA: 0x181BABA40
	public Vector2 Value2D() { }

	// RVA: 0x1BABB20 Offset: 0x1BAA120 VA: 0x181BABB20
	public static Vector2 Value2D(uint seed) { }

	// RVA: 0x1BABA50 Offset: 0x1BAA050 VA: 0x181BABA50
	public static Vector2 Value2D(ref uint seed) { }

	// RVA: 0x1BABC30 Offset: 0x1BAA230 VA: 0x181BABC30
	public static uint Wanghash(ref uint x) { }

	// RVA: 0x1BABBF0 Offset: 0x1BAA1F0 VA: 0x181BABBF0
	public static float Wanghash01(ref uint x) { }

	// RVA: 0x1BABC60 Offset: 0x1BAA260 VA: 0x181BABC60
	public static uint Xorshift(ref uint x) { }

	// RVA: 0x1BABBB0 Offset: 0x1BAA1B0 VA: 0x181BABBB0
	public static float Xorshift01(ref uint x) { }

}

