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

	// RVA: 0x17C5E20 Offset: 0x17C4420 VA: 0x1817C5E20
	protected void .ctor() { }

	// RVA: 0x17C5D20 Offset: 0x17C4320 VA: 0x1817C5D20 Slot: 4
	public void Dispose() { }

	// RVA: 0x17C5B30 Offset: 0x17C4130 VA: 0x1817C5B30
	public void Clear() { }

	// RVA: 0x17C5CB0 Offset: 0x17C42B0 VA: 0x1817C5CB0 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00 Slot: 6
	public virtual int get_BlockSize() { }

	// RVA: 0x17C6010 Offset: 0x17C4610 VA: 0x1817C6010 Slot: 7
	public virtual void set_BlockSize(int value) { }

	// RVA: 0x57C9D0 Offset: 0x57AFD0 VA: 0x18057C9D0 Slot: 8
	public virtual int get_FeedbackSize() { }

	// RVA: 0x17C5E50 Offset: 0x17C4450 VA: 0x1817C5E50 Slot: 9
	public virtual byte[] get_IV() { }

	// RVA: 0x17C6140 Offset: 0x17C4740 VA: 0x1817C6140 Slot: 10
	public virtual void set_IV(byte[] value) { }

	// RVA: 0x17C5EF0 Offset: 0x17C44F0 VA: 0x1817C5EF0 Slot: 11
	public virtual byte[] get_Key() { }

	// RVA: 0x17C62F0 Offset: 0x17C48F0 VA: 0x1817C62F0 Slot: 12
	public virtual void set_Key(byte[] value) { }

	// RVA: 0x17C5F90 Offset: 0x17C4590 VA: 0x1817C5F90 Slot: 13
	public virtual KeySizes[] get_LegalKeySizes() { }

	// RVA: 0x6BBA50 Offset: 0x6BA050 VA: 0x1806BBA50 Slot: 14
	public virtual int get_KeySize() { }

	// RVA: 0x17C6250 Offset: 0x17C4850 VA: 0x1817C6250 Slot: 15
	public virtual void set_KeySize(int value) { }

	// RVA: 0x5E2F50 Offset: 0x5E1550 VA: 0x1805E2F50 Slot: 16
	public virtual CipherMode get_Mode() { }

	// RVA: 0x17C6420 Offset: 0x17C4A20 VA: 0x1817C6420 Slot: 17
	public virtual void set_Mode(CipherMode value) { }

	// RVA: 0x5DE440 Offset: 0x5DCA40 VA: 0x1805DE440 Slot: 18
	public virtual PaddingMode get_Padding() { }

	// RVA: 0x17C64A0 Offset: 0x17C4AA0 VA: 0x1817C64A0 Slot: 19
	public virtual void set_Padding(PaddingMode value) { }

	// RVA: 0x17C5D90 Offset: 0x17C4390 VA: 0x1817C5D90
	public bool ValidKeySize(int bitLength) { }

	// RVA: 0x17C5C30 Offset: 0x17C4230 VA: 0x1817C5C30
	public static SymmetricAlgorithm Create(string algName) { }

	// RVA: 0x17C5BD0 Offset: 0x17C41D0 VA: 0x1817C5BD0 Slot: 20
	public virtual ICryptoTransform CreateEncryptor() { }

	// RVA: -1 Offset: -1 Slot: 21
	public abstract ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV);

	// RVA: 0x17C5B70 Offset: 0x17C4170 VA: 0x1817C5B70 Slot: 22
	public virtual ICryptoTransform CreateDecryptor() { }

	// RVA: -1 Offset: -1 Slot: 23
	public abstract ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV);

	// RVA: -1 Offset: -1 Slot: 24
	public abstract void GenerateKey();

	// RVA: -1 Offset: -1 Slot: 25
	public abstract void GenerateIV();

}

