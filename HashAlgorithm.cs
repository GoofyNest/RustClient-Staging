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

	// RVA: 0x1700650 Offset: 0x16FEC50 VA: 0x181700650 Slot: 11
	public virtual byte[] get_Hash() { }

	// RVA: 0x16FFD70 Offset: 0x16FE370 VA: 0x1816FFD70
	public byte[] ComputeHash(byte[] buffer) { }

	// RVA: 0x16FFEC0 Offset: 0x16FE4C0 VA: 0x1816FFEC0
	public byte[] ComputeHash(byte[] buffer, int offset, int count) { }

	// RVA: 0x5B1870 Offset: 0x5AFE70 VA: 0x1805B1870 Slot: 12
	public virtual int get_InputBlockSize() { }

	// RVA: 0x5B1870 Offset: 0x5AFE70 VA: 0x1805B1870 Slot: 13
	public virtual int get_OutputBlockSize() { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 14
	public virtual bool get_CanTransformMultipleBlocks() { }

	// RVA: 0x17001D0 Offset: 0x16FE7D0 VA: 0x1817001D0 Slot: 8
	public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) { }

	// RVA: 0x17003E0 Offset: 0x16FE9E0 VA: 0x1817003E0 Slot: 9
	public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount) { }

	// RVA: 0x1700160 Offset: 0x16FE760 VA: 0x181700160 Slot: 4
	public void Dispose() { }

	// RVA: 0x16FFD30 Offset: 0x16FE330 VA: 0x1816FFD30
	public void Clear() { }

	// RVA: 0x1700110 Offset: 0x16FE710 VA: 0x181700110 Slot: 15
	protected virtual void Dispose(bool disposing) { }

	// RVA: -1 Offset: -1 Slot: 16
	public abstract void Initialize();

	// RVA: -1 Offset: -1 Slot: 17
	protected abstract void HashCore(byte[] array, int ibStart, int cbSize);

	// RVA: -1 Offset: -1 Slot: 18
	protected abstract byte[] HashFinal();

}

