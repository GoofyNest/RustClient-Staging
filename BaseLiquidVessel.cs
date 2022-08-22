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

	// RVA: 0xA441A0 Offset: 0xA427A0 VA: 0x180A441A0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0xA431B0 Offset: 0xA417B0 VA: 0x180A431B0
	public int AmountHeld() { }

	// RVA: 0xA438D0 Offset: 0xA41ED0 VA: 0x180A438D0
	public float HeldFraction() { }

	// RVA: 0xA439A0 Offset: 0xA41FA0 VA: 0x180A439A0
	public int MaxHoldable() { }

	// RVA: 0xA433E0 Offset: 0xA419E0 VA: 0x180A433E0
	public bool CanDrink() { }

	// RVA: 0xA43970 Offset: 0xA41F70 VA: 0x180A43970
	private bool IsWeaponBusy() { }

	// RVA: 0xA44DC0 Offset: 0xA433C0 VA: 0x180A44DC0
	private void SetBusyFor(float dur) { }

	// RVA: 0xA435D0 Offset: 0xA41BD0 VA: 0x180A435D0
	private void ClearBusy() { }

	// RVA: 0xA432C0 Offset: 0xA418C0 VA: 0x180A432C0 Slot: 160
	public virtual void CLThrow() { }

	// RVA: 0xA43A30 Offset: 0xA42030 VA: 0x180A43A30 Slot: 138
	public override void OnInput() { }

	// RVA: 0xA43600 Offset: 0xA41C00 VA: 0x180A43600 Slot: 161
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

	// RVA: 0xA43FA0 Offset: 0xA425A0 VA: 0x180A43FA0 Slot: 167
	public virtual void OnPrimaryAttackHeld(Item ammo, BasePlayer player) { }

	// RVA: 0xA44C70 Offset: 0xA43270 VA: 0x180A44C70 Slot: 144
	public override void OnViewmodelEvent(string name) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA431F0 Offset: 0xA417F0 VA: 0x180A431F0
	public void CLIENT_StartFillingSoundsContainer(BaseEntity.RPCMessage rpc) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA43200 Offset: 0xA41800 VA: 0x180A43200
	public void CLIENT_StartFillingSoundsWorld(BaseEntity.RPCMessage rpc) { }

	// RVA: 0xA44DF0 Offset: 0xA433F0 VA: 0x180A44DF0
	private void StartFillingSounds(bool fromContainer = True) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0xA43210 Offset: 0xA41810 VA: 0x180A43210
	public void CLIENT_StopFillingSounds(BaseEntity.RPCMessage rpc) { }

	// RVA: 0xA43210 Offset: 0xA41810 VA: 0x180A43210
	private void StopFillingSounds() { }

	// RVA: 0xA44D10 Offset: 0xA43310 VA: 0x180A44D10 Slot: 153
	public override void ProcessSpectatorViewmodelEvent(ViewModel vm, BaseEntity.Signal signal, string arg) { }

	// RVA: 0xA434C0 Offset: 0xA41AC0 VA: 0x180A434C0
	public bool CanFillFromWorld() { }

	// RVA: 0xA435B0 Offset: 0xA41BB0 VA: 0x180A435B0
	public bool CanThrow() { }

	// RVA: 0xA43650 Offset: 0xA41C50 VA: 0x180A43650
	public LiquidContainer GetFacingLiquidContainer() { }

	// RVA: 0xA450D0 Offset: 0xA436D0 VA: 0x180A450D0
	public void .ctor() { }

}

