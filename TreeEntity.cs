public class TreeEntity : ResourceEntity, IPrefabPreProcess // TypeDefIndex: 8657
{	// Fields
	[HeaderAttribute] // RVA: 0xB7250 Offset: 0xB6650 VA: 0x1800B7250
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

	// RVA: 0xA1A240 Offset: 0xA18840 VA: 0x180A1A240 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA1B690 Offset: 0xA19C90 VA: 0x180A1B690
	public void TreeFall(BaseEntity.RPCMessage msg) { }

	// RVA: 0xA1AE80 Offset: 0xA19480 VA: 0x180A1AE80
	public void TreeFallTick() { }

	// RVA: 0xA1AC20 Offset: 0xA19220 VA: 0x180A1AC20 Slot: 27
	public override void ResetState() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 58
	public override bool ShouldLerp() { }

	// RVA: 0xA19E00 Offset: 0xA18400 VA: 0x180A19E00 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0xA1A110 Offset: 0xA18710 VA: 0x180A1A110 Slot: 20
	internal override void DoNetworkDestroy() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA19FC0 Offset: 0xA185C0 VA: 0x180A19FC0
	public void CrackSound(BaseEntity.RPCMessage msg) { }

	// RVA: 0x4C3900 Offset: 0x4C1F00 VA: 0x1804C3900 Slot: 113
	public override float BoundsPadding() { }

	// RVA: 0xA1AAE0 Offset: 0xA190E0 VA: 0x180A1AAE0 Slot: 84
	public override void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0xA1BDA0 Offset: 0xA1A3A0 VA: 0x180A1BDA0
	public void .ctor() { }

}

