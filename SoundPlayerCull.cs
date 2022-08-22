public class SoundPlayerCull : MonoBehaviour, IClientComponent, ILOD // TypeDefIndex: 9040
{	// Fields
	public SoundPlayer soundPlayer; // 0x18
	public float cullDistance; // 0x20
	private LODCell cell; // 0x28

	// Methods

	// RVA: 0xA7AEC0 Offset: 0xA794C0 VA: 0x180A7AEC0
	protected void OnEnable() { }

	// RVA: 0xA7AE10 Offset: 0xA79410 VA: 0x180A7AE10
	protected void OnDisable() { }

	// RVA: 0xA7AF40 Offset: 0xA79540 VA: 0x180A7AF40 Slot: 5
	public void RefreshLOD() { }

	// RVA: 0xA7ACC0 Offset: 0xA792C0 VA: 0x180A7ACC0 Slot: 4
	public void ChangeLOD() { }

	// RVA: 0xA7AFC0 Offset: 0xA795C0 VA: 0x180A7AFC0
	public void .ctor() { }

}

