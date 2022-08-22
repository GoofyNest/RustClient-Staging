public sealed class AesCryptoServiceProvider : Aes // TypeDefIndex: 3195
{	// Properties
	public override byte[] IV { get; set; }
	public override byte[] Key { get; set; }
	public override int KeySize { get; set; }
	public override int FeedbackSize { get; }
	public override CipherMode Mode { get; set; }
	public override PaddingMode Padding { get; set; }

	// Methods

	// RVA: 0x2221030 Offset: 0x221F630 VA: 0x182221030
	public void .ctor() { }

	// RVA: 0x2220FD0 Offset: 0x221F5D0 VA: 0x182220FD0 Slot: 25
	public override void GenerateIV() { }

	// RVA: 0x2221000 Offset: 0x221F600 VA: 0x182221000 Slot: 24
	public override void GenerateKey() { }

	// RVA: 0x2220E00 Offset: 0x221F400 VA: 0x182220E00 Slot: 23
	public override ICryptoTransform CreateDecryptor(byte[] key, byte[] iv) { }

	// RVA: 0x2220EE0 Offset: 0x221F4E0 VA: 0x182220EE0 Slot: 21
	public override ICryptoTransform CreateEncryptor(byte[] key, byte[] iv) { }

	// RVA: 0x2221090 Offset: 0x221F690 VA: 0x182221090 Slot: 9
	public override byte[] get_IV() { }

	// RVA: 0x22210B0 Offset: 0x221F6B0 VA: 0x1822210B0 Slot: 10
	public override void set_IV(byte[] value) { }

	// RVA: 0x22210A0 Offset: 0x221F6A0 VA: 0x1822210A0 Slot: 11
	public override byte[] get_Key() { }

	// RVA: 0x22210D0 Offset: 0x221F6D0 VA: 0x1822210D0 Slot: 12
	public override void set_Key(byte[] value) { }

	// RVA: 0x6BBA50 Offset: 0x6BA050 VA: 0x1806BBA50 Slot: 14
	public override int get_KeySize() { }

	// RVA: 0x22210C0 Offset: 0x221F6C0 VA: 0x1822210C0 Slot: 15
	public override void set_KeySize(int value) { }

	// RVA: 0x57C9D0 Offset: 0x57AFD0 VA: 0x18057C9D0 Slot: 8
	public override int get_FeedbackSize() { }

	// RVA: 0x5E2F50 Offset: 0x5E1550 VA: 0x1805E2F50 Slot: 16
	public override CipherMode get_Mode() { }

	// RVA: 0x22210E0 Offset: 0x221F6E0 VA: 0x1822210E0 Slot: 17
	public override void set_Mode(CipherMode value) { }

	// RVA: 0x5DE440 Offset: 0x5DCA40 VA: 0x1805DE440 Slot: 18
	public override PaddingMode get_Padding() { }

	// RVA: 0x2221160 Offset: 0x221F760 VA: 0x182221160 Slot: 19
	public override void set_Padding(PaddingMode value) { }

	// RVA: 0x17C5B70 Offset: 0x17C4170 VA: 0x1817C5B70 Slot: 22
	public override ICryptoTransform CreateDecryptor() { }

	// RVA: 0x17C5BD0 Offset: 0x17C41D0 VA: 0x1817C5BD0 Slot: 20
	public override ICryptoTransform CreateEncryptor() { }

	// RVA: 0x2220FC0 Offset: 0x221F5C0 VA: 0x182220FC0 Slot: 5
	protected override void Dispose(bool disposing) { }

}

