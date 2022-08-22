public class RemoteControlEntity : BaseCombatEntity, IRemoteControllable // TypeDefIndex: 8435
{	// Fields
	private Option __menuOption_Menu_SetID; // 0x240
	[HeaderAttribute] // RVA: 0x7FD60 Offset: 0x7F160 VA: 0x18007FD60
	public string rcIdentifier; // 0x298
	public Transform viewEyes; // 0x2A0
	public GameObjectRef IDPanelPrefab; // 0x2A8

	// Properties
	public override bool HasMenuOptions { get; }
	public virtual bool RequiresMouse { get; }

	// Methods

	// RVA: 0x94C660 Offset: 0x94AC60 VA: 0x18094C660 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x94CE60 Offset: 0x94B460 VA: 0x18094CE60 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x94CC30 Offset: 0x94B230 VA: 0x18094CC30 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x94C640 Offset: 0x94AC40 VA: 0x18094C640 Slot: 145
	public Transform GetEyes() { }

	// RVA: 0x4B3FF0 Offset: 0x4B25F0 VA: 0x1804B3FF0 Slot: 146
	public BaseEntity GetEnt() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 147
	public bool Occupied() { }

	// RVA: 0x94C650 Offset: 0x94AC50 VA: 0x18094C650 Slot: 149
	public string GetIdentifier() { }

	// RVA: 0x94CD20 Offset: 0x94B320 VA: 0x18094CD20 Slot: 148
	public void UpdateIdentifier(string newID, bool clientSend = False) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 154
	public virtual void RCSetup() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 155
	public virtual void RCShutdown() { }

	// RVA: 0x94C9E0 Offset: 0x94AFE0 VA: 0x18094C9E0 Slot: 28
	public override void InitShared() { }

	// RVA: 0x94C610 Offset: 0x94AC10 VA: 0x18094C610 Slot: 31
	public override void DestroyShared() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 156
	public virtual bool CanControl() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 157
	public virtual bool get_RequiresMouse() { }

	// RVA: 0x94CA10 Offset: 0x94B010 VA: 0x18094CA10 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	[BaseEntity.Menu] // RVA: 0x7D320 Offset: 0x7C720 VA: 0x18007D320
	[BaseEntity.Menu.Description] // RVA: 0x7D320 Offset: 0x7C720 VA: 0x18007D320
	[BaseEntity.Menu.Icon] // RVA: 0x7D320 Offset: 0x7C720 VA: 0x18007D320
	[BaseEntity.Menu.ShowIf] // RVA: 0x7D320 Offset: 0x7C720 VA: 0x18007D320
	// RVA: 0x94CB50 Offset: 0x94B150 VA: 0x18094CB50
	public void Menu_SetID(BasePlayer player) { }

	// RVA: 0x94CAB0 Offset: 0x94B0B0 VA: 0x18094CAB0
	public bool Menu_SetID_ShowIf(BasePlayer player) { }

	// RVA: 0x94CE10 Offset: 0x94B410 VA: 0x18094CE10
	public void .ctor() { }

}

