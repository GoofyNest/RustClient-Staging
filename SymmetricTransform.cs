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

	// RVA: 0x1758130 Offset: 0x1756730 VA: 0x181758130
	public void .ctor(SymmetricAlgorithm symmAlgo, bool encryption, byte[] rgbIV) { }

	// RVA: 0x15BF7C0 Offset: 0x15BDDC0 VA: 0x1815BF7C0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1757A30 Offset: 0x1756030 VA: 0x181757A30 Slot: 9
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1756FE0 Offset: 0x17555E0 VA: 0x181756FE0 Slot: 10
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 11
	public virtual bool get_CanTransformMultipleBlocks() { }

	// RVA: 0x4C1460 Offset: 0x4BFA60 VA: 0x1804C1460 Slot: 12
	public virtual int get_InputBlockSize() { }

	// RVA: 0x4C1460 Offset: 0x4BFA60 VA: 0x1804C1460 Slot: 13
	public virtual int get_OutputBlockSize() { }

	// RVA: 0x1757F40 Offset: 0x1756540 VA: 0x181757F40 Slot: 14
	protected virtual void Transform(byte[] input, byte[] output) { }

	// RVA: -1 Offset: -1 Slot: 15
	protected abstract void ECB(byte[] input, byte[] output);

	// RVA: 0x1756A70 Offset: 0x1755070 VA: 0x181756A70 Slot: 16
	protected virtual void CBC(byte[] input, byte[] output) { }

	// RVA: 0x1756BF0 Offset: 0x17551F0 VA: 0x181756BF0 Slot: 17
	protected virtual void CFB(byte[] input, byte[] output) { }

	// RVA: 0x1757900 Offset: 0x1755F00 VA: 0x181757900 Slot: 18
	protected virtual void OFB(byte[] input, byte[] output) { }

	// RVA: 0x1756E30 Offset: 0x1755430 VA: 0x181756E30 Slot: 19
	protected virtual void CTS(byte[] input, byte[] output) { }

	// RVA: 0x1756E90 Offset: 0x1755490 VA: 0x181756E90
	private void CheckInput(byte[] inputBuffer, int inputOffset, int inputCount) { }

	// RVA: 0x1757BD0 Offset: 0x17561D0 VA: 0x181757BD0 Slot: 20
	public virtual int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) { }

	// RVA: 0x1758460 Offset: 0x1756A60 VA: 0x181758460
	private bool get_KeepLastBlock() { }

	// RVA: 0x1757720 Offset: 0x1755D20 VA: 0x181757720
	private int InternalTransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) { }

	// RVA: 0x1757960 Offset: 0x1755F60 VA: 0x181757960
	private void Random(byte[] buffer, int start, int length) { }

	// RVA: 0x1757AA0 Offset: 0x17560A0 VA: 0x181757AA0
	private void ThrowBadPaddingException(PaddingMode padding, int length, int position) { }

	// RVA: 0x17573B0 Offset: 0x17559B0 VA: 0x1817573B0 Slot: 21
	protected virtual byte[] FinalEncrypt(byte[] inputBuffer, int inputOffset, int inputCount) { }

	// RVA: 0x1757060 Offset: 0x1755660 VA: 0x181757060 Slot: 22
	protected virtual byte[] FinalDecrypt(byte[] inputBuffer, int inputOffset, int inputCount) { }

	// RVA: 0x1757E60 Offset: 0x1756460 VA: 0x181757E60 Slot: 23
	public virtual byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount) { }

}

