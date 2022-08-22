public class Random // TypeDefIndex: 288
{	// Fields
	private const int MBIG = 2147483647;
	private const int MSEED = 161803398;
	private const int MZ = 0;
	private int inext; // 0x10
	private int inextp; // 0x14
	private int[] SeedArray; // 0x18

	// Methods

	// RVA: 0x18D4EF0 Offset: 0x18D34F0 VA: 0x1818D4EF0
	public void .ctor() { }

	// RVA: 0x18D4F20 Offset: 0x18D3520 VA: 0x1818D4F20
	public void .ctor(int Seed) { }

	// RVA: 0x18D4ED0 Offset: 0x18D34D0 VA: 0x1818D4ED0 Slot: 4
	protected virtual double Sample() { }

	// RVA: 0x18D4B90 Offset: 0x18D3190 VA: 0x1818D4B90
	private int InternalSample() { }

	// RVA: 0x18D4C40 Offset: 0x18D3240 VA: 0x1818D4C40 Slot: 5
	public virtual int Next() { }

	// RVA: 0x18D4B30 Offset: 0x18D3130 VA: 0x1818D4B30
	private double GetSampleForLargeRange() { }

	// RVA: 0x18D4C50 Offset: 0x18D3250 VA: 0x1818D4C50 Slot: 6
	public virtual int Next(int minValue, int maxValue) { }

	// RVA: 0x18D4DE0 Offset: 0x18D33E0 VA: 0x1818D4DE0 Slot: 7
	public virtual int Next(int maxValue) { }

	// RVA: 0x4D3FB0 Offset: 0x4D25B0 VA: 0x1804D3FB0 Slot: 8
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
	// RVA: 0x18FFF70 Offset: 0x18FE570 VA: 0x1818FFF70
	public static void InitState(int seed) { }

	// RVA: 0x1900240 Offset: 0x18FE840 VA: 0x181900240
	public static Random.State get_state() { }

	// RVA: 0x19002F0 Offset: 0x18FE8F0 VA: 0x1819002F0
	public static void set_state(Random.State value) { }

	[FreeFunctionAttribute] // RVA: 0x7A450 Offset: 0x79850 VA: 0x18007A450
	// RVA: 0x18FFFF0 Offset: 0x18FE5F0 VA: 0x1818FFFF0
	public static float Range(float min, float max) { }

	// RVA: 0x18FFFB0 Offset: 0x18FE5B0 VA: 0x1818FFFB0
	public static int Range(int min, int max) { }

	[FreeFunctionAttribute] // RVA: 0x7A450 Offset: 0x79850 VA: 0x18007A450
	// RVA: 0x18FFFB0 Offset: 0x18FE5B0 VA: 0x1818FFFB0
	private static int RandomRangeInt(int min, int max) { }

	[FreeFunctionAttribute] // RVA: 0x7A450 Offset: 0x79850 VA: 0x18007A450
	// RVA: 0x1900280 Offset: 0x18FE880 VA: 0x181900280
	public static float get_value() { }

	[FreeFunctionAttribute] // RVA: 0x7A450 Offset: 0x79850 VA: 0x18007A450
	// RVA: 0x19000C0 Offset: 0x18FE6C0 VA: 0x1819000C0
	public static Vector3 get_insideUnitSphere() { }

	[FreeFunctionAttribute] // RVA: 0x7A450 Offset: 0x79850 VA: 0x18007A450
	// RVA: 0x18FFF30 Offset: 0x18FE530 VA: 0x1818FFF30
	private static void GetRandomUnitCircle(out Vector2 output) { }

	// RVA: 0x1900040 Offset: 0x18FE640 VA: 0x181900040
	public static Vector2 get_insideUnitCircle() { }

	[FreeFunctionAttribute] // RVA: 0x7A450 Offset: 0x79850 VA: 0x18007A450
	// RVA: 0x1900140 Offset: 0x18FE740 VA: 0x181900140
	public static Vector3 get_onUnitSphere() { }

	[FreeFunctionAttribute] // RVA: 0x7A450 Offset: 0x79850 VA: 0x18007A450
	// RVA: 0x19001C0 Offset: 0x18FE7C0 VA: 0x1819001C0
	public static Quaternion get_rotation() { }

	[ObsoleteAttribute] // RVA: 0xB4200 Offset: 0xB3600 VA: 0x1800B4200
	// RVA: 0x18FFFB0 Offset: 0x18FE5B0 VA: 0x1818FFFB0
	public static int RandomRange(int min, int max) { }

	// RVA: 0x18FFD70 Offset: 0x18FE370 VA: 0x1818FFD70
	public static Color ColorHSV(float hueMin, float hueMax, float saturationMin, float saturationMax, float valueMin, float valueMax, float alphaMin, float alphaMax) { }

	// RVA: 0x1900200 Offset: 0x18FE800 VA: 0x181900200
	private static void get_state_Injected(out Random.State ret) { }

	// RVA: 0x19002B0 Offset: 0x18FE8B0 VA: 0x1819002B0
	private static void set_state_Injected(ref Random.State value) { }

	// RVA: 0x1900080 Offset: 0x18FE680 VA: 0x181900080
	private static void get_insideUnitSphere_Injected(out Vector3 ret) { }

	// RVA: 0x1900100 Offset: 0x18FE700 VA: 0x181900100
	private static void get_onUnitSphere_Injected(out Vector3 ret) { }

	// RVA: 0x1900180 Offset: 0x18FE780 VA: 0x181900180
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

