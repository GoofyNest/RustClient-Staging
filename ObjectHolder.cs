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

	// RVA: 0x12941F0 Offset: 0x12927F0 VA: 0x1812941F0
	internal void .ctor(long objID) { }

	// RVA: 0x1293FA0 Offset: 0x12925A0 VA: 0x181293FA0
	internal void .ctor(object obj, long objID, SerializationInfo info, ISerializationSurrogate surrogate, long idOfContainingObj, FieldInfo field, int[] arrayIndex) { }

	// RVA: 0x1293E80 Offset: 0x1292480 VA: 0x181293E80
	internal void .ctor(string obj, long objID, SerializationInfo info, ISerializationSurrogate surrogate, long idOfContainingObj, FieldInfo field, int[] arrayIndex) { }

	// RVA: 0x1293A00 Offset: 0x1292000 VA: 0x181293A00
	private void IncrementDescendentFixups(int amount) { }

	// RVA: 0x12939A0 Offset: 0x1291FA0 VA: 0x1812939A0
	internal void DecrementFixupsRemaining(ObjectManager manager) { }

	// RVA: 0x1293A20 Offset: 0x1292020 VA: 0x181293A20
	internal void RemoveDependency(long id) { }

	// RVA: 0x12938B0 Offset: 0x1291EB0 VA: 0x1812938B0
	internal void AddFixup(FixupHolder fixup, ObjectManager manager) { }

	// RVA: 0x1293E20 Offset: 0x1292420 VA: 0x181293E20
	private void UpdateDescendentDependencyChain(int amount, ObjectManager manager) { }

	// RVA: 0x1293730 Offset: 0x1291D30 VA: 0x181293730
	internal void AddDependency(long dependentObject) { }

	// RVA: 0x1293C50 Offset: 0x1292250 VA: 0x181293C50
	internal void UpdateData(object obj, SerializationInfo info, ISerializationSurrogate surrogate, long idOfContainer, FieldInfo field, int[] arrayIndex, ObjectManager manager) { }

	// RVA: 0x1293A10 Offset: 0x1292010 VA: 0x181293A10
	internal void MarkForCompletionWhenAvailable() { }

	// RVA: 0x1293AB0 Offset: 0x12920B0 VA: 0x181293AB0
	internal void SetFlags() { }

	// RVA: 0xD85D70 Offset: 0xD84370 VA: 0x180D85D70
	internal bool get_IsIncompleteObjectReference() { }

	// RVA: 0x1294400 Offset: 0x1292A00 VA: 0x181294400
	internal void set_IsIncompleteObjectReference(bool value) { }

	// RVA: 0x1294390 Offset: 0x1292990 VA: 0x181294390
	internal bool get_RequiresDelayedFixup() { }

	// RVA: 0xD85D60 Offset: 0xD84360 VA: 0x180D85D60
	internal bool get_RequiresValueTypeFixup() { }

	// RVA: 0x12943D0 Offset: 0x12929D0 VA: 0x1812943D0
	internal bool get_ValueTypeFixupPerformed() { }

	// RVA: 0x1294440 Offset: 0x1292A40 VA: 0x181294440
	internal void set_ValueTypeFixupPerformed(bool value) { }

	// RVA: 0xE6AE70 Offset: 0xE69470 VA: 0x180E6AE70
	internal bool get_HasISerializable() { }

	// RVA: 0x1294380 Offset: 0x1292980 VA: 0x181294380
	internal bool get_HasSurrogate() { }

	// RVA: 0x12942C0 Offset: 0x12928C0 VA: 0x1812942C0
	internal bool get_CanSurrogatedObjectValueChange() { }

	// RVA: 0x12942A0 Offset: 0x12928A0 VA: 0x1812942A0
	internal bool get_CanObjectValueChange() { }

	// RVA: 0x4D37D0 Offset: 0x4D1DD0 VA: 0x1804D37D0
	internal int get_DirectlyDependentObjects() { }

	// RVA: 0x12943C0 Offset: 0x12929C0 VA: 0x1812943C0
	internal int get_TotalDependentObjects() { }

	// RVA: 0x82CA00 Offset: 0x82B000 VA: 0x18082CA00
	internal bool get_Reachable() { }

	// RVA: 0xE69910 Offset: 0xE67F10 VA: 0x180E69910
	internal void set_Reachable(bool value) { }

	// RVA: 0x117E9B0 Offset: 0x117CFB0 VA: 0x18117E9B0
	internal bool get_TypeLoadExceptionReachable() { }

	// RVA: 0x536320 Offset: 0x534920 VA: 0x180536320
	internal TypeLoadExceptionHolder get_TypeLoadException() { }

	// RVA: 0x536330 Offset: 0x534930 VA: 0x180536330
	internal void set_TypeLoadException(TypeLoadExceptionHolder value) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	internal object get_ObjectValue() { }

	// RVA: 0x1293B30 Offset: 0x1292130 VA: 0x181293B30
	internal void SetObjectValue(object obj, ObjectManager manager) { }

	// RVA: 0x7EE330 Offset: 0x7EC930 VA: 0x1807EE330
	internal SerializationInfo get_SerializationInfo() { }

	// RVA: 0x7EE340 Offset: 0x7EC940 VA: 0x1807EE340
	internal void set_SerializationInfo(SerializationInfo value) { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	internal ISerializationSurrogate get_Surrogate() { }

	// RVA: 0x4BC5B0 Offset: 0x4BABB0 VA: 0x1804BC5B0
	internal LongList get_DependentObjects() { }

	// RVA: 0x4BC610 Offset: 0x4BAC10 VA: 0x1804BC610
	internal void set_DependentObjects(LongList value) { }

	// RVA: 0x12943A0 Offset: 0x12929A0 VA: 0x1812943A0
	internal bool get_RequiresSerInfoFixup() { }

	// RVA: 0x1294420 Offset: 0x1292A20 VA: 0x181294420
	internal void set_RequiresSerInfoFixup(bool value) { }

	// RVA: 0x4CF860 Offset: 0x4CDE60 VA: 0x1804CF860
	internal ValueTypeFixupInfo get_ValueFixup() { }

	// RVA: 0x1294350 Offset: 0x1292950 VA: 0x181294350
	internal bool get_CompletelyFixed() { }

	// RVA: 0x1294370 Offset: 0x1292970 VA: 0x181294370
	internal long get_ContainerID() { }

}

