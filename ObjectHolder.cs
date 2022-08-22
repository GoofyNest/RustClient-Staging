internal sealed class ObjectHolder // TypeDefIndex: 1038
{	// Fields
	private object m_object; // 0x10
	internal long m_id; // 0x18
	private int m_missingElementsRemaining; // 0x20
	private int m_missingDecendents; // 0x24
	internal SerializationInfo m_serInfo; // 0x28
	internal ISerializationSurrogate m_surrogate; // 0x30
	internal FixupHolderList m_missingElements; // 0x38
	internal LongList m_dependentObjects; // 0x40
	internal ObjectHolder m_next; // 0x48
	internal int m_flags; // 0x50
	private bool m_markForFixupWhenAvailable; // 0x54
	private ValueTypeFixupInfo m_valueFixup; // 0x58
	private TypeLoadExceptionHolder m_typeLoad; // 0x60
	private bool m_reachable; // 0x68

	// Properties
	internal bool IsIncompleteObjectReference { get; set; }
	internal bool RequiresDelayedFixup { get; }
	internal bool RequiresValueTypeFixup { get; }
	internal bool ValueTypeFixupPerformed { get; set; }
	internal bool HasISerializable { get; }
	internal bool HasSurrogate { get; }
	internal bool CanSurrogatedObjectValueChange { get; }
	internal bool CanObjectValueChange { get; }
	internal int DirectlyDependentObjects { get; }
	internal int TotalDependentObjects { get; }
	internal bool Reachable { get; set; }
	internal bool TypeLoadExceptionReachable { get; }
	internal TypeLoadExceptionHolder TypeLoadException { get; set; }
	internal object ObjectValue { get; }
	internal SerializationInfo SerializationInfo { get; set; }
	internal ISerializationSurrogate Surrogate { get; }
	internal LongList DependentObjects { get; set; }
	internal bool RequiresSerInfoFixup { get; set; }
	internal ValueTypeFixupInfo ValueFixup { get; }
	internal bool CompletelyFixed { get; }
	internal long ContainerID { get; }

	// Methods

	// RVA: 0x12944B0 Offset: 0x1292AB0 VA: 0x1812944B0
	internal void .ctor(long objID) { }

	// RVA: 0x1294260 Offset: 0x1292860 VA: 0x181294260
	internal void .ctor(object obj, long objID, SerializationInfo info, ISerializationSurrogate surrogate, long idOfContainingObj, FieldInfo field, int[] arrayIndex) { }

	// RVA: 0x1294140 Offset: 0x1292740 VA: 0x181294140
	internal void .ctor(string obj, long objID, SerializationInfo info, ISerializationSurrogate surrogate, long idOfContainingObj, FieldInfo field, int[] arrayIndex) { }

	// RVA: 0x1293CC0 Offset: 0x12922C0 VA: 0x181293CC0
	private void IncrementDescendentFixups(int amount) { }

	// RVA: 0x1293C60 Offset: 0x1292260 VA: 0x181293C60
	internal void DecrementFixupsRemaining(ObjectManager manager) { }

	// RVA: 0x1293CE0 Offset: 0x12922E0 VA: 0x181293CE0
	internal void RemoveDependency(long id) { }

	// RVA: 0x1293B70 Offset: 0x1292170 VA: 0x181293B70
	internal void AddFixup(FixupHolder fixup, ObjectManager manager) { }

	// RVA: 0x12940E0 Offset: 0x12926E0 VA: 0x1812940E0
	private void UpdateDescendentDependencyChain(int amount, ObjectManager manager) { }

	// RVA: 0x12939F0 Offset: 0x1291FF0 VA: 0x1812939F0
	internal void AddDependency(long dependentObject) { }

	// RVA: 0x1293F10 Offset: 0x1292510 VA: 0x181293F10
	internal void UpdateData(object obj, SerializationInfo info, ISerializationSurrogate surrogate, long idOfContainer, FieldInfo field, int[] arrayIndex, ObjectManager manager) { }

	// RVA: 0x1293CD0 Offset: 0x12922D0 VA: 0x181293CD0
	internal void MarkForCompletionWhenAvailable() { }

	// RVA: 0x1293D70 Offset: 0x1292370 VA: 0x181293D70
	internal void SetFlags() { }

	// RVA: 0xD86030 Offset: 0xD84630 VA: 0x180D86030
	internal bool get_IsIncompleteObjectReference() { }

	// RVA: 0x12946C0 Offset: 0x1292CC0 VA: 0x1812946C0
	internal void set_IsIncompleteObjectReference(bool value) { }

	// RVA: 0x1294650 Offset: 0x1292C50 VA: 0x181294650
	internal bool get_RequiresDelayedFixup() { }

	// RVA: 0xD86020 Offset: 0xD84620 VA: 0x180D86020
	internal bool get_RequiresValueTypeFixup() { }

	// RVA: 0x1294690 Offset: 0x1292C90 VA: 0x181294690
	internal bool get_ValueTypeFixupPerformed() { }

	// RVA: 0x1294700 Offset: 0x1292D00 VA: 0x181294700
	internal void set_ValueTypeFixupPerformed(bool value) { }

	// RVA: 0xE6B130 Offset: 0xE69730 VA: 0x180E6B130
	internal bool get_HasISerializable() { }

	// RVA: 0x1294640 Offset: 0x1292C40 VA: 0x181294640
	internal bool get_HasSurrogate() { }

	// RVA: 0x1294580 Offset: 0x1292B80 VA: 0x181294580
	internal bool get_CanSurrogatedObjectValueChange() { }

	// RVA: 0x1294560 Offset: 0x1292B60 VA: 0x181294560
	internal bool get_CanObjectValueChange() { }

	// RVA: 0x4D37D0 Offset: 0x4D1DD0 VA: 0x1804D37D0
	internal int get_DirectlyDependentObjects() { }

	// RVA: 0x1294680 Offset: 0x1292C80 VA: 0x181294680
	internal int get_TotalDependentObjects() { }

	// RVA: 0x82CB10 Offset: 0x82B110 VA: 0x18082CB10
	internal bool get_Reachable() { }

	// RVA: 0xE69BD0 Offset: 0xE681D0 VA: 0x180E69BD0
	internal void set_Reachable(bool value) { }

	// RVA: 0x117EC70 Offset: 0x117D270 VA: 0x18117EC70
	internal bool get_TypeLoadExceptionReachable() { }

	// RVA: 0x536320 Offset: 0x534920 VA: 0x180536320
	internal TypeLoadExceptionHolder get_TypeLoadException() { }

	// RVA: 0x536330 Offset: 0x534930 VA: 0x180536330
	internal void set_TypeLoadException(TypeLoadExceptionHolder value) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	internal object get_ObjectValue() { }

	// RVA: 0x1293DF0 Offset: 0x12923F0 VA: 0x181293DF0
	internal void SetObjectValue(object obj, ObjectManager manager) { }

	// RVA: 0x7EE440 Offset: 0x7ECA40 VA: 0x1807EE440
	internal SerializationInfo get_SerializationInfo() { }

	// RVA: 0x7EE450 Offset: 0x7ECA50 VA: 0x1807EE450
	internal void set_SerializationInfo(SerializationInfo value) { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	internal ISerializationSurrogate get_Surrogate() { }

	// RVA: 0x4BC5B0 Offset: 0x4BABB0 VA: 0x1804BC5B0
	internal LongList get_DependentObjects() { }

	// RVA: 0x4BC610 Offset: 0x4BAC10 VA: 0x1804BC610
	internal void set_DependentObjects(LongList value) { }

	// RVA: 0x1294660 Offset: 0x1292C60 VA: 0x181294660
	internal bool get_RequiresSerInfoFixup() { }

	// RVA: 0x12946E0 Offset: 0x1292CE0 VA: 0x1812946E0
	internal void set_RequiresSerInfoFixup(bool value) { }

	// RVA: 0x4CF860 Offset: 0x4CDE60 VA: 0x1804CF860
	internal ValueTypeFixupInfo get_ValueFixup() { }

	// RVA: 0x1294610 Offset: 0x1292C10 VA: 0x181294610
	internal bool get_CompletelyFixed() { }

	// RVA: 0x1294630 Offset: 0x1292C30 VA: 0x181294630
	internal long get_ContainerID() { }

}

