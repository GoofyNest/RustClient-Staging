internal class PropagationPaths // TypeDefIndex: 4700
{	// Fields
	private static readonly ObjectPool<PropagationPaths> s_Pool; // 0x0
	public readonly List<VisualElement> trickleDownPath; // 0x10
	public readonly List<VisualElement> targetElements; // 0x18
	public readonly List<VisualElement> bubbleUpPath; // 0x20

	// Methods

	// RVA: 0xEB9BB0 Offset: 0xEB81B0 VA: 0x180EB9BB0
	public void .ctor() { }

	// RVA: 0xEB99A0 Offset: 0xEB7FA0 VA: 0x180EB99A0
	internal static PropagationPaths Copy(PropagationPaths paths) { }

	// RVA: 0xEB9710 Offset: 0xEB7D10 VA: 0x180EB9710
	public static PropagationPaths Build(VisualElement elem, PropagationPaths.Type pathTypesRequested) { }

	// RVA: 0xEB9A80 Offset: 0xEB8080 VA: 0x180EB9A80
	public void Release() { }

	// RVA: 0xEB9B40 Offset: 0xEB8140 VA: 0x180EB9B40
	private static void .cctor() { }

}

public enum PropagationPaths.Type // TypeDefIndex: 4701
{	// Fields
	public int value__; // 0x0
	public const PropagationPaths.Type None = 0;
	public const PropagationPaths.Type TrickleDown = 1;
	public const PropagationPaths.Type BubbleUp = 2;

}

