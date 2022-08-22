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

	// RVA: 0x117F9F0 Offset: 0x117DFF0 VA: 0x18117F9F0
	public void .ctor(ServicePoint sPoint, string name) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x117FAB0 Offset: 0x117E0B0 VA: 0x18117FAB0
	public void add_ConnectionClosed(EventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x117FB50 Offset: 0x117E150 VA: 0x18117FB50
	public void remove_ConnectionClosed(EventHandler value) { }

	// RVA: 0x117F220 Offset: 0x117D820 VA: 0x18117F220
	private void OnConnectionClosed() { }

	// RVA: 0x117EAF0 Offset: 0x117D0F0 VA: 0x18117EAF0
	public void Close() { }

	// RVA: 0x117F140 Offset: 0x117D740 VA: 0x18117F140
	public WebConnection GetConnection(HttpWebRequest request, out bool created) { }

	// RVA: 0x117F240 Offset: 0x117D840 VA: 0x18117F240
	private static void PrepareSharingNtlm(WebConnection cnc, HttpWebRequest request) { }

	// RVA: 0x117EF90 Offset: 0x117D590 VA: 0x18117EF90
	private WebConnectionGroup.ConnectionState FindIdleConnection() { }

	// RVA: 0x117EDB0 Offset: 0x117D3B0 VA: 0x18117EDB0
	private WebConnection CreateOrReuseConnection(HttpWebRequest request, out bool created) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public string get_Name() { }

	// RVA: 0x7EE330 Offset: 0x7EC930 VA: 0x1807EE330
	internal Queue get_Queue() { }

	// RVA: 0x117F510 Offset: 0x117DB10 VA: 0x18117F510
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
	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public WebConnection get_Connection() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4BC630 Offset: 0x4BAC30 VA: 0x1804BC630
	private void set_Connection(WebConnection value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880 Slot: 4
	public WebConnectionGroup get_Group() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0
	private void set_Group(WebConnectionGroup value) { }

	// RVA: 0xE570D0 Offset: 0xE556D0 VA: 0x180E570D0 Slot: 7
	public ServicePoint get_ServicePoint() { }

	// RVA: 0xB103F0 Offset: 0xB0E9F0 VA: 0x180B103F0 Slot: 8
	public bool get_Busy() { }

	// RVA: 0x7EE330 Offset: 0x7EC930 VA: 0x1807EE330 Slot: 9
	public DateTime get_IdleSince() { }

	// RVA: 0x117B5E0 Offset: 0x1179BE0 VA: 0x18117B5E0 Slot: 5
	public bool TrySetBusy() { }

	// RVA: 0x117B4E0 Offset: 0x1179AE0 VA: 0x18117B4E0 Slot: 6
	public void SetIdle() { }

	// RVA: 0x117B760 Offset: 0x1179D60 VA: 0x18117B760
	public void .ctor(WebConnectionGroup group) { }

}

