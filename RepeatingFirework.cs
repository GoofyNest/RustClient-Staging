public class RepeatingFirework : BaseFirework // TypeDefIndex: 8279
{	// Fields
	public float timeBetweenRepeats; // 0x250
	public int maxRepeats; // 0x254
	public SoundPlayer launchSound; // 0x258

	// Methods

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x954270 Offset: 0x952870 VA: 0x180954270
	public void RPCFire(BaseEntity.RPCMessage msg) { }

	// RVA: 0x953E00 Offset: 0x952400 VA: 0x180953E00 Slot: 145
	public virtual void Fire() { }

	// RVA: 0x953E30 Offset: 0x952430 VA: 0x180953E30 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x954290 Offset: 0x952890 VA: 0x180954290
	public void .ctor() { }

}

