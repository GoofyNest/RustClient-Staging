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

	// RVA: 0xD73BA0 Offset: 0xD721A0 VA: 0x180D73BA0
	private static void RegisterContext(Context ctx) { }

	// RVA: 0xD73BA0 Offset: 0xD721A0 VA: 0x180D73BA0
	private static void ReleaseContext(Context ctx) { }

	// RVA: 0x1474F20 Offset: 0x1473520 VA: 0x181474F20
	public void .ctor() { }

	// RVA: 0x1473D10 Offset: 0x1472310 VA: 0x181473D10 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1475000 Offset: 0x1473600 VA: 0x181475000
	public static Context get_DefaultContext() { }

	// RVA: 0x57C960 Offset: 0x57AF60 VA: 0x18057C960 Slot: 4
	public virtual int get_ContextID() { }

	// RVA: 0x1474FA0 Offset: 0x14735A0 VA: 0x181474FA0 Slot: 5
	public virtual IContextProperty[] get_ContextProperties() { }

	// RVA: 0x14751D0 Offset: 0x14737D0 VA: 0x1814751D0
	internal bool get_IsDefaultContext() { }

	// RVA: 0x1475380 Offset: 0x1473980 VA: 0x181475380
	internal bool get_NeedsContextSink() { }

	// RVA: 0x14748D0 Offset: 0x1472ED0 VA: 0x1814748D0
	public static bool RegisterDynamicProperty(IDynamicProperty prop, ContextBoundObject obj, Context ctx) { }

	// RVA: 0x1474CC0 Offset: 0x14732C0 VA: 0x181474CC0
	public static bool UnregisterDynamicProperty(string name, ContextBoundObject obj, Context ctx) { }

	// RVA: 0x14741B0 Offset: 0x14727B0 VA: 0x1814741B0
	private static DynamicPropertyCollection GetDynamicPropertyCollection(ContextBoundObject obj, Context ctx) { }

	// RVA: 0x1474790 Offset: 0x1472D90 VA: 0x181474790
	internal static void NotifyGlobalDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async) { }

	// RVA: 0x1475120 Offset: 0x1473720 VA: 0x181475120
	internal static bool get_HasGlobalDynamicSinks() { }

	// RVA: 0x1474700 Offset: 0x1472D00 VA: 0x181474700
	internal void NotifyDynamicSinks(bool start, IMessage req_msg, bool client_site, bool async) { }

	// RVA: 0x1475010 Offset: 0x1473610 VA: 0x181475010
	internal bool get_HasDynamicSinks() { }

	// RVA: 0x1475050 Offset: 0x1473650 VA: 0x181475050
	internal bool get_HasExitSinks() { }

	// RVA: 0x14743E0 Offset: 0x14729E0 VA: 0x1814743E0 Slot: 6
	public virtual IContextProperty GetProperty(string name) { }

	// RVA: 0x1474B20 Offset: 0x1473120 VA: 0x181474B20 Slot: 7
	public virtual void SetProperty(IContextProperty prop) { }

	// RVA: 0x1473E60 Offset: 0x1472460 VA: 0x181473E60 Slot: 8
	public virtual void Freeze() { }

	// RVA: 0x1474C60 Offset: 0x1473260 VA: 0x181474C60 Slot: 3
	public override string ToString() { }

	// RVA: 0x1474550 Offset: 0x1472B50 VA: 0x181474550
	internal IMessageSink GetServerContextSinkChain() { }

	// RVA: 0x1473FE0 Offset: 0x14725E0 VA: 0x181473FE0
	internal IMessageSink GetClientContextSinkChain() { }

	// RVA: 0x1473A20 Offset: 0x1472020 VA: 0x181473A20
	internal IMessageSink CreateServerObjectSinkChain(MarshalByRefObject obj, bool forceInternalExecute) { }

	// RVA: 0x1473200 Offset: 0x1471800 VA: 0x181473200
	internal IMessageSink CreateEnvoySink(MarshalByRefObject serverObject) { }

	// RVA: 0x1474C50 Offset: 0x1473250 VA: 0x181474C50
	internal static Context SwitchToContext(Context newContext) { }

	// RVA: 0x1473390 Offset: 0x1471990 VA: 0x181473390
	internal static Context CreateNewContext(IConstructionCallMessage msg) { }

	// RVA: 0x1473BD0 Offset: 0x14721D0 VA: 0x181473BD0
	public void DoCallBack(CrossContextDelegate deleg) { }

	// RVA: 0x14751E0 Offset: 0x14737E0 VA: 0x1814751E0
	private LocalDataStore get_MyLocalStore() { }

	// RVA: 0x1473110 Offset: 0x1471710 VA: 0x181473110
	public static LocalDataStoreSlot AllocateDataSlot() { }

	// RVA: 0x1473180 Offset: 0x1471780 VA: 0x181473180
	public static LocalDataStoreSlot AllocateNamedDataSlot(string name) { }

	// RVA: 0x1473DE0 Offset: 0x14723E0 VA: 0x181473DE0
	public static void FreeNamedDataSlot(string name) { }

	// RVA: 0x1474360 Offset: 0x1472960 VA: 0x181474360
	public static LocalDataStoreSlot GetNamedDataSlot(string name) { }

	// RVA: 0x1474170 Offset: 0x1472770 VA: 0x181474170
	public static object GetData(LocalDataStoreSlot slot) { }

	// RVA: 0x1474AD0 Offset: 0x14730D0 VA: 0x181474AD0
	public static void SetData(LocalDataStoreSlot slot, object data) { }

	// RVA: 0x1474EC0 Offset: 0x14734C0 VA: 0x181474EC0
	private static void .cctor() { }

}

