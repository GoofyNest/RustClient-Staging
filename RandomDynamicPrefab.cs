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

	// RVA: 0x6A75C0 Offset: 0x6A5BC0 VA: 0x1806A75C0
	protected void OnEnable() { }

	// RVA: 0x6A7510 Offset: 0x6A5B10 VA: 0x1806A7510
	protected void OnDisable() { }

	// RVA: 0x6A7800 Offset: 0x6A5E00 VA: 0x1806A7800 Slot: 5
	public void RefreshLOD() { }

	// RVA: 0x6A7370 Offset: 0x6A5970 VA: 0x1806A7370 Slot: 4
	public void ChangeLOD() { }

	// RVA: 0x6A7880 Offset: 0x6A5E80 VA: 0x1806A7880
	public void .ctor() { }

}

