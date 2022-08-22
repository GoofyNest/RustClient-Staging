public class ChromaAnimationAPI // TypeDefIndex: 7675
{	// Fields
	private const string DLL_NAME = "CChromaEditorLibrary64";

	// Methods

	// RVA: 0x21BECF0 Offset: 0x21BD2F0 VA: 0x1821BECF0
	public static int CoreCreateChromaLinkEffect(ChromaLink.EFFECT_TYPE effect, void* pParam, out Guid pEffectId) { }

	// RVA: 0x21BED90 Offset: 0x21BD390 VA: 0x1821BED90
	public static int CoreCreateHeadsetEffect(Headset.EFFECT_TYPE effect, void* pParam, out Guid pEffectId) { }

	// RVA: 0x21BEE30 Offset: 0x21BD430 VA: 0x1821BEE30
	public static int CoreCreateKeyboardEffect(Keyboard.EFFECT_TYPE effect, void* pParam, out Guid pEffectId) { }

	// RVA: 0x21BEED0 Offset: 0x21BD4D0 VA: 0x1821BEED0
	public static int CoreCreateKeypadEffect(Keypad.EFFECT_TYPE effect, void* pParam, out Guid pEffectId) { }

	// RVA: 0x21BEF70 Offset: 0x21BD570 VA: 0x1821BEF70
	public static int CoreCreateMouseEffect(Mouse.EFFECT_TYPE effect, void* pParam, out Guid pEffectId) { }

	// RVA: 0x21BF010 Offset: 0x21BD610 VA: 0x1821BF010
	public static int CoreCreateMousepadEffect(Mousepad.EFFECT_TYPE effect, void* pParam, out Guid pEffectId) { }

	// RVA: 0x21BF0B0 Offset: 0x21BD6B0 VA: 0x1821BF0B0
	public static int CoreDeleteEffect(Guid effectId) { }

	// RVA: 0x21BF320 Offset: 0x21BD920 VA: 0x1821BF320
	public static int CoreInit() { }

	// RVA: 0x21BF140 Offset: 0x21BD740 VA: 0x1821BF140
	public static int CoreInitSDK(ref APPINFOTYPE appInfo) { }

	// RVA: 0x21BF390 Offset: 0x21BD990 VA: 0x1821BF390
	public static int CoreQueryDevice(Guid deviceId, out DEVICE_INFO_TYPE deviceInfo) { }

	// RVA: 0x21BF430 Offset: 0x21BDA30 VA: 0x1821BF430
	public static int CoreSetEffect(Guid effectId) { }

	// RVA: 0x21BF4C0 Offset: 0x21BDAC0 VA: 0x1821BF4C0
	public static int CoreUnInit() { }

	// RVA: 0x21BECF0 Offset: 0x21BD2F0 VA: 0x1821BECF0
	private static extern int PluginCoreCreateChromaLinkEffect(ChromaLink.EFFECT_TYPE effect, void* pParam, out Guid pEffectId) { }

	// RVA: 0x21BED90 Offset: 0x21BD390 VA: 0x1821BED90
	private static extern int PluginCoreCreateHeadsetEffect(Headset.EFFECT_TYPE effect, void* pParam, out Guid pEffectId) { }

	// RVA: 0x21BEE30 Offset: 0x21BD430 VA: 0x1821BEE30
	private static extern int PluginCoreCreateKeyboardEffect(Keyboard.EFFECT_TYPE effect, void* pParam, out Guid pEffectId) { }

	// RVA: 0x21BEED0 Offset: 0x21BD4D0 VA: 0x1821BEED0
	private static extern int PluginCoreCreateKeypadEffect(Keypad.EFFECT_TYPE effect, void* pParam, out Guid pEffectId) { }

	// RVA: 0x21BEF70 Offset: 0x21BD570 VA: 0x1821BEF70
	private static extern int PluginCoreCreateMouseEffect(Mouse.EFFECT_TYPE effect, void* pParam, out Guid pEffectId) { }

	// RVA: 0x21BF010 Offset: 0x21BD610 VA: 0x1821BF010
	private static extern int PluginCoreCreateMousepadEffect(Mousepad.EFFECT_TYPE effect, void* pParam, out Guid pEffectId) { }

	// RVA: 0x21BF0B0 Offset: 0x21BD6B0 VA: 0x1821BF0B0
	private static extern int PluginCoreDeleteEffect(Guid effectId) { }

	// RVA: 0x21BF320 Offset: 0x21BD920 VA: 0x1821BF320
	private static extern int PluginCoreInit() { }

	// RVA: 0x21BF140 Offset: 0x21BD740 VA: 0x1821BF140
	private static extern int PluginCoreInitSDK(ref APPINFOTYPE appInfo) { }

	// RVA: 0x21BF390 Offset: 0x21BD990 VA: 0x1821BF390
	private static extern int PluginCoreQueryDevice(Guid deviceId, out DEVICE_INFO_TYPE deviceInfo) { }

	// RVA: 0x21BF430 Offset: 0x21BDA30 VA: 0x1821BF430
	private static extern int PluginCoreSetEffect(Guid effectId) { }

	// RVA: 0x21BF4C0 Offset: 0x21BDAC0 VA: 0x1821BF4C0
	private static extern int PluginCoreUnInit() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

