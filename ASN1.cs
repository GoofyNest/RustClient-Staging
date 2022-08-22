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

	// RVA: 0x1AAE330 Offset: 0x1AAC930 VA: 0x181AAE330
	public void .ctor(byte[] data) { }

	// RVA: 0x16397D0 Offset: 0x1637DD0 VA: 0x1816397D0
	public int get_Count() { }

	// RVA: 0x49AF90 Offset: 0x499590 VA: 0x18049AF90
	public byte get_Tag() { }

	// RVA: 0x16398D0 Offset: 0x1637ED0 VA: 0x1816398D0
	public int get_Length() { }

	// RVA: 0x1AAE5B0 Offset: 0x1AACBB0 VA: 0x181AAE5B0
	public byte[] get_Value() { }

	// RVA: 0x1AAE650 Offset: 0x1AACC50 VA: 0x181AAE650
	public void set_Value(byte[] value) { }

	// RVA: 0x1638650 Offset: 0x1636C50 VA: 0x181638650
	private bool CompareArray(byte[] array1, byte[] array2) { }

	// RVA: 0x16386F0 Offset: 0x1636CF0 VA: 0x1816386F0
	public bool CompareValue(byte[] value) { }

	// RVA: 0x1AAD460 Offset: 0x1AABA60 VA: 0x181AAD460
	public ASN1 Add(ASN1 asn1) { }

	// RVA: 0x1AAD970 Offset: 0x1AABF70 VA: 0x181AAD970 Slot: 4
	public virtual byte[] GetBytes() { }

	// RVA: 0x1AAD650 Offset: 0x1AABC50 VA: 0x181AAD650
	protected void Decode(byte[] asn1, ref int anPos, int anLength) { }

	// RVA: 0x1AAD500 Offset: 0x1AABB00 VA: 0x181AAD500
	protected void DecodeTLV(byte[] asn1, ref int pos, out byte tag, out int length, out byte[] content) { }

	// RVA: 0x1AAE4D0 Offset: 0x1AACAD0 VA: 0x181AAE4D0
	public ASN1 get_Item(int index) { }

	// RVA: 0x1AAD860 Offset: 0x1AABE60 VA: 0x181AAD860
	public ASN1 Element(int index, byte anTag) { }

	// RVA: 0x1AAE060 Offset: 0x1AAC660 VA: 0x181AAE060 Slot: 3
	public override string ToString() { }

}

