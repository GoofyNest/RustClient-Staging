public class RepeatingFirework : BaseFirework // TypeDefIndex: 8279
{	public float timeBetweenRepeats; // 0x250
	public int maxRepeats; // 0x254
	public SoundPlayer launchSound; // 0x258


	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	public void RPCFire(BaseEntity.RPCMessage msg) { }

	public virtual void Fire() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public void .ctor() { }

}

