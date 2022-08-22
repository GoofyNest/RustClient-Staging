internal class PropagationPaths // TypeDefIndex: 4700
{	// Fields
	private static readonly ObjectPool<PropagationPaths> s_Pool; // 0x0
	public readonly List<VisualElement> trickleDownPath; // 0x10
	public readonly List<VisualElement> targetElements; // 0x18
	public readonly List<VisualElement> bubbleUpPath; // 0x20

	// Methods

	// RVA: 0xEBA660 Offset: 0xEB8C60 VA: 0x180EBA660
	public void .ctor() { }

	// RVA: 0xEBA450 Offset: 0xEB8A50 VA: 0x180EBA450
	internal static PropagationPaths Copy(PropagationPaths paths) { }

	// RVA: 0xEBA1C0 Offset: 0xEB87C0 VA: 0x180EBA1C0
	public static PropagationPaths Build(VisualElement elem, PropagationPaths.Type pathTypesRequested) { }

	// RVA: 0xEBA530 Offset: 0xEB8B30 VA: 0x180EBA530
	public void Release() { }

	// RVA: 0xEBA5F0 Offset: 0xEB8BF0 VA: 0x180EBA5F0
	private static void .cctor() { }

}

public enum PropagationPaths.Type // TypeDefIndex: 4701
{	// Fields
	public int value__; // 0x0
	public const PropagationPaths.Type None = 0;
	public const PropagationPaths.Type TrickleDown = 1;
	public const PropagationPaths.Type BubbleUp = 2;

}

