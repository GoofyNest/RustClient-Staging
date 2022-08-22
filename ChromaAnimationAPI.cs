public class ChromaAnimationAPI // TypeDefIndex: 7675
{	// Fields
	private const string DLL_NAME = "CChromaEditorLibrary64";

	// Methods

	// RVA: 0x21BE4D0 Offset: 0x21BCAD0 VA: 0x1821BE4D0
	public static int CoreCreateChromaLinkEffect(ChromaLink.EFFECT_TYPE effect, void* pParam, out Guid pEffectId) { }

	// RVA: 0x21BE570 Offset: 0x21BCB70 VA: 0x1821BE570
	public static int CoreCreateHeadsetEffect(Headset.EFFECT_TYPE effect, void* pParam, out Guid pEffectId) { }

	// RVA: 0x21BE610 Offset: 0x21BCC10 VA: 0x1821BE610
	public static int CoreCreateKeyboardEffect(Keyboard.EFFECT_TYPE effect, void* pParam, out Guid pEffectId) { }

	// RVA: 0x21BE6B0 Offset: 0x21BCCB0 VA: 0x1821BE6B0
	public static int CoreCreateKeypadEffect(Keypad.EFFECT_TYPE effect, void* pParam, out Guid pEffectId) { }

	// RVA: 0x21BE750 Offset: 0x21BCD50 VA: 0x1821BE750
	public static int CoreCreateMouseEffect(Mouse.EFFECT_TYPE effect, void* pParam, out Guid pEffectId) { }

	// RVA: 0x21BE7F0 Offset: 0x21BCDF0 VA: 0x1821BE7F0
	public static int CoreCreateMousepadEffect(Mousepad.EFFECT_TYPE effect, void* pParam, out Guid pEffectId) { }

	// RVA: 0x21BE890 Offset: 0x21BCE90 VA: 0x1821BE890
	public static int CoreDeleteEffect(Guid effectId) { }

	// RVA: 0x21BEB00 Offset: 0x21BD100 VA: 0x1821BEB00
	public static int CoreInit() { }

	// RVA: 0x21BE920 Offset: 0x21BCF20 VA: 0x1821BE920
	public static int CoreInitSDK(ref APPINFOTYPE appInfo) { }

	// RVA: 0x21BEB70 Offset: 0x21BD170 VA: 0x1821BEB70
	public static int CoreQueryDevice(Guid deviceId, out DEVICE_INFO_TYPE deviceInfo) { }

	// RVA: 0x21BEC10 Offset: 0x21BD210 VA: 0x1821BEC10
	public static int CoreSetEffect(Guid effectId) { }

	// RVA: 0x21BECA0 Offset: 0x21BD2A0 VA: 0x1821BECA0
	public static int CoreUnInit() { }

	// RVA: 0x21BE4D0 Offset: 0x21BCAD0 VA: 0x1821BE4D0
	private static extern int PluginCoreCreateChromaLinkEffect(ChromaLink.EFFECT_TYPE effect, void* pParam, out Guid pEffectId) { }

	// RVA: 0x21BE570 Offset: 0x21BCB70 VA: 0x1821BE570
	private static extern int PluginCoreCreateHeadsetEffect(Headset.EFFECT_TYPE effect, void* pParam, out Guid pEffectId) { }

	// RVA: 0x21BE610 Offset: 0x21BCC10 VA: 0x1821BE610
	private static extern int PluginCoreCreateKeyboardEffect(Keyboard.EFFECT_TYPE effect, void* pParam, out Guid pEffectId) { }

	// RVA: 0x21BE6B0 Offset: 0x21BCCB0 VA: 0x1821BE6B0
	private static extern int PluginCoreCreateKeypadEffect(Keypad.EFFECT_TYPE effect, void* pParam, out Guid pEffectId) { }

	// RVA: 0x21BE750 Offset: 0x21BCD50 VA: 0x1821BE750
	private static extern int PluginCoreCreateMouseEffect(Mouse.EFFECT_TYPE effect, void* pParam, out Guid pEffectId) { }

	// RVA: 0x21BE7F0 Offset: 0x21BCDF0 VA: 0x1821BE7F0
	private static extern int PluginCoreCreateMousepadEffect(Mousepad.EFFECT_TYPE effect, void* pParam, out Guid pEffectId) { }

	// RVA: 0x21BE890 Offset: 0x21BCE90 VA: 0x1821BE890
	private static extern int PluginCoreDeleteEffect(Guid effectId) { }

	// RVA: 0x21BEB00 Offset: 0x21BD100 VA: 0x1821BEB00
	private static extern int PluginCoreInit() { }

	// RVA: 0x21BE920 Offset: 0x21BCF20 VA: 0x1821BE920
	private static extern int PluginCoreInitSDK(ref APPINFOTYPE appInfo) { }

	// RVA: 0x21BEB70 Offset: 0x21BD170 VA: 0x1821BEB70
	private static extern int PluginCoreQueryDevice(Guid deviceId, out DEVICE_INFO_TYPE deviceInfo) { }

	// RVA: 0x21BEC10 Offset: 0x21BD210 VA: 0x1821BEC10
	private static extern int PluginCoreSetEffect(Guid effectId) { }

	// RVA: 0x21BECA0 Offset: 0x21BD2A0 VA: 0x1821BECA0
	private static extern int PluginCoreUnInit() { }

	// RVA: 0x2FC0E0 Offset: 0x2FA6E0 VA: 0x1802FC0E0
	public void .ctor() { }

}

