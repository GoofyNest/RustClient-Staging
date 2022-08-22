public sealed class LogicalCallContext : ISerializable, ICloneable // TypeDefIndex: 1217
{	// Fields
	private static Type s_callContextType; // 0x0
	private const string s_CorrelationMgrSlotName = "System.Diagnostics.Trace.CorrelationManagerSlot";
	private Hashtable m_Datastore; // 0x10
	private CallContextRemotingData m_RemotingData; // 0x18
	private CallContextSecurityData m_SecurityData; // 0x20
	private object m_HostContext; // 0x28
	private bool m_IsCorrelationMgr; // 0x30
	private Header[] _sendHeaders; // 0x38
	private Header[] _recvHeaders; // 0x40

	// Properties
	public bool HasInfo { get; }
	private bool HasUserData { get; }
	private Hashtable Datastore { get; }

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	internal void .ctor() { }

	// RVA: 0x147B630 Offset: 0x1479C30 VA: 0x18147B630
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x147AEC0 Offset: 0x14794C0 VA: 0x18147AEC0 Slot: 4
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x147A780 Offset: 0x1478D80 VA: 0x18147A780 Slot: 5
	public object Clone() { }

	// RVA: 0x147B200 Offset: 0x1479800 VA: 0x18147B200
	internal void Merge(LogicalCallContext lc) { }

	// RVA: 0x147B9B0 Offset: 0x1479FB0 VA: 0x18147B9B0
	public bool get_HasInfo() { }

	// RVA: 0x14784A0 Offset: 0x1476AA0 VA: 0x1814784A0
	private bool get_HasUserData() { }

	// RVA: 0x147B940 Offset: 0x1479F40 VA: 0x18147B940
	private Hashtable get_Datastore() { }

	// RVA: 0x147AE20 Offset: 0x1479420 VA: 0x18147AE20
	public object GetData(string name) { }

	// RVA: 0x147B4D0 Offset: 0x1479AD0 VA: 0x18147B4D0
	public void SetData(string name, object data) { }

	// RVA: 0x147B5C0 Offset: 0x1479BC0 VA: 0x18147B5C0
	private static void .cctor() { }

}

internal struct LogicalCallContext.Reader // TypeDefIndex: 1218
{	// Fields
	private LogicalCallContext m_ctx; // 0x0

	// Properties
	public bool IsNull { get; }
	public bool HasInfo { get; }

	// Methods

	// RVA: 0xF1490 Offset: 0xF0890 VA: 0x1800F1490
	public void .ctor(LogicalCallContext ctx) { }

	// RVA: 0x118820 Offset: 0x117C20 VA: 0x180118820
	public bool get_IsNull() { }

	// RVA: 0x1EFDD0 Offset: 0x1EF1D0 VA: 0x1801EFDD0
	public bool get_HasInfo() { }

	// RVA: 0x1EFD50 Offset: 0x1EF150 VA: 0x1801EFD50
	public LogicalCallContext Clone() { }

	// RVA: 0x1EFDC0 Offset: 0x1EF1C0 VA: 0x1801EFDC0
	public object GetData(string name) { }

}

