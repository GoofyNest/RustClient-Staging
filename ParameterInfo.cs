public class ParameterInfo : ICustomAttributeProvider, IObjectReference, _ParameterInfo // TypeDefIndex: 596
{	// Fields
	protected Type ClassImpl; // 0x10
	protected object DefaultValueImpl; // 0x18
	protected MemberInfo MemberImpl; // 0x20
	protected string NameImpl; // 0x28
	protected int PositionImpl; // 0x30
	protected ParameterAttributes AttrsImpl; // 0x34
	internal MarshalAsAttribute marshalAs; // 0x38

	// Properties
	public virtual Type ParameterType { get; }
	public virtual ParameterAttributes Attributes { get; }
	public bool IsIn { get; }
	public bool IsOptional { get; }
	public bool IsOut { get; }
	public bool IsRetval { get; }
	public virtual MemberInfo Member { get; }
	public virtual string Name { get; }
	public virtual int Position { get; }
	public virtual object DefaultValue { get; }

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	protected void .ctor() { }

	// RVA: 0x18D2420 Offset: 0x18D0A20 VA: 0x1818D2420 Slot: 3
	public override string ToString() { }

	// RVA: 0x18D1D40 Offset: 0x18D0340 VA: 0x1818D1D40
	internal static void FormatParameters(StringBuilder sb, ParameterInfo[] p, CallingConventions callingConvention, bool serialization) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0 Slot: 8
	public virtual Type get_ParameterType() { }

	// RVA: 0x5E2F40 Offset: 0x5E1540 VA: 0x1805E2F40 Slot: 9
	public virtual ParameterAttributes get_Attributes() { }

	// RVA: 0x18D2650 Offset: 0x18D0C50 VA: 0x1818D2650
	public bool get_IsIn() { }

	// RVA: 0x18D2670 Offset: 0x18D0C70 VA: 0x1818D2670
	public bool get_IsOptional() { }

	// RVA: 0x18D2690 Offset: 0x18D0C90 VA: 0x1818D2690
	public bool get_IsOut() { }

	// RVA: 0x18D26B0 Offset: 0x18D0CB0 VA: 0x1818D26B0
	public bool get_IsRetval() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70 Slot: 10
	public virtual MemberInfo get_Member() { }

	// RVA: 0x7EE440 Offset: 0x7ECA40 VA: 0x1807EE440 Slot: 11
	public virtual string get_Name() { }

	// RVA: 0xA38FA0 Offset: 0xA375A0 VA: 0x180A38FA0 Slot: 12
	public virtual int get_Position() { }

	// RVA: 0x18D1FB0 Offset: 0x18D05B0 VA: 0x1818D1FB0
	internal object[] GetPseudoCustomAttributes() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	internal object GetDefaultValueImpl() { }

	// RVA: 0x18D2600 Offset: 0x18D0C00 VA: 0x1818D2600 Slot: 13
	public virtual object get_DefaultValue() { }

	// RVA: 0x18D1F30 Offset: 0x18D0530 VA: 0x1818D1F30 Slot: 14
	public virtual object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x18D1F70 Offset: 0x18D0570 VA: 0x1818D1F70 Slot: 15
	public virtual object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x18D22D0 Offset: 0x18D08D0 VA: 0x1818D22D0 Slot: 7
	public object GetRealObject(StreamingContext context) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 16
	public virtual bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x18D2320 Offset: 0x18D0920 VA: 0x1818D2320
	internal static ParameterInfo New(ParameterInfo pinfo, MemberInfo member) { }

}

