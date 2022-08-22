public class RandomDynamicObject : MonoBehaviour, IClientComponent, ILOD // TypeDefIndex: 10354
{	// Fields
	public uint Seed; // 0x18
	public float Distance; // 0x1C
	public float Probability; // 0x20
	public GameObject[] Candidates; // 0x28
	private GameObject instance; // 0x30
	private LODCell cell; // 0x38

	// Methods

	// RVA: 0x6A6FB0 Offset: 0x6A55B0 VA: 0x1806A6FB0
	protected void OnEnable() { }

	// RVA: 0x6A6F00 Offset: 0x6A5500 VA: 0x1806A6F00
	protected void OnDisable() { }

	// RVA: 0x6A7340 Offset: 0x6A5940 VA: 0x1806A7340 Slot: 5
	public void RefreshLOD() { }

	// RVA: 0x6A6E90 Offset: 0x6A5490 VA: 0x1806A6E90 Slot: 4
	public void ChangeLOD() { }

	// RVA: 0x6A73C0 Offset: 0x6A59C0 VA: 0x1806A73C0
	public void .ctor() { }

}

