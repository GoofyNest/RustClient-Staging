public class HeldBoomBox : HeldEntity, ICassettePlayer // TypeDefIndex: 8574
{	// Fields
	public BoomBox BoxController; // 0x1F8
	public SwapKeycard cassetteSwapper; // 0x200
	private TimeSince lastPlayToggle; // 0x208
	private static int animPlay; // 0x0

	// Properties
	public BaseEntity ToBaseEntity { get; }

	// Methods

	// RVA: 0x7368B0 Offset: 0x734EB0 VA: 0x1807368B0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x4B3FF0 Offset: 0x4B25F0 VA: 0x1804B3FF0 Slot: 157
	public BaseEntity get_ToBaseEntity() { }

	// RVA: 0x7366E0 Offset: 0x734CE0 VA: 0x1807366E0 Slot: 138
	public override void OnInput() { }

	// RVA: 0x736500 Offset: 0x734B00 VA: 0x180736500 Slot: 142
	public override void OnHolster() { }

	// RVA: 0x736300 Offset: 0x734900 VA: 0x180736300 Slot: 140
	public override void OnDeploy() { }

	// RVA: 0x736340 Offset: 0x734940 VA: 0x180736340 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7361A0 Offset: 0x7347A0 VA: 0x1807361A0
	public void Client_OnCassetteInserted(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x7361F0 Offset: 0x7347F0 VA: 0x1807361F0
	public void Client_OnCassetteRemoved(BaseEntity.RPCMessage msg) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x736870 Offset: 0x734E70 VA: 0x180736870
	public void OnRadioIPChanged(BaseEntity.RPCMessage msg) { }

	// RVA: 0x736830 Offset: 0x734E30 VA: 0x180736830 Slot: 158
	public void OnLoadedWithCassette(Cassette c) { }

	// RVA: 0x7362D0 Offset: 0x7348D0 VA: 0x1807362D0 Slot: 159
	public void OnCensorRecordingsChanged() { }

	// RVA: 0x7373C0 Offset: 0x7359C0 VA: 0x1807373C0
	private void UpdateCassetteSwapper() { }

	// RVA: 0x737490 Offset: 0x735A90 VA: 0x180737490
	private void UpdateViewmodelCassette(ViewModel vm) { }

	// RVA: 0x737680 Offset: 0x735C80 VA: 0x180737680
	private void UpdateViewmodelPlay(ViewModel vm) { }

	// RVA: 0x737390 Offset: 0x735990 VA: 0x180737390 Slot: 152
	public override void ProcessSpectatorViewmodel(ViewModel vm) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40 Slot: 153
	public override void ProcessSpectatorViewmodelEvent(ViewModel vm, BaseEntity.Signal signal, string arg) { }

	// RVA: 0x736240 Offset: 0x734840 VA: 0x180736240 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x737880 Offset: 0x735E80 VA: 0x180737880
	public void .ctor() { }

	// RVA: 0x737830 Offset: 0x735E30 VA: 0x180737830
	private static void .cctor() { }

}

