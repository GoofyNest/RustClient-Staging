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

	// RVA: 0x90ACA0 Offset: 0x9092A0 VA: 0x18090ACA0
	public void set_shouldShowPlayer(Func<ulong, bool> value) { }

	// RVA: 0x90AB90 Offset: 0x909190 VA: 0x18090AB90
	public void SetHeaderText(PickAFriend.PickFriendMode mode) { }

	// RVA: 0x90AA00 Offset: 0x909000 VA: 0x18090AA00 Slot: 8
	public override void OpenDialog() { }

	// RVA: 0x90A8B0 Offset: 0x908EB0 VA: 0x18090A8B0
	private void CheckForNoInput() { }

	// RVA: 0x90AAF0 Offset: 0x9090F0 VA: 0x18090AAF0
	public void SelectTextField() { }

	// RVA: 0x90A980 Offset: 0x908F80 VA: 0x18090A980
	public void DoAssign(ulong steamid, string steamName) { }

	// RVA: 0x90A830 Offset: 0x908E30 VA: 0x18090A830
	public void Cancel() { }

	// RVA: 0x90ABF0 Offset: 0x9091F0 VA: 0x18090ABF0
	public void .ctor() { }

}

public enum PickAFriend.PickFriendMode // TypeDefIndex: 10904
{	// Fields
	public int value__; // 0x0
	public const PickAFriend.PickFriendMode SleepingBag = 0;
	public const PickAFriend.PickFriendMode AutoTurret = 1;

}

