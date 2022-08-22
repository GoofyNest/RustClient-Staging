public class FireBall : BaseEntity, ISplashable // TypeDefIndex: 9538
{	// Fields
	public float lifeTimeMin; // 0x168
	public float lifeTimeMax; // 0x16C
	public ParticleSystem[] movementSystems; // 0x170
	public ParticleSystem[] restingSystems; // 0x178
	public float generation; // 0x180
	public GameObjectRef spreadSubEntity; // 0x188
	public float tickRate; // 0x190
	public float damagePerSecond; // 0x194
	public float radius; // 0x198
	public int waterToExtinguish; // 0x19C
	public bool canMerge; // 0x1A0
	public LayerMask AttackLayers; // 0x1A4
	public bool ignoreNPC; // 0x1A8
	private bool wasResting; // 0x1A9

	// Methods

	// RVA: 0x788A50 Offset: 0x787050 VA: 0x180788A50
	public bool IsResting() { }

	// RVA: 0x788A60 Offset: 0x787060 VA: 0x180788A60 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x788C60 Offset: 0x787260 VA: 0x180788C60
	public void .ctor() { }

}

