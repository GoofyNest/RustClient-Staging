public abstract class HashAlgorithm : IDisposable, ICryptoTransform // TypeDefIndex: 959
{	// Fields
	protected int HashSizeValue; // 0x10
	protected internal byte[] HashValue; // 0x18
	protected int State; // 0x20
	private bool m_bDisposed; // 0x24

	// Properties
	public virtual int HashSize { get; }
	public virtual byte[] Hash { get; }
	public virtual int InputBlockSize { get; }
	public virtual int OutputBlockSize { get; }
	public virtual bool CanTransformMultipleBlocks { get; }

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

	// RVA: 0x36BA00 Offset: 0x36A000 VA: 0x18036BA00 Slot: 10
	public virtual int get_HashSize() { }

	// RVA: 0x1702A60 Offset: 0x1701060 VA: 0x181702A60 Slot: 11
	public virtual byte[] get_Hash() { }

	// RVA: 0x1702180 Offset: 0x1700780 VA: 0x181702180
	public byte[] ComputeHash(byte[] buffer) { }

	// RVA: 0x17022D0 Offset: 0x17008D0 VA: 0x1817022D0
	public byte[] ComputeHash(byte[] buffer, int offset, int count) { }

	// RVA: 0x5B18E0 Offset: 0x5AFEE0 VA: 0x1805B18E0 Slot: 12
	public virtual int get_InputBlockSize() { }

	// RVA: 0x5B18E0 Offset: 0x5AFEE0 VA: 0x1805B18E0 Slot: 13
	public virtual int get_OutputBlockSize() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 14
	public virtual bool get_CanTransformMultipleBlocks() { }

	// RVA: 0x17025E0 Offset: 0x1700BE0 VA: 0x1817025E0 Slot: 8
	public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) { }

	// RVA: 0x17027F0 Offset: 0x1700DF0 VA: 0x1817027F0 Slot: 9
	public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount) { }

	// RVA: 0x1702570 Offset: 0x1700B70 VA: 0x181702570 Slot: 4
	public void Dispose() { }

	// RVA: 0x1702140 Offset: 0x1700740 VA: 0x181702140
	public void Clear() { }

	// RVA: 0x1702520 Offset: 0x1700B20 VA: 0x181702520 Slot: 15
	protected virtual void Dispose(bool disposing) { }

	// RVA: -1 Offset: -1 Slot: 16
	public abstract void Initialize();

	// RVA: -1 Offset: -1 Slot: 17
	protected abstract void HashCore(byte[] array, int ibStart, int cbSize);

	// RVA: -1 Offset: -1 Slot: 18
	protected abstract byte[] HashFinal();

}

