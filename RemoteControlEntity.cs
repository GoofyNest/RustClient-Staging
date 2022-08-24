public class RemoteControlEntity : BaseCombatEntity, IRemoteControllable // TypeDefIndex: 8435
{	private Option __menuOption_Menu_SetID; // 0x240
	[HeaderAttribute] // RVA: 0x7FE50 Offset: 0x7F250 VA: 0x18007FE50
	public string rcIdentifier; // 0x298
	public Transform viewEyes; // 0x2A0
	public GameObjectRef IDPanelPrefab; // 0x2A8

	public override bool HasMenuOptions { get; }
	public virtual bool RequiresMouse { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public Transform GetEyes() { }

	public BaseEntity GetEnt() { }

	public bool Occupied() { }

	public string GetIdentifier() { }

	public void UpdateIdentifier(string newID, bool clientSend = False) { }

	public virtual void RCSetup() { }

	public virtual void RCShutdown() { }

	public override void InitShared() { }

	public override void DestroyShared() { }

	public virtual bool CanControl() { }

	public virtual bool get_RequiresMouse() { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	[BaseEntity.Menu] // RVA: 0x7D3B0 Offset: 0x7C7B0 VA: 0x18007D3B0
	[BaseEntity.Menu.Description] // RVA: 0x7D3B0 Offset: 0x7C7B0 VA: 0x18007D3B0
	[BaseEntity.Menu.Icon] // RVA: 0x7D3B0 Offset: 0x7C7B0 VA: 0x18007D3B0
	[BaseEntity.Menu.ShowIf] // RVA: 0x7D3B0 Offset: 0x7C7B0 VA: 0x18007D3B0
	public void Menu_SetID(BasePlayer player) { }

	public bool Menu_SetID_ShowIf(BasePlayer player) { }

	public void .ctor() { }

}

