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

	// RVA: 0x18CD530 Offset: 0x18CBB30 VA: 0x1818CD530 Slot: 8
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x7EE440 Offset: 0x7ECA40 VA: 0x1807EE440 Slot: 3
	public override string ToString() { }

	// RVA: 0x18CD500 Offset: 0x18CBB00 VA: 0x1818CD500 Slot: 9
	internal virtual Guid GetModuleVersionId() { }

	// RVA: 0x18CD810 Offset: 0x18CBE10 VA: 0x1818CD810
	private static bool filter_by_type_name(Type m, object filterCriteria) { }

	// RVA: 0x18CD6F0 Offset: 0x18CBCF0 VA: 0x1818CD6F0
	private static bool filter_by_type_name_ignore_case(Type m, object filterCriteria) { }

	// RVA: 0x18CD4F0 Offset: 0x18CBAF0 VA: 0x1818CD4F0
	private string GetGuidInternal() { }

	// RVA: 0x1291C00 Offset: 0x1290200 VA: 0x181291C00 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0xCCE820 Offset: 0xCCCE20 VA: 0x180CCE820 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x18C6610 Offset: 0x18C4C10 VA: 0x1818C6610
	public static bool op_Equality(Module left, Module right) { }

	// RVA: 0x18CD920 Offset: 0x18CBF20 VA: 0x1818CD920 Slot: 10
	public virtual Assembly get_Assembly() { }

	// RVA: 0x18CD9E0 Offset: 0x18CBFE0 VA: 0x1818CD9E0 Slot: 11
	public virtual string get_ScopeName() { }

	// RVA: 0x18CD980 Offset: 0x18CBF80 VA: 0x1818CD980 Slot: 12
	public virtual Guid get_ModuleVersionId() { }

	// RVA: 0x18CD3E0 Offset: 0x18CB9E0 VA: 0x1818CD3E0
	private static Exception CreateNIE() { }

	// RVA: 0x18CD5E0 Offset: 0x18CBBE0 VA: 0x1818CD5E0 Slot: 13
	public virtual bool IsResource() { }

	// RVA: 0x18CD490 Offset: 0x18CBA90 VA: 0x1818CD490 Slot: 14
	public virtual object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x18CD430 Offset: 0x18CBA30 VA: 0x1818CD430 Slot: 15
	public virtual object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x18CD580 Offset: 0x18CBB80 VA: 0x1818CD580 Slot: 16
	public virtual bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x18CD640 Offset: 0x18CBC40 VA: 0x1818CD640
	private static void .cctor() { }

}

