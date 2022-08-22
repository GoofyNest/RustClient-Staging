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

	// RVA: 0xA43CB0 Offset: 0xA422B0 VA: 0x180A43CB0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0xA42CC0 Offset: 0xA412C0 VA: 0x180A42CC0
	public int AmountHeld() { }

	// RVA: 0xA433E0 Offset: 0xA419E0 VA: 0x180A433E0
	public float HeldFraction() { }

	// RVA: 0xA434B0 Offset: 0xA41AB0 VA: 0x180A434B0
	public int MaxHoldable() { }

	// RVA: 0xA42EF0 Offset: 0xA414F0 VA: 0x180A42EF0
	public bool CanDrink() { }

	// RVA: 0xA43480 Offset: 0xA41A80 VA: 0x180A43480
	private bool IsWeaponBusy() { }

	// RVA: 0xA448D0 Offset: 0xA42ED0 VA: 0x180A448D0
	private void SetBusyFor(float dur) { }

	// RVA: 0xA430E0 Offset: 0xA416E0 VA: 0x180A430E0
	private void ClearBusy() { }

	// RVA: 0xA42DD0 Offset: 0xA413D0 VA: 0x180A42DD0 Slot: 160
	public virtual void CLThrow() { }

	// RVA: 0xA43540 Offset: 0xA41B40 VA: 0x180A43540 Slot: 138
	public override void OnInput() { }

	// RVA: 0xA43110 Offset: 0xA41710 VA: 0x180A43110 Slot: 161
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

	// RVA: 0xA43AB0 Offset: 0xA420B0 VA: 0x180A43AB0 Slot: 167
	public virtual void OnPrimaryAttackHeld(Item ammo, BasePlayer player) { }

	// RVA: 0xA44780 Offset: 0xA42D80 VA: 0x180A44780 Slot: 144
	public override void OnViewmodelEvent(string name) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA42D00 Offset: 0xA41300 VA: 0x180A42D00
	public void CLIENT_StartFillingSoundsContainer(BaseEntity.RPCMessage rpc) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA42D10 Offset: 0xA41310 VA: 0x180A42D10
	public void CLIENT_StartFillingSoundsWorld(BaseEntity.RPCMessage rpc) { }

	// RVA: 0xA44900 Offset: 0xA42F00 VA: 0x180A44900
	private void StartFillingSounds(bool fromContainer = True) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA42D20 Offset: 0xA41320 VA: 0x180A42D20
	public void CLIENT_StopFillingSounds(BaseEntity.RPCMessage rpc) { }

	// RVA: 0xA42D20 Offset: 0xA41320 VA: 0x180A42D20
	private void StopFillingSounds() { }

	// RVA: 0xA44820 Offset: 0xA42E20 VA: 0x180A44820 Slot: 153
	public override void ProcessSpectatorViewmodelEvent(ViewModel vm, BaseEntity.Signal signal, string arg) { }

	// RVA: 0xA42FD0 Offset: 0xA415D0 VA: 0x180A42FD0
	public bool CanFillFromWorld() { }

	// RVA: 0xA430C0 Offset: 0xA416C0 VA: 0x180A430C0
	public bool CanThrow() { }

	// RVA: 0xA43160 Offset: 0xA41760 VA: 0x180A43160
	public LiquidContainer GetFacingLiquidContainer() { }

	// RVA: 0xA44BE0 Offset: 0xA431E0 VA: 0x180A44BE0
	public void .ctor() { }

}

