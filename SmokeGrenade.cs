public class SmokeGrenade : TimedExplosive // TypeDefIndex: 9608
{	// Fields
	public float smokeDuration; // 0x1B8
	public GameObjectRef smokeEffectPrefab; // 0x1C0
	public GameObjectRef igniteSound; // 0x1C8
	public SoundPlayer soundLoop; // 0x1D0
	private GameObject smokeEffectInstance; // 0x1D8
	public static List<SmokeGrenade> activeGrenades; // 0x0
	public float fieldMin; // 0x1E0
	public float fieldMax; // 0x1E4

	// Methods

	// RVA: 0x5B06A0 Offset: 0x5AECA0 VA: 0x1805B06A0 Slot: 31
	public override void DestroyShared() { }

	// RVA: 0x5B0720 Offset: 0x5AED20 VA: 0x1805B0720
	public void EnsureSmokeEffectEnabled() { }

	// RVA: 0x5B05C0 Offset: 0x5AEBC0 VA: 0x1805B05C0 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x5B0590 Offset: 0x5AEB90 VA: 0x1805B0590
	public void CheckFuse() { }

	// RVA: 0x5B09B0 Offset: 0x5AEFB0 VA: 0x1805B09B0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x5B0A10 Offset: 0x5AF010 VA: 0x1805B0A10
	public void OnDestroy() { }

	// RVA: 0x5B0C40 Offset: 0x5AF240 VA: 0x1805B0C40
	public void Update() { }

	// RVA: 0x5B0E90 Offset: 0x5AF490 VA: 0x1805B0E90
	public void .ctor() { }

	// RVA: 0x5B0E30 Offset: 0x5AF430 VA: 0x1805B0E30
	private static void .cctor() { }

}

