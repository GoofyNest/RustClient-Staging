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

	// RVA: 0xA39490 Offset: 0xA37A90 VA: 0x180A39490
	protected int get_BlockSizeValue() { }

	// RVA: 0xA39A50 Offset: 0xA38050 VA: 0x180A39A50
	protected void set_BlockSizeValue(int value) { }

	// RVA: 0x16FFA50 Offset: 0x16FE050 VA: 0x1816FFA50
	private void UpdateIOPadBuffers() { }

	// RVA: 0x16FF820 Offset: 0x16FDE20 VA: 0x1816FF820
	internal void InitializeKey(byte[] key) { }

	// RVA: 0x16FFC20 Offset: 0x16FE220 VA: 0x1816FFC20 Slot: 19
	public override byte[] get_Key() { }

	// RVA: 0x16FFCA0 Offset: 0x16FE2A0 VA: 0x1816FFCA0 Slot: 20
	public override void set_Key(byte[] value) { }

	// RVA: 0x16FF4F0 Offset: 0x16FDAF0 VA: 0x1816FF4F0
	public static HMAC Create() { }

	// RVA: 0x16FFA00 Offset: 0x16FE000 VA: 0x1816FFA00 Slot: 16
	public override void Initialize() { }

	// RVA: 0x16FF5F0 Offset: 0x16FDBF0 VA: 0x1816FF5F0 Slot: 17
	protected override void HashCore(byte[] rgb, int ib, int cb) { }

	// RVA: 0x16FF6A0 Offset: 0x16FDCA0 VA: 0x1816FF6A0 Slot: 18
	protected override byte[] HashFinal() { }

	// RVA: 0x16FF540 Offset: 0x16FDB40 VA: 0x1816FF540 Slot: 15
	protected override void Dispose(bool disposing) { }

	// RVA: 0x16FFC10 Offset: 0x16FE210 VA: 0x1816FFC10
	protected void .ctor() { }

}

