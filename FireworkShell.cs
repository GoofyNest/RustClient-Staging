public class FireworkShell : BaseMonoBehaviour, IClientComponent // TypeDefIndex: 8272
{	// Fields
	public float fuseLengthMin; // 0x18
	public float fuseLengthMax; // 0x1C
	public float speedMin; // 0x20
	public float speedMax; // 0x24
	public ParticleSystem explodePFX; // 0x28
	public SoundPlayer explodeSound; // 0x30
	public float inaccuracyDegrees; // 0x38
	public LightEx explosionLight; // 0x40
	public float lifetime; // 0x48
	private float speed; // 0x4C
	protected bool exploded; // 0x50

	// Methods

	// RVA: 0x78A680 Offset: 0x788C80 VA: 0x18078A680 Slot: 6
	public virtual void Init(MortarFirework firework) { }

	// RVA: 0x78A9A0 Offset: 0x788FA0 VA: 0x18078A9A0
	public void ToggleExplosionLight(bool wantsOn) { }

	// RVA: 0x78AA40 Offset: 0x789040 VA: 0x18078AA40 Slot: 7
	public virtual void Update() { }

	// RVA: 0x78A360 Offset: 0x788960 VA: 0x18078A360 Slot: 8
	public virtual void Cleanup() { }

	// RVA: 0x78A830 Offset: 0x788E30 VA: 0x18078A830
	public float SoundDelayTime() { }

	// RVA: 0x78A810 Offset: 0x788E10 VA: 0x18078A810
	public void PlaySound() { }

	// RVA: 0x78A3F0 Offset: 0x7889F0 VA: 0x18078A3F0 Slot: 9
	public virtual void Explode() { }

	// RVA: 0x78A340 Offset: 0x788940 VA: 0x18078A340 Slot: 10
	public virtual float CalculateFuseLength() { }

	// RVA: 0x78ACE0 Offset: 0x7892E0 VA: 0x18078ACE0
	public void .ctor() { }

}

