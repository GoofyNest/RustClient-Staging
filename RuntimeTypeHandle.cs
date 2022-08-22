public struct RuntimeTypeHandle : ISerializable // TypeDefIndex: 391
{	// Fields
	private IntPtr value; // 0x0

	// Properties
	public IntPtr Value { get; }

	// Methods

	// RVA: 0x1D2EB0 Offset: 0x1D22B0 VA: 0x1801D2EB0
	internal void .ctor(IntPtr val) { }

	// RVA: 0x1DF320 Offset: 0x1DE720 VA: 0x1801DF320
	internal void .ctor(RuntimeType type) { }

	// RVA: 0x1DF1A0 Offset: 0x1DE5A0 VA: 0x1801DF1A0
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xFC840 Offset: 0xFBC40 VA: 0x1800FC840
	public IntPtr get_Value() { }

	// RVA: 0x1DF180 Offset: 0x1DE580 VA: 0x1801DF180 Slot: 4
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x1DF070 Offset: 0x1DE470 VA: 0x1801DF070 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x14C4D0 Offset: 0x14B8D0 VA: 0x18014C4D0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1299440 Offset: 0x1297A40 VA: 0x181299440
	internal static TypeAttributes GetAttributes(RuntimeType type) { }

	// RVA: 0x1299490 Offset: 0x1297A90 VA: 0x181299490
	private static int GetMetadataToken(RuntimeType type) { }

	// RVA: 0x1299490 Offset: 0x1297A90 VA: 0x181299490
	internal static int GetToken(RuntimeType type) { }

	// RVA: 0x1299480 Offset: 0x1297A80 VA: 0x181299480
	private static Type GetGenericTypeDefinition_impl(RuntimeType type) { }

	// RVA: 0x1299480 Offset: 0x1297A80 VA: 0x181299480
	internal static Type GetGenericTypeDefinition(RuntimeType type) { }

	// RVA: 0x12996A0 Offset: 0x1297CA0 VA: 0x1812996A0
	internal static bool HasElementType(RuntimeType type) { }

	// RVA: 0x12996E0 Offset: 0x1297CE0 VA: 0x1812996E0
	internal static bool HasInstantiation(RuntimeType type) { }

	// RVA: 0x1299700 Offset: 0x1297D00 VA: 0x181299700
	internal static bool IsArray(RuntimeType type) { }

	// RVA: 0x1299710 Offset: 0x1297D10 VA: 0x181299710
	internal static bool IsByRef(RuntimeType type) { }

	// RVA: 0xD699C0 Offset: 0xD67FC0 VA: 0x180D699C0
	internal static bool IsComObject(RuntimeType type) { }

	// RVA: 0x12997E0 Offset: 0x1297DE0 VA: 0x1812997E0
	internal static bool IsInstanceOfType(RuntimeType type, object o) { }

	// RVA: 0x1299810 Offset: 0x1297E10 VA: 0x181299810
	internal static bool IsPointer(RuntimeType type) { }

	// RVA: 0x1299820 Offset: 0x1297E20 VA: 0x181299820
	internal static bool IsPrimitive(RuntimeType type) { }

	// RVA: 0x12996F0 Offset: 0x1297CF0 VA: 0x1812996F0
	internal static bool HasReferences(RuntimeType type) { }

	// RVA: 0x1299720 Offset: 0x1297D20 VA: 0x181299720
	internal static bool IsComObject(RuntimeType type, bool isGenericCOM) { }

	// RVA: 0x1299730 Offset: 0x1297D30 VA: 0x181299730
	internal static bool IsContextful(RuntimeType type) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40
	internal static bool IsEquivalentTo(RuntimeType rtType1, RuntimeType rtType2) { }

	// RVA: 0x1299830 Offset: 0x1297E30 VA: 0x181299830
	internal static bool IsSzArray(RuntimeType type) { }

	// RVA: 0x12997F0 Offset: 0x1297DF0 VA: 0x1812997F0
	internal static bool IsInterface(RuntimeType type) { }

	// RVA: 0x1299420 Offset: 0x1297A20 VA: 0x181299420
	internal static int GetArrayRank(RuntimeType type) { }

	// RVA: 0x1299430 Offset: 0x1297A30 VA: 0x181299430
	internal static RuntimeAssembly GetAssembly(RuntimeType type) { }

	// RVA: 0x1299460 Offset: 0x1297A60 VA: 0x181299460
	internal static RuntimeType GetElementType(RuntimeType type) { }

	// RVA: 0x12994A0 Offset: 0x1297AA0 VA: 0x1812994A0
	internal static RuntimeModule GetModule(RuntimeType type) { }

	// RVA: 0x12997D0 Offset: 0x1297DD0 VA: 0x1812997D0
	internal static bool IsGenericVariable(RuntimeType type) { }

	// RVA: 0x1299450 Offset: 0x1297A50 VA: 0x181299450
	internal static RuntimeType GetBaseType(RuntimeType type) { }

	// RVA: 0x1299410 Offset: 0x1297A10 VA: 0x181299410
	internal static bool CanCastTo(RuntimeType type, RuntimeType target) { }

	// RVA: 0x12998A0 Offset: 0x1297EA0 VA: 0x1812998A0
	private static bool type_is_assignable_from(Type a, Type b) { }

	// RVA: 0x12997C0 Offset: 0x1297DC0 VA: 0x1812997C0
	internal static bool IsGenericTypeDefinition(RuntimeType type) { }

	// RVA: 0x1299470 Offset: 0x1297A70 VA: 0x181299470
	internal static IntPtr GetGenericParameterInfo(RuntimeType type) { }

}

