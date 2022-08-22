public class ViewmodelAttachment : EntityComponent<BaseEntity>, IClientComponent, IViewModeChanged, IViewModelUpdated // TypeDefIndex: 11456
{	// Fields
	public GameObjectRef modelObject; // 0x20
	public string targetBone; // 0x28
	public bool hideViewModelIronSights; // 0x30
	public GameObject spawnedGameObject; // 0x38

	// Methods

	// RVA: 0x7F6B40 Offset: 0x7F5140 VA: 0x1807F6B40
	public void OnEnable() { }

	// RVA: 0x7F6940 Offset: 0x7F4F40 VA: 0x1807F6940
	public void OnDisable() { }

	// RVA: 0x7F6BF0 Offset: 0x7F51F0 VA: 0x1807F6BF0 Slot: 10
	public void OnViewModeChanged() { }

	// RVA: 0x7F6BF0 Offset: 0x7F51F0 VA: 0x1807F6BF0 Slot: 11
	public void OnViewModelUpdated() { }

	// RVA: 0x7F62E0 Offset: 0x7F48E0 VA: 0x1807F62E0
	public void CreateAttachment() { }

	// RVA: 0x7F6C00 Offset: 0x7F5200 VA: 0x1807F6C00 Slot: 12
	public virtual void RootEntFlagsChanged(BaseEntity flagCarrier) { }

	// RVA: 0x7F67E0 Offset: 0x7F4DE0 VA: 0x1807F67E0
	private bool IsThisOurViewmodel(BaseViewModel viewmodel) { }

	// RVA: 0x7F6CE0 Offset: 0x7F52E0 VA: 0x1807F6CE0
	public void .ctor() { }

}

