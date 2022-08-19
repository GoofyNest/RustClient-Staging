internal class ListMap : ObjectMap // TypeDefIndex: 2129
{	// Fields
	private XmlTypeMapElementInfoList _itemInfo; // 0x10
	private string _choiceMember; // 0x18

	// Properties
	public string ChoiceMember { set; }
	public XmlTypeMapElementInfoList ItemInfo { get; set; }

	// Methods

	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0
	public void set_ChoiceMember(string value) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public XmlTypeMapElementInfoList get_ItemInfo() { }

	// RVA: 0x4BC630 Offset: 0x4BAC30 VA: 0x1804BC630
	public void set_ItemInfo(XmlTypeMapElementInfoList value) { }

	// RVA: 0x1100E80 Offset: 0x10FF480 VA: 0x181100E80
	public XmlTypeMapElementInfo FindElement(object ob, int index, object memberValue) { }

	// RVA: 0x11014B0 Offset: 0x10FFAB0 VA: 0x1811014B0
	public XmlTypeMapElementInfo FindElement(string elementName, string ns) { }

	// RVA: 0x11016B0 Offset: 0x10FFCB0 VA: 0x1811016B0
	public XmlTypeMapElementInfo FindTextElement() { }

	// RVA: 0x1101890 Offset: 0x10FFE90 VA: 0x181101890
	public void GetArrayType(int itemCount, out string localName, out string ns) { }

	// RVA: 0x1100D00 Offset: 0x10FF300 VA: 0x181100D00 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0xCCE560 Offset: 0xCCCB60 VA: 0x180CCE560 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

