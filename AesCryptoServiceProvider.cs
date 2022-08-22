public sealed class AesCryptoServiceProvider : Aes // TypeDefIndex: 3195
{	// Properties
	public override byte[] IV { get; set; }
	public override byte[] Key { get; set; }
	public override int KeySize { get; set; }
	public override int FeedbackSize { get; }
	public override CipherMode Mode { get; set; }
	public override PaddingMode Padding { get; set; }

	// Methods

	// RVA: 0x2220D70 Offset: 0x221F370 VA: 0x182220D70
	public void .ctor() { }

	// RVA: 0x2220D10 Offset: 0x221F310 VA: 0x182220D10 Slot: 25
	public override void GenerateIV() { }

	// RVA: 0x2220D40 Offset: 0x221F340 VA: 0x182220D40 Slot: 24
	public override void GenerateKey() { }

	// RVA: 0x2220B40 Offset: 0x221F140 VA: 0x182220B40 Slot: 23
	public override ICryptoTransform CreateDecryptor(byte[] key, byte[] iv) { }

	// RVA: 0x2220C20 Offset: 0x221F220 VA: 0x182220C20 Slot: 21
	public override ICryptoTransform CreateEncryptor(byte[] key, byte[] iv) { }

	// RVA: 0x2220DD0 Offset: 0x221F3D0 VA: 0x182220DD0 Slot: 9
	public override byte[] get_IV() { }

	// RVA: 0x2220DF0 Offset: 0x221F3F0 VA: 0x182220DF0 Slot: 10
	public override void set_IV(byte[] value) { }

	// RVA: 0x2220DE0 Offset: 0x221F3E0 VA: 0x182220DE0 Slot: 11
	public override byte[] get_Key() { }

	// RVA: 0x2220E10 Offset: 0x221F410 VA: 0x182220E10 Slot: 12
	public override void set_Key(byte[] value) { }

	// RVA: 0x6BB940 Offset: 0x6B9F40 VA: 0x1806BB940 Slot: 14
	public override int get_KeySize() { }

	// RVA: 0x2220E00 Offset: 0x221F400 VA: 0x182220E00 Slot: 15
	public override void set_KeySize(int value) { }

	// RVA: 0x57C9D0 Offset: 0x57AFD0 VA: 0x18057C9D0 Slot: 8
	public override int get_FeedbackSize() { }

	// RVA: 0x5E2F50 Offset: 0x5E1550 VA: 0x1805E2F50 Slot: 16
	public override CipherMode get_Mode() { }

	// RVA: 0x2220E20 Offset: 0x221F420 VA: 0x182220E20 Slot: 17
	public override void set_Mode(CipherMode value) { }

	// RVA: 0x5DE440 Offset: 0x5DCA40 VA: 0x1805DE440 Slot: 18
	public override PaddingMode get_Padding() { }

	// RVA: 0x2220EA0 Offset: 0x221F4A0 VA: 0x182220EA0 Slot: 19
	public override void set_Padding(PaddingMode value) { }

	// RVA: 0x17C58B0 Offset: 0x17C3EB0 VA: 0x1817C58B0 Slot: 22
	public override ICryptoTransform CreateDecryptor() { }

	// RVA: 0x17C5910 Offset: 0x17C3F10 VA: 0x1817C5910 Slot: 20
	public override ICryptoTransform CreateEncryptor() { }

	// RVA: 0x2220D00 Offset: 0x221F300 VA: 0x182220D00 Slot: 5
	protected override void Dispose(bool disposing) { }

}

