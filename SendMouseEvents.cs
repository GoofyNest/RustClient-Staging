internal class SendMouseEvents // TypeDefIndex: 4076
{	// Fields
	private static bool s_MouseUsed; // 0x0
	private static readonly SendMouseEvents.HitInfo[] m_LastHit; // 0x8
	private static readonly SendMouseEvents.HitInfo[] m_MouseDownHit; // 0x10
	private static readonly SendMouseEvents.HitInfo[] m_CurrentHit; // 0x18
	private static Camera[] m_Cameras; // 0x20

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x23161C0 Offset: 0x23147C0 VA: 0x1823161C0
	private static void SetMouseMoved() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2314A00 Offset: 0x2313000 VA: 0x182314A00
	private static void DoSendMouseEvents(int skipRTCameras) { }

	// RVA: 0x2315700 Offset: 0x2313D00 VA: 0x182315700
	private static void SendEvents(int i, SendMouseEvents.HitInfo hit) { }

	// RVA: 0x2316220 Offset: 0x2314820 VA: 0x182316220
	private static void .cctor() { }

}

private struct SendMouseEvents.HitInfo // TypeDefIndex: 4077
{	// Fields
	public GameObject target; // 0x0
	public Camera camera; // 0x8

	// Methods

	// RVA: 0x240A70 Offset: 0x23FE70 VA: 0x180240A70
	public void SendMessage(string name) { }

	// RVA: 0x23141C0 Offset: 0x23127C0 VA: 0x1823141C0
	public static bool op_Implicit(SendMouseEvents.HitInfo exists) { }

	// RVA: 0x2314100 Offset: 0x2312700 VA: 0x182314100
	public static bool Compare(SendMouseEvents.HitInfo lhs, SendMouseEvents.HitInfo rhs) { }

}

