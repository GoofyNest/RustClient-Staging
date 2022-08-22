public class SoundFollowCollider : MonoBehaviour, IClientComponent // TypeDefIndex: 9031
{	// Fields
	public SoundDefinition soundDefinition; // 0x18
	public Sound sound; // 0x20
	public Bounds soundFollowBounds; // 0x28
	public bool startImmediately; // 0x40
	private bool soundPlaying; // 0x41

	// Methods

	// RVA: 0xA75E10 Offset: 0xA74410 VA: 0x180A75E10
	private void Awake() { }

	// RVA: 0xA75EC0 Offset: 0xA744C0 VA: 0x180A75EC0
	public void StartSound() { }

	// RVA: 0xA75ED0 Offset: 0xA744D0 VA: 0x180A75ED0
	public void StopSound() { }

	// RVA: 0xA75EE0 Offset: 0xA744E0 VA: 0x180A75EE0
	private void Update() { }

	// RVA: 0xA75E20 Offset: 0xA74420 VA: 0x180A75E20
	private void FadeOutSound() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

