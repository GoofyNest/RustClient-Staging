internal class ActivationServices // TypeDefIndex: 1202
{	// Fields
	private static IActivator _constructionActivator; // 0x13FA0

	// Properties
	private static IActivator ConstructionActivator { get; }

	// Methods

	// RVA: 0xFDB840 Offset: 0xFD9E40 VA: 0x180FDB840
	private static IActivator get_ConstructionActivator() { }

	// RVA: 0xFDA8A0 Offset: 0xFD8EA0 VA: 0x180FDA8A0
	public static IMessage Activate(RemotingProxy proxy, ConstructionCall ctorCall) { }

	// RVA: 0xFDB780 Offset: 0xFD9D80 VA: 0x180FDB780
	public static IMessage RemoteActivate(IConstructionCallMessage ctorCall) { }

	// RVA: 0xFDAA50 Offset: 0xFD9050 VA: 0x180FDAA50
	public static ConstructionCall CreateConstructionCall(Type type, string activationUrl, object[] activationAttributes) { }

	// RVA: 0xFDB230 Offset: 0xFD9830 VA: 0x180FDB230
	public static IMessage CreateInstanceFromMessage(IConstructionCallMessage ctorCall) { }

	// RVA: 0xFDB610 Offset: 0xFD9C10 VA: 0x180FDB610
	public static object CreateProxyForType(Type type) { }

	// RVA: 0xFDAA40 Offset: 0xFD9040 VA: 0x180FDAA40
	public static object AllocateUninitializedClassInstance(Type type) { }

	// RVA: 0xFDB770 Offset: 0xFD9D70 VA: 0x180FDB770
	public static void EnableProxyActivation(Type type, bool enable) { }

}

