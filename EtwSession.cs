internal class EtwSession // TypeDefIndex: 1618
{	// Fields
	public readonly int m_etwSessionId; // 0x10
	public ActivityFilter m_activityFilter; // 0x18
	private static List<WeakReference<EtwSession>> s_etwSessions; // 0x0

	// Methods

	// RVA: 0xD73670 Offset: 0xD71C70 VA: 0x180D73670
	public static EtwSession GetEtwSession(int etwSessionId, bool bCreateIfNeeded = False) { }

	// RVA: 0xD739C0 Offset: 0xD71FC0 VA: 0x180D739C0
	public static void RemoveEtwSession(EtwSession etwSession) { }

	// RVA: 0xD73B20 Offset: 0xD72120 VA: 0x180D73B20
	private static void TrimGlobalList() { }

	// RVA: 0x49A8E0 Offset: 0x498EE0 VA: 0x18049A8E0
	private void .ctor(int etwSessionId) { }

	// RVA: 0xD73C80 Offset: 0xD72280 VA: 0x180D73C80
	private static void .cctor() { }

}

private sealed class EtwSession.<>c__DisplayClass1_0 // TypeDefIndex: 1619
{	// Fields
	public EtwSession etwSession; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xD87690 Offset: 0xD85C90 VA: 0x180D87690
	internal bool <RemoveEtwSession>b__0(WeakReference<EtwSession> wrEtwSession) { }

}

private sealed class EtwSession.<>c // TypeDefIndex: 1620
{	// Fields
	public static readonly EtwSession.<>c <>9; // 0x0
	public static Predicate<WeakReference<EtwSession>> <>9__2_0; // 0x8

	// Methods

	// RVA: 0xD877F0 Offset: 0xD85DF0 VA: 0x180D877F0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xD87520 Offset: 0xD85B20 VA: 0x180D87520
	internal bool <TrimGlobalList>b__2_0(WeakReference<EtwSession> wrEtwSession) { }

}

