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

	// RVA: 0x68A8A0 Offset: 0x688EA0 VA: 0x18068A8A0
	public void .ctor(string objectUri) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract ObjRef CreateObjRef(Type requestedType);

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public IMessageSink get_ChannelSink() { }

	// RVA: 0x4D3770 Offset: 0x4D1D70 VA: 0x1804D3770
	public void set_ChannelSink(IMessageSink value) { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public IMessageSink get_EnvoySink() { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public string get_ObjectUri() { }

	// RVA: 0x4BC5C0 Offset: 0x4BABC0 VA: 0x1804BC5C0
	public void set_ObjectUri(string value) { }

	// RVA: 0x795C00 Offset: 0x794200 VA: 0x180795C00
	public bool get_IsConnected() { }

	// RVA: 0x805B90 Offset: 0x804190 VA: 0x180805B90
	public bool get_Disposed() { }

	// RVA: 0x810590 Offset: 0x80EB90 VA: 0x180810590
	public void set_Disposed(bool value) { }

	// RVA: 0x1477330 Offset: 0x1475930 VA: 0x181477330
	public DynamicPropertyCollection get_ClientDynamicProperties() { }

	// RVA: 0x14773F0 Offset: 0x14759F0 VA: 0x1814773F0
	public bool get_HasServerDynamicSinks() { }

	// RVA: 0x1477210 Offset: 0x1475810 VA: 0x181477210
	public void NotifyClientDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async) { }

	// RVA: 0x14772A0 Offset: 0x14758A0 VA: 0x1814772A0
	public void NotifyServerDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async) { }

}

