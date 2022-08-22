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

	// RVA: 0x9E7C10 Offset: 0x9E6210 VA: 0x1809E7C10 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x9E7EA0 Offset: 0x9E64A0 VA: 0x1809E7EA0 Slot: 19
	protected override void DoClientDestroy() { }

	// RVA: 0x9E7F30 Offset: 0x9E6530 VA: 0x1809E7F30 Slot: 146
	public void RefreshLOD() { }

	// RVA: 0x9E7A60 Offset: 0x9E6060 VA: 0x1809E7A60 Slot: 145
	public void ChangeLOD() { }

	// RVA: 0x9E7FB0 Offset: 0x9E65B0 VA: 0x1809E7FB0
	private void SpawnVisual() { }

	// RVA: 0x9E7CA0 Offset: 0x9E62A0 VA: 0x1809E7CA0
	private void DestroyVisual() { }

	// RVA: 0x9E8100 Offset: 0x9E6700 VA: 0x1809E8100
	public void .ctor() { }

}

