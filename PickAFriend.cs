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

	// RVA: 0x90A790 Offset: 0x908D90 VA: 0x18090A790
	public void set_shouldShowPlayer(Func<ulong, bool> value) { }

	// RVA: 0x90A680 Offset: 0x908C80 VA: 0x18090A680
	public void SetHeaderText(PickAFriend.PickFriendMode mode) { }

	// RVA: 0x90A4F0 Offset: 0x908AF0 VA: 0x18090A4F0 Slot: 8
	public override void OpenDialog() { }

	// RVA: 0x90A3A0 Offset: 0x9089A0 VA: 0x18090A3A0
	private void CheckForNoInput() { }

	// RVA: 0x90A5E0 Offset: 0x908BE0 VA: 0x18090A5E0
	public void SelectTextField() { }

	// RVA: 0x90A470 Offset: 0x908A70 VA: 0x18090A470
	public void DoAssign(ulong steamid, string steamName) { }

	// RVA: 0x90A320 Offset: 0x908920 VA: 0x18090A320
	public void Cancel() { }

	// RVA: 0x90A6E0 Offset: 0x908CE0 VA: 0x18090A6E0
	public void .ctor() { }

}

public enum PickAFriend.PickFriendMode // TypeDefIndex: 10904
{	// Fields
	public int value__; // 0x0
	public const PickAFriend.PickFriendMode SleepingBag = 0;
	public const PickAFriend.PickFriendMode AutoTurret = 1;

}

