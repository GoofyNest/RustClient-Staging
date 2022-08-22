public class Random // TypeDefIndex: 288
{	// Fields
	private const int MBIG = 2147483647;
	private const int MSEED = 161803398;
	private const int MZ = 0;
	private int inext; // 0x10
	private int inextp; // 0x14
	private int[] SeedArray; // 0x18

	// Methods

	// RVA: 0x18D4610 Offset: 0x18D2C10 VA: 0x1818D4610
	public void .ctor() { }

	// RVA: 0x18D4640 Offset: 0x18D2C40 VA: 0x1818D4640
	public void .ctor(int Seed) { }

	// RVA: 0x18D45F0 Offset: 0x18D2BF0 VA: 0x1818D45F0 Slot: 4
	protected virtual double Sample() { }

	// RVA: 0x18D42B0 Offset: 0x18D28B0 VA: 0x1818D42B0
	private int InternalSample() { }

	// RVA: 0x18D4360 Offset: 0x18D2960 VA: 0x1818D4360 Slot: 5
	public virtual int Next() { }

	// RVA: 0x18D4250 Offset: 0x18D2850 VA: 0x1818D4250
	private double GetSampleForLargeRange() { }

	// RVA: 0x18D4370 Offset: 0x18D2970 VA: 0x1818D4370 Slot: 6
	public virtual int Next(int minValue, int maxValue) { }

	// RVA: 0x18D4500 Offset: 0x18D2B00 VA: 0x1818D4500 Slot: 7
	public virtual int Next(int maxValue) { }

	// RVA: 0x4D3F40 Offset: 0x4D2540 VA: 0x1804D3F40 Slot: 8
	public virtual double NextDouble() { }

}

public sealed class Random // TypeDefIndex: 3487
{	// Properties
	[StaticAccessorAttribute] // RVA: 0xB4350 Offset: 0xB3750 VA: 0x1800B4350
	public static Random.State state { get; set; }
	public static float value { get; }
	public static Vector3 insideUnitSphere { get; }
	public static Vector2 insideUnitCircle { get; }
	public static Vector3 onUnitSphere { get; }
	public static Quaternion rotation { get; }

	// Methods

	[NativeMethodAttribute] // RVA: 0xB3980 Offset: 0xB2D80 VA: 0x1800B3980
	[StaticAccessorAttribute] // RVA: 0xB3980 Offset: 0xB2D80 VA: 0x1800B3980
	// RVA: 0x18FF690 Offset: 0x18FDC90 VA: 0x1818FF690
	public static void InitState(int seed) { }

	// RVA: 0x18FF960 Offset: 0x18FDF60 VA: 0x1818FF960
	public static Random.State get_state() { }

	// RVA: 0x18FFA10 Offset: 0x18FE010 VA: 0x1818FFA10
	public static void set_state(Random.State value) { }

	[FreeFunctionAttribute] // RVA: 0x7A450 Offset: 0x79850 VA: 0x18007A450
	// RVA: 0x18FF710 Offset: 0x18FDD10 VA: 0x1818FF710
	public static float Range(float min, float max) { }

	// RVA: 0x18FF6D0 Offset: 0x18FDCD0 VA: 0x1818FF6D0
	public static int Range(int min, int max) { }

	[FreeFunctionAttribute] // RVA: 0x7A450 Offset: 0x79850 VA: 0x18007A450
	// RVA: 0x18FF6D0 Offset: 0x18FDCD0 VA: 0x1818FF6D0
	private static int RandomRangeInt(int min, int max) { }

	[FreeFunctionAttribute] // RVA: 0x7A450 Offset: 0x79850 VA: 0x18007A450
	// RVA: 0x18FF9A0 Offset: 0x18FDFA0 VA: 0x1818FF9A0
	public static float get_value() { }

	[FreeFunctionAttribute] // RVA: 0x7A450 Offset: 0x79850 VA: 0x18007A450
	// RVA: 0x18FF7E0 Offset: 0x18FDDE0 VA: 0x1818FF7E0
	public static Vector3 get_insideUnitSphere() { }

	[FreeFunctionAttribute] // RVA: 0x7A450 Offset: 0x79850 VA: 0x18007A450
	// RVA: 0x18FF650 Offset: 0x18FDC50 VA: 0x1818FF650
	private static void GetRandomUnitCircle(out Vector2 output) { }

	// RVA: 0x18FF760 Offset: 0x18FDD60 VA: 0x1818FF760
	public static Vector2 get_insideUnitCircle() { }

	[FreeFunctionAttribute] // RVA: 0x7A450 Offset: 0x79850 VA: 0x18007A450
	// RVA: 0x18FF860 Offset: 0x18FDE60 VA: 0x1818FF860
	public static Vector3 get_onUnitSphere() { }

	[FreeFunctionAttribute] // RVA: 0x7A450 Offset: 0x79850 VA: 0x18007A450
	// RVA: 0x18FF8E0 Offset: 0x18FDEE0 VA: 0x1818FF8E0
	public static Quaternion get_rotation() { }

	[ObsoleteAttribute] // RVA: 0xB4200 Offset: 0xB3600 VA: 0x1800B4200
	// RVA: 0x18FF6D0 Offset: 0x18FDCD0 VA: 0x1818FF6D0
	public static int RandomRange(int min, int max) { }

	// RVA: 0x18FF490 Offset: 0x18FDA90 VA: 0x1818FF490
	public static Color ColorHSV(float hueMin, float hueMax, float saturationMin, float saturationMax, float valueMin, float valueMax, float alphaMin, float alphaMax) { }

	// RVA: 0x18FF920 Offset: 0x18FDF20 VA: 0x1818FF920
	private static void get_state_Injected(out Random.State ret) { }

	// RVA: 0x18FF9D0 Offset: 0x18FDFD0 VA: 0x1818FF9D0
	private static void set_state_Injected(ref Random.State value) { }

	// RVA: 0x18FF7A0 Offset: 0x18FDDA0 VA: 0x1818FF7A0
	private static void get_insideUnitSphere_Injected(out Vector3 ret) { }

	// RVA: 0x18FF820 Offset: 0x18FDE20 VA: 0x1818FF820
	private static void get_onUnitSphere_Injected(out Vector3 ret) { }

	// RVA: 0x18FF8A0 Offset: 0x18FDEA0 VA: 0x1818FF8A0
	private static void get_rotation_Injected(out Quaternion ret) { }

}

public struct Random.State // TypeDefIndex: 3488
{	// Fields
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int s0; // 0x0
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int s1; // 0x4
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int s2; // 0x8
	[SerializeField] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private int s3; // 0xC

}

