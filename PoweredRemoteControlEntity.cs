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

	// RVA: 0x9A0120 Offset: 0x99E720 VA: 0x1809A0120 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x9A08A0 Offset: 0x99EEA0 VA: 0x1809A08A0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x9A0690 Offset: 0x99EC90 VA: 0x1809A0690 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x9A04A0 Offset: 0x99EAA0 VA: 0x1809A04A0
	public bool IsStatic() { }

	// RVA: 0x93E6F0 Offset: 0x93CCF0 VA: 0x18093E6F0 Slot: 159
	public Transform GetEyes() { }

	// RVA: 0x9A00B0 Offset: 0x99E6B0 VA: 0x1809A00B0 Slot: 168
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

	// RVA: 0x9A04B0 Offset: 0x99EAB0 VA: 0x1809A04B0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x9A0780 Offset: 0x99ED80 VA: 0x1809A0780 Slot: 162
	public void UpdateIdentifier(string newID, bool clientSend = False) { }

	// RVA: 0x9A0110 Offset: 0x99E710 VA: 0x1809A0110 Slot: 163
	public string GetIdentifier() { }

	// RVA: 0x9A0470 Offset: 0x99EA70 VA: 0x1809A0470 Slot: 28
	public override void InitShared() { }

	// RVA: 0x9A00E0 Offset: 0x99E6E0 VA: 0x1809A00E0 Slot: 31
	public override void DestroyShared() { }

	[BaseEntity.Menu] // RVA: 0x7D320 Offset: 0x7C720 VA: 0x18007D320
	[BaseEntity.Menu.Description] // RVA: 0x7D320 Offset: 0x7C720 VA: 0x18007D320
	[BaseEntity.Menu.Icon] // RVA: 0x7D320 Offset: 0x7C720 VA: 0x18007D320
	[BaseEntity.Menu.ShowIf] // RVA: 0x7D320 Offset: 0x7C720 VA: 0x18007D320
	// RVA: 0x9A05B0 Offset: 0x99EBB0 VA: 0x1809A05B0
	public void Menu_SetID(BasePlayer player) { }

	// RVA: 0x9A0560 Offset: 0x99EB60 VA: 0x1809A0560
	public bool Menu_SetID_ShowIf(BasePlayer player) { }

	// RVA: 0x9A0830 Offset: 0x99EE30 VA: 0x1809A0830
	public void .ctor() { }

}

