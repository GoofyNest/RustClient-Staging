internal class DESTransform : SymmetricTransform // TypeDefIndex: 1004
{	// Fields
	internal static readonly int KEY_BIT_SIZE; // 0x0
	internal static readonly int KEY_BYTE_SIZE; // 0x4
	internal static readonly int BLOCK_BIT_SIZE; // 0x8
	internal static readonly int BLOCK_BYTE_SIZE; // 0xC
	private byte[] keySchedule; // 0x58
	private byte[] byteBuff; // 0x60
	private uint[] dwordBuff; // 0x68
	private static readonly uint[] spBoxes; // 0x10
	private static readonly byte[] PC1; // 0x18
	private static readonly byte[] leftRotTotal; // 0x20
	private static readonly byte[] PC2; // 0x28
	internal static readonly uint[] ipTab; // 0x30
	internal static readonly uint[] fpTab; // 0x38

	// Methods

	// RVA: 0x16FE890 Offset: 0x16FCE90 VA: 0x1816FE890
	internal void .ctor(SymmetricAlgorithm symmAlgo, bool encryption, byte[] key, byte[] iv) { }

	// RVA: 0x16FD230 Offset: 0x16FB830 VA: 0x1816FD230
	private uint CipherFunct(uint r, int n) { }

	// RVA: 0x16FD750 Offset: 0x16FBD50 VA: 0x1816FD750
	internal static void Permutation(byte[] input, byte[] output, uint[] permTab, bool preSwap) { }

	// RVA: 0x16FD180 Offset: 0x16FB780 VA: 0x1816FD180
	private static void BSwap(byte[] byteBuff) { }

	// RVA: 0x16FE1E0 Offset: 0x16FC7E0 VA: 0x1816FE1E0
	internal void SetKey(byte[] key) { }

	// RVA: 0x16FDD30 Offset: 0x16FC330 VA: 0x1816FDD30
	public void ProcessBlock(byte[] input, byte[] output) { }

	// RVA: 0x16FD5B0 Offset: 0x16FBBB0 VA: 0x1816FD5B0 Slot: 15
	protected override void ECB(byte[] input, byte[] output) { }

	// RVA: 0x16FD680 Offset: 0x16FBC80 VA: 0x1816FD680
	internal static byte[] GetStrongKey() { }

	// RVA: 0x16FE670 Offset: 0x16FCC70 VA: 0x1816FE670
	private static void .cctor() { }

}

