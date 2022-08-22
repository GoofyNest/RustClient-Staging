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

	// RVA: 0x1298C90 Offset: 0x1297290 VA: 0x181298C90
	internal void .ctor(ISurrogateSelector selector, StreamingContext context, bool checkSecurity, bool isCrossAppDomain) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250
	private bool CanCallGetType(object obj) { }

	// RVA: 0x7EE450 Offset: 0x7ECA50 VA: 0x1807EE450
	internal void set_TopObject(object value) { }

	// RVA: 0x7EE440 Offset: 0x7ECA40 VA: 0x1807EE440
	internal object get_TopObject() { }

	// RVA: 0x1298D20 Offset: 0x1297320 VA: 0x181298D20
	internal ObjectHolderList get_SpecialFixupObjects() { }

	// RVA: 0x1297020 Offset: 0x1295620 VA: 0x181297020
	internal ObjectHolder FindObjectHolder(long objectID) { }

	// RVA: 0x1297080 Offset: 0x1295680 VA: 0x181297080
	internal ObjectHolder FindOrCreateObjectHolder(long objectID) { }

	// RVA: 0x1294F50 Offset: 0x1293550 VA: 0x181294F50
	private void AddObjectHolder(ObjectHolder holder) { }

	// RVA: 0x12974F0 Offset: 0x1295AF0 VA: 0x1812974F0
	private bool GetCompletionInfo(FixupHolder fixup, out ObjectHolder holder, out object member, bool bThrowIfMissing) { }

	// RVA: 0x12971D0 Offset: 0x12957D0 VA: 0x1812971D0
	private void FixupSpecialObject(ObjectHolder holder) { }

	// RVA: 0x1298A80 Offset: 0x1297080 VA: 0x181298A80
	private bool ResolveObjectReference(ObjectHolder holder) { }

	// RVA: 0x1296A00 Offset: 0x1295000 VA: 0x181296A00
	private bool DoValueTypeFixup(FieldInfo memberToFix, ObjectHolder holder, object value) { }

	// RVA: 0x12954E0 Offset: 0x1293AE0 VA: 0x1812954E0
	internal void CompleteObject(ObjectHolder holder, bool bObjectFullyComplete) { }

	// RVA: 0x1296840 Offset: 0x1294E40 VA: 0x181296840
	private void DoNewlyRegisteredObjectFixups(ObjectHolder holder) { }

	// RVA: 0x1297980 Offset: 0x1295F80 VA: 0x181297980 Slot: 4
	public virtual object GetObject(long objectID) { }

	// RVA: 0x1298920 Offset: 0x1296F20 VA: 0x181298920
	internal void RegisterString(string obj, long objectID, SerializationInfo info, long idOfContainingObj, MemberInfo member) { }

	// RVA: 0x12982C0 Offset: 0x12968C0 VA: 0x1812982C0
	public void RegisterObject(object obj, long objectID, SerializationInfo info, long idOfContainingObj, MemberInfo member, int[] arrayIndex) { }

	// RVA: 0x12951F0 Offset: 0x12937F0 VA: 0x1812951F0
	internal void CompleteISerializableObject(object obj, SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1297870 Offset: 0x1295E70 VA: 0x181297870
	internal static RuntimeConstructorInfo GetConstructor(RuntimeType t) { }

	// RVA: 0x1296440 Offset: 0x1294A40 VA: 0x181296440 Slot: 5
	public virtual void DoFixups() { }

	// RVA: 0x1298110 Offset: 0x1296710 VA: 0x181298110
	private void RegisterFixup(FixupHolder fixup, long objectToBeFixed, long objectRequired) { }

	// RVA: 0x1297EC0 Offset: 0x12964C0 VA: 0x181297EC0 Slot: 6
	public virtual void RecordFixup(long objectToBeFixed, MemberInfo member, long objectRequired) { }

	// RVA: 0x1297D80 Offset: 0x1296380 VA: 0x181297D80 Slot: 7
	public virtual void RecordDelayedFixup(long objectToBeFixed, string memberName, long objectRequired) { }

	// RVA: 0x1297C40 Offset: 0x1296240 VA: 0x181297C40 Slot: 8
	public virtual void RecordArrayElementFixup(long arrayToBeFixed, int[] indices, long objectRequired) { }

	// RVA: 0x1297A90 Offset: 0x1296090 VA: 0x181297A90 Slot: 9
	public virtual void RaiseDeserializationEvent() { }

	// RVA: 0x12950C0 Offset: 0x12936C0 VA: 0x1812950C0 Slot: 10
	internal virtual void AddOnDeserialization(DeserializationEventHandler handler) { }

	// RVA: 0x1295140 Offset: 0x1293740 VA: 0x181295140 Slot: 11
	internal virtual void AddOnDeserialized(object obj) { }

	// RVA: 0x1297AE0 Offset: 0x12960E0 VA: 0x181297AE0 Slot: 12
	internal virtual void RaiseOnDeserializedEvent(object obj) { }

	// RVA: 0x1297B90 Offset: 0x1296190 VA: 0x181297B90
	public void RaiseOnDeserializingEvent(object obj) { }

}

