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

	// RVA: 0x78A730 Offset: 0x788D30 VA: 0x18078A730 Slot: 6
	public virtual void Init(MortarFirework firework) { }

	// RVA: 0x78AA50 Offset: 0x789050 VA: 0x18078AA50
	public void ToggleExplosionLight(bool wantsOn) { }

	// RVA: 0x78AAF0 Offset: 0x7890F0 VA: 0x18078AAF0 Slot: 7
	public virtual void Update() { }

	// RVA: 0x78A410 Offset: 0x788A10 VA: 0x18078A410 Slot: 8
	public virtual void Cleanup() { }

	// RVA: 0x78A8E0 Offset: 0x788EE0 VA: 0x18078A8E0
	public float SoundDelayTime() { }

	// RVA: 0x78A8C0 Offset: 0x788EC0 VA: 0x18078A8C0
	public void PlaySound() { }

	// RVA: 0x78A4A0 Offset: 0x788AA0 VA: 0x18078A4A0 Slot: 9
	public virtual void Explode() { }

	// RVA: 0x78A3F0 Offset: 0x7889F0 VA: 0x18078A3F0 Slot: 10
	public virtual float CalculateFuseLength() { }

	// RVA: 0x78AD90 Offset: 0x789390 VA: 0x18078AD90
	public void .ctor() { }

}

