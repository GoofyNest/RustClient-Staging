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

	// RVA: 0x22215A0 Offset: 0x221FBA0 VA: 0x1822215A0
	public void .ctor() { }

	// RVA: 0x22216F0 Offset: 0x221FCF0 VA: 0x1822216F0 Slot: 8
	public override int get_FeedbackSize() { }

	// RVA: 0x2221720 Offset: 0x221FD20 VA: 0x182221720 Slot: 9
	public override byte[] get_IV() { }

	// RVA: 0x2221810 Offset: 0x221FE10 VA: 0x182221810 Slot: 10
	public override void set_IV(byte[] value) { }

	// RVA: 0x2221780 Offset: 0x221FD80 VA: 0x182221780 Slot: 11
	public override byte[] get_Key() { }

	// RVA: 0x2221870 Offset: 0x221FE70 VA: 0x182221870 Slot: 12
	public override void set_Key(byte[] value) { }

	// RVA: 0x2221750 Offset: 0x221FD50 VA: 0x182221750 Slot: 14
	public override int get_KeySize() { }

	// RVA: 0x2221840 Offset: 0x221FE40 VA: 0x182221840 Slot: 15
	public override void set_KeySize(int value) { }

	// RVA: 0x22217B0 Offset: 0x221FDB0 VA: 0x1822217B0 Slot: 16
	public override CipherMode get_Mode() { }

	// RVA: 0x22218A0 Offset: 0x221FEA0 VA: 0x1822218A0 Slot: 17
	public override void set_Mode(CipherMode value) { }

	// RVA: 0x22217E0 Offset: 0x221FDE0 VA: 0x1822217E0 Slot: 18
	public override PaddingMode get_Padding() { }

	// RVA: 0x2221940 Offset: 0x221FF40 VA: 0x182221940 Slot: 19
	public override void set_Padding(PaddingMode value) { }

	// RVA: 0x2221170 Offset: 0x221F770 VA: 0x182221170 Slot: 22
	public override ICryptoTransform CreateDecryptor() { }

	// RVA: 0x22211A0 Offset: 0x221F7A0 VA: 0x1822211A0 Slot: 23
	public override ICryptoTransform CreateDecryptor(byte[] key, byte[] iv) { }

	// RVA: 0x2221300 Offset: 0x221F900 VA: 0x182221300 Slot: 20
	public override ICryptoTransform CreateEncryptor() { }

	// RVA: 0x2221330 Offset: 0x221F930 VA: 0x182221330 Slot: 21
	public override ICryptoTransform CreateEncryptor(byte[] key, byte[] iv) { }

	// RVA: 0x2221490 Offset: 0x221FA90 VA: 0x182221490 Slot: 5
	protected override void Dispose(bool disposing) { }

	// RVA: 0x146D6E0 Offset: 0x146BCE0 VA: 0x18146D6E0 Slot: 25
	public override void GenerateIV() { }

	// RVA: 0x2221570 Offset: 0x221FB70 VA: 0x182221570 Slot: 24
	public override void GenerateKey() { }

}

