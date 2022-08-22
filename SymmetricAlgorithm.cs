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

	// RVA: 0x17C3970 Offset: 0x17C1F70 VA: 0x1817C3970
	protected void .ctor() { }

	// RVA: 0x17C3870 Offset: 0x17C1E70 VA: 0x1817C3870 Slot: 4
	public void Dispose() { }

	// RVA: 0x17C3680 Offset: 0x17C1C80 VA: 0x1817C3680
	public void Clear() { }

	// RVA: 0x17C3800 Offset: 0x17C1E00 VA: 0x1817C3800 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00 Slot: 6
	public virtual int get_BlockSize() { }

	// RVA: 0x17C3B60 Offset: 0x17C2160 VA: 0x1817C3B60 Slot: 7
	public virtual void set_BlockSize(int value) { }

	// RVA: 0x57C960 Offset: 0x57AF60 VA: 0x18057C960 Slot: 8
	public virtual int get_FeedbackSize() { }

	// RVA: 0x17C39A0 Offset: 0x17C1FA0 VA: 0x1817C39A0 Slot: 9
	public virtual byte[] get_IV() { }

	// RVA: 0x17C3C90 Offset: 0x17C2290 VA: 0x1817C3C90 Slot: 10
	public virtual void set_IV(byte[] value) { }

	// RVA: 0x17C3A40 Offset: 0x17C2040 VA: 0x1817C3A40 Slot: 11
	public virtual byte[] get_Key() { }

	// RVA: 0x17C3E40 Offset: 0x17C2440 VA: 0x1817C3E40 Slot: 12
	public virtual void set_Key(byte[] value) { }

	// RVA: 0x17C3AE0 Offset: 0x17C20E0 VA: 0x1817C3AE0 Slot: 13
	public virtual KeySizes[] get_LegalKeySizes() { }

	// RVA: 0x6BB9E0 Offset: 0x6B9FE0 VA: 0x1806BB9E0 Slot: 14
	public virtual int get_KeySize() { }

	// RVA: 0x17C3DA0 Offset: 0x17C23A0 VA: 0x1817C3DA0 Slot: 15
	public virtual void set_KeySize(int value) { }

	// RVA: 0x5E2EE0 Offset: 0x5E14E0 VA: 0x1805E2EE0 Slot: 16
	public virtual CipherMode get_Mode() { }

	// RVA: 0x17C3F70 Offset: 0x17C2570 VA: 0x1817C3F70 Slot: 17
	public virtual void set_Mode(CipherMode value) { }

	// RVA: 0x5DE3D0 Offset: 0x5DC9D0 VA: 0x1805DE3D0 Slot: 18
	public virtual PaddingMode get_Padding() { }

	// RVA: 0x17C3FF0 Offset: 0x17C25F0 VA: 0x1817C3FF0 Slot: 19
	public virtual void set_Padding(PaddingMode value) { }

	// RVA: 0x17C38E0 Offset: 0x17C1EE0 VA: 0x1817C38E0
	public bool ValidKeySize(int bitLength) { }

	// RVA: 0x17C3780 Offset: 0x17C1D80 VA: 0x1817C3780
	public static SymmetricAlgorithm Create(string algName) { }

	// RVA: 0x17C3720 Offset: 0x17C1D20 VA: 0x1817C3720 Slot: 20
	public virtual ICryptoTransform CreateEncryptor() { }

	// RVA: -1 Offset: -1 Slot: 21
	public abstract ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgbIV);

	// RVA: 0x17C36C0 Offset: 0x17C1CC0 VA: 0x1817C36C0 Slot: 22
	public virtual ICryptoTransform CreateDecryptor() { }

	// RVA: -1 Offset: -1 Slot: 23
	public abstract ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgbIV);

	// RVA: -1 Offset: -1 Slot: 24
	public abstract void GenerateKey();

	// RVA: -1 Offset: -1 Slot: 25
	public abstract void GenerateIV();

}

