public class SprayCanViewmodel : MonoBehaviour, IAnimationEventReceiver // TypeDefIndex: 8882
{	// Fields
	public ParticleSystem Particles; // 0x18
	public SoundDefinition sprayLoopDef; // 0x20
	private Sound sprayLoop; // 0x28

	// Methods

	// RVA: 0xA841F0 Offset: 0xA827F0 VA: 0x180A841F0
	public void SetSprayColour(Color c) { }

	// RVA: 0xA842D0 Offset: 0xA828D0 VA: 0x180A842D0
	public void ToggleSpray(bool state) { }

	// RVA: 0xA84150 Offset: 0xA82750 VA: 0x180A84150
	private void OnDisable() { }

	// RVA: 0xA840C0 Offset: 0xA826C0 VA: 0x180A840C0 Slot: 4
	public void OnAnimationEvent(string eventName) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

