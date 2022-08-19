public struct FixedSByteNorm4 // TypeDefIndex: 11419
{	// Fields
	private const int FracBits = 7;
	private const float MaxFrac = 128;
	private const float RcpMaxFrac = 0,0078125;
	public sbyte x; // 0x0
	public sbyte y; // 0x1
	public sbyte z; // 0x2
	public sbyte w; // 0x3

	// Methods

	// RVA: 0xF54F0 Offset: 0xF48F0 VA: 0x1800F54F0
	public void .ctor(Vector4 vec) { }

	// RVA: 0x78DD00 Offset: 0x78C300 VA: 0x18078DD00
	public static Vector4 op_Explicit(FixedSByteNorm4 vec) { }

}

