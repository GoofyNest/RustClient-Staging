public class SoundFollowCollider : MonoBehaviour, IClientComponent // TypeDefIndex: 9031
{	// Fields
	public SoundDefinition soundDefinition; // 0x18
	public Sound sound; // 0x20
	public Bounds soundFollowBounds; // 0x28
	public bool startImmediately; // 0x40
	private bool soundPlaying; // 0x41

	// Methods

	// RVA: 0xA762E0 Offset: 0xA748E0 VA: 0x180A762E0
	private void Awake() { }

	// RVA: 0xA76390 Offset: 0xA74990 VA: 0x180A76390
	public void StartSound() { }

	// RVA: 0xA763A0 Offset: 0xA749A0 VA: 0x180A763A0
	public void StopSound() { }

	// RVA: 0xA763B0 Offset: 0xA749B0 VA: 0x180A763B0
	private void Update() { }

	// RVA: 0xA762F0 Offset: 0xA748F0 VA: 0x180A762F0
	private void FadeOutSound() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

