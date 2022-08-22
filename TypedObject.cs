internal class TypedObject // TypeDefIndex: 2149
{	// Fields
	private TypedObject.DecimalStruct dstruct; // 0x10
	private object ovalue; // 0x18
	private string svalue; // 0x20
	private XmlSchemaDatatype xsdtype; // 0x28
	private int dim; // 0x30
	private bool isList; // 0x34

	// Properties
	public int Dim { get; }
	public bool IsList { get; }
	public bool IsDecimal { get; }
	public Decimal[] Dvalue { get; }
	public object Value { get; }
	public XmlSchemaDatatype Type { get; }

	// Methods

	// RVA: 0xA39490 Offset: 0xA37A90 VA: 0x180A39490
	public int get_Dim() { }

	// RVA: 0xBA2210 Offset: 0xBA0810 VA: 0x180BA2210
	public bool get_IsList() { }

	// RVA: 0xEF29C0 Offset: 0xEF0FC0 VA: 0x180EF29C0
	public bool get_IsDecimal() { }

	// RVA: 0x4D20B0 Offset: 0x4D06B0 VA: 0x1804D20B0
	public Decimal[] get_Dvalue() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public object get_Value() { }

	// RVA: 0x7EE9D0 Offset: 0x7ECFD0 VA: 0x1807EE9D0
	public XmlSchemaDatatype get_Type() { }

	// RVA: 0xEF27F0 Offset: 0xEF0DF0 VA: 0x180EF27F0
	public void .ctor(object obj, string svalue, XmlSchemaDatatype xsdtype) { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70 Slot: 3
	public override string ToString() { }

	// RVA: 0xEF24C0 Offset: 0xEF0AC0 VA: 0x180EF24C0
	public void SetDecimal() { }

	// RVA: 0xEF2380 Offset: 0xEF0980 VA: 0x180EF2380
	private bool ListDValueEquals(TypedObject other) { }

	// RVA: 0xEF1FF0 Offset: 0xEF05F0 VA: 0x180EF1FF0
	public bool Equals(TypedObject other) { }

}

private class TypedObject.DecimalStruct // TypeDefIndex: 2150
{	// Fields
	private bool isDecimal; // 0x10
	private Decimal[] dvalue; // 0x18

	// Properties
	public bool IsDecimal { get; set; }
	public Decimal[] Dvalue { get; }

	// Methods

	// RVA: 0x49AF90 Offset: 0x499590 VA: 0x18049AF90
	public bool get_IsDecimal() { }

	// RVA: 0x49AFC0 Offset: 0x4995C0 VA: 0x18049AFC0
	public void set_IsDecimal(bool value) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public Decimal[] get_Dvalue() { }

	// RVA: 0xEDB0D0 Offset: 0xED96D0 VA: 0x180EDB0D0
	public void .ctor() { }

	// RVA: 0xEDB130 Offset: 0xED9730 VA: 0x180EDB130
	public void .ctor(int dim) { }

}

