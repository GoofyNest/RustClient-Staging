public abstract class WeatherEffect : BaseMonoBehaviour, IClientComponent // TypeDefIndex: 10069
{	// Fields
	public ParticleSystem[] emitOnStart; // 0x18
	public ParticleSystem[] emitOnStop; // 0x20
	public ParticleSystem[] emitOnLoop; // 0x28
	private float currentIntensity; // 0x30
	private float[] maxEmissionRates; // 0x38
	private Action invokeUpdate; // 0x40

	// Methods

	// RVA: 0x8F28E0 Offset: 0x8F0EE0 VA: 0x1808F28E0
	protected void Awake() { }

	// RVA: 0x8F2E70 Offset: 0x8F1470 VA: 0x1808F2E70
	protected void OnEnable() { }

	// RVA: 0x8F2E60 Offset: 0x8F1460 VA: 0x1808F2E60
	protected void OnDisable() { }

	// RVA: 0x8F2A60 Offset: 0x8F1060 VA: 0x1808F2A60
	protected void InvokeUpdate() { }

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract float GetCurrentIntensity();

	// RVA: -1 Offset: -1 Slot: 7
	protected abstract float GetUpdateInterval(float intensity);

	// RVA: -1 Offset: -1 Slot: 8
	protected abstract void UpdatePosition(float intensity);

	// RVA: 0x8F2E80 Offset: 0x8F1480 VA: 0x1808F2E80
	protected void .ctor() { }

}

