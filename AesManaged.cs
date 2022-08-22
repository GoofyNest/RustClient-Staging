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

	// RVA: 0x2221DC0 Offset: 0x22203C0 VA: 0x182221DC0
	public void .ctor() { }

	// RVA: 0x2221F10 Offset: 0x2220510 VA: 0x182221F10 Slot: 8
	public override int get_FeedbackSize() { }

	// RVA: 0x2221F40 Offset: 0x2220540 VA: 0x182221F40 Slot: 9
	public override byte[] get_IV() { }

	// RVA: 0x2222030 Offset: 0x2220630 VA: 0x182222030 Slot: 10
	public override void set_IV(byte[] value) { }

	// RVA: 0x2221FA0 Offset: 0x22205A0 VA: 0x182221FA0 Slot: 11
	public override byte[] get_Key() { }

	// RVA: 0x2222090 Offset: 0x2220690 VA: 0x182222090 Slot: 12
	public override void set_Key(byte[] value) { }

	// RVA: 0x2221F70 Offset: 0x2220570 VA: 0x182221F70 Slot: 14
	public override int get_KeySize() { }

	// RVA: 0x2222060 Offset: 0x2220660 VA: 0x182222060 Slot: 15
	public override void set_KeySize(int value) { }

	// RVA: 0x2221FD0 Offset: 0x22205D0 VA: 0x182221FD0 Slot: 16
	public override CipherMode get_Mode() { }

	// RVA: 0x22220C0 Offset: 0x22206C0 VA: 0x1822220C0 Slot: 17
	public override void set_Mode(CipherMode value) { }

	// RVA: 0x2222000 Offset: 0x2220600 VA: 0x182222000 Slot: 18
	public override PaddingMode get_Padding() { }

	// RVA: 0x2222160 Offset: 0x2220760 VA: 0x182222160 Slot: 19
	public override void set_Padding(PaddingMode value) { }

	// RVA: 0x2221990 Offset: 0x221FF90 VA: 0x182221990 Slot: 22
	public override ICryptoTransform CreateDecryptor() { }

	// RVA: 0x22219C0 Offset: 0x221FFC0 VA: 0x1822219C0 Slot: 23
	public override ICryptoTransform CreateDecryptor(byte[] key, byte[] iv) { }

	// RVA: 0x2221B20 Offset: 0x2220120 VA: 0x182221B20 Slot: 20
	public override ICryptoTransform CreateEncryptor() { }

	// RVA: 0x2221B50 Offset: 0x2220150 VA: 0x182221B50 Slot: 21
	public override ICryptoTransform CreateEncryptor(byte[] key, byte[] iv) { }

	// RVA: 0x2221CB0 Offset: 0x22202B0 VA: 0x182221CB0 Slot: 5
	protected override void Dispose(bool disposing) { }

	// RVA: 0x146C7B0 Offset: 0x146ADB0 VA: 0x18146C7B0 Slot: 25
	public override void GenerateIV() { }

	// RVA: 0x2221D90 Offset: 0x2220390 VA: 0x182221D90 Slot: 24
	public override void GenerateKey() { }

}

