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

	// RVA: 0x22977A0 Offset: 0x2295DA0 VA: 0x1822977A0
	private ContactPoint[] GetContacts_Internal() { }

	// RVA: 0x181DC90 Offset: 0x181C290 VA: 0x18181DC90
	public Rigidbody get_rigidbody() { }

	// RVA: 0xEB5D90 Offset: 0xEB4390 VA: 0x180EB5D90
	public Collider get_collider() { }

	// RVA: 0x22977C0 Offset: 0x2295DC0 VA: 0x1822977C0
	public Transform get_transform() { }

	// RVA: 0x22977B0 Offset: 0x2295DB0 VA: 0x1822977B0
	public int get_contactCount() { }

	// RVA: 0x2297670 Offset: 0x2295C70 VA: 0x182297670
	public ContactPoint GetContact(int index) { }

}

