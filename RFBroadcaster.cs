public class RFBroadcaster : IOEntity, IRFObject // TypeDefIndex: 10157
{
	private Option __menuOption_Menu_SetFreqency;
	public int frequency;
	public GameObjectRef frequencyPanelPrefab;
	public const BaseEntity.Flags Flag_Broadcasting = 512;
	public bool playerUsable;

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public int GetFrequency() { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	[BaseEntity.Menu]
	[BaseEntity.Menu.Description]
	[BaseEntity.Menu.Icon]
	[BaseEntity.Menu.ShowIf]
	public void Menu_SetFreqency(BasePlayer player) { }

	public bool Menu_SetFrequency_ShowIf(BasePlayer player) { }

	public void ClientSetFrequency(int newFreq) { }

	public void .ctor() { }

}

