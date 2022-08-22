internal class DeflaterHuffman // TypeDefIndex: 5660
{	// Fields
	private static int BUFSIZE; // 0x0
	private static int LITERAL_NUM; // 0x4
	private static int DIST_NUM; // 0x8
	private static int BITLEN_NUM; // 0xC
	private static int REP_3_6; // 0x10
	private static int REP_3_10; // 0x14
	private static int REP_11_138; // 0x18
	private static int EOF_SYMBOL; // 0x1C
	private static int[] BL_ORDER; // 0x20
	private static byte[] bit4Reverse; // 0x28
	public DeflaterPending pending; // 0x10
	private DeflaterHuffman.Tree literalTree; // 0x18
	private DeflaterHuffman.Tree distTree; // 0x20
	private DeflaterHuffman.Tree blTree; // 0x28
	private short[] d_buf; // 0x30
	private byte[] l_buf; // 0x38
	private int last_lit; // 0x40
	private int extra_bits; // 0x44
	private static short[] staticLCodes; // 0x30
	private static byte[] staticLLength; // 0x38
	private static short[] staticDCodes; // 0x40
	private static byte[] staticDLength; // 0x48

	// Methods

	// RVA: 0x13ACEF0 Offset: 0x13AB4F0 VA: 0x1813ACEF0
	public static short BitReverse(int toReverse) { }

	// RVA: 0x13AE3A0 Offset: 0x13AC9A0 VA: 0x1813AE3A0
	private static void .cctor() { }

	// RVA: 0x13AE920 Offset: 0x13ACF20 VA: 0x1813AE920
	public void .ctor(DeflaterPending pending) { }

	// RVA: 0x13AD980 Offset: 0x13ABF80 VA: 0x1813AD980
	public void Reset() { }

	// RVA: 0x13AD950 Offset: 0x13ABF50 VA: 0x1813AD950
	private int Lcode(int len) { }

	// RVA: 0x13AD290 Offset: 0x13AB890 VA: 0x1813AD290
	private int Dcode(int distance) { }

	// RVA: 0x13AD9D0 Offset: 0x13ABFD0 VA: 0x1813AD9D0
	public void SendAllTrees(int blTreeCodes) { }

	// RVA: 0x13AD010 Offset: 0x13AB610 VA: 0x1813AD010
	public void CompressBlock() { }

	// RVA: 0x13AD7F0 Offset: 0x13ABDF0 VA: 0x1813AD7F0
	public void FlushStoredBlock(byte[] stored, int storedOffset, int storedLength, bool lastBlock) { }

	// RVA: 0x13AD2B0 Offset: 0x13AB8B0 VA: 0x1813AD2B0
	public void FlushBlock(byte[] stored, int storedOffset, int storedLength, bool lastBlock) { }

	// RVA: 0x13AD8E0 Offset: 0x13ABEE0 VA: 0x1813AD8E0
	public bool IsFull() { }

	// RVA: 0x13AE290 Offset: 0x13AC890 VA: 0x1813AE290
	public bool TallyLit(int lit) { }

	// RVA: 0x13AE0D0 Offset: 0x13AC6D0 VA: 0x1813AE0D0
	public bool TallyDist(int dist, int len) { }

}

internal class DeflaterHuffman.Tree // TypeDefIndex: 5661
{	// Fields
	public short[] freqs; // 0x10
	public byte[] length; // 0x18
	public int minNumCodes; // 0x20
	public int numCodes; // 0x24
	private short[] codes; // 0x28
	private int[] bl_counts; // 0x30
	private int maxLength; // 0x38
	private DeflaterHuffman dh; // 0x40

	// Methods

	// RVA: 0x13CCF30 Offset: 0x13CB530 VA: 0x1813CCF30
	public void .ctor(DeflaterHuffman dh, int elems, int minCodes, int maxLength) { }

	// RVA: 0x13CCB30 Offset: 0x13CB130 VA: 0x1813CCB30
	public void Reset() { }

	// RVA: 0x13CCC00 Offset: 0x13CB200 VA: 0x1813CCC00
	public void WriteSymbol(int code) { }

	// RVA: 0x13CCBC0 Offset: 0x13CB1C0 VA: 0x1813CCBC0
	public void SetStaticCodes(short[] stCodes, byte[] stLength) { }

	// RVA: 0x13CB6E0 Offset: 0x13C9CE0 VA: 0x1813CB6E0
	public void BuildCodes() { }

	// RVA: 0x13CB980 Offset: 0x13C9F80 VA: 0x1813CB980
	private void BuildLength(int[] childs) { }

	// RVA: 0x13CBEB0 Offset: 0x13CA4B0 VA: 0x1813CBEB0
	public void BuildTree() { }

	// RVA: 0x13CCAA0 Offset: 0x13CB0A0 VA: 0x1813CCAA0
	public int GetEncodedLength() { }

	// RVA: 0x13CC7E0 Offset: 0x13CADE0 VA: 0x1813CC7E0
	public void CalcBLFreq(DeflaterHuffman.Tree blTree) { }

	// RVA: 0x13CCC80 Offset: 0x13CB280 VA: 0x1813CCC80
	public void WriteTree(DeflaterHuffman.Tree blTree) { }

}

