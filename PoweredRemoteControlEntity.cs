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

	// RVA: 0x9A0610 Offset: 0x99EC10 VA: 0x1809A0610 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x9A0D90 Offset: 0x99F390 VA: 0x1809A0D90 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x9A0B80 Offset: 0x99F180 VA: 0x1809A0B80 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x9A0990 Offset: 0x99EF90 VA: 0x1809A0990
	public bool IsStatic() { }

	// RVA: 0x93EC00 Offset: 0x93D200 VA: 0x18093EC00 Slot: 159
	public Transform GetEyes() { }

	// RVA: 0x9A05A0 Offset: 0x99EBA0 VA: 0x1809A05A0 Slot: 168
	public virtual bool CanControl() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 169
	public virtual bool get_RequiresMouse() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 170
	public virtual void UserInput(InputState inputState, BasePlayer player) { }

	// RVA: 0x4B3F80 Offset: 0x4B2580 VA: 0x1804B3F80 Slot: 160
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

	// RVA: 0x9A09A0 Offset: 0x99EFA0 VA: 0x1809A09A0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x9A0C70 Offset: 0x99F270 VA: 0x1809A0C70 Slot: 162
	public void UpdateIdentifier(string newID, bool clientSend = False) { }

	// RVA: 0x9A0600 Offset: 0x99EC00 VA: 0x1809A0600 Slot: 163
	public string GetIdentifier() { }

	// RVA: 0x9A0960 Offset: 0x99EF60 VA: 0x1809A0960 Slot: 28
	public override void InitShared() { }

	// RVA: 0x9A05D0 Offset: 0x99EBD0 VA: 0x1809A05D0 Slot: 31
	public override void DestroyShared() { }

	[BaseEntity.Menu] // RVA: 0x7D320 Offset: 0x7C720 VA: 0x18007D320
	[BaseEntity.Menu.Description] // RVA: 0x7D320 Offset: 0x7C720 VA: 0x18007D320
	[BaseEntity.Menu.Icon] // RVA: 0x7D320 Offset: 0x7C720 VA: 0x18007D320
	[BaseEntity.Menu.ShowIf] // RVA: 0x7D320 Offset: 0x7C720 VA: 0x18007D320
	// RVA: 0x9A0AA0 Offset: 0x99F0A0 VA: 0x1809A0AA0
	public void Menu_SetID(BasePlayer player) { }

	// RVA: 0x9A0A50 Offset: 0x99F050 VA: 0x1809A0A50
	public bool Menu_SetID_ShowIf(BasePlayer player) { }

	// RVA: 0x9A0D20 Offset: 0x99F320 VA: 0x1809A0D20
	public void .ctor() { }

}

