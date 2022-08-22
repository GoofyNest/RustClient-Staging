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

	// RVA: 0x1486AC0 Offset: 0x14850C0 VA: 0x181486AC0
	internal void .ctor(Type type, ClientIdentity identity) { }

	// RVA: 0x1486B70 Offset: 0x1485170 VA: 0x181486B70
	internal void .ctor(Type type, string activationUrl, object[] activationAttributes) { }

	// RVA: 0x14864A0 Offset: 0x1484AA0 VA: 0x1814864A0 Slot: 5
	public override IMessage Invoke(IMessage request) { }

	// RVA: 0x1485D50 Offset: 0x1484350 VA: 0x181485D50
	internal void AttachIdentity(Identity identity) { }

	// RVA: 0x1485BF0 Offset: 0x14841F0 VA: 0x181485BF0
	internal IMessage ActivateRemoteObject(IMethodMessage request) { }

	// RVA: 0x1486C00 Offset: 0x1485200 VA: 0x181486C00 Slot: 8
	public string get_TypeName() { }

	// RVA: 0x1486100 Offset: 0x1484700 VA: 0x181486100 Slot: 9
	public bool CanCastTo(Type fromType, object o) { }

	// RVA: 0x1486390 Offset: 0x1484990 VA: 0x181486390 Slot: 1
	protected override void Finalize() { }

	// RVA: 0x14869F0 Offset: 0x1484FF0 VA: 0x1814869F0
	private static void .cctor() { }

}

