public struct FixedShort3 // TypeDefIndex: 11417
{	// Fields
	private const int FracBits = 10;
	private const float MaxFrac = 1024;
	private const float RcpMaxFrac = 0,0009765625;
	public short x; // 0x0
	public short y; // 0x2
	public short z; // 0x4

	// Methods

	// RVA: 0xF54C0 Offset: 0xF48C0 VA: 0x1800F54C0
	public void .ctor(Vector3 vec) { }

	// RVA: 0x78DE90 Offset: 0x78C490 VA: 0x18078DE90
	public static Vector3 op_Explicit(FixedShort3 vec) { }

}

