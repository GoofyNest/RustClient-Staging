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

	// RVA: 0x1481160 Offset: 0x147F760 VA: 0x181481160
	public void .ctor() { }

	// RVA: 0x14815E0 Offset: 0x147FBE0 VA: 0x1814815E0
	internal void .ctor(string uri, IChannelInfo cinfo) { }

	// RVA: 0x1480BC0 Offset: 0x147F1C0 VA: 0x181480BC0
	internal ObjRef DeserializeInTheCurrentDomain(int domainId, byte[] tInfo) { }

	// RVA: 0x1480F20 Offset: 0x147F520 VA: 0x181480F20
	internal byte[] SerializeType() { }

	// RVA: 0x1481060 Offset: 0x147F660 VA: 0x181481060
	internal void .ctor(Type type, string url, object remoteChannelData) { }

	// RVA: 0x14811D0 Offset: 0x147F7D0 VA: 0x1814811D0
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1481630 Offset: 0x147FC30 VA: 0x181481630
	internal bool get_IsReferenceToWellKnow() { }

	[ReliabilityContractAttribute] // RVA: 0x76CD0 Offset: 0x760D0 VA: 0x180076CD0
	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560 Slot: 6
	public virtual IChannelInfo get_ChannelInfo() { }

	// RVA: 0x7EE9D0 Offset: 0x7ECFD0 VA: 0x1807EE9D0 Slot: 7
	public virtual IEnvoyInfo get_EnvoyInfo() { }

	// RVA: 0x7EE9E0 Offset: 0x7ECFE0 VA: 0x1807EE9E0 Slot: 8
	public virtual void set_EnvoyInfo(IEnvoyInfo value) { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70 Slot: 9
	public virtual IRemotingTypeInfo get_TypeInfo() { }

	// RVA: 0x49AFA0 Offset: 0x4995A0 VA: 0x18049AFA0 Slot: 10
	public virtual void set_TypeInfo(IRemotingTypeInfo value) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 11
	public virtual string get_URI() { }

	// RVA: 0x4D3770 Offset: 0x4D1D70 VA: 0x1804D3770 Slot: 12
	public virtual void set_URI(string value) { }

	// RVA: 0x1480CE0 Offset: 0x147F2E0 VA: 0x181480CE0 Slot: 13
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1480E30 Offset: 0x147F430 VA: 0x181480E30 Slot: 14
	public virtual object GetRealObject(StreamingContext context) { }

	// RVA: 0x1480FB0 Offset: 0x147F5B0 VA: 0x181480FB0
	internal void UpdateChannelInfo() { }

	// RVA: 0x14816A0 Offset: 0x147FCA0 VA: 0x1814816A0
	internal Type get_ServerType() { }

	// RVA: 0x1481010 Offset: 0x147F610 VA: 0x181481010
	private static void .cctor() { }

}

