public class SpookySpeaker : BaseCombatEntity // TypeDefIndex: 8453
{	private Option __menuOption_Menu_SoundOff; // 0x240
	private Option __menuOption_Menu_SoundOn; // 0x298
	public SoundPlayer soundPlayer; // 0x2F0
	public float soundSpacing; // 0x2F8
	public float soundSpacingRand; // 0x2FC

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void PlaySpookySound() { }

	[BaseEntity.Menu] // RVA: 0x8D4F0 Offset: 0x8C8F0 VA: 0x18008D4F0
	[BaseEntity.Menu.Description] // RVA: 0x8D4F0 Offset: 0x8C8F0 VA: 0x18008D4F0
	[BaseEntity.Menu.Icon] // RVA: 0x8D4F0 Offset: 0x8C8F0 VA: 0x18008D4F0
	[BaseEntity.Menu.ShowIf] // RVA: 0x8D4F0 Offset: 0x8C8F0 VA: 0x18008D4F0
	public void Menu_SoundOn(BasePlayer player) { }

	public bool Menu_SoundOn_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x8D790 Offset: 0x8CB90 VA: 0x18008D790
	[BaseEntity.Menu.Description] // RVA: 0x8D790 Offset: 0x8CB90 VA: 0x18008D790
	[BaseEntity.Menu.Icon] // RVA: 0x8D790 Offset: 0x8CB90 VA: 0x18008D790
	[BaseEntity.Menu.ShowIf] // RVA: 0x8D790 Offset: 0x8CB90 VA: 0x18008D790
	public void Menu_SoundOff(BasePlayer player) { }

	public bool Menu_SoundOff_ShowIf(BasePlayer player) { }

	public void .ctor() { }

}

