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

	// RVA: 0x1481DD0 Offset: 0x14803D0 VA: 0x181481DD0
	public void .ctor() { }

	// RVA: 0x1482250 Offset: 0x1480850 VA: 0x181482250
	internal void .ctor(string uri, IChannelInfo cinfo) { }

	// RVA: 0x1481830 Offset: 0x147FE30 VA: 0x181481830
	internal ObjRef DeserializeInTheCurrentDomain(int domainId, byte[] tInfo) { }

	// RVA: 0x1481B90 Offset: 0x1480190 VA: 0x181481B90
	internal byte[] SerializeType() { }

	// RVA: 0x1481CD0 Offset: 0x14802D0 VA: 0x181481CD0
	internal void .ctor(Type type, string url, object remoteChannelData) { }

	// RVA: 0x1481E40 Offset: 0x1480440 VA: 0x181481E40
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x14822A0 Offset: 0x14808A0 VA: 0x1814822A0
	internal bool get_IsReferenceToWellKnow() { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0 Slot: 6
	public virtual IChannelInfo get_ChannelInfo() { }

	// RVA: 0x7EE330 Offset: 0x7EC930 VA: 0x1807EE330 Slot: 7
	public virtual IEnvoyInfo get_EnvoyInfo() { }

	// RVA: 0x7EE340 Offset: 0x7EC940 VA: 0x1807EE340 Slot: 8
	public virtual void set_EnvoyInfo(IEnvoyInfo value) { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70 Slot: 9
	public virtual IRemotingTypeInfo get_TypeInfo() { }

	// RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0 Slot: 10
	public virtual void set_TypeInfo(IRemotingTypeInfo value) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 11
	public virtual string get_URI() { }

	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0 Slot: 12
	public virtual void set_URI(string value) { }

	// RVA: 0x1481950 Offset: 0x147FF50 VA: 0x181481950 Slot: 13
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1481AA0 Offset: 0x14800A0 VA: 0x181481AA0 Slot: 14
	public virtual object GetRealObject(StreamingContext context) { }

	// RVA: 0x1481C20 Offset: 0x1480220 VA: 0x181481C20
	internal void UpdateChannelInfo() { }

	// RVA: 0x1482310 Offset: 0x1480910 VA: 0x181482310
	internal Type get_ServerType() { }

	// RVA: 0x1481C80 Offset: 0x1480280 VA: 0x181481C80
	private static void .cctor() { }

}

