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

	// RVA: 0x94C550 Offset: 0x94AB50 VA: 0x18094C550 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x94CD50 Offset: 0x94B350 VA: 0x18094CD50 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x94CB20 Offset: 0x94B120 VA: 0x18094CB20 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x94C530 Offset: 0x94AB30 VA: 0x18094C530 Slot: 145
	public Transform GetEyes() { }

	// RVA: 0x4B3FF0 Offset: 0x4B25F0 VA: 0x1804B3FF0 Slot: 146
	public BaseEntity GetEnt() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 147
	public bool Occupied() { }

	// RVA: 0x94C540 Offset: 0x94AB40 VA: 0x18094C540 Slot: 149
	public string GetIdentifier() { }

	// RVA: 0x94CC10 Offset: 0x94B210 VA: 0x18094CC10 Slot: 148
	public void UpdateIdentifier(string newID, bool clientSend = False) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 154
	public virtual void RCSetup() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 155
	public virtual void RCShutdown() { }

	// RVA: 0x94C8D0 Offset: 0x94AED0 VA: 0x18094C8D0 Slot: 28
	public override void InitShared() { }

	// RVA: 0x94C500 Offset: 0x94AB00 VA: 0x18094C500 Slot: 31
	public override void DestroyShared() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 156
	public virtual bool CanControl() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 157
	public virtual bool get_RequiresMouse() { }

	// RVA: 0x94C900 Offset: 0x94AF00 VA: 0x18094C900 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	[BaseEntity.Menu] // RVA: 0x7D320 Offset: 0x7C720 VA: 0x18007D320
	[BaseEntity.Menu.Description] // RVA: 0x7D320 Offset: 0x7C720 VA: 0x18007D320
	[BaseEntity.Menu.Icon] // RVA: 0x7D320 Offset: 0x7C720 VA: 0x18007D320
	[BaseEntity.Menu.ShowIf] // RVA: 0x7D320 Offset: 0x7C720 VA: 0x18007D320
	// RVA: 0x94CA40 Offset: 0x94B040 VA: 0x18094CA40
	public void Menu_SetID(BasePlayer player) { }

	// RVA: 0x94C9A0 Offset: 0x94AFA0 VA: 0x18094C9A0
	public bool Menu_SetID_ShowIf(BasePlayer player) { }

	// RVA: 0x94CD00 Offset: 0x94B300 VA: 0x18094CD00
	public void .ctor() { }

}

