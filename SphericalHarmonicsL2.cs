public struct SphericalHarmonicsL2 : IEquatable<SphericalHarmonicsL2> // TypeDefIndex: 3842
{	// Fields
	private float shr0; // 0x0
	private float shr1; // 0x4
	private float shr2; // 0x8
	private float shr3; // 0xC
	private float shr4; // 0x10
	private float shr5; // 0x14
	private float shr6; // 0x18
	private float shr7; // 0x1C
	private float shr8; // 0x20
	private float shg0; // 0x24
	private float shg1; // 0x28
	private float shg2; // 0x2C
	private float shg3; // 0x30
	private float shg4; // 0x34
	private float shg5; // 0x38
	private float shg6; // 0x3C
	private float shg7; // 0x40
	private float shg8; // 0x44
	private float shb0; // 0x48
	private float shb1; // 0x4C
	private float shb2; // 0x50
	private float shb3; // 0x54
	private float shb4; // 0x58
	private float shb5; // 0x5C
	private float shb6; // 0x60
	private float shb7; // 0x64
	private float shb8; // 0x68

	// Properties
	public float Item { get; }

	// Methods

	// RVA: 0x222E30 Offset: 0x222230 VA: 0x180222E30
	public void AddAmbientLight(Color color) { }

	// RVA: 0x222E80 Offset: 0x222280 VA: 0x180222E80
	public void AddDirectionalLight(Vector3 direction, Color color, float intensity) { }

	[FreeFunctionAttribute] // RVA: 0x7A450 Offset: 0x79850 VA: 0x18007A450
	// RVA: 0x19B67C0 Offset: 0x19B4DC0 VA: 0x1819B67C0
	private static void AddDirectionalLightInternal(ref SphericalHarmonicsL2 sh, Vector3 direction, Color color) { }

	// RVA: 0x223140 Offset: 0x222540 VA: 0x180223140
	public float get_Item(int rgb, int coefficient) { }

	// RVA: 0x223130 Offset: 0x222530 VA: 0x180223130 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x222F10 Offset: 0x222310 VA: 0x180222F10 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x223070 Offset: 0x222470 VA: 0x180223070 Slot: 4
	public bool Equals(SphericalHarmonicsL2 other) { }

	// RVA: 0x19B6F10 Offset: 0x19B5510 VA: 0x1819B6F10
	public static bool op_Equality(SphericalHarmonicsL2 lhs, SphericalHarmonicsL2 rhs) { }

	// RVA: 0x19B66C0 Offset: 0x19B4CC0 VA: 0x1819B66C0
	private static void AddAmbientLight_Injected(ref SphericalHarmonicsL2 _unity_self, ref Color color) { }

	// RVA: 0x19B6760 Offset: 0x19B4D60 VA: 0x1819B6760
	private static void AddDirectionalLightInternal_Injected(ref SphericalHarmonicsL2 sh, ref Vector3 direction, ref Color color) { }

}

