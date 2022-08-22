public class Transaction : IDisposable, ISerializable // TypeDefIndex: 3983
{	// Fields
	[ThreadStaticAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
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
	[CompilerGeneratedAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
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

	// RVA: 0x230DC00 Offset: 0x230C200 VA: 0x18230DC00
	internal List<IEnlistmentNotification> get_Volatiles() { }

	// RVA: 0x230DB70 Offset: 0x230C170 VA: 0x18230DB70
	internal List<ISinglePhaseNotification> get_Durables() { }

	// RVA: 0x230D950 Offset: 0x230BF50 VA: 0x18230D950
	internal void .ctor() { }

	[MonoTODOAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x230D900 Offset: 0x230BF00 VA: 0x18230D900 Slot: 5
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x230DB30 Offset: 0x230C130 VA: 0x18230DB30
	public static Transaction get_Current() { }

	// RVA: 0x230DAF0 Offset: 0x230C0F0 VA: 0x18230DAF0
	internal static Transaction get_CurrentInternal() { }

	// RVA: 0x230DBE0 Offset: 0x230C1E0 VA: 0x18230DBE0
	public TransactionInformation get_TransactionInformation() { }

	// RVA: 0x230D100 Offset: 0x230B700 VA: 0x18230D100 Slot: 4
	public void Dispose() { }

	[MonoTODOAttribute] // RVA: 0xA8050 Offset: 0xA7450 VA: 0x1800A8050
	// RVA: 0x230D150 Offset: 0x230B750 VA: 0x18230D150
	public Enlistment EnlistVolatile(IEnlistmentNotification enlistmentNotification, EnlistmentOptions enlistmentOptions) { }

	// RVA: 0x230D150 Offset: 0x230B750 VA: 0x18230D150
	private Enlistment EnlistVolatileInternal(IEnlistmentNotification notification, EnlistmentOptions options) { }

	// RVA: 0x230D370 Offset: 0x230B970 VA: 0x18230D370 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x230D340 Offset: 0x230B940 VA: 0x18230D340
	private bool Equals(Transaction t) { }

	// RVA: 0x230DC70 Offset: 0x230C270 VA: 0x18230DC70
	public static bool op_Equality(Transaction x, Transaction y) { }

	// RVA: 0x230DCA0 Offset: 0x230C2A0 VA: 0x18230DCA0
	public static bool op_Inequality(Transaction x, Transaction y) { }

	// RVA: 0x230D4E0 Offset: 0x230BAE0 VA: 0x18230D4E0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x230D590 Offset: 0x230BB90 VA: 0x18230D590
	public void Rollback() { }

	// RVA: 0x230D550 Offset: 0x230BB50 VA: 0x18230D550
	public void Rollback(Exception e) { }

	// RVA: 0x230D5C0 Offset: 0x230BBC0 VA: 0x18230D5C0
	internal void Rollback(Exception ex, object abortingEnlisted) { }

	// RVA: 0x230DCD0 Offset: 0x230C2D0 VA: 0x18230DCD0
	private void set_Aborted(bool value) { }

	// RVA: 0x5C3450 Offset: 0x5C1A50 VA: 0x1805C3450
	internal TransactionScope get_Scope() { }

	// RVA: 0x230D420 Offset: 0x230BA20 VA: 0x18230D420
	private void FireCompleted() { }

	// RVA: 0x230D230 Offset: 0x230B830 VA: 0x18230D230
	private static void EnsureIncompleteCurrentScope() { }

}

