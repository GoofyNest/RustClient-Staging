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

	// RVA: 0x795BE0 Offset: 0x7941E0 VA: 0x180795BE0
	public bool get_IsConnected() { }

	// RVA: 0x8054F0 Offset: 0x803AF0 VA: 0x1808054F0
	public bool get_Disposed() { }

	// RVA: 0x80FEF0 Offset: 0x80E4F0 VA: 0x18080FEF0
	public void set_Disposed(bool value) { }

	// RVA: 0x1477FA0 Offset: 0x14765A0 VA: 0x181477FA0
	public DynamicPropertyCollection get_ClientDynamicProperties() { }

	// RVA: 0x1478060 Offset: 0x1476660 VA: 0x181478060
	public bool get_HasServerDynamicSinks() { }

	// RVA: 0x1477E80 Offset: 0x1476480 VA: 0x181477E80
	public void NotifyClientDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async) { }

	// RVA: 0x1477F10 Offset: 0x1476510 VA: 0x181477F10
	public void NotifyServerDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async) { }

}

