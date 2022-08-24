public class Random // TypeDefIndex: 288
{	private const int MBIG = 2147483647;
	private const int MSEED = 161803398;
	private const int MZ = 0;
	private int inext; // 0x10
	private int inextp; // 0x14
	private int[] SeedArray; // 0x18


	public void .ctor() { }

	public void .ctor(int Seed) { }

	protected virtual double Sample() { }

	private int InternalSample() { }

	public virtual int Next() { }

	private double GetSampleForLargeRange() { }

	public virtual int Next(int minValue, int maxValue) { }

	public virtual int Next(int maxValue) { }

	public virtual double NextDouble() { }

}

public sealed class Random // TypeDefIndex: 3487
{	[StaticAccessorAttribute] // RVA: 0xB4390 Offset: 0xB3790 VA: 0x1800B4390
	public static Random.State state { get; set; }
	public static float value { get; }
	public static Vector3 insideUnitSphere { get; }
	public static Vector2 insideUnitCircle { get; }
	public static Vector3 onUnitSphere { get; }
	public static Quaternion rotation { get; }


	[NativeMethodAttribute] // RVA: 0xB3A00 Offset: 0xB2E00 VA: 0x1800B3A00
	[StaticAccessorAttribute] // RVA: 0xB3A00 Offset: 0xB2E00 VA: 0x1800B3A00
	public static void InitState(int seed) { }

	public static Random.State get_state() { }

	public static void set_state(Random.State value) { }

	[FreeFunctionAttribute] // RVA: 0x7A500 Offset: 0x79900 VA: 0x18007A500
	public static float Range(float min, float max) { }

	public static int Range(int min, int max) { }

	[FreeFunctionAttribute] // RVA: 0x7A500 Offset: 0x79900 VA: 0x18007A500
	private static int RandomRangeInt(int min, int max) { }

	[FreeFunctionAttribute] // RVA: 0x7A500 Offset: 0x79900 VA: 0x18007A500
	public static float get_value() { }

	[FreeFunctionAttribute] // RVA: 0x7A500 Offset: 0x79900 VA: 0x18007A500
	public static Vector3 get_insideUnitSphere() { }

	[FreeFunctionAttribute] // RVA: 0x7A500 Offset: 0x79900 VA: 0x18007A500
	private static void GetRandomUnitCircle(out Vector2 output) { }

	public static Vector2 get_insideUnitCircle() { }

	[FreeFunctionAttribute] // RVA: 0x7A500 Offset: 0x79900 VA: 0x18007A500
	public static Vector3 get_onUnitSphere() { }

	[FreeFunctionAttribute] // RVA: 0x7A500 Offset: 0x79900 VA: 0x18007A500
	public static Quaternion get_rotation() { }

	[ObsoleteAttribute] // RVA: 0xB4280 Offset: 0xB3680 VA: 0x1800B4280
	public static int RandomRange(int min, int max) { }

	public static Color ColorHSV(float hueMin, float hueMax, float saturationMin, float saturationMax, float valueMin, float valueMax, float alphaMin, float alphaMax) { }

	private static void get_state_Injected(out Random.State ret) { }

	private static void set_state_Injected(ref Random.State value) { }

	private static void get_insideUnitSphere_Injected(out Vector3 ret) { }

	private static void get_onUnitSphere_Injected(out Vector3 ret) { }

	private static void get_rotation_Injected(out Quaternion ret) { }

}

public struct Random.State // TypeDefIndex: 3488
{	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private int s0; // 0x0
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private int s1; // 0x4
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private int s2; // 0x8
	[SerializeField] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	private int s3; // 0xC

}

