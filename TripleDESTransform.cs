internal class TripleDESTransform : SymmetricTransform // TypeDefIndex: 1013
{	// Fields
	private DESTransform E1; // 0x58
	private DESTransform D2; // 0x60
	private DESTransform E3; // 0x68
	private DESTransform D1; // 0x70
	private DESTransform E2; // 0x78
	private DESTransform D3; // 0x80

	// Methods

	// RVA: 0x17C8450 Offset: 0x17C6A50 VA: 0x1817C8450
	public void .ctor(TripleDES algo, bool encryption, byte[] key, byte[] iv) { }

	// RVA: 0x17C7E40 Offset: 0x17C6440 VA: 0x1817C7E40 Slot: 15
	protected override void ECB(byte[] input, byte[] output) { }

	// RVA: 0x17C7FC0 Offset: 0x17C65C0 VA: 0x1817C7FC0
	internal static byte[] GetStrongKey() { }

}

