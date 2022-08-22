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

	// RVA: 0xAC1020 Offset: 0xABF620 VA: 0x180AC1020
	public float GetWindSpeedScale() { }

	// RVA: 0xAC1240 Offset: 0xABF840 VA: 0x180AC1240 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0xAC0F30 Offset: 0xABF530 VA: 0x180AC0F30
	public Vector3 GetWindAimDir(float time) { }

	// RVA: 0xAC15B0 Offset: 0xABFBB0 VA: 0x180AC15B0
	public void Woosh() { }

	// RVA: 0xAC12D0 Offset: 0xABF8D0 VA: 0x180AC12D0
	public void Update() { }

	// RVA: 0xAC1660 Offset: 0xABFC60 VA: 0x180AC1660
	public void .ctor() { }

	// RVA: 0xAC1610 Offset: 0xABFC10 VA: 0x180AC1610
	private static void .cctor() { }

}

