internal sealed class RelatedView : DataView, IFilter // TypeDefIndex: 4293
{	// Fields
	private readonly Nullable<DataKey> _parentKey; // 0xB0
	private readonly DataKey _childKey; // 0xC0
	private readonly DataRowView _parentRowView; // 0xC8
	private readonly object[] _filterValues; // 0xD0

	// Methods

	// RVA: 0xE95C40 Offset: 0xE94240 VA: 0x180E95C40
	public void .ctor(DataColumn[] columns, object[] values) { }

	// RVA: 0xE95AF0 Offset: 0xE940F0 VA: 0x180E95AF0
	public void .ctor(DataRowView parentRowView, DataKey parentKey, DataColumn[] childKeyColumns) { }

	// RVA: 0xE958C0 Offset: 0xE93EC0 VA: 0x180E958C0
	private object[] GetParentValues() { }

	// RVA: 0xE95960 Offset: 0xE93F60 VA: 0x180E95960 Slot: 32
	public bool Invoke(DataRow row, DataRowVersion version) { }

	// RVA: 0x4B3FF0 Offset: 0x4B25F0 VA: 0x1804B3FF0 Slot: 26
	internal override IFilter GetFilter() { }

	// RVA: 0xE95850 Offset: 0xE93E50 VA: 0x180E95850 Slot: 25
	public override DataRowView AddNew() { }

	// RVA: 0xE95AC0 Offset: 0xE940C0 VA: 0x180E95AC0 Slot: 29
	internal override void SetIndex(string newSort, DataViewRowState newRowStates, IFilter newRowFilter) { }

}

