public abstract class WeatherEffectSting : BaseMonoBehaviour, IClientComponent // TypeDefIndex: 10075
{	// Fields
	public float frequency; // 0x18
	public float variance; // 0x1C
	public GameObjectRef[] effects; // 0x20
	private SynchronizedClock stingClock; // 0x28

	// Methods

	// RVA: 0x8F2730 Offset: 0x8F0D30 VA: 0x1808F2730
	private void PlaySting(uint seed) { }

	// RVA: 0x8F2540 Offset: 0x8F0B40 VA: 0x1808F2540
	protected void Awake() { }

	// RVA: 0x8F25F0 Offset: 0x8F0BF0 VA: 0x1808F25F0
	protected void LateUpdate() { }

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract float GetCurrentIntensity();

	// RVA: 0x8F2970 Offset: 0x8F0F70 VA: 0x1808F2970
	protected void .ctor() { }

}

