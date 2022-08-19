internal class PropagationPaths // TypeDefIndex: 4700
{	// Fields
	private static readonly ObjectPool<PropagationPaths> s_Pool; // 0x0
	public readonly List<VisualElement> trickleDownPath; // 0x10
	public readonly List<VisualElement> targetElements; // 0x18
	public readonly List<VisualElement> bubbleUpPath; // 0x20

	// Methods

	// RVA: 0xEB98F0 Offset: 0xEB7EF0 VA: 0x180EB98F0
	public void .ctor() { }

	// RVA: 0xEB96E0 Offset: 0xEB7CE0 VA: 0x180EB96E0
	internal static PropagationPaths Copy(PropagationPaths paths) { }

	// RVA: 0xEB9450 Offset: 0xEB7A50 VA: 0x180EB9450
	public static PropagationPaths Build(VisualElement elem, PropagationPaths.Type pathTypesRequested) { }

	// RVA: 0xEB97C0 Offset: 0xEB7DC0 VA: 0x180EB97C0
	public void Release() { }

	// RVA: 0xEB9880 Offset: 0xEB7E80 VA: 0x180EB9880
	private static void .cctor() { }

}

public enum PropagationPaths.Type // TypeDefIndex: 4701
{	// Fields
	public int value__; // 0x0
	public const PropagationPaths.Type None = 0;
	public const PropagationPaths.Type TrickleDown = 1;
	public const PropagationPaths.Type BubbleUp = 2;

}

