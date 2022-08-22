public class UnreadMessages : SingletonComponent<UnreadMessages> // TypeDefIndex: 11175
{	// Fields
	public StyleAsset AllRead; // 0x18
	public StyleAsset Unread; // 0x20
	public RustButton Button; // 0x28
	public GameObject UnreadTextObject; // 0x30
	public RustText UnreadText; // 0x38
	public GameObject MessageList; // 0x40
	public GameObject MessageListContainer; // 0x48
	public GameObject MessageListEmpty; // 0x50
	private int lastCount; // 0x58
	private List<RustButton> createdButtons; // 0x60

	// Methods

	// RVA: 0x11340A0 Offset: 0x11326A0 VA: 0x1811340A0 Slot: 6
	protected override void Awake() { }

	// RVA: 0x1134120 Offset: 0x1132720 VA: 0x181134120
	public void Frame() { }

	// RVA: 0x1134DD0 Offset: 0x11333D0 VA: 0x181134DD0
	private void UpdateForAmount(int count) { }

	// RVA: 0x11342E0 Offset: 0x11328E0 VA: 0x1811342E0
	public void OpenList() { }

	// RVA: 0x11340F0 Offset: 0x11326F0 VA: 0x1811340F0
	public void CloseList() { }

	// RVA: 0x1134F10 Offset: 0x1133510 VA: 0x181134F10
	public void .ctor() { }

}

private sealed class UnreadMessages.<>c__DisplayClass13_0 // TypeDefIndex: 11176
{	// Fields
	public NoticeData info; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x1128BE0 Offset: 0x11271E0 VA: 0x181128BE0
	internal void <OpenList>b__2() { }

}

private sealed class UnreadMessages.<>c // TypeDefIndex: 11177
{	// Fields
	public static readonly UnreadMessages.<>c <>9; // 0x0
	public static Func<AccountNotice, bool> <>9__13_0; // 0x8
	public static Func<AccountNotice, DateTime> <>9__13_1; // 0x10

	// Methods

	// RVA: 0x1128C30 Offset: 0x1127230 VA: 0x181128C30
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x1128BC0 Offset: 0x11271C0 VA: 0x181128BC0
	internal bool <OpenList>b__13_0(AccountNotice x) { }

	// RVA: 0x9573C0 Offset: 0x9559C0 VA: 0x1809573C0
	internal DateTime <OpenList>b__13_1(AccountNotice x) { }

}

