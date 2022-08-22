public abstract class WeatherEffect : BaseMonoBehaviour, IClientComponent // TypeDefIndex: 10069
{	// Fields
	public ParticleSystem[] emitOnStart; // 0x18
	public ParticleSystem[] emitOnStop; // 0x20
	public ParticleSystem[] emitOnLoop; // 0x28
	private float currentIntensity; // 0x30
	private float[] maxEmissionRates; // 0x38
	private Action invokeUpdate; // 0x40

	// Methods

	// RVA: 0x8F2F00 Offset: 0x8F1500 VA: 0x1808F2F00
	protected void Awake() { }

	// RVA: 0x8F3490 Offset: 0x8F1A90 VA: 0x1808F3490
	protected void OnEnable() { }

	// RVA: 0x8F3480 Offset: 0x8F1A80 VA: 0x1808F3480
	protected void OnDisable() { }

	// RVA: 0x8F3080 Offset: 0x8F1680 VA: 0x1808F3080
	protected void InvokeUpdate() { }

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract float GetCurrentIntensity();

	// RVA: -1 Offset: -1 Slot: 7
	protected abstract float GetUpdateInterval(float intensity);

	// RVA: -1 Offset: -1 Slot: 8
	protected abstract void UpdatePosition(float intensity);

	// RVA: 0x8F34A0 Offset: 0x8F1AA0 VA: 0x1808F34A0
	protected void .ctor() { }

}

