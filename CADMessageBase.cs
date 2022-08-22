internal class CADMessageBase // TypeDefIndex: 1227
{	// Fields
	protected object[] _args; // 0x10
	protected byte[] _serializedArgs; // 0x18
	protected int _propertyCount; // 0x20
	protected CADArgHolder _callContext; // 0x28
	internal byte[] serializedMethod; // 0x30

	// Methods

	// RVA: 0x1470C00 Offset: 0x146F200 VA: 0x181470C00
	public void .ctor(IMethodMessage msg) { }

	// RVA: 0x146F180 Offset: 0x146D780 VA: 0x18146F180
	internal MethodBase GetMethod() { }

	// RVA: 0x146F250 Offset: 0x146D850 VA: 0x18146F250
	protected static Type[] GetSignature(MethodBase methodBase, bool load) { }

	// RVA: 0x146F8F0 Offset: 0x146DEF0 VA: 0x18146F8F0
	internal static int MarshalProperties(IDictionary dict, ref ArrayList args) { }

	// RVA: 0x1470AA0 Offset: 0x146F0A0 VA: 0x181470AA0
	internal static void UnmarshalProperties(IDictionary dict, int count, ArrayList args) { }

	// RVA: 0x146F470 Offset: 0x146DA70 VA: 0x18146F470
	private static bool IsPossibleToIgnoreMarshal(object obj) { }

	// RVA: 0x146F650 Offset: 0x146DC50 VA: 0x18146F650
	protected object MarshalArgument(object arg, ref ArrayList args) { }

	// RVA: 0x146FF50 Offset: 0x146E550 VA: 0x18146FF50
	protected object UnmarshalArgument(object arg, ArrayList args) { }

	// RVA: 0x146F7C0 Offset: 0x146DDC0 VA: 0x18146F7C0
	internal object[] MarshalArguments(object[] arguments, ref ArrayList args) { }

	// RVA: 0x1470970 Offset: 0x146EF70 VA: 0x181470970
	internal object[] UnmarshalArguments(object[] arguments, ArrayList args) { }

	// RVA: 0x146FDB0 Offset: 0x146E3B0 VA: 0x18146FDB0
	protected void SaveLogicalCallContext(IMethodMessage msg, ref ArrayList serializeList) { }

	// RVA: 0x146F0F0 Offset: 0x146D6F0 VA: 0x18146F0F0
	internal LogicalCallContext GetLogicalCallContext(ArrayList args) { }

}

