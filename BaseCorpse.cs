public class BaseCorpse : BaseCombatEntity // TypeDefIndex: 9457
{	// Fields
	public GameObjectRef prefabRagdoll; // 0x240
	public BaseEntity parentEnt; // 0x248
	internal ResourceDispenser resourceDispenser; // 0x250
	internal GameObject ragdollObject; // 0x258

	// Properties
	public override BaseEntity.TraitFlag Traits { get; }

	// Methods

	// RVA: 0x7D8E20 Offset: 0x7D7420 VA: 0x1807D8E20 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x7D93A0 Offset: 0x7D79A0 VA: 0x1807D93A0 Slot: 13
	public override void ClientOnEnable() { }

	// RVA: 0x7D95A0 Offset: 0x7D7BA0 VA: 0x1807D95A0 Slot: 19
	protected override void DoClientDestroy() { }

	// RVA: 0x7D9C10 Offset: 0x7D8210 VA: 0x1807D9C10 Slot: 16
	public override void PostNetworkUpdate() { }

	// RVA: 0x7D9D70 Offset: 0x7D8370 VA: 0x1807D9D70
	private Rigidbody SetupRigidBody() { }

	// RVA: 0x7D97B0 Offset: 0x7D7DB0 VA: 0x1807D97B0 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x7D96C0 Offset: 0x7D7CC0 VA: 0x1807D96C0
	private void Load(Corpse corpse) { }

	// RVA: 0x7D9960 Offset: 0x7D7F60 VA: 0x1807D9960 Slot: 116
	public override void OnAttacked(HitInfo info) { }

	// RVA: 0x7D8DF0 Offset: 0x7D73F0 VA: 0x1807D8DF0 Slot: 122
	public override string Categorize() { }

	// RVA: 0x7D9EE0 Offset: 0x7D84E0 VA: 0x1807D9EE0 Slot: 86
	public override BaseEntity.TraitFlag get_Traits() { }

	// RVA: 0x49BC40 Offset: 0x49A240 VA: 0x18049BC40 Slot: 128
	public override bool ShouldInheritNetworkGroup() { }

	// RVA: 0x49C290 Offset: 0x49A890 VA: 0x18049C290
	public void .ctor() { }

}

