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

	// RVA: 0x18D1B40 Offset: 0x18D0140 VA: 0x1818D1B40 Slot: 3
	public override string ToString() { }

	// RVA: 0x18D1460 Offset: 0x18CFA60 VA: 0x1818D1460
	internal static void FormatParameters(StringBuilder sb, ParameterInfo[] p, CallingConventions callingConvention, bool serialization) { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560 Slot: 8
	public virtual Type get_ParameterType() { }

	// RVA: 0x5E2ED0 Offset: 0x5E14D0 VA: 0x1805E2ED0 Slot: 9
	public virtual ParameterAttributes get_Attributes() { }

	// RVA: 0x18D1D70 Offset: 0x18D0370 VA: 0x1818D1D70
	public bool get_IsIn() { }

	// RVA: 0x18D1D90 Offset: 0x18D0390 VA: 0x1818D1D90
	public bool get_IsOptional() { }

	// RVA: 0x18D1DB0 Offset: 0x18D03B0 VA: 0x1818D1DB0
	public bool get_IsOut() { }

	// RVA: 0x18D1DD0 Offset: 0x18D03D0 VA: 0x1818D1DD0
	public bool get_IsRetval() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70 Slot: 10
	public virtual MemberInfo get_Member() { }

	// RVA: 0x7EE9D0 Offset: 0x7ECFD0 VA: 0x1807EE9D0 Slot: 11
	public virtual string get_Name() { }

	// RVA: 0xA39490 Offset: 0xA37A90 VA: 0x180A39490 Slot: 12
	public virtual int get_Position() { }

	// RVA: 0x18D16D0 Offset: 0x18CFCD0 VA: 0x1818D16D0
	internal object[] GetPseudoCustomAttributes() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	internal object GetDefaultValueImpl() { }

	// RVA: 0x18D1D20 Offset: 0x18D0320 VA: 0x1818D1D20 Slot: 13
	public virtual object get_DefaultValue() { }

	// RVA: 0x18D1650 Offset: 0x18CFC50 VA: 0x1818D1650 Slot: 14
	public virtual object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x18D1690 Offset: 0x18CFC90 VA: 0x1818D1690 Slot: 15
	public virtual object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x18D19F0 Offset: 0x18CFFF0 VA: 0x1818D19F0 Slot: 7
	public object GetRealObject(StreamingContext context) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 16
	public virtual bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x18D1A40 Offset: 0x18D0040 VA: 0x1818D1A40
	internal static ParameterInfo New(ParameterInfo pinfo, MemberInfo member) { }

}

