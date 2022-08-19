internal class SortKeyBuffer // TypeDefIndex: 44
{	// Fields
	private byte[] l1b; // 0x10
	private byte[] l2b; // 0x18
	private byte[] l3b; // 0x20
	private byte[] l4sb; // 0x28
	private byte[] l4tb; // 0x30
	private byte[] l4kb; // 0x38
	private byte[] l4wb; // 0x40
	private byte[] l5b; // 0x48
	private string source; // 0x50
	private int l1; // 0x58
	private int l2; // 0x5C
	private int l3; // 0x60
	private int l4s; // 0x64
	private int l4t; // 0x68
	private int l4k; // 0x6C
	private int l4w; // 0x70
	private int l5; // 0x74
	private int lcid; // 0x78
	private CompareOptions options; // 0x7C
	private bool processLevel2; // 0x80
	private bool frenchSort; // 0x81
	private bool frenchSorted; // 0x82

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor(int lcid) { }

	// RVA: 0x1651890 Offset: 0x164FE90 VA: 0x181651890
	public void Reset() { }

	// RVA: 0x1651690 Offset: 0x164FC90 VA: 0x181651690
	internal void Initialize(CompareOptions options, int lcid, string s, bool frenchSort) { }

	// RVA: 0x1650A10 Offset: 0x164F010 VA: 0x181650A10
	internal void AppendCJKExtension(byte lv1msb, byte lv1lsb) { }

	// RVA: 0x1650AF0 Offset: 0x164F0F0 VA: 0x181650AF0
	internal void AppendKana(byte category, byte lv1, byte lv2, byte lv3, bool isSmallKana, byte markType, bool isKatakana, bool isHalfWidth) { }

	// RVA: 0x1650CA0 Offset: 0x164F2A0 VA: 0x181650CA0
	internal void AppendNormal(byte category, byte lv1, byte lv2, byte lv3) { }

	// RVA: 0x1650BC0 Offset: 0x164F1C0 VA: 0x181650BC0
	private void AppendLevel5(byte category, byte lv1) { }

	// RVA: 0x1650950 Offset: 0x164EF50 VA: 0x181650950
	private void AppendBufferPrimitive(byte value, ref byte[] buf, ref int bidx) { }

	// RVA: 0x1650F20 Offset: 0x164F520 VA: 0x181650F20
	public SortKey GetResultAndReset() { }

	// RVA: 0x1650EC0 Offset: 0x164F4C0 VA: 0x181650EC0
	private int GetOptimizedLength(byte[] data, int len, byte defaultValue) { }

	// RVA: 0x1650F50 Offset: 0x164F550 VA: 0x181650F50
	public SortKey GetResult() { }

}

