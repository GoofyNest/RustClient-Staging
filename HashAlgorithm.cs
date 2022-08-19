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

	// RVA: 0x17027A0 Offset: 0x1700DA0 VA: 0x1817027A0 Slot: 11
	public virtual byte[] get_Hash() { }

	// RVA: 0x1701EC0 Offset: 0x17004C0 VA: 0x181701EC0
	public byte[] ComputeHash(byte[] buffer) { }

	// RVA: 0x1702010 Offset: 0x1700610 VA: 0x181702010
	public byte[] ComputeHash(byte[] buffer, int offset, int count) { }

	// RVA: 0x5B18E0 Offset: 0x5AFEE0 VA: 0x1805B18E0 Slot: 12
	public virtual int get_InputBlockSize() { }

	// RVA: 0x5B18E0 Offset: 0x5AFEE0 VA: 0x1805B18E0 Slot: 13
	public virtual int get_OutputBlockSize() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 14
	public virtual bool get_CanTransformMultipleBlocks() { }

	// RVA: 0x1702320 Offset: 0x1700920 VA: 0x181702320 Slot: 8
	public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) { }

	// RVA: 0x1702530 Offset: 0x1700B30 VA: 0x181702530 Slot: 9
	public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount) { }

	// RVA: 0x17022B0 Offset: 0x17008B0 VA: 0x1817022B0 Slot: 4
	public void Dispose() { }

	// RVA: 0x1701E80 Offset: 0x1700480 VA: 0x181701E80
	public void Clear() { }

	// RVA: 0x1702260 Offset: 0x1700860 VA: 0x181702260 Slot: 15
	protected virtual void Dispose(bool disposing) { }

	// RVA: -1 Offset: -1 Slot: 16
	public abstract void Initialize();

	// RVA: -1 Offset: -1 Slot: 17
	protected abstract void HashCore(byte[] array, int ibStart, int cbSize);

	// RVA: -1 Offset: -1 Slot: 18
	protected abstract byte[] HashFinal();

}

