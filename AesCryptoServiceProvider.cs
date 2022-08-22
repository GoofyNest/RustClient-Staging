public sealed class AesCryptoServiceProvider : Aes // TypeDefIndex: 3195
{	// Properties
	public override byte[] IV { get; set; }
	public override byte[] Key { get; set; }
	public override int KeySize { get; set; }
	public override int FeedbackSize { get; }
	public override CipherMode Mode { get; set; }
	public override PaddingMode Padding { get; set; }

	// Methods

	// RVA: 0x2221850 Offset: 0x221FE50 VA: 0x182221850
	public void .ctor() { }

	// RVA: 0x22217F0 Offset: 0x221FDF0 VA: 0x1822217F0 Slot: 25
	public override void GenerateIV() { }

	// RVA: 0x2221820 Offset: 0x221FE20 VA: 0x182221820 Slot: 24
	public override void GenerateKey() { }

	// RVA: 0x2221620 Offset: 0x221FC20 VA: 0x182221620 Slot: 23
	public override ICryptoTransform CreateDecryptor(byte[] key, byte[] iv) { }

	// RVA: 0x2221700 Offset: 0x221FD00 VA: 0x182221700 Slot: 21
	public override ICryptoTransform CreateEncryptor(byte[] key, byte[] iv) { }

	// RVA: 0x22218B0 Offset: 0x221FEB0 VA: 0x1822218B0 Slot: 9
	public override byte[] get_IV() { }

	// RVA: 0x22218D0 Offset: 0x221FED0 VA: 0x1822218D0 Slot: 10
	public override void set_IV(byte[] value) { }

	// RVA: 0x22218C0 Offset: 0x221FEC0 VA: 0x1822218C0 Slot: 11
	public override byte[] get_Key() { }

	// RVA: 0x22218F0 Offset: 0x221FEF0 VA: 0x1822218F0 Slot: 12
	public override void set_Key(byte[] value) { }

	// RVA: 0x6BB9E0 Offset: 0x6B9FE0 VA: 0x1806BB9E0 Slot: 14
	public override int get_KeySize() { }

	// RVA: 0x22218E0 Offset: 0x221FEE0 VA: 0x1822218E0 Slot: 15
	public override void set_KeySize(int value) { }

	// RVA: 0x57C960 Offset: 0x57AF60 VA: 0x18057C960 Slot: 8
	public override int get_FeedbackSize() { }

	// RVA: 0x5E2EE0 Offset: 0x5E14E0 VA: 0x1805E2EE0 Slot: 16
	public override CipherMode get_Mode() { }

	// RVA: 0x2221900 Offset: 0x221FF00 VA: 0x182221900 Slot: 17
	public override void set_Mode(CipherMode value) { }

	// RVA: 0x5DE3D0 Offset: 0x5DC9D0 VA: 0x1805DE3D0 Slot: 18
	public override PaddingMode get_Padding() { }

	// RVA: 0x2221980 Offset: 0x221FF80 VA: 0x182221980 Slot: 19
	public override void set_Padding(PaddingMode value) { }

	// RVA: 0x17C36C0 Offset: 0x17C1CC0 VA: 0x1817C36C0 Slot: 22
	public override ICryptoTransform CreateDecryptor() { }

	// RVA: 0x17C3720 Offset: 0x17C1D20 VA: 0x1817C3720 Slot: 20
	public override ICryptoTransform CreateEncryptor() { }

	// RVA: 0x22217E0 Offset: 0x221FDE0 VA: 0x1822217E0 Slot: 5
	protected override void Dispose(bool disposing) { }

}

