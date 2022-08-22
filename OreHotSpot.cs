public class OreHotSpot : BaseCombatEntity, ILOD // TypeDefIndex: 8811
{	// Fields
	public float visualDistance; // 0x240
	public GameObjectRef visualEffect; // 0x248
	public GameObjectRef finishEffect; // 0x250
	public GameObjectRef damageEffect; // 0x258
	public OreResourceEntity owner; // 0x260
	private GameObject visualInstance; // 0x268
	private LODCell cell; // 0x270

	// Methods

	// RVA: 0x9E7720 Offset: 0x9E5D20 VA: 0x1809E7720 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x9E79B0 Offset: 0x9E5FB0 VA: 0x1809E79B0 Slot: 19
	protected override void DoClientDestroy() { }

	// RVA: 0x9E7A40 Offset: 0x9E6040 VA: 0x1809E7A40 Slot: 146
	public void RefreshLOD() { }

	// RVA: 0x9E7570 Offset: 0x9E5B70 VA: 0x1809E7570 Slot: 145
	public void ChangeLOD() { }

	// RVA: 0x9E7AC0 Offset: 0x9E60C0 VA: 0x1809E7AC0
	private void SpawnVisual() { }

	// RVA: 0x9E77B0 Offset: 0x9E5DB0 VA: 0x1809E77B0
	private void DestroyVisual() { }

	// RVA: 0x9E7C10 Offset: 0x9E6210 VA: 0x1809E7C10
	public void .ctor() { }

}

