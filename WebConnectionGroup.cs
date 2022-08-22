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

	// RVA: 0x117FCB0 Offset: 0x117E2B0 VA: 0x18117FCB0
	public void .ctor(ServicePoint sPoint, string name) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x117FD70 Offset: 0x117E370 VA: 0x18117FD70
	public void add_ConnectionClosed(EventHandler value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x117FE10 Offset: 0x117E410 VA: 0x18117FE10
	public void remove_ConnectionClosed(EventHandler value) { }

	// RVA: 0x117F4E0 Offset: 0x117DAE0 VA: 0x18117F4E0
	private void OnConnectionClosed() { }

	// RVA: 0x117EDB0 Offset: 0x117D3B0 VA: 0x18117EDB0
	public void Close() { }

	// RVA: 0x117F400 Offset: 0x117DA00 VA: 0x18117F400
	public WebConnection GetConnection(HttpWebRequest request, out bool created) { }

	// RVA: 0x117F500 Offset: 0x117DB00 VA: 0x18117F500
	private static void PrepareSharingNtlm(WebConnection cnc, HttpWebRequest request) { }

	// RVA: 0x117F250 Offset: 0x117D850 VA: 0x18117F250
	private WebConnectionGroup.ConnectionState FindIdleConnection() { }

	// RVA: 0x117F070 Offset: 0x117D670 VA: 0x18117F070
	private WebConnection CreateOrReuseConnection(HttpWebRequest request, out bool created) { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public string get_Name() { }

	// RVA: 0x7EE440 Offset: 0x7ECA40 VA: 0x1807EE440
	internal Queue get_Queue() { }

	// RVA: 0x117F7D0 Offset: 0x117DDD0 VA: 0x18117F7D0
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

	// RVA: 0xE57390 Offset: 0xE55990 VA: 0x180E57390 Slot: 7
	public ServicePoint get_ServicePoint() { }

	// RVA: 0xB106B0 Offset: 0xB0ECB0 VA: 0x180B106B0 Slot: 8
	public bool get_Busy() { }

	// RVA: 0x7EE440 Offset: 0x7ECA40 VA: 0x1807EE440 Slot: 9
	public DateTime get_IdleSince() { }

	// RVA: 0x117B8A0 Offset: 0x1179EA0 VA: 0x18117B8A0 Slot: 5
	public bool TrySetBusy() { }

	// RVA: 0x117B7A0 Offset: 0x1179DA0 VA: 0x18117B7A0 Slot: 6
	public void SetIdle() { }

	// RVA: 0x117BA20 Offset: 0x117A020 VA: 0x18117BA20
	public void .ctor(WebConnectionGroup group) { }

}

