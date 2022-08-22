public class RepeatingFirework : BaseFirework // TypeDefIndex: 8279
{	// Fields
	public float timeBetweenRepeats; // 0x250
	public int maxRepeats; // 0x254
	public SoundPlayer launchSound; // 0x258

	// Methods

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x954770 Offset: 0x952D70 VA: 0x180954770
	public void RPCFire(BaseEntity.RPCMessage msg) { }

	// RVA: 0x954300 Offset: 0x952900 VA: 0x180954300 Slot: 145
	public virtual void Fire() { }

	// RVA: 0x954330 Offset: 0x952930 VA: 0x180954330 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x954790 Offset: 0x952D90 VA: 0x180954790
	public void .ctor() { }

}

