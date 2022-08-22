internal class ConstraintEnumerator // TypeDefIndex: 4177
{
// Namespace: System.Data
internal class ConstraintEnumerator // TypeDefIndex: 4177
	// Fields
	private IEnumerator _tables; // 0x10
	private IEnumerator _constraints; // 0x18
	private Constraint _currentObject; // 0x20

	// Properties
	protected Constraint CurrentObject { get; }

	// Methods

	// RVA: 0x1229B40 Offset: 0x1228140 VA: 0x181229B40
	public void .ctor(DataSet dataSet) { }

	// RVA: 0x12298B0 Offset: 0x1227EB0 VA: 0x1812298B0
	public bool GetNext() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public Constraint GetConstraint() { }

	// RVA: 0x4D51E0 Offset: 0x4D37E0 VA: 0x1804D51E0 Slot: 4
	protected virtual bool IsValidCandidate(Constraint constraint) { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	protected Constraint get_CurrentObject() { }

}

