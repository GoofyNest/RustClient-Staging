public class EasterBasket : AttackEntity // TypeDefIndex: 8567
{	// Fields
	public GameObjectRef eggProjectile; // 0x280
	public ItemDefinition ammoType; // 0x288
	public int lastCollectedIndex; // 0x290
	private bool aiming; // 0x294
	private float nextAmmoCheckTime; // 0x298
	private bool didHaveAmmo; // 0x29C

	// Methods

	// RVA: 0xAB86C0 Offset: 0xAB6CC0 VA: 0x180AB86C0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x923BB0 Offset: 0x9221B0 VA: 0x180923BB0 Slot: 157
	public override Vector3 GetInheritedVelocity(BasePlayer player) { }

	// RVA: 0xAB7B00 Offset: 0xAB6100 VA: 0x180AB7B00
	public Item GetAmmo() { }

	// RVA: 0xAB7BF0 Offset: 0xAB61F0 VA: 0x180AB7BF0
	public bool HasAmmo() { }

	// RVA: 0xAB7C10 Offset: 0xAB6210 VA: 0x180AB7C10
	public void LaunchProjectile() { }

	// RVA: 0xAB87B0 Offset: 0xAB6DB0 VA: 0x180AB87B0 Slot: 144
	public override void OnViewmodelEvent(string name) { }

	// RVA: 0xAB7ED0 Offset: 0xAB64D0 VA: 0x180AB7ED0 Slot: 138
	public override void OnInput() { }

	// RVA: 0xAB89C0 Offset: 0xAB6FC0 VA: 0x180AB89C0
	public void .ctor() { }

}

