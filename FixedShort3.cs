public struct FixedShort3 // TypeDefIndex: 11417
{	// Fields
	private const int FracBits = 10;
	private const float MaxFrac = 1024;
	private const float RcpMaxFrac = 0,0009765625;
	public short x; // 0x0
	public short y; // 0x2
	public short z; // 0x4

	// Methods

	// RVA: 0xF5540 Offset: 0xF4940 VA: 0x1800F5540
	public void .ctor(Vector3 vec) { }

	// RVA: 0x78DD80 Offset: 0x78C380 VA: 0x18078DD80
	public static Vector3 op_Explicit(FixedShort3 vec) { }

}
