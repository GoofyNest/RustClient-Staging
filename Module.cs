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

	// RVA: 0x18CD2B0 Offset: 0x18CB8B0 VA: 0x1818CD2B0 Slot: 8
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x7EE330 Offset: 0x7EC930 VA: 0x1807EE330 Slot: 3
	public override string ToString() { }

	// RVA: 0x18CD280 Offset: 0x18CB880 VA: 0x1818CD280 Slot: 9
	internal virtual Guid GetModuleVersionId() { }

	// RVA: 0x18CD590 Offset: 0x18CBB90 VA: 0x1818CD590
	private static bool filter_by_type_name(Type m, object filterCriteria) { }

	// RVA: 0x18CD470 Offset: 0x18CBA70 VA: 0x1818CD470
	private static bool filter_by_type_name_ignore_case(Type m, object filterCriteria) { }

	// RVA: 0x18CD270 Offset: 0x18CB870 VA: 0x1818CD270
	private string GetGuidInternal() { }

	// RVA: 0x1291940 Offset: 0x128FF40 VA: 0x181291940 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0xCCE560 Offset: 0xCCCB60 VA: 0x180CCE560 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x18C6390 Offset: 0x18C4990 VA: 0x1818C6390
	public static bool op_Equality(Module left, Module right) { }

	// RVA: 0x18CD6A0 Offset: 0x18CBCA0 VA: 0x1818CD6A0 Slot: 10
	public virtual Assembly get_Assembly() { }

	// RVA: 0x18CD760 Offset: 0x18CBD60 VA: 0x1818CD760 Slot: 11
	public virtual string get_ScopeName() { }

	// RVA: 0x18CD700 Offset: 0x18CBD00 VA: 0x1818CD700 Slot: 12
	public virtual Guid get_ModuleVersionId() { }

	// RVA: 0x18CD160 Offset: 0x18CB760 VA: 0x1818CD160
	private static Exception CreateNIE() { }

	// RVA: 0x18CD360 Offset: 0x18CB960 VA: 0x1818CD360 Slot: 13
	public virtual bool IsResource() { }

	// RVA: 0x18CD210 Offset: 0x18CB810 VA: 0x1818CD210 Slot: 14
	public virtual object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x18CD1B0 Offset: 0x18CB7B0 VA: 0x1818CD1B0 Slot: 15
	public virtual object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x18CD300 Offset: 0x18CB900 VA: 0x1818CD300 Slot: 16
	public virtual bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x18CD3C0 Offset: 0x18CB9C0 VA: 0x1818CD3C0
	private static void .cctor() { }

}

