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

	// RVA: 0x69F1A0 Offset: 0x69D7A0 VA: 0x18069F1A0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x69F940 Offset: 0x69DF40 VA: 0x18069F940 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x69F7F0 Offset: 0x69DDF0 VA: 0x18069F7F0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x69F190 Offset: 0x69D790 VA: 0x18069F190 Slot: 160
	public int GetFrequency() { }

	// RVA: 0x69F4B0 Offset: 0x69DAB0 VA: 0x18069F4B0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	[BaseEntity.Menu] // RVA: 0x80230 Offset: 0x7F630 VA: 0x180080230
	[BaseEntity.Menu.Description] // RVA: 0x80230 Offset: 0x7F630 VA: 0x180080230
	[BaseEntity.Menu.Icon] // RVA: 0x80230 Offset: 0x7F630 VA: 0x180080230
	[BaseEntity.Menu.ShowIf] // RVA: 0x80230 Offset: 0x7F630 VA: 0x180080230
	// RVA: 0x69F510 Offset: 0x69DB10 VA: 0x18069F510
	public void Menu_SetFreqency(BasePlayer player) { }

	// RVA: 0x69F720 Offset: 0x69DD20 VA: 0x18069F720
	public bool Menu_SetFrequency_ShowIf(BasePlayer player) { }

	// RVA: 0x69F140 Offset: 0x69D740 VA: 0x18069F140 Slot: 159
	public void ClientSetFrequency(int newFreq) { }

	// RVA: 0x69F8E0 Offset: 0x69DEE0 VA: 0x18069F8E0
	public void .ctor() { }

}

