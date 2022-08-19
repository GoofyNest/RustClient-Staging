internal class SendMouseEvents // TypeDefIndex: 4076
{	// Fields
	private static bool s_MouseUsed; // 0x0
	private static readonly SendMouseEvents.HitInfo[] m_LastHit; // 0x8
	private static readonly SendMouseEvents.HitInfo[] m_MouseDownHit; // 0x10
	private static readonly SendMouseEvents.HitInfo[] m_CurrentHit; // 0x18
	private static Camera[] m_Cameras; // 0x20

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x23158A0 Offset: 0x2313EA0 VA: 0x1823158A0
	private static void SetMouseMoved() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x23140E0 Offset: 0x23126E0 VA: 0x1823140E0
	private static void DoSendMouseEvents(int skipRTCameras) { }

	// RVA: 0x2314DE0 Offset: 0x23133E0 VA: 0x182314DE0
	private static void SendEvents(int i, SendMouseEvents.HitInfo hit) { }

	// RVA: 0x2315900 Offset: 0x2313F00 VA: 0x182315900
	private static void .cctor() { }

}

private struct SendMouseEvents.HitInfo // TypeDefIndex: 4077
{	// Fields
	public GameObject target; // 0x0
	public Camera camera; // 0x8

	// Methods

	// RVA: 0x240AF0 Offset: 0x23FEF0 VA: 0x180240AF0
	public void SendMessage(string name) { }

	// RVA: 0x23138A0 Offset: 0x2311EA0 VA: 0x1823138A0
	public static bool op_Implicit(SendMouseEvents.HitInfo exists) { }

	// RVA: 0x23137E0 Offset: 0x2311DE0 VA: 0x1823137E0
	public static bool Compare(SendMouseEvents.HitInfo lhs, SendMouseEvents.HitInfo rhs) { }

}

