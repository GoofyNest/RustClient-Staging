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

	// RVA: 0x1294B50 Offset: 0x1293150 VA: 0x181294B50
	internal void .ctor(long objID) { }

	// RVA: 0x1294900 Offset: 0x1292F00 VA: 0x181294900
	internal void .ctor(object obj, long objID, SerializationInfo info, ISerializationSurrogate surrogate, long idOfContainingObj, FieldInfo field, int[] arrayIndex) { }

	// RVA: 0x12947E0 Offset: 0x1292DE0 VA: 0x1812947E0
	internal void .ctor(string obj, long objID, SerializationInfo info, ISerializationSurrogate surrogate, long idOfContainingObj, FieldInfo field, int[] arrayIndex) { }

	// RVA: 0x1294360 Offset: 0x1292960 VA: 0x181294360
	private void IncrementDescendentFixups(int amount) { }

	// RVA: 0x1294300 Offset: 0x1292900 VA: 0x181294300
	internal void DecrementFixupsRemaining(ObjectManager manager) { }

	// RVA: 0x1294380 Offset: 0x1292980 VA: 0x181294380
	internal void RemoveDependency(long id) { }

	// RVA: 0x1294210 Offset: 0x1292810 VA: 0x181294210
	internal void AddFixup(FixupHolder fixup, ObjectManager manager) { }

	// RVA: 0x1294780 Offset: 0x1292D80 VA: 0x181294780
	private void UpdateDescendentDependencyChain(int amount, ObjectManager manager) { }

	// RVA: 0x1294090 Offset: 0x1292690 VA: 0x181294090
	internal void AddDependency(long dependentObject) { }

	// RVA: 0x12945B0 Offset: 0x1292BB0 VA: 0x1812945B0
	internal void UpdateData(object obj, SerializationInfo info, ISerializationSurrogate surrogate, long idOfContainer, FieldInfo field, int[] arrayIndex, ObjectManager manager) { }

	// RVA: 0x1294370 Offset: 0x1292970 VA: 0x181294370
	internal void MarkForCompletionWhenAvailable() { }

	// RVA: 0x1294410 Offset: 0x1292A10 VA: 0x181294410
	internal void SetFlags() { }

	// RVA: 0xD86AE0 Offset: 0xD850E0 VA: 0x180D86AE0
	internal bool get_IsIncompleteObjectReference() { }

	// RVA: 0x1294D60 Offset: 0x1293360 VA: 0x181294D60
	internal void set_IsIncompleteObjectReference(bool value) { }

	// RVA: 0x1294CF0 Offset: 0x12932F0 VA: 0x181294CF0
	internal bool get_RequiresDelayedFixup() { }

	// RVA: 0xD86AD0 Offset: 0xD850D0 VA: 0x180D86AD0
	internal bool get_RequiresValueTypeFixup() { }

	// RVA: 0x1294D30 Offset: 0x1293330 VA: 0x181294D30
	internal bool get_ValueTypeFixupPerformed() { }

	// RVA: 0x1294DA0 Offset: 0x12933A0 VA: 0x181294DA0
	internal void set_ValueTypeFixupPerformed(bool value) { }

	// RVA: 0xE6BBE0 Offset: 0xE6A1E0 VA: 0x180E6BBE0
	internal bool get_HasISerializable() { }

	// RVA: 0x1294CE0 Offset: 0x12932E0 VA: 0x181294CE0
	internal bool get_HasSurrogate() { }

	// RVA: 0x1294C20 Offset: 0x1293220 VA: 0x181294C20
	internal bool get_CanSurrogatedObjectValueChange() { }

	// RVA: 0x1294C00 Offset: 0x1293200 VA: 0x181294C00
	internal bool get_CanObjectValueChange() { }

	// RVA: 0x4D3760 Offset: 0x4D1D60 VA: 0x1804D3760
	internal int get_DirectlyDependentObjects() { }

	// RVA: 0x1294D20 Offset: 0x1293320 VA: 0x181294D20
	internal int get_TotalDependentObjects() { }

	// RVA: 0x82D060 Offset: 0x82B660 VA: 0x18082D060
	internal bool get_Reachable() { }

	// RVA: 0xE6A680 Offset: 0xE68C80 VA: 0x180E6A680
	internal void set_Reachable(bool value) { }

	// RVA: 0x1183590 Offset: 0x1181B90 VA: 0x181183590
	internal bool get_TypeLoadExceptionReachable() { }

	// RVA: 0x5362B0 Offset: 0x5348B0 VA: 0x1805362B0
	internal TypeLoadExceptionHolder get_TypeLoadException() { }

	// RVA: 0x5362C0 Offset: 0x5348C0 VA: 0x1805362C0
	internal void set_TypeLoadException(TypeLoadExceptionHolder value) { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	internal object get_ObjectValue() { }

	// RVA: 0x1294490 Offset: 0x1292A90 VA: 0x181294490
	internal void SetObjectValue(object obj, ObjectManager manager) { }

	// RVA: 0x7EE9D0 Offset: 0x7ECFD0 VA: 0x1807EE9D0
	internal SerializationInfo get_SerializationInfo() { }

	// RVA: 0x7EE9E0 Offset: 0x7ECFE0 VA: 0x1807EE9E0
	internal void set_SerializationInfo(SerializationInfo value) { }

	// RVA: 0x4A5FE0 Offset: 0x4A45E0 VA: 0x1804A5FE0
	internal ISerializationSurrogate get_Surrogate() { }

	// RVA: 0x4BC540 Offset: 0x4BAB40 VA: 0x1804BC540
	internal LongList get_DependentObjects() { }

	// RVA: 0x4BC5A0 Offset: 0x4BABA0 VA: 0x1804BC5A0
	internal void set_DependentObjects(LongList value) { }

	// RVA: 0x1294D00 Offset: 0x1293300 VA: 0x181294D00
	internal bool get_RequiresSerInfoFixup() { }

	// RVA: 0x1294D80 Offset: 0x1293380 VA: 0x181294D80
	internal void set_RequiresSerInfoFixup(bool value) { }

	// RVA: 0x4CF7F0 Offset: 0x4CDDF0 VA: 0x1804CF7F0
	internal ValueTypeFixupInfo get_ValueFixup() { }

	// RVA: 0x1294CB0 Offset: 0x12932B0 VA: 0x181294CB0
	internal bool get_CompletelyFixed() { }

	// RVA: 0x1294CD0 Offset: 0x12932D0 VA: 0x181294CD0
	internal long get_ContainerID() { }

}

