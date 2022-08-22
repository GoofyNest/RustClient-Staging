public class BaseLiquidVessel : AttackEntity // TypeDefIndex: 8522
{	// Fields
	[HeaderAttribute] // RVA: 0xA2990 Offset: 0xA1D90 VA: 0x1800A2990
	public GameObjectRef thrownWaterObject; // 0x280
	public GameObjectRef ThrowEffect3P; // 0x288
	public SoundDefinition throwSound3P; // 0x290
	public GameObjectRef fillFromContainer; // 0x298
	public GameObjectRef fillFromWorld; // 0x2A0
	public SoundDefinition fillFromContainerStartSoundDef; // 0x2A8
	public SoundDefinition fillFromContainerSoundDef; // 0x2B0
	public SoundDefinition fillFromWorldStartSoundDef; // 0x2B8
	public SoundDefinition fillFromWorldSoundDef; // 0x2C0
	public bool hasLid; // 0x2C8
	public float throwScale; // 0x2CC
	public bool canDrinkFrom; // 0x2D0
	public bool updateVMWater; // 0x2D1
	public float minThrowFrac; // 0x2D4
	public bool useThrowAnim; // 0x2D8
	public float fillMlPerSec; // 0x2DC
	private Sound fillSound; // 0x2E0
	private float timeSinceLastAttack; // 0x2E8
	private bool wasFilling; // 0x2EC
	private float nextFreeTime; // 0x2F0

	// Methods

	// RVA: 0xA439F0 Offset: 0xA41FF0 VA: 0x180A439F0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0xA42A00 Offset: 0xA41000 VA: 0x180A42A00
	public int AmountHeld() { }

	// RVA: 0xA43120 Offset: 0xA41720 VA: 0x180A43120
	public float HeldFraction() { }

	// RVA: 0xA431F0 Offset: 0xA417F0 VA: 0x180A431F0
	public int MaxHoldable() { }

	// RVA: 0xA42C30 Offset: 0xA41230 VA: 0x180A42C30
	public bool CanDrink() { }

	// RVA: 0xA431C0 Offset: 0xA417C0 VA: 0x180A431C0
	private bool IsWeaponBusy() { }

	// RVA: 0xA44610 Offset: 0xA42C10 VA: 0x180A44610
	private void SetBusyFor(float dur) { }

	// RVA: 0xA42E20 Offset: 0xA41420 VA: 0x180A42E20
	private void ClearBusy() { }

	// RVA: 0xA42B10 Offset: 0xA41110 VA: 0x180A42B10 Slot: 160
	public virtual void CLThrow() { }

	// RVA: 0xA43280 Offset: 0xA41880 VA: 0x180A43280 Slot: 138
	public override void OnInput() { }

	// RVA: 0xA42E50 Offset: 0xA41450 VA: 0x180A42E50 Slot: 161
	public virtual void DoSendFilling(bool flag) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 162
	public virtual void OnPrimaryAttackPressed() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 163
	public virtual void OnEmptyPrimaryAttackPressed() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 164
	public virtual void OnPrimaryAttackReleased() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 165
	public virtual void OnReloadPressed() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 166
	public virtual void OnReloadHeld() { }

	// RVA: 0xA437F0 Offset: 0xA41DF0 VA: 0x180A437F0 Slot: 167
	public virtual void OnPrimaryAttackHeld(Item ammo, BasePlayer player) { }

	// RVA: 0xA444C0 Offset: 0xA42AC0 VA: 0x180A444C0 Slot: 144
	public override void OnViewmodelEvent(string name) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA42A40 Offset: 0xA41040 VA: 0x180A42A40
	public void CLIENT_StartFillingSoundsContainer(BaseEntity.RPCMessage rpc) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA42A50 Offset: 0xA41050 VA: 0x180A42A50
	public void CLIENT_StartFillingSoundsWorld(BaseEntity.RPCMessage rpc) { }

	// RVA: 0xA44640 Offset: 0xA42C40 VA: 0x180A44640
	private void StartFillingSounds(bool fromContainer = True) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA42A60 Offset: 0xA41060 VA: 0x180A42A60
	public void CLIENT_StopFillingSounds(BaseEntity.RPCMessage rpc) { }

	// RVA: 0xA42A60 Offset: 0xA41060 VA: 0x180A42A60
	private void StopFillingSounds() { }

	// RVA: 0xA44560 Offset: 0xA42B60 VA: 0x180A44560 Slot: 153
	public override void ProcessSpectatorViewmodelEvent(ViewModel vm, BaseEntity.Signal signal, string arg) { }

	// RVA: 0xA42D10 Offset: 0xA41310 VA: 0x180A42D10
	public bool CanFillFromWorld() { }

	// RVA: 0xA42E00 Offset: 0xA41400 VA: 0x180A42E00
	public bool CanThrow() { }

	// RVA: 0xA42EA0 Offset: 0xA414A0 VA: 0x180A42EA0
	public LiquidContainer GetFacingLiquidContainer() { }

	// RVA: 0xA44920 Offset: 0xA42F20 VA: 0x180A44920
	public void .ctor() { }

}

