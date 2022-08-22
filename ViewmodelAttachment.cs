public class ViewmodelAttachment : EntityComponent<BaseEntity>, IClientComponent, IViewModeChanged, IViewModelUpdated // TypeDefIndex: 11456
{	// Fields
	public GameObjectRef modelObject; // 0x20
	public string targetBone; // 0x28
	public bool hideViewModelIronSights; // 0x30
	public GameObject spawnedGameObject; // 0x38

	// Methods

	// RVA: 0x7F70D0 Offset: 0x7F56D0 VA: 0x1807F70D0
	public void OnEnable() { }

	// RVA: 0x7F6ED0 Offset: 0x7F54D0 VA: 0x1807F6ED0
	public void OnDisable() { }

	// RVA: 0x7F7180 Offset: 0x7F5780 VA: 0x1807F7180 Slot: 10
	public void OnViewModeChanged() { }

	// RVA: 0x7F7180 Offset: 0x7F5780 VA: 0x1807F7180 Slot: 11
	public void OnViewModelUpdated() { }

	// RVA: 0x7F6870 Offset: 0x7F4E70 VA: 0x1807F6870
	public void CreateAttachment() { }

	// RVA: 0x7F7190 Offset: 0x7F5790 VA: 0x1807F7190 Slot: 12
	public virtual void RootEntFlagsChanged(BaseEntity flagCarrier) { }

	// RVA: 0x7F6D70 Offset: 0x7F5370 VA: 0x1807F6D70
	private bool IsThisOurViewmodel(BaseViewModel viewmodel) { }

	// RVA: 0x7F7270 Offset: 0x7F5870 VA: 0x1807F7270
	public void .ctor() { }

}

