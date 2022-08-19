public class SprayCanViewmodel : MonoBehaviour, IAnimationEventReceiver // TypeDefIndex: 8882
{	// Fields
	public ParticleSystem Particles; // 0x18
	public SoundDefinition sprayLoopDef; // 0x20
	private Sound sprayLoop; // 0x28

	// Methods

	// RVA: 0xA83A60 Offset: 0xA82060 VA: 0x180A83A60
	public void SetSprayColour(Color c) { }

	// RVA: 0xA83B40 Offset: 0xA82140 VA: 0x180A83B40
	public void ToggleSpray(bool state) { }

	// RVA: 0xA839C0 Offset: 0xA81FC0 VA: 0x180A839C0
	private void OnDisable() { }

	// RVA: 0xA83930 Offset: 0xA81F30 VA: 0x180A83930 Slot: 4
	public void OnAnimationEvent(string eventName) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

