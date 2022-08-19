public abstract class SymmetricAlgorithm : IDisposable // TypeDefIndex: 999
{	// Fields
	protected int BlockSizeValue; // 0x10
	protected int FeedbackSizeValue; // 0x14
	protected byte[] IVValue; // 0x18
	protected byte[] KeyValue; // 0x20
	protected KeySizes[] LegalBlockSizesValue; // 0x28
	protected KeySizes[] LegalKeySizesValue; // 0x30
	protected int KeySizeValue; // 0x38
	protected CipherMode ModeValue; // 0x3C
	protected PaddingMode PaddingValue; // 0x40

	// Properties
	public virtual int BlockSize { get; set; }
	public virtual int FeedbackSize { get; }
	public virtual byte[] IV { get; set; }
	public virtual byte[] Key { get; set; }
	public virtual KeySizes[] LegalKeySizes { get; }
	public virtual int KeySize { get; set; }
	public virtual CipherMode Mode { get; set; }
	public virtual PaddingMode Padding { get; set; }

	// Methods

	// RVA: 0x17C5B60 Offset: 0x17C4160 VA: 0x1817C5B60
	protected void .ctor() { }

	// RVA: 0x17C5A60 Offset: 0x17C4060 VA: 0x1817C5A60 Slot: 4
	public void Dispose() { }

	// RVA: 0x17C5870 Offset: 0x17C3E70 VA: 0x1817C5870
	public void Clear() { }

	// RVA: 0x17C59F0 Offset: 0x17C3FF0 VA: 0x1817C59F0 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00 Slot: 6
	public virtual int get_BlockSize() { }

	// RVA: 0x17C5D50 Offset: 0x17C4350 VA: 0x1817C5D50 Slot: 7
	public virtual void set_BlockSize(int value) { }

	// RVA: 0x57C9D0 Offset: 0x57AFD0 VA: 0x18057C9D0 Slot: 8
	public virtual int get_FeedbackSize() { }

	// RVA: 0x17C5B90 Offset: 0x17C4190 VA: 0x1817C5B90 Slot: 9
	public virtual byte[] get_IV() { }

	// RVA: 0x17C5E80 Offset: 0x17C4480 VA: 0x1817C5E80 Slot: 10
	public virtual void set_IV(byte[] value) { }

	// RVA: 0x17C5C30 Offset: 0x17C4230 VA: 0x1817C5C30 Slot: 11
	public virtual byte[] get_Key() { }

	// RVA: 0x17C6030 Offset: 0x17C4630 VA: 0x1817C6030 Slot: 12
	public virtual void set_Key(byte[] value) { }

	// RVA: 0x17C5CD0 Offset: 0x17C42D0 VA: 0x1817C5CD0 Slot: 13
	public virtual KeySizes[] get_LegalKeySizes() { }

	// RVA: 0x6BB940 Offset: 0x6B9F40 VA: 0x1806BB940 Slot: 14
	public virtual int get_KeySize() { }

	// RVA: 0x17C5F90 Offset: 0x17C4590 VA: 0x1817C5F90 Slot: 15
	public virtual void set_KeySize(int value) { }

	// RVA: 0x5E2F50 Offset: 0x5E1550 VA: 0x1805E2F50 Slot: 16
	public virtual CipherMode get_Mode() { }

	// RVA: 0x17C6160 Offset: 0x17C4760 VA: 0x1817C6160 Slot: 17
	public virtual void set_Mode(CipherMode value) { }

	// RVA: 0x5DE440 Offset: 0x5DCA40 VA: 0x1805DE440 Slot: 18
	public virtual PaddingMode get_Padding() { }

	// RVA: 0x17C61E0 Offset: 0x17C47E0 VA: 0x1817C61E0 Slot: 19
	public virtual void set_Padding(PaddingMode value) { }

	// RVA: 0x17C5AD0 Offset: 0x17C40D0 VA: 0x1817C5AD0
	public bool ValidKeySize(int bitLength) { }

	// RVA: 0x17C5970 Offset: 0x17C3F70 VA: 0x1817C5970
	public static SymmetricAlgorithm Create(string algName) { }

	// RVA: 0x17C5910 Offset: 0x17C3F10 VA: 0x1817C5910 Slot: 20
	public virtual ICryptoTransform CreateEncryptor() { }

	// RVA: -1 Offset: -1 Slot: 21
	public abstract ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV);

	// RVA: 0x17C58B0 Offset: 0x17C3EB0 VA: 0x1817C58B0 Slot: 22
	public virtual ICryptoTransform CreateDecryptor() { }

	// RVA: -1 Offset: -1 Slot: 23
	public abstract ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV);

	// RVA: -1 Offset: -1 Slot: 24
	public abstract void GenerateKey();

	// RVA: -1 Offset: -1 Slot: 25
	public abstract void GenerateIV();

}

