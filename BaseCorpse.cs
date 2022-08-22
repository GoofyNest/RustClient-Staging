public class BaseCorpse : BaseCombatEntity // TypeDefIndex: 9457
{	// Fields
	public GameObjectRef prefabRagdoll; // 0x240
	public BaseEntity parentEnt; // 0x248
	internal ResourceDispenser resourceDispenser; // 0x250
	internal GameObject ragdollObject; // 0x258

	// Properties
	public override BaseEntity.TraitFlag Traits { get; }

	// Methods

	// RVA: 0x7D8F30 Offset: 0x7D7530 VA: 0x1807D8F30 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x7D94B0 Offset: 0x7D7AB0 VA: 0x1807D94B0 Slot: 13
	public override void ClientOnEnable() { }

	// RVA: 0x7D96B0 Offset: 0x7D7CB0 VA: 0x1807D96B0 Slot: 19
	protected override void DoClientDestroy() { }

	// RVA: 0x7D9D20 Offset: 0x7D8320 VA: 0x1807D9D20 Slot: 16
	public override void PostNetworkUpdate() { }

	// RVA: 0x7D9E80 Offset: 0x7D8480 VA: 0x1807D9E80
	private Rigidbody SetupRigidBody() { }

	// RVA: 0x7D98C0 Offset: 0x7D7EC0 VA: 0x1807D98C0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x7D97D0 Offset: 0x7D7DD0 VA: 0x1807D97D0
	private void Load(Corpse corpse) { }

	// RVA: 0x7D9A70 Offset: 0x7D8070 VA: 0x1807D9A70 Slot: 116
	public override void OnAttacked(HitInfo info) { }

	// RVA: 0x7D8F00 Offset: 0x7D7500 VA: 0x1807D8F00 Slot: 122
	public override string Categorize() { }

	// RVA: 0x7D9FF0 Offset: 0x7D85F0 VA: 0x1807D9FF0 Slot: 86
	public override BaseEntity.TraitFlag get_Traits() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 128
	public override bool ShouldInheritNetworkGroup() { }

	// RVA: 0x49C290 Offset: 0x49A890 VA: 0x18049C290
	public void .ctor() { }

}

