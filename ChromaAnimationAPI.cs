public class ChromaAnimationAPI // TypeDefIndex: 7675
{	// Fields
	private const string DLL_NAME = "CChromaEditorLibrary64";

	// Methods

	// RVA: 0x21BE210 Offset: 0x21BC810 VA: 0x1821BE210
	public static int CoreCreateChromaLinkEffect(ChromaLink.EFFECT_TYPE effect, void* pParam, out Guid pEffectId) { }

	// RVA: 0x21BE2B0 Offset: 0x21BC8B0 VA: 0x1821BE2B0
	public static int CoreCreateHeadsetEffect(Headset.EFFECT_TYPE effect, void* pParam, out Guid pEffectId) { }

	// RVA: 0x21BE350 Offset: 0x21BC950 VA: 0x1821BE350
	public static int CoreCreateKeyboardEffect(Keyboard.EFFECT_TYPE effect, void* pParam, out Guid pEffectId) { }

	// RVA: 0x21BE3F0 Offset: 0x21BC9F0 VA: 0x1821BE3F0
	public static int CoreCreateKeypadEffect(Keypad.EFFECT_TYPE effect, void* pParam, out Guid pEffectId) { }

	// RVA: 0x21BE490 Offset: 0x21BCA90 VA: 0x1821BE490
	public static int CoreCreateMouseEffect(Mouse.EFFECT_TYPE effect, void* pParam, out Guid pEffectId) { }

	// RVA: 0x21BE530 Offset: 0x21BCB30 VA: 0x1821BE530
	public static int CoreCreateMousepadEffect(Mousepad.EFFECT_TYPE effect, void* pParam, out Guid pEffectId) { }

	// RVA: 0x21BE5D0 Offset: 0x21BCBD0 VA: 0x1821BE5D0
	public static int CoreDeleteEffect(Guid effectId) { }

	// RVA: 0x21BE840 Offset: 0x21BCE40 VA: 0x1821BE840
	public static int CoreInit() { }

	// RVA: 0x21BE660 Offset: 0x21BCC60 VA: 0x1821BE660
	public static int CoreInitSDK(ref APPINFOTYPE appInfo) { }

	// RVA: 0x21BE8B0 Offset: 0x21BCEB0 VA: 0x1821BE8B0
	public static int CoreQueryDevice(Guid deviceId, out DEVICE_INFO_TYPE deviceInfo) { }

	// RVA: 0x21BE950 Offset: 0x21BCF50 VA: 0x1821BE950
	public static int CoreSetEffect(Guid effectId) { }

	// RVA: 0x21BE9E0 Offset: 0x21BCFE0 VA: 0x1821BE9E0
	public static int CoreUnInit() { }

	// RVA: 0x21BE210 Offset: 0x21BC810 VA: 0x1821BE210
	private static extern int PluginCoreCreateChromaLinkEffect(ChromaLink.EFFECT_TYPE effect, void* pParam, out Guid pEffectId) { }

	// RVA: 0x21BE2B0 Offset: 0x21BC8B0 VA: 0x1821BE2B0
	private static extern int PluginCoreCreateHeadsetEffect(Headset.EFFECT_TYPE effect, void* pParam, out Guid pEffectId) { }

	// RVA: 0x21BE350 Offset: 0x21BC950 VA: 0x1821BE350
	private static extern int PluginCoreCreateKeyboardEffect(Keyboard.EFFECT_TYPE effect, void* pParam, out Guid pEffectId) { }

	// RVA: 0x21BE3F0 Offset: 0x21BC9F0 VA: 0x1821BE3F0
	private static extern int PluginCoreCreateKeypadEffect(Keypad.EFFECT_TYPE effect, void* pParam, out Guid pEffectId) { }

	// RVA: 0x21BE490 Offset: 0x21BCA90 VA: 0x1821BE490
	private static extern int PluginCoreCreateMouseEffect(Mouse.EFFECT_TYPE effect, void* pParam, out Guid pEffectId) { }

	// RVA: 0x21BE530 Offset: 0x21BCB30 VA: 0x1821BE530
	private static extern int PluginCoreCreateMousepadEffect(Mousepad.EFFECT_TYPE effect, void* pParam, out Guid pEffectId) { }

	// RVA: 0x21BE5D0 Offset: 0x21BCBD0 VA: 0x1821BE5D0
	private static extern int PluginCoreDeleteEffect(Guid effectId) { }

	// RVA: 0x21BE840 Offset: 0x21BCE40 VA: 0x1821BE840
	private static extern int PluginCoreInit() { }

	// RVA: 0x21BE660 Offset: 0x21BCC60 VA: 0x1821BE660
	private static extern int PluginCoreInitSDK(ref APPINFOTYPE appInfo) { }

	// RVA: 0x21BE8B0 Offset: 0x21BCEB0 VA: 0x1821BE8B0
	private static extern int PluginCoreQueryDevice(Guid deviceId, out DEVICE_INFO_TYPE deviceInfo) { }

	// RVA: 0x21BE950 Offset: 0x21BCF50 VA: 0x1821BE950
	private static extern int PluginCoreSetEffect(Guid effectId) { }

	// RVA: 0x21BE9E0 Offset: 0x21BCFE0 VA: 0x1821BE9E0
	private static extern int PluginCoreUnInit() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

