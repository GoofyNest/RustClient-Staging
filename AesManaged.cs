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

	// RVA: 0x22214A0 Offset: 0x221FAA0 VA: 0x1822214A0
	public void .ctor() { }

	// RVA: 0x22215F0 Offset: 0x221FBF0 VA: 0x1822215F0 Slot: 8
	public override int get_FeedbackSize() { }

	// RVA: 0x2221620 Offset: 0x221FC20 VA: 0x182221620 Slot: 9
	public override byte[] get_IV() { }

	// RVA: 0x2221710 Offset: 0x221FD10 VA: 0x182221710 Slot: 10
	public override void set_IV(byte[] value) { }

	// RVA: 0x2221680 Offset: 0x221FC80 VA: 0x182221680 Slot: 11
	public override byte[] get_Key() { }

	// RVA: 0x2221770 Offset: 0x221FD70 VA: 0x182221770 Slot: 12
	public override void set_Key(byte[] value) { }

	// RVA: 0x2221650 Offset: 0x221FC50 VA: 0x182221650 Slot: 14
	public override int get_KeySize() { }

	// RVA: 0x2221740 Offset: 0x221FD40 VA: 0x182221740 Slot: 15
	public override void set_KeySize(int value) { }

	// RVA: 0x22216B0 Offset: 0x221FCB0 VA: 0x1822216B0 Slot: 16
	public override CipherMode get_Mode() { }

	// RVA: 0x22217A0 Offset: 0x221FDA0 VA: 0x1822217A0 Slot: 17
	public override void set_Mode(CipherMode value) { }

	// RVA: 0x22216E0 Offset: 0x221FCE0 VA: 0x1822216E0 Slot: 18
	public override PaddingMode get_Padding() { }

	// RVA: 0x2221840 Offset: 0x221FE40 VA: 0x182221840 Slot: 19
	public override void set_Padding(PaddingMode value) { }

	// RVA: 0x2221070 Offset: 0x221F670 VA: 0x182221070 Slot: 22
	public override ICryptoTransform CreateDecryptor() { }

	// RVA: 0x22210A0 Offset: 0x221F6A0 VA: 0x1822210A0 Slot: 23
	public override ICryptoTransform CreateDecryptor(byte[] key, byte[] iv) { }

	// RVA: 0x2221200 Offset: 0x221F800 VA: 0x182221200 Slot: 20
	public override ICryptoTransform CreateEncryptor() { }

	// RVA: 0x2221230 Offset: 0x221F830 VA: 0x182221230 Slot: 21
	public override ICryptoTransform CreateEncryptor(byte[] key, byte[] iv) { }

	// RVA: 0x2221390 Offset: 0x221F990 VA: 0x182221390 Slot: 5
	protected override void Dispose(bool disposing) { }

	// RVA: 0x146D420 Offset: 0x146BA20 VA: 0x18146D420 Slot: 25
	public override void GenerateIV() { }

	// RVA: 0x2221470 Offset: 0x221FA70 VA: 0x182221470 Slot: 24
	public override void GenerateKey() { }

}

