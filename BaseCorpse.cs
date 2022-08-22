public class BaseCorpse : BaseCombatEntity // TypeDefIndex: 9457
{	// Fields
	public GameObjectRef prefabRagdoll; // 0x240
	public BaseEntity parentEnt; // 0x248
	internal ResourceDispenser resourceDispenser; // 0x250
	internal GameObject ragdollObject; // 0x258

	// Properties
	public override BaseEntity.TraitFlag Traits { get; }

	// Methods

	// RVA: 0x7A4850 Offset: 0x7A2E50 VA: 0x1807A4850 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x7A4DD0 Offset: 0x7A33D0 VA: 0x1807A4DD0 Slot: 13
	public override void ClientOnEnable() { }

	// RVA: 0x7A4FD0 Offset: 0x7A35D0 VA: 0x1807A4FD0 Slot: 19
	protected override void DoClientDestroy() { }

	// RVA: 0x7A5640 Offset: 0x7A3C40 VA: 0x1807A5640 Slot: 16
	public override void PostNetworkUpdate() { }

	// RVA: 0x7A57A0 Offset: 0x7A3DA0 VA: 0x1807A57A0
	private Rigidbody SetupRigidBody() { }

	// RVA: 0x7A51E0 Offset: 0x7A37E0 VA: 0x1807A51E0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x7A50F0 Offset: 0x7A36F0 VA: 0x1807A50F0
	private void Load(Corpse corpse) { }

	// RVA: 0x7A5390 Offset: 0x7A3990 VA: 0x1807A5390 Slot: 116
	public override void OnAttacked(HitInfo info) { }

	// RVA: 0x7A4820 Offset: 0x7A2E20 VA: 0x1807A4820 Slot: 122
	public override string Categorize() { }

	// RVA: 0x7A5910 Offset: 0x7A3F10 VA: 0x1807A5910 Slot: 86
	public override BaseEntity.TraitFlag get_Traits() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 128
	public override bool ShouldInheritNetworkGroup() { }

	// RVA: 0x49C290 Offset: 0x49A890 VA: 0x18049C290
	public void .ctor() { }

}

