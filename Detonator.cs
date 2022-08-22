public class Detonator : HeldEntity, IRFObject // TypeDefIndex: 8565
{	// Fields
	public int frequency; // 0x1F8
	private float timeSinceDeploy; // 0x1FC
	public GameObjectRef frequencyPanelPrefab; // 0x200
	public GameObjectRef attackEffect; // 0x208
	public GameObjectRef unAttackEffect; // 0x210
	private float deployDelay; // 0x218
	private bool wasAttacking; // 0x21C
	private float configProgress; // 0x220
	private float attackHeldTime; // 0x224
	private float attackReleasedTime; // 0x228

	// Methods

	// RVA: 0x97DC30 Offset: 0x97C230 VA: 0x18097DC30 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x97D770 Offset: 0x97BD70 VA: 0x18097D770 Slot: 159
	public virtual bool IsFullyDeployed() { }

	// RVA: 0x97DED0 Offset: 0x97C4D0 VA: 0x18097DED0
	protected void ProcessInputTime() { }

	// RVA: 0x97D7F0 Offset: 0x97BDF0 VA: 0x18097D7F0 Slot: 140
	public override void OnDeploy() { }

	// RVA: 0x97D810 Offset: 0x97BE10 VA: 0x18097D810 Slot: 143
	public override void OnHolstered() { }

	// RVA: 0x97DDF0 Offset: 0x97C3F0 VA: 0x18097DDF0
	private void OpenConfigPanel() { }

	// RVA: 0x97D870 Offset: 0x97BE70 VA: 0x18097D870 Slot: 138
	public override void OnInput() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void BeginSounds() { }

	// RVA: 0x97DD20 Offset: 0x97C320 VA: 0x18097DD20 Slot: 144
	public override void OnViewmodelEvent(string name) { }

	// RVA: 0x97D790 Offset: 0x97BD90 VA: 0x18097D790 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x97D760 Offset: 0x97BD60 VA: 0x18097D760 Slot: 158
	public int GetFrequency() { }

	// RVA: 0x97D710 Offset: 0x97BD10 VA: 0x18097D710 Slot: 157
	public void ClientSetFrequency(int newFreq) { }

	// RVA: 0x97DF10 Offset: 0x97C510 VA: 0x18097DF10
	public void .ctor() { }

}

