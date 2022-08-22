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

	// RVA: 0xAAC6F0 Offset: 0xAAACF0 VA: 0x180AAC6F0
	public Animator get_animator() { }

	// RVA: 0xAAC4B0 Offset: 0xAAAAB0 VA: 0x180AAC4B0
	private void DoorOpenStart() { }

	// RVA: 0xAAC270 Offset: 0xAAA870 VA: 0x180AAC270
	private void DoorOpenEnd() { }

	// RVA: 0xAAC030 Offset: 0xAAA630 VA: 0x180AAC030
	private void DoorCloseStart() { }

	// RVA: 0xAABDF0 Offset: 0xAAA3F0 VA: 0x180AABDF0
	private void DoorCloseEnd() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

