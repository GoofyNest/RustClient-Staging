public abstract class WeatherEffect : BaseMonoBehaviour, IClientComponent // TypeDefIndex: 10069
{	// Fields
	public ParticleSystem[] emitOnStart; // 0x18
	public ParticleSystem[] emitOnStop; // 0x20
	public ParticleSystem[] emitOnLoop; // 0x28
	private float currentIntensity; // 0x30
	private float[] maxEmissionRates; // 0x38
	private Action invokeUpdate; // 0x40

	// Methods

	// RVA: 0x8F29F0 Offset: 0x8F0FF0 VA: 0x1808F29F0
	protected void Awake() { }

	// RVA: 0x8F2F80 Offset: 0x8F1580 VA: 0x1808F2F80
	protected void OnEnable() { }

	// RVA: 0x8F2F70 Offset: 0x8F1570 VA: 0x1808F2F70
	protected void OnDisable() { }

	// RVA: 0x8F2B70 Offset: 0x8F1170 VA: 0x1808F2B70
	protected void InvokeUpdate() { }

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract float GetCurrentIntensity();

	// RVA: -1 Offset: -1 Slot: 7
	protected abstract float GetUpdateInterval(float intensity);

	// RVA: -1 Offset: -1 Slot: 8
	protected abstract void UpdatePosition(float intensity);

	// RVA: 0x8F2F90 Offset: 0x8F1590 VA: 0x1808F2F90
	protected void .ctor() { }

}

