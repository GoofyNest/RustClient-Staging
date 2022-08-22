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

	// RVA: 0x12294A0 Offset: 0x1227AA0 VA: 0x1812294A0
	public void .ctor(DataSet dataSet) { }

	// RVA: 0x1229210 Offset: 0x1227810 VA: 0x181229210
	public bool GetNext() { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public Constraint GetConstraint() { }

	// RVA: 0x4D5250 Offset: 0x4D3850 VA: 0x1804D5250 Slot: 4
	protected virtual bool IsValidCandidate(Constraint constraint) { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	protected Constraint get_CurrentObject() { }

}

