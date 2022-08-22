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

	// RVA: 0x17BAAB0 Offset: 0x17B90B0 VA: 0x1817BAAB0
	internal void .ctor(byte[] rgbKey, CipherMode mode, byte[] rgbIV, int blockSize, int feedbackSize, PaddingMode PaddingValue, RijndaelManagedTransformMode transformMode) { }

	// RVA: 0x17B8740 Offset: 0x17B6D40 VA: 0x1817B8740 Slot: 9
	public void Dispose() { }

	// RVA: 0x17B8850 Offset: 0x17B6E50 VA: 0x1817B8850
	private void Dispose(bool disposing) { }

	// RVA: 0x7D0D10 Offset: 0x7CF310 VA: 0x1807D0D10 Slot: 4
	public int get_InputBlockSize() { }

	// RVA: 0x4BE600 Offset: 0x4BCC00 VA: 0x1804BE600 Slot: 5
	public int get_OutputBlockSize() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 6
	public bool get_CanTransformMultipleBlocks() { }

	// RVA: 0x17BA200 Offset: 0x17B8800 VA: 0x1817BA200 Slot: 7
	public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset) { }

	// RVA: 0x17BA5B0 Offset: 0x17B8BB0 VA: 0x1817BA5B0 Slot: 8
	public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount) { }

	// RVA: 0x17BA070 Offset: 0x17B8670 VA: 0x1817BA070
	public void Reset() { }

	// RVA: 0x17B8B60 Offset: 0x17B7160 VA: 0x1817B8B60
	private int EncryptData(byte[] inputBuffer, int inputOffset, int inputCount, ref byte[] outputBuffer, int outputOffset, PaddingMode paddingMode, bool fLast) { }

	// RVA: 0x17B7860 Offset: 0x17B5E60 VA: 0x1817B7860
	private int DecryptData(byte[] inputBuffer, int inputOffset, int inputCount, ref byte[] outputBuffer, int outputOffset, PaddingMode paddingMode, bool fLast) { }

	// RVA: 0x17B8960 Offset: 0x17B6F60 VA: 0x1817B8960
	private void Enc(int* encryptindex, int* encryptKeyExpansion, int* T, int* TF, int* work, int* temp) { }

	// RVA: 0x17B7620 Offset: 0x17B5C20 VA: 0x1817B7620
	private void Dec(int* decryptindex, int* decryptKeyExpansion, int* iT, int* iTF, int* work, int* temp) { }

	// RVA: 0x17B9930 Offset: 0x17B7F30 VA: 0x1817B9930
	private void GenerateKeyExpansion(byte[] rgbKey) { }

	// RVA: 0x17BB170 Offset: 0x17B9770 VA: 0x1817BB170
	private static int rot1(int val) { }

	// RVA: 0x17BB180 Offset: 0x17B9780 VA: 0x1817BB180
	private static int rot2(int val) { }

	// RVA: 0x17BB190 Offset: 0x17B9790 VA: 0x1817BB190
	private static int rot3(int val) { }

	// RVA: 0x17BA0F0 Offset: 0x17B86F0 VA: 0x1817BA0F0
	private static int SubWord(int a) { }

	// RVA: 0x17BA040 Offset: 0x17B8640 VA: 0x1817BA040
	private static int MulX(int x) { }

	// RVA: 0x17BA8F0 Offset: 0x17B8EF0 VA: 0x1817BA8F0
	private static void .cctor() { }

}

