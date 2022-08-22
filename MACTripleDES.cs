public class MACTripleDES : KeyedHashAlgorithm // TypeDefIndex: 969
{	// Fields
	private ICryptoTransform m_encryptor; // 0x30
	private CryptoStream _cs; // 0x38
	private TailStream _ts; // 0x40
	private int m_bytesPerBlock; // 0x48
	private TripleDES des; // 0x50

	// Methods

	// RVA: 0x1703220 Offset: 0x1701820 VA: 0x181703220
	public void .ctor() { }

	// RVA: 0x817380 Offset: 0x815980 VA: 0x180817380 Slot: 16
	public override void Initialize() { }

	// RVA: 0x1702F00 Offset: 0x1701500 VA: 0x181702F00 Slot: 17
	protected override void HashCore(byte[] rgbData, int ibStart, int cbSize) { }

	// RVA: 0x17030A0 Offset: 0x17016A0 VA: 0x1817030A0 Slot: 18
	protected override byte[] HashFinal() { }

	// RVA: 0x1702E60 Offset: 0x1701460 VA: 0x181702E60 Slot: 15
	protected override void Dispose(bool disposing) { }

}

