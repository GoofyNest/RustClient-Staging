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

	// RVA: 0x13ADAE0 Offset: 0x13AC0E0 VA: 0x1813ADAE0
	public void .ctor(DeflaterPending pending) { }

	// RVA: 0x13AD3A0 Offset: 0x13AB9A0 VA: 0x1813AD3A0
	public void Reset() { }

	// RVA: 0x13AD370 Offset: 0x13AB970 VA: 0x1813AD370
	public void ResetAdler() { }

	// RVA: 0x13ADDD0 Offset: 0x13AC3D0 VA: 0x1813ADDD0
	public int get_Adler() { }

	// RVA: 0x803B90 Offset: 0x802190 VA: 0x180803B90
	public int get_TotalIn() { }

	// RVA: 0x598430 Offset: 0x596A30 VA: 0x180598430
	public void set_Strategy(DeflateStrategy value) { }

	// RVA: 0x13AD5B0 Offset: 0x13ABBB0 VA: 0x1813AD5B0
	public void SetLevel(int lvl) { }

	// RVA: 0x13ADA30 Offset: 0x13AC030 VA: 0x1813ADA30
	private void UpdateHash() { }

	// RVA: 0x13AD290 Offset: 0x13AB890 VA: 0x1813AD290
	private int InsertString() { }

	// RVA: 0x13AD940 Offset: 0x13ABF40 VA: 0x1813AD940
	private void SlideWindow() { }

	// RVA: 0x13ACC00 Offset: 0x13AB200 VA: 0x1813ACC00
	public void FillWindow() { }

	// RVA: 0x13ACD20 Offset: 0x13AB320 VA: 0x1813ACD20
	private bool FindLongestMatch(int curMatch) { }

	// RVA: 0x13AC850 Offset: 0x13AAE50 VA: 0x1813AC850
	private bool DeflateStored(bool flush, bool finish) { }

	// RVA: 0x13AC1F0 Offset: 0x13AA7F0 VA: 0x1813AC1F0
	private bool DeflateFast(bool flush, bool finish) { }

	// RVA: 0x13AC500 Offset: 0x13AAB00 VA: 0x1813AC500
	private bool DeflateSlow(bool flush, bool finish) { }

	// RVA: 0x13AC9C0 Offset: 0x13AAFC0 VA: 0x1813AC9C0
	public bool Deflate(bool flush, bool finish) { }

	// RVA: 0x13AD4C0 Offset: 0x13ABAC0 VA: 0x1813AD4C0
	public void SetInput(byte[] buf, int off, int len) { }

	// RVA: 0x13AD360 Offset: 0x13AB960 VA: 0x1813AD360
	public bool NeedsInput() { }

	// RVA: 0x13ADAA0 Offset: 0x13AC0A0 VA: 0x1813ADAA0
	private static void .cctor() { }

}

