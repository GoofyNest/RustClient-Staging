public class ChromaAnimationAPI // TypeDefIndex: 7675
{	// Fields
	private const string DLL_NAME = "CChromaEditorLibrary64";

	// Methods

	// RVA: 0x21BE3D0 Offset: 0x21BC9D0 VA: 0x1821BE3D0
	public static int CoreCreateChromaLinkEffect(ChromaLink.EFFECT_TYPE effect, void* pParam, out Guid pEffectId) { }

	// RVA: 0x21BE470 Offset: 0x21BCA70 VA: 0x1821BE470
	public static int CoreCreateHeadsetEffect(Headset.EFFECT_TYPE effect, void* pParam, out Guid pEffectId) { }

	// RVA: 0x21BE510 Offset: 0x21BCB10 VA: 0x1821BE510
	public static int CoreCreateKeyboardEffect(Keyboard.EFFECT_TYPE effect, void* pParam, out Guid pEffectId) { }

	// RVA: 0x21BE5B0 Offset: 0x21BCBB0 VA: 0x1821BE5B0
	public static int CoreCreateKeypadEffect(Keypad.EFFECT_TYPE effect, void* pParam, out Guid pEffectId) { }

	// RVA: 0x21BE650 Offset: 0x21BCC50 VA: 0x1821BE650
	public static int CoreCreateMouseEffect(Mouse.EFFECT_TYPE effect, void* pParam, out Guid pEffectId) { }

	// RVA: 0x21BE6F0 Offset: 0x21BCCF0 VA: 0x1821BE6F0
	public static int CoreCreateMousepadEffect(Mousepad.EFFECT_TYPE effect, void* pParam, out Guid pEffectId) { }

	// RVA: 0x21BE790 Offset: 0x21BCD90 VA: 0x1821BE790
	public static int CoreDeleteEffect(Guid effectId) { }

	// RVA: 0x21BEA00 Offset: 0x21BD000 VA: 0x1821BEA00
	public static int CoreInit() { }

	// RVA: 0x21BE820 Offset: 0x21BCE20 VA: 0x1821BE820
	public static int CoreInitSDK(ref APPINFOTYPE appInfo) { }

	// RVA: 0x21BEA70 Offset: 0x21BD070 VA: 0x1821BEA70
	public static int CoreQueryDevice(Guid deviceId, out DEVICE_INFO_TYPE deviceInfo) { }

	// RVA: 0x21BEB10 Offset: 0x21BD110 VA: 0x1821BEB10
	public static int CoreSetEffect(Guid effectId) { }

	// RVA: 0x21BEBA0 Offset: 0x21BD1A0 VA: 0x1821BEBA0
	public static int CoreUnInit() { }

	// RVA: 0x21BE3D0 Offset: 0x21BC9D0 VA: 0x1821BE3D0
	private static extern int PluginCoreCreateChromaLinkEffect(ChromaLink.EFFECT_TYPE effect, void* pParam, out Guid pEffectId) { }

	// RVA: 0x21BE470 Offset: 0x21BCA70 VA: 0x1821BE470
	private static extern int PluginCoreCreateHeadsetEffect(Headset.EFFECT_TYPE effect, void* pParam, out Guid pEffectId) { }

	// RVA: 0x21BE510 Offset: 0x21BCB10 VA: 0x1821BE510
	private static extern int PluginCoreCreateKeyboardEffect(Keyboard.EFFECT_TYPE effect, void* pParam, out Guid pEffectId) { }

	// RVA: 0x21BE5B0 Offset: 0x21BCBB0 VA: 0x1821BE5B0
	private static extern int PluginCoreCreateKeypadEffect(Keypad.EFFECT_TYPE effect, void* pParam, out Guid pEffectId) { }

	// RVA: 0x21BE650 Offset: 0x21BCC50 VA: 0x1821BE650
	private static extern int PluginCoreCreateMouseEffect(Mouse.EFFECT_TYPE effect, void* pParam, out Guid pEffectId) { }

	// RVA: 0x21BE6F0 Offset: 0x21BCCF0 VA: 0x1821BE6F0
	private static extern int PluginCoreCreateMousepadEffect(Mousepad.EFFECT_TYPE effect, void* pParam, out Guid pEffectId) { }

	// RVA: 0x21BE790 Offset: 0x21BCD90 VA: 0x1821BE790
	private static extern int PluginCoreDeleteEffect(Guid effectId) { }

	// RVA: 0x21BEA00 Offset: 0x21BD000 VA: 0x1821BEA00
	private static extern int PluginCoreInit() { }

	// RVA: 0x21BE820 Offset: 0x21BCE20 VA: 0x1821BE820
	private static extern int PluginCoreInitSDK(ref APPINFOTYPE appInfo) { }

	// RVA: 0x21BEA70 Offset: 0x21BD070 VA: 0x1821BEA70
	private static extern int PluginCoreQueryDevice(Guid deviceId, out DEVICE_INFO_TYPE deviceInfo) { }

	// RVA: 0x21BEB10 Offset: 0x21BD110 VA: 0x1821BEB10
	private static extern int PluginCoreSetEffect(Guid effectId) { }

	// RVA: 0x21BEBA0 Offset: 0x21BD1A0 VA: 0x1821BEBA0
	private static extern int PluginCoreUnInit() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

