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

	// RVA: 0x82D060 Offset: 0x82B660 VA: 0x18082D060
	public bool IsMapEntity() { }

	// RVA: 0x82DC60 Offset: 0x82C260 VA: 0x18082DC60
	public void SendEntityMessage(string msg) { }

	// RVA: 0x82D550 Offset: 0x82BB50 VA: 0x18082D550 Slot: 6
	public virtual bool OnEntityMessage(string msg, bool predicted = False) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void OnNewChild(ArcadeEntity newChild) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void OnChildUnparented(ArcadeEntity lostChild) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void OnNewParent() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void OnUnparented() { }

	// RVA: 0x82D8D0 Offset: 0x82BED0 VA: 0x18082D8D0
	public void Remove() { }

	// RVA: 0x82DD10 Offset: 0x82C310 VA: 0x18082DD10
	public void SetArcadeParent(ArcadeEntity desiredParent) { }

	// RVA: 0x82CC30 Offset: 0x82B230 VA: 0x18082CC30 Slot: 7
	public virtual void Hurt(ArcadeEntity damageSource, float damage, Vector3 hitPos, Collider collider) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 8
	public virtual void OnKilled() { }

	// RVA: 0x82CBB0 Offset: 0x82B1B0 VA: 0x18082CBB0
	public ArcadeEntity GetArcadeEntityFromCollider(Collider hitCol) { }

	// RVA: 0x82CFC0 Offset: 0x82B5C0 VA: 0x18082CFC0
	public bool IsAuthorative() { }

	// RVA: 0x82DE50 Offset: 0x82C450 VA: 0x18082DE50
	public void SetLocalAuthorative(bool wants) { }

	// RVA: 0x82E500 Offset: 0x82CB00 VA: 0x18082E500
	public Vector3 get_positionLocal() { }

	// RVA: 0x82E550 Offset: 0x82CB50 VA: 0x18082E550
	public void set_positionLocal(Vector3 value) { }

	// RVA: 0x2FA9E0 Offset: 0x2F8FE0 VA: 0x1802FA9E0
	public Vector3 get_positionWorld() { }

	// RVA: 0x82E5A0 Offset: 0x82CBA0 VA: 0x18082E5A0
	public void set_positionWorld(Vector3 value) { }

	// RVA: 0x574400 Offset: 0x572A00 VA: 0x180574400
	public void SetController(ArcadeEntityController newController) { }

	// RVA: 0x574370 Offset: 0x572970 VA: 0x180574370
	public ArcadeEntityController GetController() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 9
	public virtual void AuthorativeThink(float delta) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 10
	public virtual void SlaveThink(float delta) { }

	// RVA: 0x82D4C0 Offset: 0x82BAC0 VA: 0x18082D4C0
	public void MarkDirty() { }

	// RVA: 0x82CC70 Offset: 0x82B270 VA: 0x18082CC70 Slot: 11
	public virtual void Initialize() { }

	// RVA: 0x82D4D0 Offset: 0x82BAD0 VA: 0x18082D4D0
	public void OnDestroy() { }

	// RVA: 0x82DF30 Offset: 0x82C530 VA: 0x18082DF30
	public void Shutdown() { }

	// RVA: 0x82DCA0 Offset: 0x82C2A0 VA: 0x18082DCA0 Slot: 12
	public virtual void SetArcadeGameParent(BaseArcadeGame newParent) { }

	// RVA: 0x82DEF0 Offset: 0x82C4F0 VA: 0x18082DEF0
	public void SetupCollider(int type, Vector3 scale) { }

	// RVA: 0x82E1C0 Offset: 0x82C7C0 VA: 0x18082E1C0 Slot: 13
	public virtual void UpdateSave(bool force = False) { }

	// RVA: 0x82D070 Offset: 0x82B670 VA: 0x18082D070 Slot: 14
	public virtual void Load(ArcadeGame.arcadeEnt proto) { }

	// RVA: 0x82D560 Offset: 0x82BB60 VA: 0x18082D560 Slot: 15
	public virtual void PostLoad() { }

	// RVA: 0x82DE60 Offset: 0x82C460 VA: 0x18082DE60 Slot: 16
	public virtual void SetPositionWorld(Vector3 newPos) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 17
	public virtual void SetVisible(bool wantsVis) { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 18
	public virtual bool IsVisible() { }

	// RVA: 0x82E490 Offset: 0x82CA90 VA: 0x18082E490
	public void .ctor() { }

	// RVA: 0x82E450 Offset: 0x82CA50 VA: 0x18082E450
	private static void .cctor() { }

}

