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

	// RVA: 0x12AAC40 Offset: 0x12A9240 VA: 0x1812AAC40
	public void .ctor(long containerID, FieldInfo member, int[] parentIndex) { }

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560
	public long get_ContainerID() { }

	// RVA: 0x49A880 Offset: 0x498E80 VA: 0x18049A880
	public FieldInfo get_ParentField() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public int[] get_ParentIndex() { }

}

