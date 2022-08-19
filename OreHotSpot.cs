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

	// RVA: 0x9E7460 Offset: 0x9E5A60 VA: 0x1809E7460 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x9E76F0 Offset: 0x9E5CF0 VA: 0x1809E76F0 Slot: 19
	protected override void DoClientDestroy() { }

	// RVA: 0x9E7780 Offset: 0x9E5D80 VA: 0x1809E7780 Slot: 146
	public void RefreshLOD() { }

	// RVA: 0x9E72B0 Offset: 0x9E58B0 VA: 0x1809E72B0 Slot: 145
	public void ChangeLOD() { }

	// RVA: 0x9E7800 Offset: 0x9E5E00 VA: 0x1809E7800
	private void SpawnVisual() { }

	// RVA: 0x9E74F0 Offset: 0x9E5AF0 VA: 0x1809E74F0
	private void DestroyVisual() { }

	// RVA: 0x9E7950 Offset: 0x9E5F50 VA: 0x1809E7950
	public void .ctor() { }

}

