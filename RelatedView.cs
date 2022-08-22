internal sealed class RelatedView : DataView, IFilter // TypeDefIndex: 4293
{	// Fields
	private readonly Nullable<DataKey> _parentKey; // 0xB0
	private readonly DataKey _childKey; // 0xC0
	private readonly DataRowView _parentRowView; // 0xC8
	private readonly object[] _filterValues; // 0xD0

	// Methods

	// RVA: 0xE95F00 Offset: 0xE94500 VA: 0x180E95F00
	public void .ctor(DataColumn[] columns, object[] values) { }

	// RVA: 0xE95DB0 Offset: 0xE943B0 VA: 0x180E95DB0
	public void .ctor(DataRowView parentRowView, DataKey parentKey, DataColumn[] childKeyColumns) { }

	// RVA: 0xE95B80 Offset: 0xE94180 VA: 0x180E95B80
	private object[] GetParentValues() { }

	// RVA: 0xE95C20 Offset: 0xE94220 VA: 0x180E95C20 Slot: 32
	public bool Invoke(DataRow row, DataRowVersion version) { }

	// RVA: 0x4B3FF0 Offset: 0x4B25F0 VA: 0x1804B3FF0 Slot: 26
	internal override IFilter GetFilter() { }

	// RVA: 0xE95B10 Offset: 0xE94110 VA: 0x180E95B10 Slot: 25
	public override DataRowView AddNew() { }

	// RVA: 0xE95D80 Offset: 0xE94380 VA: 0x180E95D80 Slot: 29
	internal override void SetIndex(string newSort, DataViewRowState newRowStates, IFilter newRowFilter) { }

}

