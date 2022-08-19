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

	// RVA: 0x4BC5D0 Offset: 0x4BABD0 VA: 0x1804BC5D0 Slot: 4
	protected virtual IDbCommand get_BaseCommand() { }

	// RVA: 0x4BC630 Offset: 0x4BAC30 VA: 0x1804BC630 Slot: 5
	protected virtual void set_BaseCommand(IDbCommand value) { }

	// RVA: 0x4D3FB0 Offset: 0x4D25B0 VA: 0x1804D3FB0
	public IDbCommand get_Command() { }

	// RVA: 0x17D6970 Offset: 0x17D4F70 VA: 0x1817D6970
	public void set_Command(IDbCommand value) { }

	// RVA: 0x7EE340 Offset: 0x7EC940 VA: 0x1807EE340
	public void set_Errors(Exception value) { }

	// RVA: 0x4A6050 Offset: 0x4A4650 VA: 0x1804A6050
	public DataRow get_Row() { }

	// RVA: 0x4C1470 Offset: 0x4BFA70 VA: 0x1804C1470
	public StatementType get_StatementType() { }

	// RVA: 0x6BB940 Offset: 0x6B9F40 VA: 0x1806BB940
	public UpdateStatus get_Status() { }

	// RVA: 0x17D6990 Offset: 0x17D4F90 VA: 0x1817D6990
	public void set_Status(UpdateStatus value) { }

	// RVA: 0x49AF70 Offset: 0x499570 VA: 0x18049AF70
	public DataTableMapping get_TableMapping() { }

}

