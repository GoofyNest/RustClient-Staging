public class SprayCanViewmodel : MonoBehaviour, IAnimationEventReceiver // TypeDefIndex: 8882
{	// Fields
	public ParticleSystem Particles; // 0x18
	public SoundDefinition sprayLoopDef; // 0x20
	private Sound sprayLoop; // 0x28

	// Methods

	// RVA: 0xA83D20 Offset: 0xA82320 VA: 0x180A83D20
	public void SetSprayColour(Color c) { }

	// RVA: 0xA83E00 Offset: 0xA82400 VA: 0x180A83E00
	public void ToggleSpray(bool state) { }

	// RVA: 0xA83C80 Offset: 0xA82280 VA: 0x180A83C80
	private void OnDisable() { }

	// RVA: 0xA83BF0 Offset: 0xA821F0 VA: 0x180A83BF0 Slot: 4
	public void OnAnimationEvent(string eventName) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

