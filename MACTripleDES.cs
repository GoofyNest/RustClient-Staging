public class MACTripleDES : KeyedHashAlgorithm // TypeDefIndex: 969
{	// Fields
	private ICryptoTransform m_encryptor; // 0x30
	private CryptoStream _cs; // 0x38
	private TailStream _ts; // 0x40
	private int m_bytesPerBlock; // 0x48
	private TripleDES des; // 0x50

	// Methods

	// RVA: 0x1702F60 Offset: 0x1701560 VA: 0x181702F60
	public void .ctor() { }

	// RVA: 0x817270 Offset: 0x815870 VA: 0x180817270 Slot: 16
	public override void Initialize() { }

	// RVA: 0x1702C40 Offset: 0x1701240 VA: 0x181702C40 Slot: 17
	protected override void HashCore(byte[] rgbData, int ibStart, int cbSize) { }

	// RVA: 0x1702DE0 Offset: 0x17013E0 VA: 0x181702DE0 Slot: 18
	protected override byte[] HashFinal() { }

	// RVA: 0x1702BA0 Offset: 0x17011A0 VA: 0x181702BA0 Slot: 15
	protected override void Dispose(bool disposing) { }

}

