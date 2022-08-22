public class HeldBoomBox : HeldEntity, ICassettePlayer // TypeDefIndex: 8574
{	// Fields
	public BoomBox BoxController; // 0x1F8
	public SwapKeycard cassetteSwapper; // 0x200
	private TimeSince lastPlayToggle; // 0x208
	private static int animPlay; // 0x0

	// Properties
	public BaseEntity ToBaseEntity { get; }

	// Methods

	// RVA: 0x7367A0 Offset: 0x734DA0 VA: 0x1807367A0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x4B3FF0 Offset: 0x4B25F0 VA: 0x1804B3FF0 Slot: 157
	public BaseEntity get_ToBaseEntity() { }

	// RVA: 0x7365D0 Offset: 0x734BD0 VA: 0x1807365D0 Slot: 138
	public override void OnInput() { }

	// RVA: 0x7363F0 Offset: 0x7349F0 VA: 0x1807363F0 Slot: 142
	public override void OnHolster() { }

	// RVA: 0x7361F0 Offset: 0x7347F0 VA: 0x1807361F0 Slot: 140
	public override void OnDeploy() { }

	// RVA: 0x736230 Offset: 0x734830 VA: 0x180736230 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x736090 Offset: 0x734690 VA: 0x180736090
	public void Client_OnCassetteInserted(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7360E0 Offset: 0x7346E0 VA: 0x1807360E0
	public void Client_OnCassetteRemoved(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x736760 Offset: 0x734D60 VA: 0x180736760
	public void OnRadioIPChanged(BaseEntity.RPCMessage msg) { }

	// RVA: 0x736720 Offset: 0x734D20 VA: 0x180736720 Slot: 158
	public void OnLoadedWithCassette(Cassette c) { }

	// RVA: 0x7361C0 Offset: 0x7347C0 VA: 0x1807361C0 Slot: 159
	public void OnCensorRecordingsChanged() { }

	// RVA: 0x7372B0 Offset: 0x7358B0 VA: 0x1807372B0
	private void UpdateCassetteSwapper() { }

	// RVA: 0x737380 Offset: 0x735980 VA: 0x180737380
	private void UpdateViewmodelCassette(ViewModel vm) { }

	// RVA: 0x737570 Offset: 0x735B70 VA: 0x180737570
	private void UpdateViewmodelPlay(ViewModel vm) { }

	// RVA: 0x737280 Offset: 0x735880 VA: 0x180737280 Slot: 152
	public override void ProcessSpectatorViewmodel(ViewModel vm) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 153
	public override void ProcessSpectatorViewmodelEvent(ViewModel vm, BaseEntity.Signal signal, string arg) { }

	// RVA: 0x736130 Offset: 0x734730 VA: 0x180736130 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x737770 Offset: 0x735D70 VA: 0x180737770
	public void .ctor() { }

	// RVA: 0x737720 Offset: 0x735D20 VA: 0x180737720
	private static void .cctor() { }

}

