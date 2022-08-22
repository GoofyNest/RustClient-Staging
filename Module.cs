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

	// RVA: 0x18CD270 Offset: 0x18CB870 VA: 0x1818CD270 Slot: 8
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x7EE330 Offset: 0x7EC930 VA: 0x1807EE330 Slot: 3
	public override string ToString() { }

	// RVA: 0x18CD240 Offset: 0x18CB840 VA: 0x1818CD240 Slot: 9
	internal virtual Guid GetModuleVersionId() { }

	// RVA: 0x18CD550 Offset: 0x18CBB50 VA: 0x1818CD550
	private static bool filter_by_type_name(Type m, object filterCriteria) { }

	// RVA: 0x18CD430 Offset: 0x18CBA30 VA: 0x1818CD430
	private static bool filter_by_type_name_ignore_case(Type m, object filterCriteria) { }

	// RVA: 0x18CD230 Offset: 0x18CB830 VA: 0x1818CD230
	private string GetGuidInternal() { }

	// RVA: 0x1291940 Offset: 0x128FF40 VA: 0x181291940 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0xCCE560 Offset: 0xCCCB60 VA: 0x180CCE560 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x18C6350 Offset: 0x18C4950 VA: 0x1818C6350
	public static bool op_Equality(Module left, Module right) { }

	// RVA: 0x18CD660 Offset: 0x18CBC60 VA: 0x1818CD660 Slot: 10
	public virtual Assembly get_Assembly() { }

	// RVA: 0x18CD720 Offset: 0x18CBD20 VA: 0x1818CD720 Slot: 11
	public virtual string get_ScopeName() { }

	// RVA: 0x18CD6C0 Offset: 0x18CBCC0 VA: 0x1818CD6C0 Slot: 12
	public virtual Guid get_ModuleVersionId() { }

	// RVA: 0x18CD120 Offset: 0x18CB720 VA: 0x1818CD120
	private static Exception CreateNIE() { }

	// RVA: 0x18CD320 Offset: 0x18CB920 VA: 0x1818CD320 Slot: 13
	public virtual bool IsResource() { }

	// RVA: 0x18CD1D0 Offset: 0x18CB7D0 VA: 0x1818CD1D0 Slot: 14
	public virtual object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x18CD170 Offset: 0x18CB770 VA: 0x1818CD170 Slot: 15
	public virtual object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x18CD2C0 Offset: 0x18CB8C0 VA: 0x1818CD2C0 Slot: 16
	public virtual bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x18CD380 Offset: 0x18CB980 VA: 0x1818CD380
	private static void .cctor() { }

}

