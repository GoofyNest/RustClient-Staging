public class ElectricWindmill : IOEntity // TypeDefIndex: 8740
{	// Fields
	public Animator animator; // 0x288
	public int maxPowerGeneration; // 0x290
	public Transform vaneRot; // 0x298
	public SoundDefinition wooshSound; // 0x2A0
	public Transform wooshOrigin; // 0x2A8
	public float targetSpeed; // 0x2B0
	private float serverWindSpeed; // 0x2B4
	private float lastServerTime; // 0x2B8
	protected static int speedIndex; // 0x0

	// Methods

	// RVA: 0x5BFA60 Offset: 0x5BE060 VA: 0x1805BFA60 Slot: 151
	public override int MaximalPowerOutput() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 145
	public override bool IsRootEntity() { }

	// RVA: 0xAC0D60 Offset: 0xABF360 VA: 0x180AC0D60
	public float GetWindSpeedScale() { }

	// RVA: 0xAC0F80 Offset: 0xABF580 VA: 0x180AC0F80 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0xAC0C70 Offset: 0xABF270 VA: 0x180AC0C70
	public Vector3 GetWindAimDir(float time) { }

	// RVA: 0xAC12F0 Offset: 0xABF8F0 VA: 0x180AC12F0
	public void Woosh() { }

	// RVA: 0xAC1010 Offset: 0xABF610 VA: 0x180AC1010
	public void Update() { }

	// RVA: 0xAC13A0 Offset: 0xABF9A0 VA: 0x180AC13A0
	public void .ctor() { }

	// RVA: 0xAC1350 Offset: 0xABF950 VA: 0x180AC1350
	private static void .cctor() { }

}

