public class RCBookmarkEntry : MonoBehaviour // TypeDefIndex: 8686
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private string <identifier>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private uint <netid>k__BackingField; // 0x20
	private ComputerMenu owner; // 0x28
	public RectTransform connectButton; // 0x30
	public RectTransform disconnectButton; // 0x38
	public RawImage onlineIndicator; // 0x40
	public RawImage offlineIndicator; // 0x48
	public GameObject selectedindicator; // 0x50
	public Image backgroundImage; // 0x58
	public Color activeColor; // 0x60
	public Color inactiveColor; // 0x70
	public Text nameLabel; // 0x80
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private bool <isControlling>k__BackingField; // 0x88
	public EventTrigger eventTrigger; // 0x90

	// Properties
	public string identifier { get; set; }
	public uint netid { get; set; }
	public bool isControlling { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public string get_identifier() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4D37E0 Offset: 0x4D1DE0 VA: 0x1804D37E0
	private void set_identifier(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x4D37D0 Offset: 0x4D1DD0 VA: 0x1804D37D0
	public uint get_netid() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x69D730 Offset: 0x69BD30 VA: 0x18069D730
	private void set_netid(uint value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x69D710 Offset: 0x69BD10 VA: 0x18069D710
	public bool get_isControlling() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x69D720 Offset: 0x69BD20 VA: 0x18069D720
	private void set_isControlling(bool value) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void CursorEnter() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void CursorExit() { }

	// RVA: 0x69D5B0 Offset: 0x69BBB0 VA: 0x18069D5B0
	public void Setup(string newidentifier, uint newnetid, ComputerMenu ownerMenu, string overrideText = "") { }

	// RVA: 0x69D520 Offset: 0x69BB20 VA: 0x18069D520
	public void DeletePressed() { }

	// RVA: 0x69D580 Offset: 0x69BB80 VA: 0x18069D580
	public void OnPressed() { }

	// RVA: 0x69D550 Offset: 0x69BB50 VA: 0x18069D550
	public void DisconnectedPressed() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

