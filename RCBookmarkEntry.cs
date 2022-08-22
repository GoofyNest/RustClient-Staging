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
	// RVA: 0x69D620 Offset: 0x69BC20 VA: 0x18069D620
	private void set_netid(uint value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x69D600 Offset: 0x69BC00 VA: 0x18069D600
	public bool get_isControlling() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x69D610 Offset: 0x69BC10 VA: 0x18069D610
	private void set_isControlling(bool value) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void CursorEnter() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void CursorExit() { }

	// RVA: 0x69D4A0 Offset: 0x69BAA0 VA: 0x18069D4A0
	public void Setup(string newidentifier, uint newnetid, ComputerMenu ownerMenu, string overrideText = "") { }

	// RVA: 0x69D410 Offset: 0x69BA10 VA: 0x18069D410
	public void DeletePressed() { }

	// RVA: 0x69D470 Offset: 0x69BA70 VA: 0x18069D470
	public void OnPressed() { }

	// RVA: 0x69D440 Offset: 0x69BA40 VA: 0x18069D440
	public void DisconnectedPressed() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

