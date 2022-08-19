internal class RC2Transform : SymmetricTransform // TypeDefIndex: 1007
{	// Fields
	private ushort R0; // 0x58
	private ushort R1; // 0x5A
	private ushort R2; // 0x5C
	private ushort R3; // 0x5E
	private ushort[] K; // 0x60
	private int j; // 0x68
	private static readonly byte[] pitable; // 0x0

	// Methods

	// RVA: 0x17060B0 Offset: 0x17046B0 VA: 0x1817060B0
	public void .ctor(RC2 rc2Algo, bool encryption, byte[] key, byte[] iv) { }

	// RVA: 0x1705250 Offset: 0x1703850 VA: 0x181705250 Slot: 15
	protected override void ECB(byte[] input, byte[] output) { }

	// RVA: 0x1706040 Offset: 0x1704640 VA: 0x181706040
	private static void .cctor() { }

}

