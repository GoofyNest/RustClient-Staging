public class ViewmodelAttachment : EntityComponent<BaseEntity>, IClientComponent, IViewModeChanged, IViewModelUpdated // TypeDefIndex: 11456
{	// Fields
	public GameObjectRef modelObject; // 0x20
	public string targetBone; // 0x28
	public bool hideViewModelIronSights; // 0x30
	public GameObject spawnedGameObject; // 0x38

	// Methods

	// RVA: 0x7F6A30 Offset: 0x7F5030 VA: 0x1807F6A30
	public void OnEnable() { }

	// RVA: 0x7F6830 Offset: 0x7F4E30 VA: 0x1807F6830
	public void OnDisable() { }

	// RVA: 0x7F6AE0 Offset: 0x7F50E0 VA: 0x1807F6AE0 Slot: 10
	public void OnViewModeChanged() { }

	// RVA: 0x7F6AE0 Offset: 0x7F50E0 VA: 0x1807F6AE0 Slot: 11
	public void OnViewModelUpdated() { }

	// RVA: 0x7F61D0 Offset: 0x7F47D0 VA: 0x1807F61D0
	public void CreateAttachment() { }

	// RVA: 0x7F6AF0 Offset: 0x7F50F0 VA: 0x1807F6AF0 Slot: 12
	public virtual void RootEntFlagsChanged(BaseEntity flagCarrier) { }

	// RVA: 0x7F66D0 Offset: 0x7F4CD0 VA: 0x1807F66D0
	private bool IsThisOurViewmodel(BaseViewModel viewmodel) { }

	// RVA: 0x7F6BD0 Offset: 0x7F51D0 VA: 0x1807F6BD0
	public void .ctor() { }

}

