public struct FixedSByteNorm3 // TypeDefIndex: 11418
{	// Fields
	private const int FracBits = 7;
	private const float MaxFrac = 128;
	private const float RcpMaxFrac = 0,0078125;
	public sbyte x; // 0x0
	public sbyte y; // 0x1
	public sbyte z; // 0x2

	// Methods

	// RVA: 0xF5490 Offset: 0xF4890 VA: 0x1800F5490
	public void .ctor(Vector3 vec) { }

	// RVA: 0x78DC90 Offset: 0x78C290 VA: 0x18078DC90
	public static Vector3 op_Explicit(FixedSByteNorm3 vec) { }

}
