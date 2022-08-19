public class SoundPlayerCull : MonoBehaviour, IClientComponent, ILOD // TypeDefIndex: 9040
{	// Fields
	public SoundPlayer soundPlayer; // 0x18
	public float cullDistance; // 0x20
	private LODCell cell; // 0x28

	// Methods

	// RVA: 0xA7AC00 Offset: 0xA79200 VA: 0x180A7AC00
	protected void OnEnable() { }

	// RVA: 0xA7AB50 Offset: 0xA79150 VA: 0x180A7AB50
	protected void OnDisable() { }

	// RVA: 0xA7AC80 Offset: 0xA79280 VA: 0x180A7AC80 Slot: 5
	public void RefreshLOD() { }

	// RVA: 0xA7AA00 Offset: 0xA79000 VA: 0x180A7AA00 Slot: 4
	public void ChangeLOD() { }

	// RVA: 0xA7AD00 Offset: 0xA79300 VA: 0x180A7AD00
	public void .ctor() { }

}

