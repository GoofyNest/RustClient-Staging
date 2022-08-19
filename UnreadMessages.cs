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

	// RVA: 0x1133370 Offset: 0x1131970 VA: 0x181133370 Slot: 6
	protected override void Awake() { }

	// RVA: 0x11333F0 Offset: 0x11319F0 VA: 0x1811333F0
	public void Frame() { }

	// RVA: 0x11340A0 Offset: 0x11326A0 VA: 0x1811340A0
	private void UpdateForAmount(int count) { }

	// RVA: 0x11335B0 Offset: 0x1131BB0 VA: 0x1811335B0
	public void OpenList() { }

	// RVA: 0x11333C0 Offset: 0x11319C0 VA: 0x1811333C0
	public void CloseList() { }

	// RVA: 0x11341E0 Offset: 0x11327E0 VA: 0x1811341E0
	public void .ctor() { }

}

private sealed class UnreadMessages.<>c__DisplayClass13_0 // TypeDefIndex: 11176
{	// Fields
	public NoticeData info; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x1127EB0 Offset: 0x11264B0 VA: 0x181127EB0
	internal void <OpenList>b__2() { }

}

private sealed class UnreadMessages.<>c // TypeDefIndex: 11177
{	// Fields
	public static readonly UnreadMessages.<>c <>9; // 0x0
	public static Func<AccountNotice, bool> <>9__13_0; // 0x8
	public static Func<AccountNotice, DateTime> <>9__13_1; // 0x10

	// Methods

	// RVA: 0x1127F00 Offset: 0x1126500 VA: 0x181127F00
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x1127E90 Offset: 0x1126490 VA: 0x181127E90
	internal bool <OpenList>b__13_0(AccountNotice x) { }

	// RVA: 0x956DB0 Offset: 0x9553B0 VA: 0x180956DB0
	internal DateTime <OpenList>b__13_1(AccountNotice x) { }

}

