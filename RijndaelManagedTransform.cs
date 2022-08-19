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

	// RVA: 0x17BA7F0 Offset: 0x17B8DF0 VA: 0x1817BA7F0
	internal void .ctor(byte[] rgbKey, CipherMode mode, byte[] rgbIV, int blockSize, int feedbackSize, PaddingMode PaddingValue, RijndaelManagedTransformMode transformMode) { }

	// RVA: 0x17B8480 Offset: 0x17B6A80 VA: 0x1817B8480 Slot: 9
	public void Dispose() { }

	// RVA: 0x17B8590 Offset: 0x17B6B90 VA: 0x1817B8590
	private void Dispose(bool disposing) { }

	// RVA: 0x7D0C00 Offset: 0x7CF200 VA: 0x1807D0C00 Slot: 4
	public int get_InputBlockSize() { }

	// RVA: 0x4BE600 Offset: 0x4BCC00 VA: 0x1804BE600 Slot: 5
	public int get_OutputBlockSize() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 6
	public bool get_CanTransformMultipleBlocks() { }

	// RVA: 0x17B9F40 Offset: 0x17B8540 VA: 0x1817B9F40 Slot: 7
	public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) { }

	// RVA: 0x17BA2F0 Offset: 0x17B88F0 VA: 0x1817BA2F0 Slot: 8
	public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount) { }

	// RVA: 0x17B9DB0 Offset: 0x17B83B0 VA: 0x1817B9DB0
	public void Reset() { }

	// RVA: 0x17B88A0 Offset: 0x17B6EA0 VA: 0x1817B88A0
	private int EncryptData(byte[] inputBuffer, int inputOffset, int inputCount, ref byte[] outputBuffer, int outputOffset, PaddingMode paddingMode, bool fLast) { }

	// RVA: 0x17B75A0 Offset: 0x17B5BA0 VA: 0x1817B75A0
	private int DecryptData(byte[] inputBuffer, int inputOffset, int inputCount, ref byte[] outputBuffer, int outputOffset, PaddingMode paddingMode, bool fLast) { }

	// RVA: 0x17B86A0 Offset: 0x17B6CA0 VA: 0x1817B86A0
	private void Enc(int* encryptindex, int* encryptKeyExpansion, int* T, int* TF, int* work, int* temp) { }

	// RVA: 0x17B7360 Offset: 0x17B5960 VA: 0x1817B7360
	private void Dec(int* decryptindex, int* decryptKeyExpansion, int* iT, int* iTF, int* work, int* temp) { }

	// RVA: 0x17B9670 Offset: 0x17B7C70 VA: 0x1817B9670
	private void GenerateKeyExpansion(byte[] rgbKey) { }

	// RVA: 0x17BAEB0 Offset: 0x17B94B0 VA: 0x1817BAEB0
	private static int rot1(int val) { }

	// RVA: 0x17BAEC0 Offset: 0x17B94C0 VA: 0x1817BAEC0
	private static int rot2(int val) { }

	// RVA: 0x17BAED0 Offset: 0x17B94D0 VA: 0x1817BAED0
	private static int rot3(int val) { }

	// RVA: 0x17B9E30 Offset: 0x17B8430 VA: 0x1817B9E30
	private static int SubWord(int a) { }

	// RVA: 0x17B9D80 Offset: 0x17B8380 VA: 0x1817B9D80
	private static int MulX(int x) { }

	// RVA: 0x17BA630 Offset: 0x17B8C30 VA: 0x1817BA630
	private static void .cctor() { }

}

