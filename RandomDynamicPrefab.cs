public class RandomDynamicPrefab : MonoBehaviour, IClientComponent, ILOD // TypeDefIndex: 10355
{	// Fields
	public uint Seed; // 0x18
	public float Distance; // 0x1C
	public float Probability; // 0x20
	public string ResourceFolder; // 0x28
	private Prefab prefab; // 0x30
	private GameObject instance; // 0x38
	private LODCell cell; // 0x40

	// Methods

	// RVA: 0x6A7520 Offset: 0x6A5B20 VA: 0x1806A7520
	protected void OnEnable() { }

	// RVA: 0x6A7470 Offset: 0x6A5A70 VA: 0x1806A7470
	protected void OnDisable() { }

	// RVA: 0x6A7760 Offset: 0x6A5D60 VA: 0x1806A7760 Slot: 5
	public void RefreshLOD() { }

	// RVA: 0x6A72D0 Offset: 0x6A58D0 VA: 0x1806A72D0 Slot: 4
	public void ChangeLOD() { }

	// RVA: 0x6A77E0 Offset: 0x6A5DE0 VA: 0x1806A77E0
	public void .ctor() { }

}

