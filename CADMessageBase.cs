internal class CADMessageBase // TypeDefIndex: 1227
{	// Fields
	protected object[] _args; // 0x10
	protected byte[] _serializedArgs; // 0x18
	protected int _propertyCount; // 0x20
	protected CADArgHolder _callContext; // 0x28
	internal byte[] serializedMethod; // 0x30

	// Methods

	// RVA: 0x1470940 Offset: 0x146EF40 VA: 0x181470940
	public void .ctor(IMethodMessage msg) { }

	// RVA: 0x146EEC0 Offset: 0x146D4C0 VA: 0x18146EEC0
	internal MethodBase GetMethod() { }

	// RVA: 0x146EF90 Offset: 0x146D590 VA: 0x18146EF90
	protected static Type[] GetSignature(MethodBase methodBase, bool load) { }

	// RVA: 0x146F630 Offset: 0x146DC30 VA: 0x18146F630
	internal static int MarshalProperties(IDictionary dict, ref ArrayList args) { }

	// RVA: 0x14707E0 Offset: 0x146EDE0 VA: 0x1814707E0
	internal static void UnmarshalProperties(IDictionary dict, int count, ArrayList args) { }

	// RVA: 0x146F1B0 Offset: 0x146D7B0 VA: 0x18146F1B0
	private static bool IsPossibleToIgnoreMarshal(object obj) { }

	// RVA: 0x146F390 Offset: 0x146D990 VA: 0x18146F390
	protected object MarshalArgument(object arg, ref ArrayList args) { }

	// RVA: 0x146FC90 Offset: 0x146E290 VA: 0x18146FC90
	protected object UnmarshalArgument(object arg, ArrayList args) { }

	// RVA: 0x146F500 Offset: 0x146DB00 VA: 0x18146F500
	internal object[] MarshalArguments(object[] arguments, ref ArrayList args) { }

	// RVA: 0x14706B0 Offset: 0x146ECB0 VA: 0x1814706B0
	internal object[] UnmarshalArguments(object[] arguments, ArrayList args) { }

	// RVA: 0x146FAF0 Offset: 0x146E0F0 VA: 0x18146FAF0
	protected void SaveLogicalCallContext(IMethodMessage msg, ref ArrayList serializeList) { }

	// RVA: 0x146EE30 Offset: 0x146D430 VA: 0x18146EE30
	internal LogicalCallContext GetLogicalCallContext(ArrayList args) { }

}

