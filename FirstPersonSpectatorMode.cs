public static class FirstPersonSpectatorMode // TypeDefIndex: 9189
{	// Fields
	private static ViewModel createdViewmodel; // 0x0
	private static BaseViewModel createdViewmodelInstance; // 0x8
	private static BasePlayer lastPlayer; // 0x10
	private static Vector3 smoothLookDir; // 0x18
	private static bool wasParented; // 0x24
	private static Item lastHeldItem; // 0x28
	private static TimeUntil reloadEnds; // 0x30

	// Methods

	// RVA: 0x78B860 Offset: 0x789E60 VA: 0x18078B860
	public static void Apply(Camera cam, BaseEntity target) { }

	// RVA: 0x78CAD0 Offset: 0x78B0D0 VA: 0x18078CAD0
	public static void OnFirstPersonSpectateEnds() { }

	// RVA: 0x78CE20 Offset: 0x78B420 VA: 0x18078CE20
	public static void OnPlayerSignal(BaseEntity.Signal signal, string arg, BasePlayer fromPlayer) { }

	// RVA: 0x78CCB0 Offset: 0x78B2B0 VA: 0x18078CCB0
	public static void OnHeldNetworkUpdate(HeldEntity entity) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void .cctor() { }

}

