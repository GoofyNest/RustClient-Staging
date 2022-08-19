internal struct ResourceLocator // TypeDefIndex: 494
{	// Fields
	internal object _value; // 0x0
	internal int _dataPos; // 0x8

	// Properties
	internal int DataPosition { get; }
	internal object Value { get; set; }

	// Methods

	// RVA: 0x14C910 Offset: 0x14BD10 VA: 0x18014C910
	internal void .ctor(int dataPos, object value) { }

	// RVA: 0x122E90 Offset: 0x122290 VA: 0x180122E90
	internal int get_DataPosition() { }

	// RVA: 0xFC8C0 Offset: 0xFBCC0 VA: 0x1800FC8C0
	internal object get_Value() { }

	// RVA: 0xF1510 Offset: 0xF0910 VA: 0x1800F1510
	internal void set_Value(object value) { }

	// RVA: 0xFEC610 Offset: 0xFEAC10 VA: 0x180FEC610
	internal static bool CanCache(ResourceTypeCode value) { }

}

