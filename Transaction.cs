public class Transaction : IDisposable, ISerializable // TypeDefIndex: 3983
{	// Fields
	[ThreadStaticAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private static Transaction ambient; // 0x80000000
	private IsolationLevel level; // 0x10
	private TransactionInformation info; // 0x18
	private ArrayList dependents; // 0x20
	private List<IEnlistmentNotification> volatiles; // 0x28
	private List<ISinglePhaseNotification> durables; // 0x30
	private IPromotableSinglePhaseNotification pspe; // 0x38
	private bool aborted; // 0x40
	private TransactionScope scope; // 0x48
	private Exception innerException; // 0x50
	private Guid tag; // 0x58
	[CompilerGeneratedAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	private TransactionCompletedEventHandler TransactionCompleted; // 0x68

	// Properties
	internal List<IEnlistmentNotification> Volatiles { get; }
	internal List<ISinglePhaseNotification> Durables { get; }
	public static Transaction Current { get; }
	internal static Transaction CurrentInternal { get; }
	public TransactionInformation TransactionInformation { get; }
	private bool Aborted { set; }
	internal TransactionScope Scope { get; }

	// Methods

	// RVA: 0x230DB00 Offset: 0x230C100 VA: 0x18230DB00
	internal List<IEnlistmentNotification> get_Volatiles() { }

	// RVA: 0x230DA70 Offset: 0x230C070 VA: 0x18230DA70
	internal List<ISinglePhaseNotification> get_Durables() { }

	// RVA: 0x230D850 Offset: 0x230BE50 VA: 0x18230D850
	internal void .ctor() { }

	[MonoTODOAttribute] // RVA: 0x6F3A0 Offset: 0x6E7A0 VA: 0x18006F3A0
	// RVA: 0x230D800 Offset: 0x230BE00 VA: 0x18230D800 Slot: 5
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x230DA30 Offset: 0x230C030 VA: 0x18230DA30
	public static Transaction get_Current() { }

	// RVA: 0x230D9F0 Offset: 0x230BFF0 VA: 0x18230D9F0
	internal static Transaction get_CurrentInternal() { }

	// RVA: 0x230DAE0 Offset: 0x230C0E0 VA: 0x18230DAE0
	public TransactionInformation get_TransactionInformation() { }

	// RVA: 0x230D000 Offset: 0x230B600 VA: 0x18230D000 Slot: 4
	public void Dispose() { }

	[MonoTODOAttribute] // RVA: 0xA7FC0 Offset: 0xA73C0 VA: 0x1800A7FC0
	// RVA: 0x230D050 Offset: 0x230B650 VA: 0x18230D050
	public Enlistment EnlistVolatile(IEnlistmentNotification enlistmentNotification, EnlistmentOptions enlistmentOptions) { }

	// RVA: 0x230D050 Offset: 0x230B650 VA: 0x18230D050
	private Enlistment EnlistVolatileInternal(IEnlistmentNotification notification, EnlistmentOptions options) { }

	// RVA: 0x230D270 Offset: 0x230B870 VA: 0x18230D270 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x230D240 Offset: 0x230B840 VA: 0x18230D240
	private bool Equals(Transaction t) { }

	// RVA: 0x230DB70 Offset: 0x230C170 VA: 0x18230DB70
	public static bool op_Equality(Transaction x, Transaction y) { }

	// RVA: 0x230DBA0 Offset: 0x230C1A0 VA: 0x18230DBA0
	public static bool op_Inequality(Transaction x, Transaction y) { }

	// RVA: 0x230D3E0 Offset: 0x230B9E0 VA: 0x18230D3E0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x230D490 Offset: 0x230BA90 VA: 0x18230D490
	public void Rollback() { }

	// RVA: 0x230D450 Offset: 0x230BA50 VA: 0x18230D450
	public void Rollback(Exception e) { }

	// RVA: 0x230D4C0 Offset: 0x230BAC0 VA: 0x18230D4C0
	internal void Rollback(Exception ex, object abortingEnlisted) { }

	// RVA: 0x230DBD0 Offset: 0x230C1D0 VA: 0x18230DBD0
	private void set_Aborted(bool value) { }

	// RVA: 0x5C3450 Offset: 0x5C1A50 VA: 0x1805C3450
	internal TransactionScope get_Scope() { }

	// RVA: 0x230D320 Offset: 0x230B920 VA: 0x18230D320
	private void FireCompleted() { }

	// RVA: 0x230D130 Offset: 0x230B730 VA: 0x18230D130
	private static void EnsureIncompleteCurrentScope() { }

}

