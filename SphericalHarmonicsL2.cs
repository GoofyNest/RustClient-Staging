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

	// RVA: 0x21E3B0 Offset: 0x21D7B0 VA: 0x18021E3B0
	public void AddAmbientLight(Color color) { }

	// RVA: 0x21E400 Offset: 0x21D800 VA: 0x18021E400
	public void AddDirectionalLight(Vector3 direction, Color color, float intensity) { }

	[FreeFunctionAttribute] // RVA: 0x7A450 Offset: 0x79850 VA: 0x18007A450
	// RVA: 0x19A3E80 Offset: 0x19A2480 VA: 0x1819A3E80
	private static void AddDirectionalLightInternal(ref SphericalHarmonicsL2 sh, Vector3 direction, Color color) { }

	// RVA: 0x21E6C0 Offset: 0x21DAC0 VA: 0x18021E6C0
	public float get_Item(int rgb, int coefficient) { }

	// RVA: 0x21E6B0 Offset: 0x21DAB0 VA: 0x18021E6B0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x21E490 Offset: 0x21D890 VA: 0x18021E490 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x21E5F0 Offset: 0x21D9F0 VA: 0x18021E5F0 Slot: 4
	public bool Equals(SphericalHarmonicsL2 other) { }

	// RVA: 0x19A45D0 Offset: 0x19A2BD0 VA: 0x1819A45D0
	public static bool op_Equality(SphericalHarmonicsL2 lhs, SphericalHarmonicsL2 rhs) { }

	// RVA: 0x19A3D80 Offset: 0x19A2380 VA: 0x1819A3D80
	private static void AddAmbientLight_Injected(ref SphericalHarmonicsL2 _unity_self, ref Color color) { }

	// RVA: 0x19A3E20 Offset: 0x19A2420 VA: 0x1819A3E20
	private static void AddDirectionalLightInternal_Injected(ref SphericalHarmonicsL2 sh, ref Vector3 direction, ref Color color) { }

}

