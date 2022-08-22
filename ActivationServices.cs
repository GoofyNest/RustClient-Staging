internal class ActivationServices // TypeDefIndex: 1202
{	// Fields
	private static IActivator _constructionActivator; // 0x2B10440

	// Properties
	private static IActivator ConstructionActivator { get; }

	// Methods

	// RVA: 0xFDC2E0 Offset: 0xFDA8E0 VA: 0x180FDC2E0
	private static IActivator get_ConstructionActivator() { }

	// RVA: 0xFDB340 Offset: 0xFD9940 VA: 0x180FDB340
	public static IMessage Activate(RemotingProxy proxy, ConstructionCall ctorCall) { }

	// RVA: 0xFDC220 Offset: 0xFDA820 VA: 0x180FDC220
	public static IMessage RemoteActivate(IConstructionCallMessage ctorCall) { }

	// RVA: 0xFDB4F0 Offset: 0xFD9AF0 VA: 0x180FDB4F0
	public static ConstructionCall CreateConstructionCall(Type type, string activationUrl, object[] activationAttributes) { }

	// RVA: 0xFDBCD0 Offset: 0xFDA2D0 VA: 0x180FDBCD0
	public static IMessage CreateInstanceFromMessage(IConstructionCallMessage ctorCall) { }

	// RVA: 0xFDC0B0 Offset: 0xFDA6B0 VA: 0x180FDC0B0
	public static object CreateProxyForType(Type type) { }

	// RVA: 0xFDB4E0 Offset: 0xFD9AE0 VA: 0x180FDB4E0
	public static object AllocateUninitializedClassInstance(Type type) { }

	// RVA: 0xFDC210 Offset: 0xFDA810 VA: 0x180FDC210
	public static void EnableProxyActivation(Type type, bool enable) { }

}

