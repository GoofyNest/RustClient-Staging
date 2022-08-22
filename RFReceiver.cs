public class RFReceiver : IOEntity, IRFObject // TypeDefIndex: 8438
{	// Fields
	private Option __menuOption_Menu_SetFreqency; // 0x288
	public int frequency; // 0x2E0
	public GameObjectRef frequencyPanelPrefab; // 0x2E8

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x69FBC0 Offset: 0x69E1C0 VA: 0x18069FBC0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x6A02E0 Offset: 0x69E8E0 VA: 0x1806A02E0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x6A0190 Offset: 0x69E790 VA: 0x1806A0190 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x69F190 Offset: 0x69D790 VA: 0x18069F190 Slot: 160
	public int GetFrequency() { }

	// RVA: 0x69F4B0 Offset: 0x69DAB0 VA: 0x18069F4B0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	[BaseEntity.Menu] // RVA: 0x806F0 Offset: 0x7FAF0 VA: 0x1800806F0
	[BaseEntity.Menu.Description] // RVA: 0x806F0 Offset: 0x7FAF0 VA: 0x1800806F0
	[BaseEntity.Menu.Icon] // RVA: 0x806F0 Offset: 0x7FAF0 VA: 0x1800806F0
	[BaseEntity.Menu.ShowIf] // RVA: 0x806F0 Offset: 0x7FAF0 VA: 0x1800806F0
	// RVA: 0x69FED0 Offset: 0x69E4D0 VA: 0x18069FED0
	public void Menu_SetFreqency(BasePlayer player) { }

	// RVA: 0x6A00E0 Offset: 0x69E6E0 VA: 0x1806A00E0
	public bool Menu_SetFrequency_ShowIf(BasePlayer player) { }

	// RVA: 0x69FB70 Offset: 0x69E170 VA: 0x18069FB70 Slot: 159
	public void ClientSetFrequency(int newFreq) { }

	// RVA: 0x6A0280 Offset: 0x69E880 VA: 0x1806A0280
	public void .ctor() { }

}

