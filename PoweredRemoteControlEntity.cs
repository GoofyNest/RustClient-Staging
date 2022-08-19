public class PoweredRemoteControlEntity : IOEntity, IRemoteControllable // TypeDefIndex: 8429
{	// Fields
	private Option __menuOption_Menu_SetID; // 0x288
	public string rcIdentifier; // 0x2E0
	public Transform viewEyes; // 0x2E8
	public GameObjectRef IDPanelPrefab; // 0x2F0
	public bool isStatic; // 0x2F8
	public bool appendEntityIDToIdentifier; // 0x2F9

	// Properties
	public override bool HasMenuOptions { get; }
	public virtual bool RequiresMouse { get; }

	// Methods

	// RVA: 0x9A0010 Offset: 0x99E610 VA: 0x1809A0010 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x9A0790 Offset: 0x99ED90 VA: 0x1809A0790 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x9A0580 Offset: 0x99EB80 VA: 0x1809A0580 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x9A0390 Offset: 0x99E990 VA: 0x1809A0390
	public bool IsStatic() { }

	// RVA: 0x93E5E0 Offset: 0x93CBE0 VA: 0x18093E5E0 Slot: 159
	public Transform GetEyes() { }

	// RVA: 0x99FFA0 Offset: 0x99E5A0 VA: 0x18099FFA0 Slot: 168
	public virtual bool CanControl() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 169
	public virtual bool get_RequiresMouse() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 170
	public virtual void UserInput(InputState inputState, BasePlayer player) { }

	// RVA: 0x4B3FF0 Offset: 0x4B25F0 VA: 0x1804B3FF0 Slot: 160
	public BaseEntity GetEnt() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 161
	public bool Occupied() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 171
	public virtual void InitializeControl(BasePlayer controller) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 172
	public virtual void StopControl() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 173
	public virtual void RCSetup() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 174
	public virtual void RCShutdown() { }

	// RVA: 0x9A03A0 Offset: 0x99E9A0 VA: 0x1809A03A0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x9A0670 Offset: 0x99EC70 VA: 0x1809A0670 Slot: 162
	public void UpdateIdentifier(string newID, bool clientSend = False) { }

	// RVA: 0x9A0000 Offset: 0x99E600 VA: 0x1809A0000 Slot: 163
	public string GetIdentifier() { }

	// RVA: 0x9A0360 Offset: 0x99E960 VA: 0x1809A0360 Slot: 28
	public override void InitShared() { }

	// RVA: 0x99FFD0 Offset: 0x99E5D0 VA: 0x18099FFD0 Slot: 31
	public override void DestroyShared() { }

	[BaseEntity.Menu] // RVA: 0x7D250 Offset: 0x7C650 VA: 0x18007D250
	[BaseEntity.Menu.Description] // RVA: 0x7D250 Offset: 0x7C650 VA: 0x18007D250
	[BaseEntity.Menu.Icon] // RVA: 0x7D250 Offset: 0x7C650 VA: 0x18007D250
	[BaseEntity.Menu.ShowIf] // RVA: 0x7D250 Offset: 0x7C650 VA: 0x18007D250
	// RVA: 0x9A04A0 Offset: 0x99EAA0 VA: 0x1809A04A0
	public void Menu_SetID(BasePlayer player) { }

	// RVA: 0x9A0450 Offset: 0x99EA50 VA: 0x1809A0450
	public bool Menu_SetID_ShowIf(BasePlayer player) { }

	// RVA: 0x9A0720 Offset: 0x99ED20 VA: 0x1809A0720
	public void .ctor() { }

}

