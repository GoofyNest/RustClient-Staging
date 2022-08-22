public abstract class WeatherEffectSting : BaseMonoBehaviour, IClientComponent // TypeDefIndex: 10075
{	// Fields
	public float frequency; // 0x18
	public float variance; // 0x1C
	public GameObjectRef[] effects; // 0x20
	private SynchronizedClock stingClock; // 0x28

	// Methods

	// RVA: 0x8F2C40 Offset: 0x8F1240 VA: 0x1808F2C40
	private void PlaySting(uint seed) { }

	// RVA: 0x8F2A50 Offset: 0x8F1050 VA: 0x1808F2A50
	protected void Awake() { }

	// RVA: 0x8F2B00 Offset: 0x8F1100 VA: 0x1808F2B00
	protected void LateUpdate() { }

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract float GetCurrentIntensity();

	// RVA: 0x8F2E80 Offset: 0x8F1480 VA: 0x1808F2E80
	protected void .ctor() { }

}

