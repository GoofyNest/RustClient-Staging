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

	// RVA: 0x5BF9F0 Offset: 0x5BDFF0 VA: 0x1805BF9F0 Slot: 151
	public override int MaximalPowerOutput() { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 145
	public override bool IsRootEntity() { }

	// RVA: 0xAC14F0 Offset: 0xABFAF0 VA: 0x180AC14F0
	public float GetWindSpeedScale() { }

	// RVA: 0xAC1710 Offset: 0xABFD10 VA: 0x180AC1710 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0xAC1400 Offset: 0xABFA00 VA: 0x180AC1400
	public Vector3 GetWindAimDir(float time) { }

	// RVA: 0xAC1A80 Offset: 0xAC0080 VA: 0x180AC1A80
	public void Woosh() { }

	// RVA: 0xAC17A0 Offset: 0xABFDA0 VA: 0x180AC17A0
	public void Update() { }

	// RVA: 0xAC1B30 Offset: 0xAC0130 VA: 0x180AC1B30
	public void .ctor() { }

	// RVA: 0xAC1AE0 Offset: 0xAC00E0 VA: 0x180AC1AE0
	private static void .cctor() { }

}

