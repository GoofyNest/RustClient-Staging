internal class RemotingProxy : RealProxy, IRemotingTypeInfo // TypeDefIndex: 1162
{	// Fields
	private static MethodInfo _cache_GetTypeMethod; // 0x0
	private static MethodInfo _cache_GetHashCodeMethod; // 0x8
	private IMessageSink _sink; // 0x50
	private bool _hasEnvoySink; // 0x58
	private ConstructionCall _ctorCall; // 0x60

	// Properties
	public string TypeName { get; }

	// Methods

	// RVA: 0x14879F0 Offset: 0x1485FF0 VA: 0x1814879F0
	internal void .ctor(Type type, ClientIdentity identity) { }

	// RVA: 0x1487AA0 Offset: 0x14860A0 VA: 0x181487AA0
	internal void .ctor(Type type, string activationUrl, object[] activationAttributes) { }

	// RVA: 0x14873D0 Offset: 0x14859D0 VA: 0x1814873D0 Slot: 5
	public override IMessage Invoke(IMessage request) { }

	// RVA: 0x1486C80 Offset: 0x1485280 VA: 0x181486C80
	internal void AttachIdentity(Identity identity) { }

	// RVA: 0x1486B20 Offset: 0x1485120 VA: 0x181486B20
	internal IMessage ActivateRemoteObject(IMethodMessage request) { }

	// RVA: 0x1487B30 Offset: 0x1486130 VA: 0x181487B30 Slot: 8
	public string get_TypeName() { }

	// RVA: 0x1487030 Offset: 0x1485630 VA: 0x181487030 Slot: 9
	public bool CanCastTo(Type fromType, object o) { }

	// RVA: 0x14872C0 Offset: 0x14858C0 VA: 0x1814872C0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1487920 Offset: 0x1485F20 VA: 0x181487920
	private static void .cctor() { }

}

