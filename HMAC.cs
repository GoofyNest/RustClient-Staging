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

	// RVA: 0xA38FA0 Offset: 0xA375A0 VA: 0x180A38FA0
	protected int get_BlockSizeValue() { }

	// RVA: 0xA39560 Offset: 0xA37B60 VA: 0x180A39560
	protected void set_BlockSizeValue(int value) { }

	// RVA: 0x1701E60 Offset: 0x1700460 VA: 0x181701E60
	private void UpdateIOPadBuffers() { }

	// RVA: 0x1701C30 Offset: 0x1700230 VA: 0x181701C30
	internal void InitializeKey(byte[] key) { }

	// RVA: 0x1702030 Offset: 0x1700630 VA: 0x181702030 Slot: 19
	public override byte[] get_Key() { }

	// RVA: 0x17020B0 Offset: 0x17006B0 VA: 0x1817020B0 Slot: 20
	public override void set_Key(byte[] value) { }

	// RVA: 0x1701900 Offset: 0x16FFF00 VA: 0x181701900
	public static HMAC Create() { }

	// RVA: 0x1701E10 Offset: 0x1700410 VA: 0x181701E10 Slot: 16
	public override void Initialize() { }

	// RVA: 0x1701A00 Offset: 0x1700000 VA: 0x181701A00 Slot: 17
	protected override void HashCore(byte[] rgb, int ib, int cb) { }

	// RVA: 0x1701AB0 Offset: 0x17000B0 VA: 0x181701AB0 Slot: 18
	protected override byte[] HashFinal() { }

	// RVA: 0x1701950 Offset: 0x16FFF50 VA: 0x181701950 Slot: 15
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1702020 Offset: 0x1700620 VA: 0x181702020
	protected void .ctor() { }

}

