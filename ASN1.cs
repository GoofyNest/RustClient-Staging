internal class ASN1 // TypeDefIndex: 45
{	// Fields
	private byte m_nTag; // 0x10
	private byte[] m_aValue; // 0x18
	private ArrayList elist; // 0x20

	// Properties
	public int Count { get; }
	public byte Tag { get; }
	public int Length { get; }
	public byte[] Value { get; set; }
	public ASN1 Item { get; }

	// Methods

	// RVA: 0x1639790 Offset: 0x1637D90 VA: 0x181639790
	public void .ctor(byte tag) { }

	// RVA: 0x1639750 Offset: 0x1637D50 VA: 0x181639750
	public void .ctor(byte tag, byte[] data) { }

	// RVA: 0x16395B0 Offset: 0x1637BB0 VA: 0x1816395B0
	public void .ctor(byte[] data) { }

	// RVA: 0x16397D0 Offset: 0x1637DD0 VA: 0x1816397D0
	public int get_Count() { }

	// RVA: 0x49AF90 Offset: 0x499590 VA: 0x18049AF90
	public byte get_Tag() { }

	// RVA: 0x16398D0 Offset: 0x1637ED0 VA: 0x1816398D0
	public int get_Length() { }

	// RVA: 0x16398E0 Offset: 0x1637EE0 VA: 0x1816398E0
	public byte[] get_Value() { }

	// RVA: 0x1639980 Offset: 0x1637F80 VA: 0x181639980
	public void set_Value(byte[] value) { }

	// RVA: 0x1638650 Offset: 0x1636C50 VA: 0x181638650
	private bool CompareArray(byte[] array1, byte[] array2) { }

	// RVA: 0x16386F0 Offset: 0x1636CF0 VA: 0x1816386F0
	public bool CompareValue(byte[] value) { }

	// RVA: 0x16385B0 Offset: 0x1636BB0 VA: 0x1816385B0
	public ASN1 Add(ASN1 asn1) { }

	// RVA: 0x1638BF0 Offset: 0x16371F0 VA: 0x181638BF0 Slot: 4
	public virtual byte[] GetBytes() { }

	// RVA: 0x16388D0 Offset: 0x1636ED0 VA: 0x1816388D0
	protected void Decode(byte[] asn1, ref int anPos, int anLength) { }

	// RVA: 0x1638780 Offset: 0x1636D80 VA: 0x181638780
	protected void DecodeTLV(byte[] asn1, ref int pos, out byte tag, out int length, out byte[] content) { }

	// RVA: 0x16397F0 Offset: 0x1637DF0 VA: 0x1816397F0
	public ASN1 get_Item(int index) { }

	// RVA: 0x1638AE0 Offset: 0x16370E0 VA: 0x181638AE0
	public ASN1 Element(int index, byte anTag) { }

	// RVA: 0x16392E0 Offset: 0x16378E0 VA: 0x1816392E0 Slot: 3
	public override string ToString() { }

}

public class ASN1 // TypeDefIndex: 1704
{	// Fields
	private byte m_nTag; // 0x10
	private byte[] m_aValue; // 0x18
	private ArrayList elist; // 0x20

	// Properties
	public int Count { get; }
	public byte Tag { get; }
	public int Length { get; }
	public byte[] Value { get; set; }
	public ASN1 Item { get; }

	// Methods

	// RVA: 0x1639790 Offset: 0x1637D90 VA: 0x181639790
	public void .ctor(byte tag) { }

	// RVA: 0x1639750 Offset: 0x1637D50 VA: 0x181639750
	public void .ctor(byte tag, byte[] data) { }

	// RVA: 0x1AAE4F0 Offset: 0x1AACAF0 VA: 0x181AAE4F0
	public void .ctor(byte[] data) { }

	// RVA: 0x16397D0 Offset: 0x1637DD0 VA: 0x1816397D0
	public int get_Count() { }

	// RVA: 0x49AF90 Offset: 0x499590 VA: 0x18049AF90
	public byte get_Tag() { }

	// RVA: 0x16398D0 Offset: 0x1637ED0 VA: 0x1816398D0
	public int get_Length() { }

	// RVA: 0x1AAE770 Offset: 0x1AACD70 VA: 0x181AAE770
	public byte[] get_Value() { }

	// RVA: 0x1AAE810 Offset: 0x1AACE10 VA: 0x181AAE810
	public void set_Value(byte[] value) { }

	// RVA: 0x1638650 Offset: 0x1636C50 VA: 0x181638650
	private bool CompareArray(byte[] array1, byte[] array2) { }

	// RVA: 0x16386F0 Offset: 0x1636CF0 VA: 0x1816386F0
	public bool CompareValue(byte[] value) { }

	// RVA: 0x1AAD620 Offset: 0x1AABC20 VA: 0x181AAD620
	public ASN1 Add(ASN1 asn1) { }

	// RVA: 0x1AADB30 Offset: 0x1AAC130 VA: 0x181AADB30 Slot: 4
	public virtual byte[] GetBytes() { }

	// RVA: 0x1AAD810 Offset: 0x1AABE10 VA: 0x181AAD810
	protected void Decode(byte[] asn1, ref int anPos, int anLength) { }

	// RVA: 0x1AAD6C0 Offset: 0x1AABCC0 VA: 0x181AAD6C0
	protected void DecodeTLV(byte[] asn1, ref int pos, out byte tag, out int length, out byte[] content) { }

	// RVA: 0x1AAE690 Offset: 0x1AACC90 VA: 0x181AAE690
	public ASN1 get_Item(int index) { }

	// RVA: 0x1AADA20 Offset: 0x1AAC020 VA: 0x181AADA20
	public ASN1 Element(int index, byte anTag) { }

	// RVA: 0x1AAE220 Offset: 0x1AAC820 VA: 0x181AAE220 Slot: 3
	public override string ToString() { }

}

