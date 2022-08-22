public class FlameTurret : StorageContainer // TypeDefIndex: 8569
{	// Fields
	public Transform upper; // 0x3D0
	public Vector3 aimDir; // 0x3D8
	public float arc; // 0x3E4
	public float triggeredDuration; // 0x3E8
	public float flameRange; // 0x3EC
	public float flameRadius; // 0x3F0
	public float fuelPerSec; // 0x3F4
	public Transform eyeTransform; // 0x3F8
	public List<DamageTypeEntry> damagePerSec; // 0x400
	public GameObjectRef triggeredEffect; // 0x408
	public GameObjectRef fireballPrefab; // 0x410
	public GameObjectRef explosionEffect; // 0x418
	public TargetTrigger trigger; // 0x420

	// Methods

	// RVA: 0x790020 Offset: 0x78E620 VA: 0x180790020 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x738290 Offset: 0x736890 VA: 0x180738290
	public bool IsTriggered() { }

	// RVA: 0x78FFE0 Offset: 0x78E5E0 VA: 0x18078FFE0
	public Vector3 GetEyePosition() { }

	// RVA: 0x7906D0 Offset: 0x78ECD0 VA: 0x1807906D0
	public void Update() { }

	// RVA: 0x78FF90 Offset: 0x78E590 VA: 0x18078FF90 Slot: 134
	public override bool CanPickup(BasePlayer player) { }

	// RVA: 0x78FFD0 Offset: 0x78E5D0 VA: 0x18078FFD0
	public void ClientThink() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x78FF30 Offset: 0x78E530 VA: 0x18078FF30
	public void CLIENT_ReceiveAimDir(BaseEntity.RPCMessage rpc) { }

	// RVA: 0x790480 Offset: 0x78EA80 VA: 0x180790480
	public void UpdateAiming() { }

	// RVA: 0x790700 Offset: 0x78ED00 VA: 0x180790700
	public void .ctor() { }

}

