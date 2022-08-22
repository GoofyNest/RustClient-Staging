public class MACTripleDES : KeyedHashAlgorithm // TypeDefIndex: 969
{	// Fields
	private ICryptoTransform m_encryptor; // 0x30
	private CryptoStream _cs; // 0x38
	private TailStream _ts; // 0x40
	private int m_bytesPerBlock; // 0x48
	private TripleDES des; // 0x50

	// Methods

	// RVA: 0x1700E10 Offset: 0x16FF410 VA: 0x181700E10
	public void .ctor() { }

	// RVA: 0x817910 Offset: 0x815F10 VA: 0x180817910 Slot: 16
	public override void Initialize() { }

	// RVA: 0x1700AF0 Offset: 0x16FF0F0 VA: 0x181700AF0 Slot: 17
	protected override void HashCore(byte[] rgbData, int ibStart, int cbSize) { }

	// RVA: 0x1700C90 Offset: 0x16FF290 VA: 0x181700C90 Slot: 18
	protected override byte[] HashFinal() { }

	// RVA: 0x1700A50 Offset: 0x16FF050 VA: 0x181700A50 Slot: 15
	protected override void Dispose(bool disposing) { }

}

