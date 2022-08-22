public struct RuntimeTypeHandle : ISerializable // TypeDefIndex: 391
{	// Fields
	private IntPtr value; // 0x0

	// Properties
	public IntPtr Value { get; }

	// Methods

	// RVA: 0x1D3520 Offset: 0x1D2920 VA: 0x1801D3520
	internal void .ctor(IntPtr val) { }

	// RVA: 0x1DF990 Offset: 0x1DED90 VA: 0x1801DF990
	internal void .ctor(RuntimeType type) { }

	// RVA: 0x1DF810 Offset: 0x1DEC10 VA: 0x1801DF810
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0xFC840 Offset: 0xFBC40 VA: 0x1800FC840
	public IntPtr get_Value() { }

	// RVA: 0x1DF7F0 Offset: 0x1DEBF0 VA: 0x1801DF7F0 Slot: 4
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x1DF6E0 Offset: 0x1DEAE0 VA: 0x1801DF6E0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x14C2F0 Offset: 0x14B6F0 VA: 0x18014C2F0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1299AE0 Offset: 0x12980E0 VA: 0x181299AE0
	internal static TypeAttributes GetAttributes(RuntimeType type) { }

	// RVA: 0x1299B30 Offset: 0x1298130 VA: 0x181299B30
	private static int GetMetadataToken(RuntimeType type) { }

	// RVA: 0x1299B30 Offset: 0x1298130 VA: 0x181299B30
	internal static int GetToken(RuntimeType type) { }

	// RVA: 0x1299B20 Offset: 0x1298120 VA: 0x181299B20
	private static Type GetGenericTypeDefinition_impl(RuntimeType type) { }

	// RVA: 0x1299B20 Offset: 0x1298120 VA: 0x181299B20
	internal static Type GetGenericTypeDefinition(RuntimeType type) { }

	// RVA: 0x1299D40 Offset: 0x1298340 VA: 0x181299D40
	internal static bool HasElementType(RuntimeType type) { }

	// RVA: 0x1299D80 Offset: 0x1298380 VA: 0x181299D80
	internal static bool HasInstantiation(RuntimeType type) { }

	// RVA: 0x1299DA0 Offset: 0x12983A0 VA: 0x181299DA0
	internal static bool IsArray(RuntimeType type) { }

	// RVA: 0x1299DB0 Offset: 0x12983B0 VA: 0x181299DB0
	internal static bool IsByRef(RuntimeType type) { }

	// RVA: 0xD6A470 Offset: 0xD68A70 VA: 0x180D6A470
	internal static bool IsComObject(RuntimeType type) { }

	// RVA: 0x1299E80 Offset: 0x1298480 VA: 0x181299E80
	internal static bool IsInstanceOfType(RuntimeType type, object o) { }

	// RVA: 0x1299EB0 Offset: 0x12984B0 VA: 0x181299EB0
	internal static bool IsPointer(RuntimeType type) { }

	// RVA: 0x1299EC0 Offset: 0x12984C0 VA: 0x181299EC0
	internal static bool IsPrimitive(RuntimeType type) { }

	// RVA: 0x1299D90 Offset: 0x1298390 VA: 0x181299D90
	internal static bool HasReferences(RuntimeType type) { }

	// RVA: 0x1299DC0 Offset: 0x12983C0 VA: 0x181299DC0
	internal static bool IsComObject(RuntimeType type, bool isGenericCOM) { }

	// RVA: 0x1299DD0 Offset: 0x12983D0 VA: 0x181299DD0
	internal static bool IsContextful(RuntimeType type) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40
	internal static bool IsEquivalentTo(RuntimeType rtType1, RuntimeType rtType2) { }

	// RVA: 0x1299ED0 Offset: 0x12984D0 VA: 0x181299ED0
	internal static bool IsSzArray(RuntimeType type) { }

	// RVA: 0x1299E90 Offset: 0x1298490 VA: 0x181299E90
	internal static bool IsInterface(RuntimeType type) { }

	// RVA: 0x1299AC0 Offset: 0x12980C0 VA: 0x181299AC0
	internal static int GetArrayRank(RuntimeType type) { }

	// RVA: 0x1299AD0 Offset: 0x12980D0 VA: 0x181299AD0
	internal static RuntimeAssembly GetAssembly(RuntimeType type) { }

	// RVA: 0x1299B00 Offset: 0x1298100 VA: 0x181299B00
	internal static RuntimeType GetElementType(RuntimeType type) { }

	// RVA: 0x1299B40 Offset: 0x1298140 VA: 0x181299B40
	internal static RuntimeModule GetModule(RuntimeType type) { }

	// RVA: 0x1299E70 Offset: 0x1298470 VA: 0x181299E70
	internal static bool IsGenericVariable(RuntimeType type) { }

	// RVA: 0x1299AF0 Offset: 0x12980F0 VA: 0x181299AF0
	internal static RuntimeType GetBaseType(RuntimeType type) { }

	// RVA: 0x1299AB0 Offset: 0x12980B0 VA: 0x181299AB0
	internal static bool CanCastTo(RuntimeType type, RuntimeType target) { }

	// RVA: 0x1299F40 Offset: 0x1298540 VA: 0x181299F40
	private static bool type_is_assignable_from(Type a, Type b) { }

	// RVA: 0x1299E60 Offset: 0x1298460 VA: 0x181299E60
	internal static bool IsGenericTypeDefinition(RuntimeType type) { }

	// RVA: 0x1299B10 Offset: 0x1298110 VA: 0x181299B10
	internal static IntPtr GetGenericParameterInfo(RuntimeType type) { }

}

