public abstract class WeatherEffectSting : BaseMonoBehaviour, IClientComponent // TypeDefIndex: 10075
{	// Fields
	public float frequency; // 0x18
	public float variance; // 0x1C
	public GameObjectRef[] effects; // 0x20
	private SynchronizedClock stingClock; // 0x28

	// Methods

	// RVA: 0x8F2620 Offset: 0x8F0C20 VA: 0x1808F2620
	private void PlaySting(uint seed) { }

	// RVA: 0x8F2430 Offset: 0x8F0A30 VA: 0x1808F2430
	protected void Awake() { }

	// RVA: 0x8F24E0 Offset: 0x8F0AE0 VA: 0x1808F24E0
	protected void LateUpdate() { }

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract float GetCurrentIntensity();

	// RVA: 0x8F2860 Offset: 0x8F0E60 VA: 0x1808F2860
	protected void .ctor() { }

}

