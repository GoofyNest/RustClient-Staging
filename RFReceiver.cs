public class RFReceiver : IOEntity, IRFObject // TypeDefIndex: 8438
{	private Option __menuOption_Menu_SetFreqency; // 0x288
	public int frequency; // 0x2E0
	public GameObjectRef frequencyPanelPrefab; // 0x2E8

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public int GetFrequency() { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	[BaseEntity.Menu] // RVA: 0x807E0 Offset: 0x7FBE0 VA: 0x1800807E0
	[BaseEntity.Menu.Description] // RVA: 0x807E0 Offset: 0x7FBE0 VA: 0x1800807E0
	[BaseEntity.Menu.Icon] // RVA: 0x807E0 Offset: 0x7FBE0 VA: 0x1800807E0
	[BaseEntity.Menu.ShowIf] // RVA: 0x807E0 Offset: 0x7FBE0 VA: 0x1800807E0
	public void Menu_SetFreqency(BasePlayer player) { }

	public bool Menu_SetFrequency_ShowIf(BasePlayer player) { }

	public void ClientSetFrequency(int newFreq) { }

	public void .ctor() { }

}

