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

	// RVA: 0x230D940 Offset: 0x230BF40 VA: 0x18230D940
	internal List<IEnlistmentNotification> get_Volatiles() { }

	// RVA: 0x230D8B0 Offset: 0x230BEB0 VA: 0x18230D8B0
	internal List<ISinglePhaseNotification> get_Durables() { }

	// RVA: 0x230D690 Offset: 0x230BC90 VA: 0x18230D690
	internal void .ctor() { }

	[MonoTODOAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x230D640 Offset: 0x230BC40 VA: 0x18230D640 Slot: 5
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x230D870 Offset: 0x230BE70 VA: 0x18230D870
	public static Transaction get_Current() { }

	// RVA: 0x230D830 Offset: 0x230BE30 VA: 0x18230D830
	internal static Transaction get_CurrentInternal() { }

	// RVA: 0x230D920 Offset: 0x230BF20 VA: 0x18230D920
	public TransactionInformation get_TransactionInformation() { }

	// RVA: 0x230CE40 Offset: 0x230B440 VA: 0x18230CE40 Slot: 4
	public void Dispose() { }

	[MonoTODOAttribute] // RVA: 0xA8050 Offset: 0xA7450 VA: 0x1800A8050
	// RVA: 0x230CE90 Offset: 0x230B490 VA: 0x18230CE90
	public Enlistment EnlistVolatile(IEnlistmentNotification enlistmentNotification, EnlistmentOptions enlistmentOptions) { }

	// RVA: 0x230CE90 Offset: 0x230B490 VA: 0x18230CE90
	private Enlistment EnlistVolatileInternal(IEnlistmentNotification notification, EnlistmentOptions options) { }

	// RVA: 0x230D0B0 Offset: 0x230B6B0 VA: 0x18230D0B0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x230D080 Offset: 0x230B680 VA: 0x18230D080
	private bool Equals(Transaction t) { }

	// RVA: 0x230D9B0 Offset: 0x230BFB0 VA: 0x18230D9B0
	public static bool op_Equality(Transaction x, Transaction y) { }

	// RVA: 0x230D9E0 Offset: 0x230BFE0 VA: 0x18230D9E0
	public static bool op_Inequality(Transaction x, Transaction y) { }

	// RVA: 0x230D220 Offset: 0x230B820 VA: 0x18230D220 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x230D2D0 Offset: 0x230B8D0 VA: 0x18230D2D0
	public void Rollback() { }

	// RVA: 0x230D290 Offset: 0x230B890 VA: 0x18230D290
	public void Rollback(Exception e) { }

	// RVA: 0x230D300 Offset: 0x230B900 VA: 0x18230D300
	internal void Rollback(Exception ex, object abortingEnlisted) { }

	// RVA: 0x230DA10 Offset: 0x230C010 VA: 0x18230DA10
	private void set_Aborted(bool value) { }

	// RVA: 0x5C3450 Offset: 0x5C1A50 VA: 0x1805C3450
	internal TransactionScope get_Scope() { }

	// RVA: 0x230D160 Offset: 0x230B760 VA: 0x18230D160
	private void FireCompleted() { }

	// RVA: 0x230CF70 Offset: 0x230B570 VA: 0x18230CF70
	private static void EnsureIncompleteCurrentScope() { }

}

