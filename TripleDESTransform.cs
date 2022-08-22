internal class TripleDESTransform : SymmetricTransform // TypeDefIndex: 1013
{	// Fields
	private DESTransform E1; // 0x58
	private DESTransform D2; // 0x60
	private DESTransform E3; // 0x68
	private DESTransform D1; // 0x70
	private DESTransform E2; // 0x78
	private DESTransform D3; // 0x80

	// Methods

	// RVA: 0x17C5FA0 Offset: 0x17C45A0 VA: 0x1817C5FA0
	public void .ctor(TripleDES algo, bool encryption, byte[] key, byte[] iv) { }

	// RVA: 0x17C5990 Offset: 0x17C3F90 VA: 0x1817C5990 Slot: 15
	protected override void ECB(byte[] input, byte[] output) { }

	// RVA: 0x17C5B10 Offset: 0x17C4110 VA: 0x1817C5B10
	internal static byte[] GetStrongKey() { }

}

