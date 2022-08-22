public class HeldBoomBox : HeldEntity, ICassettePlayer // TypeDefIndex: 8574
{	// Fields
	public BoomBox BoxController; // 0x1F8
	public SwapKeycard cassetteSwapper; // 0x200
	private TimeSince lastPlayToggle; // 0x208
	private static int animPlay; // 0x0

	// Properties
	public BaseEntity ToBaseEntity { get; }

	// Methods

	// RVA: 0x736800 Offset: 0x734E00 VA: 0x180736800 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x4B3F80 Offset: 0x4B2580 VA: 0x1804B3F80 Slot: 157
	public BaseEntity get_ToBaseEntity() { }

	// RVA: 0x736630 Offset: 0x734C30 VA: 0x180736630 Slot: 138
	public override void OnInput() { }

	// RVA: 0x736450 Offset: 0x734A50 VA: 0x180736450 Slot: 142
	public override void OnHolster() { }

	// RVA: 0x736250 Offset: 0x734850 VA: 0x180736250 Slot: 140
	public override void OnDeploy() { }

	// RVA: 0x736290 Offset: 0x734890 VA: 0x180736290 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7360F0 Offset: 0x7346F0 VA: 0x1807360F0
	public void Client_OnCassetteInserted(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x736140 Offset: 0x734740 VA: 0x180736140
	public void Client_OnCassetteRemoved(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7367C0 Offset: 0x734DC0 VA: 0x1807367C0
	public void OnRadioIPChanged(BaseEntity.RPCMessage msg) { }

	// RVA: 0x736780 Offset: 0x734D80 VA: 0x180736780 Slot: 158
	public void OnLoadedWithCassette(Cassette c) { }

	// RVA: 0x736220 Offset: 0x734820 VA: 0x180736220 Slot: 159
	public void OnCensorRecordingsChanged() { }

	// RVA: 0x737310 Offset: 0x735910 VA: 0x180737310
	private void UpdateCassetteSwapper() { }

	// RVA: 0x7373E0 Offset: 0x7359E0 VA: 0x1807373E0
	private void UpdateViewmodelCassette(ViewModel vm) { }

	// RVA: 0x7375D0 Offset: 0x735BD0 VA: 0x1807375D0
	private void UpdateViewmodelPlay(ViewModel vm) { }

	// RVA: 0x7372E0 Offset: 0x7358E0 VA: 0x1807372E0 Slot: 152
	public override void ProcessSpectatorViewmodel(ViewModel vm) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 153
	public override void ProcessSpectatorViewmodelEvent(ViewModel vm, BaseEntity.Signal signal, string arg) { }

	// RVA: 0x736190 Offset: 0x734790 VA: 0x180736190 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x7377D0 Offset: 0x735DD0 VA: 0x1807377D0
	public void .ctor() { }

	// RVA: 0x737780 Offset: 0x735D80 VA: 0x180737780
	private static void .cctor() { }

}

