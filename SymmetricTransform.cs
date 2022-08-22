internal abstract class SymmetricTransform : ICryptoTransform, IDisposable // TypeDefIndex: 77
{	// Fields
	protected SymmetricAlgorithm algo; // 0x10
	protected bool encrypt; // 0x18
	protected int BlockSizeByte; // 0x1C
	protected byte[] temp; // 0x20
	protected byte[] temp2; // 0x28
	private byte[] workBuff; // 0x30
	private byte[] workout; // 0x38
	protected PaddingMode padmode; // 0x40
	protected int FeedBackByte; // 0x44
	private bool m_disposed; // 0x48
	protected bool lastBlock; // 0x49
	private RandomNumberGenerator _rng; // 0x50

	// Properties
	public virtual bool CanTransformMultipleBlocks { get; }
	public virtual int InputBlockSize { get; }
	public virtual int OutputBlockSize { get; }
	private bool KeepLastBlock { get; }

	// Methods

	// RVA: 0x1755FB0 Offset: 0x17545B0 VA: 0x181755FB0
	public void .ctor(SymmetricAlgorithm symmAlgo, bool encryption, byte[] rgbIV) { }

	// RVA: 0x15BEB50 Offset: 0x15BD150 VA: 0x1815BEB50 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x17558B0 Offset: 0x1753EB0 VA: 0x1817558B0 Slot: 9
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1754E60 Offset: 0x1753460 VA: 0x181754E60 Slot: 10
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 11
	public virtual bool get_CanTransformMultipleBlocks() { }

	// RVA: 0x4C13F0 Offset: 0x4BF9F0 VA: 0x1804C13F0 Slot: 12
	public virtual int get_InputBlockSize() { }

	// RVA: 0x4C13F0 Offset: 0x4BF9F0 VA: 0x1804C13F0 Slot: 13
	public virtual int get_OutputBlockSize() { }

	// RVA: 0x1755DC0 Offset: 0x17543C0 VA: 0x181755DC0 Slot: 14
	protected virtual void Transform(byte[] input, byte[] output) { }

	// RVA: -1 Offset: -1 Slot: 15
	protected abstract void ECB(byte[] input, byte[] output);

	// RVA: 0x17548F0 Offset: 0x1752EF0 VA: 0x1817548F0 Slot: 16
	protected virtual void CBC(byte[] input, byte[] output) { }

	// RVA: 0x1754A70 Offset: 0x1753070 VA: 0x181754A70 Slot: 17
	protected virtual void CFB(byte[] input, byte[] output) { }

	// RVA: 0x1755780 Offset: 0x1753D80 VA: 0x181755780 Slot: 18
	protected virtual void OFB(byte[] input, byte[] output) { }

	// RVA: 0x1754CB0 Offset: 0x17532B0 VA: 0x181754CB0 Slot: 19
	protected virtual void CTS(byte[] input, byte[] output) { }

	// RVA: 0x1754D10 Offset: 0x1753310 VA: 0x181754D10
	private void CheckInput(byte[] inputBuffer, int inputOffset, int inputCount) { }

	// RVA: 0x1755A50 Offset: 0x1754050 VA: 0x181755A50 Slot: 20
	public virtual int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) { }

	// RVA: 0x17562E0 Offset: 0x17548E0 VA: 0x1817562E0
	private bool get_KeepLastBlock() { }

	// RVA: 0x17555A0 Offset: 0x1753BA0 VA: 0x1817555A0
	private int InternalTransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) { }

	// RVA: 0x17557E0 Offset: 0x1753DE0 VA: 0x1817557E0
	private void Random(byte[] buffer, int start, int length) { }

	// RVA: 0x1755920 Offset: 0x1753F20 VA: 0x181755920
	private void ThrowBadPaddingException(PaddingMode padding, int length, int position) { }

	// RVA: 0x1755230 Offset: 0x1753830 VA: 0x181755230 Slot: 21
	protected virtual byte[] FinalEncrypt(byte[] inputBuffer, int inputOffset, int inputCount) { }

	// RVA: 0x1754EE0 Offset: 0x17534E0 VA: 0x181754EE0 Slot: 22
	protected virtual byte[] FinalDecrypt(byte[] inputBuffer, int inputOffset, int inputCount) { }

	// RVA: 0x1755CE0 Offset: 0x17542E0 VA: 0x181755CE0 Slot: 23
	public virtual byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount) { }

}

