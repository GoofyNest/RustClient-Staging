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

	// RVA: 0x78B750 Offset: 0x789D50 VA: 0x18078B750
	public static void Apply(Camera cam, BaseEntity target) { }

	// RVA: 0x78C9C0 Offset: 0x78AFC0 VA: 0x18078C9C0
	public static void OnFirstPersonSpectateEnds() { }

	// RVA: 0x78CD10 Offset: 0x78B310 VA: 0x18078CD10
	public static void OnPlayerSignal(BaseEntity.Signal signal, string arg, BasePlayer fromPlayer) { }

	// RVA: 0x78CBA0 Offset: 0x78B1A0 VA: 0x18078CBA0
	public static void OnHeldNetworkUpdate(HeldEntity entity) { }

	// RVA: 0x363E40 Offset: 0x362440 VA: 0x180363E40
	private static void .cctor() { }

}

