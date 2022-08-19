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

	// RVA: 0x1743D90 Offset: 0x1742390 VA: 0x181743D90
	public void .ctor() { }

	// RVA: 0x17436B0 Offset: 0x1741CB0 VA: 0x1817436B0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x17435E0 Offset: 0x1741BE0 VA: 0x1817435E0 Slot: 5
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1743EA0 Offset: 0x17424A0 VA: 0x181743EA0 Slot: 11
	public override byte[] get_Key() { }

	// RVA: 0x1743F40 Offset: 0x1742540 VA: 0x181743F40 Slot: 12
	public override void set_Key(byte[] value) { }

	// RVA: 0x17435B0 Offset: 0x1741BB0 VA: 0x1817435B0 Slot: 21
	public override ICryptoTransform CreateEncryptor(byte[] rgbKey, byte[] rgvIV) { }

	// RVA: 0x1743570 Offset: 0x1741B70 VA: 0x181743570 Slot: 23
	public override ICryptoTransform CreateDecryptor(byte[] rgbKey, byte[] rgvIV) { }

	// RVA: 0x1743750 Offset: 0x1741D50 VA: 0x181743750 Slot: 25
	public override void GenerateIV() { }

	// RVA: 0x17437A0 Offset: 0x1741DA0 VA: 0x1817437A0 Slot: 24
	public override void GenerateKey() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 28
	public bool get_CanTransformMultipleBlocks() { }

	// RVA: 0x5B18E0 Offset: 0x5AFEE0 VA: 0x1805B18E0 Slot: 26
	public int get_InputBlockSize() { }

	// RVA: 0x5B18E0 Offset: 0x5AFEE0 VA: 0x1805B18E0 Slot: 27
	public int get_OutputBlockSize() { }

	// RVA: 0x1743A20 Offset: 0x1742020 VA: 0x181743A20
	private void KeySetup(byte[] key) { }

	// RVA: 0x1743420 Offset: 0x1741A20 VA: 0x181743420
	private void CheckInput(byte[] inputBuffer, int inputOffset, int inputCount) { }

	// RVA: 0x1743B70 Offset: 0x1742170 VA: 0x181743B70 Slot: 29
	public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) { }

	// RVA: 0x1743830 Offset: 0x1741E30 VA: 0x181743830
	private int InternalTransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) { }

	// RVA: 0x1743CD0 Offset: 0x17422D0 VA: 0x181743CD0 Slot: 30
	public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount) { }

}

