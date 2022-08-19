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

	// RVA: 0x1487730 Offset: 0x1485D30 VA: 0x181487730
	internal void .ctor(Type type, ClientIdentity identity) { }

	// RVA: 0x14877E0 Offset: 0x1485DE0 VA: 0x1814877E0
	internal void .ctor(Type type, string activationUrl, object[] activationAttributes) { }

	// RVA: 0x1487110 Offset: 0x1485710 VA: 0x181487110 Slot: 5
	public override IMessage Invoke(IMessage request) { }

	// RVA: 0x14869C0 Offset: 0x1484FC0 VA: 0x1814869C0
	internal void AttachIdentity(Identity identity) { }

	// RVA: 0x1486860 Offset: 0x1484E60 VA: 0x181486860
	internal IMessage ActivateRemoteObject(IMethodMessage request) { }

	// RVA: 0x1487870 Offset: 0x1485E70 VA: 0x181487870 Slot: 8
	public string get_TypeName() { }

	// RVA: 0x1486D70 Offset: 0x1485370 VA: 0x181486D70 Slot: 9
	public bool CanCastTo(Type fromType, object o) { }

	// RVA: 0x1487000 Offset: 0x1485600 VA: 0x181487000 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x1487660 Offset: 0x1485C60 VA: 0x181487660
	private static void .cctor() { }

}

