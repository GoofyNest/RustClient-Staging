internal class SendMouseEvents // TypeDefIndex: 4076
{	// Fields
	private static bool s_MouseUsed; // 0x0
	private static readonly SendMouseEvents.HitInfo[] m_LastHit; // 0x8
	private static readonly SendMouseEvents.HitInfo[] m_MouseDownHit; // 0x10
	private static readonly SendMouseEvents.HitInfo[] m_CurrentHit; // 0x18
	private static Camera[] m_Cameras; // 0x20

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x23156E0 Offset: 0x2313CE0 VA: 0x1823156E0
	private static void SetMouseMoved() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2313F20 Offset: 0x2312520 VA: 0x182313F20
	private static void DoSendMouseEvents(int skipRTCameras) { }

	// RVA: 0x2314C20 Offset: 0x2313220 VA: 0x182314C20
	private static void SendEvents(int i, SendMouseEvents.HitInfo hit) { }

	// RVA: 0x2315740 Offset: 0x2313D40 VA: 0x182315740
	private static void .cctor() { }

}

private struct SendMouseEvents.HitInfo // TypeDefIndex: 4077
{	// Fields
	public GameObject target; // 0x0
	public Camera camera; // 0x8

	// Methods

	// RVA: 0x240A70 Offset: 0x23FE70 VA: 0x180240A70
	public void SendMessage(string name) { }

	// RVA: 0x23136E0 Offset: 0x2311CE0 VA: 0x1823136E0
	public static bool op_Implicit(SendMouseEvents.HitInfo exists) { }

	// RVA: 0x2313620 Offset: 0x2311C20 VA: 0x182313620
	public static bool Compare(SendMouseEvents.HitInfo lhs, SendMouseEvents.HitInfo rhs) { }

}

