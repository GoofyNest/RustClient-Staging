public class PickAFriend : UIDialog // TypeDefIndex: 10903
{	// Fields
	public InputField input; // 0x30
	public RustText headerText; // 0x38
	public bool AutoSelectInputField; // 0x40
	public Action<ulong, string> onSelected; // 0x48
	public Translate.Phrase sleepingBagHeaderPhrase; // 0x50
	public Translate.Phrase turretHeaderPhrase; // 0x58
	public SteamFriendsList friendsList; // 0x60

	// Properties
	public Func<ulong, bool> shouldShowPlayer { set; }

	// Methods

	// RVA: 0x90A680 Offset: 0x908C80 VA: 0x18090A680
	public void set_shouldShowPlayer(Func<ulong, bool> value) { }

	// RVA: 0x90A570 Offset: 0x908B70 VA: 0x18090A570
	public void SetHeaderText(PickAFriend.PickFriendMode mode) { }

	// RVA: 0x90A3E0 Offset: 0x9089E0 VA: 0x18090A3E0 Slot: 8
	public override void OpenDialog() { }

	// RVA: 0x90A290 Offset: 0x908890 VA: 0x18090A290
	private void CheckForNoInput() { }

	// RVA: 0x90A4D0 Offset: 0x908AD0 VA: 0x18090A4D0
	public void SelectTextField() { }

	// RVA: 0x90A360 Offset: 0x908960 VA: 0x18090A360
	public void DoAssign(ulong steamid, string steamName) { }

	// RVA: 0x90A210 Offset: 0x908810 VA: 0x18090A210
	public void Cancel() { }

	// RVA: 0x90A5D0 Offset: 0x908BD0 VA: 0x18090A5D0
	public void .ctor() { }

}

public enum PickAFriend.PickFriendMode // TypeDefIndex: 10904
{	// Fields
	public int value__; // 0x0
	public const PickAFriend.PickFriendMode SleepingBag = 0;
	public const PickAFriend.PickFriendMode AutoTurret = 1;

}

