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

	// RVA: 0x13ADDF0 Offset: 0x13AC3F0 VA: 0x1813ADDF0
	public static short BitReverse(int toReverse) { }

	// RVA: 0x13AF2A0 Offset: 0x13AD8A0 VA: 0x1813AF2A0
	private static void .cctor() { }

	// RVA: 0x13AF820 Offset: 0x13ADE20 VA: 0x1813AF820
	public void .ctor(DeflaterPending pending) { }

	// RVA: 0x13AE880 Offset: 0x13ACE80 VA: 0x1813AE880
	public void Reset() { }

	// RVA: 0x13AE850 Offset: 0x13ACE50 VA: 0x1813AE850
	private int Lcode(int len) { }

	// RVA: 0x13AE190 Offset: 0x13AC790 VA: 0x1813AE190
	private int Dcode(int distance) { }

	// RVA: 0x13AE8D0 Offset: 0x13ACED0 VA: 0x1813AE8D0
	public void SendAllTrees(int blTreeCodes) { }

	// RVA: 0x13ADF10 Offset: 0x13AC510 VA: 0x1813ADF10
	public void CompressBlock() { }

	// RVA: 0x13AE6F0 Offset: 0x13ACCF0 VA: 0x1813AE6F0
	public void FlushStoredBlock(byte[] stored, int storedOffset, int storedLength, bool lastBlock) { }

	// RVA: 0x13AE1B0 Offset: 0x13AC7B0 VA: 0x1813AE1B0
	public void FlushBlock(byte[] stored, int storedOffset, int storedLength, bool lastBlock) { }

	// RVA: 0x13AE7E0 Offset: 0x13ACDE0 VA: 0x1813AE7E0
	public bool IsFull() { }

	// RVA: 0x13AF190 Offset: 0x13AD790 VA: 0x1813AF190
	public bool TallyLit(int lit) { }

	// RVA: 0x13AEFD0 Offset: 0x13AD5D0 VA: 0x1813AEFD0
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

	// RVA: 0x13CDE30 Offset: 0x13CC430 VA: 0x1813CDE30
	public void .ctor(DeflaterHuffman dh, int elems, int minCodes, int maxLength) { }

	// RVA: 0x13CDA30 Offset: 0x13CC030 VA: 0x1813CDA30
	public void Reset() { }

	// RVA: 0x13CDB00 Offset: 0x13CC100 VA: 0x1813CDB00
	public void WriteSymbol(int code) { }

	// RVA: 0x13CDAC0 Offset: 0x13CC0C0 VA: 0x1813CDAC0
	public void SetStaticCodes(short[] stCodes, byte[] stLength) { }

	// RVA: 0x13CC5E0 Offset: 0x13CABE0 VA: 0x1813CC5E0
	public void BuildCodes() { }

	// RVA: 0x13CC880 Offset: 0x13CAE80 VA: 0x1813CC880
	private void BuildLength(int[] childs) { }

	// RVA: 0x13CCDB0 Offset: 0x13CB3B0 VA: 0x1813CCDB0
	public void BuildTree() { }

	// RVA: 0x13CD9A0 Offset: 0x13CBFA0 VA: 0x1813CD9A0
	public int GetEncodedLength() { }

	// RVA: 0x13CD6E0 Offset: 0x13CBCE0 VA: 0x1813CD6E0
	public void CalcBLFreq(DeflaterHuffman.Tree blTree) { }

	// RVA: 0x13CDB80 Offset: 0x13CC180 VA: 0x1813CDB80
	public void WriteTree(DeflaterHuffman.Tree blTree) { }

}

