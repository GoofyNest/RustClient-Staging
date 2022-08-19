public class RandomDynamicObject : MonoBehaviour, IClientComponent, ILOD // TypeDefIndex: 10354
{	// Fields
	public uint Seed; // 0x18
	public float Distance; // 0x1C
	public float Probability; // 0x20
	public GameObject[] Candidates; // 0x28
	private GameObject instance; // 0x30
	private LODCell cell; // 0x38

	// Methods

	// RVA: 0x6A6EA0 Offset: 0x6A54A0 VA: 0x1806A6EA0
	protected void OnEnable() { }

	// RVA: 0x6A6DF0 Offset: 0x6A53F0 VA: 0x1806A6DF0
	protected void OnDisable() { }

	// RVA: 0x6A7230 Offset: 0x6A5830 VA: 0x1806A7230 Slot: 5
	public void RefreshLOD() { }

	// RVA: 0x6A6D80 Offset: 0x6A5380 VA: 0x1806A6D80 Slot: 4
	public void ChangeLOD() { }

	// RVA: 0x6A72B0 Offset: 0x6A58B0 VA: 0x1806A72B0
	public void .ctor() { }

}

