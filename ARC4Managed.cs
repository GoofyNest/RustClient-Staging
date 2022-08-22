internal class ARC4Managed : RC4, ICryptoTransform, IDisposable // TypeDefIndex: 63
{	// Fields
	private byte[] key; // 0x48
	private byte[] state; // 0x50
	private byte x; // 0x58
	private byte y; // 0x59
	private bool m_disposed; // 0x5A

	// Properties
	public override byte[] Key { get; set; }
	public bool CanTransformMultipleBlocks { get; }
	public int InputBlockSize { get; }
	public int OutputBlockSize { get; }

	// Methods

	// RVA: 0x1741C10 Offset: 0x1740210 VA: 0x181741C10
	public void .ctor() { }

	// RVA: 0x1741530 Offset: 0x173FB30 VA: 0x181741530 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1741460 Offset: 0x173FA60 VA: 0x181741460 Slot: 5
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1741D20 Offset: 0x1740320 VA: 0x181741D20 Slot: 11
	public override byte[] get_Key() { }

	// RVA: 0x1741DC0 Offset: 0x17403C0 VA: 0x181741DC0 Slot: 12
	public override void set_Key(byte[] value) { }

	// RVA: 0x1741430 Offset: 0x173FA30 VA: 0x181741430 Slot: 21
	public override ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgvIV) { }

	// RVA: 0x17413F0 Offset: 0x173F9F0 VA: 0x1817413F0 Slot: 23
	public override ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgvIV) { }

	// RVA: 0x17415D0 Offset: 0x173FBD0 VA: 0x1817415D0 Slot: 25
	public override void GenerateIV() { }

	// RVA: 0x1741620 Offset: 0x173FC20 VA: 0x181741620 Slot: 24
	public override void GenerateKey() { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 28
	public bool get_CanTransformMultipleBlocks() { }

	// RVA: 0x5B1870 Offset: 0x5AFE70 VA: 0x1805B1870 Slot: 26
	public int get_InputBlockSize() { }

	// RVA: 0x5B1870 Offset: 0x5AFE70 VA: 0x1805B1870 Slot: 27
	public int get_OutputBlockSize() { }

	// RVA: 0x17418A0 Offset: 0x173FEA0 VA: 0x1817418A0
	private void KeySetup(byte[] key) { }

	// RVA: 0x17412A0 Offset: 0x173F8A0 VA: 0x1817412A0
	private void CheckInput(byte[] inputBuffer, int inputOffset, int inputCount) { }

	// RVA: 0x17419F0 Offset: 0x173FFF0 VA: 0x1817419F0 Slot: 29
	public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) { }

	// RVA: 0x17416B0 Offset: 0x173FCB0 VA: 0x1817416B0
	private int InternalTransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) { }

	// RVA: 0x1741B50 Offset: 0x1740150 VA: 0x181741B50 Slot: 30
	public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount) { }

}

