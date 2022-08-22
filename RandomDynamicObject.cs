public class RandomDynamicObject : MonoBehaviour, IClientComponent, ILOD // TypeDefIndex: 10354
{	// Fields
	public uint Seed; // 0x18
	public float Distance; // 0x1C
	public float Probability; // 0x20
	public GameObject[] Candidates; // 0x28
	private GameObject instance; // 0x30
	private LODCell cell; // 0x38

	// Methods

	// RVA: 0x6A6F40 Offset: 0x6A5540 VA: 0x1806A6F40
	protected void OnEnable() { }

	// RVA: 0x6A6E90 Offset: 0x6A5490 VA: 0x1806A6E90
	protected void OnDisable() { }

	// RVA: 0x6A72D0 Offset: 0x6A58D0 VA: 0x1806A72D0 Slot: 5
	public void RefreshLOD() { }

	// RVA: 0x6A6E20 Offset: 0x6A5420 VA: 0x1806A6E20 Slot: 4
	public void ChangeLOD() { }

	// RVA: 0x6A7350 Offset: 0x6A5950 VA: 0x1806A7350
	public void .ctor() { }

}

