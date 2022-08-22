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

	// RVA: 0x16FEB50 Offset: 0x16FD150 VA: 0x1816FEB50
	internal void .ctor(SymmetricAlgorithm symmAlgo, bool encryption, byte[] key, byte[] iv) { }

	// RVA: 0x16FD4F0 Offset: 0x16FBAF0 VA: 0x1816FD4F0
	private uint CipherFunct(uint r, int n) { }

	// RVA: 0x16FDA10 Offset: 0x16FC010 VA: 0x1816FDA10
	internal static void Permutation(byte[] input, byte[] output, uint[] permTab, bool preSwap) { }

	// RVA: 0x16FD440 Offset: 0x16FBA40 VA: 0x1816FD440
	private static void BSwap(byte[] byteBuff) { }

	// RVA: 0x16FE4A0 Offset: 0x16FCAA0 VA: 0x1816FE4A0
	internal void SetKey(byte[] key) { }

	// RVA: 0x16FDFF0 Offset: 0x16FC5F0 VA: 0x1816FDFF0
	public void ProcessBlock(byte[] input, byte[] output) { }

	// RVA: 0x16FD870 Offset: 0x16FBE70 VA: 0x1816FD870 Slot: 15
	protected override void ECB(byte[] input, byte[] output) { }

	// RVA: 0x16FD940 Offset: 0x16FBF40 VA: 0x1816FD940
	internal static byte[] GetStrongKey() { }

	// RVA: 0x16FE930 Offset: 0x16FCF30 VA: 0x1816FE930
	private static void .cctor() { }

}

