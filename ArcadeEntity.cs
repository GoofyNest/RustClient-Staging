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
	[HeaderAttribute] // RVA: 0xBE420 Offset: 0xBD820 VA: 0x1800BE420
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

	// RVA: 0x82CA00 Offset: 0x82B000 VA: 0x18082CA00
	public bool IsMapEntity() { }

	// RVA: 0x82D600 Offset: 0x82BC00 VA: 0x18082D600
	public void SendEntityMessage(string msg) { }

	// RVA: 0x82CEF0 Offset: 0x82B4F0 VA: 0x18082CEF0 Slot: 6
	public virtual bool OnEntityMessage(string msg, bool predicted = False) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void OnNewChild(ArcadeEntity newChild) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void OnChildUnparented(ArcadeEntity lostChild) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void OnNewParent() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void OnUnparented() { }

	// RVA: 0x82D270 Offset: 0x82B870 VA: 0x18082D270
	public void Remove() { }

	// RVA: 0x82D6B0 Offset: 0x82BCB0 VA: 0x18082D6B0
	public void SetArcadeParent(ArcadeEntity desiredParent) { }

	// RVA: 0x82C5D0 Offset: 0x82ABD0 VA: 0x18082C5D0 Slot: 7
	public virtual void Hurt(ArcadeEntity damageSource, float damage, Vector3 hitPos, Collider collider) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 8
	public virtual void OnKilled() { }

	// RVA: 0x82C550 Offset: 0x82AB50 VA: 0x18082C550
	public ArcadeEntity GetArcadeEntityFromCollider(Collider hitCol) { }

	// RVA: 0x82C960 Offset: 0x82AF60 VA: 0x18082C960
	public bool IsAuthorative() { }

	// RVA: 0x82D7F0 Offset: 0x82BDF0 VA: 0x18082D7F0
	public void SetLocalAuthorative(bool wants) { }

	// RVA: 0x82DEA0 Offset: 0x82C4A0 VA: 0x18082DEA0
	public Vector3 get_positionLocal() { }

	// RVA: 0x82DEF0 Offset: 0x82C4F0 VA: 0x18082DEF0
	public void set_positionLocal(Vector3 value) { }

	// RVA: 0x2FA9E0 Offset: 0x2F8FE0 VA: 0x1802FA9E0
	public Vector3 get_positionWorld() { }

	// RVA: 0x82DF40 Offset: 0x82C540 VA: 0x18082DF40
	public void set_positionWorld(Vector3 value) { }

	// RVA: 0x574470 Offset: 0x572A70 VA: 0x180574470
	public void SetController(ArcadeEntityController newController) { }

	// RVA: 0x5743E0 Offset: 0x5729E0 VA: 0x1805743E0
	public ArcadeEntityController GetController() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 9
	public virtual void AuthorativeThink(float delta) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 10
	public virtual void SlaveThink(float delta) { }

	// RVA: 0x82CE60 Offset: 0x82B460 VA: 0x18082CE60
	public void MarkDirty() { }

	// RVA: 0x82C610 Offset: 0x82AC10 VA: 0x18082C610 Slot: 11
	public virtual void Initialize() { }

	// RVA: 0x82CE70 Offset: 0x82B470 VA: 0x18082CE70
	public void OnDestroy() { }

	// RVA: 0x82D8D0 Offset: 0x82BED0 VA: 0x18082D8D0
	public void Shutdown() { }

	// RVA: 0x82D640 Offset: 0x82BC40 VA: 0x18082D640 Slot: 12
	public virtual void SetArcadeGameParent(BaseArcadeGame newParent) { }

	// RVA: 0x82D890 Offset: 0x82BE90 VA: 0x18082D890
	public void SetupCollider(int type, Vector3 scale) { }

	// RVA: 0x82DB60 Offset: 0x82C160 VA: 0x18082DB60 Slot: 13
	public virtual void UpdateSave(bool force = False) { }

	// RVA: 0x82CA10 Offset: 0x82B010 VA: 0x18082CA10 Slot: 14
	public virtual void Load(ArcadeGame.arcadeEnt proto) { }

	// RVA: 0x82CF00 Offset: 0x82B500 VA: 0x18082CF00 Slot: 15
	public virtual void PostLoad() { }

	// RVA: 0x82D800 Offset: 0x82BE00 VA: 0x18082D800 Slot: 16
	public virtual void SetPositionWorld(Vector3 newPos) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 17
	public virtual void SetVisible(bool wantsVis) { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 18
	public virtual bool IsVisible() { }

	// RVA: 0x82DE30 Offset: 0x82C430 VA: 0x18082DE30
	public void .ctor() { }

	// RVA: 0x82DDF0 Offset: 0x82C3F0 VA: 0x18082DDF0
	private static void .cctor() { }

}

