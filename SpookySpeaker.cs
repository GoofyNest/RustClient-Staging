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

	// RVA: 0xA80A30 Offset: 0xA7F030 VA: 0x180A80A30 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0xA81550 Offset: 0xA7FB50 VA: 0x180A81550 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0xA81060 Offset: 0xA7F660 VA: 0x180A81060 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA81490 Offset: 0xA7FA90 VA: 0x180A81490
	public void PlaySpookySound() { }

	[BaseEntity.Menu] // RVA: 0x8D4F0 Offset: 0x8C8F0 VA: 0x18008D4F0
	[BaseEntity.Menu.Description] // RVA: 0x8D4F0 Offset: 0x8C8F0 VA: 0x18008D4F0
	[BaseEntity.Menu.Icon] // RVA: 0x8D4F0 Offset: 0x8C8F0 VA: 0x18008D4F0
	[BaseEntity.Menu.ShowIf] // RVA: 0x8D4F0 Offset: 0x8C8F0 VA: 0x18008D4F0
	// RVA: 0xA81010 Offset: 0xA7F610 VA: 0x180A81010
	public void Menu_SoundOn(BasePlayer player) { }

	// RVA: 0x7A0080 Offset: 0x79E680 VA: 0x1807A0080
	public bool Menu_SoundOn_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x8D790 Offset: 0x8CB90 VA: 0x18008D790
	[BaseEntity.Menu.Description] // RVA: 0x8D790 Offset: 0x8CB90 VA: 0x18008D790
	[BaseEntity.Menu.Icon] // RVA: 0x8D790 Offset: 0x8CB90 VA: 0x18008D790
	[BaseEntity.Menu.ShowIf] // RVA: 0x8D790 Offset: 0x8CB90 VA: 0x18008D790
	// RVA: 0xA80FC0 Offset: 0xA7F5C0 VA: 0x180A80FC0
	public void Menu_SoundOff(BasePlayer player) { }

	// RVA: 0x7A0040 Offset: 0x79E640 VA: 0x1807A0040
	public bool Menu_SoundOff_ShowIf(BasePlayer player) { }

	// RVA: 0xA81530 Offset: 0xA7FB30 VA: 0x180A81530
	public void .ctor() { }

}

