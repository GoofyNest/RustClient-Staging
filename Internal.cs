internal struct Internal_DrawTextureArguments // TypeDefIndex: 3394
{	// Fields
	public Rect screenRect; // 0x0
	public Rect sourceRect; // 0x10
	public int leftBorder; // 0x20
	public int rightBorder; // 0x24
	public int topBorder; // 0x28
	public int bottomBorder; // 0x2C
	public Color leftBorderColor; // 0x30
	public Color rightBorderColor; // 0x40
	public Color topBorderColor; // 0x50
	public Color bottomBorderColor; // 0x60
	public Color color; // 0x70
	public Vector4 borderWidths; // 0x80
	public Vector4 cornerRadiuses; // 0x90
	public bool smoothCorners; // 0xA0
	public int pass; // 0xA4
	public Texture texture; // 0xA8
	public Material mat; // 0xB0

}

internal static class Internal_SubsystemInstances // TypeDefIndex: 3942
{	// Fields
	internal static List<ISubsystem> s_IntegratedSubsystemInstances; // 0x0
	internal static List<ISubsystem> s_StandaloneSubsystemInstances; // 0x8

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2319110 Offset: 0x2317710 VA: 0x182319110
	internal static void Internal_InitializeManagedInstance(IntPtr ptr, IntegratedSubsystem inst) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2318D00 Offset: 0x2317300 VA: 0x182318D00
	internal static void Internal_ClearManagedInstances() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x23191D0 Offset: 0x23177D0 VA: 0x1823191D0
	internal static void Internal_RemoveInstanceByPtr(IntPtr ptr) { }

	// RVA: 0x2318F30 Offset: 0x2317530 VA: 0x182318F30
	internal static IntegratedSubsystem Internal_GetInstanceByPtr(IntPtr ptr) { }

	// RVA: 0x2319470 Offset: 0x2317A70 VA: 0x182319470
	private static void .cctor() { }

}

internal static class Internal_SubsystemDescriptors // TypeDefIndex: 3943
{	// Fields
	internal static List<ISubsystemDescriptorImpl> s_IntegratedSubsystemDescriptors; // 0x0
	internal static List<ISubsystemDescriptor> s_StandaloneSubsystemDescriptors; // 0x8

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x23187A0 Offset: 0x2316DA0 VA: 0x1823187A0
	internal static bool Internal_AddDescriptor(SubsystemDescriptor descriptor) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2318BC0 Offset: 0x23171C0 VA: 0x182318BC0
	internal static void Internal_InitializeManagedDescriptor(IntPtr ptr, ISubsystemDescriptorImpl desc) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x23189D0 Offset: 0x2316FD0 VA: 0x1823189D0
	internal static void Internal_ClearManagedDescriptors() { }

	// RVA: 0x2318C60 Offset: 0x2317260 VA: 0x182318C60
	private static void .cctor() { }

}

