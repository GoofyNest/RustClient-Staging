public class TreeEntity : ResourceEntity, IPrefabPreProcess // TypeDefIndex: 8657
{	// Fields
	[HeaderAttribute] // RVA: 0xB71B0 Offset: 0xB65B0 VA: 0x1800B71B0
	public bool fallOnKilled; // 0x180
	public float fallDuration; // 0x184
	public GameObjectRef fallStartSound; // 0x188
	public GameObjectRef fallImpactSound; // 0x190
	public GameObjectRef fallImpactParticles; // 0x198
	public SoundDefinition fallLeavesLoopDef; // 0x1A0
	public bool[] usedHeights; // 0x1A8
	public bool impactSoundPlayed; // 0x1B0
	private float treeDistanceUponFalling; // 0x1B4
	protected Transform treeBaseRef; // 0x1B8
	protected Vector3 oldSkinPos; // 0x1C0
	protected Quaternion oldSkinRot; // 0x1CC
	protected float lastTreeFallTickTime; // 0x1DC
	protected float fallStartTime; // 0x1E0
	private Sound fallLeavesLoop; // 0x1E8
	private SoundModulation.Modulator fallLeavesGainMod; // 0x1F0
	private Vector3 hitDirection; // 0x1F8
	private Vector3 rotateDirection; // 0x204
	private float impactSoundCheckHeight; // 0x210
	private const float treeFallMaxDistSq = 10000;
	public GameObjectRef prefab; // 0x218
	public bool hasBonusGame; // 0x220
	public GameObjectRef bonusHitEffect; // 0x228
	public GameObjectRef bonusHitSound; // 0x230
	public Collider serverCollider; // 0x238
	public Collider clientCollider; // 0x240
	public SoundDefinition smallCrackSoundDef; // 0x248
	public SoundDefinition medCrackSoundDef; // 0x250
	private float lastAttackDamage; // 0x258
	private const float crackSoundMaxDistSq = 900;
	private TreeLOD skin; // 0x260

	// Methods

	// RVA: 0xA19F80 Offset: 0xA18580 VA: 0x180A19F80 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xA1B3D0 Offset: 0xA199D0 VA: 0x180A1B3D0
	public void TreeFall(BaseEntity.RPCMessage msg) { }

	// RVA: 0xA1ABC0 Offset: 0xA191C0 VA: 0x180A1ABC0
	public void TreeFallTick() { }

	// RVA: 0xA1A960 Offset: 0xA18F60 VA: 0x180A1A960 Slot: 27
	public override void ResetState() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 58
	public override bool ShouldLerp() { }

	// RVA: 0xA19B40 Offset: 0xA18140 VA: 0x180A19B40 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0xA19E50 Offset: 0xA18450 VA: 0x180A19E50 Slot: 20
	internal override void DoNetworkDestroy() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0xA19D00 Offset: 0xA18300 VA: 0x180A19D00
	public void CrackSound(BaseEntity.RPCMessage msg) { }

	// RVA: 0x4C3900 Offset: 0x4C1F00 VA: 0x1804C3900 Slot: 113
	public override float BoundsPadding() { }

	// RVA: 0xA1A820 Offset: 0xA18E20 VA: 0x180A1A820 Slot: 84
	public override void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0xA1BAE0 Offset: 0xA1A0E0 VA: 0x180A1BAE0
	public void .ctor() { }

}

