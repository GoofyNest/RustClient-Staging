internal sealed class ValueFixup // TypeDefIndex: 1122
{	// Fields
	internal ValueFixupEnum valueFixupEnum; // 0x10
	internal Array arrayObj; // 0x18
	internal int[] indexMap; // 0x20
	internal object header; // 0x28
	internal object memberObject; // 0x30
	internal static MemberInfo valueInfo; // 0x0
	internal ReadObjectInfo objectInfo; // 0x38
	internal string memberName; // 0x40

	// Methods

	// RVA: 0x1207580 Offset: 0x1205B80 VA: 0x181207580
	internal void .ctor(Array arrayObj, int[] indexMap) { }

	// RVA: 0x12075E0 Offset: 0x1205BE0 VA: 0x1812075E0
	internal void .ctor(object memberObject, string memberName, ReadObjectInfo objectInfo) { }

	// RVA: 0x1207290 Offset: 0x1205890 VA: 0x181207290
	internal void Fixup(ParseRecord record, ParseRecord parent) { }

}

