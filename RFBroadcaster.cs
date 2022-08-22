public class RFBroadcaster : IOEntity, IRFObject // TypeDefIndex: 8437
{	// Fields
	private Option __menuOption_Menu_SetFreqency; // 0x288
	public int frequency; // 0x2E0
	public GameObjectRef frequencyPanelPrefab; // 0x2E8
	public const BaseEntity.Flags Flag_Broadcasting = 512;
	public bool playerUsable; // 0x2F0

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x69F240 Offset: 0x69D840 VA: 0x18069F240 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x69F9E0 Offset: 0x69DFE0 VA: 0x18069F9E0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x69F890 Offset: 0x69DE90 VA: 0x18069F890 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x69F230 Offset: 0x69D830 VA: 0x18069F230 Slot: 160
	public int GetFrequency() { }

	// RVA: 0x69F550 Offset: 0x69DB50 VA: 0x18069F550 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	[BaseEntity.Menu] // RVA: 0x80230 Offset: 0x7F630 VA: 0x180080230
	[BaseEntity.Menu.Description] // RVA: 0x80230 Offset: 0x7F630 VA: 0x180080230
	[BaseEntity.Menu.Icon] // RVA: 0x80230 Offset: 0x7F630 VA: 0x180080230
	[BaseEntity.Menu.ShowIf] // RVA: 0x80230 Offset: 0x7F630 VA: 0x180080230
	// RVA: 0x69F5B0 Offset: 0x69DBB0 VA: 0x18069F5B0
	public void Menu_SetFreqency(BasePlayer player) { }

	// RVA: 0x69F7C0 Offset: 0x69DDC0 VA: 0x18069F7C0
	public bool Menu_SetFrequency_ShowIf(BasePlayer player) { }

	// RVA: 0x69F1E0 Offset: 0x69D7E0 VA: 0x18069F1E0 Slot: 159
	public void ClientSetFrequency(int newFreq) { }

	// RVA: 0x69F980 Offset: 0x69DF80 VA: 0x18069F980
	public void .ctor() { }

}

