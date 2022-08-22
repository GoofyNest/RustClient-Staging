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

	// RVA: 0x1639A50 Offset: 0x1638050 VA: 0x181639A50
	public void .ctor(byte tag) { }

	// RVA: 0x1639A10 Offset: 0x1638010 VA: 0x181639A10
	public void .ctor(byte tag, byte[] data) { }

	// RVA: 0x1639870 Offset: 0x1637E70 VA: 0x181639870
	public void .ctor(byte[] data) { }

	// RVA: 0x1639A90 Offset: 0x1638090 VA: 0x181639A90
	public int get_Count() { }

	// RVA: 0x49AF90 Offset: 0x499590 VA: 0x18049AF90
	public byte get_Tag() { }

	// RVA: 0x1639B90 Offset: 0x1638190 VA: 0x181639B90
	public int get_Length() { }

	// RVA: 0x1639BA0 Offset: 0x16381A0 VA: 0x181639BA0
	public byte[] get_Value() { }

	// RVA: 0x1639C40 Offset: 0x1638240 VA: 0x181639C40
	public void set_Value(byte[] value) { }

	// RVA: 0x1638910 Offset: 0x1636F10 VA: 0x181638910
	private bool CompareArray(byte[] array1, byte[] array2) { }

	// RVA: 0x16389B0 Offset: 0x1636FB0 VA: 0x1816389B0
	public bool CompareValue(byte[] value) { }

	// RVA: 0x1638870 Offset: 0x1636E70 VA: 0x181638870
	public ASN1 Add(ASN1 asn1) { }

	// RVA: 0x1638EB0 Offset: 0x16374B0 VA: 0x181638EB0 Slot: 4
	public virtual byte[] GetBytes() { }

	// RVA: 0x1638B90 Offset: 0x1637190 VA: 0x181638B90
	protected void Decode(byte[] asn1, ref int anPos, int anLength) { }

	// RVA: 0x1638A40 Offset: 0x1637040 VA: 0x181638A40
	protected void DecodeTLV(byte[] asn1, ref int pos, out byte tag, out int length, out byte[] content) { }

	// RVA: 0x1639AB0 Offset: 0x16380B0 VA: 0x181639AB0
	public ASN1 get_Item(int index) { }

	// RVA: 0x1638DA0 Offset: 0x16373A0 VA: 0x181638DA0
	public ASN1 Element(int index, byte anTag) { }

	// RVA: 0x16395A0 Offset: 0x1637BA0 VA: 0x1816395A0 Slot: 3
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

	// RVA: 0x1639A50 Offset: 0x1638050 VA: 0x181639A50
	public void .ctor(byte tag) { }

	// RVA: 0x1639A10 Offset: 0x1638010 VA: 0x181639A10
	public void .ctor(byte tag, byte[] data) { }

	// RVA: 0x1AAE5F0 Offset: 0x1AACBF0 VA: 0x181AAE5F0
	public void .ctor(byte[] data) { }

	// RVA: 0x1639A90 Offset: 0x1638090 VA: 0x181639A90
	public int get_Count() { }

	// RVA: 0x49AF90 Offset: 0x499590 VA: 0x18049AF90
	public byte get_Tag() { }

	// RVA: 0x1639B90 Offset: 0x1638190 VA: 0x181639B90
	public int get_Length() { }

	// RVA: 0x1AAE870 Offset: 0x1AACE70 VA: 0x181AAE870
	public byte[] get_Value() { }

	// RVA: 0x1AAE910 Offset: 0x1AACF10 VA: 0x181AAE910
	public void set_Value(byte[] value) { }

	// RVA: 0x1638910 Offset: 0x1636F10 VA: 0x181638910
	private bool CompareArray(byte[] array1, byte[] array2) { }

	// RVA: 0x16389B0 Offset: 0x1636FB0 VA: 0x1816389B0
	public bool CompareValue(byte[] value) { }

	// RVA: 0x1AAD720 Offset: 0x1AABD20 VA: 0x181AAD720
	public ASN1 Add(ASN1 asn1) { }

	// RVA: 0x1AADC30 Offset: 0x1AAC230 VA: 0x181AADC30 Slot: 4
	public virtual byte[] GetBytes() { }

	// RVA: 0x1AAD910 Offset: 0x1AABF10 VA: 0x181AAD910
	protected void Decode(byte[] asn1, ref int anPos, int anLength) { }

	// RVA: 0x1AAD7C0 Offset: 0x1AABDC0 VA: 0x181AAD7C0
	protected void DecodeTLV(byte[] asn1, ref int pos, out byte tag, out int length, out byte[] content) { }

	// RVA: 0x1AAE790 Offset: 0x1AACD90 VA: 0x181AAE790
	public ASN1 get_Item(int index) { }

	// RVA: 0x1AADB20 Offset: 0x1AAC120 VA: 0x181AADB20
	public ASN1 Element(int index, byte anTag) { }

	// RVA: 0x1AAE320 Offset: 0x1AAC920 VA: 0x181AAE320 Slot: 3
	public override string ToString() { }

}

