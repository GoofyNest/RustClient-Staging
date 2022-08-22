internal class EtwSession // TypeDefIndex: 1618
{	// Fields
	public readonly int m_etwSessionId; // 0x10
	public ActivityFilter m_activityFilter; // 0x18
	private static List<WeakReference<EtwSession>> s_etwSessions; // 0x0

	// Methods

	// RVA: 0xD73930 Offset: 0xD71F30 VA: 0x180D73930
	public static EtwSession GetEtwSession(int etwSessionId, bool bCreateIfNeeded = False) { }

	// RVA: 0xD73C80 Offset: 0xD72280 VA: 0x180D73C80
	public static void RemoveEtwSession(EtwSession etwSession) { }

	// RVA: 0xD73DE0 Offset: 0xD723E0 VA: 0x180D73DE0
	private static void TrimGlobalList() { }

	// RVA: 0x49A8E0 Offset: 0x498EE0 VA: 0x18049A8E0
	private void .ctor(int etwSessionId) { }

	// RVA: 0xD73F40 Offset: 0xD72540 VA: 0x180D73F40
	private static void .cctor() { }

}

private sealed class EtwSession.<>c__DisplayClass1_0 // TypeDefIndex: 1619
{	// Fields
	public EtwSession etwSession; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xD87950 Offset: 0xD85F50 VA: 0x180D87950
	internal bool <RemoveEtwSession>b__0(WeakReference<EtwSession> wrEtwSession) { }

}

private sealed class EtwSession.<>c // TypeDefIndex: 1620
{	// Fields
	public static readonly EtwSession.<>c <>9; // 0x0
	public static Predicate<WeakReference<EtwSession>> <>9__2_0; // 0x8

	// Methods

	// RVA: 0xD87AB0 Offset: 0xD860B0 VA: 0x180D87AB0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xD877E0 Offset: 0xD85DE0 VA: 0x180D877E0
	internal bool <TrimGlobalList>b__2_0(WeakReference<EtwSession> wrEtwSession) { }

}

