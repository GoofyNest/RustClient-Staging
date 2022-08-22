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

	// RVA: 0x16FC740 Offset: 0x16FAD40 VA: 0x1816FC740
	internal void .ctor(SymmetricAlgorithm symmAlgo, bool encryption, byte[] key, byte[] iv) { }

	// RVA: 0x16FB0E0 Offset: 0x16F96E0 VA: 0x1816FB0E0
	private uint CipherFunct(uint r, int n) { }

	// RVA: 0x16FB600 Offset: 0x16F9C00 VA: 0x1816FB600
	internal static void Permutation(byte[] input, byte[] output, uint[] permTab, bool preSwap) { }

	// RVA: 0x16FB030 Offset: 0x16F9630 VA: 0x1816FB030
	private static void BSwap(byte[] byteBuff) { }

	// RVA: 0x16FC090 Offset: 0x16FA690 VA: 0x1816FC090
	internal void SetKey(byte[] key) { }

	// RVA: 0x16FBBE0 Offset: 0x16FA1E0 VA: 0x1816FBBE0
	public void ProcessBlock(byte[] input, byte[] output) { }

	// RVA: 0x16FB460 Offset: 0x16F9A60 VA: 0x1816FB460 Slot: 15
	protected override void ECB(byte[] input, byte[] output) { }

	// RVA: 0x16FB530 Offset: 0x16F9B30 VA: 0x1816FB530
	internal static byte[] GetStrongKey() { }

	// RVA: 0x16FC520 Offset: 0x16FAB20 VA: 0x1816FC520
	private static void .cctor() { }

}

