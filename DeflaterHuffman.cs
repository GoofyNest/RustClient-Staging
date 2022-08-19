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

	// RVA: 0x13ADB30 Offset: 0x13AC130 VA: 0x1813ADB30
	public static short BitReverse(int toReverse) { }

	// RVA: 0x13AEFE0 Offset: 0x13AD5E0 VA: 0x1813AEFE0
	private static void .cctor() { }

	// RVA: 0x13AF560 Offset: 0x13ADB60 VA: 0x1813AF560
	public void .ctor(DeflaterPending pending) { }

	// RVA: 0x13AE5C0 Offset: 0x13ACBC0 VA: 0x1813AE5C0
	public void Reset() { }

	// RVA: 0x13AE590 Offset: 0x13ACB90 VA: 0x1813AE590
	private int Lcode(int len) { }

	// RVA: 0x13ADED0 Offset: 0x13AC4D0 VA: 0x1813ADED0
	private int Dcode(int distance) { }

	// RVA: 0x13AE610 Offset: 0x13ACC10 VA: 0x1813AE610
	public void SendAllTrees(int blTreeCodes) { }

	// RVA: 0x13ADC50 Offset: 0x13AC250 VA: 0x1813ADC50
	public void CompressBlock() { }

	// RVA: 0x13AE430 Offset: 0x13ACA30 VA: 0x1813AE430
	public void FlushStoredBlock(byte[] stored, int storedOffset, int storedLength, bool lastBlock) { }

	// RVA: 0x13ADEF0 Offset: 0x13AC4F0 VA: 0x1813ADEF0
	public void FlushBlock(byte[] stored, int storedOffset, int storedLength, bool lastBlock) { }

	// RVA: 0x13AE520 Offset: 0x13ACB20 VA: 0x1813AE520
	public bool IsFull() { }

	// RVA: 0x13AEED0 Offset: 0x13AD4D0 VA: 0x1813AEED0
	public bool TallyLit(int lit) { }

	// RVA: 0x13AED10 Offset: 0x13AD310 VA: 0x1813AED10
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

	// RVA: 0x13CDB70 Offset: 0x13CC170 VA: 0x1813CDB70
	public void .ctor(DeflaterHuffman dh, int elems, int minCodes, int maxLength) { }

	// RVA: 0x13CD770 Offset: 0x13CBD70 VA: 0x1813CD770
	public void Reset() { }

	// RVA: 0x13CD840 Offset: 0x13CBE40 VA: 0x1813CD840
	public void WriteSymbol(int code) { }

	// RVA: 0x13CD800 Offset: 0x13CBE00 VA: 0x1813CD800
	public void SetStaticCodes(short[] stCodes, byte[] stLength) { }

	// RVA: 0x13CC320 Offset: 0x13CA920 VA: 0x1813CC320
	public void BuildCodes() { }

	// RVA: 0x13CC5C0 Offset: 0x13CABC0 VA: 0x1813CC5C0
	private void BuildLength(int[] childs) { }

	// RVA: 0x13CCAF0 Offset: 0x13CB0F0 VA: 0x1813CCAF0
	public void BuildTree() { }

	// RVA: 0x13CD6E0 Offset: 0x13CBCE0 VA: 0x1813CD6E0
	public int GetEncodedLength() { }

	// RVA: 0x13CD420 Offset: 0x13CBA20 VA: 0x1813CD420
	public void CalcBLFreq(DeflaterHuffman.Tree blTree) { }

	// RVA: 0x13CD8C0 Offset: 0x13CBEC0 VA: 0x1813CD8C0
	public void WriteTree(DeflaterHuffman.Tree blTree) { }

}

