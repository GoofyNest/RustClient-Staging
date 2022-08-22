public class SpookySpeaker : BaseCombatEntity // TypeDefIndex: 8453
{	// Fields
	private Option __menuOption_Menu_SoundOff; // 0x240
	private Option __menuOption_Menu_SoundOn; // 0x298
	public SoundPlayer soundPlayer; // 0x2F0
	public float soundSpacing; // 0x2F8
	public float soundSpacingRand; // 0x2FC

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0xA811C0 Offset: 0xA7F7C0 VA: 0x180A811C0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0xA81CE0 Offset: 0xA802E0 VA: 0x180A81CE0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0xA817F0 Offset: 0xA7FDF0 VA: 0x180A817F0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA81C20 Offset: 0xA80220 VA: 0x180A81C20
	public void PlaySpookySound() { }

	[BaseEntity.Menu] // RVA: 0x8D4F0 Offset: 0x8C8F0 VA: 0x18008D4F0
	[BaseEntity.Menu.Description] // RVA: 0x8D4F0 Offset: 0x8C8F0 VA: 0x18008D4F0
	[BaseEntity.Menu.Icon] // RVA: 0x8D4F0 Offset: 0x8C8F0 VA: 0x18008D4F0
	[BaseEntity.Menu.ShowIf] // RVA: 0x8D4F0 Offset: 0x8C8F0 VA: 0x18008D4F0
	// RVA: 0xA817A0 Offset: 0xA7FDA0 VA: 0x180A817A0
	public void Menu_SoundOn(BasePlayer player) { }

	// RVA: 0x7BE590 Offset: 0x7BCB90 VA: 0x1807BE590
	public bool Menu_SoundOn_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x8D790 Offset: 0x8CB90 VA: 0x18008D790
	[BaseEntity.Menu.Description] // RVA: 0x8D790 Offset: 0x8CB90 VA: 0x18008D790
	[BaseEntity.Menu.Icon] // RVA: 0x8D790 Offset: 0x8CB90 VA: 0x18008D790
	[BaseEntity.Menu.ShowIf] // RVA: 0x8D790 Offset: 0x8CB90 VA: 0x18008D790
	// RVA: 0xA81750 Offset: 0xA7FD50 VA: 0x180A81750
	public void Menu_SoundOff(BasePlayer player) { }

	// RVA: 0x7BE550 Offset: 0x7BCB50 VA: 0x1807BE550
	public bool Menu_SoundOff_ShowIf(BasePlayer player) { }

	// RVA: 0xA81CC0 Offset: 0xA802C0 VA: 0x180A81CC0
	public void .ctor() { }

}

