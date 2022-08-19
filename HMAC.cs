public abstract class HMAC : KeyedHashAlgorithm // TypeDefIndex: 960
{	// Fields
	private int blockSizeValue; // 0x30
	internal string m_hashName; // 0x38
	internal HashAlgorithm m_hash1; // 0x40
	internal HashAlgorithm m_hash2; // 0x48
	private byte[] m_inner; // 0x50
	private byte[] m_outer; // 0x58
	private bool m_hashing; // 0x60

	// Properties
	protected int BlockSizeValue { get; set; }
	public override byte[] Key { get; set; }

	// Methods

	// RVA: 0xA38CE0 Offset: 0xA372E0 VA: 0x180A38CE0
	protected int get_BlockSizeValue() { }

	// RVA: 0xA392A0 Offset: 0xA378A0 VA: 0x180A392A0
	protected void set_BlockSizeValue(int value) { }

	// RVA: 0x1701BA0 Offset: 0x17001A0 VA: 0x181701BA0
	private void UpdateIOPadBuffers() { }

	// RVA: 0x1701970 Offset: 0x16FFF70 VA: 0x181701970
	internal void InitializeKey(byte[] key) { }

	// RVA: 0x1701D70 Offset: 0x1700370 VA: 0x181701D70 Slot: 19
	public override byte[] get_Key() { }

	// RVA: 0x1701DF0 Offset: 0x17003F0 VA: 0x181701DF0 Slot: 20
	public override void set_Key(byte[] value) { }

	// RVA: 0x1701640 Offset: 0x16FFC40 VA: 0x181701640
	public static HMAC Create() { }

	// RVA: 0x1701B50 Offset: 0x1700150 VA: 0x181701B50 Slot: 16
	public override void Initialize() { }

	// RVA: 0x1701740 Offset: 0x16FFD40 VA: 0x181701740 Slot: 17
	protected override void HashCore(byte[] rgb, int ib, int cb) { }

	// RVA: 0x17017F0 Offset: 0x16FFDF0 VA: 0x1817017F0 Slot: 18
	protected override byte[] HashFinal() { }

	// RVA: 0x1701690 Offset: 0x16FFC90 VA: 0x181701690 Slot: 15
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1701D60 Offset: 0x1700360 VA: 0x181701D60
	protected void .ctor() { }

}

