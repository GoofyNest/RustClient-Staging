internal class TripleDESTransform : SymmetricTransform // TypeDefIndex: 1013
{	// Fields
	private DESTransform E1; // 0x58
	private DESTransform D2; // 0x60
	private DESTransform E3; // 0x68
	private DESTransform D1; // 0x70
	private DESTransform E2; // 0x78
	private DESTransform D3; // 0x80

	// Methods

	// RVA: 0x17C8190 Offset: 0x17C6790 VA: 0x1817C8190
	public void .ctor(TripleDES algo, bool encryption, byte[] key, byte[] iv) { }

	// RVA: 0x17C7B80 Offset: 0x17C6180 VA: 0x1817C7B80 Slot: 15
	protected override void ECB(byte[] input, byte[] output) { }

	// RVA: 0x17C7D00 Offset: 0x17C6300 VA: 0x1817C7D00
	internal static byte[] GetStrongKey() { }

}

