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

	// RVA: 0x78FF10 Offset: 0x78E510 VA: 0x18078FF10 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	// RVA: 0x738180 Offset: 0x736780 VA: 0x180738180
	public bool IsTriggered() { }

	// RVA: 0x78FED0 Offset: 0x78E4D0 VA: 0x18078FED0
	public Vector3 GetEyePosition() { }

	// RVA: 0x7905C0 Offset: 0x78EBC0 VA: 0x1807905C0
	public void Update() { }

	// RVA: 0x78FE80 Offset: 0x78E480 VA: 0x18078FE80 Slot: 134
	public override bool CanPickup(BasePlayer player) { }

	// RVA: 0x78FEC0 Offset: 0x78E4C0 VA: 0x18078FEC0
	public void ClientThink() { }

	[BaseEntity.RPC_Client] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x78FE20 Offset: 0x78E420 VA: 0x18078FE20
	public void CLIENT_ReceiveAimDir(BaseEntity.RPCMessage rpc) { }

	// RVA: 0x790370 Offset: 0x78E970 VA: 0x180790370
	public void UpdateAiming() { }

	// RVA: 0x7905F0 Offset: 0x78EBF0 VA: 0x1807905F0
	public void .ctor() { }

}

