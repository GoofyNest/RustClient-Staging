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

	// RVA: 0xA80CF0 Offset: 0xA7F2F0 VA: 0x180A80CF0 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0xA81810 Offset: 0xA7FE10 VA: 0x180A81810 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0xA81320 Offset: 0xA7F920 VA: 0x180A81320 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA81750 Offset: 0xA7FD50 VA: 0x180A81750
	public void PlaySpookySound() { }

	[BaseEntity.Menu] // RVA: 0x8D4F0 Offset: 0x8C8F0 VA: 0x18008D4F0
	[BaseEntity.Menu.Description] // RVA: 0x8D4F0 Offset: 0x8C8F0 VA: 0x18008D4F0
	[BaseEntity.Menu.Icon] // RVA: 0x8D4F0 Offset: 0x8C8F0 VA: 0x18008D4F0
	[BaseEntity.Menu.ShowIf] // RVA: 0x8D4F0 Offset: 0x8C8F0 VA: 0x18008D4F0
	// RVA: 0xA812D0 Offset: 0xA7F8D0 VA: 0x180A812D0
	public void Menu_SoundOn(BasePlayer player) { }

	// RVA: 0x7A0190 Offset: 0x79E790 VA: 0x1807A0190
	public bool Menu_SoundOn_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x8D790 Offset: 0x8CB90 VA: 0x18008D790
	[BaseEntity.Menu.Description] // RVA: 0x8D790 Offset: 0x8CB90 VA: 0x18008D790
	[BaseEntity.Menu.Icon] // RVA: 0x8D790 Offset: 0x8CB90 VA: 0x18008D790
	[BaseEntity.Menu.ShowIf] // RVA: 0x8D790 Offset: 0x8CB90 VA: 0x18008D790
	// RVA: 0xA81280 Offset: 0xA7F880 VA: 0x180A81280
	public void Menu_SoundOff(BasePlayer player) { }

	// RVA: 0x7A0150 Offset: 0x79E750 VA: 0x1807A0150
	public bool Menu_SoundOff_ShowIf(BasePlayer player) { }

	// RVA: 0xA817F0 Offset: 0xA7FDF0 VA: 0x180A817F0
	public void .ctor() { }

}

