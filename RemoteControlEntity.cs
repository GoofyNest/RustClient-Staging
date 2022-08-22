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

	// RVA: 0x94CB70 Offset: 0x94B170 VA: 0x18094CB70 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x94D370 Offset: 0x94B970 VA: 0x18094D370 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x94D140 Offset: 0x94B740 VA: 0x18094D140 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x94CB50 Offset: 0x94B150 VA: 0x18094CB50 Slot: 145
	public Transform GetEyes() { }

	// RVA: 0x4B3F80 Offset: 0x4B2580 VA: 0x1804B3F80 Slot: 146
	public BaseEntity GetEnt() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 147
	public bool Occupied() { }

	// RVA: 0x94CB60 Offset: 0x94B160 VA: 0x18094CB60 Slot: 149
	public string GetIdentifier() { }

	// RVA: 0x94D230 Offset: 0x94B830 VA: 0x18094D230 Slot: 148
	public void UpdateIdentifier(string newID, bool clientSend = False) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 154
	public virtual void RCSetup() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 155
	public virtual void RCShutdown() { }

	// RVA: 0x94CEF0 Offset: 0x94B4F0 VA: 0x18094CEF0 Slot: 28
	public override void InitShared() { }

	// RVA: 0x94CB20 Offset: 0x94B120 VA: 0x18094CB20 Slot: 31
	public override void DestroyShared() { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 156
	public virtual bool CanControl() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 157
	public virtual bool get_RequiresMouse() { }

	// RVA: 0x94CF20 Offset: 0x94B520 VA: 0x18094CF20 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	[BaseEntity.Menu] // RVA: 0x7D320 Offset: 0x7C720 VA: 0x18007D320
	[BaseEntity.Menu.Description] // RVA: 0x7D320 Offset: 0x7C720 VA: 0x18007D320
	[BaseEntity.Menu.Icon] // RVA: 0x7D320 Offset: 0x7C720 VA: 0x18007D320
	[BaseEntity.Menu.ShowIf] // RVA: 0x7D320 Offset: 0x7C720 VA: 0x18007D320
	// RVA: 0x94D060 Offset: 0x94B660 VA: 0x18094D060
	public void Menu_SetID(BasePlayer player) { }

	// RVA: 0x94CFC0 Offset: 0x94B5C0 VA: 0x18094CFC0
	public bool Menu_SetID_ShowIf(BasePlayer player) { }

	// RVA: 0x94D320 Offset: 0x94B920 VA: 0x18094D320
	public void .ctor() { }

}

