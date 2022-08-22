public class RustigeEgg : BaseCombatEntity // TypeDefIndex: 8440
{	// Fields
	private Option __menuOption_Menu_Close; // 0x240
	private Option __menuOption_Menu_Open; // 0x298
	private Option __menuOption_Menu_Spin; // 0x2F0
	private Option __menuOption_Menu_StopSpin; // 0x348
	public const BaseEntity.Flags Flag_Spin = 128;
	public Transform eggRotationTransform; // 0x3A0

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x49B460 Offset: 0x499A60 VA: 0x18049B460 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x49C2A0 Offset: 0x49A8A0 VA: 0x18049C2A0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x49BCF0 Offset: 0x49A2F0 VA: 0x18049BCF0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x49BB60 Offset: 0x49A160 VA: 0x18049BB60
	public bool IsSpinning() { }

	[BaseEntity.Menu] // RVA: 0x80BC0 Offset: 0x7FFC0 VA: 0x180080BC0
	[BaseEntity.Menu.Description] // RVA: 0x80BC0 Offset: 0x7FFC0 VA: 0x180080BC0
	[BaseEntity.Menu.Icon] // RVA: 0x80BC0 Offset: 0x7FFC0 VA: 0x180080BC0
	[BaseEntity.Menu.ShowIf] // RVA: 0x80BC0 Offset: 0x7FFC0 VA: 0x180080BC0
	// RVA: 0x49BC50 Offset: 0x49A250 VA: 0x18049BC50
	public void Menu_Spin(BasePlayer player) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40
	public bool Menu_Spin_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x80DE0 Offset: 0x801E0 VA: 0x180080DE0
	[BaseEntity.Menu.Description] // RVA: 0x80DE0 Offset: 0x801E0 VA: 0x180080DE0
	[BaseEntity.Menu.Icon] // RVA: 0x80DE0 Offset: 0x801E0 VA: 0x180080DE0
	[BaseEntity.Menu.ShowIf] // RVA: 0x80DE0 Offset: 0x801E0 VA: 0x180080DE0
	// RVA: 0x49BCA0 Offset: 0x49A2A0 VA: 0x18049BCA0
	public void Menu_StopSpin(BasePlayer player) { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40
	public bool Menu_StopSpin_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x81230 Offset: 0x80630 VA: 0x180081230
	[BaseEntity.Menu.Description] // RVA: 0x81230 Offset: 0x80630 VA: 0x180081230
	[BaseEntity.Menu.Icon] // RVA: 0x81230 Offset: 0x80630 VA: 0x180081230
	[BaseEntity.Menu.ShowIf] // RVA: 0x81230 Offset: 0x80630 VA: 0x180081230
	// RVA: 0x49BBF0 Offset: 0x49A1F0 VA: 0x18049BBF0
	public void Menu_Open(BasePlayer player) { }

	// RVA: 0x49BBD0 Offset: 0x49A1D0 VA: 0x18049BBD0
	public bool Menu_Open_ShowIf(BasePlayer player) { }

	[BaseEntity.Menu] // RVA: 0x81510 Offset: 0x80910 VA: 0x180081510
	[BaseEntity.Menu.Description] // RVA: 0x81510 Offset: 0x80910 VA: 0x180081510
	[BaseEntity.Menu.Icon] // RVA: 0x81510 Offset: 0x80910 VA: 0x180081510
	[BaseEntity.Menu.ShowIf] // RVA: 0x81510 Offset: 0x80910 VA: 0x180081510
	// RVA: 0x49BB80 Offset: 0x49A180 VA: 0x18049BB80
	public void Menu_Close(BasePlayer player) { }

	// RVA: 0x49BB70 Offset: 0x49A170 VA: 0x18049BB70
	public bool Menu_Close_ShowIf(BasePlayer player) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x49B2D0 Offset: 0x4998D0 VA: 0x18049B2D0
	public void FaceEggPosition(BaseEntity.RPCMessage msg) { }

	// RVA: 0x49C290 Offset: 0x49A890 VA: 0x18049C290
	public void .ctor() { }

}

