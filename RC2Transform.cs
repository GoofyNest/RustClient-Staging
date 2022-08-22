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

	// RVA: 0x1703F60 Offset: 0x1702560 VA: 0x181703F60
	public void .ctor(RC2 rc2Algo, bool encryption, byte[] key, byte[] iv) { }

	// RVA: 0x1703100 Offset: 0x1701700 VA: 0x181703100 Slot: 15
	protected override void ECB(byte[] input, byte[] output) { }

	// RVA: 0x1703EF0 Offset: 0x17024F0 VA: 0x181703EF0
	private static void .cctor() { }

}

