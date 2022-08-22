public sealed class RijndaelManagedTransform : ICryptoTransform, IDisposable // TypeDefIndex: 978
{	// Fields
	private CipherMode m_cipherMode; // 0x10
	private PaddingMode m_paddingValue; // 0x14
	private RijndaelManagedTransformMode m_transformMode; // 0x18
	private int m_blockSizeBits; // 0x1C
	private int m_blockSizeBytes; // 0x20
	private int m_inputBlockSize; // 0x24
	private int m_outputBlockSize; // 0x28
	private int[] m_encryptKeyExpansion; // 0x30
	private int[] m_decryptKeyExpansion; // 0x38
	private int m_Nr; // 0x40
	private int m_Nb; // 0x44
	private int m_Nk; // 0x48
	private int[] m_encryptindex; // 0x50
	private int[] m_decryptindex; // 0x58
	private int[] m_IV; // 0x60
	private int[] m_lastBlockBuffer; // 0x68
	private byte[] m_depadBuffer; // 0x70
	private byte[] m_shiftRegister; // 0x78
	private static readonly byte[] s_Sbox; // 0x0
	private static readonly int[] s_Rcon; // 0x8
	private static readonly int[] s_T; // 0x10
	private static readonly int[] s_TF; // 0x18
	private static readonly int[] s_iT; // 0x20
	private static readonly int[] s_iTF; // 0x28

	// Properties
	public int InputBlockSize { get; }
	public int OutputBlockSize { get; }
	public bool CanTransformMultipleBlocks { get; }

	// Methods

	// RVA: 0x17B8600 Offset: 0x17B6C00 VA: 0x1817B8600
	internal void .ctor(byte[] rgbKey, CipherMode mode, byte[] rgbIV, int blockSize, int feedbackSize, PaddingMode PaddingValue, RijndaelManagedTransformMode transformMode) { }

	// RVA: 0x17B6290 Offset: 0x17B4890 VA: 0x1817B6290 Slot: 9
	public void Dispose() { }

	// RVA: 0x17B63A0 Offset: 0x17B49A0 VA: 0x1817B63A0
	private void Dispose(bool disposing) { }

	// RVA: 0x79C630 Offset: 0x79AC30 VA: 0x18079C630 Slot: 4
	public int get_InputBlockSize() { }

	// RVA: 0x4BE590 Offset: 0x4BCB90 VA: 0x1804BE590 Slot: 5
	public int get_OutputBlockSize() { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 6
	public bool get_CanTransformMultipleBlocks() { }

	// RVA: 0x17B7D50 Offset: 0x17B6350 VA: 0x1817B7D50 Slot: 7
	public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) { }

	// RVA: 0x17B8100 Offset: 0x17B6700 VA: 0x1817B8100 Slot: 8
	public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount) { }

	// RVA: 0x17B7BC0 Offset: 0x17B61C0 VA: 0x1817B7BC0
	public void Reset() { }

	// RVA: 0x17B66B0 Offset: 0x17B4CB0 VA: 0x1817B66B0
	private int EncryptData(byte[] inputBuffer, int inputOffset, int inputCount, ref byte[] outputBuffer, int outputOffset, PaddingMode paddingMode, bool fLast) { }

	// RVA: 0x17B53B0 Offset: 0x17B39B0 VA: 0x1817B53B0
	private int DecryptData(byte[] inputBuffer, int inputOffset, int inputCount, ref byte[] outputBuffer, int outputOffset, PaddingMode paddingMode, bool fLast) { }

	// RVA: 0x17B64B0 Offset: 0x17B4AB0 VA: 0x1817B64B0
	private void Enc(int* encryptindex, int* encryptKeyExpansion, int* T, int* TF, int* work, int* temp) { }

	// RVA: 0x17B5170 Offset: 0x17B3770 VA: 0x1817B5170
	private void Dec(int* decryptindex, int* decryptKeyExpansion, int* iT, int* iTF, int* work, int* temp) { }

	// RVA: 0x17B7480 Offset: 0x17B5A80 VA: 0x1817B7480
	private void GenerateKeyExpansion(byte[] rgbKey) { }

	// RVA: 0x17B8CC0 Offset: 0x17B72C0 VA: 0x1817B8CC0
	private static int rot1(int val) { }

	// RVA: 0x17B8CD0 Offset: 0x17B72D0 VA: 0x1817B8CD0
	private static int rot2(int val) { }

	// RVA: 0x17B8CE0 Offset: 0x17B72E0 VA: 0x1817B8CE0
	private static int rot3(int val) { }

	// RVA: 0x17B7C40 Offset: 0x17B6240 VA: 0x1817B7C40
	private static int SubWord(int a) { }

	// RVA: 0x17B7B90 Offset: 0x17B6190 VA: 0x1817B7B90
	private static int MulX(int x) { }

	// RVA: 0x17B8440 Offset: 0x17B6A40 VA: 0x1817B8440
	private static void .cctor() { }

}

