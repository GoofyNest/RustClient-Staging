public class ArcadeEntity : BaseMonoBehaviour // TypeDefIndex: 8759
{	// Fields
	public uint id; // 0x18
	public uint spriteID; // 0x1C
	public uint soundID; // 0x20
	public bool visible; // 0x24
	public Vector3 heading; // 0x28
	public bool isEnabled; // 0x34
	public bool dirty; // 0x35
	public float alpha; // 0x38
	public BoxCollider boxCollider; // 0x40
	public bool host; // 0x48
	public bool localAuthorativeOverride; // 0x49
	public ArcadeEntity arcadeEntityParent; // 0x50
	public uint prefabID; // 0x58
	[HeaderAttribute] // RVA: 0xBE480 Offset: 0xBD880 VA: 0x1800BE480
	public bool takesDamage; // 0x5C
	public float health; // 0x60
	public float maxHealth; // 0x64
	public bool mapLoadedEntiy; // 0x68
	private Sprite spriteRef; // 0x70
	protected BaseArcadeGame arcadeGameParent; // 0x78
	private ArcadeEntityController controller; // 0x80
	public static uint PARENTID_INVALID; // 0x0
	public ArcadeGame.arcadeEnt savedState; // 0x88

	// Properties
	public Vector3 positionLocal { get; set; }
	public Vector3 positionWorld { get; set; }

	// Methods

	// RVA: 0x82CB10 Offset: 0x82B110 VA: 0x18082CB10
	public bool IsMapEntity() { }

	// RVA: 0x82D710 Offset: 0x82BD10 VA: 0x18082D710
	public void SendEntityMessage(string msg) { }

	// RVA: 0x82D000 Offset: 0x82B600 VA: 0x18082D000 Slot: 6
	public virtual bool OnEntityMessage(string msg, bool predicted = False) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void OnNewChild(ArcadeEntity newChild) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void OnChildUnparented(ArcadeEntity lostChild) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void OnNewParent() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void OnUnparented() { }

	// RVA: 0x82D380 Offset: 0x82B980 VA: 0x18082D380
	public void Remove() { }

	// RVA: 0x82D7C0 Offset: 0x82BDC0 VA: 0x18082D7C0
	public void SetArcadeParent(ArcadeEntity desiredParent) { }

	// RVA: 0x82C6E0 Offset: 0x82ACE0 VA: 0x18082C6E0 Slot: 7
	public virtual void Hurt(ArcadeEntity damageSource, float damage, Vector3 hitPos, Collider collider) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 8
	public virtual void OnKilled() { }

	// RVA: 0x82C660 Offset: 0x82AC60 VA: 0x18082C660
	public ArcadeEntity GetArcadeEntityFromCollider(Collider hitCol) { }

	// RVA: 0x82CA70 Offset: 0x82B070 VA: 0x18082CA70
	public bool IsAuthorative() { }

	// RVA: 0x82D900 Offset: 0x82BF00 VA: 0x18082D900
	public void SetLocalAuthorative(bool wants) { }

	// RVA: 0x82DFB0 Offset: 0x82C5B0 VA: 0x18082DFB0
	public Vector3 get_positionLocal() { }

	// RVA: 0x82E000 Offset: 0x82C600 VA: 0x18082E000
	public void set_positionLocal(Vector3 value) { }

	// RVA: 0x2FA9E0 Offset: 0x2F8FE0 VA: 0x1802FA9E0
	public Vector3 get_positionWorld() { }

	// RVA: 0x82E050 Offset: 0x82C650 VA: 0x18082E050
	public void set_positionWorld(Vector3 value) { }

	// RVA: 0x574470 Offset: 0x572A70 VA: 0x180574470
	public void SetController(ArcadeEntityController newController) { }

	// RVA: 0x5743E0 Offset: 0x5729E0 VA: 0x1805743E0
	public ArcadeEntityController GetController() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 9
	public virtual void AuthorativeThink(float delta) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 10
	public virtual void SlaveThink(float delta) { }

	// RVA: 0x82CF70 Offset: 0x82B570 VA: 0x18082CF70
	public void MarkDirty() { }

	// RVA: 0x82C720 Offset: 0x82AD20 VA: 0x18082C720 Slot: 11
	public virtual void Initialize() { }

	// RVA: 0x82CF80 Offset: 0x82B580 VA: 0x18082CF80
	public void OnDestroy() { }

	// RVA: 0x82D9E0 Offset: 0x82BFE0 VA: 0x18082D9E0
	public void Shutdown() { }

	// RVA: 0x82D750 Offset: 0x82BD50 VA: 0x18082D750 Slot: 12
	public virtual void SetArcadeGameParent(BaseArcadeGame newParent) { }

	// RVA: 0x82D9A0 Offset: 0x82BFA0 VA: 0x18082D9A0
	public void SetupCollider(int type, Vector3 scale) { }

	// RVA: 0x82DC70 Offset: 0x82C270 VA: 0x18082DC70 Slot: 13
	public virtual void UpdateSave(bool force = False) { }

	// RVA: 0x82CB20 Offset: 0x82B120 VA: 0x18082CB20 Slot: 14
	public virtual void Load(ArcadeGame.arcadeEnt proto) { }

	// RVA: 0x82D010 Offset: 0x82B610 VA: 0x18082D010 Slot: 15
	public virtual void PostLoad() { }

	// RVA: 0x82D910 Offset: 0x82BF10 VA: 0x18082D910 Slot: 16
	public virtual void SetPositionWorld(Vector3 newPos) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 17
	public virtual void SetVisible(bool wantsVis) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 18
	public virtual bool IsVisible() { }

	// RVA: 0x82DF40 Offset: 0x82C540 VA: 0x18082DF40
	public void .ctor() { }

	// RVA: 0x82DF00 Offset: 0x82C500 VA: 0x18082DF00
	private static void .cctor() { }

}

