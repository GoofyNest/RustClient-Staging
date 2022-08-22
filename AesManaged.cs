public sealed class AesManaged : Aes // TypeDefIndex: 3194
{	// Fields
	private RijndaelManaged m_rijndael; // 0x48

	// Properties
	public override int FeedbackSize { get; }
	public override byte[] IV { get; set; }
	public override byte[] Key { get; set; }
	public override int KeySize { get; set; }
	public override CipherMode Mode { get; set; }
	public override PaddingMode Padding { get; set; }

	// Methods

	// RVA: 0x22212E0 Offset: 0x221F8E0 VA: 0x1822212E0
	public void .ctor() { }

	// RVA: 0x2221430 Offset: 0x221FA30 VA: 0x182221430 Slot: 8
	public override int get_FeedbackSize() { }

	// RVA: 0x2221460 Offset: 0x221FA60 VA: 0x182221460 Slot: 9
	public override byte[] get_IV() { }

	// RVA: 0x2221550 Offset: 0x221FB50 VA: 0x182221550 Slot: 10
	public override void set_IV(byte[] value) { }

	// RVA: 0x22214C0 Offset: 0x221FAC0 VA: 0x1822214C0 Slot: 11
	public override byte[] get_Key() { }

	// RVA: 0x22215B0 Offset: 0x221FBB0 VA: 0x1822215B0 Slot: 12
	public override void set_Key(byte[] value) { }

	// RVA: 0x2221490 Offset: 0x221FA90 VA: 0x182221490 Slot: 14
	public override int get_KeySize() { }

	// RVA: 0x2221580 Offset: 0x221FB80 VA: 0x182221580 Slot: 15
	public override void set_KeySize(int value) { }

	// RVA: 0x22214F0 Offset: 0x221FAF0 VA: 0x1822214F0 Slot: 16
	public override CipherMode get_Mode() { }

	// RVA: 0x22215E0 Offset: 0x221FBE0 VA: 0x1822215E0 Slot: 17
	public override void set_Mode(CipherMode value) { }

	// RVA: 0x2221520 Offset: 0x221FB20 VA: 0x182221520 Slot: 18
	public override PaddingMode get_Padding() { }

	// RVA: 0x2221680 Offset: 0x221FC80 VA: 0x182221680 Slot: 19
	public override void set_Padding(PaddingMode value) { }

	// RVA: 0x2220EB0 Offset: 0x221F4B0 VA: 0x182220EB0 Slot: 22
	public override ICryptoTransform CreateDecryptor() { }

	// RVA: 0x2220EE0 Offset: 0x221F4E0 VA: 0x182220EE0 Slot: 23
	public override ICryptoTransform CreateDecryptor(byte[] key, byte[] iv) { }

	// RVA: 0x2221040 Offset: 0x221F640 VA: 0x182221040 Slot: 20
	public override ICryptoTransform CreateEncryptor() { }

	// RVA: 0x2221070 Offset: 0x221F670 VA: 0x182221070 Slot: 21
	public override ICryptoTransform CreateEncryptor(byte[] key, byte[] iv) { }

	// RVA: 0x22211D0 Offset: 0x221F7D0 VA: 0x1822211D0 Slot: 5
	protected override void Dispose(bool disposing) { }

	// RVA: 0x146D420 Offset: 0x146BA20 VA: 0x18146D420 Slot: 25
	public override void GenerateIV() { }

	// RVA: 0x22212B0 Offset: 0x221F8B0 VA: 0x1822212B0 Slot: 24
	public override void GenerateKey() { }

}

