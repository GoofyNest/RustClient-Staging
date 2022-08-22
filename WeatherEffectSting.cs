public abstract class WeatherEffectSting : BaseMonoBehaviour, IClientComponent // TypeDefIndex: 10075
{	public float frequency; // 0x18
	public float variance; // 0x1C
	public GameObjectRef[] effects; // 0x20
	private SynchronizedClock stingClock; // 0x28


	private void PlaySting(uint seed) { }

	protected void Awake() { }

	protected void LateUpdate() { }

	protected abstract float GetCurrentIntensity();

	protected void .ctor() { }

}

