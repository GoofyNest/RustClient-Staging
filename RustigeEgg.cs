public class RustigeEgg : BaseCombatEntity // TypeDefIndex: 8440
{	private Option __menuOption_Menu_Close; // 0x240
	private Option __menuOption_Menu_Open; // 0x298
	private Option __menuOption_Menu_Spin; // 0x2F0
	private Option __menuOption_Menu_StopSpin; // 0x348
	public const BaseEntity.Flags Flag_Spin = 128;
	public Transform eggRotationTransform; // 0x3A0

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public bool IsSpinning() { }

	[BaseEntity.Menu] // RVA: 0x80CB0 Offset: 0x800B0 VA: 0x180080CB0
	[BaseEntity.Menu.Description] // RVA: 0x80CB0 Offset: 0x800B0 VA: 0x180080CB0
	[BaseEntity.Menu.Icon] // RVA: 0x80CB0 Offset: 0x800B0 VA: 0x180080CB0
	[BaseEntity.Menu.ShowIf] // RVA: 0x80CB0 Offset: 0x800B0 VA: 0x180080CB0
	public void Menu_Spin(BasePlayer player) { }

	public bool Menu_Spin_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x80EA0 Offset: 0x802A0 VA: 0x180080EA0
	[BaseEntity.Menu.Description] // RVA: 0x80EA0 Offset: 0x802A0 VA: 0x180080EA0
	[BaseEntity.Menu.Icon] // RVA: 0x80EA0 Offset: 0x802A0 VA: 0x180080EA0
	[BaseEntity.Menu.ShowIf] // RVA: 0x80EA0 Offset: 0x802A0 VA: 0x180080EA0
	public void Menu_StopSpin(BasePlayer player) { }

	public bool Menu_StopSpin_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x81250 Offset: 0x80650 VA: 0x180081250
	[BaseEntity.Menu.Description] // RVA: 0x81250 Offset: 0x80650 VA: 0x180081250
	[BaseEntity.Menu.Icon] // RVA: 0x81250 Offset: 0x80650 VA: 0x180081250
	[BaseEntity.Menu.ShowIf] // RVA: 0x81250 Offset: 0x80650 VA: 0x180081250
	public void Menu_Open(BasePlayer player) { }

	public bool Menu_Open_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x815C0 Offset: 0x809C0 VA: 0x1800815C0
	[BaseEntity.Menu.Description] // RVA: 0x815C0 Offset: 0x809C0 VA: 0x1800815C0
	[BaseEntity.Menu.Icon] // RVA: 0x815C0 Offset: 0x809C0 VA: 0x1800815C0
	[BaseEntity.Menu.ShowIf] // RVA: 0x815C0 Offset: 0x809C0 VA: 0x1800815C0
	public void Menu_Close(BasePlayer player) { }

	public bool Menu_Close_ShowIf(BasePlayer player) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F480 Offset: 0x6E880 VA: 0x18006F480
	public void FaceEggPosition(BaseEntity.RPCMessage msg) { }

	public void .ctor() { }

}

