public class ObjectManager // TypeDefIndex: 1037
{	// Fields
	private DeserializationEventHandler m_onDeserializationHandler; // 0x10
	private SerializationEventHandler m_onDeserializedHandler; // 0x18
	internal ObjectHolder[] m_objects; // 0x20
	internal object m_topObject; // 0x28
	internal ObjectHolderList m_specialFixupObjects; // 0x30
	internal long m_fixupCount; // 0x38
	internal ISurrogateSelector m_selector; // 0x40
	internal StreamingContext m_context; // 0x48

	// Properties
	internal object TopObject { get; set; }
	internal ObjectHolderList SpecialFixupObjects { get; }

	// Methods

	// RVA: 0x1299330 Offset: 0x1297930 VA: 0x181299330
	internal void .ctor(ISurrogateSelector selector, StreamingContext context, bool checkSecurity, bool isCrossAppDomain) { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0
	private bool CanCallGetType(object obj) { }

	// RVA: 0x7EE9E0 Offset: 0x7ECFE0 VA: 0x1807EE9E0
	internal void set_TopObject(object value) { }

	// RVA: 0x7EE9D0 Offset: 0x7ECFD0 VA: 0x1807EE9D0
	internal object get_TopObject() { }

	// RVA: 0x12993C0 Offset: 0x12979C0 VA: 0x1812993C0
	internal ObjectHolderList get_SpecialFixupObjects() { }

	// RVA: 0x12976C0 Offset: 0x1295CC0 VA: 0x1812976C0
	internal ObjectHolder FindObjectHolder(long objectID) { }

	// RVA: 0x1297720 Offset: 0x1295D20 VA: 0x181297720
	internal ObjectHolder FindOrCreateObjectHolder(long objectID) { }

	// RVA: 0x12955F0 Offset: 0x1293BF0 VA: 0x1812955F0
	private void AddObjectHolder(ObjectHolder holder) { }

	// RVA: 0x1297B90 Offset: 0x1296190 VA: 0x181297B90
	private bool GetCompletionInfo(FixupHolder fixup, out ObjectHolder holder, out object member, bool bThrowIfMissing) { }

	// RVA: 0x1297870 Offset: 0x1295E70 VA: 0x181297870
	private void FixupSpecialObject(ObjectHolder holder) { }

	// RVA: 0x1299120 Offset: 0x1297720 VA: 0x181299120
	private bool ResolveObjectReference(ObjectHolder holder) { }

	// RVA: 0x12970A0 Offset: 0x12956A0 VA: 0x1812970A0
	private bool DoValueTypeFixup(FieldInfo memberToFix, ObjectHolder holder, object value) { }

	// RVA: 0x1295B80 Offset: 0x1294180 VA: 0x181295B80
	internal void CompleteObject(ObjectHolder holder, bool bObjectFullyComplete) { }

	// RVA: 0x1296EE0 Offset: 0x12954E0 VA: 0x181296EE0
	private void DoNewlyRegisteredObjectFixups(ObjectHolder holder) { }

	// RVA: 0x1298020 Offset: 0x1296620 VA: 0x181298020 Slot: 4
	public virtual object GetObject(long objectID) { }

	// RVA: 0x1298FC0 Offset: 0x12975C0 VA: 0x181298FC0
	internal void RegisterString(string obj, long objectID, SerializationInfo info, long idOfContainingObj, MemberInfo member) { }

	// RVA: 0x1298960 Offset: 0x1296F60 VA: 0x181298960
	public void RegisterObject(object obj, long objectID, SerializationInfo info, long idOfContainingObj, MemberInfo member, int[] arrayIndex) { }

	// RVA: 0x1295890 Offset: 0x1293E90 VA: 0x181295890
	internal void CompleteISerializableObject(object obj, SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1297F10 Offset: 0x1296510 VA: 0x181297F10
	internal static RuntimeConstructorInfo GetConstructor(RuntimeType t) { }

	// RVA: 0x1296AE0 Offset: 0x12950E0 VA: 0x181296AE0 Slot: 5
	public virtual void DoFixups() { }

	// RVA: 0x12987B0 Offset: 0x1296DB0 VA: 0x1812987B0
	private void RegisterFixup(FixupHolder fixup, long objectToBeFixed, long objectRequired) { }

	// RVA: 0x1298560 Offset: 0x1296B60 VA: 0x181298560 Slot: 6
	public virtual void RecordFixup(long objectToBeFixed, MemberInfo member, long objectRequired) { }

	// RVA: 0x1298420 Offset: 0x1296A20 VA: 0x181298420 Slot: 7
	public virtual void RecordDelayedFixup(long objectToBeFixed, string memberName, long objectRequired) { }

	// RVA: 0x12982E0 Offset: 0x12968E0 VA: 0x1812982E0 Slot: 8
	public virtual void RecordArrayElementFixup(long arrayToBeFixed, int[] indices, long objectRequired) { }

	// RVA: 0x1298130 Offset: 0x1296730 VA: 0x181298130 Slot: 9
	public virtual void RaiseDeserializationEvent() { }

	// RVA: 0x1295760 Offset: 0x1293D60 VA: 0x181295760 Slot: 10
	internal virtual void AddOnDeserialization(DeserializationEventHandler handler) { }

	// RVA: 0x12957E0 Offset: 0x1293DE0 VA: 0x1812957E0 Slot: 11
	internal virtual void AddOnDeserialized(object obj) { }

	// RVA: 0x1298180 Offset: 0x1296780 VA: 0x181298180 Slot: 12
	internal virtual void RaiseOnDeserializedEvent(object obj) { }

	// RVA: 0x1298230 Offset: 0x1296830 VA: 0x181298230
	public void RaiseOnDeserializingEvent(object obj) { }

}

