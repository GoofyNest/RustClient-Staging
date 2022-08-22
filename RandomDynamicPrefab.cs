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

	// RVA: 0x6A7630 Offset: 0x6A5C30 VA: 0x1806A7630
	protected void OnEnable() { }

	// RVA: 0x6A7580 Offset: 0x6A5B80 VA: 0x1806A7580
	protected void OnDisable() { }

	// RVA: 0x6A7870 Offset: 0x6A5E70 VA: 0x1806A7870 Slot: 5
	public void RefreshLOD() { }

	// RVA: 0x6A73E0 Offset: 0x6A59E0 VA: 0x1806A73E0 Slot: 4
	public void ChangeLOD() { }

	// RVA: 0x6A78F0 Offset: 0x6A5EF0 VA: 0x1806A78F0
	public void .ctor() { }

}

