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

	// RVA: 0xD72E30 Offset: 0xD71430 VA: 0x180D72E30
	private static void RegisterContext(Context ctx) { }

	// RVA: 0xD72E30 Offset: 0xD71430 VA: 0x180D72E30
	private static void ReleaseContext(Context ctx) { }

	// RVA: 0x1475B90 Offset: 0x1474190 VA: 0x181475B90
	public void .ctor() { }

	// RVA: 0x1474980 Offset: 0x1472F80 VA: 0x181474980 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1475C70 Offset: 0x1474270 VA: 0x181475C70
	public static Context get_DefaultContext() { }

	// RVA: 0x57C9D0 Offset: 0x57AFD0 VA: 0x18057C9D0 Slot: 4
	public virtual int get_ContextID() { }

	// RVA: 0x1475C10 Offset: 0x1474210 VA: 0x181475C10 Slot: 5
	public virtual IContextProperty[] get_ContextProperties() { }

	// RVA: 0x1475E40 Offset: 0x1474440 VA: 0x181475E40
	internal bool get_IsDefaultContext() { }

	// RVA: 0x1475FF0 Offset: 0x14745F0 VA: 0x181475FF0
	internal bool get_NeedsContextSink() { }

	// RVA: 0x1475540 Offset: 0x1473B40 VA: 0x181475540
	public static bool RegisterDynamicProperty(IDynamicProperty prop, ContextBoundObject obj, Context ctx) { }

	// RVA: 0x1475930 Offset: 0x1473F30 VA: 0x181475930
	public static bool UnregisterDynamicProperty(string name, ContextBoundObject obj, Context ctx) { }

	// RVA: 0x1474E20 Offset: 0x1473420 VA: 0x181474E20
	private static DynamicPropertyCollection GetDynamicPropertyCollection(ContextBoundObject obj, Context ctx) { }

	// RVA: 0x1475400 Offset: 0x1473A00 VA: 0x181475400
	internal static void NotifyGlobalDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async) { }

	// RVA: 0x1475D90 Offset: 0x1474390 VA: 0x181475D90
	internal static bool get_HasGlobalDynamicSinks() { }

	// RVA: 0x1475370 Offset: 0x1473970 VA: 0x181475370
	internal void NotifyDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async) { }

	// RVA: 0x1475C80 Offset: 0x1474280 VA: 0x181475C80
	internal bool get_HasDynamicSinks() { }

	// RVA: 0x1475CC0 Offset: 0x14742C0 VA: 0x181475CC0
	internal bool get_HasExitSinks() { }

	// RVA: 0x1475050 Offset: 0x1473650 VA: 0x181475050 Slot: 6
	public virtual IContextProperty GetProperty(string name) { }

	// RVA: 0x1475790 Offset: 0x1473D90 VA: 0x181475790 Slot: 7
	public virtual void SetProperty(IContextProperty prop) { }

	// RVA: 0x1474AD0 Offset: 0x14730D0 VA: 0x181474AD0 Slot: 8
	public virtual void Freeze() { }

	// RVA: 0x14758D0 Offset: 0x1473ED0 VA: 0x1814758D0 Slot: 3
	public override string ToString() { }

	// RVA: 0x14751C0 Offset: 0x14737C0 VA: 0x1814751C0
	internal IMessageSink GetServerContextSinkChain() { }

	// RVA: 0x1474C50 Offset: 0x1473250 VA: 0x181474C50
	internal IMessageSink GetClientContextSinkChain() { }

	// RVA: 0x1474690 Offset: 0x1472C90 VA: 0x181474690
	internal IMessageSink CreateServerObjectSinkChain(MarshalByRefObject obj, bool forceInternalExecute) { }

	// RVA: 0x1473E70 Offset: 0x1472470 VA: 0x181473E70
	internal IMessageSink CreateEnvoySink(MarshalByRefObject serverObject) { }

	// RVA: 0x14758C0 Offset: 0x1473EC0 VA: 0x1814758C0
	internal static Context SwitchToContext(Context newContext) { }

	// RVA: 0x1474000 Offset: 0x1472600 VA: 0x181474000
	internal static Context CreateNewContext(IConstructionCallMessage msg) { }

	// RVA: 0x1474840 Offset: 0x1472E40 VA: 0x181474840
	public void DoCallBack(CrossContextDelegate deleg) { }

	// RVA: 0x1475E50 Offset: 0x1474450 VA: 0x181475E50
	private LocalDataStore get_MyLocalStore() { }

	// RVA: 0x1473D80 Offset: 0x1472380 VA: 0x181473D80
	public static LocalDataStoreSlot AllocateDataSlot() { }

	// RVA: 0x1473DF0 Offset: 0x14723F0 VA: 0x181473DF0
	public static LocalDataStoreSlot AllocateNamedDataSlot(string name) { }

	// RVA: 0x1474A50 Offset: 0x1473050 VA: 0x181474A50
	public static void FreeNamedDataSlot(string name) { }

	// RVA: 0x1474FD0 Offset: 0x14735D0 VA: 0x181474FD0
	public static LocalDataStoreSlot GetNamedDataSlot(string name) { }

	// RVA: 0x1474DE0 Offset: 0x14733E0 VA: 0x181474DE0
	public static object GetData(LocalDataStoreSlot slot) { }

	// RVA: 0x1475740 Offset: 0x1473D40 VA: 0x181475740
	public static void SetData(LocalDataStoreSlot slot, object data) { }

	// RVA: 0x1475B30 Offset: 0x1474130 VA: 0x181475B30
	private static void .cctor() { }

}

