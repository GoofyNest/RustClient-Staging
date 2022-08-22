public class MuteListController : UIDialog // TypeDefIndex: 12040
{	// Fields
	public RectTransform ListParent; // 0x30
	public GameObjectRef UserWidget; // 0x38
	public SteamFriendsList SearchList; // 0x40

	// Methods

	// RVA: 0x4C1540 Offset: 0x4BFB40 VA: 0x1804C1540 Slot: 6
	protected override void OnEnable() { }

	// RVA: 0x4C1650 Offset: 0x4BFC50 VA: 0x1804C1650
	private void PopulateMuteList() { }

	// RVA: 0x4C19D0 Offset: 0x4BFFD0 VA: 0x1804C19D0
	public void RemoveFromMuteList(ulong id) { }

	// RVA: 0x4C1490 Offset: 0x4BFA90 VA: 0x1804C1490
	public void MutePlayer(ulong id, string playerName) { }

	// RVA: 0x4C1A40 Offset: 0x4C0040 VA: 0x1804C1A40
	public void .ctor() { }

}

private sealed class MuteListController.<>c // TypeDefIndex: 12041
{	// Fields
	public static readonly MuteListController.<>c <>9; // 0x0
	public static Func<ulong, bool> <>9__3_0; // 0x8

	// Methods

	// RVA: 0x4D2670 Offset: 0x4D0C70 VA: 0x1804D2670
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x4D1BD0 Offset: 0x4D01D0 VA: 0x1804D1BD0
	internal bool <OnEnable>b__3_0(ulong arg) { }

}

private sealed class MuteListController.<>c__DisplayClass4_0 // TypeDefIndex: 12042
{	// Fields
	public Chat.MuteEntry muteEntry; // 0x10
	public MuteListController <>4__this; // 0x28

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x4D2470 Offset: 0x4D0A70 VA: 0x1804D2470
	internal void <PopulateMuteList>b__0() { }

}

