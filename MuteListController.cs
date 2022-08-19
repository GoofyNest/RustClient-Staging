public class MuteListController : UIDialog // TypeDefIndex: 12040
{	// Fields
	public RectTransform ListParent; // 0x30
	public GameObjectRef UserWidget; // 0x38
	public SteamFriendsList SearchList; // 0x40

	// Methods

	// RVA: 0x4C15B0 Offset: 0x4BFBB0 VA: 0x1804C15B0 Slot: 6
	protected override void OnEnable() { }

	// RVA: 0x4C16C0 Offset: 0x4BFCC0 VA: 0x1804C16C0
	private void PopulateMuteList() { }

	// RVA: 0x4C1A40 Offset: 0x4C0040 VA: 0x1804C1A40
	public void RemoveFromMuteList(ulong id) { }

	// RVA: 0x4C1500 Offset: 0x4BFB00 VA: 0x1804C1500
	public void MutePlayer(ulong id, string playerName) { }

	// RVA: 0x4C1AB0 Offset: 0x4C00B0 VA: 0x1804C1AB0
	public void .ctor() { }

}

private sealed class MuteListController.<>c // TypeDefIndex: 12041
{	// Fields
	public static readonly MuteListController.<>c <>9; // 0x0
	public static Func<ulong, bool> <>9__3_0; // 0x8

	// Methods

	// RVA: 0x4D26E0 Offset: 0x4D0CE0 VA: 0x1804D26E0
	private static void .cctor() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x4D1C40 Offset: 0x4D0240 VA: 0x1804D1C40
	internal bool <OnEnable>b__3_0(ulong arg) { }

}

private sealed class MuteListController.<>c__DisplayClass4_0 // TypeDefIndex: 12042
{	// Fields
	public Chat.MuteEntry muteEntry; // 0x10
	public MuteListController <>4__this; // 0x28

	// Methods

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

	// RVA: 0x4D24E0 Offset: 0x4D0AE0 VA: 0x1804D24E0
	internal void <PopulateMuteList>b__0() { }

}

