internal sealed class ObjectMap // TypeDefIndex: 1088
{	// Fields
	internal string objectName; // 0x10
	internal Type objectType; // 0x18
	internal BinaryTypeEnum[] binaryTypeEnumA; // 0x20
	internal object[] typeInformationA; // 0x28
	internal Type[] memberTypes; // 0x30
	internal string[] memberNames; // 0x38
	internal ReadObjectInfo objectInfo; // 0x40
	internal bool isInitObjectInfo; // 0x48
	internal ObjectReader objectReader; // 0x50
	internal int objectId; // 0x58
	internal BinaryAssemblyInfo assemblyInfo; // 0x60

	// Methods

	// RVA: 0x11F7490 Offset: 0x11F5A90 VA: 0x1811F7490
	internal void .ctor(string objectName, Type objectType, string[] memberNames, ObjectReader objectReader, int objectId, BinaryAssemblyInfo assemblyInfo) { }

	// RVA: 0x11F6F10 Offset: 0x11F5510 VA: 0x1811F6F10
	internal void .ctor(string objectName, string[] memberNames, BinaryTypeEnum[] binaryTypeEnumA, object[] typeInformationA, int[] memberAssemIds, ObjectReader objectReader, int objectId, BinaryAssemblyInfo assemblyInfo, SizedArray assemIdToAssemblyTable) { }

	// RVA: 0x11F6D50 Offset: 0x11F5350 VA: 0x1811F6D50
	internal ReadObjectInfo CreateObjectInfo(ref SerializationInfo si, ref object[] memberData) { }

	// RVA: 0x11F6DA0 Offset: 0x11F53A0 VA: 0x1811F6DA0
	internal static ObjectMap Create(string name, Type objectType, string[] memberNames, ObjectReader objectReader, int objectId, BinaryAssemblyInfo assemblyInfo) { }

	// RVA: 0x11F6E40 Offset: 0x11F5440 VA: 0x1811F6E40
	internal static ObjectMap Create(string name, string[] memberNames, BinaryTypeEnum[] binaryTypeEnumA, object[] typeInformationA, int[] memberAssemIds, ObjectReader objectReader, int objectId, BinaryAssemblyInfo assemblyInfo, SizedArray assemIdToAssemblyTable) { }

}

internal class ObjectMap // TypeDefIndex: 2082
{	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

