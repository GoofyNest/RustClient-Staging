public sealed class MarshalAsAttribute : Attribute // TypeDefIndex: 1356
{	// Fields
	public string MarshalCookie; // 0x10
	[ComVisibleAttribute] // RVA: 0x76000 Offset: 0x75400 VA: 0x180076000
	public string MarshalType; // 0x18
	[ComVisibleAttribute] // RVA: 0x76000 Offset: 0x75400 VA: 0x180076000
	public Type MarshalTypeRef; // 0x20
	public Type SafeArrayUserDefinedSubType; // 0x28
	private UnmanagedType utype; // 0x30
	public UnmanagedType ArraySubType; // 0x34
	public VarEnum SafeArraySubType; // 0x38
	public int SizeConst; // 0x3C
	public int IidParameterIndex; // 0x40
	public short SizeParamIndex; // 0x44

	// Methods

	// RVA: 0xFE9EA0 Offset: 0xFE84A0 VA: 0x180FE9EA0
	internal MarshalAsAttribute Copy() { }

}

