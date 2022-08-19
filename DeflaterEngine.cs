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

	// RVA: 0x13AD820 Offset: 0x13ABE20 VA: 0x1813AD820
	public void .ctor(DeflaterPending pending) { }

	// RVA: 0x13AD0E0 Offset: 0x13AB6E0 VA: 0x1813AD0E0
	public void Reset() { }

	// RVA: 0x13AD0B0 Offset: 0x13AB6B0 VA: 0x1813AD0B0
	public void ResetAdler() { }

	// RVA: 0x13ADB10 Offset: 0x13AC110 VA: 0x1813ADB10
	public int get_Adler() { }

	// RVA: 0x803A80 Offset: 0x802080 VA: 0x180803A80
	public int get_TotalIn() { }

	// RVA: 0x598430 Offset: 0x596A30 VA: 0x180598430
	public void set_Strategy(DeflateStrategy value) { }

	// RVA: 0x13AD2F0 Offset: 0x13AB8F0 VA: 0x1813AD2F0
	public void SetLevel(int lvl) { }

	// RVA: 0x13AD770 Offset: 0x13ABD70 VA: 0x1813AD770
	private void UpdateHash() { }

	// RVA: 0x13ACFD0 Offset: 0x13AB5D0 VA: 0x1813ACFD0
	private int InsertString() { }

	// RVA: 0x13AD680 Offset: 0x13ABC80 VA: 0x1813AD680
	private void SlideWindow() { }

	// RVA: 0x13AC940 Offset: 0x13AAF40 VA: 0x1813AC940
	public void FillWindow() { }

	// RVA: 0x13ACA60 Offset: 0x13AB060 VA: 0x1813ACA60
	private bool FindLongestMatch(int curMatch) { }

	// RVA: 0x13AC590 Offset: 0x13AAB90 VA: 0x1813AC590
	private bool DeflateStored(bool flush, bool finish) { }

	// RVA: 0x13ABF30 Offset: 0x13AA530 VA: 0x1813ABF30
	private bool DeflateFast(bool flush, bool finish) { }

	// RVA: 0x13AC240 Offset: 0x13AA840 VA: 0x1813AC240
	private bool DeflateSlow(bool flush, bool finish) { }

	// RVA: 0x13AC700 Offset: 0x13AAD00 VA: 0x1813AC700
	public bool Deflate(bool flush, bool finish) { }

	// RVA: 0x13AD200 Offset: 0x13AB800 VA: 0x1813AD200
	public void SetInput(byte[] buf, int off, int len) { }

	// RVA: 0x13AD0A0 Offset: 0x13AB6A0 VA: 0x1813AD0A0
	public bool NeedsInput() { }

	// RVA: 0x13AD7E0 Offset: 0x13ABDE0 VA: 0x1813AD7E0
	private static void .cctor() { }

}

