public class EasterBasket : AttackEntity // TypeDefIndex: 8567
{	// Fields
	public GameObjectRef eggProjectile; // 0x280
	public ItemDefinition ammoType; // 0x288
	public int lastCollectedIndex; // 0x290
	private bool aiming; // 0x294
	private float nextAmmoCheckTime; // 0x298
	private bool didHaveAmmo; // 0x29C

	// Methods

	// RVA: 0xAB8980 Offset: 0xAB6F80 VA: 0x180AB8980 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x923CC0 Offset: 0x9222C0 VA: 0x180923CC0 Slot: 157
	public override Vector3 GetInheritedVelocity(BasePlayer player) { }

	// RVA: 0xAB7DC0 Offset: 0xAB63C0 VA: 0x180AB7DC0
	public Item GetAmmo() { }

	// RVA: 0xAB7EB0 Offset: 0xAB64B0 VA: 0x180AB7EB0
	public bool HasAmmo() { }

	// RVA: 0xAB7ED0 Offset: 0xAB64D0 VA: 0x180AB7ED0
	public void LaunchProjectile() { }

	// RVA: 0xAB8A70 Offset: 0xAB7070 VA: 0x180AB8A70 Slot: 144
	public override void OnViewmodelEvent(string name) { }

	// RVA: 0xAB8190 Offset: 0xAB6790 VA: 0x180AB8190 Slot: 138
	public override void OnInput() { }

	// RVA: 0xAB8C80 Offset: 0xAB7280 VA: 0x180AB8C80
	public void .ctor() { }

}

