public class ObjRef : IObjectReference, ISerializable // TypeDefIndex: 1136
{	// Fields
	private IChannelInfo channel_info; // 0x10
	private string uri; // 0x18
	private IRemotingTypeInfo typeInfo; // 0x20
	private IEnvoyInfo envoyInfo; // 0x28
	private int flags; // 0x30
	private Type _serverType; // 0x38
	private static int MarshalledObjectRef; // 0x0
	private static int WellKnowObjectRef; // 0x4

	// Properties
	internal bool IsReferenceToWellKnow { get; }
	public virtual IChannelInfo ChannelInfo { get; }
	public virtual IEnvoyInfo EnvoyInfo { get; set; }
	public virtual IRemotingTypeInfo TypeInfo { get; set; }
	public virtual string URI { get; set; }
	internal Type ServerType { get; }

	// Methods

	// RVA: 0x1482090 Offset: 0x1480690 VA: 0x181482090
	public void .ctor() { }

	// RVA: 0x1482510 Offset: 0x1480B10 VA: 0x181482510
	internal void .ctor(string uri, IChannelInfo cinfo) { }

	// RVA: 0x1481AF0 Offset: 0x14800F0 VA: 0x181481AF0
	internal ObjRef DeserializeInTheCurrentDomain(int domainId, byte[] tInfo) { }

	// RVA: 0x1481E50 Offset: 0x1480450 VA: 0x181481E50
	internal byte[] SerializeType() { }

	// RVA: 0x1481F90 Offset: 0x1480590 VA: 0x181481F90
	internal void .ctor(Type type, string url, object remoteChannelData) { }

	// RVA: 0x1482100 Offset: 0x1480700 VA: 0x181482100
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1482560 Offset: 0x1480B60 VA: 0x181482560
	internal bool get_IsReferenceToWellKnow() { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0 Slot: 6
	public virtual IChannelInfo get_ChannelInfo() { }

	// RVA: 0x7EE440 Offset: 0x7ECA40 VA: 0x1807EE440 Slot: 7
	public virtual IEnvoyInfo get_EnvoyInfo() { }

	// RVA: 0x7EE450 Offset: 0x7ECA50 VA: 0x1807EE450 Slot: 8
	public virtual void set_EnvoyInfo(IEnvoyInfo value) { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70 Slot: 9
	public virtual IRemotingTypeInfo get_TypeInfo() { }

	// RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0 Slot: 10
	public virtual void set_TypeInfo(IRemotingTypeInfo value) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 11
	public virtual string get_URI() { }

	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0 Slot: 12
	public virtual void set_URI(string value) { }

	// RVA: 0x1481C10 Offset: 0x1480210 VA: 0x181481C10 Slot: 13
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1481D60 Offset: 0x1480360 VA: 0x181481D60 Slot: 14
	public virtual object GetRealObject(StreamingContext context) { }

	// RVA: 0x1481EE0 Offset: 0x14804E0 VA: 0x181481EE0
	internal void UpdateChannelInfo() { }

	// RVA: 0x14825D0 Offset: 0x1480BD0 VA: 0x1814825D0
	internal Type get_ServerType() { }

	// RVA: 0x1481F40 Offset: 0x1480540 VA: 0x181481F40
	private static void .cctor() { }

}

