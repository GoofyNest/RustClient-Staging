internal class CADMessageBase // TypeDefIndex: 1227
{	// Fields
	protected object[] _args; // 0x10
	protected byte[] _serializedArgs; // 0x18
	protected int _propertyCount; // 0x20
	protected CADArgHolder _callContext; // 0x28
	internal byte[] serializedMethod; // 0x30

	// Methods

	// RVA: 0x146FCD0 Offset: 0x146E2D0 VA: 0x18146FCD0
	public void .ctor(IMethodMessage msg) { }

	// RVA: 0x146E250 Offset: 0x146C850 VA: 0x18146E250
	internal MethodBase GetMethod() { }

	// RVA: 0x146E320 Offset: 0x146C920 VA: 0x18146E320
	protected static Type[] GetSignature(MethodBase methodBase, bool load) { }

	// RVA: 0x146E9C0 Offset: 0x146CFC0 VA: 0x18146E9C0
	internal static int MarshalProperties(IDictionary dict, ref ArrayList args) { }

	// RVA: 0x146FB70 Offset: 0x146E170 VA: 0x18146FB70
	internal static void UnmarshalProperties(IDictionary dict, int count, ArrayList args) { }

	// RVA: 0x146E540 Offset: 0x146CB40 VA: 0x18146E540
	private static bool IsPossibleToIgnoreMarshal(object obj) { }

	// RVA: 0x146E720 Offset: 0x146CD20 VA: 0x18146E720
	protected object MarshalArgument(object arg, ref ArrayList args) { }

	// RVA: 0x146F020 Offset: 0x146D620 VA: 0x18146F020
	protected object UnmarshalArgument(object arg, ArrayList args) { }

	// RVA: 0x146E890 Offset: 0x146CE90 VA: 0x18146E890
	internal object[] MarshalArguments(object[] arguments, ref ArrayList args) { }

	// RVA: 0x146FA40 Offset: 0x146E040 VA: 0x18146FA40
	internal object[] UnmarshalArguments(object[] arguments, ArrayList args) { }

	// RVA: 0x146EE80 Offset: 0x146D480 VA: 0x18146EE80
	protected void SaveLogicalCallContext(IMethodMessage msg, ref ArrayList serializeList) { }

	// RVA: 0x146E1C0 Offset: 0x146C7C0 VA: 0x18146E1C0
	internal LogicalCallContext GetLogicalCallContext(ArrayList args) { }

}

