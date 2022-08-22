internal class EtwSession // TypeDefIndex: 1618
{	// Fields
	public readonly int m_etwSessionId; // 0x10
	public ActivityFilter m_activityFilter; // 0x18
	private static List<WeakReference<EtwSession>> s_etwSessions; // 0x0

	// Methods

	// RVA: 0xD743E0 Offset: 0xD729E0 VA: 0x180D743E0
	public static EtwSession GetEtwSession(int etwSessionId, bool bCreateIfNeeded = False) { }

	// RVA: 0xD74730 Offset: 0xD72D30 VA: 0x180D74730
	public static void RemoveEtwSession(EtwSession etwSession) { }

	// RVA: 0xD74890 Offset: 0xD72E90 VA: 0x180D74890
	private static void TrimGlobalList() { }

	// RVA: 0x49A8E0 Offset: 0x498EE0 VA: 0x18049A8E0
	private void .ctor(int etwSessionId) { }

	// RVA: 0xD749F0 Offset: 0xD72FF0 VA: 0x180D749F0
	private static void .cctor() { }

}

private sealed class EtwSession.<>c__DisplayClass1_0 // TypeDefIndex: 1619
{	// Fields
	public EtwSession etwSession; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xD88400 Offset: 0xD86A00 VA: 0x180D88400
	internal bool <RemoveEtwSession>b__0(WeakReference<EtwSession> wrEtwSession) { }

}

private sealed class EtwSession.<>c // TypeDefIndex: 1620
{	// Fields
	public static readonly EtwSession.<>c <>9; // 0x0
	public static Predicate<WeakReference<EtwSession>> <>9__2_0; // 0x8

	// Methods

	// RVA: 0xD88560 Offset: 0xD86B60 VA: 0x180D88560
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0xD88290 Offset: 0xD86890 VA: 0x180D88290
	internal bool <TrimGlobalList>b__2_0(WeakReference<EtwSession> wrEtwSession) { }

}

