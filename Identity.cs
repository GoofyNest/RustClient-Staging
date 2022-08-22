internal abstract class Identity // TypeDefIndex: 1133
{	// Fields
	protected string _objectUri; // 0x10
	protected IMessageSink _channelSink; // 0x18
	protected IMessageSink _envoySink; // 0x20
	private DynamicPropertyCollection _clientDynamicProperties; // 0x28
	private DynamicPropertyCollection _serverDynamicProperties; // 0x30
	protected ObjRef _objRef; // 0x38
	private bool _disposed; // 0x40

	// Properties
	public IMessageSink ChannelSink { get; set; }
	public IMessageSink EnvoySink { get; }
	public string ObjectUri { get; set; }
	public bool IsConnected { get; }
	public bool Disposed { get; set; }
	public DynamicPropertyCollection ClientDynamicProperties { get; }
	public bool HasServerDynamicSinks { get; }

	// Methods

	// RVA: 0x68A910 Offset: 0x688F10 VA: 0x18068A910
	public void .ctor(string objectUri) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract ObjRef CreateObjRef(Type requestedType);

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public IMessageSink get_ChannelSink() { }

	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0
	public void set_ChannelSink(IMessageSink value) { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public IMessageSink get_EnvoySink() { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public string get_ObjectUri() { }

	// RVA: 0x4BC630 Offset: 0x4BAC30 VA: 0x1804BC630
	public void set_ObjectUri(string value) { }

	// RVA: 0x795CF0 Offset: 0x7942F0 VA: 0x180795CF0
	public bool get_IsConnected() { }

	// RVA: 0x805600 Offset: 0x803C00 VA: 0x180805600
	public bool get_Disposed() { }

	// RVA: 0x810000 Offset: 0x80E600 VA: 0x180810000
	public void set_Disposed(bool value) { }

	// RVA: 0x1478260 Offset: 0x1476860 VA: 0x181478260
	public DynamicPropertyCollection get_ClientDynamicProperties() { }

	// RVA: 0x1478320 Offset: 0x1476920 VA: 0x181478320
	public bool get_HasServerDynamicSinks() { }

	// RVA: 0x1478140 Offset: 0x1476740 VA: 0x181478140
	public void NotifyClientDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async) { }

	// RVA: 0x14781D0 Offset: 0x14767D0 VA: 0x1814781D0
	public void NotifyServerDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async) { }

}

