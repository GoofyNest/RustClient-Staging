internal class ValueTypeFixupInfo // TypeDefIndex: 1064
{	// Fields
	private long m_containerID; // 0x10
	private FieldInfo m_parentField; // 0x18
	private int[] m_parentIndex; // 0x20

	// Properties
	public long ContainerID { get; }
	public FieldInfo ParentField { get; }
	public int[] ParentIndex { get; }

	// Methods

	// RVA: 0x12AA2E0 Offset: 0x12A88E0 VA: 0x1812AA2E0
	public void .ctor(long containerID, FieldInfo member, int[] parentIndex) { }

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0
	public long get_ContainerID() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public FieldInfo get_ParentField() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public int[] get_ParentIndex() { }

}

