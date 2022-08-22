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

	// RVA: 0xAACBC0 Offset: 0xAAB1C0 VA: 0x180AACBC0
	public Animator get_animator() { }

	// RVA: 0xAAC980 Offset: 0xAAAF80 VA: 0x180AAC980
	private void DoorOpenStart() { }

	// RVA: 0xAAC740 Offset: 0xAAAD40 VA: 0x180AAC740
	private void DoorOpenEnd() { }

	// RVA: 0xAAC500 Offset: 0xAAAB00 VA: 0x180AAC500
	private void DoorCloseStart() { }

	// RVA: 0xAAC2C0 Offset: 0xAAA8C0 VA: 0x180AAC2C0
	private void DoorCloseEnd() { }

	// RVA: 0x2FA1F0 Offset: 0x2F87F0 VA: 0x1802FA1F0
	public void .ctor() { }

}

