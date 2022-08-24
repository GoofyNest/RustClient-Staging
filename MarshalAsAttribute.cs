public sealed class MarshalAsAttribute : Attribute // TypeDefIndex: 1356
{	public string MarshalCookie; // 0x10
	[ComVisibleAttribute] // RVA: 0x760B0 Offset: 0x754B0 VA: 0x1800760B0
	public string MarshalType; // 0x18
	[ComVisibleAttribute] // RVA: 0x760B0 Offset: 0x754B0 VA: 0x1800760B0
	public Type MarshalTypeRef; // 0x20
	public Type SafeArrayUserDefinedSubType; // 0x28
	private UnmanagedType utype; // 0x30
	public UnmanagedType ArraySubType; // 0x34
	public VarEnum SafeArraySubType; // 0x38
	public int SizeConst; // 0x3C
	public int IidParameterIndex; // 0x40
	public short SizeParamIndex; // 0x44


	internal MarshalAsAttribute Copy() { }

}

