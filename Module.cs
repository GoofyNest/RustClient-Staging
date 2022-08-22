public abstract class Module : ISerializable, ICustomAttributeProvider, _Module // TypeDefIndex: 571
{	// Fields
	public static readonly TypeFilter FilterTypeName; // 0x0
	public static readonly TypeFilter FilterTypeNameIgnoreCase; // 0x8
	internal IntPtr _impl; // 0x10
	internal Assembly assembly; // 0x18
	internal string fqname; // 0x20
	internal string name; // 0x28
	internal string scopename; // 0x30
	internal bool is_resource; // 0x38
	internal int token; // 0x3C
	private const BindingFlags defaultBindingFlags = 28;

	// Properties
	public virtual Assembly Assembly { get; }
	public virtual string ScopeName { get; }
	public virtual Guid ModuleVersionId { get; }

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

	// RVA: 0x18CCC50 Offset: 0x18CB250 VA: 0x1818CCC50 Slot: 8
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x7EE9D0 Offset: 0x7ECFD0 VA: 0x1807EE9D0 Slot: 3
	public override string ToString() { }

	// RVA: 0x18CCC20 Offset: 0x18CB220 VA: 0x1818CCC20 Slot: 9
	internal virtual Guid GetModuleVersionId() { }

	// RVA: 0x18CCF30 Offset: 0x18CB530 VA: 0x1818CCF30
	private static bool filter_by_type_name(Type m, object filterCriteria) { }

	// RVA: 0x18CCE10 Offset: 0x18CB410 VA: 0x1818CCE10
	private static bool filter_by_type_name_ignore_case(Type m, object filterCriteria) { }

	// RVA: 0x18CCC10 Offset: 0x18CB210 VA: 0x1818CCC10
	private string GetGuidInternal() { }

	// RVA: 0x12922A0 Offset: 0x12908A0 VA: 0x1812922A0 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0xCCECC0 Offset: 0xCCD2C0 VA: 0x180CCECC0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x18C5D30 Offset: 0x18C4330 VA: 0x1818C5D30
	public static bool op_Equality(Module left, Module right) { }

	// RVA: 0x18CD040 Offset: 0x18CB640 VA: 0x1818CD040 Slot: 10
	public virtual Assembly get_Assembly() { }

	// RVA: 0x18CD100 Offset: 0x18CB700 VA: 0x1818CD100 Slot: 11
	public virtual string get_ScopeName() { }

	// RVA: 0x18CD0A0 Offset: 0x18CB6A0 VA: 0x1818CD0A0 Slot: 12
	public virtual Guid get_ModuleVersionId() { }

	// RVA: 0x18CCB00 Offset: 0x18CB100 VA: 0x1818CCB00
	private static Exception CreateNIE() { }

	// RVA: 0x18CCD00 Offset: 0x18CB300 VA: 0x1818CCD00 Slot: 13
	public virtual bool IsResource() { }

	// RVA: 0x18CCBB0 Offset: 0x18CB1B0 VA: 0x1818CCBB0 Slot: 14
	public virtual object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x18CCB50 Offset: 0x18CB150 VA: 0x1818CCB50 Slot: 15
	public virtual object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x18CCCA0 Offset: 0x18CB2A0 VA: 0x1818CCCA0 Slot: 16
	public virtual bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x18CCD60 Offset: 0x18CB360 VA: 0x1818CCD60
	private static void .cctor() { }

}

