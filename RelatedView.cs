internal sealed class RelatedView : DataView, IFilter // TypeDefIndex: 4293
{	// Fields
	private readonly Nullable<DataKey> _parentKey; // 0xB0
	private readonly DataKey _childKey; // 0xC0
	private readonly DataRowView _parentRowView; // 0xC8
	private readonly object[] _filterValues; // 0xD0

	// Methods

	// RVA: 0xE969B0 Offset: 0xE94FB0 VA: 0x180E969B0
	public void .ctor(DataColumn[] columns, object[] values) { }

	// RVA: 0xE96860 Offset: 0xE94E60 VA: 0x180E96860
	public void .ctor(DataRowView parentRowView, DataKey parentKey, DataColumn[] childKeyColumns) { }

	// RVA: 0xE96630 Offset: 0xE94C30 VA: 0x180E96630
	private object[] GetParentValues() { }

	// RVA: 0xE966D0 Offset: 0xE94CD0 VA: 0x180E966D0 Slot: 32
	public bool Invoke(DataRow row, DataRowVersion version) { }

	// RVA: 0x4B3F80 Offset: 0x4B2580 VA: 0x1804B3F80 Slot: 26
	internal override IFilter GetFilter() { }

	// RVA: 0xE965C0 Offset: 0xE94BC0 VA: 0x180E965C0 Slot: 25
	public override DataRowView AddNew() { }

	// RVA: 0xE96830 Offset: 0xE94E30 VA: 0x180E96830 Slot: 29
	internal override void SetIndex(string newSort, DataViewRowState newRowStates, IFilter newRowFilter) { }

}

