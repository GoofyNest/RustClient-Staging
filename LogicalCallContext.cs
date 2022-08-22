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

	// RVA: 0x147A9C0 Offset: 0x1478FC0 VA: 0x18147A9C0
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x147A250 Offset: 0x1478850 VA: 0x18147A250 Slot: 4
	public void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1479B10 Offset: 0x1478110 VA: 0x181479B10 Slot: 5
	public object Clone() { }

	// RVA: 0x147A590 Offset: 0x1478B90 VA: 0x18147A590
	internal void Merge(LogicalCallContext lc) { }

	// RVA: 0x147AD40 Offset: 0x1479340 VA: 0x18147AD40
	public bool get_HasInfo() { }

	// RVA: 0x1477830 Offset: 0x1475E30 VA: 0x181477830
	private bool get_HasUserData() { }

	// RVA: 0x147ACD0 Offset: 0x14792D0 VA: 0x18147ACD0
	private Hashtable get_Datastore() { }

	// RVA: 0x147A1B0 Offset: 0x14787B0 VA: 0x18147A1B0
	public object GetData(string name) { }

	// RVA: 0x147A860 Offset: 0x1478E60 VA: 0x18147A860
	public void SetData(string name, object data) { }

	// RVA: 0x147A950 Offset: 0x1478F50 VA: 0x18147A950
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

	// RVA: 0x1F01F0 Offset: 0x1EF5F0 VA: 0x1801F01F0
	public bool get_HasInfo() { }

	// RVA: 0x1F0170 Offset: 0x1EF570 VA: 0x1801F0170
	public LogicalCallContext Clone() { }

	// RVA: 0x1F01E0 Offset: 0x1EF5E0 VA: 0x1801F01E0
	public object GetData(string name) { }

}

