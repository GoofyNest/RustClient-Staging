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

	// RVA: 0x147B8F0 Offset: 0x1479EF0 VA: 0x18147B8F0
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x147B180 Offset: 0x1479780 VA: 0x18147B180 Slot: 4
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x147AA40 Offset: 0x1479040 VA: 0x18147AA40 Slot: 5
	public object Clone() { }

	// RVA: 0x147B4C0 Offset: 0x1479AC0 VA: 0x18147B4C0
	internal void Merge(LogicalCallContext lc) { }

	// RVA: 0x147BC70 Offset: 0x147A270 VA: 0x18147BC70
	public bool get_HasInfo() { }

	// RVA: 0x1478760 Offset: 0x1476D60 VA: 0x181478760
	private bool get_HasUserData() { }

	// RVA: 0x147BC00 Offset: 0x147A200 VA: 0x18147BC00
	private Hashtable get_Datastore() { }

	// RVA: 0x147B0E0 Offset: 0x14796E0 VA: 0x18147B0E0
	public object GetData(string name) { }

	// RVA: 0x147B790 Offset: 0x1479D90 VA: 0x18147B790
	public void SetData(string name, object data) { }

	// RVA: 0x147B880 Offset: 0x1479E80 VA: 0x18147B880
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

