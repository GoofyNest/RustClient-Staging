internal class DeflaterEngine : DeflaterConstants // TypeDefIndex: 5659
{	// Fields
	private static int TOO_FAR; // 0x0
	private int ins_h; // 0x10
	private short[] head; // 0x18
	private short[] prev; // 0x20
	private int matchStart; // 0x28
	private int matchLen; // 0x2C
	private bool prevAvailable; // 0x30
	private int blockStart; // 0x34
	private int strstart; // 0x38
	private int lookahead; // 0x3C
	private byte[] window; // 0x40
	private DeflateStrategy strategy; // 0x48
	private int max_chain; // 0x4C
	private int max_lazy; // 0x50
	private int niceLength; // 0x54
	private int goodLength; // 0x58
	private int comprFunc; // 0x5C
	private byte[] inputBuf; // 0x60
	private int totalIn; // 0x68
	private int inputOff; // 0x6C
	private int inputEnd; // 0x70
	private DeflaterPending pending; // 0x78
	private DeflaterHuffman huffman; // 0x80
	private Adler32 adler; // 0x88

	// Properties
	public int Adler { get; }
	public int TotalIn { get; }
	public DeflateStrategy Strategy { set; }

	// Methods

	// RVA: 0x13ACBE0 Offset: 0x13AB1E0 VA: 0x1813ACBE0
	public void .ctor(DeflaterPending pending) { }

	// RVA: 0x13AC4A0 Offset: 0x13AAAA0 VA: 0x1813AC4A0
	public void Reset() { }

	// RVA: 0x13AC470 Offset: 0x13AAA70 VA: 0x1813AC470
	public void ResetAdler() { }

	// RVA: 0x13ACED0 Offset: 0x13AB4D0 VA: 0x1813ACED0
	public int get_Adler() { }

	// RVA: 0x804120 Offset: 0x802720 VA: 0x180804120
	public int get_TotalIn() { }

	// RVA: 0x5983C0 Offset: 0x5969C0 VA: 0x1805983C0
	public void set_Strategy(DeflateStrategy value) { }

	// RVA: 0x13AC6B0 Offset: 0x13AACB0 VA: 0x1813AC6B0
	public void SetLevel(int lvl) { }

	// RVA: 0x13ACB30 Offset: 0x13AB130 VA: 0x1813ACB30
	private void UpdateHash() { }

	// RVA: 0x13AC390 Offset: 0x13AA990 VA: 0x1813AC390
	private int InsertString() { }

	// RVA: 0x13ACA40 Offset: 0x13AB040 VA: 0x1813ACA40
	private void SlideWindow() { }

	// RVA: 0x13ABD00 Offset: 0x13AA300 VA: 0x1813ABD00
	public void FillWindow() { }

	// RVA: 0x13ABE20 Offset: 0x13AA420 VA: 0x1813ABE20
	private bool FindLongestMatch(int curMatch) { }

	// RVA: 0x13AB950 Offset: 0x13A9F50 VA: 0x1813AB950
	private bool DeflateStored(bool flush, bool finish) { }

	// RVA: 0x13AB2F0 Offset: 0x13A98F0 VA: 0x1813AB2F0
	private bool DeflateFast(bool flush, bool finish) { }

	// RVA: 0x13AB600 Offset: 0x13A9C00 VA: 0x1813AB600
	private bool DeflateSlow(bool flush, bool finish) { }

	// RVA: 0x13ABAC0 Offset: 0x13AA0C0 VA: 0x1813ABAC0
	public bool Deflate(bool flush, bool finish) { }

	// RVA: 0x13AC5C0 Offset: 0x13AABC0 VA: 0x1813AC5C0
	public void SetInput(byte[] buf, int off, int len) { }

	// RVA: 0x13AC460 Offset: 0x13AAA60 VA: 0x1813AC460
	public bool NeedsInput() { }

	// RVA: 0x13ACBA0 Offset: 0x13AB1A0 VA: 0x1813ACBA0
	private static void .cctor() { }

}

