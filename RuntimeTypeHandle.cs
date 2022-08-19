public struct RuntimeTypeHandle : ISerializable // TypeDefIndex: 391
{	// Fields
	private IntPtr value; // 0x0

	// Properties
	public IntPtr Value { get; }

	// Methods

	// RVA: 0x1D2F30 Offset: 0x1D2330 VA: 0x1801D2F30
	internal void .ctor(IntPtr val) { }

	// RVA: 0x1DF3A0 Offset: 0x1DE7A0 VA: 0x1801DF3A0
	internal void .ctor(RuntimeType type) { }

	// RVA: 0x1DF220 Offset: 0x1DE620 VA: 0x1801DF220
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xFC8C0 Offset: 0xFBCC0 VA: 0x1800FC8C0
	public IntPtr get_Value() { }

	// RVA: 0x1DF200 Offset: 0x1DE600 VA: 0x1801DF200 Slot: 4
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[ReliabilityContractAttribute] // RVA: 0x76D80 Offset: 0x76180 VA: 0x180076D80
	// RVA: 0x1DF0F0 Offset: 0x1DE4F0 VA: 0x1801DF0F0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x14C550 Offset: 0x14B950 VA: 0x18014C550 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1299180 Offset: 0x1297780 VA: 0x181299180
	internal static TypeAttributes GetAttributes(RuntimeType type) { }

	// RVA: 0x12991D0 Offset: 0x12977D0 VA: 0x1812991D0
	private static int GetMetadataToken(RuntimeType type) { }

	// RVA: 0x12991D0 Offset: 0x12977D0 VA: 0x1812991D0
	internal static int GetToken(RuntimeType type) { }

	// RVA: 0x12991C0 Offset: 0x12977C0 VA: 0x1812991C0
	private static Type GetGenericTypeDefinition_impl(RuntimeType type) { }

	// RVA: 0x12991C0 Offset: 0x12977C0 VA: 0x1812991C0
	internal static Type GetGenericTypeDefinition(RuntimeType type) { }

	// RVA: 0x12993E0 Offset: 0x12979E0 VA: 0x1812993E0
	internal static bool HasElementType(RuntimeType type) { }

	// RVA: 0x1299420 Offset: 0x1297A20 VA: 0x181299420
	internal static bool HasInstantiation(RuntimeType type) { }

	// RVA: 0x1299440 Offset: 0x1297A40 VA: 0x181299440
	internal static bool IsArray(RuntimeType type) { }

	// RVA: 0x1299450 Offset: 0x1297A50 VA: 0x181299450
	internal static bool IsByRef(RuntimeType type) { }

	// RVA: 0xD69700 Offset: 0xD67D00 VA: 0x180D69700
	internal static bool IsComObject(RuntimeType type) { }

	// RVA: 0x1299520 Offset: 0x1297B20 VA: 0x181299520
	internal static bool IsInstanceOfType(RuntimeType type, object o) { }

	// RVA: 0x1299550 Offset: 0x1297B50 VA: 0x181299550
	internal static bool IsPointer(RuntimeType type) { }

	// RVA: 0x1299560 Offset: 0x1297B60 VA: 0x181299560
	internal static bool IsPrimitive(RuntimeType type) { }

	// RVA: 0x1299430 Offset: 0x1297A30 VA: 0x181299430
	internal static bool HasReferences(RuntimeType type) { }

	// RVA: 0x1299460 Offset: 0x1297A60 VA: 0x181299460
	internal static bool IsComObject(RuntimeType type, bool isGenericCOM) { }

	// RVA: 0x1299470 Offset: 0x1297A70 VA: 0x181299470
	internal static bool IsContextful(RuntimeType type) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40
	internal static bool IsEquivalentTo(RuntimeType rtType1, RuntimeType rtType2) { }

	// RVA: 0x1299570 Offset: 0x1297B70 VA: 0x181299570
	internal static bool IsSzArray(RuntimeType type) { }

	// RVA: 0x1299530 Offset: 0x1297B30 VA: 0x181299530
	internal static bool IsInterface(RuntimeType type) { }

	// RVA: 0x1299160 Offset: 0x1297760 VA: 0x181299160
	internal static int GetArrayRank(RuntimeType type) { }

	// RVA: 0x1299170 Offset: 0x1297770 VA: 0x181299170
	internal static RuntimeAssembly GetAssembly(RuntimeType type) { }

	// RVA: 0x12991A0 Offset: 0x12977A0 VA: 0x1812991A0
	internal static RuntimeType GetElementType(RuntimeType type) { }

	// RVA: 0x12991E0 Offset: 0x12977E0 VA: 0x1812991E0
	internal static RuntimeModule GetModule(RuntimeType type) { }

	// RVA: 0x1299510 Offset: 0x1297B10 VA: 0x181299510
	internal static bool IsGenericVariable(RuntimeType type) { }

	// RVA: 0x1299190 Offset: 0x1297790 VA: 0x181299190
	internal static RuntimeType GetBaseType(RuntimeType type) { }

	// RVA: 0x1299150 Offset: 0x1297750 VA: 0x181299150
	internal static bool CanCastTo(RuntimeType type, RuntimeType target) { }

	// RVA: 0x12995E0 Offset: 0x1297BE0 VA: 0x1812995E0
	private static bool type_is_assignable_from(Type a, Type b) { }

	// RVA: 0x1299500 Offset: 0x1297B00 VA: 0x181299500
	internal static bool IsGenericTypeDefinition(RuntimeType type) { }

	// RVA: 0x12991B0 Offset: 0x12977B0 VA: 0x1812991B0
	internal static IntPtr GetGenericParameterInfo(RuntimeType type) { }

}

