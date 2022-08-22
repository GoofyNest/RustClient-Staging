public class EasterBasket : AttackEntity // TypeDefIndex: 8567
{	// Fields
	public GameObjectRef eggProjectile; // 0x280
	public ItemDefinition ammoType; // 0x288
	public int lastCollectedIndex; // 0x290
	private bool aiming; // 0x294
	private float nextAmmoCheckTime; // 0x298
	private bool didHaveAmmo; // 0x29C

	// Methods

	// RVA: 0xAB8E50 Offset: 0xAB7450 VA: 0x180AB8E50 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x9241D0 Offset: 0x9227D0 VA: 0x1809241D0 Slot: 157
	public override Vector3 GetInheritedVelocity(BasePlayer player) { }

	// RVA: 0xAB8290 Offset: 0xAB6890 VA: 0x180AB8290
	public Item GetAmmo() { }

	// RVA: 0xAB8380 Offset: 0xAB6980 VA: 0x180AB8380
	public bool HasAmmo() { }

	// RVA: 0xAB83A0 Offset: 0xAB69A0 VA: 0x180AB83A0
	public void LaunchProjectile() { }

	// RVA: 0xAB8F40 Offset: 0xAB7540 VA: 0x180AB8F40 Slot: 144
	public override void OnViewmodelEvent(string name) { }

	// RVA: 0xAB8660 Offset: 0xAB6C60 VA: 0x180AB8660 Slot: 138
	public override void OnInput() { }

	// RVA: 0xAB9150 Offset: 0xAB7750 VA: 0x180AB9150
	public void .ctor() { }

}

