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

	// RVA: 0x5B0710 Offset: 0x5AED10 VA: 0x1805B0710 Slot: 31
	public override void DestroyShared() { }

	// RVA: 0x5B0790 Offset: 0x5AED90 VA: 0x1805B0790
	public void EnsureSmokeEffectEnabled() { }

	// RVA: 0x5B0630 Offset: 0x5AEC30 VA: 0x1805B0630 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x5B0600 Offset: 0x5AEC00 VA: 0x1805B0600
	public void CheckFuse() { }

	// RVA: 0x5B0A20 Offset: 0x5AF020 VA: 0x1805B0A20 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x5B0A80 Offset: 0x5AF080 VA: 0x1805B0A80
	public void OnDestroy() { }

	// RVA: 0x5B0CB0 Offset: 0x5AF2B0 VA: 0x1805B0CB0
	public void Update() { }

	// RVA: 0x5B0F00 Offset: 0x5AF500 VA: 0x1805B0F00
	public void .ctor() { }

	// RVA: 0x5B0EA0 Offset: 0x5AF4A0 VA: 0x1805B0EA0
	private static void .cctor() { }

}

