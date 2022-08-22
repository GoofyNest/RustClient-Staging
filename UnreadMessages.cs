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

	// RVA: 0x1133630 Offset: 0x1131C30 VA: 0x181133630 Slot: 6
	protected override void Awake() { }

	// RVA: 0x11336B0 Offset: 0x1131CB0 VA: 0x1811336B0
	public void Frame() { }

	// RVA: 0x1134360 Offset: 0x1132960 VA: 0x181134360
	private void UpdateForAmount(int count) { }

	// RVA: 0x1133870 Offset: 0x1131E70 VA: 0x181133870
	public void OpenList() { }

	// RVA: 0x1133680 Offset: 0x1131C80 VA: 0x181133680
	public void CloseList() { }

	// RVA: 0x11344A0 Offset: 0x1132AA0 VA: 0x1811344A0
	public void .ctor() { }

}

private sealed class UnreadMessages.<>c__DisplayClass13_0 // TypeDefIndex: 11176
{	// Fields
	public NoticeData info; // 0x10

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x1128170 Offset: 0x1126770 VA: 0x181128170
	internal void <OpenList>b__2() { }

}

private sealed class UnreadMessages.<>c // TypeDefIndex: 11177
{	// Fields
	public static readonly UnreadMessages.<>c <>9; // 0x0
	public static Func<AccountNotice, bool> <>9__13_0; // 0x8
	public static Func<AccountNotice, DateTime> <>9__13_1; // 0x10

	// Methods

	// RVA: 0x11281C0 Offset: 0x11267C0 VA: 0x1811281C0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x1128150 Offset: 0x1126750 VA: 0x181128150
	internal bool <OpenList>b__13_0(AccountNotice x) { }

	// RVA: 0x956EC0 Offset: 0x9554C0 VA: 0x180956EC0
	internal DateTime <OpenList>b__13_1(AccountNotice x) { }

}

