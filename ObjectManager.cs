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

	// RVA: 0x12989D0 Offset: 0x1296FD0 VA: 0x1812989D0
	internal void .ctor(ISurrogateSelector selector, StreamingContext context, bool checkSecurity, bool isCrossAppDomain) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250
	private bool CanCallGetType(object obj) { }

	// RVA: 0x7EE340 Offset: 0x7EC940 VA: 0x1807EE340
	internal void set_TopObject(object value) { }

	// RVA: 0x7EE330 Offset: 0x7EC930 VA: 0x1807EE330
	internal object get_TopObject() { }

	// RVA: 0x1298A60 Offset: 0x1297060 VA: 0x181298A60
	internal ObjectHolderList get_SpecialFixupObjects() { }

	// RVA: 0x1296D60 Offset: 0x1295360 VA: 0x181296D60
	internal ObjectHolder FindObjectHolder(long objectID) { }

	// RVA: 0x1296DC0 Offset: 0x12953C0 VA: 0x181296DC0
	internal ObjectHolder FindOrCreateObjectHolder(long objectID) { }

	// RVA: 0x1294C90 Offset: 0x1293290 VA: 0x181294C90
	private void AddObjectHolder(ObjectHolder holder) { }

	// RVA: 0x1297230 Offset: 0x1295830 VA: 0x181297230
	private bool GetCompletionInfo(FixupHolder fixup, out ObjectHolder holder, out object member, bool bThrowIfMissing) { }

	// RVA: 0x1296F10 Offset: 0x1295510 VA: 0x181296F10
	private void FixupSpecialObject(ObjectHolder holder) { }

	// RVA: 0x12987C0 Offset: 0x1296DC0 VA: 0x1812987C0
	private bool ResolveObjectReference(ObjectHolder holder) { }

	// RVA: 0x1296740 Offset: 0x1294D40 VA: 0x181296740
	private bool DoValueTypeFixup(FieldInfo memberToFix, ObjectHolder holder, object value) { }

	// RVA: 0x1295220 Offset: 0x1293820 VA: 0x181295220
	internal void CompleteObject(ObjectHolder holder, bool bObjectFullyComplete) { }

	// RVA: 0x1296580 Offset: 0x1294B80 VA: 0x181296580
	private void DoNewlyRegisteredObjectFixups(ObjectHolder holder) { }

	// RVA: 0x12976C0 Offset: 0x1295CC0 VA: 0x1812976C0 Slot: 4
	public virtual object GetObject(long objectID) { }

	// RVA: 0x1298660 Offset: 0x1296C60 VA: 0x181298660
	internal void RegisterString(string obj, long objectID, SerializationInfo info, long idOfContainingObj, MemberInfo member) { }

	// RVA: 0x1298000 Offset: 0x1296600 VA: 0x181298000
	public void RegisterObject(object obj, long objectID, SerializationInfo info, long idOfContainingObj, MemberInfo member, int[] arrayIndex) { }

	// RVA: 0x1294F30 Offset: 0x1293530 VA: 0x181294F30
	internal void CompleteISerializableObject(object obj, SerializationInfo info, StreamingContext context) { }

	// RVA: 0x12975B0 Offset: 0x1295BB0 VA: 0x1812975B0
	internal static RuntimeConstructorInfo GetConstructor(RuntimeType t) { }

	// RVA: 0x1296180 Offset: 0x1294780 VA: 0x181296180 Slot: 5
	public virtual void DoFixups() { }

	// RVA: 0x1297E50 Offset: 0x1296450 VA: 0x181297E50
	private void RegisterFixup(FixupHolder fixup, long objectToBeFixed, long objectRequired) { }

	// RVA: 0x1297C00 Offset: 0x1296200 VA: 0x181297C00 Slot: 6
	public virtual void RecordFixup(long objectToBeFixed, MemberInfo member, long objectRequired) { }

	// RVA: 0x1297AC0 Offset: 0x12960C0 VA: 0x181297AC0 Slot: 7
	public virtual void RecordDelayedFixup(long objectToBeFixed, string memberName, long objectRequired) { }

	// RVA: 0x1297980 Offset: 0x1295F80 VA: 0x181297980 Slot: 8
	public virtual void RecordArrayElementFixup(long arrayToBeFixed, int[] indices, long objectRequired) { }

	// RVA: 0x12977D0 Offset: 0x1295DD0 VA: 0x1812977D0 Slot: 9
	public virtual void RaiseDeserializationEvent() { }

	// RVA: 0x1294E00 Offset: 0x1293400 VA: 0x181294E00 Slot: 10
	internal virtual void AddOnDeserialization(DeserializationEventHandler handler) { }

	// RVA: 0x1294E80 Offset: 0x1293480 VA: 0x181294E80 Slot: 11
	internal virtual void AddOnDeserialized(object obj) { }

	// RVA: 0x1297820 Offset: 0x1295E20 VA: 0x181297820 Slot: 12
	internal virtual void RaiseOnDeserializedEvent(object obj) { }

	// RVA: 0x12978D0 Offset: 0x1295ED0 VA: 0x1812978D0
	public void RaiseOnDeserializingEvent(object obj) { }

}

