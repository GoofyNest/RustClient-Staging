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
	// RVA: 0x2319BF0 Offset: 0x23181F0 VA: 0x182319BF0
	internal static void Internal_InitializeManagedInstance(IntPtr ptr, IntegratedSubsystem inst) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x23197E0 Offset: 0x2317DE0 VA: 0x1823197E0
	internal static void Internal_ClearManagedInstances() { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2319CB0 Offset: 0x23182B0 VA: 0x182319CB0
	internal static void Internal_RemoveInstanceByPtr(IntPtr ptr) { }

	// RVA: 0x2319A10 Offset: 0x2318010 VA: 0x182319A10
	internal static IntegratedSubsystem Internal_GetInstanceByPtr(IntPtr ptr) { }

	// RVA: 0x2319F50 Offset: 0x2318550 VA: 0x182319F50
	private static void .cctor() { }

}

internal static class Internal_SubsystemDescriptors // TypeDefIndex: 3943
{	// Fields
	internal static List<ISubsystemDescriptorImpl> s_IntegratedSubsystemDescriptors; // 0x0
	internal static List<ISubsystemDescriptor> s_StandaloneSubsystemDescriptors; // 0x8

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x2319280 Offset: 0x2317880 VA: 0x182319280
	internal static bool Internal_AddDescriptor(SubsystemDescriptor descriptor) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x23196A0 Offset: 0x2317CA0 VA: 0x1823196A0
	internal static void Internal_InitializeManagedDescriptor(IntPtr ptr, ISubsystemDescriptorImpl desc) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F3D0 Offset: 0x6E7D0 VA: 0x18006F3D0
	// RVA: 0x23194B0 Offset: 0x2317AB0 VA: 0x1823194B0
	internal static void Internal_ClearManagedDescriptors() { }

	// RVA: 0x2319740 Offset: 0x2317D40 VA: 0x182319740
	private static void .cctor() { }

}

