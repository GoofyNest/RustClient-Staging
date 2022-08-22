internal class WebConnectionGroup // TypeDefIndex: 3031
{	// Fields
	private ServicePoint sPoint; // 0x10
	private string name; // 0x18
	private LinkedList<WebConnectionGroup.ConnectionState> connections; // 0x20
	private Queue queue; // 0x28
	private bool closing; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private EventHandler ConnectionClosed; // 0x38

	// Properties
	public string Name { get; }
	internal Queue Queue { get; }

	// Methods

	// RVA: 0x11845D0 Offset: 0x1182BD0 VA: 0x1811845D0
	public void .ctor(ServicePoint sPoint, string name) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1184690 Offset: 0x1182C90 VA: 0x181184690
	public void add_ConnectionClosed(EventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x1184730 Offset: 0x1182D30 VA: 0x181184730
	public void remove_ConnectionClosed(EventHandler value) { }

	// RVA: 0x1183E00 Offset: 0x1182400 VA: 0x181183E00
	private void OnConnectionClosed() { }

	// RVA: 0x11836D0 Offset: 0x1181CD0 VA: 0x1811836D0
	public void Close() { }

	// RVA: 0x1183D20 Offset: 0x1182320 VA: 0x181183D20
	public WebConnection GetConnection(HttpWebRequest request, out bool created) { }

	// RVA: 0x1183E20 Offset: 0x1182420 VA: 0x181183E20
	private static void PrepareSharingNtlm(WebConnection cnc, HttpWebRequest request) { }

	// RVA: 0x1183B70 Offset: 0x1182170 VA: 0x181183B70
	private WebConnectionGroup.ConnectionState FindIdleConnection() { }

	// RVA: 0x1183990 Offset: 0x1181F90 VA: 0x181183990
	private WebConnection CreateOrReuseConnection(HttpWebRequest request, out bool created) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public string get_Name() { }

	// RVA: 0x7EE9D0 Offset: 0x7ECFD0 VA: 0x1807EE9D0
	internal Queue get_Queue() { }

	// RVA: 0x11840F0 Offset: 0x11826F0 VA: 0x1811840F0
	internal bool TryRecycle(TimeSpan maxIdleTime, ref DateTime idleSince) { }

}

private class WebConnectionGroup.ConnectionState : IWebConnectionState // TypeDefIndex: 3032
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private WebConnection <Connection>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private WebConnectionGroup <Group>k__BackingField; // 0x18
	private bool busy; // 0x20
	private DateTime idleSince; // 0x28

	// Properties
	public WebConnection Connection { get; set; }
	public WebConnectionGroup Group { get; set; }
	public ServicePoint ServicePoint { get; }
	public bool Busy { get; }
	public DateTime IdleSince { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public WebConnection get_Connection() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC5C0 Offset: 0x4BABC0 VA: 0x1804BC5C0
	private void set_Connection(WebConnection value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	public WebConnectionGroup get_Group() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4D3770 Offset: 0x4D1D70 VA: 0x1804D3770
	private void set_Group(WebConnectionGroup value) { }

	// RVA: 0xE57E40 Offset: 0xE56440 VA: 0x180E57E40 Slot: 7
	public ServicePoint get_ServicePoint() { }

	// RVA: 0xB10B80 Offset: 0xB0F180 VA: 0x180B10B80 Slot: 8
	public bool get_Busy() { }

	// RVA: 0x7EE9D0 Offset: 0x7ECFD0 VA: 0x1807EE9D0 Slot: 9
	public DateTime get_IdleSince() { }

	// RVA: 0x11801C0 Offset: 0x117E7C0 VA: 0x1811801C0 Slot: 5
	public bool TrySetBusy() { }

	// RVA: 0x11800C0 Offset: 0x117E6C0 VA: 0x1811800C0 Slot: 6
	public void SetIdle() { }

	// RVA: 0x1180340 Offset: 0x117E940 VA: 0x181180340
	public void .ctor(WebConnectionGroup group) { }

}

