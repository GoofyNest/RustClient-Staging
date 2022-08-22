public class RowUpdatingEventArgs : EventArgs // TypeDefIndex: 4409
{	// Fields
	private IDbCommand _command; // 0x10
	private StatementType _statementType; // 0x18
	private DataTableMapping _tableMapping; // 0x20
	private Exception _errors; // 0x28
	private DataRow _dataRow; // 0x30
	private UpdateStatus _status; // 0x38

	// Properties
	protected virtual IDbCommand BaseCommand { get; set; }
	public IDbCommand Command { get; set; }
	public Exception Errors { set; }
	public DataRow Row { get; }
	public StatementType StatementType { get; }
	public UpdateStatus Status { get; set; }
	public DataTableMapping TableMapping { get; }

	// Methods

	// RVA: 0x4BC560 Offset: 0x4BAB60 VA: 0x1804BC560 Slot: 4
	protected virtual IDbCommand get_BaseCommand() { }

	// RVA: 0x4BC5C0 Offset: 0x4BABC0 VA: 0x1804BC5C0 Slot: 5
	protected virtual void set_BaseCommand(IDbCommand value) { }

	// RVA: 0x4D3F40 Offset: 0x4D2540 VA: 0x1804D3F40
	public IDbCommand get_Command() { }

	// RVA: 0x17D4780 Offset: 0x17D2D80 VA: 0x1817D4780
	public void set_Command(IDbCommand value) { }

	// RVA: 0x7EE9E0 Offset: 0x7ECFE0 VA: 0x1807EE9E0
	public void set_Errors(Exception value) { }

	// RVA: 0x4A5FE0 Offset: 0x4A45E0 VA: 0x1804A5FE0
	public DataRow get_Row() { }

	// RVA: 0x4C1400 Offset: 0x4BFA00 VA: 0x1804C1400
	public StatementType get_StatementType() { }

	// RVA: 0x6BB9E0 Offset: 0x6B9FE0 VA: 0x1806BB9E0
	public UpdateStatus get_Status() { }

	// RVA: 0x17D47A0 Offset: 0x17D2DA0 VA: 0x1817D47A0
	public void set_Status(UpdateStatus value) { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public DataTableMapping get_TableMapping() { }

}

