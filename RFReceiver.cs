public class RFReceiver : IOEntity, IRFObject // TypeDefIndex: 8438
{	// Fields
	private Option __menuOption_Menu_SetFreqency; // 0x288
	public int frequency; // 0x2E0
	public GameObjectRef frequencyPanelPrefab; // 0x2E8

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x69FCD0 Offset: 0x69E2D0 VA: 0x18069FCD0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x6A03F0 Offset: 0x69E9F0 VA: 0x1806A03F0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x6A02A0 Offset: 0x69E8A0 VA: 0x1806A02A0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x69F2A0 Offset: 0x69D8A0 VA: 0x18069F2A0 Slot: 160
	public int GetFrequency() { }

	// RVA: 0x69F5C0 Offset: 0x69DBC0 VA: 0x18069F5C0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	[BaseEntity.Menu] // RVA: 0x806F0 Offset: 0x7FAF0 VA: 0x1800806F0
	[BaseEntity.Menu.Description] // RVA: 0x806F0 Offset: 0x7FAF0 VA: 0x1800806F0
	[BaseEntity.Menu.Icon] // RVA: 0x806F0 Offset: 0x7FAF0 VA: 0x1800806F0
	[BaseEntity.Menu.ShowIf] // RVA: 0x806F0 Offset: 0x7FAF0 VA: 0x1800806F0
	// RVA: 0x69FFE0 Offset: 0x69E5E0 VA: 0x18069FFE0
	public void Menu_SetFreqency(BasePlayer player) { }

	// RVA: 0x6A01F0 Offset: 0x69E7F0 VA: 0x1806A01F0
	public bool Menu_SetFrequency_ShowIf(BasePlayer player) { }

	// RVA: 0x69FC80 Offset: 0x69E280 VA: 0x18069FC80 Slot: 159
	public void ClientSetFrequency(int newFreq) { }

	// RVA: 0x6A0390 Offset: 0x69E990 VA: 0x1806A0390
	public void .ctor() { }

}

