public class SoundFollowCollider : MonoBehaviour, IClientComponent // TypeDefIndex: 9031
{	// Fields
	public SoundDefinition soundDefinition; // 0x18
	public Sound sound; // 0x20
	public Bounds soundFollowBounds; // 0x28
	public bool startImmediately; // 0x40
	private bool soundPlaying; // 0x41

	// Methods

	// RVA: 0xA75B50 Offset: 0xA74150 VA: 0x180A75B50
	private void Awake() { }

	// RVA: 0xA75C00 Offset: 0xA74200 VA: 0x180A75C00
	public void StartSound() { }

	// RVA: 0xA75C10 Offset: 0xA74210 VA: 0x180A75C10
	public void StopSound() { }

	// RVA: 0xA75C20 Offset: 0xA74220 VA: 0x180A75C20
	private void Update() { }

	// RVA: 0xA75B60 Offset: 0xA74160 VA: 0x180A75B60
	private void FadeOutSound() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

