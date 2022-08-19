public class DoorAnimEvents : MonoBehaviour, IClientComponent // TypeDefIndex: 9325
{	// Fields
	public GameObjectRef openStart; // 0x18
	public GameObjectRef openEnd; // 0x20
	public GameObjectRef closeStart; // 0x28
	public GameObjectRef closeEnd; // 0x30
	public GameObject soundTarget; // 0x38
	public bool checkAnimSpeed; // 0x40

	// Properties
	public Animator animator { get; }

	// Methods

	// RVA: 0xAAC430 Offset: 0xAAAA30 VA: 0x180AAC430
	public Animator get_animator() { }

	// RVA: 0xAAC1F0 Offset: 0xAAA7F0 VA: 0x180AAC1F0
	private void DoorOpenStart() { }

	// RVA: 0xAABFB0 Offset: 0xAAA5B0 VA: 0x180AABFB0
	private void DoorOpenEnd() { }

	// RVA: 0xAABD70 Offset: 0xAAA370 VA: 0x180AABD70
	private void DoorCloseStart() { }

	// RVA: 0xAABB30 Offset: 0xAAA130 VA: 0x180AABB30
	private void DoorCloseEnd() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

