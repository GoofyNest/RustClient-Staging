public class SedanWheelSmoke : MonoBehaviour // TypeDefIndex: 8297
{	// Fields
	public ParticleSystem[] tireSmoke; // 0x18
	public ParticleSystem[] tireWaterSplash; // 0x20
	public ParticleSystem[] tireWaterSplash_Extra; // 0x28
	public bool[] wheelTouching; // 0x30
	private ParticleSystem[] activeTireEffect; // 0x38
	private Vector3 vecLastPosition; // 0x40
	private float forwardSpeed; // 0x4C
	private float updateTime; // 0x50

	// Methods

	// RVA: 0x4A75F0 Offset: 0x4A5BF0 VA: 0x1804A75F0
	public void InitWheelSmoke() { }

	// RVA: 0x4A7F70 Offset: 0x4A6570 VA: 0x1804A7F70
	public void UpdateWheelSmoke() { }

	// RVA: 0x4A77A0 Offset: 0x4A5DA0 VA: 0x1804A77A0
	private void UpdateTireEffects(float speedRatio) { }

	// RVA: 0x4A71E0 Offset: 0x4A57E0 VA: 0x1804A71E0
	private bool CheckInWater(int i) { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

