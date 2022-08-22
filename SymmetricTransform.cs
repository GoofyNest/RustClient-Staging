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

	// RVA: 0x17583F0 Offset: 0x17569F0 VA: 0x1817583F0
	public void .ctor(SymmetricAlgorithm symmAlgo, bool encryption, byte[] rgbIV) { }

	// RVA: 0x15BFA80 Offset: 0x15BE080 VA: 0x1815BFA80 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1757CF0 Offset: 0x17562F0 VA: 0x181757CF0 Slot: 9
	private void System.IDisposable.Dispose() { }

	// RVA: 0x17572A0 Offset: 0x17558A0 VA: 0x1817572A0 Slot: 10
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 11
	public virtual bool get_CanTransformMultipleBlocks() { }

	// RVA: 0x4C1460 Offset: 0x4BFA60 VA: 0x1804C1460 Slot: 12
	public virtual int get_InputBlockSize() { }

	// RVA: 0x4C1460 Offset: 0x4BFA60 VA: 0x1804C1460 Slot: 13
	public virtual int get_OutputBlockSize() { }

	// RVA: 0x1758200 Offset: 0x1756800 VA: 0x181758200 Slot: 14
	protected virtual void Transform(byte[] input, byte[] output) { }

	// RVA: -1 Offset: -1 Slot: 15
	protected abstract void ECB(byte[] input, byte[] output);

	// RVA: 0x1756D30 Offset: 0x1755330 VA: 0x181756D30 Slot: 16
	protected virtual void CBC(byte[] input, byte[] output) { }

	// RVA: 0x1756EB0 Offset: 0x17554B0 VA: 0x181756EB0 Slot: 17
	protected virtual void CFB(byte[] input, byte[] output) { }

	// RVA: 0x1757BC0 Offset: 0x17561C0 VA: 0x181757BC0 Slot: 18
	protected virtual void OFB(byte[] input, byte[] output) { }

	// RVA: 0x17570F0 Offset: 0x17556F0 VA: 0x1817570F0 Slot: 19
	protected virtual void CTS(byte[] input, byte[] output) { }

	// RVA: 0x1757150 Offset: 0x1755750 VA: 0x181757150
	private void CheckInput(byte[] inputBuffer, int inputOffset, int inputCount) { }

	// RVA: 0x1757E90 Offset: 0x1756490 VA: 0x181757E90 Slot: 20
	public virtual int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) { }

	// RVA: 0x1758720 Offset: 0x1756D20 VA: 0x181758720
	private bool get_KeepLastBlock() { }

	// RVA: 0x17579E0 Offset: 0x1755FE0 VA: 0x1817579E0
	private int InternalTransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) { }

	// RVA: 0x1757C20 Offset: 0x1756220 VA: 0x181757C20
	private void Random(byte[] buffer, int start, int length) { }

	// RVA: 0x1757D60 Offset: 0x1756360 VA: 0x181757D60
	private void ThrowBadPaddingException(PaddingMode padding, int length, int position) { }

	// RVA: 0x1757670 Offset: 0x1755C70 VA: 0x181757670 Slot: 21
	protected virtual byte[] FinalEncrypt(byte[] inputBuffer, int inputOffset, int inputCount) { }

	// RVA: 0x1757320 Offset: 0x1755920 VA: 0x181757320 Slot: 22
	protected virtual byte[] FinalDecrypt(byte[] inputBuffer, int inputOffset, int inputCount) { }

	// RVA: 0x1758120 Offset: 0x1756720 VA: 0x181758120 Slot: 23
	public virtual byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount) { }

}

