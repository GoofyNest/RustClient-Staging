public class Collision // TypeDefIndex: 3915
{	// Fields
	internal Vector3 m_Impulse; // 0x10
	internal Vector3 m_RelativeVelocity; // 0x1C
	internal Rigidbody m_Rigidbody; // 0x28
	internal Collider m_Collider; // 0x30
	internal int m_ContactCount; // 0x38
	internal ContactPoint[] m_ReusedContacts; // 0x40
	internal ContactPoint[] m_LegacyContacts; // 0x48

	// Properties
	public Rigidbody rigidbody { get; }
	public Collider collider { get; }
	public Transform transform { get; }
	public int contactCount { get; }

	// Methods

	// RVA: 0x2297FC0 Offset: 0x22965C0 VA: 0x182297FC0
	private ContactPoint[] GetContacts_Internal() { }

	// RVA: 0x180B0D0 Offset: 0x18096D0 VA: 0x18180B0D0
	public Rigidbody get_rigidbody() { }

	// RVA: 0xEB6840 Offset: 0xEB4E40 VA: 0x180EB6840
	public Collider get_collider() { }

	// RVA: 0x2297FE0 Offset: 0x22965E0 VA: 0x182297FE0
	public Transform get_transform() { }

	// RVA: 0x2297FD0 Offset: 0x22965D0 VA: 0x182297FD0
	public int get_contactCount() { }

	// RVA: 0x2297E90 Offset: 0x2296490 VA: 0x182297E90
	public ContactPoint GetContact(int index) { }

}

