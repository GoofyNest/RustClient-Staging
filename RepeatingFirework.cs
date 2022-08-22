public class RepeatingFirework : BaseFirework // TypeDefIndex: 8279
{	// Fields
	public float timeBetweenRepeats; // 0x250
	public int maxRepeats; // 0x254
	public SoundPlayer launchSound; // 0x258

	// Methods

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x954160 Offset: 0x952760 VA: 0x180954160
	public void RPCFire(BaseEntity.RPCMessage msg) { }

	// RVA: 0x953CF0 Offset: 0x9522F0 VA: 0x180953CF0 Slot: 145
	public virtual void Fire() { }

	// RVA: 0x953D20 Offset: 0x952320 VA: 0x180953D20 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x954180 Offset: 0x952780 VA: 0x180954180
	public void .ctor() { }

}

