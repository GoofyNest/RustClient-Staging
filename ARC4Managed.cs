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

	// RVA: 0x1744050 Offset: 0x1742650 VA: 0x181744050
	public void .ctor() { }

	// RVA: 0x1743970 Offset: 0x1741F70 VA: 0x181743970 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x17438A0 Offset: 0x1741EA0 VA: 0x1817438A0 Slot: 5
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1744160 Offset: 0x1742760 VA: 0x181744160 Slot: 11
	public override byte[] get_Key() { }

	// RVA: 0x1744200 Offset: 0x1742800 VA: 0x181744200 Slot: 12
	public override void set_Key(byte[] value) { }

	// RVA: 0x1743870 Offset: 0x1741E70 VA: 0x181743870 Slot: 21
	public override ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgvIV) { }

	// RVA: 0x1743830 Offset: 0x1741E30 VA: 0x181743830 Slot: 23
	public override ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgvIV) { }

	// RVA: 0x1743A10 Offset: 0x1742010 VA: 0x181743A10 Slot: 25
	public override void GenerateIV() { }

	// RVA: 0x1743A60 Offset: 0x1742060 VA: 0x181743A60 Slot: 24
	public override void GenerateKey() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 28
	public bool get_CanTransformMultipleBlocks() { }

	// RVA: 0x5B18E0 Offset: 0x5AFEE0 VA: 0x1805B18E0 Slot: 26
	public int get_InputBlockSize() { }

	// RVA: 0x5B18E0 Offset: 0x5AFEE0 VA: 0x1805B18E0 Slot: 27
	public int get_OutputBlockSize() { }

	// RVA: 0x1743CE0 Offset: 0x17422E0 VA: 0x181743CE0
	private void KeySetup(byte[] key) { }

	// RVA: 0x17436E0 Offset: 0x1741CE0 VA: 0x1817436E0
	private void CheckInput(byte[] inputBuffer, int inputOffset, int inputCount) { }

	// RVA: 0x1743E30 Offset: 0x1742430 VA: 0x181743E30 Slot: 29
	public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) { }

	// RVA: 0x1743AF0 Offset: 0x17420F0 VA: 0x181743AF0
	private int InternalTransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) { }

	// RVA: 0x1743F90 Offset: 0x1742590 VA: 0x181743F90 Slot: 30
	public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount) { }

}

