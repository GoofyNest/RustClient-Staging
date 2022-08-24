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

	[BaseEntity.RPC_Client] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public void PlaySpookySound() { }

	[BaseEntity.Menu] // RVA: 0x8D630 Offset: 0x8CA30 VA: 0x18008D630
	[BaseEntity.Menu.Description] // RVA: 0x8D630 Offset: 0x8CA30 VA: 0x18008D630
	[BaseEntity.Menu.Icon] // RVA: 0x8D630 Offset: 0x8CA30 VA: 0x18008D630
	[BaseEntity.Menu.ShowIf] // RVA: 0x8D630 Offset: 0x8CA30 VA: 0x18008D630
	public void Menu_SoundOn(BasePlayer player) { }

	public bool Menu_SoundOn_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x8D8D0 Offset: 0x8CCD0 VA: 0x18008D8D0
	[BaseEntity.Menu.Description] // RVA: 0x8D8D0 Offset: 0x8CCD0 VA: 0x18008D8D0
	[BaseEntity.Menu.Icon] // RVA: 0x8D8D0 Offset: 0x8CCD0 VA: 0x18008D8D0
	[BaseEntity.Menu.ShowIf] // RVA: 0x8D8D0 Offset: 0x8CCD0 VA: 0x18008D8D0
	public void Menu_SoundOff(BasePlayer player) { }

	public bool Menu_SoundOff_ShowIf(BasePlayer player) { }

	public void .ctor() { }

}

