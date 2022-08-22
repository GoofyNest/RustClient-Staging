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

	// RVA: 0x1206EE0 Offset: 0x12054E0 VA: 0x181206EE0
	internal void .ctor(Array arrayObj, int[] indexMap) { }

	// RVA: 0x1206F40 Offset: 0x1205540 VA: 0x181206F40
	internal void .ctor(object memberObject, string memberName, ReadObjectInfo objectInfo) { }

	// RVA: 0x1206BF0 Offset: 0x12051F0 VA: 0x181206BF0
	internal void Fixup(ParseRecord record, ParseRecord parent) { }

}

