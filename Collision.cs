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

	// RVA: 0x22974E0 Offset: 0x2295AE0 VA: 0x1822974E0
	private ContactPoint[] GetContacts_Internal() { }

	// RVA: 0x181D9D0 Offset: 0x181BFD0 VA: 0x18181D9D0
	public Rigidbody get_rigidbody() { }

	// RVA: 0xEB5AD0 Offset: 0xEB40D0 VA: 0x180EB5AD0
	public Collider get_collider() { }

	// RVA: 0x2297500 Offset: 0x2295B00 VA: 0x182297500
	public Transform get_transform() { }

	// RVA: 0x22974F0 Offset: 0x2295AF0 VA: 0x1822974F0
	public int get_contactCount() { }

	// RVA: 0x22973B0 Offset: 0x22959B0 VA: 0x1822973B0
	public ContactPoint GetContact(int index) { }

}

