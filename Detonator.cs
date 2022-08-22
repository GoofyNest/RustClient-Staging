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

	// RVA: 0x97D730 Offset: 0x97BD30 VA: 0x18097D730 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x97D270 Offset: 0x97B870 VA: 0x18097D270 Slot: 159
	public virtual bool IsFullyDeployed() { }

	// RVA: 0x97D9D0 Offset: 0x97BFD0 VA: 0x18097D9D0
	protected void ProcessInputTime() { }

	// RVA: 0x97D2F0 Offset: 0x97B8F0 VA: 0x18097D2F0 Slot: 140
	public override void OnDeploy() { }

	// RVA: 0x97D310 Offset: 0x97B910 VA: 0x18097D310 Slot: 143
	public override void OnHolstered() { }

	// RVA: 0x97D8F0 Offset: 0x97BEF0 VA: 0x18097D8F0
	private void OpenConfigPanel() { }

	// RVA: 0x97D370 Offset: 0x97B970 VA: 0x18097D370 Slot: 138
	public override void OnInput() { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	public void BeginSounds() { }

	// RVA: 0x97D820 Offset: 0x97BE20 VA: 0x18097D820 Slot: 144
	public override void OnViewmodelEvent(string name) { }

	// RVA: 0x97D290 Offset: 0x97B890 VA: 0x18097D290 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x97D260 Offset: 0x97B860 VA: 0x18097D260 Slot: 158
	public int GetFrequency() { }

	// RVA: 0x97D210 Offset: 0x97B810 VA: 0x18097D210 Slot: 157
	public void ClientSetFrequency(int newFreq) { }

	// RVA: 0x97DA10 Offset: 0x97C010 VA: 0x18097DA10
	public void .ctor() { }

}

