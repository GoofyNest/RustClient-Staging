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

	// RVA: 0x69F2B0 Offset: 0x69D8B0 VA: 0x18069F2B0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x69FA50 Offset: 0x69E050 VA: 0x18069FA50 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x69F900 Offset: 0x69DF00 VA: 0x18069F900 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x69F2A0 Offset: 0x69D8A0 VA: 0x18069F2A0 Slot: 160
	public int GetFrequency() { }

	// RVA: 0x69F5C0 Offset: 0x69DBC0 VA: 0x18069F5C0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	[BaseEntity.Menu] // RVA: 0x80230 Offset: 0x7F630 VA: 0x180080230
	[BaseEntity.Menu.Description] // RVA: 0x80230 Offset: 0x7F630 VA: 0x180080230
	[BaseEntity.Menu.Icon] // RVA: 0x80230 Offset: 0x7F630 VA: 0x180080230
	[BaseEntity.Menu.ShowIf] // RVA: 0x80230 Offset: 0x7F630 VA: 0x180080230
	// RVA: 0x69F620 Offset: 0x69DC20 VA: 0x18069F620
	public void Menu_SetFreqency(BasePlayer player) { }

	// RVA: 0x69F830 Offset: 0x69DE30 VA: 0x18069F830
	public bool Menu_SetFrequency_ShowIf(BasePlayer player) { }

	// RVA: 0x69F250 Offset: 0x69D850 VA: 0x18069F250 Slot: 159
	public void ClientSetFrequency(int newFreq) { }

	// RVA: 0x69F9F0 Offset: 0x69DFF0 VA: 0x18069F9F0
	public void .ctor() { }

}

