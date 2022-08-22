internal class SendMouseEvents // TypeDefIndex: 4076
{	// Fields
	private static bool s_MouseUsed; // 0x0
	private static readonly SendMouseEvents.HitInfo[] m_LastHit; // 0x8
	private static readonly SendMouseEvents.HitInfo[] m_MouseDownHit; // 0x10
	private static readonly SendMouseEvents.HitInfo[] m_CurrentHit; // 0x18
	private static Camera[] m_Cameras; // 0x20

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x23159A0 Offset: 0x2313FA0 VA: 0x1823159A0
	private static void SetMouseMoved() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x23141E0 Offset: 0x23127E0 VA: 0x1823141E0
	private static void DoSendMouseEvents(int skipRTCameras) { }

	// RVA: 0x2314EE0 Offset: 0x23134E0 VA: 0x182314EE0
	private static void SendEvents(int i, SendMouseEvents.HitInfo hit) { }

	// RVA: 0x2315A00 Offset: 0x2314000 VA: 0x182315A00
	private static void .cctor() { }

}

private struct SendMouseEvents.HitInfo // TypeDefIndex: 4077
{	// Fields
	public GameObject target; // 0x0
	public Camera camera; // 0x8

	// Methods

	// RVA: 0x240A70 Offset: 0x23FE70 VA: 0x180240A70
	public void SendMessage(string name) { }

	// RVA: 0x23139A0 Offset: 0x2311FA0 VA: 0x1823139A0
	public static bool op_Implicit(SendMouseEvents.HitInfo exists) { }

	// RVA: 0x23138E0 Offset: 0x2311EE0 VA: 0x1823138E0
	public static bool Compare(SendMouseEvents.HitInfo lhs, SendMouseEvents.HitInfo rhs) { }

}

