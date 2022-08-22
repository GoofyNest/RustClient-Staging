public class Context // TypeDefIndex: 1171
{	// Fields
	private int domain_id; // 0x10
	private int context_id; // 0x14
	private UIntPtr static_data; // 0x18
	private UIntPtr data; // 0x20
	[ContextStaticAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	private static object[] local_slots; // 0x0
	private static IMessageSink default_server_context_sink; // 0x8
	private IMessageSink server_context_sink_chain; // 0x28
	private IMessageSink client_context_sink_chain; // 0x30
	private List<IContextProperty> context_properties; // 0x38
	private static int global_count; // 0x10
	private LocalDataStoreHolder _localDataStore; // 0x40
	private static LocalDataStoreMgr _localDataStoreMgr; // 0x18
	private static DynamicPropertyCollection global_dynamic_properties; // 0x20
	private DynamicPropertyCollection context_dynamic_properties; // 0x48
	private ContextCallbackObject callback_object; // 0x50

	// Properties
	public static Context DefaultContext { get; }
	public virtual int ContextID { get; }
	public virtual IContextProperty[] ContextProperties { get; }
	internal bool IsDefaultContext { get; }
	internal bool NeedsContextSink { get; }
	internal static bool HasGlobalDynamicSinks { get; }
	internal bool HasDynamicSinks { get; }
	internal bool HasExitSinks { get; }
	private LocalDataStore MyLocalStore { get; }

	// Methods

	// RVA: 0xD730F0 Offset: 0xD716F0 VA: 0x180D730F0
	private static void RegisterContext(Context ctx) { }

	// RVA: 0xD730F0 Offset: 0xD716F0 VA: 0x180D730F0
	private static void ReleaseContext(Context ctx) { }

	// RVA: 0x1475E50 Offset: 0x1474450 VA: 0x181475E50
	public void .ctor() { }

	// RVA: 0x1474C40 Offset: 0x1473240 VA: 0x181474C40 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1475F30 Offset: 0x1474530 VA: 0x181475F30
	public static Context get_DefaultContext() { }

	// RVA: 0x57C9D0 Offset: 0x57AFD0 VA: 0x18057C9D0 Slot: 4
	public virtual int get_ContextID() { }

	// RVA: 0x1475ED0 Offset: 0x14744D0 VA: 0x181475ED0 Slot: 5
	public virtual IContextProperty[] get_ContextProperties() { }

	// RVA: 0x1476100 Offset: 0x1474700 VA: 0x181476100
	internal bool get_IsDefaultContext() { }

	// RVA: 0x14762B0 Offset: 0x14748B0 VA: 0x1814762B0
	internal bool get_NeedsContextSink() { }

	// RVA: 0x1475800 Offset: 0x1473E00 VA: 0x181475800
	public static bool RegisterDynamicProperty(IDynamicProperty prop, ContextBoundObject obj, Context ctx) { }

	// RVA: 0x1475BF0 Offset: 0x14741F0 VA: 0x181475BF0
	public static bool UnregisterDynamicProperty(string name, ContextBoundObject obj, Context ctx) { }

	// RVA: 0x14750E0 Offset: 0x14736E0 VA: 0x1814750E0
	private static DynamicPropertyCollection GetDynamicPropertyCollection(ContextBoundObject obj, Context ctx) { }

	// RVA: 0x14756C0 Offset: 0x1473CC0 VA: 0x1814756C0
	internal static void NotifyGlobalDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async) { }

	// RVA: 0x1476050 Offset: 0x1474650 VA: 0x181476050
	internal static bool get_HasGlobalDynamicSinks() { }

	// RVA: 0x1475630 Offset: 0x1473C30 VA: 0x181475630
	internal void NotifyDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async) { }

	// RVA: 0x1475F40 Offset: 0x1474540 VA: 0x181475F40
	internal bool get_HasDynamicSinks() { }

	// RVA: 0x1475F80 Offset: 0x1474580 VA: 0x181475F80
	internal bool get_HasExitSinks() { }

	// RVA: 0x1475310 Offset: 0x1473910 VA: 0x181475310 Slot: 6
	public virtual IContextProperty GetProperty(string name) { }

	// RVA: 0x1475A50 Offset: 0x1474050 VA: 0x181475A50 Slot: 7
	public virtual void SetProperty(IContextProperty prop) { }

	// RVA: 0x1474D90 Offset: 0x1473390 VA: 0x181474D90 Slot: 8
	public virtual void Freeze() { }

	// RVA: 0x1475B90 Offset: 0x1474190 VA: 0x181475B90 Slot: 3
	public override string ToString() { }

	// RVA: 0x1475480 Offset: 0x1473A80 VA: 0x181475480
	internal IMessageSink GetServerContextSinkChain() { }

	// RVA: 0x1474F10 Offset: 0x1473510 VA: 0x181474F10
	internal IMessageSink GetClientContextSinkChain() { }

	// RVA: 0x1474950 Offset: 0x1472F50 VA: 0x181474950
	internal IMessageSink CreateServerObjectSinkChain(MarshalByRefObject obj, bool forceInternalExecute) { }

	// RVA: 0x1474130 Offset: 0x1472730 VA: 0x181474130
	internal IMessageSink CreateEnvoySink(MarshalByRefObject serverObject) { }

	// RVA: 0x1475B80 Offset: 0x1474180 VA: 0x181475B80
	internal static Context SwitchToContext(Context newContext) { }

	// RVA: 0x14742C0 Offset: 0x14728C0 VA: 0x1814742C0
	internal static Context CreateNewContext(IConstructionCallMessage msg) { }

	// RVA: 0x1474B00 Offset: 0x1473100 VA: 0x181474B00
	public void DoCallBack(CrossContextDelegate deleg) { }

	// RVA: 0x1476110 Offset: 0x1474710 VA: 0x181476110
	private LocalDataStore get_MyLocalStore() { }

	// RVA: 0x1474040 Offset: 0x1472640 VA: 0x181474040
	public static LocalDataStoreSlot AllocateDataSlot() { }

	// RVA: 0x14740B0 Offset: 0x14726B0 VA: 0x1814740B0
	public static LocalDataStoreSlot AllocateNamedDataSlot(string name) { }

	// RVA: 0x1474D10 Offset: 0x1473310 VA: 0x181474D10
	public static void FreeNamedDataSlot(string name) { }

	// RVA: 0x1475290 Offset: 0x1473890 VA: 0x181475290
	public static LocalDataStoreSlot GetNamedDataSlot(string name) { }

	// RVA: 0x14750A0 Offset: 0x14736A0 VA: 0x1814750A0
	public static object GetData(LocalDataStoreSlot slot) { }

	// RVA: 0x1475A00 Offset: 0x1474000 VA: 0x181475A00
	public static void SetData(LocalDataStoreSlot slot, object data) { }

	// RVA: 0x1475DF0 Offset: 0x14743F0 VA: 0x181475DF0
	private static void .cctor() { }

}

