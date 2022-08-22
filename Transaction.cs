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

	// RVA: 0x230E420 Offset: 0x230CA20 VA: 0x18230E420
	internal List<IEnlistmentNotification> get_Volatiles() { }

	// RVA: 0x230E390 Offset: 0x230C990 VA: 0x18230E390
	internal List<ISinglePhaseNotification> get_Durables() { }

	// RVA: 0x230E170 Offset: 0x230C770 VA: 0x18230E170
	internal void .ctor() { }

	[MonoTODOAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x230E120 Offset: 0x230C720 VA: 0x18230E120 Slot: 5
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x230E350 Offset: 0x230C950 VA: 0x18230E350
	public static Transaction get_Current() { }

	// RVA: 0x230E310 Offset: 0x230C910 VA: 0x18230E310
	internal static Transaction get_CurrentInternal() { }

	// RVA: 0x230E400 Offset: 0x230CA00 VA: 0x18230E400
	public TransactionInformation get_TransactionInformation() { }

	// RVA: 0x230D920 Offset: 0x230BF20 VA: 0x18230D920 Slot: 4
	public void Dispose() { }

	[MonoTODOAttribute] // RVA: 0xA8050 Offset: 0xA7450 VA: 0x1800A8050
	// RVA: 0x230D970 Offset: 0x230BF70 VA: 0x18230D970
	public Enlistment EnlistVolatile(IEnlistmentNotification enlistmentNotification, EnlistmentOptions enlistmentOptions) { }

	// RVA: 0x230D970 Offset: 0x230BF70 VA: 0x18230D970
	private Enlistment EnlistVolatileInternal(IEnlistmentNotification notification, EnlistmentOptions options) { }

	// RVA: 0x230DB90 Offset: 0x230C190 VA: 0x18230DB90 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x230DB60 Offset: 0x230C160 VA: 0x18230DB60
	private bool Equals(Transaction t) { }

	// RVA: 0x230E490 Offset: 0x230CA90 VA: 0x18230E490
	public static bool op_Equality(Transaction x, Transaction y) { }

	// RVA: 0x230E4C0 Offset: 0x230CAC0 VA: 0x18230E4C0
	public static bool op_Inequality(Transaction x, Transaction y) { }

	// RVA: 0x230DD00 Offset: 0x230C300 VA: 0x18230DD00 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x230DDB0 Offset: 0x230C3B0 VA: 0x18230DDB0
	public void Rollback() { }

	// RVA: 0x230DD70 Offset: 0x230C370 VA: 0x18230DD70
	public void Rollback(Exception e) { }

	// RVA: 0x230DDE0 Offset: 0x230C3E0 VA: 0x18230DDE0
	internal void Rollback(Exception ex, object abortingEnlisted) { }

	// RVA: 0x230E4F0 Offset: 0x230CAF0 VA: 0x18230E4F0
	private void set_Aborted(bool value) { }

	// RVA: 0x5C33E0 Offset: 0x5C19E0 VA: 0x1805C33E0
	internal TransactionScope get_Scope() { }

	// RVA: 0x230DC40 Offset: 0x230C240 VA: 0x18230DC40
	private void FireCompleted() { }

	// RVA: 0x230DA50 Offset: 0x230C050 VA: 0x18230DA50
	private static void EnsureIncompleteCurrentScope() { }

}

