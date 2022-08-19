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

	// RVA: 0x97D620 Offset: 0x97BC20 VA: 0x18097D620 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x97D160 Offset: 0x97B760 VA: 0x18097D160 Slot: 159
	public virtual bool IsFullyDeployed() { }

	// RVA: 0x97D8C0 Offset: 0x97BEC0 VA: 0x18097D8C0
	protected void ProcessInputTime() { }

	// RVA: 0x97D1E0 Offset: 0x97B7E0 VA: 0x18097D1E0 Slot: 140
	public override void OnDeploy() { }

	// RVA: 0x97D200 Offset: 0x97B800 VA: 0x18097D200 Slot: 143
	public override void OnHolstered() { }

	// RVA: 0x97D7E0 Offset: 0x97BDE0 VA: 0x18097D7E0
	private void OpenConfigPanel() { }

	// RVA: 0x97D260 Offset: 0x97B860 VA: 0x18097D260 Slot: 138
	public override void OnInput() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void BeginSounds() { }

	// RVA: 0x97D710 Offset: 0x97BD10 VA: 0x18097D710 Slot: 144
	public override void OnViewmodelEvent(string name) { }

	// RVA: 0x97D180 Offset: 0x97B780 VA: 0x18097D180 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x97D150 Offset: 0x97B750 VA: 0x18097D150 Slot: 158
	public int GetFrequency() { }

	// RVA: 0x97D100 Offset: 0x97B700 VA: 0x18097D100 Slot: 157
	public void ClientSetFrequency(int newFreq) { }

	// RVA: 0x97D900 Offset: 0x97BF00 VA: 0x18097D900
	public void .ctor() { }

}

