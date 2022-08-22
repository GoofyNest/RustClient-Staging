internal sealed class ObjectProgress // TypeDefIndex: 1089
{	// Fields
	internal static int opRecordIdCount; // 0x0
	internal bool isInitial; // 0x10
	internal int count; // 0x14
	internal BinaryTypeEnum expectedType; // 0x18
	internal object expectedTypeInformation; // 0x20
	internal string name; // 0x28
	internal InternalObjectTypeE objectTypeEnum; // 0x30
	internal InternalMemberTypeE memberTypeEnum; // 0x34
	internal InternalMemberValueE memberValueEnum; // 0x38
	internal Type dtType; // 0x40
	internal int numItems; // 0x48
	internal BinaryTypeEnum binaryTypeEnum; // 0x4C
	internal object typeInformation; // 0x50
	internal int nullCount; // 0x58
	internal int memberLength; // 0x5C
	internal BinaryTypeEnum[] binaryTypeEnumA; // 0x60
	internal object[] typeInformationA; // 0x68
	internal string[] memberNames; // 0x70
	internal Type[] memberTypes; // 0x78
	internal ParseRecord pr; // 0x80

	// Methods

	// RVA: 0x11F7B20 Offset: 0x11F6120 VA: 0x1811F7B20
	internal void .ctor() { }

	// RVA: 0x11F7A20 Offset: 0x11F6020 VA: 0x1811F7A20
	internal void Init() { }

	// RVA: 0x11F7880 Offset: 0x11F5E80 VA: 0x1811F7880
	internal void ArrayCountIncrement(int value) { }

	// RVA: 0x11F7890 Offset: 0x11F5E90 VA: 0x1811F7890
	internal bool GetNext(out BinaryTypeEnum outBinaryTypeEnum, out object outTypeInformation) { }

	// RVA: 0x11F7AE0 Offset: 0x11F60E0 VA: 0x1811F7AE0
	private static void .cctor() { }

}

