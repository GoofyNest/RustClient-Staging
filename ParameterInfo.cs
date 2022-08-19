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

	// RVA: 0x18D21A0 Offset: 0x18D07A0 VA: 0x1818D21A0 Slot: 3
	public override string ToString() { }

	// RVA: 0x18D1AC0 Offset: 0x18D00C0 VA: 0x1818D1AC0
	internal static void FormatParameters(StringBuilder sb, ParameterInfo[] p, CallingConventions callingConvention, bool serialization) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0 Slot: 8
	public virtual Type get_ParameterType() { }

	// RVA: 0x5E2F40 Offset: 0x5E1540 VA: 0x1805E2F40 Slot: 9
	public virtual ParameterAttributes get_Attributes() { }

	// RVA: 0x18D23D0 Offset: 0x18D09D0 VA: 0x1818D23D0
	public bool get_IsIn() { }

	// RVA: 0x18D23F0 Offset: 0x18D09F0 VA: 0x1818D23F0
	public bool get_IsOptional() { }

	// RVA: 0x18D2410 Offset: 0x18D0A10 VA: 0x1818D2410
	public bool get_IsOut() { }

	// RVA: 0x18D2430 Offset: 0x18D0A30 VA: 0x1818D2430
	public bool get_IsRetval() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70 Slot: 10
	public virtual MemberInfo get_Member() { }

	// RVA: 0x7EE330 Offset: 0x7EC930 VA: 0x1807EE330 Slot: 11
	public virtual string get_Name() { }

	// RVA: 0xA38CE0 Offset: 0xA372E0 VA: 0x180A38CE0 Slot: 12
	public virtual int get_Position() { }

	// RVA: 0x18D1D30 Offset: 0x18D0330 VA: 0x1818D1D30
	internal object[] GetPseudoCustomAttributes() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	internal object GetDefaultValueImpl() { }

	// RVA: 0x18D2380 Offset: 0x18D0980 VA: 0x1818D2380 Slot: 13
	public virtual object get_DefaultValue() { }

	// RVA: 0x18D1CB0 Offset: 0x18D02B0 VA: 0x1818D1CB0 Slot: 14
	public virtual object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x18D1CF0 Offset: 0x18D02F0 VA: 0x1818D1CF0 Slot: 15
	public virtual object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x18D2050 Offset: 0x18D0650 VA: 0x1818D2050 Slot: 7
	public object GetRealObject(StreamingContext context) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 16
	public virtual bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x18D20A0 Offset: 0x18D06A0 VA: 0x1818D20A0
	internal static ParameterInfo New(ParameterInfo pinfo, MemberInfo member) { }

}

